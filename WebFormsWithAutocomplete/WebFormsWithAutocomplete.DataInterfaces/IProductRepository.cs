using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFormsWithAutocomplete.Models;

namespace WebFormsWithAutocomplete.RepositoryInterfaces
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        List<Product> GetByCodeAutocomplete(string id);
    }
}
