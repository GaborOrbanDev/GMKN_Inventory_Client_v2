namespace GMKN_Inventory_Client_v2
{
    partial class FormInventory
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_qoh = new System.Windows.Forms.Label();
            this.label_qr = new System.Windows.Forms.Label();
            this.label_lsp = new System.Windows.Forms.Label();
            this.label_osp = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.out_sub = new System.Windows.Forms.Button();
            this.low_sub = new System.Windows.Forms.Button();
            this.reserved_sub = new System.Windows.Forms.Button();
            this.quantity_sub = new System.Windows.Forms.Button();
            this.out_add = new System.Windows.Forms.Button();
            this.low_add = new System.Windows.Forms.Button();
            this.reserved_add = new System.Windows.Forms.Button();
            this.quatity_add = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(45, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jelenlegi készlet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(45, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lefoglalt készlet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(45, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Készleten kívüli pont:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(45, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alacsony készlet pont:";
            // 
            // label_qoh
            // 
            this.label_qoh.AutoSize = true;
            this.label_qoh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_qoh.Location = new System.Drawing.Point(213, 126);
            this.label_qoh.Name = "label_qoh";
            this.label_qoh.Size = new System.Drawing.Size(24, 25);
            this.label_qoh.TabIndex = 4;
            this.label_qoh.Text = "0";
            // 
            // label_qr
            // 
            this.label_qr.AutoSize = true;
            this.label_qr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_qr.Location = new System.Drawing.Point(213, 184);
            this.label_qr.Name = "label_qr";
            this.label_qr.Size = new System.Drawing.Size(24, 25);
            this.label_qr.TabIndex = 5;
            this.label_qr.Text = "0";
            // 
            // label_lsp
            // 
            this.label_lsp.AutoSize = true;
            this.label_lsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_lsp.Location = new System.Drawing.Point(259, 242);
            this.label_lsp.Name = "label_lsp";
            this.label_lsp.Size = new System.Drawing.Size(24, 25);
            this.label_lsp.TabIndex = 6;
            this.label_lsp.Text = "0";
            // 
            // label_osp
            // 
            this.label_osp.AutoSize = true;
            this.label_osp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_osp.Location = new System.Drawing.Point(259, 297);
            this.label_osp.Name = "label_osp";
            this.label_osp.Size = new System.Drawing.Size(24, 25);
            this.label_osp.TabIndex = 7;
            this.label_osp.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.out_sub);
            this.groupBox1.Controls.Add(this.low_sub);
            this.groupBox1.Controls.Add(this.reserved_sub);
            this.groupBox1.Controls.Add(this.quantity_sub);
            this.groupBox1.Controls.Add(this.out_add);
            this.groupBox1.Controls.Add(this.low_add);
            this.groupBox1.Controls.Add(this.reserved_add);
            this.groupBox1.Controls.Add(this.quatity_add);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(356, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 275);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mennyiség változtatása";
            // 
            // out_sub
            // 
            this.out_sub.Location = new System.Drawing.Point(257, 226);
            this.out_sub.Name = "out_sub";
            this.out_sub.Size = new System.Drawing.Size(88, 30);
            this.out_sub.TabIndex = 17;
            this.out_sub.Text = "-";
            this.out_sub.UseVisualStyleBackColor = true;
            this.out_sub.Click += new System.EventHandler(this.out_sub_Click);
            // 
            // low_sub
            // 
            this.low_sub.Location = new System.Drawing.Point(257, 171);
            this.low_sub.Name = "low_sub";
            this.low_sub.Size = new System.Drawing.Size(88, 30);
            this.low_sub.TabIndex = 16;
            this.low_sub.Text = "-";
            this.low_sub.UseVisualStyleBackColor = true;
            this.low_sub.Click += new System.EventHandler(this.low_sub_Click);
            // 
            // reserved_sub
            // 
            this.reserved_sub.Location = new System.Drawing.Point(257, 113);
            this.reserved_sub.Name = "reserved_sub";
            this.reserved_sub.Size = new System.Drawing.Size(88, 30);
            this.reserved_sub.TabIndex = 15;
            this.reserved_sub.Text = "-";
            this.reserved_sub.UseVisualStyleBackColor = true;
            this.reserved_sub.Click += new System.EventHandler(this.reserved_sub_Click);
            // 
            // quantity_sub
            // 
            this.quantity_sub.Location = new System.Drawing.Point(257, 57);
            this.quantity_sub.Name = "quantity_sub";
            this.quantity_sub.Size = new System.Drawing.Size(88, 30);
            this.quantity_sub.TabIndex = 14;
            this.quantity_sub.Text = "-";
            this.quantity_sub.UseVisualStyleBackColor = true;
            this.quantity_sub.Click += new System.EventHandler(this.quantity_sub_Click);
            // 
            // out_add
            // 
            this.out_add.Location = new System.Drawing.Point(133, 226);
            this.out_add.Name = "out_add";
            this.out_add.Size = new System.Drawing.Size(88, 30);
            this.out_add.TabIndex = 13;
            this.out_add.Text = "+";
            this.out_add.UseVisualStyleBackColor = true;
            this.out_add.Click += new System.EventHandler(this.out_add_Click);
            // 
            // low_add
            // 
            this.low_add.Location = new System.Drawing.Point(133, 174);
            this.low_add.Name = "low_add";
            this.low_add.Size = new System.Drawing.Size(88, 30);
            this.low_add.TabIndex = 12;
            this.low_add.Text = "+";
            this.low_add.UseVisualStyleBackColor = true;
            this.low_add.Click += new System.EventHandler(this.low_add_Click);
            // 
            // reserved_add
            // 
            this.reserved_add.Location = new System.Drawing.Point(133, 116);
            this.reserved_add.Name = "reserved_add";
            this.reserved_add.Size = new System.Drawing.Size(88, 30);
            this.reserved_add.TabIndex = 11;
            this.reserved_add.Text = "+";
            this.reserved_add.UseVisualStyleBackColor = true;
            this.reserved_add.Click += new System.EventHandler(this.reserved_add_Click);
            // 
            // quatity_add
            // 
            this.quatity_add.Location = new System.Drawing.Point(133, 55);
            this.quatity_add.Name = "quatity_add";
            this.quatity_add.Size = new System.Drawing.Size(88, 30);
            this.quatity_add.TabIndex = 10;
            this.quatity_add.Text = "+";
            this.quatity_add.UseVisualStyleBackColor = true;
            this.quatity_add.Click += new System.EventHandler(this.quatity_add_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(21, 226);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(70, 30);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(21, 171);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(70, 30);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(21, 113);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(70, 30);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(70, 30);
            this.textBox1.TabIndex = 0;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Gold;
            this.btn_save.Enabled = false;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_save.Location = new System.Drawing.Point(442, 373);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(216, 50);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Mentés";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_name.Location = new System.Drawing.Point(47, 27);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(62, 25);
            this.label_name.TabIndex = 11;
            this.label_name.Text = "Ruha";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_osp);
            this.Controls.Add(this.label_lsp);
            this.Controls.Add(this.label_qr);
            this.Controls.Add(this.label_qoh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "FormInventory";
            this.Text = "Készlet szerkesztése";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_qoh;
        private System.Windows.Forms.Label label_qr;
        private System.Windows.Forms.Label label_lsp;
        private System.Windows.Forms.Label label_osp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button out_sub;
        private System.Windows.Forms.Button low_sub;
        private System.Windows.Forms.Button reserved_sub;
        private System.Windows.Forms.Button quantity_sub;
        private System.Windows.Forms.Button out_add;
        private System.Windows.Forms.Button low_add;
        private System.Windows.Forms.Button reserved_add;
        private System.Windows.Forms.Button quatity_add;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}