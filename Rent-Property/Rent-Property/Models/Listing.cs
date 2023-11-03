namespace Rent_Property.Models
{
    public class Listing
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageSrc { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Category { get; set; }
        public int RoomCount { get; set; }
        public int BathroomCount { get; set; }
        public int GuestCount { get; set; }
        public string LocationValue { get; set; }
        public string UserId { get; set; }
        public int Price { get; set; }

        public User User { get; set; }

    }
}
