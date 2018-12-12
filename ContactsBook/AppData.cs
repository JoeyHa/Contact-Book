using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsBook
{
    class AppData
    {
        #region Commands
        public static SqlConnection GetConnection()
        {
            var cn = new SqlConnection(Program.ConnectionString);
            return cn;
        }

        public static SqlCommand GetCommand(string query, SqlConnection cn)
        {
            var cmd = new SqlCommand(query, cn);
            cmd.CommandTimeout = 180;
            return cmd;
        }
        public object ExecuteNonQuery(SqlCommand cmd)
        {
            var cn = cmd.Connection;
            if (cn.State != ConnectionState.Open)
            {
                cn.Open();
            }
            return cmd.ExecuteNonQuery();
        }
        private object ExecScalar(SqlCommand cmd)
        {
            var cn = cmd.Connection;
            if (cn.State != ConnectionState.Open)
            {
                cn.Open();
            }
            return cmd.ExecuteScalar();
        }
        private object ExecuteReader(SqlCommand cmd)
        {
            var cn = cmd.Connection;
            if (cn.State != ConnectionState.Open)
            {
                cn.Open();
            }
            return cmd.ExecuteReader();
        }
        //public static bool IsNullOrEmpty(String str)
        //{
        //    if ((str != null)  || (str.Length > 0))
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }

        //}
        #endregion
        static public DataTable SearchContact(string firstName, string lastName, string phone)
        {
            DataTable dt = null;
            string sql = "SELECT FirstName,LastName,Phone FROM tblContacts where FirstName Like @firstName AND LastName Like @lastName AND Phone LIKE @phone";
            using (SqlConnection cn = GetConnection())
            {
                try
                {
                    cn.Open();
                    using (SqlCommand cmd = GetCommand(sql, cn))
                    {
                        cmd.AddParam("@firstName", SqlDbType.VarChar, "%" + firstName + "%");
                        cmd.AddParam("@lastName", SqlDbType.VarChar, "%" + lastName + "%");
                        cmd.AddParam("@phone", SqlDbType.VarChar, "%" + phone + "%");
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    cn.Close();
                }
            }
            return dt;

        }
        static public int AddContact(string firstName, string lastName, string phone)
        {
            int res = 0;
            bool isExists = ValidatePhoneNumberDup(phone);
            if (isExists)
            {
                return res = -1;
            }
            else
            { 
                string sql = "INSERT INTO tblContacts(FirstName , LastName , Phone , createdAt) VALUES(@firstName, @lastName, @phone, GETDATE())";
                using (SqlConnection cn = GetConnection())
                {
                    try
                    {
                        cn.Open();
                        using (SqlCommand cmd = GetCommand(sql, cn))
                        {
                            cmd.AddParam("@firstName", SqlDbType.VarChar, firstName);
                            cmd.AddParam("@lastName", SqlDbType.VarChar, lastName);
                            cmd.AddParam("@phone", SqlDbType.VarChar, phone);


                            try
                            {
                                int i = cmd.ExecuteNonQuery();
                                if (i != 0)
                                {
                                    return res = i;
                                }
                                else
                                {
                                    return res = 0;
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex);
                            }
                            cn.Close();
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Something wrong..");
                        cn.Close();
                    }
                }
            }
            return res;
        }
        static public DataTable ShowAllContacts()
        {
            DataTable dt = null;
            using (SqlConnection cn = GetConnection())
            {
                cn.Open();
                try
                {
                    using (SqlCommand cmd = GetCommand("SELECT FirstName,LastName,Phone FROM tblContacts ORDER BY FirstName DESC", cn))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
                catch
                {
                    Console.WriteLine("Something went wrong..");
                }
            }
            return dt;
        }
        static public DataTable GetDataFromGrid(string val)
        {
            DataTable dt = null;
            string sql = "SELECT FirstName,LastName,Phone FROM tblContacts where FirstName= '@val' OR LastName='@val' OR Phone='@val'";
            using (SqlConnection cn = GetConnection())
            {
                try
                {
                    cn.Open();
                    using (SqlCommand cmd = GetCommand(sql, cn))
                    {
                        cmd.AddParam("@val", SqlDbType.VarChar, val);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    cn.Close();
                }
            }
            return dt;
        }

        static public bool ValidatePhoneNumberDup(string phone)
        {
            bool IsExsits = false;
            using (SqlConnection cn = GetConnection())
            {
                try
                {
                    cn.Open();
                    using (SqlCommand cmd = GetCommand("SELECT * FROM tblContacts WHERE Phone = @phone", cn))
                    {
                        cmd.AddParam("@phone", SqlDbType.VarChar, phone);
                        try
                        {
                            int i = cmd.ExecuteNonQuery();
                            if (i != 0)
                            {
                                return IsExsits = false;
                            }
                            else
                            {
                                return IsExsits = true;
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                        }
                        cn.Close();
                    }
                }
                catch
                {
                    Console.WriteLine("Something wrong..");
                    cn.Close();
                }
            }
            return IsExsits;
        }
    }
}