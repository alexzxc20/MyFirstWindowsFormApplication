namespace WindowsFormsApplication1
{
    partial class _helloForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_helloForm));
            this._hLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _hLabel
            // 
            this._hLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._hLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this._hLabel.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._hLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this._hLabel.Location = new System.Drawing.Point(12, 9);
            this._hLabel.Name = "_hLabel";
            this._hLabel.Size = new System.Drawing.Size(322, 182);
            this._hLabel.TabIndex = 0;
            this._hLabel.Text = "label1";
            this._hLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._hLabel.Click += new System.EventHandler(this._hLabel_Click);
            // 
            // _helloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 200);
            this.Controls.Add(this._hLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "_helloForm";
            this.Text = "Окно приветствия";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label _hLabel;
    }
}