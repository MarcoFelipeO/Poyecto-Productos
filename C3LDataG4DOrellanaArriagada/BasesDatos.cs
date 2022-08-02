using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using C3LNegG4DWOrellanaArriagada;
using C3LDataG4DOrellanaArriagada;


namespace C3LDataG4DOrellanaArriagada
{
    public class BasesDatos
    {
        


       string conn = ConfigurationManager.AppSettings["strConexion"];

        public Producto Ingresar(Producto objProducto)
        {
            //bool esExito = false;
            SqlCommand cmd = new SqlCommand();

            try
            {
                
                cmd.Connection = new SqlConnection(conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "pa_insertar";
                cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = objProducto.codigo;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = objProducto.nombre;
                cmd.Parameters.Add("@proveedor", SqlDbType.VarChar, 50).Value = objProducto.proveedor;
                cmd.Parameters.Add("@fechaadquisicion", SqlDbType.DateTime, 50).Value = objProducto.fechaadquisicion;
                cmd.Parameters.Add("@cantidadadquirida", SqlDbType.Int).Value = objProducto.cantidadadquirida;
                cmd.Parameters.Add("@stock", SqlDbType.Int).Value = objProducto.stock;
                cmd.Parameters.Add("@nfactura", SqlDbType.Int).Value = objProducto.nfactura;
                cmd.Parameters.Add("@fechafactura", SqlDbType.DateTime).Value = objProducto.fechafactura;


                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                objProducto.esExito = true;

            }
            catch (SqlException ex)
            {
                objProducto.mensaje = "Excepcion capturada: " + ex;
                objProducto.esExito = false;
            }
            return objProducto;
        }// Fin ingresar

        public Producto mostrar(Producto objProducto)
        {
           
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            try
            {
               cmd.Connection = new SqlConnection(conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "pa_mostrar";


                cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = objProducto.codigo;
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                sda.Fill(objProducto.ds, "tblProducto");
                cmd.Connection.Close();

            }
            catch (SqlException ex)
            {
                objProducto.mensaje = "Excepcion capturada: " + ex;
            }
            return objProducto;
        }// fin mostrar

        public Producto eliminar(Producto objProducto)
        {
           
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            try
            {

               cmd.Connection = new SqlConnection(conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "pa_eliminar";
                cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = objProducto.codigo;

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                sda.Fill(objProducto.ds, "tblProducto");
                cmd.Connection.Close();
                objProducto.esExito = true;

            }
            catch (SqlException ex)
            {
                objProducto.mensaje = "Excepcion capturada: " + ex;
                objProducto.esExito = false;
            }

            return objProducto;
        }

        public Producto modificar(Producto objProducto)
        {
            
            SqlCommand cmd = new SqlCommand();

            try
            {
               
               cmd.Connection = new SqlConnection(conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "pa_modificar";
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = objProducto.id;
                cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = objProducto.codigo;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = objProducto.nombre;
                cmd.Parameters.Add("@proveedor", SqlDbType.VarChar, 50).Value = objProducto.proveedor;
                cmd.Parameters.Add("@fechaadquisicion", SqlDbType.DateTime, 50).Value = objProducto.fechaadquisicion;
                cmd.Parameters.Add("@cantidadadquirida", SqlDbType.Int).Value = objProducto.cantidadadquirida;
                cmd.Parameters.Add("@stock", SqlDbType.Int).Value = objProducto.stock;
                cmd.Parameters.Add("@nfactura", SqlDbType.Int).Value = objProducto.nfactura;
                cmd.Parameters.Add("@fechafactura", SqlDbType.DateTime).Value = objProducto.fechafactura;

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                objProducto.esExito = true;

            }
            catch (SqlException ex)
            {
                objProducto.mensaje = "Excepcion capturada: " + ex;
                objProducto.esExito = false;
            }
            return objProducto;
        }
    }
}

