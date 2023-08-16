using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBRSP_Slides
{
    class Settings
    {
        private static readonly int _defaultWidth = 800;
        private static readonly int _defaultHeight = 600;
        private static readonly int _defaultTamanhoFonte = 90;
        private static readonly float _defaultEspacoLinha = 2.5f;
        private static readonly Boolean _defaultLetraMaiucscula = true;
        private static readonly string _defaultEnderecoIP = "192.168.0.173";
        private static readonly int _defaultPortaIP = 8001;
        private static readonly int _defaultMonitorExibicao = 1;
        private static readonly string _defaultPastaInicial = "c:\\Letras\\";
        private static readonly int _defaultTamanhoImagem = 2;
        private static readonly float _defaultEspacoSuperior = 7f;
        private static readonly string _defaultImagemFundo = "";

        public static int WindowWidth
        {
            get
            {
                int value;
                if (!int.TryParse(ConfigurationManager.AppSettings["WindowWidth"], out value))
                    value = _defaultWidth;
                return value;
            }
        }

        public static int WindowHeight
        {
            get
            {
                int value;
                if (!int.TryParse(ConfigurationManager.AppSettings["WindowHeight"], out value))
                    value = _defaultHeight;
                return value;
            }
        }

        public static int TamanhoFonte
        {
            get
            {
                int value;
                if (!int.TryParse(ConfigurationManager.AppSettings["TamanhoFonte"], out value))
                    value = _defaultTamanhoFonte;
                return value;
            }
        }

        public static float EspacoLinha
        {
            get
            {
                float value;
                if (!float.TryParse(ConfigurationManager.AppSettings["EspacoLinha"], out value))
                    value = _defaultEspacoLinha;
                return value;
            }
        }

        public static Boolean LetraMaiucscula
        {
            get
            {
                Boolean value;
                if (!Boolean.TryParse(ConfigurationManager.AppSettings["LetraMaiucscula"], out value))
                    value = _defaultLetraMaiucscula;
                return value;
            }
        }

        public static string EnderecoIP
        {
            get
            {
                return ConfigurationManager.AppSettings["EnderecoIP"] ?? _defaultEnderecoIP;
            }
        }

        public static int PortaIP
        {
            get
            {
                int value;
                if (!int.TryParse(ConfigurationManager.AppSettings["PortaIP"], out value))
                    value = _defaultPortaIP;
                return value;
            }
        }

        public static int MonitorExibicao
        {
            get
            {
                int value;
                if (!int.TryParse(ConfigurationManager.AppSettings["MonitorExibicao"], out value))
                    value = _defaultMonitorExibicao;
                return value;
            }
        }

        public static string PastaInicial
        {
            get
            {
                return ConfigurationManager.AppSettings["PastaInicial"] ?? _defaultPastaInicial;
            }
        }

        public static int TamanhoImagem
        {
            get
            {
                int value;
                if (!int.TryParse(ConfigurationManager.AppSettings["TamanhoImagem"], out value))
                    value = _defaultTamanhoImagem;
                return value;
            }
        }

        public static float EspacoSuperior
        {
            get
            {
                float value;
                if (!float.TryParse(ConfigurationManager.AppSettings["EspacoSuperior"], out value))
                    value = _defaultEspacoSuperior;
                return value;
            }
        }

        public static string ImagemFundo
        {
            get
            {
                return ConfigurationManager.AppSettings["ImagemFundo"] ?? _defaultImagemFundo;
            }
        }

    }
}
