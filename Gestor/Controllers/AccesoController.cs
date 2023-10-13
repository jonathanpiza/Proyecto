using Microsoft.AspNetCore.Mvc;
using Admin.Models;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Admin.Controllers
{
    public class AccesoController : Controller
    {
        static string connectionString = "Server=172.16.0.63;Port=3306;Database=NOKIA;Uid=jonathan;password=Ale123456789";
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Logout()
        {
            Console.WriteLine("hola");
            return RedirectToAction("login", "Acceso");
        }

        [HttpPost]
        public IActionResult Login(Usuario user)
        {


            using (MySqlConnection conexion = new MySqlConnection(connectionString)){
                MySqlCommand command = new MySqlCommand();
                command.Connection = conexion;
                command.CommandText = "SELECT id, nombre, pass, permiso FROM Usuarios WHERE nombre=?user";
                command.Parameters.Add("?user", MySqlDbType.VarChar).Value = user.Name;
                conexion.Open();
                var response = command.ExecuteReader();
                
                
            }

            return RedirectToAction("Index", "Home");


            
        }
        
    }
}
