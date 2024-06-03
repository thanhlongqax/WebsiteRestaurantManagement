﻿namespace Gimji.GUI.Management.CustomerManagement
{
    partial class uc_customer
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_customer));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pal_customer = new Guna.UI2.WinForms.Guna2Panel();
            btn_remove = new Guna.UI2.WinForms.Guna2Button();
            btn_edit = new Guna.UI2.WinForms.Guna2Button();
            lb_point = new Label();
            lb_name = new Label();
            lb_id = new Label();
            lb_stt = new Label();
            pal_customer.SuspendLayout();
            SuspendLayout();
            // 
            // pal_customer
            // 
            pal_customer.BackColor = Color.Transparent;
            pal_customer.BorderColor = Color.FromArgb(224, 224, 224);
            pal_customer.BorderRadius = 5;
            pal_customer.BorderThickness = 1;
            pal_customer.Controls.Add(btn_remove);
            pal_customer.Controls.Add(btn_edit);
            pal_customer.Controls.Add(lb_point);
            pal_customer.Controls.Add(lb_name);
            pal_customer.Controls.Add(lb_id);
            pal_customer.Controls.Add(lb_stt);
            pal_customer.CustomizableEdges = customizableEdges5;
            pal_customer.Location = new Point(0, 0);
            pal_customer.Name = "pal_customer";
            pal_customer.ShadowDecoration.CustomizableEdges = customizableEdges6;
            pal_customer.Size = new Size(546, 37);
            pal_customer.TabIndex = 3;
            // 
            // btn_remove
            // 
            btn_remove.BorderRadius = 5;
            btn_remove.CustomizableEdges = customizableEdges1;
            btn_remove.DisabledState.BorderColor = Color.DarkGray;
            btn_remove.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_remove.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_remove.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_remove.FillColor = Color.Transparent;
            btn_remove.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_remove.ForeColor = Color.White;
            btn_remove.Image = (Image)resources.GetObject("btn_remove.Image");
            btn_remove.ImageSize = new Size(25, 25);
            btn_remove.Location = new Point(506, 6);
            btn_remove.Name = "btn_remove";
            btn_remove.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_remove.Size = new Size(27, 27);
            btn_remove.TabIndex = 5;
            btn_remove.Click += btn_remove_Click;
            // 
            // btn_edit
            // 
            btn_edit.BorderRadius = 5;
            btn_edit.CustomizableEdges = customizableEdges3;
            btn_edit.DisabledState.BorderColor = Color.DarkGray;
            btn_edit.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_edit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_edit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_edit.FillColor = Color.Transparent;
            btn_edit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_edit.ForeColor = Color.White;
            btn_edit.HoverState.BorderColor = Color.White;
            btn_edit.Image = (Image)resources.GetObject("btn_edit.Image");
            btn_edit.ImageSize = new Size(25, 25);
            btn_edit.Location = new Point(475, 6);
            btn_edit.Name = "btn_edit";
            btn_edit.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btn_edit.Size = new Size(27, 27);
            btn_edit.TabIndex = 4;
            btn_edit.Click += btn_edit_Click;
            // 
            // lb_point
            // 
            lb_point.AutoSize = true;
            lb_point.FlatStyle = FlatStyle.Flat;
            lb_point.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_point.ForeColor = SystemColors.ButtonHighlight;
            lb_point.Location = new Point(344, 4);
            lb_point.Name = "lb_point";
            lb_point.Size = new Size(53, 28);
            lb_point.TabIndex = 3;
            lb_point.Text = "1560";
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.BackColor = Color.Transparent;
            lb_name.FlatStyle = FlatStyle.Flat;
            lb_name.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_name.ForeColor = SystemColors.ButtonHighlight;
            lb_name.Location = new Point(218, 4);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(96, 28);
            lb_name.TabIndex = 2;
            lb_name.Text = "Elelphant";
            // 
            // lb_id
            // 
            lb_id.AutoSize = true;
            lb_id.FlatStyle = FlatStyle.Flat;
            lb_id.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_id.ForeColor = SystemColors.ButtonHighlight;
            lb_id.Location = new Point(102, 4);
            lb_id.Name = "lb_id";
            lb_id.Size = new Size(62, 28);
            lb_id.TabIndex = 1;
            lb_id.Text = "#1001";
            // 
            // lb_stt
            // 
            lb_stt.AutoSize = true;
            lb_stt.FlatStyle = FlatStyle.Flat;
            lb_stt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_stt.ForeColor = SystemColors.ButtonHighlight;
            lb_stt.Location = new Point(13, 4);
            lb_stt.Name = "lb_stt";
            lb_stt.Size = new Size(20, 28);
            lb_stt.TabIndex = 0;
            lb_stt.Text = "1";
            // 
            // uc_customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pal_customer);
            Name = "uc_customer";
            Size = new Size(546, 49);
            pal_customer.ResumeLayout(false);
            pal_customer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pal_customer;
        private Guna.UI2.WinForms.Guna2Button btn_remove;
        private Guna.UI2.WinForms.Guna2Button btn_edit;
        private Label lb_point;
        private Label lb_name;
        private Label lb_id;
        private Label lb_stt;
    }
}
