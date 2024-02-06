using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourNamespace
{
    public class BaseForm : Form
    {
        public BaseForm()
        {

            this.Height = 1000;
            this.Width = 1000;
            this.BackColor = Color.YellowGreen;
            this.StartPosition = FormStartPosition.CenterScreen;
          

        }

        private void InitializeComponent()
        {

        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
        }
    }
}

