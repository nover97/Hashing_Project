using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Hashing_Project
{
    public partial class Form1 : Form
    {
        private string oText = "";
        public static string mD5_Hash( string text )
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            //compute hash from the bytes of text  
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            //get hash result after compute it  
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits  
                //for each byte  
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString().ToLower();
        }

        public static string sha1_Hash( string text )
        {
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            sha1.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            byte[] result = sha1.Hash;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < result.Length; i++)
                sb.Append(result[i].ToString("x2"));

            return sb.ToString().ToLower();
        }

        public static string sha256_Hash( string text )
        {
            SHA256 sha256 = new SHA256CryptoServiceProvider();
            sha256.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            byte[] result = sha256.Hash;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < result.Length; i++)
                sb.Append(result[i].ToString("x2"));

            return sb.ToString().ToLower();
        }

        public static string sha384_Hash( string text )
        {
            SHA384 sha384 = new SHA384CryptoServiceProvider();
            sha384.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            byte[] result = sha384.Hash;
            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < result.Length; i++)
                sb.Append(result[i].ToString("x2"));

            return sb.ToString().ToLower();
        }

        public static string sha512_Hash( string text )
        {
            SHA512 sha512 = new SHA512CryptoServiceProvider();
            sha512.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            byte[] result = sha512.Hash;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < result.Length; i++)
                sb.Append(result[i].ToString("x2"));
            return sb.ToString().ToLower();
        }
        /*
        public static string sha3_Hash( string text )
        {
            var hashAlgorithm = new Org.BountyCastle.Crypto.Digests.Sha3Digest(512);
        }
        */

        private void md5Checked()
        {
            if (md5ChkBx.Checked)
                md5TBx.Text = mD5_Hash(oText);
            else
                md5TBx.Text = "Your MD5 hash will appear here";
        }
        private void sha1Checked()
        {
            if (sha1ChkBx.Checked)
                sha1TBx.Text = sha1_Hash(oText);
            else
                sha1TBx.Text = "Your SHA-1 hash will appear here";
        }
        private void sha256Checked()
        {
            if (sha256ChkBx.Checked)
                sha256TBx.Text = sha256_Hash(oText);
            else
                sha256TBx.Text = "Your SHA-256 hash will appear here";
        }
        private void sha384Checked()
        {
            if (sha384ChkBx.Checked)
                sha384TBx.Text = sha384_Hash(oText);
            else
                sha384TBx.Text = "Your SHA-384 hash will appear here";
        }
        private void sha512Checked()
        {
            if (sha512ChkBx.Checked)
                sha512TBx.Text = sha512_Hash(oText);
            else
                sha512TBx.Text = "Your SHA-512 hash will appear here";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load( object sender, EventArgs e )
        {
            
        }

        private void orgnTBx_Click( object sender, EventArgs e )
        {
            orgnTBx.Clear();
        }
        private void orgnTBx_TextChanged( object sender, EventArgs e )
        {
            oText = orgnTBx.Text;
            md5Checked();
            sha1Checked();
            sha256Checked();
            sha384Checked();
            sha512Checked();
        }

        private void md5ChkBx_CheckedChanged( object sender, EventArgs e )
        {
            md5Checked();
        }
        private void sha1ChkBx_CheckedChanged( object sender, EventArgs e )
        {
            sha1Checked();
        }
        private void sha256ChkBx_CheckedChanged( object sender, EventArgs e )
        {
            sha256Checked();
        }
        private void sha384ChkBx_CheckedChanged( object sender, EventArgs e )
        {
            sha384Checked();
        }
        private void sha512ChkBx_CheckedChanged( object sender, EventArgs e )
        {
            sha512Checked();
        }
        
        private void md5CpyBtn_Click( object sender, EventArgs e )
        {
            md5TBx.SelectAll();
            md5TBx.Copy();
        }
        private void sha1CpyBtn_Click( object sender, EventArgs e )
        {
            sha1TBx.SelectAll();
            sha1TBx.Copy();
        }
        private void sha256CpyBtn_Click( object sender, EventArgs e )
        {
            sha256TBx.SelectAll();
            sha256TBx.Copy();
        }
        private void sha384CpyBtn_Click( object sender, EventArgs e )
        {
            sha384TBx.SelectAll();
            sha384TBx.Copy();
        }
        private void sha512CpyBtn_Click( object sender, EventArgs e )
        {
            sha512TBx.SelectAll();
            sha512TBx.Copy();
        }

        
    }
}
