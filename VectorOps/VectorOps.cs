using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

            //test
            txtResult.Font = new Font("Cambria Math", 18); // Font compatibil 

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
            if(cmbOption.SelectedItem != null)
            {
                switch(cmbOption.SelectedItem.ToString())
                {
                    case "None":
                        txtResult.Visible = false;
                        break;
                    case "Addition":
                        txtResult.Visible = true;
                        txtResult.Text = "Vector a\u20D7 + b\u20D7:";
                        if(txtZV1.Visible == true)
                        {
                            Addition(txtXV1.Text, txtXV2.Text, txtYV1.Text, txtYV2.Text, txtZV1.Text, txtZV2.Text);
                        }
                        else
                        {
                            Addition(txtXV1.Text, txtXV2.Text, txtYV1.Text, txtYV2.Text);
                        }
                        break;
                    case "Subtraction":
                        txtResult.Visible = true;
                        txtResult.Text = "Vector a\u20D7 - b\u20D7:";
                        break;
                    case "Vector Norm":
                        break;
                    case "Dot Product":
                        break;
                    case "Cross Product":
                        break;
                    case "Vector Rotation":
                        break;
                }
            }

        }

        public void Addition(string XV1, string XV2, string YV1, string YV2)
        {

        }

        public void Addition(string XV1, string XV2, string YV1, string YV2, string ZV1, string ZV2)
        {

        }

        private void txtXV1_Validating(object sender, CancelEventArgs e)
        {
            string input = txtXV1.Text.Trim();
            // Verifică dacă inputul este un număr întreg valid
            if (int.TryParse(input, out _))
            {
                // Inputul este un număr întreg valid
                errorProviderXV1.SetError(txtXV1, string.Empty);
            }
            // Verifică dacă inputul este un număr float valid
            else if (float.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out _))
            {
                // Inputul este un număr float valid
                errorProviderXV1.SetError(txtXV1, string.Empty);
            }
            // Verifică dacă inputul este o fracție validă
            else if (EsteFractieValida(input))
            {
                // Inputul este o fracție validă
                errorProviderXV1.SetError(txtXV1, string.Empty);
            }
            else
            {
                // Inputul nu este valid
                errorProviderXV1.SetError(txtXV1, "Introduceți un număr întreg, un număr zecimal sau o fracție validă.");
                e.Cancel = true; // Anulează evenimentul, menținând focusul pe TextBox
            }
        }

        private bool EsteFractieValida(string input)
        {
            // Verifică dacă inputul conține caracterul '/'
            if (input.Contains("/"))
            {
                string[] parti = input.Split('/');
                if (parti.Length == 2)
                {
                    // Verifică dacă ambele părți sunt numere întregi valide și numitorul nu este zero
                    if (int.TryParse(parti[0].Trim(), out _) && int.TryParse(parti[1].Trim(), out int numitor) && numitor != 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void txtYV1_Validating(object sender, CancelEventArgs e)
        {
            string input = txtYV1.Text.Trim();
            // Verifică dacă inputul este un număr întreg valid
            if (int.TryParse(input, out _))
            {
                // Inputul este un număr întreg valid
                errorProviderYV1.SetError(txtYV1, string.Empty);
            }
            // Verifică dacă inputul este un număr float valid
            else if (float.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out _))
            {
                // Inputul este un număr float valid
                errorProviderYV1.SetError(txtYV1, string.Empty);
            }
            // Verifică dacă inputul este o fracție validă
            else if (EsteFractieValida(input))
            {
                // Inputul este o fracție validă
                errorProviderYV1.SetError(txtYV1, string.Empty);
            }
            else
            {
                // Inputul nu este valid
                errorProviderYV1.SetError(txtYV1, "Introduceți un număr întreg, un număr zecimal sau o fracție validă.");
                e.Cancel = true; // Anulează evenimentul, menținând focusul pe TextBox
            }
        }

        private void txtZV1_Validating(object sender, CancelEventArgs e)
        {
            string input = txtZV1.Text.Trim();
            // Verifică dacă inputul este un număr întreg valid
            if (int.TryParse(input, out _))
            {
                // Inputul este un număr întreg valid
                errorProviderZV1.SetError(txtZV1, string.Empty);
            }
            // Verifică dacă inputul este un număr float valid
            else if (float.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out _))
            {
                // Inputul este un număr float valid
                errorProviderZV1.SetError(txtZV1, string.Empty);
            }
            // Verifică dacă inputul este o fracție validă
            else if (EsteFractieValida(input))
            {
                // Inputul este o fracție validă
                errorProviderZV1.SetError(txtZV1, string.Empty);
            }
            else
            {
                // Inputul nu este valid
                errorProviderZV1.SetError(txtZV1, "Introduceți un număr întreg, un număr zecimal sau o fracție validă.");
                e.Cancel = true; // Anulează evenimentul, menținând focusul pe TextBox
            }
        }

        private void txtXV2_Validating(object sender, CancelEventArgs e)
        {
            string input = txtXV2.Text.Trim();
            // Verifică dacă inputul este un număr întreg valid
            if (int.TryParse(input, out _))
            {
                // Inputul este un număr întreg valid
                errorProviderXV2.SetError(txtXV1, string.Empty);
            }
            // Verifică dacă inputul este un număr float valid
            else if (float.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out _))
            {
                // Inputul este un număr float valid
                errorProviderXV2.SetError(txtXV2, string.Empty);
            }
            // Verifică dacă inputul este o fracție validă
            else if (EsteFractieValida(input))
            {
                // Inputul este o fracție validă
                errorProviderXV2.SetError(txtXV2, string.Empty);
            }
            else
            {
                // Inputul nu este valid
                errorProviderXV2.SetError(txtXV2, "Introduceți un număr întreg, un număr zecimal sau o fracție validă.");
                e.Cancel = true; // Anulează evenimentul, menținând focusul pe TextBox
            }
        }

        private void txtYV2_Validating(object sender, CancelEventArgs e)
        {
            string input = txtYV2.Text.Trim();
            // Verifică dacă inputul este un număr întreg valid
            if (int.TryParse(input, out _))
            {
                // Inputul este un număr întreg valid
                errorProviderYV2.SetError(txtYV2, string.Empty);
            }
            // Verifică dacă inputul este un număr float valid
            else if (float.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out _))
            {
                // Inputul este un număr float valid
                errorProviderYV2.SetError(txtYV2, string.Empty);
            }
            // Verifică dacă inputul este o fracție validă
            else if (EsteFractieValida(input))
            {
                // Inputul este o fracție validă
                errorProviderYV2.SetError(txtYV2, string.Empty);
            }
            else
            {
                // Inputul nu este valid
                errorProviderYV2.SetError(txtYV2, "Introduceți un număr întreg, un număr zecimal sau o fracție validă.");
                e.Cancel = true; // Anulează evenimentul, menținând focusul pe TextBox
            }
        }

        private void txtZV2_Validating(object sender, CancelEventArgs e)
        {
            string input = txtZV2.Text.Trim();
            // Verifică dacă inputul este un număr întreg valid
            if (int.TryParse(input, out _))
            {
                // Inputul este un număr întreg valid
                errorProviderZV2.SetError(txtZV2, string.Empty);
            }
            // Verifică dacă inputul este un număr float valid
            else if (float.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out _))
            {
                // Inputul este un număr float valid
                errorProviderZV2.SetError(txtZV2, string.Empty);
            }
            // Verifică dacă inputul este o fracție validă
            else if (EsteFractieValida(input))
            {
                // Inputul este o fracție validă
                errorProviderZV2.SetError(txtZV2, string.Empty);
            }
            else
            {
                // Inputul nu este valid
                errorProviderZV2.SetError(txtZV2, "Introduceți un număr întreg, un număr zecimal sau o fracție validă.");
                e.Cancel = true; // Anulează evenimentul, menținând focusul pe TextBox
            }
        }
    }
}
