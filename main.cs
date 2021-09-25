using System;

class Program {
  public static void Main (string[] args) {




int counter = 1;

Console.WriteLine ("Enter the number of cars:") ;
double numofcars = Convert.ToDouble (Console.ReadLine()) ;
double total = numofcars;
while(counter <= numofcars){

  
//loop the car inputs until you reach seven
  Console.WriteLine ("Enter the distance covered by Car#" + counter) ;
double distance = Convert.ToDouble (Console.ReadLine()) ;

Console.WriteLine ("Enter the time taken by Car#"+ counter) ;
double time = Convert.ToDouble (Console.ReadLine()) ;

double speed = distance / time ;

total = total + speed ;

Console.WriteLine ("The speed of this car is " + speed + " miles per hour") ;
counter++;
}
 

double average = (total - numofcars) / numofcars ;

Console.WriteLine("Average = " + average) ;
  }
}


