using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarLibrary
{

    public enum EngineState {  engineAlive, engineDead }
    public enum MusicMedia { musicCd, musicTape, musicRadio, musicMp3 }

    public abstract class Car
    {
        protected string petName;
        protected short currSpeed;
        protected short maxSpeed;
        protected EngineState egnState = EngineState.engineAlive;

        public Car()
        {
            MessageBox.Show("Car 2.0.0.0");
        }
            public Car(string name, short max, short curr) {
                MessageBox.Show("Car 2.0.0.0");
                petName = name;
                maxSpeed = max;
                currSpeed = curr;
            }
            public string PetName
            {
                get { return petName; }
                set { petName = value; }
            }
            public short CurrSpeed
            {
                get { return currSpeed; }
                set { currSpeed = value; }
            }
            public short MaxSpeed
            {
                get { return maxSpeed; }
            }

            public EngineState EngineState
            {
                get { return egnState; }
            }
            public abstract void Turbo();
            public void TurnOnRadio(bool musicOn, MusicMedia mm)
            {
                if (musicOn)
                {
                    MessageBox.Show(string.Format("Jamming {0}", mm.ToString()));
                }
                else
                {
                    MessageBox.Show("Quiet time...");
                }
            }
    }
}
