#!/bin/bash

read -p "Enter a number: " arg 

if [[ "$arg" -eq 99  ]]; then
touch "critical_success.txt"
elif [[ "$arg" -lt 5 ]]; then
touch "less.txt" 
else 
touch "greater.txt"
fi

exit 0
