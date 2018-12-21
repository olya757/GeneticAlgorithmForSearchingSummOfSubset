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
            this.nUDValue = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nUDAmountOfGenerations = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nUDProb = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nUDAmountOfFirstGeneration = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nUDTop = new System.Windows.Forms.NumericUpDown();
            this.tBSearchResult = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbGen = new System.Windows.Forms.Label();
            this.lbRight = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nUDValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDAmountOfGenerations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDProb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDAmountOfFirstGeneration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDTop)).BeginInit();
            this.SuspendLayout();
            // 
            // tBGenes
            // 
            this.tBGenes.Location = new System.Drawing.Point(12, 31);
            this.tBGenes.Name = "tBGenes";
            this.tBGenes.Size = new System.Drawing.Size(362, 20);
            this.tBGenes.TabIndex = 0;
            this.tBGenes.Text = "1 2 3 4 3 5 -2 3 4 5 2";
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(12, 338);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(75, 23);
            this.btnInput.TabIndex = 1;
            this.btnInput.Text = "Ввести";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // tBChromosomes
            // 
            this.tBChromosomes.Location = new System.Drawing.Point(380, 31);
            this.tBChromosomes.Multiline = true;
            this.tBChromosomes.Name = "tBChromosomes";
            this.tBChromosomes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBChromosomes.Size = new System.Drawing.Size(191, 299);
            this.tBChromosomes.TabIndex = 2;
            this.tBChromosomes.TextChanged += new System.EventHandler(this.tBChromosomes_TextChanged);
            // 
            // nUDValue
            // 
            this.nUDValue.Location = new System.Drawing.Point(12, 79);
            this.nUDValue.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nUDValue.Name = "nUDValue";
            this.nUDValue.Size = new System.Drawing.Size(120, 20);
            this.nUDValue.TabIndex = 4;
            this.nUDValue.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
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
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Введите искомую сумму";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Введите количество поколений";
            // 
            // nUDAmountOfGenerations
            // 
            this.nUDAmountOfGenerations.Location = new System.Drawing.Point(12, 127);
            this.nUDAmountOfGenerations.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nUDAmountOfGenerations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDAmountOfGenerations.Name = "nUDAmountOfGenerations";
            this.nUDAmountOfGenerations.Size = new System.Drawing.Size(120, 20);
            this.nUDAmountOfGenerations.TabIndex = 7;
            this.nUDAmountOfGenerations.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Введите вероятность мутации";
            // 
            // nUDProb
            // 
            this.nUDProb.Location = new System.Drawing.Point(12, 175);
            this.nUDProb.Name = "nUDProb";
            this.nUDProb.Size = new System.Drawing.Size(120, 20);
            this.nUDProb.TabIndex = 9;
            this.nUDProb.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Введите размер первого поколения";
            // 
            // nUDAmountOfFirstGeneration
            // 
            this.nUDAmountOfFirstGeneration.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUDAmountOfFirstGeneration.Location = new System.Drawing.Point(12, 223);
            this.nUDAmountOfFirstGeneration.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nUDAmountOfFirstGeneration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDAmountOfFirstGeneration.Name = "nUDAmountOfFirstGeneration";
            this.nUDAmountOfFirstGeneration.Size = new System.Drawing.Size(120, 20);
            this.nUDAmountOfFirstGeneration.TabIndex = 11;
            this.nUDAmountOfFirstGeneration.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(277, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Введите долю хромосом, оставляемую после отсева";
            // 
            // nUDTop
            // 
            this.nUDTop.Location = new System.Drawing.Point(12, 271);
            this.nUDTop.Name = "nUDTop";
            this.nUDTop.Size = new System.Drawing.Size(120, 20);
            this.nUDTop.TabIndex = 13;
            this.nUDTop.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // tBSearchResult
            // 
            this.tBSearchResult.Location = new System.Drawing.Point(592, 31);
            this.tBSearchResult.Multiline = true;
            this.tBSearchResult.Name = "tBSearchResult";
            this.tBSearchResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBSearchResult.Size = new System.Drawing.Size(187, 299);
            this.tBSearchResult.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(589, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Результат полученный перебором";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(377, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Генетический алгоритм";
            // 
            // lbGen
            // 
            this.lbGen.AutoSize = true;
            this.lbGen.Location = new System.Drawing.Point(436, 337);
            this.lbGen.Name = "lbGen";
            this.lbGen.Size = new System.Drawing.Size(0, 13);
            this.lbGen.TabIndex = 19;
            // 
            // lbRight
            // 
            this.lbRight.AutoSize = true;
            this.lbRight.Location = new System.Drawing.Point(666, 337);
            this.lbRight.Name = "lbRight";
            this.lbRight.Size = new System.Drawing.Size(0, 13);
            this.lbRight.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 382);
            this.Controls.Add(this.lbRight);
            this.Controls.Add(this.lbGen);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tBSearchResult);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nUDTop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nUDAmountOfFirstGeneration);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nUDProb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nUDAmountOfGenerations);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nUDValue);
            this.Controls.Add(this.tBChromosomes);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.tBGenes);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nUDValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDAmountOfGenerations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDProb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDAmountOfFirstGeneration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBGenes;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.TextBox tBChromosomes;
        private System.Windows.Forms.NumericUpDown nUDValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nUDAmountOfGenerations;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nUDProb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nUDAmountOfFirstGeneration;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nUDTop;
        private System.Windows.Forms.TextBox tBSearchResult;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbGen;
        private System.Windows.Forms.Label lbRight;
    }
}

