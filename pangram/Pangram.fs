module Pangram

open System.Text.RegularExpressions

let space = " "
let punctuations = "[\"_\-.]"
let numbers = "[0-9]"
let remove pattern s = Regex.Replace(s, pattern, "")

let normalize =
    remove numbers
    >> remove punctuations
    >> remove space

let isPangram (input: string): bool =
    let letters =
        input.ToLower()
        |> normalize
        |> Set.ofSeq
    letters.Count = 26
