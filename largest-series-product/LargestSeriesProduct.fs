module LargestSeriesProduct

open System

let toInt (c: char): int = int c - 48


let largestProduct (input: string) (seriesLength: int): int option =
    if (input
       |> Seq.filter Char.IsDigit
       |> Seq.length) <> input.Length then
        None
    else
        match (input.Length, seriesLength) with
        | (l, n) when (n > l || n < 0) -> None
        | (l, n) when (n = 0 || l = 0) -> Some(1)
        | (_, n) ->
            input
            |> Seq.windowed n
            |> Seq.map (Seq.map toInt)
            |> Seq.map (Seq.reduce (*))
            |> Seq.max
            |> Some
