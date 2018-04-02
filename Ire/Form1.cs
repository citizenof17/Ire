using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ire
{
    public partial class Form1 : Form
    {
        List<List<string>> words;
        List<string> curWord;
        List<bool> isGuessed;
        bool isPlayed;
        Random rng;
        KeysConverter kc;
        HashSet<char> used;
        int TrLeft = 4;

        public Form1()
        {
            InitializeComponent();
            kc = new KeysConverter();
        }

        private void UpdateText()
        {
            string curText = curWord[0];
            string word = curWord[1];
            for (int i = 0; i < word.Length; i++)
                if (!isGuessed[i])
                {
                    StringBuilder sb = new StringBuilder(word);
                    sb[i] = '*';
                    word = sb.ToString();
                }
            int l = curText.IndexOf('*');
            int r = curText.LastIndexOf('*');
            curText = curText.Remove(l, r - l + 1);
            curText = curText.Insert(l, word);
            textBox2.Text = curText;
            TriesLeft.Text = TrLeft.ToString();
            bool isNotGuessed = false;
            for (int i = 0; i < curWord[1].Length; i++)
                if (!isGuessed[i])
                    isNotGuessed = true;
            if (TrLeft == 0 || (!isNotGuessed))
            {
                isPlayed = false;
            }
        }

        private void StartHangman()
        {
            isPlayed = true;
            int n = words.Count;
            while(n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                List<string> temp = words[k];
                words[k] = words[n];
                words[n] = temp;
            }
            curWord = words[0];
            words.RemoveAt(0);
            isGuessed = new List<bool>();
            for (int i = 0; i < curWord[1].Length; i++)
                isGuessed.Add(false);
            TrLeft = 4;

            UpdateText();
            used = new HashSet<char>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            words = new List<List<string>>();
            string[] cur = { "You can find lots of ancient books in Trinity *******.", "LIBRARY" };
            words.Add(new List<string>(cur));
            string[] cur2 = { "The monument of a famous woman Molly Malone is called Molly Malone ******.", "STATUE" };
            words.Add(new List<string>(cur2));
            string[] cur3 = { "Crags which are located at the southwestern edge of the Burren region in County Clare are called ****** of Moher.", "CLIFFS" };
            words.Add(new List<string>(cur3));
            string[] cur4 = { "Dublin ****** is now a major Irish government complex.", "CASTLE" };
            words.Add(new List<string>(cur4));
            string[] cur5 = { "Phoenix **** is a really large and magnificent place where a lot of deer live.", "PARK" };
            words.Add(new List<string>(cur5));
            rng = new Random();
            StartHangman();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isNotGuessed = false;
            for (int i = 0; i < isGuessed.Count; i++)
                if (!isGuessed[i])
                    isNotGuessed = true;
            if (isNotGuessed)
            {
                words.Add(curWord);
            }
            if (words.Count > 0)
            {
                StartHangman();
            }
            else
            {
                Form f = new FormKiller(this, "Good job! Now you are closer to Irish Treasure!");
                f.Show();
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!isPlayed) return;
            char cc = e.KeyChar;
            cc = char.ToUpper(cc);
            if (cc > 'Z' || cc < 'A')
                return;
            if (!used.Contains(cc))
            {
                used.Add(cc);
                if (curWord[1].Contains(cc))
                {
                    for (int i = 0; i < curWord[1].Length; i++)
                        if (curWord[1][i] == cc)
                            isGuessed[i] = true;
                }
                else
                    TrLeft--;
                UpdateText();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
