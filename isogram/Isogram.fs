module Isogram

let isIsogram (str: string): bool =
    let ns = str.ToLower() |> String.filter System.Char.IsLetter
    (set ns |> Set.count) = String.length ns
