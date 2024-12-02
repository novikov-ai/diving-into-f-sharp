// 17.1
let rec pow = function
    | (s,1) -> s
    | (s,n) -> s + "\n" + pow(s,n-1)

// 17.2
let rec isIthChar (s,n,c) =
    if n < 0 || n >= String.length s then
        false
    else 
        s.[n] = c

// 17.3
let rec occFromIth  (s,n,c) = 
    if n >= 0 && n < String.length s then
        if  s.[n] = c then
            1+occFromIth(s,n+1,c)
        else
            occFromIth(s,n+1,c)
    else
       0