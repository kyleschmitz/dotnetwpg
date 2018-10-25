# Class 12 - October 22, 2018

## Agenda

* Finishing notes from last class
  * https://drive.google.com/open?id=1WWaD-diUf0WxzH2jM3qIRMqavHi2SBR1r-Epdqlz6Gs
* Time in class to work on the question below.

## Examples from class
  * [Books example](BooksExample2/BooksExample2/Program.cs)

Next class will be further learning about **Object Oriented Programming**

## In-class Question

1) Create a class called Book that stores information for each book in a library. 
The class should contain the following information:
* Title of the book
* Author
* Number of copies of the book
* Number of lent copies.
The class will contain the following methods:
* Default constructor.
* Constructor with parameters to store each of the attributes.
* Method Loan() that increases the lent copies of the book each time a loan is made.
  * No books may be borrowed if no copies are available to lend. 
  * Returns true if the operation was successful and false otherwise. 
 * Method Return() that decrements the corresponding attribute when a book is returned.
   * No books can be returned that have not been lent out. 
   * Returns true if the operation was successful and false otherwise.
   * ToString() method to display data from books in the following format:
     * `<Title>, by <Author>. <Number lent> copies lent out from <Number of copies> total`.
 * Write a program to test the operation of the Book class. This program will have a control loop that will do the following:
  * Ask the user to enter an option
     * 1 - Quit
     * 2 - Create a book
     * 3 - Take out a book
     * 4 - Return a book
  * The program will continue to loop until the user enters 1 to quit the application.
  * The program will allow the user to enter up to 10 books.
  * If the user tries to loan a book or return a book and is unsuccessful, the program will display an error message that the book can't be loaned or returned.

 Sample output:

```bash
*****
Options:
1 - Quit
2 - Create a book
3 - Take out a book
4 - Return a book
5 - List all books
Please enter an option: 2

Enter name of book: Game of Thrones
Enter author of book: George RR Martin
Enter copies of book: 10

*****
Options:
1 - Quit
2 - Create a book
3 - Take out a book
4 - Return a book
5 - List all books
Please enter an option: 2

Enter name of book: The Hunger Games
Enter author of book: Suzanne Collins
Enter copies of book: 5

*****
Options:
1 - Quit
2 - Create a book
3 - Take out a book
4 - Return a book
5 - List all books
Please enter an option: 3

Which book do you want to take out? 0

*****
Options:
1 - Quit
2 - Create a book
3 - Take out a book
4 - Return a book
5 - List all books
Please enter an option: 5

Here are all the books in the library:

Index 0 - Game of thrones, by George RR Martin. 9 copies.
Index 1 - The Hunger Games, by Suzanne Collins. 5 copies.

*****
Options:
1 - Quit
2 - Create a book
3 - Take out a book
4 - Return a book
5 - List all books
Please enter an option: 1

Thanks for stopping by!
```

## Homework

Complete the following questions in C#:
* https://drive.google.com/open?id=1U8o_fe033WPHV2rOhDpoCRkH6eSeNwoPpT102q559Qc