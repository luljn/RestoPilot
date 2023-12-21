using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using RestoPilot.Model.DAO; // Référence à l'assembly RestoPilot

namespace RestoPilotTest.Model.DAO
{
    [TestClass]
    public class DatabaseAccessTests
    {
        [TestMethod]
        public void Constructor_ShouldInitializeConnectionString()
        {
            // Arrange
            DatabaseAccess databaseAccess = new DatabaseAccess();

            // Act
            string connectionString = databaseAccess.Cnx;

            // Assert
            connectionString.Should().Be("Server=localhost\\SQLEXPRESS;Database=RestoPilot;Trusted_Connection=True;");
        }

        // Ajoutez d'autres tests pour les autres méthodes de la classe DatabaseAccess
    }
}
