namespace BT1
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
            this.lbSoA = new System.Windows.Forms.Label();
            this.lbSoB = new System.Windows.Forms.Label();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.TXTA = new System.Windows.Forms.TextBox();
            this.TXTB = new System.Windows.Forms.TextBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.BTCONG = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSoA
            // 
            this.lbSoA.AutoSize = true;
            this.lbSoA.Location = new System.Drawing.Point(35, 64);
            this.lbSoA.Name = "lbSoA";
            this.lbSoA.Size = new System.Drawing.Size(72, 31);
            this.lbSoA.TabIndex = 0;
            this.lbSoA.Text = "So A";
            // 
            // lbSoB
            // 
            this.lbSoB.AutoSize = true;
            this.lbSoB.Location = new System.Drawing.Point(35, 149);
            this.lbSoB.Name = "lbSoB";
            this.lbSoB.Size = new System.Drawing.Size(72, 31);
            this.lbSoB.TabIndex = 0;
            this.lbSoB.Text = "So B";
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Location = new System.Drawing.Point(35, 222);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(106, 31);
            this.lbKetQua.TabIndex = 0;
            this.lbKetQua.Text = "KetQua";
            // 
            // TXTA
            // 
            this.TXTA.Location = new System.Drawing.Point(159, 57);
            this.TXTA.Name = "TXTA";
            this.TXTA.Size = new System.Drawing.Size(284, 38);
            this.TXTA.TabIndex = 1;
            // 
            // TXTB
            // 
            this.TXTB.Location = new System.Drawing.Point(159, 142);
            this.TXTB.Name = "TXTB";
            this.TXTB.Size = new System.Drawing.Size(284, 38);
            this.TXTB.TabIndex = 1;
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(159, 219);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(284, 38);
            this.txtKQ.TabIndex = 1;
            // 
            // BTCONG
            // 
            this.BTCONG.Location = new System.Drawing.Point(75, 322);
            this.BTCONG.Name = "BTCONG";
            this.BTCONG.Size = new System.Drawing.Size(102, 61);
            this.BTCONG.TabIndex = 2;
            this.BTCONG.Text = "+";
            this.BTCONG.UseVisualStyleBackColor = true;
            this.BTCONG.Click += new System.EventHandler(this.BTCONG_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 622);
            this.Controls.Add(this.BTCONG);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.TXTB);
            this.Controls.Add(this.TXTA);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.lbSoB);
            this.Controls.Add(this.lbSoA);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSoA;
        private System.Windows.Forms.Label lbSoB;
        private System.Windows.Forms.Label lbKetQua;
        private System.Windows.Forms.TextBox TXTA;
        private System.Windows.Forms.TextBox TXTB;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Button BTCONG;
    }
}

