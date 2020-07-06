using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        int i=0;
        public Form1()
        {   
            InitializeComponent();
            TopMost = true;
            cbMain.Items.Add("Static");
            cbMain.Items.Add("Pan");
            cbMain.Items.Add("Tilt");
            cbMain.Items.Add("Dolly");
            cbMain.Items.Add("Truck");
            cbMain.Items.Add("Pedestal");
            cbMain.Items.Add("Zoom");
            cbMain.Items.Add("Roll");
            cbMain.Items.Add("");
            cbSub1.Enabled = false;
            cbSub2.Enabled = false;
            cbSub3.Enabled = false;
            cbSub4.Enabled = false;
            cbSub5.Enabled = false;
            cbSub6.Enabled = false;
        }

        private void cbMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSub1.Items.Clear();
            cbSub2.Items.Clear();
            cbSub3.Items.Clear();
            cbSub4.Items.Clear();
            cbSub5.Items.Clear();
            cbSub6.Items.Clear();
            cbSub1.Enabled = true;
            cbSub2.Enabled = true;
            cbSub3.Enabled = true;
            cbSub4.Enabled = true;
            cbSub5.Enabled = true;
            cbSub6.Enabled = true;
            if (cbMain.SelectedItem == "Static")
            {
                cbSub1.Items.Add("Handheld");
                cbSub1.Items.Add("Tripod");
                cbSub1.Items.Add("");

                cbSub2.Items.Add("Follow");
                cbSub2.Items.Add("NoFollow");
                cbSub2.Items.Add("");

                cbSub3.Items.Add("InCar");
                cbSub3.Items.Add("CarRig");
                cbSub3.Items.Add("");

                cbSub4.Enabled = false;
                cbSub5.Enabled = false;
                cbSub6.Enabled = false;
            }
            if (cbMain.SelectedItem == "Pan")
            {
                cbSub1.Items.Add("LeftToRight");
                cbSub1.Items.Add("RightToLeft");
                cbSub1.Items.Add("");

                cbSub2.Items.Add("Follow");
                cbSub2.Items.Add("NoFollow");
                cbSub2.Items.Add("");

                cbSub3.Items.Add("Slow");
                cbSub3.Items.Add("Normal");
                cbSub3.Items.Add("Fast");
                cbSub3.Items.Add("");

                cbSub4.Items.Add("WithTruck");
                cbSub4.Items.Add("WithDolly");
                cbSub4.Items.Add("");

                cbSub5.Items.Add("Handheld");
                cbSub5.Items.Add("Tripod");
                cbSub5.Items.Add("");

                cbSub6.Items.Add("Parallax");
                cbSub6.Items.Add("Diagonal	");
                cbSub6.Items.Add("");
            }
            if (cbMain.SelectedItem == "Tilt")
            {
                cbSub1.Items.Add("Up");
                cbSub1.Items.Add("Down");
                cbSub1.Items.Add("");

                cbSub2.Items.Add("Follow");
                cbSub2.Items.Add("NoFollow");
                cbSub2.Items.Add("");

                cbSub3.Items.Add("Slow");
                cbSub3.Items.Add("Normal");
                cbSub3.Items.Add("Fast");
                cbSub3.Items.Add("");

                cbSub4.Items.Add("WithDolly");
                cbSub4.Items.Add("WithPedestal");
                cbSub4.Items.Add("");

                cbSub5.Items.Add("Handheld");
                cbSub5.Items.Add("Tripod");
                cbSub5.Items.Add("");

                cbSub6.Items.Add("Diagonal");
                cbSub6.Items.Add("");
            }
            if (cbMain.SelectedItem == "Dolly")
            {
                cbSub1.Items.Add("Forwards");
                cbSub1.Items.Add("Backwards");
                cbSub1.Items.Add("");

                cbSub2.Items.Add("Follow");
                cbSub2.Items.Add("NoFollow");
                cbSub2.Items.Add("");

                cbSub3.Items.Add("Slow");
                cbSub3.Items.Add("Normal");
                cbSub3.Items.Add("Fast");
                cbSub3.Items.Add("");

                cbSub4.Items.Add("WithPan");
                cbSub4.Items.Add("WithTilt");
                cbSub4.Items.Add("Car-rig");
                cbSub4.Items.Add("In-car");
                cbSub4.Items.Add("");

                cbSub5.Items.Add("Gimbal");
                cbSub5.Items.Add("Handheld");
                cbSub5.Items.Add("");

                cbSub6.Enabled = false;
                cbSub6.Items.Add("");
            }
            if (cbMain.SelectedItem == "Truck")
            {
                cbSub1.Items.Add("LeftToRight");
                cbSub1.Items.Add("RightToLeft");
                cbSub1.Items.Add("");

                cbSub2.Items.Add("Follow");
                cbSub2.Items.Add("NoFollow");
                cbSub2.Items.Add("");

                cbSub3.Items.Add("Slow");
                cbSub3.Items.Add("Normal");
                cbSub3.Items.Add("Fast");
                cbSub3.Items.Add("");

                cbSub4.Items.Add("WithPan");
                cbSub4.Items.Add("InCar");
                cbSub4.Items.Add("CarRig");
                cbSub4.Items.Add("");

                cbSub5.Items.Add("Gimbal");
                cbSub5.Items.Add("Handheld");
                cbSub5.Items.Add("");

                cbSub6.Items.Add("Parallax");
                cbSub6.Items.Add("");
            }
            if (cbMain.SelectedItem == "Pedestal")
            {
                cbSub1.Items.Add("Up");
                cbSub1.Items.Add("Down");
                cbSub1.Items.Add("");

                cbSub2.Items.Add("Follow");
                cbSub2.Items.Add("NoFollow");
                cbSub2.Items.Add("");

                cbSub3.Items.Add("Slow");
                cbSub3.Items.Add("Normal");
                cbSub3.Items.Add("Fast");
                cbSub3.Items.Add("");

                cbSub4.Items.Add("WithTilt");
                cbSub4.Items.Add("");

                cbSub5.Enabled = false;
                cbSub6.Enabled = false;
            }
            if (cbMain.SelectedItem == "Zoom")
            {
                cbSub1.Items.Add("In");
                cbSub1.Items.Add("Out");
                cbSub1.Items.Add("");

                cbSub2.Items.Add("Follow");
                cbSub2.Items.Add("NoFollow");
                cbSub2.Items.Add("");

                cbSub3.Items.Add("Slow");
                cbSub3.Items.Add("Normal");
                cbSub3.Items.Add("Fast");
                cbSub2.Items.Add("");


                cbSub4.Enabled = false;
                cbSub5.Enabled = false;
                cbSub6.Enabled = false;
            }
            if (cbMain.SelectedItem == "Roll")
            {
                cbSub1.Items.Add("Clockwise");
                cbSub1.Items.Add("Counter-Clockwise");
                cbSub1.Items.Add("");

                cbSub2.Items.Add("Follow");
                cbSub2.Items.Add("NoFollow");
                cbSub2.Items.Add("");

                cbSub3.Items.Add("Slow");
                cbSub3.Items.Add("Normal");
                cbSub3.Items.Add("Fast");
                cbSub3.Items.Add("");
                cbSub4.Enabled = false;
                cbSub5.Enabled = false;
                cbSub6.Enabled = false;
            }
            if (cbMain.SelectedItem == "")
            {
                cbSub1.Enabled = false;
                cbSub2.Enabled = false;
                cbSub3.Enabled = false;
                cbSub4.Enabled = false;
                cbSub5.Enabled = false;
                cbSub6.Enabled = false;
            }
        }
        private void btnClipboard_Click(object sender, EventArgs e)
        {
            string t = i.ToString()+"_"+cbMain.Text + "_" + cbSub1.Text + "_" + cbSub2.Text + "_" + cbSub3.Text + "_" + cbSub4.Text + "_" + cbSub5.Text + "_" + cbSub6.Text + "_";
            textBox1.Text = t;
            Clipboard.SetText(t);
            i++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                i = Convert.ToInt32(textBox2.Text);
            }
            catch
            {
                i = 0;
            }
        }
    }
}
