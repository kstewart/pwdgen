using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace WorkingCode.CodeProject.PwdGen
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
    public class PwdGenUI : System.Windows.Forms.Form
    {
        private PasswordGenerator pwdGen;

        private System.Windows.Forms.TextBox genPwd;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.CheckBox consecutive;
        private System.Windows.Forms.CheckBox repeating;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar maxSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox exclude;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox excludeSymbols;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public PwdGenUI()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose( bool disposing )
        {
            if( disposing )
            {
                if (components != null) 
                {
                    components.Dispose();
                }
            }
            base.Dispose( disposing );
        }

		#region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.genPwd = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.consecutive = new System.Windows.Forms.CheckBox();
            this.repeating = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maxSize = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.exclude = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.excludeSymbols = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.maxSize)).BeginInit();
            this.SuspendLayout();
            // 
            // genPwd
            // 
            this.genPwd.Location = new System.Drawing.Point(16, 272);
            this.genPwd.Name = "genPwd";
            this.genPwd.Size = new System.Drawing.Size(328, 20);
            this.genPwd.TabIndex = 4;
            this.genPwd.Text = "";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(208, 312);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(136, 23);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Generate Password";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // consecutive
            // 
            this.consecutive.Location = new System.Drawing.Point(16, 8);
            this.consecutive.Name = "consecutive";
            this.consecutive.Size = new System.Drawing.Size(152, 24);
            this.consecutive.TabIndex = 0;
            this.consecutive.Text = "Consecutive characters?";
            // 
            // repeating
            // 
            this.repeating.Location = new System.Drawing.Point(192, 8);
            this.repeating.Name = "repeating";
            this.repeating.Size = new System.Drawing.Size(144, 24);
            this.repeating.TabIndex = 1;
            this.repeating.Text = "Repeating characters?";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Generated Password";
            // 
            // maxSize
            // 
            this.maxSize.LargeChange = 10;
            this.maxSize.Location = new System.Drawing.Point(16, 64);
            this.maxSize.Maximum = 50;
            this.maxSize.Minimum = 10;
            this.maxSize.Name = "maxSize";
            this.maxSize.Size = new System.Drawing.Size(328, 45);
            this.maxSize.SmallChange = 5;
            this.maxSize.TabIndex = 2;
            this.maxSize.TickFrequency = 5;
            this.maxSize.Value = 10;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 40);
            this.label2.Name = "label2";
            this.label2.TabIndex = 8;
            this.label2.Text = "Maximum Size";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Exclude these characters";
            // 
            // exclude
            // 
            this.exclude.Location = new System.Drawing.Point(16, 192);
            this.exclude.Name = "exclude";
            this.exclude.Size = new System.Drawing.Size(328, 20);
            this.exclude.TabIndex = 3;
            this.exclude.Text = "";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(24, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "10";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(320, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 23);
            this.label6.TabIndex = 21;
            this.label6.Text = "50";
            // 
            // excludeSymbols
            // 
            this.excludeSymbols.Location = new System.Drawing.Point(208, 159);
            this.excludeSymbols.Name = "excludeSymbols";
            this.excludeSymbols.Size = new System.Drawing.Size(144, 24);
            this.excludeSymbols.TabIndex = 22;
            this.excludeSymbols.Text = "Exclude symbols?";
            // 
            // PwdGenUI
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(368, 350);
            this.Controls.Add(this.excludeSymbols);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.exclude);
            this.Controls.Add(this.genPwd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maxSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.repeating);
            this.Controls.Add(this.consecutive);
            this.Controls.Add(this.btnGenerate);
            this.Name = "PwdGenUI";
            this.Text = "Password Generator";
            this.Load += new System.EventHandler(this.PwdGenUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maxSize)).EndInit();
            this.ResumeLayout(false);

        }
		#endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() 
        {
            Application.Run(new PwdGenUI());
        }

        private void PwdGenUI_Load(object sender, System.EventArgs e)
        {
            pwdGen = new PasswordGenerator();
        }

        private void btnGenerate_Click(object sender, System.EventArgs e)
        {
            if ( null != pwdGen)
            {
                if ( ( null != this.exclude.Text ) || ( String.Empty != this.exclude.Text ) )
                {
                    pwdGen.Exclusions = this.exclude.Text;
                }
                pwdGen.Maximum = this.maxSize.Value;
                pwdGen.ConsecutiveCharacters = this.consecutive.Checked;
                pwdGen.RepeatCharacters = this.repeating.Checked;
                pwdGen.ExcludeSymbols = this.excludeSymbols.Checked;
                genPwd.Text = pwdGen.Generate();
            }
        }
    }
}