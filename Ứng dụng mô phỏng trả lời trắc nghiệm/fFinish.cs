using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ứng_dụng_mô_phỏng_trả_lời_trắc_nghiệm
{
    public partial class fFinish : Form
    {
        BindingSource bindingSrc = new BindingSource();
        ExamInformation eInfo;
        float scoreP1, scoreP2, scoreP3;
        float maxScoreP1, maxScoreP2, maxScoreP3;

        private void fFinish_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Kiểm tra nếu đây không phải form chính
            if (this != Application.OpenForms[0])
            {
                Application.Exit(); // Kết thúc toàn bộ ứng dụng
            }
        }

        public fFinish(BindingSource bindingSource, ExamInformation eInfo)
        {
            InitializeComponent();
            this.bindingSrc = bindingSource;
            this.eInfo = eInfo;
            CalculateScore();
            ShowScore();
        }

        private void btn_exportFile_Click(object sender, EventArgs e)
        {
            string filePath = "";
            // tạo SaveFileDialog để lưu file excel
            SaveFileDialog dialog = new SaveFileDialog();

            dialog.Filter = "Excel | *.xlsx | Excel 2003 | *.xls";

            // Nếu mở file và chọn nơi lưu file thành công sẽ lưu đường dẫn lại dùng
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName;

                if (Path.GetExtension(filePath) == "")
                {
                    filePath = Path.Combine(filePath, "exportData.xlsx");
                }
            }
            else
            {
                MessageBox.Show("Mở file thất bại");
                return;
            }

            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Đường dẫn báo cáo không hợp lệ");
                return;
            }

            try
            {
                using (ExcelPackage p = new ExcelPackage())
                {
                    string sheetName = "Báo cáo";
                    p.Workbook.Properties.Author = "Duy Pham Tran Khanh";
                    p.Workbook.Worksheets.Add(sheetName);

                    ExcelWorksheet ws = p.Workbook.Worksheets[sheetName];
                    ws.Name = sheetName;
                    ws.Cells.Style.Font.Size = 11;
                    ws.Cells.Style.Font.Name = "Times New Roman";

                    List<string> columnHeaders = new List<string>();
                    columnHeaders.AddRange(new string[]
                        {
                            "Phần",
                            "Nội dung câu hỏi",
                            "Lệnh A",
                            "Lệnh B",
                            "Lệnh C",
                            "Lệnh D",
                            "Đáp án học sinh",
                            "Đáp án giáo viên",
                            "Điểm",
                            "Điểm tối đa",
                            "Ghi chú"
                        });

                    int headerRow = 2;
                    int columnIndex = 1;
                    int headerCount = columnHeaders.Count;
                    foreach (var header in columnHeaders)
                    {
                        var cell = ws.Cells[headerRow, columnIndex];
                        cell.Value = header;
                        columnIndex++;
                    }
                    ws.Cells[1, 1].Value = "BÁO CÁO KẾT QUẢ THI THEO TỪNG CÂU";
                    ws.Cells[1, 1, 1, headerCount].Merge = true;
                    ws.Cells[1, 1, 1, headerCount].Style.Font.Bold = true;
                    ws.Cells[1, 1, 1, headerCount].Style.Font.Size = 16;
                    ws.Cells[1, 1, 1, headerCount].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    //I want to take the List which is located in bindingSrc
                    //When bindingSrc is initialized, I used BindingSource bindingSrc = new BindingSource();
                    //bindingSrc.DataSource = new List<cQuestion>();
                    List<cQuestion> questions = bindingSrc.DataSource as List<cQuestion>;

                    int rowIndex = headerRow + 1;
                    foreach (var question in questions)
                    {
                        ws.Cells[rowIndex, 1].Value = question.Part;
                        ws.Cells[rowIndex, 2].Value = question.GetQuestionContent();
                        //ws.Cells[rowIndex, 3].Value = question.OptionA;
                        //ws.Cells[rowIndex, 4].Value = question.OptionB;
                        //ws.Cells[rowIndex, 5].Value = question.OptionC;
                        //ws.Cells[rowIndex, 6].Value = question.OptionD;
                        if (question.Part == "I" || question.Part == "II")
                        {
                            List<string> options = new List<string>();
                            if (question is cMultipleChoieQuestion)
                            {
                                var tmp = (cMultipleChoieQuestion)question;
                                options = tmp.Options;
                            }
                            else if (question is cMultiplyTrueFalseQuestion)
                            {
                                var tmp = (cMultiplyTrueFalseQuestion)question;
                                options = tmp.Options;
                            }
                            ws.Cells[rowIndex, 3].Value = options[0];
                            ws.Cells[rowIndex, 4].Value = options[1];
                            ws.Cells[rowIndex, 5].Value = options[2];
                            ws.Cells[rowIndex, 6].Value = options[3];
                        }
                        ws.Cells[rowIndex, 7].Value = question.GetStudentAnswer();
                        ws.Cells[rowIndex, 8].Value = question.GetCorrectAnswer();
                        ws.Cells[rowIndex, 9].Value = question.getScore();
                        ws.Cells[rowIndex, 10].Value = question.GetMaxScore();
                        ws.Cells[rowIndex, 11].Value = question.Note;
                        rowIndex++;
                    }

                    if (eInfo.ExamType == "Đề chuẩn THPTQG")
                    {
                        rowIndex++;
                        columnHeaders = new List<string>();
                        columnHeaders.AddRange(new string[] { "Tổng điểm", "Điểm đạt được", "Điểm tối đa" });
                        headerCount = columnHeaders.Count;

                        ws.Cells[rowIndex, 1].Value = "BÁO CÁO KẾT QUẢ THI THEO PHẦN";
                        ws.Cells[rowIndex, 1, rowIndex, headerCount].Merge = true;
                        ws.Cells[rowIndex, 1, rowIndex, headerCount].Style.Font.Bold = true;
                        ws.Cells[rowIndex, 1, rowIndex, headerCount].Style.Font.Size = 16;
                        ws.Cells[rowIndex, 1, rowIndex, headerCount].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                        rowIndex++;

                        columnIndex = 1;
                        foreach (var header in columnHeaders)
                        {
                            var cell = ws.Cells[rowIndex, columnIndex];
                            cell.Value = header;
                            columnIndex++;
                        }
                        rowIndex++;

                        ws.Cells[rowIndex, 1].Value = "Phần I: Trắc nghiệm";
                        ws.Cells[rowIndex, 2].Value = scoreP1;
                        ws.Cells[rowIndex, 3].Value = maxScoreP1;
                        rowIndex++;

                        ws.Cells[rowIndex, 1].Value = "Phần II: Đúng - Sai";
                        ws.Cells[rowIndex, 2].Value = scoreP2;
                        ws.Cells[rowIndex, 3].Value = maxScoreP2;
                        rowIndex++;

                        ws.Cells[rowIndex, 1].Value = "Phần III: Trả lời ngắn";
                        ws.Cells[rowIndex, 2].Value = scoreP3;
                        ws.Cells[rowIndex, 3].Value = maxScoreP3;
                        rowIndex++;
                    }
                    ws.Cells[ws.Dimension.Address].AutoFitColumns();

                    Byte[] bin = p.GetAsByteArray();
                    File.WriteAllBytes(filePath, bin);
                    MessageBox.Show($"Xuất file thành công! tại {filePath}");
                }
            }
            catch(Exception ex) {
                MessageBox.Show($"Có lỗi khi lưu file {ex.Message}");
            }
        }

        void CalculateScore()
        {
            scoreP1 = 0;
            scoreP2 = 0;
            scoreP3 = 0;
            maxScoreP1 = maxScoreP2 = maxScoreP3 = 0;

            float temp;

            foreach (cQuestion question in this.bindingSrc)
            {
                temp = question.getScore();
                if (question is cMultipleChoieQuestion)
                {
                    scoreP1 += temp;
                    maxScoreP1 += question.GetMaxScore();
                }
                else if (question is cMultiplyTrueFalseQuestion)
                {
                    scoreP2 += temp;
                    maxScoreP2 += question.GetMaxScore();
                }
                else if (question is cShortAnswerQuestion)
                {
                    scoreP3 += temp;
                    maxScoreP3 += question.GetMaxScore();
                }
            }
        }
        void ShowScore()
        {
            lb_part1.Text = "Phần I: Trắc nghiệm: " + scoreP1.ToString();
            lb_part2.Text = "Phần II: Đúng - Sai: " + scoreP2.ToString();
            lb_part3.Text = "Phần III: Trả lời ngắn: " + scoreP3.ToString();
            string finalScore = "Tổng điểm: " + (scoreP1 + scoreP2 + scoreP3).ToString();
            lb_finalScore.Text = finalScore;

            if (eInfo.ExamType == "Đề chuẩn THPTQG")
            {
                lb_part1.Visible = true;
                lb_part2.Visible = true;
                lb_part3.Visible = true;
                return;
            }
            
            if (eInfo.ExamType == "TN 1 trong 4 đáp án")
            {
                lb_part1.Visible = true;
                lb_part2.Visible = false;
                lb_part3.Visible = false;
                return;
            }

            if (eInfo.ExamType == "TN đúng/sai")
            {
                lb_part1.Visible = false;
                lb_part2.Visible = true;
                lb_part3.Visible = false;
                return;
            }

            if (eInfo.ExamType == "TN trả lời ngắn")
            {
                lb_part1.Visible = false;
                lb_part2.Visible = false;
                lb_part3.Visible = true;
                return;
            }
        }
    }
}
