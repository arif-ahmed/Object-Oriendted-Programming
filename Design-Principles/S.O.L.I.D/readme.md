## What is S.O.L.I.D?

S.O.L.I.D. is a collection of best-practice, object-oriented design principles which can be applied
to your design, allowing you to accomplish various desirable goals such as loose-coupling,
higher maintainability, intuitive location of interesting code, etc. S.O.L.I.D. is an acronym for
the following principles (which are, themselves acronyms -- confused yet?).

* [SRP](http://www.dropwizard.io/1.0.2/docs/) - Single Responsibility Principle\
  THERE SHOULD NEVER BE MORE THAN ONE REASON FOR A CLASS TO CHANGE.
  
* [OCP](https://maven.apache.org/) - Open Closed Principle\
  SOFTWARE ENTITIES (CLASSES, MODULES, FUNCTIONS, ETC.) SHOULD BE OPEN FOR EXTENSION
  BUT CLOSED FOR MODIFICATION.
  
* [LSP](https://rometools.github.io/rome/) - Liskov Substitution Principle\
  FUNCTIONS THAT USE ... REFERENCES TO BASE CLASSES MUST BE ABLE TO USE OBJECTS OF
  DERIVED CLASSES WITHOUT KNOWING IT.
  
* [ISP](https://rometools.github.io/rome/) - Interface Segregation Principle\
  CLIENTS SHOULD NOT BE FORCED TO DEPEND UPON INTERFACES THAT THEY DO NOT USE
  
* [DIP](https://rometools.github.io/rome/) - Dependency Inversion Principle\
  A. HIGH LEVEL MODULES SHOULD NOT DEPEND UPON LOW LEVEL MODULES. BOTH SHOULD
  DEPEND UPON ABSTRACTIONS\
  B. ABSTRACTIONS SHOULD NOT DEPEND UPON DETAILS. DETAILS SHOULD DEPEND UPON
  ABSTRACTIONS

### SOLID software system means its allows to build system that is
- Easy to maintain
- Easy to extend
- Easy to understand
- Easy to implement
- Easy to explain
