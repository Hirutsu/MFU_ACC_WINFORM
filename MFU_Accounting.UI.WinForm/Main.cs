using MFU_Accounting.BLL.Interfaces;
using MFU_Accounting.Common;
using MFU_Accounting.Entities;
using MFU_Accounting.UI.WinForm;

namespace MFU_Accounting.UI
{
    public partial class Main : Form
    {
        IModelService _modelService = Dependencies.ModelService;
        Form? addModel;
        Form? about;
        Form? deleteModel;
        List<Model>? models;

        public  Main()
        {
            models = _modelService.GetModels();
            InitializeComponent();
            SetModelInfo(models);
        }

        private void SetModelInfo(List<Model> models)
        {
            int i = 0;
            foreach (var model in models)
            {
                modelsInfo.Rows.Add();
                modelsInfo[0, i].Value = model.ModelId;
                modelsInfo[1, i].Value = model.Name;
                modelsInfo[2, i].Value = model.CountFueled;
                modelsInfo[3, i].Value = "+";
                modelsInfo[4, i].Value = "-";
                modelsInfo[5, i].Value = model.CountEmpty;
                modelsInfo[6, i].Value = "+";
                modelsInfo[7, i].Value = "-";
                modelsInfo[8, i].Value = model.CountBroken;
                modelsInfo[9, i].Value = "+";
                modelsInfo[10, i].Value = "-";
                i++;
            }
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (addModel == null || addModel.IsDisposed) 
            {
                addModel = new AddModel(this); 
                addModel.Show(); 
            }
            else 
            { 
                addModel.Focus(); 
            }
        }

        private void modelsInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(modelsInfo[0, senderGrid.CurrentCellAddress.Y].Value);

                if (senderGrid.CurrentCellAddress.X == 3)
                {
                    _modelService.UpdateFueledPlus(id);
                    int cur = Convert.ToInt32(modelsInfo[2, senderGrid.CurrentCellAddress.Y].Value.ToString());
                    modelsInfo[2, senderGrid.CurrentCellAddress.Y].Value = cur + 1;
                }
                if (senderGrid.CurrentCellAddress.X == 4)
                {
                    _modelService.UpdateFueledMinus(id);
                    int cur = Convert.ToInt32(modelsInfo[2, senderGrid.CurrentCellAddress.Y].Value.ToString());
                    modelsInfo[2, senderGrid.CurrentCellAddress.Y].Value = cur - 1;
                }

                if (senderGrid.CurrentCellAddress.X == 6)
                {
                    _modelService.UpdateEmptyPlus(id);
                    int cur = Convert.ToInt32(modelsInfo[5, senderGrid.CurrentCellAddress.Y].Value.ToString());
                    modelsInfo[5, senderGrid.CurrentCellAddress.Y].Value = cur + 1;
                }
                if (senderGrid.CurrentCellAddress.X == 7)
                {
                    _modelService.UpdateEmptyMinus(id);
                    int cur = Convert.ToInt32(modelsInfo[5, senderGrid.CurrentCellAddress.Y].Value.ToString());
                    modelsInfo[5, senderGrid.CurrentCellAddress.Y].Value = cur - 1;
                }

                if (senderGrid.CurrentCellAddress.X == 9)
                {
                    _modelService.UpdateBrokenPlus(id);
                    int cur = Convert.ToInt32(modelsInfo[8, senderGrid.CurrentCellAddress.Y].Value.ToString());
                    modelsInfo[8, senderGrid.CurrentCellAddress.Y].Value = cur + 1;
                }
                if (senderGrid.CurrentCellAddress.X == 10)
                {
                    _modelService.UpdateBrokenMinuse(id);
                    int cur = Convert.ToInt32(modelsInfo[8, senderGrid.CurrentCellAddress.Y].Value.ToString());
                    modelsInfo[8, senderGrid.CurrentCellAddress.Y].Value = cur - 1;
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (about == null || about.IsDisposed)
            {
                about = new About();
                about.Show();
            }
            else
            {
                about.Focus();
            }
        }

        private void DeleteModelTS_Click(object sender, EventArgs e)
        {
            if (deleteModel == null || deleteModel.IsDisposed)
            {
                deleteModel = new DeleteModel();
                deleteModel.Show();
            }
            else
            {
                deleteModel.Focus();
            }
        }
    }
}
