// WorkflowConfigConverter.cs

using Glimpse.Core.Extensibility;
using Glimpse.Core.Tab.Assist;
using System;
using Telerik.Sitefinity.Workflow.Configuration;

namespace Glimpse.Sitefinity.SerializationConverter
{
    public sealed class WorkflowConfigConverter : SerializationConverter<WorkflowConfig>
    {
        public override object Convert(WorkflowConfig obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");

            var root = new TabObject();
            root.AddRow().Key("Workflows").Value(obj.Workflows);
            root.AddRow().Key("Binding Timeouts").Value(obj.BindingTimeouts);
            root.AddRow().Key("Default Provider").Value(obj.DefaultProvider);
            root.AddRow().Key("Providers").Value(obj.Providers);
            root.AddRow().Key("Use External Endpoint On Windows Azure").Value(obj.UseExternalEndpointOnWindowsAzure);
            root.AddRow().Key("Windows Azure External Endpoint Binding Timeouts").Value(obj.WindowsAzureExternalEndpointBindingTimeouts);
            root.AddRow().Key("Visualizations").Value(obj.Visualizations);
            return root.Build();
        }
    }
}