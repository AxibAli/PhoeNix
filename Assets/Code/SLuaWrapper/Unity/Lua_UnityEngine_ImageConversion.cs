using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_ImageConversion : LuaObject {
	[SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int EncodeToPNG_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			UnityEngine.Texture2D a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.ImageConversion.EncodeToPNG(a1);
			pushValue(l,true);
			pushValue(l,ret);
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
	[SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int EncodeToJPG_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.Texture2D a1;
				checkType(l,1,out a1);
				var ret=UnityEngine.ImageConversion.EncodeToJPG(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				UnityEngine.Texture2D a1;
				checkType(l,1,out a1);
				System.Int32 a2;
				checkType(l,2,out a2);
				var ret=UnityEngine.ImageConversion.EncodeToJPG(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function EncodeToJPG to call");
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
	[SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int EncodeToEXR_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.Texture2D a1;
				checkType(l,1,out a1);
				var ret=UnityEngine.ImageConversion.EncodeToEXR(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				UnityEngine.Texture2D a1;
				checkType(l,1,out a1);
				UnityEngine.Texture2D.EXRFlags a2;
				checkEnum(l,2,out a2);
				var ret=UnityEngine.ImageConversion.EncodeToEXR(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function EncodeToEXR to call");
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
	[SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int LoadImage_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#endif
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.Texture2D a1;
				checkType(l,1,out a1);
				System.Byte[] a2;
				checkArray(l,2,out a2);
				var ret=UnityEngine.ImageConversion.LoadImage(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==3){
				UnityEngine.Texture2D a1;
				checkType(l,1,out a1);
				System.Byte[] a2;
				checkArray(l,2,out a2);
				System.Boolean a3;
				checkType(l,3,out a3);
				var ret=UnityEngine.ImageConversion.LoadImage(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function LoadImage to call");
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
		getTypeTable(l,"UnityEngine.ImageConversion");
		addMember(l,EncodeToPNG_s);
		addMember(l,EncodeToJPG_s);
		addMember(l,EncodeToEXR_s);
		addMember(l,LoadImage_s);
		createTypeMetatable(l,null, typeof(UnityEngine.ImageConversion));
	}
}
