use std::io;

fn factorial(num:i32) -> i32 {
    if num < 2 && num >= 0 {
        return 1;
    } else if num < 0 {
        panic!("Число {} не может быть отрицательным", num);
    }
    return num*factorial(num-1);
}

fn fibonacci(num:i32) -> i32{
    if num == 0 {
        return 0;
    }else if num == 1 {
        return 1;
    }
    return fibonacci(num-2)+fibonacci(num-1);
}

fn main() {
    {
        // Первое задание
        let mut array: [i32; 10] = [0; 10];
        for n in 0..array.len() {
            let mut number = String::new();
            io::stdin().read_line(&mut number).unwrap();
            let number: i32 = number.trim().parse().unwrap();
            array[n] = number;
        }
        println!("{:?} ", array);
    }

    {
    // Второе задание

        let mut number = String::new();
        io::stdin().read_line(&mut number).unwrap();
        let number: i32 = number.trim().parse().unwrap();
        let number = factorial(number);
        println!("{number}");
    }

    {
    // Третье задание

        let mut number = String::new();
        io::stdin().read_line(&mut number).unwrap();
        let number: i32 = number.trim().parse().unwrap();
        println!("{:?} ", fibonacci(number));
    }
}



