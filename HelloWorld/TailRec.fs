// 48.4.1
let rec fibo1 n n1 n2 = 
    let rec boo x a b= 
        if x <= 2 then (a+b)
        else 
            boo (x-1) (a+b) a
    boo n n1 n2

// 48.4.2
let rec fibo2 n c = 
    if n = 0 then c 0
    elif n <= 2 then c 1
    else
        fibo2 (n-1) (fun f1 -> fibo2 (n-2) (fun f2 -> c (f1 + f2)))

// 48.4.3
let rec bigList n k =
  if n=0 then k []
  else bigList (n-1) (fun res -> k(1::res))