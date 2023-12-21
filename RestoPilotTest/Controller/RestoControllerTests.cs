using RestoPilot.Controller;
using RestoPilot.View;

namespace RestoPilotTest.Controller;

[TestClass]
public class RestoControllerTests
{
    private Form1 menu = new Form1(); 
    
    [TestMethod]
    public void Start_ShouldInitializeMenu() {
        // Arrange
        RestoController restoController = new RestoController();
        
        // Assert
        Assert.IsNull(restoController.GetMenu());
    }

    [TestMethod]
    public void QuitApp_ShouldCloseMenu() {
        // Arrange
        RestoController restoController = new RestoController();
        Form1 menu = new Form1();
        restoController.SetMenu(menu);

        // Act
        restoController.QuitApp(null, null);

        // Assert
        Assert.IsTrue(menu.IsDisposed);
    }
}