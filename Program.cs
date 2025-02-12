using System;

class Rectangle{
    public double Height {get;set;}
    public double Width {get;set;}

    
    public Rectangle(){
        Height=2;
        Width=4;
    }

    public Rectangle(double height,double width){
        Width = width;
        Height = height;
    }

    public Rectangle(Rectangle other){
        Width = other.Width;
        Height = other.Height;
    }

    

    public double S(){
        return Height*Width;
    }

    ~Rectangle()
    {
        Console.WriteLine($"Дестурктор");
    }
}

class Program{
    static void Main(string[] args)    {
        Rectangle rec1 = new Rectangle();        
        Console.WriteLine($"Ширина:{rec1.Width} Длина:{rec1.Height} Площадь: {rec1.S()}");
        Rectangle rec2 = new Rectangle(3,1);
        Console.WriteLine($"Ширина:{rec2.Width} Длина:{rec2.Height} Площадь: {rec2.S()}");
        Rectangle rec3 = new Rectangle(rec2);        
        Console.WriteLine($"Ширина:{rec3.Width} Длина:{rec3.Height} Площадь: {rec3.S()}");
    }
}
