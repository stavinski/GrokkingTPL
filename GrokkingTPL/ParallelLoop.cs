using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;
using System.Diagnostics;

namespace GrokkingTPL
{
    
    public partial class ParallelLoop : Form
    {
        public ParallelLoop()
        {
            InitializeComponent();
        }

        private void ChooseFileButton_Click(object sender, EventArgs e)
        {
            if (ReadFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var ioStopwatch = new Stopwatch();
                var cpuStopwatch = new Stopwatch();
                var writingStopwatch = new Stopwatch();
                
                var task = Task.Factory.StartNew<string[]>(() =>
                {
                    ioStopwatch.Start();
                    var content = File.ReadAllLines(ReadFileDialog.FileName);
                    ioStopwatch.Stop();
                    cpuStopwatch.Start();
                    return DoWork(content);
                });
                task.ContinueWith(results =>
                {
                    cpuStopwatch.Stop();
                    
                    if (!results.IsFaulted)
                    {
                        writingStopwatch.Start();
                        var content = new StringBuilder();
                        foreach (var line in results.Result)
                        {
                            content.AppendLine(line);
                        }
                        ResultsTextBox.Text = content.ToString();
                        writingStopwatch.Stop();
                        ElapsedLabel.Text = string.Format("IO: {0} / CPU: {1} / Writing: {2}", ioStopwatch.ElapsedMilliseconds, cpuStopwatch.ElapsedMilliseconds, writingStopwatch.ElapsedMilliseconds);
                    }
                }, TaskScheduler.FromCurrentSynchronizationContext());
            }
        }

        private string[] DoWork(string[] content)
        {
            var results = new string[content.Length];
            
            if (SequentialRadioButton.Checked)
            {
                for (int i = 0; i < content.Length; i++)
                {
                    var words = content[i].Split(' ').ToList();
                    words.Sort();
                    results[i] = string.Join(" ", words);
                }
            }

            if (ParallelRadioButton.Checked)
            {
                var options = new ParallelOptions()
                {
                    MaxDegreeOfParallelism = Environment.ProcessorCount
                };
                Parallel.For(0, content.Length, options, index =>
                    {
                        var words = content[index].Split(' ').ToList();
                        words.Sort();
                        results[index] = string.Join(" ", words);
                    });
            }

            if (PlinqRadioButton.Checked)
            {
                results = content.AsParallel()
                                .Select(line =>
                                {
                                    var words = line.Split(' ').ToList();
                                    words.Sort();
                                    return string.Join(" ", words);
                                }).ToArray();
            }
            
            return results;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ResultsTextBox.Clear();
            ElapsedLabel.Text = "IO:  / CPU: / Writing: ";
        }
    }
}
