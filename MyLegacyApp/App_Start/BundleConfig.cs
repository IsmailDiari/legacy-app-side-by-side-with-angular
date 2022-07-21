using MyLegacyApp.Extensions;
using System.Web.Optimization;

namespace MyLegacyApp
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.AddScripts();
            bundles.AddStyles();
        }
    }
}
