using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SmartStore.Models.Catalog
{
    public class ProductReviewHelpfulness
    {
        /// <summary>
        /// Gets or sets the product review identifier.
        /// </summary>

        [Key, ScaffoldColumn(false), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductReviewId { get; set; }

        /// <summary>
        /// A value indicating whether a review is helpful.
        /// </summary>
        public bool WasHelpful { get; set; }

        /// <summary>
        /// Gets the product review.
        /// </summary>
        public virtual ProductReview ProductReview { get; set; }
    }
}