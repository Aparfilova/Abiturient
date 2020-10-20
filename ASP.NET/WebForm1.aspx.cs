using ICSSoft.STORMNET.Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IIS.Abiturient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ExecuteSqlQueryButtom_OnClick(object sender, EventArgs e)
        {
            SQLDataService ds = (SQLDataService)DataServiceProvider.DataService;
            IDbConnection connection = ds.GetConnection();
            try
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "SELECT  Город FROM Абитуриент GROUP BY Город ORDER BY COUNT(*) DESC";
                var result = command.ExecuteScalar();
                
            }
            catch (Exception ex)
            {
             
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
