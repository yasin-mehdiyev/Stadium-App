namespace _13_11_2018
{
    partial class AddStadium
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
            this.txtStdName = new System.Windows.Forms.TextBox();
            this.LblstdName = new System.Windows.Forms.Label();
            this.btnAddStadium = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtStdName
            // 
            this.txtStdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStdName.Location = new System.Drawing.Point(71, 100);
            this.txtStdName.Name = "txtStdName";
            this.txtStdName.Size = new System.Drawing.Size(264, 32);
            this.txtStdName.TabIndex = 9;
            // 
            // LblstdName
            // 
            this.LblstdName.AutoSize = true;
            this.LblstdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblstdName.Location = new System.Drawing.Point(66, 54);
            this.LblstdName.Name = "LblstdName";
            this.LblstdName.Size = new System.Drawing.Size(113, 25);
            this.LblstdName.TabIndex = 6;
            this.LblstdName.Text = "Stadion Adı";
            // 
            // btnAddStadium
            // 
            this.btnAddStadium.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStadium.Location = new System.Drawing.Point(71, 163);
            this.btnAddStadium.Name = "btnAddStadium";
            this.btnAddStadium.Size = new System.Drawing.Size(264, 51);
            this.btnAddStadium.TabIndex = 4;
            this.btnAddStadium.Text = "Əlavə et";
            this.btnAddStadium.UseVisualStyleBackColor = true;
            this.btnAddStadium.Click += new System.EventHandler(this.btnAddStadium_Click);
            // 
            // AddStadium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 281);
            this.Controls.Add(this.txtStdName);
            this.Controls.Add(this.LblstdName);
            this.Controls.Add(this.btnAddStadium);
            this.Name = "AddStadium";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddStadium";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStdName;
        private System.Windows.Forms.Label LblstdName;
        private System.Windows.Forms.Button btnAddStadium;
    }
}