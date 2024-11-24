let days_in_month = function
    | 1 -> 31 // January
    | 2 -> 28 // February (non-leap year)
    | 3 -> 31 // March
    | 4 -> 30 // April
    | 5 -> 31 // May
    | 6 -> 30 // June
    | 7 -> 31 // July
    | 8 -> 31 // August
    | 9 -> 30 // September
    | 10 -> 31 // October
    | 11 -> 30 // November
    | 12 -> 31 // December
    | _ -> 0 // Invalid month