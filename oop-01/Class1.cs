using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace oop_01
{
    public struct DeliveryAddress
    {
        public string City;
        public string Street;
        public int BuildingNumber;
        public DeliveryAddress(string City, string Street, int BuildingNumber)
        {
            this.City = City;
            this.Street = Street;
            this.BuildingNumber = BuildingNumber;
        }
        public string GetFullAddress()
        {
            return $"{BuildingNumber}, {Street}, {City}";
        }
    }

    public struct Shipment
    {
        string TrackingCode;
        string Description;
        double Weight;
        double DeliveryFee;
        public DeliveryAddress Destination { get; set; }

        public string trackingcode
        { 
            get => TrackingCode;

            private set
            {
                TrackingCode = !string.IsNullOrWhiteSpace(value) ? value : TrackingCode;
            }
        }

        public string description
        {
            get => Description;

            set
            {
                Description = !string.IsNullOrWhiteSpace(value) ? value : Description;
            }
        }

        public double weight
        {
            get => Weight;

            set
            {
                Weight = value > 0 ? value : Weight;
            }
        }
        public double deliveryfee
        {
            get => DeliveryFee;

            private set
            {
                DeliveryFee= value > 0 ? value : DeliveryFee;
            }
        }

        public double EstimatedCost
        {
            get => DeliveryFee+(Weight*5);
        }

        public Shipment(string TrackingCode)
        {
            trackingcode = TrackingCode;
            description = "Unknown";
            weight = 1;
            deliveryfee = 50;
            Destination = new DeliveryAddress();
        }

        public Shipment(string trackingcode, string description,double weight,double deliveryfree, DeliveryAddress destination)
        {
            this.trackingcode = trackingcode;
            this.description = description;
            this.weight = weight;
            this.deliveryfee = deliveryfree;
            this.Destination = destination;
        }

        public void UpdateDeliveryFee(double newFee)
        {
            deliveryfee = newFee;
        }
        public void PrintShipment()
        {
            Console.WriteLine(trackingcode);
            Console.WriteLine(description);
            Console.WriteLine(weight);
            Console.WriteLine(deliveryfee);
            Console.WriteLine(EstimatedCost);
        }
    }
}
