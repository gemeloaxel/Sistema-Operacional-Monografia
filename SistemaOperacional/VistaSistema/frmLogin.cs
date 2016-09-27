using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace VistaSistema
{
    public partial class frmLogin :DevComponents.DotNetBar.Office2007Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }

        private void buttonAdv1_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
