using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Earthpapers {
    public class Image : PictureBox {
        public Image(int width, int height) {
            // Set the size of the Image based on the width,height values passed in
            this.Size = new Size(width, height);
            this.Image = new Bitmap("img.jpg");
            this.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}