// 41.4.1
let list_filter f xs = 
    List.foldBack (fun x acc -> if f x then x :: acc else acc) xs []

// 41.4.2
let sum (p, xs) = 
  List.foldBack (fun x acc -> if p x then acc + x else acc) xs 0

// 41.4.3
let revrev  = function
  | xs -> 
    let reversedList list = 
      List.fold (fun acc x -> x :: acc) [] list
    List.fold (fun acc inner -> reversedList inner :: acc) [] xs