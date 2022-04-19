using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace UseCases
{
    public class SellProductUseCase : ISellProductUseCase
    {
        private readonly IProductRepository productRepository;
        private readonly IRecordTransactionUseCase recordTransactionUseCase;

        public SellProductUseCase(
            IProductRepository productRepository,
            IRecordTransactionUseCase recordTransactionUseCase)
        {
            this.productRepository = productRepository;
            this.recordTransactionUseCase = recordTransactionUseCase;
        }

        public void Execute(string cashierName, int productId, int qtyToSell, bool visaa)
        {
           // var product = productRepository.GetProductById(productId);
         //  if (product == null) return; 
            recordTransactionUseCase.Execute(cashierName, productId, qtyToSell,visaa);
         // product.Quantity -= qtyToSell;
         //   productRepository.UpdateProduct(product);            
        }
    }
}
