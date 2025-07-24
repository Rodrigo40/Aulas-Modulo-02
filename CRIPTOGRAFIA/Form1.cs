using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRIPTOGRAFIA
{
    public partial class Form1 : Form
    {
        string chaveBase64 = ""; // Chave AES
        string vetorBase64 = ""; // IV (Vetor de Inicialização)
        public Form1()
        {
            InitializeComponent();
        }
        // Gera uma nova chave AES de 256 bits (32 bytes)
        public static string GerarChave()
        {
            using (Aes aes = Aes.Create())
            {
                aes.KeySize = 256;
                aes.GenerateKey();
                return Convert.ToBase64String(aes.Key);
            }
        }
        //Criptografa o texto e retorna(TextoCriptografadoBase64, VetorBase64)
        public (string cipherText, string ivBase64) Criptografar(string plainText, string keyBase64)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Convert.FromBase64String(keyBase64);
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;
                aes.GenerateIV();
                txtModo.Text = aes.Mode.ToString();
                txtModoPreechimento.Text = aes.Padding.ToString();
                txtTamanho.Text = aes.KeySize.ToString();
                txtTamanhoBloco.Text = aes.BlockSize.ToString();

                byte[] encrypted;

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    using (StreamWriter sw = new StreamWriter(cs))
                    {
                        sw.Write(plainText);
                    }

                    encrypted = ms.ToArray(); // Agora está dentro do escopo de ms
                }

                string cipherTextBase64 = Convert.ToBase64String(encrypted);
                string ivBase64 = Convert.ToBase64String(aes.IV);

                return (cipherTextBase64, ivBase64);
            }
        }
        // Descriptografa o texto criptografado com base na chave e IV
        public string Descriptografar(string cipherTextBase64, string keyBase64, string ivBase64)
        {
            try
            {
                using (Aes aes = Aes.Create())
                {
                    aes.Key = Convert.FromBase64String(keyBase64);
                    aes.IV = Convert.FromBase64String(ivBase64);
                    aes.Mode = CipherMode.CBC;
                    aes.Padding = PaddingMode.PKCS7;
                    txtModo.Text = aes.Mode.ToString();
                    txtModoPreechimento.Text = aes.Padding.ToString();
                    txtTamanho.Text = aes.KeySize.ToString();
                    txtTamanhoBloco.Text = aes.BlockSize.ToString();

                    byte[] cipherBytes = Convert.FromBase64String(cipherTextBase64);

                    using (MemoryStream ms = new MemoryStream(cipherBytes))
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Read))
                    using (StreamReader sr = new StreamReader(cs))
                    {
                        return sr.ReadToEnd();
                    }
                }
            }
            catch (Exception ex)
            {
                return "Erro ao descriptografar: " + ex.Message;
            }
        }
        private void btnCriptografar_Click(object sender, EventArgs e)
        {
            // Gera chave se ainda não tiver
            if (string.IsNullOrEmpty(chaveBase64))
                chaveBase64 = GerarChave();

            // Criptografa
            var resultado =Criptografar(txtTexto.Text, chaveBase64);
            vetorBase64 = resultado.ivBase64;

            txtTextoCriptografado.Text = resultado.cipherText;
        }
        private void btnGrarAleatorio_Click(object sender, EventArgs e)
        {
            using (Aes aesAlgorithm = Aes.Create())
            {
                //MrrGRBMaHUJsomXAQl4WHSvA9Sr7pZ9h2pl8qVbORhE=
                aesAlgorithm.KeySize = 256;
                aesAlgorithm.GenerateKey();//Gera automaticamente uma chave de 256 bits
                string keyBase64 = Convert.ToBase64String(aesAlgorithm.Key);
                txtTamanho.Text = aesAlgorithm.KeySize.ToString();
                txtTextoCriptografado.Text = keyBase64;
            }
        }
        private void btnDecriptografar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(chaveBase64) || string.IsNullOrEmpty(vetorBase64))
            {
                MessageBox.Show("Chave ou IV não disponíveis.");
                return;
            }

            string resultado = Descriptografar(txtTextoCriptografado.Text, chaveBase64, vetorBase64);
            txtDescriptografado.Text = resultado;
        }
    }
}
