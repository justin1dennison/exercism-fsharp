module RnaTranscription

let transcribe (codon: char ): char =
    match codon with
    | 'a'
    | 'A' -> 'U'
    | 'c'
    | 'C' -> 'G'
    | 't'
    | 'T' -> 'A'
    | 'g'
    | 'G' -> 'C'
    | _ -> failwith "Invalid codon"

let toRna (dna: string): string = dna |> String.map transcribe
