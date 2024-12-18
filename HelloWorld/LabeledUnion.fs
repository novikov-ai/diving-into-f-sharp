type F = 
  | AM
  | PM

type TimeOfDay = { hours : int; minutes : int; f: F }

let transform (x: TimeOfDay) = 
    match x.f with
    | AM -> (0 + x.hours) * 60 + x.minutes
    | PM -> (12 + x.hours) * 60 + x.minutes

let (.>.) x y = (transform x) > (transform y)