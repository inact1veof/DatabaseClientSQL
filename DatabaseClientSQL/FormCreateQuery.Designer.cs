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
            this.buttonUsingConstr = new System.Windows.Forms.Button();
            this.buttonUsingSQL = new System.Windows.Forms.Button();
            this.textBoxForSQL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxQueryName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxTablesArr = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxAtrArr = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ButtonMakeQuery
            // 
            this.ButtonMakeQuery.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonMakeQuery.Location = new System.Drawing.Point(12, 312);
            this.ButtonMakeQuery.Name = "ButtonMakeQuery";
            this.ButtonMakeQuery.Size = new System.Drawing.Size(432, 34);
            this.ButtonMakeQuery.TabIndex = 0;
            this.ButtonMakeQuery.Text = "Создать";
            this.ButtonMakeQuery.UseVisualStyleBackColor = true;
            this.ButtonMakeQuery.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonUsingConstr
            // 
            this.buttonUsingConstr.Location = new System.Drawing.Point(12, 12);
            this.buttonUsingConstr.Name = "buttonUsingConstr";
            this.buttonUsingConstr.Size = new System.Drawing.Size(84, 23);
            this.buttonUsingConstr.TabIndex = 1;
            this.buttonUsingConstr.Text = "Конструктор";
            this.buttonUsingConstr.UseVisualStyleBackColor = true;
            this.buttonUsingConstr.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonUsingSQL
            // 
            this.buttonUsingSQL.Location = new System.Drawing.Point(103, 13);
            this.buttonUsingSQL.Name = "buttonUsingSQL";
            this.buttonUsingSQL.Size = new System.Drawing.Size(75, 23);
            this.buttonUsingSQL.TabIndex = 2;
            this.buttonUsingSQL.Text = "SQL";
            this.buttonUsingSQL.UseVisualStyleBackColor = true;
            this.buttonUsingSQL.Click += new System.EventHandler(this.buttonUsingSQL_Click);
            // 
            // textBoxForSQL
            // 
            this.textBoxForSQL.Location = new System.Drawing.Point(12, 68);
            this.textBoxForSQL.Multiline = true;
            this.textBoxForSQL.Name = "textBoxForSQL";
            this.textBoxForSQL.Size = new System.Drawing.Size(432, 238);
            this.textBoxForSQL.TabIndex = 3;
            this.textBoxForSQL.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите название запроса:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxQueryName
            // 
            this.textBoxQueryName.Location = new System.Drawing.Point(168, 42);
            this.textBoxQueryName.Name = "textBoxQueryName";
            this.textBoxQueryName.Size = new System.Drawing.Size(276, 20);
            this.textBoxQueryName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Выберите таблицу с данными:";
            // 
            // listBoxTablesArr
            // 
            this.listBoxTablesArr.FormattingEnabled = true;
            this.listBoxTablesArr.Location = new System.Drawing.Point(209, 82);
            this.listBoxTablesArr.Name = "listBoxTablesArr";
            this.listBoxTablesArr.Size = new System.Drawing.Size(188, 82);
            this.listBoxTablesArr.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Выберите атрибуты для вывода:";
            // 
            // listBoxAtrArr
            // 
            this.listBoxAtrArr.FormattingEnabled = true;
            this.listBoxAtrArr.Location = new System.Drawing.Point(220, 179);
            this.listBoxAtrArr.Name = "listBoxAtrArr";
            this.listBoxAtrArr.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxAtrArr.Size = new System.Drawing.Size(177, 95);
            this.listBoxAtrArr.TabIndex = 9;
            // 
            // FormCreateQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 360);
            this.Controls.Add(this.listBoxAtrArr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxTablesArr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxQueryName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxForSQL);
            this.Controls.Add(this.buttonUsingSQL);
            this.Controls.Add(this.buttonUsingConstr);
            this.Controls.Add(this.ButtonMakeQuery);
            this.Name = "FormCreateQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Создание нового запроса";
            this.Load += new System.EventHandler(this.FormCreateQuery_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonMakeQuery;
        private System.Windows.Forms.Button buttonUsingConstr;
        private System.Windows.Forms.Button buttonUsingSQL;
        private System.Windows.Forms.TextBox textBoxForSQL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxQueryName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxTablesArr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxAtrArr;
    }
}