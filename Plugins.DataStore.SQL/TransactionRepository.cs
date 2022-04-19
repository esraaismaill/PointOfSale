using CoreBusiness;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.SQL
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly MarketContext db;

        public TransactionRepository(MarketContext db)
        {
            this.db = db;
        }

        public IEnumerable<Transaction> Get(string cashierName)
        {
            return db.Transactions.ToList();
        }

        public IEnumerable<Transaction> Get(bool visaa)
        {
            return db.Transactions.ToList();
        }

        public IEnumerable<Transaction> GetByDay(string cashierName, DateTime date)
        {
            if (string.IsNullOrWhiteSpace(cashierName))
                return db.Transactions.Where(x => x.TimeStamp.Date == date.Date);
            else
                return db.Transactions.Where(x =>
                    EF.Functions.Like(x.CashierName, $"%{cashierName}%") &&
                    x.TimeStamp.Date == date.Date);
        }

        public void Save(string cashierName, int productId, string productName, double price, int beforeQty, int soldQty, bool visaa)
        {
            var transaction = new Transaction
            {
                ProductId = productId,
                ProductName = productName,
                TimeStamp = DateTime.Now,
                Price = price,
                BeforeQty = beforeQty,
                SoldQty = soldQty,
                CashierName = cashierName,
                Visa= visaa
            };

            db.Transactions.Add(transaction);
            db.SaveChanges();
        }

        public IEnumerable<Transaction> Search(string cashierName, DateTime startDate, DateTime endDate, bool visaa)
        {
            if (string.IsNullOrWhiteSpace(cashierName)) 
                return db.Transactions.Where(x => x.TimeStamp >= startDate.Date && x.TimeStamp <= endDate.Date.AddDays(1).Date);
            if (string.IsNullOrWhiteSpace(visaa.ToString()))
                return db.Transactions.Where(x => x.TimeStamp >= startDate.Date && x.TimeStamp <= endDate.Date.AddDays(1).Date);
            else
                return db.Transactions.Where(x =>
                    (EF.Functions.Like(x.CashierName, $"%{cashierName}%") && x.TimeStamp >= startDate.Date && x.TimeStamp <= endDate.Date.AddDays(1).Date)
                    || ((x.Visa == visaa) && x.TimeStamp >= startDate.Date && x.TimeStamp <= endDate.Date.AddDays(1).Date)) ;
        }
    }
}
