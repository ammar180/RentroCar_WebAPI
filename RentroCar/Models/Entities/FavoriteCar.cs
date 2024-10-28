namespace RentroCar.Models.Entities
{
	public class FavoriteCar
	{
        public int UserId { get; set; }
        public int CarId { get; set; }
        public User User { get; set; }
        public Car Car { get; set; }
    }
}