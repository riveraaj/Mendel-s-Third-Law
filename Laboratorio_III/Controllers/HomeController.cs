using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Laboratorio_III.Models;
using System.Collections.Generic;

namespace Laboratorio_III.Controllers
{
    public class HomeController : Controller
    {
        ModelImage OModelImage = new ();
        ModelCount OModelCount = new();
        Random Rand = new ();

        public IActionResult Index()
        {
            OModelCount.Message = "";
            OModelCount.Component = Rand.Next(1, 20);
            OModelCount.Path = OModelImage.OrganicCompounds[OModelCount.Component].path;
            OModelCount.Correct = (OModelCount.Correct == 0) ? 0 : OModelCount.Correct;
            OModelCount.Incorrect = (OModelCount.Incorrect == 0) ? 0 : OModelCount.Incorrect;
            return View(OModelCount);
        }

        [HttpPost]
        public IActionResult Index(ModelCount data)
        {
            string upperName = data.Name.ToUpper();
            if (upperName.Equals(OModelImage.OrganicCompounds[data.Component].name))
            {
                OModelCount.Correct = data.Correct + 1;
                OModelCount.Incorrect = data.Incorrect;
                OModelCount.Message = "Respuesta Correcta, Felizidades!";
            }
            else
            {
                OModelCount.Incorrect = data.Incorrect + 1;
                OModelCount.Correct = data.Correct;
                OModelCount.Message = "Respuesta incorrecta. Puede volver a intentarlo!";
            }


            if (Request.Form["Check"] == "on")
            {
                OModelCount.Component = Rand.Next (1, 20);
                OModelCount.Path = OModelImage.OrganicCompounds[OModelCount.Component].path;
            } 
            else
            {
                OModelCount.Path = data.Path;
                OModelCount.Component = data.Component;
            }
            return View(OModelCount);
        }
    }
}