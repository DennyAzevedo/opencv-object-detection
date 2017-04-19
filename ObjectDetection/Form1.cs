using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.UI;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.Threading;
using System.Runtime.InteropServices;
using Emgu.CV.VideoStab;

namespace ObjectDetection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Capture cap;
        videoUtility videoProcessing = new videoUtility();

        private void onlineCam()
        {
            while (true)
            {
                if (pictureFrame.InvokeRequired)
                {
                    pictureFrame.Image = cap.QueryFrame().ToBitmap();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            videoProcessing.getAllCamera(cb_camera);
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            cap = new Capture(cb_camera.SelectedIndex);
            Thread t = new Thread(onlineCam);
            t.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
