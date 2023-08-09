class Juego{
    private static string _username{get;set;}
    private static int _puntajeActual{get;set;}
    private static int _cantidadPreguntasCorrectas{get;set;}
    private static List<Pregunta> _preguntas{get;set;}
    private static List<Respuesta> _respuestas{get;set;}
    
    public static void InicializarJuego(){
        _username = ""; 
        _puntajeActual = 0;
        _cantidadPreguntasCorrectas = 0;
    }
    public static List<Categorias> ObtenerCategorias(){
        return BD.ObtenerCategorias();
    }
    public static List<Dificultades> ObtenerDificultades(){
        return BD.ObtenerDificultades();
    }
    public static void CargarPartida(string username, int dificultad, int categoria){
        _preguntas = BD.ObtenerPreguntas(dificultad, categoria);
        _respuestas = BD.ObtenerRespuestas();
    }
    public static _preguntas ObtenerProximaPregunta(){
        if(){
              return ;
        }
        else {
           return ;
        }
        return ;  
    }
    public static _respuestas ObtenerProximasRespuestas(int idPregunta){ 
        foreach (int idPregunta in _respuestas)
        {
            _respuestas.add(idRespuesta);
        }
        return _respuestas;
    }
    public static void VerificarRespuesta(int idPregunta, int idRespuesta){
    
    }

}
