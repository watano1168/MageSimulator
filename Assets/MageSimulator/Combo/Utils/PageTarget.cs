﻿using UnityEngine;

namespace MageSimulator.Combo.Utils
{
    [CreateAssetMenu(menuName = "BrowserUI/Link Target", fileName = "New Link Target", order = 0)]
    public class PageTarget : ScriptableObject
    {
        public GameObject prefab;
    }
}