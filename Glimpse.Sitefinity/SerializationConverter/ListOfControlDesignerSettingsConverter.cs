// ListOfControlDesignerSettingsConverter.cs

using Glimpse.Core.Extensibility;
using Glimpse.Core.Tab.Assist;
using System;
using Telerik.Sitefinity.Configuration;
using Telerik.Sitefinity.Web.UI.ControlDesign;

namespace Glimpse.Sitefinity.SerializationConverter
{
    public sealed class ListOfControlDesignerSettingsConverter : SerializationConverter<ConfigElementDictionary<string, ControlDesignerSettings>>
    {
        public override object Convert(ConfigElementDictionary<string, ControlDesignerSettings> obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");

            var root = new TabSection("Control Designer", "Control Type");
            foreach (var value in obj.Values)
            {
                root
                    .AddRow()
                    .Column(value.ControlDesigner)
                    .Column(value.ControlType);
            }
            return root.Build();
        }
    }
}