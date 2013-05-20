using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Concurrent;

namespace GrokkingTPL
{
    public partial class ParallelAggregation : Form
    {
        public ParallelAggregation()
        {
            InitializeComponent();
        }

        private void ChooseFileButton_Click(object sender, EventArgs e)
        {
            if (ReadFileDialog.ShowDialog() == DialogResult.OK)
            {
                var ioStopwatch = new Stopwatch();
                var cpuStopwatch = new Stopwatch();
                var writingStopwatch = new Stopwatch();

                var task = Task.Factory.StartNew<Dictionary<string, int>>(() =>
                    {
                        ioStopwatch.Start();
                        var content = File.ReadAllText(ReadFileDialog.FileName);
                        ioStopwatch.Stop();
                        cpuStopwatch.Start();
                        return DoWork(content);
                    });

                task.ContinueWith(results =>
                    {
                        cpuStopwatch.Stop();
                        if (!results.IsFaulted)
                        {
                            //writingStopwatch.Start();
                            //WordsGridView.DataSource = results.Result
                            //                            .Select(item => new { Word = item.Key, Count = item.Value }).ToArray();
                            //writingStopwatch.Stop();
                            ElapsedLabel.Text = string.Format("IO: {0} / CPU: {1} / Writing: {2}", ioStopwatch.ElapsedMilliseconds, cpuStopwatch.ElapsedMilliseconds, writingStopwatch.ElapsedMilliseconds);
                        }
                    },
                    TaskScheduler.FromCurrentSynchronizationContext()); // execute on UI thread
                
            }
        }

        private Dictionary<string, int> DoWork(string content)
        {
            var results = new Dictionary<string, int>();
            var words = content.Split(' ');

            if (SequentialRadioButton.Checked)
            {
                foreach (var word in words)
                {
                    if (results.ContainsKey(word))
                        results[word] = results[word] + 1;
                    else
                        results.Add(word, 1);
                }
            }

            if (ParallelRadioButton.Checked)
            {
                var locker = new Object();
                var options = new ParallelOptions()
                {
                    MaxDegreeOfParallelism = Environment.ProcessorCount
                };
                Parallel.ForEach(words,
                    options,
                    () => new Dictionary<string, int>(), // create new local dictionary
                    (word, state, index, dictionary) => // do work
                    {
                        if (dictionary.ContainsKey(word))
                            dictionary[word] = dictionary[word] + 1;
                        else
                            dictionary.Add(word, 1);

                        return dictionary;
                    },
                    (dictionary) => { 
                        lock (locker) // merge dictionary values
                        {
                            foreach (var word in dictionary.Keys)
                            {
                                if (results.ContainsKey(word))
                                    results[word] += dictionary[word];
                                else
                                    results.Add(word, dictionary[word]);
                            }
                        } 
                    });
            }

            if (PlinqRadioButton.Checked)
            {
                results = words.AsParallel()
                            .WithDegreeOfParallelism(Environment.ProcessorCount)
                            .GroupBy(word => word)
                            .Select(group => new { Word = group.Key, Count = group.Count() })
                            .ToDictionary(key => key.Word, selector => selector.Count);     
            }

            if (BadParallelRadioButton.Checked)
            {
                var lockedDictionary = new ConcurrentDictionary<string, int>();
                var options = new ParallelOptions()
                {
                    MaxDegreeOfParallelism = Environment.ProcessorCount
                };
                Parallel.ForEach(words, options, word =>
                    {
                        lockedDictionary.AddOrUpdate(word, 1, (key, value) => value + 1);
                    });
            }

            return results;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            WordsGridView.DataSource = null;
            ElapsedLabel.Text = "IO:  / CPU: / Writing: ";
        }
    }
}
