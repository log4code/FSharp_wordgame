open System

[<Literal>]
let ExitIntent = "exit" //Literal used for patter matching must be capitalized (ie not exitIntent)

let getInput () =
    printf "guess:>"
    Console.ReadLine ()

let output (s:string) =
    printfn "You typed: %s" s

let detectExit s =
    match s with
    | ExitIntent -> -1
    | _ -> 0


let rec gameLoop () =
    let decideAction s =
        match (detectExit s) with
        | 0 -> gameLoop
        | _ -> (fun x -> Console.WriteLine "Exiting the game. Thanks for playing!") //return anonymous function

    let input = getInput ()
    output input
    let action = decideAction input
    action () //these two steps could be one line, but made into 2 to show that a function is returned from 'decideAction'

[<EntryPoint>]
let main argv =
    gameLoop ()
    0 // return an integer exit code
