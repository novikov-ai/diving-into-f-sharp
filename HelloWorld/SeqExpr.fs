// 50.2.1
let fac_seq =
    let rec fact n = 
                if n <= 1 then 1 
                else
                n * fact(n-1)
    seq {
        yield! Seq.initInfinite fact
    }

// 50.2.2
let seq_seq = 
    seq{
        yield! Seq.initInfinite (fun i -> if i % 2 = 0 then i / 2 else i/2-i)
    }