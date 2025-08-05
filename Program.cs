var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();      // ✅ Use this in .NET 8

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();       // ✅ No WithStaticAssets in .NET 8

app.Run();
