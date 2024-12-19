namespace Calculator
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            tableLayoutPanel1 = new TableLayoutPanel();
            txtDisplay = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            buttonDot = new Button();
            buttonDivide = new Button();
            buttonEqual = new Button();
            buttonZero = new Button();
            buttonPlus = new Button();
            buttonThree = new Button();
            buttonTwo = new Button();
            buttonOne = new Button();
            buttonMinus = new Button();
            buttonSix = new Button();
            buttonFive = new Button();
            buttonFour = new Button();
            buttonMultiply = new Button();
            buttonNine = new Button();
            buttonEight = new Button();
            buttonSeven = new Button();
            buttonClear = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(txtDisplay, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2602491F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85.73975F));
            tableLayoutPanel1.Size = new Size(612, 562);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // txtDisplay
            // 
            txtDisplay.Anchor = AnchorStyles.Right;
            txtDisplay.BackColor = Color.LightCyan;
            txtDisplay.BorderStyle = BorderStyle.FixedSingle;
            txtDisplay.Cursor = Cursors.No;
            txtDisplay.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDisplay.Location = new Point(3, 3);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(606, 74);
            txtDisplay.TabIndex = 0;
            txtDisplay.Text = " ";
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            txtDisplay.TextChanged += txtDisplay_TextChanged;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(buttonDot, 2, 4);
            tableLayoutPanel2.Controls.Add(buttonDivide, 3, 0);
            tableLayoutPanel2.Controls.Add(buttonEqual, 3, 4);
            tableLayoutPanel2.Controls.Add(buttonZero, 1, 4);
            tableLayoutPanel2.Controls.Add(buttonPlus, 3, 3);
            tableLayoutPanel2.Controls.Add(buttonThree, 2, 3);
            tableLayoutPanel2.Controls.Add(buttonTwo, 1, 3);
            tableLayoutPanel2.Controls.Add(buttonOne, 0, 3);
            tableLayoutPanel2.Controls.Add(buttonMinus, 3, 2);
            tableLayoutPanel2.Controls.Add(buttonSix, 2, 2);
            tableLayoutPanel2.Controls.Add(buttonFive, 1, 2);
            tableLayoutPanel2.Controls.Add(buttonFour, 0, 2);
            tableLayoutPanel2.Controls.Add(buttonMultiply, 3, 1);
            tableLayoutPanel2.Controls.Add(buttonNine, 2, 1);
            tableLayoutPanel2.Controls.Add(buttonEight, 1, 1);
            tableLayoutPanel2.Controls.Add(buttonSeven, 0, 1);
            tableLayoutPanel2.Controls.Add(buttonClear, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 83);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(606, 476);
            tableLayoutPanel2.TabIndex = 1;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // buttonDot
            // 
            buttonDot.AccessibleName = "";
            buttonDot.BackColor = Color.SteelBlue;
            buttonDot.Dock = DockStyle.Fill;
            buttonDot.FlatStyle = FlatStyle.Popup;
            buttonDot.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDot.Location = new Point(305, 383);
            buttonDot.Name = "buttonDot";
            buttonDot.RightToLeft = RightToLeft.No;
            buttonDot.Size = new Size(145, 90);
            buttonDot.TabIndex = 26;
            buttonDot.Text = ".";
            buttonDot.UseVisualStyleBackColor = false;
            buttonDot.Click += buttonDot_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.AccessibleName = "";
            buttonDivide.BackColor = SystemColors.ActiveCaption;
            buttonDivide.Dock = DockStyle.Fill;
            buttonDivide.FlatStyle = FlatStyle.Popup;
            buttonDivide.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDivide.Location = new Point(456, 3);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.RightToLeft = RightToLeft.No;
            buttonDivide.Size = new Size(147, 89);
            buttonDivide.TabIndex = 22;
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = false;
            buttonDivide.Click += buttonDivide_Click;
            // 
            // buttonEqual
            // 
            buttonEqual.AccessibleName = "";
            buttonEqual.BackColor = SystemColors.HotTrack;
            buttonEqual.Dock = DockStyle.Fill;
            buttonEqual.FlatStyle = FlatStyle.Popup;
            buttonEqual.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEqual.Location = new Point(456, 383);
            buttonEqual.Name = "buttonEqual";
            buttonEqual.RightToLeft = RightToLeft.No;
            buttonEqual.Size = new Size(147, 90);
            buttonEqual.TabIndex = 19;
            buttonEqual.Text = "=";
            buttonEqual.UseVisualStyleBackColor = false;
            buttonEqual.Click += buttonEqual_Click;
            // 
            // buttonZero
            // 
            buttonZero.AccessibleName = "";
            buttonZero.BackColor = Color.SteelBlue;
            buttonZero.Dock = DockStyle.Fill;
            buttonZero.FlatStyle = FlatStyle.Popup;
            buttonZero.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonZero.Location = new Point(154, 383);
            buttonZero.Name = "buttonZero";
            buttonZero.RightToLeft = RightToLeft.No;
            buttonZero.Size = new Size(145, 90);
            buttonZero.TabIndex = 17;
            buttonZero.Text = "0";
            buttonZero.UseVisualStyleBackColor = false;
            buttonZero.Click += buttonZero_Click;
            // 
            // buttonPlus
            // 
            buttonPlus.AccessibleName = "";
            buttonPlus.BackColor = SystemColors.ActiveCaption;
            buttonPlus.Dock = DockStyle.Fill;
            buttonPlus.FlatStyle = FlatStyle.Popup;
            buttonPlus.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPlus.Location = new Point(456, 288);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.RightToLeft = RightToLeft.No;
            buttonPlus.Size = new Size(147, 89);
            buttonPlus.TabIndex = 15;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = false;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // buttonThree
            // 
            buttonThree.AccessibleName = "";
            buttonThree.BackColor = Color.SteelBlue;
            buttonThree.Dock = DockStyle.Fill;
            buttonThree.FlatStyle = FlatStyle.Popup;
            buttonThree.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonThree.Location = new Point(305, 288);
            buttonThree.Name = "buttonThree";
            buttonThree.RightToLeft = RightToLeft.No;
            buttonThree.Size = new Size(145, 89);
            buttonThree.TabIndex = 14;
            buttonThree.Text = "3";
            buttonThree.UseVisualStyleBackColor = false;
            buttonThree.Click += buttonThree_Click;
            // 
            // buttonTwo
            // 
            buttonTwo.AccessibleName = "";
            buttonTwo.BackColor = Color.SteelBlue;
            buttonTwo.Dock = DockStyle.Fill;
            buttonTwo.FlatStyle = FlatStyle.Popup;
            buttonTwo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTwo.Location = new Point(154, 288);
            buttonTwo.Name = "buttonTwo";
            buttonTwo.RightToLeft = RightToLeft.No;
            buttonTwo.Size = new Size(145, 89);
            buttonTwo.TabIndex = 13;
            buttonTwo.Text = "2";
            buttonTwo.UseVisualStyleBackColor = false;
            buttonTwo.Click += buttonTwo_Click;
            // 
            // buttonOne
            // 
            buttonOne.AccessibleName = "";
            buttonOne.BackColor = Color.SteelBlue;
            buttonOne.Dock = DockStyle.Fill;
            buttonOne.FlatStyle = FlatStyle.Popup;
            buttonOne.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonOne.Location = new Point(3, 288);
            buttonOne.Name = "buttonOne";
            buttonOne.RightToLeft = RightToLeft.No;
            buttonOne.Size = new Size(145, 89);
            buttonOne.TabIndex = 12;
            buttonOne.Text = "1";
            buttonOne.UseVisualStyleBackColor = false;
            buttonOne.Click += buttonOne_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.AccessibleName = "";
            buttonMinus.BackColor = SystemColors.ActiveCaption;
            buttonMinus.Dock = DockStyle.Fill;
            buttonMinus.FlatStyle = FlatStyle.Popup;
            buttonMinus.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMinus.Location = new Point(456, 193);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.RightToLeft = RightToLeft.No;
            buttonMinus.Size = new Size(147, 89);
            buttonMinus.TabIndex = 11;
            buttonMinus.Text = "−";
            buttonMinus.UseVisualStyleBackColor = false;
            buttonMinus.Click += buttonMinus_Click;
            // 
            // buttonSix
            // 
            buttonSix.AccessibleName = "";
            buttonSix.BackColor = Color.SteelBlue;
            buttonSix.Dock = DockStyle.Fill;
            buttonSix.FlatStyle = FlatStyle.Popup;
            buttonSix.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSix.Location = new Point(305, 193);
            buttonSix.Name = "buttonSix";
            buttonSix.RightToLeft = RightToLeft.No;
            buttonSix.Size = new Size(145, 89);
            buttonSix.TabIndex = 10;
            buttonSix.Text = "6";
            buttonSix.UseVisualStyleBackColor = false;
            buttonSix.Click += buttonSix_Click;
            // 
            // buttonFive
            // 
            buttonFive.AccessibleName = "";
            buttonFive.BackColor = Color.SteelBlue;
            buttonFive.Dock = DockStyle.Fill;
            buttonFive.FlatStyle = FlatStyle.Popup;
            buttonFive.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonFive.Location = new Point(154, 193);
            buttonFive.Name = "buttonFive";
            buttonFive.RightToLeft = RightToLeft.No;
            buttonFive.Size = new Size(145, 89);
            buttonFive.TabIndex = 9;
            buttonFive.Text = "5";
            buttonFive.UseVisualStyleBackColor = false;
            buttonFive.Click += buttonFive_Click;
            // 
            // buttonFour
            // 
            buttonFour.AccessibleName = "";
            buttonFour.BackColor = Color.SteelBlue;
            buttonFour.Dock = DockStyle.Fill;
            buttonFour.FlatStyle = FlatStyle.Popup;
            buttonFour.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonFour.Location = new Point(3, 193);
            buttonFour.Name = "buttonFour";
            buttonFour.RightToLeft = RightToLeft.No;
            buttonFour.Size = new Size(145, 89);
            buttonFour.TabIndex = 8;
            buttonFour.Text = "4";
            buttonFour.UseVisualStyleBackColor = false;
            buttonFour.Click += buttonFour_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.AccessibleName = "";
            buttonMultiply.BackColor = SystemColors.ActiveCaption;
            buttonMultiply.Dock = DockStyle.Fill;
            buttonMultiply.FlatStyle = FlatStyle.Popup;
            buttonMultiply.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMultiply.Location = new Point(456, 98);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.RightToLeft = RightToLeft.No;
            buttonMultiply.Size = new Size(147, 89);
            buttonMultiply.TabIndex = 7;
            buttonMultiply.Text = "x";
            buttonMultiply.UseVisualStyleBackColor = false;
            buttonMultiply.Click += buttonMultiply_Click;
            // 
            // buttonNine
            // 
            buttonNine.AccessibleName = "";
            buttonNine.BackColor = Color.SteelBlue;
            buttonNine.Dock = DockStyle.Fill;
            buttonNine.FlatStyle = FlatStyle.Popup;
            buttonNine.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonNine.Location = new Point(305, 98);
            buttonNine.Name = "buttonNine";
            buttonNine.RightToLeft = RightToLeft.No;
            buttonNine.Size = new Size(145, 89);
            buttonNine.TabIndex = 6;
            buttonNine.Text = "9";
            buttonNine.UseVisualStyleBackColor = false;
            buttonNine.Click += buttonNine_Click;
            // 
            // buttonEight
            // 
            buttonEight.AccessibleName = "";
            buttonEight.BackColor = Color.SteelBlue;
            buttonEight.Dock = DockStyle.Fill;
            buttonEight.FlatStyle = FlatStyle.Popup;
            buttonEight.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEight.Location = new Point(154, 98);
            buttonEight.Name = "buttonEight";
            buttonEight.RightToLeft = RightToLeft.No;
            buttonEight.Size = new Size(145, 89);
            buttonEight.TabIndex = 5;
            buttonEight.Text = "8";
            buttonEight.UseVisualStyleBackColor = false;
            buttonEight.Click += buttonEight_Click;
            // 
            // buttonSeven
            // 
            buttonSeven.AccessibleName = "";
            buttonSeven.BackColor = Color.SteelBlue;
            buttonSeven.Dock = DockStyle.Fill;
            buttonSeven.FlatStyle = FlatStyle.Popup;
            buttonSeven.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSeven.Location = new Point(3, 98);
            buttonSeven.Name = "buttonSeven";
            buttonSeven.RightToLeft = RightToLeft.No;
            buttonSeven.Size = new Size(145, 89);
            buttonSeven.TabIndex = 4;
            buttonSeven.Text = "7";
            buttonSeven.UseVisualStyleBackColor = false;
            buttonSeven.Click += buttonSeven_Click;
            // 
            // buttonClear
            // 
            buttonClear.AccessibleName = "";
            buttonClear.BackColor = SystemColors.WindowFrame;
            buttonClear.Dock = DockStyle.Fill;
            buttonClear.FlatStyle = FlatStyle.Popup;
            buttonClear.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonClear.Location = new Point(3, 3);
            buttonClear.Name = "buttonClear";
            buttonClear.RightToLeft = RightToLeft.No;
            buttonClear.Size = new Size(145, 89);
            buttonClear.TabIndex = 0;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AutoValidate = AutoValidate.Disable;
            BackColor = Color.SlateGray;
            ClientSize = new Size(641, 587);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.SeaShell;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Calculator";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtDisplay;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonClear;
        private Button buttonEqual;
        private Button buttonZero;
        private Button buttonPlus;
        private Button buttonThree;
        private Button buttonTwo;
        private Button buttonOne;
        private Button buttonMinus;
        private Button buttonSix;
        private Button buttonFive;
        private Button buttonFour;
        private Button buttonNine;
        private Button buttonEight;
        private Button buttonSeven;
        private Button buttonMultiply;
        private Button buttonDivide;
        private Button buttonDot;
    }
}
