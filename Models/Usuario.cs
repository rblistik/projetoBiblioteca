namespace Biblioteca.Models
{
public class Usuario
{

    public static int admin = 0;
    public static int padrao=1; 

    public int Id{get;set;}   
    public string Nome{get;set;}
    public string login{get;set;}

    public string senha{get;set;}
    public int Tipo{get;set;}
}
}