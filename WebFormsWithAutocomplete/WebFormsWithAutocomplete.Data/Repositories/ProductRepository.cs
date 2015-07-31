using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFormsWithAutocomplete.Models;
using WebFormsWithAutocomplete.RepositoryInterfaces;

namespace WebFormsWithAutocomplete.SQLServer.Repositories
{
    public class ProductRepository : IProductRepository
    {

        public List<Models.Product> GetAll()
        {
            using (var context = new EFContext()) 
            {
                var query = from x in context.Products
                            select x;
                var result = MappingProduct(query);

                return result;
            }

        }



        public List<Models.Product> GetByCodeAutocomplete(string code)
        {
            using (var context = new EFContext()) 
            {
                var query = from x in context.Products
                            where x.Code.StartsWith(code)
                            select x;
                var result = MappingProduct(query);
                
                return result;
            }

        }

        private static List<Models.Product> MappingProduct(IQueryable<Product> query)
        {
            var result = new List<Models.Product>();
            foreach (var item in query)
            {
                var record = new Models.Product();
                record.Code = item.Code;
                record.Name = item.Name;
                record.Price = item.Price;
                result.Add(record);
            }
            return result;
        }
    }
}
