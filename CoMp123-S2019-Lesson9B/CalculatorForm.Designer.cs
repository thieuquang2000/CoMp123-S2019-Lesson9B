namespace CoMp123_S2019_Lesson9B
{
    partial class CalculatorForm
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
            this.CalculatorButtonTableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.EqualsButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.ThirdButton = new System.Windows.Forms.Button();
            this.SecondButton = new System.Windows.Forms.Button();
            this.FirstButton = new System.Windows.Forms.Button();
            this.SixthButton = new System.Windows.Forms.Button();
            this.FifthButton = new System.Windows.Forms.Button();
            this.FourthButton = new System.Windows.Forms.Button();
            this.NinthButton = new System.Windows.Forms.Button();
            this.EightBtton = new System.Windows.Forms.Button();
            this.SeventhButton = new System.Windows.Forms.Button();
            this.ResultLable = new System.Windows.Forms.Label();
            this.DecimalButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.CalculatorButtonTableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalculatorButtonTableLayoutPanel1
            // 
            this.CalculatorButtonTableLayoutPanel1.ColumnCount = 4;
            this.CalculatorButtonTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorButtonTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorButtonTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorButtonTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorButtonTableLayoutPanel1.Controls.Add(this.ThirdButton, 2, 3);
            this.CalculatorButtonTableLayoutPanel1.Controls.Add(this.SecondButton, 1, 3);
            this.CalculatorButtonTableLayoutPanel1.Controls.Add(this.FirstButton, 0, 3);
            this.CalculatorButtonTableLayoutPanel1.Controls.Add(this.FourthButton, 0, 2);
            this.CalculatorButtonTableLayoutPanel1.Controls.Add(this.FifthButton, 1, 2);
            this.CalculatorButtonTableLayoutPanel1.Controls.Add(this.SixthButton, 2, 2);
            this.CalculatorButtonTableLayoutPanel1.Controls.Add(this.NinthButton, 2, 1);
            this.CalculatorButtonTableLayoutPanel1.Controls.Add(this.EightBtton, 1, 1);
            this.CalculatorButtonTableLayoutPanel1.Controls.Add(this.SeventhButton, 0, 1);
            this.CalculatorButtonTableLayoutPanel1.Controls.Add(this.ResultLable, 0, 0);
            this.CalculatorButtonTableLayoutPanel1.Controls.Add(this.DecimalButton, 2, 4);
            this.CalculatorButtonTableLayoutPanel1.Controls.Add(this.ClearButton, 3, 2);
            this.CalculatorButtonTableLayoutPanel1.Controls.Add(this.BackButton, 3, 1);
            this.CalculatorButtonTableLayoutPanel1.Controls.Add(this.ZeroButton, 0, 4);
            this.CalculatorButtonTableLayoutPanel1.Controls.Add(this.EqualsButton, 3, 3);
            this.CalculatorButtonTableLayoutPanel1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculatorButtonTableLayoutPanel1.Location = new System.Drawing.Point(12, 190);
            this.CalculatorButtonTableLayoutPanel1.Name = "CalculatorButtonTableLayoutPanel1";
            this.CalculatorButtonTableLayoutPanel1.RowCount = 5;
            this.CalculatorButtonTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorButtonTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorButtonTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorButtonTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorButtonTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorButtonTableLayoutPanel1.Size = new System.Drawing.Size(280, 239);
            this.CalculatorButtonTableLayoutPanel1.TabIndex = 0;
            // 
            // EqualsButton
            // 
            this.EqualsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EqualsButton.BackColor = System.Drawing.Color.SeaGreen;
            this.EqualsButton.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EqualsButton.Location = new System.Drawing.Point(213, 144);
            this.EqualsButton.Name = "EqualsButton";
            this.CalculatorButtonTableLayoutPanel1.SetRowSpan(this.EqualsButton, 2);
            this.EqualsButton.Size = new System.Drawing.Size(64, 92);
            this.EqualsButton.TabIndex = 11;
            this.EqualsButton.Tag = "result";
            this.EqualsButton.Text = "Done";
            this.EqualsButton.UseVisualStyleBackColor = false;
            this.EqualsButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ZeroButton.BackColor = System.Drawing.Color.SteelBlue;
            this.CalculatorButtonTableLayoutPanel1.SetColumnSpan(this.ZeroButton, 2);
            this.ZeroButton.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZeroButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ZeroButton.Location = new System.Drawing.Point(3, 191);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(134, 45);
            this.ZeroButton.TabIndex = 10;
            this.ZeroButton.Tag = "0";
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = false;
            this.ZeroButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // ThirdButton
            // 
            this.ThirdButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ThirdButton.BackColor = System.Drawing.Color.SteelBlue;
            this.ThirdButton.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThirdButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ThirdButton.Location = new System.Drawing.Point(143, 144);
            this.ThirdButton.Name = "ThirdButton";
            this.ThirdButton.Size = new System.Drawing.Size(64, 41);
            this.ThirdButton.TabIndex = 8;
            this.ThirdButton.Tag = "3";
            this.ThirdButton.Text = "3";
            this.ThirdButton.UseVisualStyleBackColor = false;
            this.ThirdButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // SecondButton
            // 
            this.SecondButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SecondButton.BackColor = System.Drawing.Color.SteelBlue;
            this.SecondButton.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SecondButton.Location = new System.Drawing.Point(73, 144);
            this.SecondButton.Name = "SecondButton";
            this.SecondButton.Size = new System.Drawing.Size(64, 41);
            this.SecondButton.TabIndex = 7;
            this.SecondButton.Tag = "2";
            this.SecondButton.Text = "2";
            this.SecondButton.UseVisualStyleBackColor = false;
            this.SecondButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // FirstButton
            // 
            this.FirstButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstButton.BackColor = System.Drawing.Color.SteelBlue;
            this.FirstButton.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FirstButton.Location = new System.Drawing.Point(3, 144);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Size = new System.Drawing.Size(64, 41);
            this.FirstButton.TabIndex = 6;
            this.FirstButton.Tag = "1";
            this.FirstButton.Text = "1";
            this.FirstButton.UseVisualStyleBackColor = false;
            this.FirstButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // SixthButton
            // 
            this.SixthButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SixthButton.BackColor = System.Drawing.Color.SteelBlue;
            this.SixthButton.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SixthButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SixthButton.Location = new System.Drawing.Point(143, 97);
            this.SixthButton.Name = "SixthButton";
            this.SixthButton.Size = new System.Drawing.Size(64, 41);
            this.SixthButton.TabIndex = 5;
            this.SixthButton.Tag = "6";
            this.SixthButton.Text = "6";
            this.SixthButton.UseVisualStyleBackColor = false;
            this.SixthButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // FifthButton
            // 
            this.FifthButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FifthButton.BackColor = System.Drawing.Color.SteelBlue;
            this.FifthButton.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FifthButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FifthButton.Location = new System.Drawing.Point(73, 97);
            this.FifthButton.Name = "FifthButton";
            this.FifthButton.Size = new System.Drawing.Size(64, 41);
            this.FifthButton.TabIndex = 4;
            this.FifthButton.Tag = "5";
            this.FifthButton.Text = "5";
            this.FifthButton.UseVisualStyleBackColor = false;
            this.FifthButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // FourthButton
            // 
            this.FourthButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FourthButton.BackColor = System.Drawing.Color.SteelBlue;
            this.FourthButton.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FourthButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FourthButton.Location = new System.Drawing.Point(3, 97);
            this.FourthButton.Name = "FourthButton";
            this.FourthButton.Size = new System.Drawing.Size(64, 41);
            this.FourthButton.TabIndex = 3;
            this.FourthButton.Tag = "4";
            this.FourthButton.Text = "4";
            this.FourthButton.UseVisualStyleBackColor = false;
            this.FourthButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // NinthButton
            // 
            this.NinthButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NinthButton.BackColor = System.Drawing.Color.SteelBlue;
            this.NinthButton.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NinthButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NinthButton.Location = new System.Drawing.Point(143, 50);
            this.NinthButton.Name = "NinthButton";
            this.NinthButton.Size = new System.Drawing.Size(64, 41);
            this.NinthButton.TabIndex = 2;
            this.NinthButton.Tag = "9";
            this.NinthButton.Text = "9";
            this.NinthButton.UseVisualStyleBackColor = false;
            this.NinthButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // EightBtton
            // 
            this.EightBtton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EightBtton.BackColor = System.Drawing.Color.SteelBlue;
            this.EightBtton.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EightBtton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EightBtton.Location = new System.Drawing.Point(73, 50);
            this.EightBtton.Name = "EightBtton";
            this.EightBtton.Size = new System.Drawing.Size(64, 41);
            this.EightBtton.TabIndex = 1;
            this.EightBtton.Tag = "8";
            this.EightBtton.Text = "8";
            this.EightBtton.UseVisualStyleBackColor = false;
            this.EightBtton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // SeventhButton
            // 
            this.SeventhButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SeventhButton.BackColor = System.Drawing.Color.SteelBlue;
            this.SeventhButton.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeventhButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SeventhButton.Location = new System.Drawing.Point(3, 50);
            this.SeventhButton.Name = "SeventhButton";
            this.SeventhButton.Size = new System.Drawing.Size(64, 41);
            this.SeventhButton.TabIndex = 0;
            this.SeventhButton.Tag = "7";
            this.SeventhButton.Text = "7";
            this.SeventhButton.UseVisualStyleBackColor = false;
            this.SeventhButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // ResultLable
            // 
            this.ResultLable.BackColor = System.Drawing.Color.White;
            this.CalculatorButtonTableLayoutPanel1.SetColumnSpan(this.ResultLable, 4);
            this.ResultLable.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLable.Location = new System.Drawing.Point(3, 0);
            this.ResultLable.Name = "ResultLable";
            this.ResultLable.Size = new System.Drawing.Size(274, 47);
            this.ResultLable.TabIndex = 12;
            this.ResultLable.Text = "0";
            this.ResultLable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DecimalButton
            // 
            this.DecimalButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DecimalButton.BackColor = System.Drawing.Color.SteelBlue;
            this.DecimalButton.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecimalButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DecimalButton.Location = new System.Drawing.Point(143, 191);
            this.DecimalButton.Name = "DecimalButton";
            this.DecimalButton.Size = new System.Drawing.Size(64, 45);
            this.DecimalButton.TabIndex = 13;
            this.DecimalButton.Tag = "decimal";
            this.DecimalButton.Text = ".";
            this.DecimalButton.UseVisualStyleBackColor = false;
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearButton.BackColor = System.Drawing.Color.Orange;
            this.ClearButton.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClearButton.Location = new System.Drawing.Point(213, 97);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(64, 41);
            this.ClearButton.TabIndex = 14;
            this.ClearButton.Tag = "clear";
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackButton.BackColor = System.Drawing.Color.SteelBlue;
            this.BackButton.BackgroundImage = global::CoMp123_S2019_Lesson9B.Properties.Resources.backbutton;
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackButton.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackButton.Location = new System.Drawing.Point(213, 50);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(64, 41);
            this.BackButton.TabIndex = 15;
            this.BackButton.Tag = "back";
            this.BackButton.UseVisualStyleBackColor = false;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.CalculatorButtonTableLayoutPanel1);
            this.Name = "CalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.CalculatorButtonTableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel CalculatorButtonTableLayoutPanel1;
        private System.Windows.Forms.Button EqualsButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button ThirdButton;
        private System.Windows.Forms.Button SecondButton;
        private System.Windows.Forms.Button FirstButton;
        private System.Windows.Forms.Button SixthButton;
        private System.Windows.Forms.Button FifthButton;
        private System.Windows.Forms.Button FourthButton;
        private System.Windows.Forms.Button NinthButton;
        private System.Windows.Forms.Button EightBtton;
        private System.Windows.Forms.Button SeventhButton;
        private System.Windows.Forms.Label ResultLable;
        private System.Windows.Forms.Button DecimalButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button BackButton;
    }
}

