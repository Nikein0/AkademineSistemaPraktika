using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademineSistemaPraktika
{
    internal class Class1
    {
        private int choice;
        private int destdalykas;
        private int studentoID;

        

        public void setDalykas(int dalykas)
        {
            destdalykas = dalykas;
        }
        public int GetDalykas()
        {
            return destdalykas;
        }
        public void SetChoice(int Choice)
        {
            choice = Choice;
        }
        public int GetChoice()
        {
            return choice;
        }
        public void setStudID(int studid)
        {
            studentoID = studid;
        }
        public int GetStudID()
        {
            return studentoID;
        }
    }
}
