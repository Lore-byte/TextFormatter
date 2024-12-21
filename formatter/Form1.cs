using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formatter
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;  
            this.MaximizeBox = false;
            this.Text = "Formatter";
        }

        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.cmdInvia = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.Location = new System.Drawing.Point(12, 29);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(385, 148);
            this.txtInput.TabIndex = 0;
            this.txtInput.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(173, 265);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(0, 13);
            this.lblInput.TabIndex = 3;
            this.lblInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdInvia
            // 
            this.cmdInvia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdInvia.Location = new System.Drawing.Point(74, 183);
            this.cmdInvia.Name = "cmdInvia";
            this.cmdInvia.Size = new System.Drawing.Size(323, 37);
            this.cmdInvia.TabIndex = 6;
            this.cmdInvia.Text = "FORMAT";
            this.cmdInvia.UseVisualStyleBackColor = true;
            this.cmdInvia.Click += new System.EventHandler(this.cmdInvia_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 203);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(58, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Output";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(12, 226);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(385, 148);
            this.txtOutput.TabIndex = 10;
            this.txtOutput.Text = "";
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(416, 390);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cmdInvia);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInput);
            this.Name = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void cmdInvia_Click(object sender, EventArgs e)
        {
            try
            {

                string inputText = txtInput.Text;

                string formattedText = System.Text.RegularExpressions.Regex.Replace(inputText, @"\s+", " ").Trim();

                string formattedText1 = System.Text.RegularExpressions.Regex.Replace(formattedText, "- " , "").Trim();

                txtOutput.Text = formattedText1;

                Clipboard.SetDataObject(formattedText1);

                txtInput.Clear();
            
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"Si è verificato un errore: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            txtOutput.Visible = checkBox1.Checked;

            if (!checkBox1.Checked)
            { 
                this.ClientSize = new System.Drawing.Size(416, 230); 
            }
            else
            {
                this.ClientSize = new System.Drawing.Size(416, 390); 
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(416, 225);
        }
    }
}
