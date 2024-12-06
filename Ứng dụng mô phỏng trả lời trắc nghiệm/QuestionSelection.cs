using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace Ứng_dụng_mô_phỏng_trả_lời_trắc_nghiệm
{
    public partial class QuestionSelection : Form
    {
        public QuestionSelection()
        {
            InitializeComponent();
            loadQuestion();
        }
        List<cQuestion> questions = new List<cQuestion>();

        private void ReadDatasType1(ExcelWorksheet ws,int[] limits, float pt3Score)
        {
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
            int[] start = new int[] { 8, 32, 38 };

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

            for (int i = start[2]; i < start[2] + limits[2]; i++)
            {
                try
                {
                    int id = ws.Cells[i, columnIndex["ID"]].GetValue<int>();
                    string questionContent =
                        ws.Cells[i, columnIndex["QuestionContent"]].GetValue<string>();
                    string correctAnswer =
                        ws.Cells[i, columnIndex["CorrectAnswer"]].GetValue<string>();
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
        private void loadQuestion()
        {
            //Cài bản quyền
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            // tạo ra danh sách cQuestion rỗng để hứng data
            //List<cQuestion> questions = new List<cQuestion>();

            try
            {
                //mở file excel
                var package = new ExcelPackage(new System.IO.FileInfo("Đề Mẫu Toán.xlsx"));
                //lấy sheet đầu tiên
                ExcelWorksheet workSheet = package.Workbook.Worksheets["Sheet1"];

                int start = workSheet.Dimension.Start.Row;
                int examType = workSheet.Cells[start + 1, 1].GetValue<int>();
                int questionType = workSheet.Cells[start + 3, 1].GetValue<int>();

                int[] limitQuestion = new int[]{ 0, 0, 0 };
                float part3Score = 0.25f;

                switch (examType){
                    case 1:
                        switch (questionType)
                        {
                            case 1:
                                limitQuestion = new int[] { 12, 4, 6 };
                                part3Score = 0.5f;
                                break;
                            case 2:
                                limitQuestion = new int[] { 18, 4, 6 };
                                break;
                            case 3:
                                limitQuestion = new int[] { 24, 4, 0 };
                                break;
                            case 4:
                                limitQuestion = new int[] { 24, 6, 0 };
                                break;
                            case 5:
                                limitQuestion = new int[] { 40, 0, 0 };
                                break;
                            default:
                                MessageBox.Show("Loại câu hỏi không hợp lệ, vui lòng kiểm tra file Excel");
                                return;
                        }
                        ReadDatasType1(workSheet, limitQuestion, part3Score);
                        break;
                    case 2:
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
            dgv_questionSelection.DataSource = questions;
        }
    }
}
