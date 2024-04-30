using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeNim
{
    internal class Tas
    {
        private byte aNumero;
        private byte aNombreAllumette;
        private bool[] aNombreAllumetteBin;

        public byte Numero { get => aNumero; }
        public byte NombreAllumette
        {
            get => aNombreAllumette;
            set
            {
                aNombreAllumette = value;
                aNombreAllumetteBin = intToBin(value);
            }
        }
        public bool[] NombreAllumetteBin 
        { 
            get => aNombreAllumetteBin; 
            set
            {
                aNombreAllumetteBin = value;
                aNombreAllumette = binToInt(value);
            }
        
        }

        public Tas(byte pNumero, byte pNombreAllumette)
        {
            this.aNumero = pNumero;
            this.NombreAllumette = pNombreAllumette;
        }

        private bool[] intToBin(byte pNombreAllumette)
        {
            bool[] pNombreAllumetteBin = new bool[3];
            for (byte i = (byte)(pNombreAllumetteBin.Length - 1); pNombreAllumette != 0; i--)
            {
                pNombreAllumetteBin[i] = pNombreAllumette % 2 == 1;
                pNombreAllumette = (byte)(pNombreAllumette / 2);
            }
            return pNombreAllumetteBin; 
        } 

        private byte binToInt(bool[] pNombreAllumetteBin)
        {
            byte pNombreAllumette = 0;
            int max = pNombreAllumetteBin.Length - 1;
            for (int i = max; i >= 0; i--)
            {
                pNombreAllumette += (byte)((pNombreAllumetteBin[i] ? 1 : 0) * Math.Pow(2, max - i));
            }
            return pNombreAllumette;
        } 

        public override string ToString()
        {
            string afficher = "Tas " + Numero + ": ";
            for (int i = 0; i < this.aNombreAllumette; i++)
            {
                afficher += "|";
            }
            return afficher;
        }
    }
}
