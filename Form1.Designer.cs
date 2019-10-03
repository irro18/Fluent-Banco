namespace FluentBanco
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNumDeC = new System.Windows.Forms.TextBox();
            this.textBoxPropietario = new System.Windows.Forms.TextBox();
            this.textBoxTasa = new System.Windows.Forms.TextBox();
            this.textBoxSaldoInicial = new System.Windows.Forms.TextBox();
            this.comboBox1TipodeC = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonGenerar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(11, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de Cuenta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Propietario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tasa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Saldo Inicial:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo de Cuenta:";
            // 
            // textBoxNumDeC
            // 
            this.textBoxNumDeC.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxNumDeC.Location = new System.Drawing.Point(116, 33);
            this.textBoxNumDeC.Name = "textBoxNumDeC";
            this.textBoxNumDeC.Size = new System.Drawing.Size(134, 20);
            this.textBoxNumDeC.TabIndex = 5;
            this.textBoxNumDeC.TextChanged += new System.EventHandler(this.TextBoxNumDeC_TextChanged);
            // 
            // textBoxPropietario
            // 
            this.textBoxPropietario.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxPropietario.Location = new System.Drawing.Point(116, 59);
            this.textBoxPropietario.Name = "textBoxPropietario";
            this.textBoxPropietario.Size = new System.Drawing.Size(134, 20);
            this.textBoxPropietario.TabIndex = 6;
            // 
            // textBoxTasa
            // 
            this.textBoxTasa.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxTasa.Location = new System.Drawing.Point(116, 92);
            this.textBoxTasa.Name = "textBoxTasa";
            this.textBoxTasa.Size = new System.Drawing.Size(134, 20);
            this.textBoxTasa.TabIndex = 7;
            this.textBoxTasa.Text = "0";
            // 
            // textBoxSaldoInicial
            // 
            this.textBoxSaldoInicial.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxSaldoInicial.Location = new System.Drawing.Point(116, 125);
            this.textBoxSaldoInicial.Name = "textBoxSaldoInicial";
            this.textBoxSaldoInicial.Size = new System.Drawing.Size(134, 20);
            this.textBoxSaldoInicial.TabIndex = 8;
            this.textBoxSaldoInicial.Text = "0";
            // 
            // comboBox1TipodeC
            // 
            this.comboBox1TipodeC.BackColor = System.Drawing.SystemColors.Info;
            this.comboBox1TipodeC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1TipodeC.FormattingEnabled = true;
            this.comboBox1TipodeC.Items.AddRange(new object[] {
            "Basic",
            "Platinum",
            "Golden",
            "Black"});
            this.comboBox1TipodeC.Location = new System.Drawing.Point(116, 156);
            this.comboBox1TipodeC.Name = "comboBox1TipodeC";
            this.comboBox1TipodeC.Size = new System.Drawing.Size(134, 21);
            this.comboBox1TipodeC.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(500, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Lista de Cuentas Generadas:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(314, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 182);
            this.dataGridView1.TabIndex = 11;
            // 
            // buttonGenerar
            // 
            this.buttonGenerar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonGenerar.Location = new System.Drawing.Point(116, 194);
            this.buttonGenerar.Name = "buttonGenerar";
            this.buttonGenerar.Size = new System.Drawing.Size(134, 23);
            this.buttonGenerar.TabIndex = 12;
            this.buttonGenerar.Text = "Generar Cuenta";
            this.buttonGenerar.UseVisualStyleBackColor = false;
            this.buttonGenerar.Click += new System.EventHandler(this.ButtonGenerar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(879, 241);
            this.Controls.Add(this.buttonGenerar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1TipodeC);
            this.Controls.Add(this.textBoxSaldoInicial);
            this.Controls.Add(this.textBoxTasa);
            this.Controls.Add(this.textBoxPropietario);
            this.Controls.Add(this.textBoxNumDeC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cuentas de Banco";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNumDeC;
        private System.Windows.Forms.TextBox textBoxPropietario;
        private System.Windows.Forms.TextBox textBoxTasa;
        private System.Windows.Forms.TextBox textBoxSaldoInicial;
        private System.Windows.Forms.ComboBox comboBox1TipodeC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonGenerar;
    }
}