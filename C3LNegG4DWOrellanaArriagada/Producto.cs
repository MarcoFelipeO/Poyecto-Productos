using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using C3LDataG4DOrellanaArriagada;



namespace C3LNegG4DWOrellanaArriagada
{
    public class Producto
    {
        int _id;
        int _codigo;
        string _nombre;
        string _proveedor;
        DateTime _fechaadquisicion;
        int _cantidadadquirida;
        int _stock;
        int _nfactura;
        DateTime _fechafactura;
        string _mensaje;
        bool _esExito;
        DataSet _ds = new DataSet();

        public int id { get => _id; set => _id = value; }
        public int codigo { get => _codigo; set => _codigo = value; }
        public string nombre { get => _nombre; set => _nombre = value; }
        public string proveedor { get => _proveedor; set => _proveedor = value; }
        public DateTime fechaadquisicion { get => _fechaadquisicion; set => _fechaadquisicion = value; }
        public int cantidadadquirida { get => _cantidadadquirida; set => _cantidadadquirida = value; }
        public int stock { get => _stock; set => _stock = value; }
        public int nfactura { get => _nfactura; set => _nfactura = value; }
        public DateTime fechafactura { get => _fechafactura; set => _fechafactura = value; }
        public string mensaje { get => _mensaje; set => _mensaje = value; }
        public bool esExito { get => _esExito; set => _esExito = value; }

        public DataSet ds { get => _ds; set => _ds = value; }

        public Producto ingresar(Producto objProducto)
        {
            BasesDatos objDB = new BasesDatos();
            objProducto = objDB.Ingresar(objProducto);
            return objProducto;
        }
        public Producto mostrar(Producto objProducto)
        {
            BasesDatos objDB = new BasesDatos();
            objProducto = objDB.mostrar(objProducto);
            return objProducto;
        }
        public Producto eliminar(Producto objProducto)
        {
            BasesDatos objDB = new BasesDatos();
            objProducto = objDB.eliminar(objProducto);
            return objProducto;
        }
        public Producto modificar(Producto objProducto)
        {
            BasesDatos objDB = new BasesDatos();
            objProducto = objDB.modificar(objProducto);
            return objProducto;
        }
    }
}
