using SmartStore.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartStore.Models.Catalog
{
    public class Product
    {

        [Key, ScaffoldColumn(false), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string PictureThumnailUrl { get; set; }

        public bool NoThumb { get; set; }

        public int ProductTypeId { get; set; }

        public string ProductTypeName { get; set; }

        public string ProductTypeLabelHint { get; set; }

        public string ProductUrl { get; set; }

        public int AssociatedToProductId { get; set; }
        public string AssociatedToProductName { get; set; }

        public ProductVisibility Visibility { get; set; }

        public ProductCondition Condition { get; set; }

        [AllowHtml]
        public int ProductTemplateId { get; set; }
        public IList<ProductTemplate> AvailableProductTemplates { get; set; }

        [AllowHtml]
        public string Name { get; set; }

        [AllowHtml]
        public string ShortDescription { get; set; }

        [AllowHtml]
        public string FullDescription { get; set; }

        //[AllowHtml]
        //public string AdminComment { get; set; }

        //public bool ShowOnHomePage { get; set; }

        //public int HomePageDisplayOrder { get; set; }

        //[AllowHtml]
        //public string MetaKeywords { get; set; }

        //[AllowHtml]
        //public string MetaDescription { get; set; }

        //[AllowHtml]
        //public string MetaTitle { get; set; }

        //[AllowHtml]
        //public string SeName { get; set; }

        //public bool AllowCustomerReviews { get; set; }

        //public string[] ProductTags { get; set; }
        //public MultiSelectList AvailableProductTags { get; set; }

        [AllowHtml]
        public string Sku { get; set; }

        [AllowHtml]
        public string ManufacturerPartNumber { get; set; }

        [AllowHtml]
        public string Gtin { get; set; }

        public string CustomsTariffNumber { get; set; }

        public int? CountryOfOriginId { get; set; }
        public IList<SelectListItem> AvailableCountries { get; set; }

        public bool IsGiftCard { get; set; }

        public int GiftCardTypeId { get; set; }

        public bool RequireOtherProducts { get; set; }

        public string RequiredProductIds { get; set; }

        public bool AutomaticallyAddRequiredProducts { get; set; }

        public bool IsDownload { get; set; }

        [UIHint("Download")]
        public int? NewVersionDownloadId { get; set; }

        public string NewVersion { get; set; }

        //public List<DownloadVersion> DownloadVersions { get; set; }

        [UIHint("Download")]
        public int? DownloadId { get; set; }
        public string DownloadThumbUrl { get; set; }
        //public Download CurrentDownload { get; set; }

        public string DownloadFileVersion { get; set; }

        public bool UnlimitedDownloads { get; set; }

        public int MaxNumberOfDownloads { get; set; }

        public int? DownloadExpirationDays { get; set; }

        public int DownloadActivationTypeId { get; set; }

        public bool HasSampleDownload { get; set; }

        [UIHint("Download")]
        public int? SampleDownloadId { get; set; }

        public int? OldSampleDownloadId { get; set; }

        public bool HasUserAgreement { get; set; }

        [AllowHtml]
        public string UserAgreementText { get; set; }

        [AllowHtml]
        public string AddChangelog { get; set; }

        public bool IsRecurring { get; set; }

        public int RecurringCycleLength { get; set; }

        public int RecurringCyclePeriodId { get; set; }

        public int RecurringTotalCycles { get; set; }

        public bool IsShipEnabled { get; set; }

        public bool IsFreeShipping { get; set; }

        public decimal AdditionalShippingCharge { get; set; }

        public bool IsEsd { get; set; }

        public bool IsTaxExempt { get; set; }

        public int? TaxCategoryId { get; set; }
        public IList<SelectListItem> AvailableTaxCategories { get; set; }

        public int ManageInventoryMethodId { get; set; }
        public IList<SelectListItem> AvailableManageInventoryMethods { get; set; }

        public int StockQuantity { get; set; }
        public int OriginalStockQuantity { get; set; }

        public bool DisplayStockAvailability { get; set; }

        public bool DisplayStockQuantity { get; set; }

        public int MinStockQuantity { get; set; }

        public int LowStockActivityId { get; set; }

        public int NotifyAdminForQuantityBelow { get; set; }

        public int BackorderModeId { get; set; }

        public bool AllowBackInStockSubscriptions { get; set; }

        public int OrderMinimumQuantity { get; set; }

        public int OrderMaximumQuantity { get; set; }

        public int QuantityStep { get; set; }

        public QuantityControlType QuantiyControlType { get; set; }

        public bool HideQuantityControl { get; set; }

        public string AllowedQuantities { get; set; }

        public bool DisableBuyButton { get; set; }

        public bool DisableWishlistButton { get; set; }

        public bool AvailableForPreOrder { get; set; }

        public bool CallForPrice { get; set; }

        public decimal Price { get; set; }

        public decimal OldPrice { get; set; }

        public decimal ProductCost { get; set; }

        public decimal? SpecialPrice { get; set; }

        public DateTime? SpecialPriceStartDateTimeUtc { get; set; }

        public DateTime? SpecialPriceEndDateTimeUtc { get; set; }

        public bool CustomerEntersPrice { get; set; }

        public decimal MinimumCustomerEnteredPrice { get; set; }

        public decimal MaximumCustomerEnteredPrice { get; set; }

        public decimal Weight { get; set; }

        public decimal Length { get; set; }

        public decimal Width { get; set; }

        public decimal Height { get; set; }

        public DateTime? AvailableStartDateTimeUtc { get; set; }

        public DateTime? AvailableEndDateTimeUtc { get; set; }

        public bool Published { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public string BundleTitleText { get; set; }

        public bool BundlePerItemPricing { get; set; }

        public bool BundlePerItemShipping { get; set; }

        public bool BundlePerItemShoppingCart { get; set; }

        public AttributeChoiceBehaviour AttributeChoiceBehaviour { get; set; }

        public string PrimaryStoreCurrencyCode { get; set; }
        public string BaseDimensionIn { get; set; }
        public string BaseWeightIn { get; set; }

        //public IList<ProductLocalizedModel> Locales { get; set; }

        // ACL (customer roles).
        [UIHint("CustomerRoles")]
        [AdditionalMetadata("multiple", true)]
        public int[] SelectedCustomerRoleIds { get; set; }

        public bool SubjectToAcl { get; set; }

        // Store mapping.
        [UIHint("Stores")]
        [AdditionalMetadata("multiple", true)]
        public int[] SelectedStoreIds { get; set; }

        public bool LimitedToStores { get; set; }

        public int NumberOfAvailableCategories { get; set; }
        public int NumberOfAvailableManufacturers { get; set; }
        public int NumberOfAvailableProductAttributes { get; set; }

        //Pictures.
        public bool HasPreviewPicture { get; set; }
        //public ProductPictureModel AddPictureModel { get; set; }

        //public IList<ProductMediaFile> ProductMediaFiles { get; set; }

        [UIHint("Discounts")]
        [AdditionalMetadata("multiple", true)]
        //[AdditionalMetadata("discountType", DiscountType.AssignedToSkus)]
        public int[] SelectedDiscountIds { get; set; }


        //public CopyProductModel CopyProductModel { get; set; }

        //BasePrice
        public bool BasePriceEnabled { get; set; }

        public string BasePriceMeasureUnit { get; set; }

        public decimal? BasePriceAmount { get; set; }

        public int? BasePriceBaseAmount { get; set; }

        public IList<SelectListItem> AvailableMeasureWeights { get; set; }
        public IList<SelectListItem> AvailableMeasureUnits { get; set; }

        [UIHint("DeliveryTimes")]
        public int? DeliveryTimeId { get; set; }

        public int? QuantityUnitId { get; set; }
        public IList<SelectListItem> AvailableQuantityUnits { get; set; }

        public string ProductSelectCheckboxClass { get; set; }

        public bool IsSystemProduct { get; set; }
        public string SystemName { get; set; }

    }

}