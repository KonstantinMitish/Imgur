using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Net;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Imgur
{
  public partial class Form1 : Form
  {
     string[] chars= {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W",
                      "X", "Y", "Z", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t",
                      "u", "v", "w", "x", "y", "z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"};
     public Form1()
     {
         InitializeComponent();
     }

     private void Form1_Load(object sender, EventArgs e)
     {

     }

    Random rnd = new Random();
    private void Form1_Click(object sender, EventArgs e)
    {


    }

    private static bool on = false;
    private void button2_Click(object sender, EventArgs e)
    {
      if (on)
      {
        timer1.Stop();
        button.Text = "START";
        on = false;
      }
      else
      {
        timer1.Start();
        button.Text = "STOP";
        on = true;
      }
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      if (!Directory.Exists("img"))
        Directory.CreateDirectory("img");
      string file = chars[rnd.Next(chars.Length)] + chars[rnd.Next(chars.Length)] +
                  chars[rnd.Next(chars.Length)] + chars[rnd.Next(chars.Length)] + chars[rnd.Next(chars.Length)] +
                  ".jpg";
      Uri url = new Uri("https://i.imgur.com/" + file);
      //url = new Uri("https://i.imgur.com/11111.jpg");
      var request = (HttpWebRequest)WebRequest.Create(url);
      request.Method = "HEAD";
      request.AllowAutoRedirect = false;
      
      using (var response = request.GetResponse() as HttpWebResponse)
      {
        if (response.StatusCode != HttpStatusCode.Redirect)
        {
          WebClient client = new WebClient();
          client.DownloadFile(url, "img/" + file);
          this.BackgroundImage = Image.FromFile("img/" + file);
        }
      }
    }
  }
}
