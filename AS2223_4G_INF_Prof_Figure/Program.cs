// See https://aka.ms/new-console-template for more information

using AS2223_4G_INF_Prof_Figure;

Console.WriteLine("Prof;AS 22/23 4G;17/11/22; Gestione figure geometriche");

Quadrato q = new Quadrato(4);
Rettangolo r = new Rettangolo(4,2);
Cerchio c = new Cerchio(4);

Console.WriteLine($"Il quadrato ha area {q.Area()} e perimetro {q.Perimetro()}");
Console.WriteLine($"Il rettangolo ha area {r.Area()} e perimetro {r.Perimetro()}");
Console.WriteLine($"Il cerchio ha area {c.Area()} e perimetro {c.Perimetro()}");

