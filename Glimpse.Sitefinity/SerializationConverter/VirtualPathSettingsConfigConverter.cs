// VirtualPathSettingsConfigConverter.cs

using Glimpse.Core.Extensibility;
using Glimpse.Core.Tab.Assist;
using System;
using Telerik.Sitefinity.Abstractions.VirtualPath.Configuration;

namespace Glimpse.Sitefinity.SerializationConverter
{
    public sealed class VirtualPathSettingsConfigConverter : SerializationConverter<VirtualPathSettingsConfig>
    {
        public override object Convert(VirtualPathSettingsConfig obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");

            var root = new TabObject();
            root.AddRow().Key("Virtual Paths").Value(obj.VirtualPaths);
            return root.Build();
        }
    }
}