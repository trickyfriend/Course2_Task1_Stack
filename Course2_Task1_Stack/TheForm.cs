using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace Course2_Task1_Stack
{
    public partial class TheForm : Form
    {
        MyStack stack = new MyStack();

        public TheForm()
        {
            InitializeComponent();
        }

        private void FileChooseButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                try
                {
                    Logic.ReadFile(openFileDialog.FileName, stack);
                }
                catch (Exception except)
                {
                    FormsUtils.ErrorMessageBox(except);
                }
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                try
                {
                    saveFileDialog.InitialDirectory = Path.GetDirectoryName(saveFileDialog.FileName);
                    Logic.WriteFile(saveFileDialog.FileName, stack);
                }
                catch (Exception except)
                {
                    FormsUtils.ErrorMessageBox(except);
                }
        }


    }
}
