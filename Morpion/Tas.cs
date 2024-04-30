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
        private byte[] aNombreAllumetteBin;

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
        public byte[] NombreAllumetteBin 
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

        private byte[] intToBin(byte pNombreAllumette)
        {
            byte[] nombreAllumetteBin = new byte[3];
            for (byte i = (byte)(nombreAllumetteBin.Length - 1); pNombreAllumette != 0; i--)
            {
                nombreAllumetteBin[i] = (byte)(pNombreAllumette % 2);
                pNombreAllumette = (byte)(pNombreAllumette / 2);
            }
            return nombreAllumetteBin; 
        } 

        private byte binToInt(byte[] pNombreAllumetteBin)
        {
            byte nombreAllumette = 0;
            for (sbyte i = (sbyte)(pNombreAllumetteBin.Length - 1); i >= 0; i--)
            {
                nombreAllumette += (byte)(pNombreAllumetteBin[i] * Math.Pow(2, i));
            }
            return nombreAllumette;
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
