using System.Collections.Generic;
using XeApp.Game.Common;

namespace XeApp.Game.RhythmGame
{
	public class RhythmGameCheerSoundOrderer
	{
		private class EventBase
		{
			private int m_msec_prev; // 0x8
			private int m_msec_now; // 0xC
			
			//// RVA: 0xDC2B78 Offset: 0xDC2B78 VA: 0xDC2B78
			//public void ResetTime() { }

			//// RVA: 0xDC2B90 Offset: 0xDC2B90 VA: 0xDC2B90
			//public int GetTimeNow() { }

			//// RVA: 0xDC2B98 Offset: 0xDC2B98 VA: 0xDC2B98
			//public int GetTimePrev() { }

			//// RVA: 0xDC2BA0 Offset: 0xDC2BA0 VA: 0xDC2BA0
			protected bool CheckTime(int a_msec)
			{
				if (m_msec_prev < a_msec)
					return false;
				return a_msec < m_msec_now;
			}

			//// RVA: 0xDC2BC8 Offset: 0xDC2BC8 VA: 0xDC2BC8
			protected bool CheckTimeRange(int a_msec_st, int a_msec_ed)
			{
				return a_msec_st <= m_msec_now && m_msec_now < a_msec_ed;
			}

			//// RVA: 0xDC23C4 Offset: 0xDC23C4 VA: 0xDC23C4
			public void Update(int a_msec)
			{
				m_msec_prev = m_msec_now;
				m_msec_now = a_msec;
				OnUpdate();
			}

			//// RVA: 0xDC2BEC Offset: 0xDC2BEC VA: 0xDC2BEC Slot: 4
			protected virtual void OnUpdate()
			{
				return;
			}
		}

		private class EventTrigger : EventBase
		{
			public delegate void delegateOnTrigger(EventTrigger a_event);
			public MusicScoreData.InputNoteInfo m_info; // 0x10
			private bool m_on; // 0x14
			private delegateOnTrigger m_delegate; // 0x18

			//// RVA: 0xDC2078 Offset: 0xDC2078 VA: 0xDC2078
			public EventTrigger(MusicScoreData.InputNoteInfo a_info, delegateOnTrigger a_delegate)
			{
				m_delegate = a_delegate;
				m_info = a_info;
			}

			//// RVA: 0xDC31E0 Offset: 0xDC31E0 VA: 0xDC31E0 Slot: 4
			protected override void OnUpdate()
			{
				if(CheckTime(m_info.time))
				{
					if(!m_on)
					{
						if (m_delegate != null)
							m_delegate(this);
						m_on = true;
					}
					return;
				}
				m_on = false;
			}
		}

		private class EventLoop : EventBase // TypeDefIndex: 18139
		{
			public delegate void DelegateOnActive(bool a_enable, RhythmGameCheerSoundOrderer.EventLoop a_event);

			public MusicScoreData.InputNoteInfo m_st; // 0x10
			public MusicScoreData.InputNoteInfo m_ed; // 0x14
			private bool m_on; // 0x18
			private RhythmGameCheerSoundOrderer.EventLoop.DelegateOnActive m_delegateOnActive; // 0x1C

			//// RVA: 0xDC2034 Offset: 0xDC2034 VA: 0xDC2034
			public EventLoop(MusicScoreData.InputNoteInfo a_info1, MusicScoreData.InputNoteInfo a_info2, RhythmGameCheerSoundOrderer.EventLoop.DelegateOnActive a_delegate)
			{
				m_st = a_info1;
				m_ed = a_info2;
				m_delegateOnActive = a_delegate;
			}

			//// RVA: 0xDC2BF8 Offset: 0xDC2BF8 VA: 0xDC2BF8 Slot: 4
			protected override void OnUpdate()
			{
				if(!CheckTimeRange(m_st.time, m_ed.time))
				{
					if(m_on)
					{
						m_on = false;
						if(m_delegateOnActive != null)
						{
							m_delegateOnActive(false, this);
						}
						return;
					}
				}
				else if(!m_on)
				{
					m_on = true;
					if (m_delegateOnActive != null)
						m_delegateOnActive(true, this);
				}
			}
		}

		public class AccessorScoreDataInputNote
		{
			private List<MusicScoreData.InputNoteInfo> m_list; // 0x8

			public int current { get; set; } // 0xC

			//// RVA: 0xDC1CC8 Offset: 0xDC1CC8 VA: 0xDC1CC8
			//public void .ctor(List<MusicScoreData.InputNoteInfo> a_list) { }

			//// RVA: 0xDC20A0 Offset: 0xDC20A0 VA: 0xDC20A0
			//public bool IsEnd() { }

			//// RVA: 0xDC1CF0 Offset: 0xDC1CF0 VA: 0xDC1CF0
			//public MusicScoreData.InputNoteInfo GetAdd() { }

			//// RVA: 0xDC1D98 Offset: 0xDC1D98 VA: 0xDC1D98
			//public MusicScoreData.InputNoteInfo SearchLongEnd(MusicScoreData.InputNoteInfo t_input_st, int t_st) { }
		}


		private MusicScoreData m_socre_data; // 0x8
		private List<EventLoop> m_list_loop; // 0xC
		private List<EventTrigger> m_list_trigger; // 0x10
		private bool m_init; // 0x14
		private const int TRACK_VOLUME = 3;

		// RVA: 0xDC1888 Offset: 0xDC1888 VA: 0xDC1888
		public void OnDestroy()
		{
			TodoLogger.Log(0, "RhythmGameCheerSoundOrderer OnDestroy");
		}

		//// RVA: 0xDC18EC Offset: 0xDC18EC VA: 0xDC18EC
		public void Initialize(MusicScoreData a_score_data)
		{
			TodoLogger.Log(0, "RhythmGameCheerSoundOrderer Initialize");
		}

		//// RVA: 0xDC212C Offset: 0xDC212C VA: 0xDC212C
		public void Update(int a_note_msec)
		{
			if(m_init)
			{
				foreach(var t in m_list_trigger)
				{
					t.Update(a_note_msec);
				}
				foreach(var e in m_list_loop)
				{
					e.Update(a_note_msec);
				}
			}
		}

		//// RVA: 0xDC23E0 Offset: 0xDC23E0 VA: 0xDC23E0
		//private void OnTrigger(RhythmGameCheerSoundOrderer.EventTrigger a_event) { }

		//// RVA: 0xDC25D8 Offset: 0xDC25D8 VA: 0xDC25D8
		//private void OnLoop(bool a_enable, RhythmGameCheerSoundOrderer.EventLoop a_event) { }

		//// RVA: 0xDC2804 Offset: 0xDC2804 VA: 0xDC2804
		//public void Pause() { }

		//// RVA: 0xDC2864 Offset: 0xDC2864 VA: 0xDC2864
		public void Resume()
		{
			SoundManager.Instance.sePlayerCheer.Resume();
		}

		//// RVA: 0xDC188C Offset: 0xDC188C VA: 0xDC188C
		public void Stop()
		{
			SoundManager.Instance.sePlayerCheer.Stop();
		}

		//// RVA: 0xDC28C4 Offset: 0xDC28C4 VA: 0xDC28C4
		//public void Reset() { }
	}
}
