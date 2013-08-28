// SitefinityModelConverter.cs

using Glimpse.Core.Extensibility;
using Glimpse.Core.Tab.Assist;
using Glimpse.Sitefinity.Model;
using System;

namespace Glimpse.Sitefinity.SerializationConverter
{
    public sealed class SitefinityModelConverter : SerializationConverter<SitefinityModel>
    {
        public override object Convert(SitefinityModel obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");

            var root = new TabObject();
            root.AddRow().Key("System Configuration").Value(obj.SystemConfig);
            //root.AddRow().Key("Search Configuration").Value(obj.SearchConfig);
            root.AddRow().Key("Data Configuration").Value(obj.DataConfig);
            root.AddRow().Key("Virtual Path Settings Configuration").Value(obj.VirtualPathSettingsConfig);
            root.AddRow().Key("Workflow Configuration").Value(obj.WorkflowConfig);
            root.AddRow().Key("Page").Value(obj.PageSiteNode);
            return root.Build();
        }
    }
}