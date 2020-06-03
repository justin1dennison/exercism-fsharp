module ReverseString

let reverse (input: string): string =
    seq { input.Length - 1 .. -1 .. 0 }
    |> Seq.map (fun x -> string (input.[x]))
    |> Seq.fold (+) ""
