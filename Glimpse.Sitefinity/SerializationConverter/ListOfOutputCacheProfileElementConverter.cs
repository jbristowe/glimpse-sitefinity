// ListOfOutputCacheProfileElementConverter.cs

using Glimpse.Core.Extensibility;
using Glimpse.Core.Tab.Assist;
using System;
using Telerik.Sitefinity.Configuration;
using Telerik.Sitefinity.Modules.Pages.Configuration;

namespace Glimpse.Sitefinity.SerializationConverter
{
    public sealed class ListOfOutputCacheProfileElementConverter : SerializationConverter<ConfigElementDictionary<string, OutputCacheProfileElement>>
    {
        public override object Convert(ConfigElementDictionary<string, OutputCacheProfileElement> obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");

            var root = new TabSection("Name", "Enabled", "Duration", "MaxSize", "SlidingExpiration");
            foreach (var value in obj.Values)
            {
                root
                    .AddRow()
                    .Column(value.Name)
                    .Column(value.Enabled)
                    .Column(value.Duration)
                    .Column(value.MaxSize)
                    .Column(value.SlidingExpiration);
            }
            return root.Build();
        }
    }
}
