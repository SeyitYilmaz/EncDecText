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

namespace PassDecEnc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string alphabet = "0123456789ABCDEFGHIJKLMNOPQRSTUWXYZabcdefghijklmnopqrstuwxyz";
        private void btn_Enc_Click(object sender, EventArgs e)
        {
            lbl_crypted.Text = text_enc(txt_EncText.Text);
            
        }
        private string text_enc(string text)
        {
            lbl_cipher.Text = "";
            lbl_crypted.Text = "";
            lbl_dcr.Text = "";
            Random rnd = new Random();
            string cryptedText = "";
            string asciiText = "";
            int rndIndex = 0;
            int textCharacterPosition = 0;
            for (int i = 0; i < text.Length; i++)
            {
                textCharacterPosition = alphabet.IndexOf(text[i]);
                rndIndex = rnd.Next(0, alphabet.Length);
                asciiText += (char)rndIndex;
                cryptedText += (char)(rndIndex + textCharacterPosition);
            }
            lbl_cipher.Text = asciiText;
            Console.WriteLine(asciiText);
            return cryptedText;
        }

        private string text_dec(string cryptedText, string cipherText)
        {
            string decryptedText = "";
            int x = 0, y = 0;
            for (int i = 0; i < cryptedText.Length; i++)
            {
                Console.WriteLine("Y eski = " + y);
                x = (int)cryptedText[i];
                Console.WriteLine(x);
                y = (int)cipherText[i];
                Console.WriteLine(y);
               
                Console.WriteLine((int)cryptedText[i] - (int)cipherText[i]);
                decryptedText += alphabet[((int)cryptedText[i]-(int)cipherText[i])];
            }
            return decryptedText;
        }

        private void btn_Dec_Click(object sender, EventArgs e)
        {
            lbl_dcr.Text = text_dec(lbl_crypted.Text, lbl_cipher.Text);
        }

    }
}
