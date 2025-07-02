using Microsoft.Data.SqlClient;
using Dapper;

public class Integrante
{
    public string nombreUsuario {get; set;}
    public string contraseña {get; set;}

    public string nombre {get; set;}
    public string apellido {get; set;}
    public string fechaNacimiento {get; set;}
    public string DNI {get; set;}

    public string telefono {get; set;}

    public Integrante(string nombreUsuario, string contraseña, string nombre, string apellido, string fechaNacimiento, string DNI, string telefono)
    {
        this.nombreUsuario = nombreUsuario;   
        this.contraseña = contraseña;
        this.nombre = nombre;
        this.apellido = apellido;
        this.fechaNacimiento = fechaNacimiento;
        this.DNI = DNI;
        this.telefono = telefono;
    }
}
