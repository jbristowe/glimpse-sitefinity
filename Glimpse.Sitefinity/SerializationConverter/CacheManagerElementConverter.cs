// CacheManagerElementConverter.cs

using Glimpse.Core.Extensibility;
using Glimpse.Core.Tab.Assist;
using System;
using Telerik.Sitefinity.Services.Configuration;

namespace Glimpse.Sitefinity.SerializationConverter
{
    public sealed class CacheManagerElementConverter : SerializationConverter<CacheManagerElement>
    {
        public override object Convert(CacheManagerElement obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");
            
            var root = new TabObject();
            root.AddRow().Key("Backing Store").Value(obj.BackingStoreName);
            root.AddRow().Key("Cache Store").Value(obj.CacheStore.ToString());
            root.AddRow().Key("Name").Value(obj.Name);
            root.AddRow().Key("Poll Whether Items Are Expired Interval Seconds").Value(obj.PollWhetherItemsAreExpiredIntervalSeconds);
            root.AddRow().Key("Start Scavenging After Item Count").Value(obj.StartScavengingAfterItemCount);
            root.AddRow().Key("When Scavenging Remove Item Count").Value(obj.WhenScavengingRemoveItemCount);
            return root.Build();
        }
    }
}
