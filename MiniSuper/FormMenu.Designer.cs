namespace MiniSuper
{
    partial class FormMenu
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Factura");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Venta", new System.Windows.Forms.TreeNode[] {
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Compra");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Compra", new System.Windows.Forms.TreeNode[] {
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("AgregarEmpleado");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Empleado", new System.Windows.Forms.TreeNode[] {
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("InsertarProducto");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Producto", new System.Windows.Forms.TreeNode[] {
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("InsertarProveedor");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Proveedor", new System.Windows.Forms.TreeNode[] {
            treeNode21});
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("AgregarSerie");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Serie", new System.Windows.Forms.TreeNode[] {
            treeNode23});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.treeView1.Name = "treeView1";
            treeNode13.Name = "Nodo7";
            treeNode13.Text = "Factura";
            treeNode14.Name = "Nodo0";
            treeNode14.Text = "Venta";
            treeNode15.Name = "Nodo8";
            treeNode15.Text = "Compra";
            treeNode16.Name = "Nodo1";
            treeNode16.Text = "Compra";
            treeNode17.Name = "Nodo9";
            treeNode17.Text = "AgregarEmpleado";
            treeNode18.Name = "Nodo2";
            treeNode18.Text = "Empleado";
            treeNode19.Name = "Nodo10";
            treeNode19.Text = "InsertarProducto";
            treeNode20.Name = "Nodo3";
            treeNode20.Text = "Producto";
            treeNode21.Name = "Nodo11";
            treeNode21.Text = "InsertarProveedor";
            treeNode22.Name = "Nodo4";
            treeNode22.Text = "Proveedor";
            treeNode23.Name = "Nodo12";
            treeNode23.Text = "AgregarSerie";
            treeNode24.Name = "Nodo5";
            treeNode24.Text = "Serie";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode16,
            treeNode18,
            treeNode20,
            treeNode22,
            treeNode24});
            this.treeView1.Size = new System.Drawing.Size(407, 1470);
            this.treeView1.TabIndex = 2;
            this.treeView1.BeforeCheck += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeCheck);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1671, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 93);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(407, 1377);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2271, 93);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(800, 93);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mini Super Mercado \"EL GALLO\"";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::MiniSuper.Properties.Resources._2;
            this.ClientSize = new System.Drawing.Size(2678, 1470);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.treeView1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}