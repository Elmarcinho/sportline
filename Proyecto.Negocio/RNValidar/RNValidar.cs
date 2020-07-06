using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Proyecto.Negocio
{
    public class RNValidar
    {
        char[] CadMayuscula = { 'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P', 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'Ñ', 'Z', 'X', 'C', 'V', 'B', 'N', 'M' };
        char[] CadMinuscula = { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'ñ', 'z', 'x', 'c', 'v', 'b', 'n', 'm' };
        char[] CadNumero = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        char[] CadEspecial = { '@', '#', '%','$' };
        bool Mayuscula, Minuscula, Numero, Caracter, Complexity, vacio;
        public void Numeros(KeyPressEventArgs d)
        {
            try
            {
                if (char.IsDigit(d.KeyChar))
                { d.Handled = false; }
                else if (char.IsControl(d.KeyChar))
                { d.Handled = false; }
                else
                {
                    d.Handled = true;
                    MessageBox.Show("Por favor digitar solo numeros", "Sistema de Ventas",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            { MessageBox.Show("Error en validar","Sistema de Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error); }

        }
        public void Letras(KeyPressEventArgs d, TextBox t)
        {
            try
            {
                //if (t.Text == string.Empty)
                //{ d.Handled = char.IsWhiteSpace(d.KeyChar); }
                if (char.IsLetter(d.KeyChar))
                { d.Handled = false; }
                else if (char.IsSeparator(d.KeyChar) && t.Text.Length > 2)
                { d.Handled = false; }
                else if (char.IsControl(d.KeyChar))
                { d.Handled = false; }
                else
                {
                    d.Handled = true;
                    //MessageBox.Show("Por favor digitar solo letras");
                }
            }
            catch (Exception)
            { MessageBox.Show("Error en validar", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public void Decimal(KeyPressEventArgs e,TextBox t)
        {
            try
           {
                string cadena = t.Text;
                string filtro = "1234567890";
                if (cadena.Length > 0)
                {
                    filtro += ".";
                }
                foreach (var caracter in filtro)
                {
                    if (e.KeyChar == caracter)
                    {
                        e.Handled = false;
                        break;
                    }
                    else { e.Handled = true; }
                }
                if (cadena != "")
                {
                    if (e.KeyChar == '0' && cadena.Substring(0, 1) == "0" && cadena.Length == 1)
                    {
                        t.Text = "";
                    }
                    else if (e.KeyChar != '0' && e.KeyChar != '.' && cadena.Substring(0, 1) == "0" && cadena.Length == 1)
                    {
                        t.Text = "";
                    }
                }

                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }

                if (e.KeyChar == '.' && (~cadena.IndexOf(".")) != 0)
                {
                    e.Handled = true;
                }
                //Codigo Igual Funciona
                //if ((e.KeyChar.ToString() == ".")&&!(cadena.IndexOf(".")==-1))
                //{
                //    e.Handled = true;
                //}
            }
            catch (Exception)
            { MessageBox.Show("Error en validar", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
        public void Alfanumerico(KeyPressEventArgs d)
        {
            try
            {
                char[] Permitir = { '-', '_', ',', '/', '(', ')', '.' };

                if (Char.IsLetter(d.KeyChar))
                {
                    d.Handled = false;
                }
                else if (Char.IsDigit(d.KeyChar))
                {
                    d.Handled = false;
                }
                else if (Char.IsControl(d.KeyChar))
                {
                    d.Handled = false;
                }
                else if (Char.IsSeparator(d.KeyChar))
                {
                    d.Handled = false;
                }
                else if (Permitir.Contains(d.KeyChar))
                {
                    d.Handled = false;
                }
                else
                {
                    d.Handled = true;
                    MessageBox.Show("Por favor digitar número, letra y algunos caracteres especiales.", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            { MessageBox.Show("Error en validar", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
        public bool email(TextBox email)
        {
            string expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email.Text, expresion))
            {
                if (Regex.Replace(email.Text, expresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool txtVacio(TextBox a, TextBox b, TextBox c)
        {

            if (string.IsNullOrEmpty(a.Text) || string.IsNullOrEmpty(b.Text) ||
                string.IsNullOrEmpty(c.Text))

            {
                vacio = false;
                MessageBox.Show("Favor de llenar todos los campos.", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else { vacio = true; }

            return vacio;
        }
        public bool CompararImagem(Image imagem1, Image imagem2)
        {
            return Enumerable.SequenceEqual(GetImageByteArray(imagem1), GetImageByteArray(imagem2));
        }
        private byte[] GetImageByteArray(Image image)
        {
            using (var stream = new System.IO.MemoryStream())
            {
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);
                stream.Seek(0, System.IO.SeekOrigin.Begin);
                var byteArray = new byte[stream.Length];
                stream.Read(byteArray, 0, Convert.ToInt32(stream.Length));
                return byteArray;
            }
        }
        public Image ConvertirImagen(byte[] a)
        {

            using (System.IO.MemoryStream ms = new System.IO.MemoryStream(a))
            {
                return Image.FromStream(ms);
            }

        }
        public void Longitud(TextBox t)
        {
            try
            {
                if (t.Text.Length < 8)
                {
                    MessageBox.Show("La contraseña tiene que tener minimo 8 caracteres", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    t.Clear();
                }
                else if(t.Text.Length >15)
                {
                    MessageBox.Show("La contraseña tiene que tener mamimo 15 caracteres", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    t.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la validacion de longitud", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public bool Complejidad(TextBox t)
        {
            if ((IsMayuscula(t.Text) == false) || (IsMinuscula(t.Text) == false) || (IsNumero(t.Text) == false) || (IsEspecial(t.Text) == false))
            {
                MessageBox.Show("Contraseña no cumple con las requisito de seguridad", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Complexity = false;
            }
            else
            {
                Complexity = true;
            }
            return Complexity;
        }
        private bool IsMayuscula(string t)
        {
            char[] txtChar = t.ToCharArray();

            for (int i = 0; i < txtChar.Length; i++)
            {
                for (int x = 0; x < CadMayuscula.Length; x++)
                {

                    if (txtChar[i] == CadMayuscula[x])
                    {
                        Mayuscula = true;
                        break;
                    }
                }
            }
            return Mayuscula;
        }
        private bool IsMinuscula(string t)
        {
            char[] txtChar = t.ToCharArray();

            for (int i = 0; i < txtChar.Length; i++)
            {
                for (int x = 0; x < CadMinuscula.Length; x++)
                {

                    if (txtChar[i] == CadMinuscula[x])
                    {
                        Minuscula = true;
                        break;
                    }
                }
            }
            return Minuscula;
        }
        private bool IsNumero(string t)
        {
            char[] txtChar = t.ToCharArray();

            for (int i = 0; i < txtChar.Length; i++)
            {
                for (int x = 0; x < CadNumero.Length; x++)
                {

                    if (txtChar[i] == CadNumero[x])
                    {
                        Numero = true;
                        break;
                    }
                }
            }
            return Numero;
        }
        private bool IsEspecial(string t)
        {
            char[] txtChar = t.ToCharArray();

            for (int i = 0; i < txtChar.Length; i++)
            {
                for (int x = 0; x < CadEspecial.Length; x++)
                {

                    if (txtChar[i] == CadEspecial[x])
                    {
                        Caracter = true;
                        break;
                    }
                }
            }
            return Caracter;
        }
    }
}
