using Timer = System.Windows.Forms.Timer;

namespace RestoPilot.Model;

public interface IMobile {    

    public void Deplacement(object sender, EventArgs e);  // To move a mobile element.
    public PictureBox GetBox();
    public Timer GetTimer();
}