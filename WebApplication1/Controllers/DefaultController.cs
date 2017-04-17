using Helper;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {

            if (!Helper.SessionHelper.ExistUserInSession())
            {
                return View();
            }
            return Redirect("~/");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Autentificar(UsuarioModel usuario) 
        {
            if (ModelState.IsValid)
            {
                // Guardamos un usuario en SESSION, en teoría tiene el ID número 2001
                SessionHelper.AddUserToSession(usuario.Email);
            }
          
            return Redirect("~/");
        }
    
        public ActionResult Autentificado()
        {
           
            if (Helper.SessionHelper.ExistUserInSession())
            {
                return View();
            }
                return Redirect("~/");
           
        }
   
        public ActionResult Logout()
        {
            SessionHelper.DestroyUserSession();
            return Redirect("~/");
        }

        public ActionResult Loading()
        {
            return View();
        }
     

        public ActionResult Validacion()
        {
            return Json(Helper.SessionHelper.ExistUserInSession(), JsonRequestBehavior.AllowGet);
        }
    }
}