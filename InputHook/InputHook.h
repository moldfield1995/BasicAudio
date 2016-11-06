#pragma once

namespace CallBackResponces
{
	namespace SetCallBack
	{
		const int SUCCESS = 1;
		const int ALREADY_SET = -2;
		const int NOT_IMPLEMENTED = -3;
		const int ARGUMENT_ERROR = -4;
	}
	namespace FilterMessage
	{
		const int SUCCESS = 1;
		const int FAILED = -2;
		const int NOT_IMPLEMENTED = -3;
	}
}
namespace LowLevelHook {

	typedef void (CALLBACK *HookProc)(int code, WPARAM w, LPARAM l);
	static LRESULT CALLBACK InternalKeyboardHookCallback(int code, WPARAM wparam, LPARAM lparam);
	bool Initialize(int threadID);
	void DeInititlize(UINT ID);
	void Despose(UINT ID);
	//int SetCallback(HookProc userProc, UINT ID);

	HINSTANCE appInstance;
	HOOKPROC keyboardCallback;
	HHOOK keybordHook;
}