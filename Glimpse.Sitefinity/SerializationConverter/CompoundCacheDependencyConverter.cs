// CompoundCacheDependencyConverter.cs

using Glimpse.Core.Extensibility;
using Glimpse.Core.Tab.Assist;
using System;
using Telerik.Sitefinity.Data;

namespace Glimpse.Sitefinity.SerializationConverter
{
    public sealed class CompoundCacheDependencyConverter : SerializationConverter<CompoundCacheDependency>
    {
        public override object Convert(CompoundCacheDependency obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");

            var root = new TabObject();
            root.AddRow().Key("Cache Dependencies").Value(obj.CacheDependencies);
            return root.Build();
        }
    }
}