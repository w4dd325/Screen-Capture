using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Screen_Capture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CaptureMyScreen();
            //www.c-sharpcorner.com/UploadFile/2d2d83/how-to-capture-a-screen-using-C-Sharp/
        }

        private void CaptureMyScreen()
        {
            try
            {
                //Creating a new Bitmap object
                //Bitmap captureBitmap = new Bitmap(1024, 768, PixelFormat.Format32bppArgb);

                //40 40 is the height and width I want to capture, change as needed
                Bitmap captureBitmap = new Bitmap(40, 40, PixelFormat.Format32bppArgb);
                //Bitmap captureBitmap = new Bitmap(int width, int height, PixelFormat);
                //Creating a Rectangle object which will
                //capture our Current Screen
                //Rectangle captureRectangle = Screen.AllScreens[0].Bounds;
                //363, 180, 40, 40 is the area I want to capture, change as needed
                Rectangle captureRectangle = new Rectangle(363, 180, 40, 40);
                //Creating a New Graphics Object
                Graphics captureGraphics = Graphics.FromImage(captureBitmap);
                //Copying Image from The Screen
                captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);
                //Saving the Image File.
                captureBitmap.Save(@"C:\Users\James\Downloads\Capture.jpg", ImageFormat.Jpeg);
                //Displaying the Successfull Result
                //MessageBox.Show("Screen Captured");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
