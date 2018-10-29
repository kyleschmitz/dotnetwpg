# Class 14 - October 29, 2018

## Agenda

* Continue learning about object oriented programming:
  * https://drive.google.com/open?id=1hW8H_0FF_NdHHTf3EJ-owJxau2i-m7NnYDh9OQcKdTM
* Examples from class:
  * (Not posted yet)

Next class will be further learning about **Object Oriented Programming**

## Homework

Create an application that reads and stores student information, including:

* The student's name
* The student's grade (from 0 to 100)

The application will prompt the user to enter the name and grade for 10 students. Each time a student is entered, that student will be stored in an array from the highest grade to the lowest. For example:

* If there are no students in the array, the new student will be put at element 0.
* If the student just entered has the lowest grade, they will be put after all the current students.
* If the student just entered has a higher grade than some of the existing students, then they will need to be inserted into the middle of the array, which means you will need to shuffle elements down the array.
  * Do not use linq for this question. You must do the sorting of the array manually.

Once the user has finished entering in all 10 students, the entire list of students and their grades is printed, showing that everything is in the correct order. For example:

```bash
Enter the name for student 1: Bob
Enter the grade for student 1: 43

Enter the name for student 2: Alice
Enter the grade for student 2: 90

Enter the name for student 3: Wendy
Enter the grade for student 3: 27

Enter the name for student 4: Zach
Enter the grade for student 4: 54

Enter the name for student 5: Jeff
Enter the grade for student 5: 82

Enter the name for student 6: Mandy
Enter the grade for student 6: 71

Enter the name for student 7: Fred
Enter the grade for student 7: 33

Enter the name for student 8: George
Enter the grade for student 8: 20

Enter the name for student 9: Tom
Enter the grade for student 9: 65

Enter the name for student 10: Roger
Enter the grade for student 10: 40

The students in order of grades are:
Alice - 90
Jeff - 82
Mandy - 71
Tom - 65
Zach - 54
Bob - 43
Roger - 40
Fred - 33
Wendy - 27
George - 20
```