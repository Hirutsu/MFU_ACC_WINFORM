using MFU_Accounting.BLL.Interfaces;
using MFU_Accounting.Common;
using MFU_Accounting.Entities;

namespace MFU_Accounting.UI
{
    public partial class AddModel : Form
    {
        IModelService _modelService = Dependencies.ModelService;
        Main _main;
        public AddModel(Main main)
        {
            _main = main;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        Point lastPoint;

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void AddModelBtn_Click(object sender, EventArgs e)
        {
            Model model = new Model();
            model.Name = ModelTB.Text;
            model.CountFueled = Convert.ToInt32(FueledTB.Text);
            model.CountEmpty = Convert.ToInt32(EmptyTB.Text);
            model.CountBroken = Convert.ToInt32(BrokenTB.Text);
            _modelService.AddModel(model);
            this.Close();
            Application.Restart();
        }
    }
}
