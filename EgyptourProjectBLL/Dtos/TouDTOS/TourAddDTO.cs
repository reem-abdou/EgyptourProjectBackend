using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgyptourProject.DAL.Data.Models;

namespace EgyptourProject.BLL.Dtos.TouDTOS
{
    public class TourAddDTO
    {
        [Required(ErrorMessage = "Please select a category")]
        public TripCategory TripCategory { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(50, ErrorMessage = "Title cannot exceed 50 characters")]
        public string TripTitle { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [StringLength(500, MinimumLength = 20, ErrorMessage = "Description must be between 20 and 500 characters")]
        public string TripDescription { get; set; }

        [Required(ErrorMessage = "Highlights is required")]
        public string Highlights { get; set; }

        [Required(ErrorMessage = "Date is required")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal TripPrice { get; set; }

        [Required(ErrorMessage = "Quantity is required")]
        [Range(1, long.MaxValue, ErrorMessage = "Quantity must be a positive number")]
        public long TripsQuantity { get; set; }

        [RegularExpression(@"^(https?://|/).+\.(jpg|jpeg|png|gif|webp)$",
            ErrorMessage = "Must be a valid image URL ending with .jpg, .jpeg, .png, .gif, or .webp")]
        public string ProfileImagePath { get; set; }
    }
}
