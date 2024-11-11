using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace GrabICO
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void processStart_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Executable Files (*.exe)|*.exe";
            if (!string.IsNullOrEmpty(fileDialog.Filter) && fileDialog.ShowDialog() == DialogResult.OK)
                try
                {
                    Icon icon = Icon.ExtractAssociatedIcon(fileDialog.FileName);
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Icon Files (*.ico)|*.ico";


                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                        {
                            icon.Save(stream);
                        }
                }

                catch (Exception)
                {
                    
                }

        }
    }
}