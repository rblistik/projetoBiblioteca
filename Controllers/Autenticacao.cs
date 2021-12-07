using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Biblioteca.Models;
using System.Linq;
using System.Collections.Generic;


namespace Biblioteca.Controllers
{
    public class Autenticacao
    {
        public static void CheckLogin(Controller controller)
        {   
            if(string.IsNullOrEmpty(controller.HttpContext.Session.GetString("login")))
            {
                controller.Request.HttpContext.Response.Redirect("/Home/Login");
            }
        }
    }
        public static void verificaSeUsuarioAdminExiste(BiliotecaContext.bc)
          {
           IQueryable<Usuario> userEcontrado=bc.Usuarios.Where(u =>u.Login=="admin");
            if(userEcontrado.ToList().Count==0)
            {
             Usuario.admin=new Usuario();
             admin.Login="Admin";
             admin.Senha=Criptografo.TextoCriptografado("123");
             admin.Tipo=Usuario.admin;
             admin.Nome="Administrador";

             bc.Usuarios.Add(admin);
             bc.SaveChanges();




            }


          }







    public static bool verificaLoginSenha(string Login,string senha,Controller controller)
    {

        using(BibliotecaContext bc=new BibliotecaContext())
            {

                verificaSeUsuarioAdminExiste(bc);
                senha=Criptografo.TextoCriptografado(senha);
                IQueryable<Usuario> UsuarioEncontrado= bc.Usuarios.where(u=>u.Login==login && u.Senha==senha);
                List<Usuario> ListaUsuarioEncontrado=UsuarioEncontrado.ToList();
                
                if(ListaUsuarioEncontrado.Count==0)
                 {
                     return false;
                 }

                     else

                 {
                   controller.HttpContext.Session.SetString("Login",ListaUsuarioEncontrado[0].Login);
                   controller.HttpContext.Session.SetString("Nome",ListaUsuarioEncontrado[0].Nome);
                   controller.HttpContext.Session.SetInt32("Tipo",ListaUsuarioEncontrado[0].Tipo);
                   return true;
                 }







                if (userEncontrado.ToList()==0)
                {
                    admin.login="admin";
                    admin.senha=Criptografo.TextoCriptografado("123");
                    admin.Tipo= Usuario.admin;
                    admin.Nome= "Administrador";

                    bc.Usuarios.Add(admin);
                    bc.SaveChanges();
                 
                }
                public static void verificaSeUsuarioEAdmin(Controller controller)
                {
                 if(!Controller.HttpContext.Session.GetInt32("tipo")==Usuario.admin)
                      {
                          controller.Request.HttpContext.Response.Redirect("/Usuarios/NeedAdmin");
                      }

                }
            }
    }
}