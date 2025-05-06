using GorillaShirts.Interfaces;
using System;

namespace GorillaShirts.Locations
{
    internal class Arena : IStandLocation
    {
        public float Roof => -1f;
        public bool IsInZone(GTZone zone) => zone == GTZone.arena;
        public Tuple<UnityEngine.Vector3, UnityEngine.Vector3> Location => Tuple.Create<UnityEngine.Vector3, UnityEngine.Vector3>(new(100.7505f, 3.945f, 196.4247f), new(0f, 315f, 0f));
    }
}
