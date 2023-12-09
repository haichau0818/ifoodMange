using FoodManage.GUI.Forms.AlertBox;
using FoodManage.GUI.UserControls.Home;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodManage.ULTI
{
    public class handle
    {
        public static byte[] ConvertImageFromPictureBox(PictureBox pic)
        {
            Image image = pic.Image;
            byte[] image_aray;
            ImageConverter converter = new ImageConverter();
            image_aray = (byte[])converter.ConvertTo(image, typeof(byte[]));
            return image_aray;
        }

        public static Image ConverByteArrayToImage(byte[] bytesArr)
        {
            using (MemoryStream memstr = new MemoryStream(bytesArr))
            {
                Image img = Image.FromStream(memstr);
                return img;
            }
        }
        public static bool IsValidEmail(string eMail)
        {
            bool Result = false;

            try
            {
                var eMailValidator = new System.Net.Mail.MailAddress(eMail);

                Result = (eMail.LastIndexOf(".") > eMail.LastIndexOf("@"));
            }
            catch
            {
                Result = false;
            };

            return Result;
        }
        public static string Encrypt(string key, string plainText)
        {
            byte[] iv = new byte[16];
            byte[] array;

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                        {
                            streamWriter.Write(plainText);
                        }

                        array = memoryStream.ToArray();
                    }
                }
            }

            return Convert.ToBase64String(array);
        }

        public static string Decrypt(string key, string cipherText)
        {
            byte[] iv = new byte[16];
            byte[] buffer = Convert.FromBase64String(cipherText);

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream(buffer))
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }


        public static void AlertBox(Color backColor, Color color, string title, string content, Image icon)
        {
            frmAlert _frm = new frmAlert();
            _frm.BackgroundColorAlert = backColor;
            _frm.ColorAlert = color;
            _frm.TitleAlert = title;
            _frm.ContentAlert = content;
            _frm.IconsAlert = icon;
            _frm.ShowDialog();
        }

        public static void AlertWarning(string content)
        {
            frmAlert _frm = new frmAlert();
            _frm.BackgroundColorAlert = Color.LightGoldenrodYellow;
            _frm.ColorAlert = Color.Goldenrod;
            _frm.TitleAlert = "Warning";
            _frm.ContentAlert = content;
            _frm.IconsAlert = Properties.Resources.warning_48;
            _frm.ShowDialog();
        }
        public static void AlertError(string content)
        {
            frmAlert _frm = new frmAlert();
            _frm.BackgroundColorAlert = Color.LightPink;
            _frm.ColorAlert = Color.DarkRed;
            _frm.TitleAlert = "Error";
            _frm.ContentAlert = content;
            _frm.IconsAlert = Properties.Resources.cancel_48;
            _frm.ShowDialog();
        }
        public static void AlertSuccess(string content)
        {
            frmAlert _frm = new frmAlert();
            _frm.BackgroundColorAlert = Color.LightGray;
            _frm.ColorAlert = Color.SeaGreen;
            _frm.TitleAlert = "Success";
            _frm.ContentAlert = content;
            _frm.IconsAlert = Properties.Resources.success_48;
            _frm.ShowDialog();
        }
        public static void AlertInfomation(string content)
        {
            frmAlert _frm = new frmAlert();
            _frm.BackgroundColorAlert = Color.LightSteelBlue;
            _frm.ColorAlert = Color.DodgerBlue;
            _frm.TitleAlert = "Information";
            _frm.ContentAlert = content;
            _frm.IconsAlert = Properties.Resources.infor_48;
            _frm.ShowDialog();
        }

        public static DialogResult MessageBoxCustom(Color backColor,string text, string title,Image icons)
        {
            frmMessageBox frmMessageBox = new frmMessageBox();
            frmMessageBox.MessageContent = text;
            frmMessageBox.MessageTitle = title;
            frmMessageBox.ColorMessage = backColor;
            frmMessageBox.IconsMessage = icons;
            frmMessageBox.ShowDialog();
            return frmMessageBox.DialogResult;
        }
        public static DialogResult MessageBoxInformation(string text)
        {
            frmMessageBox frmMessageBox = new frmMessageBox();
            frmMessageBox.MessageContent = text;
            frmMessageBox.MessageTitle = "Information";
            frmMessageBox.ColorMessage = Color.DodgerBlue;
            frmMessageBox.IconsMessage = Properties.Resources.infor_48;
            frmMessageBox.ShowDialog();
            return frmMessageBox.DialogResult;
        }
        public static DialogResult MessageBoxWarning(string text)
        {
            frmMessageBox frmMessageBox = new frmMessageBox();
            frmMessageBox.MessageContent = text;
            frmMessageBox.MessageTitle = "Warning";
            frmMessageBox.ColorMessage = Color.Goldenrod;
            frmMessageBox.IconsMessage = Properties.Resources.warning_48;
            frmMessageBox.ShowDialog();
            return frmMessageBox.DialogResult;
        }

    }
}
