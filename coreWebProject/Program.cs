var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

/*app.MapGet("/", () => "Hello World!");*/

/* Index.html, index.htm, default.html, default.htm */
// app.UseDefaultFiles();

DefaultFilesOptions options = new DefaultFilesOptions();
options.DefaultFileNames.Clear();
options.DefaultFileNames.Add("home.html");
options.DefaultFileNames.Add("about.html");
app.UseDefaultFiles(options);

app.UseStaticFiles();

app.Run();
