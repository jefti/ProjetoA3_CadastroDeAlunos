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
            Land_DataGrid_Alunos = new DataGridView();
            alunoBindingSource = new BindingSource(components);
            dBContextBindingSource = new BindingSource(components);
            dBContextBindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)Land_DataGrid_Alunos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)alunoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dBContextBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dBContextBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // Land_DataGrid_Alunos
            // 
            Land_DataGrid_Alunos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Land_DataGrid_Alunos.Location = new Point(44, 61);
            Land_DataGrid_Alunos.Name = "Land_DataGrid_Alunos";
            Land_DataGrid_Alunos.RowHeadersWidth = 51;
            Land_DataGrid_Alunos.Size = new Size(382, 325);
            Land_DataGrid_Alunos.TabIndex = 1;
            // 
            // alunoBindingSource
            // 
            alunoBindingSource.DataSource = typeof(Repositories.Entities.Aluno);
            // 
            // dBContextBindingSource
            // 
            dBContextBindingSource.DataSource = typeof(Repositories.DBContext);
            // 
            // dBContextBindingSource1
            // 
            dBContextBindingSource1.DataSource = typeof(Repositories.DBContext);
            // 
            // LandingPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Land_DataGrid_Alunos);
            Name = "LandingPage";
            Text = "LandingPage";
            Load += LandingPage_Load;
            Controls.SetChildIndex(Land_DataGrid_Alunos, 0);
            ((System.ComponentModel.ISupportInitialize)Land_DataGrid_Alunos).EndInit();
            ((System.ComponentModel.ISupportInitialize)alunoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dBContextBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dBContextBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Land_DataGrid_Alunos;
        private BindingSource alunoBindingSource;
        private BindingSource dBContextBindingSource;
        private BindingSource dBContextBindingSource1;
    }
}