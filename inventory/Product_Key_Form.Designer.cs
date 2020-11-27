namespace inventory
{
    partial class Product_Key_Form
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
            this.lblTitleLabel = new System.Windows.Forms.Label();
            this.lblSystemName = new System.Windows.Forms.Label();
            this.lblProductKey = new System.Windows.Forms.Label();
            this.lblActivationKey = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.pnlBodyProductKeyForm = new System.Windows.Forms.Panel();
            this.txtActivationKey = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtProductKey = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtSystemName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.pnlBodyProductKeyForm.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitleLabel
            // 
            this.lblTitleLabel.AutoSize = true;
            this.lblTitleLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleLabel.ForeColor = System.Drawing.Color.White;
            this.lblTitleLabel.Location = new System.Drawing.Point(147, 81);
            this.lblTitleLabel.Name = "lblTitleLabel";
            this.lblTitleLabel.Size = new System.Drawing.Size(464, 21);
            this.lblTitleLabel.TabIndex = 0;
            this.lblTitleLabel.Text = "Please input inventory system information and product key";
            // 
            // lblSystemName
            // 
            this.lblSystemName.AutoSize = true;
            this.lblSystemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemName.Location = new System.Drawing.Point(49, 31);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(106, 20);
            this.lblSystemName.TabIndex = 10;
            this.lblSystemName.Text = "System name";
            // 
            // lblProductKey
            // 
            this.lblProductKey.AutoSize = true;
            this.lblProductKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductKey.Location = new System.Drawing.Point(50, 97);
            this.lblProductKey.Name = "lblProductKey";
            this.lblProductKey.Size = new System.Drawing.Size(92, 20);
            this.lblProductKey.TabIndex = 4;
            this.lblProductKey.Text = "Product key";
            // 
            // lblActivationKey
            // 
            this.lblActivationKey.AutoSize = true;
            this.lblActivationKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivationKey.Location = new System.Drawing.Point(50, 159);
            this.lblActivationKey.Name = "lblActivationKey";
            this.lblActivationKey.Size = new System.Drawing.Size(106, 20);
            this.lblActivationKey.TabIndex = 6;
            this.lblActivationKey.Text = "Activation key";
            // 
            // btnContinue
            // 
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.Location = new System.Drawing.Point(53, 236);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(414, 38);
            this.btnContinue.TabIndex = 4;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // pnlBodyProductKeyForm
            // 
            this.pnlBodyProductKeyForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pnlBodyProductKeyForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlBodyProductKeyForm.Controls.Add(this.txtActivationKey);
            this.pnlBodyProductKeyForm.Controls.Add(this.txtProductKey);
            this.pnlBodyProductKeyForm.Controls.Add(this.txtSystemName);
            this.pnlBodyProductKeyForm.Controls.Add(this.btnContinue);
            this.pnlBodyProductKeyForm.Controls.Add(this.lblActivationKey);
            this.pnlBodyProductKeyForm.Controls.Add(this.lblSystemName);
            this.pnlBodyProductKeyForm.Controls.Add(this.lblProductKey);
            this.pnlBodyProductKeyForm.Location = new System.Drawing.Point(114, 108);
            this.pnlBodyProductKeyForm.Name = "pnlBodyProductKeyForm";
            this.pnlBodyProductKeyForm.Size = new System.Drawing.Size(530, 318);
            this.pnlBodyProductKeyForm.TabIndex = 8;
            // 
            // txtActivationKey
            // 
            this.txtActivationKey.Depth = 0;
            this.txtActivationKey.Hint = "";
            this.txtActivationKey.Location = new System.Drawing.Point(53, 183);
            this.txtActivationKey.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtActivationKey.Name = "txtActivationKey";
            this.txtActivationKey.PasswordChar = 'X';
            this.txtActivationKey.SelectedText = "";
            this.txtActivationKey.SelectionLength = 0;
            this.txtActivationKey.SelectionStart = 0;
            this.txtActivationKey.Size = new System.Drawing.Size(414, 23);
            this.txtActivationKey.TabIndex = 3;
            this.txtActivationKey.UseSystemPasswordChar = false;
            // 
            // txtProductKey
            // 
            this.txtProductKey.Depth = 0;
            this.txtProductKey.Hint = "";
            this.txtProductKey.Location = new System.Drawing.Point(53, 122);
            this.txtProductKey.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtProductKey.Name = "txtProductKey";
            this.txtProductKey.PasswordChar = '\0';
            this.txtProductKey.SelectedText = "";
            this.txtProductKey.SelectionLength = 0;
            this.txtProductKey.SelectionStart = 0;
            this.txtProductKey.Size = new System.Drawing.Size(414, 23);
            this.txtProductKey.TabIndex = 2;
            this.txtProductKey.UseSystemPasswordChar = false;
            // 
            // txtSystemName
            // 
            this.txtSystemName.Depth = 0;
            this.txtSystemName.Hint = "";
            this.txtSystemName.Location = new System.Drawing.Point(53, 56);
            this.txtSystemName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSystemName.Name = "txtSystemName";
            this.txtSystemName.PasswordChar = '\0';
            this.txtSystemName.SelectedText = "";
            this.txtSystemName.SelectionLength = 0;
            this.txtSystemName.SelectionStart = 0;
            this.txtSystemName.Size = new System.Drawing.Size(197, 23);
            this.txtSystemName.TabIndex = 1;
            this.txtSystemName.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 28);
            this.panel1.TabIndex = 8;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(736, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.lblTitleLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(769, 170);
            this.panel2.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::inventory.Properties.Resources.icons8_key_30;
            this.pictureBox1.Location = new System.Drawing.Point(349, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(640, 111);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(10, 327);
            this.materialDivider1.TabIndex = 11;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(117, 420);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(524, 18);
            this.materialDivider2.TabIndex = 12;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // Product_Key_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 475);
            this.Controls.Add(this.pnlBodyProductKeyForm);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Product_Key_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Product_Key_Form";
            this.pnlBodyProductKeyForm.ResumeLayout(false);
            this.pnlBodyProductKeyForm.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitleLabel;
        private System.Windows.Forms.Label lblSystemName;
        private System.Windows.Forms.Label lblProductKey;
        private System.Windows.Forms.Label lblActivationKey;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Panel pnlBodyProductKeyForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtActivationKey;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtProductKey;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSystemName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
    }
}