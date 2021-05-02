using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    class DB
    {
        public string connectionString = @"Data Source=DESKTOP-BCE1OBQ\LOCALSERVER;Initial Catalog=INTEC;Integrated Security=True";
        public DataTable Select(string storedProcedure, List<ParametroDB> listaParams)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = storedProcedure;
                    foreach (ParametroDB p in listaParams)
                    {
                        if (!p.esIn)
                        {
                            SqlParameter para = new SqlParameter(p.nombre, p.valor);
                            para.Value = p.valor;
                            para.Direction = ParameterDirection.Output;
                            command.Parameters.Add(para);
                        }
                        else
                        {
                            SqlParameter para = new SqlParameter(p.nombre, p.valor);
                            para.Value = p.valor;
                            command.Parameters.Add(para);
                        }
                    }
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    dataAdapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        public bool Insert(string storedProcedure, List<ParametroDB> listaParams)
        {
            int rows = 0;
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = storedProcedure;
                        foreach (ParametroDB p in listaParams)
                        {
                            if (!p.esIn)
                            {
                                SqlParameter para = new SqlParameter(p.nombre, p.valor);
                                para.Value = p.valor;
                                para.Direction = ParameterDirection.Output;
                                command.Parameters.Add(para);
                            }
                            else
                            {
                                SqlParameter para = new SqlParameter(p.nombre, p.valor);
                                para.Value = p.valor;
                                command.Parameters.Add(para);
                            }
                        }
                        connection.Open();
                        rows = command.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            connection.Close();
                            return true;
                        }
                        else
                        {
                            connection.Close();
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update(string storedProcedure, List<ParametroDB> listaParams)
        {
            try
            {
                int rows = 0;
                DataTable dataTable = new DataTable();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = storedProcedure;
                        foreach (ParametroDB p in listaParams)
                        {
                            if (!p.esIn)
                            {
                                SqlParameter para = new SqlParameter(p.nombre, p.valor);
                                para.Value = p.valor;
                                para.Direction = ParameterDirection.Output;
                                command.Parameters.Add(para);
                            }
                            else
                            {
                                SqlParameter para = new SqlParameter(p.nombre, p.valor);
                                para.Value = p.valor;
                                command.Parameters.Add(para);
                            }
                        }
                        connection.Open();
                        rows = command.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            connection.Close();
                            return true;
                        }
                        else
                        {
                            connection.Close();
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(string storedProcedure, List<ParametroDB> listaParams)
        {
            int rows = 0;
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = storedProcedure;
                    foreach (ParametroDB p in listaParams)
                    {
                        if (!p.esIn)
                        {
                            SqlParameter para = new SqlParameter(p.nombre, p.valor);
                            para.Value = p.valor;
                            para.Direction = ParameterDirection.Output;
                            command.Parameters.Add(para);
                        }
                        else
                        {
                            SqlParameter para = new SqlParameter(p.nombre, p.valor);
                            para.Value = p.valor;
                            command.Parameters.Add(para);
                        }
                    }
                    connection.Open();
                    rows = command.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        connection.Close();
                        return true;
                    }
                    else
                    {
                        connection.Close();
                        return false;
                    }
                }
            }
        }
    }
}
