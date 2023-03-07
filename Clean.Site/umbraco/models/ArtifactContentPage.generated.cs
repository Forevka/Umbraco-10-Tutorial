//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v11.2.0+cf1cd51
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Umbraco.Cms.Web.Common.PublishedModels
{
	/// <summary>Artifact Content Page</summary>
	[PublishedModel("artifactContentPage")]
	public partial class ArtifactContentPage : PublishedContentModel, IContentProperties, IReadAlsoProperties, IVisibilityProperties
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.2.0+cf1cd51")]
		public new const string ModelTypeAlias = "artifactContentPage";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.2.0+cf1cd51")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.2.0+cf1cd51")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.2.0+cf1cd51")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<ArtifactContentPage, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public ArtifactContentPage(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Circlet Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.2.0+cf1cd51")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("circletDescription")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString CircletDescription => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "circletDescription");

		///<summary>
		/// Circlet Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.2.0+cf1cd51")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("circletImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops CircletImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "circletImage");

		///<summary>
		/// Flower Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.2.0+cf1cd51")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("flowerDescription")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString FlowerDescription => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "flowerDescription");

		///<summary>
		/// Flower Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.2.0+cf1cd51")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("flowerImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops FlowerImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "flowerImage");

		///<summary>
		/// Goblet Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.2.0+cf1cd51")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("gobletDescription")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString GobletDescription => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "gobletDescription");

		///<summary>
		/// Goblet Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.2.0+cf1cd51")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("gobletImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops GobletImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "gobletImage");

		///<summary>
		/// Plume Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.2.0+cf1cd51")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("plumeDescription")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString PlumeDescription => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "plumeDescription");

		///<summary>
		/// Plume Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.2.0+cf1cd51")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("plumeImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops PlumeImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "plumeImage");

		///<summary>
		/// Rarity
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.2.0+cf1cd51")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("rarity")]
		public virtual global::System.Collections.Generic.IEnumerable<string> Rarity => this.Value<global::System.Collections.Generic.IEnumerable<string>>(_publishedValueFallback, "rarity");

		///<summary>
		/// Sands Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.2.0+cf1cd51")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("sandsDescription")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString SandsDescription => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "sandsDescription");

		///<summary>
		/// Sands Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.2.0+cf1cd51")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("sandsImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops SandsImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "sandsImage");

		///<summary>
		/// Set bonus four pieces: Bonus that set gives when 4 pieces equiped
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.2.0+cf1cd51")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("setBonusFourPieces")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString SetBonusFourPieces => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "setBonusFourPieces");

		///<summary>
		/// Set bonus two pieces: Bonus that set gives when 2 pieces equiped
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.2.0+cf1cd51")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("setBonusTwoPieces")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString SetBonusTwoPieces => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "setBonusTwoPieces");

		///<summary>
		/// Set name: Name of the artifact set
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.2.0+cf1cd51")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("setName")]
		public virtual string SetName => this.Value<string>(_publishedValueFallback, "setName");

		///<summary>
		/// Main Content: Enter the main content rows for this page
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.2.0+cf1cd51")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("mainContent")]
		public virtual global::Umbraco.Cms.Core.Models.Blocks.BlockListModel MainContent => global::Umbraco.Cms.Web.Common.PublishedModels.ContentProperties.GetMainContent(this, _publishedValueFallback);

		///<summary>
		/// Main Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.2.0+cf1cd51")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("mainImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops MainImage => global::Umbraco.Cms.Web.Common.PublishedModels.ContentProperties.GetMainImage(this, _publishedValueFallback);

		///<summary>
		/// Tags: Tags list
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.2.0+cf1cd51")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("tags")]
		public virtual global::System.Collections.Generic.IEnumerable<string> Tags => global::Umbraco.Cms.Web.Common.PublishedModels.ContentProperties.GetTags(this, _publishedValueFallback);

		///<summary>
		/// List of content: List of articles to show in "read also" part
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.2.0+cf1cd51")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("listOfContent")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent> ListOfContent => global::Umbraco.Cms.Web.Common.PublishedModels.ReadAlsoProperties.GetListOfContent(this, _publishedValueFallback);

		///<summary>
		/// Hide: Set this to true if you want to hide this page from the main navigation and from search results. sitemaps and general list pages.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "11.2.0+cf1cd51")]
		[ImplementPropertyType("umbracoNaviHide")]
		public virtual bool UmbracoNaviHide => global::Umbraco.Cms.Web.Common.PublishedModels.VisibilityProperties.GetUmbracoNaviHide(this, _publishedValueFallback);
	}
}
