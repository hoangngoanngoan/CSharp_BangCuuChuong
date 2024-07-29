using System.CodeDom.Compiler;
using System.Linq.Expressions;

namespace CSharp_BangCuuChuong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Khai báo biến số
        private int so;

        //Gán giá trị cho biến
        private void GetInfo()
        {
            so = Convert.ToInt32(txtBCC.Text);
        }

        //Kiểm tra biến có hợp lệ hay không
        private bool CheckInfo()
        {
            try
            {
                GetInfo();
                return true;
            }
            catch
            {
                MessageBox.Show("Phải nhập số", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //Hàm hiển thị kết quả
        private void HienThiKQ()
        {
            CheckInfo();
            labKQ.Text = "Kết quả:";
            for (int i = 1; i <= 10; i++)
            {
                labKQ.Text += $"\n{so} x {i} = {so * i}";
                listBox1.Items.Add($"\n{so} x {i} = {so * i}");
            }
        }

        
        private void butKQ_Click(object sender, EventArgs e)
        {
            HienThiKQ();
        }

        private void numBCC_ValueChanged(object sender, EventArgs e)
        {
            txtBCC.Text = numBCC.Value.ToString();
        }

        private void tbSo_Scroll(object sender, EventArgs e)
        {
            labTrackBar.Text = tbSo.Value.ToString();
            txtBCC.Text = tbSo.Value.ToString();
        }

        private void GetInfo2()
        {
            if (rad2.Checked) so = 2;
            if (rad3.Checked) so = 3;
            if (rad4.Checked) so = 4;
            if (rad5.Checked) so = 5;
            if (rad6.Checked) so = 6;
            if (rad7.Checked) so = 7;
            if (rad8.Checked) so = 8;
            if (rad9.Checked) so = 9;
            if (rad10.Checked) so = 10;
        }
        private void HienThiKQ2()
        {
            GetInfo2();
            labKQ.Text = "Kết quả";
            listBox1.Items.Clear();
            for (int i = 1; i <= 10; i++)
            {
                labKQ.Text += $"\n{so} x {i} = {so * i}";
                listBox1.Items.Add($"\n{so} x {i} = {so * i}");
            }
        }
        private void butRad_Click(object sender, EventArgs e)
        {
            HienThiKQ2();
        }
    }
}
