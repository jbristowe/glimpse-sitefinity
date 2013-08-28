// GuidConverter.cs

using Glimpse.Core.Extensibility;
using System;
using System.Globalization;

namespace Glimpse.Sitefinity.SerializationConverter
{
    public sealed class GuidConverter : SerializationConverter<Guid>
    {
        public override object Convert(Guid obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");

            return obj.ToString("D").ToUpper(CultureInfo.InvariantCulture);
        }
    }
}
