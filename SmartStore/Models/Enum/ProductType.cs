using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartStore.Models.Enum
{
    public enum ProductType
    {
        /// <summary>
        /// Simple product
        /// </summary>
        SimpleProduct = 5,

        /// <summary>
        /// Grouped product
        /// </summary>
        GroupedProduct = 10,

        /// <summary>
        /// Bundled product
        /// </summary>
        BundledProduct = 15
    }
}