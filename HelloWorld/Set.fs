// 42.3
let rec allSubsets n k = 
  if k > n then 
   raise (System.Exception("k > n"))

  if k = 0 then Set.ofList [] 
  else 
    Set.add k (allSubsets n (k - 1))