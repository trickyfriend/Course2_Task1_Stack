namespace Course2_Task1_Stack
{
    partial class TheForm
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
            this.FileChooseButton = new System.Windows.Forms.Button();
            this.RunButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // FileChooseButton
            // 
            this.FileChooseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileChooseButton.Location = new System.Drawing.Point(64, 53);
            this.FileChooseButton.Name = "FileChooseButton";
            this.FileChooseButton.Size = new System.Drawing.Size(157, 66);
            this.FileChooseButton.TabIndex = 0;
            this.FileChooseButton.Text = "Choose file";
            this.FileChooseButton.UseVisualStyleBackColor = true;
            this.FileChooseButton.Click += new System.EventHandler(this.FileChooseButton_Click);
            // 
            // RunButton
            // 
            this.RunButton.BackColor = System.Drawing.Color.Red;
            this.RunButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RunButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RunButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RunButton.Location = new System.Drawing.Point(64, 159);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(157, 66);
            this.RunButton.TabIndex = 1;
            this.RunButton.Text = "RUN!";
            this.RunButton.UseVisualStyleBackColor = false;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "inputFile";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "outputFile";
            // 
            // TheForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 292);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.FileChooseButton);
            this.Name = "TheForm";
            this.Text = "TheForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FileChooseButton;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

