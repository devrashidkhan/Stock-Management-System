using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace StockManagementSystem.Models.ViewModel
{
    public class CategoryItemView:DatabaseGateway
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string ItemDetails { get; set; }
        public int Quantity { get; set; }

        public List<CategoryItemView> GetAllItems(int? itemId)
        {
            string msg = string.Empty;
            if (itemId == 0 || string.IsNullOrEmpty(itemId.ToString()))
            {
                Query = @"SELECT * FROM CategoryItemView";

            }
            else
            {
                Query = @"SELECT * FROM CategoryItemView c where c.ItemId=" + itemId;

            }


            Command = new SqlCommand(Query, Connection);
            List<CategoryItemView> items = new List<CategoryItemView>();

            try
            {
                Connection.Open();
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    CategoryItemView itemView = new CategoryItemView();
                    itemView.ItemId = Convert.ToInt32(Reader["ItemId"]);
                    itemView.Name = Reader["Name"].ToString();
                    itemView.ItemDetails = Reader["ItemDetails"].ToString();
                    itemView.Quantity = Convert.ToInt32(Reader["Quantity"]);
                    itemView.CategoryId = Convert.ToInt32(Reader["CategoryId"]);
                    itemView.CategoryName = Reader["CategoryName"].ToString();
                    items.Add(itemView);
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

            return items;
        }
    }
}
