// ListOfClientCacheProfileElementConverter.cs

using Glimpse.Core.Extensibility;
using Glimpse.Core.Tab.Assist;
using System;
using Telerik.Sitefinity.Configuration;
using Telerik.Sitefinity.Modules.Pages.Configuration;

namespace Glimpse.Sitefinity.SerializationConverter
{
    public sealed class ListOfClientCacheProfileElementConverter : SerializationConverter<ConfigElementDictionary<string, ClientCacheProfileElement>>
    {
        public override object Convert(ConfigElementDictionary<string, ClientCacheProfileElement> obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");

            var root = new TabSection("Name", "Enabled", "Duration");
            foreach (var value in obj.Values)
            {
                root
                    .AddRow()
                    .Column(value.Name)
                    .Column(value.Enabled)
                    .Column(value.Duration);
            }
            return root.Build();
        }
    }
}