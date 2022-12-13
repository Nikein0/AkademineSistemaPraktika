namespace AkademineSistemaPraktika
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
            this.textBoxStudID = new System.Windows.Forms.TextBox();
            this.Vesti_pazymi = new System.Windows.Forms.Button();
            this.textBoxStudPazimys = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxStudID
            // 
            this.textBoxStudID.Location = new System.Drawing.Point(200, 138);
            this.textBoxStudID.Name = "textBoxStudID";
            this.textBoxStudID.Size = new System.Drawing.Size(100, 20);
            this.textBoxStudID.TabIndex = 0;
            // 
            // Vesti_pazymi
            // 
            this.Vesti_pazymi.Location = new System.Drawing.Point(99, 136);
            this.Vesti_pazymi.Name = "Vesti_pazymi";
            this.Vesti_pazymi.Size = new System.Drawing.Size(75, 23);
            this.Vesti_pazymi.TabIndex = 1;
            this.Vesti_pazymi.Text = "Vesti pažymį";
            this.Vesti_pazymi.UseVisualStyleBackColor = true;
            this.Vesti_pazymi.Click += new System.EventHandler(this.Vesti_pazymi_Click);
            // 
            // textBoxStudPazimys
            // 
            this.textBoxStudPazimys.Location = new System.Drawing.Point(306, 138);
            this.textBoxStudPazimys.Name = "textBoxStudPazimys";
            this.textBoxStudPazimys.Size = new System.Drawing.Size(100, 20);
            this.textBoxStudPazimys.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Studento ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pažimys";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxStudPazimys);
            this.Controls.Add(this.Vesti_pazymi);
            this.Controls.Add(this.textBoxStudID);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStudID;
        private System.Windows.Forms.Button Vesti_pazymi;
        private System.Windows.Forms.TextBox textBoxStudPazimys;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}