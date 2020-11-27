
namespace inventory
{
    partial class DeletePrompt
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
            this.pPromptBody = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPromptYes = new System.Windows.Forms.Button();
            this.btnPromptNo = new System.Windows.Forms.Button();
            this.pPromptBody.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pPromptBody
            // 
            this.pPromptBody.Controls.Add(this.btnPromptNo);
            this.pPromptBody.Controls.Add(this.btnPromptYes);
            this.pPromptBody.Controls.Add(this.label2);
            this.pPromptBody.Controls.Add(this.label1);
            this.pPromptBody.Controls.Add(this.pictureBox1);
            this.pPromptBody.Controls.Add(this.panel1);
            this.pPromptBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPromptBody.Location = new System.Drawing.Point(0, 0);
            this.pPromptBody.Name = "pPromptBody";
            this.pPromptBody.Size = new System.Drawing.Size(436, 205);
            this.pPromptBody.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblConfirm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 39);
            this.panel1.TabIndex = 0;
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirm.ForeColor = System.Drawing.Color.White;
            this.lblConfirm.Location = new System.Drawing.Point(14, 9);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(70, 19);
            this.lblConfirm.TabIndex = 1;
            this.lblConfirm.Text = "Confirm";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(397, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::inventory.Properties.Resources.icons8_general_warning_sign_96;
            this.pictureBox1.Location = new System.Drawing.Point(18, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Are you sure you want to delete this file?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "You can\'t undo this action.";
            // 
            // btnPromptYes
            // 
            this.btnPromptYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.btnPromptYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromptYes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromptYes.ForeColor = System.Drawing.Color.White;
            this.btnPromptYes.Location = new System.Drawing.Point(286, 153);
            this.btnPromptYes.Name = "btnPromptYes";
            this.btnPromptYes.Size = new System.Drawing.Size(127, 40);
            this.btnPromptYes.TabIndex = 4;
            this.btnPromptYes.Text = "YES";
            this.btnPromptYes.UseVisualStyleBackColor = false;
            this.btnPromptYes.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPromptNo
            // 
            this.btnPromptNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromptNo.Location = new System.Drawing.Point(197, 153);
            this.btnPromptNo.Name = "btnPromptNo";
            this.btnPromptNo.Size = new System.Drawing.Size(83, 40);
            this.btnPromptNo.TabIndex = 4;
            this.btnPromptNo.Text = "NO";
            this.btnPromptNo.UseVisualStyleBackColor = true;
            this.btnPromptNo.Click += new System.EventHandler(this.btnPromptNo_Click);
            // 
            // DeletePrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 205);
            this.Controls.Add(this.pPromptBody);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "DeletePrompt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeletePrompt";
            this.pPromptBody.ResumeLayout(false);
            this.pPromptBody.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pPromptBody;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.Button btnPromptYes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPromptNo;
    }
}