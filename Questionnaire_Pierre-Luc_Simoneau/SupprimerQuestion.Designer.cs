﻿namespace Questionnaire_Pierre_Luc_Simoneau
{
    partial class SupprimerQuestion
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox2 = new GroupBox();
            btnSupprimer = new Button();
            txtId = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSupprimer);
            groupBox2.Controls.Add(txtId);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(94, 67);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(462, 154);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSupprimer.Location = new Point(167, 87);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(117, 41);
            btnSupprimer.TabIndex = 2;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // txtId
            // 
            txtId.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(215, 43);
            txtId.Name = "txtId";
            txtId.Size = new Size(190, 21);
            txtId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(16, 46);
            label1.Name = "label1";
            label1.Size = new Size(175, 18);
            label1.TabIndex = 0;
            label1.Text = "Saisir l'ID de la question";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(label3);
            panel1.Location = new Point(18, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(644, 38);
            panel1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(192, 3);
            label3.Name = "label3";
            label3.Size = new Size(250, 30);
            label3.TabIndex = 0;
            label3.Text = "Supprimer une Question";
            // 
            // SupprimerQuestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Name = "SupprimerQuestion";
            Size = new Size(695, 260);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private Button btnSupprimer;
        private TextBox txtId;
        private Label label1;
        private Panel panel1;
        private Label label3;
    }
}
