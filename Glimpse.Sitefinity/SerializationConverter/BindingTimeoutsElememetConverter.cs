// BindingTimeoutsElememetConverter.cs

using Glimpse.Core.Extensibility;
using Glimpse.Core.Tab.Assist;
using System;
using Telerik.Sitefinity.Workflow.Configuration;

namespace Glimpse.Sitefinity.SerializationConverter
{
    public sealed class BindingTimeoutsElememetConverter : SerializationConverter<BindingTimeoutsElememet>
    {
        public override object Convert(BindingTimeoutsElememet obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");

            var root = new TabObject();
            root.AddRow().Key("All Properties Timeout Default Value").Value(obj.AllPropertiesTimeoutDefaultValue);
            root.AddRow().Key("Close Timeout").Value(obj.CloseTimeout);
            root.AddRow().Key("Open Timeout").Value(obj.OpenTimeout);
            root.AddRow().Key("Receive Timeout").Value(obj.ReceiveTimeout);
            root.AddRow().Key("Send Timeout").Value(obj.SendTimeout);
            return root.Build();
        }
    }
}