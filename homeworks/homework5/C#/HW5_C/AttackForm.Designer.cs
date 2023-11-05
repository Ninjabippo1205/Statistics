namespace lambdaAttacks
{
    partial class AttackForm
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
            nValue = new NumericUpDown();
            cancBT = new Button();
            startBT = new Button();
            label1 = new Label();
            label2 = new Label();
            bindingSource1 = new BindingSource(components);
            picBox = new PictureBox();
            label3 = new Label();
            mSystems = new NumericUpDown();
            label4 = new Label();
            A = new NumericUpDown();
            lambdaValue = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mSystems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)A).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lambdaValue).BeginInit();
            SuspendLayout();
            // 
            // nValue
            // 
            nValue.Location = new Point(100, 7);
            nValue.Margin = new Padding(2, 1, 2, 1);
            nValue.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nValue.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nValue.Name = "nValue";
            nValue.Size = new Size(73, 27);
            nValue.TabIndex = 1;
            nValue.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cancBT
            // 
            cancBT.Location = new Point(1160, 8);
            cancBT.Margin = new Padding(2, 1, 2, 1);
            cancBT.Name = "cancBT";
            cancBT.Size = new Size(76, 29);
            cancBT.TabIndex = 3;
            cancBT.Text = "Cancel";
            cancBT.UseVisualStyleBackColor = true;
            cancBT.Click += cancBT_Click;
            // 
            // startBT
            // 
            startBT.Location = new Point(1068, 8);
            startBT.Margin = new Padding(2, 1, 2, 1);
            startBT.Name = "startBT";
            startBT.Size = new Size(76, 29);
            startBT.TabIndex = 4;
            startBT.Text = "Start";
            startBT.UseVisualStyleBackColor = true;
            startBT.Click += startBT_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 11);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(23, 20);
            label1.TabIndex = 6;
            label1.Text = "N:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(714, 11);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 7;
            label2.Text = "Choose λ:";
            // 
            // picBox
            // 
            picBox.Location = new Point(9, 44);
            picBox.Margin = new Padding(2, 1, 2, 1);
            picBox.Name = "picBox";
            picBox.Size = new Size(1268, 625);
            picBox.TabIndex = 8;
            picBox.TabStop = false;
            picBox.MouseDown += mouseDown;
            picBox.MouseMove += mouseMove;
            picBox.MouseUp += mouseUp;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(218, 11);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 9;
            label3.Text = "M systems:";
            // 
            // mSystems
            // 
            mSystems.Location = new Point(304, 7);
            mSystems.Margin = new Padding(4);
            mSystems.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            mSystems.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            mSystems.Name = "mSystems";
            mSystems.Size = new Size(78, 27);
            mSystems.TabIndex = 10;
            mSystems.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(433, 13);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(141, 20);
            label4.TabIndex = 11;
            label4.Text = "attack on histogram";
            // 
            // A
            // 
            A.Location = new Point(580, 9);
            A.Margin = new Padding(4);
            A.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            A.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            A.Name = "A";
            A.Size = new Size(78, 27);
            A.TabIndex = 12;
            A.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lambdaValue
            // 
            lambdaValue.Location = new Point(792, 11);
            lambdaValue.Margin = new Padding(2, 1, 2, 1);
            lambdaValue.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            lambdaValue.Name = "lambdaValue";
            lambdaValue.Size = new Size(87, 27);
            lambdaValue.TabIndex = 2;
            lambdaValue.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // AttackForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1297, 659);
            Controls.Add(A);
            Controls.Add(label4);
            Controls.Add(mSystems);
            Controls.Add(label3);
            Controls.Add(picBox);
            Controls.Add(lambdaValue);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(startBT);
            Controls.Add(cancBT);
            Controls.Add(nValue);
            Margin = new Padding(2, 1, 2, 1);
            Name = "AttackForm";
            Text = "Form1";
            FormClosing += closingFunc;
            ResizeEnd += resizePicBox;
            ((System.ComponentModel.ISupportInitialize)nValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)mSystems).EndInit();
            ((System.ComponentModel.ISupportInitialize)A).EndInit();
            ((System.ComponentModel.ISupportInitialize)lambdaValue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public NumericUpDown nValue;
        public Button cancBT;
        public Button startBT;

        private Label label1;
        private Label label2;
        private BindingSource bindingSource1;
        public PictureBox picBox;
        private Label label3;
        private NumericUpDown mSystems;
        private Label label4;
        private NumericUpDown A;
        public NumericUpDown lambdaValue;
    }
}