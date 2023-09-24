read number

if [[ -z "$number" ]]; then
echo "Arg can't be space"
exit 1
fi

factorial=1

if [[ "$number" -lt 0 ]]; then 
    echo "Arg сan't be negative"
exit 1
fi

for ((i=1;i<=number;i++))
do
factorial=$((factorial * i))
done

echo "Factorial number $number this $factorial"
exit 0
