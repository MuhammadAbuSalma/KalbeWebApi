using KalbeWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KalbeWebApi.IServices
{
	public interface IMCurrencyService
	{
		IEnumerable<MCurrency> GetMCurrency();		
		MCurrency AddMCurrency(MCurrency mcurrency);
		MCurrency UpdateMCurrency(MCurrency mcurrency);
		MCurrency DeleteMCurrency(string id);
		MCurrency GetMCurrencyById(string id);
	}
}
