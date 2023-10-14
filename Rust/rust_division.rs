use std::io;

struct Division{
    first_number:u32,
    second_number:u32,
}

impl Division{
    fn safe_division(&self) -> Option<u32>{
        if self.second_number != 0 {
            Some(self.first_number / self.second_number)
        }else{
            None
        }
    }
}

fn keyboard_read() -> (u32, u32){
    let mut fnumber = String::new();
    io::stdin().read_line(&mut fnumber).unwrap();
    let fnumber:u32 = fnumber.trim().parse().unwrap();
    let mut snumber = String::new();
    io::stdin().read_line(&mut snumber).unwrap();
    let snumber:u32 = snumber.trim().parse().unwrap();
    (fnumber, snumber)
}

fn main() {
    let number = keyboard_read();
    let div1 = Division{
        first_number: number.0,
        second_number: number.1,
    };

    println!("Result division = {:?}", div1.safe_division())
}