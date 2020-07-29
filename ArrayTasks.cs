/* Methods */
using System;

class MainClass {
  public static void Main (string[] args) {

/* Creates class with string under name Grade for 4 indices*/
char[] Grade = new char[4];


/* This sets the grades A,B,D,F to those 4 indices */
Grade[0] = 'A';
Grade[1] = 'B';
Grade[2] = 'D';
Grade[3] = 'F';

/* This finds index 0 */

Console.WriteLine(Grade[0])

/* This displays all the indices for classSize */
foreach (var value in Grade)
{
    Console.WriteLine(value);
  }
    Console.ReadKey();

/* This inserts an element into the array (Couldn't figure it out) */
/* I get this overload error because it's saying I don't have a method for Copy */


Array.Copy(Grade[0],Grade[1],Grade[2],Grade[3], newGrade(0) - 1, 2, 3, 4);

Console.WriteLine(Grade);


/* This resizes the array */
using System;

class MainClass {
  public static void Main (string[] args) {
string[] Subject = new string[4];

Subject[0] = "English";
Subject[1] = "Maths";
Subject[2] = "History";

Array.Resize(ref Subject, 4);
Subject[3] = "Computing";

Console.WriteLine(Subject[3]);
}
}




