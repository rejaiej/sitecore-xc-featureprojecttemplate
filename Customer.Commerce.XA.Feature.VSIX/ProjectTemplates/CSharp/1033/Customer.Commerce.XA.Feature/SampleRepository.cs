namespace $safeprojectname$.Repositories
{
    using Sitecore.Commerce.XA.Foundation.Common.Models;
    using Sitecore.Commerce.XA.Foundation.Common.Repositories;
    using Sitecore.Diagnostics;
    using Sitecore.XA.Foundation.SitecoreExtensions.Interfaces;

    using Models;

    public class $sampleRepositoryName$ : BaseCommerceModelRepository, $sampleIRepositoryName$
    {
        public $sampleRepositoryName$(
            IModelProvider modelProvider)
        {
            Assert.ArgumentNotNull(modelProvider, nameof(modelProvider));
            this.ModelProvider = modelProvider;
        }

        public IModelProvider ModelProvider { get; protected set; }

        public virtual $sampleRenderingModelName$ GetAllItems(
            IRendering rendering)
{
            $sampleRenderingModelName$ model = this.ModelProvider.GetModel<$sampleRenderingModelName$> ();
            this.Init(model);
            model.Initialize(rendering);
            return model;
        }
    }
}