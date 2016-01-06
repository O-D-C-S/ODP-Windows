using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Soap
{
    public partial class Form1 : Form
    {
        Random ra = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        #region Events
        private void button_fast_aes_gen_Click(object sender, EventArgs e)
        {
            textBox_fast_aes.Text = getRandomString(32);
        }
        private void textBox_fast_aes_TextChanged(object sender, EventArgs e)
        {
            gen_fast();
        }
        private void textBox_fast_Content_TextChanged(object sender, EventArgs e)
        {
            gen_fast();
        }
        #endregion

        #region ODPGenerator
        private void gen_fast()
        {
            string key = textBox_fast_aes.Text;
            string content = textBox_fast_Content.Text;
            textBox_odp_final.Text = encrypt_fast(content, key);

        }
        private string encrypt_fast(string Content, string AesKey)
        {
            //处理AES Key
            string key = AesKey;

            //不足32时使用odp三个字符循环直到补全为止
            string paddingStr = "odpodpodpodpodpodpodpodpodpodpodp";
            key += paddingStr;
            key = key.Substring(0, 32);

            //1. 对 Content 进行 base64 编码
            byte[] rawContentArray = UTF8Encoding.UTF8.GetBytes(Content);
            string ContentBase64 = Convert.ToBase64String(rawContentArray, 0, rawContentArray.Length);

            //2. 拼接 Fast-ODP 标识符
            string wait4AES = "local@" + ContentBase64;

            //3. AES 加密
            byte[] keyArray = UTF8Encoding.UTF8.GetBytes(key);

            RijndaelManaged rDel = new RijndaelManaged();
            rDel.Key = keyArray;
            rDel.Mode = CipherMode.ECB; //使用 ECB Mode
            rDel.Padding = PaddingMode.PKCS7; //Padding Mode PKCS7
            ICryptoTransform cTransform = rDel.CreateEncryptor();

            byte[] ContentBase64Array = UTF8Encoding.UTF8.GetBytes(ContentBase64);
            byte[] FinalArray = cTransform.TransformFinalBlock(ContentBase64Array, 0, ContentBase64Array.Length);

            //4. 对 AES 加密后内容再次进行 Base64 编码，保证为可见字符
            string FinalStr = Convert.ToBase64String(FinalArray, 0, FinalArray.Length);

            //5. 拼接 Url Scheme
            return "odp://" + FinalStr + "/";
        }
        #endregion

        private string getRandomString(int _Length)
        {
            string _strList = "qwertyuioplkjhgfdsazxcvbnm1234567890";
            string _buffer = "";
            for (int i = 1; i <= _Length; i++)
            {
                _buffer += _strList[ra.Next(0, 35)];
            }
            return _buffer;
        }
    }
}
