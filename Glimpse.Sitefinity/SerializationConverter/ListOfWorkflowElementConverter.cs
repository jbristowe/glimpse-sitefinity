// ListOfWorkflowElementConverter.cs

using Glimpse.Core.Extensibility;
using Glimpse.Core.Tab.Assist;
using System;
using Telerik.Sitefinity.Configuration;
using Telerik.Sitefinity.Workflow.Configuration;

namespace Glimpse.Sitefinity.SerializationConverter
{
    public sealed class ListOfWorkflowElementConverter : SerializationConverter<ConfigElementDictionary<string, WorkflowElement>>
    {
        public override object Convert(ConfigElementDictionary<string, WorkflowElement> obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");

            var root = new TabSection("Title", "Service URL", "Module Name", "Content Type", "Resource Class ID");
            foreach (var value in obj.Values)
            {
                root
                    .AddRow()
                    .Column(value.Title)
                    .Column(value.ServiceUrl)
                    .Column(value.ModuleName)
                    .Column(value.ContentType)
                    .Column(value.ResourceClassId);
            }
            return root.Build();
        }
    }
}