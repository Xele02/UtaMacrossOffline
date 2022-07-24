
using System;
using System.Collections.Generic;
using System.IO;
using CriWare;
using DereTore.Exchange.Audio.HCA;
using UnityEngine;
using VGMToolbox.format;

namespace ExternLib
{
    public static partial class LibCriWare
    {    
        static float bytesToFloat(byte firstByte, byte secondByte)
        {
            // convert two bytes to one short (little endian)
            short s = (short)((secondByte << 8) | firstByte);
            // convert to range from -1 to (just below) 1
            return s / 32768.0F;
        }

        class PlayerData
        {
            public CriAtomExPlayer.Config config;
            public string cueName = "";
            public int cueId = -1;
            public IntPtr acbPtr;
            public CriAtomExPlayer.Status status = CriAtomExPlayer.Status.Stop;
            public Stream acbStream;
            public HcaAudioStream audioStream;
            public uint currentPlayingId = 0;
        }
        static Dictionary<IntPtr, PlayerData> playersList = new Dictionary<IntPtr, PlayerData>();
        static List<IntPtr> playersToCheckEnd = new List<IntPtr>();
        static int playerCount = 0;

        public static void criAtomExPlayer_Stop(IntPtr player)
        {
            if(playersList.ContainsKey(player))
            {
                if(playersList[player].acbStream != null)
                {
                    UnityEngine.Debug.Log("Stop sound "+playersList[player].cueName+" "+playersList[player].cueId);
                    playersList[player].config.source.unityAudioSource.Stop();
                    playersList[player].config.source.unityAudioSource.clip = null;
                    playersList[player].audioStream = null;
                    playersList[player].acbStream = null;
                    playersList[player].status = CriAtomExPlayer.Status.Stop;
                    if(playersList[player].currentPlayingId != 0)
                        playbacksList.Remove(playersList[player].currentPlayingId);
                    playersList[player].currentPlayingId = 0;
                    playersList[player].cueName = "";
                    playersList[player].cueId = -1;
                }
                playersToCheckEnd.Remove(player);
            }
        }
        public static void criAtomExPlayer_StopWithoutReleaseTime(IntPtr player)
        {
            UnityEngine.Debug.LogError("TODO criAtomExPlayer_StopWithoutReleaseTime");
        }
        public static void CRIWARE0C3ECA83_criAtomUnityEntryPool_Clear(IntPtr pool)
        {
            UnityEngine.Debug.LogError("TODO CRIWARE0C3ECA83_criAtomUnityEntryPool_Clear");
        }
        public static void criAtomExPlayer_SetVolume(IntPtr player, float volume)
        {
            if(playersList.ContainsKey(player))
            {
                playersList[player].config.source.unityAudioSource.volume = volume;
            }
        }
        public static void CRIWARE693E0CA2_criAtomUnityEntryPool_Destroy(IntPtr pool)
        {
            UnityEngine.Debug.LogError("TODO CRIWARE693E0CA2_criAtomUnityEntryPool_Destroy");
        }
        public static IntPtr criAtomExPlayer_Create(ref CriAtomExPlayer.Config config, IntPtr work, int work_size)
        {
            IntPtr ptr = new IntPtr(++playerCount);
            PlayerData data = new PlayerData();
            data.config = config;
            playersList[ptr] = data;
            return ptr;
        }
        public static void criAtomExPlayer_Destroy(IntPtr player)
        {
            if(playersList.ContainsKey(player))
            {
                playersList.Remove(player);
            }
        }
        public static CriAtomExPlayer.Status criAtomExPlayer_GetStatus(IntPtr player)
        {
            if(playersList.ContainsKey(player))
            {
                return playersList[player].status;
            }
            return CriAtomExPlayer.Status.Error;
        }
        public static void criAtomExPlayer_SetStartTime(IntPtr player, long start_time_ms)
        {
            if(playersList.ContainsKey(player))
            {
                playersList[player].config.source.unityAudioSource.time = start_time_ms * 1.0f / 1000.0f;
            }
        }
        public static void criAtomExPlayer_UpdateAll(IntPtr player)
        {
        }
        public static void criAtomExPlayer_Set3dSourceHn(IntPtr player, IntPtr source)
        {
            if(playersList.ContainsKey(player) && srcsList.ContainsKey(source))
            {
                if(playersList[player].config.source.unityAudioSource == srcsList[source].config.source.unityAudioSource)
                    return;
            }
            UnityEngine.Debug.LogError("TODO criAtomExPlayer_Set3dSourceHn");
        }
        public static void criAtomExPlayer_Set3dListenerHn(IntPtr player, IntPtr listener)
        {
            UnityEngine.Debug.LogError("TODO criAtomExPlayer_Set3dListenerHn");
        }
        public static void criAtomExPlayer_SetPitch(IntPtr player, float pitch)
        {
            if(playersList.ContainsKey(player))
            {
                // Criware : 0 default, 100 = +1 semitone, -100 = -1 semitone.
                // Unity : 1 default, 1.05946 ^n, n being semitone.
                float numSemitone = pitch / 100;
                float unityVal = Mathf.Pow(1.05946f, numSemitone);
                playersList[player].config.source.unityAudioSource.pitch = unityVal;
            }
        }
        public static void criAtomExPlayer_SetCueName(IntPtr player, IntPtr acb_hn, string cue_name)
        {
            if(playersList.ContainsKey(player))
            {
                if(playersList[player].acbPtr != null)
                    criAtomExPlayer_Stop(player);
                
                playersList[player].acbPtr = acb_hn;
                playersList[player].cueName = cue_name;

                if(!acbFiles.ContainsKey(acb_hn))
                {
                    playersList[player].status = CriAtomExPlayer.Status.Error;
                    return;
                }
                playersList[player].status = CriAtomExPlayer.Status.Prep;

                CriAcbFile file = acbFiles[acb_hn];
                bool isStreaming = false;
                if(playersList[player].cueName != "")
                    playersList[player].acbStream = file.GetCueFileStream(playersList[player].cueName, out isStreaming);
                else
                    playersList[player].acbStream = file.GetCueFileStream(playersList[player].cueId, out isStreaming);
                if(playersList[player].acbStream == null)
                {
                    playersList[player].status = CriAtomExPlayer.Status.Error;
                    return;
                }
                
                var decodeParams = DecodeParams.CreateDefault(0x44C5F5F5, 0x0581B687);
                var audioParams = AudioParams.CreateDefault();
                audioParams.InfiniteLoop = true;
                audioParams.SimulatedLoopCount = 0;
                audioParams.OutputWaveHeader = false;

                AudioSource source = playersList[player].config.source.unityAudioSource;
                
                HcaAudioStream audioStream = new HcaAudioStream(playersList[player].acbStream, decodeParams, audioParams);
                playersList[player].audioStream = audioStream;
                int length = System.Int32.MaxValue;
                if(audioStream.HcaInfo.LoopFlag)
                    source.loop = true;
                long reallength = (audioStream.Length / (2 * audioStream.HcaInfo.ChannelCount));
                if(reallength < System.Int32.MaxValue)
                {
                    length = (int)reallength;
                }
                AudioClip clip = AudioClip.Create(playersList[player].cueName, length, (int)audioStream.HcaInfo.ChannelCount, (int)audioStream.HcaInfo.SamplingRate, isStreaming, (float[] data) => {
                    //UnityEngine.Debug.Log("Asked new data ("+data.Length+"), cur pos = "+/*curPos+*/" stream pos = "+audioStream.Position);
                    int numLeft = data.Length * 2;
                    byte[] readData = new byte[data.Length * 2];
                    int read = 1;
                    int offset = 0;
                    while(read > 0 && numLeft > 0)
                    {
                        read = audioStream.Read(readData, 0, numLeft);
                        //UnityEngine.Debug.Log("Read "+read);
                        for(int i = 0; i < read; i+=2)
                        {
                            data[offset] = bytesToFloat(readData[i], readData[i + 1]);
                            offset++;
                        }
                        numLeft -= read;
                    }
                    //curPos += data.Length;
                }, (int newPos) =>
                {
                    audioStream.Seek(newPos * 2, SeekOrigin.Begin);
                });
                source.clip = clip;
                playersList[player].status = CriAtomExPlayer.Status.Stop;
                UnityEngine.Debug.Log("Prepared sound "+playersList[player].cueName+" "+playersList[player].cueId);
            }
        }
        public static void criAtomExPlayer_LimitLoopCount(IntPtr player, int count)
        {
            UnityEngine.Debug.LogError("TODO criAtomExPlayer_LimitLoopCount");
        }
        public static IntPtr criAtomExPlayer_GetPlayerParameter(IntPtr player)
        {
            UnityEngine.Debug.LogError("TODO criAtomExPlayer_GetPlayerParameter");
            return IntPtr.Zero;
        }
        public static void criAtomExPlayerParameter_RemoveParameter(IntPtr player_parameter, ushort id)
        {
            UnityEngine.Debug.LogError("TODO criAtomExPlayerParameter_RemoveParameter");
        }
        public static uint criAtomExPlayer_Start(IntPtr player)
        {
            if(playersList.ContainsKey(player))
            {
                AudioSource source = playersList[player].config.source.unityAudioSource;
                source.Play();
                UnityEngine.Debug.Log("Play sound "+playersList[player].cueName+" "+playersList[player].cueId);
                playersList[player].status = CriAtomExPlayer.Status.Playing;
                playersList[player].currentPlayingId = (uint)++playbackCount;
                PlaybackInfo pbinfo = new PlaybackInfo();
                pbinfo.playerPtr = player;
                pbinfo.sourcePtr = playersList[player].config.source.source.nativeHandle;
                playbacksList[playersList[player].currentPlayingId] = pbinfo;
                if(!source.loop)
                    playersToCheckEnd.Add(player);
                return playersList[player].currentPlayingId;
            }
            return 0;
        }
        public static void criAtomExPlayer_SetCueId(IntPtr player, IntPtr acb_hn, int id)
        {
            if(playersList.ContainsKey(player))
            {
                playersList[player].acbPtr = acb_hn;
                playersList[player].cueId = id;
            }
        }
        public static void criAtomExPlayer_Pause(IntPtr player, bool sw)
        {
            UnityEngine.Debug.LogError("TODO criAtomExPlayer_Pause");
        }
        public static void criAtomExPlayer_Resume(IntPtr player, CriAtomEx.ResumeMode mode)
        {
            UnityEngine.Debug.LogError("TODO criAtomExPlayer_Resume");
        }
        public static bool criAtomExPlayer_IsPaused(IntPtr player)
        {
            UnityEngine.Debug.LogError("TODO criAtomExPlayer_IsPaused");
            return false;
        }
        public static void CheckSoundStatus()
        {
            List<IntPtr> playersStopped = new List<IntPtr>();
            for(int i = playersToCheckEnd.Count - 1; i >= 0; i--)
            {
                AudioSource source = playersList[playersToCheckEnd[i]].config.source.unityAudioSource;
                if(!source.isPlaying)
                {
                    playersStopped.Add(playersToCheckEnd[i]);
                }
            }
            for(int i = 0; i < playersStopped.Count; i++)
            {
                criAtomExPlayer_Stop(playersStopped[i]);
            }
        }
    }
}