module Darts

let distance (x: double) (y: double) = (x ** 2.0 + y ** 2.0) ** 0.5

let score (x: double) (y: double): int =
    match distance x y with
    | d when d <= 1.0 -> 10
    | d when d <= 5.0 -> 5
    | d when d <= 10.0 -> 1
    | _ -> 0
