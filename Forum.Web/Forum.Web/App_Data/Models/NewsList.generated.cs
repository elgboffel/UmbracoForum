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
	/// <summary>Nyheder</summary>
	[PublishedContentModel("newsList")]
	public partial class NewsList : PublishedContentModel, ICompositionOpenGraph, ICompositionSeoChecker, ICompositionSimplePageHeader, ICompositionUmbracoProperties
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "newsList";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public NewsList(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<NewsList, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Layout
		///</summary>
		[ImplementPropertyType("layout")]
		public string Layout
		{
			get { return this.GetPropertyValue<string>("layout"); }
		}

		///<summary>
		/// #Description: #Description Description
		///</summary>
		[ImplementPropertyType("ogDescription")]
		public string OgDescription
		{
			get { return Umbraco.Web.PublishedContentModels.CompositionOpenGraph.GetOgDescription(this); }
		}

		///<summary>
		/// #Images: #Images Description
		///</summary>
		[ImplementPropertyType("ogImages")]
		public string OgImages
		{
			get { return Umbraco.Web.PublishedContentModels.CompositionOpenGraph.GetOgImages(this); }
		}

		///<summary>
		/// #Title: #Title Description
		///</summary>
		[ImplementPropertyType("ogTitle")]
		public string OgTitle
		{
			get { return Umbraco.Web.PublishedContentModels.CompositionOpenGraph.GetOgTitle(this); }
		}

		///<summary>
		/// #Type: #Type Description
		///</summary>
		[ImplementPropertyType("ogType")]
		public string OgType
		{
			get { return Umbraco.Web.PublishedContentModels.CompositionOpenGraph.GetOgType(this); }
		}

		///<summary>
		/// #Checker
		///</summary>
		[ImplementPropertyType("seoChecker")]
		public string SeoChecker
		{
			get { return Umbraco.Web.PublishedContentModels.CompositionSeoChecker.GetSeoChecker(this); }
		}

		///<summary>
		/// #Headline
		///</summary>
		[ImplementPropertyType("headline")]
		public string Headline
		{
			get { return Umbraco.Web.PublishedContentModels.CompositionSimplePageHeader.GetHeadline(this); }
		}

		///<summary>
		/// #Lead
		///</summary>
		[ImplementPropertyType("lead")]
		public string Lead
		{
			get { return Umbraco.Web.PublishedContentModels.CompositionSimplePageHeader.GetLead(this); }
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
