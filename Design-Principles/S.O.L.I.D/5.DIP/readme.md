# Dependency Inversion Principle (DIP)

Instead of lower level modules defining an interface that higher level module depend on, higher level modules define an interface that lower level module implement.

A. High-level modules should not depend on low-level modules. Both should depend on abstractions.\
B. Abstractions should not depend upon details. Details should depend upon abstractions.

<b> Case 1: Dependency not inverted (High level module depend on low level interface) </b>

