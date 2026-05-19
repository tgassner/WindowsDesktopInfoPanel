using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsDesktopInfoPanelConfigurator;
partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        lblWidth = new Label();
        numWidth = new NumericUpDown();
        lblHeight = new Label();
        numHeight = new NumericUpDown();
        lblTop = new Label();
        numTop = new NumericUpDown();
        lblMargin = new Label();
        numMargin = new NumericUpDown();
        lblUrl = new Label();
        txtUrl = new TextBox();
        lblColor = new Label();
        txtColor = new TextBox();
        btnSave = new Button();
        btnCancel = new Button();
        colorDialog1 = new ColorDialog();
        ((System.ComponentModel.ISupportInitialize)numWidth).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numHeight).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numTop).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numMargin).BeginInit();
        SuspendLayout();
        // 
        // lblWidth
        // 
        lblWidth.Location = new Point(23, 23);
        lblWidth.Name = "lblWidth";
        lblWidth.Size = new Size(149, 31);
        lblWidth.TabIndex = 0;
        lblWidth.Text = "Breite (px):";
        // 
        // numWidth
        // 
        numWidth.Font = new System.Drawing.Font("Segoe UI", 12F);
        numWidth.Location = new Point(209, 14);
        numWidth.Margin = new Padding(3, 5, 3, 5);
        numWidth.Maximum = new decimal(new int[] { 4000, 0, 0, 0 });
        numWidth.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
        numWidth.Name = "numWidth";
        numWidth.Size = new Size(130, 34);
        numWidth.TabIndex = 1;
        numWidth.Value = new decimal(new int[] { 100, 0, 0, 0 });
        // 
        // lblHeight
        // 
        lblHeight.Location = new Point(23, 67);
        lblHeight.Name = "lblHeight";
        lblHeight.Size = new Size(149, 31);
        lblHeight.TabIndex = 2;
        lblHeight.Text = "Höhe (px):";
        // 
        // numHeight
        // 
        numHeight.Font = new System.Drawing.Font("Segoe UI", 12F);
        numHeight.Location = new Point(209, 58);
        numHeight.Margin = new Padding(3, 5, 3, 5);
        numHeight.Maximum = new decimal(new int[] { 4000, 0, 0, 0 });
        numHeight.Minimum = new decimal(new int[] { 50, 0, 0, 0 });
        numHeight.Name = "numHeight";
        numHeight.Size = new Size(130, 34);
        numHeight.TabIndex = 3;
        numHeight.Value = new decimal(new int[] { 50, 0, 0, 0 });
        // 
        // lblTop
        // 
        lblTop.Location = new Point(23, 116);
        lblTop.Name = "lblTop";
        lblTop.Size = new Size(149, 31);
        lblTop.TabIndex = 4;
        lblTop.Text = "Abstand Oben (px):";
        // 
        // numTop
        // 
        numTop.Font = new System.Drawing.Font("Segoe UI", 12F);
        numTop.Location = new Point(209, 107);
        numTop.Margin = new Padding(3, 5, 3, 5);
        numTop.Maximum = new decimal(new int[] { 4000, 0, 0, 0 });
        numTop.Name = "numTop";
        numTop.Size = new Size(130, 34);
        numTop.TabIndex = 5;
        // 
        // lblMargin
        // 
        lblMargin.Location = new Point(23, 160);
        lblMargin.Name = "lblMargin";
        lblMargin.Size = new Size(149, 31);
        lblMargin.TabIndex = 6;
        lblMargin.Text = "Abstand Rechts (px):";
        // 
        // numMargin
        // 
        numMargin.Font = new System.Drawing.Font("Segoe UI", 12F);
        numMargin.Location = new Point(209, 151);
        numMargin.Margin = new Padding(3, 5, 3, 5);
        numMargin.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
        numMargin.Name = "numMargin";
        numMargin.Size = new Size(130, 34);
        numMargin.TabIndex = 7;
        // 
        // lblUrl
        // 
        lblUrl.Location = new Point(23, 204);
        lblUrl.Name = "lblUrl";
        lblUrl.Size = new Size(149, 31);
        lblUrl.TabIndex = 8;
        lblUrl.Text = "ESP IP / URL:";
        // 
        // txtUrl
        // 
        txtUrl.Font = new System.Drawing.Font("Segoe UI", 12F);
        txtUrl.Location = new Point(209, 194);
        txtUrl.Margin = new Padding(3, 4, 3, 4);
        txtUrl.Name = "txtUrl";
        txtUrl.Size = new Size(693, 34);
        txtUrl.TabIndex = 9;
        // 
        // lblColor
        // 
        lblColor.Location = new Point(23, 246);
        lblColor.Name = "lblColor";
        lblColor.Size = new Size(149, 31);
        lblColor.TabIndex = 10;
        lblColor.Text = "Hintergrund (HEX):";
        // 
        // txtColor
        // 
        txtColor.Font = new System.Drawing.Font("Segoe UI", 12F);
        txtColor.Location = new Point(209, 236);
        txtColor.Margin = new Padding(3, 4, 3, 4);
        txtColor.Name = "txtColor";
        txtColor.Size = new Size(114, 34);
        txtColor.TabIndex = 11;
        // 
        // btnSave
        // 
        btnSave.Location = new Point(23, 281);
        btnSave.Margin = new Padding(3, 4, 3, 4);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(206, 47);
        btnSave.TabIndex = 12;
        btnSave.Text = "Speichern && Schließen";
        btnSave.UseVisualStyleBackColor = true;
        btnSave.Click += btnSave_Click;
        // 
        // btnCancel
        // 
        btnCancel.Location = new Point(235, 281);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(147, 47);
        btnCancel.TabIndex = 13;
        btnCancel.Text = "Cancel && Schießen";
        btnCancel.UseVisualStyleBackColor = true;
        btnCancel.Click += btnCancel_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(914, 600);
        Controls.Add(btnCancel);
        Controls.Add(btnSave);
        Controls.Add(txtColor);
        Controls.Add(lblColor);
        Controls.Add(txtUrl);
        Controls.Add(lblUrl);
        Controls.Add(numMargin);
        Controls.Add(lblMargin);
        Controls.Add(numTop);
        Controls.Add(lblTop);
        Controls.Add(numHeight);
        Controls.Add(lblHeight);
        Controls.Add(numWidth);
        Controls.Add(lblWidth);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(3, 4, 3, 4);
        MaximizeBox = false;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Desktop Panel - Einstellungen";
        ((System.ComponentModel.ISupportInitialize)numWidth).EndInit();
        ((System.ComponentModel.ISupportInitialize)numHeight).EndInit();
        ((System.ComponentModel.ISupportInitialize)numTop).EndInit();
        ((System.ComponentModel.ISupportInitialize)numMargin).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblWidth;
    private NumericUpDown numWidth;
    private Label lblHeight;
    private NumericUpDown numHeight;
    private Label lblTop;
    private NumericUpDown numTop;
    private Label lblMargin;
    private NumericUpDown numMargin;
    private Label lblUrl;
    private TextBox txtUrl;
    private Label lblColor;
    private TextBox txtColor;
    private Button btnSave;
    private Button btnCancel;
    private ColorDialog colorDialog1;
}