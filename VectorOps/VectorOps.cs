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
        }

        private void VectorOps_Load(object sender, EventArgs e)
        {
        //adaugarea optiunilor pentru selectie
            cmbOption.Items.Add("None");
            cmbOption.Items.Add("Addition");
            cmbOption.Items.Add("Subtraction");
            cmbOption.Items.Add("Vector Norm");
            cmbOption.Items.Add("Dot Product");
            cmbOption.Items.Add("Cross Product");
            cmbOption.Items.Add("Vector Rotation");
         // Setarea opțiunii implicite (prima opțiune)
            cmbOption.SelectedIndex = 0; // Index 0 reprezintă "None"
            //cmbOption.MaxDropDownItems = 3; //nr maxim de elemente pe care le afiseaza combox inainte de aparea bara de derulare

        }
    }
}
