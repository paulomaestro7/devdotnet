using System;
using System.Collections.Generic;
using System.Text;

namespace Aula2Demo3
{
    public static class Util
    {
        public static string RemoverAcentos(this string Texto)
        {
            string ComAcentos = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç";
            string SemAcentos = "AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCc";

            for (int i = 0; i < ComAcentos.Length; i++)
            {
                Texto = Texto.Replace(ComAcentos[i].ToString(), SemAcentos[i].ToString());
            }
            return Texto;
        }

        public static string RemoverAcentos(this string Texto, string Ignorar)
        {
            string ComAcentos = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç";
            string SemAcentos = "AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCc";

            for (int i = 0; i < ComAcentos.Length; i++)
            {
                if (ComAcentos[i].ToString() != Ignorar)
                    Texto = Texto.Replace(ComAcentos[i].ToString(), SemAcentos[i].ToString());
            }
            return Texto;
        }
    }
}
