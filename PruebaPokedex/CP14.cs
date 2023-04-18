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
    class CP14 : IPrueba
    {
        public void EjecutarPruebas()
        {
            CrearPokemones();
        }
        // Método que prueba la funcionalidad crear un nuevo pokemon
        private void CrearPokemones()
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
                driver.GetScreenshot().SaveAsFile("./Capturas/CP14-1.jpg");
                // Localizar y hacer clic en el botón "Crear Nuevo Pokemon"
                element = driver.FindElement(By.LinkText("Crear Nuevo Pokemon"));
                element.Click();
                // Tomar otra captura de pantalla y guardarla en el directorio "Capturas"
                driver.GetScreenshot().SaveAsFile("./Capturas/CP14-2.jpg");
                // Localizar el campo "Name" e ingresar el texto "PokemonNuevo"
                element = driver.FindElement(By.Id("Name"));
                element.SendKeys("PokemonNuevo");
                // Localizar el campo "ImageUrl" e ingresar el texto "https://assets.pokemon.com/assets/cms2/img/pokedex/full/015.png"
                element = driver.FindElement(By.Id("ImageUrl"));
                element.SendKeys("https://assets.pokemon.com/assets/cms2/img/pokedex/full/015.png");
                // Localizar el menú desplegable "RegionId" y seleccionar la opción "kanto"
                IWebElement dropdown = driver.FindElement(By.Id("RegionId"));
                SelectElement select = new SelectElement(dropdown);
                select.SelectByText("kanto");
                // Localizar el menú desplegable "TipoPriId" y seleccionar la opción "Agua"
                dropdown = driver.FindElement(By.Id("TipoPriId"));
                select = new SelectElement(dropdown);
                select.SelectByText("Agua");
                // Localizar el menú desplegable "TipoSecId" y seleccionar la opción "Dragon"
                dropdown = driver.FindElement(By.Id("TipoSecId"));
                select = new SelectElement(dropdown);
                select.SelectByText("Dragon");
                // Tomar otra captura de pantalla y guardarla en el directorio "Capturas"
                driver.GetScreenshot().SaveAsFile("./Capturas/CP14-3.jpg");
                // Localizar y hacer clic en el botón "Guardar"
                element = driver.FindElement(By.Id("btnGuardar"));
                element.Click();
                // Tomar otra captura de pantalla y guardarla en el directorio "Capturas"
                driver.GetScreenshot().SaveAsFile("./Capturas/CP14-4.jpg");
            }
            finally
            {
                driver.Close();
            }
        }
    }
}
