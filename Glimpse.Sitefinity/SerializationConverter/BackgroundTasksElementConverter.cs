// BackgroundTasksElementConverter.cs

using Glimpse.Core.Extensibility;
using Glimpse.Core.Tab.Assist;
using System;
using Telerik.Sitefinity.BackgroundTasks.Configuration;

namespace Glimpse.Sitefinity.SerializationConverter
{
    public sealed class BackgroundTasksElementConverter : SerializationConverter<BackgroundTasksElement>
    {
        public override object Convert(BackgroundTasksElement obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");

            var root = new TabObject();
            root.AddRow().Key("Max Background Parallel Tasks Per Node").Value(obj.MaxBackgroundParallelTasksPerNode);
            root.AddRow().Key("Wait Before Abort Tasks").Value(obj.WaitBeforeAbortTasks);
            return root.Build();
        }
    }
}