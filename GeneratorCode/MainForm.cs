
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ZXing;
using QRCoder;
using System.Reflection;


namespace QRDataMatrix
{
    public partial class MainForm : Form
    {
        private Bitmap lastCode1;
        private Bitmap lastCode2;

        public MainForm()
        {
            InitializeComponent();

            // Gắn sự kiện
            inputBox.TextChanged += (s, e) => GenerateCodes();
            radioQR.CheckedChanged += (s, e) => GenerateCodes();
            radioDM.CheckedChanged += (s, e) => GenerateCodes();
            chkAppendSuffix.CheckedChanged += (s, e) => GenerateCodes();
            btnSave.Click += BtnSave_Click;
            btnSave.BringToFront();
            // Lấy version từ Assembly
            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            // Hiển thị 2 dòng
            lblCopyright.Text = "Copyright by Nông Văn Phấn"
                                + Environment.NewLine
                                + "Build Version: v" + version;

            // Căn copyright khi load và resize
            this.Load += (s, e) => AlignCopyright();
            this.Resize += (s, e) => AlignCopyright();
        }

        private void AlignCopyright()
        {
            int margin = 10;
            if (this.lblCopyright != null)
            {
                this.lblCopyright.Left = this.ClientSize.Width - this.lblCopyright.Width - margin;
                this.lblCopyright.Top = this.ClientSize.Height - this.lblCopyright.Height - margin;
            }
        }


        private void GenerateCodes()
        {
            string baseText = inputBox.Text.Trim();
            if (string.IsNullOrEmpty(baseText))
            {
                pictureBox1.Image = null;
                pictureBox2.Image = null;
                lblCode1.Text = "";
                lblCode2.Text = "";
                return;
            }

            if (radioQR.Checked)
            {
                // Trả layout về 2 ô
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                lblCode1.Visible = true;
                lblCode2.Visible = true;

                pictureBox1.Left = 30;
                pictureBox2.Left = 350;
                lblCode1.Left = 20;
                lblCode2.Left = 340;
                lblCode1.Width = pictureBox1.Width;
                lblCode2.Width = pictureBox2.Width;

                // Cho phép label xuống dòng và hiển thị rõ ràng
                lblCode1.AutoSize = false;
                lblCode1.MaximumSize = new Size(pictureBox1.Width, 0);
                lblCode1.Height = 60;  // đủ để chứa 2 dòng
                lblCode1.TextAlign = ContentAlignment.MiddleCenter;

                lblCode2.AutoSize = false;
                lblCode2.MaximumSize = new Size(pictureBox2.Width, 0);
                lblCode2.Height = 60;  // đủ để chứa 2 dòng
                lblCode2.TextAlign = ContentAlignment.MiddleCenter;

                // Sinh 2 mã QR
                string text1 = baseText;
                string text2 = baseText;

                if (chkAppendSuffix.Checked)
                {
                    text1 += "#1";
                    text2 += "#2";
                }

                lastCode1 = GenerateSingleCode(text1);
                lastCode2 = GenerateSingleCode(text2);

                pictureBox1.Image = lastCode1;
                pictureBox2.Image = lastCode2;

                lblCode1.Text = text1;
                lblCode2.Text = text2;
            }
            else if (radioDM.Checked)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                lblCode1.Visible = true;
                lblCode2.Visible = false;

                // Đặt pictureBox1 và label vào giữa form
                pictureBox1.Left = (this.ClientSize.Width - pictureBox1.Width) / 2;
                lblCode1.Left = pictureBox1.Left;
                lblCode1.Width = pictureBox1.Width;

                // Cấu hình label để hiển thị nhiều dòng
                lblCode1.AutoSize = false;
                lblCode1.MaximumSize = new Size(pictureBox1.Width, 0);
                lblCode1.Height = 60;
                lblCode1.TextAlign = ContentAlignment.MiddleCenter;

                string text = baseText;
                if (chkAppendSuffix.Checked)
                {
                    text += "#1";
                }

                lastCode1 = GenerateSingleCode(text);
                lastCode2 = null;

                pictureBox1.Image = lastCode1;
                lblCode1.Text = text;
            }
        }

        private Bitmap GenerateSingleCode(string text)
        {
            if (radioQR.Checked)
            {
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                return qrCode.GetGraphic(10);
            }
            else
            {
                BarcodeWriter writer = new BarcodeWriter
                {
                    Format = BarcodeFormat.DATA_MATRIX,
                    Options = new ZXing.Common.EncodingOptions
                    {
                        Height = 300,
                        Width = 300,
                        Margin = 0
                    }
                };
                return writer.Write(text);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (lastCode1 == null && lastCode2 == null)
            {
                lblStatus.Text = "❌ Không có code để lưu.";
                lblStatus.ForeColor = Color.Red;
                return;
            }

            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Filter = "PNG Image|*.png";
                dlg.FileName = "Code.png";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string baseDir = Path.GetDirectoryName(dlg.FileName);
                    string message = "";

                    if (radioQR.Checked)
                    {
                        string file1 = null;
                        string file2 = null;

                        if (lastCode1 != null)
                        {
                            string name1 = chkAppendSuffix.Checked
                                ? lblCode1.Text
                                : inputBox.Text.Trim() + "_1";
                            file1 = Path.Combine(baseDir, name1 + ".png");
                            lastCode1.Save(file1, System.Drawing.Imaging.ImageFormat.Png);
                        }

                        if (lastCode2 != null)
                        {
                            string name2 = chkAppendSuffix.Checked
                                ? lblCode2.Text
                                : inputBox.Text.Trim() + "_2";
                            file2 = Path.Combine(baseDir, name2 + ".png");
                            lastCode2.Save(file2, System.Drawing.Imaging.ImageFormat.Png);
                        }

                        message = "✅ Đã lưu 2 code QR thành công!\r\n" +
                                  (file1 != null ? file1 + "\r\n" : "") +
                                  (file2 != null ? file2 : "");
                    }
                    else if (radioDM.Checked)
                    {
                        string file = null;

                        if (lastCode1 != null)
                        {
                            string name = chkAppendSuffix.Checked
                                ? lblCode1.Text
                                : inputBox.Text.Trim();
                            file = Path.Combine(baseDir, name + ".png");
                            lastCode1.Save(file, System.Drawing.Imaging.ImageFormat.Png);
                        }

                        message = "✅ Đã lưu code DataMatrix thành công!\r\n" +
                                  (file != null ? file : "");
                    }

                    lblStatus.Text = message;
                    lblStatus.ForeColor = Color.Green;
                }
            }
        }
    }
}
