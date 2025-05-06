﻿using UnityEngine;

namespace GorillaShirts.Behaviours.Appearance
{
    public class GorillaColour : MonoBehaviour
    {
        public ShirtVisual ShirtVisual;

        private Material material;

        public void Start()
        {
            material = GetComponent<Renderer>().material;
            ApplyColour();
        }

        public void OnEnable()
        {
            ShirtVisual.OnColourChanged += ApplyColour;
        }

        public void OnDisable()
        {
            ShirtVisual.OnColourChanged -= ApplyColour;
        }

        public void ApplyColour()
        {
            Color colour = ShirtVisual.Colour;
            material.SetColor("_BaseColor", LightenColour(colour));
        }

        private Color LightenColour(Color original, float amount = 0.8f)
        {
            float oneMinus = 1 - amount;
            float r = original.r * (amount + oneMinus);
            float g = original.g * (amount + oneMinus);
            float b = original.b * (amount + oneMinus);
            return new Color(r, g, b, original.a);
        }
    }
}
