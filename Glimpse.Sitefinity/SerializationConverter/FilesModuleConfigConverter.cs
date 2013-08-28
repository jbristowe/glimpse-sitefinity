// FilesModuleConfigConverter.cs

using Glimpse.Core.Extensibility;
using Glimpse.Core.Tab.Assist;
using System;
using Telerik.Sitefinity.Modules.Files.Configuration;

namespace Glimpse.Sitefinity.SerializationConverter
{
    public sealed class FilesModuleConfigConverter : SerializationConverter<FilesModuleConfig>
    {
        public override object Convert(FilesModuleConfig obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");

            var root = new TabObject();
            root.AddRow().Key("Max File Size").Value(obj.MaxFileSize);
            return root.Build();
        }
    }
}