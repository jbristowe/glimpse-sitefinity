// ContentLocationsSettingsElementConverter.cs

using Glimpse.Core.Extensibility;
using Glimpse.Core.Tab.Assist;
using System;
using Telerik.Sitefinity.Services.Configuration;

namespace Glimpse.Sitefinity.SerializationConverter
{
    public sealed class ContentLocationsSettingsElementConverter : SerializationConverter<ContentLocationsSettingsElement>
    {
        public override object Convert(ContentLocationsSettingsElement obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");

            var root = new TabObject();
            root.AddRow().Key("Disable Canonical URLs").Value(obj.DisableCanonicalUrls);
            return root.Build();
        }
    }
}