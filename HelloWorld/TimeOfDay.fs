type TimeOfDay = { hours: int; minutes: int; f: string }

let (.>.) x y = 
    if x.f > y.f then true
    elif x.f < y.f then false
    else
        if x.hours > y.hours then true
        elif x.hours < y.hours then false
        else
            if x.minutes > y.minutes then true
            elif x.minutes < y.minutes then false
            else
                false

type TimeOfDay = { hours: int; minutes: int; f: string }

let transform (x: TimeOfDay) = 
    if x.f = "PM" then (x.hours + 12) * 60 + x.minutes
    else x.hours * 60 + x.minutes

let (.>.) x y = (transform x) > (transform y)