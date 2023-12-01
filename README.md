# ProgrammingTechLesson9
Task. Indexers and Properties
Part 1. Study of Indexers
Implement the RandomArray class representing an array of natural numbers.
• In the RandomArray class, there are two indexers that control the index going beyond the array bounds and also allow writing to the array only numbers that are powers of two.
• The second indexer overloads the first with the ability to process an index of a non-integer type.
• Implement properties in the class used to store the array's length (int) and the last processing error (bool). Editing the field supported by the property is prohibited in the calling code.
• The array must be filled with random values that are powers of two (numbers 2, 4, 8, 16, 32, 64, 128…).
• In the RandomArray class, create a public method, AmountOfDegrees, which returns the ratio:
product of the base 2 powers / sum of the base 2 powers.
For example, in an array of numbers {2, 256, 4, 32, 16}.
AmountOf Degrees should return the value:
= (1*8*2*5*4) / (1+8+2+5+4)
• Demonstrate the operation of all class methods. The array must be fully filled during the program's execution.
• Use the built-in .NET Random class to generate a random sequence of numbers when filling the array implemented by the RandomArray class.
• Before filling the array, prompt the user to enter the required number of array elements in the range from 10 to 100.
• Demonstrate the check for the possibility of writing and reading the RandomArray object array only for numbers that are powers of two.
Part 2. Study of Properties
Implement the NaturalNumber class with fields "base" and "power," and for them, implement properties that set the natural number and the power to which the number will be raised.
• For the "power" field property, the set accessor sets the power, and get returns the value of the base raised to the specified power.
• Create an automatically implemented property for the "base" field.
• Demonstrate the operation of the NaturalNumber class object.
