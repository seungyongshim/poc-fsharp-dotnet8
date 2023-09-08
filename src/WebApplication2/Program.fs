open System
open Microsoft.AspNetCore.Builder
open Microsoft.Extensions.Hosting
open Giraffe
open System.Diagnostics

#nowarn "20"

let webapp = choose [
    route "/" >=> json {|
        TraceId = Activity.Current.Id
        //Text = "pong"
    |}
]

let builder = WebApplication.CreateBuilder()
builder.Services.AddGiraffe();
let app = builder.Build()


app.UseGiraffe webapp
app.Run()

0 // Exit code

