using DI_T5E1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_T5E1_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelTextBox1.SeparationChanged +=
                (s, e) => labelSeparation.Text = labelTextBox1.Separation + "";
            labelTextBox1.OrientationChanged +=
                (s, e) => Text = labelTextBox1.Orientation == OrientationType.Left ? "Left" : "Right";
            labelTextBox1.KeyUp += (s, e) => labelLastPressedKey.Text = e.KeyData.ToString();
            labelTextBox1.TextChanged += (s, e) => labelUpdatedText.Text = labelTextBox1.TextBoxText;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonInvertOrientation_Click(object sender, EventArgs e)
        {
            labelTextBox1.Orientation =
                labelTextBox1.Orientation == OrientationType.Left
                ? OrientationType.Right
                : OrientationType.Left;
        }

        private void buttonChangePasswordChar_Click(object sender, EventArgs e)
        {
            if (textBoxPasswordChar.Text.Length > 1)
            {
                MessageBox.Show(null,
                    "Invalid value for PasswordChar.",
                    "Invalid value",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                labelTextBox1.PasswordChar =
                    textBoxPasswordChar.Text.Length == 0 ? '\0' : textBoxPasswordChar.Text[0];
            }
        }

        private void buttonChangeSeparation_Click(object sender, EventArgs e)
        {
            int newValue;
            if (!int.TryParse(textBoxSeparation.Text, out newValue) || newValue < 0)
            {
                MessageBox.Show(null,
                    "Invalid separation value.",
                    "Invalid value",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                labelTextBox1.Separation = newValue;
                Refresh();
            }
        }
    }
}
