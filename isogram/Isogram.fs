module Isogram

let isIsogram (str: string): bool =
    let charSeq =
        str.ToLower()
        |> Seq.filter (fun x -> x <> '-')
        |> Seq.filter (fun x -> x <> ' ')

    let charSet = charSeq |> Set.ofSeq

    Set.count charSet = Seq.length charSeq
