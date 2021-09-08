using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMediar.Model
{
    public class TextChangedEventArgs : EventArgs
    {
        private String rutafile;
        private string tipo;
        private string extension;
        private string nombre;

        //Did not implement a "Set" so that the only way to give it the Text value is in the constructor
        public String RutaFile
        {
            get { return rutafile; }
        }
        public string Tipo
        {
            get
            {
                return tipo;
            }
        }
        public string Extension
        {
            get
            {
                return extension;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
        }
        public TextChangedEventArgs(String theText,String textTwo,String textTree,string textfour)  : base()
        {
            rutafile = theText;
            tipo = textTwo;
            extension = textTree;
            nombre = textfour;
        }
    }
}
