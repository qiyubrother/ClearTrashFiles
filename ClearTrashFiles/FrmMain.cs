using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace ClearTrashFiles
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(txtDataFileDir.Text))
            {
                MessageBox.Show(string.Format("[{0}] {1}", label1.Text, "无效"));
                return;
            }
            if (!Directory.Exists(txtSampleFileDir.Text))
            {
                MessageBox.Show(string.Format("[{0}] {1}", label2.Text, "无效"));
                return;
            }
            var files = Directory.GetFiles(txtSampleFileDir.Text);
            var lst = new List<InnerFileInfo>();
            foreach (var f in files)
            {
                var fi = new InnerFileInfo();
                fi.IsDataFile = true;
                fi.FileInfo = new FileInfo(f);
                if (fi.FileInfo.Attributes == FileAttributes.Hidden || fi.FileInfo.Attributes == FileAttributes.System)
                    continue;
                fi.FileInfo.IsReadOnly = false;
                fi.MD5 = GetMD5HashFromFile(f);
                lst.Add(fi);
            }

            var dirs = Directory.GetDirectories(txtSampleFileDir.Text);
            foreach (var d in dirs)
            {
                var fi = new InnerFileInfo();
                fi.IsDataFile = false;
                fi.DirName = new FileInfo(d).Name;
                lst.Add(fi);
            }
            var srcFiles = Directory.GetFiles(txtDataFileDir.Text, "*.*", SearchOption.AllDirectories);
            foreach (var f in srcFiles)
            {
                var fi = new FileInfo(f);
                if (fi.Attributes == FileAttributes.Hidden || fi.Attributes == FileAttributes.System)
                    continue;
                fi.IsReadOnly = false;
                if (lst.Exists(v => v.IsDataFile && v.FileInfo.Length == fi.Length))
                {
                    var md5 = GetMD5HashFromFile(f);
                    if (lst.Exists(v => v.MD5 == md5 && v.IsDataFile))
                    {
                        File.Delete(f);
                    }
                }
            }

            var srcDir = Directory.GetDirectories(txtDataFileDir.Text, "*.*", SearchOption.AllDirectories);
            foreach (var d in srcDir)
            {
                var fi = new FileInfo(d);
                if (fi.Attributes == FileAttributes.Hidden || fi.Attributes == FileAttributes.System)
                    continue;
                if (lst.Exists(v => v.DirName == fi.Name))
                {
                    if (Directory.Exists(d))
                    {
                        Directory.Delete(d, true);
                    }
                }
            }

            MessageBox.Show("执行完毕!");
        }

        public static string GetMD5(string myString)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] fromData = System.Text.Encoding.Unicode.GetBytes(myString);
            byte[] targetData = md5.ComputeHash(fromData);
            string byte2String = null;

            for (int i = 0; i < targetData.Length; i++)
            {
                byte2String += targetData[i].ToString("x");
            }

            return byte2String;
        }  

        private static string GetMD5HashFromFile(string fileName)
        {
            try
            {
                var file = new FileStream(fileName, FileMode.Open);
                var md5 = new MD5CryptoServiceProvider();
                byte[] retVal = md5.ComputeHash(file);
                file.Close();
 
                var sb = new StringBuilder();
                for (int i = 0; i < retVal.Length; i++)
                {
                    sb.Append(retVal[i].ToString("x2"));
                }
                return sb.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnSelDir1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtDataFileDir.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnSelDir2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtSampleFileDir.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }

    public class InnerFileInfo
    {
        public string DirName = string.Empty;
        public bool IsDataFile = true;
        public FileInfo FileInfo = null;
        public string MD5 = string.Empty;
    }
}
