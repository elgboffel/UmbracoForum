//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.7.99
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Mappe</summary>
	[PublishedContentModel("siteFolder")]
	public partial class SiteFolder : PublishedContentModel, ICompositionUmbracoProperties
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "siteFolder";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public SiteFolder(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<SiteFolder, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// #umbracoInternalRedirectId: #umbracoInternalRedirectId_desc
		///</summary>
		[ImplementPropertyType("umbracoInternalRedirectId")]
		public string UmbracoInternalRedirectId
		{
			get { return Umbraco.Web.PublishedContentModels.CompositionUmbracoProperties.GetUmbracoInternalRedirectId(this); }
		}

		///<summary>
		/// #umbracoNaviHide: #umbracoNaviHide_desc
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return Umbraco.Web.PublishedContentModels.CompositionUmbracoProperties.GetUmbracoNaviHide(this); }
		}

		///<summary>
		/// #umbracoRedirect: #umbracoRedirect_desc
		///</summary>
		[ImplementPropertyType("umbracoRedirect")]
		public string UmbracoRedirect
		{
			get { return Umbraco.Web.PublishedContentModels.CompositionUmbracoProperties.GetUmbracoRedirect(this); }
		}

		///<summary>
		/// #umbracoUrlAlias: #umbracoUrlAlias_desc
		///</summary>
		[ImplementPropertyType("umbracoUrlAlias")]
		public string UmbracoUrlAlias
		{
			get { return Umbraco.Web.PublishedContentModels.CompositionUmbracoProperties.GetUmbracoUrlAlias(this); }
		}

		///<summary>
		/// #umbracoUrlName: #umbracoUrlName_desc
		///</summary>
		[ImplementPropertyType("umbracoUrlName")]
		public string UmbracoUrlName
		{
			get { return Umbraco.Web.PublishedContentModels.CompositionUmbracoProperties.GetUmbracoUrlName(this); }
		}
	}
}
