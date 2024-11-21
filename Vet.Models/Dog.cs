namespace Vet.Models;

public class Dog
: Animal
{
 public Dog(string name, string owner, decimal height, decimal height)
 :base(name, owner, weight, height){}

 public override string Greet()
 {
    return $"Woof {this.Name}!";
 }
}