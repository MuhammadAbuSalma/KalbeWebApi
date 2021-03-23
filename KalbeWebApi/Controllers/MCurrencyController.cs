using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KalbeWebApi.IServices;
using KalbeWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KalbeWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MCurrencyController : ControllerBase
    {
        private readonly IMCurrencyService mcurrencyService;
        public MCurrencyController(IMCurrencyService mcurrency)
        {
            mcurrencyService = mcurrency;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/MCurrency/GetMCurrency")]
        public IEnumerable<MCurrency> GetMCurrency()
        {
            return mcurrencyService.GetMCurrency();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/MCurrency/AddMCurrency")]
        public MCurrency AddMCurrency(MCurrency mcurrency)
        {
            return mcurrencyService.AddMCurrency(mcurrency);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/MCurrency/UpdateMCurrency")]
        public MCurrency UpdateMCurrency(MCurrency mcurrency)
        {
            return mcurrencyService.UpdateMCurrency(mcurrency);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/MCurrency/DeleteMCurrency")]
        public MCurrency DeleteMCurrency(string id)
        {
            return mcurrencyService.DeleteMCurrency(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/MCurrency/GetMCurrencyById")]
        public MCurrency GetMCurrencyById(string id)
        {
            return mcurrencyService.GetMCurrencyById(id);
        }

    }
}