﻿using InvoiceDesigner.Domain.Shared.DTOs.Currency;
using InvoiceDesigner.Domain.Shared.Models.Directories;
using InvoiceDesigner.Domain.Shared.QueryParameters;
using InvoiceDesigner.Domain.Shared.Responses;

namespace InvoiceDesigner.Application.Interfaces.Admin
{
	public interface ICurrencyService
	{
		Task<ResponsePaged<CurrencyViewDto>> GetPagedEntitiesAsync(QueryPaged queryPaged);
		Task<ResponseRedirect> CreateAsync(int userId, CurrencyEditDto currencyEditDto);
		Task<CurrencyEditDto> GetEditDtoByIdAsync(int id);
		Task<Currency> GetByIdAsync(int id);
		Task<string> GetNameByIdAsync(int id);
		Task<ResponseRedirect> UpdateAsync(int userId, CurrencyEditDto currencyEditDto);
		Task<ResponseBoolean> DeleteOrMarkAsDeletedAsync(QueryDeleteEntity queryDeleteEntity);
		Task<int> GetCountAsync();
		Task<IReadOnlyCollection<CurrencyAutocompleteDto>> GetAutocompleteDto();
		Task<IReadOnlyCollection<CurrencyAutocompleteDto>> FilteringData(string f);
	}
}
