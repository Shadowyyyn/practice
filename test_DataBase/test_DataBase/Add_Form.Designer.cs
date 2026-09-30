
namespace test_DataBase
{
    partial class Add_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_type2 = new System.Windows.Forms.TextBox();
            this.textBox_count2 = new System.Windows.Forms.TextBox();
            this.textBox_postav2 = new System.Windows.Forms.TextBox();
            this.textBox_price2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(19, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тип товара:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Количество:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(18, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Поставщик:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(60, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Цена:";
            // 
            // textBox_type2
            // 
            this.textBox_type2.Location = new System.Drawing.Point(113, 65);
            this.textBox_type2.Multiline = true;
            this.textBox_type2.Name = "textBox_type2";
            this.textBox_type2.Size = new System.Drawing.Size(216, 26);
            this.textBox_type2.TabIndex = 4;
            // 
            // textBox_count2
            // 
            this.textBox_count2.Location = new System.Drawing.Point(113, 97);
            this.textBox_count2.Multiline = true;
            this.textBox_count2.Name = "textBox_count2";
            this.textBox_count2.Size = new System.Drawing.Size(216, 26);
            this.textBox_count2.TabIndex = 5;
            // 
            // textBox_postav2
            // 
            this.textBox_postav2.Location = new System.Drawing.Point(113, 129);
            this.textBox_postav2.Multiline = true;
            this.textBox_postav2.Name = "textBox_postav2";
            this.textBox_postav2.Size = new System.Drawing.Size(216, 26);
            this.textBox_postav2.TabIndex = 6;
            // 
            // textBox_price2
            // 
            this.textBox_price2.Location = new System.Drawing.Point(113, 161);
            this.textBox_price2.Multiline = true;
            this.textBox_price2.Name = "textBox_price2";
            this.textBox_price2.Size = new System.Drawing.Size(216, 26);
            this.textBox_price2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 271);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_price2);
            this.Controls.Add(this.textBox_postav2);
            this.Controls.Add(this.textBox_count2);
            this.Controls.Add(this.textBox_type2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Add_Form";
            this.Text = "Add_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_type2;
        private System.Windows.Forms.TextBox textBox_count2;
        private System.Windows.Forms.TextBox textBox_postav2;
        private System.Windows.Forms.TextBox textBox_price2;
        private System.Windows.Forms.Button button1;
    }
}