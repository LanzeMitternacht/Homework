fn main() {
    let matrix = vec![vec![4,3,2,-1], vec![3,2,1,-1], vec![1,1,-1,-2], vec![-1,-1,-2,-3]];
    println!("Negatives count in matrix: {}", count_negatives(matrix))
}
fn count_negatives(matrix: Vec<Vec<i32>>) -> i32 {
    let mut count = 0;

    for row in matrix.iter() {
        for &number in row.iter().rev() {
            if number < 0 {
                count += 1;
            } else {
                break;
            }
        }
    }

    count
}


#[cfg(test)]
mod test{
    use super::*;

    #[test]
    fn case_negative(){
        let matrix = vec![vec![3,2], vec![1,0]];
        assert_eq!(0, count_negatives(matrix))
    }
}