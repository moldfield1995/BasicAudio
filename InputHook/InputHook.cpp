#include "pch.h"
#include "InputHook.h"
#pragma comment( lib, "user32.lib" )
#include <windows.h>

namespace LowLevelHook {
	bool Initialize(int threadID)
	{

		if (appInstance == NULL)
		{
			return false;
		}
		
		if (keyboardCallback == NULL)
		{
			return false;
		}
		
		keybordHook = SetWindowsHookEx(WH_KEYBOARD_LL, (HOOKPROC)InternalKeyboardHookCallback, appInstance, threadID);
		return keybordHook != NULL;
	}

	void DeInititlize(UINT ID)
	{
	}

	void Despose(UINT ID)
	{
	}
}