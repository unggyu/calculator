using System.Windows.Forms;
using System.Text.RegularExpressions;
using System;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private char op = '\0';
        private double memory = 0;
        private double result = 0;
        private double tempNum = 0;
        private double tempOperand = 0;
        private string tempStr = string.Empty;
        private string tempExpression = string.Empty;

        private bool isException = false;
        private bool isInputOp = false;
        private bool isPressedEquals = false;
        private bool isPressedImmediateOperator = false;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 이항 연산
        /// </summary>
        /// <param name="op">연산자</param>
        /// <param name="operand1">피연산자1</param>
        /// <param name="operand2">피연산자2</param>
        /// <returns></returns>
        private double binomialCalculator(char op, double operand1, double operand2)
        {
            switch (op)
            {
                case '+': return operand1 + operand2;
                case '-': return operand1 - operand2;
                case '*': return operand1 * operand2;
                case '/': return operand1 / operand2;
                default: return -1;
            }
        }

        #region 이벤트 처리 메서드들
        private void memoryBtn_Click(object sender, EventArgs e)
        {
            if (isException)
            {
                return;
            }

            switch ((sender as Button).Text)
            {
                case "MC":
                    memory = 0;
                    break;
                case "MR":
                    result = memory;
                    resultLabel.Text = memory.ToString();
                    break;
                case "MS":
                    memory = double.Parse(resultLabel.Text);
                    break;
                case "M+":
                    memory += double.Parse(resultLabel.Text);
                    break;
                case "M-":
                    memory -= double.Parse(resultLabel.Text);
                    break;
            }
        }

        /// <summary>
        /// 숫자 버튼들 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numberBtn_Click(object sender, EventArgs e)
        {
            if (isException)
            {
                return;
            }

            KeyEventArgs ke = (e as KeyEventArgs);

            string num;
            if (ke == null)
            {
                num = (sender as Button).Text;
            }
            else
            {
                switch (ke.KeyData)
                {
                    case Keys.NumPad0:
                        num = "0";
                        break;
                    case Keys.NumPad1:
                        num = "1";
                        break;
                    case Keys.NumPad2:
                        num = "2";
                        break;
                    case Keys.NumPad3:
                        num = "3";
                        break;
                    case Keys.NumPad4:
                        num = "4";
                        break;
                    case Keys.NumPad5:
                        num = "5";
                        break;
                    case Keys.NumPad6:
                        num = "6";
                        break;
                    case Keys.NumPad7:
                        num = "7";
                        break;
                    case Keys.NumPad8:
                        num = "8";
                        break;
                    case Keys.NumPad9:
                        num = "9";
                        break;
                    default:
                        num = "0";
                        break;
                }
            }

            if (resultLabel.Text.Equals("0") && !num.Equals(".") || isInputOp || isPressedEquals || isPressedImmediateOperator)
            {
                resultLabel.Text = string.Empty;
            }

            int limitLength = (resultLabel.Text.Contains("-")) ? 17 : 16;

            if (resultLabel.Text.Length < limitLength && !(resultLabel.Text.Contains(".") && num.Equals(".")))
            {
                resultLabel.Text += num;
                result = double.Parse(resultLabel.Text);
            }
            else
            {
                System.Media.SystemSounds.Beep.Play();
            }

            isInputOp = false;
            isPressedEquals = false;
            isPressedImmediateOperator = false;
        }

        private void backspaceBtn_Click(object sender, EventArgs e)
        {
            if (isException || isPressedEquals || isPressedImmediateOperator)
            {
                return;
            }

            if (!resultLabel.Text.Equals("0"))
            {
                if (!resultLabel.Text.EndsWith(")"))
                {
                    resultLabel.Text = resultLabel.Text.Remove(resultLabel.Text.Length - 1);
                    if (resultLabel.Text.Equals(string.Empty))
                    {
                        resultLabel.Text = "0";
                    }
                }
                else
                {
                    System.Media.SystemSounds.Beep.Play();
                }
            }
        }

        private void clearEntryBtn_Click(object sender, EventArgs e)
        {
            if (isException)
            {
                expressionLabel.Text = string.Empty;
                tempStr = string.Empty;
                tempNum = 0;
                op = '\0';
            }
            tempExpression = string.Empty;
            resultLabel.Text = "0";
            tempOperand = 0;
            result = 0;

            isException = false;
            isInputOp = false;
            isPressedEquals = false;
            isPressedImmediateOperator = false;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            expressionLabel.Text = string.Empty;
            tempExpression = string.Empty;
            tempStr = string.Empty;
            resultLabel.Text = "0";
            op = '\0';
            tempNum = 0;
            tempOperand = 0;
            result = 0;

            isException = false;
            isInputOp = false;
            isPressedEquals = false;
            isPressedImmediateOperator = false;
        }

        private void changeSignBtn_Click(object sender, EventArgs e)
        {
            if (isException)
            {
                return;
            }

            if (resultLabel.Text.StartsWith("-"))
            {
                resultLabel.Text = resultLabel.Text.Substring(1);
                result = double.Parse(resultLabel.Text);
            }
            else
            {
                #region negate처리
                //if (resultLabel.Text.Equals("0") || Regex.Matches(resultLabel.Text, @"[a-zA-Z]").Count > 0)
                //{
                //    if (tempNum.Length == 0)
                //    {
                //        expressionLabel.Text = string.Format("negate({0})", resultLabel.Text);
                //    }
                //    else
                //    {
                //        expressionLabel.Text = expressionLabel.Text.Replace(tempNum, string.Format("negate({0})", tempNum));
                //    }
                //}
                //else
                #endregion
                if (result != 0)
                {
                    resultLabel.Text = "-" + resultLabel.Text;
                    result = double.Parse(resultLabel.Text);
                }
            }

            isPressedEquals = false;
            isPressedImmediateOperator = false;
        }

        /// <summary>
        /// 이항 연산 버튼들 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void easternOperatorsBtns_Click(object sender, EventArgs e)
        {
            if (isException)
            {
                return;
            }

            if (!isInputOp || isPressedEquals || isPressedImmediateOperator)
            {
                string tempResult = resultLabel.Text;

                if (!op.Equals('\0') && !isPressedEquals)
                {
                    if (op.Equals('/') && result == 0)
                    {
                        resultLabel.Text = "0으로 나눌 수 없습니다.";
                        isException = true;
                    }
                    else
                    {
                        result = binomialCalculator(op, tempNum, result);
                        resultLabel.Text = result.ToString();
                    }
                }

                KeyEventArgs ke = (e as KeyEventArgs);

                if (ke == null)
                {
                    op = (sender as Button).Text.ToCharArray()[0];
                }
                else
                {
                    switch (ke.KeyData)
                    {
                        case Keys.Add:
                            op = '+';
                            break;
                        case Keys.OemMinus:
                            op = '-';
                            break;
                        case Keys.Multiply:
                            op = '*';
                            break;
                        case Keys.Divide:
                            op = '/';
                            break;
                    }
                }

                if (tempStr.Equals(string.Empty))
                {
                    expressionLabel.Text = string.Format("{0}{1} {2} ", expressionLabel.Text, tempResult, op);
                }
                else
                {
                    expressionLabel.Text = string.Format("{0}{1} ", expressionLabel.Text, op);
                }
                tempNum = result;
            }
            else
            {
                KeyEventArgs ke = (e as KeyEventArgs);

                if (ke == null)
                {
                    op = (sender as Button).Text.ToCharArray()[0];
                }
                else
                {
                    switch (ke.KeyData)
                    {
                        case Keys.Add:
                            op = '+';
                            break;
                        case Keys.OemMinus:
                            op = '-';
                            break;
                        case Keys.Multiply:
                            op = '*';
                            break;
                        case Keys.Divide:
                            op = '/';
                            break;
                    }
                }
                expressionLabel.Text = string.Format("{0} {1} ", expressionLabel.Text.Remove(expressionLabel.Text.Length - 3), op);
            }

            tempStr = string.Empty;
            tempExpression = string.Empty;
            isInputOp = true;
            isPressedEquals = false;
            isPressedImmediateOperator = false;
        }

        private void equalsBtn_Click(object sender, EventArgs e)
        {
            if (isException)
            {
                return;
            }

            if (!op.Equals('\0'))
            {
                if (op.Equals('/') && result == 0)
                {
                    resultLabel.Text = "0으로 나눌 수 없습니다.";
                    isException = true;
                    return;
                }
                
                if (isPressedEquals)
                {
                    result = binomialCalculator(op, result, tempOperand);
                }
                else
                {
                    tempOperand = result;
                    result = binomialCalculator(op, tempNum, result);
                }
                resultLabel.Text = result.ToString();
            }
            tempStr = string.Empty;
            expressionLabel.Text = string.Empty;

            isPressedImmediateOperator = false;
            isPressedEquals = true;
        }
        #endregion

        private void immediateOperatorBtns_Click(object sender, EventArgs e)
        {
            if (isException)
            {
                return;
            }

            string expression;
            switch ((sender as Button).Text)
            {
                case "√":
                    if (string.IsNullOrEmpty(tempStr))
                    {
                        tempStr = string.Format("sqrt({0})", result);
                        tempExpression = expressionLabel.Text;
                        expression = expressionLabel.Text;
                    }
                    else
                    {
                        tempStr = string.Format("sqrt({0})", tempStr);
                        expression = tempExpression;
                    }
                    result = Math.Sqrt(result);
                    break;
                case "%":
                    result *= tempNum * 0.01;
                    if (string.IsNullOrEmpty(tempStr))
                    {
                        tempExpression = expressionLabel.Text;
                        expression = expressionLabel.Text;
                    }
                    else
                    {
                        expression = tempExpression;
                    }
                    tempStr = result.ToString();
                    break;
                case "1/x":
                    if (string.IsNullOrEmpty(tempStr))
                    {
                        tempStr = string.Format("reciproc({0})", result);
                        tempExpression = expressionLabel.Text;
                        expression = expressionLabel.Text;
                    }
                    else
                    {
                        tempStr = string.Format("reciproc({0})", tempStr);
                        expression = tempExpression;
                    }
                    result = 1 / result;
                    break;
                default:
                    expression = string.Empty;
                    break;
            }
            expressionLabel.Text = string.Format("{0}{1} ", expression, tempStr);
            resultLabel.Text = result.ToString();

            isPressedEquals = false;
            isPressedImmediateOperator = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.NumPad0:
                case Keys.NumPad1:
                case Keys.NumPad2:
                case Keys.NumPad3:
                case Keys.NumPad4:
                case Keys.NumPad5:
                case Keys.NumPad6:
                case Keys.NumPad7:
                case Keys.NumPad8:
                case Keys.NumPad9:
                    numberBtn_Click(sender, e);
                    break;
                case Keys.Add:
                case Keys.OemMinus:
                case Keys.Multiply:
                case Keys.Divide:
                    easternOperatorsBtns_Click(sender, e);
                    break;
                case Keys.Enter:
                    equalsBtn_Click(sender, e);
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BringToFront();
            Focus();
            KeyPreview = true;
        }
    }
}
