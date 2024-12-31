// 40.1
let rec sum (p, xs) = 
  match xs with
  | [] -> 0
  | head :: tail -> if p head then head + sum(p, tail) else sum(p, tail)

// 40.2.1
let rec count (xs, n) = 
  match xs with
  | [] -> 0
  | head :: tail -> if head = n then 1 + count(tail, n) elif head < n then count(tail, n) else 0

// 40.2.2
let rec insert (xs, n) = 
  match xs with
  | [] -> [n]
  | head :: tail -> if head < n then head :: insert(tail, n) else n :: head :: tail

let rec find x ls = 
      match ls with
      | [] -> false
      | head :: tail -> if head = x then true else find x tail
let rec remove x ls =
  match ls with
    | [] -> []
    | head :: tail -> if head = x then tail else head :: remove x tail

// 40.2.3
let rec intersect (xs1, xs2) = 
  match xs1  with 
  | [] -> []
  | head::tail -> 
    if find head xs2 then head :: intersect(tail, remove head xs2) else intersect(tail, xs2)

// 40.2.4
let rec plus (xs1, xs2) = List.sort (xs1 @ xs2)

// 40.2.5
let rec minus (xs1, xs2) = 
  match xs1 with 
  | [] -> []
  | head :: tail -> if find head xs2 then minus(tail, remove head xs2) else head :: minus(tail, xs2)

// 40.3.1
let rec smallest = function
  | [] -> None
  | list -> Some (List.min list)

// 40.3.2
let rec delete (n, xs) = 
  match xs with
    | [] -> []
    | head :: tail -> if head = n then tail else head :: delete(n, tail)

// 40.3.3
let rec sort = function
  | list -> List.sort list

let rec rv = function
    | [] -> []
    | head :: tail ->
      let reverted = List.rev head
      reverted :: rv tail

// 40.4
let rec revrev = function
  | [] -> []
  | list -> List.rev (rv list)