// 34.1
let rec upto = function
  | 0 -> []
  | n -> upto(n-1) @ [n]

// 34.2
let rec dnto = function 
  | 0 -> []
  | n -> n::dnto(n-1)

// 34.3
let rec evenn = function
  | n -> if n <= 0 then [] else (evenn (n-1) @ [2*(n-1)])