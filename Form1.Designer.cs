namespace Father
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menu_panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_settings = new System.Windows.Forms.Button();
            this.button_database = new System.Windows.Forms.Button();
            this.button_info = new System.Windows.Forms.Button();
            this.button_calculations = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.med_list = new System.Windows.Forms.ListView();
            this.med_list_amount = new System.Windows.Forms.ColumnHeader();
            this.med_list_name = new System.Windows.Forms.ColumnHeader();
            this.button_refresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_logo = new System.Windows.Forms.Button();
            this.menu_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_panel
            // 
            this.menu_panel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.menu_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menu_panel.Controls.Add(this.label2);
            this.menu_panel.Controls.Add(this.label1);
            this.menu_panel.Controls.Add(this.button_settings);
            this.menu_panel.Controls.Add(this.button_database);
            this.menu_panel.Controls.Add(this.button_info);
            this.menu_panel.Controls.Add(this.button_calculations);
            this.menu_panel.Location = new System.Drawing.Point(-10, 1);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(216, 546);
            this.menu_panel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(22, 494);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dr.Ahmed Ibrahim Abdel aziz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(22, 516);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Version 1.0.1";
            // 
            // button_settings
            // 
            this.button_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_settings.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_settings.ForeColor = System.Drawing.Color.Silver;
            this.button_settings.Image = global::Father.Properties.Resources.ad;
            this.button_settings.Location = new System.Drawing.Point(11, 233);
            this.button_settings.Name = "button_settings";
            this.button_settings.Size = new System.Drawing.Size(190, 80);
            this.button_settings.TabIndex = 3;
            this.button_settings.Text = "Settings";
            this.button_settings.UseVisualStyleBackColor = true;
            this.button_settings.Click += new System.EventHandler(this.button_settings_Click);
            // 
            // button_database
            // 
            this.button_database.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button_database.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_database.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_database.ForeColor = System.Drawing.Color.Silver;
            this.button_database.Image = global::Father.Properties.Resources.asdsa;
            this.button_database.Location = new System.Drawing.Point(11, 156);
            this.button_database.Name = "button_database";
            this.button_database.Size = new System.Drawing.Size(190, 80);
            this.button_database.TabIndex = 2;
            this.button_database.Text = "DataBase";
            this.button_database.UseVisualStyleBackColor = true;
            this.button_database.Click += new System.EventHandler(this.button_database_Click);
            // 
            // button_info
            // 
            this.button_info.BackColor = System.Drawing.Color.Transparent;
            this.button_info.BackgroundImage = global::Father.Properties.Resources._SALLAS;
            this.button_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_info.Font = new System.Drawing.Font("Berlin Sans FB", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_info.ForeColor = System.Drawing.Color.Silver;
            this.button_info.Image = global::Father.Properties.Resources.CD;
            this.button_info.Location = new System.Drawing.Point(11, 78);
            this.button_info.Name = "button_info";
            this.button_info.Size = new System.Drawing.Size(190, 81);
            this.button_info.TabIndex = 1;
            this.button_info.Text = "Info";
            this.button_info.UseVisualStyleBackColor = false;
            this.button_info.Click += new System.EventHandler(this.button_info_Click);
            // 
            // button_calculations
            // 
            this.button_calculations.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_calculations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_calculations.Font = new System.Drawing.Font("Berlin Sans FB Demi", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_calculations.ForeColor = System.Drawing.Color.Silver;
            this.button_calculations.Image = global::Father.Properties.Resources.CALC;
            this.button_calculations.Location = new System.Drawing.Point(11, 0);
            this.button_calculations.Name = "button_calculations";
            this.button_calculations.Size = new System.Drawing.Size(190, 81);
            this.button_calculations.TabIndex = 0;
            this.button_calculations.Text = "Calculations";
            this.button_calculations.UseVisualStyleBackColor = true;
            this.button_calculations.Click += new System.EventHandler(this.button_calculations_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.med_list);
            this.panel1.Controls.Add(this.button_refresh);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lbl_logo);
            this.panel1.Location = new System.Drawing.Point(190, -33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 580);
            this.panel1.TabIndex = 0;
            // 
            // med_list
            // 
            this.med_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.med_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.med_list_amount,
            this.med_list_name});
            this.med_list.Font = new System.Drawing.Font("Berlin Sans FB", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.med_list.ForeColor = System.Drawing.Color.Transparent;
            this.med_list.GridLines = true;
            this.med_list.Location = new System.Drawing.Point(4, 199);
            this.med_list.Name = "med_list";
            this.med_list.Size = new System.Drawing.Size(828, 270);
            this.med_list.TabIndex = 4;
            this.med_list.UseCompatibleStateImageBehavior = false;
            this.med_list.View = System.Windows.Forms.View.Details;
            // 
            // med_list_amount
            // 
            this.med_list_amount.Text = "Amount";
            this.med_list_amount.Width = 70;
            // 
            // med_list_name
            // 
            this.med_list_name.Text = "Name";
            this.med_list_name.Width = 750;
            // 
            // button_refresh
            // 
            this.button_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_refresh.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_refresh.ForeColor = System.Drawing.Color.Silver;
            this.button_refresh.Location = new System.Drawing.Point(61, 475);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(120, 45);
            this.button_refresh.TabIndex = 3;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(660, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Send Email";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_logo
            // 
            this.lbl_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_logo.Enabled = false;
            this.lbl_logo.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.lbl_logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_logo.Image = global::Father.Properties.Resources.LLLLLL;
            this.lbl_logo.Location = new System.Drawing.Point(3, 34);
            this.lbl_logo.Name = "lbl_logo";
            this.lbl_logo.Size = new System.Drawing.Size(835, 165);
            this.lbl_logo.TabIndex = 0;
            this.lbl_logo.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 547);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menu_panel);
            this.Font = new System.Drawing.Font("Bernard MT Condensed", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Medicine Tracker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu_panel.ResumeLayout(false);
            this.menu_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel menu_panel;
        private Panel panel1;
        private Button lbl_logo;
        private Button button_calculations;
        private Button button_info;
        private Button button_database;
        private Button button_settings;
        private Label label1;
        private Button button1;
        private Button button_refresh;
        private Label label2;
        private ListView med_list;
        private ColumnHeader med_list_amount;
        private ColumnHeader med_list_name;
    }
}