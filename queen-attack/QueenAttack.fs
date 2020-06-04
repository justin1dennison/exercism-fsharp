module QueenAttack

let boardBounds = (0, 7)

let (<=>) x (min, max): bool = x <= max && x >= min


let create (position: int * int): bool =
    let (x, y) = position
    x <=> boardBounds && y <=> boardBounds

let canAttack (queen1: int * int) (queen2: int * int): bool =
    let (x1, y1) = queen1
    let (x2, y2) = queen2

    let inPosition =
        match ((y2 - y1), (x2 - x1)) with
        | (x, y) when x = 0 || y = 0 || x / y = -1 || x / y = 1 -> true
        | _ -> false
    inPosition && create queen1 && create queen2
