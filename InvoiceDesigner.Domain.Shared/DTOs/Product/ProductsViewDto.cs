﻿using InvoiceDesigner.Domain.Shared.Interfaces.Abstract;

namespace InvoiceDesigner.Domain.Shared.DTOs.Product
{
	public class ProductsViewDto : IHasIdAndName
	{
		public int Id { get; set; }

		public string Name { get; set; } = string.Empty;

		public bool IsDeleted { get; set; }
	}
}
