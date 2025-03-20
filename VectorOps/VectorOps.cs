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
            // Initialize variables
            radVector2D.Checked = true;
            txtZV1.Visible = false;
            ZV1.Visible = false;
            txtZV2.Visible = false;
            ZV2.Visible = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Fixed size
            this.MaximizeBox = true; // Disable maximize button
            this.MinimizeBox = true; // Optional, allow minimize
            Vector1.Text = "Coordinates of vector a⃗";
            Vector2.Text = "Coordinates of vector b⃗";
        }

        // Declare external variables for functions to manipulate their inputs
        private void VectorOps_Load(object sender, EventArgs e)
        {
            // Add options for selection
            cmbOption.Items.Add("None");
            cmbOption.Items.Add("Addition");
            cmbOption.Items.Add("Subtraction");
            cmbOption.Items.Add("Vector Magnitude");
            cmbOption.Items.Add("Dot Product");
            cmbOption.Items.Add("Cross Product");
            cmbOption.Items.Add("Vector Rotation");
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
            // Test
            textResult.Visible = false;
            txtResult.Font = new Font("Cambria Math", 18); // Compatible font
        }

        private void radVector2D_CheckedChanged(object sender, EventArgs e)
        {
            // If 2D vector is checked, hide Z parameter set
            txtZV1.Visible = false;
            ZV1.Visible = false;
            txtZV2.Visible = false;
            ZV2.Visible = false;
        }

        private void radVector3D_CheckedChanged(object sender, EventArgs e)
        {
            // If 3D vector is checked, show Z parameter set
            txtZV1.Visible = true;
            ZV1.Visible = true;
            txtZV2.Visible = true;
            ZV2.Visible = true;
        }

        private void cmbOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Reset the interface
            ResetUI();

            if (cmbOption.SelectedItem == null) return;

            string selectedOption = cmbOption.SelectedItem.ToString();

            if (selectedOption == "None")
            {
                return; // Do nothing for "None" option
            }

            // Validate inputs based on the selected option
            bool isValid;

            if (selectedOption == "Vector Magnitude" || selectedOption == "Vector Rotation")
            {
                // Only Vector A needs to be filled
                isValid = IsVectorAValid();
            }
            else
            {
                // For other options, both Vector A and Vector B need to be filled
                isValid = IsVectorAValid() && IsVectorBValid();
            }

            if (!isValid)
            {
                cmbOption.SelectedIndex = 0; // Reset to "None"
                MessageBox.Show("Please fill in the required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Handle options
            switch (selectedOption)
            {
                case "Addition":
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

                case "Subtraction":
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

                case "Vector Magnitude":
                    SetUIForOperation("Magnitude |a⃗|:", false, false);
                    textResult.Visible = false;
                    if (txtZV1.Visible)
                    {
                        VectorMagnitude(txtXV1.Text, txtYV1.Text, txtZV1.Text);
                    }
                    else
                    {
                        VectorMagnitude(txtXV1.Text, txtYV1.Text);
                    }
                    break;

                case "Dot Product":
                    SetUIForOperation("Dot Product (a⃗ ⋅ b⃗):", true, false);
                    if (txtZV1.Visible)
                    {
                        DotProduct(txtXV1.Text, txtXV2.Text, txtYV1.Text, txtYV2.Text, txtZV1.Text, txtZV2.Text);
                    }
                    else
                    {
                        DotProduct(txtXV1.Text, txtXV2.Text, txtYV1.Text, txtYV2.Text);
                    }
                    break;

                case "Cross Product":
                    SetUIForOperation("Cross Product (a⃗ × b⃗):", true, true);
                    if (txtZV1.Visible)
                    {
                        CrossProduct(txtXV1.Text, txtXV2.Text, txtYV1.Text, txtYV2.Text, txtZV1.Text, txtZV2.Text);
                    }
                    else
                    {
                        CrossProduct(txtXV1.Text, txtXV2.Text, txtYV1.Text, txtYV2.Text);
                    }
                    break;

                case "Vector Rotation":
                    if (radVector3D.Checked) // Check if 3D is selected
                    {
                        Open3DRotation(); // Open 3D rotation window
                    }
                    else
                    {
                        Open2DRotation(); // Open 2D rotation window (already exists)
                    }
                    break;
                default:
                    MessageBox.Show("Unknown option!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        // Function to validate the completion of Vector A fields
        private bool IsVectorAValid()
        {
            return !string.IsNullOrWhiteSpace(txtXV1.Text) &&
                   !string.IsNullOrWhiteSpace(txtYV1.Text) &&
                   (!txtZV1.Visible || !string.IsNullOrWhiteSpace(txtZV1.Text));
        }

        // Function to validate the completion of Vector B fields
        private bool IsVectorBValid()
        {
            return !string.IsNullOrWhiteSpace(txtXV2.Text) &&
                   !string.IsNullOrWhiteSpace(txtYV2.Text) &&
                   (!txtZV2.Visible || !string.IsNullOrWhiteSpace(txtZV2.Text));
        }

        // Function to reset the interface
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

        // Function to configure the UI for an operation
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

        // Function to add two 2D vectors
        public void Addition(string XV1, string XV2, string YV1, string YV2)
        {
            float x1 = ParseStringToFloat(XV1);
            float y1 = ParseStringToFloat(YV1);

            float x2 = ParseStringToFloat(XV2);
            float y2 = ParseStringToFloat(YV2);

            // Using the defined Vector2D class, create two 2D vectors and perform the addition operation using the method inside the class
            Vector2D vector1 = new Vector2D(x1, y1);
            Vector2D vector2 = new Vector2D(x2, y2);
            Vector2D sum = Vector2D.Add(vector1, vector2);
            Console.WriteLine($"Sum: {sum}");
            // Display the result in the text boxes
            txtResultX.Text = sum.X.ToString();
            txtResultY.Text = sum.Y.ToString();
        }

        // Function to add two 3D vectors
        public void Addition(string XV1, string XV2, string YV1, string YV2, string ZV1, string ZV2)
        {
            float x1 = ParseStringToFloat(XV1);
            float y1 = ParseStringToFloat(YV1);
            float z1 = ParseStringToFloat(ZV1);

            float x2 = ParseStringToFloat(XV2);
            float y2 = ParseStringToFloat(YV2);
            float z2 = ParseStringToFloat(ZV2);

            // Using the defined Vector3D class, create two 3D vectors and perform the addition operation using the method inside the class
            Vector3D vector1 = new Vector3D(x1, y1, z1);
            Vector3D vector2 = new Vector3D(x2, y2, z2);
            Vector3D sum = Vector3D.Add(vector1, vector2);
            Console.WriteLine($"Sum: {sum}");
            // Display the result in the text boxes
            txtResultX.Text = sum.X.ToString();
            txtResultY.Text = sum.Y.ToString();
            txtResultZ.Text = sum.Z.ToString();
        }

        // Function to subtract two 2D vectors
        public void Subtraction(string XV1, string XV2, string YV1, string YV2)
        {
            float x1 = ParseStringToFloat(XV1);
            float y1 = ParseStringToFloat(YV1);

            float x2 = ParseStringToFloat(XV2);
            float y2 = ParseStringToFloat(YV2);

            // Using the defined Vector2D class, create two 2D vectors and perform the subtraction operation using the method inside the class
            Vector2D vector1 = new Vector2D(x1, y1);
            Vector2D vector2 = new Vector2D(x2, y2);
            Vector2D difference = Vector2D.Subtract(vector1, vector2);
            Console.WriteLine($"Difference: {difference}");
            // Display the result in the text boxes
            txtResultX.Text = difference.X.ToString();
            txtResultY.Text = difference.Y.ToString();
        }

        // Function to subtract two 3D vectors
        public void Subtraction(string XV1, string XV2, string YV1, string YV2, string ZV1, string ZV2)
        {
            float x1 = ParseStringToFloat(XV1);
            float y1 = ParseStringToFloat(YV1);
            float z1 = ParseStringToFloat(ZV1);

            float x2 = ParseStringToFloat(XV2);
            float y2 = ParseStringToFloat(YV2);
            float z2 = ParseStringToFloat(ZV2);

            // Using the defined Vector3D class, create two 3D vectors and perform the subtraction operation using the method inside the class
            Vector3D vector1 = new Vector3D(x1, y1, z1);
            Vector3D vector2 = new Vector3D(x2, y2, z2);
            Vector3D difference = Vector3D.Subtract(vector1, vector2);
            Console.WriteLine($"Difference: {difference}");
            // Display the result in the text boxes
            txtResultX.Text = difference.X.ToString();
            txtResultY.Text = difference.Y.ToString();
            txtResultZ.Text = difference.Z.ToString();
        }

        // Function to calculate the magnitude of a 2D vector
        public void VectorMagnitude(string XV1, string YV1)
        {
            txtResultX.Visible = false;
            txtResultY.Visible = false;
            labelX.Visible = false;
            labelY.Visible = false;
            float x1 = ParseStringToFloat(XV1);
            float y1 = ParseStringToFloat(YV1);
            Vector2D vector1 = new Vector2D(x1, y1);
            float magnitude = vector1.Magnitude();
            // Display the result in the console with two decimal places
            Console.WriteLine($"Magnitude of vector ({x1}, {y1}) is: {magnitude:F2}");
            txtNormVector.Visible = true;
            txtNormVector.Text = magnitude.ToString("F2");
        }

        // Function to calculate the magnitude of a 3D vector
        public void VectorMagnitude(string XV1, string YV1, string ZV1)
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
            float magnitude = vector1.Magnitude();
            // Display the result in the console with two decimal places
            Console.WriteLine($"Magnitude of vector ({x1}, {y1}, {z1}) is: {magnitude:F2}");
            txtNormVector.Visible = true;
            txtNormVector.Text = magnitude.ToString("F2");
        }

        // Function to calculate the dot product of two 2D vectors
        public void DotProduct(string XV1, string XV2, string YV1, string YV2)
        {
            float x1 = ParseStringToFloat(XV1);
            float y1 = ParseStringToFloat(YV1);

            float x2 = ParseStringToFloat(XV2);
            float y2 = ParseStringToFloat(YV2);

            // Calculate the dot product
            float dotProduct = (x1 * x2) + (y1 * y2);
            Console.WriteLine($"Dot Product: {dotProduct}");
            textResult.Visible = true;
            txtNormVector.Visible = false;
            textResult.Text = dotProduct.ToString("F2");

            // Hide the components of the resulting vector
            txtResultX.Visible = false;
            txtResultY.Visible = false;
            txtResultZ.Visible = false;

            labelX.Visible = false;
            labelY.Visible = false;
            labelZ.Visible = false;
        }

        // Function to calculate the dot product of two 3D vectors
        public void DotProduct(string XV1, string XV2, string YV1, string YV2, string ZV1, string ZV2)
        {
            float x1 = ParseStringToFloat(XV1);
            float y1 = ParseStringToFloat(YV1);
            float z1 = ParseStringToFloat(ZV1);

            float x2 = ParseStringToFloat(XV2);
            float y2 = ParseStringToFloat(YV2);
            float z2 = ParseStringToFloat(ZV2);

            // Calculate the dot product
            float dotProduct = (x1 * x2) + (y1 * y2) + (z1 * z2);

            // Display the result in textResult
            textResult.Visible = true;
            txtNormVector.Visible = false;
            textResult.Text = dotProduct.ToString("F2");
            Console.WriteLine($"Dot Product: {dotProduct}");
            // Hide the components of the resulting vector
            txtResultX.Visible = false;
            txtResultY.Visible = false;
            txtResultZ.Visible = false;

            labelX.Visible = false;
            labelY.Visible = false;
            labelZ.Visible = false;
        }

        // Function to calculate the cross product of two 3D vectors
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
            Vector3D crossProduct = Vector3D.CrossProduct(vector1, vector2);
            // Display the result in the text boxes
            Console.WriteLine($"Cross Product: {crossProduct}");
            txtResultX.Text = crossProduct.X.ToString("F2");
            txtResultY.Text = crossProduct.Y.ToString("F2");
            txtResultZ.Text = crossProduct.Z.ToString("F2");
            textResult.Visible = false;
        }

        // Function to calculate the cross product of two 2D vectors
        public void CrossProduct(string XV1, string XV2, string YV1, string YV2)
        {
            float x1 = ParseStringToFloat(XV1);
            float y1 = ParseStringToFloat(YV1);

            float x2 = ParseStringToFloat(XV2);
            float y2 = ParseStringToFloat(YV2);

            // Calculate the cross product (scalar for 2D vectors)
            float crossProduct = (x1 * y2) - (y1 * x2);
            Console.WriteLine($"Cross Product: {crossProduct}");
            textResult.Visible = true;
            txtNormVector.Visible = false;
            textResult.Text = crossProduct.ToString("F2");

            // Hide the components of the resulting vector, as it does not apply to 2D vectors
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
            // Retrieve the vector coordinates from input fields
            float vectorX = ParseStringToFloat(txtXV1.Text);
            float vectorY = ParseStringToFloat(txtYV1.Text);
            Vector2D vector1 = new Vector2D(vectorX, vectorY);
            float distanceFromOrigin = vector1.Magnitude();
            Console.WriteLine($"Distance of the vector from the origin: ({vectorX}, {vectorY}) is: {distanceFromOrigin:F2}");
            // Instantiate the form for rotation and open it
            RotatingVector2DForm rotationForm = new RotatingVector2DForm(vectorX, vectorY);
            rotationForm.Show();
            }
            catch (Exception ex)
            {
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Open3DRotation()
        {
            try
            {
            // Retrieve the vector coordinates from input fields
            float vectorX = ParseStringToFloat(txtXV1.Text);
            float vectorY = ParseStringToFloat(txtYV1.Text);
            float vectorZ = ParseStringToFloat(txtZV1.Text);

            // Temporarily hide the main window
            this.Hide();

            // Instantiate the OpenGL 3D window
            OpenGL3DWindow rotationWindow = new OpenGL3DWindow(vectorX, vectorY, vectorZ);

            // Subscribe to the closing event of the 3D window
            rotationWindow.Closed += (sender, args) =>
            {
                // After the OpenGL window is closed, show the main window again
                this.Invoke((MethodInvoker)delegate
                {
                this.Show(); // Show the main window again
                this.BringToFront(); // Bring the main window to the front
                });
            };

            // Run the OpenGL window on the main thread
            rotationWindow.Run(60.0); // Run at 60 FPS
            }
            catch (Exception ex)
            {
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        // Function to parse a string into a float, supporting fractional input
        private float ParseStringToFloat(string input)
        {
            // Trim whitespace from the input string
            input = input.Trim();

            // Check if the string contains a fraction in the form "numerator/denominator"
            if (input.Contains("/"))
            {
            string[] parts = input.Split('/');
            if (parts.Length == 2 &&
                float.TryParse(parts[0], NumberStyles.Float, CultureInfo.InvariantCulture, out float numerator) &&
                float.TryParse(parts[1], NumberStyles.Float, CultureInfo.InvariantCulture, out float denominator))
            {
                if (denominator == 0)
                throw new DivideByZeroException("Denominator cannot be zero.");

                return numerator / denominator;
            }
            else
            {
                throw new FormatException("Invalid fraction format.");
            }
            }
            else
            {
            // Try to convert the string directly to a float
            if (float.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out float result))
            {
                return result;
            }
            else
            {
                throw new FormatException("The string is not a valid number.");
            }
            }
        }
    }
}
