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
    // Clase que implementa la interfaz IPrueba para realizar pruebas automatizadas con Selenium
    class CP13 : IPrueba
    {
        // Método que ejecuta las pruebas definidas en esta clase
        public void EjecutarPruebas()
        {
            EliminarTipos();
        }

        // Método que prueba la funcionalidad de eliminar tipos de Pokémon
        private void EliminarTipos()
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
                driver.GetScreenshot().SaveAsFile("./Capturas/CP13-1.jpg");
                // Localizar y hacer clic en el botón "Eliminar" del tipo "Fantasma"
                element = driver.FindElement(By.XPath("/html/body/div/main/div/div[2]/div[6]/div/div/div/div/a[2]"));
                element.Click();
                // Tomar otra captura de pantalla y guardarla en el directorio "Capturas"
                driver.GetScreenshot().SaveAsFile("./Capturas/CP13-2.jpg");
                // Localizar y hacer clic en el botón "Eliminar" de la página de confirmación
                element = driver.FindElement(By.XPath("/html/body/div/main/div/div/div/div[2]/form/button"));
                element.Click();
                // Tomar otra captura de pantalla y guardarla en el directorio "Capturas"
                driver.GetScreenshot().SaveAsFile("./Capturas/CP13-3.jpg");

            }
            finally
            {
                // Cerrar el navegador
                driver.Close();
            }
        }
    }
}
