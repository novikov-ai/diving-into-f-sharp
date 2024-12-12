// 23.4.1
let normalize (gold, silver, copper) =
    let totalCopper = gold * 20 * 12 + silver * 12 + copper
    let newGold = totalCopper / (20 * 12)
    let newSilver = (totalCopper % (20 * 12)) / 12
    let newCopper = totalCopper % 12
    (newGold, newSilver, newCopper)

let (.+.) x y =
    let (g1, s1, c1) = x
    let (g2, s2, c2) = y
    normalize (g1 + g2, s1 + s2, c1 + c2)

let (.-.) x y =
    let (g1, s1, c1) = x
    let (g2, s2, c2) = y
    normalize (g1 - g2, s1 - s2, c1 - c2)

// 23.4.2
let (.+) x y =
    let (a, b) = x
    let (c, d) = y
    (a + c, b + d)

let (.-) x y =
    let (a, b) = x
    let (c, d) = y
    (a - c, b - d)

let (.*) x y =
    let (a, b) = x
    let (c, d) = y
    (a * c - b * d, b * c + a * d)

let (./) x y =
    let (a, b) = x
    let (c, d) = y
    let denominator = c * c + d * d
    ((a * c + b * d) / denominator, (b * c - a * d) / denominator)



