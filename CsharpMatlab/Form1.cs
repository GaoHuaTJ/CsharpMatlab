using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;
using FunctionVisual1;
using System.Text.RegularExpressions;
using System.IO;

namespace CsharpMatlab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            DelectDir(@".\图片\");//清空文件夹下面的文件
            if (IsNumeric(textBoxStep.Text) && IsNumeric(textBoxXmax.Text) && IsNumeric(textBoxXmin.Text))
            {

                MWNumericArray xMax = Convert.ToDouble(textBoxXmax.Text);
                MWNumericArray xStep = Convert.ToDouble(textBoxStep.Text);
                MWNumericArray xMin = Convert.ToDouble(textBoxXmin.Text);
                FunctionVisual1.FunctionVisual functionVisual = new FunctionVisual1.FunctionVisual();
                functionVisual.PlotSin(xMin,xStep,xMax);
                Random rd = new Random();
                var name = rd.Next().ToString();
                File.Copy(@".\图片\sin.png", string.Format(@".\temp\sin{0}.png", name), true);
                pictureBox1.Image = Image.FromFile(string.Format(@".\temp\sin{0}.png", name));
            }
            else
            {
                MessageBox.Show("请输入正确的数值","提示");
            }
        }

        /// <summary>
        /// 判断字符串是否是数字
        /// </summary>
        public static bool IsNumeric(string str)
        {
            string regextext = @"^(-?\d+)(\.\d+)?$";
            Regex regex = new Regex(regextext, RegexOptions.None);
            return regex.IsMatch(str.Trim());
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxStep.Text = "0.01";
            textBoxXmax.Text = "100";
            textBoxXmin.Text = "0";
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            if (IsNumeric(textBoxStep.Text) && IsNumeric(textBoxXmax.Text) && IsNumeric(textBoxXmin.Text))
            {
                DelectDir(@".\图片\");//清空文件夹下面的文件
                MWNumericArray xMax = Convert.ToDouble(textBoxXmax.Text);
                MWNumericArray xStep = Convert.ToDouble(textBoxStep.Text);
                MWNumericArray xMin = Convert.ToDouble(textBoxXmin.Text);
                FunctionVisual1.FunctionVisual functionVisual = new FunctionVisual1.FunctionVisual();
                functionVisual.PlotCos(xMin, xStep, xMax);
                Random rd = new Random();
                var name = rd.Next().ToString();
                File.Copy(@".\图片\cos.png", string.Format(@".\temp\cos{0}.png",name), true);
                pictureBox1.Image = Image.FromFile(string.Format(@".\temp\cos{0}.png", name));
            }
            else
            {
                MessageBox.Show("请输入正确的数值", "提示");
            }
        }

        public static void DelectDir(string srcPath)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(srcPath);
                FileSystemInfo[] fileinfo = dir.GetFileSystemInfos();  //返回目录中所有文件和子目录
                foreach (FileSystemInfo i in fileinfo)
                {
                    if (i is DirectoryInfo)            //判断是否文件夹
                    {
                        DirectoryInfo subdir = new DirectoryInfo(i.FullName);
                        subdir.Delete(true);          //删除子目录和文件
                    }
                    else
                    {
                        //如果 使用了 streamreader 在删除前 必须先关闭流 ，否则无法删除 sr.close();
                        File.Delete(i.FullName);      //删除指定文件
                    }
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
