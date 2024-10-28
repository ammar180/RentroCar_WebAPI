using System.ComponentModel.DataAnnotations.Schema;

namespace RentroCar.Models.Entities
{
	public class Car
	{
        public int CarId { get; set; }
        public string Model { get; set; }
        public int AvailableDays { get; set; }
        public double RentingPrice { get; set; }
        public bool IsAvailable { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        //public List<FavoriteCar> CarFavorites { get; set; }
        public List<Photo> CarPhotos { get; set; }
    }
	public class Photo
	{
        [ForeignKey("CarId")]
        public int CarId { get; set; }
        public string PhotoURL { get; set; }
    }
}