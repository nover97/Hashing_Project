using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Hashing_Project {
    public partial class Form1 : Form {
        private string oText = "";
        private string oFile = "";
        private bool upc = false, isFile = false;
        private bool isHex = false, isHexValidated = false;


        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load( object sender, EventArgs e ) {

        }

        /*public static String ByteArrayToHexString( byte[] str )
        {
            StringBuilder hex = new StringBuilder(str.Length * 2);
            foreach (byte b in str)
            {
                hex.AppendFormat("{0:x2}", b);
            }
            return hex.ToString();
        }

        public static byte[] HexStringByteArray( String hex )
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i++)
            {
                bytes[1 / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            }
            return bytes;
        }*/
        private static byte[] ConvertHex( string hex ) {
            //if (hex.Length % 2 == 1)

            int bytes = hex.Length / 2;
            byte[] result = new byte[bytes];
            int inputIndex = 0;
            for (int i = 0; i < bytes; i++) {
                result[i] = (byte) ((GetHexNibble(hex[inputIndex++]) << 4) + (GetHexNibble(hex[inputIndex++])));
            }
            return result;
        }

        private static int GetHexNibble( char hex ) {
            if (hex <= '9')
                return hex - '0';
            return (hex - 'a') + 10;
        }
        private bool hexValidate( string text ) {
            int n = text.Length;
            if (n % 2 == 1) return false;
            for (int i = 0; i < n; i++) {
                if (text[i] < '0') return false;
                if (text[i] > '9' && text[i] < 'a') return false;
                if (text[i] > 'f') return false;
            }
            return true;
        }
        public string mD5_Hash( string text ) {
            if (isHex && !isHexValidated)
                return "Please check your HexaDecimal input!";

            MD5 md5 = new MD5CryptoServiceProvider();
            //compute hash from the bytes of text
            md5.ComputeHash(isHex ? ConvertHex(text) : ASCIIEncoding.ASCII.GetBytes(text));

            //get hash result after compute it  
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++) {
                //change it into 2 hexadecimal digits  
                //for each byte  
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString().ToLower();
        }
        public string sha1_Hash( string text ) {
            if (isHex && !isHexValidated)
                return "Please check your HexaDecimal input!";

            SHA1 sha1 = new SHA1CryptoServiceProvider();
            sha1.ComputeHash(isHex ? ConvertHex(text) : ASCIIEncoding.ASCII.GetBytes(text));

            byte[] result = sha1.Hash;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < result.Length; i++)
                sb.Append(result[i].ToString("x2"));

            return sb.ToString().ToLower();
        }
        public string sha256_Hash( string text ) {
            if (isHex && !isHexValidated)
                return "Please check your HexaDecimal input!";

            SHA256 sha256 = new SHA256CryptoServiceProvider();
            sha256.ComputeHash(isHex ? ConvertHex(text) : ASCIIEncoding.ASCII.GetBytes(text));

            byte[] result = sha256.Hash;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < result.Length; i++)
                sb.Append(result[i].ToString("x2"));

            return sb.ToString().ToLower();
        }
        public string sha384_Hash( string text ) {
            if (isHex && !isHexValidated)
                return "Please check your HexaDecimal input!";

            SHA384 sha384 = new SHA384CryptoServiceProvider();
            sha384.ComputeHash(isHex ? ConvertHex(text) : ASCIIEncoding.ASCII.GetBytes(text));

            byte[] result = sha384.Hash;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < result.Length; i++)
                sb.Append(result[i].ToString("x2"));

            return sb.ToString().ToLower();
        }
        public string sha512_Hash( string text ) {
            if (isHex && !isHexValidated)
                return "Please check your HexaDecimal input!";

            SHA512 sha512 = new SHA512CryptoServiceProvider();
            sha512.ComputeHash(isHex ? ConvertHex(text) : ASCIIEncoding.ASCII.GetBytes(text));

            byte[] result = sha512.Hash;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < result.Length; i++)
                sb.Append(result[i].ToString("x2"));
            return sb.ToString().ToLower();
        }

        public static string md5_FileHash( string filename ) {
            using (var md5 = MD5.Create()) {
                using (var stream = File.OpenRead(filename)) {
                    var hash = md5.ComputeHash(stream);
                    //return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                    return BitConverter.ToString(hash).Replace("-", "").ToLower();
                }
            }
            /*
            using (System.Security.Cryptography.MD5 md5hash = System.Security.Cryptography.MD5.Create())
            {
                string hash = GetMd5hash(md5hash, m_UserInput_TextBox.Text);
                md5TBx.Text = hash;
            }
            static string GetMd5hash( System.Security.Cryptography.MD5 md5hash, string input )
            {
                byte[] data = md5hash.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder sBuilder = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }
                return sBuilder.ToString();
            }*/
        }
        public static string sha1_FileHash( string filename ) {
            using (var sha1 = SHA1.Create()) {
                using (var stream = File.OpenRead(filename)) {
                    var hash = sha1.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLower();
                }
            }
        }
        public static string sha256_FileHash( string filename ) {
            using (var sha256 = SHA256.Create()) {
                using (var stream = File.OpenRead(filename)) {
                    var hash = sha256.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLower();
                }
            }
        }
        public static string sha384_FileHash( string filename ) {
            using (var sha384 = SHA384.Create()) {
                using (var stream = File.OpenRead(filename)) {
                    var hash = sha384.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLower();
                }
            }
        }
        public static string sha512_FileHash( string filename ) {
            using (var sha512 = SHA512.Create()) {
                using (var stream = File.OpenRead(filename)) {
                    var hash = sha512.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLower();
                }
            }
        }

        private void md5Show() {
            string hash = isFile ? md5_FileHash(oFile) : mD5_Hash(oText);
            md5TBx.Text = md5ChkBx.Checked ? hash : "Your MD5 hash will appear here";
            md5TBx.Text = upc ? md5TBx.Text.ToUpper() : md5TBx.Text;
        }
        private void sha1Show() {
            string hash = isFile ? sha1_FileHash(oFile) : sha1_Hash(oText);
            sha1TBx.Text = sha1ChkBx.Checked ? hash : "Your SHA-1 hash will appear here";
            sha1TBx.Text = upc ? sha1TBx.Text.ToUpper() : sha1TBx.Text;
        }
        private void sha256Show() {
            string hash = isFile ? sha256_FileHash(oFile) : sha256_Hash(oText);
            sha256TBx.Text = sha256ChkBx.Checked ? hash : "Your SHA-256 hash will appear here";
            sha256TBx.Text = upc ? sha256TBx.Text.ToUpper() : sha256TBx.Text;
        }
        private void sha384Show() {
            string hash = isFile ? sha384_FileHash(oFile) : sha384_Hash(oText);
            sha384TBx.Text = sha384ChkBx.Checked ? hash : "Your SHA-384 hash will appear here";
            sha384TBx.Text = upc ? sha384TBx.Text.ToUpper() : sha384TBx.Text;
        }
        private void sha512Show() {
            string hash = isFile ? sha512_FileHash(oFile) : sha512_Hash(oText);
            sha512TBx.Text = sha512ChkBx.Checked ? hash : "Your SHA-512 hash will appear here";
            sha512TBx.Text = upc ? sha512TBx.Text.ToUpper() : sha512TBx.Text;
        }

        private void allShow() {
            md5Show();
            sha1Show();
            sha256Show();
            sha384Show();
            sha512Show();
        }


        private void orgnTBx_Click( object sender, EventArgs e ) {
            orgnTBx.SelectAll();
        }
        private void orgnTBx_TextChanged( object sender, EventArgs e ) {
            oText = orgnTBx.Text;
            if (isHex) {
                oText = oText.ToLower();
                isHexValidated = hexValidate(oText);
            }
            allShow();
        }

        private void md5ChkBx_CheckedChanged( object sender, EventArgs e ) {
            md5Show();
        }
        private void sha1ChkBx_CheckedChanged( object sender, EventArgs e ) {
            sha1Show();
        }
        private void sha256ChkBx_CheckedChanged( object sender, EventArgs e ) {
            sha256Show();
        }
        private void sha384ChkBx_CheckedChanged( object sender, EventArgs e ) {
            sha384Show();
        }
        private void sha512ChkBx_CheckedChanged( object sender, EventArgs e ) {
            sha512Show();
        }

        private void md5CpyBtn_Click( object sender, EventArgs e ) {
            if (!md5ChkBx.Checked) return;
            md5TBx.SelectAll();
            md5TBx.Copy();
        }
        private void sha1CpyBtn_Click( object sender, EventArgs e ) {
            if (!sha1ChkBx.Checked) return;
            sha1TBx.SelectAll();
            sha1TBx.Copy();
        }
        private void sha256CpyBtn_Click( object sender, EventArgs e ) {
            if (!sha256ChkBx.Checked) return;
            sha256TBx.SelectAll();
            sha256TBx.Copy();
        }
        private void sha384CpyBtn_Click( object sender, EventArgs e ) {
            if (!sha384ChkBx.Checked) return;
            sha384TBx.SelectAll();
            sha384TBx.Copy();
        }
        private void sha512CpyBtn_Click( object sender, EventArgs e ) {
            if (!sha512ChkBx.Checked) return;
            sha512TBx.SelectAll();
            sha512TBx.Copy();
        }

        private void upcChkBx_CheckedChanged( object sender, EventArgs e ) {
            upc = upcChkBx.Checked;
            if (upc) {
                md5TBx.Text = md5TBx.Text.ToUpper();
                sha1TBx.Text = sha1TBx.Text.ToUpper();
                sha256TBx.Text = sha256TBx.Text.ToUpper();
                sha384TBx.Text = sha384TBx.Text.ToUpper();
                sha512TBx.Text = sha512TBx.Text.ToUpper();
            } else {
                md5TBx.Text = md5TBx.Text.ToLower();
                sha1TBx.Text = sha1TBx.Text.ToLower();
                sha256TBx.Text = sha256TBx.Text.ToLower();
                sha384TBx.Text = sha384TBx.Text.ToLower();
                sha512TBx.Text = sha512TBx.Text.ToLower();
            }
        }

        private void openFileBtn_Click( object sender, EventArgs e ) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.RestoreDirectory = true;
            ofd.Title = "Browse Files";
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            if (ofd.ShowDialog() == DialogResult.OK) {
                fileNameTBx.Text = oFile = ofd.FileName;
                isFile = true;
                allShow();
            }
        }

        private void hexChkBx_CheckedChanged( object sender, EventArgs e ) {
            isHex = hexChkBx.Checked;
            oText = (hexChkBx.Checked) ? oText.ToLower() : orgnTBx.Text;
            if(isHex)
                isHexValidated = hexValidate(oText);
            allShow();
        }

        private void delFileBtn_Click( object sender, EventArgs e ) {
            fileNameTBx.Clear();
            isFile = false;
            allShow();
        }
    }
}
