using Parser_X.Core;
using Parser_X.Core.ibook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parser_X
{
    public partial class Parser : Form
    {
        ParserWorker<string[]> parser;
        public Parser()
        {
            InitializeComponent();
            parser = new ParserWorker<string[]>(
                new ibookParser());
            parser.OnCompleted += parser_OnCompleted;
            parser.onNewData += parser_onnewdata;

        }

        private void parser_onnewdata(object arg1, string[] arg2)
        {
          //  ListComments.Items.AddRange(arg2);
            for (int i = 0; i < arg2.Length; i++)
            {
                textBox2.Text += arg2[i] + Environment.NewLine+ Environment.NewLine;
            }
        }

        private void parser_OnCompleted(object obj)
        {
            MessageBox.Show("All works done");
        }
        private IParserSettings newibookSettings()
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            parser.Settings = new ibookSettings((int)numericIsStart.Value, (int)numericIsEnd.Value);
            parser.Start();

        }

        private void Abort_Click(object sender, EventArgs e)
        {
            parser.Abort();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListComments_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void EndPointer_Click(object sender, EventArgs e)
        {

        }
    }
}
