// Sitefinity.cs

using Glimpse.Core.Extensibility;
using Glimpse.Sitefinity.Model;
using System;

namespace Glimpse.Sitefinity.Tab
{
    public sealed class Sitefinity : TabBase, IDocumentation, ILayoutControl, IKey
    {
        public override object GetData(ITabContext context)
        {
            if (context == null) throw new ArgumentNullException("context");

            return SitefinityModel.GetSitefinityModel();
        }

        public bool KeysHeadings
        {
            get { return true; }
        }

        public string Key
        {
            get { return "sitefinity_configuration"; }
        }

        public override string Name
        {
            get { return "Sitefinity"; }
        }

        public string DocumentationUri
        {
            get { return "TBA"; }
        }
    }
}
