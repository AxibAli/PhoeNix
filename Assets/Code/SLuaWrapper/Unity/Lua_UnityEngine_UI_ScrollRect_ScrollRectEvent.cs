﻿using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_UI_ScrollRect_ScrollRectEvent : LuaObject {
	[SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			UnityEngine.UI.ScrollRect.ScrollRectEvent o;
			o=new UnityEngine.UI.ScrollRect.ScrollRectEvent();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
		#if DEBUG
		finally {
			UnityEngine.Profiling.Profiler.EndSample();
		}
		#endif
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		LuaUnityEvent_UnityEngine_Vector2.reg(l);
		getTypeTable(l,"UnityEngine.UI.ScrollRect.ScrollRectEvent");
		createTypeMetatable(l,constructor, typeof(UnityEngine.UI.ScrollRect.ScrollRectEvent),typeof(LuaUnityEvent_UnityEngine_Vector2));
	}
}
