module Pangram

let isPangram (input: string): bool =
    let alphabet = set { 'a' .. 'z' }

    let letters =
        input.ToLower()
        |> Set.ofSeq
        |> Set.intersect alphabet
    letters.Count = 26
