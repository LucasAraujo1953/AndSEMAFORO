using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projLeds
{
    internal class Semaforo
    {
        private byte estado;

        public Semaforo()
        {
            this.estado = 0;
        }

        public void setVerde(int rua)
        {
            if (rua == 1)
            {
                this.estado = (byte)((int)this.estado & 248);
                this.estado = (byte)((int)this.estado | 1);
            }
            else
            {
                this.estado = (byte)((int)this.estado & 31);
                this.estado = (byte)((int)this.estado | 32);
            }
        }

        public void setAmarelo(int rua)
        {
            if (rua == 1)
            {
                this.estado = (byte)((int)this.estado & 248);
                this.estado = (byte)((int)this.estado | 2);
            }
            else
            {
                this.estado = (byte)((int)this.estado & 31);
                this.estado = (byte)((int)this.estado | 64 );
            }
        }

        public void setVermelho(int rua)
        {
            if (rua == 1)
            {
                this.estado = (byte)((int)this.estado & 248);
                this.estado = (byte)((int)this.estado | 4);
            }
            else
            {
                this.estado = (byte)((int)this.estado & 31);
                this.estado = (byte)((int)this.estado | 128);
            }
        }
    }
}
