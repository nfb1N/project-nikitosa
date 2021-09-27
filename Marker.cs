namespace project_nikitosa
{
    class Marker{
        private float CountOfUsing;
        public float CountOfUsingProp
        {
            get { return CountOfUsing; }
            set { 
                    if(value < 0){
                        CountOfUsing = System.Math.Abs(value); 
                    }
                    else
                        CountOfUsing = value;    
                }
        }
        
        private System.ConsoleColor Color;
        public System.ConsoleColor ColorProp
        {
            get { return Color; }
            set { 
                    if(value != null)
                        Color = value;
                    else
                        Color = System.ConsoleColor.White;
                }
        }
        
        
        
              
        public Marker(float CountOfUsing, System.ConsoleColor Color)
        {
            this.CountOfUsingProp  = CountOfUsing;
            this.ColorProp = Color;
        }

       

        public void write(string str){
            if(str != null){
                System.Console.ForegroundColor = this.Color;
                System.Console.WriteLine(str);
                System.Console.ForegroundColor = System.ConsoleColor.White;
            }   
        }
    }
}