using System;
using Box2DSharp.Inspection;
using UnityEngine;

namespace Box2DSharp
{
    public class TestSettings : MonoBehaviour
    {
        [HideInInspector]
        public DebugDrawer DebugDrawer;

        [HideInInspector]
        public BoxDrawer WorldDrawer;

        [Toggle]
        public bool Sleep = true;

        [Toggle]
        public bool WarmStarting = true;

        [Toggle]
        public bool TimeOfImpact = true;

        [Toggle]
        public bool SubStepping = false;

        [Toggle]
        public bool Shape = true;

        [Toggle]
        public bool Joint = true;

        [Toggle]
        public bool AABB = false;

        [Toggle]
        public bool Pair = false;

        [Toggle]
        public bool CenterOfMass = false;

        [Toggle]
        public bool ContactPoint = false;

        [Toggle]
        public bool ContactNormals = false;

        [Toggle]
        public bool ContactImpulse = false;

        [Toggle]
        public bool FrictionImpulse = false;

        [Toggle]
        public bool Statistics = false;

        [Toggle]
        public bool Profile = false;

        public int Frequency = 60;

        public int PositionIteration = 3;

        public int VelocityIteration = 8;
    }

    [AttributeUsage(AttributeTargets.Field)]
    public class ToggleAttribute : Attribute
    { }
}