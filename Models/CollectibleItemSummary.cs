namespace CollectorsHelper.Frontend.Models
{
    public class CollectibleItemSummary
    {
        public int Id { get; set; }

        public required string ItemType { get; set; }

        public required string Name { get; set; }

        public required string Country { get; set; }

        public int ProductionYear { get; set; }

        public DateOnly LastEdit { get; set; }

        public int NumberOfCopies { get; set; }

    }
}
