using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;

namespace capaNegocio
{
    public class NCliente
    {

        //Método Insertar que llama al método insertar de la clase DCliente
        // de la capaDatos

        public static string Insertar(string nombre, string apellidos, string sexo, DateTime fecha_nacimiento,
            string tipo_documento, string num_documento, string direccion, string telefono, string email)
        {
            DCliente Obj = new DCliente();
            Obj.Nombre = nombre;
            Obj.Apellidos = nombre;
            Obj.Sexo = sexo;
            Obj.Fecha_Nacimiento = fecha_nacimiento;
            Obj.Tipo_Documento = tipo_documento;
            Obj.Num_Documento = num_documento;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;

            return Obj.Insertar(Obj);

        }

        //Método Editar que llama al método Editar de la clase DCliente 
        //de la CapaDatos

        public static string Editar(int idcliente,string nombre, string apellidos, string sexo, DateTime fecha_nacimiento,
            string tipo_documento, string num_documento, string direccion, string telefono, string email)
        {
            DCliente Obj = new DCliente();
            Obj.IdCliente = idcliente;
            Obj.Apellidos = nombre;
            Obj.Sexo = sexo;
            Obj.Fecha_Nacimiento = fecha_nacimiento;
            Obj.Tipo_Documento = tipo_documento;
            Obj.Num_Documento = num_documento;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;
            return Obj.Editar(Obj);
        }

        //Método Eliminar que llama al método Eliminar de la clase DCliente
        //de la CapaDatos

        public static string Eliminar(int idcliente)
        {
            DCliente Obj = new DCliente();
            Obj.IdCliente = idcliente;
            return Obj.Eliminar(Obj);

        }

        //Método Mostrar que llama al método Mostrar de la clase DCliente
        //de la CapaDatos

        public static DataTable Mostrar()
        {
            return new DCliente().Mostrar();

        }

     

        public static DataTable BuscarApellidos(string textobuscar)
        {
            DCliente Obj = new DCliente();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarApellidos(Obj);
        }
        public static DataTable BuscarNum_Documento(string textobuscar)
        {
            DCliente     Obj = new DCliente();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNum_Documento(Obj);
        }

    }
}
