#nowarn "20"
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Http
open System


let builder = WebApplication.CreateBuilder()
let app = builder.Build()

// https://github.com/fsharp/fslang-suggestions/issues/1131
app.Map("/hello", Func<_,_>(fun (ctx:HttpContext) -> task {
    return Results.Ok("ok")
}));

app.Run()

exit 0
