﻿using FluentAssertions;
using RestoPilot.Model.Hall;

namespace RestoPilotTest.Model.Hall;

[TestClass]
public class ButlerTests {
    
    [TestMethod]
    public void Constructor_ShouldInitializePictureBox() {
        
        // Arrange
        Butler butler = new Butler();

        // Act
        PictureBox butlerBox = butler.GetButlerBox();

        // Assert
        butlerBox.Should().NotBeNull();
        butlerBox.Image.Should().NotBeNull();
        // butlerBox.ImageLocation.Should().Be("C:\\Users\\User\\Documents\\X2026\\X2 2022-2023\\SEM1 X2\\2 - Programmation Orienté Objet (Java)\\Projet Développement dune application POO-UML-JAVA\\player_sprites\\tile073.png");
        // butlerBox.Location.Should().Be(new Point(110, 200));
        butlerBox.Size.Should().Be(new Size(40, 40));
        butlerBox.SizeMode.Should().Be(PictureBoxSizeMode.StretchImage);
    }
}