using ICSSoft.STORMNET.Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IIS.Abiturient.forms
{
    public partial class Query1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ButtonQuery1_OnClick(object sender, EventArgs e)
        {

            SQLDataService ds = (SQLDataService)DataServiceProvider.DataService;
            IDbConnection connection = ds.GetConnection();
            try
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "SELECT  Город FROM Абитуриент GROUP BY Город ORDER BY COUNT(*) DESC";
                var result = command.ExecuteScalar();
                QueryLabel1.Text = result.ToString();
            }
            catch (Exception ex)
            {
                QueryLabel1.Text = ex.ToString();
            }
            finally
            {
                connection.Close();
            }

        } 
        protected void ButtonQuery2_OnClick(object sender, EventArgs e)
        {

            SQLDataService ds = (SQLDataService)DataServiceProvider.DataService;
            IDbConnection connection = ds.GetConnection();
            try
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "SELECT Top 1 Специальность FROM ЗаписьВЗаявлении GROUP BY Специальность ORDER BY COUNT(*) DESC";
                var result2 = command.ExecuteScalar();
                QueryLabel2.Text = result2.ToString();
            }
            catch (Exception ex)
            {
                QueryLabel2.Text = ex.ToString();
            }
            finally
            {
                connection.Close();
            }

        }
        protected void ButtonQuery3_OnClick(object sender, EventArgs e)
        {

            SQLDataService ds = (SQLDataService)DataServiceProvider.DataService;
            IDbConnection connection = ds.GetConnection();
            try
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "Select DISTINCT ЗаписьВЗаявлении.Специальность, avg(Абитуриент.Возраст) as Средний_возраст From ЗаписьВЗаявлении JOIN Абитуриент on ЗаписьВЗаявлении.Заявление = Абитуриент.Фамилия GROUP BY ЗаписьВЗаявлении.Специальность ";
                var result3 = command.ExecuteScalar();
                QueryLabel3.Text = result3.ToString();
            }
            catch (Exception ex)
            {
                QueryLabel3.Text = ex.ToString();
            }
            finally
            {
                connection.Close();
            }

        }
        protected void ButtonQuery4_OnClick(object sender, EventArgs e)
        {

            SQLDataService ds = (SQLDataService)DataServiceProvider.DataService;
            IDbConnection connection = ds.GetConnection();
            try
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "SELECT DISTINCT  YEAR(Заявление.ДатаПодачи) as year,Абитуриент.Город, COUNT(Заявление.ПорядковыйНомер) as Среднее From Заявление JOIN Абитуриент on Заявление.ПорядковыйНомер = Абитуриент.Фамилия GROUP BY Абитуриент.Город, Заявление.ДатаПодачи";
                var result4 = command.ExecuteScalar();
                QueryLabel4.Text = result4.ToString();
            }
            catch (Exception ex)
            {
                QueryLabel4.Text = ex.ToString();
            }
            finally
            {
                connection.Close();
            }

        }
        protected void ButtonQuery5_OnClick(object sender, EventArgs e)
        {

            SQLDataService ds = (SQLDataService)DataServiceProvider.DataService;
            IDbConnection connection = ds.GetConnection();
            try
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "SELECT  Специальность FROM ЗаписьВЗаявлении GROUP BY Приоритет, Специальность ORDER BY COUNT(*) DESC";
                var result5 = command.ExecuteScalar();
                QueryLabel5.Text = result5.ToString();
            }
            catch (Exception ex)
            {
                QueryLabel5.Text = ex.ToString();
            }
            finally
            {
                connection.Close();
            }

        }
    }
}