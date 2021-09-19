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
        public static ConstantesDB SQL_QUERY_LISTAR_MARCAS { get { return new ConstantesDB("SELECT * FROM MARCAS"); } }
        public static ConstantesDB SQL_QUERY_LISTAR_CATEGORIAS { get { return new ConstantesDB("SELECT * FROM CATEGORIAS"); } }
        public static ConstantesDB SQL_QUERY_LISTAR_ARTICULOS { get { return new ConstantesDB("SELECT " +
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
                                                "JOIN CATEGORIAS c ON a.IdCategoria = c.Id"); } }
        public static ConstantesDB SQL_QUERY_INSERTAR_CATEGORIAS { get { return new ConstantesDB("Insert into CATEGORIAS (Id, Descripcion) values"); } }
    }
}
