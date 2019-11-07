using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Business;
using Entities;

namespace Prueba_Training
{
    public partial class Form1 : Form
    {
        private List<LineCommand> LstLineCommand;
        private string OutPutText;
        private bool CloseApp;

        public Form1()
        {
            InitializeComponent();
            txtOutput.Font = new Font("Consolas", 10);
            LstLineCommand = new List<LineCommand>();
            OutPutText = "";
            CloseApp = false;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                LstLineCommand.Clear();
                OutPutText = "";
                ProcessCommands();
                ShowLCDFormatOutput();
                ValidateCloseApplication();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProcessCommands()
        {
            var LstStringCommand = txtInput.Text.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();

            int count = 1;
            foreach (var line in LstStringCommand)
            { 
                if (LineValidator.ValidLine(count, line))
                {
                    if(line == "0,0")
                    {
                        CloseApp = true;
                        break;
                    }                                         

                    LstLineCommand.Add(new LineCommand { Value = line });
                }                  
                count++;
            }
        }

        private void ShowLCDFormatOutput()
        {
            foreach(var line in LstLineCommand)
            {
                OutPutText += LCDFormatGenerator.Generate(line);
                OutPutText += Environment.NewLine;
            }

            txtOutput.Text = OutPutText;              
        }

        private void ValidateCloseApplication()
        {
            if (CloseApp)
            {
                MessageBox.Show("Aplicación finalizada correctamente", "Cerrando", MessageBoxButtons.OK);
                Close();
            }
        }
    }
}
