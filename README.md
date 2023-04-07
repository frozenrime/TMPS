# TMPS
🌟 My  Project 🌟
    
 📕 BookStore 📕

📚 The SOLID Principles 🧱 are a set of five object design principles used to create software that is:

💡 Easy to understand
🧮 Flexible
📈 Scalable
These principles are:

🔍 Single Responsibility Principle (SRP): This principle states that a class should have only one reason to change, i.e. have only one responsibility. 
By applying this principle, classes are assigned separate tasks and responsibilities, which makes code easier to test and maintain.

🔓 Open/Closed Principle (OCP): This principle holds that a class should be open for extension but closed for modification. In other words, 
it is recommended to create classes that can be extended by inheritance or implementing interfaces, without changing the original code of the class. 
This allows new functionality to be added without affecting existing code.

🔗 Liskov Substitution Principle (LSP): This principle states that objects of a derived class should be able to replace objects 
of the base class without affecting the correctness of the program. Essentially, this principle is about using inheritance and polymorphism 
in a way that preserves compatibility between base and derived classes, thus avoiding errors caused by overriding or changing unexpected behavior.

🧩 Interface Segregation Principle (ISP): This principle states that interfaces should not require the implementation 
of unnecessary methods for a class. In other words, interfaces should be small and specific to a functionality, instead of large and general. 
This principle helps to reduce complexity and create modular code that can be easily understood and maintained.

🔄 Dependency Inversion Principle (DIP): This principle suggests that high-level modules should not depend on lower-level modules, 
but both should depend on abstractions. Also, abstractions should not depend on details, and details should depend on abstractions. 
Applying this principle allows for a more flexible and easily modifiable code architecture.

📖 The following components of a bookstore system demonstrate the SOLID principles:

🧑‍💼 BookstoreClient: responsible for handling user input/output and interacting with other system components.
📕 Book: represented a book entity in the system and contains the basic logic of the bookstore.
🏭 BookFactory: class responsible for creating instances of the Book class.
📚 BookModel: class represents the data or state of a book entity.
The Book class follows the 
🔍 Single Responsibility Principle (SRP) by having only one responsibility, such as managing book data. The BookFactory class follows the 
🔓 Open/Closed Principle (OCP) by being open for extension but closed for modification. The BookstoreClient class adheres to the 
🧩 Interface Segregation Principle (ISP) by not depending on methods it does not use.

![Bookstore](https://user-images.githubusercontent.com/25839770/230552060-f499a14c-360a-4153-9d93-b36120193c0b.png)
