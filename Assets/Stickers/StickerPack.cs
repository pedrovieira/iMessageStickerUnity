﻿using System.Collections.Generic;
using UnityEngine;

namespace Agens.Stickers
{
    [CreateAssetMenu(fileName = "StickerPack", menuName = "Sticker Pack")]
    public class StickerPack : ScriptableObject
    {
        [Tooltip("The Display Name of the Sticker Pack")]
        [SerializeField]
        private string title;

        public string Title
        {
            get
            {
                if (string.IsNullOrEmpty(title))
                {
                    Debug.LogWarning("Title is missing from Sticker Pack", this);
                    return name;
                }
                return title;
            }
            set { title = value; }
        }

        [Tooltip("Bundle identifier postfix. This will come after the parents app bundle identifier.")]
        [SerializeField]
        private string bundleId;

        public string BundleId
        {
            get
            {
                if (string.IsNullOrEmpty(bundleId))
                {
                    Debug.LogWarning("Bundle Id is missing from Sticker Pack", this);
                    return "stickers";
                }
                return bundleId;
            }

            set { bundleId = value; }
        }

        public SigningSettings Signing;


        public StickerPackIcon Icons;
        [SerializeField]
        private StickerSize size = StickerSize.Medium;

        public StickerSize Size { get { return size; } set { size = value; }}
        public List<Sticker> Stickers;
    }
}