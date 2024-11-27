let rec fibo = function
    | 0 -> 0
    | 1 -> 1
    | n -> fibo (n-1) + fibo (n-2)

let value = fibo(5)

printfn "%d" value