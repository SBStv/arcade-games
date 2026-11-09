var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
var repositoryRoot = app.Environment.ContentRootPath;

app.MapGet("/", () => Results.Redirect("/frogger.html"));
app.MapGet("/index.html", () =>
    Results.File(Path.Combine(repositoryRoot, "index.html"), "text/html"));
app.MapGet("/frogger.html", () =>
    Results.File(Path.Combine(repositoryRoot, "frogger.html"), "text/html"));
app.MapGet("/Tadpole Hop.html", () =>
    Results.File(Path.Combine(repositoryRoot, "Tadpole Hop.html"), "text/html"));

app.Run();
