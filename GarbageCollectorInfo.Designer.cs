namespace GarbageCollectorInfo
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox infoTextBox;
        private Button collectButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.infoTextBox = new System.Windows.Forms.TextBox();
            this.collectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // infoTextBox
            // 
            this.infoTextBox.Location = new System.Drawing.Point(12, 12);
            this.infoTextBox.Multiline = true;
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.ReadOnly = true;
            this.infoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.infoTextBox.Size = new System.Drawing.Size(760, 500);
            this.infoTextBox.TabIndex = 0;
            // 
            // collectButton
            // 
            this.collectButton.Location = new System.Drawing.Point(350, 530);
            this.collectButton.Name = "collectButton";
            this.collectButton.Size = new System.Drawing.Size(100, 30);
            this.collectButton.TabIndex = 1;
            this.collectButton.Text = "Запустить GC";
            this.collectButton.UseVisualStyleBackColor = true;
            this.collectButton.Click += new System.EventHandler(this.collectButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 581);
            this.Controls.Add(this.infoTextBox);
            this.Controls.Add(this.collectButton);
            this.Name = "Form1";
            this.Text = "Информация о сборщике мусора";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}