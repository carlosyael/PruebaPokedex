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
    class CP10 : IPrueba
    {
        // Método que ejecuta las pruebas definidas en esta clase
        public void EjecutarPruebas()
        {
            EnvioFormularioPokemonParcialmenteLleno();
        }

        // Método que prueba la validación del formulario de crear un nuevo pokemon con algunos campos vacíos
        private void EnvioFormularioPokemonParcialmenteLleno()
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
                driver.GetScreenshot().SaveAsFile("./Capturas/CP10-1.jpg");
                // Localizar y hacer clic en el botón "Crear Nuevo Pokemon"
                element = driver.FindElement(By.LinkText("Crear Nuevo Pokemon"));
                element.Click();
                // Tomar otra captura de pantalla y guardarla en el directorio "Capturas"
                driver.GetScreenshot().SaveAsFile("./Capturas/CP10-2.jpg");
                // Localizar el menú desplegable "RegionId" y seleccionar la opción "kanto"
                IWebElement dropdown = driver.FindElement(By.Id("RegionId"));
                SelectElement select = new SelectElement(dropdown);
                select.SelectByText("kanto");
                // Localizar el menú desplegable "TipoPriId" y seleccionar la opción "fuego"
                dropdown = driver.FindElement(By.Id("TipoPriId"));
                select = new SelectElement(dropdown);
                select.SelectByText("fuego");
                // Localizar el menú desplegable "TipoSecId" y seleccionar la opción "Dragon"
                dropdown = driver.FindElement(By.Id("TipoSecId"));
                select = new SelectElement(dropdown);
                select.SelectByText("Dragon");
                // Tomar otra captura de pantalla y guardarla en el directorio "Capturas"
                driver.GetScreenshot().SaveAsFile("./Capturas/CP10-3.jpg");
                // Localizar y hacer clic en el botón "Guardar" sin llenar los campos "Name" e "ImageUrl"
                element = driver.FindElement(By.Id("btnGuardar"));
                element.Click();
                // Tomar otra captura de pantalla y guardarla en el directorio "Capturas"
                driver.GetScreenshot().SaveAsFile("./Capturas/CP10-4.jpg");
            }
            finally
            {
                // Cerrar el navegador
                driver.Close();
            }
        }
    }
}
