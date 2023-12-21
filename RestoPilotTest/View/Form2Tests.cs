using RestoPilot.View;
using Timer = System.Windows.Forms.Timer;

namespace RestoPilotTest.View;

[TestClass]
public class Form2Tests {
    
    [TestMethod]
    public void Form2_ShouldInitializeMembers() {
        
        Form2 form = new Form2();
        
        // Assert
        Assert.IsNotNull(form.GetRestoController);
        Assert.IsNotNull(form.GetSimulationController);
        Assert.IsNotNull(form.GetTimer);
        Assert.IsInstanceOfType(form.GetTimer(), typeof(Timer));
    }
}