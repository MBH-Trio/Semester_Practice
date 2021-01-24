using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExtractor;
using System.Xml.Linq;
using System.Net;
using VideoLibrary;
using System.IO;
using System.Net.Http;

namespace Youtube_Downloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        YouTubeVideo video_obj;
        public string path_str="";

        private void download(object sender, EventArgs e)
        {
            var youTube_obj = YouTube.Default; // starting point for YouTube actions
            timer1.Enabled = true;

            video_obj = youTube_obj.GetVideo(link.Text); // gets a Video object with info about the video
            int size = video_obj.Resolution;
            File.WriteAllBytes(path.Text + ".mp4", video_obj.GetBytes());
            status.Text = "Done this";
            MessageBox.Show("downloaded");
            timer1.Enabled = false;
            path_str = path.Text + ".mp4";
        }

        private  async Task check_progress(YouTubeVideo video_obj)
        {
            var client = new HttpClient();
            long? totalByte = 0;
            using (Stream output = File.OpenWrite(path_str))
            {
                using (var request = new HttpRequestMessage(HttpMethod.Head, video_obj.Uri))
                {
                    totalByte = client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).Result.Content.Headers.ContentLength;
                }
                using (var input = await client.GetStreamAsync(video_obj.Uri))
                {
                    byte[] buffer = new byte[16 * 1024];
                    int read;
                    int totalRead = 0;
                    Console.WriteLine("Download Started");
                    while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        output.Write(buffer, 0, read);
                        totalRead += read;
                        Console.Write($"\rDownloading {totalRead}/{totalByte} ...");
                    }
                    Console.WriteLine("Download Complete");
                    
                }
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void zeroitLollipopButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            DialogResult dialogResult =  saveFileDialog.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                path.Text = saveFileDialog.FileName;
            }
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            await check_progress(video_obj); 
        }
    }
    
}
