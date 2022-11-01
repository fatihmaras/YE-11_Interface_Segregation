using OOP_11_Interface_Segregation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_11_Interface_Segregation
{
        public class Lecture : IResearchAssistance
        {
            public void Lecturing()
            {
                throw new NotImplementedException();
            }

            public void Researching()
            {
                throw new NotImplementedException();
            }
        }
    public class Program
    {
        static void Main(string[] args)
        {
        }
    }

}



