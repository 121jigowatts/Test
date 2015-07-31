using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

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
        public static List<ProductInfo> GetData(string prodCode)
        {
            var result = new List<ProductInfo>() 
            {
                new ProductInfo(){Code=prodCode,Name="Sample 1"},
                new ProductInfo(){Code=prodCode,Name="Sample 2"},
                new ProductInfo(){Code=prodCode,Name="Sample 3"}
            };
            return result;
        }
    }

    public class ProductInfo
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
}