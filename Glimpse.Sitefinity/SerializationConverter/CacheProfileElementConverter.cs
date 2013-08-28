// CacheProfileElementConverter.cs

using Glimpse.Core.Extensibility;
using Glimpse.Core.Tab.Assist;
using System;
using Telerik.Sitefinity.Services.Configuration;

namespace Glimpse.Sitefinity.SerializationConverter
{
    public sealed class CacheProfileElementConverter : SerializationConverter<CacheProfileElement>
    {
        public override object Convert(CacheProfileElement obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");
            
            var root = new TabObject();
            root.AddRow().Key("Duration").Value(obj.Duration);
            root.AddRow().Key("Sliding Expiration").Value(obj.SlidingExpiration);
            return root.Build();
        }
    }
}