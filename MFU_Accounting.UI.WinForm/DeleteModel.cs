using MFU_Accounting.BLL.Interfaces;
using MFU_Accounting.Common;

namespace MFU_Accounting.UI.WinForm
{
    public partial class DeleteModel : Form
    {
        Point lastPoint;
        IModelService _modelService = Dependencies.ModelService;

        public DeleteModel()
        {
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

        private void DeleteModelBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(InputIdTB.Text);
            _modelService.DeleteModel(id);
            this.Close();
            Application.Restart();
        }

        private void InputIdTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                MessageBox.Show("Ввод только для чисел");
                e.Handled = true;
            }
        }
    }
}
