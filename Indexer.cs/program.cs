//using System;


class Employe<T>
{
    private T[] employe = new T[10];
    public T this[int index]
    {
        get { return employe[index]; }
        set { employe[index] = value; }
    }
}


class Program
{
    static void Main(string[] args)
    {
        Employe<string> Name = new Employe<string>();

        Name[0] = "ahmadgholi";
        Name[1] = "shala";
        Name[2] = "abas";

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(Name[i]);
        }


    }

}
