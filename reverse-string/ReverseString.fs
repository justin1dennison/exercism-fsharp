module ReverseString

open System

// This is a simpler solution than the one below. Something to remember.
let reverse (input: string): string = input |> Seq.rev |> String.Concat


//let reverse (input: string): string =
//    seq { input.Length - 1 .. -1 .. 0 }
//    |> Seq.map (fun x -> string (input.[x]))
//    |> Seq.fold (+) ""

