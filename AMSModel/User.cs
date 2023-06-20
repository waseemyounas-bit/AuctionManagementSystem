using System.ComponentModel.DataAnnotations;
namespace AMSModels
{
	public class User
	{
		public Guid Id { get; set; }
		[Required(AllowEmptyStrings = false)]
		[StringLength(100, MinimumLength = 3, ErrorMessage = "Length should be in between 3 and 100")]
		public string? FullName { get; set; }
		//[Required(AllowEmptyStrings = false)]
		//[StringLength(100, MinimumLength = 3, ErrorMessage = "Length should be in between 3 and 100")]
		//public string? LastName { get; set; }
		[Required(AllowEmptyStrings = false)]
		[RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Invalid email")]
		public string? Email { get; set; }
		[Required(AllowEmptyStrings = false)]
		[StringLength(50, MinimumLength = 8, ErrorMessage = "password should be between 8 and 50 characters")]
		public string? Password { get; set; }
		public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
		public int RoleId { get; set; }
		public bool SellerType { get; set; } = false; //false for private party and true for dealer
		public int IsApproved { get; set; } = 1;
		public List<AddVehicle>? Vehicles { get; set; }
    }
}
