using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace StockManagementSystem.Models
{
    public class Sale
    {
        public int SaleId { get; set; }
        public int ClientId { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime SaleDate { get; set; }
        public string SaveSale(Sale sale)
        {
            string msg = string.Empty;
            IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory).AddJsonFile("appsettings.json").Build();
            string connectionString = configuration.GetConnectionString("DefaultConnection");
            string query = @"INSERT INTO Sale VALUES(@ClientId ,@ItemId ,@Quantity ,@UnitPrice ,@SaleDate)";

            string query2 = @"update item 
                                   set item.Quantity=(i.Quantity-@Quantity)
                                  from item i
                                  where i.ItemId=@ItemId";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClientId", sale.ClientId);
            command.Parameters.AddWithValue("@ItemId", sale.ItemId);
            command.Parameters.AddWithValue("@Quantity", sale.Quantity);
            command.Parameters.AddWithValue("@UnitPrice", sale.UnitPrice);
            command.Parameters.AddWithValue("@SaleDate", sale.SaleDate);

            SqlCommand command1 = new SqlCommand(query2, connection);
            command1.Parameters.AddWithValue("@Quantity", sale.Quantity);
            command1.Parameters.AddWithValue("@ItemId", sale.ItemId);



            try
            {
                connection.Open();


                int effectedRow = command.ExecuteNonQuery();
                if (effectedRow > 0)
                {
                    effectedRow = command1.ExecuteNonQuery();
                }
                msg = effectedRow + " record has been Saved!!";
            }
            catch (Exception ex)
            {

                msg = ex.Message;
            }
            finally
            {

                connection.Close();
            }

            return msg;
        }
    }
}
