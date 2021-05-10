***

![Main](ImgForReadme/singleton.png)

***

"Singleton" is a generative design pattern that ensures that only 1 instance of a class is created.

---

### pros:

- Ensures there is only one instance of the class.
- The object is initialized when it is accessed, not when the project starts (as in a static class).
- Can be serialized and deserialized.
- Can be passed as an argument to the method.

### cons:

- Violates the principle of single responsibility (from solid) for at least class 2 tasks (control that multiple instances are not created + BL).
- Requires constant creation of Mock objects in unit-testing.
- Global variable (it is not known what is currently with the object, since this object can be changed by anyone).
 
## conclusion
I believe that singleton is an anti-pattern and should not be used in practice since there is a static class.

I took example from https://refactoring.guru/design-patterns/singleton

If I am wrong somewhere, correct me.
___