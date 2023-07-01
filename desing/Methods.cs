using desing.Model;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desing
{
    public static class Methods
    {
        public static Form? form;
        public static Panel? smallpanel;
        public static Panel? bigpanel;
        private static string key = "fahricihandemir1";
        public static void OpenForms(Form frm, Panel pnl)
        {
            try
            {
                Form1 form = new Form1();
                pnl.Controls.Clear();
                frm.MdiParent = form;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.Dock = DockStyle.Fill;
                frm.Size = pnl.Size;
                pnl.Controls.Add(frm);
                frm.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Bilinmeyen Bir Hata Meydana Geldi Lütfen Tekrar Dene :(");  
            }      
        }
        public static void LoadDGW<T>(DataGridView dgw, string fieldName, string value) where T : class
        {
            //using (var db = new HospitalContext())
            //{
            //    var table = db.Set<T>().ToList();
            //    dgw.DataSource = table;
            //}
            using (var context = new HospitalContext())
            {
                var patients = context.Patients.Where(p =>
                    fieldName == "patient_gender" ? p.patient_gender == value :
                    fieldName == "patient_name" ? p.patient_name == value :
                    false // eğer fieldName geçerli bir alan değilse hiçbir kayıt döndürmeyecek
                ).ToList();
                dgw.DataSource = patients;
            }
        }

        public static void DataGridViewDoldur(string sıralamaAnahtarı, object şartDeğeri, DataGridView dgw, string propertyName)
        {
            try
            {
                using (var context = new HospitalContext())
                {
                    if (sıralamaAnahtarı == "Doktor")
                    {
                        //var doktorlar = context.Users.OfType<User>().Where(d => d.GetType().GetProperty(şartAlanı).GetValue(d).ToString() == şartDeğeri).ToList();
                        //dgw.DataSource = doktorlar;
                        ParameterExpression parameterExpression = Expression.Parameter(typeof(User), "h");
                        MemberExpression propertyExpression = Expression.Property(parameterExpression, propertyName);
                        BinaryExpression binaryExpression = Expression.Equal(propertyExpression, Expression.Constant(şartDeğeri));
                        Expression<Func<User, bool>> lambda = Expression.Lambda<Func<User, bool>>(binaryExpression, parameterExpression);
                        var users = context.Users.Where(lambda).ToList();
                        dgw.DataSource = users;
                    }
                    else if (sıralamaAnahtarı == "Hasta")
                    {
                        ParameterExpression parameterExpression = Expression.Parameter(typeof(Patient), "h");
                        MemberExpression propertyExpression = Expression.Property(parameterExpression, propertyName);
                        BinaryExpression binaryExpression = Expression.Equal(propertyExpression, Expression.Constant(şartDeğeri));
                        Expression<Func<Patient, bool>> lambda = Expression.Lambda<Func<Patient, bool>>(binaryExpression, parameterExpression);
                        var hastalar = context.Patients.Where(lambda).ToList();
                        dgw.DataSource = hastalar;
                    }
                    else
                    {
                        throw new ArgumentException("Geçersiz sıralama anahtarı");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bilinmeyen Bir Hata Meydana Geldi Lütfen Tekrar Dene :(");
            }
        }
       
        


        public static void ChangeButtonColorInForm(Form form, Button sender)
        {
            sender.BackColor = Color.FromArgb(237, 60, 60);
            foreach (Control control in form.Controls)
            {
                if (control is Button && control != sender)
                {
                    control.BackColor = Color.Brown;
                }
            }
        }
        public static void ChangeButtonColorInPanel(Panel panel, Button sender)
        {
            sender.BackColor = Color.FromArgb(237, 60, 60);
            foreach (Control control in panel.Controls)
            {
                if (control is Button && control != sender)
                {
                    control.BackColor = Color.Brown;
                }
            }
        }
        public static bool Verification(string tc)
        {
            try
            {
                int condition1 = ((((int.Parse(tc[0].ToString()) + int.Parse(tc[2].ToString()) + int.Parse(tc[4].ToString()) + int.Parse(tc[6].ToString()) + int.Parse(tc[8].ToString())) * 7) - (int.Parse(tc[1].ToString()) + int.Parse(tc[3].ToString()) + int.Parse(tc[5].ToString()) + int.Parse(tc[7].ToString()))) % 10);
                int condition2 = ((int.Parse(tc[0].ToString()) + int.Parse(tc[1].ToString()) + int.Parse(tc[2].ToString()) + int.Parse(tc[3].ToString()) + int.Parse(tc[4].ToString()) + int.Parse(tc[5].ToString()) + int.Parse(tc[6].ToString()) + int.Parse(tc[7].ToString()) + int.Parse(tc[8].ToString()) + int.Parse(tc[9].ToString())) % 10);
                if (condition1 == int.Parse(tc[9].ToString()) && condition2 == int.Parse(tc[10].ToString()) && tc.Length == 11)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                if (tc.Length < 11)
                {
                    return false;
                }
                else
                {
                    return false;
                }
            }
        }
        public static string Encrypt(string plainText)
        {
            byte[] encryptedBytes;
            using (Aes aesAlgorithm = Aes.Create())
            {
                aesAlgorithm.Key = Encoding.UTF8.GetBytes(key);
                aesAlgorithm.IV = new byte[16]; // IV (Initialization Vector) should be 16 bytes long.
                ICryptoTransform encryptor = aesAlgorithm.CreateEncryptor();

                byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
                encryptedBytes = encryptor.TransformFinalBlock(plainTextBytes, 0, plainTextBytes.Length);

                aesAlgorithm.Clear();
            }
            string encryptedText = Convert.ToBase64String(encryptedBytes);
            return encryptedText;
        }

        public static string Decrypt(string encryptedText)
        {
            byte[] decryptedBytes;
            using (Aes aesAlgorithm = Aes.Create())
            {
                aesAlgorithm.Key = Encoding.UTF8.GetBytes(key);
                aesAlgorithm.IV = new byte[16];
                ICryptoTransform decryptor = aesAlgorithm.CreateDecryptor();

                byte[] encryptedBytes = Convert.FromBase64String(encryptedText);
                decryptedBytes = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);

                aesAlgorithm.Clear();
            }

            string decryptedText = Encoding.UTF8.GetString(decryptedBytes);
            return decryptedText;
        }
        //public static string GetPhysicalMacAddress()
        //{
        //    string macAddress = string.Empty;

        //    try
        //    {
        //        NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

        //        // Find the network interface with OperationalStatus Up
        //        NetworkInterface selectedInterface = networkInterfaces.FirstOrDefault(
        //            ni => ni.NetworkInterfaceType != NetworkInterfaceType.Loopback &&
        //                  ni.NetworkInterfaceType != NetworkInterfaceType.Tunnel &&
        //                  ni.OperationalStatus == OperationalStatus.Up);

        //        if (selectedInterface != null)
        //        {
        //            macAddress = selectedInterface.GetPhysicalAddress().ToString();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        // Handle any exceptions that may occur while retrieving the MAC address
        //        Console.WriteLine("Error retrieving physical MAC address: " + ex.Message);
        //    }

        //    return macAddress;
        //}
    }
}
