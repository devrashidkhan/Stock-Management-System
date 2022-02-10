using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockManagementSystem.Models
{
    public class Client:DatabaseGateway
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public List<Client> GetAllClients(int? ClientId)
        {
            string msg = string.Empty;
            if (ClientId == 0 || string.IsNullOrEmpty(ClientId.ToString()))
            {
                Query = @"SELECT * FROM Client";

            }
            else
            {
                Query = @"SELECT * FROM Client c where c.Client=" + ClientId;

            }
            Command = new System.Data.SqlClient.SqlCommand(Query, Connection);
            List<Client> clients = new List<Client>();

            try
            {
                Connection.Open();
                Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    Client client = new Client();
                    client.ClientId = Convert.ToInt32(Reader["ClientId"]);
                    client.Name = Reader["Name"].ToString();
                    client.PhoneNumber = Reader["PhoneNumber"].ToString();
                    clients.Add(client);
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

            return clients;
        }

        public string SaveClient(Client client)
        {
            string msg = string.Empty;
            if (client.ClientId == 0)
            {
                Query = @"INSERT INTO Client VALUES(@Name ,@PhoneNumber)";

            }
            else
            {
                Query = @"update Client 
                             set Name=@Name , PhoneNumber=@PhoneNumber
                           where ClientId=" + client.ClientId;
            }
            Command = new System.Data.SqlClient.SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@Name", client.Name);
            Command.Parameters.AddWithValue("@PhoneNumber", client.PhoneNumber);

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
        public string DeleteClientById(int clientId)
        {
            string msg = string.Empty;
            Query = @"DELETE FROM Client WHERE ClientId=@clientId";


            Command = new System.Data.SqlClient.SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@clientId", clientId);

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
