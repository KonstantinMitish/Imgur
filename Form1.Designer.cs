namespace Imgur
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
      this.components = new System.ComponentModel.Container();
      this.button = new System.Windows.Forms.Button();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.SuspendLayout();
      // 
      // button
      // 
      this.button.Dock = System.Windows.Forms.DockStyle.Top;
      this.button.Location = new System.Drawing.Point(0, 0);
      this.button.Name = "button";
      this.button.Size = new System.Drawing.Size(284, 48);
      this.button.TabIndex = 1;
      this.button.Text = "START";
      this.button.UseVisualStyleBackColor = true;
      this.button.Click += new System.EventHandler(this.button2_Click);
      // 
      // timer1
      // 
      this.timer1.Interval = 1;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.ClientSize = new System.Drawing.Size(284, 261);
      this.Controls.Add(this.button);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.Click += new System.EventHandler(this.Form1_Click);
      this.ResumeLayout(false);

        }

    #endregion

    private System.Windows.Forms.Button button;
    private System.Windows.Forms.Timer timer1;
  }
}

