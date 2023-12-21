using FluentAssertions;
using RestoPilot.Model.Kitchen;

namespace RestoPilotTest.Model.Kitchen;

[TestClass]
public class ChefTests {

    [TestMethod]
    public void Constructor_ShouldInitializePictureBox() {

        // Arrange
        Chef Chef = new Chef();

        // Act
        PictureBox ChefBox = Chef.GetChefBox();

        // Assert
        ChefBox.Should().NotBeNull();
        ChefBox.Image.Should().NotBeNull();
        // ChefBox.ImageLocation.Should().Be("C:\\Users\\User\\Documents\\X2026\\X2 2022-2023\\SEM1 X2\\2 - Programmation Orienté Objet (Java)\\Projet Développement dune application POO-UML-JAVA\\player_sprites\\tile081.png");
        // ChefBox.Location.Should().Be(new Point(110, 200));
        ChefBox.Size.Should().Be(new Size(40, 40));
        ChefBox.SizeMode.Should().Be(PictureBoxSizeMode.StretchImage);
    }
}