
// car obj = new car();
// obj.display();
/*
class Car : Engine
{
  private String carCompany { get; set; }
  private String carType { get; set; }
  private String carColor { get; set; }
  private int carPrice { get; set; }


  public Car(String carCompanay, String carType, String carColor, int carPrice)
  {
    Console.WriteLine("Car Constructure Executed");
    this.carCompany = carCompanay;
    this.carType = carType;
    this.carColor = carColor;
    this.carPrice = carPrice;
    
  }
  public void Display()
  {
    Console.WriteLine("This is a car");
  }

  static void Main(String[] args)
  {
    Car car = new Car("BMW", "Sedan", "Black", 5000000);
    car.Display();
    car.Start();
    car.Stop(); 
  }
}
*/
/*
class ParentClass
{
  public void method1()
  {
    Console.WriteLine("Method 1 Called from ParentClass");
  }

  public virtual void method2(int value)
  {
    Console.WriteLine("Method 2 Called from ParentClass with value: " + value);
  }

}

class ChildClass : ParentClass
{
  public void method2()
  {
    Console.WriteLine("Method 2 Called from ChildClass");
  }

  public void method1(int value)
  {
    Console.WriteLine("Overloaded: Method 1 Called from ChildClass with value: " + value);
  }

  public override void method2(int value)
  {
    Console.WriteLine("Overridden: Method 2 Called from ChildClass with value: " + value);
  }
  public static void Main(String[] args)
  {
    // ChildClass child = new ChildClass();
    // child.method2();
    // ParentClass parent = new ParentClass();
    // parent.method1();

    ChildClass child = new ChildClass();
    child.method1(10); // method overloading 

    ParentClass parent = new ParentClass();
    parent.method1(); // method from parent class 
    // parent.method1(10); // we can not access child class method from parent class object.

    child.method2(20); // method overriding
    parent.method2(30); // method from parent class
    // parent.method2(30); // we can not access child class method from parent class object.

    NonAbstractChildClass nonAbstractChild = new NonAbstractChildClass();
    nonAbstractChild.AbstractMethod1();
    nonAbstractChild.AbstractMethod2(40);


  }
}

abstract class AbstractParentClass
{
  public abstract void AbstractMethod1();
  public abstract void AbstractMethod2(int value);
  public void NormalMethod()
  {
    Console.WriteLine("Normal Method Called from AbstractParentClass");
  }
}

class NonAbstractChildClass : AbstractParentClass
{
  public override void AbstractMethod1()
  {
    Console.WriteLine("Abstract Method 1 Implemented in AbstractChildClass");
  }

  public override void AbstractMethod2(int value)
  {
    Console.WriteLine("Abstract Method 2 Implemented in AbstractChildClass with value: " + value);
  }

}
*/

using System.Collections;

class CollectionClass
{

  public void method1()
  {
    /*
    // Array
    int[] numbers = { 1, 2, 3, 4, 5 };
    int[] numberlist = new int[] { 10, 20, 30, 40, 50 };
    int[] numberlist2 = new int[6];
    numberlist2[0] = 100;
    numberlist2[1] = 200;

    String[] names = { "John", "Jane", "Jack", "Jill" };

    foreach (int number in numbers)
    {
      Console.WriteLine("Array Number: " + number);
    }

    for (int i = 0; i < numberlist.Length; i++)
    {
      Console.WriteLine("Array Number List: " + numberlist[i]);
    }

    foreach (String name in names)
    {
      Console.WriteLine("Array Name: " + name);
    }
    for (int i = 0; i < names.Length; i++)
    {
      Console.WriteLine("Array Name List: " + names[i]);
    }
    {
      
    }
    */

    // Array List
    ArrayList arrayList = new ArrayList();
    arrayList.Add(1);
    arrayList.Add("Hello");
    arrayList.Add(3.14);
    foreach (var item in arrayList)
    {
      Console.WriteLine("ArrayList Item: " + item);
    }

    // Hash Table
    Hashtable hashtable = new Hashtable();
    hashtable.Add("K001", "Harsha");  
    hashtable.Add("K002", "Rahul");
    hashtable.Add("K003", 4567654);
    foreach (DictionaryEntry entry in hashtable)
    {
      Console.WriteLine("Hashtable Key: " + entry.Key + ", Value: " + entry.Value);
    }


  }

  public static void Main(String[] args)
  {
    CollectionClass collection = new CollectionClass();
    collection.method1();
  }
}