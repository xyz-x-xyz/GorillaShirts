using GorillaShirts.Interfaces;
using System;

namespace GorillaShirts.Locations
{
    internal class Critterpark : IStandLocation
    {
        public float Roof => -1f;
        public bool IsInZone(GTZone zone) => zone == GTZone.critters;
        public Tuple<UnityEngine.Vector3, UnityEngine.Vector3> Location => Tuple.Create<UnityEngine.Vector3, UnityEngine.Vector3>(new(93.7149f, -93.22f, 39.6249f), new(0f, 0f, 0f));
    }
}
