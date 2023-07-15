namespace NotePad
{
    partial class frmAbout
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
            ProductName = new Label();
            btnOK = new Button();
            ProductVersion = new Label();
            Copyright = new Label();
            SuspendLayout();
            // 
            // ProductName
            // 
            ProductName.AutoSize = true;
            ProductName.Location = new Point(38, 26);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(50, 20);
            ProductName.TabIndex = 0;
            ProductName.Text = "label1";
            // 
            // btnOK
            // 
            btnOK.Location = new Point(190, 249);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 27);
            btnOK.TabIndex = 1;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // ProductVersion
            // 
            ProductVersion.AutoSize = true;
            ProductVersion.Location = new Point(38, 101);
            ProductVersion.Name = "ProductVersion";
            ProductVersion.Size = new Size(50, 20);
            ProductVersion.TabIndex = 2;
            ProductVersion.Text = "label2";
            // 
            // Copyright
            // 
            Copyright.AutoSize = true;
            Copyright.Location = new Point(38, 181);
            Copyright.Name = "Copyright";
            Copyright.Size = new Size(50, 20);
            Copyright.TabIndex = 3;
            Copyright.Text = "label3";
            // 
            // frmAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 290);
            Controls.Add(Copyright);
            Controls.Add(ProductVersion);
            Controls.Add(btnOK);
            Controls.Add(ProductName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAbout";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "About";
            Load += frmAbout__Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ProductName;
        private Button btnOK;
        private Label ProductVersion;
        private Label Copyright;
    }
}