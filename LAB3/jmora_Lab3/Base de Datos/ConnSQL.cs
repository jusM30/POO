﻿using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows;
using jmora_Lab3.Utilidades;

namespace jmora_Lab3.Base_de_Datos
{
    class ConnSQL
    {
        public SqlDataReader SQLCargaDataReader(string _SQLConnection, string SQLQuery)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand sqlCommand = new SqlCommand(SQLQuery, cn);
            SqlDataReader dr;

            try
            {
                cn = new SqlConnection(_SQLConnection);
                if ((cn.State == ConnectionState.Closed))
                {
                    cn.Open();
                }

                sqlCommand = new SqlCommand(SQLQuery, cn);
                sqlCommand.CommandTimeout = 300;

                dr = sqlCommand.ExecuteReader();
                cn.Close();

                return dr;
            }
            catch (Exception ex)
            {
                variablesGlobales.log = new escribirLog(ex.Message, false);
                throw ex;
                cn.Close();
            }

        }
        public void SQLCargaDataSet(string _SQLConnection, ref DataSet ds, string SQLQuery)
        {
            SqlConnection cn = new SqlConnection(_SQLConnection);
            try
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(SQLQuery, cn);
                adaptador.Fill(ds);
                cn.Close();
            }
            catch (Exception ex)
            {
                variablesGlobales.log = new escribirLog(ex.Message, false);
                throw ex;
            }
        }

        public string SQLExecuteCmm(string _SQLConnection, string SQLQuery)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand sqlCommand = new SqlCommand(SQLQuery, cn);

            try
            {
                cn = new SqlConnection(_SQLConnection);
                if ((cn.State == ConnectionState.Closed))
                {
                    cn.Open();
                }

                sqlCommand = new SqlCommand(SQLQuery, cn);
                sqlCommand.CommandTimeout = 180;

                sqlCommand.ExecuteNonQuery();
                cn.Close();
                return "01";
            }
            catch (Exception ex)
            {
                variablesGlobales.log = new escribirLog(ex.Message, false);
                cn.Close();
                return "02";
            }
        }

        public DataTable SQLCargaDataTable(string _SQLConnection, string SQLQuery, DataTable dt)
        {
            SqlConnection cmd = new SqlConnection(_SQLConnection);
            dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(SQLQuery, cmd);
                dt = new DataTable();
                da.Fill(dt);
                cmd.Dispose();
                return dt;
            }
            catch (Exception ex)
            {
                variablesGlobales.log = new escribirLog(ex.Message, false);
                return dt;
            }

            finally
            {
                cmd.Dispose();
            }

        }
    }
}
