namespace GestionEmpleados
{
    partial class Inicio
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
            homeMenu = new MenuStrip();
            adminMenuItem = new ToolStripMenuItem();
            usuariosSysSubMenuItem = new ToolStripMenuItem();
            empleadosMenuItem = new ToolStripMenuItem();
            EmpleadosSubMenuItem = new ToolStripMenuItem();
            AdelantosSubMenuItem = new ToolStripMenuItem();
            PrestamosSubMenuItem = new ToolStripMenuItem();
            homeMenu.SuspendLayout();
            SuspendLayout();
            // 
            // homeMenu
            // 
            homeMenu.AutoSize = false;
            homeMenu.BackColor = SystemColors.ActiveCaption;
            homeMenu.Font = new Font("Sitka Small", 15F);
            homeMenu.ImageScalingSize = new Size(20, 20);
            homeMenu.Items.AddRange(new ToolStripItem[] { adminMenuItem, empleadosMenuItem });
            homeMenu.Location = new Point(0, 0);
            homeMenu.Name = "homeMenu";
            homeMenu.Padding = new Padding(5, 2, 0, 2);
            homeMenu.Size = new Size(800, 82);
            homeMenu.TabIndex = 1;
            homeMenu.Text = "home_menu";
            // 
            // adminMenuItem
            // 
            adminMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuariosSysSubMenuItem });
            adminMenuItem.Name = "adminMenuItem";
            adminMenuItem.Size = new Size(180, 78);
            adminMenuItem.Text = "Administración";
            // 
            // usuariosSysSubMenuItem
            // 
            usuariosSysSubMenuItem.Name = "usuariosSysSubMenuItem";
            usuariosSysSubMenuItem.Size = new Size(180, 34);
            usuariosSysSubMenuItem.Text = "Usuarios";
            usuariosSysSubMenuItem.Click += usuariosSysSubMenuItem_Click;
            // 
            // empleadosMenuItem
            // 
            empleadosMenuItem.DropDownItems.AddRange(new ToolStripItem[] { EmpleadosSubMenuItem, AdelantosSubMenuItem, PrestamosSubMenuItem });
            empleadosMenuItem.Name = "empleadosMenuItem";
            empleadosMenuItem.Size = new Size(136, 78);
            empleadosMenuItem.Text = "Empleados";
            // 
            // EmpleadosSubMenuItem
            // 
            EmpleadosSubMenuItem.Name = "EmpleadosSubMenuItem";
            EmpleadosSubMenuItem.Size = new Size(197, 34);
            EmpleadosSubMenuItem.Text = "Empleados";
            EmpleadosSubMenuItem.Click += EmpleadosSubMenuItem_Click;
            // 
            // AdelantosSubMenuItem
            // 
            AdelantosSubMenuItem.Name = "AdelantosSubMenuItem";
            AdelantosSubMenuItem.Size = new Size(197, 34);
            AdelantosSubMenuItem.Text = "Adelantos";
            // 
            // PrestamosSubMenuItem
            // 
            PrestamosSubMenuItem.Name = "PrestamosSubMenuItem";
            PrestamosSubMenuItem.Size = new Size(197, 34);
            PrestamosSubMenuItem.Text = "Prestamos";
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(homeMenu);
            Name = "Inicio";
            Text = "Inicio";
            WindowState = FormWindowState.Maximized;
            homeMenu.ResumeLayout(false);
            homeMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip homeMenu;
        private ToolStripMenuItem adminMenuItem;
        private ToolStripMenuItem usuariosSysSubMenuItem;
        private ToolStripMenuItem empleadosMenuItem;
        private ToolStripMenuItem EmpleadosSubMenuItem;
        private ToolStripMenuItem AdelantosSubMenuItem;
        private ToolStripMenuItem PrestamosSubMenuItem;
    }
}