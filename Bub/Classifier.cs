using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Bub
{
    public class Classifier
    {
        public static DataSet dataSet = new DataSet();

        public static DataSet DataSet
        {
            get { return dataSet; }
            set { dataSet = value; }
        }

        public static void TrainClassifier(DataTable table)   // Table  là bảng trainning ban đầu 
        {
            dataSet.Tables.Add(table); // thêm bản  đầu vào dataset ( cụ thể: bản vừa train ) 

            //table

            DataTable GaussianDistribution = dataSet.Tables.Add("Gaussian"); // lấy cái bảng có tên là Gaussian cho bản  GaussianDistribution
            GaussianDistribution.Columns.Add(table.Columns[0].ColumnName);   //giới tính (Sex) 

            //columns
            for (int i = 1; i < table.Columns.Count; i++)
            {
                GaussianDistribution.Columns.Add(table.Columns[i].ColumnName + " Mean");     // tên thuộc tính( của bản tbtrain + với giá  trị tính đc 
                GaussianDistribution.Columns.Add(table.Columns[i].ColumnName + " Variance"); // độ lệch chuẩn : 
            }

            //calc data : tính toán dữ liệu 
            var results = (
                           from myRow in table.AsEnumerable()                                        //
                           group myRow by myRow.Field<string>(table.Columns[0].ColumnName) into g    // add các giá trị vào resuls ( 1 cái List)
                           select new { Name = g.Key, Count = g.Count() }                            //
                           ).ToList();

            for (int j = 0; j < results.Count; j++) //  results.Count = GaussianDistribution.Rows.cout tức số phần từ trong results bằng số dòng trong bảng
            {
                DataRow row = GaussianDistribution.Rows.Add();
                row[0] = results[j].Name;

                int a = 1;
                for (int i = 1; i < table.Columns.Count; i++)
                {
                    row[a] = Helper.Mean(SelectRows(table, i, string.Format("{0} = '{1}'", table.Columns[0].ColumnName, results[j].Name)));       // tính trung bình        
                    row[++a] = Helper.Variance(SelectRows(table, i, string.Format("{0} = '{1}'", table.Columns[0].ColumnName, results[j].Name))); // tính tỷ lệ            
                    a++;
                }
            }

            Form1.tb_Train = GaussianDistribution;   // bảng kết quả để mình show
        }

        //Các hàm tính toán
        public static string Classify(double[] obj)
        {
            Dictionary<string, double> score = new Dictionary<string, double>();

            var results = (from myRow in dataSet.Tables[0].AsEnumerable()
                           group myRow by myRow.Field<string>(dataSet.Tables[0].Columns[0].ColumnName) into g
                           select new { Name = g.Key, Count = g.Count() }).ToList();

            for (int i = 0; i < results.Count; i++)
            {
                List<double> subScoreList = new List<double>();
                int a = 1, b = 1;   // a là  cột mean, b là cột Variance
                for (int k = 1; k < dataSet.Tables["Gaussian"].Columns.Count; k = k + 2)
                {
                    double mean = Convert.ToDouble(dataSet.Tables["Gaussian"].Rows[i][a]);
                    double variance = Convert.ToDouble(dataSet.Tables["Gaussian"].Rows[i][++a]);
                    double result = Helper.NormalDist(obj[b - 1], mean, Helper.SquareRoot(variance));
                    subScoreList.Add(result);
                    a++;
                    b++;
                }

                double finalScore = 0;
                for (int z = 0; z < subScoreList.Count; z++)
                {
                    if (finalScore == 0) // hạn chế các  giá trị 0 
                    {
                        finalScore = subScoreList[z];
                        continue;
                    }

                    finalScore = finalScore * subScoreList[z];  // tính toán tỷ lệ 
                }

                score.Add(results[i].Name, finalScore * 0.5); // and cái list kết quả 
            }

            double maxOne = score.Max(c => c.Value);
            var name = (from c in score
                        where c.Value == maxOne
                        select c.Key).First(); // lấy giá trị đầu tiên, cũng có nghĩa là tỷ lệ cao nhất
           // FShow_data.value_tinhtoan = maxOne.ToString(); 
            return name;
        }
        #region Helper Function

        public static IEnumerable<double> SelectRows(DataTable table, int column, string filter)
        {
            List<double> _doubleList = new List<double>();
            DataRow[] rows = table.Select(filter);
            for (int i = 0; i < rows.Length; i++)
            {
                _doubleList.Add((double)rows[i][column]);
            }

            return _doubleList;
        }

        public void Clear()
        {
            dataSet = new DataSet();
        }

        #endregion
    }
}
