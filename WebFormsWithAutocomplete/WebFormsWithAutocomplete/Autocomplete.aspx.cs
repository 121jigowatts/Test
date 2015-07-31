using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormsWithAutocomplete.Models;
using WebFormsWithAutocomplete.RepositoryInterfaces;
using WebFormsWithAutocomplete.SQLServer.Repositories;

namespace WebFormsWithAutocomplete
{
    public partial class Autocomplete : System.Web.UI.Page
    {       
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        [WebMethod]
        public static string CodeBehindMethod(string code)
        {
            return string.Format("☆{0}☆", code); ;
        }

        [WebMethod]
        public static List<Product> GetData(string prodCode)
        {
            IProductRepository repository = new ProductRepository();
            var result = repository.GetByCodeAutocomplete(prodCode);
            return result;
        }
    }

}