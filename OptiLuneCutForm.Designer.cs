namespace OptiLineCut {
  partial class OptiLuneCutForm {
    /// <summary>
    /// Требуется переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Обязательный метод для поддержки конструктора - не изменяйте
    /// содержимое данного метода при помощи редактора кода.
    /// </summary>
    private void InitializeComponent() {
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuFilESaveTask = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuFilELoadTask = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
      this.pnlLeft = new System.Windows.Forms.Panel();
      this.pnlTaskMain = new System.Windows.Forms.Panel();
      this.panel3 = new System.Windows.Forms.Panel();
      this.btnRemoveOrderDet = new System.Windows.Forms.Button();
      this.btnAddOrderDet = new System.Windows.Forms.Button();
      this.lbxOrderDetails = new System.Windows.Forms.ListBox();
      this.pgrdOrderDetail = new System.Windows.Forms.PropertyGrid();
      this.label4 = new System.Windows.Forms.Label();
      this.btnCompute = new System.Windows.Forms.Button();
      this.panel2 = new System.Windows.Forms.Panel();
      this.pgrdTest = new System.Windows.Forms.PropertyGrid();
      this.label3 = new System.Windows.Forms.Label();
      this.panel4 = new System.Windows.Forms.Panel();
      this.tbxCutTHick = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label2 = new System.Windows.Forms.Label();
      this.cmbDimension = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.splWork = new System.Windows.Forms.SplitContainer();
      this.dgvAllCuts = new System.Windows.Forms.DataGridView();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.splMain = new System.Windows.Forms.SplitContainer();
      this.dgvSimplexMethod = new System.Windows.Forms.DataGridView();
      this.menuStrip1.SuspendLayout();
      this.pnlLeft.SuspendLayout();
      this.pnlTaskMain.SuspendLayout();
      this.panel3.SuspendLayout();
      this.panel2.SuspendLayout();
      this.panel4.SuspendLayout();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splWork)).BeginInit();
      this.splWork.Panel1.SuspendLayout();
      this.splWork.Panel2.SuspendLayout();
      this.splWork.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvAllCuts)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.splMain)).BeginInit();
      this.splMain.Panel1.SuspendLayout();
      this.splMain.Panel2.SuspendLayout();
      this.splMain.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvSimplexMethod)).BeginInit();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(812, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // mnuFile
      // 
      this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFilESaveTask,
            this.mnuFilELoadTask,
            this.toolStripSeparator1,
            this.mnuFileExit});
      this.mnuFile.Name = "mnuFile";
      this.mnuFile.Size = new System.Drawing.Size(48, 20);
      this.mnuFile.Text = "Файл";
      // 
      // mnuFilESaveTask
      // 
      this.mnuFilESaveTask.Name = "mnuFilESaveTask";
      this.mnuFilESaveTask.Size = new System.Drawing.Size(141, 22);
      this.mnuFilESaveTask.Text = "Сохранить...";
      this.mnuFilESaveTask.Click += new System.EventHandler(this.mnuFilESaveTask_Click);
      // 
      // mnuFilELoadTask
      // 
      this.mnuFilELoadTask.Name = "mnuFilELoadTask";
      this.mnuFilELoadTask.Size = new System.Drawing.Size(141, 22);
      this.mnuFilELoadTask.Text = "Открыть...";
      this.mnuFilELoadTask.Click += new System.EventHandler(this.mnuFilELoadTask_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(138, 6);
      // 
      // mnuFileExit
      // 
      this.mnuFileExit.Name = "mnuFileExit";
      this.mnuFileExit.Size = new System.Drawing.Size(141, 22);
      this.mnuFileExit.Text = "Выход";
      this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
      // 
      // pnlLeft
      // 
      this.pnlLeft.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
      this.pnlLeft.Controls.Add(this.pnlTaskMain);
      this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlLeft.Location = new System.Drawing.Point(0, 0);
      this.pnlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.pnlLeft.Name = "pnlLeft";
      this.pnlLeft.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.pnlLeft.Size = new System.Drawing.Size(220, 609);
      this.pnlLeft.TabIndex = 1;
      // 
      // pnlTaskMain
      // 
      this.pnlTaskMain.BackColor = System.Drawing.SystemColors.Control;
      this.pnlTaskMain.Controls.Add(this.panel3);
      this.pnlTaskMain.Controls.Add(this.btnCompute);
      this.pnlTaskMain.Controls.Add(this.panel2);
      this.pnlTaskMain.Controls.Add(this.panel4);
      this.pnlTaskMain.Controls.Add(this.panel1);
      this.pnlTaskMain.Controls.Add(this.label1);
      this.pnlTaskMain.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlTaskMain.Location = new System.Drawing.Point(3, 4);
      this.pnlTaskMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.pnlTaskMain.Name = "pnlTaskMain";
      this.pnlTaskMain.Padding = new System.Windows.Forms.Padding(1);
      this.pnlTaskMain.Size = new System.Drawing.Size(214, 540);
      this.pnlTaskMain.TabIndex = 0;
      // 
      // panel3
      // 
      this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
      this.panel3.Controls.Add(this.btnRemoveOrderDet);
      this.panel3.Controls.Add(this.btnAddOrderDet);
      this.panel3.Controls.Add(this.lbxOrderDetails);
      this.panel3.Controls.Add(this.pgrdOrderDetail);
      this.panel3.Controls.Add(this.label4);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel3.Location = new System.Drawing.Point(1, 226);
      this.panel3.Name = "panel3";
      this.panel3.Padding = new System.Windows.Forms.Padding(3);
      this.panel3.Size = new System.Drawing.Size(212, 265);
      this.panel3.TabIndex = 7;
      // 
      // btnRemoveOrderDet
      // 
      this.btnRemoveOrderDet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnRemoveOrderDet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnRemoveOrderDet.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.btnRemoveOrderDet.Location = new System.Drawing.Point(186, 51);
      this.btnRemoveOrderDet.Name = "btnRemoveOrderDet";
      this.btnRemoveOrderDet.Size = new System.Drawing.Size(22, 26);
      this.btnRemoveOrderDet.TabIndex = 7;
      this.btnRemoveOrderDet.Text = "-";
      this.btnRemoveOrderDet.UseVisualStyleBackColor = true;
      this.btnRemoveOrderDet.Click += new System.EventHandler(this.btnRemoveOrderDet_Click);
      // 
      // btnAddOrderDet
      // 
      this.btnAddOrderDet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnAddOrderDet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnAddOrderDet.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.btnAddOrderDet.Location = new System.Drawing.Point(186, 24);
      this.btnAddOrderDet.Name = "btnAddOrderDet";
      this.btnAddOrderDet.Size = new System.Drawing.Size(22, 26);
      this.btnAddOrderDet.TabIndex = 6;
      this.btnAddOrderDet.Text = "+";
      this.btnAddOrderDet.UseVisualStyleBackColor = true;
      this.btnAddOrderDet.Click += new System.EventHandler(this.btnAddOrderDet_Click);
      // 
      // lbxOrderDetails
      // 
      this.lbxOrderDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lbxOrderDetails.FormattingEnabled = true;
      this.lbxOrderDetails.ItemHeight = 16;
      this.lbxOrderDetails.Location = new System.Drawing.Point(3, 24);
      this.lbxOrderDetails.Name = "lbxOrderDetails";
      this.lbxOrderDetails.Size = new System.Drawing.Size(180, 132);
      this.lbxOrderDetails.TabIndex = 5;
      this.lbxOrderDetails.SelectedIndexChanged += new System.EventHandler(this.lbxOrderDetails_SelectedIndexChanged);
      this.lbxOrderDetails.DoubleClick += new System.EventHandler(this.lbxOrderDetails_DoubleClick);
      // 
      // pgrdOrderDetail
      // 
      this.pgrdOrderDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.pgrdOrderDetail.HelpVisible = false;
      this.pgrdOrderDetail.Location = new System.Drawing.Point(3, 159);
      this.pgrdOrderDetail.Name = "pgrdOrderDetail";
      this.pgrdOrderDetail.Size = new System.Drawing.Size(206, 103);
      this.pgrdOrderDetail.TabIndex = 4;
      this.pgrdOrderDetail.ToolbarVisible = false;
      // 
      // label4
      // 
      this.label4.BackColor = System.Drawing.Color.Transparent;
      this.label4.Dock = System.Windows.Forms.DockStyle.Top;
      this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label4.Location = new System.Drawing.Point(3, 3);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(206, 21);
      this.label4.TabIndex = 1;
      this.label4.Text = "Заказ";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // btnCompute
      // 
      this.btnCompute.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.btnCompute.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.btnCompute.Location = new System.Drawing.Point(1, 511);
      this.btnCompute.Name = "btnCompute";
      this.btnCompute.Size = new System.Drawing.Size(212, 28);
      this.btnCompute.TabIndex = 6;
      this.btnCompute.Text = "Решить";
      this.btnCompute.UseVisualStyleBackColor = true;
      this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
      this.panel2.Controls.Add(this.pgrdTest);
      this.panel2.Controls.Add(this.label3);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(1, 88);
      this.panel2.Name = "panel2";
      this.panel2.Padding = new System.Windows.Forms.Padding(3);
      this.panel2.Size = new System.Drawing.Size(212, 138);
      this.panel2.TabIndex = 5;
      // 
      // pgrdTest
      // 
      this.pgrdTest.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pgrdTest.HelpVisible = false;
      this.pgrdTest.Location = new System.Drawing.Point(3, 24);
      this.pgrdTest.Name = "pgrdTest";
      this.pgrdTest.Size = new System.Drawing.Size(206, 111);
      this.pgrdTest.TabIndex = 4;
      this.pgrdTest.ToolbarVisible = false;
      // 
      // label3
      // 
      this.label3.BackColor = System.Drawing.Color.Transparent;
      this.label3.Dock = System.Windows.Forms.DockStyle.Top;
      this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label3.Location = new System.Drawing.Point(3, 3);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(206, 21);
      this.label3.TabIndex = 1;
      this.label3.Text = "Заготовка";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // panel4
      // 
      this.panel4.Controls.Add(this.tbxCutTHick);
      this.panel4.Controls.Add(this.label5);
      this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel4.Location = new System.Drawing.Point(1, 61);
      this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.panel4.Name = "panel4";
      this.panel4.Padding = new System.Windows.Forms.Padding(3);
      this.panel4.Size = new System.Drawing.Size(212, 27);
      this.panel4.TabIndex = 8;
      // 
      // tbxCutTHick
      // 
      this.tbxCutTHick.Dock = System.Windows.Forms.DockStyle.Right;
      this.tbxCutTHick.Location = new System.Drawing.Point(115, 3);
      this.tbxCutTHick.Name = "tbxCutTHick";
      this.tbxCutTHick.Size = new System.Drawing.Size(94, 20);
      this.tbxCutTHick.TabIndex = 3;
      this.tbxCutTHick.Text = "0.05";
      this.tbxCutTHick.TextChanged += new System.EventHandler(this.tbxCutTHick_TextChanged);
      // 
      // label5
      // 
      this.label5.Dock = System.Windows.Forms.DockStyle.Left;
      this.label5.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label5.Location = new System.Drawing.Point(3, 3);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(132, 21);
      this.label5.TabIndex = 2;
      this.label5.Text = "Величина среза:";
      this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.cmbDimension);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(1, 31);
      this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.panel1.Name = "panel1";
      this.panel1.Padding = new System.Windows.Forms.Padding(3);
      this.panel1.Size = new System.Drawing.Size(212, 30);
      this.panel1.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.Dock = System.Windows.Forms.DockStyle.Left;
      this.label2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(3, 3);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(132, 24);
      this.label2.TabIndex = 2;
      this.label2.Text = "Размерность:";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // cmbDimension
      // 
      this.cmbDimension.Dock = System.Windows.Forms.DockStyle.Right;
      this.cmbDimension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbDimension.FormattingEnabled = true;
      this.cmbDimension.Items.AddRange(new object[] {
            "1",
            "2"});
      this.cmbDimension.Location = new System.Drawing.Point(170, 3);
      this.cmbDimension.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.cmbDimension.Name = "cmbDimension";
      this.cmbDimension.Size = new System.Drawing.Size(39, 24);
      this.cmbDimension.TabIndex = 1;
      this.cmbDimension.SelectedIndexChanged += new System.EventHandler(this.cmbDimension_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
      this.label1.Dock = System.Windows.Forms.DockStyle.Top;
      this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(1, 1);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(212, 30);
      this.label1.TabIndex = 0;
      this.label1.Text = "Задача";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // splWork
      // 
      this.splWork.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splWork.Location = new System.Drawing.Point(0, 0);
      this.splWork.Name = "splWork";
      this.splWork.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splWork.Panel1
      // 
      this.splWork.Panel1.Controls.Add(this.dgvAllCuts);
      this.splWork.Panel1.Controls.Add(this.label6);
      this.splWork.Panel1MinSize = 100;
      // 
      // splWork.Panel2
      // 
      this.splWork.Panel2.Controls.Add(this.dgvSimplexMethod);
      this.splWork.Panel2.Controls.Add(this.label7);
      this.splWork.Panel2MinSize = 100;
      this.splWork.Size = new System.Drawing.Size(588, 609);
      this.splWork.SplitterDistance = 155;
      this.splWork.TabIndex = 2;
      // 
      // dgvAllCuts
      // 
      this.dgvAllCuts.AllowUserToAddRows = false;
      this.dgvAllCuts.AllowUserToDeleteRows = false;
      this.dgvAllCuts.AllowUserToResizeColumns = false;
      this.dgvAllCuts.AllowUserToResizeRows = false;
      this.dgvAllCuts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgvAllCuts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
      this.dgvAllCuts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvAllCuts.ColumnHeadersVisible = false;
      this.dgvAllCuts.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgvAllCuts.Location = new System.Drawing.Point(0, 23);
      this.dgvAllCuts.Name = "dgvAllCuts";
      this.dgvAllCuts.ReadOnly = true;
      this.dgvAllCuts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
      this.dgvAllCuts.RowHeadersVisible = false;
      this.dgvAllCuts.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.dgvAllCuts.ShowEditingIcon = false;
      this.dgvAllCuts.Size = new System.Drawing.Size(588, 132);
      this.dgvAllCuts.TabIndex = 1;
      // 
      // label6
      // 
      this.label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
      this.label6.Dock = System.Windows.Forms.DockStyle.Top;
      this.label6.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label6.Location = new System.Drawing.Point(0, 0);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(588, 23);
      this.label6.TabIndex = 2;
      this.label6.Text = "Варианты раскроя";
      this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label7
      // 
      this.label7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
      this.label7.Dock = System.Windows.Forms.DockStyle.Top;
      this.label7.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label7.Location = new System.Drawing.Point(0, 0);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(588, 23);
      this.label7.TabIndex = 3;
      this.label7.Text = "Симплекс";
      this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // splMain
      // 
      this.splMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splMain.Location = new System.Drawing.Point(0, 24);
      this.splMain.Name = "splMain";
      // 
      // splMain.Panel1
      // 
      this.splMain.Panel1.Controls.Add(this.pnlLeft);
      this.splMain.Panel1MinSize = 220;
      // 
      // splMain.Panel2
      // 
      this.splMain.Panel2.Controls.Add(this.splWork);
      this.splMain.Panel2MinSize = 300;
      this.splMain.Size = new System.Drawing.Size(812, 609);
      this.splMain.SplitterDistance = 220;
      this.splMain.TabIndex = 3;
      // 
      // dgvSimplexMethod
      // 
      this.dgvSimplexMethod.AllowUserToAddRows = false;
      this.dgvSimplexMethod.AllowUserToDeleteRows = false;
      this.dgvSimplexMethod.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgvSimplexMethod.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      this.dgvSimplexMethod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvSimplexMethod.ColumnHeadersVisible = false;
      this.dgvSimplexMethod.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgvSimplexMethod.Location = new System.Drawing.Point(0, 23);
      this.dgvSimplexMethod.Name = "dgvSimplexMethod";
      this.dgvSimplexMethod.RowHeadersVisible = false;
      this.dgvSimplexMethod.RowHeadersWidth = 10;
      this.dgvSimplexMethod.Size = new System.Drawing.Size(588, 427);
      this.dgvSimplexMethod.TabIndex = 4;
      // 
      // OptiLuneCutForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(812, 633);
      this.Controls.Add(this.splMain);
      this.Controls.Add(this.menuStrip1);
      this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "OptiLuneCutForm";
      this.Text = "Задача Линейного Раскроя";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.pnlLeft.ResumeLayout(false);
      this.pnlTaskMain.ResumeLayout(false);
      this.panel3.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.panel4.ResumeLayout(false);
      this.panel4.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.splWork.Panel1.ResumeLayout(false);
      this.splWork.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splWork)).EndInit();
      this.splWork.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgvAllCuts)).EndInit();
      this.splMain.Panel1.ResumeLayout(false);
      this.splMain.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splMain)).EndInit();
      this.splMain.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgvSimplexMethod)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem mnuFile;
    private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
    private System.Windows.Forms.Panel pnlLeft;
    private System.Windows.Forms.Panel pnlTaskMain;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox cmbDimension;
    private System.Windows.Forms.PropertyGrid pgrdTest;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btnCompute;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.PropertyGrid pgrdOrderDetail;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ListBox lbxOrderDetails;
    private System.Windows.Forms.Button btnRemoveOrderDet;
    private System.Windows.Forms.Button btnAddOrderDet;
    private System.Windows.Forms.Panel panel4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox tbxCutTHick;
    private System.Windows.Forms.SplitContainer splWork;
    private System.Windows.Forms.DataGridView dgvAllCuts;
    private System.Windows.Forms.ToolStripMenuItem mnuFilESaveTask;
    private System.Windows.Forms.ToolStripMenuItem mnuFilELoadTask;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.SplitContainer splMain;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.DataGridView dgvSimplexMethod;
  }
}

