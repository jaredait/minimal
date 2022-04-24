using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.MinimalDataSetTableAdapters;

namespace WebApplication1
{
    public partial class ReporteProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-CPR26P6/SQLEXPRESS;Initial Catalog=Minimal;User ID=sa;Password=Kiburobuc9021 providerName = System.Data.SqlClient");
            
            
        }
    }
}