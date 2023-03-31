namespace LuaChonMonAn
{
    partial class ThucDon
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
            this.label1 = new System.Windows.Forms.Label();
            this.textChoices = new System.Windows.Forms.TextBox();
            this.BTNChoices = new System.Windows.Forms.Button();
            this.BTNAdd = new System.Windows.Forms.Button();
            this.BTNAddAll = new System.Windows.Forms.Button();
            this.BTNSub = new System.Windows.Forms.Button();
            this.BTNSubAll = new System.Windows.Forms.Button();
            this.BTNExit = new System.Windows.Forms.Button();
            this.List_Thucdon = new System.Windows.Forms.ListBox();
            this.List_Chon = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên món :";
            // 
            // textChoices
            // 
            this.textChoices.Location = new System.Drawing.Point(122, 18);
            this.textChoices.Name = "textChoices";
            this.textChoices.Size = new System.Drawing.Size(326, 20);
            this.textChoices.TabIndex = 1;
            this.textChoices.TextChanged += new System.EventHandler(this.textChoices_TextChanged);
            this.textChoices.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textChoices_KeyPress);
            // 
            // BTNChoices
            // 
            this.BTNChoices.Enabled = false;
            this.BTNChoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.BTNChoices.Location = new System.Drawing.Point(467, 15);
            this.BTNChoices.Name = "BTNChoices";
            this.BTNChoices.Size = new System.Drawing.Size(75, 23);
            this.BTNChoices.TabIndex = 2;
            this.BTNChoices.Text = "Thêm";
            this.BTNChoices.UseVisualStyleBackColor = true;
            this.BTNChoices.Click += new System.EventHandler(this.BTNChoices_Click);
            // 
            // BTNAdd
            // 
            this.BTNAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.BTNAdd.Location = new System.Drawing.Point(249, 65);
            this.BTNAdd.Name = "BTNAdd";
            this.BTNAdd.Size = new System.Drawing.Size(62, 36);
            this.BTNAdd.TabIndex = 3;
            this.BTNAdd.Text = ">";
            this.BTNAdd.UseVisualStyleBackColor = true;
            this.BTNAdd.Click += new System.EventHandler(this.BTNAdd_Click);
            // 
            // BTNAddAll
            // 
            this.BTNAddAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.BTNAddAll.Location = new System.Drawing.Point(249, 118);
            this.BTNAddAll.Name = "BTNAddAll";
            this.BTNAddAll.Size = new System.Drawing.Size(62, 36);
            this.BTNAddAll.TabIndex = 4;
            this.BTNAddAll.Text = ">>";
            this.BTNAddAll.UseVisualStyleBackColor = true;
            this.BTNAddAll.Click += new System.EventHandler(this.BTNAddAll_Click);
            // 
            // BTNSub
            // 
            this.BTNSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.BTNSub.Location = new System.Drawing.Point(249, 171);
            this.BTNSub.Name = "BTNSub";
            this.BTNSub.Size = new System.Drawing.Size(62, 36);
            this.BTNSub.TabIndex = 5;
            this.BTNSub.Text = "<";
            this.BTNSub.UseVisualStyleBackColor = true;
            this.BTNSub.Click += new System.EventHandler(this.BTNSub_Click);
            // 
            // BTNSubAll
            // 
            this.BTNSubAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.BTNSubAll.Location = new System.Drawing.Point(249, 227);
            this.BTNSubAll.Name = "BTNSubAll";
            this.BTNSubAll.Size = new System.Drawing.Size(62, 36);
            this.BTNSubAll.TabIndex = 6;
            this.BTNSubAll.Text = "<<";
            this.BTNSubAll.UseVisualStyleBackColor = true;
            this.BTNSubAll.Click += new System.EventHandler(this.BTNSubAll_Click);
            // 
            // BTNExit
            // 
            this.BTNExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.BTNExit.Location = new System.Drawing.Point(467, 289);
            this.BTNExit.Name = "BTNExit";
            this.BTNExit.Size = new System.Drawing.Size(75, 23);
            this.BTNExit.TabIndex = 7;
            this.BTNExit.Text = "Thoát";
            this.BTNExit.UseVisualStyleBackColor = true;
            this.BTNExit.Click += new System.EventHandler(this.BTNExit_Click);
            // 
            // List_Thucdon
            // 
            this.List_Thucdon.FormattingEnabled = true;
            this.List_Thucdon.Location = new System.Drawing.Point(22, 51);
            this.List_Thucdon.Name = "List_Thucdon";
            this.List_Thucdon.Size = new System.Drawing.Size(212, 225);
            this.List_Thucdon.TabIndex = 8;
            // 
            // List_Chon
            // 
            this.List_Chon.FormattingEnabled = true;
            this.List_Chon.Location = new System.Drawing.Point(330, 51);
            this.List_Chon.Name = "List_Chon";
            this.List_Chon.Size = new System.Drawing.Size(212, 225);
            this.List_Chon.TabIndex = 9;
            // 
            // ThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 345);
            this.Controls.Add(this.List_Chon);
            this.Controls.Add(this.List_Thucdon);
            this.Controls.Add(this.BTNExit);
            this.Controls.Add(this.BTNSubAll);
            this.Controls.Add(this.BTNSub);
            this.Controls.Add(this.BTNAddAll);
            this.Controls.Add(this.BTNAdd);
            this.Controls.Add(this.BTNChoices);
            this.Controls.Add(this.textChoices);
            this.Controls.Add(this.label1);
            this.Name = "ThucDon";
            this.Text = "Thực Đơn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textChoices;
        private System.Windows.Forms.Button BTNChoices;
        private System.Windows.Forms.Button BTNAdd;
        private System.Windows.Forms.Button BTNAddAll;
        private System.Windows.Forms.Button BTNSub;
        private System.Windows.Forms.Button BTNSubAll;
        private System.Windows.Forms.Button BTNExit;
        private System.Windows.Forms.ListBox List_Thucdon;
        private System.Windows.Forms.ListBox List_Chon;
    }
}

