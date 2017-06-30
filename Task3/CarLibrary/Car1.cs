using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarLibrary
{
    public class Car1 : Car {
		public Car1(){}
		public Car1(string name, short max, short curr) : base(name,max,curr){}
		public override void Turbo() {
			MessageBox.Show("Ramming speed!", "Faster is better");
		}
	}
    public class Car2 : Car
    {
        public Car2() { }
        public Car2(string name, short max, short curr) : base(name, max, curr) { }
        public override void Turbo()
        {
            egnState = EngineState.engineDead;
            MessageBox.Show("AAAAA", "11111111111");
        }
        public void BeQuiet(string kidName, int numb)
        {
            for (int i = 0; i < numb; i++)
            {
                MessageBox.Show("Be quiet " + kidName + "!!");
            }
        }
    }
}
