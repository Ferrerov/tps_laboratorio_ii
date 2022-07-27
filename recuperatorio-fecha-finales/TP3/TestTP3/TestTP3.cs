using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca;
using System.Collections.Generic;

namespace TestTP3
{
    [TestClass]
    public class TestTP3
    {
        [TestMethod]
        public void EliminarElemento_CuandoElElementoNoExisteEnLaLista_DeberiaRetornarFalse()
        {
            //Arrange
            ListadoGenerico<Cliente> listado = new ListadoGenerico<Cliente>(0);
            Cliente clienteUno = new Cliente(1, "Pablo", 43261323, 3399546789, "Los Alerces 321", "pablito@gmail.com");
            Cliente clienteDos = new Cliente(2, "Juan", 23456789, 0224356789, "Los Troncos 224", "juancito@gmail.com");
            listado.AgregarElemento(clienteUno);
            bool resultado;
            //Act
            resultado = listado.EliminarElemento(clienteDos);
            //Assert
            Assert.IsFalse(resultado);
        }

        [TestMethod]

        public void ExisteElementoEnLaLista_CuandoLosDniDeLosClientesSonIguales_DeberiaRetornarTrue()
        {
            //Arrange
            ListadoGenerico<Cliente> listadoGenerico = new ListadoGenerico<Cliente>(0);
            Cliente cliente = new Cliente(1, "Pablo", 43261323, 3399546789, "Los Alerces 321", "pablito@gmail.com");
            listadoGenerico.AgregarElemento(cliente);
            Cliente clienteDos = new Cliente(2, "Juan", 43261323, 0224356789, "Los Troncos 224", "juancito@gmail.com");
            //Act
            bool resultado = Cliente.ExisteElementoEnLaLista(listadoGenerico, clienteDos);
            //Assert
            Assert.IsTrue(resultado);
        }
    }
}
