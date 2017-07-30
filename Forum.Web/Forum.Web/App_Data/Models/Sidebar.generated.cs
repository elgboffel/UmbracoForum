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
	// Mixin content Type 1099 with alias "sidebar"
	/// <summary>Sidebar</summary>
	public partial interface ISidebar : IPublishedContent
	{
		/// <summary>#Headline</summary>
		string SidebarHeadline { get; }

		/// <summary>Layout</summary>
		IEnumerable<IPublishedContent> SidebarLayout { get; }
	}

	/// <summary>Sidebar</summary>
	[PublishedContentModel("sidebar")]
	public partial class Sidebar : PublishedContentModel, ISidebar
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "sidebar";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Sidebar(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Sidebar, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// #Headline
		///</summary>
		[ImplementPropertyType("sidebarHeadline")]
		public string SidebarHeadline
		{
			get { return GetSidebarHeadline(this); }
		}

		/// <summary>Static getter for #Headline</summary>
		public static string GetSidebarHeadline(ISidebar that) { return that.GetPropertyValue<string>("sidebarHeadline"); }

		///<summary>
		/// Layout
		///</summary>
		[ImplementPropertyType("sidebarLayout")]
		public IEnumerable<IPublishedContent> SidebarLayout
		{
			get { return GetSidebarLayout(this); }
		}

		/// <summary>Static getter for Layout</summary>
		public static IEnumerable<IPublishedContent> GetSidebarLayout(ISidebar that) { return that.GetPropertyValue<IEnumerable<IPublishedContent>>("sidebarLayout"); }
	}
}
