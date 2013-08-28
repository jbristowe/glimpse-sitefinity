// SitefinityModel.cs

using System;
using Telerik.Sitefinity.Abstractions.VirtualPath.Configuration;
using Telerik.Sitefinity.Configuration;
using Telerik.Sitefinity.Data.Configuration;
using Telerik.Sitefinity.Services;
//using Telerik.Sitefinity.Services.Search.Configuration;
using Telerik.Sitefinity.Web;
using Telerik.Sitefinity.Workflow.Configuration;

namespace Glimpse.Sitefinity.Model
{
    public sealed class SitefinityModel
    {
        public SystemConfig SystemConfig { get; set; }
        public DataConfig DataConfig { get; set; }
        public VirtualPathSettingsConfig VirtualPathSettingsConfig { get; set; }
        public WorkflowConfig WorkflowConfig { get; set; }
        public PageSiteNode PageSiteNode { get; set; }

        public static SitefinityModel GetSitefinityModel()
        {
            var systemConfiguration = Config.Get<SystemConfig>();
            if (systemConfiguration == null) return new SitefinityModel();

            var node = SiteMapBase.GetActualCurrentNode();
            if (node == null) return new SitefinityModel();

            var sitefinityModel = new SitefinityModel
            {
                SystemConfig = systemConfiguration,
                //SearchConfig = Config.Get<SearchConfig>(),
                DataConfig = Config.Get<DataConfig>(),
                VirtualPathSettingsConfig = Config.Get<VirtualPathSettingsConfig>(),
                WorkflowConfig = Config.Get<WorkflowConfig>(),
                PageSiteNode = node
            };

            return sitefinityModel;
        }
    }
}