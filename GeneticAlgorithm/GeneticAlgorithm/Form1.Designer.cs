namespace GeneticAlgorithm
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
            this.tBGenes = new System.Windows.Forms.TextBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.tBChromosomes = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.nUDValue = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nUDValue)).BeginInit();
            this.SuspendLayout();
            // 
            // tBGenes
            // 
            this.tBGenes.Location = new System.Drawing.Point(12, 31);
            this.tBGenes.Name = "tBGenes";
            this.tBGenes.Size = new System.Drawing.Size(362, 20);
            this.tBGenes.TabIndex = 0;
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(12, 134);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(75, 23);
            this.btnInput.TabIndex = 1;
            this.btnInput.Text = "Ввести";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // tBChromosomes
            // 
            this.tBChromosomes.Location = new System.Drawing.Point(393, 12);
            this.tBChromosomes.Multiline = true;
            this.tBChromosomes.Name = "tBChromosomes";
            this.tBChromosomes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBChromosomes.Size = new System.Drawing.Size(384, 400);
            this.tBChromosomes.TabIndex = 2;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(222, 352);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(152, 60);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Следующее поколение";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // nUDValue
            // 
            this.nUDValue.Location = new System.Drawing.Point(12, 89);
            this.nUDValue.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nUDValue.Name = "nUDValue";
            this.nUDValue.Size = new System.Drawing.Size(120, 20);
            this.nUDValue.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите элементы множества через пробел";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Введите искомую сумму";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nUDValue);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.tBChromosomes);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.tBGenes);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nUDValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBGenes;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.TextBox tBChromosomes;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.NumericUpDown nUDValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

