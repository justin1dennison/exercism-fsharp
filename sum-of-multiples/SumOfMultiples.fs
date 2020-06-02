module SumOfMultiples

let sum (numbers: int list) (upperBound: int): int = 
    let ns = List.filter (fun n -> n <> 0) numbers;
    [ for x in 1..(upperBound - 1) do for n in ns do if x % n = 0 then yield x ]
    |> List.distinct
    |> List.sum
