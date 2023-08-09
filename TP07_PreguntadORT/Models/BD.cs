using System.Data.SqlClient;
using Dapper;

private static string _connectionString = @"Server=localhost; Database=Tp07_PreguntadORT;Trusted_Connection=True";

public static void ObtenerCategorias()
{
    using(SqlConnection db = new SqlConnection(_connectionString)){
    string sql = "SELECT * FROM Categorias";
    _ListadoCategorias = db.Query<Categorias>(sql).ToList();
    }
}

public static void ObtenerDificultades()
{
    using(SqlConnection db = new SqlConnection(_connectionString)){
    string sql = "SELECT * FROM Categorias";
    _ListadoDificultades = db.Query<Dificultades>(sql).ToList();
    }
}

public static void ObtenerPreguntas(int dificultad, int categoria)// no es void
{
    using(SqlConnection db = new SqlConnection(_connectionString)){
    string sql = "SELECT * FROM Categorias";
    _ListadoPreguntas = db.Query<Pregunta>(sql).ToList();
    }
    
}

public static void ObtenerRespuestas(List<Respuesta> Respuestas)// no es void
{
    using(SqlConnection db = new SqlConnection(_connectionString)){
    string sql = "SELECT * FROM Categorias";
    _ListadoRespuestas = db.Query<Respuestas>(sql).ToList();

    }
}
