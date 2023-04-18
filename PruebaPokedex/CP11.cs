using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;

namespace PruebaPokedex
{
    class CP11 : IPrueba
    {
        // Método que ejecuta las pruebas definidas en esta clase
        public void EjecutarPruebas()
        {
            EliminarPokemones();
        }

        // Método que prueba la funcionalidad de eliminar un pokemon
        private void EliminarPokemones()
        {
            // Crear una instancia del WebDriver para Edge
            var driver = new EdgeDriver();
            try
            {
                // Navegar a la página principal de la aplicación
                driver.Url = "https://localhost:44315/";
                // Maximizar la ventana del navegador
                driver.Manage().Window.Maximize();
                // Localizar y hacer clic en el enlace "Pokemones"
                var element = driver.FindElement(By.XPath("/html/body/header/nav/div/div/ul/li[1]/a"));
                element.Click();
                // Tomar una captura de pantalla y guardarla en el directorio "Capturas"
                driver.GetScreenshot().SaveAsFile("./Capturas/CP11-1.jpg");
                // Localizar y hacer clic en el botón "Eliminar" del pokemon "Bulbasaur"
                element = driver.FindElement(By.XPath("/html/body/div/main/div/div[2]/div[3]/div/div/div/div/a[2]"));
                element.Click();
                // Tomar otra captura de pantalla y guardarla en el directorio "Capturas"
                driver.GetScreenshot().SaveAsFile("./Capturas/CP11-2.jpg");
                // Localizar y hacer clic en el botón "Eliminar" de la página de confirmación
                element = driver.FindElement(By.XPath("/html/body/div/main/div/div/div/div[2]/form/button"));
                element.Click();
                // Tomar otra captura de pantalla y guardarla en el directorio "Capturas"
                driver.GetScreenshot().SaveAsFile("./Capturas/CP11-3.jpg");

            }
            finally
            {
                // Cerrar el navegador
                driver.Close();
            }
        }
    }
}
