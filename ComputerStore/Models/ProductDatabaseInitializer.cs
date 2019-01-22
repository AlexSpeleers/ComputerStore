using System.Collections.Generic;
using System.Data.Entity;

namespace ComputerStore.Models
{
	public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
	{
		protected override void Seed(ProductContext context)
		{
			GetCategories().ForEach(c => context.Categories.Add(c));
			GetProducts().ForEach(p => context.Products.Add(p));
		}

		private static List<Category> GetCategories()
		{
			var categories = new List<Category> {
				new Category
				{
					CategoryID = 1,
					CategoryName = "Laptop"
				},
				new Category
				{
					CategoryID = 2,
					CategoryName = "PC"
				},
				new Category
				{
					CategoryID = 3,
					CategoryName = "PS4"
				},
				new Category
				{
					CategoryID = 4,
					CategoryName = "X-Box One"
				},
				new Category
				{
					CategoryID = 5,
					CategoryName = "Nintendo Switch"
				},
			};

			return categories;
		}

		private static List<Product> GetProducts()
		{
			var products = new List<Product> {
				new Product
				{
					ProductID = 1,
					ProductName = "Dell G3",
					Description = "Gaming laptops engineered with " +
					"NVIDIA® GeForce® discrete graphics, 8th Gen Intel® processors " +
					"and a thin design for a sleek gaming experience.",
					ImagePath="dell G3.jpg",
					UnitPrice = 799.99,
					CategoryID = 1
			   },
				new Product
				{
					ProductID = 2,
					ProductName = "Dell G5",
					Description = "15-Inch gaming laptop with " +
					"stunning visuals powered by NVIDIA® GeForce® GTX 1060 graphics" +
					" and the latest 8th Gen Intel® Quad-and-Hex Core™ CPUs.",
					ImagePath="dell G5.jpg",
					UnitPrice = 949.99,
					 CategoryID = 1
			   },
				new Product
				{
					ProductID = 3,
					ProductName = "Dell G7",
					Description = "15-Inch gaming laptop designed for a powerful, " +
					"immersive in-game experience featuring NVIDIA® GeForce® GTX 1060 graphics " +
					"and the latest 8th Gen Intel® Quad-and-Hex Core™ CPUs, up to i9.",
					ImagePath="dell G7.jpg",
					UnitPrice = 1099.99,
					CategoryID = 1
				},
				new Product
				{
					ProductID = 4,
					ProductName = "Aurora",
					Description = "Designed for VR and engineered " +
					"with liquid cooling and tool-less access, " +
					"the Alienware Aurora was built to get you deeper in the game.",
					ImagePath="dell Aurora.jpg",
					UnitPrice = 999.99,
					CategoryID = 2
				},
				new Product
				{
					ProductID = 5,
					ProductName = "Area 51",
					Description = "Gaming desktop with iconic, innovative design, and tuned for ultimate performance.",
					ImagePath="dell Area 51.jpg",
					UnitPrice = 1969.99,
					CategoryID = 2
				},
				new Product
				{
					ProductID = 6,
					ProductName = "Area 51 Threadripper",
					Description = "Dominate the game with unbeatable performance" +
					" and world-bending graphics options on the redesigned Alienware Area-51 Threadripper.",
					ImagePath="dell Area 51 Threadripper.jpg",
					UnitPrice = 2819.99,
					CategoryID = 2
				},
				new Product
				{
					ProductID = 7,
					ProductName = "PlayStation 4",
					Description = "1TB hard drive.",
					ImagePath="PS4.jpg",
					UnitPrice = 299.99,
					CategoryID = 3
				},
				new Product
				{
					ProductID = 8,
					ProductName = "PS4 Pro",
					Description = "PS4 Pro outputs gameplay to your 4K TV." +
					"Turn on Boost Mode to give PS4 games access to the increased power of PS4 Pro. ",
					ImagePath="PS4 PRO.jpg",
					UnitPrice = 399.99,
					CategoryID = 3
				},
				new Product
				{
					ProductID = 9,
					ProductName = "Xbox One S",
					Description = "Gear up with Xbox 1TB accessories: Xbox One Play & Charge Kit \nXbox Elite Wireless Controller " +
					"\nXbox Design Lab",
					ImagePath="XBOX One S.jpg",
					UnitPrice = 299.00,
					CategoryID = 4
				},
				new Product
				{
					ProductID = 10,
					ProductName = "Xbox One X",
					Description = "Gear up with Xbox 1TB accessories: Xbox One Play & Charge Kit \nXbox Elite Wireless Controller " +
					"\nXbox Design Lab",
					ImagePath="XBOX One X.jpg",
					UnitPrice = 499.00,
					CategoryID = 4
				},
				new Product
				{
					ProductID = 11,
					ProductName = "Nintendo Switch with Gray Joy‑Con",
					Description = "This bundle includes the Nintendo Switch console" +
					" and Nintendo Switch dock in black, and left and right Joy‑Con controllers" +
					" in a contrasting gray. It also includes all the extras you need to get started.",
					ImagePath="Nintendo Switch Grey.jpg",
					UnitPrice = 299.00,
					CategoryID = 5
				},
				new Product
				{
					ProductID = 12,
					ProductName = "Nintendo Switch with Neon Blue and Neon Red Joy‑Con",
					Description = "This bundle includes the Nintendo Switch console " +
					"and Nintendo Switch dock in black, with contrasting left and right " +
					"Joy‑Con controllers—one red, one blue. It also includes all the extras you need to get started.",
					ImagePath="Nintendo Switch Blue&Red.jpg",
					UnitPrice = 299.00,
					CategoryID = 5
				}
			};

			return products;
		}
	}
}