using RestoPilot.Model.DAO;
using FluentAssertions;

namespace RestoPilotTest.Model.DAO;

[TestClass]
public class DatabaseAccessTests {
    
    [TestMethod]
    public void Constructor_ShouldInitializeConnectionString()
    {
        // Arrange
        DatabaseAccess databaseAccess = new DatabaseAccess();

        // Act
        string connectionString = databaseAccess.GetCnx();

        // Assert
        connectionString.Should().Be("Server=localhost\\SQLEXPRESS;Database=RestoPilot;Trusted_Connection=True;");
    }

}