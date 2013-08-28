// LicenseElementConverter.cs

using Glimpse.Core.Extensibility;
using Glimpse.Core.Tab.Assist;
using System;
using Telerik.Sitefinity.Licensing.Configuration;

namespace Glimpse.Sitefinity.SerializationConverter
{
    public sealed class LicenseElementConverter : SerializationConverter<LicenseElement>
    {
        public override object Convert(LicenseElement obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");

            var root = new TabObject();
            root.AddRow().Key("License Service URL").Value(obj.LicenseServiceUrl);
            root.AddRow().Key("Service Connection TimeOut").Value(obj.ServiceConnectionTimeOut);
            return root.Build();
        }
    }
}