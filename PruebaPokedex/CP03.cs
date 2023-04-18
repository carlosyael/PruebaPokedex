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
    class CP03 : IPrueba
    {
        // Método que ejecuta las pruebas definidas en esta clase
        public void EjecutarPruebas()
        {
            VerListaRegiones();
        }

        // Método que prueba la funcionalidad de ver la lista de regiones y crear una nueva región
        private void VerListaRegiones()
        {
            // Crear una instancia del WebDriver para Edge
            var driver = new EdgeDriver();
            try
            {
                // Navegar a la página principal de la aplicación
                driver.Url = "https://localhost:44315/";
                // Maximizar la ventana del navegador
                driver.Manage().Window.Maximize();
                // Localizar y hacer clic en el enlace "Regiones"
                var element = driver.FindElement(By.XPath("/html/body/header/nav/div/div/ul/li[3]/a"));
                element.Click();
                // Tomar una captura de pantalla y guardarla en el directorio "Capturas"
                driver.GetScreenshot().SaveAsFile("./Capturas/CP03-1.jpg");
                // Localizar y hacer clic en el botón "Crear Nueva Region"
                element = driver.FindElement(By.LinkText("Crear Nueva Region"));
                element.Click();
                // Tomar otra captura de pantalla y guardarla en el directorio "Capturas"
                driver.GetScreenshot().SaveAsFile("./Capturas/CP03-2.jpg");
                // Localizar el campo "Name" e ingresar el texto "Santo Domingo"
                element = driver.FindElement(By.Id("Name"));
                element.SendKeys("Santo Domingo");
                // Tomar otra captura de pantalla y guardarla en el directorio "Capturas"
                driver.GetScreenshot().SaveAsFile("./Capturas/CP03-3.jpg");
                // Localizar y hacer clic en el botón "Guardar"
                element = driver.FindElement(By.Id("btnGuardar"));
                element.Click();
                // Tomar otra captura de pantalla y guardarla en el directorio "Capturas"
                driver.GetScreenshot().SaveAsFile("./Capturas/CP03-4.jpg");
            }
            finally
            {
                // Cerrar el navegador
                driver.Close();
            }
        }
    }
}
