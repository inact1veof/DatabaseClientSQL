namespace DatabaseClientSQL
{
    partial class MainFormShowQueries
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
            this.ButtonCreateQuery = new System.Windows.Forms.Button();
            this.ButtonDeleteQuery = new System.Windows.Forms.Button();
            this.ListQueries = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ButtonCreateQuery
            // 
            this.ButtonCreateQuery.Location = new System.Drawing.Point(12, 12);
            this.ButtonCreateQuery.Name = "ButtonCreateQuery";
            this.ButtonCreateQuery.Size = new System.Drawing.Size(166, 34);
            this.ButtonCreateQuery.TabIndex = 0;
            this.ButtonCreateQuery.Text = "Создать новый запрос";
            this.ButtonCreateQuery.UseVisualStyleBackColor = true;
            this.ButtonCreateQuery.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonDeleteQuery
            // 
            this.ButtonDeleteQuery.Location = new System.Drawing.Point(219, 12);
            this.ButtonDeleteQuery.Name = "ButtonDeleteQuery";
            this.ButtonDeleteQuery.Size = new System.Drawing.Size(167, 34);
            this.ButtonDeleteQuery.TabIndex = 1;
            this.ButtonDeleteQuery.Text = "Удалить запрос";
            this.ButtonDeleteQuery.UseVisualStyleBackColor = true;
            // 
            // ListQueries
            // 
            this.ListQueries.FormattingEnabled = true;
            this.ListQueries.Location = new System.Drawing.Point(12, 52);
            this.ListQueries.Name = "ListQueries";
            this.ListQueries.Size = new System.Drawing.Size(374, 277);
            this.ListQueries.TabIndex = 2;
            this.ListQueries.SelectedIndexChanged += new System.EventHandler(this.ListQueries_SelectedIndexChanged);
            // 
            // MainFormShowQueries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 341);
            this.Controls.Add(this.ListQueries);
            this.Controls.Add(this.ButtonDeleteQuery);
            this.Controls.Add(this.ButtonCreateQuery);
            this.Name = "MainFormShowQueries";
            this.Text = "Менеджер управления запросами";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonCreateQuery;
        private System.Windows.Forms.Button ButtonDeleteQuery;
        private System.Windows.Forms.ListBox ListQueries;
    }
}