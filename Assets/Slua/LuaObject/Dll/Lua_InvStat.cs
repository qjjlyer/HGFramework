﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_InvStat : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			InvStat o;
			o=new InvStat();
			pushValue(l,o);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetName_s(IntPtr l) {
		try {
			InvStat.Identifier a1;
			checkEnum(l,1,out a1);
			var ret=InvStat.GetName(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetDescription_s(IntPtr l) {
		try {
			InvStat.Identifier a1;
			checkEnum(l,1,out a1);
			var ret=InvStat.GetDescription(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CompareArmor_s(IntPtr l) {
		try {
			InvStat a1;
			checkType(l,1,out a1);
			InvStat a2;
			checkType(l,2,out a2);
			var ret=InvStat.CompareArmor(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CompareWeapon_s(IntPtr l) {
		try {
			InvStat a1;
			checkType(l,1,out a1);
			InvStat a2;
			checkType(l,2,out a2);
			var ret=InvStat.CompareWeapon(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_id(IntPtr l) {
		try {
			InvStat self=(InvStat)checkSelf(l);
			pushEnum(l,(int)self.id);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_id(IntPtr l) {
		try {
			InvStat self=(InvStat)checkSelf(l);
			InvStat.Identifier v;
			checkEnum(l,2,out v);
			self.id=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_modifier(IntPtr l) {
		try {
			InvStat self=(InvStat)checkSelf(l);
			pushEnum(l,(int)self.modifier);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_modifier(IntPtr l) {
		try {
			InvStat self=(InvStat)checkSelf(l);
			InvStat.Modifier v;
			checkEnum(l,2,out v);
			self.modifier=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_amount(IntPtr l) {
		try {
			InvStat self=(InvStat)checkSelf(l);
			pushValue(l,self.amount);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_amount(IntPtr l) {
		try {
			InvStat self=(InvStat)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.amount=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"InvStat");
		addMember(l,GetName_s);
		addMember(l,GetDescription_s);
		addMember(l,CompareArmor_s);
		addMember(l,CompareWeapon_s);
		addMember(l,"id",get_id,set_id,true);
		addMember(l,"modifier",get_modifier,set_modifier,true);
		addMember(l,"amount",get_amount,set_amount,true);
		createTypeMetatable(l,constructor, typeof(InvStat));
	}
}