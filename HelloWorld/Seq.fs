// 49.5.1
let even_seq = 
  Seq.initInfinite (fun i -> i+i)

// 49.5.2
let even_seq = 
  let rec fact n = 
    if n = 0 then 1 
    elif n = 1 then 1 
    else
      n * fact(n-1) 

  Seq.initInfinite (fun i -> fact(i))

// 49.5.3
let seq_seq = 
  Seq.initInfinite (fun i -> if i % 2 = 0 then i / 2 else i/2-i)