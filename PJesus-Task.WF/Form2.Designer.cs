namespace PJesus_Task.WF
{
    partial class frmTask2
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
            this.btnCarregar = new System.Windows.Forms.Button();
            this.txtPalestras = new System.Windows.Forms.TextBox();
            this.txtPalestrantes = new System.Windows.Forms.TextBox();
            this.lblPalestras = new System.Windows.Forms.Label();
            this.lblPalestrantes = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.txtTimer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(12, 12);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(435, 28);
            this.btnCarregar.TabIndex = 1;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // txtPalestras
            // 
            this.txtPalestras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPalestras.Location = new System.Drawing.Point(12, 66);
            this.txtPalestras.Multiline = true;
            this.txtPalestras.Name = "txtPalestras";
            this.txtPalestras.ReadOnly = true;
            this.txtPalestras.Size = new System.Drawing.Size(210, 159);
            this.txtPalestras.TabIndex = 3;
            // 
            // txtPalestrantes
            // 
            this.txtPalestrantes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPalestrantes.Location = new System.Drawing.Point(237, 66);
            this.txtPalestrantes.Multiline = true;
            this.txtPalestrantes.Name = "txtPalestrantes";
            this.txtPalestrantes.ReadOnly = true;
            this.txtPalestrantes.Size = new System.Drawing.Size(210, 159);
            this.txtPalestrantes.TabIndex = 4;
            // 
            // lblPalestras
            // 
            this.lblPalestras.AutoSize = true;
            this.lblPalestras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalestras.Location = new System.Drawing.Point(12, 50);
            this.lblPalestras.Name = "lblPalestras";
            this.lblPalestras.Size = new System.Drawing.Size(63, 13);
            this.lblPalestras.TabIndex = 5;
            this.lblPalestras.Text = "Palestras:";
            // 
            // lblPalestrantes
            // 
            this.lblPalestrantes.AutoSize = true;
            this.lblPalestrantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalestrantes.Location = new System.Drawing.Point(234, 50);
            this.lblPalestrantes.Name = "lblPalestrantes";
            this.lblPalestrantes.Size = new System.Drawing.Size(81, 13);
            this.lblPalestrantes.TabIndex = 6;
            this.lblPalestrantes.Text = "Palestrantes:";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(12, 238);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(42, 13);
            this.lblTimer.TabIndex = 7;
            this.lblTimer.Text = "Timer:";
            // 
            // txtTimer
            // 
            this.txtTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimer.Location = new System.Drawing.Point(60, 235);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.ReadOnly = true;
            this.txtTimer.Size = new System.Drawing.Size(162, 20);
            this.txtTimer.TabIndex = 8;
            // 
            // frmTask2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 267);
            this.Controls.Add(this.txtTimer);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblPalestrantes);
            this.Controls.Add(this.lblPalestras);
            this.Controls.Add(this.txtPalestrantes);
            this.Controls.Add(this.txtPalestras);
            this.Controls.Add(this.btnCarregar);
            this.Name = "frmTask2";
            this.Text = "Paulo Jesus - Task 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.TextBox txtPalestras;
        private System.Windows.Forms.TextBox txtPalestrantes;
        private System.Windows.Forms.Label lblPalestras;
        private System.Windows.Forms.Label lblPalestrantes;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.TextBox txtTimer;
    }
}