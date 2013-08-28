// ListOfDataProviderSettingsConverter.cs

using Glimpse.Core.Extensibility;
using Glimpse.Core.Tab.Assist;
using System;
using Telerik.Sitefinity.Configuration;

namespace Glimpse.Sitefinity.SerializationConverter
{
    public sealed class ListOfDataProviderSettingsConverter : SerializationConverter<ConfigElementDictionary<string, DataProviderSettings>>
    {
        public override object Convert(ConfigElementDictionary<string, DataProviderSettings> obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");

            var root = new TabSection("Name", "Title", "Description", "Enabled", "Provider Type", "Parameters", "Resource Class ID");
            foreach (var value in obj.Values)
            {
                root
                    .AddRow()
                    .Column(value.Name)
                    .Column(value.Title)
                    .Column(value.Description)
                    .Column(value.Enabled)
                    .Column(value.ProviderType != null ? value.ProviderType.ToString() : "--")
                    .Column(value.Parameters)
                    .Column(value.ResourceClassId);
            }
            return root.Build();
        }
    }
}