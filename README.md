# DesignPatterns


===========I'm still working in more examples to upload here!=============


You can find more details about each Design Pattern here: https://en.wikipedia.org/wiki/Software_design_pattern. If you click in the specific Pattern, you can get more information! 
:)


CREATIONAL PATTERN


  1. Singleton
  
    a.	Control the access and instantiate only 1x
    b.	Reduce the memory utilization
    c.	Static structures are more flexible 
    
    
  2.	Factory Method
  
    a.	Create an instance of many derived of classes
    b.	Also known as Virtual Constructor
    c.	Create realtime object factories and let the object decides the type dynamically
    d.	The Factory Method has an interface that creates the object but the subclasses will decide which class will be instantiated
    
  3.	Abstract Method
  
    a.	Very similar than Factory Method
    b.	Create an instance of many families of classes
    c.	Classes and objects within this pattern are:
              - AbstractFactory
              - ConcrecteFactory
              - AbstractProduct
              - Product
    d.  The creation of subclasses becomes more flexible
    e.  Negative Point. Perhaps it's needed to create so many subclasses of the class Creator only to create a ConcreteProduct
    



STRUCTURAL PATTERN    
    
  1.	Proxy
  
    a.	Proxy Provide a surrogate or placeholder for another object to control access to it.
    b.	Classes and objects within this pattern are:
              - Proxy 
              - Subject 
              - RealSubject  
  
  
  ![alt text](https://upload.wikimedia.org/wikipedia/commons/thumb/7/75/Proxy_pattern_diagram.svg/439px-Proxy_pattern_diagram.svg.png)
    
    
BEHAVIORAL PATTERN    
    
  1.	Strategy
  
    a.	Define a family of algorithms, encapsulate each one, and make them interchangeable. Strategy lets the algorithm vary independently from clients that use it.
    b.	Classes and objects within this pattern are:
              - Strategy 
              - ConcreteStrategy 
              - Context  
              
   ![alt text](https://upload.wikimedia.org/wikipedia/commons/3/39/Strategy_Pattern_in_UML.png)          
