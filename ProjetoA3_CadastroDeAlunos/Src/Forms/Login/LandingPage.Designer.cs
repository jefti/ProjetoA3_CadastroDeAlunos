namespace ProjetoA3_CadastroDeAlunos.Src.Forms.LandingPage
{
    partial class LandingPage
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
            components = new System.ComponentModel.Container();
            alunoBindingSource = new BindingSource(components);
            dBContextBindingSource = new BindingSource(components);
            dBContextBindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)alunoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dBContextBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dBContextBindingSource1).BeginInit();
            SuspendLayout();

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "LandingPage";
            Text = "LandingPage";
            Load += LandingPage_Load;
            ((System.ComponentModel.ISupportInitialize)alunoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dBContextBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dBContextBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource alunoBindingSource;
        private BindingSource dBContextBindingSource;
        private BindingSource dBContextBindingSource1;
    }
}