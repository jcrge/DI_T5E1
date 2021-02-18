using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_T5E1
{
    public enum OrientationType { Left, Right }

    [DefaultProperty("LabelText")]
    [DefaultEvent("Load")]
    public partial class LabelTextBox : UserControl
    {
        private TextBox textBox;
        private Label label;

        private OrientationType orientation;

        [Category("Appearance")]
        [Description("Specifies whether the Label should be shown to the left or to the right of the TextBox.")]
        public OrientationType Orientation
        {
            get => orientation;
            set
            {
                if (!Enum.IsDefined(typeof(OrientationType), value))
                {
                    throw new InvalidEnumArgumentException();
                }

                orientation = value;
                Refresh();
                OrientationChanged?.Invoke(this, new EventArgs());
            }
        }

        private int separation = 0;

        [Category("Design")]
        [Description("Number of pixels of separation between the Label and the TextBox.")]
        public int Separation
        {
            get => separation;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                separation = value;
                Refresh();
                SeparationChanged?.Invoke(this, new EventArgs());
            }
        }

        [Category("Appearance")]
        [Description("Inner Label's text.")]
        public string LabelText
        {
            get => label.Text;
            set
            {
                label.Text = value;
                Refresh();
            }
        }

        [Category("Appearance")]
        [Description("Inner TextBox's text.")]
        public string TextBoxText
        {
            get => textBox.Text;
            set => textBox.Text = value;
        }

        [Category("Behavior")]
        [Description("If non-blank, specifies which character to show repeatedly on the"
            + " inner TextBox in place of the real user input so that said TextBox acts"
            + " as a password field.")]
        public char PasswordChar
        {
            get => textBox.PasswordChar;
            set => textBox.PasswordChar = value;
        }

        [Category("Design")]
        [Description("The inner Label's orientation was changed.")]
        public event EventHandler OrientationChanged;

        [Category("Design")]
        [Description("The separation between the two inner components was changed.")]
        public event EventHandler SeparationChanged;

        public LabelTextBox()
        {
            InitializeComponent();
            textBox = new TextBox();
            Controls.Add(textBox);
            label = new Label();
            label.AutoSize = true;
            Controls.Add(label);

            // Si en vez de utilizar los TextChanged y KeyUp de UserControl tuviese
            // que crear mis propios eventos: cada evento se declara como `public event
            // EventHandler NombreEvento` y se lanza con `NombreEvento?.Invoke(s, e)`.
            // Pero como TextChanged y KeyUp ya existen en UserControl, en principio lo
            // implemento así.
            textBox.TextChanged += (s, e) => OnTextChanged(e);
            textBox.KeyUp += (s, e) => OnKeyUp(e);

            textBox.Width = 40;

            TextBoxText = "";
            LabelText = Name;
            Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            UpdateLayout();
        }

        private void UpdateLayout()
        {
            Width = label.Width + Separation + textBox.Width;
            Height = Math.Max(textBox.Height, label.Height);

            Control leftControl = Orientation == OrientationType.Left ? label : (Control)textBox;
            Control rightControl = leftControl == label ? textBox : (Control)label;

            leftControl.Location = new Point(0, 0);
            rightControl.Location = new Point(leftControl.Width + Separation, 0);
        }
    }
}
