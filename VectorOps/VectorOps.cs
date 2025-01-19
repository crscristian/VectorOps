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
using System.Numerics;
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
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Dimensiune fixă
            this.MaximizeBox = true; // Dezactivează butonul de maximizare
            this.MinimizeBox = true; // Opțional, permite minimizarea

        }
        //declaram variabile externe functiilor pentru a manipula intrariile celor 
        private void VectorOps_Load(object sender, EventArgs e)
        {
        //add options for select
            cmbOption.Items.Add("None");
            cmbOption.Items.Add("Adunare");
            cmbOption.Items.Add("Scadere");
            cmbOption.Items.Add("Modul Vector");
            cmbOption.Items.Add("Produs Scalar");
            cmbOption.Items.Add("Produs Vectorial");
            cmbOption.Items.Add("Rotatie Vector");
         // Implicit selection (first option)
            cmbOption.SelectedIndex = 0; // Index 0 is "None"
            txtResult.Visible = false;
            txtResultX.Visible = false;
            txtResultY.Visible = false;
            txtResultZ.Visible = false;
            labelX.Visible = false;
            labelY.Visible = false;
            labelZ.Visible = false;
            txtNormVector.Visible = false;
            //test
            textResult.Visible = false;
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
            // Resetăm interfața
            ResetUI();

            if (cmbOption.SelectedItem == null) return;

            string selectedOption = cmbOption.SelectedItem.ToString();

            if (selectedOption == "None")
            {
                return; // Nu facem nimic pentru opțiunea "None"
            }

            // Validăm inputurile în funcție de opțiunea selectată
            bool isValid;

            if (selectedOption == "Modul Vector" || selectedOption == "Rotatie Vector")
            {
                // Doar Vector A trebuie completat
                isValid = IsVectorAValid();
            }
            else
            {
                // Pentru celelalte opțiuni, trebuie completate Vector A și Vector B
                isValid = IsVectorAValid() && IsVectorBValid();
            }

            if (!isValid)
            {
                cmbOption.SelectedIndex = 0; // Resetează la "None"
                MessageBox.Show("Vă rugăm să completați câmpurile obligatorii.", "Avertizare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Gestionăm opțiunile
            switch (selectedOption)
            {
                case "Adunare":
                    SetUIForOperation("Vector a⃗ + b⃗:", true, true);
                    textResult.Visible = false;
                    if (txtZV1.Visible)
                    {
                        labelZ.Visible = true;
                        txtResultZ.Visible = true;
                        Addition(txtXV1.Text, txtXV2.Text, txtYV1.Text, txtYV2.Text, txtZV1.Text, txtZV2.Text);
                    }
                    else
                    {
                        labelZ.Visible = false;
                        txtResultZ.Visible = false;
                        Addition(txtXV1.Text, txtXV2.Text, txtYV1.Text, txtYV2.Text);
                    }
                    break;

                case "Scadere":
                    SetUIForOperation("Vector a⃗ - b⃗:", true, true);
                    textResult.Visible = false;
                    if (txtZV1.Visible)
                    {
                        labelZ.Visible = true;
                        txtResultZ.Visible = true;
                        Subtraction(txtXV1.Text, txtXV2.Text, txtYV1.Text, txtYV2.Text, txtZV1.Text, txtZV2.Text);
                    }
                    else
                    {
                        labelZ.Visible = false;
                        txtResultZ.Visible = false;
                        Subtraction(txtXV1.Text, txtXV2.Text, txtYV1.Text, txtYV2.Text);
                    }
                    break;

                case "Modul Vector":
                    SetUIForOperation("Modul |a⃗|:", false, false);
                    textResult.Visible=false;
                    if (txtZV1.Visible)
                    {
                        VectorNorm(txtXV1.Text, txtYV1.Text, txtZV1.Text);
                    }
                    else
                    {
                        VectorNorm(txtXV1.Text, txtYV1.Text);
                    }
                    break;

                case "Produs Scalar":
                    SetUIForOperation("Produs Scalar (a⃗ ⋅ b⃗):", true, false);
                    if (txtZV1.Visible)
                    {
                        DotProduct(txtXV1.Text, txtXV2.Text, txtYV1.Text, txtYV2.Text, txtZV1.Text, txtZV2.Text);
                    }
                    else
                    {
                        DotProduct(txtXV1.Text, txtXV2.Text, txtYV1.Text, txtYV2.Text);
                    }
                    break;

                case "Produs Vectorial":
                    SetUIForOperation("Produs Vectorial (a⃗ × b⃗):", true, true);
                    if (txtZV1.Visible)
                    {
                        CrossProduct(txtXV1.Text, txtXV2.Text, txtYV1.Text, txtYV2.Text, txtZV1.Text, txtZV2.Text);
                    }
                    else
                    {
                        CrossProduct(txtXV1.Text, txtXV2.Text, txtYV1.Text, txtYV2.Text);
                    }
                    break;

                case "Rotatie Vector":
                    if (radVector3D.Checked) // Verificăm dacă este selectat 3D
                    {
                        Open3DRotation(); // Deschidem fereastra 3D
                    }
                    else
                    {
                        Open2DRotation(); // Deschidem fereastra 2D (există deja)
                    }
                    break;
                default:
                    MessageBox.Show("Opțiune necunoscută!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        // Funcție pentru validarea completării câmpurilor Vector A
        private bool IsVectorAValid()
        {
            return !string.IsNullOrWhiteSpace(txtXV1.Text) &&
                   !string.IsNullOrWhiteSpace(txtYV1.Text) &&
                   (!txtZV1.Visible || !string.IsNullOrWhiteSpace(txtZV1.Text));
        }

        // Funcție pentru validarea completării câmpurilor Vector B
        private bool IsVectorBValid()
        {
            return !string.IsNullOrWhiteSpace(txtXV2.Text) &&
                   !string.IsNullOrWhiteSpace(txtYV2.Text) &&
                   (!txtZV2.Visible || !string.IsNullOrWhiteSpace(txtZV2.Text));
        }

        // Funcție pentru resetarea interfeței
        private void ResetUI()
        {
            txtResult.Visible = false;
            txtResultX.Visible = false;
            txtResultY.Visible = false;
            txtResultZ.Visible = false;
            txtNormVector.Visible = false;

            labelX.Visible = false;
            labelY.Visible = false;
            labelZ.Visible = false;
        }

        // Funcție pentru configurarea UI pentru o operație
        private void SetUIForOperation(string resultText, bool showVectorB, bool showResultZ)
        {
            txtResult.Visible = true;
            txtResult.Text = resultText;

            txtResultX.Visible = true;
            txtResultY.Visible = true;
            labelX.Visible = true;
            labelY.Visible = true;

            if (showResultZ)
            {
                txtResultZ.Visible = true;
                labelZ.Visible = true;
            }

            if (showVectorB)
            {
                txtXV2.Visible = true;
                txtYV2.Visible = true;
                XV2.Visible = true;
                YV2.Visible = true;

                if (txtZV1.Visible)
                {
                    txtZV2.Visible = true;
                    ZV2.Visible = true;
                }
            }
        }

        public void Addition(string XV1, string XV2, string YV1, string YV2)
        {
            float x1 = ParseStringToFloat(XV1);
            float y1 = ParseStringToFloat(YV1);

            float x2 = ParseStringToFloat(XV2);
            float y2 = ParseStringToFloat(YV2);
            //utilizand clasa Vector2D definita vom crea doi vectori bidimnesionali si vom efectua operatia de adunare utilizand metoda din interiorul clasei
            Vector2D vector1 = new Vector2D(x1, y1);
            Vector2D vector2 = new Vector2D(x2, y2);
            Vector2D suma = Vector2D.Adunare(vector1, vector2);
            Console.WriteLine($"Suma: {suma}");
            //afisam rezultatul in text boxurile
            txtResultX.Text = suma.X.ToString();
            txtResultY.Text = suma.Y.ToString();
        }

        public void Addition(string XV1, string XV2, string YV1, string YV2, string ZV1, string ZV2)
        {
            float x1 = ParseStringToFloat(XV1);
            float y1 = ParseStringToFloat(YV1);
            float z1 = ParseStringToFloat(ZV1);

            float x2 = ParseStringToFloat(XV2);
            float y2 = ParseStringToFloat(YV2);
            float z2 = ParseStringToFloat(ZV2);
            //utilizand clasa Vector2D definita vom crea doi vectori bidimnesionali si vom efectua operatia de adunare utilizand metoda din interiorul clasei
            Vector3D vector1 = new Vector3D(x1, y1, z1);
            Vector3D vector2 = new Vector3D(x2, y2, z2);
            Vector3D suma = Vector3D.Adunare(vector1, vector2);
            Console.WriteLine($"Suma: {suma}");
            //afisam rezultatul in text boxurile
            txtResultX.Text = suma.X.ToString();
            txtResultY.Text = suma.Y.ToString();
            txtResultZ.Text = suma.Z.ToString();
        }

        public void Subtraction(string XV1, string XV2, string YV1, string YV2)
        {
            float x1 = ParseStringToFloat(XV1);
            float y1 = ParseStringToFloat(YV1);

            float x2 = ParseStringToFloat(XV2);
            float y2 = ParseStringToFloat(YV2);
            //utilizand clasa Vector2D definita vom crea doi vectori bidimnesionali si vom efectua operatia de adunare utilizand metoda din interiorul clasei
            Vector2D vector1 = new Vector2D(x1, y1);
            Vector2D vector2 = new Vector2D(x2, y2);
            Vector2D diferenta = Vector2D.Scadere(vector1, vector2);
            Console.WriteLine($"diferenta: {diferenta}");
            //afisam rezultatul in text boxurile
            txtResultX.Text = diferenta.X.ToString();
            txtResultY.Text = diferenta.Y.ToString();
        }

        public void Subtraction(string XV1, string XV2, string YV1, string YV2, string ZV1, string ZV2)
        {
            float x1 = ParseStringToFloat(XV1);
            float y1 = ParseStringToFloat(YV1);
            float z1 = ParseStringToFloat(ZV1);

            float x2 = ParseStringToFloat(XV2);
            float y2 = ParseStringToFloat(YV2);
            float z2 = ParseStringToFloat(ZV2);
            //utilizand clasa Vector3D definita vom crea doi vectori bidimnesionali si vom efectua operatia de adunare utilizand metoda din interiorul clasei
            Vector3D vector1 = new Vector3D(x1, y1, z1);
            Vector3D vector2 = new Vector3D(x2, y2, z2);
            Vector3D diferenta = Vector3D.Scadere(vector1, vector2);
            Console.WriteLine($"diferenta: {diferenta}");
            //afisam rezultatul in text boxurile
            txtResultX.Text = diferenta.X.ToString(); 
            txtResultY.Text = diferenta.Y.ToString();
            txtResultZ.Text = diferenta.Z.ToString();
        }

        public void VectorNorm(string XV1, string YV1)
        {
            txtResultX.Visible = false;
            txtResultY.Visible = false;
            labelX.Visible = false;
            labelY.Visible = false;
            float x1 = ParseStringToFloat(XV1);
            float y1 = ParseStringToFloat(YV1);
            Vector2D vector1 = new Vector2D(x1, y1);
            float modul = vector1.Modul();
            // Afișarea rezultatului în consolă cu două zecimale
            Console.WriteLine($"Modulul vectorului ({x1}, {y1}) este: {modul:F2}");
            txtNormVector.Visible = true;
            txtNormVector.Text = modul.ToString("F2");

        }

        public void VectorNorm(string XV1, string YV1, string ZV1)
        {
            txtResultX.Visible = false;
            txtResultY.Visible = false;
            txtResultZ.Visible = false;
            labelX.Visible = false;
            labelY.Visible = false;
            labelZ.Visible = false;
            float x1 = ParseStringToFloat(XV1);
            float y1 = ParseStringToFloat(YV1);
            float z1 = ParseStringToFloat(ZV1);
            Vector3D vector1 = new Vector3D(x1, y1, z1);
            float modul = vector1.Modul();
            // Afișarea rezultatului în consolă cu două zecimale
            Console.WriteLine($"Modulul vectorului ({x1}, {y1}, {z1}) este: {modul:F2}");
            txtNormVector.Visible = true;
            txtNormVector.Text = modul.ToString("F2");
        }

        public void DotProduct(string XV1, string XV2, string YV1, string YV2)
        {
            float x1 = ParseStringToFloat(XV1);
            float y1 = ParseStringToFloat(YV1);

            float x2 = ParseStringToFloat(XV2);
            float y2 = ParseStringToFloat(YV2);

            // Calculăm produsul scalar
            float produsScalar = (x1 * x2) + (y1 * y2);
            Console.WriteLine($"produsScalar: {produsScalar}");
            textResult.Visible = true;
            txtNormVector.Visible = false;
            textResult.Text = produsScalar.ToString("F2");

            // Ascundem componentele vectorului rezultat
            txtResultX.Visible = false;
            txtResultY.Visible = false;
            txtResultZ.Visible = false;

            labelX.Visible = false;
            labelY.Visible = false;
            labelZ.Visible = false;
        }

        public void DotProduct(string XV1, string XV2, string YV1, string YV2, string ZV1, string ZV2)
        {
            float x1 = ParseStringToFloat(XV1);
            float y1 = ParseStringToFloat(YV1);
            float z1 = ParseStringToFloat(ZV1);

            float x2 = ParseStringToFloat(XV2);
            float y2 = ParseStringToFloat(YV2);
            float z2 = ParseStringToFloat(ZV2);

            // Calculăm produsul scalar
            float produsScalar = (x1 * x2) + (y1 * y2) + (z1 * z2);

            // Afișăm rezultatul în textResult
            textResult.Visible = true;
            txtNormVector.Visible = false;
            textResult.Text = produsScalar.ToString("F2");
            Console.WriteLine($"produsScalar: {produsScalar}");
            // Ascundem componentele vectorului rezultat
            txtResultX.Visible = false;
            txtResultY.Visible = false;
            txtResultZ.Visible = false;

            labelX.Visible = false;
            labelY.Visible = false;
            labelZ.Visible = false;
        }

        public void CrossProduct(string XV1, string XV2, string YV1, string YV2, string ZV1, string ZV2)
        {
            float x1 = ParseStringToFloat(XV1);
            float y1 = ParseStringToFloat(YV1);
            float z1 = ParseStringToFloat(ZV1);

            float x2 = ParseStringToFloat(XV2);
            float y2 = ParseStringToFloat(YV2);
            float z2 = ParseStringToFloat(ZV2);
            Vector3D vector1 = new Vector3D(x1, y1, z1);
            Vector3D vector2 = new Vector3D(x2, y2, z2);
            Vector3D produsVectorial = Vector3D.ProdusVectorial(vector1, vector2);
            //afisam rezultatul in text boxurile
            Console.WriteLine($"produsVectorial: {produsVectorial}");
            txtResultX.Text = produsVectorial.X.ToString("F2");
            txtResultY.Text = produsVectorial.Y.ToString("F2");
            txtResultZ.Text = produsVectorial.Z.ToString("F2");
            textResult.Visible = false;
        }

        public void CrossProduct(string XV1, string XV2, string YV1, string YV2)
        {
            // Convertim intrările în float-uri
            float x1 = ParseStringToFloat(XV1);
            float y1 = ParseStringToFloat(YV1);

            float x2 = ParseStringToFloat(XV2);
            float y2 = ParseStringToFloat(YV2);

            // Calculăm produsul vectorial asociat (scalar pentru vectori 2D)
            float produsVectorial = (x1 * y2) - (y1 * x2);
            Console.WriteLine($"produsVectorial: {produsVectorial}");
            textResult.Visible = true;
            txtNormVector.Visible = false;
            textResult.Text = produsVectorial.ToString("F2");

            // Ascundem componentele vectorului rezultat, deoarece nu se aplică pentru vectori 2D
            txtResultX.Visible = false;
            txtResultY.Visible = false;
            txtResultZ.Visible = false;

            labelX.Visible = false;
            labelY.Visible = false;
            labelZ.Visible = false;
        }

        private void Open2DRotation()
        {
            try
            {
                // Preluăm coordonatele vectorului din câmpuri
                float vectorX = ParseStringToFloat(txtXV1.Text);
                float vectorY = ParseStringToFloat(txtYV1.Text);
                Vector2D vector1 = new Vector2D(vectorX, vectorY);
                float distanta_Origine = vector1.Modul();
                Console.WriteLine($"Distanta vectorului fata de origine: ({vectorX}, {vectorY}) este: {distanta_Origine:F2}");
                // Instanțiem form-ul pentru rotație și îl deschidem
                RotatingVector2DForm rotationForm = new RotatingVector2DForm(vectorX, vectorY);
                rotationForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Open3DRotation()
        {
            try
            {
                // Preluăm coordonatele vectorului din câmpurile de input
                float vectorX = ParseStringToFloat(txtXV1.Text);
                float vectorY = ParseStringToFloat(txtYV1.Text);
                float vectorZ = ParseStringToFloat(txtZV1.Text);

                // Închidem temporar fereastra principală
                this.Hide();

                // Instanțiem fereastra OpenGL 3D
                OpenGL3DWindow rotationWindow = new OpenGL3DWindow(vectorX, vectorY, vectorZ);

                // Abonare la evenimentul de închidere a ferestrei 3D
                rotationWindow.Closed += (sender, args) =>
                {
                    // După ce fereastra OpenGL este închisă, redeschidem fereastra principală
                    this.Invoke((MethodInvoker)delegate
                    {
                        this.Show(); // Afișăm din nou fereastra principală
                        this.BringToFront(); // Aducem fereastra principală în prim-plan
                    });
                };

                // Rulăm fereastra OpenGL pe firul principal
                rotationWindow.Run(60.0); // Rulăm la 60 FPS
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        private float ParseStringToFloat(string input)
        {
            // Elimină spațiile albe de la începutul și sfârșitul șirului
            input = input.Trim();

            // Verifică dacă șirul conține o fracție de forma "numărător/numitor"
            if (input.Contains("/"))
            {
                string[] parts = input.Split('/');
                if (parts.Length == 2 &&
                    float.TryParse(parts[0], NumberStyles.Float, CultureInfo.InvariantCulture, out float numerator) &&
                    float.TryParse(parts[1], NumberStyles.Float, CultureInfo.InvariantCulture, out float denominator))
                {
                    if (denominator == 0)
                        throw new DivideByZeroException("Numitorul nu poate fi zero.");

                    return numerator / denominator;
                }
                else
                {
                    throw new FormatException("Formatul fracției este invalid.");
                }
            }
            else
            {
                // Încearcă să convertească șirul direct într-un float
                if (float.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out float result))
                {
                    return result;
                }
                else
                {
                    throw new FormatException("Șirul nu este un număr valid.");
                }
            }
        }
    }
}
