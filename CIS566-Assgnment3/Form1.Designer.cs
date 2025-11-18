namespace CIS566_Assgnment3
{
    partial class Form1
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
            inputBox = new TextBox();
            label1 = new Label();
            resultBox = new TextBox();
            conversionBox = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // inputBox
            // 
            inputBox.Location = new Point(104, 74);
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(100, 23);
            inputBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(241, 76);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 1;
            label1.Text = "Kilometers";
            label1.Click += label1_Click;
            // 
            // resultBox
            // 
            resultBox.BackColor = SystemColors.ControlLight;
            resultBox.Location = new Point(104, 133);
            resultBox.Name = "resultBox";
            resultBox.Size = new Size(100, 23);
            resultBox.TabIndex = 2;
            // 
            // conversionBox
            // 
            conversionBox.FormattingEnabled = true;
            conversionBox.Items.AddRange(new object[] { "Miles", "Yards", "Feet" });
            conversionBox.Location = new Point(241, 133);
            conversionBox.Name = "conversionBox";
            conversionBox.Size = new Size(121, 23);
            conversionBox.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(105, 190);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Convert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(conversionBox);
            Controls.Add(resultBox);
            Controls.Add(label1);
            Controls.Add(inputBox);
            Name = "Form1";
            Text = "0";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputBox;
        private Label label1;
        private TextBox resultBox;
        private ComboBox conversionBox;
        private Button button1;
    }
}