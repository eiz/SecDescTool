namespace SecDescTool
{
    partial class SecurityDescriptorGenerator
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
            this._sdBinary = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._sddlText = new System.Windows.Forms.TextBox();
            this._copy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Binary:";
            // 
            // _sdBinary
            // 
            this._sdBinary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._sdBinary.BackColor = System.Drawing.SystemColors.Window;
            this._sdBinary.Location = new System.Drawing.Point(16, 57);
            this._sdBinary.Multiline = true;
            this._sdBinary.Name = "_sdBinary";
            this._sdBinary.ReadOnly = true;
            this._sdBinary.Size = new System.Drawing.Size(511, 106);
            this._sdBinary.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Text:";
            // 
            // _sddlText
            // 
            this._sddlText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._sddlText.Location = new System.Drawing.Point(50, 10);
            this._sddlText.Name = "_sddlText";
            this._sddlText.Size = new System.Drawing.Size(477, 20);
            this._sddlText.TabIndex = 0;
            this._sddlText.TextChanged += new System.EventHandler(this._sddlText_TextChanged);
            // 
            // _copy
            // 
            this._copy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._copy.Enabled = false;
            this._copy.Location = new System.Drawing.Point(452, 169);
            this._copy.Name = "_copy";
            this._copy.Size = new System.Drawing.Size(75, 23);
            this._copy.TabIndex = 3;
            this._copy.Text = "&Copy Binary";
            this._copy.UseVisualStyleBackColor = true;
            this._copy.Click += new System.EventHandler(this._copy_Click);
            // 
            // SecurityDescriptorGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 204);
            this.Controls.Add(this._copy);
            this.Controls.Add(this._sddlText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._sdBinary);
            this.Controls.Add(this.label1);
            this.Name = "SecurityDescriptorGenerator";
            this.Text = "SDDL to Binary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _sdBinary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _sddlText;
        private System.Windows.Forms.Button _copy;
    }
}

