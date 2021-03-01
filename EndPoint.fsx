let data = [1.;2.;3.;4.]

let sqr x = x * x

let sumsq' xs =
    let mutable acc = 0.0
    for x in xs do
        acc <- acc + sqr x
    acc

let rec sumsq''= function
    | []    -> 0.0
    | h::t   -> sqr h + sumsq'' t

let sumsq''' xs =
    Seq.sumBy sqr xs

let sumsq: float seq -> float =
    Seq.map sqr >> Seq.sum

let sumBy (f: float -> float) =
    Seq.map f >> Seq.sum

let mult x y = x * y

let double = mult 2.0

let funcs = [
    sumsq' 
    sumsq''
    sumsq'''
    sumsq   
    sumBy sqr
    sumBy double
]

let grandTotal =
    Seq.sumBy (fun f -> f data) funcs