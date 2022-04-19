using CoreBusiness;
using System.Collections.Generic;

namespace UseCases
{
    public interface IGetTodayTransactionsUseCase
    {
        IEnumerable<Transaction> Execute(string cashierName);
        IEnumerable<Transaction> Execute(bool visa);
    }
}