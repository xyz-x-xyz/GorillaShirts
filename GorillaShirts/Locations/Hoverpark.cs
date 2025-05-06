using GorillaShirts.Interfaces;
using System;

namespace GorillaShirts.Locations
{
    internal class Hoverpark : IStandLocation
    {
        public float Roof => -1f;
        public bool IsInZone(GTZone zone) => zone == GTZone.hoverboard;
        public Tuple<UnityEngine.Vector3, UnityEngine.Vector3> Location => Tuple.Create<UnityEngine.Vector3, UnityEngine.Vector3>(new(-90.884f, -16.675f, 32.163f), new(0f, 135f, 0f));
    }
}
