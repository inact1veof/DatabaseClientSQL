namespace DatabaseClientSQL
{
    partial class FormToConnect
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
            this.buttonStartConnect = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.textBoxDatabase = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxUserPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStartConnect
            // 
            this.buttonStartConnect.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonStartConnect.Location = new System.Drawing.Point(79, 194);
            this.buttonStartConnect.Name = "buttonStartConnect";
            this.buttonStartConnect.Size = new System.Drawing.Size(101, 30);
            this.buttonStartConnect.TabIndex = 0;
            this.buttonStartConnect.Text = "Подключиться";
            this.buttonStartConnect.UseVisualStyleBackColor = true;
            this.buttonStartConnect.Click += new System.EventHandler(this.buttonStartConnect_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(230, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(171, 25);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(171, 20);
            this.textBoxAdress.TabIndex = 2;
            // 
            // textBoxDatabase
            // 
            this.textBoxDatabase.Location = new System.Drawing.Point(171, 65);
            this.textBoxDatabase.Name = "textBoxDatabase";
            this.textBoxDatabase.Size = new System.Drawing.Size(171, 20);
            this.textBoxDatabase.TabIndex = 3;
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(171, 101);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(171, 20);
            this.textBoxUser.TabIndex = 4;
            // 
            // textBoxUserPassword
            // 
            this.textBoxUserPassword.Location = new System.Drawing.Point(171, 142);
            this.textBoxUserPassword.Name = "textBoxUserPassword";
            this.textBoxUserPassword.Size = new System.Drawing.Size(171, 20);
            this.textBoxUserPassword.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(51, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 137);
            this.label1.TabIndex = 6;
            this.label1.Text = "Адрес подключения:\r\n\r\n\r\nИмя базы данных:\r\n\r\n\r\nПользователь:\r\n\r\n\r\nПароль:";
            // 
            // FormToConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 246);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUserPassword);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.textBoxDatabase);
            this.Controls.Add(this.textBoxAdress);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonStartConnect);
            this.Name = "FormToConnect";
            this.Text = "Подключение";
            this.Load += new System.EventHandler(this.FormToConnect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStartConnect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.TextBox textBoxDatabase;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxUserPassword;
        private System.Windows.Forms.Label label1;
    }
}