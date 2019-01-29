using System.ComponentModel.DataAnnotations;

namespace ComputerStore.Models
{
	public class CartItem
	{
		[Key]
		public string ItemId { get; set; }//main key

		public string CartId { get; set; }// match to user/customer ID

		public int Quantity { get; set; }

		public System.DateTime DateCreated { get; set; }

		public int ProductId { get; set; }

		public virtual Product Product { get; set; }
	}
}