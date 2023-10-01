using YardimMasasi.IsKatmani.Somut;
using YardimMasasi.IsKatmani.Soyut;

namespace YardimMasasi.BackendApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<IAnaKonuService, AnaKonuService>();
            builder.Services.AddScoped<IAltKonuService, AltKonuService>();
            builder.Services.AddScoped<ISurecService, SurecService>();
            builder.Services.AddScoped<IDuyuruService, DuyuruService>();
            builder.Services.AddScoped<IKullaniciService, KullaniciService>();
            builder.Services.AddScoped<IHaberService, HaberService>();
            builder.Services.AddScoped<IBirimService, BirimService>();

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
        }
    }
}