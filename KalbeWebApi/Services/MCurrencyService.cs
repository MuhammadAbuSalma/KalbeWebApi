using KalbeWebApi.IServices;
using KalbeWebApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KalbeWebApi.Services
{
	public class MCurrencyService : IMCurrencyService
	{
		DataContext dbContext;
		public MCurrencyService(DataContext _db)
		{
			dbContext = _db;
		}

		public IEnumerable<MCurrency> GetMCurrency()
		{
			var mcurrency = dbContext.MCurrencys.ToList();
			return mcurrency;
		}

		public MCurrency AddMCurrency(MCurrency mcurrency)
		{
			if (mcurrency != null)
			{
				dbContext.MCurrencys.Add(mcurrency);
				dbContext.SaveChanges();
				return mcurrency;
			}
			return null;
		}

		public MCurrency UpdateMCurrency(MCurrency mcurrency)
		{

			dbContext.Entry(mcurrency).State = EntityState.Modified;
			dbContext.SaveChanges();
			return mcurrency;
		}

		public MCurrency DeleteMCurrency(string id)
		{
			var mcurrency = dbContext.MCurrencys.FirstOrDefault(x => x.CurrencyId == id);
			dbContext.Entry(mcurrency).State = EntityState.Deleted;
			dbContext.SaveChanges();
			return mcurrency;
		}

		public MCurrency GetMCurrencyById(string id)
		{
			var mcurrency = dbContext.MCurrencys.FirstOrDefault(x => x.CurrencyId == id);			
			return mcurrency;
		}

	}
}
