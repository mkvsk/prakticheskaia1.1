
namespace prakticheskaia1_byNeshik
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
            this.labelWho = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.buttonSum = new System.Windows.Forms.Button();
            this.buttonMax = new System.Windows.Forms.Button();
            this.textBoxName1 = new System.Windows.Forms.TextBox();
            this.textBoxName2 = new System.Windows.Forms.TextBox();
            this.textBoxName3 = new System.Windows.Forms.TextBox();
            this.textBoxQuantity3 = new System.Windows.Forms.TextBox();
            this.textBoxQuantity2 = new System.Windows.Forms.TextBox();
            this.textBoxQuantity1 = new System.Windows.Forms.TextBox();
            this.textBoxMaxResult = new System.Windows.Forms.TextBox();
            this.textBoxSumResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelWho
            // 
            this.labelWho.AutoSize = true;
            this.labelWho.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWho.Location = new System.Drawing.Point(39, 40);
            this.labelWho.Name = "labelWho";
            this.labelWho.Size = new System.Drawing.Size(54, 25);
            this.labelWho.TabIndex = 0;
            this.labelWho.Text = "Кто:";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuantity.Location = new System.Drawing.Point(39, 107);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(102, 25);
            this.labelQuantity.TabIndex = 1;
            this.labelQuantity.Text = "Сколько:";
            // 
            // buttonSum
            // 
            this.buttonSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSum.Location = new System.Drawing.Point(44, 174);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(158, 33);
            this.buttonSum.TabIndex = 2;
            this.buttonSum.Text = "сумма";
            this.buttonSum.UseVisualStyleBackColor = true;
            this.buttonSum.Click += new System.EventHandler(this.buttonSum_Click);
            // 
            // buttonMax
            // 
            this.buttonMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMax.Location = new System.Drawing.Point(44, 244);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Size = new System.Drawing.Size(158, 33);
            this.buttonMax.TabIndex = 3;
            this.buttonMax.Text = "максимум";
            this.buttonMax.UseVisualStyleBackColor = true;
            this.buttonMax.Click += new System.EventHandler(this.buttonMax_Click);
            // 
            // textBoxName1
            // 
            this.textBoxName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName1.Location = new System.Drawing.Point(211, 40);
            this.textBoxName1.Name = "textBoxName1";
            this.textBoxName1.Size = new System.Drawing.Size(158, 31);
            this.textBoxName1.TabIndex = 4;
            // 
            // textBoxName2
            // 
            this.textBoxName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName2.Location = new System.Drawing.Point(404, 40);
            this.textBoxName2.Name = "textBoxName2";
            this.textBoxName2.Size = new System.Drawing.Size(158, 31);
            this.textBoxName2.TabIndex = 5;
            // 
            // textBoxName3
            // 
            this.textBoxName3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName3.Location = new System.Drawing.Point(594, 40);
            this.textBoxName3.Name = "textBoxName3";
            this.textBoxName3.Size = new System.Drawing.Size(158, 31);
            this.textBoxName3.TabIndex = 6;
            // 
            // textBoxQuantity3
            // 
            this.textBoxQuantity3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxQuantity3.Location = new System.Drawing.Point(594, 101);
            this.textBoxQuantity3.Name = "textBoxQuantity3";
            this.textBoxQuantity3.Size = new System.Drawing.Size(158, 31);
            this.textBoxQuantity3.TabIndex = 9;
            // 
            // textBoxQuantity2
            // 
            this.textBoxQuantity2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxQuantity2.Location = new System.Drawing.Point(404, 101);
            this.textBoxQuantity2.Name = "textBoxQuantity2";
            this.textBoxQuantity2.Size = new System.Drawing.Size(158, 31);
            this.textBoxQuantity2.TabIndex = 8;
            // 
            // textBoxQuantity1
            // 
            this.textBoxQuantity1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxQuantity1.Location = new System.Drawing.Point(211, 101);
            this.textBoxQuantity1.Name = "textBoxQuantity1";
            this.textBoxQuantity1.Size = new System.Drawing.Size(158, 31);
            this.textBoxQuantity1.TabIndex = 7;
            // 
            // textBoxMaxResult
            // 
            this.textBoxMaxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMaxResult.Location = new System.Drawing.Point(214, 246);
            this.textBoxMaxResult.Name = "textBoxMaxResult";
            this.textBoxMaxResult.Size = new System.Drawing.Size(535, 31);
            this.textBoxMaxResult.TabIndex = 11;
            // 
            // textBoxSumResult
            // 
            this.textBoxSumResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSumResult.Location = new System.Drawing.Point(211, 176);
            this.textBoxSumResult.Name = "textBoxSumResult";
            this.textBoxSumResult.Size = new System.Drawing.Size(538, 31);
            this.textBoxSumResult.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 345);
            this.Controls.Add(this.textBoxMaxResult);
            this.Controls.Add(this.textBoxSumResult);
            this.Controls.Add(this.textBoxQuantity3);
            this.Controls.Add(this.textBoxQuantity2);
            this.Controls.Add(this.textBoxQuantity1);
            this.Controls.Add(this.textBoxName3);
            this.Controls.Add(this.textBoxName2);
            this.Controls.Add(this.textBoxName1);
            this.Controls.Add(this.buttonMax);
            this.Controls.Add(this.buttonSum);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelWho);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWho;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.Button buttonMax;
        private System.Windows.Forms.TextBox textBoxName1;
        private System.Windows.Forms.TextBox textBoxName2;
        private System.Windows.Forms.TextBox textBoxName3;
        private System.Windows.Forms.TextBox textBoxQuantity3;
        private System.Windows.Forms.TextBox textBoxQuantity2;
        private System.Windows.Forms.TextBox textBoxQuantity1;
        private System.Windows.Forms.TextBox textBoxMaxResult;
        private System.Windows.Forms.TextBox textBoxSumResult;
    }
}

