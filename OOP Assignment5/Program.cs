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



            #region Shipment

            //public abstract partial class Shipment
            //        {
            //            private string trackingCode;
            //            private string description;
            //            private decimal weight;
            //            private decimal deliveryFee;

            //            public static int TotalShipmentsCreated;

            //            public string TrackingCode
            //            {
            //                get
            //                {
            //                    return trackingCode;
            //                }
            //            }

            //            public string Description
            //            {
            //                get
            //                {
            //                    return description;
            //                }

            //                set
            //                {
            //                    if (!string.IsNullOrWhiteSpace(value))
            //                        description = value;
            //                }
            //            }

            //            public decimal Weight
            //            {
            //                get
            //                {
            //                    return weight;
            //                }

            //                set
            //                {
            //                    if (value > 0)
            //                        weight = value;
            //                }
            //            }

            //            public decimal DeliveryFee
            //            {
            //                get
            //                {
            //                    return deliveryFee;
            //                }

            //                private set
            //                {
            //                    if (value > 0)
            //                        deliveryFee = value;
            //                }
            //            }

            //            public DeliveryAddress Destination
            //            {
            //                get;
            //                set;
            //            }

            //            public abstract decimal EstimatedCost
            //            {
            //                get;
            //            }

            //            static Shipment()
            //            {
            //                TotalShipmentsCreated = 0;

            //                Console.WriteLine(
            //                    "Shipment System Initialized");
            //            }

            //            protected Shipment(
            //                string trackingCode,
            //                string description,
            //                decimal weight,
            //                decimal deliveryFee,
            //                DeliveryAddress destination)
            //            {
            //                this.trackingCode =
            //                    string.IsNullOrWhiteSpace(trackingCode)
            //                    ? "Unknown"
            //                    : trackingCode;

            //                this.description = "Unknown";
            //                this.weight = 1;
            //                this.deliveryFee = 50;

            //                Description = description;
            //                Weight = weight;
            //                DeliveryFee = deliveryFee;

            //                Destination = destination;

            //                TotalShipmentsCreated++;
            //            }

            //            public abstract void PrintShipment();

            //            public static int GetTotalShipmentsCreated()
            //            {
            //                return TotalShipmentsCreated;
            //            }

            //            public Shipment CopyShipment()
            //            {
            //                return (Shipment)this.MemberwiseClone();
            //            }

            //            public Shipment ShallowCopy()
            //            {
            //                return (Shipment)this.MemberwiseClone();
            //            }

            //            public Shipment DeepCopy()
            //            {
            //                Shipment copy =
            //                    (Shipment)this.MemberwiseClone();

            //                if (Destination != null)
            //                {
            //                    copy.Destination =
            //                        new DeliveryAddress(
            //                            Destination.City,
            //                            Destination.Street,
            //                            Destination.BuildingNumber);
            //                }

            //                return copy;
            //            }

            //            public void UpdateWeight(decimal newWeight)
            //            {
            //                if (newWeight > 0)
            //                    Weight = newWeight;
            //            }

            //            public void UpdateWeight(
            //                decimal newWeight,
            //                decimal extraPackingWeight)
            //            {
            //                if (newWeight > 0 &&
            //                    extraPackingWeight >= 0)
            //                {
            //                    Weight =
            //                        newWeight +
            //                        extraPackingWeight;
            //                }
            //            }
            //        }

            #endregion



            #region Shipment Tracking

            //public abstract partial class Shipment
            //        {
            //            private string trackingStatus = "In Transit";

            //            public string GetTrackingStatus()
            //            {
            //                return trackingStatus;
            //            }

            //            public void UpdateTrackingStatus(
            //                string newStatus)
            //            {
            //                if (!string.IsNullOrWhiteSpace(newStatus))
            //                {
            //                    trackingStatus = newStatus;

            //                    OnTrackingStatusChanged(
            //                        newStatus);
            //                }
            //            }

            //            partial void OnTrackingStatusChanged(
            //                string newStatus);

            //            partial void OnTrackingStatusChanged(
            //                string newStatus)
            //            {
            //                Console.WriteLine(
            //                    "Tracking status changed to: "
            //                    + newStatus);
            //            }
            //        }

            #endregion












































    }
}
}
