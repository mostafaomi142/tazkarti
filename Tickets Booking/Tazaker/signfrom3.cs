using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class signfrom3: Form
    {
        public signfrom3()
        {
            InitializeComponent();
        }

        private void kryptonButton9_Click(object sender, EventArgs e)
        {
            Form2 _Newform = new Form2();
            _Newform.Show();
        }

        private void kryptonButton10_Click(object sender, EventArgs e)
        {
            Form NEWform = new signform2();
            NEWform.Show();
        }
    }
}
