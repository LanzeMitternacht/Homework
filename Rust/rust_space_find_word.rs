use std::io;

fn main() {
    let mut input = String::new();
    io::stdin().read_line(&mut input).unwrap();
    let mut number = String::new();
    io::stdin().read_line(&mut number).unwrap();
    let number:usize = number.trim().parse().unwrap();
    let space = string_space(&input);
    println!("Space in {} result: {}", input, space);

    match find_word(&input, number) {
        Some(word) => println!("Word with index {}: {}", number, word),
        None => println!("Can't find word with index {}", number),
    }

}

fn string_space(s: &String) -> i32{
   let bytes = s.as_bytes();
    let mut space = 0;
    for(_i, &item) in bytes.iter().enumerate(){
        if item == b' ' {
            space += 1;
        }
    }
    space
}

fn find_word(s:&str, number:usize) -> Option<&str>{
    let words: Vec<&str> = s.split_whitespace().collect();
    if number < words.len(){
        Some(words[number-1])
        } else {
        None
    }
}