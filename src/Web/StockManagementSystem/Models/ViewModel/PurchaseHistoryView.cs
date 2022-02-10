using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace StockManagementSystem.Models.ViewModel
{
    public class PurchaseHistoryView:DatabaseGateway
    {
        public int PurchaseId { get; set; }
        public int VendorId { get; set; }
        public string VendorName { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime PurchaseDate { get; set; }
        public List<PurchaseHistoryView> GetAllPurchaseHistory(PurchaseHistoryView purchaseHistory,DateTime? dateFrom, DateTime? dateTo)
        {
            string msg = string.Empty;

            Query = @"select * 
                          from PurchaseHistoryView v
                        where v.PurchaseDate >= ISNULL(@DateFrom, v.PurchaseDate)
                          and v.PurchaseDate <= ISNULL(@DateTo, v.PurchaseDate)
                          and v.purchaseId=ISNULL(@PurchaseId, v.PurchaseId)
                          and v.VendorId=ISNULL(@VendorId, v.VendorId)
                          and v.CategoryId=ISNULL(@CategoryId, v.CategoryId)
                          and v.ItemId=ISNULL(@ItemId, v.ItemId)";



            Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@DateFrom", dateFrom==null? DBNull.Value : dateFrom);
            Command.Parameters.AddWithValue("@DateTo", dateTo == null ? DBNull.Value : dateTo);
            Command.Parameters.AddWithValue("@PurchaseId", purchaseHistory.PurchaseId == 0?DBNull.Value: purchaseHistory.PurchaseId);
            Command.Parameters.AddWithValue("@VendorId", purchaseHistory.VendorId == 0? DBNull.Value : purchaseHistory.VendorId);
            Command.Parameters.AddWithValue("@CategoryId", purchaseHistory.ItemId==0? DBNull.Value : purchaseHistory.CategoryId);
            Command.Parameters.AddWithValue("@ItemId", purchaseHistory.ItemId==0? DBNull.Value : purchaseHistory.ItemId);

            List<PurchaseHistoryView> purchases = new List<PurchaseHistoryView>();

            try
            {
                Connection.Open();
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    PurchaseHistoryView purchaseView = new PurchaseHistoryView();
                    purchaseView.PurchaseId = Convert.ToInt32(Reader["PurchaseId"]);
                    purchaseView.VendorId = Convert.ToInt32(Reader["VendorId"]);
                    purchaseView.VendorName = Reader["VendorName"].ToString();
                    purchaseView.CategoryId = Convert.ToInt32(Reader["CategoryId"]);
                    purchaseView.CategoryName = Reader["CategoryName"].ToString();
                    purchaseView.ItemId = Convert.ToInt32(Reader["ItemId"]);
                    purchaseView.ItemName = Reader["ItemName"].ToString();
                    purchaseView.Quantity = Convert.ToInt32(Reader["Quantity"]);
                    purchaseView.UnitPrice = Convert.ToDecimal(Reader["UnitPrice"]);
                    purchaseView.PurchaseDate = Convert.ToDateTime(Reader["PurchaseDate"]);
                    purchases.Add(purchaseView);
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

            return purchases;
        }
    }
}
