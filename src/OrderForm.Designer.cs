﻿namespace OptiLineCut.src {
  partial class OrderForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.button1 = new System.Windows.Forms.Button();
      this.tbxCount = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.pnlPgrd = new System.Windows.Forms.Panel();
      this.pgrdTest = new System.Windows.Forms.PropertyGrid();
      this.pnlPgrd.SuspendLayout();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.button1.Location = new System.Drawing.Point(150, 144);
      this.button1.Margin = new System.Windows.Forms.Padding(4);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(127, 27);
      this.button1.TabIndex = 0;
      this.button1.Text = "Ok";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // tbxCount
      // 
      this.tbxCount.Location = new System.Drawing.Point(140, 13);
      this.tbxCount.Margin = new System.Windows.Forms.Padding(4);
      this.tbxCount.Name = "tbxCount";
      this.tbxCount.Size = new System.Drawing.Size(116, 23);
      this.tbxCount.TabIndex = 1;
      this.tbxCount.TextChanged += new System.EventHandler(this.tbxCount_TextChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(43, 16);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(89, 18);
      this.label1.TabIndex = 2;
      this.label1.Text = "Количество:";
      // 
      // pnlPgrd
      // 
      this.pnlPgrd.Controls.Add(this.pgrdTest);
      this.pnlPgrd.Location = new System.Drawing.Point(12, 43);
      this.pnlPgrd.Name = "pnlPgrd";
      this.pnlPgrd.Size = new System.Drawing.Size(265, 94);
      this.pnlPgrd.TabIndex = 3;
      // 
      // pgrdTest
      // 
      this.pgrdTest.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pgrdTest.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.pgrdTest.HelpVisible = false;
      this.pgrdTest.Location = new System.Drawing.Point(0, 0);
      this.pgrdTest.Name = "pgrdTest";
      this.pgrdTest.Size = new System.Drawing.Size(265, 94);
      this.pgrdTest.TabIndex = 5;
      this.pgrdTest.ToolbarVisible = false;
      // 
      // OrderForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(290, 184);
      this.Controls.Add(this.pnlPgrd);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.tbxCount);
      this.Controls.Add(this.button1);
      this.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "OrderForm";
      this.Text = "Деталь заказа";
      this.pnlPgrd.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox tbxCount;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel pnlPgrd;
    private System.Windows.Forms.PropertyGrid pgrdTest;
  }
}