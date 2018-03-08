namespace Securely
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
            this.Panel_Form_Control = new System.Windows.Forms.Panel();
            this.Button_Form_Control_Minimise = new Securely.FlatButton();
            this.Button_Form_Control_Close = new Securely.FlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Panel_Main_Window = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Textbox_Folder_Path = new System.Windows.Forms.TextBox();
            this.Button_Folder_Browser = new Securely.FlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Panel_Settings = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Radio_Low = new System.Windows.Forms.RadioButton();
            this.Radio_Medium = new System.Windows.Forms.RadioButton();
            this.Radio_High = new System.Windows.Forms.RadioButton();
            this.Panel_Start = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.Button_Start_Process = new Securely.FlatButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Panel_Form_Control.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Panel_Main_Window.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Panel_Settings.SuspendLayout();
            this.Panel_Start.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Form_Control
            // 
            this.Panel_Form_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(188)))), ((int)(((byte)(173)))));
            this.Panel_Form_Control.Controls.Add(this.Button_Form_Control_Minimise);
            this.Panel_Form_Control.Controls.Add(this.Button_Form_Control_Close);
            this.Panel_Form_Control.Controls.Add(this.label3);
            this.Panel_Form_Control.Location = new System.Drawing.Point(0, 0);
            this.Panel_Form_Control.Name = "Panel_Form_Control";
            this.Panel_Form_Control.Size = new System.Drawing.Size(734, 29);
            this.Panel_Form_Control.TabIndex = 0;
            this.Panel_Form_Control.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_Form);
            // 
            // Button_Form_Control_Minimise
            // 
            this.Button_Form_Control_Minimise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(183)))), ((int)(((byte)(50)))));
            this.Button_Form_Control_Minimise.FlatAppearance.BorderSize = 0;
            this.Button_Form_Control_Minimise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Form_Control_Minimise.Font = new System.Drawing.Font("Segoe UI Semilight", 8F);
            this.Button_Form_Control_Minimise.ForeColor = System.Drawing.Color.White;
            this.Button_Form_Control_Minimise.Location = new System.Drawing.Point(671, 0);
            this.Button_Form_Control_Minimise.Name = "Button_Form_Control_Minimise";
            this.Button_Form_Control_Minimise.Size = new System.Drawing.Size(27, 29);
            this.Button_Form_Control_Minimise.TabIndex = 2;
            this.Button_Form_Control_Minimise.TabStop = false;
            this.Button_Form_Control_Minimise.Text = "-";
            this.Button_Form_Control_Minimise.UseVisualStyleBackColor = false;
            this.Button_Form_Control_Minimise.Click += new System.EventHandler(this.Button_Form_Control_Minimise_Click);
            // 
            // Button_Form_Control_Close
            // 
            this.Button_Form_Control_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(73)))), ((int)(((byte)(27)))));
            this.Button_Form_Control_Close.FlatAppearance.BorderSize = 0;
            this.Button_Form_Control_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Form_Control_Close.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F);
            this.Button_Form_Control_Close.ForeColor = System.Drawing.Color.White;
            this.Button_Form_Control_Close.Location = new System.Drawing.Point(704, 0);
            this.Button_Form_Control_Close.Name = "Button_Form_Control_Close";
            this.Button_Form_Control_Close.Size = new System.Drawing.Size(30, 29);
            this.Button_Form_Control_Close.TabIndex = 1;
            this.Button_Form_Control_Close.TabStop = false;
            this.Button_Form_Control_Close.Text = "X";
            this.Button_Form_Control_Close.UseVisualStyleBackColor = false;
            this.Button_Form_Control_Close.Click += new System.EventHandler(this.Button_Form_Control_Close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(188)))), ((int)(((byte)(173)))));
            this.panel1.Controls.Add(this.Panel_Main_Window);
            this.panel1.Location = new System.Drawing.Point(-11, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 490);
            this.panel1.TabIndex = 1;
            // 
            // Panel_Main_Window
            // 
            this.Panel_Main_Window.BackColor = System.Drawing.Color.White;
            this.Panel_Main_Window.Controls.Add(this.Panel_Start);
            this.Panel_Main_Window.Controls.Add(this.Panel_Settings);
            this.Panel_Main_Window.Controls.Add(this.panel2);
            this.Panel_Main_Window.Controls.Add(this.label1);
            this.Panel_Main_Window.Controls.Add(this.tableLayoutPanel1);
            this.Panel_Main_Window.Location = new System.Drawing.Point(12, 0);
            this.Panel_Main_Window.Name = "Panel_Main_Window";
            this.Panel_Main_Window.Size = new System.Drawing.Size(730, 484);
            this.Panel_Main_Window.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 12.75F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Securely 0.0.12";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 299);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(729, 27);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 16.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(239, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Securely delete anything.";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Button_Folder_Browser);
            this.panel2.Controls.Add(this.Textbox_Folder_Path);
            this.panel2.Location = new System.Drawing.Point(0, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(729, 81);
            this.panel2.TabIndex = 2;
            // 
            // Textbox_Folder_Path
            // 
            this.Textbox_Folder_Path.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Folder_Path.Location = new System.Drawing.Point(143, 42);
            this.Textbox_Folder_Path.Name = "Textbox_Folder_Path";
            this.Textbox_Folder_Path.Size = new System.Drawing.Size(396, 23);
            this.Textbox_Folder_Path.TabIndex = 3;
            this.Textbox_Folder_Path.TabStop = false;
            // 
            // Button_Folder_Browser
            // 
            this.Button_Folder_Browser.BackColor = System.Drawing.Color.Silver;
            this.Button_Folder_Browser.FlatAppearance.BorderSize = 0;
            this.Button_Folder_Browser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Folder_Browser.ForeColor = System.Drawing.Color.White;
            this.Button_Folder_Browser.Location = new System.Drawing.Point(545, 42);
            this.Button_Folder_Browser.Name = "Button_Folder_Browser";
            this.Button_Folder_Browser.Size = new System.Drawing.Size(39, 23);
            this.Button_Folder_Browser.TabIndex = 3;
            this.Button_Folder_Browser.TabStop = false;
            this.Button_Folder_Browser.Text = "...";
            this.Button_Folder_Browser.UseVisualStyleBackColor = false;
            this.Button_Folder_Browser.Click += new System.EventHandler(this.Button_Folder_Browser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 10.75F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(139, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "First, pick the folder.";
            // 
            // Panel_Settings
            // 
            this.Panel_Settings.Controls.Add(this.Radio_High);
            this.Panel_Settings.Controls.Add(this.Radio_Medium);
            this.Panel_Settings.Controls.Add(this.Radio_Low);
            this.Panel_Settings.Controls.Add(this.label4);
            this.Panel_Settings.Location = new System.Drawing.Point(0, 193);
            this.Panel_Settings.Name = "Panel_Settings";
            this.Panel_Settings.Size = new System.Drawing.Size(730, 100);
            this.Panel_Settings.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 10.75F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(139, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(344, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Now, pick how secure you would like the delete to be.";
            // 
            // Radio_Low
            // 
            this.Radio_Low.AutoSize = true;
            this.Radio_Low.Font = new System.Drawing.Font("Segoe UI Light", 10.75F);
            this.Radio_Low.Location = new System.Drawing.Point(143, 63);
            this.Radio_Low.Name = "Radio_Low";
            this.Radio_Low.Size = new System.Drawing.Size(55, 24);
            this.Radio_Low.TabIndex = 5;
            this.Radio_Low.Text = "A bit";
            this.Radio_Low.UseVisualStyleBackColor = true;
            // 
            // Radio_Medium
            // 
            this.Radio_Medium.AutoSize = true;
            this.Radio_Medium.Checked = true;
            this.Radio_Medium.Font = new System.Drawing.Font("Segoe UI Light", 10.75F);
            this.Radio_Medium.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Radio_Medium.Location = new System.Drawing.Point(258, 63);
            this.Radio_Medium.Name = "Radio_Medium";
            this.Radio_Medium.Size = new System.Drawing.Size(209, 24);
            this.Radio_Medium.TabIndex = 6;
            this.Radio_Medium.TabStop = true;
            this.Radio_Medium.Text = "Make it impossible to recover";
            this.Radio_Medium.UseVisualStyleBackColor = true;
            // 
            // Radio_High
            // 
            this.Radio_High.AutoSize = true;
            this.Radio_High.Font = new System.Drawing.Font("Segoe UI Light", 10.75F);
            this.Radio_High.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Radio_High.Location = new System.Drawing.Point(508, 63);
            this.Radio_High.Name = "Radio_High";
            this.Radio_High.Size = new System.Drawing.Size(76, 24);
            this.Radio_High.TabIndex = 7;
            this.Radio_High.Text = "Nuclear";
            this.Radio_High.UseVisualStyleBackColor = true;
            // 
            // Panel_Start
            // 
            this.Panel_Start.Controls.Add(this.progressBar1);
            this.Panel_Start.Controls.Add(this.Button_Start_Process);
            this.Panel_Start.Controls.Add(this.label5);
            this.Panel_Start.Location = new System.Drawing.Point(0, 318);
            this.Panel_Start.Name = "Panel_Start";
            this.Panel_Start.Size = new System.Drawing.Size(730, 163);
            this.Panel_Start.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 10.75F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(139, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Finally, let the deletion begin.";
            // 
            // Button_Start_Process
            // 
            this.Button_Start_Process.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(183)))), ((int)(((byte)(50)))));
            this.Button_Start_Process.FlatAppearance.BorderSize = 0;
            this.Button_Start_Process.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Start_Process.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Start_Process.ForeColor = System.Drawing.Color.White;
            this.Button_Start_Process.Location = new System.Drawing.Point(286, 54);
            this.Button_Start_Process.Name = "Button_Start_Process";
            this.Button_Start_Process.Size = new System.Drawing.Size(152, 47);
            this.Button_Start_Process.TabIndex = 9;
            this.Button_Start_Process.TabStop = false;
            this.Button_Start_Process.Text = "Start";
            this.Button_Start_Process.UseVisualStyleBackColor = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(3, 140);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(724, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(732, 512);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Panel_Form_Control);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Panel_Form_Control.ResumeLayout(false);
            this.Panel_Form_Control.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.Panel_Main_Window.ResumeLayout(false);
            this.Panel_Main_Window.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Panel_Settings.ResumeLayout(false);
            this.Panel_Settings.PerformLayout();
            this.Panel_Start.ResumeLayout(false);
            this.Panel_Start.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Form_Control;
        private FlatButton Button_Form_Control_Close;
        private FlatButton Button_Form_Control_Minimise;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Panel_Main_Window;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Textbox_Folder_Path;
        private FlatButton Button_Folder_Browser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Panel_Settings;
        private System.Windows.Forms.RadioButton Radio_High;
        private System.Windows.Forms.RadioButton Radio_Medium;
        private System.Windows.Forms.RadioButton Radio_Low;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel Panel_Start;
        private System.Windows.Forms.Label label5;
        private FlatButton Button_Start_Process;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

