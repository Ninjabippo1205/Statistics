namespace pAttacks
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
            pValue = new NumericUpDown();
            picBox = new PictureBox();
            label3 = new Label();
            mSystems = new NumericUpDown();
            label4 = new Label();
            A = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mSystems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)A).BeginInit();
            SuspendLayout();
            // 
            // nValue
            // 
            nValue.Location = new Point(151, 10);
            nValue.Margin = new Padding(3, 2, 3, 2);
            nValue.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nValue.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nValue.Name = "nValue";
            nValue.Size = new Size(110, 35);
            nValue.TabIndex = 1;
            nValue.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cancBT
            // 
            cancBT.BackColor = Color.DarkGray;
            cancBT.Location = new Point(1740, 12);
            cancBT.Margin = new Padding(3, 2, 3, 2);
            cancBT.Name = "cancBT";
            cancBT.Size = new Size(115, 44);
            cancBT.TabIndex = 3;
            cancBT.Text = "Cancel";
            cancBT.UseVisualStyleBackColor = false;
            cancBT.Click += cancBT_Click;
            // 
            // startBT
            // 
            startBT.BackColor = Color.DarkGray;
            startBT.ForeColor = Color.Black;
            startBT.Location = new Point(1601, 12);
            startBT.Margin = new Padding(3, 2, 3, 2);
            startBT.Name = "startBT";
            startBT.Size = new Size(115, 44);
            startBT.TabIndex = 4;
            startBT.Text = "Start";
            startBT.UseVisualStyleBackColor = false;
            startBT.Click += startBT_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 14);
            label1.Name = "label1";
            label1.Size = new Size(105, 30);
            label1.TabIndex = 6;
            label1.Text = "N attacks:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1071, 16);
            label2.Name = "label2";
            label2.Size = new Size(105, 30);
            label2.TabIndex = 7;
            label2.Text = "Choose p:";
            // 
            // pValue
            // 
            pValue.DecimalPlaces = 6;
            pValue.Increment = new decimal(new int[] { 5, 0, 0, 327680 });
            pValue.Location = new Point(1182, 14);
            pValue.Margin = new Padding(3, 2, 3, 2);
            pValue.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            pValue.Name = "pValue";
            pValue.Size = new Size(130, 35);
            pValue.TabIndex = 2;
            // 
            // picBox
            // 
            picBox.Location = new Point(12, 60);
            picBox.Margin = new Padding(3, 2, 3, 2);
            picBox.Name = "picBox";
            picBox.Size = new Size(2744, 1189);
            picBox.TabIndex = 8;
            picBox.TabStop = false;
            picBox.MouseDown += mouseDown;
            picBox.MouseMove += mouseMove;
            picBox.MouseUp += mouseUp;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(327, 16);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(116, 30);
            label3.TabIndex = 9;
            label3.Text = "M systems:";
            // 
            // mSystems
            // 
            mSystems.Location = new Point(453, 9);
            mSystems.Margin = new Padding(5, 6, 5, 6);
            mSystems.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            mSystems.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            mSystems.Name = "mSystems";
            mSystems.Size = new Size(117, 35);
            mSystems.TabIndex = 10;
            mSystems.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(650, 20);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(198, 30);
            label4.TabIndex = 11;
            label4.Text = "attack on histogram";
            label4.Click += label4_Click;
            // 
            // A
            // 
            A.Location = new Point(858, 12);
            A.Margin = new Padding(5, 6, 5, 6);
            A.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            A.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            A.Name = "A";
            A.Size = new Size(117, 35);
            A.TabIndex = 12;
            A.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // AttackForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(2770, 1260);
            Controls.Add(A);
            Controls.Add(label4);
            Controls.Add(mSystems);
            Controls.Add(label3);
            Controls.Add(picBox);
            Controls.Add(pValue);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(startBT);
            Controls.Add(cancBT);
            Controls.Add(nValue);
            ForeColor = Color.Black;
            Margin = new Padding(3, 2, 3, 2);
            Name = "AttackForm";
            Text = "Form1";
            FormClosing += closingFunc;
            ResizeEnd += resizePicBox;
            ((System.ComponentModel.ISupportInitialize)nValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)mSystems).EndInit();
            ((System.ComponentModel.ISupportInitialize)A).EndInit();
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
        public NumericUpDown pValue;
        public PictureBox picBox;
        private Label label3;
        private NumericUpDown mSystems;
        private Label label4;
        private NumericUpDown A;
    }
}