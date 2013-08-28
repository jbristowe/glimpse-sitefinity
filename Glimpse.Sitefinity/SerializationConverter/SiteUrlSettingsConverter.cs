// SiteUrlSettingsConverter.cs

using Glimpse.Core.Extensibility;
using Glimpse.Core.Tab.Assist;
using System;
using Telerik.Sitefinity.Services;

namespace Glimpse.Sitefinity.SerializationConverter
{
    public sealed class SiteUrlSettingsConverter : SerializationConverter<SiteUrlSettings>
    {
        public override object Convert(SiteUrlSettings obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");

            var root = new TabObject();
            root.AddRow().Key("Host").Value(obj.Host);
            root.AddRow().Key("Non-Default Site URL Settings").Value(obj.EnableNonDefaultSiteUrlSettings);
            root.AddRow().Key("Non-Default HTTP Port").Value(obj.NonDefaultHttpPort);
            root.AddRow().Key("Non-Default HTTPS Port").Value(obj.NonDefaultHttpsPort);
            return root.Build();
        }
    }
}