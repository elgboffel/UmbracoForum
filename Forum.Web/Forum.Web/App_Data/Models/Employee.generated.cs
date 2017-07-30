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
	/// <summary>Employee</summary>
	[PublishedContentModel("employee")]
	public partial class Employee : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "employee";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Employee(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Employee, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// #Department
		///</summary>
		[ImplementPropertyType("department")]
		public string Department
		{
			get { return this.GetPropertyValue<string>("department"); }
		}

		///<summary>
		/// #Image
		///</summary>
		[ImplementPropertyType("image")]
		public string Image
		{
			get { return this.GetPropertyValue<string>("image"); }
		}

		///<summary>
		/// #Mail
		///</summary>
		[ImplementPropertyType("mail")]
		public string Mail
		{
			get { return this.GetPropertyValue<string>("mail"); }
		}

		///<summary>
		/// #Mobile Phone
		///</summary>
		[ImplementPropertyType("mobilePhone")]
		public string MobilePhone
		{
			get { return this.GetPropertyValue<string>("mobilePhone"); }
		}

		///<summary>
		/// #Phone
		///</summary>
		[ImplementPropertyType("phone")]
		public string Phone
		{
			get { return this.GetPropertyValue<string>("phone"); }
		}

		///<summary>
		/// #Title
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return this.GetPropertyValue<string>("title"); }
		}
	}
}