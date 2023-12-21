namespace RestoPilot.Model.Hall;

public class Hall {
    
    private PictureBox HallBox { get; }

    public Hall() {
        
        this.HallBox = new PictureBox();
        this.HallBox.Image = Image.FromFile("C:\\Users\\User\\Pictures\\Screenshots\\Screenshot 2023-12-16 143054.png");
        this.HallBox.Location = new Point(0, 0);
        this.HallBox.Size = new Size(1200, 520);
        this.HallBox.SizeMode = PictureBoxSizeMode.StretchImage;
    }
    
    public PictureBox GetHallBox() { return this.HallBox; }
}