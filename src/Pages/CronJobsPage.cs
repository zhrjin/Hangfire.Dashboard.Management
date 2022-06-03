﻿namespace Hangfire.Dashboard.Management.v2.Pages
{
	internal class CronJobsPage : RazorPage
	{
		public CronJobsPage()
		{

		}
		public override void Execute()
		{
			WriteLiteral($@"
<style>
	.tab-content input[type=number] {{
		height: 25px;
		width: 52px;
	}}
</style>
<div>
	<div>
		<!-- Nav tabs -->
		<ul class=""nav nav-tabs"" role=""tablist"">
<!--
			<li role=""presentation"" class=""active"">
				<a href=""#second"" aria-controls=""second"" role=""tab"" data-toggle=""tab"">秒</a>
			</li>
-->
			<li role=""presentation"" class=""active"">
				<a href=""#minute"" aria-controls=""minute"" role=""tab"" data-toggle=""tab"">分钟</a>
			</li>
			<li role=""presentation"">
				<a href=""#hour"" aria-controls=""hour"" role=""tab"" data-toggle=""tab"">小时</a>
			</li>
			<li role=""presentation"">
				<a href=""#day"" aria-controls=""day"" role=""tab"" data-toggle=""tab"">天</a>
			</li>
			<li role=""presentation"">
				<a href=""#month"" aria-controls=""month"" role=""tab"" data-toggle=""tab"">月</a>
			</li>
			<li role=""presentation"">
				<a href=""#week"" aria-controls=""week"" role=""tab"" data-toggle=""tab"">周</a>
			</li>
<!--
			<li role=""presentation"">
				<a href=""#year"" aria-controls=""year"" role=""tab"" data-toggle=""tab"">年</a>
			</li>
-->
			<li role=""presentation"">
				<a href=""#general"" aria-controls=""general"" role=""tab"" data-toggle=""tab"">常用Cron表达式</a>
			</li>
			<li role=""presentation"">
				<a href=""#cron"" aria-controls=""cron"" role=""tab"" data-toggle=""tab"">Cron表达式解析</a>
			</li>
		</ul>
		<!-- Tab panes -->
		<div class=""tab-content"">
			<!--second-->
			<!--<div role=""tabpanel"" class=""tab-pane active"" id=""second"">
					<div class=""radio"">
						<label>
							<input type=""radio"" name=""secondType"" value=""All"" checked=""checked"">
							每秒 允许的通配符[, - * /]
						</label>
					</div>
					<div class=""radio"">
						<label>
							<input type=""radio"" name=""secondType"" value=""Cyclic"">
							周期从
							<input type=""number"" maxlength=""2"" id=""secondTypeCyclic_1"" value=""1"">
							-
							<input type=""number"" id=""secondTypeCyclic_2"" value=""2"">
							 秒
						</label>
					</div>
					<div class=""radio"">
						<label>
							<input type=""radio"" name=""secondType"" value=""Interval"">
							从
							<input type=""number"" id=""secondTypeInterval_1"" value=""0"">
							秒开始,每
							<input type=""number"" id=""secondTypeInterval_2"" value=""1"">
							 秒执行一次
						</label>
					</div>
					<div class=""radio"">
						<label>
							<input type=""radio"" name=""secondType"" value=""Assigned"">
							指定
						</label>
					</div>
					<div style=""margin-left: 20px;"">
						<select id=""secondTypeAssigned_1"" data-placeholder=""选择指定的秒...""
								style=""width:350px;"" multiple></select>
					</div>
				</div>-->
			<!--minute-->
			<div role=""tabpanel"" class=""tab-pane active"" id=""minute"">
				<div class=""radio"">
					<label>
						<input type=""radio"" name=""minuteType"" value=""All"" checked=""checked"">
						每分钟 (允许的通配符[, - * /])
					</label>
				</div>
				<div class=""radio"">
					<label>
						<input type=""radio"" name=""minuteType"" value=""Cyclic"">
						周期从
						<input type=""number"" id=""minuteTypeCyclic_1"" value=""1"">
						-
						<input type=""number"" id=""minuteTypeCyclic_2"" value=""2"">
						分钟
					</label>
				</div>
				<div class=""radio"">
					<label>
						<input type=""radio"" name=""minuteType"" value=""Interval"">
						从
						<input type=""number"" id=""minuteTypeInterval_1"" value=""0"">
						分钟开始,每
						<input type=""number"" id=""minuteTypeInterval_2"" value=""1"">
						分钟执行一次
					</label>
				</div>
				<div class=""radio"">
					<label>
						<input type=""radio"" name=""minuteType"" value=""Assigned"">
						指定
					</label>
				</div>
				<div style=""margin-left: 20px;"">
					<select id=""minuteTypeAssigned_1"" data-placeholder=""选择指定的分钟...""
							style=""width:350px;"" multiple></select>
				</div>
			</div>
			<!--hour-->
			<div role=""tabpanel"" class=""tab-pane"" id=""hour"">
				<div class=""radio"">
					<label>
						<input type=""radio"" name=""hourType"" value=""All"" checked=""checked"">
						每小时 (允许的通配符[, - * /])
					</label>
				</div>
				<div class=""radio"">
					<label>
						<input type=""radio"" name=""hourType"" value=""Cyclic"">
						周期从
						<input type=""number"" id=""hourTypeCyclic_1"" value=""0"">
						-
						<input type=""number"" id=""hourTypeCyclic_2"" value=""2"">
						小时
					</label>
				</div>
				<div class=""radio"">
					<label>
						<input type=""radio"" name=""hourType"" value=""Interval"">
						从
						<input type=""number"" id=""hourTypeInterval_1"" value=""0"">
						小时开始,每
						<input type=""number"" id=""hourTypeInterval_2"" value=""1"">
						小时执行一次
					</label>
				</div>
				<div class=""radio"">
					<label>
						<input type=""radio"" name=""hourType"" value=""Assigned"">
						指定
					</label>
				</div>
				<div style=""margin-left: 20px;"">
					<select id=""hourTypeAssigned_1"" data-placeholder=""选择指定的小时...""
							style=""width:350px;"" multiple></select>
				</div>
			</div>

			<!--日-->
			<div role=""tabpanel"" class=""tab-pane"" id=""day"">
				<div class=""radio"">
					<label>
						<input type=""radio"" name=""dayType"" value=""All"" checked=""checked"">
						每天 (允许的通配符[, - * /])
					</label>
				</div>
				<div class=""radio"">
					<label>
						<input type=""radio"" name=""dayType"" value=""Cyclic"">
						周期从
						<input type=""number"" id=""dayTypeCyclic_1"" value=""1"">
						-
						<input type=""number"" id=""dayTypeCyclic_2"" value=""2"">
						日
					</label>
				</div>
				<div class=""radio"">
					<label>
						<input type=""radio"" name=""dayType"" value=""Interval"">
						从
						<input type=""number"" id=""dayTypeInterval_1"" value=""1"">
						日开始,每
						<input type=""number"" id=""dayTypeInterval_2"" value=""1"">
						日执行一次
					</label>
				</div>
				<div class=""radio"">
					<label>
						<input type=""radio"" name=""dayType"" value=""Assigned"">
						指定
					</label>
				</div>
				<div style=""margin-left: 20px;"">
					<select id=""dayTypeAssigned_1"" data-placeholder=""选择指定的日...""
							style=""width:350px;"" multiple></select>
				</div>
				<!--<div class=""radio"">
						<label>
							<input type=""radio"" name=""dayType"" value=""NotAssigned"">
							Not specify
						</label>
					</div>
					<div class=""radio"">
						<label>
							<input type=""radio"" name=""dayType"" value=""RecentDays"">
							per month
							<input type=""number"" id=""dayTypeRecentDays_1"" value=""1"">
							The nearest working day
						</label>
					</div>
					<div class=""radio"">
						<label>
							<input type=""radio"" name=""dayType"" value=""LastDayOfMonth"">
							Last day of the month
						</label>
					</div>
					<div class=""radio"">
						<label>
							<input type=""radio"" name=""dayType"" value=""LastDayOfMonthRecentDays"">
							Last business day of the month
						</label>
					</div>-->
			</div>

			<!--月-->
			<div role=""tabpanel"" class=""tab-pane"" id=""month"">
				<div class=""radio"">
					<label>
						<input type=""radio"" name=""monthType"" value=""All"" checked=""checked"">
						每月(允许的通配符[, - * /])
					</label>
				</div>
				<div class=""radio"">
					<label>
						<input type=""radio"" name=""monthType"" value=""Cyclic"">
						周期从
						<input type=""number"" id=""monthTypeCyclic_1"" value=""1"">
						-
						<input type=""number"" id=""monthTypeCyclic_2"" value=""2"">
						月
					</label>
				</div>
				<div class=""radio"">
					<label>
						<input type=""radio"" name=""monthType"" value=""Interval"">
						从
						<input type=""number"" id=""monthTypeInterval_1"" value=""1"">
						月开始,每
						<input type=""number"" id=""monthTypeInterval_2"" value=""1"">
						月执行一次
					</label>
				</div>
				<div class=""radio"">
					<label>
						<input type=""radio"" name=""monthType"" value=""Assigned"">
						指定
					</label>
				</div>
				<div style=""margin-left: 20px;"">
					<select id=""monthTypeAssigned_1"" data-placeholder=""选择指定的月...""
							style=""width:350px;"" multiple></select>
				</div>
				<!--<div class=""radio"">
						<label>
							<input type=""radio"" name=""monthType"" value=""NotAssigned"">
							Not specify
						</label>
					</div>-->
			</div>

			<!--周-->
			<div role=""tabpanel"" class=""tab-pane"" id=""week"">
				<div class=""radio"">
					<label>
						<input type=""radio"" name=""weekType"" value=""All"" checked=""checked"">
						每周(允许的通配符[, - * /])
					</label>
				</div>
				<div class=""radio"">
					<label>
						<input type=""radio"" name=""weekType"" value=""Cyclic"">
						周期从
						<input type=""number"" id=""weekTypeCyclic_1"" value=""1"">
						-
						<input type=""number"" id=""weekTypeCyclic_2"" value=""2"">
						周
					</label>
				</div>
				<div class=""radio"">
					<label>
						<input type=""radio"" name=""weekType"" value=""WeeksOfWeek"">
						第
						<input type=""number"" id=""weekTypeWeeksOfWeek_1"" value=""1"">
						 周的星期
						<input type=""number"" id=""weekTypeWeeksOfWeek_2"" value=""1"">
					</label>
				</div>
				<div class=""radio"">
					<label>
						<input type=""radio"" name=""weekType"" value=""Assigned"">
						指定
					</label>
				</div>
				<div style=""margin-left: 20px;"">
					<select id=""weekTypeAssigned_1"" data-placeholder=""选择指定的周...""
							style=""width:350px;"" multiple></select>
				</div>
				<!--<div class=""radio"">
						<label>
							<input type=""radio"" name=""weekType"" value=""NotAssigned"">
							Not specify
						</label>
					</div>
					<div class=""radio"">
						<label>
							<input type=""radio"" name=""weekType"" value=""LastWeekOfMonth"">
							Last week of the month
							<input type=""number"" id=""weekTypeLastWeekOfMonth_1"" value=""1"">
						</label>
					</div>-->
			</div>
			<!--年-->
			<!--<div role=""tabpanel"" class=""tab-pane"" id=""year"">
					<div class=""radio"">
						<label>
							<input type=""radio"" name=""yearType"" value=""All"" checked=""checked"">
							Wildcard allowed per year [, - * /]
						</label>
					</div>
					<div class=""radio"">
						<label>
							<input type=""radio"" name=""yearType"" value=""NotAssigned"">
							Not specify
						</label>
					</div>
					<div class=""radio"">
						<label>
							<input type=""radio"" name=""yearType"" value=""Cyclic"">
							Cycle from
							<input type=""number"" id=""yearTypeCyclic_1"" value=""2015"">
							-
							<input type=""number"" id=""yearTypeCyclic_2"" value=""2299"">
							year
						</label>
					</div>
					<div class=""radio"">
						<label>
							<input type=""radio"" name=""yearType"" value=""Assigned"">
							Specified
						</label>
					</div>
					<div style=""margin-left: 20px;"">
						<select id=""yearTypeAssigned_1"" data-placeholder=""Select specified year ...""
								style=""width:350px;"" multiple></select>
					</div>
				</div>-->


            <!--常用Cron表达式-->
        <div role=""tabpanel"" class=""tab-pane"" id=""general"">
            每分： (* * * * *)<br />
            每时： (0 * * * *)<br />
            每天： (0 0 * * *)<br />
            每周： (0 0 * * 1)<br />
            每月： (0 0 1 * *)<br />
            每年： (0 0 1 1 *)<br />
            <br /><br />
            <b>Commonly used Example</b><br />
            0 10 * * * ?--------------------每个小时过10分执行一次<br />
            0 0/32 8,12 * * ? --------------每天8:32,12:32 执行一次<br />
            0 0/2 * * * ?-------------------每2分钟执行一次<br />
            0 0 12 * * ?--------------------在每天中午12：00触发<br />
            0 15 10 ? * *-------------------每天上午10:15 触发<br />
            0 15 10 * * ?-------------------每天上午10:15 触发<br />
            0 15 10 * * ? *-----------------每天上午10:15 触发<br />
            0 15 10 * * ? 2005--------------在2005年中的每天上午10:15 触发<br />
            0 * 14 * * ?--------------------每天在下午2：00至2：59之间每分钟触发一次<br />
            0 0/5 14 * * ?------------------每天在下午2：00至2：59之间每5分钟触发一次<br />
            0 0/5 14,18 * * ?---------------每天在下午2：00至2：59和6：00至6：59之间的每5分钟触发一次<br />
            0 0-5 14 * * ?------------------每天在下午2：00至2：05之间每分钟触发一次<br />
            0 10,44 14 ? 3 WED--------------每三月份的星期三在下午2：00和2：44时触发<br />
            0 15 10 ? * MON-FRI-------------从星期一至星期五的每天上午10：15触发<br />
            0 15 10 15 * ?------------------在每个月的每15天的上午10：15触发<br />
            0 15 10 L * ?-------------------在每个月的最后一天的上午10：15触发<br />
            0 15 10 ? * 6L------------------在每个月的最后一个星期五的上午10：15触发<br />
            0 15 10 ? * 6L 2002-2005--------在2002, 2003, 2004 and 2005年的每个月的最后一个星期五的上午10：15触发<br />
            0 15 10 ? * 6#3-----------------在每个月的第三个星期五的上午10：15触发<br />
            0 0 12 1/5 * ?------------------从每月的第一天起每过5天的中午12：00时触发<br />
            0 11 11 11 11 ?-----------------在每个11月11日的上午11：11时触发.<br />




            <br /><br />

            在每个11月11日的上午11：11时触发.：0 0 0 * * ?<br />
            每周一0点：0 0 0 ? * MON 或者 0 0 0 ? * 2 (注:1=SUN,2=MON,3=TUE,4=WED,5=THU,6=FRI,7=SAT)<br />
            每月1日0点： 0 0 0 1 * ?<br />
            每年1月1日0点：0 0 0 1 1 ?或者 0 0 0 1 JAN ?(注:1-12月依次是JAN, FEB, MAR, APR, MAY, JUN, JUL, AUG, SEP, OCT, NOV, DEC)<br />
            2046年8月1日0点：0 0 0 1 8 ? 2046<br />

            每隔5秒执行一次：*/5 * * * * ?<br />

            每隔1分钟执行一次：0 */1 * * * ?<br />

            每天23点执行一次：0 0 23 * * ?<br />

            每天凌晨1点执行一次：0 0 1 * * ?<br />

            每月1号凌晨1点执行一次：0 0 1 1 * ?<br />

            每月最后一天23点执行一次：0 0 23 L * ?<br />

            每周星期天凌晨1点实行一次：0 0 1 ? * L<br />

            在26分、29分、33分执行一次：0 26,29,33 * * * ?<br />

            每天的0点、13点、18点、21点都执行一次：0 0 0,13,18,21 * * ?<br />

            每隔5分钟执行一次：0 0/5 * * * ?<br />
            0 0 12 * * ? 在每天中午12：00触发<br />
            0 15 10 ? * * 每天上午10:15 触发<br />
            0 15 10 * * ? 每天上午10:15 触发<br />
            0 15 10 * * ? * 每天上午10:15 触发<br />
            0 15 10 * * ? 2005 在2005年中的每天上午10:15 触发<br />
            0 * 14 * * ? 每天在下午2：00至2：59之间每分钟触发一次<br />
            0 0/5 14 * * ? 每天在下午2：00至2：59之间每5分钟触发一次<br />
            0 0/5 14,18 * * ? 每天在下午2：00至2：59和6：00至6：59之间的每5分钟触发一次<br />
            0 0-5 14 * * ? 每天在下午2：00至2：05之间每分钟触发一次<br />
            0 10,44 14 ? 3 WED 每三月份的星期三在下午2：00和2：44时触发<br />
            0 15 10 ? * MON-FRI 从星期一至星期五的每天上午10：15触发<br />
            0 15 10 15 * ? 在每个月的每15天的上午10：15触发<br />
            0 15 10 L * ? 在每个月的最后一天的上午10：15触发<br />
            0 15 10 ? * 6L 在每个月的最后一个星期五的上午10：15触发<br />
            0 15 10 ? * 6L 2002-2005 在2002, 2003, 2004 and 2005年的每个月的最后一个星期五的上午10：15触发<br />
            0 15 10 ? * 6#3 在每个月的第三个星期五的上午10：15触发<br />
        </div>
            <!--Cron表达式解析-->
        <div role=""tabpanel"" class=""tab-pane"" id=""cron"">
            验证地址 {Url.To("/cron?cron=*+*+*+*+*")}<br /><br />
            精确到分钟数的五部分格式
<pre>
                    * * * * *
                    - - - - -
                    | | | | |
                    | | | | +----- [周]day of week (0 - 6) (Sunday=0)
                    | | | +------- [月]month (1 - 12)
                    | | +--------- [天]day of month (1 - 31)
                    | +----------- [时]hour (0 - 23)
                    +------------- [分]min (0 - 59)
</pre>
            精确到秒数的六部分格式
<pre>
                * * * * * *
                - - - - - -
                | | | | | |
                | | | | | +--- [周]day of week (0 - 6) (Sunday=0)
                | | | | +----- [月]month (1 - 12)
                | | | +------- [天]day of month (1 - 31)
                | | +--------- [时]hour (0 - 23)
                | +----------- [分]min (0 - 59)
                +------------- [秒]sec (0 - 59)
</pre>
            特殊字符 意义<br />
                                                                 <pre>
                * 表示所有值；例如，“*”在子表达式（月）里表示每个月的含义，“*”在子表达式（天（星期））表示星期的每一天
                - 表示一个指定的范围；
                , 表示附加一个可能值；
                / 符号前表示开始时间，符号后表示每次递增的值；
</pre>

            <b>Cron 表达式包括以下 7 个字段</b><br />
            <ul class=""list-unstyled"">
                <li>格式: [秒] [分] [小时] [日] [月] [周] [年]</li>
                <li>
                    <table class=""table table-hover"">
                        <tr>
                            <th>序号</th>
                            <th>说明</th>
                            <th>是否必填</th>
                            <th>允许填写的值</th>
                            <th>允许的通配符</th>
                        </tr>
                        <tr>
                            <td>1</td>
                            <td>秒</td>
                            <td>是</td>
                            <td>0-59</td>
                            <td>, - * /</td>
                        </tr>
                        <tr>
                            <td>2</td>
                            <td>分</td>
                            <td>是</td>
                            <td>0-59</td>
                            <td>, - * /</td>
                        </tr>
                        <tr>
                            <td>3</td>
                            <td>小时</td>
                            <td>是</td>
                            <td>0-23</td>
                            <td>, - * /</td>
                        </tr>
                        <tr>
                            <td>4</td>
                            <td>日</td>
                            <td>是</td>
                            <td>0-31</td>
                            <td>, - * ? / L W</td>
                        </tr>
                        <tr>
                            <td>5</td>
                            <td>月</td>
                            <td>是</td>
                            <td>1-12 or JAN-DEC</td>
                            <td>, - * /</td>
                        </tr>
                        <tr>
                            <td>6</td>
                            <td>周</td>
                            <td>是</td>
                            <td>1-7 or SUN-SAT</td>
                            <td>, - * ? / L #</td>
                        </tr>
                        <tr>
                            <td>7</td>
                            <td>年</td>
                            <td>否</td>
                            <td>empty 或者 1970-2099</td>
                            <td>, - * /</td>
                        </tr>
                    </table>
                </li>
            </ul>
            <b>通配符说明</b><br />
            <ol>
                <li>反斜线（/）字符表示增量值。例如，在秒字段中“5/15”代表从第 5 秒开始，每 15 秒一次。</li>
                <li>星号（*）字符是通配字符，表示该字段可以接受任何可能的值（例如:在分的字段上设置 \""*\"",表示每一分钟都会触发）。</li>
                <li>问号（?）问号表示这个字段不包含具体值。所以，如果指定月内日期，可以在月内日期字段中插入“?”，表示周内日期值无关紧要。字母 L 字符是 last 的缩写。放在月内日期字段中，表示安排在当月最后一天执行。在周内日期字段中，如果“L”单独存在，就等于“7”，否则代表当月内周内日期的最后一个实例。所以“0L”表示安排在当月的最后一个星期日执行。</li>
                <li>-  表示区间，例如 在小时上设置 \""10-12\"",表示 10,11,12点都会触发。</li>
                <li>逗号（, ） 表示指定多个值，例如在周字段上设置 \""MON,WED,FRI\"" 表示周一，周三和周五触发</li>
                <li>井号（#）字符为给定月份指定具体的工作日实例。把“MON#2”放在周内日期字段中，表示把任务安排在当月的第二个星期一。</li>
                <li>L 表示最后的意思。在日字段设置上，表示当月的最后一天(依据当前月份，如果是二月还会依据是否是润年[leap]), 在周字段上表示星期六，相当于\""7\""或\""SAT\""。如果在\""L\""前加上数字，则表示该数据的最后一个。例如在周字段上设置\""6L\""这样的格式,则表示“本月最后一个星期五\""。</li>
                <li>W 表示离指定日期的最近那个工作日(周一至周五). 例如在日字段上设置\""15W\""，表示离每月15号最近的那个工作日触发。如果15号正好是周六，则找最近的周五(14号)触发, 如果15号是周未，则找最近的下周一(16号)触发.如果15号正好在工作日(周一至周五)，则就在该天触发。如果指定格式为 \""1W\"",它则表示每月1号往后最近的工作日触发。如果1号正是周六，则将在3号下周一触发。(注，\""W\""前只能设置具体的数字,不允许区间\""-\。</li>
            </ol>
            <p class=""text-danger"">注：'L'和 'W'可以一组合使用。如果在日字段上设置\""LW\""，则表示在本月的最后一个工作日触发。</p><br />

        </div>
        </div>
    </div>
    <hr>
    <div class=""panel panel-info"">
        <div class=""panel-heading"">
            <h3 class=""panel-title"">结果</h3>
        </div>
        <div class=""panel-body"">
            <form class=""form-inline"">
                <div class=""form-group"">
                    <div class=""input-group input-group-sm"">
                        <input type=""text"" class=""form-control"" style=""width: 450px;"" id=""result"" placeholder=""结果"">
                        <div class=""input-group-btn "">
                            <button type=""button"" id=""analysis"" class=""btn btn-default""><span class=""glyphicon glyphicon-ok""></span>  &nbsp;反解析</button>
                        </div>
                    </div>
                </div>
            </form>
        </div>
    </div>

</div>
");
		}
	}
}
