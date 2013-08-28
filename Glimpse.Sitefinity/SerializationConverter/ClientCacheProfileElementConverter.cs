// ClientCacheProfileElementConverter.cs

using Glimpse.Core.Extensibility;
using Glimpse.Core.Tab.Assist;
using System;
using Telerik.Sitefinity.Modules.Pages.Configuration;

namespace Glimpse.Sitefinity.SerializationConverter
{
    public sealed class ClientCacheProfileElementConverter : SerializationConverter<ClientCacheProfileElement>
    {
        public override object Convert(ClientCacheProfileElement obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");

            var root = new TabObject();
            root.AddRow().Key("Name").Value(obj.Name);
            root.AddRow().Key("Enabled").Value(obj.Enabled);
            root.AddRow().Key("Duration").Value(obj.Duration);
            return root.Build();
        }
    }
}
