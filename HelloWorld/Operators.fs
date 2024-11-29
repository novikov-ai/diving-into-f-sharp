// 16.1
let notDivisible (n,m) = 
    m % n = 0

// 16.2
let  prime n = 
    let isPrime =
        if n < 2 then false
        else
            let mutable value: bool = true
            for i in 2..n-1 do
                if n % i = 0 then 
                    value <- false 
            value
    isPrime