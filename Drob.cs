namespace project_nikitosa
{
    class Drob{
       public int Nomen { get; set; }
       
       private int DeNomen;
       public int DeNomenProp
       {
           get { return DeNomen; }
           set { 
                if(value != 0) DeNomen = value;
                else DeNomen = 1;
            }
       }
       
       public Drob()
       {
           this.Nomen = 1;
           this.DeNomen = 1;
       }

       public Drob(int nom, int denom)
       {
           this.Nomen =nom;
           this.DeNomenProp =denom;
       }
        //MATH
       public static Drob operator+(Drob first, Drob second){
           return new Drob(first.Nomen*second.DeNomen + second.Nomen*first.DeNomen, first.DeNomen*second.DeNomen);
       }

       public static Drob operator-(Drob first, Drob second){
           return new Drob(first.Nomen*second.DeNomen - second.Nomen*first.DeNomen, first.DeNomen*second.DeNomen);
       }
        //LOGIC
      public static bool operator==(Drob first, Drob second){
       return first.Nomen*second.DeNomen == second.Nomen*first.DeNomen;  
      }

      public static bool operator!=(Drob first, Drob second){
       return first.Nomen*second.DeNomen != second.Nomen*first.DeNomen;  
      }

      public static bool operator>(Drob first, Drob second){
       return first.Nomen*second.DeNomen > first.DeNomen*second.DeNomen;  
      }

      public static bool operator<(Drob first, Drob second){
       return first.Nomen*second.DeNomen < first.DeNomen*second.DeNomen;  
      }
      //TEXT

      public override string ToString()
        {
            return $"{this.Nomen}/{this.DeNomen}";
        }
      //SIMPLE FUNC 
      public Drob reduction(){
        int min;
	    min =  this.Nomen < this.DeNomen ?  System.Math.Abs(this.Nomen) : System.Math.Abs(this.DeNomen);
        for (int i = 2; i <= min; i++)
        {
            if(System.Math.Abs(this.Nomen) % i == 0 && System.Math.Abs(this.DeNomen) % i == 0) {
                do
                {
                    this.Nomen = this.Nomen / i;
                    this.DeNomen = this.DeNomen / i;
                } while (System.Math.Abs(this.Nomen) % i == 0 && System.Math.Abs(this.DeNomen) % i == 0);
            }
        }
        return this;
      }
    }   
}