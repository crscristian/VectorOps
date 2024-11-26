using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VectorOps
{
    public partial class VectorOps : Form
    {
        public VectorOps()
        {
            InitializeComponent();
            //init variables 
            radVector2D.Checked = true;
            txtZV1.Visible = false;
            ZV1.Visible = false;
            txtZV2.Visible = false;
            ZV2.Visible = false;

        }

        private void VectorOps_Load(object sender, EventArgs e)
        {
        //add options for select
            cmbOption.Items.Add("None");
            cmbOption.Items.Add("Addition");
            cmbOption.Items.Add("Subtraction");
            cmbOption.Items.Add("Vector Norm");
            cmbOption.Items.Add("Dot Product");
            cmbOption.Items.Add("Cross Product");
            cmbOption.Items.Add("Vector Rotation");
         // Implicit selection (first option)
            cmbOption.SelectedIndex = 0; // Index 0 is "None"
            

        }

        private void radVector2D_CheckedChanged(object sender, EventArgs e)
        {
            txtZV1.Visible = false; // if is checked 2D vector, Z parameter set is hide
            ZV1.Visible = false;
            txtZV2.Visible = false;
            ZV2.Visible = false;
        }

        private void radVector3D_CheckedChanged(object sender, EventArgs e)
        {
            txtZV1.Visible = true;//if is checked 3D vector, Z parameter set is visible
            ZV1.Visible = true;
            txtZV2.Visible = true;
            ZV2.Visible = true;
        }

        private void cmbOption_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
