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
    class CP09 : IPrueba
    {
        public void EjecutarPruebas()
        {
            EnvioFormularioRegionesVacio();
        }

        // Método que prueba la validación del formulario de crear una nueva región
        private void EnvioFormularioRegionesVacio()
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
                driver.GetScreenshot().SaveAsFile("./Capturas/CP09-1.jpg");
                // Localizar y hacer clic en el botón "Crear Nueva Region"
                element = driver.FindElement(By.LinkText("Crear Nueva Region"));
                element.Click();
                // Tomar otra captura de pantalla y guardarla en el directorio "Capturas"
                driver.GetScreenshot().SaveAsFile("./Capturas/CP09-2.jpg");
                // Localizar y hacer clic en el botón "Guardar" sin llenar ningún campo
                element = driver.FindElement(By.Id("btnGuardar"));
                element.Click();
                // Tomar otra captura de pantalla y guardarla en el directorio "Capturas"
                driver.GetScreenshot().SaveAsFile("./Capturas/CP09-3.jpg");
            }
            finally
            {
                // Cerrar el navegador
                driver.Close();
            }
        }
    }
}
