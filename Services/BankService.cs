using System;
using Microsoft.Extensions.Configuration;
using OreganCoAPI.Infrastructure.Integromat;
using OreganCoAPI.Models;
using OreganCoAPI.Models.ModelViews;

namespace OreganCoAPI.Services
{
    public class BankService : IBankService
    {
        public readonly IIntegromatClient _integromat;
        public readonly IConfiguration _configuration;

        public BankService(IIntegromatClient integromat, IConfiguration configuration)
        {
            _integromat = integromat;
            _configuration = configuration;
        }

        public ResultModelView PostNewTransaction(BankTransaction transaction)
        {
            var requestUrl = _configuration.GetSection("Integromat")
                .GetSection("BankTransfersWebhook").Value;

            var response = _integromat.SendIntegromatWebhook(requestUrl, transaction, RestSharp.Method.POST);

            return GetSuccessfulView();
        }

        public ResultModelView GetSuccessfulView()
        {
            var result = new ResultModelView
            {
                StatusCode = 200,
                Comment = "Transaction saved successfully"
            };

            return result;
        }

    }
}
