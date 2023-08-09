using Microsoft.AspNetCore.Mvc;

namespace TP07_PreguntadORT.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult ConfigurarJuego()
    {
        Juego.InicializarJuego();
        ViewBag.ConfigurarJuego = BD.ObtenerCategorias();
        ViewBag.ConfigurarJuego = BD.ObtenerDificultades(); 
        return View();
    }
    public IActionResult Comenzar(string username, int dificultad, int categoria){
        If (Juego.CargarPartida() == true) {
          return RedirectToAction("jugar");
        }
        else {
          return RedirectToAction("ConfigurarJuego");
        }
    } 
    [HttpPost] public IActionResult VerificarRespuesta(int idPregunta, int idRespuesta){
      ViewBag = Juego.VerificarRespuesta(idRespuesta);
      return View("resultado");
    } 
    
     public IActionResult Jugar()
     {  
      if(preguntas >= 1){
        return Fin();
      } else{
      ViewBag.Pregunta = Pregunta. 
      ViewBag.Respuestas = Respuesta.
              return Juego();
      } 
    }
}