namespace DatabaseClientSQL
{
    partial class FormCreateQuery
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
            this.ButtonMakeQuery = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonMakeQuery
            // 
            this.ButtonMakeQuery.Location = new System.Drawing.Point(48, 302);
            this.ButtonMakeQuery.Name = "ButtonMakeQuery";
            this.ButtonMakeQuery.Size = new System.Drawing.Size(163, 34);
            this.ButtonMakeQuery.TabIndex = 0;
            this.ButtonMakeQuery.Text = "Создать";
            this.ButtonMakeQuery.UseVisualStyleBackColor = true;
            this.ButtonMakeQuery.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormCreateQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 348);
            this.Controls.Add(this.ButtonMakeQuery);
            this.Name = "FormCreateQuery";
            this.Text = "Создание нового запроса";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonMakeQuery;
    }
}