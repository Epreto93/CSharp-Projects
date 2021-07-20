
namespace WindowsFormsMiniProj
{
    partial class PersonForm
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
            this.Adresses = new System.Windows.Forms.ListBox();
            this.personName = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.surnameText = new System.Windows.Forms.TextBox();
            this.personSurname = new System.Windows.Forms.Label();
            this.addAddress = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Adresses
            // 
            this.Adresses.FormattingEnabled = true;
            this.Adresses.ItemHeight = 20;
            this.Adresses.Location = new System.Drawing.Point(90, 236);
            this.Adresses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Adresses.Name = "Adresses";
            this.Adresses.Size = new System.Drawing.Size(334, 184);
            this.Adresses.TabIndex = 0;
            // 
            // personName
            // 
            this.personName.AutoSize = true;
            this.personName.Location = new System.Drawing.Point(75, 69);
            this.personName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.personName.Name = "personName";
            this.personName.Size = new System.Drawing.Size(51, 20);
            this.personName.TabIndex = 1;
            this.personName.Text = "Name";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(133, 69);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(291, 26);
            this.nameText.TabIndex = 2;
            // 
            // surnameText
            // 
            this.surnameText.Location = new System.Drawing.Point(133, 113);
            this.surnameText.Name = "surnameText";
            this.surnameText.Size = new System.Drawing.Size(291, 26);
            this.surnameText.TabIndex = 3;
            // 
            // personSurname
            // 
            this.personSurname.AutoSize = true;
            this.personSurname.Location = new System.Drawing.Point(52, 119);
            this.personSurname.Name = "personSurname";
            this.personSurname.Size = new System.Drawing.Size(74, 20);
            this.personSurname.TabIndex = 4;
            this.personSurname.Text = "Surname";
            // 
            // addAddress
            // 
            this.addAddress.Location = new System.Drawing.Point(287, 189);
            this.addAddress.Name = "addAddress";
            this.addAddress.Size = new System.Drawing.Size(137, 39);
            this.addAddress.TabIndex = 5;
            this.addAddress.Text = "Add Address";
            this.addAddress.UseVisualStyleBackColor = true;
            this.addAddress.Click += new System.EventHandler(this.addAddress_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(287, 449);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(137, 40);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 501);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addAddress);
            this.Controls.Add(this.personSurname);
            this.Controls.Add(this.surnameText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.personName);
            this.Controls.Add(this.Adresses);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PersonForm";
            this.Text = "Person Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Adresses;
        private System.Windows.Forms.Label personName;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox surnameText;
        private System.Windows.Forms.Label personSurname;
        private System.Windows.Forms.Button addAddress;
        private System.Windows.Forms.Button saveButton;
    }
}

