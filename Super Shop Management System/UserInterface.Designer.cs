namespace Super_Shop_Management_System
{
    partial class UserInterface
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
            this.btnlogOut = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnApplyPromo = new System.Windows.Forms.Button();
            this.txtReturn = new System.Windows.Forms.TextBox();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.txtInTotalPrice = new System.Windows.Forms.TextBox();
            this.txtPromo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbQuantity = new System.Windows.Forms.ComboBox();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnPView = new System.Windows.Forms.Button();
            this.bntAllpView = new System.Windows.Forms.Button();
            this.cmbPview = new System.Windows.Forms.ComboBox();
            this.gridViewProduct = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnCreateCAccount = new System.Windows.Forms.Button();
            this.txtCPhone = new System.Windows.Forms.TextBox();
            this.txtCAddress = new System.Windows.Forms.TextBox();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProduct)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnlogOut
            // 
            this.btnlogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogOut.Location = new System.Drawing.Point(346, 272);
            this.btnlogOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnlogOut.Name = "btnlogOut";
            this.btnlogOut.Size = new System.Drawing.Size(93, 29);
            this.btnlogOut.TabIndex = 0;
            this.btnlogOut.Text = "Log Out";
            this.btnlogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlogOut.UseVisualStyleBackColor = true;
            this.btnlogOut.Click += new System.EventHandler(this.btnlogOut_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(445, 266);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnCalculate);
            this.tabPage1.Controls.Add(this.btnApplyPromo);
            this.tabPage1.Controls.Add(this.txtReturn);
            this.tabPage1.Controls.Add(this.txtPayment);
            this.tabPage1.Controls.Add(this.txtInTotalPrice);
            this.tabPage1.Controls.Add(this.txtPromo);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btnPrint);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.cmbQuantity);
            this.tabPage1.Controls.Add(this.cmbProduct);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(437, 240);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Reciept Area";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(326, 183);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Return";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(214, 181);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Payment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 181);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "In Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Promo";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(244, 212);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(79, 21);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnApplyPromo
            // 
            this.btnApplyPromo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyPromo.Location = new System.Drawing.Point(42, 212);
            this.btnApplyPromo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnApplyPromo.Name = "btnApplyPromo";
            this.btnApplyPromo.Size = new System.Drawing.Size(50, 21);
            this.btnApplyPromo.TabIndex = 10;
            this.btnApplyPromo.Text = "Apply";
            this.btnApplyPromo.UseVisualStyleBackColor = true;
            this.btnApplyPromo.Click += new System.EventHandler(this.btnApplyPromo_Click);
            // 
            // txtReturn
            // 
            this.txtReturn.Location = new System.Drawing.Point(369, 180);
            this.txtReturn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtReturn.Name = "txtReturn";
            this.txtReturn.Size = new System.Drawing.Size(45, 20);
            this.txtReturn.TabIndex = 9;
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(265, 181);
            this.txtPayment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(45, 20);
            this.txtPayment.TabIndex = 9;
            // 
            // txtInTotalPrice
            // 
            this.txtInTotalPrice.Location = new System.Drawing.Point(147, 181);
            this.txtInTotalPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInTotalPrice.Name = "txtInTotalPrice";
            this.txtInTotalPrice.Size = new System.Drawing.Size(65, 20);
            this.txtInTotalPrice.TabIndex = 8;
            // 
            // txtPromo
            // 
            this.txtPromo.Location = new System.Drawing.Point(42, 180);
            this.txtPromo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPromo.Name = "txtPromo";
            this.txtPromo.Size = new System.Drawing.Size(57, 20);
            this.txtPromo.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 44);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(433, 133);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(362, 208);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(60, 29);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(319, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbQuantity
            // 
            this.cmbQuantity.FormattingEnabled = true;
            this.cmbQuantity.Location = new System.Drawing.Point(217, 13);
            this.cmbQuantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbQuantity.Name = "cmbQuantity";
            this.cmbQuantity.Size = new System.Drawing.Size(82, 21);
            this.cmbQuantity.TabIndex = 1;
            // 
            // cmbProduct
            // 
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(2, 13);
            this.cmbProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(198, 21);
            this.cmbProduct.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnPView);
            this.tabPage3.Controls.Add(this.bntAllpView);
            this.tabPage3.Controls.Add(this.cmbPview);
            this.tabPage3.Controls.Add(this.gridViewProduct);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(437, 240);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Product";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnPView
            // 
            this.btnPView.Location = new System.Drawing.Point(57, 55);
            this.btnPView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPView.Name = "btnPView";
            this.btnPView.Size = new System.Drawing.Size(62, 21);
            this.btnPView.TabIndex = 7;
            this.btnPView.Text = "View";
            this.btnPView.UseVisualStyleBackColor = true;
            this.btnPView.Click += new System.EventHandler(this.btnPView_Click_1);
            // 
            // bntAllpView
            // 
            this.bntAllpView.Location = new System.Drawing.Point(192, 20);
            this.bntAllpView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bntAllpView.Name = "bntAllpView";
            this.bntAllpView.Size = new System.Drawing.Size(71, 25);
            this.bntAllpView.TabIndex = 6;
            this.bntAllpView.Text = "All Product";
            this.bntAllpView.UseVisualStyleBackColor = true;
            this.bntAllpView.Click += new System.EventHandler(this.bntAllpView_Click_1);
            // 
            // cmbPview
            // 
            this.cmbPview.FormattingEnabled = true;
            this.cmbPview.Location = new System.Drawing.Point(33, 27);
            this.cmbPview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbPview.Name = "cmbPview";
            this.cmbPview.Size = new System.Drawing.Size(117, 21);
            this.cmbPview.TabIndex = 5;
            // 
            // gridViewProduct
            // 
            this.gridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewProduct.Location = new System.Drawing.Point(3, 87);
            this.gridViewProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridViewProduct.Name = "gridViewProduct";
            this.gridViewProduct.RowTemplate.Height = 28;
            this.gridViewProduct.Size = new System.Drawing.Size(318, 156);
            this.gridViewProduct.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.btnCreateCAccount);
            this.tabPage2.Controls.Add(this.txtCPhone);
            this.tabPage2.Controls.Add(this.txtCAddress);
            this.tabPage2.Controls.Add(this.txtCName);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(437, 240);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Customer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(274, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(133, 75);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(4, 44);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(67, 19);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(4, 12);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(53, 19);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnCreateCAccount
            // 
            this.btnCreateCAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCAccount.Location = new System.Drawing.Point(156, 183);
            this.btnCreateCAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreateCAccount.Name = "btnCreateCAccount";
            this.btnCreateCAccount.Size = new System.Drawing.Size(147, 35);
            this.btnCreateCAccount.TabIndex = 2;
            this.btnCreateCAccount.Text = "Create Account";
            this.btnCreateCAccount.UseVisualStyleBackColor = true;
            this.btnCreateCAccount.Click += new System.EventHandler(this.btnCreateCAccount_Click);
            // 
            // txtCPhone
            // 
            this.txtCPhone.Location = new System.Drawing.Point(94, 110);
            this.txtCPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCPhone.Name = "txtCPhone";
            this.txtCPhone.Size = new System.Drawing.Size(140, 21);
            this.txtCPhone.TabIndex = 1;
            // 
            // txtCAddress
            // 
            this.txtCAddress.Location = new System.Drawing.Point(94, 63);
            this.txtCAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCAddress.Name = "txtCAddress";
            this.txtCAddress.Size = new System.Drawing.Size(140, 21);
            this.txtCAddress.TabIndex = 1;
            // 
            // txtCName
            // 
            this.txtCName.Location = new System.Drawing.Point(94, 21);
            this.txtCName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(140, 21);
            this.txtCName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 309);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnlogOut);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserInterface";
            this.Text = "Shop Management System";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProduct)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnlogOut;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCreateCAccount;
        private System.Windows.Forms.TextBox txtCPhone;
        private System.Windows.Forms.TextBox txtCAddress;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbQuantity;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnApplyPromo;
        private System.Windows.Forms.TextBox txtReturn;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.TextBox txtInTotalPrice;
        private System.Windows.Forms.TextBox txtPromo;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnPView;
        private System.Windows.Forms.Button bntAllpView;
        private System.Windows.Forms.ComboBox cmbPview;
        private System.Windows.Forms.DataGridView gridViewProduct;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}