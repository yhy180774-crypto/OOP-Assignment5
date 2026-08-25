namespace OOP_Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {



            #region Question01

            /// 01) Object Copying
            ///
            /// a) What happens when you assign one object variable to another object variable?
            ///
            /// When one object variable is assigned to another object variable,
            /// both variables refer to the same object in memory.
            ///
            /// b) Does assigning one object to another create a new object? Explain.
            ///
            /// No, assigning one object variable to another does not create a new object.
            /// It only copies the reference to the same object.
            ///
            /// c) What is the difference between copying an object and copying its reference?
            ///
            /// Copying a reference means that two variables refer to the same object.
            /// Copying an object means creating a new object with its own data.
            ///


            #endregion



            #region Question02

            /// 02) Shallow Copy vs Deep Copy
            ///
            /// a) What is a Shallow Copy?
            ///
            /// A Shallow Copy creates a new object but copies references of
            /// reference-type members instead of creating new referenced objects.
            ///
            /// b) What is a Deep Copy?
            ///
            /// A Deep Copy creates a new object and also creates new objects
            /// for its reference-type members.
            ///
            /// c) What happens to reference-type members when a Shallow Copy is created?
            ///
            /// The reference-type members of the original and copied objects
            /// refer to the same objects.
            ///
            /// d) What happens to reference-type members when a Deep Copy is created?
            ///
            /// The reference-type members of the original and copied objects
            /// refer to different objects.
            ///
            /// e) Give one situation where Deep Copy would be safer than Shallow Copy.
            ///
            /// Deep Copy is safer when we want to modify the copied object
            /// without affecting the original object.
            ///

            #endregion



            #region Question03

            /// 03) Static Members
            ///
            /// a) What is a static field, and how is it different from an instance field?
            ///
            /// A static field belongs to the class itself and is shared by all objects.
            /// An instance field belongs to each individual object.
            ///
            /// b) What is a static method? Can a static method directly access instance members?
            ///
            /// A static method belongs to the class and can be called without creating
            /// an object.
            ///
            /// A static method cannot directly access instance members because
            /// instance members belong to a specific object.
            ///
            /// c) What is a static constructor, and when is it executed?
            ///
            /// A static constructor is used to initialize static members.
            /// It runs automatically once before the class is used for the first time.
            /// It cannot be called manually.
            ///
            /// d) What is a static class? Can you create an object from a static class?
            ///
            /// A static class contains only static members.
            /// You cannot create an object from a static class.


            #endregion



            #region Question04

            /// 04) Extension Methods
            ///
            /// a) What is an Extension Method?
            ///
            /// An Extension Method allows us to add a new method to an existing type
            /// without modifying its original class.
            ///
            /// b) What keyword must be used in the first parameter of an extension method?
            ///
            /// The keyword "this" must be used before the first parameter.
            ///
            /// c) Where must an extension method be declared?
            ///
            /// An Extension Method must be declared inside a static class.
            ///
            /// d) Can an extension method access private members of the class it extends?
            ///
            /// No. An Extension Method cannot directly access private members
            /// of the class it extends.

            #endregion



            #region DeliveryAddress

            /// DeliveryAddress is a reference type so that
            /// Shallow Copy can share the same DeliveryAddress object.

            //public class DeliveryAddress
            //        {
            //            public string City { get; set; }
            //            public string Street { get; set; }
            //            public int BuildingNumber { get; set; }

            //            public DeliveryAddress(
            //                string city,
            //                string street,
            //                int buildingNumber)
            //            {
            //                City = city;
            //                Street = street;
            //                BuildingNumber = buildingNumber;
            //            }

            //            public string GetFullAddress()
            //            {
            //                return $"{BuildingNumber} {Street}, {City}";
            //            }
            //        }

            #endregion

















































    }
}
}
