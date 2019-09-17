using System;

namespace mypp
{
    public class Point{
        public double x;
        public double y;


        public Point(double x, double y){
            this.x = x;
            this.y = y;

        }
            public void Afficher(){

                Console.Out.WriteLine("POINT("+x+","+y+")");

            }
    }
    public class cercle{
        private Point centre;
        private double rayon;

   
       public cercle(Point p,double r){
           centre = p;
           rayon = r;

       }
       public double getPerimetre(){
           return Math.Round(2*Math.PI * rayon,2);
       }
       public double getSurface(){
        return Math.Round(2*Math.PI * rayon * rayon,2);
       }
        public bool Appartient(Point p)
                {
                    double dis;
                    dis = Math.Sqrt(Math.Pow(centre.x - p.x, 2) + Math.Pow(centre.y - p.y, 2));   
                //La distance entre le centre du cercle courant et le point passé en paramètre.
                    if (dis <= rayon)
                        return true;
                    else
                        return false;
                }
 
                public void Afficher()
                {
                    Console.Out.WriteLine("CERCLE(" + centre.y + "," + centre.y + "," + rayon + ")");
        //Source : www.exelib.net

        
       
    }
    }
    class Program

    {
        static void Main(string[] args)
        {
       double x, y,r;
       Console.Out.WriteLine("donner l'absicce du centre:");
       x = double.Parse(Console.In.ReadLine());
            Console.Out.Write("Donner l'ordonné du centre: ");
                        y = double.Parse(Console.In.ReadLine());
                        Console.Out.Write("Donner le rayon: ");
                        r = double.Parse(Console.In.ReadLine());
 
                        Point centre = new Point(x, y);
                        cercle C = new cercle(centre, r); 
 
                        Console.Out.WriteLine("\n\n");
                        C.Afficher();
                        Console.Out.WriteLine("Le périmétre est : "+C.getPerimetre());
                        Console.Out.WriteLine("La surface est : " + C.getSurface());
 
                        Console.Out.WriteLine("\nDonner un point: ");
                        Console.Out.Write("X:");
                        x = double.Parse(Console.In.ReadLine());
                        Console.Out.Write("Y:");
                        y = double.Parse(Console.In.ReadLine());
 
                        Point p = new Point(x, y);
                        p.Afficher();
                        if (C.Appartient(p))
                            Console.Out.WriteLine("\nLe point appartient au cercle");
                        else
                            Console.Out.WriteLine("Le point n'appartient pas au cercle");
 
                        Console.ReadKey();
           
        } 
    }

}
    

