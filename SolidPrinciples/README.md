# SOLID Principles

*1. Single responsibility*
- If a class/method is doing more than its supposed to, remove it and create a new class.
- Add the new class as a property on the old class and use its function.
- For example refactoring out the logging logic.

*2. Open closed principle*
- Use parameters
- inheritance (mark the method as virtual then override it at a child class) 
- composition/injection (pull out to its own class then use an instance of that class, initialize this class during construction)
- extension methods
- For example creating a factory to make decisions depending on the type selected. Additional functionality can be extended through the factory by adding another
instance of the abstract class.

*3. Liskov Substitution Principle*
- Subtypes must be substitutable for their base types.
- For example using a null object pattern instead of checking for null.

*4. Interface Segregation Principle*
- Clients should not be forced to depend on methods they do not use - means break up interfaces into small and cohesive interfaces
- Prefer small, cohesive interfaces to large fat ones
- Violating ISP results in classes that depend on things they dont need
- Mode dependencies means more coupling, more brittle code, more difficult to test

*5. Dependency Inversion Principle*
- High level modules should not depend on low level modules. Both should depend on abstractions (abstract class, intefaces)
- Abstractions should not depend on details. Details should depend on abstractions.
- Abstraction describe what and details specify how.
- Dependency injection - client injects dependencies as constructor arguments, properties, method arguments
- Use constructor injection over properties and method arguments
