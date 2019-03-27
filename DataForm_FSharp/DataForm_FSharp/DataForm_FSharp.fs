namespace DataForm_FSharp

open System
open System.Numerics
open Xamarin.Forms
open Xamarin.Forms.Xaml
open Syncfusion.XForms.DataForm


type LoginRow() =     

    member val user = "" with get,set
    member val pwd = "" with get,set
    member val zone = "" with get,set
    member val url = "" with get,set

type TwoButtonsPage() = 
    inherit ContentPage()

    let mainStack = StackLayout()
    do mainStack.BackgroundColor <- Color.Orange
            
    do mainStack.VerticalOptions <- LayoutOptions.FillAndExpand  
    do mainStack.Orientation <- StackOrientation.Vertical
   
      
    let dataForm = new SfDataForm()
    do  dataForm.BackgroundColor <- Color.Red
    do  dataForm.DataObject <- new LoginRow()
    
    do mainStack.Children.Add(dataForm)       
    
    do base.Content <- mainStack

 
  
      
