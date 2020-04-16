# Interface Segregation Principle

#### What is Interface Segregation?

* Segregate interfaces
* Prefer small, cohesive (lean and focused) interfaces
* Divide "fat" interfaces into "role" interfaces

> "Clients should not be forced to depend
on methods they do not use." - Agile Principles, Patterns and Practices in C#

Abstraction is the heart of object-oriented design. It allows the client to be unconcerned with the implementation details of functionality. In Java, abstraction is achieved through abstract classes and interfaces.

> "Abstraction is elimination of the irrelevant and amplification of the essential." – Robert C. Martin

#### Fat Interfaces
* Classes whose interfaces are not cohesive have "fat" interfaces

```c#
public interface IWorker
{
  void Work();
  void Sleep();
}
```

```c#
public class Robot : IWorker
{
  void Work() { … }
  void Sleep()
  { 
    throw new NotImplementedException(); 
  }
}
```

#### Code Smells for ISP Violations 
* A Bulky Interface
* Not implemented methods
* A Client references a class, but only uses a small portion of it
* Unused Dependencies
* Methods Throwing Exceptions

#### ISP - Approaches
* What does the client see and use?

* The "fat" interfaces implement a number of small interfaces with just what you need

* All public members of a class divided in separate classes – again, could be thought of as an interface

* Let the client define interfaces – "role" interfaces

#### Cohesive Interfaces
* Small and Cohesive "Role" Interfaces

```c#
  public interface IWorker
  {
    void Work();
  }

  public interface ISleeper
  {
    void Sleep();
  }

  public class Robot : IWorker
  {
    void Work() { // Do some work… }
  }
```

#### Adapter Pattern

- Problem that the Adapter pattern solves
 * Reusing classes that do not have an interface that
a client requires

 * Making classes with incompatible interfaces work
together

 * Providing an alternative interface for a class

 * Convert the incompatible interface of a class Adaptee into
another interface – Target, that clients require

 * Define a separate class – Adapter, that does the job
 
 ```c#
 interface Target
 {
    void Request();
 }
 
 class Adaptee
 {
   public void SpecificRequest()
   {
     Console.Write("Called SpecificRequest()");
   }
  }
  
 class Adapter : Target
 {
   private Adaptee adaptee = new Adaptee();
 
   public void Request()
   {
     // Possibly do some other work
     adaptee.SpecificRequest();
   }
 }
 ```
