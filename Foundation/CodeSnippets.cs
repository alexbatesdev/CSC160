using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    internal class CodeSnippets
    {
        public static void Execute()
        {
            //Names are nonsense and meaningless in this example to illustrate the concept
            Sneefloog sneefloog = new Sneefloog();
            sneefloog.glibby();
            sneefloog.ShibbityBop();
            ProctorialSymantics proctorialSymantics = new ProctorialSymantics();
            //Here proctorial symantics calls glibby, but it is overridden in the ProctorialSymantics class
            proctorialSymantics.glibby();
            //proctorialSymantics can call shibbity bop because it is inherited from Sneefloog
            proctorialSymantics.ShibbityBop();
        }
    }

    class Sneefloog
    {
        public virtual void glibby() {
            Console.WriteLine("glibbygloglabby");
        }

        public void ShibbityBop()
        {
            Console.WriteLine("Pringled");
        }
            
    }
    
    class ProctorialSymantics : Sneefloog
    {   
        //Here we ovverride the glibby class inherited from Sneefloog
        public override void glibby()
        {
            Console.WriteLine("Glibby was overriden");
        }

        // Shibbity Bop class is inherited
    }
}
