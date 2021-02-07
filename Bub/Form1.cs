using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        #region ======================================== Khai báo ========================================
        // sắp xếp 
        Random rd = new Random();
        int[] Arr_BubbleSort;
        int[] Arr_QuickSort;
        //int[] Arr;
        Button[] BArr_BubbleSort;
        Button[] BArr_QuickSort;
        const int GAP = 25;
        const int HEIGHT = 100;
        const int SIZE = 50;
        // 
        public static DataTable tb_Train = new DataTable();
        #endregion

        #region ======================================== BubbleSort ========================================

        // THUẬT TOÁN BUBBLESORT
        public void BubbleSort(int[] arr)
        {
            int i, j;
           // Status st = new Status();
            for (i = 0; i < arr.Length; i++)
            {
                for (j = arr.Length - 1; j > i; j--)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                        System.Threading.Thread.Sleep(10);
                        MoveButtonBubbleSort(j, j - 1);
                    }
                }
            }
        }

        //
        // HÀM MÔ PHỎNG DI CHUYỂN
        //

        private void MoveButtonBubbleSort(int i, int j)
        {
            Status st = new Status();
            st.Pos1 = i;
            st.Pos2 = j;
            st.type = MoveType.MOVE_TOP_DOWN;
            for (int x = 0; x < SIZE; x++)
            {
                BackGroundBubbleSort.ReportProgress(0, st);
                System.Threading.Thread.Sleep(10);
            }
            st.type = MoveType.MOVE_LEFT_RiGHT;
            int Distance = Math.Abs(i - j) * (SIZE + GAP);
            for (int x = 0; x < Distance; x++)
            {
                BackGroundBubbleSort.ReportProgress(0, st);
                System.Threading.Thread.Sleep(10);
            }
            st.type = MoveType.MOVE_IN_LINE;
            for (int x = 0; x < SIZE; x++)
            {
                BackGroundBubbleSort.ReportProgress(0, st);
                System.Threading.Thread.Sleep(10);
            }
         
            st.type = MoveType.MOVED;
            BackGroundBubbleSort.ReportProgress(0, st);
            System.Threading.Thread.Sleep(10);
        }

        //
        // Chạy thuật toán 
        //

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BubbleSort(Arr_BubbleSort);
        }
        //
        // Chạy thuật toán 
        //

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Status st = e.UserState as Status;
            if (st == null) return;
            if (st.type == MoveType.MOVED)
            {
                Button tmp = BArr_BubbleSort[st.Pos1];
                BArr_BubbleSort[st.Pos1] = BArr_BubbleSort[st.Pos2];
                BArr_BubbleSort[st.Pos2] = tmp;
                return;
            }
            Button btn1 = BArr_BubbleSort[st.Pos1];
            Button btn2 = BArr_BubbleSort[st.Pos2];
            if (st.type == MoveType.MOVE_TOP_DOWN)
            {
                btn1.Top = btn1.Top + 1;
                btn2.Top = btn2.Top - 1;
            }
            else if (st.type == MoveType.MOVE_LEFT_RiGHT)
            {
                btn1.Left = btn1.Left - 1;
                btn2.Left = btn2.Left + 1;
            }
            else if (st.type == MoveType.MOVE_IN_LINE)
            {
                btn1.Top = btn1.Top - 1;
                btn2.Top = btn2.Top + 1;
            }

            button1.Text = st.type.ToString();
        }

        //  Giao diện hoàn thành 

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            TaoMangBanDau(l_bubble0, pnMophongBubbleSort);

            foreach (Button btn in BArr_BubbleSort)
            {
                btn.BackgroundImage = global::Bub.Properties.Resources.circle1;
                btn.Location = new Point(btn.Location.X, lbKetqua.Location.Y + 25);
            }
            lbKetqua.Visible = true;
            pnMophongBubbleSort.Controls.Add(lbKetqua);
            btSort.Enabled = false;
        }

        //
        // Khởi tạo mảng truyền vào 
        //

        private void btTaomang_Click(object sender, EventArgs e)
        {
            if (tbArrLenght.Text.Trim().Length != 0 && Convert.ToInt32(tbArrLenght.Text) >= 2)
            {
                btSort.Enabled = true;
                TaoCacNut(ref Arr_BubbleSort, ref BArr_BubbleSort, tbArrLenght, pnMophongBubbleSort);
                l_bubble0.Clear();
                for (int i = 0; i < Arr_BubbleSort.Length; i++)
                {
                    l_bubble0.Add(Arr_BubbleSort[i]);
                }
                lbBul0.Visible = true;
                pnMophongBubbleSort.Controls.Add(lbBul0);
            }
            else
            {
                btSort.Enabled = false;
                tbArrLenght.Clear();
                tbArrLenght.Focus();
            }
        }

        //
        // Cho bắt đầu BackgroundWorker của bulusort
        //

        private void btSort_Click(object sender, EventArgs e)
        {
            BackGroundBubbleSort.RunWorkerAsync();
        }

        #endregion

        #region ======================================== QuickSort ========================================

        //
        // Thuật toán QuickSort
        // 

        public void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    QuickSort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    QuickSort(arr, pivot + 1, right);
                }
            }
        }

        // 
        // Hàm phân vùng của thật toán quicksort 
        // 

        public int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {

                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                    MoveButtonQuickSort(left, right);


                }
                else
                {
                    return right;
                }
            }
        }

        //
        // HÀM MÔ PHỎNG DI CHUYỂN QuickSort
        //

        private void MoveButtonQuickSort(int i, int j)
        {
            Status st = new Status();
            st.Pos1 = i;
            st.Pos2 = j;
            st.type = MoveType.MOVE_TOP_DOWN;
            for (int x = 0; x < SIZE; x++)
            {
                BackGroudQuickSort.ReportProgress(0, st);
                System.Threading.Thread.Sleep(10);
            }
            st.type = MoveType.MOVE_LEFT_RiGHT;
            int Distance = Math.Abs(i - j) * (SIZE + GAP);
            for (int x = 0; x < Distance; x++)
            {
                BackGroudQuickSort.ReportProgress(0, st);
                System.Threading.Thread.Sleep(10);
            }
            st.type = MoveType.MOVE_IN_LINE;
            for (int x = 0; x < SIZE; x++)
            {
                BackGroudQuickSort.ReportProgress(0, st);
                System.Threading.Thread.Sleep(10);
            }
            st.type = MoveType.MOVED;
            BackGroudQuickSort.ReportProgress(0, st);
            System.Threading.Thread.Sleep(10);
        }

        //
        // Chạy thuật toán quickSort
        //

        private void BackGroudQuickSort_DoWork(object sender, DoWorkEventArgs e)
        {
            if (tbArrayLeghtQuick.Text.Length != 0)
            {
                QuickSort(Arr_QuickSort, 0, Arr_QuickSort.Length - 1);
            }

        }

        //
        // HÀM MÔ PHỎNG DI CHUYỂN QuickSort
        //
        private void BackGroudQuickSort_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Status st = e.UserState as Status;
            if (st == null) return;
            if (st.type == MoveType.MOVED)
            {
                Button tmp = BArr_QuickSort[st.Pos1];
                BArr_QuickSort[st.Pos1] = BArr_QuickSort[st.Pos2];
                BArr_QuickSort[st.Pos2] = tmp;
                return;
            }

            Button btn1 = BArr_QuickSort[st.Pos1];
            Button btn2 = BArr_QuickSort[st.Pos2];
            if (st.type == MoveType.MOVE_TOP_DOWN)
            {
                btn1.Top = btn1.Top + 1;
                btn2.Top = btn2.Top - 1;
            }
            else if (st.type == MoveType.MOVE_LEFT_RiGHT)
            {
                btn1.Left = btn1.Left + 1;
                btn2.Left = btn2.Left - 1;
            }
            else if (st.type == MoveType.MOVE_IN_LINE)
            {
                btn1.Top = btn1.Top - 1;
                btn2.Top = btn2.Top + 1;
            }
        }

        //
        // Giao diện sau khi hoàn thành kết quả sắp xếp 
        //

        private void BackGroudQuickSort_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            TaoMangBanDau(l_quick0, pnMpQuickSort);

            //
            foreach (Button btn in BArr_QuickSort)
            {
                btn.BackgroundImage = global::Bub.Properties.Resources.circle1;
                btn.Location = new Point(btn.Location.X, lbKetquaQ.Location.Y + 25);
            }

            lbKetquaQ.Visible = true;
            pnMpQuickSort.Controls.Add(lbKetquaQ);
            btSorttingQuick.Enabled = false;
        }
        //
        //Tảo mảng ban đầu cho quicksort
        //
        private void btTaoMangQuick_Click(object sender, EventArgs e)
        {
            if (tbArrayLeghtQuick.Text.Trim().Length != 0 && Convert.ToInt32(tbArrayLeghtQuick.Text) >= 2)
            {
                btSorttingQuick.Enabled = true;
                TaoCacNut(ref Arr_QuickSort, ref BArr_QuickSort, tbArrayLeghtQuick, pnMpQuickSort);
                l_quick0.Clear();
                for (int i = 0; i < Arr_QuickSort.Length; i++)
                {
                    l_quick0.Add(Arr_QuickSort[i]);
                }

                lbLQuic0.Visible = true;
                pnMpQuickSort.Controls.Add(lbLQuic0);
            }
            else
            {
                btSorttingQuick.Enabled = false;
                tbArrayLeghtQuick.Clear();
                tbArrayLeghtQuick.Focus();
            }
        }
        //
        // Bắt đầu sắp xếp 
        //
        private void btSorttingQuick_Click(object sender, EventArgs e)
        {
            BackGroudQuickSort.RunWorkerAsync();
        }
        #endregion


        // 
        // Hàm tạo động các nút 
        //

        #region  =============================== Hàm tạo động các nút ==============================

        public void TaoCacNut(ref int[] ArrInt, ref Button[] ArrButtton, TextBox tb, Panel pnMophong)
        {
            if (tb.Text.Length != 0 && Convert.ToInt32(tb.Text) >= 2)
            {
                int n = int.Parse(tb.Text);
                ArrInt = new int[n];
                ArrButtton = new Button[n];
                pnMophong.Controls.Clear();
                int X0 = pnMophong.Width / 2 - (SIZE + GAP) * n / 2;
                for (int i = 0; i < n; i++)
                {
                    Button btn = new Button();
                    int val = rd.Next(100);
                    btn.Text = val.ToString();
                    btn.Width = btn.Height = SIZE;
                    btn.BackColor = Color.AntiqueWhite;
                    btn.Location = new Point(X0 + i * (btn.Width + GAP), 70);
                    btn.BackColor = Color.Transparent;
                    btn.BackgroundImage = global::Bub.Properties.Resources.circle__1_;
                    btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btn.ForeColor = System.Drawing.Color.White;

                    Label lnum = new Label();
                    lnum.Text = i.ToString();
                    lnum.Location = new Point(btn.Location.X + 15, btn.Location.Y + 55);
                    lnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lnum.ForeColor = System.Drawing.Color.DarkOrange;
                    lnum.MaximumSize = new Size(50, 50);
                    lnum.BackColor = Color.Transparent;
                    lnum.SendToBack();
                    btn.BringToFront();
                    pnMophong.Controls.Add(lnum);


                    ArrInt[i] = val;
                    ArrButtton[i] = btn;
                    pnMophong.Controls.Add(btn);
                }

                //lb Trạng thái
            }
        }


        //
        //Tạo mảng ban đầu sau khi hoàn thành 
        // 
        List<int> l_quick0 = new List<int>();
        List<int> l_bubble0 = new List<int>();

        public void TaoMangBanDau(List<int> arr, Panel pnMophong)
        {
            if (arr.Count >= 2)
            {
                int n = arr.Count;
                int X0 = pnMophong.Width / 2 - (SIZE + GAP) * n / 2;
                for (int i = 0; i < n; i++)
                {
                    Button btn = new Button();
                    btn.Text = arr[i].ToString();
                    btn.Width = btn.Height = SIZE;
                    btn.BackColor = Color.AntiqueWhite;
                    btn.Location = new Point(X0 + i * (btn.Width + GAP), 70);
                    btn.BackColor = Color.Transparent;
                    btn.BackgroundImage = global::Bub.Properties.Resources.circle__1_;
                    btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btn.ForeColor = System.Drawing.Color.White;
                    //btn.Visible = false; 
                    Label lnum = new Label();
                    lnum.Text = i.ToString();
                    lnum.Location = new Point(btn.Location.X + 15, 243);
                    lnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lnum.ForeColor = System.Drawing.Color.DarkOrange;
                    lnum.MaximumSize = new Size(50, 50);
                    lnum.BackColor = Color.Transparent;
                    lnum.SendToBack();
                    btn.BringToFront();
                    pnMophong.Controls.Add(lnum);

                    pnMophong.Controls.Add(btn);
                }
            }
        }

        #endregion


        #region  ========================================  Naive Bayes ========================================

        private void btCheck_Click(object sender, EventArgs e)
        {
            if (tbFootsize.Text.Length * tbHeight.Text.Length * tbWeight.Text.Length > 0) // kiểm tra  dữ liệu có nhập vào không  
            {
                double _Footsize = Convert.ToDouble(tbFootsize.Text.Trim());
                double _Height = Convert.ToDouble(tbHeight.Text.Trim());
                double _Weight = Convert.ToDouble(tbWeight.Text.Trim());

                // 
                if (_Footsize * _Height * _Weight > 0)
                {
                    lbRasult.Text = Classifier.Classify(new double[] { _Footsize, _Height, _Weight });  // show kết quả sau khi tính toán

                    if (lbRasult.Text == "male")
                    {
                        btKetqua.BackgroundImage = global::Bub.Properties.Resources.male_avatar; // cho hình ảnh  

                    }
                    else
                    {
                        btKetqua.BackgroundImage = global::Bub.Properties.Resources.user;

                    }
                }
             
            }
        }


        DataTable Table_trainning = new DataTable(); 
        private void btLoadData_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();               // tạo bảng dữ liệu lấy thông tin để Trainning
            table.Columns.Add("Sex");                        // add các cột của đặc tính đối tượng
            table.Columns.Add("Height", typeof(double));     // add các cột của đặc tính đối tượng
            table.Columns.Add("Weight", typeof(double));     // add các cột của đặc tính đối tượng
            table.Columns.Add("FootSize", typeof(double));   // add các cột của đặc tính đối tượng

            //training data.
            table.Rows.Add("male", 6, 180, 12);
            table.Rows.Add("male", 5.92, 190, 11);
            table.Rows.Add("male", 5.58, 170, 12);
            table.Rows.Add("male", 5.92, 165, 10);

            table.Rows.Add("female", 5, 100, 6);
            table.Rows.Add("female", 5.5, 150, 8);
            table.Rows.Add("female", 5.42, 130, 7);
            table.Rows.Add("female", 5.75, 150, 9);

            Table_trainning = table; 
            // Show dữ liệu 
            gridviewdata.DataSource = null;
            gridviewdata.DataSource = table;
            gridviewthongtin.DataSource = null; 


            if (table.Rows.Count >0 )
            {
                btTrainning.Enabled = true; 
            }
        }

        private void btTrainning_Click(object sender, EventArgs e)
        {
            gridviewthongtin.DataSource = null;
            Classifier.TrainClassifier(Table_trainning);      // Trainning và tính toán để cho ra công thức 
            gridviewthongtin.DataSource = tb_Train;    // show các dữ liệu sau khi tính toán 

            if (tb_Train.Rows.Count > 0)
            {
                btCheck.Enabled = true;
            }
        }

        private void tbHeight_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            double check;
            try
            {
                check = double.Parse(tb.Text.Trim()); 
            }
            catch 
            {
                tb.Clear();
                tb.Focus(); 
            }
        }



        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> l_R = new List<string>() { "R1", "R3", "R7", "R5", "R4", "R15", "R12", "R10" };
            string bandau = string.Empty;
            string bandau2 = string.Empty;

            for (int i = 0; i < l_R.Count; i++)
            {
                bandau += (i + 1).ToString() + "." + l_R[i] + "\t";
            }
            SorteList(l_R);
            for (int i = 0; i < l_R.Count; i++)
            {
                bandau2 += (i + 1).ToString() + "." + l_R[i] + "\t";
            }

            MessageBox.Show(bandau + "\n" + bandau2);
        }
        public static void SorteList(List<string> L_Input)
        {
            // int i, j;
            for (int i = 0; i < L_Input.Count; i++)
            {

                for (int j = L_Input.Count - 1; j > i; j--)
                {
                    int temp1 = Convert.ToInt32(L_Input[j].Substring(1).Trim());
                    int temp2 = Convert.ToInt32(L_Input[j - 1].Substring(1).Trim());
                    if (temp1 < temp2)
                    {
                        string tempstring = L_Input[j];
                        L_Input[j] = L_Input[j - 1];
                        L_Input[j - 1] = tempstring;
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
