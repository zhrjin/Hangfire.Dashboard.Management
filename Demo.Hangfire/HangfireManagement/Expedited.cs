using Hangfire;
using Hangfire.Dashboard.Management.v2.Metadata;
using Hangfire.Dashboard.Management.v2.Support;
using Hangfire.Server;

using System;
using System.ComponentModel;

namespace Demo.Hangfire.HangfireManagement
{
	[ManagementPage(MenuName = "ExpeditedJobs", Title = "测试测定")]
	/*              A                            B                        */
	public class Expedited : IJob
	{
		[DisplayName("EEEE")] //C
		[Description("斯蒂芬斯蒂芬发士大夫")] //D
		[Queue("expedited")]
		[AllowMultiple]
		public void Job1(PerformContext context, IJobCancellationToken token,
			[DisplayData(
			Label = "String Input 1",
			Description = "This is the description text for the string input with a default value and the control is disabled",
			DefaultValue = "This is the Default Value",
			IsDisabled = true
		)]
		string strInput1,

			[DisplayData(
			Placeholder = "This is the placeholder text",
			Description = "This is the description text for the string input without a default value and the control is enabled",
			IsRequired = true
		)]
		string strInput2,

			[DisplayData(
			Label = "DateTime Input",
			Placeholder = "What is the date and time?",
			DefaultValue = "2022/6/3",
			Description = "This is a date time input control"
		)]
		DateTime dtInput,

			[DisplayData(
			Label = "Boolean Input",
			DefaultValue = true,
			Description = "This is a boolean input"
		)]
		bool blInput,

			[DisplayData(
			Label = "Select Input",
			DefaultValue = TestEnum.Test5,
			Description = "Based on an enum object"
		)]
		TestEnum enumTest
		)
		{
			//Do awesome things here
		}

		public enum TestEnum
		{
			Test1,
			Test2,
			Test3,
			Test4 = 44,
			Test5
		}
	}
}
