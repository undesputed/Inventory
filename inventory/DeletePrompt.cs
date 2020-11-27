using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory
{
    public partial class DeletePrompt : Form
    {
        public DeletePrompt()
        {
            InitializeComponent();
        }

        private void btnPromptContinue_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPromptCancel_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnPromptNo_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
