using Scalar.AspNetCore;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddOpenApi();
//Configuração para formatar os nomes dos endpoints em caixa baixa
builder.Services.AddRouting(map => map.LowercaseUrls = true);
//Configuração do Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}
//Habilitando a biblioteca do Swagger
app.UseSwagger();
app.UseSwaggerUI();
//Habilitando a biblioteca do Scalar
app.MapScalarApiReference
        (s => s.WithTheme(ScalarTheme.BluePlanet));
app.UseAuthorization();
app.MapControllers();
app.Run();