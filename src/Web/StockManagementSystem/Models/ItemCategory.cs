using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace StockManagementSystem.Models
{
    public class ItemCategory:DatabaseGateway
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<ItemCategory> GetAllItemCategories(int? ItemCategoryId)
        {
            string msg = string.Empty;
            if (ItemCategoryId == 0 || string.IsNullOrEmpty(ItemCategoryId.ToString()))
            {
                Query = @"SELECT * FROM ItemCategory";

            }
            else
            {
                Query = @"SELECT * FROM ItemCategory c where c.CategoryId=" + ItemCategoryId;

            }
            Command = new SqlCommand(Query, Connection);
            List<ItemCategory> categorys = new List<ItemCategory>();

            try
            {
                if (Connection.State == ConnectionState.Closed)
                {
                    Connection.Open();
                }
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    ItemCategory category = new ItemCategory();
                    category.CategoryId = Convert.ToInt32(Reader["CategoryId"]);
                    category.CategoryName = Reader["CategoryName"].ToString();
                    categorys.Add(category);
                }
            }
            catch (Exception ex)
            {

                msg = ex.Message;
            }
            finally
            {
                Connection.Close();
            }

            return categorys;
        }
    }
    
}
