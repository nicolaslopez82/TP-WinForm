using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using ConexionDataBase;

namespace negocio
{
    public class BusquedaNegocio
    {
        private AccesoDatos AccesoDatos = new AccesoDatos();

        public List<String> ListarCodigos()
        {
            List<String> CodigosList = new List<String>();

            try
            {
                AccesoDatos.setearconsulta(ConstantesDB.SQL_QUERY_BUSQUEDA_ARTICULO_CODIGO.Value);

                AccesoDatos.ejecutarLectura();

                while (AccesoDatos.Lector.Read())
                {
                    CodigosList.Add((string)AccesoDatos.Lector["Codigo"]);
                }
                AccesoDatos.cerrarConexion();
                return CodigosList;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<String> ListarNombres()
        {
            List<String> NombresList = new List<String>();

            try
            {
                AccesoDatos.setearconsulta(ConstantesDB.SQL_QUERY_BUSQUEDA_ARTICULO_NOMBRE.Value);

                AccesoDatos.ejecutarLectura();

                while (AccesoDatos.Lector.Read())
                {
                    NombresList.Add((string)AccesoDatos.Lector["Nombre"]);
                }
                AccesoDatos.cerrarConexion();
                return NombresList;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<String> ListarDescripciones()
        {
            List<String> DescripcionesList = new List<String>();

            try
            {
                AccesoDatos.setearconsulta(ConstantesDB.SQL_QUERY_BUSQUEDA_ARTICULO_DESCRIPCION.Value);

                AccesoDatos.ejecutarLectura();

                while (AccesoDatos.Lector.Read())
                {
                    DescripcionesList.Add((string)AccesoDatos.Lector["Descripcion"]);
                }
                AccesoDatos.cerrarConexion();
                return DescripcionesList;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<String> ListarMarcas()
        {
            List<String> MarcasList = new List<String>();

            try
            {
                AccesoDatos.setearconsulta(ConstantesDB.SQL_QUERY_BUSQUEDA_ARTICULO_MARCAS.Value);

                AccesoDatos.ejecutarLectura();

                while (AccesoDatos.Lector.Read())
                {
                    MarcasList.Add((string)AccesoDatos.Lector["Descripcion"]);
                }
                AccesoDatos.cerrarConexion();
                return MarcasList;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<String> ListarCategorias()
        {
            List<String> CategoriasList = new List<String>();

            try
            {
                AccesoDatos.setearconsulta(ConstantesDB.SQL_QUERY_BUSQUEDA_ARTICULO_CATEGORIAS.Value);

                AccesoDatos.ejecutarLectura();

                while (AccesoDatos.Lector.Read())
                {
                    CategoriasList.Add((string)AccesoDatos.Lector["Descripcion"]);
                }
                AccesoDatos.cerrarConexion();
                return CategoriasList;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<decimal> listarPrecios()
        {
            List<decimal> PreciosList = new List<decimal>();

            try
            {
                AccesoDatos.setearconsulta(ConstantesDB.SQL_QUERY_BUSQUEDA_ARTICULO_PRECIO.Value);

                AccesoDatos.ejecutarLectura();

                while (AccesoDatos.Lector.Read())
                {
                    PreciosList.Add((decimal)AccesoDatos.Lector["Precio"]);
                }
                AccesoDatos.cerrarConexion();
                return PreciosList;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();

            try
            {
                AccesoDatos.setearconsulta(ConstantesDB.SQL_QUERY_LISTAR_ARTICULOS.Value);

                AccesoDatos.ejecutarLectura();

                while (AccesoDatos.Lector.Read())
                {

                }

                AccesoDatos.cerrarConexion();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Articulo> BuscarArticulos(String query, String codigo) 
        {
            List<Articulo> ArticulosList = new List<Articulo>();

            try
            {
                AccesoDatos.setearconsulta(query);
                AccesoDatos.setearParametro("@Codigo", codigo);
                AccesoDatos.ejecutarLectura();

                while (AccesoDatos.Lector.Read()) 
                {
                    Articulo articulo = new Articulo();
                    articulo.Id = (int)AccesoDatos.Lector["Id"];
                    articulo.Codigo = (string)AccesoDatos.Lector["Codigo"];
                    articulo.Nombre = (string)AccesoDatos.Lector["Nombre"];
                    articulo.Descripcion = (string)AccesoDatos.Lector["Descripcion"];
                    articulo.Precio = (decimal)AccesoDatos.Lector["Precio"];
                    if (!(AccesoDatos.Lector["ImagenUrl"] is DBNull))
                        articulo.Imagen = (string)AccesoDatos.Lector["ImagenUrl"];
                    articulo.Marca = new Marca();
                    articulo.Marca.Id = (int)AccesoDatos.Lector["Idmar"];
                    articulo.Marca.Descripcion = (string)AccesoDatos.Lector["Desmar"];
                    articulo.Categoria = new Catalogo();
                    articulo.Categoria.Id = (int)AccesoDatos.Lector["Idcat"];
                    articulo.Categoria.Descripcion = (string)AccesoDatos.Lector["Descat"];
                    ArticulosList.Add(articulo);
                }
                AccesoDatos.cerrarConexion();
                return ArticulosList;
            }
            catch (Exception ex)
            {
               throw ex;
            }
        }
    }
}
