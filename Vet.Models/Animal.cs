namespace Vet.Models;

public class Animal
{
 public string Name { get; set; }
  public string Owner { get; set; }
  public decimal Height { get; set; }

  public decimal Weight { get; set; }

  public Animal(string name, string owner, decimal height, decimal height)
  {
    this.Name = name;
    this.Owner = owner;
    this.Height = height;
    this.Weight = Weight;
  }

  public virtual string Greet()
{
    return $"Hello {this.Name}!";
}


}
