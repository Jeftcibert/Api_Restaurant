using WebApiBD_Restaurante.DAO;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//
builder.Services.AddScoped<UsuarioDAO>();
//
builder.Services.AddScoped<ClienteDAO>();
//
builder.Services.AddScoped<PlatillosDAO>();
//
builder.Services.AddScoped<MesasDAO>();
//
builder.Services.AddScoped<LoginDAO>();
//
builder.Services.AddScoped<CartaDAO>();
//------------------------

//------------------------

builder.Services.AddHttpContextAccessor();
builder.Services.AddSession(opciones =>
{
    opciones.IdleTimeout = TimeSpan.FromHours(1);
    opciones.Cookie.HttpOnly = true;
    opciones.Cookie.IsEssential = true;
});
//----------------------------





builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
