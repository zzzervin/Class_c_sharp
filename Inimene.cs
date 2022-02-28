using System;
using System.Collections.Generic;
using System.Text;

namespace Class_c_sharp
{
    class Inimene
    {
        string eesnimi;//поля
        int vanus;
        string staatus;
        Emakeel emakeel;
        public Inimene() { }//конструктор

        public Inimene(string Eesnimi,Emakeel emakeel)
        {
            eesnimi = Eesnimi;
            this.emakeel = emakeel;
            //vanus = Vanus;
        }

        public Emakeel Emakeel
        {
            get { return emakeel; }
        }

        public string Eesnimi
        {
            set
            {
                if (eesnimi == null) eesnimi = value; 
            }
            get { return eesnimi; } 


        }//св-ва
        public int Vanus
        {
            set
            { vanus = value;
                if (vanus < 7)
                {
                    staatus = "vaike laps";
                }

                else if (vanus < 17)
                {
                    staatus = "kooli laps";
                }

                else if (vanus < 65)
                {
                    staatus = "tööline laps";
                }

                else
                {
                    staatus = "senior";
                }
                
            }
            get { return vanus; }


        }
        public string Staatus
        {
            set { if(staatus==null)staatus = value;}
            get { return staatus; }

        }
        public void Tervetame()
        {
            Console.WriteLine("Tere");
            Console.WriteLine("Minu nimi on {0} . Olen {1} aastat vana. Minu staatus {2}{3} ", eesnimi, vanus, staatus,emakeel);
        }

        

    }
}
