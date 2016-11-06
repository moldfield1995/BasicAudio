// /////////////////////////////////////////////////////////////
// File: KeyboardHook.cs	Class: Kennedy.ManagedHooks.KeyboardHook
// Date: 2/25/2004			Author: Michael Kennedy
// Language: C#				Framework: .NET
//
// Copyright: Copyright (c) Michael Kennedy, 2004-2005
// /////////////////////////////////////////////////////////////
// License: See License.txt file included with application.
// Description: See compiled documentation (Managed Hooks.chm)
// /////////////////////////////////////////////////////////////

using System;

namespace MusicPlayer
{
	/// <include file='ManagedHooks.xml' path='Docs/KeyboardEvents/enum/*'/>
	public enum KeyboardEvents
	{
		/// <include file='ManagedHooks.xml' path='Docs/General/Empty/*'/>
		KeyDown			= 0x0100,
		/// <include file='ManagedHooks.xml' path='Docs/General/Empty/*'/>
		KeyUp			= 0x0101,
		/// <include file='ManagedHooks.xml' path='Docs/General/Empty/*'/>
		SystemKeyDown	= 0x0104,
		/// <include file='ManagedHooks.xml' path='Docs/General/Empty/*'/>
		SystemKeyUp		= 0x0105
	}

	/// <include file='ManagedHooks.xml' path='Docs/KeyboardHook/Class/*'/>
	public class KeyboardHook : SystemHook
	{
		/// <include file='ManagedHooks.xml' path='Docs/KeyboardHook/KeyboardEventHandler/*'/>
		public delegate void KeyboardEventHandler(KeyboardEvents kEvent, System.Windows.Forms.Keys key);

		/// <include file='ManagedHooks.xml' path='Docs/KeyboardHook/KeyboardEvent/*'/>
		public event KeyboardEventHandler KeyboardEvent;

		/// <include file='ManagedHooks.xml' path='Docs/KeyboardHook/ctor/*'/>
		public KeyboardHook() : base(HookTypes.KeyboardLL)
		{
		}

		/// <include file='ManagedHooks.xml' path='Docs/KeyboardHook/HookCallback/*'/>
		protected override void HookCallback(int code, UIntPtr wparam, IntPtr lparam)
		{
			if (KeyboardEvent == null)
			{
				return;
			}

			int vkCode = 0;
			KeyboardEvents kEvent = (KeyboardEvents)wparam.ToUInt32();

			if (kEvent != KeyboardEvents.KeyDown		&&
				kEvent != KeyboardEvents.KeyUp			&&
				kEvent != KeyboardEvents.SystemKeyDown	&&
				kEvent != KeyboardEvents.SystemKeyUp)
			{
				return;
			}

			GetKeyboardReading(wparam, lparam, ref vkCode);
			VirtualKeys vk = (VirtualKeys)vkCode;
				
			System.Windows.Forms.Keys key  = ConvertKeyCode(vk);

			if (key == System.Windows.Forms.Keys.Attn)
			{
				return;
			}

			KeyboardEvent(kEvent, key);
		}

		/// <include file='ManagedHooks.xml' path='Docs/KeyboardHook/FilterMessage/*'/>
		public void FilterMessage(KeyboardEvents eventType)
		{
			base.FilterMessage(this.HookType, (int)eventType);
		}

		#region ConvertKeyCode Method

		/// <include file='ManagedHooks.xml' path='Docs/KeyboardHook/ConvertKeyCode/*'/>
		private System.Windows.Forms.Keys ConvertKeyCode(VirtualKeys vk)
		{
			System.Windows.Forms.Keys key = System.Windows.Forms.Keys.Attn;

			switch (vk)
			{
				case VirtualKeys.ShiftLeft:
					key = System.Windows.Forms.Keys.Shift;
					break;
				case VirtualKeys.ShiftRight:
					key = System.Windows.Forms.Keys.Shift;
					break;
				case VirtualKeys.ControlLeft:
					key = System.Windows.Forms.Keys.Control;
					break;
				case VirtualKeys.ControlRight:
					key = System.Windows.Forms.Keys.Control;
					break;
				case VirtualKeys.AltLeft:
					key = System.Windows.Forms.Keys.Alt;
					break;
				case VirtualKeys.AltRight:
					key = System.Windows.Forms.Keys.Alt;
					break;
				case VirtualKeys.Back:
					key = System.Windows.Forms.Keys.Back;
					break;
				case VirtualKeys.Tab:
					key = System.Windows.Forms.Keys.Tab;
					break;
				case VirtualKeys.Clear:
					key = System.Windows.Forms.Keys.Clear;
					break;
				case VirtualKeys.Return:
					key = System.Windows.Forms.Keys.Return;
					break;
				case VirtualKeys.Menu:
					key = System.Windows.Forms.Keys.Menu;
					break;
				case VirtualKeys.Pause:
					key = System.Windows.Forms.Keys.Pause;
					break;
				case VirtualKeys.Capital:
					key = System.Windows.Forms.Keys.Capital;
					break;
				case VirtualKeys.Escape:
					key = System.Windows.Forms.Keys.Escape;
					break;
				case VirtualKeys.Space:
					key = System.Windows.Forms.Keys.Space;
					break;
				case VirtualKeys.Prior:
					key = System.Windows.Forms.Keys.Prior;
					break;
				case VirtualKeys.Next:
					key = System.Windows.Forms.Keys.Next;
					break;
				case VirtualKeys.End:
					key = System.Windows.Forms.Keys.End;
					break;
				case VirtualKeys.Home:
					key = System.Windows.Forms.Keys.Home;
					break;
				case VirtualKeys.Left:
					key = System.Windows.Forms.Keys.Left;
					break;
				case VirtualKeys.Up:
					key = System.Windows.Forms.Keys.Up;
					break;
				case VirtualKeys.Right:
					key = System.Windows.Forms.Keys.Right;
					break;
				case VirtualKeys.Down:
					key = System.Windows.Forms.Keys.Down;
					break;
				case VirtualKeys.Select:
					key = System.Windows.Forms.Keys.Select;
					break;
				case VirtualKeys.Print:
					key = System.Windows.Forms.Keys.Print;
					break;
				case VirtualKeys.Execute:
					key = System.Windows.Forms.Keys.Execute;
					break;
				case VirtualKeys.Snapshot:
					key = System.Windows.Forms.Keys.Snapshot;
					break;
				case VirtualKeys.Insert:
					key = System.Windows.Forms.Keys.Insert;
					break;
				case VirtualKeys.Delete:
					key = System.Windows.Forms.Keys.Delete;
					break;
				case VirtualKeys.Help:
					key = System.Windows.Forms.Keys.Help;
					break;
				case VirtualKeys.D0:
					key = System.Windows.Forms.Keys.D0;
					break;
				case VirtualKeys.D1:
					key = System.Windows.Forms.Keys.D1;
					break;
				case VirtualKeys.D2:
					key = System.Windows.Forms.Keys.D2;
					break;
				case VirtualKeys.D3:
					key = System.Windows.Forms.Keys.D3;
					break;
				case VirtualKeys.D4:
					key = System.Windows.Forms.Keys.D4;
					break;
				case VirtualKeys.D5:
					key = System.Windows.Forms.Keys.D5;
					break;
				case VirtualKeys.D6:
					key = System.Windows.Forms.Keys.D6;
					break;
				case VirtualKeys.D7:
					key = System.Windows.Forms.Keys.D7;
					break;
				case VirtualKeys.D8:
					key = System.Windows.Forms.Keys.D8;
					break;
				case VirtualKeys.D9:
					key = System.Windows.Forms.Keys.D9;
					break;
				case VirtualKeys.A:
					key = System.Windows.Forms.Keys.A;
					break;
				case VirtualKeys.B:
					key = System.Windows.Forms.Keys.B;
					break;
				case VirtualKeys.C:
					key = System.Windows.Forms.Keys.C;
					break;
				case VirtualKeys.D:
					key = System.Windows.Forms.Keys.D;
					break;
				case VirtualKeys.E:
					key = System.Windows.Forms.Keys.E;
					break;
				case VirtualKeys.F:
					key = System.Windows.Forms.Keys.F;
					break;
				case VirtualKeys.G:
					key = System.Windows.Forms.Keys.G;
					break;
				case VirtualKeys.H:
					key = System.Windows.Forms.Keys.H;
					break;
				case VirtualKeys.I:
					key = System.Windows.Forms.Keys.I;
					break;
				case VirtualKeys.J:
					key = System.Windows.Forms.Keys.J;
					break;
				case VirtualKeys.K:
					key = System.Windows.Forms.Keys.K;
					break;
				case VirtualKeys.L:
					key = System.Windows.Forms.Keys.L;
					break;
				case VirtualKeys.M:
					key = System.Windows.Forms.Keys.M;
					break;
				case VirtualKeys.N:
					key = System.Windows.Forms.Keys.N;
					break;
				case VirtualKeys.O:
					key = System.Windows.Forms.Keys.O;
					break;
				case VirtualKeys.P:
					key = System.Windows.Forms.Keys.P;
					break;
				case VirtualKeys.Q:
					key = System.Windows.Forms.Keys.Q;
					break;
				case VirtualKeys.R:
					key = System.Windows.Forms.Keys.R;
					break;
				case VirtualKeys.S:
					key = System.Windows.Forms.Keys.S;
					break;
				case VirtualKeys.T:
					key = System.Windows.Forms.Keys.T;
					break;
				case VirtualKeys.U:
					key = System.Windows.Forms.Keys.U;
					break;
				case VirtualKeys.V:
					key = System.Windows.Forms.Keys.V;
					break;
				case VirtualKeys.W:
					key = System.Windows.Forms.Keys.W;
					break;
				case VirtualKeys.X:
					key = System.Windows.Forms.Keys.X;
					break;
				case VirtualKeys.Y:
					key = System.Windows.Forms.Keys.Y;
					break;
				case VirtualKeys.Z:
					key = System.Windows.Forms.Keys.Z;
					break;
				case VirtualKeys.LWindows:
					key = System.Windows.Forms.Keys.LWin;
					break;
				case VirtualKeys.RWindows:
					key = System.Windows.Forms.Keys.RWin;
					break;
				case VirtualKeys.Apps:
					key = System.Windows.Forms.Keys.Apps;
					break;
				case VirtualKeys.NumPad0:
					key = System.Windows.Forms.Keys.NumPad0;
					break;
				case VirtualKeys.NumPad1:
					key = System.Windows.Forms.Keys.NumPad1;
					break;
				case VirtualKeys.NumPad2:
					key = System.Windows.Forms.Keys.NumPad2;
					break;
				case VirtualKeys.NumPad3:
					key = System.Windows.Forms.Keys.NumPad3;
					break;
				case VirtualKeys.NumPad4:
					key = System.Windows.Forms.Keys.NumPad4;
					break;
				case VirtualKeys.NumPad5:
					key = System.Windows.Forms.Keys.NumPad5;
					break;
				case VirtualKeys.NumPad6:
					key = System.Windows.Forms.Keys.NumPad6;
					break;
				case VirtualKeys.NumPad7:
					key = System.Windows.Forms.Keys.NumPad7;
					break;
				case VirtualKeys.NumPad8:
					key = System.Windows.Forms.Keys.NumPad8;
					break;
				case VirtualKeys.NumPad9:
					key = System.Windows.Forms.Keys.NumPad9;
					break;
				case VirtualKeys.Multiply:
					key = System.Windows.Forms.Keys.Multiply;
					break;
				case VirtualKeys.Add:
					key = System.Windows.Forms.Keys.Add;
					break;
				case VirtualKeys.Separator:
					key = System.Windows.Forms.Keys.Separator;
					break;
				case VirtualKeys.Subtract:
					key = System.Windows.Forms.Keys.Subtract;
					break;
				case VirtualKeys.Decimal:
					key = System.Windows.Forms.Keys.Decimal;
					break;
				case VirtualKeys.Divide:
					key = System.Windows.Forms.Keys.Divide;
					break;
				case VirtualKeys.F1:
					key = System.Windows.Forms.Keys.F1;
					break;
				case VirtualKeys.F2:
					key = System.Windows.Forms.Keys.F2;
					break;
				case VirtualKeys.F3:
					key = System.Windows.Forms.Keys.F3;
					break;
				case VirtualKeys.F4:
					key = System.Windows.Forms.Keys.F4;
					break;
				case VirtualKeys.F5:
					key = System.Windows.Forms.Keys.F5;
					break;
				case VirtualKeys.F6:
					key = System.Windows.Forms.Keys.F6;
					break;
				case VirtualKeys.F7:
					key = System.Windows.Forms.Keys.F7;
					break;
				case VirtualKeys.F8:
					key = System.Windows.Forms.Keys.F8;
					break;
				case VirtualKeys.F9:
					key = System.Windows.Forms.Keys.F9;
					break;
				case VirtualKeys.F10:
					key = System.Windows.Forms.Keys.F10;
					break;
				case VirtualKeys.F11:
					key = System.Windows.Forms.Keys.F11;
					break;
				case VirtualKeys.F12:
					key = System.Windows.Forms.Keys.F12;
					break;
				case VirtualKeys.F13:
					key = System.Windows.Forms.Keys.F13;
					break;
				case VirtualKeys.F14:
					key = System.Windows.Forms.Keys.F14;
					break;
				case VirtualKeys.F15:
					key = System.Windows.Forms.Keys.F15;
					break;
				case VirtualKeys.F16:
					key = System.Windows.Forms.Keys.F16;
					break;
				case VirtualKeys.F17:
					key = System.Windows.Forms.Keys.F17;
					break;
				case VirtualKeys.F18:
					key = System.Windows.Forms.Keys.F18;
					break;
				case VirtualKeys.F19:
					key = System.Windows.Forms.Keys.F19;
					break;
				case VirtualKeys.F20:
					key = System.Windows.Forms.Keys.F20;
					break;
				case VirtualKeys.F21:
					key = System.Windows.Forms.Keys.F21;
					break;
				case VirtualKeys.F22:
					key = System.Windows.Forms.Keys.F22;
					break;
				case VirtualKeys.F23:
					key = System.Windows.Forms.Keys.F23;
					break;
				case VirtualKeys.F24:
					key = System.Windows.Forms.Keys.F24;
					break;
				case VirtualKeys.NumLock:
					key = System.Windows.Forms.Keys.NumLock;
					break;
				case VirtualKeys.Scroll:
					key = System.Windows.Forms.Keys.Scroll;
					break;
                case VirtualKeys.MediaPlayPause:
                    key = System.Windows.Forms.Keys.MediaPlayPause;
                    break;
			}

			return key;
		}

        #endregion

        public enum VirtualKeys
        {
            Back = 0x08,
            Tab = 0x09,
            Clear = 0x0C,
            Return = 0x0D,

            ShiftLeft = 0xA0,
            ControlLeft = 0xA2,
            ShiftRight = 0xA1,
            ControlRight = 0xA3,
            AltLeft = 0xA4,
            AltRight = 0xA5,

            Menu = 0x12,
            Pause = 0x13,
            Capital = 0x14,
            Escape = 0x1B,
            Space = 0x20,
            Prior = 0x21,
            Next = 0x22,
            End = 0x23,
            Home = 0x24,
            Left = 0x25,
            Up = 0x26,
            Right = 0x27,
            Down = 0x28,
            Select = 0x29,
            Print = 0x2A,
            Execute = 0x2B,
            Snapshot = 0x2C,
            Insert = 0x2D,
            Delete = 0x2E,
            Help = 0x2F,

            D0 = 0x30,
            D1 = 0x31,
            D2 = 0x32,
            D3 = 0x33,
            D4 = 0x34,
            D5 = 0x35,
            D6 = 0x36,
            D7 = 0x37,
            D8 = 0x38,
            D9 = 0x39,

            A = 0x41,
            B = 0x42,
            C = 0x43,
            D = 0x44,
            E = 0x45,
            F = 0x46,
            G = 0x47,
            H = 0x48,
            I = 0x49,
            J = 0x4A,
            K = 0x4B,
            L = 0x4C,
            M = 0x4D,
            N = 0x4E,
            O = 0x4F,
            P = 0x50,
            Q = 0x51,
            R = 0x52,
            S = 0x53,
            T = 0x54,
            U = 0x55,
            V = 0x56,
            W = 0x57,
            X = 0x58,
            Y = 0x59,
            Z = 0x5A,

            LWindows = 0x5B,
            RWindows = 0x5C,
            Apps = 0x5D,
            NumPad0 = 0x60,
            NumPad1 = 0x61,
            NumPad2 = 0x62,
            NumPad3 = 0x63,
            NumPad4 = 0x64,
            NumPad5 = 0x65,
            NumPad6 = 0x66,
            NumPad7 = 0x67,
            NumPad8 = 0x68,
            NumPad9 = 0x69,

            Multiply = 0x6A,
            Add = 0x6B,
            Separator = 0x6C,
            Subtract = 0x6D,
            Decimal = 0x6E,
            Divide = 0x6F,
            F1 = 0x70,
            F2 = 0x71,
            F3 = 0x72,
            F4 = 0x73,
            F5 = 0x74,
            F6 = 0x75,
            F7 = 0x76,
            F8 = 0x77,
            F9 = 0x78,
            F10 = 0x79,
            F11 = 0x7A,
            F12 = 0x7B,
            F13 = 0x7C,
            F14 = 0x7D,
            F15 = 0x7E,
            F16 = 0x7F,
            F17 = 0x80,
            F18 = 0x81,
            F19 = 0x82,
            F20 = 0x83,
            F21 = 0x84,
            F22 = 0x85,
            F23 = 0x86,
            F24 = 0x87,

            NumLock = 0x90,
            Scroll = 0x91,

            //New Keys
            VomumeMute = 0xAD,
            VolumeDown = 0xAE,
            VolumeUp = 0xAF,
            MediaNext = 0xB0,
            MediaPrev = 0xB1,
            MediaStop = 0xB2,
            MediaPlayPause = 0xB3
        }
    }
}
