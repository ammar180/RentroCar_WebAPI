namespace RentroCar.Models.Entities
{
    public class User
    {
        public int UserId { get; set; }
		#region Registration fields
		public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }
        public string PhoneNumber { get; set; }
        public string ProfileImage { get; set; }
		#endregion
		#region Patment fields
		#endregion
		#region Rating & Reviewing Fields
		#endregion
		public List<Car>? UserCars { get; set; }
		public List<FavoriteCar>? FavoriteCars { get; set; }
    }
	public class Location
	{
		public int UserId { get; set; }
		public int Id { get; set; }
		public string Country { get; set; }
		public string Government { get; set; }
		public string City { get; set; }
		public string Address { get; set; }
	}

}