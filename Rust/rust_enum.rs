enum UserCategory{
    User(u32),
    Client,
    Customer(String),
    Worker(f32),
}

fn main() {
        let users = vec![
            UserCategory::User(123),
            UserCategory::Client,
            UserCategory::Customer(String::from("Email.mail")),
            UserCategory::Worker(20000.0),
        ];
    display_user(&users);
}

fn display_user(users:&Vec<UserCategory>){
    for i in users {
        print_user(i);
    }
}

fn print_user(us:&UserCategory) {
    match us {
        UserCategory::User(userid) => {
            println!("User with userid: {}", userid);
        }
        UserCategory::Client => {
            println!("Client");
        }
        UserCategory::Customer(email) => {
            println!("Customer with email: {}", email);
        }
        UserCategory::Worker(salary) => {
            println!("Worker with salary: {}", salary);
        }
    }
}