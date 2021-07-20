
namespace WindowsFormsMiniProj
{
    partial class AddressForm
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.streetName = new System.Windows.Forms.Label();
            this.streetNameText = new System.Windows.Forms.TextBox();
            this.townNameText = new System.Windows.Forms.TextBox();
            this.townName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(180, 149);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(191, 35);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // streetName
            // 
            this.streetName.AutoSize = true;
            this.streetName.Location = new System.Drawing.Point(27, 52);
            this.streetName.Name = "streetName";
            this.streetName.Size = new System.Drawing.Size(99, 20);
            this.streetName.TabIndex = 1;
            this.streetName.Text = "Street Name";
            // 
            // streetNameText
            // 
            this.streetNameText.Location = new System.Drawing.Point(165, 51);
            this.streetNameText.Name = "streetNameText";
            this.streetNameText.Size = new System.Drawing.Size(206, 26);
            this.streetNameText.TabIndex = 2;
            // 
            // townNameText
            // 
            this.townNameText.Location = new System.Drawing.Point(165, 99);
            this.townNameText.Name = "townNameText";
            this.townNameText.Size = new System.Drawing.Size(206, 26);
            this.townNameText.TabIndex = 3;
            // 
            // townName
            // 
            this.townName.AutoSize = true;
            this.townName.Location = new System.Drawing.Point(36, 105);
            this.townName.Name = "townName";
            this.townName.Size = new System.Drawing.Size(93, 20);
            this.townName.TabIndex = 4;
            this.townName.Text = "Town Name";
            // 
            // AddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 223);
            this.Controls.Add(this.townName);
            this.Controls.Add(this.townNameText);
            this.Controls.Add(this.streetNameText);
            this.Controls.Add(this.streetName);
            this.Controls.Add(this.SaveButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddressForm";
            this.Text = "Address Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label streetName;
        private System.Windows.Forms.TextBox streetNameText;
        private System.Windows.Forms.TextBox townNameText;
        private System.Windows.Forms.Label townName;
    }
}