
namespace MFU_Accounting.UI
{
    partial class AddModel
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ModelTB = new System.Windows.Forms.TextBox();
            this.FueledTB = new System.Windows.Forms.TextBox();
            this.EmptyTB = new System.Windows.Forms.TextBox();
            this.BrokenTB = new System.Windows.Forms.TextBox();
            this.AddModelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(266, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            this.menuStrip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.menuStrip.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Location = new System.Drawing.Point(234, 1);
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
            this.pictureBox2.Location = new System.Drawing.Point(206, 1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Модель";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Заполнено";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Пусто";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 152);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Сломано";
            // 
            // ModelTB
            // 
            this.ModelTB.Location = new System.Drawing.Point(141, 40);
            this.ModelTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ModelTB.Name = "ModelTB";
            this.ModelTB.Size = new System.Drawing.Size(116, 23);
            this.ModelTB.TabIndex = 7;
            // 
            // FueledTB
            // 
            this.FueledTB.Location = new System.Drawing.Point(141, 75);
            this.FueledTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FueledTB.Name = "FueledTB";
            this.FueledTB.Size = new System.Drawing.Size(116, 23);
            this.FueledTB.TabIndex = 8;
            this.FueledTB.Text = "0";
            // 
            // EmptyTB
            // 
            this.EmptyTB.Location = new System.Drawing.Point(141, 110);
            this.EmptyTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EmptyTB.Name = "EmptyTB";
            this.EmptyTB.Size = new System.Drawing.Size(116, 23);
            this.EmptyTB.TabIndex = 9;
            this.EmptyTB.Text = "0";
            // 
            // BrokenTB
            // 
            this.BrokenTB.Location = new System.Drawing.Point(141, 144);
            this.BrokenTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BrokenTB.Name = "BrokenTB";
            this.BrokenTB.Size = new System.Drawing.Size(116, 23);
            this.BrokenTB.TabIndex = 10;
            this.BrokenTB.Text = "0";
            // 
            // AddModelBtn
            // 
            this.AddModelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddModelBtn.ForeColor = System.Drawing.Color.White;
            this.AddModelBtn.Location = new System.Drawing.Point(18, 189);
            this.AddModelBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddModelBtn.Name = "AddModelBtn";
            this.AddModelBtn.Size = new System.Drawing.Size(240, 27);
            this.AddModelBtn.TabIndex = 11;
            this.AddModelBtn.Text = "Добавить";
            this.AddModelBtn.UseVisualStyleBackColor = true;
            this.AddModelBtn.Click += new System.EventHandler(this.AddModelBtn_Click);
            // 
            // AddModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(58)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(266, 230);
            this.Controls.Add(this.AddModelBtn);
            this.Controls.Add(this.BrokenTB);
            this.Controls.Add(this.EmptyTB);
            this.Controls.Add(this.FueledTB);
            this.Controls.Add(this.ModelTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AddModel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление моделей";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ModelTB;
        private System.Windows.Forms.TextBox FueledTB;
        private System.Windows.Forms.TextBox EmptyTB;
        private System.Windows.Forms.TextBox BrokenTB;
        private System.Windows.Forms.Button AddModelBtn;
    }
}

