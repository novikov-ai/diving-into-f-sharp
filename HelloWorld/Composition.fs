// 20.3.1
let vat n x =
    if n < 0 || n > 100 then x : float
    else 
    float x +  (float n / 100.0) * x 

// 20.3.2
let unvat n x =
    if n < 0 || n > 100 then x : float
    else 
        x / (1.0 + (float n / 100.0))

// 20.3.3
let rec min f =
    let rec findMin n =
        if f n = 0 then n
        else findMin (n + 1)
    findMin 1