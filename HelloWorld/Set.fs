// 42.3
let rec allSubsets n k = 
    let rec combinations k list = // combo k elements from list
      match k, list with
      | 0, _ -> [[]]
      | _, [] -> [] 
      | k, x::xs -> 
          (List.map (fun subset -> x :: subset) (combinations (k - 1) xs)) @ (combinations k xs)

    Set.ofList (List.map Set.ofList (combinations k [1..n]))