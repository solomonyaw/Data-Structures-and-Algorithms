namespace AlgorithmDataStructures
{
    partial class StackandQueus
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQsize = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.queueListBox = new System.Windows.Forms.ListBox();
            this.btnDequeue = new System.Windows.Forms.Button();
            this.textElement1 = new System.Windows.Forms.TextBox();
            this.btnEnqueue = new System.Windows.Forms.Button();
            this.btnSize = new System.Windows.Forms.Button();
            this.btnPeek = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.stackListBox = new System.Windows.Forms.ListBox();
            this.btnPop = new System.Windows.Forms.Button();
            this.txtElement = new System.Windows.Forms.TextBox();
            this.btnPush = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.btnQsize);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.queueListBox);
            this.groupBox1.Controls.Add(this.btnDequeue);
            this.groupBox1.Controls.Add(this.textElement1);
            this.groupBox1.Controls.Add(this.btnEnqueue);
            this.groupBox1.Controls.Add(this.btnSize);
            this.groupBox1.Controls.Add(this.btnPeek);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.stackListBox);
            this.groupBox1.Controls.Add(this.btnPop);
            this.groupBox1.Controls.Add(this.txtElement);
            this.groupBox1.Controls.Add(this.btnPush);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-18, -45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(871, 670);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnQsize
            // 
            this.btnQsize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQsize.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnQsize.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQsize.ForeColor = System.Drawing.Color.Maroon;
            this.btnQsize.Location = new System.Drawing.Point(341, 545);
            this.btnQsize.Name = "btnQsize";
            this.btnQsize.Size = new System.Drawing.Size(182, 42);
            this.btnQsize.TabIndex = 34;
            this.btnQsize.Text = "Queue Size";
            this.btnQsize.UseVisualStyleBackColor = false;
            this.btnQsize.Click += new System.EventHandler(this.btnQsize_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Maroon;
            this.label6.Font = new System.Drawing.Font("Myriad Pro Semi bold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(116, 455);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 19);
            this.label6.TabIndex = 33;
            this.label6.Text = "Please Enter a value";
            // 
            // queueListBox
            // 
            this.queueListBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queueListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.queueListBox.FormattingEnabled = true;
            this.queueListBox.ItemHeight = 22;
            this.queueListBox.Location = new System.Drawing.Point(572, 381);
            this.queueListBox.Name = "queueListBox";
            this.queueListBox.Size = new System.Drawing.Size(117, 158);
            this.queueListBox.TabIndex = 31;
            // 
            // btnDequeue
            // 
            this.btnDequeue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDequeue.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnDequeue.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDequeue.ForeColor = System.Drawing.Color.Maroon;
            this.btnDequeue.Location = new System.Drawing.Point(341, 497);
            this.btnDequeue.Name = "btnDequeue";
            this.btnDequeue.Size = new System.Drawing.Size(182, 42);
            this.btnDequeue.TabIndex = 30;
            this.btnDequeue.Text = "Dequeue";
            this.btnDequeue.UseVisualStyleBackColor = false;
            this.btnDequeue.Click += new System.EventHandler(this.btnDequeue_Click);
            // 
            // textElement1
            // 
            this.textElement1.Location = new System.Drawing.Point(268, 454);
            this.textElement1.Name = "textElement1";
            this.textElement1.Size = new System.Drawing.Size(74, 20);
            this.textElement1.TabIndex = 28;
            // 
            // btnEnqueue
            // 
            this.btnEnqueue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEnqueue.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnEnqueue.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnqueue.ForeColor = System.Drawing.Color.Maroon;
            this.btnEnqueue.Location = new System.Drawing.Point(360, 432);
            this.btnEnqueue.Name = "btnEnqueue";
            this.btnEnqueue.Size = new System.Drawing.Size(131, 42);
            this.btnEnqueue.TabIndex = 29;
            this.btnEnqueue.Text = "Enqueue";
            this.btnEnqueue.UseVisualStyleBackColor = false;
            this.btnEnqueue.Click += new System.EventHandler(this.btnEnqueue_Click);
            // 
            // btnSize
            // 
            this.btnSize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSize.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSize.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSize.ForeColor = System.Drawing.Color.Maroon;
            this.btnSize.Location = new System.Drawing.Point(311, 288);
            this.btnSize.Name = "btnSize";
            this.btnSize.Size = new System.Drawing.Size(182, 42);
            this.btnSize.TabIndex = 26;
            this.btnSize.Text = "Size";
            this.btnSize.UseVisualStyleBackColor = false;
            this.btnSize.Click += new System.EventHandler(this.btnSize_Click);
            // 
            // btnPeek
            // 
            this.btnPeek.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPeek.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnPeek.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeek.ForeColor = System.Drawing.Color.Maroon;
            this.btnPeek.Location = new System.Drawing.Point(311, 240);
            this.btnPeek.Name = "btnPeek";
            this.btnPeek.Size = new System.Drawing.Size(182, 42);
            this.btnPeek.TabIndex = 25;
            this.btnPeek.Text = "Peek";
            this.btnPeek.UseVisualStyleBackColor = false;
            this.btnPeek.Click += new System.EventHandler(this.btnPeek_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Maroon;
            this.label5.Font = new System.Drawing.Font("Myriad Pro Semi bold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(86, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 19);
            this.label5.TabIndex = 24;
            this.label5.Text = "Please Enter a value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Maroon;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(311, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 26);
            this.label4.TabIndex = 23;
            this.label4.Text = "Implementing Queue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Maroon;
            this.label3.Font = new System.Drawing.Font("Myriad Pro Semi bold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(39, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Push Elements into of stack";
            // 
            // stackListBox
            // 
            this.stackListBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stackListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.stackListBox.FormattingEnabled = true;
            this.stackListBox.ItemHeight = 22;
            this.stackListBox.Location = new System.Drawing.Point(572, 90);
            this.stackListBox.Name = "stackListBox";
            this.stackListBox.Size = new System.Drawing.Size(117, 158);
            this.stackListBox.TabIndex = 19;
            // 
            // btnPop
            // 
            this.btnPop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPop.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnPop.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPop.ForeColor = System.Drawing.Color.Maroon;
            this.btnPop.Location = new System.Drawing.Point(311, 192);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(182, 42);
            this.btnPop.TabIndex = 18;
            this.btnPop.Text = "Pop";
            this.btnPop.UseVisualStyleBackColor = false;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            // 
            // txtElement
            // 
            this.txtElement.Location = new System.Drawing.Point(238, 149);
            this.txtElement.Name = "txtElement";
            this.txtElement.Size = new System.Drawing.Size(74, 20);
            this.txtElement.TabIndex = 4;
            // 
            // btnPush
            // 
            this.btnPush.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPush.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnPush.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPush.ForeColor = System.Drawing.Color.Maroon;
            this.btnPush.Location = new System.Drawing.Point(330, 127);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(131, 42);
            this.btnPush.TabIndex = 13;
            this.btnPush.Text = "Push";
            this.btnPush.UseVisualStyleBackColor = false;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Maroon;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(294, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Implementing Stacks";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Myriad Pro Semi bold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(129, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pop elements out of stack";
            // 
            // StackandQueus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 570);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StackandQueus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StackandQueus";
            this.Load += new System.EventHandler(this.StackandQueus_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox stackListBox;
        private System.Windows.Forms.Button btnPop;
        private System.Windows.Forms.TextBox txtElement;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPeek;
        private System.Windows.Forms.Button btnSize;
        private System.Windows.Forms.Button btnQsize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox queueListBox;
        private System.Windows.Forms.Button btnDequeue;
        private System.Windows.Forms.TextBox textElement1;
        private System.Windows.Forms.Button btnEnqueue;
    }
}