using System;
using System.Collections.Generic;
using System.Reflection;

using Hangfire.Dashboard.Management.v2.Pages;
using Hangfire.Dashboard.Management.v2.Support;

namespace Hangfire.Dashboard.Management.v2
{
	public static class GlobalConfigurationExtension
	{
		public static void UseManagementPages(this IGlobalConfiguration config, Assembly assembly)
		{
			JobsHelper.GetAllJobs(assembly);
			CreateManagement();
		}
		public static void UseManagementPages(this IGlobalConfiguration config, Assembly[] assemblies)
		{
			foreach (var assembly in assemblies)
			{
				JobsHelper.GetAllJobs(assembly);
			}
			CreateManagement();
		}

		private static void CreateManagement()
		{
			GlobalConfigurationExtension.ReplaceCoreJs();
			var pageSet = new List<string>();
			foreach (var pageInfo in JobsHelper.Pages)
			{
				ManagementBasePage.AddCommands(pageInfo.MenuName);
				if (!pageSet.Contains(pageInfo.MenuName))
				{
					pageSet.Add(pageInfo.MenuName);
					ManagementSidebarMenu.Items.Add(p => new MenuItem(pageInfo.Title, p.Url.To($"{ManagementPage.UrlRoute}/{pageInfo.MenuName.ScrubURL()}")) {
						Active = p.RequestPath.StartsWith($"{ManagementPage.UrlRoute}/{pageInfo.MenuName.ScrubURL()}")
					});
				}

				DashboardRoutes.Routes.AddRazorPage($"{ManagementPage.UrlRoute}/{pageInfo.MenuName.ScrubURL()}", x => new ManagementBasePage(pageInfo.MenuName));
			}

			//note: have to use new here as the pages are dispatched and created each time. If we use an instance, the page gets duplicated on each call
			DashboardRoutes.Routes.AddRazorPage(ManagementPage.UrlRoute, x => new ManagementPage());

			// can't use the method of Hangfire.Console as it's usage overrides any similar usage here. Thus
			// we have to add our own endpoint to load it and call it from our code. Actually is a lot less work

			DashboardRoutes.Routes.Add($"{ManagementPage.UrlRoute}/jsmcss",
				new CombinedResourceDispatcher(
					"text/css",
					typeof(GlobalConfigurationExtension).GetTypeInfo().Assembly,
					$"{typeof(GlobalConfigurationExtension).Namespace}.Content", new[] { "Libraries.dateTimePicker.bootstrap-datetimepicker.min.css", "Libraries.inputmask.inputmask.min.css", "management.css" }
					)
				);
			DashboardRoutes.Routes.Add($"{ManagementPage.UrlRoute}/jsm",
				new CombinedResourceDispatcher(
					"application/javascript",
					typeof(GlobalConfigurationExtension).GetTypeInfo().Assembly,
					$"{typeof(GlobalConfigurationExtension).Namespace}.Content", new[] { "Libraries.dateTimePicker.bootstrap-datetimepicker.min.js", "Libraries.inputmask.jquery.inputmask.bundle.min.js", "management.js", "cron.js" }
					)
				);

			NavigationMenu.Items.Add(page => new MenuItem(ManagementPage.Title, page.Url.To(ManagementPage.UrlRoute)) {
				Active = page.RequestPath.StartsWith(ManagementPage.UrlRoute)
			});

		}


		public static void ReplaceCoreJs()
		{
			/*
			 *  "jquery-3.6.0.min.js",
            "bootstrap.min.js",
            "moment-with-locales.min.js",
            "Chart.min.js",
            "chartjs-plugin-streaming.min.js",
            "hangfire.js"
			 */
			DashboardRoutes.Routes.Replace($"/js[0-9]+",
				new CombinedResourceDispatcher(
					"application/javascript",
					typeof(GlobalConfigurationExtension).GetTypeInfo().Assembly,
					$"{typeof(GlobalConfigurationExtension).Namespace}.Content", new[] {
						"Core.jquery-3.6.0.min.js",
						"Core.bootstrap.min.js",
						"Core.moment-with-locales.min.js",
						"Core.Chart.min.js",
						"Core.chartjs-plugin-streaming.min.js",
						"Core.hangfire.js",
						"Core.hf-mycore.js"
					}
					)
				);
		}

		/// <summary>
		/// Replaces exising dispatcher for <paramref name="pathTemplate"/> with <paramref name="dispatcher"/>.
		/// If there's no dispatcher for the specified path, adds a new one.
		/// </summary>
		/// <param name="routes">Route collection</param>
		/// <param name="pathTemplate">Path template</param>
		/// <param name="dispatcher">Dispatcher to set for specified path</param>
		public static void Replace(this RouteCollection routes, string pathTemplate, IDashboardDispatcher dispatcher)
		{
			if (routes == null)
				throw new ArgumentNullException(nameof(routes));
			if (pathTemplate == null)
				throw new ArgumentNullException(nameof(pathTemplate));
			if (dispatcher == null)
				throw new ArgumentNullException(nameof(dispatcher));

			var list = routes.GetDispatchers();

			for (var i = 0; i < list.Count; i++)
			{
				var pair = list[i];
				if (pair.Item1 == pathTemplate)
				{
					list[i] = new Tuple<string, IDashboardDispatcher>(pair.Item1, dispatcher);
					return;
				}
			}

			routes.Add(pathTemplate, dispatcher);
		}

		/// <summary>
		/// Returns a private list of registered routes.
		/// </summary>
		/// <param name="routes">Route collection</param>
		private static List<Tuple<string, IDashboardDispatcher>> GetDispatchers(this RouteCollection routes)
		{
			if (routes == null)
				throw new ArgumentNullException(nameof(routes));

			return (List<Tuple<string, IDashboardDispatcher>>)_dispatchers.GetValue(routes);
		}

		private static readonly FieldInfo _dispatchers = typeof(RouteCollection).GetTypeInfo().GetDeclaredField(nameof(_dispatchers));

	}
}
