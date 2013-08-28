// ListOfConnStringSettingsConverter.cs

using Glimpse.Core.Extensibility;
using Glimpse.Core.Tab.Assist;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using Telerik.Sitefinity.Configuration;
using Telerik.Sitefinity.Data.Configuration;

namespace Glimpse.Sitefinity.SerializationConverter
{
    public sealed class ListOfConnStringSettingsConverter : SerializationConverter<ConfigElementDictionary<string, ConnStringSettings>>
    {
        public override object Convert(ConfigElementDictionary<string, ConnStringSettings> obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");

            var root = new TabSection("Name", "Type", "Provider", "Connection String", "Details");
            foreach (var value in obj.Values)
            {
                var connectionDetails = new Dictionary<string, object>(StringComparer.InvariantCultureIgnoreCase);

                try
                {
                    var providerName = string.IsNullOrEmpty(value.ProviderName) ? "System.Data.SqlClient" : value.ProviderName;
                    var connectionFactory = DbProviderFactories.GetFactory(providerName);
                    var connectionStringBuilder = connectionFactory.CreateConnectionStringBuilder();
                    if (connectionStringBuilder != null)
                    {
                        connectionStringBuilder.ConnectionString = value.ConnectionString;

                        var keys = connectionStringBuilder.Keys;
                        if (keys != null)
                        {
                            foreach (string key in keys)
                            {
                                connectionDetails.Add(key, connectionStringBuilder[key]);
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e);
                }

                root
                    .AddRow()
                    .Column(value.Name)
                    .Column(value.DatabaseType)
                    .Column(value.ProviderName)
                    .Column(value.ConnectionString)
                    .Column(connectionDetails);
            }
            return root.Build();
        }
    }
}
