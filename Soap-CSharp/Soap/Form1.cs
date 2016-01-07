using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Soap
{
    public partial class Form1 : Form
    {
        Random ra = new Random();

        enum ODPMode
        {
            Fast = 0,
            Classic = 1
        }

        public Form1()
        {
            InitializeComponent();
        }

        #region Events
        //Driver
        private void button_aes_gen_Click(object sender, EventArgs e)
        {
            textBox_aes.Text = getRandomString(32);
        }
        private void textBox_aes_TextChanged(object sender, EventArgs e)
        {
            gen_en();
        }
        private void textBox_Content_TextChanged(object sender, EventArgs e)
        {
            gen_en();
        }
        //Passenger
        private void textBox_de_Content_TextChanged(object sender, EventArgs e)
        {
            gen_de();
        }
        private void textBox_de_aes_TextChanged(object sender, EventArgs e)
        {
            gen_de();
        }
        #endregion

        #region Generators
        private void gen_en()
        {
            string key = textBox_aes.Text;
            string content = textBox_Content.Text;
            textBox_odp_final.Text = encrypt(ODPMode.Fast, content, key);

        }
        private void gen_de()
        {
            string key = textBox_de_aes.Text;
            string content = textBox_de_Content.Text;
            textBox_odp_final.Text = decrypt(content, key);
        }
        private string encrypt(ODPMode mode, string Content, string AesKey)
        {
            byte[] FinalArray;

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
            try
            {
                byte[] keyArray = UTF8Encoding.UTF8.GetBytes(key);

                RijndaelManaged rDel = new RijndaelManaged();
                rDel.Key = keyArray;
                rDel.Mode = CipherMode.ECB; //使用 ECB Mode
                rDel.Padding = PaddingMode.PKCS7; //Padding Mode PKCS7
                ICryptoTransform cTransform = rDel.CreateEncryptor();

                byte[] wait4AESArray = UTF8Encoding.UTF8.GetBytes(wait4AES);
                FinalArray = cTransform.TransformFinalBlock(wait4AESArray, 0, wait4AESArray.Length);
            }
            catch (Exception)
            {
                return "消息密码 (AES Key) 仅允许使用大小写英文，数字，与半角标点符号";
            }

            //4. 对 AES 加密后内容再次进行 Base64 编码，保证为可见字符
            string FinalStr = Convert.ToBase64String(FinalArray, 0, FinalArray.Length);

            //5. 拼接 Url Scheme
            return "odp://" + FinalStr + "/";


        }
        private string decrypt(string Content, string AesKey)
        {
            byte[] resultArray;

            //检查 ODP 消息格式
            if (Content.Length <= 6)
            {
                return "等待输入";
            }
            if (Content.Substring(0, 6).ToLower() != "odp://")
            {
                return "不是标准的 ODP 消息体";
            }
            if (Content[Content.Length - 1] != '/')
            {
                return "ODP 消息结尾需要 '/' ";
            }

            //处理AES Key
            string key = AesKey;

            //不足32时使用odp三个字符循环直到补全为止
            string paddingStr = "odpodpodpodpodpodpodpodpodpodpodp";
            key += paddingStr;
            key = key.Substring(0, 32);

            //1. 提取密文
            string rawContent = Content.Substring(6, Content.Length - 7);

            //2. Base64 解码
            byte[] AESEncryptArray = Convert.FromBase64String(rawContent);

            //3. AES 解密
            try
            {
                byte[] keyArray = UTF8Encoding.UTF8.GetBytes(key);

                RijndaelManaged rDel = new RijndaelManaged();
                rDel.Key = keyArray;
                rDel.Mode = CipherMode.ECB;
                rDel.Padding = PaddingMode.PKCS7;

                ICryptoTransform cTransform = rDel.CreateDecryptor();
                resultArray = cTransform.TransformFinalBlock(AESEncryptArray, 0, AESEncryptArray.Length);
            }
            catch (Exception)
            {
                return "密码与消息可能不匹配";
            }

            //4. 判断类型
            string ContentBase64withTag = UTF8Encoding.UTF8.GetString(resultArray);

            if (ContentBase64withTag.ToLower().Contains("local@"))
            {
                string ContentBase64 = ContentBase64withTag.Replace("local@", "");
                return UTF8Encoding.UTF8.GetString(Convert.FromBase64String(ContentBase64));
            }
            else if (ContentBase64withTag.ToLower().Contains("remote@"))
            {
                return "Classic-ODP 暂不支持";
            }
            else
            {
                return "未知的 ODP 类型，Soap 无法解析该消息";
            }
        }
        #endregion

        private string getRandomString(int _Length)
        {
            string _strList = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuioplkjhgfdsazxcvbnm1234567890";
            string _buffer = "";
            for (int i = 1; i <= _Length; i++)
            {
                _buffer += _strList[ra.Next(0, 61)];
            }
            return _buffer;
        }
    }
}
