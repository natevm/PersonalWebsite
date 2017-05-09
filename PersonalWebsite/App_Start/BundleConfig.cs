using System.Web;
using System.Web.Optimization;

namespace PersonalWebsite
{
	public class BundleConfig
	{
		// For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles)
		{
			/* jquery */
			bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
			          "~/Scripts/jquery/jquery-{version}.js"));

			/* angularjs */
			bundles.Add(new ScriptBundle("~/bundles/angularjs").Include(
								"~/Scripts/angular/angular.min.js",
								"~/Scripts/angular-animate/angular-animate.min.js",
								"~/Scripts/angular-aria/angular-aria.min.js",
								"~/Scripts/angular-messages/angular-messages.min.js",
								"~/Scripts/angular-material/angular-material.min.js"));

			bundles.Add(new StyleBundle("~/Content/css").Include(
								"~/Content/angular-material/angular-material.min.css",
								"~/Content/main.css",
								"~/Content/Sections/About Me/AboutMe.css"));
		}
	}
}
