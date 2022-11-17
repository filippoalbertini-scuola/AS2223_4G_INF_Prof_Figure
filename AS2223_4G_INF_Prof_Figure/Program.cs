using Library;

Console.WriteLine("Prof;AS 22/23 4G;17/11/22; Gestione figure geometriche - branch 2");

Figura f = new Figura();

f = new Quadrato(4);
Console.WriteLine($"Il {f.Nome} ha area {f.Area()} e perimetro {f.Perimetro()}");

f = new Rettangolo(4,2);
Console.WriteLine($"Il {f.Nome} ha area {f.Area()} e perimetro {f.Perimetro()}");

f = new Cerchio(4);
Console.WriteLine($"Il {f.Nome} ha area {f.Area()} e perimetro {f.Perimetro()}");

