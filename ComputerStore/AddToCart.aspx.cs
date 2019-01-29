using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using ComputerStore.Logic;

namespace ComputerStore
{
	public partial class AddToCart : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			string rawId = Request.QueryString["ProductID"]; //дістаємо айді продукту і присвоюємо у змінну
			int productId;
			if (!String.IsNullOrEmpty(rawId) && int.TryParse(rawId, out productId))
			{
				using (ShoppingCartActions usersShoppingCart = new ShoppingCartActions())
				{
					//визиває метод AddToCart коли створено екземпляр корзини
					//після добавлення продукту у корзину, ця стрінка перенаправляє до ShoppingCart.aspx,
					//з оновленою інфою
					usersShoppingCart.AddToCart(Convert.ToInt16(rawId));
				}
			}

			else
			{
				Debug.Fail("error не можна переходити на сторінку AddToCart без ProductId");
				throw new Exception("error");
			}
			Response.Redirect("ShoppingCart.aspx");
		}
	}
}