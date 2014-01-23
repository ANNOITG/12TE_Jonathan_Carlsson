namespace LinQ_projct
{
    partial class Form1
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
            this.bandDGV = new System.Windows.Forms.DataGridView();
            this.bandBS = new System.Windows.Forms.BindingSource(this.components);
            this.bandNameTbx = new System.Windows.Forms.TextBox();
            this.bandStartYearTbx = new System.Windows.Forms.TextBox();
            this.bandCountTbx = new System.Windows.Forms.TextBox();
            this.bandFromTbx = new System.Windows.Forms.TextBox();
            this.bandInfoTbx = new System.Windows.Forms.TextBox();
            this.bandAddBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bandRemoveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bandDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandBS)).BeginInit();
            this.SuspendLayout();
            // 
            // bandDGV
            // 
            this.bandDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bandDGV.Location = new System.Drawing.Point(12, 12);
            this.bandDGV.Name = "bandDGV";
            this.bandDGV.Size = new System.Drawing.Size(590, 279);
            this.bandDGV.TabIndex = 0;
            this.bandDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bandNameTbx
            // 
            this.bandNameTbx.Location = new System.Drawing.Point(12, 310);
            this.bandNameTbx.Name = "bandNameTbx";
            this.bandNameTbx.Size = new System.Drawing.Size(133, 20);
            this.bandNameTbx.TabIndex = 1;
            // 
            // bandStartYearTbx
            // 
            this.bandStartYearTbx.Location = new System.Drawing.Point(172, 310);
            this.bandStartYearTbx.Name = "bandStartYearTbx";
            this.bandStartYearTbx.Size = new System.Drawing.Size(133, 20);
            this.bandStartYearTbx.TabIndex = 2;
            // 
            // bandCountTbx
            // 
            this.bandCountTbx.Location = new System.Drawing.Point(12, 352);
            this.bandCountTbx.Name = "bandCountTbx";
            this.bandCountTbx.Size = new System.Drawing.Size(133, 20);
            this.bandCountTbx.TabIndex = 3;
            // 
            // bandFromTbx
            // 
            this.bandFromTbx.Location = new System.Drawing.Point(172, 352);
            this.bandFromTbx.Name = "bandFromTbx";
            this.bandFromTbx.Size = new System.Drawing.Size(133, 20);
            this.bandFromTbx.TabIndex = 4;
            // 
            // bandInfoTbx
            // 
            this.bandInfoTbx.Location = new System.Drawing.Point(12, 392);
            this.bandInfoTbx.Name = "bandInfoTbx";
            this.bandInfoTbx.Size = new System.Drawing.Size(293, 20);
            this.bandInfoTbx.TabIndex = 5;
            // 
            // bandAddBtn
            // 
            this.bandAddBtn.Location = new System.Drawing.Point(230, 426);
            this.bandAddBtn.Name = "bandAddBtn";
            this.bandAddBtn.Size = new System.Drawing.Size(75, 23);
            this.bandAddBtn.TabIndex = 6;
            this.bandAddBtn.Text = "Spara";
            this.bandAddBtn.UseVisualStyleBackColor = true;
            this.bandAddBtn.Click += new System.EventHandler(this.bandAddBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Startår";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Band Namn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Antal medlemmar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ursprung";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Info";
            // 
            // bandRemoveBtn
            // 
            this.bandRemoveBtn.Location = new System.Drawing.Point(418, 426);
            this.bandRemoveBtn.Name = "bandRemoveBtn";
            this.bandRemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.bandRemoveBtn.TabIndex = 12;
            this.bandRemoveBtn.Text = "Ta bort";
            this.bandRemoveBtn.UseVisualStyleBackColor = true;
            this.bandRemoveBtn.Click += new System.EventHandler(this.bandRemoveBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 461);
            this.Controls.Add(this.bandRemoveBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bandAddBtn);
            this.Controls.Add(this.bandInfoTbx);
            this.Controls.Add(this.bandFromTbx);
            this.Controls.Add(this.bandCountTbx);
            this.Controls.Add(this.bandStartYearTbx);
            this.Controls.Add(this.bandNameTbx);
            this.Controls.Add(this.bandDGV);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bandDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandBS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView bandDGV;
        private System.Windows.Forms.BindingSource bandBS;
        private System.Windows.Forms.TextBox bandNameTbx;
        private System.Windows.Forms.TextBox bandStartYearTbx;
        private System.Windows.Forms.TextBox bandCountTbx;
        private System.Windows.Forms.TextBox bandFromTbx;
        private System.Windows.Forms.TextBox bandInfoTbx;
        private System.Windows.Forms.Button bandAddBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bandRemoveBtn;
    }
}

