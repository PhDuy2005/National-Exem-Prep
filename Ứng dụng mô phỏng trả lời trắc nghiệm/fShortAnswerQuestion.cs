using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Ứng_dụng_mô_phỏng_trả_lời_trắc_nghiệm
{
    public partial class fShortAnswerQuestion : Form
    {
        Dictionary<int, Dictionary<int, System.Windows.Forms.CheckBox>> ckBoxDict = 
            new Dictionary<int, Dictionary<int, System.Windows.Forms.CheckBox>>();
        Dictionary<int, TextBox> txtBoxDict = new Dictionary<int, TextBox>();
        cShortAnswerQuestion question;

        // Delegate định nghĩa kiểu phương thức cho event
        public delegate void DataSubmittedHandler(cShortAnswerQuestion data);

        // Event sử dụng delegate
        public event DataSubmittedHandler OnDataSubmitted;

        public fShortAnswerQuestion(cShortAnswerQuestion question)
        {
            InitializeComponent();
            initChkBoxDictionary();
            initTxtBoxDictionary();
            this.question = question;
            ShowQuestion();
            ShowCurrentAnswer();
        }
        void initChkBoxDictionary()
        {
            // Tạo và thêm Dictionary con cho key 1
            var dict1 = new Dictionary<int, System.Windows.Forms.CheckBox>();
            dict1[-1] = ckbDigit1Minus; // CheckBox với chỉ số -1
            dict1[0] = ckbDigit1Zero;
            dict1[1] = ckbDigit1One;
            dict1[2] = ckbDigit1Two;
            dict1[3] = ckbDigit1Three;
            dict1[4] = ckbDigit1Four;
            dict1[5] = ckbDigit1Five;
            dict1[6] = ckbDigit1Six;
            dict1[7] = ckbDigit1Seven;
            dict1[8] = ckbDigit1Eight;
            dict1[9] = ckbDigit1Nine;
            ckBoxDict[1] = dict1;

            // Tạo và thêm Dictionary con cho key 2
            var dict2 = new Dictionary<int, System.Windows.Forms.CheckBox>();
            dict2[11] = ckbDigit2Comma; // CheckBox với chỉ số 11
            dict2[0] = ckbDigit2Zero;
            dict2[1] = ckbDigit2One;
            dict2[2] = ckbDigit2Two;
            dict2[3] = ckbDigit2Three;
            dict2[4] = ckbDigit2Four;
            dict2[5] = ckbDigit2Five;
            dict2[6] = ckbDigit2Six;
            dict2[7] = ckbDigit2Seven;
            dict2[8] = ckbDigit2Eight;
            dict2[9] = ckbDigit2Nine;
            ckBoxDict[2] = dict2;

            // Tạo và thêm Dictionary con cho key 3
            var dict3 = new Dictionary<int, System.Windows.Forms.CheckBox>();
            dict3[11] = ckbDigit3Comma; // CheckBox với chỉ số 11
            dict3[0] = ckbDigit3Zero;
            dict3[1] = ckbDigit3One;
            dict3[2] = ckbDigit3Two;
            dict3[3] = ckbDigit3Three;
            dict3[4] = ckbDigit3Four;
            dict3[5] = ckbDigit3Five;
            dict3[6] = ckbDigit3Six;
            dict3[7] = ckbDigit3Seven;
            dict3[8] = ckbDigit3Eight;
            dict3[9] = ckbDigit3Nine;
            ckBoxDict[3] = dict3;

            // Tạo và thêm Dictionary con cho key 4
            var dict4 = new Dictionary<int, System.Windows.Forms.CheckBox>();
            dict4[0] = ckbDigit4Zero;
            dict4[1] = ckbDigit4One;
            dict4[2] = ckbDigit4Two;
            dict4[3] = ckbDigit4Three;
            dict4[4] = ckbDigit4Four;
            dict4[5] = ckbDigit4Five;
            dict4[6] = ckbDigit4Six;
            dict4[7] = ckbDigit4Seven;
            dict4[8] = ckbDigit4Eight;
            dict4[9] = ckbDigit4Nine;
            ckBoxDict[4] = dict4;
        }
        void initTxtBoxDictionary()
        {
            // Thêm các TextBox vào Dictionary
            txtBoxDict[1] = tbDigit1;
            txtBoxDict[2] = tbDigit2;
            txtBoxDict[3] = tbDigit3;
            txtBoxDict[4] = tbDigit4;
        }
        void ShowQuestion()
        {
            //Hiển thị câu hỏi
            lb_questionContent.Text = question.GetQuestionContent();
            lb_QuestionNum.Text = "Phần I - Câu " + question.QuestionID.ToString();
        }
        void ShowCurrentAnswer()
        {
            if (question.AnswerState == "")
            {
                // Reset tất cả CheckBox và TextBox
                foreach (var ckb_dict in ckBoxDict)
                {
                    foreach (var cb in ckb_dict.Value)
                    {
                        cb.Value.Checked = false;
                    }
                }
                foreach (var tbDict in txtBoxDict)
                {
                    tbDict.Value.Text = string.Empty;
                }
            }
            else
            {
                //update các checkBox
                foreach (var answer in question.currentAnswer)
                {
                    int key = answer.Key; // Vị trí (1-based)
                    string selectedValues = answer.Value; // Các ký tự đã chọn (VD: "0,1,-")

                    // Kiểm tra nếu key tồn tại trong ckBoxDict
                    if (ckBoxDict.ContainsKey(key))
                    {
                        foreach (var cb in ckBoxDict[key])
                        {
                            if (cb.Key == -1)
                            {
                                // Đặt Checked = true nếu selectedValues chứa ký tự '-'
                                cb.Value.Checked = selectedValues.Contains("-");
                            }
                            else if (cb.Key == 11)
                            {
                                // Đặt Checked = true nếu selectedValues chứa ký tự ','
                                cb.Value.Checked = selectedValues.Contains(",");
                            }
                            else
                            {
                                // Đặt Checked = true nếu key của CheckBox nằm trong selectedValues
                                cb.Value.Checked = selectedValues.Contains(cb.Key.ToString());
                            }
                        }
                    }
                }

                // Cập nhật trạng thái TextBox từ AnswerState
                string answerState = question.AnswerState;

                for (int i = 0; i < answerState.Length; i++)
                {
                    char currentChar = answerState[i];
                    int key = i + 1; // Key trong Dictionary là 1-based

                    // Cập nhật TextBox nếu key tồn tại trong txtBoxDict
                    if (txtBoxDict.ContainsKey(key))
                    {
                        if (currentChar == ' ')
                        {
                            txtBoxDict[key].Text = string.Empty; // Vị trí trống
                        }
                        else
                        {
                            txtBoxDict[key].Text = currentChar.ToString(); // Số hoặc ký tự khác
                        }
                    }
                }

            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            //Cập nhật answer state dựa trên thông tin ghi trên các textBox
            question.AnswerState = "";
            foreach (var tbd in txtBoxDict)
            {
                if (tbd.Value.Text.Trim() == string.Empty)
                {
                    question.AnswerState += " ";
                }
                else
                {
                    question.AnswerState += tbd.Value.Text;
                }
                question.AnswerState.Trim();
            }

            //Cập nhật current answer dựa trên thông tin ghi trên các checkBox
            foreach (var ckb_dict in ckBoxDict)
            {
                string selectedValues = "";
                foreach (var cb in ckb_dict.Value)
                {
                    if (cb.Value.Checked)
                    {
                        if (cb.Key == -1)
                        {
                            selectedValues += "-";
                        }
                        else if (cb.Key == 11)
                        {
                            selectedValues += ",";
                        }
                        else
                        {
                            selectedValues += cb.Key.ToString();
                        }
                    }
                }
                question.currentAnswer[ckb_dict.Key] = selectedValues;
            }

            string newStudentAnswer = "";
            foreach (var answer in question.currentAnswer)
            {
                if (answer.Value != "")
                {
                    if (answer.Value.Length == 1)
                    {
                        newStudentAnswer += answer.Value;
                    }
                    else if (answer.Value.Length > 1)
                    {
                        newStudentAnswer += "M";
                    }
                }
            }
            question.SetStudentAnswer(newStudentAnswer);

            OnDataSubmitted?.Invoke(question);
            this.DialogResult = DialogResult.OK;
        }
    }
}
