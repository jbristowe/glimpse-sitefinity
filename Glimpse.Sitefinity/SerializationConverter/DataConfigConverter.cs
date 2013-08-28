// DataConfigConverter.cs

using Glimpse.Core.Extensibility;
using Glimpse.Core.Tab.Assist;
using System;
using Telerik.Sitefinity.Data.Configuration;

namespace Glimpse.Sitefinity.SerializationConverter
{
    public sealed class DataConfigConverter : SerializationConverter<DataConfig>
    {
        public override object Convert(DataConfig obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");

            var root = new TabObject();
            root.AddRow().Key("Connection Strings").Value(obj.ConnectionStrings);
            root.AddRow().Key("Database Mapping Options").Value(obj.DatabaseMappingOptions);
            root.AddRow().Key("Enable Data Caching").Value(obj.EnableDataCaching);
            root.AddRow().Key("GUID Generation Strategy").Value(obj.GuidGenerationStrategy);
            root.AddRow().Key("Incremental GUID Range").Value(obj.IncrementalGuidRange);
            root.AddRow().Key("Resolvers").Value(obj.Resolvers);
            root.AddRow().Key("URL Evaluators").Value(obj.UrlEvaluators);
            return root.Build();
        }
    }
}