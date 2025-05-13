using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyptourProject.DAL.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        
        [Required(ErrorMessage = "Please select a category")]
        public string ProductCategory { get; set; }


        [Required(ErrorMessage = "Quantity is required")]
        [Range(1, long.MaxValue, ErrorMessage = "Quantity must be a positive number")]
        public long ProductQuantity { get; set; }


        [Required(ErrorMessage = "Title is required")]
        [StringLength(50, ErrorMessage = "Title cannot exceed 50 characters")]
        public string ProductTitle { get; set; }

        
        [Required(ErrorMessage = "Description is required")]
        [StringLength(500, MinimumLength = 20, ErrorMessage = "Description must be between 20 and 500 characters")]
        public string ProductDescription { get; set; }

        
        [Required(ErrorMessage = "Price is required")]
        [Column(TypeName = "decimal(18,2)")]
        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = true)]
        public decimal ProductPrice { get; set; }


        [RegularExpression(@"^(https?://|/).+\.(jpg|jpeg|png|gif|webp)$",
        ErrorMessage = "Must be a valid image URL ending with .jpg, .jpeg, .png, .gif, or .webp")]
        public string ProfileImagePath { get; set; }

    }
}
