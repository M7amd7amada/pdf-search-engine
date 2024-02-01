using PdfSearchEngine.Api;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddPresentation();
}

var app = builder.Build();
{
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    app.MapControllers();

    await app.RunAsync();
}
