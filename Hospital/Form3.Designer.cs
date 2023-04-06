namespace Hospital
{
    partial class Form3
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
            this.beteg_felvetel_gomb = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hospitalDataSet15 = new Hospital.hospitalDataSet15();
            this.alkalmazottakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alkalmazottakTableAdapter = new Hospital.hospitalDataSet15TableAdapters.alkalmazottakTableAdapter();
            this.alkalmazottidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonszamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alkalmazottakBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // beteg_felvetel_gomb
            // 
            this.beteg_felvetel_gomb.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.beteg_felvetel_gomb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.beteg_felvetel_gomb.Location = new System.Drawing.Point(12, 12);
            this.beteg_felvetel_gomb.Name = "beteg_felvetel_gomb";
            this.beteg_felvetel_gomb.Size = new System.Drawing.Size(107, 43);
            this.beteg_felvetel_gomb.TabIndex = 1;
            this.beteg_felvetel_gomb.Text = "Orvosok";
            this.beteg_felvetel_gomb.UseVisualStyleBackColor = false;
            this.beteg_felvetel_gomb.Click += new System.EventHandler(this.ORVOS_felvetel_gomb_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(12, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Aszisztensek";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(12, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 43);
            this.button2.TabIndex = 3;
            this.button2.Text = "Beszalitok";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LawnGreen;
            this.label9.Location = new System.Drawing.Point(366, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 32);
            this.label9.TabIndex = 5;
            this.label9.Text = "ALKALMAZOTTAK";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.alkalmazottidDataGridViewTextBoxColumn,
            this.nevDataGridViewTextBoxColumn,
            this.telefonszamDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.alkalmazottakBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(207, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(581, 377);
            this.dataGridView1.TabIndex = 6;
            // 
            // hospitalDataSet15
            // 
            this.hospitalDataSet15.DataSetName = "hospitalDataSet15";
            this.hospitalDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alkalmazottakBindingSource
            // 
            this.alkalmazottakBindingSource.DataMember = "alkalmazottak";
            this.alkalmazottakBindingSource.DataSource = this.hospitalDataSet15;
            // 
            // alkalmazottakTableAdapter
            // 
            this.alkalmazottakTableAdapter.ClearBeforeFill = true;
            // 
            // alkalmazottidDataGridViewTextBoxColumn
            // 
            this.alkalmazottidDataGridViewTextBoxColumn.DataPropertyName = "alkalmazott_id";
            this.alkalmazottidDataGridViewTextBoxColumn.HeaderText = "alkalmazott_id";
            this.alkalmazottidDataGridViewTextBoxColumn.Name = "alkalmazottidDataGridViewTextBoxColumn";
            // 
            // nevDataGridViewTextBoxColumn
            // 
            this.nevDataGridViewTextBoxColumn.DataPropertyName = "nev";
            this.nevDataGridViewTextBoxColumn.HeaderText = "nev";
            this.nevDataGridViewTextBoxColumn.Name = "nevDataGridViewTextBoxColumn";
            // 
            // telefonszamDataGridViewTextBoxColumn
            // 
            this.telefonszamDataGridViewTextBoxColumn.DataPropertyName = "telefonszam";
            this.telefonszamDataGridViewTextBoxColumn.HeaderText = "telefonszam";
            this.telefonszamDataGridViewTextBoxColumn.Name = "telefonszamDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hospital.Properties.Resources._16x9_M1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.beteg_felvetel_gomb);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alkalmazottakBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button beteg_felvetel_gomb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private hospitalDataSet15 hospitalDataSet15;
        private System.Windows.Forms.BindingSource alkalmazottakBindingSource;
        private hospitalDataSet15TableAdapters.alkalmazottakTableAdapter alkalmazottakTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn alkalmazottidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonszamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}