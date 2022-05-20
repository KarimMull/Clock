
namespace CLOCK
{
    partial class Form2
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
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.radioButton_repeat = new System.Windows.Forms.RadioButton();
            this.textBox_time_set = new System.Windows.Forms.TextBox();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(12, 28);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(101, 43);
            this.button_Cancel.TabIndex = 0;
            this.button_Cancel.Text = "отмена";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(298, 28);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(101, 43);
            this.button_Save.TabIndex = 1;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // radioButton_repeat
            // 
            this.radioButton_repeat.AutoSize = true;
            this.radioButton_repeat.Location = new System.Drawing.Point(101, 451);
            this.radioButton_repeat.Name = "radioButton_repeat";
            this.radioButton_repeat.Size = new System.Drawing.Size(199, 21);
            this.radioButton_repeat.TabIndex = 4;
            this.radioButton_repeat.TabStop = true;
            this.radioButton_repeat.Text = "Повтор сигнала (ДА/НЕТ)";
            this.radioButton_repeat.UseVisualStyleBackColor = true;
            // 
            // textBox_time_set
            // 
            this.textBox_time_set.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_time_set.Location = new System.Drawing.Point(112, 148);
            this.textBox_time_set.Name = "textBox_time_set";
            this.textBox_time_set.Size = new System.Drawing.Size(167, 75);
            this.textBox_time_set.TabIndex = 5;
            this.textBox_time_set.Text = "08:00";
            // 
            // textBox_description
            // 
            this.textBox_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_description.Location = new System.Drawing.Point(87, 372);
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(236, 30);
            this.textBox_description.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(82, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Описание";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 565);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_description);
            this.Controls.Add(this.textBox_time_set);
            this.Controls.Add(this.radioButton_repeat);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Cancel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.RadioButton radioButton_repeat;
        private System.Windows.Forms.TextBox textBox_time_set;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.Label label1;
    }
}