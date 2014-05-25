﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using Common;

namespace Extraction
{
    /// <summary>
    /// 还需要添加每隔一小时进行数据刷新功能
    /// </summary>
    class Program
    {
        private DataSet ds = null;
        private DateTime today = DateTime.Today;//get today's datetime
        private Dictionary<string, Int32> Activity_Dic = new Dictionary<string, int>();
       
        static void Main(string[] args)
        {
            Program p = new Program();
            p.ds = p.getDataSet();
            p.classify();
            p.Show_ActivityNumber();
            p.Show_TotalActivityNumber();
            Console.WriteLine("Last week event number is :"+p.Last_Week_Event_Number());
            Console.WriteLine("Last two week event number is :" + p.Last_TwoWeek_Event_Number());
            Console.WriteLine("Last month event number is: "+p.Last_Month_Event_Number());

            Console.ReadKey();
        }
        public void classify()
        {
            
            int counter = 0;
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                counter++;


                Console.Write(counter + " ");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(row[i].ToString() + "  ");
                }
                Console.WriteLine();
                Duration du = new Duration()
                {
                    TimeStamp = Convert.ToDateTime(row[0].ToString()),
                    Activity_id = row[1].ToString(),
                    Activity_duration = row[2].ToString(),

                };
                if (Activity_Dic.ContainsKey(du.Activity_id))
                {
                    Activity_Dic[du.Activity_id]++;
                }
                else
                {
                    Activity_Dic.Add(du.Activity_id, 1);

                }

                ////Embedded em = new Embedded()
                ////{
                ////    TimeStamp=Convert.ToDateTime(row[0].ToString()),
                ////    Item1=row[1].ToString(),
                ////    Item2=row[2].ToString()

                ////};
                using (Week8Container w8c = new Week8Container())
                {
                    w8c.DurationSet.AddObject(du);
                    //w8c.EmbeddedSet.AddObject(em);
                    w8c.SaveChanges();

                }




            }
 
        }
        public void Show_ActivityNumber()
        {
            
            foreach (var item in Activity_Dic)
            {
                Console.WriteLine("Activity name:{0} and it appeared {1} times", item.Key, item.Value);
            }
 
        }
        public void Show_TotalActivityNumber()
        {
            int sum = 0;
            foreach (int a in Activity_Dic.Values)
            {
                sum += a;

            }
            Console.WriteLine("Total event Number is" + sum);
 
        }
        public int Last_Week_Event_Number()
        {
            int Last_Week_Event_Number = 0;
            ds = this.getDataSet();
            DateTime FactorDate=new DateTime();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                FactorDate=Convert.ToDateTime(row[0].ToString());

                if((DateTime.Compare(FactorDate,ImprotantDateTime.GetLastOneWeekMondayStartTime())>0)&&(DateTime.Compare(FactorDate,ImprotantDateTime.GetLastOneWeekSundayEndTime())<0))
                {
                    Last_Week_Event_Number++;
                }

            }
            return Last_Week_Event_Number;

        }
        public int Last_TwoWeek_Event_Number()
        {
            int Last_Two_Week_Event_Number = 0;
            ds = this.getDataSet();
            DateTime FactorDate = new DateTime();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                FactorDate = Convert.ToDateTime(row[0].ToString());

                if ((DateTime.Compare(FactorDate, ImprotantDateTime.GetLastTwoWeekMondayStartTime()) > 0) && (DateTime.Compare(FactorDate, ImprotantDateTime.GetLastTwoWeekSundayEndTime()) < 0))
                {
                    Last_Two_Week_Event_Number++;
                }

            }
            return Last_Two_Week_Event_Number;

        }

        public int Last_Month_Event_Number()
        {
            int Last_Month_Event_Number = 0;
            ds = this.getDataSet();
            DateTime FactorDate = new DateTime();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                FactorDate = Convert.ToDateTime(row[0].ToString());

                if ((DateTime.Compare(FactorDate, ImprotantDateTime.GetLastMonthStartTime()) > 0) && (DateTime.Compare(FactorDate, ImprotantDateTime.GetLastMonthEndTime()) < 0))
                {
                    Last_Month_Event_Number++;
                }

            }
            return Last_Month_Event_Number;


        }
        private DataSet getDataSet()
        {
            string FilePath = @"c:\users\zhigang zhang\documents\visual studio 2010\Projects\ExtractDataFromExcel\Extraction\duration.xlsx";
            string strConn;

            strConn="Provider=Microsoft.ACE.OLEDB.12.0;" +"Data source=" + FilePath + ";" +"Extended Properties=Excel 8.0";

            OleDbConnection conn = new OleDbConnection(strConn);

            OleDbDataAdapter myCommand = new OleDbDataAdapter("SELECT * FROM [Form Responses$]", strConn);

            DataSet myDataSet = new DataSet();

            try
            {

                myCommand.Fill(myDataSet);

            }

            catch (Exception ex)
            {

                throw new Exception("The sheet name of the Excel file is incorrect," + ex.Message);

            }

            return myDataSet;
 
        }
        //According to the data in duration table,the base date today is 
    }
}
