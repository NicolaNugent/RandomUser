namespace RandomUser.Models
{
    public class User
    {
        public Name name { get; set; } = new Name();

		public DoB dob { get; set; } = new DoB();

		public Location location { get; set; } = new Location();
	}
}