using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;


namespace negocio
{
    public class PokemonNegocio
    {
        public List<Pokemon> listar()
        {
            List<Pokemon> lista = new List<Pokemon>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select  p.Numero, p.Nombre,p.Id,p.UrlImagen,p.Descripcion,p.IdTipo,p.IdDebilidad,e.Descripcion as tipo, d.Descripcion as debilidad from POKEMONS as p, elementos as e, ELEMENTOS as d where e.Id = p.IdTipo and d.Id = p.IdDebilidad";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.ID = (int)lector["Id"]; 
                    aux.Numero = lector.GetInt32(0);
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                   // if(!lector.IsDBNull(lector.GetOrdinal("UrlImagen")))
                     //   aux.UrlImagen = (string)lector["UrlImagen"];
                     if(!(lector["UrlImagen"] is DBNull))
                    aux.UrlImagen = (string)lector["UrlImagen"];
                    aux.Tipo = new Elemento();
                    aux.Tipo.id = (int)lector["IdTipo"];
                    aux.Tipo.Descripcion = (string)lector["tipo"];
                    aux.Debilidad = new Elemento();
                    aux.Debilidad.id = (int)lector["IdDebilidad"];
                    aux.Debilidad.Descripcion = (string)lector["debilidad"];
                    lista.Add(aux);
                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void agregar (Pokemon nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into POKEMONS (Numero,Nombre,Descripcion,Activo,IdTipo,IdDebilidad,UrlImagen) values ("+nuevo.Numero +",'" + nuevo.Nombre +"','"+ nuevo.Descripcion + "',1,@idtipo,@idDebilidad,@UrlImagen)");
                datos.setearParametro("@idTipo", nuevo.Tipo.id);
                datos.setearParametro("@idDebilidad", nuevo.Debilidad.id);
                datos.setearParametro("@UrlImagen", nuevo.UrlImagen);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void modificar(Pokemon poke) {
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.setearConsulta("update POKEMONS set Numero = @numero,Nombre = @nombre, Descripcion = @Descripcion,UrlImagen = @UrlImagen,IdTipo = @IdTipo,IdDebilidad = @IdDebilidad where Id = @id");
                datos.setearParametro("@Numero", poke.Numero);
                datos.setearParametro("@Nombre", poke.Nombre);
                datos.setearParametro("@Descripcion", poke.Descripcion);
                datos.setearParametro("@UrlImagen", poke.UrlImagen);
                datos.setearParametro("@IdTipo", poke.Tipo.id);
                datos.setearParametro("@IdDebilidad", poke.Debilidad.id);
                datos.setearParametro("@Id", poke.ID);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
