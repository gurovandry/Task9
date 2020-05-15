namespace Task9
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
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_from = new System.Windows.Forms.TextBox();
            this.label_welcome = new System.Windows.Forms.Label();
            this.textBox_to = new System.Windows.Forms.TextBox();
            this.textBox_intervals = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_search
            // 
            this.button_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_search.Location = new System.Drawing.Point(148, 344);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(182, 73);
            this.button_search.TabIndex = 0;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBox_from
            // 
            this.textBox_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_from.Location = new System.Drawing.Point(148, 134);
            this.textBox_from.MaxLength = 10;
            this.textBox_from.Multiline = true;
            this.textBox_from.Name = "textBox_from";
            this.textBox_from.Size = new System.Drawing.Size(182, 64);
            this.textBox_from.TabIndex = 2;
            // 
            // label_welcome
            // 
            this.label_welcome.BackColor = System.Drawing.SystemColors.Window;
            this.label_welcome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_welcome.Location = new System.Drawing.Point(12, 9);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(776, 75);
            this.label_welcome.TabIndex = 3;
            this.label_welcome.Text = "Welcome to Simple Number Searcher. Please, input the data";
            this.label_welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_to
            // 
            this.textBox_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_to.Location = new System.Drawing.Point(148, 204);
            this.textBox_to.MaxLength = 10;
            this.textBox_to.Multiline = true;
            this.textBox_to.Name = "textBox_to";
            this.textBox_to.Size = new System.Drawing.Size(182, 64);
            this.textBox_to.TabIndex = 4;
            // 
            // textBox_intervals
            // 
            this.textBox_intervals.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_intervals.Location = new System.Drawing.Point(148, 274);
            this.textBox_intervals.MaxLength = 10;
            this.textBox_intervals.Multiline = true;
            this.textBox_intervals.Name = "textBox_intervals";
            this.textBox_intervals.Size = new System.Drawing.Size(182, 64);
            this.textBox_intervals.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_intervals);
            this.Controls.Add(this.textBox_to);
            this.Controls.Add(this.label_welcome);
            this.Controls.Add(this.textBox_from);
            this.Controls.Add(this.button_search);
            this.Name = "Form1";
            this.Text = "Simple Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox_from;
        private System.Windows.Forms.Label label_welcome;
        private System.Windows.Forms.TextBox textBox_to;
        private System.Windows.Forms.TextBox textBox_intervals;
    }
}

