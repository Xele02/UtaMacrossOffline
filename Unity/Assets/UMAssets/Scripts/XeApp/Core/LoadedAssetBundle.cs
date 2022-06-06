using UnityEngine;

namespace XeApp.Core
{
    public class LoadedAssetBundle
    {
        public AssetBundle m_AssetBundle; // 0x8
        public int m_ReferencedCount; // 0xC

        // RVA: 0x1D6AEB4 Offset: 0x1D6AEB4 VA: 0x1D6AEB4
        public LoadedAssetBundle(AssetBundle assetBundle)
        {
            m_AssetBundle = assetBundle;
            m_ReferencedCount = 1;
        }
    }
}