// SystemConfigConverter.cs

using Glimpse.Core.Extensibility;
using Glimpse.Core.Tab.Assist;
using System;
using Telerik.Sitefinity.Services;

namespace Glimpse.Sitefinity.SerializationConverter
{
    public sealed class SystemConfigConverter : SerializationConverter<SystemConfig>
    {
        public override object Convert(SystemConfig obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");

            var root = new TabObject();
            root.AddRow().Key("Application Modules").Value(obj.ApplicationModules);
            root.AddRow().Key("Background Tasks").Value(obj.BackgroundTasks);
            root.AddRow().Key("Cache Dependency Handlers").Value(obj.CacheDependencyHandlers);
            root.AddRow().Key("Cache Managers").Value(obj.CacheManagers);
            root.AddRow().Key("Cache Settings").Value(obj.CacheSettings);
            root.AddRow().Key("Content Links Cache").Value(obj.ContentLinksCache);
            root.AddRow().Key("Content Locations Settings").Value(obj.ContentLocationsSettings);
            root.AddRow().Key("Control Designers").Value(obj.ControlDesigners);
            root.AddRow().Key("Disable Backend UI").Value(obj.DisableBackendUI);
            root.AddRow().Key("Files Module Configuration").Value(obj.FilesModuleConfig);
            root.AddRow().Key("Geo-Location Settings").Value(obj.GeoLocationSettings);
            root.AddRow().Key("Licensing").Value(obj.Licensing);
            root.AddRow().Key("Load Balancing Configuration").Value(obj.LoadBalancingConfig);
            root.AddRow().Key("Services Paths").Value(obj.ServicesPaths);
            root.AddRow().Key("Site URL Settings").Value(obj.SiteUrlSettings);
            root.AddRow().Key("SMTP Settings").Value(obj.SmtpSettings);
            root.AddRow().Key("System Services").Value(obj.SystemServices);
            root.AddRow().Key("Type Implementations Mapping").Value(obj.TypeImplementationsMapping);
            root.AddRow().Key("UI Time Zone Settings").Value(obj.UITimeZoneSettings);
            root.AddRow().Key("URL Shortener Settings").Value(obj.UrlShortenerSettings);
            root.AddRow().Key("Visible In UI").Value(obj.VisibleInUI);
            return root.Build();
        }
    }
}
