using System;
using OreganCoAPI.Models;
using OreganCoAPI.Models.ModelViews;

namespace OreganCoAPI.Services
{
    public interface IBankService
    {
        ResultModelView PostNewTransaction(BankTransaction transaction);
    }
}
