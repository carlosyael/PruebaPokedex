using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using System.Threading;
namespace PruebaPokedex
{
    class CP01 : IPrueba
    {
        // Método que ejecuta las pruebas definidas en esta clase
        public void EjecutarPruebas()
        {
            VerListaTipos();
        }

        // Método que prueba la funcionalidad de ver la lista de tipos de Pokémon y crear un nuevo tipo
        private void VerListaTipos()
        {
            // Crear una instancia del WebDriver para Edge
            var driver = new EdgeDriver();
            try
            {
                // Navegar a la página principal de la aplicación
                driver.Url = "https://localhost:44315/";
                // Maximizar la ventana del navegador
                driver.Manage().Window.Maximize();
                // Localizar y hacer clic en el enlace "Tipos"
                var element = driver.FindElement(By.XPath("/html/body/header/nav/div/div/ul/li[2]/a"));
                element.Click();
                // Tomar una captura de pantalla y guardarla en el directorio "Capturas"
                driver.GetScreenshot().SaveAsFile("./Capturas/CP01-1.jpg");
                // Localizar y hacer clic en el botón "Crear Nuevo Tipo"
                element = driver.FindElement(By.LinkText("Crear Nuevo Tipo"));
                element.Click();
                // Tomar otra captura de pantalla y guardarla en el directorio "Capturas"
                driver.GetScreenshot().SaveAsFile("./Capturas/CP01-2.jpg");
                // Localizar el campo "Name" e ingresar el texto "Dragon"
                element = driver.FindElement(By.Id("Name"));
                element.SendKeys("Dragon");
                // Tomar otra captura de pantalla y guardarla en el directorio "Capturas"
                driver.GetScreenshot().SaveAsFile("./Capturas/CP01-3.jpg");
                // Localizar y hacer clic en el botón "Guardar"
                element = driver.FindElement(By.Id("btnGuardar"));
                element.Click();
                // Tomar otra captura de pantalla y guardarla en el directorio "Capturas"
                driver.GetScreenshot().SaveAsFile("./Capturas/CP01-4.jpg");
            }
            finally
            {
                // Cerrar el navegador
                driver.Close();
            }

        }

    }
}
