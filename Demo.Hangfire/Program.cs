using Hangfire;
using Hangfire.Dashboard.Management.v2.Support;
using Hangfire.MemoryStorage;
using Hangfire.Dashboard.Management.v2;
using Hangfire.Dashboard;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddRazorPages();


var services = builder.Services;
services.AddHangfire((configuration) =>
{
	configuration
		.UseMemoryStorage()
		.UseSimpleAssemblyNameTypeSerializer()
		.UseRecommendedSerializerSettings()
		.UseManagementPages(typeof(Program).Assembly);
});

services.AddHangfireServer((options) => {
	var queues = new List<string>();
	queues.Add("default");
	queues.AddRange(JobsHelper.GetAllQueues());

	options.Queues = queues.Distinct().ToArray();
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

//app.UseAuthorization();

//app.MapRazorPages();



app.UseHangfireDashboard("/hangfire", new DashboardOptions() {
	DisplayStorageConnectionString = false,
	DashboardTitle = "Hangfire Management",
	StatsPollingInterval = 5000
});


app.Run();
