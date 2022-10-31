namespace WindowsApp
{
    partial class FrmPrac3
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
            this.btnCrearObj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearObj
            // 
            this.btnCrearObj.Location = new System.Drawing.Point(114, 70);
            this.btnCrearObj.Name = "btnCrearObj";
            this.btnCrearObj.Size = new System.Drawing.Size(75, 23);
            this.btnCrearObj.TabIndex = 0;
            this.btnCrearObj.Text = "Crear Objeto";
            this.btnCrearObj.UseVisualStyleBackColor = true;
            this.btnCrearObj.Click += new System.EventHandler(this.btnCrearObj_Click);
            // 
            // FrmPrac3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 174);
            this.Controls.Add(this.btnCrearObj);
            this.Name = "FrmPrac3";
            this.Text = "FrmPrac3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearObj;
    }
}