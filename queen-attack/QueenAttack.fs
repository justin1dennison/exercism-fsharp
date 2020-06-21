module QueenAttack

let boardBounds = (0, 7)

let (<=>) x (min, max): bool = x <= max && x >= min


let create (position: int * int): bool =
    let (x, y) = position
    x <=> boardBounds && y <=> boardBounds

let canAttack (queen1: int * int) (queen2: int * int): bool =
    let (x1, y1) = queen1
    let (x2, y2) = queen2
    let dx = (x2 - x1)
    let dy = (y2 - y1)
    let inPosition = dx = 0 || dy = 0 || dx / dy = -1 || dx / dy = 1
    inPosition && create queen1 && create queen2
