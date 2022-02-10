using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockManagementSystem.Models
{
    public class Vendor:DatabaseGateway
    {
        public int? VendorId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public List<Vendor> GetAllVendor(int? vendorId)
        {
            string msg = string.Empty;
            if (vendorId==0||string.IsNullOrEmpty(vendorId.ToString()))
            {
                Query = @"SELECT * FROM Vendor";

            }
            else
            {
                Query = @"SELECT * FROM Vendor v where v.VendorId="+vendorId;

            }
            Command = new System.Data.SqlClient.SqlCommand(Query, Connection);
            List<Vendor> vendors = new List<Vendor>();

            try
            {
                Connection.Open();
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    Vendor vendor = new Vendor();
                    vendor.VendorId = Convert.ToInt32(Reader["VendorId"]);
                    vendor.Name = Reader["Name"].ToString();
                    vendor.PhoneNumber = Reader["PhoneNumber"].ToString();
                    vendors.Add(vendor);
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

            return vendors;
        }
        public string SaveVendor(Vendor vendor)
        {
            string msg = string.Empty;
            if (vendor.VendorId == 0)
            {
                Query = @"INSERT INTO Vendor VALUES(@Name ,@PhoneNumber)";

            }
            else
            {
                Query = @"update Vendor 
                             set Name=@Name , PhoneNumber=@PhoneNumber
                           where VendorId="+vendor.VendorId;
            }
            Command = new System.Data.SqlClient.SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@Name", vendor.Name);
            Command.Parameters.AddWithValue("@PhoneNumber", vendor.PhoneNumber);

            try
            {
                Connection.Open();
                int effectedRow = Command.ExecuteNonQuery();
                msg = effectedRow + " record has been Saved!!";
            }
            catch (Exception ex)
            {

                msg=ex.Message;
            }
            finally
            {
                Connection.Close();
            }

            return msg;
        }

        public string DeleteVendorById(int vendorId)
        {
            string msg = string.Empty;
            Query = @"DELETE FROM Vendor WHERE VendorId=@vendorId";

           
            Command = new System.Data.SqlClient.SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@vendorId", vendorId);

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
