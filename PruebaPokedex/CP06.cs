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
    class CP06 : IPrueba
    {
        // Método que ejecuta las pruebas definidas en esta clase
        public void EjecutarPruebas()
        {
            EditarRegiones();
        }

        // Método que prueba la funcionalidad de editar una región
        private void EditarRegiones()
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
                driver.GetScreenshot().SaveAsFile("./Capturas/CP06-1.jpg");
                // Localizar y hacer clic en el botón "Editar" de la región "Johto"
                element = driver.FindElement(By.XPath("/html/body/div/main/div/div[2]/div[3]/div/div/div/div/a[1]"));
                element.Click();
                // Tomar otra captura de pantalla y guardarla en el directorio "Capturas"
                driver.GetScreenshot().SaveAsFile("./Capturas/CP06-2.jpg");
                // Localizar el campo "Name", borrar su contenido e ingresar el texto "www"
                element = driver.FindElement(By.Id("Name"));
                element.Clear();
                element.SendKeys("www");
                // Tomar otra captura de pantalla y guardarla en el directorio "Capturas"
                driver.GetScreenshot().SaveAsFile("./Capturas/CP06-3.jpg");
                // Localizar y hacer clic en el botón "Guardar"
                element = driver.FindElement(By.Id("btnGuardar"));
                element.Click();
                // Tomar otra captura de pantalla y guardarla en el directorio "Capturas"
                driver.GetScreenshot().SaveAsFile("./Capturas/CP06-4.jpg");
            }
            finally
            {
                // Cerrar el navegador
                driver.Close();
            }
        }
    }
}
