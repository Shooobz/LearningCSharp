using System;
namespace AreaApplication
{
   class Rectangle
   {
		  double length;
		  double width;
		  
		  public void getDimensions(){
			  double l, w;
			  Console.WriteLine("Please input the length of the rectangle");
			  l = double.Parse(Console.ReadLine());
			  length = l;
			  Console.WriteLine("Please input the width of the rectangle");
			  w = double.Parse(Console.ReadLine());
			  width = w;
			  return;
		  }
		  public double returnArea(){
			  return length*width;
			  }
		public void DisplayValues(){
			Console.WriteLine("The Length is: {0}", length);
			Console.WriteLine("The Width is: {0}", width);
			Console.WriteLine("The Area of the rectangle is: {0}", returnArea());
			return;
		}
		public Rectangle(double l, double w){
			length = l;
			width = w;
		}
		public Rectangle(){}
	}
	
	class ExecuteProgram{
		static void Main(string[] args){
<<<<<<< HEAD
			Console.WriteLine("Welcome to my program!\nWould you like to use the constructor or no?");
			char ans;

			ans = char.Parse(Console.ReadLine());
			
			if(ans != 'y'){
				//Console.WriteLine("Calls function to receive dimensions for area calculation");
				Rectangle r = new Rectangle();
				r.getDimensions();
				r.DisplayValues();
			}
			if(ans == 'y'){
				//Console.WriteLine("Receives user input and then initializes class object through constructor");
				double l, w;
				Console.WriteLine("Please enter the Length");
				l = double.Parse(Console.ReadLine());
				Console.WriteLine("Please enter the Width");
				w = double.Parse(Console.ReadLine());
				Rectangle f = new Rectangle(l, w);
				f.DisplayValues();
			}
=======
			Rectangle r = new Rectangle();
			r.getDimensions();
			r.DisplayValues();
			
			double l, w;
			Console.WriteLine("Please enter the Length");
			l = double.Parse(Console.ReadLine());
			Console.WriteLine("Please enter the Width");
			w = double.Parse(Console.ReadLine());
			Rectangle f = new Rectangle(l, w);
			f.DisplayValues();
>>>>>>> 9b5825db7501c5365a8b0083585a5447122a52c6
		}
	}
			
		
		
		
		 
}
