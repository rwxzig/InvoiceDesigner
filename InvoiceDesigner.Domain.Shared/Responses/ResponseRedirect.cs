﻿namespace InvoiceDesigner.Domain.Shared.Responses
{
	public class ResponseRedirect
	{
		public string RedirectUrl { get; set; } = string.Empty;

		public int entityId { get; set; }
	}
}
