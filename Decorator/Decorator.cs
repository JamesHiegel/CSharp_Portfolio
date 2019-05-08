// SOURCE: https://www.linkedin.com/learning/c-sharp-design-patterns-part-1/decorator-pattern-overview
// AUTHOR: Reynald Adolphe, a technologist and .NET developer specializing in website consulting and development.
//  He focuses on user experience, user interface, back-end development, and the languages used to create web 
//  applications. He's a speaker and personal technology coach helping programmers build their brand and career 
//  to the next level and guiding new-comers to become elite software engineers. Previously, he worked for the 
//  Tribune Company in Los Angeles and Accenture in Chicago.
// FILENAME: Decorator.cs
// PURPOSE: Use the bucket sort algorithm to sort an array of integers.
// STUDENT: James Hiegel
// DATE: 07 May 2019

// STYLE MODIFICATIONS:
// Added comments to classes, methods and code blocks clarifying what the program is doing
// Used blank lines to make program easier to read

// FUNCTIONAL MODIFICATIONS:
// Condensed into single file
// Added multiple examples

// The Decorator Pattern provides a flexible alternative to sub classing for extending functionality dynamically.
// The idea of the Decorator Pattern is to wrap an existing class, add other functionality to it, then expose the 
// same interface to the outside world.Because of this our decorator exactly looks like the original class to the 
// people who are using it. It is used to extend or alter the functionality at runtime.It does this by wrapping 
// them in an object of the decorator class without modifying the original object. So it can be called a wrapper pattern.
using System;

namespace JJH
{
    class Decorator
    {
        static void Main(string[] args)
        {
            // creates compact car
            Car compactCar = new CompactCar();
            // add navigation
            compactCar = new Navigation(compactCar);
            // display description and cost
            Console.WriteLine(compactCar.GetDescription());
            Console.WriteLine($"{compactCar.GetCarPrice():C2}\n");

            // creates compact car
            Car midsizeCar = new MidsizeCar();
            // add sunroof and leather seats
            midsizeCar = new Sunroof(midsizeCar);
            midsizeCar = new LeatherSeats(midsizeCar);
            // display description and cost
            Console.WriteLine(midsizeCar.GetDescription());
            Console.WriteLine($"{midsizeCar.GetCarPrice():C2}\n");

            // creates compact car
            Car fullsizeCar = new FullSizeCar();
            // add navigation, sun roof and leather seats
            fullsizeCar = new Sunroof(fullsizeCar);
            fullsizeCar = new LeatherSeats(fullsizeCar);
            fullsizeCar = new Navigation(fullsizeCar);

            // display description and cost
            Console.WriteLine(fullsizeCar.GetDescription());
            Console.WriteLine($"{fullsizeCar.GetCarPrice():C2}\n");

            Console.ReadKey();
        }
    }

    // The abstract Car class acts as a template that concrete Car classes must follow
    public abstract class Car
    {
        public string Description { get; set; }
        public abstract string GetDescription();
        public abstract double GetCarPrice();
    }

    // The CompactCar class is a concrete implementation of the Car class
    public class CompactCar : Car
    {
        public CompactCar()
        {
            Description = "Compact Car";
        }

        public override double GetCarPrice() => 10000.00;
        public override string GetDescription() => Description;
    }

    // The MidsizeCar class is a concrete implementation of the Car class
    public class MidsizeCar : Car
    {
        public MidsizeCar()
        {
            Description = "Midsize Car";
        }

        public override double GetCarPrice() => 20000.00;
        public override string GetDescription() => Description;
    }

    // The FullSizeCar class is a concrete implementation of the Car class
    public class FullSizeCar : Car
    {
        public FullSizeCar()
        {
            Description = "FullSize Car";
        }

        public override double GetCarPrice() => 30000.00;
        public override string GetDescription() => Description;
    }

    // The CarDecorator class acts as a template that concrete Decorator classes must follow
    // Note that it also extends the Car class, this is important as it allows Car type variables
    // to also hold CarDercorator objects
    public class CarDecorator : Car
    {
        protected Car _car;
        public CarDecorator(Car car)
        {
            _car = car;
        }

        public override double GetCarPrice() => _car.GetCarPrice();

        public override string GetDescription() => _car.GetDescription();
    }

    // The Sunroof class is a concrete implentation of the CarDecorator class
    public class Sunroof : CarDecorator
    {
        public Sunroof(Car car) : base(car)
        {
            Description = "Sunroof";
        }
        // appends the Sunroof class Description onto existing Description
        public override string GetDescription() => $"{_car.GetDescription()}, {Description}";
        // adds the Sunroof class cost to existing cost
        public override double GetCarPrice() => _car.GetCarPrice() + 2500;
    }

    // The Navigation class is a concrete implentation of the CarDecorator class
    public class Navigation : CarDecorator
    {
        public Navigation(Car car)
            : base(car)
        {
            Description = "Navigation";
        }
        // appends the Sunroof class Description onto existing Description
        public override string GetDescription() => $"{_car.GetDescription()}, {Description}";
        // adds the Sunroof class cost to existing cost
        public override double GetCarPrice() => _car.GetCarPrice() + 5000;
    }

    // The LeatherSeats class is a concrete implentation of the CarDecorator class
    public class LeatherSeats : CarDecorator
    {
        public LeatherSeats(Car car) : base(car)
        {
            Description = "Leather Seats";
        }
        // appends the Sunroof class Description onto existing Description
        public override string GetDescription() =>
                                $"{_car.GetDescription()},  {Description}";
        // adds the Sunroof class cost to existing cost
        public override double GetCarPrice() => _car.GetCarPrice() + 2500;
    }
}
