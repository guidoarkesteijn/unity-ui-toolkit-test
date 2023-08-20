using System;
using Unity.Properties;
using UnityEngine;

namespace App.Ask
{
    [Serializable]
    public class ProfileView
    {
        [CreateProperty]
        [field: SerializeField]
        public string Name;

        [CreateProperty]
        [field: SerializeField]
        public string Description;

        [CreateProperty]
        [field: SerializeField]
        public Sprite Image;

        [CreateProperty]
        [field: SerializeField]
        public bool IsAdmin;

        [CreateProperty]
        [field: SerializeField]
        public Level Level;
    }

    [Serializable]
    public class Level
    {
        [CreateProperty]
        [field: SerializeField]
        public string Name { get; set; }

        [CreateProperty]
        [field: SerializeField]
        public int Current { get; set; }
    }
}