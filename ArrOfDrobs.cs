using System;
namespace project_nikitosa
{
    class ArrOfDrobs{
        public Drob[] drobs { get; private set; }
        public Drob this[int num]{
                get{
                    if(num < drobs.Length)
                        return drobs[num];
                    return null;

                }
                private set{}
        }
       
        public void add(Drob drob){
            Array.Resize<Drob>(ref drobs, drobs.Length + 1);
            drobs[drobs.Length] = drob;
        }

        public Drob sum(){
            Drob returned = new Drob();
            for (var i = 0; i < drobs.Length-1; i++)
            {
                returned = returned + drobs[i];
            }
            return returned;
        }
    }
}