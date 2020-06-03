module Grains

let square (n: int): Result<uint64, string> =
    if n < 1 || n > 64 then
        Error "square must be between 1 and 64"
    else
        (n - 1)
        |> pown 2UL
        |> Ok

let total: Result<uint64, string> =
    [ 0 .. 63 ]
    |> List.sumBy (pown 2UL)
    |> Ok
