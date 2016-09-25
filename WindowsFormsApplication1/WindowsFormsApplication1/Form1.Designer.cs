namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this._aboutBt = new System.Windows.Forms.Button();
            this._nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._helloBt = new System.Windows.Forms.Button();
            this._exitBt = new System.Windows.Forms.Button();
            this._msg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _aboutBt
            // 
            this._aboutBt.Location = new System.Drawing.Point(12, 270);
            this._aboutBt.Name = "_aboutBt";
            this._aboutBt.Size = new System.Drawing.Size(99, 25);
            this._aboutBt.TabIndex = 0;
            this._aboutBt.Text = "О Программе";
            this._aboutBt.UseVisualStyleBackColor = true;
            this._aboutBt.Click += new System.EventHandler(this._aboutBt_Click);
            // 
            // _nameBox
            // 
            this._nameBox.Location = new System.Drawing.Point(160, 108);
            this._nameBox.Name = "_nameBox";
            this._nameBox.Size = new System.Drawing.Size(100, 20);
            this._nameBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ваше имя:";
            // 
            // _helloBt
            // 
            this._helloBt.Location = new System.Drawing.Point(127, 147);
            this._helloBt.Name = "_helloBt";
            this._helloBt.Size = new System.Drawing.Size(108, 23);
            this._helloBt.TabIndex = 3;
            this._helloBt.Text = "Далее";
            this._helloBt.UseVisualStyleBackColor = true;
            this._helloBt.Click += new System.EventHandler(this._helloBt_Click);
            // 
            // _exitBt
            // 
            this._exitBt.Location = new System.Drawing.Point(214, 270);
            this._exitBt.Name = "_exitBt";
            this._exitBt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this._exitBt.Size = new System.Drawing.Size(128, 25);
            this._exitBt.TabIndex = 4;
            this._exitBt.Text = "Закрыть приложение";
            this._exitBt.UseVisualStyleBackColor = true;
            this._exitBt.Click += new System.EventHandler(this._exitBt_Click);
            // 
            // _msg
            // 
            this._msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._msg.ForeColor = System.Drawing.Color.White;
            this._msg.Location = new System.Drawing.Point(97, 73);
            this._msg.Name = "_msg";
            this._msg.Size = new System.Drawing.Size(163, 23);
            this._msg.TabIndex = 5;
            this._msg.Text = "label2";
            this._msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(354, 307);
            this.Controls.Add(this._msg);
            this.Controls.Add(this._exitBt);
            this.Controls.Add(this._helloBt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._nameBox);
            this.Controls.Add(this._aboutBt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Самое крутое приложение";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _aboutBt;
        private System.Windows.Forms.TextBox _nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _helloBt;
        private System.Windows.Forms.Button _exitBt;
        private System.Windows.Forms.Label _msg;
    }
}

