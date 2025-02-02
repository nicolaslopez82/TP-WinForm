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

        public void agregar(Articulo nuevo)
        {            
            AccesoDatos.setearconsulta(ConstantesDB.SQL_QUERY_INSERTAR_ARTICULOS.Value);

            try
            {                
                AccesoDatos.setearParametro("@Codigo", nuevo.Codigo);
                AccesoDatos.setearParametro("@Nombre", nuevo.Nombre);
                AccesoDatos.setearParametro("@Descripcion", nuevo.Descripcion);
                AccesoDatos.setearParametro("@IdMarca", nuevo.Marca.Id);
                AccesoDatos.setearParametro("@IdCategoria", nuevo.Categoria.Id);
                AccesoDatos.setearParametro("@ImagenUrl", nuevo.Imagen);
                AccesoDatos.setearParametro("@Precio", nuevo.Precio);
                AccesoDatos.ejecturarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                AccesoDatos.cerrarConexion();
            }
        }

        public void modificar(Articulo modificar)
        {
            AccesoDatos.setearconsulta(ConstantesDB.SQL_QUERY_MODIFICAR_ARTICULO.Value);

            try
            {
                AccesoDatos.setearParametro("@Id", modificar.Id);
                AccesoDatos.setearParametro("@Codigo", modificar.Codigo);
                AccesoDatos.setearParametro("@Nombre", modificar.Nombre);
                AccesoDatos.setearParametro("@Descripcion", modificar.Descripcion);
                AccesoDatos.setearParametro("@IdMarca", modificar.Marca.Id);
                AccesoDatos.setearParametro("@IdCategoria", modificar.Categoria.Id);
                AccesoDatos.setearParametro("@ImagenUrl", modificar.Imagen);
                AccesoDatos.setearParametro("@Precio", modificar.Precio);
                AccesoDatos.ejecturarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                AccesoDatos.cerrarConexion();
            }
        }

        public void Eliminar(Articulo eliminar)
        {
            AccesoDatos.setearconsulta(ConstantesDB.SQL_QUERY_ELIMINAR_ARTICULO.Value);

            try
            {
                AccesoDatos.setearParametro("@Id", eliminar.Id);
               /* AccesoDatos.setearParametro("@Codigo", eliminar.Codigo);
                AccesoDatos.setearParametro("@Nombre", eliminar.Nombre);
                AccesoDatos.setearParametro("@Descripcion", eliminar.Descripcion);
                AccesoDatos.setearParametro("@IdMarca", eliminar.Marca.Id);
                AccesoDatos.setearParametro("@IdCategoria", eliminar.Categoria.Id);
                AccesoDatos.setearParametro("@ImagenUrl", eliminar.Imagen);
                AccesoDatos.setearParametro("@Precio", eliminar.Precio);*/
                AccesoDatos.ejecturarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                AccesoDatos.cerrarConexion();
            }
        }
    }
}
