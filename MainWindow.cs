using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace Earthpapers {
    public class MainWindow : Form {
        private SplitContainer split;

        public MainWindow() {
            // Retrieve resolution and set MainWindow to 75% size and centered
            Rectangle resolution = Screen.PrimaryScreen.Bounds;
            this.Size = new Size((int)(resolution.Width * .75), (int)(resolution.Height * .75));
            this.Text = "Earthpapers";
            this.StartPosition = FormStartPosition.CenterScreen;

            // Split window into two containers to fit image and description
            split = new SplitContainer();
            split.Dock = DockStyle.Fill;
            split.Orientation = Orientation.Horizontal;

            // Setup Panel1 to hold image
            split.Panel1MinSize = (int)(this.Height * .75);
            split.Panel1.Controls.Add(new Image(this.Width, split.Panel1MinSize));

            this.Controls.Add(split);
        }
    }
}