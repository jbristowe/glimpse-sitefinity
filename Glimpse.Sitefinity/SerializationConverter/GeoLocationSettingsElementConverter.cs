// GeoLocationSettingsElementConverter.cs

using Glimpse.Core.Extensibility;
using Glimpse.Core.Tab.Assist;
using System;
using Telerik.Sitefinity.GeoLocations.Configuration;

namespace Glimpse.Sitefinity.SerializationConverter
{
    public sealed class GeoLocationSettingsElementConverter : SerializationConverter<GeoLocationSettingsElement>
    {
        public override object Convert(GeoLocationSettingsElement obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");

            var root = new TabObject();
            root.AddRow().Key("Enable Geo-Location Search").Value(obj.EnableGeoLocationSearch);
            root.AddRow().Key("Google Map API v3 Key").Value(obj.GoogleMapApiV3Key);
            return root.Build();
        }
    }
}