using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PoeParse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool StartStop { get; set; }

        public string Ausgabe { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            this.StartStop = !this.StartStop;

           
            var searchParams = new SearchParams()
            {
                Suche = Suche.Text
            };
            poeBackgroundWorker.WorkerReportsProgress = true;
            poeBackgroundWorker.RunWorkerAsync(searchParams);
        }

        private void poeBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string nextChangeId = string.Empty;
            var searchParams = (SearchParams) e.Argument;
            var counter = 0;

            while (StartStop)
            {
                counter++;
                try
                {
                    using (WebClient wc = new WebClient())
                    {
                        var url = "http://www.pathofexile.com/api/public-stash-tabs";
                        if (!string.IsNullOrEmpty(nextChangeId))
                        {
                            url = $"http://www.pathofexile.com/api/public-stash-tabs?id={nextChangeId}";
                        }

                        var json = wc.DownloadString(url);

                        var root = JsonConvert.DeserializeObject<Rootobject>(json);

                        //var stashes = root.stashes.Where(p => p.items.Length > 0 && (p.stash.StartsWith("~")  || p.items.Any(x=> x.note != null && x.note.StartsWith("~"))) && p.items.Any(x=> x.name.ToLower().Contains(this.Suche.Text)));
                        var stashes = root.stashes.Where(p => (p.accountName != null && p.accountName.ToLower().Contains(searchParams.Suche)) || (p.lastCharacterName != null && p.lastCharacterName.ToLower().Contains(searchParams.Suche)));

                        var liga = root.stashes.Where(p => p.items.Any(x => x.league != "Hardcore"));


                        if (stashes.Any())
                        {
                            stashes.ToList().ForEach(p =>
                            {
                                Ausgabe = $"Name {p.accountName} {Environment.NewLine} {Ausgabe}";
                            });

                            //stashes.ToList().ForEach(item =>
                            //{
                            //    var foundItem = item.items.FirstOrDefault(p => p.name.ToLower().Contains(this.Suche.Text));
                            //    this.AusgabeText.Text += $"{DateTime.Now.ToLongTimeString()} Accountname: {item.accountName} | LastCharName: {item.accountName} | Stash: {item.stash} | Note {foundItem.note} | Item {foundItem.name} {Environment.NewLine}";
                            //});
                        }
                        else
                        {
                            Ausgabe = $"Nichts gefunden für ID: {nextChangeId} {Environment.NewLine} {Ausgabe}";
                        }

                        File.WriteAllText(@"c:\Temp\poeausgabe.txt", this.AusgabeText.Text);
                        nextChangeId = root.next_change_id;

                        poeBackgroundWorker.ReportProgress(counter);
                        Thread.Sleep(1000);
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                }
            }
        }

        private void poeBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.AusgabeText.Text = Ausgabe;
        }
    }
}
