using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgyptourProject.DAL.Data.Models;

namespace EgyptourProject.BLL.Dtos.TouDTOS
{
    public class TourUpdateDTO
    {
        public int TripId { get; set; }

        public TripCategory? TripCategory { get; set; }

        [StringLength(50, ErrorMessage = "Title cannot exceed 50 characters")]
        public string? TripTitle { get; set; }

        [StringLength(500, MinimumLength = 20, ErrorMessage = "Description must be between 20-500 characters")]
        public string? TripDescription { get; set; }

        public string? Highlights { get; set; }

        public DateTime? Date { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be positive")]
        public decimal? TripPrice { get; set; }

        [Range(1, long.MaxValue, ErrorMessage = "Quantity must be at least 1")]
        public long? TripsQuantity { get; set; }

        [Url(ErrorMessage = "Invalid URL format")]
        [RegularExpression(@"\.(jpg|jpeg|png|gif|webp)$", ErrorMessage = "Image must be JPG, PNG, GIF or WEBP")]
        public string? ProfileImagePath { get; set; }
    }

}
