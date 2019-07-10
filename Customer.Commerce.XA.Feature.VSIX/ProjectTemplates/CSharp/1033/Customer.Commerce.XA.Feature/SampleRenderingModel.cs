namespace $safeprojectname$.Models
{
    using System.Collections.Generic;
    using System.Linq;

    using Sitecore.Commerce.XA.Foundation.Common.Models;
    using Sitecore.Diagnostics;
    using Sitecore.XA.Foundation.SitecoreExtensions.Interfaces;

    public class $sampleRenderingModelName$ : BaseCommerceRenderingModel
    {
        public IList<string> Items { get; set; }

        public virtual void Initialize(IRendering rendering)
        {
            Assert.IsNotNull(rendering, $"$safeprojectname$.Models.$sampleRenderingModelName$.Initialize: Parameter {nameof(rendering)} cannot be null.");

            this.Items = new List<string>()
            {
                "Item1",
                "Item2",
                "Item3"
            };
        }
    }
}