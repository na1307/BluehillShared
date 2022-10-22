﻿#nullable disable
using System.ComponentModel;
using static BluehillShared.AssemblyProperties;

namespace BluehillShared;

/// <summary>
/// 정보 상자 폼
/// </summary>
public class FormAbout : Form {
    private readonly TableLayoutPanel tableLayoutPanel = new();
    private readonly PictureBox logoPictureBox = new();
    private readonly Label labelProductName = new();
    private readonly Label labelVersion = new();
    private readonly Label labelCopyright = new();
    private readonly Label labelCompanyName = new();
    private readonly TextBox textBoxDescription = new();
    private readonly Button okButton = new();

    public FormAbout() : this(null) { }

    public FormAbout(Image image) {
        tableLayoutPanel.SuspendLayout();
        ((ISupportInitialize)logoPictureBox).BeginInit();
        SuspendLayout();
        tableLayoutPanel.ColumnCount = 2;
        tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
        tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67F));
        tableLayoutPanel.Controls.Add(logoPictureBox, 0, 0);
        tableLayoutPanel.Controls.Add(labelProductName, 1, 0);
        tableLayoutPanel.Controls.Add(labelVersion, 1, 1);
        tableLayoutPanel.Controls.Add(labelCopyright, 1, 2);
        tableLayoutPanel.Controls.Add(labelCompanyName, 1, 3);
        tableLayoutPanel.Controls.Add(textBoxDescription, 1, 4);
        tableLayoutPanel.Controls.Add(okButton, 1, 5);
        tableLayoutPanel.Dock = DockStyle.Fill;
        tableLayoutPanel.Location = new(10, 8);
        tableLayoutPanel.Margin = new(4, 3, 4, 3);
        tableLayoutPanel.Name = "tableLayoutPanel";
        tableLayoutPanel.RowCount = 6;
        tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        tableLayoutPanel.Size = new(487, 245);
        tableLayoutPanel.TabIndex = 0;
        logoPictureBox.Dock = DockStyle.Fill;
        logoPictureBox.Image = image;
        logoPictureBox.Location = new(4, 3);
        logoPictureBox.Margin = new(4, 3, 4, 3);
        logoPictureBox.Name = "logoPictureBox";
        tableLayoutPanel.SetRowSpan(logoPictureBox, 6);
        logoPictureBox.Size = new(152, 239);
        logoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        logoPictureBox.TabIndex = 12;
        logoPictureBox.TabStop = false;
        labelProductName.Dock = DockStyle.Fill;
        labelProductName.Location = new(167, 0);
        labelProductName.Margin = new(7, 0, 4, 0);
        labelProductName.MaximumSize = new(0, 16);
        labelProductName.Name = "labelProductName";
        labelProductName.Size = new(316, 16);
        labelProductName.TabIndex = 19;
        labelProductName.Text = "제품 이름";
        labelProductName.TextAlign = ContentAlignment.MiddleLeft;
        labelVersion.Dock = DockStyle.Fill;
        labelVersion.Location = new(167, 24);
        labelVersion.Margin = new(7, 0, 4, 0);
        labelVersion.MaximumSize = new(0, 16);
        labelVersion.Name = "labelVersion";
        labelVersion.Size = new(316, 16);
        labelVersion.TabIndex = 0;
        labelVersion.Text = "버전";
        labelVersion.TextAlign = ContentAlignment.MiddleLeft;
        labelCopyright.Dock = DockStyle.Fill;
        labelCopyright.Location = new(167, 48);
        labelCopyright.Margin = new(7, 0, 4, 0);
        labelCopyright.MaximumSize = new(0, 16);
        labelCopyright.Name = "labelCopyright";
        labelCopyright.Size = new(316, 16);
        labelCopyright.TabIndex = 21;
        labelCopyright.Text = "저작권";
        labelCopyright.TextAlign = ContentAlignment.MiddleLeft;
        labelCompanyName.Dock = DockStyle.Fill;
        labelCompanyName.Location = new(167, 72);
        labelCompanyName.Margin = new(7, 0, 4, 0);
        labelCompanyName.MaximumSize = new(0, 16);
        labelCompanyName.Name = "labelCompanyName";
        labelCompanyName.Size = new(316, 16);
        labelCompanyName.TabIndex = 22;
        labelCompanyName.Text = "회사 이름";
        labelCompanyName.TextAlign = ContentAlignment.MiddleLeft;
        textBoxDescription.Dock = DockStyle.Fill;
        textBoxDescription.Location = new(167, 99);
        textBoxDescription.Margin = new(7, 3, 4, 3);
        textBoxDescription.Multiline = true;
        textBoxDescription.Name = "textBoxDescription";
        textBoxDescription.ReadOnly = true;
        textBoxDescription.ScrollBars = ScrollBars.Both;
        textBoxDescription.Size = new(316, 116);
        textBoxDescription.TabIndex = 23;
        textBoxDescription.TabStop = false;
        textBoxDescription.Text = "설명";
        okButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        okButton.DialogResult = DialogResult.Cancel;
        okButton.Location = new(395, 221);
        okButton.Margin = new(4, 3, 4, 3);
        okButton.Name = "okButton";
        okButton.Size = new(88, 21);
        okButton.TabIndex = 24;
        okButton.Text = "확인(&O)";
        okButton.Click += okButton_Click;
        AcceptButton = okButton;
        AutoScaleDimensions = new(7F, 12F);
        AutoScaleMode = AutoScaleMode.None;
        ClientSize = new(507, 261);
        Controls.Add(tableLayoutPanel);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new(4, 3, 4, 3);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "FormAbout";
        Padding = new(10, 8, 10, 8);
        ShowIcon = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "FormAbout";
        tableLayoutPanel.ResumeLayout(false);
        tableLayoutPanel.PerformLayout();
        ((ISupportInitialize)logoPictureBox).EndInit();
        ResumeLayout(false);

        if (LicenseManager.UsageMode != LicenseUsageMode.Designtime) {
            Text = $"{AssemblyTitle} 정보";
            labelProductName.Text = AssemblyProduct;
            labelVersion.Text = $"버전 {AssemblyInformationalVersion}";
            labelCopyright.Text = AssemblyCopyright;
            labelCompanyName.Text = AssemblyCompany;
            textBoxDescription.Text = AssemblyDescription;
        }
    }

    private void okButton_Click(object sender, EventArgs e) => Close();
}