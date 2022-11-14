// See https://aka.ms/new-console-template for more information

using AS2223_4G_INF_Prof_Figure;

Quadrato q = new Quadrato(4);
Rettangolo r = new Rettangolo(4,2);
Cerchio c = new Cerchio(4);

double area;
    
area = q.Area();
area = r.Area();
area = c.Area();

double perimetro;

perimetro = q.Perimetro();
perimetro = r.Perimetro();
perimetro = c.Perimetro();

Console.WriteLine("Hello, World!");
