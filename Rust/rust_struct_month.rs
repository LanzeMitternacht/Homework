trait Salary{
    fn salary_hour(&self) -> f32;
}

struct Driver{
    name:String,
    cost_hour:f32,
}

impl Salary for Driver{
    fn salary_hour(&self) -> f32 {
        self.cost_hour
    }
}

struct Developer{
    name:String,
    cost_hour:f32,
}

impl Salary for Developer{
    fn salary_hour(&self) -> f32 {
        self.cost_hour
    }
}

fn salary_in_month<T: Salary, Y: Salary>(fworker: &T, sworker: &Y) -> f32{
    let hour_per_month = 96.0;
    let fsalary = fworker.salary_hour()hour_per_month;
    let ssalary = sworker.salary_hour()hour_per_month;
    fsalary+ssalary
}

fn main() {
    let guy1 = Driver {name: "Mike".to_string(), cost_hour: 120.0};
    let guy2 = Developer{name: "Emiliya".to_string(), cost_hour: 250.0};
    let total_salary = salary_in_month(&guy1, &guy2);
    println!("{} and {} have {} salary per month", guy1.name, guy2.name, total_salary);
}