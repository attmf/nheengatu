using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Core
{
    public class Validar
    {
        public static bool Formulario(Panel panel, int erro = 0)
        {
            foreach (Control c in panel.Controls)
            {
                if (c is TextBox || c is MaskedTextBox)
                {
                    erro += Campo(c);
                }
            }

            return erro.Equals(0);
        }

        static int Campo(object sender, string name = null, string text = null, bool erro = false)
        {
            name = (sender as Control).Name.Replace("_input", string.Empty).Trim();
            text = (sender as Control).Text.ToLower();

            if (Amostras.Letras.Campos.Contains(name))
            {
                erro = !Regex.Match(text, Amostras.Letras.Pattern).Success;
            }
            else if (Amostras.LetrasHifen.Campos.Contains(name))
            {
                erro = !Regex.Match(text, Amostras.LetrasHifen.Pattern).Success;
            }
            else if (Amostras.LetrasHifenNumeros.Campos.Contains(name))
            {
                text = text.Length.Equals(0) ? "--" : text;
                erro = !Regex.Match(text, Amostras.LetrasHifenNumeros.Pattern).Success;
            }
            else if (Amostras.LetrasHifenNumerosArrobaUnderline.Campos.Contains(name))
            {
                erro = !Regex.Match(text, Amostras.LetrasHifenNumerosArrobaUnderline.Pattern).Success;
            }
            else if (Amostras.LetrasHifenNumerosArrobaUnderlinePontuacao.Campos.Contains(name))
            {
                erro = !Regex.Match(text, Amostras.LetrasHifenNumerosArrobaUnderlinePontuacao.Pattern).Success;
            }
            else if (Amostras.Numeros.Campos.Contains(name))
            {
                text = text.Length.Equals(0) ? "0" : text;
                erro = !Regex.Match(text, Amostras.Numeros.Pattern).Success;
            }
            else if (Amostras.NumerosComMascara.Campos.Contains(name))
            {
                erro = !(sender as MaskedTextBox).MaskCompleted;
            }

            (sender as Control).Text = text;
            (sender as Control).BackColor = Colors.Default;

            if (erro)
            {
                (sender as Control).BackColor = Colors.Error;
                (sender as Control).Focus();
            }

            return erro ? 1 : 0;
        }
    }
}
