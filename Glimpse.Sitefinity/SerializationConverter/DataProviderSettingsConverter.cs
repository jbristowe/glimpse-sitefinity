// DataProviderSettingsConverter.cs

using Glimpse.Core.Extensibility;
using Glimpse.Core.Tab.Assist;
using System;
using Telerik.Sitefinity.Configuration;

namespace Glimpse.Sitefinity.SerializationConverter
{
    public sealed class DataProviderSettingsConverter : SerializationConverter<DataProviderSettings>
    {
        public override object Convert(DataProviderSettings obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");

            var root = new TabObject();
            root.AddRow().Key("Description").Value(obj.Description);
            root.AddRow().Key("Enabled").Value(obj.Enabled);
            root.AddRow().Key("Name").Value(obj.Name);
            root.AddRow().Key("Parameters").Value(obj.Parameters);
            root.AddRow().Key("ProviderType").Value(obj.ProviderType.ToString());
            root.AddRow().Key("Resource Class ID").Value(obj.ResourceClassId);
            root.AddRow().Key("Title").Value(obj.Title);
            return root.Build();
        }
    }
}
