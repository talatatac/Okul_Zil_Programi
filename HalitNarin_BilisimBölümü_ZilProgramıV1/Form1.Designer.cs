namespace HalitNarin_BilisimBölümü_ZilProgramıV1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.zilSaatleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtlıZilSüreleriniGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.derssaatiDataSet5 = new HalitNarin_BilisimBölümü_ZilProgramıV1.derssaatiDataSet5();
            this.derssaatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.derssaatiTableAdapter = new HalitNarin_BilisimBölümü_ZilProgramıV1.derssaatiDataSet5TableAdapters.derssaatiTableAdapter();
            this.dersSaatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.girişSüresiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.öğretmenZiliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.çıkışSüresiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.derssaatiDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.derssaatiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 114);
            this.label1.TabIndex = 0;
            this.label1.Text = "00:00:00";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 137);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zilSaatleriToolStripMenuItem,
            this.kayıtlıZilSüreleriniGüncelleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(547, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // zilSaatleriToolStripMenuItem
            // 
            this.zilSaatleriToolStripMenuItem.Name = "zilSaatleriToolStripMenuItem";
            this.zilSaatleriToolStripMenuItem.Size = new System.Drawing.Size(154, 21);
            this.zilSaatleriToolStripMenuItem.Text = "- Zil Süreleri Ekle/Sil -";
            this.zilSaatleriToolStripMenuItem.Click += new System.EventHandler(this.zilSaatleriToolStripMenuItem_Click);
            // 
            // kayıtlıZilSüreleriniGüncelleToolStripMenuItem
            // 
            this.kayıtlıZilSüreleriniGüncelleToolStripMenuItem.Name = "kayıtlıZilSüreleriniGüncelleToolStripMenuItem";
            this.kayıtlıZilSüreleriniGüncelleToolStripMenuItem.Size = new System.Drawing.Size(212, 21);
            this.kayıtlıZilSüreleriniGüncelleToolStripMenuItem.Text = "- Kayıtlı Zil Sürelerini Güncelle -";
            this.kayıtlıZilSüreleriniGüncelleToolStripMenuItem.Click += new System.EventHandler(this.kayıtlıZilSüreleriniGüncelleToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dersSaatiDataGridViewTextBoxColumn,
            this.girişSüresiDataGridViewTextBoxColumn,
            this.öğretmenZiliDataGridViewTextBoxColumn,
            this.çıkışSüresiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.derssaatiBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "T";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 358);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(404, 121);
            this.dataGridView1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(412, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(126, 109);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hızlı Çal";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Zil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Saygı Duruşu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "İstiklal Marşı";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(418, 142);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Zili Değiştir";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Geçerli Zil Sesi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(256, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Geçerli Zil Sesi:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(438, 169);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(73, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Sesi Durdur";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // derssaatiDataSet5
            // 
            this.derssaatiDataSet5.DataSetName = "derssaatiDataSet5";
            this.derssaatiDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // derssaatiBindingSource
            // 
            this.derssaatiBindingSource.DataMember = "derssaati";
            this.derssaatiBindingSource.DataSource = this.derssaatiDataSet5;
            // 
            // derssaatiTableAdapter
            // 
            this.derssaatiTableAdapter.ClearBeforeFill = true;
            // 
            // dersSaatiDataGridViewTextBoxColumn
            // 
            this.dersSaatiDataGridViewTextBoxColumn.DataPropertyName = "DersSaati";
            this.dersSaatiDataGridViewTextBoxColumn.HeaderText = "DersSaati";
            this.dersSaatiDataGridViewTextBoxColumn.Name = "dersSaatiDataGridViewTextBoxColumn";
            // 
            // girişSüresiDataGridViewTextBoxColumn
            // 
            this.girişSüresiDataGridViewTextBoxColumn.DataPropertyName = "GirişSüresi";
            this.girişSüresiDataGridViewTextBoxColumn.HeaderText = "GirişSüresi";
            this.girişSüresiDataGridViewTextBoxColumn.Name = "girişSüresiDataGridViewTextBoxColumn";
            // 
            // öğretmenZiliDataGridViewTextBoxColumn
            // 
            this.öğretmenZiliDataGridViewTextBoxColumn.DataPropertyName = "ÖğretmenZili";
            this.öğretmenZiliDataGridViewTextBoxColumn.HeaderText = "ÖğretmenZili";
            this.öğretmenZiliDataGridViewTextBoxColumn.Name = "öğretmenZiliDataGridViewTextBoxColumn";
            // 
            // çıkışSüresiDataGridViewTextBoxColumn
            // 
            this.çıkışSüresiDataGridViewTextBoxColumn.DataPropertyName = "ÇıkışSüresi";
            this.çıkışSüresiDataGridViewTextBoxColumn.HeaderText = "ÇıkışSüresi";
            this.çıkışSüresiDataGridViewTextBoxColumn.Name = "çıkışSüresiDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(547, 201);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(563, 239);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(563, 239);
            this.Name = "Form1";
            this.Text = "Zil Programı";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.derssaatiDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.derssaatiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem zilSaatleriToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem kayıtlıZilSüreleriniGüncelleToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private derssaatiDataSet5 derssaatiDataSet5;
        private System.Windows.Forms.BindingSource derssaatiBindingSource;
        private derssaatiDataSet5TableAdapters.derssaatiTableAdapter derssaatiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersSaatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn girişSüresiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn öğretmenZiliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn çıkışSüresiDataGridViewTextBoxColumn;
    }
}

