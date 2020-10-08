namespace YilanOyunu
{
    partial class SkorlarForm
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
            this.lvwSkorlar = new MetroFramework.Controls.MetroListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvwSkorlar
            // 
            this.lvwSkorlar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4});
            this.lvwSkorlar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lvwSkorlar.FullRowSelect = true;
            this.lvwSkorlar.Location = new System.Drawing.Point(23, 83);
            this.lvwSkorlar.Name = "lvwSkorlar";
            this.lvwSkorlar.OwnerDraw = true;
            this.lvwSkorlar.Size = new System.Drawing.Size(635, 542);
            this.lvwSkorlar.TabIndex = 0;
            this.lvwSkorlar.UseCompatibleStateImageBehavior = false;
            this.lvwSkorlar.UseSelectable = true;
            this.lvwSkorlar.View = System.Windows.Forms.View.Details;
            this.lvwSkorlar.SelectedIndexChanged += new System.EventHandler(this.lvwSkorlar_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 1;
            this.columnHeader3.Text = "Skor";
            this.columnHeader3.Width = 166;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Oyuncu";
            this.columnHeader1.Width = 172;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Zaman";
            this.columnHeader4.Width = 181;
            // 
            // SkorlarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 669);
            this.Controls.Add(this.lvwSkorlar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.87F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "SkorlarForm";
            this.Text = "En Yüksek Skorlar";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroListView lvwSkorlar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}