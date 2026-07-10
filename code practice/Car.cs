
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
using System.Collections.Generic;

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
    /*
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
    */

    // Generic Collections
    List<int> intList = new List<int>();
    intList.Add(10);
    intList.Add(20);
    intList.Add(30);

    Dictionary<String, Object> genricList = new Dictionary<String, Object>();
    genricList.Add("1UWEYRUQYWER7R727R", "Harsha");
    genricList.Add("32R862TR2TRQ8TR263", "Rahul");
    genricList.Add("54R862TR2TRQ8TR265", "Priya");

    Console.WriteLine("\n");
    printDitionaryList(genricList);

    Dictionary<String, List<int>> genricList2 = new Dictionary<String, List<int>>();
    genricList2.Add("Y8R284YR36TR4872TR4", intList);
    Console.WriteLine("\n");
    printDitionaryList2(genricList2);

    void printDitionaryList(Dictionary<String, Object> genricList)
    {
      foreach (var kvp in genricList)
      {
        Console.WriteLine("Generic Dictionary Item: " + kvp.Key + " - " + kvp.Value);
      }
    }

    void printDitionaryList2(Dictionary<String, List<int>> genricList2)
    {
      foreach (var kvp in genricList2)
      {
        Console.WriteLine("Generic Dictionary Item Key: " + kvp.Key);
        foreach (int number in kvp.Value)
        {
          Console.WriteLine("  - " + number);
        }
      }
    }


    void printList(List<int> intList)
    {
      foreach (int number in intList)
      {
        Console.WriteLine("Generic List Item: " + number);
      }
    }
    Console.WriteLine("\n");
    printList(intList);

    intList.Remove(20);
    Console.WriteLine("\n");
    Console.WriteLine("After Removing 20:");
    printList(intList);

    intList.Insert(1, 25);
    Console.WriteLine("\n");
    printList(intList);

    intList.Sort();
    Console.WriteLine("\n");
    printList(intList);


    Queue queue = new Queue();
    queue.Enqueue(1);
    queue.Enqueue(2);
    queue.Enqueue("Harsha");
    queue.Enqueue(3.14);
    queue.Enqueue(true);
    queue.Enqueue('A');

    void printQueue(Queue queue)
    {
      Console.WriteLine("\n");
      Console.WriteLine("Queue Items:");
      foreach (var item in queue)
      {
        Console.WriteLine("  - " + item);
      }
    }

    printQueue(queue);
    queue.Dequeue(); // removed first item
    Console.WriteLine("Queue Count: " + queue.Count);
    Console.WriteLine("Contains 'Harsha': " + queue.Contains("Harsha")); // item checking
    Console.WriteLine("Peek (first item): " + queue.Peek()); // returns first item without removing it
    Queue queue2 = (Queue)queue.Clone(); // creates a shallow copy of the queue
    printQueue(queue2);
    queue2.Clear(); // removes all items from the queue
    Console.WriteLine("Queue2 Count after Clear: " + queue2.Count);

    Stack stack = new Stack();
    stack.Push("Harsha");
    stack.Push(1);
    stack.Push('A');
    stack.Push(8.4563);

    void printStack(Stack stack)
    {
      Console.WriteLine("\n");
      Console.WriteLine("Stack Items:");
      foreach (var item in stack)
      {
        Console.WriteLine("  - " + item);
      }
    }

    printStack(stack);
    stack.Pop(); // removes the top item  
    stack.Peek(); // returns the top item without removing it
    Console.WriteLine("Stack Count: " + stack.Count);
    stack.Clear(); // removes all items from the stack
    printStack(stack);



    HashSet<Object> hashset = new HashSet<Object>();
    hashset.Add("Harsha");
    hashset.Add(1);
    hashset.Add('A');
    hashset.Add(8.4563);
    hashset.Add("Harsha");
    hashset.Add(1);

    void printHashSet(HashSet<Object> hashset)
    {
      Console.WriteLine("\n");
      Console.WriteLine("HashSet Items:");
      foreach (var item in hashset)
      {
        Console.WriteLine("  - " + item);
      }
    }

    printHashSet(hashset);

    hashset.Remove(1);
    hashset.RemoveWhere(item => item is string && item.ToString()!.StartsWith("H")); // removes all items that start with "H"
    hashset.Add("New Item"); // adds a new item to the hashset
    printHashSet(hashset);
    hashset.Clear(); // removes all items from the hashset
    Console.WriteLine("HashSet Count: " + hashset.Count);

  }

  public static void Main(String[] args)
  {
    CollectionClass collection = new CollectionClass();
    collection.method1();
  }
}