// 47.4.1
let f n = 
    let mutable x = ref n
    let mutable sum = ref 1
    while x.Value > 1 do
        sum <- ref(sum.Value * x.Value)
        x.Value <- x.Value - 1
    sum.Value 

// 47.4.2
let fibo n = 
    match n with
    | 0 -> 0
    | 1 -> 1
    | _ -> 
        let mutable i = ref n
        let mutable prev = ref 1
        let mutable prevprev = ref 0

        while i.Value > 2 do
            let temp = prev
            prev <- ref(prevprev.Value + prev.Value)
            prevprev <- temp
            i <- ref(i.Value-1)

        prevprev.Value + prev.Value