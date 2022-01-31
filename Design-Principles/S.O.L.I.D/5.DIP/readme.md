# Dependency Inversion Principle (DIP)

Instead of lower level modules defining an interface that higher level module depend on, higher level modules define an interface that lower level module implement.

<b> A. High-level modules should not depend on low-level modules. Both should depend on abstractions.</b>\
<b> B. Abstractions should not depend upon details. Details should depend upon abstractions. </b>


![alt text](https://lh3.googleusercontent.com/proxy/VE7XI9R4miWeI8IlvvhDGkNvJd7i5durwZGL-WsdGDMK06etTfv4Fh1TUgsbc_KG7q7hi5360P1aPgATSuWiscIdgMmc6vK9n7w2HebJsQ)

![alt text](https://i0.wp.com/blogs.innovationm.com/wp-content/uploads/2017/11/DependencyInversionPrinciple.jpg?fit=624%2C499)

### Dependencies and Coupling
* Depend directly on other modules - Tight Coupling
* Depend on abstractions - Loose Coupling

### DIP Violations
* Classic DIP Violations:
    * Using the new keyword
    * Using static methods / properties

* How to fix code, that violates the DIP:
   * Extract interfaces + use constructor injection
   * Set up an Inversion of Control (IoC) container

References:
* [A curry of Dependency Inversion Principle (DIP), Inversion of Control (IoC), Dependency Injection (DI) and IoC Container](https://www.codeproject.com/Articles/538536/A-curry-of-Dependency-Inversion-Principle-DIP-Inve)
