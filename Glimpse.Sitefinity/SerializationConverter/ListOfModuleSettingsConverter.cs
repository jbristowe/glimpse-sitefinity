// ListOfModuleSettingsConverter.cs

using Glimpse.Core.Extensibility;
using Glimpse.Core.Tab.Assist;
using System;
using Telerik.Sitefinity.Configuration;
using Telerik.Sitefinity.Services;

namespace Glimpse.Sitefinity.SerializationConverter
{
    public sealed class ListOfModuleSettingsConverter : SerializationConverter<ConfigElementDictionary<string, ModuleSettings>>
    {
        public override object Convert(ConfigElementDictionary<string, ModuleSettings> obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");

            var root = new TabSection("Name", "Title", "Startup Type", "Description", "Parameters", "Version", "Type", "Module ID", "Resource Class ID");
            foreach (var value in obj.Values)
            {
                root
                    .AddRow()
                    .Column(value.Title)
                    .Column(value.Name)
                    .Column(value.StartupType.ToString())
                    .Column(value.Description)
                    .Column(value.Parameters)
                    .Column(value.Version != null ? value.Version.ToString() : "--")
                    .Column(value.Type)
                    .Column(value.ModuleId)
                    .Column(value.ResourceClassId);
            }
            return root.Build();
        }
    }
}