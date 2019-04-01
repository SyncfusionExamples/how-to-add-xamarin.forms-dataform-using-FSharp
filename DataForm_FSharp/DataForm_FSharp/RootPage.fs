namespace DataForm_FSharp

open System
open System.Numerics
open Xamarin.Forms
open Xamarin.Forms.Xaml
open Syncfusion.XForms.DataForm




type TwoButtonsPage1() = 
    inherit ContentPage()        

    let button = Button()
    do button.BackgroundColor <- Color.Orange
                   
    do button.Text <- "Navigate"
    do button.Clicked.Add(fun evArgs -> button.Navigation.PushModalAsync(TwoButtonsPage(), true) |> ignore)
                  
    
    do base.Content <- button

type App() = 
    inherit Application(MainPage = TwoButtonsPage1())
 

