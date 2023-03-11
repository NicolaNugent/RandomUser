namespace RandomUser.Models
{
    public class Location
    {
        public string country { get; set; } = string.Empty;

		public Coordinates coordinates { get; set; } = new Coordinates();
	}
}