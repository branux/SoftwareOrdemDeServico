﻿namespace View.OS
{
    partial class Frm_ListarOrcamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ListarOrcamento));
            this.Btm_Atualizar = new System.Windows.Forms.Button();
            this.Data_Os = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Os)).BeginInit();
            this.SuspendLayout();
            // 
            // Btm_Atualizar
            // 
            this.Btm_Atualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btm_Atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btm_Atualizar.Location = new System.Drawing.Point(983, 405);
            this.Btm_Atualizar.Name = "Btm_Atualizar";
            this.Btm_Atualizar.Size = new System.Drawing.Size(123, 23);
            this.Btm_Atualizar.TabIndex = 3;
            this.Btm_Atualizar.Text = "Atualizar";
            this.Btm_Atualizar.UseVisualStyleBackColor = true;
            this.Btm_Atualizar.Click += new System.EventHandler(this.Btm_Atualizar_Click);
            // 
            // Data_Os
            // 
            this.Data_Os.AllowUserToAddRows = false;
            this.Data_Os.AllowUserToDeleteRows = false;
            this.Data_Os.AllowUserToOrderColumns = true;
            this.Data_Os.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Data_Os.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Data_Os.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Data_Os.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_Os.EnableHeadersVisualStyles = false;
            this.Data_Os.Location = new System.Drawing.Point(2, 0);
            this.Data_Os.MultiSelect = false;
            this.Data_Os.Name = "Data_Os";
            this.Data_Os.ReadOnly = true;
            this.Data_Os.Size = new System.Drawing.Size(1127, 388);
            this.Data_Os.TabIndex = 2;
            this.Data_Os.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_Os_CellContentClick);
            this.Data_Os.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Data_Os_CellMouseDoubleClick);
            // 
            // Frm_ListarOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1131, 440);
            this.Controls.Add(this.Btm_Atualizar);
            this.Controls.Add(this.Data_Os);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_ListarOrcamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de orcamentos";
            this.Load += new System.EventHandler(this.Frm_ListarOrcamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data_Os)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btm_Atualizar;
        private System.Windows.Forms.DataGridView Data_Os;
    }
}