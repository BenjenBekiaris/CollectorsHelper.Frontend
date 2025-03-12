using CollectorsHelper.Frontend.Converters;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CollectorsHelper.Frontend.Models
{
    public class CollectibleItemDetail
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Item type is required")]
        [JsonConverter(typeof(StringConverter))]
        public string? ItemTypeId { get; set; }

        [Required]
        [StringLength(50)]
        public required string Name { get; set; }

        [Required(ErrorMessage = "Country is required")]
        [JsonConverter(typeof(StringConverter))]
        public string? CountryId { get; set; }

        [Range(0,2500)]
        public int ProductionYear { get; set; }

        public DateOnly LastEdit { get; set; }

        [Range(1,int.MaxValue, ErrorMessage = "Number of copies must be higher than 1")]
        public int NumberOfCopies { get; set; }

        public string? Description { get; set; }

        public string? ImageUrl { get; set; }
    }
}
