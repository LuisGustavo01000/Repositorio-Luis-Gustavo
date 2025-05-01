using SimuladordePatos;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("---- Simulador de Patos -------\n");

        MallardDuck duck = new MallardDuck("Pato Normal");
        duck.display();
        duck.fly();
        duck.quack();
        duck.swin();

        MuteDuck duckmute = new MuteDuck("Pato Mudo");
        duckmute.display();
        duckmute.fly();
        duckmute.swin();

        RedHeadDuck duckred = new RedHeadDuck("Pato Vermelho");
        duckred .display(); 
        duckred.fly();
        duckred.quack();
        duckred.swin();

        RuberDuck duckru = new RuberDuck("Pato de Borracha");
        duckru .display(); 
        duckru.quack();

        RocketDuck duckrocket = new RocketDuck("Pato Foguete");
        duckrocket .display();
        duckrocket.fly();

        SuperDuck ducks = new SuperDuck("Super Pato");
        ducks .display();
        ducks .fly();
        ducks.quack();
        ducks.swin();


    }
}