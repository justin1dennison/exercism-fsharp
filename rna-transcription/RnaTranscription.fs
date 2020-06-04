module RnaTranscription

let transcriber =
    Map
        [ 'A', 'U'
          'C', 'G'
          'T', 'A'
          'G', 'C' ]

let transcribe (codon: char): char = transcriber.[codon]
let toRna (dna: string): string = dna |> String.map transcribe
