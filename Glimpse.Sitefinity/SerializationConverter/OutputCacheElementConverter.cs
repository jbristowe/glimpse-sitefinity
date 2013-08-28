// OutputCacheElementConverter.cs

using Glimpse.Core.Extensibility;
using Glimpse.Core.Tab.Assist;
using System;
using Telerik.Sitefinity.Modules.Pages.Configuration;

namespace Glimpse.Sitefinity.SerializationConverter
{
    public sealed class OutputCacheElementConverter : SerializationConverter<OutputCacheElement>
    {
        public override object Convert(OutputCacheElement obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");

            var root = new TabSection("Client Profiles", "Default Client Profile", "Default Profile", "Enable Client Cache", "Enable Output Cache");
            root
                .AddRow()
                .Column(obj.ClientProfiles)
                .Column(obj.DefaultClientProfile)
                .Column(obj.DefaultProfile)
                .Column(obj.EnableClientCache)
                .Column(obj.EnableOutputCache);
            return root.Build();
        }
    }
}