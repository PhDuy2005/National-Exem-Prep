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
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace Ứng_dụng_mô_phỏng_trả_lời_trắc_nghiệm
{
    public partial class SubjectInformation : Form
    {
        List<cQuestion> questions = new List<cQuestion>();
        BindingSource bs = new BindingSource();
        ExamInformation eInfo;
        FileInfo fileInfo;
        Dictionary<string, int> columnIndex = new Dictionary<string, int>()
            {
                {"ID", 2 },
                {"QuestionContent", 3 },
                {"OptionA", 4 },
                {"OptionB", 5 },
                {"OptionC", 6 },
                {"OptionD", 7 },
                {"CorrectAnswer", 8 },
                {"Note", 9 }
            };
        private void ReadDatasType1(ExcelWorksheet ws, int[] limits, float pt3Score)
        {
            int[] start = new int[] { 8, 32, 38 };

            //Đọc đề phần I
            for (int i = start[0]; i < start[0] + limits[0]; i++)
            {
                try
                {
                    int id = ws.Cells[i, columnIndex["ID"]].GetValue<int>();
                    string questionContent =
                        ws.Cells[i, columnIndex["QuestionContent"]].GetValue<string>();
                    List<string> options = new List<string>()
                    {
                        ws.Cells[i, columnIndex["OptionA"]].GetValue<string>(),
                        ws.Cells[i, columnIndex["OptionB"]].GetValue<string>(),
                        ws.Cells[i, columnIndex["OptionC"]].GetValue<string>(),
                        ws.Cells[i, columnIndex["OptionD"]].GetValue<string>()
                    };
                    string correctAnswer =
                        ws.Cells[i, columnIndex["CorrectAnswer"]].GetValue<string>();
                    string note = ws.Cells[i, columnIndex["Note"]].GetValue<string>();

                    cMultipleChoieQuestion question =
                        new cMultipleChoieQuestion("I", id, questionContent,
                        note, correctAnswer, 0.25f, options);
                    questions.Add(question);
                    //question.Part = "I";
                }
                catch (Exception ex) { }
            }

            //Đọc đề phần II
            for (int i = start[1]; i < start[1] + limits[1]; i++)
            {
                try
                {
                    int id = ws.Cells[i, columnIndex["ID"]].GetValue<int>();
                    string questionContent =
                        ws.Cells[i, columnIndex["QuestionContent"]].GetValue<string>();
                    List<string> options = new List<string>()
                    {
                        ws.Cells[i, columnIndex["OptionA"]].GetValue<string>(),
                        ws.Cells[i, columnIndex["OptionB"]].GetValue<string>(),
                        ws.Cells[i, columnIndex["OptionC"]].GetValue<string>(),
                        ws.Cells[i, columnIndex["OptionD"]].GetValue<string>()
                    };
                    string correctAnswer =
                        ws.Cells[i, columnIndex["CorrectAnswer"]].GetValue<string>();
                    string note = ws.Cells[i, columnIndex["Note"]].GetValue<string>();

                    cMultiplyTrueFalseQuestion question =
                        new cMultiplyTrueFalseQuestion("II", id, questionContent,
                        note, correctAnswer, 1, options);
                    questions.Add(question);
                    //question.Part = "II";
                }
                catch (Exception ex) { }
            }

            //Đọc đề phần III
            for (int i = start[2]; i < start[2] + limits[2]; i++)
            {
                try
                {
                    int id = ws.Cells[i, columnIndex["ID"]].GetValue<int>();
                    string questionContent =
                        ws.Cells[i, columnIndex["QuestionContent"]].GetValue<string>();
                    string correctAnswer =
                        ws.Cells[i, columnIndex["CorrectAnswer"]].GetValue<string>();
                    while (correctAnswer.Length < 4)
                        correctAnswer += "_";
                    string note = ws.Cells[i, columnIndex["Note"]].GetValue<string>();

                    cShortAnswerQuestion question =
                        new cShortAnswerQuestion("III", id, questionContent,
                        note, correctAnswer, pt3Score);
                    questions.Add(question);
                    //question.Part = "III";
                }
                catch (Exception ex) { }
            }
        }

        void ReadForeignLanguageExamData(ExcelWorksheet ws)
        {
            int start = 47;

            for (int i = start; i < start + 40; i++)
            {
                try
                {
                    int id = ws.Cells[i, columnIndex["ID"]].GetValue<int>();
                    string questionContent =
                        ws.Cells[i, columnIndex["QuestionContent"]].GetValue<string>();
                    List<string> options = new List<string>()
                    {
                        ws.Cells[i, columnIndex["OptionA"]].GetValue<string>(),
                        ws.Cells[i, columnIndex["OptionB"]].GetValue<string>(),
                        ws.Cells[i, columnIndex["OptionC"]].GetValue<string>(),
                        ws.Cells[i, columnIndex["OptionD"]].GetValue<string>()
                    };
                    string correctAnswer =
                        ws.Cells[i, columnIndex["CorrectAnswer"]].GetValue<string>();
                    string note = ws.Cells[i, columnIndex["Note"]].GetValue<string>();

                    cMultipleChoieQuestion question =
                        new cMultipleChoieQuestion("I", id, questionContent,
                        note, correctAnswer, 0.25f, options);
                    questions.Add(question);
                }
                catch { }
            }
        }

        private void loadQuestion(FileInfo fileInfo)
        {
            //Cài bản quyền
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            // tạo ra danh sách cQuestion rỗng để hứng data
            //List<cQuestion> questions = new List<cQuestion>();

            try
            {
                //mở file excel
                var package = new ExcelPackage(fileInfo);
                //lấy sheet đầu tiên
                ExcelWorksheet workSheet = package.Workbook.Worksheets["Sheet1"];

                int start = workSheet.Dimension.Start.Row;
                int examType = workSheet.Cells[start + 1, 1].GetValue<int>();
                int questionType = workSheet.Cells[start + 3, 1].GetValue<int>();
                string subject;
                int numberOfQuestion;
                int Time;

                int[] limitQuestion = new int[] { 0, 0, 0 };
                float part3Score = 0.25f;

                switch (examType)
                {
                    case 1:
                        subject = workSheet.Cells[4, 7].GetValue<string>();
                        switch (questionType)
                        {
                            case 1:
                                limitQuestion = new int[] { 12, 4, 6 };
                                part3Score = 0.5f;
                                numberOfQuestion = 22;
                                Time = 90;
                                break;
                            case 2:
                                limitQuestion = new int[] { 18, 4, 6 };
                                numberOfQuestion = 28;
                                Time = 50;
                                break;
                            case 3:
                                limitQuestion = new int[] { 24, 4, 0 };
                                numberOfQuestion = 28;
                                Time = 50;
                                break;
                            case 4:
                                limitQuestion = new int[] { 24, 6, 0 };
                                numberOfQuestion = 30;
                                Time = 50;
                                break;
                            case 5:
                                limitQuestion = new int[] { 40, 0, 0 };
                                numberOfQuestion = 40;
                                Time = 50;
                                break;
                            default:
                                MessageBox.Show("Loại câu hỏi không hợp lệ, vui lòng kiểm tra file Excel");
                                return;
                        }
                        if (questionType == 5)
                            ReadForeignLanguageExamData(workSheet);
                        else
                            ReadDatasType1(workSheet, limitQuestion, part3Score);
                        eInfo = new ExamInformation(subject, Time, numberOfQuestion, "Đề chuẩn THPTQG");
                        break;
                    case 2:
                        numberOfQuestion = workSheet.Cells[90, 2].GetValue<int>();
                        Time = workSheet.Cells[91, 2].GetValue<int>();
                        subject = workSheet.Cells[91, 4].GetValue<string>();
                        string questionType_str = workSheet.Cells[89, 3].GetValue<string>();
                        eInfo = new ExamInformation(subject, Time, numberOfQuestion, questionType_str);

                        ReadDatasType2(workSheet, numberOfQuestion, questionType);
                        break;
                    default:
                        MessageBox.Show("Loại đề không hợp lệ, vui lòng kiểm tra lại file Excel");
                        return;
                }
                //int[] limitQuestion = { 0, 0, 0 }; 
            }
            catch
            {
                MessageBox.Show("Không thể mở file Excel");
            }
            bs.DataSource = questions;
        }

        void ReadDatasType2(ExcelWorksheet ws, int numberOfQuestion, int questionType)
        {
            int start = 94;
            cQuestion question;
            var columnIndex = this.columnIndex.ToDictionary(entry => entry.Key, entry => entry.Value);
            columnIndex["Note"] = 10;
            columnIndex["Score"] = 9;
            for (int i = start; i < start + numberOfQuestion; i++)
            {
                try
                {
                    int id = ws.Cells[i, 2].GetValue<int>();
                    string questionContent =
                        ws.Cells[i, columnIndex["QuestionContent"]].GetValue<string>();
                    List<string> options;
                    string correctAnswer = ws.Cells[i, columnIndex["CorrectAnswer"]].GetValue<string>();
                    string note = ws.Cells[i, columnIndex["Note"]].GetValue<string>();
                    float score = ws.Cells[i, columnIndex["Score"]].GetValue<float>();
                    switch (questionType)
                    {
                        case 1:
                            options = new List<string>()
                            {
                                ws.Cells[i, columnIndex["OptionA"]].GetValue<string>(),
                                ws.Cells[i, columnIndex["OptionB"]].GetValue<string>(),
                                ws.Cells[i, columnIndex["OptionC"]].GetValue<string>(),
                                ws.Cells[i, columnIndex["OptionD"]].GetValue<string>()
                            };
                            question = new cMultipleChoieQuestion("I", id, questionContent,
                                note, correctAnswer, score, options);
                            questions.Add(question);
                            break;
                        case 2:
                            options = new List<string>()
                            {
                                ws.Cells[i, columnIndex["OptionA"]].GetValue<string>(),
                                ws.Cells[i, columnIndex["OptionB"]].GetValue<string>(),
                                ws.Cells[i, columnIndex["OptionC"]].GetValue<string>(),
                                ws.Cells[i, columnIndex["OptionD"]].GetValue<string>()
                            };
                            question = new cMultiplyTrueFalseQuestion("II", id, questionContent,
                                note, correctAnswer, 1, options);
                            questions.Add(question);
                            break;
                        case 3:
                            question = new cShortAnswerQuestion("III", id, questionContent,
                                note, correctAnswer, score);
                            questions.Add(question);
                            break;
                        default:
                            question = new cQuestion();
                            break;
                    }
                }
                catch { }
            }
        }

        public SubjectInformation()
        {
            InitializeComponent();
            //loadQuestion();
            //ShowInformation();
            lb_projectInfo.Text = "Đồ án kết thúc học phần Thực hành:\r\nLập trình trực quan (IT008)\r\nPhạm Trần Khánh Duy - 23520384\r\nIT008.P11.1";
        }

        void ShowInformation()
        {
            lb_subject.Text = "Môn học: " + eInfo.Subject;
            lb_time.Text = "Thời gian: " + eInfo.Time + " phút";
            lb_numberOfQuestion.Text = "Số câu hỏi: " + eInfo.NumberOfQuestions;
            lb_examType.Text = "Loại đề: " + eInfo.ExamType;
        }

        private void StartClick(object sender, EventArgs e)
        {
            QuestionSelection f = new QuestionSelection(bs, eInfo);
            f.Show();
            this.Hide();
        }

        private void btn_loadQuestion_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files|*.xlsx;*.xls",
                Title = "Chọn file Excel để load"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Tiến hành load dữ liệu từ file
                loadQuestion(new FileInfo(filePath));
                ShowInformation();
                btn_start.Enabled = true;
            }
            else
            {
                MessageBox.Show("Tải file thất bại");
            }
        }
    }
}
