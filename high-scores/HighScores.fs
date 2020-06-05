module HighScores

let scores (values: int list): int list = values

let latest (values: int list): int =
    values
    |> List.rev
    |> List.head

let personalBest (values: int list): int = values |> List.max

let personalTopThree (values: int list): int list =
    values
    |> List.sortDescending
    |> (fun xs -> if List.length xs >= 3 then List.take 3 xs else xs)
