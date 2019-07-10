namespace $safeprojectname$.Controllers
{
    using System.Web.Mvc;
    using System.Web.SessionState;

    using Sitecore.Commerce.XA.Foundation.Common.Attributes;
    using Sitecore.Commerce.XA.Foundation.Common.Context;
    using Sitecore.Commerce.XA.Foundation.Common.Controllers;
    using Sitecore.Commerce.XA.Foundation.Common.Models;
    using Sitecore.Diagnostics;

    using Repositories;

    public class $sampleControllerName$ : BaseCommerceStandardController
    {
        public $sampleControllerName$(
            IStorefrontContext storefrontContext,
            IContext sitecoreContext,
            IModelProvider modelProvider,
            $sampleIRepositoryName$ sampleRepository)
          : base(storefrontContext, sitecoreContext)
        {
            Assert.ArgumentNotNull(modelProvider, nameof(modelProvider));
            Assert.ArgumentNotNull(sampleRepository, nameof(sampleRepository));

            this.ModelProvider = modelProvider;
            this.SampleRepository = sampleRepository;
        }

        public IModelProvider ModelProvider { get; protected set; }

        public $sampleIRepositoryName$ SampleRepository { get; protected set; }

        [StorefrontSessionState(SessionStateBehavior.ReadOnly)]
        public ActionResult GetAllItems()
        {
            return this.View(this.Rendering.RenderingViewPath, this.SampleRepository.GetAllItems(this.Rendering));
        }
    }
}