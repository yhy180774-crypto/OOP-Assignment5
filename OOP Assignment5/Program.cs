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





























































        }
    }
}
