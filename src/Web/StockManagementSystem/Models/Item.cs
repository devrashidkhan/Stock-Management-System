using StockManagementSystem.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace StockManagementSystem.Models
{
    public class Item:DatabaseGateway
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string ItemDetails { get; set; }
        public int CategoryId { get; set; }
        public int Quantity { get; set; }

        
        public string SaveItem(Item item)
        {
            string msg = string.Empty;
            if (item.ItemId == 0)
            {
                Query = @"INSERT INTO Item VALUES(@Name, @ItemDetails, @CategoryId, @Quantity)";

            }
            else
            {
                Query = @"update Item 
                             set Name=@Name , ItemDetails=@ItemDetails, CategoryId=@CategoryId, Quantity=@Quantity
                           where ItemId=" + item.ItemId;
            }
            Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@Name", item.Name);
            Command.Parameters.AddWithValue("@ItemDetails", item.ItemDetails);
            Command.Parameters.AddWithValue("@CategoryId", item.CategoryId);
            Command.Parameters.AddWithValue("@Quantity", item.Quantity);

            try
            {
                Connection.Open();
                int effectedRow = Command.ExecuteNonQuery();
                msg = effectedRow + " record has been Saved!!";
            }
            catch (Exception ex)
            {

                msg = ex.Message;
            }
            finally
            {
                Connection.Close();
            }

            return msg;
        }

        public List<Item> GetAllItems(int? itemId)
        {
            string msg = string.Empty;
            if (itemId == 0 || string.IsNullOrEmpty(itemId.ToString()))
            {
                Query = @"SELECT * FROM Item";

            }
            else
            {
                Query = @"SELECT * FROM Item c where c.ItemId=" + itemId;

            }
            Command = new SqlCommand(Query, Connection);
            List<Item> items = new List<Item>();

            try
            {
                Connection.Open();
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    Item item = new Item();
                    item.ItemId = Convert.ToInt32(Reader["ItemId"]);
                    item.CategoryId = Convert.ToInt32(Reader["CategoryId"]);
                    item.Name = Reader["Name"].ToString();
                    item.ItemDetails = Reader["ItemDetails"].ToString();
                    item.Quantity = Convert.ToInt32(Reader["Quantity"]);
                    items.Add(item);
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
        public List<Item> GetAllItemsByCatg(int? categoryId)
        {
            string msg = string.Empty;
            if (categoryId == 0 || string.IsNullOrEmpty(categoryId.ToString()))
            {
                Query = @"SELECT * FROM Item";

            }
            else
            {
                Query = @"SELECT * FROM Item c where c.CategoryId=" + categoryId;

            }
            Command = new SqlCommand(Query, Connection);
            List<Item> items = new List<Item>();

            try
            {
                Connection.Open();
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    Item item = new Item();
                    item.ItemId = Convert.ToInt32(Reader["ItemId"]);
                    item.CategoryId = Convert.ToInt32(Reader["CategoryId"]);
                    item.Name = Reader["Name"].ToString();
                    item.ItemDetails = Reader["ItemDetails"].ToString();
                    item.Quantity = Convert.ToInt32(Reader["Quantity"]);
                    items.Add(item);
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
        public string DeleteItemById(int itemId)
        {
            string msg = string.Empty;
            Query = @"DELETE FROM Item WHERE ItemId=@itemId";


            Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@itemId", itemId);

            try
            {
                Connection.Open();
                int effectedRow = Command.ExecuteNonQuery();
                msg = effectedRow + " record has been Deleted!!";
            }
            catch (Exception ex)
            {

                msg = ex.Message;
            }
            finally
            {
                Connection.Close();
            }

            return msg;
        }
    }
}
