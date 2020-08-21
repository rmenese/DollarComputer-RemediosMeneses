namespace DollarComputer_RemediosMeneses
{
    partial class StartForm
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
            this.OrderLabel = new System.Windows.Forms.Label();
            this.StartOrderButton = new System.Windows.Forms.Button();
            this.OpenOrderButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.StartPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.StartPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderLabel
            // 
            this.OrderLabel.AutoSize = true;
            this.OrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderLabel.Location = new System.Drawing.Point(175, 9);
            this.OrderLabel.Name = "OrderLabel";
            this.OrderLabel.Size = new System.Drawing.Size(292, 25);
            this.OrderLabel.TabIndex = 0;
            this.OrderLabel.Text = "Order Your Computer Today!";
            // 
            // StartOrderButton
            // 
            this.StartOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartOrderButton.Location = new System.Drawing.Point(199, 264);
            this.StartOrderButton.Name = "StartOrderButton";
            this.StartOrderButton.Size = new System.Drawing.Size(240, 45);
            this.StartOrderButton.TabIndex = 2;
            this.StartOrderButton.Text = "Start a New Order";
            this.StartOrderButton.UseVisualStyleBackColor = true;
            this.StartOrderButton.Click += new System.EventHandler(this.StartANewOrder_Click);
            // 
            // OpenOrderButton
            // 
            this.OpenOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenOrderButton.Location = new System.Drawing.Point(199, 324);
            this.OpenOrderButton.Name = "OpenOrderButton";
            this.OpenOrderButton.Size = new System.Drawing.Size(240, 44);
            this.OpenOrderButton.TabIndex = 3;
            this.OpenOrderButton.Text = "Open a Saved Order";
            this.OpenOrderButton.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(199, 385);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(240, 44);
            this.button3.TabIndex = 4;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // StartPictureBox
            // 
            this.StartPictureBox.Image = global::DollarComputer_RemediosMeneses.Properties.Resources.dollars_comp;
            this.StartPictureBox.Location = new System.Drawing.Point(199, 49);
            this.StartPictureBox.Name = "StartPictureBox";
            this.StartPictureBox.Size = new System.Drawing.Size(240, 193);
            this.StartPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StartPictureBox.TabIndex = 1;
            this.StartPictureBox.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.OpenOrderButton);
            this.Controls.Add(this.StartOrderButton);
            this.Controls.Add(this.StartPictureBox);
            this.Controls.Add(this.OrderLabel);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Dollar Computers!";
            ((System.ComponentModel.ISupportInitialize)(this.StartPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OrderLabel;
        private System.Windows.Forms.PictureBox StartPictureBox;
        private System.Windows.Forms.Button StartOrderButton;
        private System.Windows.Forms.Button OpenOrderButton;
        private System.Windows.Forms.Button button3;
    }
}