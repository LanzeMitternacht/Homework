use std::error::Error;
use std::{fs};

pub fn run(config: Config) -> Result<(), Box<dyn Error>> {
    let content = fs::read_to_string(config.file_path)?;

    let lines = if config.max_line{
        max_query(&config.line_max, &content)
    } else if config.case_ignore {
        search_case_insensitive(&config.query, &content)
    } else {
        search(&config.query, &content)
    };

    for line in lines {
        println!("{line}");
    }

    Ok(())
}
#[derive(Debug)]
pub struct Config {
    query: String,
    file_path: String,
    case_ignore: bool,
    max_line: bool,
    line_max: String
}

impl Config {
    pub fn build(args: &[String]) -> Result<Config, &'static str> {
        if args.len() < 3 {
            return Err("not enough arguments");
        }else if args.len() < 5 {
            return Err("not all arguments have");
        }

        let mut case_ignore = false;
        let mut max_line= false;
        if args.len() > 3 {
            if args[3] == "-ci" {
                case_ignore = true;
            }
        }
        if args.len() > 5 {
            if args[4] == "-max"{
                max_line = true;
            }
        }

        let c = Config {
            query: args[1].clone(),
            file_path: args[2].clone(),
            case_ignore,
            max_line,
            line_max: args[5].clone()
        };

        Ok(c)
    }
}

pub fn search<'a>(query: &str, contents: &'a str) -> Vec<&'a str> {
    let mut result = Vec::new();
    for line in contents.lines() {
        if line.contains(query) {
            result.push(line);
        }
    }

    result
}

pub fn max_query<'a>(line_max: &str, contents: &'a str) -> Vec<&'a str>{
    let mut number = line_max.parse::<u32>().unwrap();
    let mut result = Vec::new();
        for line in contents.lines() {
            result.push(line);
            number -= 1;
            if number == 0{
                break;
            }
        }
    result
}

pub fn search_case_insensitive<'a>(query: &str, contents: &'a str) -> Vec<&'a str> {
    let mut result = Vec::new();
    let query = query.to_lowercase();

    for line in contents.lines() {
        if line.to_lowercase().contains(&query) {
            result.push(line);
        }
    }

    result
}

#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn case_sensitive() {
        let query = "duct";
        let contents = "\
Rust:
safe, fast, productive.
Pick three.
Duct tape.";

        assert_eq!(vec!["safe, fast, productive."], search(query, contents));
    }

    #[test]
    fn case_insensitive() {
        let query = "rUsT";
        let contents = "\
Rust:
safe, fast, productive.
Pick three.
Trust me.";

        assert_eq!(
            vec!["Rust:", "Trust me."],
            search_case_insensitive(query, contents)
        );
    }

    #[test]
    fn case_max(){
        let contents = "\
        Rust:
        safe, fast, productive.
        Pick three.
        Trust me.";
        let line_max = "2";

        assert_eq!(vec!["Rust:", "        safe, fast, productive."], max_query(line_max, contents))
    }
}
