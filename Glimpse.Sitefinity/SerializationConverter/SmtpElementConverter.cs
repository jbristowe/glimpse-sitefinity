// SmtpElementConverter.cs

using Glimpse.Core.Extensibility;
using Glimpse.Core.Tab.Assist;
using System;
using Telerik.Sitefinity.Services;

namespace Glimpse.Sitefinity.SerializationConverter
{
    public sealed class SmtpElementConverter : SerializationConverter<SmtpElement>
    {
        public override object Convert(SmtpElement obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");

            var root = new TabObject();
            root.AddRow().Key("Host").Value(obj.Host);
            root.AddRow().Key("Pickup Directory").Value(obj.PickupDirectoryLocation);
            root.AddRow().Key("Username").Value(obj.UserName);
            root.AddRow().Key("Password").Value(obj.Password);
            root.AddRow().Key("Port").Value(obj.Port);
            root.AddRow().Key("Timeout").Value(obj.Timeout);
            root.AddRow().Key("Default Sender").Value(obj.DefaultSenderEmailAddress);
            root.AddRow().Key("Domain").Value(obj.Domain);
            root.AddRow().Key("Delivery Method").Value(obj.DeliveryMethod);
            root.AddRow().Key("SSL").Value(obj.EnableSSL);
            root.AddRow().Key("Subject Encoding").Value(obj.EmailSubjectEncoding);
            root.AddRow().Key("Body Encoding").Value(obj.EmailBodyEncoding);
            return root.Build();
        }
    }
}
