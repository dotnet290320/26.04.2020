namespace WinForm2604
{
    partial class MyForm
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
            this.helloLbl = new System.Windows.Forms.Label();
            this.worldLbl = new System.Windows.Forms.Label();
            this.timeBtn = new System.Windows.Forms.Button();
            this.timeLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.power2Btn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.userNumberTxt = new System.Windows.Forms.TextBox();
            this.resultLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // helloLbl
            // 
            this.helloLbl.AutoSize = true;
            this.helloLbl.BackColor = System.Drawing.Color.White;
            this.helloLbl.Location = new System.Drawing.Point(199, 189);
            this.helloLbl.Name = "helloLbl";
            this.helloLbl.Size = new System.Drawing.Size(40, 17);
            this.helloLbl.TabIndex = 0;
            this.helloLbl.Text = "Hello";
            // 
            // worldLbl
            // 
            this.worldLbl.AutoSize = true;
            this.worldLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(239)))), ((int)(((byte)(240)))));
            this.worldLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.worldLbl.Location = new System.Drawing.Point(274, 189);
            this.worldLbl.Name = "worldLbl";
            this.worldLbl.Size = new System.Drawing.Size(76, 25);
            this.worldLbl.TabIndex = 1;
            this.worldLbl.Text = "World!";
            // 
            // timeBtn
            // 
            this.timeBtn.AutoSize = true;
            this.timeBtn.Location = new System.Drawing.Point(188, 30);
            this.timeBtn.Name = "timeBtn";
            this.timeBtn.Size = new System.Drawing.Size(123, 27);
            this.timeBtn.TabIndex = 2;
            this.timeBtn.Text = "What\'s the time?";
            this.timeBtn.UseVisualStyleBackColor = true;
            this.timeBtn.Click += new System.EventHandler(this.timeBtn_Click);
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Location = new System.Drawing.Point(188, 80);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(44, 17);
            this.timeLbl.TabIndex = 3;
            this.timeLbl.Text = "00:00";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.resultLbl);
            this.panel1.Controls.Add(this.userNumberTxt);
            this.panel1.Controls.Add(this.clearBtn);
            this.panel1.Controls.Add(this.power2Btn);
            this.panel1.Location = new System.Drawing.Point(433, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 184);
            this.panel1.TabIndex = 4;
            // 
            // power2Btn
            // 
            this.power2Btn.AutoSize = true;
            this.power2Btn.Location = new System.Drawing.Point(52, 22);
            this.power2Btn.Name = "power2Btn";
            this.power2Btn.Size = new System.Drawing.Size(75, 27);
            this.power2Btn.TabIndex = 0;
            this.power2Btn.Text = "Power 2";
            this.power2Btn.UseVisualStyleBackColor = true;
            this.power2Btn.Click += new System.EventHandler(this.power2Btn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.AutoSize = true;
            this.clearBtn.Location = new System.Drawing.Point(156, 22);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 27);
            this.clearBtn.TabIndex = 1;
            this.clearBtn.Text = "&Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // userNumberTxt
            // 
            this.userNumberTxt.Location = new System.Drawing.Point(76, 77);
            this.userNumberTxt.Name = "userNumberTxt";
            this.userNumberTxt.Size = new System.Drawing.Size(145, 22);
            this.userNumberTxt.TabIndex = 2;
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.resultLbl.Location = new System.Drawing.Point(129, 125);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(32, 32);
            this.resultLbl.TabIndex = 3;
            this.resultLbl.Text = "?";
            this.resultLbl.Visible = false;
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 253);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.timeLbl);
            this.Controls.Add(this.timeBtn);
            this.Controls.Add(this.worldLbl);
            this.Controls.Add(this.helloLbl);
            this.Name = "MyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My First Winform Program";
            this.Load += new System.EventHandler(this.MyForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label helloLbl;
        private System.Windows.Forms.Label worldLbl;
        private System.Windows.Forms.Button timeBtn;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button power2Btn;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.TextBox userNumberTxt;
    }
}

