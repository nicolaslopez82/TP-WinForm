﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using ConexionDataBase;
using System.Data.SqlClient;

namespace negocio
{
    public class ArticuloNegocio
    {

        private AccesoDatos AccesoDatos = new AccesoDatos();

        public List<Articulo> listar()
         { 
             List<Articulo> lista = new List<Articulo>();
             SqlDataReader lector;

             try
             {               

                AccesoDatos.setearconsulta(ConstantesDB.SQL_QUERY_LISTAR_ARTICULOS.Value);

                 AccesoDatos.ejecutarLectura();

                 while (AccesoDatos.Lector.Read())
                 {
                     Articulo aux = new Articulo();
                     aux.Id = (int)AccesoDatos.Lector["Id"];
                     aux.Codigo = (string)AccesoDatos.Lector["Codigo"];
                     aux.Nombre = (string)AccesoDatos.Lector["Nombre"];
                     aux.Descripcion = (string)AccesoDatos.Lector["Descripcion"];
                     aux.Precio = (decimal)AccesoDatos.Lector["Precio"];
                     if (!(AccesoDatos.Lector["ImagenUrl"] is DBNull))
                         aux.Imagen = (string)AccesoDatos.Lector["ImagenUrl"];
                     aux.Marca = new Marca();
                     aux.Marca.Id = (int)AccesoDatos.Lector["Idmar"];
                     aux.Marca.Descripcion = (string)AccesoDatos.Lector["Desmar"];
                     aux.Categoria = new Catalogo();
                     aux.Categoria.Id = (int)AccesoDatos.Lector["Idcat"];
                     aux.Categoria.Descripcion = (string)AccesoDatos.Lector["Descat"];
                     lista.Add(aux);
                 }
                 AccesoDatos.cerrarConexion();
                 return lista;
             }
             catch (Exception ex)
             {
                throw ex;
             }           
        }
    }
}
