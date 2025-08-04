namespace Cafe_PoS
{
    partial class Stock
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
            this.rjButton2 = new Cafe_PoS.Resources.RJButton();
            this.rjButton1 = new Cafe_PoS.Resources.RJButton();
            this.Coffee = new Cafe_PoS.Resources.RJButton();
            this.SuspendLayout();
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Noto Sans SC", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Image = global::Cafe_PoS.Properties.Resources.tea_cup;
            this.rjButton2.Location = new System.Drawing.Point(555, 62);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(240, 150);
            this.rjButton2.TabIndex = 0;
            this.rjButton2.Text = "Tea";
            this.rjButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rjButton2.UseVisualStyleBackColor = false;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Noto Sans SC", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Image = global::Cafe_PoS.Properties.Resources.snack;
            this.rjButton1.Location = new System.Drawing.Point(280, 62);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(240, 150);
            this.rjButton1.TabIndex = 0;
            this.rjButton1.Text = "Snack";
            this.rjButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // Coffee
            // 
            this.Coffee.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Coffee.FlatAppearance.BorderSize = 0;
            this.Coffee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Coffee.Font = new System.Drawing.Font("Noto Sans SC", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coffee.ForeColor = System.Drawing.Color.White;
            this.Coffee.Image = global::Cafe_PoS.Properties.Resources.coffee_cup;
            this.Coffee.Location = new System.Drawing.Point(12, 62);
            this.Coffee.Name = "Coffee";
            this.Coffee.Size = new System.Drawing.Size(240, 150);
            this.Coffee.TabIndex = 0;
            this.Coffee.Text = "Coffee";
            this.Coffee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Coffee.UseVisualStyleBackColor = false;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.Coffee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.ResumeLayout(false);

        }

        #endregion

        private Resources.RJButton Coffee;
        private Resources.RJButton rjButton1;
        private Resources.RJButton rjButton2;
    }
}