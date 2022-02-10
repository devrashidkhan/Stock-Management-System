using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace StockManagementSystem.Models.ViewModel
{
    public class SaleHistoryView:DatabaseGateway
    {
        public int SaleId { get; set; }
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime SaleDate { get; set; }
        public List<SaleHistoryView> GetAllSaleHistory(SaleHistoryView saleHistory, DateTime? dateFrom, DateTime? dateTo)
        {
            string msg = string.Empty;

            Query = @"select * 
                          from SaleHistoryView v
                        where v.SaleDate >= ISNULL(@DateFrom, v.SaleDate)
                          and v.SaleDate <= ISNULL(@DateTo, v.SaleDate)
                          and v.saleId=ISNULL(@SaleId, v.SaleId)
                          and v.ClientId=ISNULL(@ClientId, v.ClientId)
                          and v.CategoryId=ISNULL(@CategoryId, v.CategoryId)
                          and v.ItemId=ISNULL(@ItemId, v.ItemId)";



            Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DateFrom", dateFrom == null ? DBNull.Value : dateFrom);
            Command.Parameters.AddWithValue("@DateTo", dateTo == null ? DBNull.Value : dateTo);
            Command.Parameters.AddWithValue("@SaleId", saleHistory.SaleId == 0 ? DBNull.Value : saleHistory.SaleId);
            Command.Parameters.AddWithValue("@ClientId", saleHistory.ClientId == 0 ? DBNull.Value : saleHistory.ClientId);
            Command.Parameters.AddWithValue("@CategoryId", saleHistory.ItemId == 0 ? DBNull.Value : saleHistory.CategoryId);
            Command.Parameters.AddWithValue("@ItemId", saleHistory.ItemId == 0 ? DBNull.Value : saleHistory.ItemId);

            List<SaleHistoryView> sales = new List<SaleHistoryView>();

            try
            {
                Connection.Open();
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    SaleHistoryView saleView = new SaleHistoryView();
                    saleView.SaleId = Convert.ToInt32(Reader["SaleId"]);
                    saleView.ClientId = Convert.ToInt32(Reader["ClientId"]);
                    saleView.ClientName = Reader["ClientName"].ToString();
                    saleView.CategoryId = Convert.ToInt32(Reader["CategoryId"]);
                    saleView.CategoryName = Reader["CategoryName"].ToString();
                    saleView.ItemId = Convert.ToInt32(Reader["ItemId"]);
                    saleView.ItemName = Reader["ItemName"].ToString();
                    saleView.Quantity = Convert.ToInt32(Reader["Quantity"]);
                    saleView.UnitPrice = Convert.ToDecimal(Reader["UnitPrice"]);
                    saleView.SaleDate = Convert.ToDateTime(Reader["SaleDate"]);
                    sales.Add(saleView);
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

            return sales;
        }
    }
}
