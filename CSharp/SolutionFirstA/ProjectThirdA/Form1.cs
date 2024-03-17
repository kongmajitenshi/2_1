using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectThirdA
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            int a = 1; // 여기서 1, 2.0, 안녕 이런 값들을 리터럴이라 부름.
            float b = 2.0f; // 실수형 기본이 double형이라 8byte임. float형에 4byte값을 넘기려면 뒤에 f를 붙여줘야함.
            // double b = 2.0; 형태로 하면 깔끔하게 가능.
            string c = "안녕";
            labelContent.Text = a.ToString();
            labelContent.Text += Environment.NewLine; // 연결자 +=를 사용해야 덮어씌워지지 않음.
            labelContent.Text += b.ToString();
            labelContent.Text += "\r\n";
            labelContent.Text += c;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}