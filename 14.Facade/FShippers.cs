using _14.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace _14.Facade
{
    public class FShippers
    {
        public static bool Insert(EShipper shipper)
        {
            bool sonuc;
            SqlConnection conn = new SqlConnection(Connection.ConnectionName);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandText = "pr_ShipperAdd";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter parameters = new SqlParameter();

            cmd.Parameters.AddWithValue("CompanyName", shipper.CompanyName);
            cmd.Parameters.AddWithValue("Phone", shipper.CompanyPhone);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                sonuc = cmd.ExecuteNonQuery() > 0 ? true : false;
            }
            catch (Exception)
            {
                sonuc = false;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            return sonuc;
        }

        public static bool Update(EShipper shipper)
        {
            if (shipper == null || string.IsNullOrEmpty(shipper.CompanyName) || shipper.ShipperId <=0 )
            {
                return false;
            }
            bool sonuc;
            SqlConnection conn = new SqlConnection(Connection.ConnectionName);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandText = "pr_ShippherUpdate";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter parameters = new SqlParameter();
            //{
            //    new SqlParameter{ParameterName = "ShipperID", Value=shipper.ShipperId },
            //    new SqlParameter{ParameterName = "CompanyName", Value=shipper.CompanyName },
            //    new SqlParameter{ParameterName = "Phone", Value=shipper.CompanyPhone }
            //};

            cmd.Parameters.AddWithValue("ShipperID", shipper.ShipperId);
            cmd.Parameters.AddWithValue("CompanyName", shipper.CompanyName);
            cmd.Parameters.AddWithValue("Phone", shipper.CompanyPhone);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                sonuc = cmd.ExecuteNonQuery() > 0 ? true : false;
            }
            catch (Exception)
            {
                sonuc = false;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            return sonuc;
        }

        public static bool Delete(int shipperID)
        {
            if (shipperID <= 0)
            {
                return false;
            }
            bool sonuc;
            SqlConnection conn = new SqlConnection(Connection.ConnectionName);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.CommandText = "pr_ShippherDelete";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter parameter = new SqlParameter { ParameterName = "ShipperID", Value = shipperID };

            cmd.Parameters.Add(parameter);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                sonuc = cmd.ExecuteNonQuery() > 0 ? true : false;
            }
            catch (Exception)
            {
                sonuc = false;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            return sonuc;
        }
    }
}

