using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;

namespace capaNegocio
{
    public class NProveedor
    {
        //Método Insertar que llama al método insertar de la clase DProveedor
        // de la capaDatos

        public static string Insertar(string razonsocial, string sector_comercial,string tipo_documento,string num_documento,string direccion,string telefono,string email,string url)
        {
            DProveedor Obj = new DProveedor();
            Obj.Razon_Social = razonsocial;
            Obj.Sector_Comercial =sector_comercial;
            Obj.Tipo_Documento = tipo_documento;
            Obj.Num_Documento = num_documento;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;
            Obj.Url = url;
            
            return Obj.Insertar(Obj);

        }

        //Método Editar que llama al método Editar de la clase DCategoria 
        //de la CapaDatos

        public static string Editar(int idproveedor, string razonsocial, string sector_comercial, string tipo_documento, string num_documento, string direccion, string telefono, string email, string url)
        {
            DProveedor Obj = new DProveedor();
            Obj.Idproveedor = idproveedor;
            Obj.Razon_Social = razonsocial;
            Obj.Sector_Comercial =sector_comercial;
            Obj.Tipo_Documento = tipo_documento;
            Obj.Num_Documento = num_documento;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;
            Obj.Url = url;

            return Obj.Editar(Obj);
        }

        //Método Eliminar que llama al método Eliminar de la clase DCategoría
        //de la CapaDatos

        public static string Eliminar(int idproveedor)
        {
            DProveedor Obj = new DProveedor();
            Obj.Idproveedor = idproveedor;
            return Obj.Eliminar(Obj);

        }

        //Método Mostrar que llama al método Mostrar de la clase DProveedor
        //de la CapaDatos

        public static DataTable Mostrar()
        {
            return new DProveedor().Mostrar();

        }

        //


        //Método BuscarRazon_Social que llama al método BuscarRazon_Social
        //de la clase DProveedor de la capaDatos

        public static DataTable BuscarRazon_social(string textobuscar)
        {
            DProveedor Obj = new DProveedor();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarRazon_Social(Obj);
        }

        //Método BuscarNumdocumento que llama al método Buscarnum_documento
        //de la clase DProveedor de la CapaDatos

        public static DataTable BuscarNum_Documento(string textobuscar)
        {
            DProveedor Obj = new DProveedor();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNum_Documento(Obj);
        }

    }
}
