using System;
using System.Collections.Generic;

public class MiniZoo
{
    private List<Animal> _animais;

    public MiniZoo()
    {
        _animais = new List<Animal>();
    }
    NewAnimal(string nome, int idade) => Leão.Add(new Mamifero(nome, idade));
    NewAnimal(string nome, int idade) => Cobra.Add(new Mamifero(nome, idade));
    EmitirSomDeTodosOsAnimais()
    {
        foreach (Animal animal in _animais)
        {
            Console.WriteLine(animal.EmitirSom());
        }
    }
  ImprimirTodosOsAnimais()
    {
        {Animal.GetType().Name}

    }


}
