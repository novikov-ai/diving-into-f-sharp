// 39.1
let rec rmodd = function
  | [] -> []
  | [_] -> []
  | _ :: y :: tail -> y :: rmodd tail

// 39.2
let rec del_even = function
  | [] -> []
  | x :: tail -> if x % 2 = 0 then del_even tail else x :: del_even tail

// 39.3
let rec multiplicity x xs = 
    match xs with
    | [] -> 0
    | head :: tail -> if head = x then 1+multiplicity x tail else multiplicity x tail

// 39.4
let rec split = function
  | [] -> ([],[])
  | x :: [] -> ([x],[])
  | x :: y :: tail -> 
    let odd, even = split tail
    x :: odd, y :: even

// 39.5
let rec zip (xs1,xs2) = 
  if List.length xs1 <> List.length xs2 then raise (System.ArgumentException("lists len are not equal"))
  match xs1, xs2 with
  | [],[] -> []
  | x1::tail1, x2::tail2 -> (x1,x2) :: zip(tail1,tail2)