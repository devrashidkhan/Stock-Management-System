using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace StockManagementSystem.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        public int VendorId { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string SavePurchase(Purchase purchase)
        {
            string msg = string.Empty;
            IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory).AddJsonFile("appsettings.json").Build();
            string connectionString= configuration.GetConnectionString("DefaultConnection");
            string query = @"INSERT INTO Purchase VALUES(@VendorId ,@ItemId ,@Quantity ,@UnitPrice ,@PurchaseDate)";

            string query2 = @"update item 
                                   set item.Quantity=(i.Quantity+@Quantity)
                                  from item i
                                  where i.ItemId=@ItemId";
            
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@VendorId", purchase.VendorId);
            command.Parameters.AddWithValue("@ItemId", purchase.ItemId);
            command.Parameters.AddWithValue("@Quantity", purchase.Quantity);
            command.Parameters.AddWithValue("@UnitPrice", purchase.UnitPrice);
            command.Parameters.AddWithValue("@PurchaseDate", purchase.PurchaseDate);

            SqlCommand command1 = new SqlCommand(query2, connection);
            command1.Parameters.AddWithValue("@Quantity", purchase.Quantity);
            command1.Parameters.AddWithValue("@ItemId", purchase.ItemId);



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
