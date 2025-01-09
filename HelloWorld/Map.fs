// 43.3
let try_find key m = 
    let xs = Map.toList m
    let rec findValue k xs = 
        match xs with
        | [] -> None
        | (a,b) :: tail -> if a = k then Some(b) else findValue k tail 
    
    findValue key xs