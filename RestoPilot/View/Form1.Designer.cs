using System.ComponentModel;

namespace RestoPilot.View;

partial class Form1 {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        
        if (disposing && (components != null)) {
            
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        // this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "RestoPilot";
        // Rendre la fenêtre non redimensionnable.
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        // Désactiver le bouton de maximisation.
        this.MaximizeBox = false;
        // Adapter automatiquement la fenêtre à la taille de l'écran
        this.WindowState = FormWindowState.Maximized;
        // Positionner la fenêtre au centre de l'écran
        this.StartPosition = FormStartPosition.CenterScreen;
    }

    #endregion
}