﻿using System.Reflection.Metadata.Ecma335;
using WebApplication_Pronia.Models.Base;

namespace WebApplication_Pronia.Models
{
	public class ProductTag : BaseEntity
	{
		public int ProductId { get; set; }
		public Product Product { get; set; }

		public int TagId { get; set; }
		public Tag Tag { get; set; }
	}
}
