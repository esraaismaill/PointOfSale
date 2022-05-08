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

        public IEnumerable<Transaction> Get(string cashierName, string visa)
        {
            return db.Transactions.ToList();
        }

   

        public IEnumerable<Transaction> GetByDay(string cashierName, DateTime date, string visa, int recId)
        {
            if (string.IsNullOrWhiteSpace(cashierName) && string.IsNullOrWhiteSpace(visa))
                return db.Transactions.Where(x => x.TimeStamp.Date == date.Date);
            else
                return db.Transactions.Where(x =>
                   ( EF.Functions.Like(x.CashierName, $"%{cashierName}%") &&
                    x.TimeStamp.Date == date.Date) || (EF.Functions.Like(x.Visa, $"%{visa}%") &&
                    x.TimeStamp.Date == date.Date)) ;
        }

        public void Save(string cashierName, int productId, string productName, double price, int beforeQty, int soldQty, string visa, int receiptsId)
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
                Visa = visa,
                ReceiptsId2 = receiptsId
            };

            db.Transactions.Add(transaction);
            db.SaveChanges();
        }

        public IEnumerable<Transaction> GetTransactionByReceiptId(int receiptId)
        {
            return db.Transactions.Where(x => x.ReceiptsId2 == receiptId).ToList();
        }

        public IEnumerable<Transaction> Search(string cashierName, DateTime startDate, DateTime endDate, string visa, string receiptsId)
        {
            if (string.IsNullOrWhiteSpace(cashierName) && string.IsNullOrWhiteSpace(visa) && string.IsNullOrWhiteSpace(receiptsId)) 
                return db.Transactions.Where(x => x.TimeStamp >= startDate.Date && x.TimeStamp <= endDate.Date.AddDays(1).Date);

           /* if (!string.IsNullOrWhiteSpace(receiptsId.ToString()) && string.IsNullOrWhiteSpace(visa) && string.IsNullOrWhiteSpace(cashierName))
                return db.Transactions.Where(x => (EF.Functions.Like(x.ReceiptsId.ToString(), $"%{receiptsId.ToString()}%") && x.TimeStamp >= startDate.Date && x.TimeStamp <= endDate.Date.AddDays(1).Date));
            
            if (!string.IsNullOrWhiteSpace(visa) && string.IsNullOrWhiteSpace(cashierName)  && !string.IsNullOrWhiteSpace(receiptsId.ToString()))
                return db.Transactions.Where(x => (EF.Functions.Like(x.Visa, $"%{visa}%") && EF.Functions.Like(x.ReceiptsId.ToString(), $"%{receiptsId.ToString()}%") && EF.Functions.Like(x.CashierName, $"%{cashierName}%") && x.TimeStamp >= startDate.Date && x.TimeStamp <= endDate.Date.AddDays(1).Date));

            if (!string.IsNullOrWhiteSpace(cashierName)  && string.IsNullOrWhiteSpace(visa) && !string.IsNullOrWhiteSpace(receiptsId.ToString()) )
                return db.Transactions.Where(x => (EF.Functions.Like(x.CashierName, $"%{cashierName}%") && x.TimeStamp >= startDate.Date && x.TimeStamp <= endDate.Date.AddDays(1).Date));
           */
           else
            return db.Transactions.Where(x => (EF.Functions.Like(x.Visa, $"%{visa}%") && EF.Functions.Like(x.ReceiptsId2.ToString(), $"%{receiptsId}%") && EF.Functions.Like(x.CashierName, $"%{cashierName}%") && x.TimeStamp >= startDate.Date && x.TimeStamp <= endDate.Date.AddDays(1).Date));
            // (EF.Functions.Like(x.CashierName, $"%{cashierName}%") && x.TimeStamp >= startDate.Date && x.TimeStamp <= endDate.Date.AddDays(1).Date)
            // || (EF.Functions.Like(x.Visa, $"%{visa}%") && x.TimeStamp >= startDate.Date && x.TimeStamp <= endDate.Date.AddDays(1).Date));
        }

        public void AddTransaction(Transaction transaction)
        {
            db.Transactions.Add(transaction);
            db.SaveChanges();
        }

        public void DeleteTransaction(int transactionId)
        {
            var transaction = db.Transactions.Find(transactionId);
            if (transaction == null) return;

            db.Transactions.Remove(transaction);
            db.SaveChanges();
        }

        public IEnumerable<Transaction> GetTransaction()
        {
            return db.Transactions.ToList();
        }

        public Transaction GetTransactionById(int transactionId)
        {
            return db.Transactions.Find(transactionId);
        }

        public void UpdateTransaction(Transaction transaction)
        {
            var tar = db.Transactions.Find(transaction.TransactionId);
            tar.TimeStamp = transaction.TimeStamp;
            tar.ProductId = transaction.ProductId;
            tar.ProductName = transaction.ProductName;
            tar.Price = transaction.Price;
            tar.BeforeQty = transaction.BeforeQty;
            tar.SoldQty = transaction.SoldQty;
            tar.CashierName = transaction.CashierName;
            tar.Visa = transaction.Visa;
            tar.ReceiptsId2 = transaction.ReceiptsId2;
            db.SaveChanges();
        }




    }
}
