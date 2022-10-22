#nullable disable
namespace BluehillShared;

/// <summary>
/// 대화 상자 폼
/// </summary>
// 추상 클래스로 표시하지 말것!
public class FormDialog : Form {
    protected TableLayoutPanel TableLayoutPanel1 = new();
    protected Button OK_Button = new();
    protected Button Cancel_Button = new();

    protected FormDialog() {
        TableLayoutPanel1.SuspendLayout();
        SuspendLayout();
        TableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        TableLayoutPanel1.ColumnCount = 2;
        TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        TableLayoutPanel1.Controls.Add(OK_Button, 0, 0);
        TableLayoutPanel1.Controls.Add(Cancel_Button, 1, 0);
        TableLayoutPanel1.Location = new(101, 218);
        TableLayoutPanel1.Margin = new(4, 3, 4, 3);
        TableLayoutPanel1.Name = "TableLayoutPanel1";
        TableLayoutPanel1.RowCount = 1;
        TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        TableLayoutPanel1.Size = new(170, 31);
        TableLayoutPanel1.TabIndex = 0;
        OK_Button.Anchor = AnchorStyles.None;
        OK_Button.DialogResult = DialogResult.OK;
        OK_Button.Location = new(4, 3);
        OK_Button.Margin = new(4, 3, 4, 3);
        OK_Button.Name = "OK_Button";
        OK_Button.Size = new(77, 25);
        OK_Button.TabIndex = 0;
        OK_Button.Text = "확인";
        OK_Button.Click += OK_Button_Click;
        Cancel_Button.Anchor = AnchorStyles.None;
        Cancel_Button.DialogResult = DialogResult.Cancel;
        Cancel_Button.Location = new(89, 3);
        Cancel_Button.Margin = new(4, 3, 4, 3);
        Cancel_Button.Name = "Cancel_Button";
        Cancel_Button.Size = new(77, 25);
        Cancel_Button.TabIndex = 1;
        Cancel_Button.Text = "취소";
        Cancel_Button.Click += Cancel_Button_Click;
        AcceptButton = OK_Button;
        AutoScaleMode = AutoScaleMode.None;
        CancelButton = Cancel_Button;
        ClientSize = new(284, 261);
        Controls.Add(TableLayoutPanel1);
        Font = new("맑은 고딕", 9F);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new(4, 3, 4, 3);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "FormDialog";
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterScreen;
        TopMost = true;
        TableLayoutPanel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    protected sealed override void OnSizeChanged(EventArgs e) {
        base.OnSizeChanged(e);
        const int s =
#if NET45_OR_GREATER || !NETFRAMEWORK
    10
#else
    0
#endif
    ;
        TableLayoutPanel1.Location = new(Size.Width - 190 - s, Size.Height - 70 - s);
    }

    protected virtual void OK_Button_Click(object sender, EventArgs e) {
        DialogResult = DialogResult.OK;
        Close();
    }

    protected virtual void Cancel_Button_Click(object sender, EventArgs e) {
        DialogResult = DialogResult.Cancel;
        Close();
    }
}