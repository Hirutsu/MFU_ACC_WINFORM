
namespace MFU_Accounting.UI
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteModelTS = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.modelsInfo = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ModelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fueled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddFueled = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteFueled = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Пустые = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddEmpty = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteEmpty = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Broken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddBroken = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteBroken = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.DeleteModelTS,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(686, 29);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            this.menuStrip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.menuStrip.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(162, 25);
            this.toolStripMenuItem1.Text = "Добавить модель";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // DeleteModelTS
            // 
            this.DeleteModelTS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteModelTS.ForeColor = System.Drawing.Color.White;
            this.DeleteModelTS.Name = "DeleteModelTS";
            this.DeleteModelTS.Size = new System.Drawing.Size(149, 25);
            this.DeleteModelTS.Text = "Удалить модель";
            this.DeleteModelTS.Click += new System.EventHandler(this.DeleteModelTS_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(127, 25);
            this.aboutToolStripMenuItem.Text = "О программе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Location = new System.Drawing.Point(656, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox2.Location = new System.Drawing.Point(625, 6);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // modelsInfo
            // 
            this.modelsInfo.AllowUserToAddRows = false;
            this.modelsInfo.AllowUserToDeleteRows = false;
            this.modelsInfo.AllowUserToResizeColumns = false;
            this.modelsInfo.AllowUserToResizeRows = false;
            this.modelsInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.modelsInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
            this.modelsInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modelsInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.modelsInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = "Null";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.modelsInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.modelsInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.modelsInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ModelID,
            this.Model,
            this.Fueled,
            this.AddFueled,
            this.DeleteFueled,
            this.Пустые,
            this.AddEmpty,
            this.DeleteEmpty,
            this.Broken,
            this.AddBroken,
            this.DeleteBroken});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.modelsInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.modelsInfo.Location = new System.Drawing.Point(14, 47);
            this.modelsInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.modelsInfo.MultiSelect = false;
            this.modelsInfo.Name = "modelsInfo";
            this.modelsInfo.ReadOnly = true;
            this.modelsInfo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.modelsInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.modelsInfo.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.modelsInfo.Size = new System.Drawing.Size(658, 303);
            this.modelsInfo.TabIndex = 3;
            this.modelsInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.modelsInfo_CellContentClick);
            // 
            // ModelID
            // 
            this.ModelID.FillWeight = 50F;
            this.ModelID.HeaderText = "ID";
            this.ModelID.Name = "ModelID";
            this.ModelID.ReadOnly = true;
            // 
            // Model
            // 
            this.Model.FillWeight = 106.2875F;
            this.Model.HeaderText = "Модель";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // Fueled
            // 
            this.Fueled.FillWeight = 110F;
            this.Fueled.HeaderText = "Заправлено";
            this.Fueled.Name = "Fueled";
            this.Fueled.ReadOnly = true;
            this.Fueled.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Fueled.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AddFueled
            // 
            this.AddFueled.FillWeight = 48.7672F;
            this.AddFueled.HeaderText = "+";
            this.AddFueled.Name = "AddFueled";
            this.AddFueled.ReadOnly = true;
            this.AddFueled.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AddFueled.Text = "+";
            // 
            // DeleteFueled
            // 
            this.DeleteFueled.FillWeight = 48.7672F;
            this.DeleteFueled.HeaderText = "-";
            this.DeleteFueled.Name = "DeleteFueled";
            this.DeleteFueled.ReadOnly = true;
            this.DeleteFueled.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Пустые
            // 
            this.Пустые.FillWeight = 96.62178F;
            this.Пустые.HeaderText = "Пусто";
            this.Пустые.Name = "Пустые";
            this.Пустые.ReadOnly = true;
            this.Пустые.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AddEmpty
            // 
            this.AddEmpty.FillWeight = 48.7672F;
            this.AddEmpty.HeaderText = "+";
            this.AddEmpty.Name = "AddEmpty";
            this.AddEmpty.ReadOnly = true;
            this.AddEmpty.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DeleteEmpty
            // 
            this.DeleteEmpty.FillWeight = 48.7672F;
            this.DeleteEmpty.HeaderText = "-";
            this.DeleteEmpty.Name = "DeleteEmpty";
            this.DeleteEmpty.ReadOnly = true;
            this.DeleteEmpty.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Broken
            // 
            this.Broken.FillWeight = 96.62178F;
            this.Broken.HeaderText = "Сломано";
            this.Broken.Name = "Broken";
            this.Broken.ReadOnly = true;
            this.Broken.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AddBroken
            // 
            this.AddBroken.FillWeight = 48.7672F;
            this.AddBroken.HeaderText = "+";
            this.AddBroken.Name = "AddBroken";
            this.AddBroken.ReadOnly = true;
            this.AddBroken.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DeleteBroken
            // 
            this.DeleteBroken.FillWeight = 48.7672F;
            this.DeleteBroken.HeaderText = "-";
            this.DeleteBroken.Name = "DeleteBroken";
            this.DeleteBroken.ReadOnly = true;
            this.DeleteBroken.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(686, 366);
            this.Controls.Add(this.modelsInfo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView modelsInfo;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem DeleteModelTS;
        private DataGridViewTextBoxColumn ModelID;
        private DataGridViewTextBoxColumn Model;
        private DataGridViewTextBoxColumn Fueled;
        private DataGridViewButtonColumn AddFueled;
        private DataGridViewButtonColumn DeleteFueled;
        private DataGridViewTextBoxColumn Пустые;
        private DataGridViewButtonColumn AddEmpty;
        private DataGridViewButtonColumn DeleteEmpty;
        private DataGridViewTextBoxColumn Broken;
        private DataGridViewButtonColumn AddBroken;
        private DataGridViewButtonColumn DeleteBroken;
    }
}

