namespace REad_Excel
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextBox_feedback = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this._bCreateCylXML = new System.Windows.Forms.Button();
            this._bAdd_Cyl = new System.Windows.Forms.Button();
            this._cbInputs = new System.Windows.Forms.ComboBox();
            this._cbOutputs = new System.Windows.Forms.ComboBox();
            this._bAdd_HSensor = new System.Windows.Forms.Button();
            this._bAdd_WSensor = new System.Windows.Forms.Button();
            this._bAdd_HAct = new System.Windows.Forms.Button();
            this._bAdd_WAct = new System.Windows.Forms.Button();
            this._lCylName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._tbTipo_Cyl = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._lInput_H = new System.Windows.Forms.Label();
            this._lInput_W = new System.Windows.Forms.Label();
            this._lOutput_H = new System.Windows.Forms.Label();
            this._lOutput_W = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._tbTimeout = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Abrir Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TextBox_feedback);
            this.panel1.Location = new System.Drawing.Point(199, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 29);
            this.panel1.TabIndex = 3;
            // 
            // TextBox_feedback
            // 
            this.TextBox_feedback.Location = new System.Drawing.Point(3, 3);
            this.TextBox_feedback.Name = "TextBox_feedback";
            this.TextBox_feedback.ReadOnly = true;
            this.TextBox_feedback.Size = new System.Drawing.Size(385, 20);
            this.TextBox_feedback.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 527);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 22);
            this.button2.TabIndex = 5;
            this.button2.Text = "Criar IO XML";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // _bCreateCylXML
            // 
            this._bCreateCylXML.Location = new System.Drawing.Point(199, 526);
            this._bCreateCylXML.Name = "_bCreateCylXML";
            this._bCreateCylXML.Size = new System.Drawing.Size(181, 23);
            this._bCreateCylXML.TabIndex = 6;
            this._bCreateCylXML.Text = "Criar Cylinders XML";
            this._bCreateCylXML.UseVisualStyleBackColor = true;
            this._bCreateCylXML.Click += new System.EventHandler(this._bCreateCylXML_Click);
            // 
            // _bAdd_Cyl
            // 
            this._bAdd_Cyl.Location = new System.Drawing.Point(199, 497);
            this._bAdd_Cyl.Name = "_bAdd_Cyl";
            this._bAdd_Cyl.Size = new System.Drawing.Size(181, 23);
            this._bAdd_Cyl.TabIndex = 7;
            this._bAdd_Cyl.Text = "Adicionar Cylindro";
            this._bAdd_Cyl.UseVisualStyleBackColor = true;
            this._bAdd_Cyl.Click += new System.EventHandler(this._bAdd_Cyl_Click);
            // 
            // _cbInputs
            // 
            this._cbInputs.FormattingEnabled = true;
            this._cbInputs.Location = new System.Drawing.Point(12, 113);
            this._cbInputs.Name = "_cbInputs";
            this._cbInputs.Size = new System.Drawing.Size(198, 21);
            this._cbInputs.TabIndex = 8;
            // 
            // _cbOutputs
            // 
            this._cbOutputs.FormattingEnabled = true;
            this._cbOutputs.Location = new System.Drawing.Point(12, 174);
            this._cbOutputs.Name = "_cbOutputs";
            this._cbOutputs.Size = new System.Drawing.Size(198, 21);
            this._cbOutputs.TabIndex = 9;
            // 
            // _bAdd_HSensor
            // 
            this._bAdd_HSensor.Location = new System.Drawing.Point(242, 108);
            this._bAdd_HSensor.Name = "_bAdd_HSensor";
            this._bAdd_HSensor.Size = new System.Drawing.Size(138, 23);
            this._bAdd_HSensor.TabIndex = 10;
            this._bAdd_HSensor.Text = "Adicionar Sensor_H";
            this._bAdd_HSensor.UseVisualStyleBackColor = true;
            this._bAdd_HSensor.Click += new System.EventHandler(this._bAdd_HSensor_Click);
            // 
            // _bAdd_WSensor
            // 
            this._bAdd_WSensor.Location = new System.Drawing.Point(242, 137);
            this._bAdd_WSensor.Name = "_bAdd_WSensor";
            this._bAdd_WSensor.Size = new System.Drawing.Size(138, 23);
            this._bAdd_WSensor.TabIndex = 11;
            this._bAdd_WSensor.Text = "Adicionar Sensor_W";
            this._bAdd_WSensor.UseVisualStyleBackColor = true;
            this._bAdd_WSensor.Click += new System.EventHandler(this._bAdd_WSensor_Click);
            // 
            // _bAdd_HAct
            // 
            this._bAdd_HAct.Location = new System.Drawing.Point(242, 167);
            this._bAdd_HAct.Name = "_bAdd_HAct";
            this._bAdd_HAct.Size = new System.Drawing.Size(138, 23);
            this._bAdd_HAct.TabIndex = 12;
            this._bAdd_HAct.Text = "Adicionar Atuador_H";
            this._bAdd_HAct.UseVisualStyleBackColor = true;
            this._bAdd_HAct.Click += new System.EventHandler(this._bAdd_HAct_Click);
            // 
            // _bAdd_WAct
            // 
            this._bAdd_WAct.Location = new System.Drawing.Point(242, 196);
            this._bAdd_WAct.Name = "_bAdd_WAct";
            this._bAdd_WAct.Size = new System.Drawing.Size(138, 23);
            this._bAdd_WAct.TabIndex = 13;
            this._bAdd_WAct.Text = "Adicionar Atuador_W";
            this._bAdd_WAct.UseVisualStyleBackColor = true;
            this._bAdd_WAct.Click += new System.EventHandler(this._bAdd_WAct_Click);
            // 
            // _lCylName
            // 
            this._lCylName.Location = new System.Drawing.Point(12, 252);
            this._lCylName.Name = "_lCylName";
            this._lCylName.Size = new System.Drawing.Size(178, 20);
            this._lCylName.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nome Cilindro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Lista Outputs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Lista inputs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Tipo Cilindro";
            // 
            // _tbTipo_Cyl
            // 
            this._tbTipo_Cyl.Location = new System.Drawing.Point(242, 252);
            this._tbTipo_Cyl.Name = "_tbTipo_Cyl";
            this._tbTipo_Cyl.Size = new System.Drawing.Size(60, 20);
            this._tbTipo_Cyl.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 278);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 191);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridView1_Paint);
            // 
            // _lInput_H
            // 
            this._lInput_H.AutoSize = true;
            this._lInput_H.Location = new System.Drawing.Point(386, 113);
            this._lInput_H.Name = "_lInput_H";
            this._lInput_H.Size = new System.Drawing.Size(72, 13);
            this._lInput_H.TabIndex = 21;
            this._lInput_H.Text = "Nome Cilindro";
            // 
            // _lInput_W
            // 
            this._lInput_W.AutoSize = true;
            this._lInput_W.Location = new System.Drawing.Point(386, 142);
            this._lInput_W.Name = "_lInput_W";
            this._lInput_W.Size = new System.Drawing.Size(72, 13);
            this._lInput_W.TabIndex = 22;
            this._lInput_W.Text = "Nome Cilindro";
            // 
            // _lOutput_H
            // 
            this._lOutput_H.AutoSize = true;
            this._lOutput_H.Location = new System.Drawing.Point(386, 172);
            this._lOutput_H.Name = "_lOutput_H";
            this._lOutput_H.Size = new System.Drawing.Size(72, 13);
            this._lOutput_H.TabIndex = 23;
            this._lOutput_H.Text = "Nome Cilindro";
            // 
            // _lOutput_W
            // 
            this._lOutput_W.AutoSize = true;
            this._lOutput_W.Location = new System.Drawing.Point(386, 201);
            this._lOutput_W.Name = "_lOutput_W";
            this._lOutput_W.Size = new System.Drawing.Size(72, 13);
            this._lOutput_W.TabIndex = 24;
            this._lOutput_W.Text = "Nome Cilindro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "TimeOut Cilindro";
            // 
            // _tbTimeout
            // 
            this._tbTimeout.Location = new System.Drawing.Point(389, 252);
            this._tbTimeout.Name = "_tbTimeout";
            this._tbTimeout.Size = new System.Drawing.Size(60, 20);
            this._tbTimeout.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 561);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._tbTimeout);
            this.Controls.Add(this._lOutput_W);
            this.Controls.Add(this._lOutput_H);
            this.Controls.Add(this._lInput_W);
            this.Controls.Add(this._lInput_H);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._tbTipo_Cyl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._lCylName);
            this.Controls.Add(this._bAdd_WAct);
            this.Controls.Add(this._bAdd_HAct);
            this.Controls.Add(this._bAdd_WSensor);
            this.Controls.Add(this._bAdd_HSensor);
            this.Controls.Add(this._cbOutputs);
            this.Controls.Add(this._cbInputs);
            this.Controls.Add(this._bAdd_Cyl);
            this.Controls.Add(this._bCreateCylXML);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TextBox_feedback;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button _bCreateCylXML;
        private System.Windows.Forms.Button _bAdd_Cyl;
        private System.Windows.Forms.ComboBox _cbInputs;
        private System.Windows.Forms.ComboBox _cbOutputs;
        private System.Windows.Forms.Button _bAdd_HSensor;
        private System.Windows.Forms.Button _bAdd_WSensor;
        private System.Windows.Forms.Button _bAdd_HAct;
        private System.Windows.Forms.Button _bAdd_WAct;
        private System.Windows.Forms.TextBox _lCylName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _tbTipo_Cyl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label _lInput_H;
        private System.Windows.Forms.Label _lInput_W;
        private System.Windows.Forms.Label _lOutput_H;
        private System.Windows.Forms.Label _lOutput_W;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _tbTimeout;
    }
}

