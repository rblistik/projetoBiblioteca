using System.Collections.Generic;
using System.Linq;

namespace Biblioteca.Models
{

public class UsuarioService
{
 public list <Usuario> Listar()
{
    using (BibliotecaContext bc= new BibliotecaContext())
    {
    return bc.Usuarios.ToList();
    }
}

public Usuario Listar(int id)
{
    using (BibliotecaContext bc= new BibliotecaContext())
    {
    return bc.Usuarios.find(id);
    }
}





public void incluirUsuario(Usuario u)
{
      using (BibliotecaContext bc= new BibliotecaContext())
   {
       bc.Add(u);
       bc.SaveChanges();

   }
{
    
}
public void editarUsuario(Usuario Editu)
{
    using (BibliotecaContext bc= new BibliotecaContext())
    {
       Usuario antigoU=bc.Usuarios.find(EditU.id);
       antigoU.Login=EditU.Login;
       antigoU.Nome=EditU.Nome;
       antigoU.Senha=EditU.Senha;
       antigoU.Tipo=EditU.Tipo;
       bc.SaveChanges();
    }
}
private static void excluirUsuario(int id)
        {
            using (BibliotecaContext bc = new BibliotecaContext())
            {
                bc.Usuarios.Remove(bc.Usuarios.Find(id));
                bc.SaveChanges();
            }
        }
 


