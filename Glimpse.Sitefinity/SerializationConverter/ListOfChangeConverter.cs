// ListOfChangeConverter.cs

using Glimpse.Core.Extensibility;
using Glimpse.Core.Tab.Assist;
using System;
using System.Collections.Generic;
using Telerik.Sitefinity.Security;
using Telerik.Sitefinity.Versioning.Model;

namespace Glimpse.Sitefinity.SerializationConverter
{
    public sealed class ListOfChangeConverter : SerializationConverter<IList<Change>>
    {
        public override object Convert(IList<Change> obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");

            var root = new TabSection("Version", "Change Type", "ID", "Application Name", "Comment", "Is Last Published Version", "Is Published Version", "Label", "Last Modified", "Owner");
            foreach (var change in obj)
            {
                root
                    .AddRow()
                    .Column(change.Version)
                    .Column(change.ChangeType)
                    .Column(change.Id)
                    .Column(change.ApplicationName)
                    .Column(change.Comment)
                    .Column(change.IsLastPublishedVersion)
                    .Column(change.IsPublishedVersion)
                    .Column(change.Label)
                    .Column(change.LastModified)
                    .Column(SecurityManager.GetUser(change.Owner).UserName);
            }
            return root.Build();
        }
    }
}