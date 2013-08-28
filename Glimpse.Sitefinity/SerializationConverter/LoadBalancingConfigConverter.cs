// LoadBalancingConfigConverter.cs

using Glimpse.Core.Extensibility;
using Glimpse.Core.Tab.Assist;
using System;
using Telerik.Sitefinity.Services;

namespace Glimpse.Sitefinity.SerializationConverter
{
    public sealed class LoadBalancingConfigConverter : SerializationConverter<LoadBalancingConfig>
    {
        public override object Convert(LoadBalancingConfig obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");

            var root = new TabObject();
            root.AddRow().Key("Disable Host Headers").Value(obj.DisableHostHeaders);
            root.AddRow().Key("Handlers").Value(obj.Handlers);
            root.AddRow().Key("MSMQ Settings").Value(obj.MsmqSettings);
            root.AddRow().Key("Senders").Value(obj.Senders);
            root.AddRow().Key("URLs").Value(obj.URLS);
            return root.Build();
        }
    }
}