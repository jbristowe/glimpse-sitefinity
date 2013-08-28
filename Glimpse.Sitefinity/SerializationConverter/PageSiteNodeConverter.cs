// PageSiteNodeConverter.cs

using Glimpse.Core.Extensibility;
using Glimpse.Core.Tab.Assist;
using System;
using Telerik.Sitefinity.Versioning;
using Telerik.Sitefinity.Web;

namespace Glimpse.Sitefinity.SerializationConverter
{
    public sealed class PageSiteNodeConverter : SerializationConverter<PageSiteNode>
    {
        public override object Convert(PageSiteNode obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");

            var root = new TabObject();
            root.AddRow().Key("Additional URLs Redirect To Default").Value(obj.AdditionalUrlsRedirectToDefault);
            root.AddRow().Key("Allow Parameters Validation").Value(obj.AllowParametersValidation);
            root.AddRow().Key("Attributes").Value(obj.Attributes);
            root.AddRow().Key("Available Languages").Value(obj.AvailableLanguages);
            root.AddRow().Key("Cache Dependency").Value(obj.CacheDependency);
            root.AddRow().Key("Cache Key").Value(obj.CacheKey);
            root.AddRow().Key("Crawlable").Value(obj.Crawlable);
            root.AddRow().Key("Denied Roles").Value(obj.DeniedRoles);
            root.AddRow().Key("Description").Value(obj.Description);
            root.AddRow().Key("Extension").Value(obj.Extension);
            root.AddRow().Key("Framework").Value(obj.Framework);
            root.AddRow().Key("ID").Value(obj.Id);
            root.AddRow().Key("Is Backend").Value(obj.IsBackend);
            root.AddRow().Key("Linked Node ID").Value(obj.LinkedNodeId);
            root.AddRow().Key("Linked Node Provider").Value(obj.LinkedNodeProvider);
            root.AddRow().Key("Localization Strategy").Value(obj.LocalizationStrategy.ToString());
            root.AddRow().Key("Node Type").Value(obj.NodeType);
            root.AddRow().Key("Ordinal").Value(obj.Ordinal);
            root.AddRow().Key("Output Cache Profile").Value(obj.OutputCacheProfile);
            root.AddRow().Key("Page ID").Value(obj.PageId);
            root.AddRow().Key("Page Links IDs").Value(obj.PageLinksIds);
            root.AddRow().Key("Page Provider Name").Value(obj.PageProviderName);
            root.AddRow().Key("Parent Key").Value(obj.ParentKey.ToUpper());
            root.AddRow().Key("Published Translations").Value(obj.PublishedTranslations);
            root.AddRow().Key("Redirect URL").Value(obj.RedirectUrl);
            root.AddRow().Key("Render As Link").Value(obj.RenderAsLink);
            root.AddRow().Key("Show In Navigation").Value(obj.ShowInNavigation);
            root.AddRow().Key("Status").Value(obj.Status);
            root.AddRow().Key("Theme").Value(obj.Theme);
            root.AddRow().Key("Title").Value(obj.Title);
            root.AddRow().Key("UI Culture").Value(obj.UiCulture);
            root.AddRow().Key("URL").Value(obj.Url);
            root.AddRow().Key("URL Evaluation Mode").Value(obj.UrlEvaluationMode);
            root.AddRow().Key("URL Name").Value(obj.UrlName);
            root.AddRow().Key("URL Without Extension").Value(obj.UrlWithoutExtension);
            root.AddRow().Key("Version History").Value(VersionManager.GetManager().GetItemVersionHistory(obj.PageId));
            root.AddRow().Key("Visible").Value(obj.Visible);
            return root.Build();
        }
    }
}