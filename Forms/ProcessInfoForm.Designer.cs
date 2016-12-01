﻿namespace ReClassNET.Forms
{
	partial class ProcessInfoForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.sectionContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.setCurrentClassAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.createClassAtAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.dumpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sectionsDataGridView = new System.Windows.Forms.DataGridView();
			this.addressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sizeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.protectionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.typeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.moduleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bannerBox1 = new ReClassNET.UI.BannerBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.modulesTabPage = new System.Windows.Forms.TabPage();
			this.modulesDataGridView = new System.Windows.Forms.DataGridView();
			this.moduleAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.moduleSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.modulePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sectionsTabPage = new System.Windows.Forms.TabPage();
			this.sectionContextMenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.sectionsDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bannerBox1)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.modulesTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.modulesDataGridView)).BeginInit();
			this.sectionsTabPage.SuspendLayout();
			this.SuspendLayout();
			// 
			// sectionContextMenuStrip
			// 
			this.sectionContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setCurrentClassAddressToolStripMenuItem,
            this.toolStripSeparator1,
            this.createClassAtAddressToolStripMenuItem,
            this.toolStripSeparator2,
            this.dumpToolStripMenuItem});
			this.sectionContextMenuStrip.Name = "contextMenuStrip";
			this.sectionContextMenuStrip.Size = new System.Drawing.Size(203, 82);
			// 
			// setCurrentClassAddressToolStripMenuItem
			// 
			this.setCurrentClassAddressToolStripMenuItem.Image = global::ReClassNET.Properties.Resources.B16x16_Exchange_Button;
			this.setCurrentClassAddressToolStripMenuItem.Name = "setCurrentClassAddressToolStripMenuItem";
			this.setCurrentClassAddressToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
			this.setCurrentClassAddressToolStripMenuItem.Text = "Set current class address";
			this.setCurrentClassAddressToolStripMenuItem.Click += new System.EventHandler(this.setCurrentClassAddressToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(199, 6);
			// 
			// createClassAtAddressToolStripMenuItem
			// 
			this.createClassAtAddressToolStripMenuItem.Image = global::ReClassNET.Properties.Resources.B16x16_Button_Class_Add;
			this.createClassAtAddressToolStripMenuItem.Name = "createClassAtAddressToolStripMenuItem";
			this.createClassAtAddressToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
			this.createClassAtAddressToolStripMenuItem.Text = "Create class at address";
			this.createClassAtAddressToolStripMenuItem.Click += new System.EventHandler(this.createClassAtAddressToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(199, 6);
			// 
			// dumpToolStripMenuItem
			// 
			this.dumpToolStripMenuItem.Name = "dumpToolStripMenuItem";
			this.dumpToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
			this.dumpToolStripMenuItem.Text = "Dump...";
			this.dumpToolStripMenuItem.Click += new System.EventHandler(this.dumpToolStripMenuItem_Click);
			// 
			// sectionsDataGridView
			// 
			this.sectionsDataGridView.AllowUserToAddRows = false;
			this.sectionsDataGridView.AllowUserToDeleteRows = false;
			this.sectionsDataGridView.AllowUserToResizeRows = false;
			this.sectionsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.sectionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.sectionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addressColumn,
            this.sizeColumn,
            this.nameColumn,
            this.protectionColumn,
            this.typeColumn,
            this.moduleColumn});
			this.sectionsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sectionsDataGridView.Location = new System.Drawing.Point(3, 3);
			this.sectionsDataGridView.MultiSelect = false;
			this.sectionsDataGridView.Name = "sectionsDataGridView";
			this.sectionsDataGridView.ReadOnly = true;
			this.sectionsDataGridView.RowHeadersVisible = false;
			this.sectionsDataGridView.RowTemplate.ContextMenuStrip = this.sectionContextMenuStrip;
			this.sectionsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.sectionsDataGridView.Size = new System.Drawing.Size(796, 386);
			this.sectionsDataGridView.TabIndex = 0;
			this.sectionsDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.sectionsDataGridView_CellMouseDoubleClick);
			this.sectionsDataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SelectRow_CellMouseDown);
			// 
			// addressColumn
			// 
			this.addressColumn.DataPropertyName = "address";
			dataGridViewCellStyle1.Format = "X";
			this.addressColumn.DefaultCellStyle = dataGridViewCellStyle1;
			this.addressColumn.HeaderText = "Address";
			this.addressColumn.Name = "addressColumn";
			this.addressColumn.ReadOnly = true;
			// 
			// sizeColumn
			// 
			this.sizeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.sizeColumn.DataPropertyName = "size";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle2.Format = "X";
			this.sizeColumn.DefaultCellStyle = dataGridViewCellStyle2;
			this.sizeColumn.HeaderText = "Size";
			this.sizeColumn.Name = "sizeColumn";
			this.sizeColumn.ReadOnly = true;
			this.sizeColumn.Width = 52;
			// 
			// nameColumn
			// 
			this.nameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.nameColumn.DataPropertyName = "name";
			this.nameColumn.HeaderText = "Name";
			this.nameColumn.Name = "nameColumn";
			this.nameColumn.ReadOnly = true;
			this.nameColumn.Width = 60;
			// 
			// protectionColumn
			// 
			this.protectionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.protectionColumn.DataPropertyName = "protection";
			this.protectionColumn.HeaderText = "Protection";
			this.protectionColumn.Name = "protectionColumn";
			this.protectionColumn.ReadOnly = true;
			this.protectionColumn.Width = 80;
			// 
			// typeColumn
			// 
			this.typeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.typeColumn.DataPropertyName = "type";
			this.typeColumn.HeaderText = "Type";
			this.typeColumn.Name = "typeColumn";
			this.typeColumn.ReadOnly = true;
			this.typeColumn.Width = 56;
			// 
			// moduleColumn
			// 
			this.moduleColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.moduleColumn.DataPropertyName = "module";
			this.moduleColumn.HeaderText = "Module";
			this.moduleColumn.Name = "moduleColumn";
			this.moduleColumn.ReadOnly = true;
			// 
			// bannerBox1
			// 
			this.bannerBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.bannerBox1.Icon = global::ReClassNET.Properties.Resources.B32x32_Magnifier;
			this.bannerBox1.Location = new System.Drawing.Point(0, 0);
			this.bannerBox1.Name = "bannerBox1";
			this.bannerBox1.Size = new System.Drawing.Size(834, 48);
			this.bannerBox1.TabIndex = 2;
			this.bannerBox1.Text = "View informations about the current process.";
			this.bannerBox1.Title = "Process Informations";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.modulesTabPage);
			this.tabControl1.Controls.Add(this.sectionsTabPage);
			this.tabControl1.Location = new System.Drawing.Point(12, 60);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(810, 418);
			this.tabControl1.TabIndex = 3;
			// 
			// modulesTabPage
			// 
			this.modulesTabPage.Controls.Add(this.modulesDataGridView);
			this.modulesTabPage.Location = new System.Drawing.Point(4, 22);
			this.modulesTabPage.Name = "modulesTabPage";
			this.modulesTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.modulesTabPage.Size = new System.Drawing.Size(802, 392);
			this.modulesTabPage.TabIndex = 1;
			this.modulesTabPage.Text = "Modules";
			this.modulesTabPage.UseVisualStyleBackColor = true;
			// 
			// modulesDataGridView
			// 
			this.modulesDataGridView.AllowUserToAddRows = false;
			this.modulesDataGridView.AllowUserToDeleteRows = false;
			this.modulesDataGridView.AllowUserToResizeRows = false;
			this.modulesDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.modulesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.modulesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.moduleAddressDataGridViewTextBoxColumn,
            this.moduleSizeDataGridViewTextBoxColumn,
            this.modulePathDataGridViewTextBoxColumn});
			this.modulesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.modulesDataGridView.Location = new System.Drawing.Point(3, 3);
			this.modulesDataGridView.MultiSelect = false;
			this.modulesDataGridView.Name = "modulesDataGridView";
			this.modulesDataGridView.ReadOnly = true;
			this.modulesDataGridView.RowHeadersVisible = false;
			this.modulesDataGridView.RowTemplate.ContextMenuStrip = this.sectionContextMenuStrip;
			this.modulesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.modulesDataGridView.Size = new System.Drawing.Size(796, 386);
			this.modulesDataGridView.TabIndex = 1;
			this.modulesDataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SelectRow_CellMouseDown);
			// 
			// moduleAddressDataGridViewTextBoxColumn
			// 
			this.moduleAddressDataGridViewTextBoxColumn.DataPropertyName = "address";
			dataGridViewCellStyle3.Format = "X";
			this.moduleAddressDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
			this.moduleAddressDataGridViewTextBoxColumn.HeaderText = "Address";
			this.moduleAddressDataGridViewTextBoxColumn.Name = "moduleAddressDataGridViewTextBoxColumn";
			this.moduleAddressDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// moduleSizeDataGridViewTextBoxColumn
			// 
			this.moduleSizeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.moduleSizeDataGridViewTextBoxColumn.DataPropertyName = "size";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle4.Format = "X";
			this.moduleSizeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
			this.moduleSizeDataGridViewTextBoxColumn.HeaderText = "Size";
			this.moduleSizeDataGridViewTextBoxColumn.Name = "moduleSizeDataGridViewTextBoxColumn";
			this.moduleSizeDataGridViewTextBoxColumn.ReadOnly = true;
			this.moduleSizeDataGridViewTextBoxColumn.Width = 52;
			// 
			// modulePathDataGridViewTextBoxColumn
			// 
			this.modulePathDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.modulePathDataGridViewTextBoxColumn.DataPropertyName = "path";
			this.modulePathDataGridViewTextBoxColumn.HeaderText = "Path";
			this.modulePathDataGridViewTextBoxColumn.Name = "modulePathDataGridViewTextBoxColumn";
			this.modulePathDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// sectionsTabPage
			// 
			this.sectionsTabPage.Controls.Add(this.sectionsDataGridView);
			this.sectionsTabPage.Location = new System.Drawing.Point(4, 22);
			this.sectionsTabPage.Name = "sectionsTabPage";
			this.sectionsTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.sectionsTabPage.Size = new System.Drawing.Size(802, 392);
			this.sectionsTabPage.TabIndex = 0;
			this.sectionsTabPage.Text = "Memory Regions";
			this.sectionsTabPage.UseVisualStyleBackColor = true;
			// 
			// ProcessMemoryViewForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(834, 490);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.bannerBox1);
			this.MinimumSize = new System.Drawing.Size(586, 320);
			this.Name = "ProcessMemoryViewForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "ReClass.NET - Memory Viewer";
			this.sectionContextMenuStrip.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.sectionsDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bannerBox1)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.modulesTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.modulesDataGridView)).EndInit();
			this.sectionsTabPage.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView sectionsDataGridView;
		private System.Windows.Forms.ContextMenuStrip sectionContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem setCurrentClassAddressToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem createClassAtAddressToolStripMenuItem;
		private UI.BannerBox bannerBox1;
		private System.Windows.Forms.DataGridViewTextBoxColumn addressColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn sizeColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn protectionColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn typeColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn moduleColumn;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage modulesTabPage;
		private System.Windows.Forms.DataGridView modulesDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn moduleAddressDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn moduleSizeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn modulePathDataGridViewTextBoxColumn;
		private System.Windows.Forms.TabPage sectionsTabPage;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem dumpToolStripMenuItem;
	}
}