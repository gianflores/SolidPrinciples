# SOLID Principles

1. Single responsibility
- If a class/method is doing more than its supposed to, remove it and create a new class.
- Add the new class as a property on the old class and use its function.
- For example refactoring out the logging logic.

2. Open closed principle
- Use parameters
- inheritance (mark the method as virtual then override it at a child class) 
- composition/injection (pull out to its own class then use an instance of that class, initialize this class during construction)
- extension methods
- For example creating a factory to make decisions depending on the type selected. Additional functionality can be extended through the factory by adding another
instance of the abstract class.

3. Liskov Substitution Principle
- Subtypes must be substitutable for their base types.
- For example using a null object pattern instead of checking for null.

