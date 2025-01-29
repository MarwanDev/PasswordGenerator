namespace PasswordGenerator
{
    partial class MultiplePasswordsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.nudNumberOfPasswords = new System.Windows.Forms.NumericUpDown();
            this.btnGenerateMultiplePasswords = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.rtbMultiplePasswords = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfPasswords)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "How many:";
            // 
            // nudNumberOfPasswords
            // 
            this.nudNumberOfPasswords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumberOfPasswords.Location = new System.Drawing.Point(127, 14);
            this.nudNumberOfPasswords.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfPasswords.Name = "nudNumberOfPasswords";
            this.nudNumberOfPasswords.Size = new System.Drawing.Size(120, 26);
            this.nudNumberOfPasswords.TabIndex = 1;
            this.nudNumberOfPasswords.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNumberOfPasswords.ValueChanged += new System.EventHandler(this.NudNumberOfPasswords_ValueChanged);
            // 
            // btnGenerateMultiplePasswords
            // 
            this.btnGenerateMultiplePasswords.Location = new System.Drawing.Point(285, 13);
            this.btnGenerateMultiplePasswords.Name = "btnGenerateMultiplePasswords";
            this.btnGenerateMultiplePasswords.Size = new System.Drawing.Size(95, 29);
            this.btnGenerateMultiplePasswords.TabIndex = 2;
            this.btnGenerateMultiplePasswords.Text = "Generate";
            this.btnGenerateMultiplePasswords.UseVisualStyleBackColor = true;
            this.btnGenerateMultiplePasswords.Click += new System.EventHandler(this.BtnGenerateMultiplePasswords_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSave.Location = new System.Drawing.Point(386, 14);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 28);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // rtbMultiplePasswords
            // 
            this.rtbMultiplePasswords.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rtbMultiplePasswords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbMultiplePasswords.Location = new System.Drawing.Point(3, 49);
            this.rtbMultiplePasswords.Name = "rtbMultiplePasswords";
            this.rtbMultiplePasswords.ReadOnly = true;
            this.rtbMultiplePasswords.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtbMultiplePasswords.Size = new System.Drawing.Size(497, 389);
            this.rtbMultiplePasswords.TabIndex = 4;
            this.rtbMultiplePasswords.Text = "";
            this.rtbMultiplePasswords.TextChanged += new System.EventHandler(this.RtbMultiplePasswords_TextChanged);
            // 
            // MultiplePasswordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 450);
            this.Controls.Add(this.rtbMultiplePasswords);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnGenerateMultiplePasswords);
            this.Controls.Add(this.nudNumberOfPasswords);
            this.Controls.Add(this.label1);
            this.Name = "MultiplePasswordsForm";
            this.Text = "Generate Multiple Passwords";
            this.Load += new System.EventHandler(this.MultiplePasswordsForm_Load);
            this.Resize += new System.EventHandler(this.MultiplePasswords_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfPasswords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudNumberOfPasswords;
        private System.Windows.Forms.Button btnGenerateMultiplePasswords;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RichTextBox rtbMultiplePasswords;
    }
}