// ListOfVirtualPathElementConverter.cs

using Glimpse.Core.Extensibility;
using Glimpse.Core.Tab.Assist;
using System;
using Telerik.Sitefinity.Abstractions.VirtualPath.Configuration;
using Telerik.Sitefinity.Configuration;

namespace Glimpse.Sitefinity.SerializationConverter
{
    public sealed class ListOfVirtualPathElementConverter : SerializationConverter<ConfigElementDictionary<string, VirtualPathElement>>
    {
        public override object Convert(ConfigElementDictionary<string, VirtualPathElement> obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");

            var root = new TabSection("Virtual Path", "Resolver Name", "Resolver Location", "Resolver Type", "Parameters");
            foreach (var value in obj.Values)
            {
                root
                    .AddRow()
                    .Column(value.VirtualPath)
                    .Column(value.ResolverName)
                    .Column(value.ResourceLocation)
                    .Column(value.ResolverType)
                    .Column(value.Parameters);
            }
            return root.Build();
        }
    }
}
