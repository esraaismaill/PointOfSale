using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreBusiness;

namespace UseCases.DataStorePluginInterfaces
{
    public interface ITransactionRepository
    {
        public IEnumerable<Transaction> Get(string cashierName, string visa);
        public IEnumerable<Transaction> GetByDay(string cashierName, DateTime date, string visa, int recId);
        public IEnumerable<Transaction> Search(string cashierName, DateTime startDate, DateTime dateTime, string visa, string receiptsId);
        public void Save(string cashierName, int productId, string productName, double price, int beforeQty, int soldQty, string visa, int receiptsId);
        IEnumerable<Transaction> GetTransaction();
        void AddTransaction(Transaction transaction);
        void UpdateTransaction(Transaction transaction);
        Transaction GetTransactionById(int transactionId);
        void DeleteTransaction(int transactionId);
        IEnumerable<Transaction> GetTransactionByReceiptId(int receiptId);
    }
}
