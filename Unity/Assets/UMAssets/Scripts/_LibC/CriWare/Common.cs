
using System;
using CriWare;

namespace ExternLib
{
#if !UNITY_ANDROID
    public static partial class LibCriWare
    {
        public static int CRIWARED1CDE3A7_criWareUnity_GetVersionNumber()
        {
            return Common.GetRequiredBinaryVersionNumber();
        }
    }
#endif
}