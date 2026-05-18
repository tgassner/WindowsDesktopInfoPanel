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
        components = new System.ComponentModel.Container();
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
        ((System.ComponentModel.ISupportInitialize)numWidth).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numHeight).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numTop).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numMargin).BeginInit();
        SuspendLayout();
        // 
        // lblWidth
        // 
        lblWidth.Location = new Point(20, 20);
        lblWidth.Name = "lblWidth";
        lblWidth.Size = new Size(130, 23);
        lblWidth.TabIndex = 0;
        lblWidth.Text = "Breite (px):";
        // 
        // numWidth
        // 
        numWidth.Location = new Point(160, 18);
        numWidth.Maximum = new decimal(new int[] { 4000, 0, 0, 0 });
        numWidth.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
        numWidth.Name = "numWidth";
        numWidth.Size = new Size(100, 23);
        numWidth.TabIndex = 1;
        numWidth.Value = new decimal(new int[] { 100, 0, 0, 0 });
        // 
        // lblHeight
        // 
        lblHeight.Location = new Point(20, 50);
        lblHeight.Name = "lblHeight";
        lblHeight.Size = new Size(130, 23);
        lblHeight.TabIndex = 2;
        lblHeight.Text = "Höhe (px):";
        // 
        // numHeight
        // 
        numHeight.Location = new Point(160, 48);
        numHeight.Maximum = new decimal(new int[] { 4000, 0, 0, 0 });
        numHeight.Minimum = new decimal(new int[] { 50, 0, 0, 0 });
        numHeight.Name = "numHeight";
        numHeight.Size = new Size(100, 23);
        numHeight.TabIndex = 3;
        numHeight.Value = new decimal(new int[] { 50, 0, 0, 0 });
        // 
        // lblTop
        // 
        lblTop.Location = new Point(20, 80);
        lblTop.Name = "lblTop";
        lblTop.Size = new Size(130, 23);
        lblTop.TabIndex = 4;
        lblTop.Text = "Abstand Oben (px):";
        // 
        // numTop
        // 
        numTop.Location = new Point(160, 78);
        numTop.Maximum = new decimal(new int[] { 4000, 0, 0, 0 });
        numTop.Name = "numTop";
        numTop.Size = new Size(100, 23);
        numTop.TabIndex = 5;
        // 
        // lblMargin
        // 
        lblMargin.Location = new Point(20, 110);
        lblMargin.Name = "lblMargin";
        lblMargin.Size = new Size(130, 23);
        lblMargin.TabIndex = 6;
        lblMargin.Text = "Abstand Rechts (px):";
        // 
        // numMargin
        // 
        numMargin.Location = new Point(160, 108);
        numMargin.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
        numMargin.Name = "numMargin";
        numMargin.Size = new Size(100, 23);
        numMargin.TabIndex = 7;
        // 
        // lblUrl
        // 
        lblUrl.Location = new Point(20, 140);
        lblUrl.Name = "lblUrl";
        lblUrl.Size = new Size(130, 23);
        lblUrl.TabIndex = 8;
        lblUrl.Text = "ESP IP / URL:";
        // 
        // txtUrl
        // 
        txtUrl.Location = new Point(160, 137);
        txtUrl.Name = "txtUrl";
        txtUrl.Size = new Size(200, 23);
        txtUrl.TabIndex = 9;
        // 
        // lblColor
        // 
        lblColor.Location = new Point(20, 170);
        lblColor.Name = "lblColor";
        lblColor.Size = new Size(130, 23);
        lblColor.TabIndex = 10;
        lblColor.Text = "Hintergrund (HEX):";
        // 
        // txtColor
        // 
        txtColor.Location = new Point(160, 167);
        txtColor.Name = "txtColor";
        txtColor.Size = new Size(100, 23);
        txtColor.TabIndex = 11;
        // 
        // btnSave
        // 
        btnSave.Location = new Point(110, 220);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(180, 35);
        btnSave.TabIndex = 12;
        btnSave.Text = "Speichern & Schließen";
        btnSave.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Text = "Form1";
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
}


/*namespace WindowsDesktopInfoPanelConfigurator
{
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
            components = new System.ComponentModel.Container();
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Text = "Form1";
        }

        #endregion
    }
}
*/