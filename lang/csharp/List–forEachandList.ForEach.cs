using System;
using System.Collections.Generic;
 
class Program {
    static void Main(string[] args) {
        //create list
        List<int> nums = new List<int>();
        //add elements to the list
        nums.Add(56);
        nums.Add(82);
        nums.Add(94);
 
        //list - foreach element
        nums.ForEach(delegate(int num) {
            Console.WriteLine(num);
        });
    }
}

//===============================================================


using System;
using System.Collections.Generic;
 
class Program {
    static void Main(string[] args) {
        //create list
        List<int> nums = new List<int>();
        nums.Add(52);
        nums.Add(68);
        nums.Add(73);
         
        //for each element in the list
        foreach (int num in nums) {
            Console.WriteLine(num);
        }
    }
}

//====================================================================



using System;
using System.Collections.Generic;
 
class Program {
    static void Main(string[] args) {
        //create list
        List<Car> cars = new List<Car>();
        cars.Add(new Car("Toyota", 1250000));
        cars.Add(new Car("Tata", 1300000));
        cars.Add(new Car("Honda", 1150000));
         
        //for each element in the list
        cars.ForEach(delegate(Car car) {
            Console.WriteLine(car.name + " - "+car.price);
        });
    }
}
 
class Car{
    public string name;
    public int price;
    public Car(string name, int price){
        this.name = name;
        this.price = price;
    }
}


