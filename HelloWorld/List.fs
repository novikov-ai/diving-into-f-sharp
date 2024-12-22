// 34.1
let rec upto n = [1..n]

// 34.2
let rec dnto n = 
  if n <= 0 then [] else n::dnto(n-1)

// 34.3
let rec evenn = function
  | 0 -> []
  | n -> if n%2 = 0 then evenn(n-1) @ [n] else evenn(n-1)