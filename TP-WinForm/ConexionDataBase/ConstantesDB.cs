using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace ConexionDataBase
{
    public class ConstantesDB
    {
        private ConstantesDB(string value) { Value = value; }

        public string Value { get; set; }

        public static ConstantesDB SQL_CONNECTION_CONEXION { get { return new ConstantesDB("server =.\\SQLEXPRESS; database = CATALOGO_DB; integrated security = true"); } }       
        public static ConstantesDB SQL_QUERY_LISTAR_ARTICULOS { get { return new ConstantesDB(
                    
                    "SELECT " +
                        "a.Id, " +
                        "a.Codigo, " +
                        "a.Nombre, " +
                        "a.Descripcion, " +
                        "a.Precio, " +
                        "a.ImagenUrl, " +
                        "m.Descripcion as Desmar, " +
                        "m.id as Idmar, " +
                        "c.Descripcion as Descat, " +
                        "c.Id as Idcat " +
                     "FROM ARTICULOS a " +
                        "JOIN MARCAS m ON a.IdMarca = m.Id " +
                        "JOIN CATEGORIAS c ON a.IdCategoria = c.Id"); } 
        }
        public static ConstantesDB SQL_QUERY_INSERTAR_ARTICULOS { get { return new ConstantesDB(
                        "INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) " +
                        "VALUES (@Codigo,@Nombre,@Descripcion,@IdMarca,@IdCategoria,@ImagenUrl,@Precio)"); } }
        public static ConstantesDB SQL_QUERY_MODIFICAR_ARTICULO { get { return new ConstantesDB(
                        "UPDATE ARTICULOS " +
                        "SET Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, " +
                        "IdCategoria = @IdCategoria, ImagenUrl = @ImagenUrl, Precio = @Precio " + 
                        "WHERE Id = @Id"); }
        }
        public static ConstantesDB SQL_QUERY_ELIMINAR_ARTICULO{ get { return new ConstantesDB(
                        "DELETE FROM ARTICULOS " +
                        "WHERE Id = @Id");
            }
        }

        public static ConstantesDB SQL_QUERY_BUSQUEDA_ARTICULO_CODIGO { get { return new ConstantesDB("SELECT Codigo FROM ARTICULOS"); } }
        public static ConstantesDB SQL_QUERY_BUSQUEDA_ARTICULO_NOMBRE { get { return new ConstantesDB("SELECT Nombre FROM ARTICULOS"); } }
        public static ConstantesDB SQL_QUERY_BUSQUEDA_ARTICULO_DESCRIPCION { get { return new ConstantesDB("SELECT Descripcion FROM ARTICULOS"); } }
        public static ConstantesDB SQL_QUERY_BUSQUEDA_ARTICULO_PRECIO { get { return new ConstantesDB("SELECT Precio FROM ARTICULOS"); } }
        public static ConstantesDB SQL_QUERY_BUSQUEDA_ARTICULO_MARCAS { get { return new ConstantesDB("SELECT Descripcion FROM MARCAS"); } }
        public static ConstantesDB SQL_QUERY_BUSQUEDA_ARTICULO_CATEGORIAS { get { return new ConstantesDB("SELECT Descripcion FROM CATEGORIAS"); } }

        public static ConstantesDB SQL_QUERY_BUSCAR_ARTICULOS { get { return new ConstantesDB(

                    "SELECT " +
                    "a.Id, " +
                    "a.Codigo, " +
                    "a.Nombre, " +
                    "a.Descripcion, " +
                    "a.Precio, " +
                    "a.ImagenUrl, " +
                    "m.Descripcion as Desmar, " +
                    "m.id as Idmar, " +
                    "c.Descripcion as Descat, " +
                    "c.Id as Idcat " +
                    "FROM ARTICULOS a " +
                        "JOIN MARCAS m ON a.IdMarca = m.Id " +
                        "JOIN CATEGORIAS c ON a.IdCategoria = c.Id " +
                    "WHERE a.Codigo = @Codigo");
            }
        }
    }
}
