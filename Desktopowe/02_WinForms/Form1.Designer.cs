namespace _01_Forms
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            buttonBye = new Button();
            dateNow = new Button();
            timeNow = new Button();
            labelResult = new Label();
            buttonNWD = new Button();
            buttonNWW = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(236, 219);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(32, 32);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.Location = new Point(142, 177);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(215, 39);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(142, 254);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(215, 39);
            textBox2.TabIndex = 4;
            // 
            // buttonBye
            // 
            buttonBye.Location = new Point(202, 51);
            buttonBye.Name = "buttonBye";
            buttonBye.Size = new Size(106, 74);
            buttonBye.TabIndex = 5;
            buttonBye.Text = "Bye";
            buttonBye.UseVisualStyleBackColor = true;
            buttonBye.Click += buttomBye_Click;
            // 
            // dateNow
            // 
            dateNow.Location = new Point(74, 506);
            dateNow.Name = "dateNow";
            dateNow.Size = new Size(162, 73);
            dateNow.TabIndex = 6;
            dateNow.Text = "Date";
            dateNow.UseVisualStyleBackColor = true;
            dateNow.Click += dateNow_Click;
            // 
            // timeNow
            // 
            timeNow.Location = new Point(260, 506);
            timeNow.Name = "timeNow";
            timeNow.Size = new Size(162, 73);
            timeNow.TabIndex = 7;
            timeNow.Text = "Time";
            timeNow.UseVisualStyleBackColor = true;
            timeNow.Click += timeNow_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelResult.Location = new Point(202, 436);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(98, 37);
            labelResult.TabIndex = 8;
            labelResult.Text = "Wynik";
            labelResult.Click += label2_Click;
            // 
            // buttonNWD
            // 
            buttonNWD.Location = new Point(74, 339);
            buttonNWD.Name = "buttonNWD";
            buttonNWD.Size = new Size(162, 57);
            buttonNWD.TabIndex = 9;
            buttonNWD.Text = "NWD";
            buttonNWD.UseVisualStyleBackColor = true;
            buttonNWD.Click += buttonNWD_Click;
            // 
            // buttonNWW
            // 
            buttonNWW.Location = new Point(260, 339);
            buttonNWW.Name = "buttonNWW";
            buttonNWW.Size = new Size(162, 57);
            buttonNWW.TabIndex = 10;
            buttonNWW.Text = "NWW";
            buttonNWW.UseVisualStyleBackColor = true;
            buttonNWW.Click += buttonNWW_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(500, 632);
            Controls.Add(buttonNWW);
            Controls.Add(buttonNWD);
            Controls.Add(labelResult);
            Controls.Add(timeNow);
            Controls.Add(dateNow);
            Controls.Add(buttonBye);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Name = "Form1";
            Text = "Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button buttonBye;
        private Button dateNow;
        private Button timeNow;
        private Label labelResult;
        private Button buttonNWD;
        private Button buttonNWW;
    }
}
