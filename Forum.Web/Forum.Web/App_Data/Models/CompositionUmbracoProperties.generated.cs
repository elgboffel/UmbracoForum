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
	// Mixin content Type 1104 with alias "compositionUmbracoProperties"
	/// <summary>Umbraco Properties</summary>
	public partial interface ICompositionUmbracoProperties : IPublishedContent
	{
		/// <summary>#umbracoInternalRedirectId</summary>
		string UmbracoInternalRedirectId { get; }

		/// <summary>#umbracoNaviHide</summary>
		bool UmbracoNaviHide { get; }

		/// <summary>#umbracoRedirect</summary>
		string UmbracoRedirect { get; }

		/// <summary>#umbracoUrlAlias</summary>
		string UmbracoUrlAlias { get; }

		/// <summary>#umbracoUrlName</summary>
		string UmbracoUrlName { get; }
	}

	/// <summary>Umbraco Properties</summary>
	[PublishedContentModel("compositionUmbracoProperties")]
	public partial class CompositionUmbracoProperties : PublishedContentModel, ICompositionUmbracoProperties
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "compositionUmbracoProperties";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public CompositionUmbracoProperties(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<CompositionUmbracoProperties, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// #umbracoInternalRedirectId: #umbracoInternalRedirectId_desc
		///</summary>
		[ImplementPropertyType("umbracoInternalRedirectId")]
		public string UmbracoInternalRedirectId
		{
			get { return GetUmbracoInternalRedirectId(this); }
		}

		/// <summary>Static getter for #umbracoInternalRedirectId</summary>
		public static string GetUmbracoInternalRedirectId(ICompositionUmbracoProperties that) { return that.GetPropertyValue<string>("umbracoInternalRedirectId"); }

		///<summary>
		/// #umbracoNaviHide: #umbracoNaviHide_desc
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return GetUmbracoNaviHide(this); }
		}

		/// <summary>Static getter for #umbracoNaviHide</summary>
		public static bool GetUmbracoNaviHide(ICompositionUmbracoProperties that) { return that.GetPropertyValue<bool>("umbracoNaviHide"); }

		///<summary>
		/// #umbracoRedirect: #umbracoRedirect_desc
		///</summary>
		[ImplementPropertyType("umbracoRedirect")]
		public string UmbracoRedirect
		{
			get { return GetUmbracoRedirect(this); }
		}

		/// <summary>Static getter for #umbracoRedirect</summary>
		public static string GetUmbracoRedirect(ICompositionUmbracoProperties that) { return that.GetPropertyValue<string>("umbracoRedirect"); }

		///<summary>
		/// #umbracoUrlAlias: #umbracoUrlAlias_desc
		///</summary>
		[ImplementPropertyType("umbracoUrlAlias")]
		public string UmbracoUrlAlias
		{
			get { return GetUmbracoUrlAlias(this); }
		}

		/// <summary>Static getter for #umbracoUrlAlias</summary>
		public static string GetUmbracoUrlAlias(ICompositionUmbracoProperties that) { return that.GetPropertyValue<string>("umbracoUrlAlias"); }

		///<summary>
		/// #umbracoUrlName: #umbracoUrlName_desc
		///</summary>
		[ImplementPropertyType("umbracoUrlName")]
		public string UmbracoUrlName
		{
			get { return GetUmbracoUrlName(this); }
		}

		/// <summary>Static getter for #umbracoUrlName</summary>
		public static string GetUmbracoUrlName(ICompositionUmbracoProperties that) { return that.GetPropertyValue<string>("umbracoUrlName"); }
	}
}