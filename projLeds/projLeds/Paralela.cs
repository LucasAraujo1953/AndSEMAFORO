using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace projLeds
{
    internal class Paralela
    {
        // Escreve um byte no endereço
        [DllImport("Inpout32.dll", EntryPoint = "Out32")]
        public static extern void Escrever(int endereco, byte valor);

        // Lê um byte do endereço
        [DllImport("Inpout32.dll", EntryPoint = "Inp32")]
        public static extern byte Ler(int endereco);
    }
}
