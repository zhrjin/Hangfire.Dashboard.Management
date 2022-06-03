using Hangfire;
using Hangfire.Dashboard.Management.v2.Metadata;
using Hangfire.Dashboard.Management.v2.Support;
using Hangfire.Server;

namespace Demo.Hangfire.HangfireManagement
{
	[ManagementPage(MenuName = "Simple Implementation", Title = nameof(Simple))]
	public class Simple : IJob
	{
		public void Job0(PerformContext context, IJobCancellationToken token)
		{
		}
	}
}
