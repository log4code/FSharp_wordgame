open System.Runtime.InteropServices

open System

let getInput () =
    printf "guess:>"
    let input = Console.ReadLine ()
    input

let output (s:string) =
    printfn "You typed: %s" s

let rec gameLoop() =
    let input = getInput ()
    output input
    gameLoop() 

[<EntryPoint>]
let main argv =
    gameLoop()
    0 // return an integer exit code
