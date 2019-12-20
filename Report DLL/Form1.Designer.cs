namespace Report_DLL
{
    partial class test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(test));
            this.CB_Version = new System.Windows.Forms.ComboBox();
            this.lbl_version = new System.Windows.Forms.Label();
            this.btn_Apply = new System.Windows.Forms.Button();
            this.rB_FS = new System.Windows.Forms.RadioButton();
            this.rb_iLogisys = new System.Windows.Forms.RadioButton();
            this.check_4927 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CB_Version
            // 
            this.CB_Version.FormattingEnabled = true;
            this.CB_Version.Location = new System.Drawing.Point(58, 96);
            this.CB_Version.Name = "CB_Version";
            this.CB_Version.Size = new System.Drawing.Size(150, 21);
            this.CB_Version.TabIndex = 0;
            // 
            // lbl_version
            // 
            this.lbl_version.AutoSize = true;
            this.lbl_version.Location = new System.Drawing.Point(114, 80);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(42, 13);
            this.lbl_version.TabIndex = 1;
            this.lbl_version.Text = "Version";
            // 
            // btn_Apply
            // 
            this.btn_Apply.Location = new System.Drawing.Point(57, 135);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(151, 23);
            this.btn_Apply.TabIndex = 2;
            this.btn_Apply.Text = "Register DLL";
            this.btn_Apply.UseVisualStyleBackColor = true;
            this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
            // 
            // rB_FS
            // 
            this.rB_FS.AutoSize = true;
            this.rB_FS.Location = new System.Drawing.Point(57, 25);
            this.rB_FS.Name = "rB_FS";
            this.rB_FS.Size = new System.Drawing.Size(90, 17);
            this.rB_FS.TabIndex = 3;
            this.rB_FS.TabStop = true;
            this.rB_FS.Text = "FreightStream";
            this.rB_FS.UseVisualStyleBackColor = true;
            this.rB_FS.CheckedChanged += new System.EventHandler(this.rB_FS_CheckedChanged);
            // 
            // rb_iLogisys
            // 
            this.rb_iLogisys.AutoSize = true;
            this.rb_iLogisys.Location = new System.Drawing.Point(153, 25);
            this.rb_iLogisys.Name = "rb_iLogisys";
            this.rb_iLogisys.Size = new System.Drawing.Size(62, 17);
            this.rb_iLogisys.TabIndex = 4;
            this.rb_iLogisys.TabStop = true;
            this.rb_iLogisys.Text = "iLogisys";
            this.rb_iLogisys.UseVisualStyleBackColor = true;
            this.rb_iLogisys.CheckedChanged += new System.EventHandler(this.rb_iLogisys_CheckedChanged);
            // 
            // check_4927
            // 
            this.check_4927.AutoSize = true;
            this.check_4927.Location = new System.Drawing.Point(109, 56);
            this.check_4927.Name = "check_4927";
            this.check_4927.Size = new System.Drawing.Size(56, 17);
            this.check_4927.TabIndex = 5;
            this.check_4927.Text = "4927+";
            this.check_4927.UseVisualStyleBackColor = true;
            this.check_4927.Visible = false;
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 183);
            this.Controls.Add(this.check_4927);
            this.Controls.Add(this.rb_iLogisys);
            this.Controls.Add(this.rB_FS);
            this.Controls.Add(this.btn_Apply);
            this.Controls.Add(this.lbl_version);
            this.Controls.Add(this.CB_Version);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "test";
            this.Text = "Register Report DLL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_Version;
        private System.Windows.Forms.Label lbl_version;
        private System.Windows.Forms.Button btn_Apply;
        private System.Windows.Forms.RadioButton rB_FS;
        private System.Windows.Forms.RadioButton rb_iLogisys;
        private System.Windows.Forms.CheckBox check_4927;
    }
}

