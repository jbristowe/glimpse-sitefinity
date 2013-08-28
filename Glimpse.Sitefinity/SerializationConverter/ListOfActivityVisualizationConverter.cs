// ListOfActivityVisualizationConverter.cs

using Glimpse.Core.Extensibility;
using Glimpse.Core.Tab.Assist;
using System;
using Telerik.Sitefinity.Configuration;
using Telerik.Sitefinity.Workflow.Configuration;

namespace Glimpse.Sitefinity.SerializationConverter
{
    public sealed class ListOfActivityVisualizationConverter : SerializationConverter<ConfigElementDictionary<string, ActivityVisualization>>
    {
        public override object Convert(ConfigElementDictionary<string, ActivityVisualization> obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");

            var root = new TabSection("Activity Type", "Visible");
            foreach (var value in obj.Values)
            {
                root
                    .AddRow()
                    .Column(value.ActivityType)
                    .Column(value.Visible);
            }
            return root.Build();
        }
    }
}