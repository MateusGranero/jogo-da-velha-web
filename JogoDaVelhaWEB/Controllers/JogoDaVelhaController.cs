using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using JogoDaVelhaWEB.Models;

namespace JogoDaVelhaWEB.Controllers
{
    public class JogoDaVelhaController : Controller
    {
        // GET: JogoDaVelha
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult IniciarJogo(Jogo jogo)//string player1, string player2
        {
            return PartialView("_Jogo",jogo);
        }
    }
}