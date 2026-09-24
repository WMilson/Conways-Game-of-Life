namespace Life
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
            DGV1 = new DataGridView();
            DGV2 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            initializeButton = new Button();
            stepButton = new Button();
            toggleTimerButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)DGV1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV2).BeginInit();
            SuspendLayout();
            // 
            // DGV1
            // 
            DGV1.AllowUserToResizeColumns = false;
            DGV1.AllowUserToResizeRows = false;
            DGV1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV1.ColumnHeadersVisible = false;
            DGV1.Location = new Point(36, 50);
            DGV1.Margin = new Padding(5);
            DGV1.Name = "DGV1";
            DGV1.RowHeadersVisible = false;
            DGV1.RowHeadersWidth = 51;
            DGV1.ScrollBars = ScrollBars.None;
            DGV1.Size = new Size(683, 717);
            DGV1.TabIndex = 0;
            DGV1.CellClick += DGV1_CellClick_1;
            // 
            // DGV2
            // 
            DGV2.AllowUserToResizeColumns = false;
            DGV2.AllowUserToResizeRows = false;
            DGV2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV2.ColumnHeadersVisible = false;
            DGV2.Location = new Point(855, 50);
            DGV2.Margin = new Padding(5);
            DGV2.Name = "DGV2";
            DGV2.RowHeadersVisible = false;
            DGV2.RowHeadersWidth = 51;
            DGV2.ScrollBars = ScrollBars.None;
            DGV2.Size = new Size(672, 717);
            DGV2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 803);
            label1.Name = "label1";
            label1.Size = new Size(193, 25);
            label1.TabIndex = 2;
            label1.Text = "Количество жителей";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 847);
            label2.Name = "label2";
            label2.Size = new Size(122, 25);
            label2.TabIndex = 3;
            label2.Text = "Размер поля";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(288, 803);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 32);
            textBox1.TabIndex = 4;
            textBox1.Text = "20";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(288, 844);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 32);
            textBox2.TabIndex = 5;
            textBox2.Text = "10";
            // 
            // initializeButton
            // 
            initializeButton.Location = new Point(472, 799);
            initializeButton.Name = "initializeButton";
            initializeButton.Size = new Size(205, 77);
            initializeButton.TabIndex = 6;
            initializeButton.Text = "Заселить";
            initializeButton.UseVisualStyleBackColor = true;
            initializeButton.Click += initializeButton_Click;
            // 
            // stepButton
            // 
            stepButton.Location = new Point(683, 799);
            stepButton.Name = "stepButton";
            stepButton.Size = new Size(205, 77);
            stepButton.TabIndex = 7;
            stepButton.Text = "Шаг";
            stepButton.UseVisualStyleBackColor = true;
            stepButton.Click += stepButton_Click;
            // 
            // toggleTimerButton
            // 
            toggleTimerButton.Location = new Point(894, 799);
            toggleTimerButton.Name = "toggleTimerButton";
            toggleTimerButton.Size = new Size(205, 77);
            toggleTimerButton.TabIndex = 8;
            toggleTimerButton.Text = "Жизнь";
            toggleTimerButton.UseVisualStyleBackColor = true;
            toggleTimerButton.Click += toggleTimerButton_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1621, 895);
            Controls.Add(toggleTimerButton);
            Controls.Add(stepButton);
            Controls.Add(initializeButton);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DGV2);
            Controls.Add(DGV1);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DGV1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGV2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGV1;
        private DataGridView DGV2;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button initializeButton;
        private Button stepButton;
        private Button toggleTimerButton;
        private System.Windows.Forms.Timer timer1;
    }
}
