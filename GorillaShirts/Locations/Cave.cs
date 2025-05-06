using GorillaShirts.Interfaces;
using System;

namespace GorillaShirts.Locations
{
    internal class Cave : IStandLocation
    {
        public float Roof => -1f;
        public bool IsInZone(GTZone zone) => zone == GTZone.cave || zone == GTZone.mines;
        public Tuple<UnityEngine.Vector3, UnityEngine.Vector3> Location => Tuple.Create<UnityEngine.Vector3, UnityEngine.Vector3>(new(-55.6199f, -4.3134f, -75.8588f), new(0f, 180f, 0f));
    }
}
