﻿using Aircompany.Models;
using Aircompany.Planes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aircompany
{
    public class Airport
    {
        public List<Plane> Planes;

        public Airport(IEnumerable<Plane> planes)
        {
            Planes = planes.ToList();
        }

        public List<PassengerPlane> GetPassengersPlanes()
        {
            List<PassengerPlane> passengerPlanes = new List<PassengerPlane>();
            for (int i=0; i < Planes.Count; i++)
            {
                if (Planes[i].GetType() == typeof(PassengerPlane))
                {
                    passengerPlanes.Add((PassengerPlane)Planes[i]);
                }
            }
            return passengerPlanes;
        }

        public List<MilitaryPlane> GetMilitaryPlanes()
        {
            List<MilitaryPlane> militaryPlanes = new List<MilitaryPlane>();
            for (int i = 0; i < Planes.Count; i++)
            {
                if (Planes[i].GetType() == typeof(MilitaryPlane))
                {
                    militaryPlanes.Add((MilitaryPlane)Planes[i]);
                }
            }
            return militaryPlanes;
        }

        public List<MilitaryPlane> GetTransportMilitaryPlanes()
        {
            List<MilitaryPlane> transportMilitaryPlanes = new List<MilitaryPlane>();
            List<MilitaryPlane> militaryPlanes = GetMilitaryPlanes();
            for (int i = 0; i < militaryPlanes.Count; i++)
            {
                MilitaryPlane plane = militaryPlanes[i];
                if (plane.PlaneTypeIs() == MilitaryType.TRANSPORT)
                {
                    transportMilitaryPlanes.Add(plane);
                }
            }
            return transportMilitaryPlanes;
        }

        public bool HasMilitaryTransportPlane()
        {
            foreach (MilitaryPlane militaryPlane in this.GetTransportMilitaryPlanes().ToList())
            {
                if (militaryPlane.PlaneTypeIs() == MilitaryType.TRANSPORT)
                    return true;
            }
            return false;
        }

        public PassengerPlane GetPassengerPlaneWithMaxPassengersCapacity()
        {
            PassengerPlane expectedPlaneWithMaxPassengersCapacity = this.GetPassengerPlaneWithMaxPassengersCapacity();
            List<PassengerPlane> passengerPlanes = GetPassengersPlanes();
            return passengerPlanes.Aggregate((w, x) => w.PassengersCapacityIs() > x.PassengersCapacityIs() ? w : x);
        }

        public bool IsSortByMaxLoadCapacityPlane()
        {
            List<Plane> planesSortedByMaxLoadCapacity = this.SortByMaxLoadCapacity().GetPlanes().ToList();
            for (int i = 0; i < planesSortedByMaxLoadCapacity.Count - 1; i++)
            {
                Plane currentPlane = planesSortedByMaxLoadCapacity[i];
                Plane nextPlane = planesSortedByMaxLoadCapacity[i + 1];
                if (currentPlane.MaxLoadCapacity() > nextPlane.MaxLoadCapacity())
                    return false;
            }
            return true;
        }

        public Airport SortByMaxDistance()
        {
            return new Airport(Planes.OrderBy(w => w.MaxFlightDistance()));
        }

        public Airport SortByMaxSpeed()
        {
            return new Airport(Planes.OrderBy(w => w.GetMaxSpeed()));
        }

        public Airport SortByMaxLoadCapacity()
        {
            return new Airport(Planes.OrderBy(w => w.MaxLoadCapacity()));
        }


        public IEnumerable<Plane> GetPlanes()
        {
            return Planes;
        }

        public override string ToString()
        {
            return "Airport{" +
                    "planes=" + string.Join(", ", Planes.Select(x => x.GetModel())) +
                    '}';
        }
    }
}
