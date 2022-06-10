module App

open Feliz
open Feliz.DaisyUI
open Feliz.DaisyUI.Operators

open Elmish
open Elmish.React
open Elmish.Debug
open Elmish.HMR

type State = 
    {
        Active : bool
    }

type Msg = 
    | Toggle

let init () : State * Cmd<Msg> = { Active = false }, Cmd.none

let update cmd model : State * Cmd<Msg> = 
    match cmd with
    | Toggle -> { model with Active = not model.Active }, Cmd.none

let view (model : State) (dispatch : Msg -> unit) =
    Html.div [
        prop.className "p-6"
        prop.children [
            Daisy.button.button [
                prop.text "qwe"
                if model.Active then button.primary
                else button.secondary
                prop.onClick (fun _ -> dispatch Toggle)
            ]
        ]
    ]
    

Program.mkProgram 
    init
    update
    view
|> Program.withConsoleTrace
|> Program.withReactSynchronous "safer-app"
|> Program.withDebugger
|> Program.run
