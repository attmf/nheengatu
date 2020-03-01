using System;

namespace Core
{
    public class Datas
    {
        public static DateTime Hoje
        {
            get
            {
                return DateTime.Today;
            }
        }
        
        public static DateTime Agora
        {
            get;
            set;
        }

        public static string HojeFormatada
        {
            get
            {
                return Hoje.ToString("dd/MM/yyyy");
            }
        }
        public static string AgoraFormatada
        {
            get
            {
                return Agora.ToString("dd/MM/yyyy");
            }
        }

        public static string Temporaria = null;
    }
}