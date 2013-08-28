// ListOfCacheManagerElementConverter.cs

using Glimpse.Core.Extensibility;
using Glimpse.Core.Tab.Assist;
using System;
using Telerik.Sitefinity.Configuration;
using Telerik.Sitefinity.Services.Configuration;

namespace Glimpse.Sitefinity.SerializationConverter
{
    public sealed class ListOfCacheManagerElementConverter : SerializationConverter<ConfigElementDictionary<string, CacheManagerElement>>
    {
        public override object Convert(ConfigElementDictionary<string, CacheManagerElement> obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");

            var root = new TabSection("Name", "Backing Store", "Cache Store", "Poll Whether Items Are Expired Interval Seconds", "Start Scavenging After Item Count", "When Scavenging Remove Item Count");
            foreach (var value in obj.Values)
            {
                root
                    .AddRow()
                    .Column(value.Name)
                    .Column(value.BackingStoreName)
                    .Column(value.CacheStore)
                    .Column(value.PollWhetherItemsAreExpiredIntervalSeconds)
                    .Column(value.StartScavengingAfterItemCount)
                    .Column(value.WhenScavengingRemoveItemCount);
            }
            return root.Build();
        }
    }
}