﻿using UnityStudio.Serialization;
using UnityStudio.Serialization.Naming;

namespace OpenMLTD.MillionDance.Entities.Mltd {
    // True name: Imas.CharacterImasMotionAsset
    [MonoBehaviour(NamingConventionType = typeof(CamelCaseNamingConvention), ThrowOnUnmatched = false, PopulationStrategy = PopulationStrategy.OptIn)]
    public sealed class CharacterImasMotionAsset {

        [MonoBehaviourProperty]
        public string Kind { get; set; }

        [MonoBehaviourProperty(Name = "attribs")]
        public object[] Atrributes { get; set; }

        [MonoBehaviourProperty(Name = "time_length")]
        public float Duration { get; set; }

        [MonoBehaviourProperty]
        public string Date { get; set; }

        [MonoBehaviourProperty]
        public Curve[] Curves { get; set; }

    }
}
