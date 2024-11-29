namespace Form_Login
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_passw = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_passw = new System.Windows.Forms.MaskedTextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(299, 50);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(43, 13);
            this.lbl_user.TabIndex = 0;
            this.lbl_user.Text = "Usuario";
            this.lbl_user.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_passw
            // 
            this.lbl_passw.AutoSize = true;
            this.lbl_passw.Location = new System.Drawing.Point(299, 90);
            this.lbl_passw.Name = "lbl_passw";
            this.lbl_passw.Size = new System.Drawing.Size(61, 13);
            this.lbl_passw.TabIndex = 1;
            this.lbl_passw.Text = "Contraseña";
            this.lbl_passw.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(302, 66);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(200, 20);
            this.txt_user.TabIndex = 2;
            this.txt_user.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_passw
            // 
            this.txt_passw.Location = new System.Drawing.Point(302, 106);
            this.txt_passw.Name = "txt_passw";
            this.txt_passw.Size = new System.Drawing.Size(200, 20);
            this.txt_passw.TabIndex = 3;
            this.txt_passw.UseSystemPasswordChar = true;
            this.txt_passw.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txt_passw_MaskInputRejected);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(302, 216);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 4;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(427, 216);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 5;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(345, 180);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(106, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Mostrar / Ocultar";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(302, 147);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Value = new System.DateTime(1984, 8, 27, 0, 0, 0, 0);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txt_passw);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.lbl_passw);
            this.Controls.Add(this.lbl_user);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_passw;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.MaskedTextBox txt_passw;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

