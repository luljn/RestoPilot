using RestoPilot.Controller;
using RestoPilot.Model;
using RestoPilot.Model.Hall;
using RestoPilot.Model.Kitchen;
using RestoPilot.View;

namespace RestoPilotTest.Controller;

[TestClass]
public class SimulationControllerTests {
    
        [TestMethod]
        public void StartASimulation_ShouldInitializeSimulation() {
            
            // Arrange
            SimulationController simulationController = new SimulationController();

            // Act
            simulationController.StartASimulation(null, null);

            // Assert
            Form2 simulation = simulationController.GetSimulation();
            Assert.IsNotNull(simulation);
        }

        [TestMethod]
        public void SimulationLoad_ShouldInitializeRestaurantAndComponents() {
            
            // Arrange
            SimulationController simulationController = new SimulationController();
            simulationController.StartASimulation(null, null);

            // Act
            simulationController.SimulationLoad(null, null);

            // Assert
            Restaurant restaurant = simulationController.GetRestaurant();
            Assert.IsNotNull(restaurant);
            Assert.IsNotNull(restaurant.GetHall());
            Assert.IsNotNull(restaurant.GetKitchen());
            Assert.IsNotNull(restaurant.BackToPrincipalMenuButton);
            Assert.IsNotNull(restaurant.BreakButton);
            Assert.IsNotNull(restaurant.ResumeTheSimulationButton);
        }

        [TestMethod]
        public void BackToPrincipalMenu_ShouldCloseSimulation() {
            
            // Arrange
            SimulationController simulationController = new SimulationController();
            simulationController.StartASimulation(null, null);
            Form2 simulation = simulationController.GetSimulation();

            // Act
            simulationController.BackToPrincipalMenu(null, null);

            // Assert
            Assert.IsTrue(simulation.IsDisposed);
        }

        [TestMethod]
        public void PutTheSimulationOnPause_ShouldStopTimers() {
            
            // Arrange
            SimulationController simulationController = new SimulationController();
            simulationController.StartASimulation(null, null);
            simulationController.SimulationLoad(null, null);

            // Act
            simulationController.PutTheSimulationOnPause(null, null);

            // Assert
            foreach (IMobile element in simulationController.GetKitchenMobileElements())
            {
                Assert.IsFalse(element.GetTimer().Enabled);
            }

            foreach (IMobile element in simulationController.GetHallMobileElements())
            {
                Assert.IsFalse(element.GetTimer().Enabled);
            }
        }

        [TestMethod]
        public void ResumeTheSimulation_ShouldStartTimers() {
            
            // Arrange
            SimulationController simulationController = new SimulationController();
            simulationController.StartASimulation(null, null);
            simulationController.SimulationLoad(null, null);
            simulationController.PutTheSimulationOnPause(null, null);

            // Act
            simulationController.ResumeTheSimulation(null, null);

            // Assert
            foreach (IMobile element in simulationController.GetKitchenMobileElements())
            {
                Assert.IsTrue(element.GetTimer().Enabled);
            }

            foreach (IMobile element in simulationController.GetHallMobileElements())
            {
                Assert.IsTrue(element.GetTimer().Enabled);
            }
        }
}