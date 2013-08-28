// CacheManagerElementConverter.cs

using Glimpse.Core.Extensibility;
using Glimpse.Core.Tab.Assist;
using System;
using Telerik.Sitefinity.Services;

namespace Glimpse.Sitefinity.SerializationConverter
{
    public sealed class ServiciesPathsConverter : SerializationConverter<ServiciesPaths>
    {
        public override object Convert(ServiciesPaths obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");

            var root = new TabObject();
            root.AddRow().Key("Workflow Base URL").Value(obj.WorkflowBaseUrl);
            return root.Build();
        }
    }
}