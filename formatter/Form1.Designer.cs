namespace formatter
{
    partial class frmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private System.Windows.Forms.RichTextBox txtInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Button cmdInvia;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RichTextBox txtOutput;
    }
}

