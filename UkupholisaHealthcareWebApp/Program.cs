using UkupholisaHealthcare.Library.BussinessLogic;
using UkupholisaHealthcare.Library.DataAccess;

namespace UkupholisaHealthcareWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            // Custom Services for dependency injection//
            builder.Services.AddTransient<ISqlDataAccess, SqlDataAccess>();
            builder.Services.AddTransient<IUserData, UserData>();
            builder.Services.AddTransient<IClientData, ClientData>();
            builder.Services.AddTransient<IPolicyData, PolicyData>();
            builder.Services.AddTransient<IProviderData, ProviderData>();
            builder.Services.AddTransient<ICallReportData, CallReportData>();
            builder.Services.AddTransient<ITreatmentData, TreatmentData>();
            builder.Services.AddTransient<IMedicalConditionData, MedicalConditionData>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}