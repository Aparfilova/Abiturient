using ICSSoft.STORMNET.Business;
using System;

using System.Data;


namespace IIS.Abiturient
{
    public partial class ExecuteQuery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ButtonQuery_OnClick(object sender, EventArgs e)
        {
            
            SQLDataService ds = (SQLDataService)DataServiceProvider.DataService;
            IDbConnection connection = ds.GetConnection();
            try
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "SELECT Возраст  FROM Абитуриент";
                var result = command.ExecuteScalar();
                QueryResultLabel.Text = result.ToString();
            }
            catch (Exception ex)
            {
                QueryResultLabel.Text = ex.ToString();
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
