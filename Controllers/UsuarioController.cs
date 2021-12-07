using Microsoft.AspNetCore.Mvc;
using Biblioteca.Models;

namespace Biblioteca.Controllers
{
  public class UsuarioController:Controller
  {
//lista
public IActionResult listadeUsuarios()
{
  Autenticacao.CheckLogin(this);
  Autenticacao.verificaSeUsuarioEAdmin(this);
  return View(new UsuarioService().Listar());
}

public IActionResult RegistraUsuario()
{
  Autenticacao.CheckLogin(this);
  Autenticacao.verificaSeUsuarioEAdmin(this);
  return View();
}
[HttpPost]
public IActionResult RegistraUsuario(Usuario novoUsuario)
{
novoUsuario.Senha=Criptografo.TextoCriptografado(novoUsuario.Senha);
new UsuarioService().incluirUsuario(novoUsuario);
return RedirectToAction("Cadastro Realizado");

}
public IActionResult CadastroRealizado()
{

    return View();
}

public IActionResult EditarUsuario(int id)
{
Usuario u=new UsuarioService().EditarUsuario(userEditado);
return RedirectToAction("ListaDeUsuarios");
}
public IActionResult ExcluirUsuario(int id)
{
return View(new UsuarioService().Listar(id));

[HttpPost]
public IActionResult ExcluirUsuario(string decisao,int id)
{

    if (decisao== "EXCLUIR")
    {
     ViewData["Mensagem"]="Exclusao Usuario" + new UsuarioService().Listar(id).Nome+"realizada com sucesso"
     new UsuarioService().ExcluirUsuario(id);
     return View("Listade Usuarios", new UsuarioService().Listar());
    }
    else
    {
     ViewData["Mensagem"]="Exclusao Cancelada"
     return View("Listade Usuarios", new UsuarioService().Listar());

    }


}

}
public IActionResult Sair()
 {
   HttpContext.Session.Clear();
   RedirectToAction("Index", "Home");
 }
public IActionResult NeedAdmin()
 {

     Autenticacao.CheckLogin(this);
     return View();
 }

  }



}