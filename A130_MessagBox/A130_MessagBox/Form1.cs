using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A130_MessagBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //(1) The simplest overload of MessageBox.Show.
            MessageBox.Show("simplest overload of MessageBox.");

            //(2) Dialog box with text and a title.
            MessageBox.Show("Dialog box with text and a title.");

            //(3) Dialog box with excalamtion icon.
            MessageBox.Show("Dialog box with excalamation icon.",
                "excalamation mark and alert sound",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //(4) Dialog box with two buttons: yes and no.
            DialogResult result1 = MessageBox.Show(
                "Dialog box with two buttons.",
                "Question", MessageBoxButtons.YesNo);

            //(5) Dialog box with question icon.
            DialogResult result2 = MessageBox.Show(
                "Dialog box with three buttons and question mark.", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            //(6) Dialog box with question icon and default button.
            DialogResult result3 = MessageBox.Show(
                "Dialog box with buttons", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            string msg = string.Format("your choice : {0} {1} {2}", result1.ToString(), result2.ToString(), result3.ToString());

            //(7) Dialog box that shows selections
            MessageBox.Show(msg, "Your Selections");
        }
    }
}
