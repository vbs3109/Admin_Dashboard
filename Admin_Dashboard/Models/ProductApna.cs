using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Admin_Dashboard.Models
{
    [Table("Product_Apna")]
    public partial class ProductApna
    {
        [Key]
        [Column("Product_Id")]
        public int ProductId { get; set; }
        [Required]

        [Column("Product_Name")]
        [StringLength(50)]

        public string ProductName { get; set; }
        [Required]
        [Column("Product_Categ")]
        [StringLength(50)]

        public string ProductCateg { get; set; }
        [Required]
        [Column("Product_ExpiryDate")]
        [StringLength(50)]

        public string ProductExpiryDate { get; set; }
        [Required]
        [Column("Product_Quility")]

        [StringLength(50)]
        public string ProductQuility { get; set; }
        [Required]

        [Column("Product_No_of_Stock")]
        [StringLength(50)]
        public string ProductNoOfStock { get; set; }
    }
}
