module Pangram
open System.Text.RegularExpressions

let removeNumbers s = Regex.Replace(s, "[0-9]", "")
let removePunctuations s = Regex.Replace(s, "[\"_\-.]", "")
let removeSpaces s = Regex.Replace(s, " ", "")
let clean = removeNumbers >> removeSpaces >> removePunctuations

let isPangram (input: string): bool =
    let letters =
        input.ToLower()
        |> clean
        |> Set.ofSeq
    letters.Count = 26
