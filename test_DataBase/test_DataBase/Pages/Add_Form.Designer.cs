namespace test_DataBase.Pages
{
    partial class Add_Form
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.TextBox txtProductType;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnSave;

        // Разделители и группировка
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.Label lblDepartmentValue;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.lblDepartmentValue = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblProductType = new System.Windows.Forms.Label();
            this.txtProductType = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBoxAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Controls.Add(this.lblDepartmentValue);
            this.groupBoxAdd.Controls.Add(this.lblDepartment);
            this.groupBoxAdd.Controls.Add(this.lblProductType);
            this.groupBoxAdd.Controls.Add(this.txtProductType);
            this.groupBoxAdd.Controls.Add(this.lblQuantity);
            this.groupBoxAdd.Controls.Add(this.txtQuantity);
            this.groupBoxAdd.Controls.Add(this.lblSupplier);
            this.groupBoxAdd.Controls.Add(this.txtSupplier);
            this.groupBoxAdd.Controls.Add(this.lblPrice);
            this.groupBoxAdd.Controls.Add(this.txtPrice);
            this.groupBoxAdd.Controls.Add(this.btnSave);
            this.groupBoxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxAdd.Location = new System.Drawing.Point(9, 10);
            this.groupBoxAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxAdd.Size = new System.Drawing.Size(345, 268);
            this.groupBoxAdd.TabIndex = 0;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "Создание записи:";
            // 
            // lblDepartmentValue
            // 
            this.lblDepartmentValue.AutoSize = true;
            this.lblDepartmentValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblDepartmentValue.Location = new System.Drawing.Point(22, 73);
            this.lblDepartmentValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepartmentValue.Name = "lblDepartmentValue";
            this.lblDepartmentValue.Size = new System.Drawing.Size(0, 15);
            this.lblDepartmentValue.TabIndex = 2;
            this.lblDepartmentValue.Visible = false;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblDepartment.Location = new System.Drawing.Point(22, 73);
            this.lblDepartment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(0, 15);
            this.lblDepartment.TabIndex = 1;
            this.lblDepartment.Visible = false;
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblProductType.Location = new System.Drawing.Point(37, 37);
            this.lblProductType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(87, 17);
            this.lblProductType.TabIndex = 3;
            this.lblProductType.Text = "Тип товара:";
            // 
            // txtProductType
            // 
            this.txtProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtProductType.Location = new System.Drawing.Point(134, 35);
            this.txtProductType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProductType.Name = "txtProductType";
            this.txtProductType.Size = new System.Drawing.Size(181, 23);
            this.txtProductType.TabIndex = 4;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblQuantity.Location = new System.Drawing.Point(37, 78);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(90, 17);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "Количество:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtQuantity.Location = new System.Drawing.Point(134, 75);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(181, 23);
            this.txtQuantity.TabIndex = 6;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSupplier.Location = new System.Drawing.Point(37, 118);
            this.lblSupplier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(85, 17);
            this.lblSupplier.TabIndex = 7;
            this.lblSupplier.Text = "Поставщик:";
            // 
            // txtSupplier
            // 
            this.txtSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSupplier.Location = new System.Drawing.Point(134, 116);
            this.txtSupplier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(181, 23);
            this.txtSupplier.TabIndex = 8;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPrice.Location = new System.Drawing.Point(37, 159);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(47, 17);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Цена:";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPrice.Location = new System.Drawing.Point(134, 157);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(181, 23);
            this.txtPrice.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnSave.Location = new System.Drawing.Point(97, 208);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 37);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "💾 Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // Add_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(363, 285);
            this.Controls.Add(this.groupBoxAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление новой записи - Отдел №1";
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxAdd.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}