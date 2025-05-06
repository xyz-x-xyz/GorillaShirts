using GorillaShirts.Interfaces;
using System;

namespace GorillaShirts.Locations
{
    internal class GhostReactorStand : IStandLocation
    {
        public float Roof => -1f;
        public bool IsInZone(GTZone zone) => zone == GTZone.ghostReactor;
         public Tuple<UnityEngine.Vector3, UnityEngine.Vector3> Location => Tuple.Create<UnityEngine.Vector3, UnityEngine.Vector3>(new(-27.6422f, -26.9659f, -62.5161f), new(0f, 122.6505f, 0f));
    }
}
