namespace PJesus_Task.WF
{
    partial class frmTask1
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
            this.btnCarregarAwait = new System.Windows.Forms.Button();
            this.btnCarregarTask = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnCancelarTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCarregarAwait
            // 
            this.btnCarregarAwait.Location = new System.Drawing.Point(12, 12);
            this.btnCarregarAwait.Name = "btnCarregarAwait";
            this.btnCarregarAwait.Size = new System.Drawing.Size(371, 28);
            this.btnCarregarAwait.TabIndex = 0;
            this.btnCarregarAwait.Text = "Carregar (Await)";
            this.btnCarregarAwait.UseVisualStyleBackColor = true;
            this.btnCarregarAwait.Click += new System.EventHandler(this.btnCarregarAwait_Click);
            // 
            // btnCarregarTask
            // 
            this.btnCarregarTask.Location = new System.Drawing.Point(12, 49);
            this.btnCarregarTask.Name = "btnCarregarTask";
            this.btnCarregarTask.Size = new System.Drawing.Size(371, 28);
            this.btnCarregarTask.TabIndex = 1;
            this.btnCarregarTask.Text = "Carregar (Task)";
            this.btnCarregarTask.UseVisualStyleBackColor = true;
            this.btnCarregarTask.Click += new System.EventHandler(this.btnCarregarTask_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResultado.Location = new System.Drawing.Point(12, 117);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(371, 159);
            this.txtResultado.TabIndex = 2;
            // 
            // btnCancelarTask
            // 
            this.btnCancelarTask.Enabled = false;
            this.btnCancelarTask.Location = new System.Drawing.Point(12, 83);
            this.btnCancelarTask.Name = "btnCancelarTask";
            this.btnCancelarTask.Size = new System.Drawing.Size(371, 28);
            this.btnCancelarTask.TabIndex = 3;
            this.btnCancelarTask.Text = "Cancelar Task";
            this.btnCancelarTask.UseVisualStyleBackColor = true;
            this.btnCancelarTask.Click += new System.EventHandler(this.btnCancelarTask_Click);
            // 
            // frmTask1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 288);
            this.Controls.Add(this.btnCancelarTask);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnCarregarTask);
            this.Controls.Add(this.btnCarregarAwait);
            this.Name = "frmTask1";
            this.Text = "Paulo Jesus - Task 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCarregarAwait;
        private System.Windows.Forms.Button btnCarregarTask;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnCancelarTask;
    }
}

