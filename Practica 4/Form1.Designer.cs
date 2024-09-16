namespace Practica_4
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
            fileBox = new ListBox();
            fifoBox = new ListBox();
            sjfBox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            prioridadesBox = new ListBox();
            label4 = new Label();
            rrBox = new ListBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // fileBox
            // 
            fileBox.FormattingEnabled = true;
            fileBox.Location = new Point(14, 45);
            fileBox.Name = "fileBox";
            fileBox.Size = new Size(416, 464);
            fileBox.TabIndex = 0;
            // 
            // fifoBox
            // 
            fifoBox.FormattingEnabled = true;
            fifoBox.Location = new Point(436, 45);
            fifoBox.Name = "fifoBox";
            fifoBox.Size = new Size(416, 464);
            fifoBox.TabIndex = 1;
            // 
            // sjfBox
            // 
            sjfBox.FormattingEnabled = true;
            sjfBox.Location = new Point(860, 45);
            sjfBox.Name = "sjfBox";
            sjfBox.Size = new Size(414, 464);
            sjfBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 22);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 3;
            label1.Text = "Procesos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(436, 22);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 4;
            label2.Text = "First in first out";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(860, 22);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 5;
            label3.Text = "Shortest Job First";
            // 
            // prioridadesBox
            // 
            prioridadesBox.FormattingEnabled = true;
            prioridadesBox.Location = new Point(14, 552);
            prioridadesBox.Name = "prioridadesBox";
            prioridadesBox.Size = new Size(416, 464);
            prioridadesBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 529);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 7;
            label4.Text = "Prioridades";
            // 
            // rrBox
            // 
            rrBox.FormattingEnabled = true;
            rrBox.Location = new Point(436, 552);
            rrBox.Name = "rrBox";
            rrBox.Size = new Size(416, 464);
            rrBox.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(436, 529);
            label5.Name = "label5";
            label5.Size = new Size(146, 20);
            label5.TabIndex = 9;
            label5.Text = "Round robin con fifo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1288, 1053);
            Controls.Add(label5);
            Controls.Add(rrBox);
            Controls.Add(label4);
            Controls.Add(prioridadesBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(sjfBox);
            Controls.Add(fifoBox);
            Controls.Add(fileBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox fileBox;
        private ListBox fifoBox;
        private ListBox sjfBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox prioridadesBox;
        private Label label4;
        private ListBox rrBox;
        private Label label5;
    }
}
