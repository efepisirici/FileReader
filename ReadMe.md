

Take-home assignment:

*********************

It's a relatively simple task focusing mainly on checking your code tidiness, OOP and usage of basic design patterns.

Use strictly C# and .Net Core 3.1+.

You can use public NuGet packages (if needed).

Follow SOLID principles.



---



Implement console application "DataProcessor".

Application fetches data from some "source" and performs some "processing" for fetched data.



We need to support "file" source of data in our first version:

1) Two required parameters: "--filePath" and "--dataType".

2) Support three dataType-s: "binary", "text" and "textReverse".

2-1) In case of binary the application should output first five bytes of data in base64 format.

2-2) In case of text the application should output first five letters of presumably textual data in UTF8 format.

2-3) In case of textReverse the application should output first five letters of presumably textual data in reverse order in UTF8 format.



Do not implement, but make sure that we'll be able to add new "sources" of data to our application easily and perform procesing of same three dataType-s over it. 

For example: 

- "database" which would get some piece of data by sql-query from file (passed as parameter). 

- "eventLog" which would get latest message description from some categoty of Windows EvenLog.



Additional dataTypes may be required in future versions as well.



---

