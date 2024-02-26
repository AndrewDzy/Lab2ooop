
namespace Lab2ooop
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtVector1XAddSubtract = new System.Windows.Forms.TextBox();
            this.txtVector1YAddSubtract = new System.Windows.Forms.TextBox();
            this.txtVector2XAddSubtract = new System.Windows.Forms.TextBox();
            this.txtVector2YAddSubtract = new System.Windows.Forms.TextBox();
            this.txtVector1ZAddSubtract = new System.Windows.Forms.TextBox();
            this.txtVector2ZAddSubtract = new System.Windows.Forms.TextBox();
            this.btnAddVectors = new System.Windows.Forms.Button();
            this.btnSubtractVectors = new System.Windows.Forms.Button();
            this.lblResultVectorAddSubtract = new System.Windows.Forms.Label();
            this.txtVector1XDot = new System.Windows.Forms.TextBox();
            this.txtVector1YDot = new System.Windows.Forms.TextBox();
            this.txtVector1ZDot = new System.Windows.Forms.TextBox();
            this.txtVector2ZDot = new System.Windows.Forms.TextBox();
            this.txtVector2YDot = new System.Windows.Forms.TextBox();
            this.txtVector2XDot = new System.Windows.Forms.TextBox();
            this.btnCalculateDotProduct = new System.Windows.Forms.Button();
            this.lblDotProductResult = new System.Windows.Forms.Label();
            this.txtVectorXLength = new System.Windows.Forms.TextBox();
            this.txtVectorYLength = new System.Windows.Forms.TextBox();
            this.txtVectorZLength = new System.Windows.Forms.TextBox();
            this.btnCalculateVectorLength = new System.Windows.Forms.Button();
            this.lblVectorLengthResult = new System.Windows.Forms.Label();
            this.txtVector1XCosine = new System.Windows.Forms.TextBox();
            this.txtVector1YCosine = new System.Windows.Forms.TextBox();
            this.txtVector1ZCosine = new System.Windows.Forms.TextBox();
            this.txtVector2ZCosine = new System.Windows.Forms.TextBox();
            this.txtVector2YCosine = new System.Windows.Forms.TextBox();
            this.txtVector2XCosine = new System.Windows.Forms.TextBox();
            this.btnCalculateAngleCosine = new System.Windows.Forms.Button();
            this.lblAngleCosineResult = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 449);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblResultVectorAddSubtract);
            this.tabPage1.Controls.Add(this.btnSubtractVectors);
            this.tabPage1.Controls.Add(this.btnAddVectors);
            this.tabPage1.Controls.Add(this.txtVector2ZAddSubtract);
            this.tabPage1.Controls.Add(this.txtVector1ZAddSubtract);
            this.tabPage1.Controls.Add(this.txtVector2YAddSubtract);
            this.tabPage1.Controls.Add(this.txtVector2XAddSubtract);
            this.tabPage1.Controls.Add(this.txtVector1YAddSubtract);
            this.tabPage1.Controls.Add(this.txtVector1XAddSubtract);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(791, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Додавання та віднімання векторів";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblDotProductResult);
            this.tabPage2.Controls.Add(this.btnCalculateDotProduct);
            this.tabPage2.Controls.Add(this.txtVector2ZDot);
            this.tabPage2.Controls.Add(this.txtVector2YDot);
            this.tabPage2.Controls.Add(this.txtVector2XDot);
            this.tabPage2.Controls.Add(this.txtVector1ZDot);
            this.tabPage2.Controls.Add(this.txtVector1YDot);
            this.tabPage2.Controls.Add(this.txtVector1XDot);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(791, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Обчислення скалярного добутку";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblVectorLengthResult);
            this.tabPage3.Controls.Add(this.btnCalculateVectorLength);
            this.tabPage3.Controls.Add(this.txtVectorZLength);
            this.tabPage3.Controls.Add(this.txtVectorYLength);
            this.tabPage3.Controls.Add(this.txtVectorXLength);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(791, 423);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Обчислення довжини вектора";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lblAngleCosineResult);
            this.tabPage4.Controls.Add(this.btnCalculateAngleCosine);
            this.tabPage4.Controls.Add(this.txtVector2ZCosine);
            this.tabPage4.Controls.Add(this.txtVector2YCosine);
            this.tabPage4.Controls.Add(this.txtVector2XCosine);
            this.tabPage4.Controls.Add(this.txtVector1ZCosine);
            this.tabPage4.Controls.Add(this.txtVector1YCosine);
            this.tabPage4.Controls.Add(this.txtVector1XCosine);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(791, 423);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Обчислення косинуса кута між векторами";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtVector1XAddSubtract
            // 
            this.txtVector1XAddSubtract.Location = new System.Drawing.Point(20, 15);
            this.txtVector1XAddSubtract.Name = "txtVector1XAddSubtract";
            this.txtVector1XAddSubtract.Size = new System.Drawing.Size(100, 20);
            this.txtVector1XAddSubtract.TabIndex = 0;
            // 
            // txtVector1YAddSubtract
            // 
            this.txtVector1YAddSubtract.Location = new System.Drawing.Point(20, 53);
            this.txtVector1YAddSubtract.Name = "txtVector1YAddSubtract";
            this.txtVector1YAddSubtract.Size = new System.Drawing.Size(100, 20);
            this.txtVector1YAddSubtract.TabIndex = 1;
            // 
            // txtVector2XAddSubtract
            // 
            this.txtVector2XAddSubtract.Location = new System.Drawing.Point(150, 15);
            this.txtVector2XAddSubtract.Name = "txtVector2XAddSubtract";
            this.txtVector2XAddSubtract.Size = new System.Drawing.Size(100, 20);
            this.txtVector2XAddSubtract.TabIndex = 2;
            // 
            // txtVector2YAddSubtract
            // 
            this.txtVector2YAddSubtract.Location = new System.Drawing.Point(150, 53);
            this.txtVector2YAddSubtract.Name = "txtVector2YAddSubtract";
            this.txtVector2YAddSubtract.Size = new System.Drawing.Size(100, 20);
            this.txtVector2YAddSubtract.TabIndex = 3;
            // 
            // txtVector1ZAddSubtract
            // 
            this.txtVector1ZAddSubtract.Location = new System.Drawing.Point(20, 97);
            this.txtVector1ZAddSubtract.Name = "txtVector1ZAddSubtract";
            this.txtVector1ZAddSubtract.Size = new System.Drawing.Size(100, 20);
            this.txtVector1ZAddSubtract.TabIndex = 4;
            // 
            // txtVector2ZAddSubtract
            // 
            this.txtVector2ZAddSubtract.Location = new System.Drawing.Point(150, 97);
            this.txtVector2ZAddSubtract.Name = "txtVector2ZAddSubtract";
            this.txtVector2ZAddSubtract.Size = new System.Drawing.Size(100, 20);
            this.txtVector2ZAddSubtract.TabIndex = 5;
            // 
            // btnAddVectors
            // 
            this.btnAddVectors.Location = new System.Drawing.Point(45, 152);
            this.btnAddVectors.Name = "btnAddVectors";
            this.btnAddVectors.Size = new System.Drawing.Size(75, 23);
            this.btnAddVectors.TabIndex = 6;
            this.btnAddVectors.Text = "button1";
            this.btnAddVectors.UseVisualStyleBackColor = true;
            this.btnAddVectors.Click += new System.EventHandler(this.btnAddVectors_Click);
            // 
            // btnSubtractVectors
            // 
            this.btnSubtractVectors.Location = new System.Drawing.Point(175, 152);
            this.btnSubtractVectors.Name = "btnSubtractVectors";
            this.btnSubtractVectors.Size = new System.Drawing.Size(75, 23);
            this.btnSubtractVectors.TabIndex = 7;
            this.btnSubtractVectors.Text = "button2";
            this.btnSubtractVectors.UseVisualStyleBackColor = true;
            this.btnSubtractVectors.Click += new System.EventHandler(this.btnSubtractVectors_Click);
            // 
            // lblResultVectorAddSubtract
            // 
            this.lblResultVectorAddSubtract.AutoSize = true;
            this.lblResultVectorAddSubtract.Location = new System.Drawing.Point(292, 162);
            this.lblResultVectorAddSubtract.Name = "lblResultVectorAddSubtract";
            this.lblResultVectorAddSubtract.Size = new System.Drawing.Size(35, 13);
            this.lblResultVectorAddSubtract.TabIndex = 8;
            this.lblResultVectorAddSubtract.Text = "label1";
            // 
            // txtVector1XDot
            // 
            this.txtVector1XDot.Location = new System.Drawing.Point(32, 38);
            this.txtVector1XDot.Name = "txtVector1XDot";
            this.txtVector1XDot.Size = new System.Drawing.Size(100, 20);
            this.txtVector1XDot.TabIndex = 0;
            // 
            // txtVector1YDot
            // 
            this.txtVector1YDot.Location = new System.Drawing.Point(32, 74);
            this.txtVector1YDot.Name = "txtVector1YDot";
            this.txtVector1YDot.Size = new System.Drawing.Size(100, 20);
            this.txtVector1YDot.TabIndex = 1;
            // 
            // txtVector1ZDot
            // 
            this.txtVector1ZDot.Location = new System.Drawing.Point(32, 112);
            this.txtVector1ZDot.Name = "txtVector1ZDot";
            this.txtVector1ZDot.Size = new System.Drawing.Size(100, 20);
            this.txtVector1ZDot.TabIndex = 2;
            // 
            // txtVector2ZDot
            // 
            this.txtVector2ZDot.Location = new System.Drawing.Point(198, 112);
            this.txtVector2ZDot.Name = "txtVector2ZDot";
            this.txtVector2ZDot.Size = new System.Drawing.Size(100, 20);
            this.txtVector2ZDot.TabIndex = 5;
            // 
            // txtVector2YDot
            // 
            this.txtVector2YDot.Location = new System.Drawing.Point(198, 74);
            this.txtVector2YDot.Name = "txtVector2YDot";
            this.txtVector2YDot.Size = new System.Drawing.Size(100, 20);
            this.txtVector2YDot.TabIndex = 4;
            // 
            // txtVector2XDot
            // 
            this.txtVector2XDot.Location = new System.Drawing.Point(198, 38);
            this.txtVector2XDot.Name = "txtVector2XDot";
            this.txtVector2XDot.Size = new System.Drawing.Size(100, 20);
            this.txtVector2XDot.TabIndex = 3;
            // 
            // btnCalculateDotProduct
            // 
            this.btnCalculateDotProduct.Location = new System.Drawing.Point(135, 177);
            this.btnCalculateDotProduct.Name = "btnCalculateDotProduct";
            this.btnCalculateDotProduct.Size = new System.Drawing.Size(75, 23);
            this.btnCalculateDotProduct.TabIndex = 6;
            this.btnCalculateDotProduct.Text = "button1";
            this.btnCalculateDotProduct.UseVisualStyleBackColor = true;
            this.btnCalculateDotProduct.Click += new System.EventHandler(this.btnCalculateDotProduct_Click);
            // 
            // lblDotProductResult
            // 
            this.lblDotProductResult.AutoSize = true;
            this.lblDotProductResult.Location = new System.Drawing.Point(263, 187);
            this.lblDotProductResult.Name = "lblDotProductResult";
            this.lblDotProductResult.Size = new System.Drawing.Size(35, 13);
            this.lblDotProductResult.TabIndex = 7;
            this.lblDotProductResult.Text = "label1";
            // 
            // txtVectorXLength
            // 
            this.txtVectorXLength.Location = new System.Drawing.Point(53, 42);
            this.txtVectorXLength.Name = "txtVectorXLength";
            this.txtVectorXLength.Size = new System.Drawing.Size(100, 20);
            this.txtVectorXLength.TabIndex = 0;
            // 
            // txtVectorYLength
            // 
            this.txtVectorYLength.Location = new System.Drawing.Point(53, 92);
            this.txtVectorYLength.Name = "txtVectorYLength";
            this.txtVectorYLength.Size = new System.Drawing.Size(100, 20);
            this.txtVectorYLength.TabIndex = 1;
            // 
            // txtVectorZLength
            // 
            this.txtVectorZLength.Location = new System.Drawing.Point(53, 139);
            this.txtVectorZLength.Name = "txtVectorZLength";
            this.txtVectorZLength.Size = new System.Drawing.Size(100, 20);
            this.txtVectorZLength.TabIndex = 2;
            // 
            // btnCalculateVectorLength
            // 
            this.btnCalculateVectorLength.Location = new System.Drawing.Point(78, 199);
            this.btnCalculateVectorLength.Name = "btnCalculateVectorLength";
            this.btnCalculateVectorLength.Size = new System.Drawing.Size(75, 23);
            this.btnCalculateVectorLength.TabIndex = 3;
            this.btnCalculateVectorLength.Text = "button1";
            this.btnCalculateVectorLength.UseVisualStyleBackColor = true;
            this.btnCalculateVectorLength.Click += new System.EventHandler(this.btnCalculateVectorLength_Click);
            // 
            // lblVectorLengthResult
            // 
            this.lblVectorLengthResult.AutoSize = true;
            this.lblVectorLengthResult.Location = new System.Drawing.Point(199, 209);
            this.lblVectorLengthResult.Name = "lblVectorLengthResult";
            this.lblVectorLengthResult.Size = new System.Drawing.Size(35, 13);
            this.lblVectorLengthResult.TabIndex = 4;
            this.lblVectorLengthResult.Text = "label1";
            // 
            // txtVector1XCosine
            // 
            this.txtVector1XCosine.Location = new System.Drawing.Point(55, 55);
            this.txtVector1XCosine.Name = "txtVector1XCosine";
            this.txtVector1XCosine.Size = new System.Drawing.Size(100, 20);
            this.txtVector1XCosine.TabIndex = 0;
            // 
            // txtVector1YCosine
            // 
            this.txtVector1YCosine.Location = new System.Drawing.Point(55, 118);
            this.txtVector1YCosine.Name = "txtVector1YCosine";
            this.txtVector1YCosine.Size = new System.Drawing.Size(100, 20);
            this.txtVector1YCosine.TabIndex = 1;
            // 
            // txtVector1ZCosine
            // 
            this.txtVector1ZCosine.Location = new System.Drawing.Point(55, 173);
            this.txtVector1ZCosine.Name = "txtVector1ZCosine";
            this.txtVector1ZCosine.Size = new System.Drawing.Size(100, 20);
            this.txtVector1ZCosine.TabIndex = 2;
            // 
            // txtVector2ZCosine
            // 
            this.txtVector2ZCosine.Location = new System.Drawing.Point(200, 173);
            this.txtVector2ZCosine.Name = "txtVector2ZCosine";
            this.txtVector2ZCosine.Size = new System.Drawing.Size(100, 20);
            this.txtVector2ZCosine.TabIndex = 5;
            // 
            // txtVector2YCosine
            // 
            this.txtVector2YCosine.Location = new System.Drawing.Point(200, 118);
            this.txtVector2YCosine.Name = "txtVector2YCosine";
            this.txtVector2YCosine.Size = new System.Drawing.Size(100, 20);
            this.txtVector2YCosine.TabIndex = 4;
            // 
            // txtVector2XCosine
            // 
            this.txtVector2XCosine.Location = new System.Drawing.Point(200, 55);
            this.txtVector2XCosine.Name = "txtVector2XCosine";
            this.txtVector2XCosine.Size = new System.Drawing.Size(100, 20);
            this.txtVector2XCosine.TabIndex = 3;
            // 
            // btnCalculateAngleCosine
            // 
            this.btnCalculateAngleCosine.Location = new System.Drawing.Point(80, 244);
            this.btnCalculateAngleCosine.Name = "btnCalculateAngleCosine";
            this.btnCalculateAngleCosine.Size = new System.Drawing.Size(75, 23);
            this.btnCalculateAngleCosine.TabIndex = 6;
            this.btnCalculateAngleCosine.Text = "button1";
            this.btnCalculateAngleCosine.UseVisualStyleBackColor = true;
            this.btnCalculateAngleCosine.Click += new System.EventHandler(this.btnCalculateAngleCosine_Click);
            // 
            // lblAngleCosineResult
            // 
            this.lblAngleCosineResult.AutoSize = true;
            this.lblAngleCosineResult.Location = new System.Drawing.Point(256, 254);
            this.lblAngleCosineResult.Name = "lblAngleCosineResult";
            this.lblAngleCosineResult.Size = new System.Drawing.Size(35, 13);
            this.lblAngleCosineResult.TabIndex = 7;
            this.lblAngleCosineResult.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lblResultVectorAddSubtract;
        private System.Windows.Forms.Button btnSubtractVectors;
        private System.Windows.Forms.Button btnAddVectors;
        private System.Windows.Forms.TextBox txtVector2ZAddSubtract;
        private System.Windows.Forms.TextBox txtVector1ZAddSubtract;
        private System.Windows.Forms.TextBox txtVector2YAddSubtract;
        private System.Windows.Forms.TextBox txtVector2XAddSubtract;
        private System.Windows.Forms.TextBox txtVector1YAddSubtract;
        private System.Windows.Forms.TextBox txtVector1XAddSubtract;
        private System.Windows.Forms.Label lblDotProductResult;
        private System.Windows.Forms.Button btnCalculateDotProduct;
        private System.Windows.Forms.TextBox txtVector2ZDot;
        private System.Windows.Forms.TextBox txtVector2YDot;
        private System.Windows.Forms.TextBox txtVector2XDot;
        private System.Windows.Forms.TextBox txtVector1ZDot;
        private System.Windows.Forms.TextBox txtVector1YDot;
        private System.Windows.Forms.TextBox txtVector1XDot;
        private System.Windows.Forms.Label lblVectorLengthResult;
        private System.Windows.Forms.Button btnCalculateVectorLength;
        private System.Windows.Forms.TextBox txtVectorZLength;
        private System.Windows.Forms.TextBox txtVectorYLength;
        private System.Windows.Forms.TextBox txtVectorXLength;
        private System.Windows.Forms.Label lblAngleCosineResult;
        private System.Windows.Forms.Button btnCalculateAngleCosine;
        private System.Windows.Forms.TextBox txtVector2ZCosine;
        private System.Windows.Forms.TextBox txtVector2YCosine;
        private System.Windows.Forms.TextBox txtVector2XCosine;
        private System.Windows.Forms.TextBox txtVector1ZCosine;
        private System.Windows.Forms.TextBox txtVector1YCosine;
        private System.Windows.Forms.TextBox txtVector1XCosine;
    }
}

