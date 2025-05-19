using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleships
{
    public partial class Form1 : Form
    { 
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TempFormTesting(this, this.CreateGraphics());
        }

        public void TempFormTesting(Form1 InputForm, Graphics FormGraphics)
        {
            FormMethods ChangeForm = new FormMethods(InputForm, FormGraphics);
            ChangeForm.SetupBaseForm();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
        }
    }
}
