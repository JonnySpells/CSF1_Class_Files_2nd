//Adding // to the start of a line creates a single-line comment that is ignored by the compiler

/*
 * You can also create multi-line comments like this.
 * They are also ignored by the compiler.
*/

//To save changes, we can hit the floppy icons at the top of the Visual Studio window,
//or we can hit Ctrl + S (save this file) or Ctrl + Shift + S (saves all files)


/*****Important Things to Know About C#*******
            * 
            * 
            * C# curly braces are used to define the scope of something. They say, all of the content inside of them relates to this one thing. Here all the code inside of the curly 
            * braces relates to the Main(). 
            * 
            * A semicolon is used like a period to show the end of a line of code
            * 
            * C# largely ignores whitespace, except when inside of string (i.e. "Hello, world!" above)
            * 
            * C# is case sensitive meaning that example and Example could refer to different things. 
            * 
            * C# is type-safe which means when something is created you define what type of thing it is and it stays that type forever.
            */

//*******Variables******//

//A variable is just a container to hold information. When a container is created, you must define what type of data it will hold (type-safety).
//The data stored in a container can be changed. 
//Variables are traditionally defined using the camelCase naming convention. 
//Variable names can ....
//   - only begin with alphabetic characters or underscores
//   - cannot contain spaces
//   - must contain at least 1 alpha or numeric character
//   - cannot be a reserved keyword (i.e. class, static, void...all shown in dark blue)
//   - be unique within their scope {}

//When making a variable you go through three steps: Declaration, Initialization, and Assignment
//1. Declaration: this is when the container is created. It is given a name and a data type. 
//2. Initialization: this is when the container is given a value for the first time. 
//3. Assignment: giving the container a new value, after the first time