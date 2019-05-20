﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades_Ejercicio_36;

namespace TestCompetencia
{
    /// <summary>
    /// Comprueba que haya agregado el vehículo a la lista
    /// </summary>
    [TestClass]
    public class T04_AgregarVehiculo
    {
        public T04_AgregarVehiculo()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Obtiene o establece el contexto de las pruebas que proporciona
        ///información y funcionalidad para la serie de pruebas actual.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Atributos de prueba adicionales
        //
        // Puede usar los siguientes atributos adicionales conforme escribe las pruebas:
        //
        // Use ClassInitialize para ejecutar el código antes de ejecutar la primera prueba en la clase
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup para ejecutar el código una vez ejecutadas todas las pruebas en una clase
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Usar TestInitialize para ejecutar el código antes de ejecutar cada prueba 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup para ejecutar el código una vez ejecutadas todas las pruebas
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethod1()
        {
            //Arrange

            Competencia competenciaTest;
            AutoF1 autoTest;

            //Act
            competenciaTest = new Competencia(10, 20, Competencia.TipoCompetencia.F1);
            autoTest = new AutoF1(20, "Ferrari");

            //Assert
            if (competenciaTest + autoTest)
            {
                if(competenciaTest == autoTest)
                {
                    //pasó el test
                }
                else
                {
                    Assert.Fail();
                }
            }

        }
    }
}
