using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class CustomTextBox : TextBox
{
    // Độ dài góc bo
    public float CornerRadius { get; set; } = 20f; // Bạn có thể thay đổi giá trị này

    protected override void OnPaint(PaintEventArgs e)
    {
        // Tạo GraphicsPath cho TextBox
        using (GraphicsPath path = new GraphicsPath())
        {
            path.StartFigure();
            path.AddArc(0, 0, CornerRadius, CornerRadius, 180, 90);
            path.AddArc(Width - CornerRadius - 1, 0, CornerRadius, CornerRadius, 270, 90);
            path.AddArc(Width - CornerRadius - 1, Height - CornerRadius - 1, CornerRadius, CornerRadius, 0, 90);
            path.AddArc(0, Height - CornerRadius - 1, CornerRadius, CornerRadius, 90, 90);
            path.CloseFigure();

            // Thiết lập hình dạng của TextBox
            this.Region = new Region(path);

            // Vẽ viền
            using (Pen pen = new Pen(Color.Blue, 2)) // Thay đổi màu viền và độ dày ở đây
            {
                e.Graphics.DrawPath(pen, path); // Vẽ viền bằng GraphicsPath đã tạo
            }
        }
    }

    protected override void OnPaintBackground(PaintEventArgs e)
    {
        // Vẽ nền của TextBox
        e.Graphics.Clear(this.BackColor);
    }
}
