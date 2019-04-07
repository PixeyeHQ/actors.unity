#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <cstring>
#include <string.h>
#include <stdio.h>
#include <cmath>
#include <limits>
#include <assert.h>
#include <stdint.h>

#include "il2cpp-class-internals.h"
#include "codegen/il2cpp-codegen.h"
#include "il2cpp-object-internals.h"

struct VirtActionInvoker0
{
	typedef void (*Action)(void*, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		((Action)invokeData.methodPtr)(obj, invokeData.method);
	}
};
template <typename R>
struct VirtFuncInvoker0
{
	typedef R (*Func)(void*, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		return ((Func)invokeData.methodPtr)(obj, invokeData.method);
	}
};
template <typename T1>
struct VirtActionInvoker1
{
	typedef void (*Action)(void*, T1, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		((Action)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};
template <typename T1, typename T2>
struct VirtActionInvoker2
{
	typedef void (*Action)(void*, T1, T2, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1, T2 p2)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		((Action)invokeData.methodPtr)(obj, p1, p2, invokeData.method);
	}
};
template <typename R, typename T1>
struct VirtFuncInvoker1
{
	typedef R (*Func)(void*, T1, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		return ((Func)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};
template <typename T1>
struct GenericVirtActionInvoker1
{
	typedef void (*Action)(void*, T1, const RuntimeMethod*);

	static inline void Invoke (const RuntimeMethod* method, RuntimeObject* obj, T1 p1)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_virtual_invoke_data(method, obj, &invokeData);
		((Action)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};
template <typename T1, typename T2>
struct GenericVirtActionInvoker2
{
	typedef void (*Action)(void*, T1, T2, const RuntimeMethod*);

	static inline void Invoke (const RuntimeMethod* method, RuntimeObject* obj, T1 p1, T2 p2)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_virtual_invoke_data(method, obj, &invokeData);
		((Action)invokeData.methodPtr)(obj, p1, p2, invokeData.method);
	}
};
struct InterfaceActionInvoker0
{
	typedef void (*Action)(void*, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		((Action)invokeData.methodPtr)(obj, invokeData.method);
	}
};
template <typename T1>
struct InterfaceActionInvoker1
{
	typedef void (*Action)(void*, T1, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj, T1 p1)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		((Action)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};
template <typename T1, typename T2>
struct InterfaceActionInvoker2
{
	typedef void (*Action)(void*, T1, T2, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj, T1 p1, T2 p2)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		((Action)invokeData.methodPtr)(obj, p1, p2, invokeData.method);
	}
};
template <typename R, typename T1>
struct InterfaceFuncInvoker1
{
	typedef R (*Func)(void*, T1, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj, T1 p1)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		return ((Func)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};
template <typename T1>
struct GenericInterfaceActionInvoker1
{
	typedef void (*Action)(void*, T1, const RuntimeMethod*);

	static inline void Invoke (const RuntimeMethod* method, RuntimeObject* obj, T1 p1)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_interface_invoke_data(method, obj, &invokeData);
		((Action)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};
template <typename T1, typename T2>
struct GenericInterfaceActionInvoker2
{
	typedef void (*Action)(void*, T1, T2, const RuntimeMethod*);

	static inline void Invoke (const RuntimeMethod* method, RuntimeObject* obj, T1 p1, T2 p2)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_interface_invoke_data(method, obj, &invokeData);
		((Action)invokeData.methodPtr)(obj, p1, p2, invokeData.method);
	}
};

// FastComparable
struct FastComparable_t85AACE6CEBE4B0D7FB16B2F3D09523B7BC4AA1A8;
// Pixeye.Actor
struct Actor_tC8E7F2C0FBC6266BB4ACD3F1D091F6AD50A15FEB;
// Pixeye.BaseStateMachineBehavior
struct BaseStateMachineBehavior_tC9B4D174C0E646DA37525E41FBB6A50C5DEEB064;
// Pixeye.BaseStateMachineBehavior[]
struct BaseStateMachineBehaviorU5BU5D_t69541BC5FF78E6A8031B638080B9821EA0364911;
// Pixeye.Box
struct Box_t4C71F0C8AB96AC3964C40FE71BB42D9C121F81B1;
// Pixeye.ComponentRelease
struct ComponentRelease_t98EE3880490384D15031D69FB587E1C7D806E527;
// Pixeye.DataGame
struct DataGame_t550789F8B729098267FD582F1E101BD29282BC52;
// Pixeye.DelayTagEvent[]
struct DelayTagEventU5BU5D_t7C4AB33A74B954415C9AF4B6E5D707E0CF3AA45F;
// Pixeye.EntityComposer
struct EntityComposer_tB9CD47E805A3232A943F6CF48BB084FB1646CCD3;
// Pixeye.Factory
struct Factory_tFA5041074647498CBAB64B0C4ABD43314393E7A5;
// Pixeye.Factory[]
struct FactoryU5BU5D_t7A8216D8ED74B1438E91899BC6A21F74EC123FD7;
// Pixeye.GroupBase[]
struct GroupBaseU5BU5D_t66B1A0989D748227CC6DD39CC2748EC2551F0E85;
// Pixeye.Group`1<Pixeye.ComponentRelease>
struct Group_1_t1D98F394A0A975D5B266B5A8EAC2FAA7F3FD5D54;
// Pixeye.HandleActorsAdd
struct HandleActorsAdd_t8D5278068F1EACBBF9799D835738C552E5550F9E;
// Pixeye.HandleActorsRemove
struct HandleActorsRemove_t775454EB912F9A2B222D5E61FA84C2DE6EFFAEA7;
// Pixeye.HandleEntities
struct HandleEntities_t05CCD5B390B45C447D8FA2542EF8CC2761054D76;
// Pixeye.HandleFastPool`1<Pixeye.Timer>
struct HandleFastPool_1_t717E0511090B921AEE3A8436B7B8AB6BC1A0C0AD;
// Pixeye.HandleFastPool`1<System.Object>
struct HandleFastPool_1_t1772C28F3B42E90C5AF36647F51804CD2E530834;
// Pixeye.HandlePool
struct HandlePool_tBB031F11A1DE7E61E63146EF835372909BFCB665;
// Pixeye.HandleScene
struct HandleScene_t9A17EE1370450F47652A7C56B9D20A02A7BA1728;
// Pixeye.HandleTimer
struct HandleTimer_tE0613FB7A046C7560F75BD4908092FA5A2260483;
// Pixeye.HandleUpdate
struct HandleUpdate_t2060842DBF2069E5F3DD3C37B41CA77A1C7B78A3;
// Pixeye.Pluggable
struct Pluggable_tED235F8443B870F25950EF2914429DA66218ADAD;
// Pixeye.Pluggable[]
struct PluggableU5BU5D_tE5D1CFECA820F0A38DD943A37A40C020341EC93F;
// Pixeye.PoolNode
struct PoolNode_tD412A3A536E55E03495943E9F456B844ACBB2568;
// Pixeye.PoolNode[]
struct PoolNodeU5BU5D_t9F244CBEF1668899FB99F01BBECF817296022C0B;
// Pixeye.ReferenceType
struct ReferenceType_tE3BEFC1D0A5EEAE313214E10535DAC824FCB1F2B;
// Pixeye.RequireAttribute
struct RequireAttribute_t8B9E56505437ECBB6B0EA3FB2B9E1AA773C1CDEB;
// Pixeye.RequireTagsAttribute
struct RequireTagsAttribute_tB80A8FCE5689F37232DC22E17DF16EEE0F912257;
// Pixeye.SceneReference
struct SceneReference_t824B30D7B4AAF610B0DBC1F5F54227F2BB69685F;
// Pixeye.SceneReference[]
struct SceneReferenceU5BU5D_t0F8A5E1535280DDA1F3A78E9476F9CCC7D3CC8E1;
// Pixeye.Script
struct Script_t5CAA335E115304E821B2CF96BCD8065B4397105D;
// Pixeye.SettingsEngine
struct SettingsEngine_tE5FAA3E51808E5B9F5820B753618576EE8035659;
// Pixeye.Starter
struct Starter_t094EE6CE9643F0578E88871EBE1EE57879A38146;
// Pixeye.StarterKernel
struct StarterKernel_t383AD5285BEE52A4F9F6FDBE97E01A368CE25E27;
// Pixeye.StarterKernel/<OnApplicationFocus>d__4
struct U3COnApplicationFocusU3Ed__4_t6A81BE9FFD6951A1410B57DFD8BCA01E3D3AF5E4;
// Pixeye.Storage
struct Storage_tDB77CB8CF4EE44D043E9BE9027A74B153B16E826;
// Pixeye.Storage[]
struct StorageU5BU5D_t5E23208F3504ECF09E6B9F1720C26F5D42D99FAA;
// Pixeye.TagBase
struct TagBase_t00D73CADD76FB47F7A9EA7BC5DA9E359CCAAAC3F;
// Pixeye.TagFieldAttribute
struct TagFieldAttribute_t44EBFA87585224B6D3C31F706F3CE1072F7C075D;
// Pixeye.TagFilterAttribute
struct TagFilterAttribute_tCFBF8A9A03FC22D02803646A5564ECD11A6E2276;
// Pixeye.Template
struct Template_t5107412B0F7996BE75F25FE9E22600F4E7DA2CA9;
// Pixeye.Time
struct Time_t70920BA2C4C4BE707DAE9822ED553B006FFC0100;
// Pixeye.Timer
struct Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA;
// Pixeye.Timer[]
struct TimerU5BU5D_t9C867AC9076A4EF5F8DDE2EE43AF21B9788C19C6;
// Pixeye.Toolbox
struct Toolbox_t081ED4540597D09C31B0F9430D6D377D6BA90E3A;
// Pixeye.taskEntity
struct taskEntity_tB8531E29867EAB8E27F86237A4F1F4BD04F72D38;
// Pixeye.taskEntityTick
struct taskEntityTick_t17493A17530F9C48141A795A60FC76E0C9E35567;
// Singleton`1<Pixeye.Toolbox>
struct Singleton_1_t70D00C90A652BD47B1B663FC32A13A31E56C12C6;
// Singleton`1<System.Object>
struct Singleton_1_t0274AA8C219E3C1AC9EFC99CA9F0E94174205873;
// System.Action
struct Action_t591D2A86165F896B4B800BB5C25CE18672A55579;
// System.Action`2<System.Array,System.Int32[]>
struct Action_2_tEEECFD1333A361FF85D469EF54DA8E989E6B0D11;
// System.Action`2<System.Object,System.Object>
struct Action_2_t0DB6FD6F515527EAB552B690A291778C6F00D48C;
// System.ArrayTraverse
struct ArrayTraverse_tD07A6D4E93DB7941CE934AFF9F006788173C70A6;
// System.AsyncCallback
struct AsyncCallback_t3F3DA3BEDAEE81DD1D24125DF8EB30E85EE14DA4;
// System.Attribute
struct Attribute_tF048C13FB3C8CFCC53F82290E4A3F621089F9A74;
// System.Boolean[]
struct BooleanU5BU5D_t192C7579715690E25BD5EFED47F3E0FC9DCB2040;
// System.Char[]
struct CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2;
// System.Collections.Generic.Dictionary`2/Entry<Pixeye.TimerKey,System.Collections.Generic.List`1<Pixeye.Timer>>[]
struct EntryU5BU5D_tB0C8C9FE1F0A5B27427A59AFC22D4465A72BED18;
// System.Collections.Generic.Dictionary`2/Entry<System.Int32,Pixeye.Storage>[]
struct EntryU5BU5D_t79BA14538CFA03A748F0E12FD93034FD4DB4ACF2;
// System.Collections.Generic.Dictionary`2/Entry<System.Int32,System.Collections.Generic.List`1<Pixeye.GroupBase>>[]
struct EntryU5BU5D_t85917DE4472FB88832B93AB341F781081FCF46F5;
// System.Collections.Generic.Dictionary`2/Entry<System.Int32,System.Int32>[]
struct EntryU5BU5D_t771BA166F0450465AFAF66A1700FD2795A4BA1F9;
// System.Collections.Generic.Dictionary`2/Entry<System.Int32,System.Object>[]
struct EntryU5BU5D_t929130352D902B0F51DF5EAB0EB281F860E35FFC;
// System.Collections.Generic.Dictionary`2/Entry<System.Object,System.Object>[]
struct EntryU5BU5D_t9EC04215E0A25794290249C0F6D7EA694596D2BE;
// System.Collections.Generic.Dictionary`2/KeyCollection<Pixeye.TimerKey,System.Collections.Generic.List`1<Pixeye.Timer>>
struct KeyCollection_t6784E9AE7A67E960F75FC3EAA50CC9E88D32842F;
// System.Collections.Generic.Dictionary`2/KeyCollection<System.Int32,Pixeye.Storage>
struct KeyCollection_t0FE37259FA097872B8DB53CFF4EEF0DF428EF876;
// System.Collections.Generic.Dictionary`2/KeyCollection<System.Int32,System.Collections.Generic.List`1<Pixeye.GroupBase>>
struct KeyCollection_tF77AE029A67C3A4099451E549B1C92D88BD5B4CF;
// System.Collections.Generic.Dictionary`2/KeyCollection<System.Int32,System.Int32>
struct KeyCollection_t07175316A062A97612A0750CD9FCFAC6C13270FA;
// System.Collections.Generic.Dictionary`2/KeyCollection<System.Int32,System.Object>
struct KeyCollection_t247C6587A2D9DAFEFD3863012E19D5BE565D738E;
// System.Collections.Generic.Dictionary`2/KeyCollection<System.Object,System.Object>
struct KeyCollection_t0394DE2BA7C2C82605C6E9DEBB21A8C5C792E97C;
// System.Collections.Generic.Dictionary`2/ValueCollection<Pixeye.TimerKey,System.Collections.Generic.List`1<Pixeye.Timer>>
struct ValueCollection_tA9AA0526554037B0A9C58CC2785792BE193E4BDD;
// System.Collections.Generic.Dictionary`2/ValueCollection<System.Int32,Pixeye.Storage>
struct ValueCollection_t8789D0E84F8039FC237ED53BA2308B18E14F6AD1;
// System.Collections.Generic.Dictionary`2/ValueCollection<System.Int32,System.Collections.Generic.List`1<Pixeye.GroupBase>>
struct ValueCollection_t56068C373977277F9A424F44602F32EF1E0BB391;
// System.Collections.Generic.Dictionary`2/ValueCollection<System.Int32,System.Int32>
struct ValueCollection_t4B03F142CD9DE8CA06D9CD246A5403B64C000D60;
// System.Collections.Generic.Dictionary`2/ValueCollection<System.Int32,System.Object>
struct ValueCollection_t4F0931CDBEC78250B6593DE976E46E2179187225;
// System.Collections.Generic.Dictionary`2/ValueCollection<System.Object,System.Object>
struct ValueCollection_t0816666499CBD11E58E1E7C79A4EFC2AA47E08A2;
// System.Collections.Generic.Dictionary`2<Pixeye.TimerKey,System.Collections.Generic.List`1<Pixeye.Timer>>
struct Dictionary_2_t7A0A951F2ACBA1FC50C942EC15413C2011C7B386;
// System.Collections.Generic.Dictionary`2<Pixeye.TimerKey,System.Object>
struct Dictionary_2_t58EC087653A1C1C8F4A74F620C874867E3DE1D55;
// System.Collections.Generic.Dictionary`2<System.Int32,Pixeye.PoolContainer>
struct Dictionary_2_t97C22D3FBC16542FD0BDAC3BCD0893A7438EADD2;
// System.Collections.Generic.Dictionary`2<System.Int32,Pixeye.Storage>
struct Dictionary_2_t683E72069DD61C3D055254F6694A3E646C6B3622;
// System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.Dictionary`2<System.Int32,System.Object>>[]
struct Dictionary_2U5BU5D_t2188B0D28935CE1B5651F98445AD751B1536083F;
// System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<Pixeye.GroupBase>>
struct Dictionary_2_t62CC83140A4EC1BB76940D6FD31E9B3B8417C850;
// System.Collections.Generic.Dictionary`2<System.Int32,System.Int32>
struct Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8;
// System.Collections.Generic.Dictionary`2<System.Int32,System.Int32>[]
struct Dictionary_2U5BU5D_t5A34008586C648E4C1725CB098BCFE11124FEC7E;
// System.Collections.Generic.Dictionary`2<System.Int32,System.Object>
struct Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884;
// System.Collections.Generic.Dictionary`2<System.Int32,System.String>
struct Dictionary_2_t4EFE6A1D6502662B911688316C6920444A18CF0C;
// System.Collections.Generic.Dictionary`2<System.Int32,UnityEngine.Object>
struct Dictionary_2_t770A301203EE62B42C6E15A74786AB854F8FA099;
// System.Collections.Generic.Dictionary`2<System.Object,System.Object>
struct Dictionary_2_t32F25F093828AA9F93CB11C2A2B4648FD62A09BA;
// System.Collections.Generic.Dictionary`2<System.String,UnityEngine.SceneManagement.Scene>
struct Dictionary_2_t5D8E8B17B1B56C65697ED1A012BDB0A1BCB2451D;
// System.Collections.Generic.Dictionary`2<System.String,UnityEngine.Transform>
struct Dictionary_2_tD568D405F77A6A44CE20C029082A82BEAC5EB63F;
// System.Collections.Generic.EqualityComparer`1<System.Object>
struct EqualityComparer_1_t54972BA287ED38B066E4BE7A3B21F49803B62EBA;
// System.Collections.Generic.IDictionary`2<System.Object,System.Object>
struct IDictionary_2_tA5D15A38270F72A7D9BDD9FCE7DB02B7BEA5385E;
// System.Collections.Generic.IEqualityComparer`1<Pixeye.TimerKey>
struct IEqualityComparer_1_tFEDE11D1B73E42D46BE64016FFF67183CF9D911E;
// System.Collections.Generic.IEqualityComparer`1<System.Int32>
struct IEqualityComparer_1_t7B82AA0F8B96BAAA21E36DDF7A1FE4348BDDBE95;
// System.Collections.Generic.IEqualityComparer`1<System.Object>
struct IEqualityComparer_1_tAE7A8756D8CF0882DD348DC328FB36FEE0FB7DD0;
// System.Collections.Generic.List`1<Pixeye.Factory>
struct List_1_tA0E2AEAC02B0C34F5538C6D39174C6E22259F642;
// System.Collections.Generic.List`1<Pixeye.GroupBase>
struct List_1_t9BDBBBDE445BCD28B6812218DD02E011357B5666;
// System.Collections.Generic.List`1<Pixeye.ITick>
struct List_1_t9B111270E51DA37359653F88A712407C7B2EF77F;
// System.Collections.Generic.List`1<Pixeye.ITickFixed>
struct List_1_tD2240B3110A6D99A40AAF7A287B8C034196C29F1;
// System.Collections.Generic.List`1<Pixeye.ITickLate>
struct List_1_tA453498B219D45B426E6E2843D5AC42720A711B9;
// System.Collections.Generic.List`1<Pixeye.Pluggable>
struct List_1_t2D6D202FD59CE78CF20816E533E40E75EF42A211;
// System.Collections.Generic.List`1<Pixeye.PoolNode>
struct List_1_tF89465888600A0DC538773BB071C4AFEA6A8597E;
// System.Collections.Generic.List`1<Pixeye.SceneReference>
struct List_1_t80222E8941042447035EF5455CC2D2B763E5AE8B;
// System.Collections.Generic.List`1<Pixeye.Storage>
struct List_1_t186D2009EAF545D4056FD040D409D10C57CE8F97;
// System.Collections.Generic.List`1<Pixeye.Timer>
struct List_1_t613852693859B0156A22267D914D17B30CFDE8F1;
// System.Collections.Generic.List`1<System.Int32>
struct List_1_tE1526161A558A17A39A8B69D8EEF3801393B6226;
// System.Collections.Generic.List`1<System.Object>
struct List_1_t05CC3C859AB5E6024394EF9A42E3E696628CA02D;
// System.Collections.Generic.List`1<System.String>
struct List_1_tE8032E48C661C350FF9550E9063D595C0AB25CD3;
// System.Collections.Generic.List`1<UnityEngine.GameObject>
struct List_1_tBA8D772D87B6502B2A4D0EFE166C846285F50650;
// System.Collections.Generic.Stack`1<Pixeye.Timer>
struct Stack_1_tF8554B34D8B53E76DA4B08AC899FF3811A8893A3;
// System.Collections.Generic.Stack`1<System.Int32>
struct Stack_1_t7C4BBD98911741434BD5D2CC3B1FA31A32EF1819;
// System.Collections.IDictionary
struct IDictionary_t1BD5C1546718A374EA8122FBD6C6EE45331E8CE7;
// System.Collections.IEnumerator
struct IEnumerator_t8789118187258CC88B77AFAC6315B5AF87D3E18A;
// System.Delegate
struct Delegate_t;
// System.DelegateData
struct DelegateData_t1BF9F691B56DAE5F8C28C5E084FDE94F15F27BBE;
// System.Delegate[]
struct DelegateU5BU5D_tDFCDEE2A6322F96C0FE49AF47E9ADB8C4B294E86;
// System.Diagnostics.StackTrace[]
struct StackTraceU5BU5D_t855F09649EA34DEE7C1B6F088E0538E3CCC3F196;
// System.Func`2<System.Object,System.Boolean>
struct Func_2_t7EE965B791A606D187CCB69569A433D4CBB36879;
// System.Func`2<System.Reflection.FieldInfo,System.Boolean>
struct Func_2_t8B737A62DCD6BCDB37818A2DFF357973A9317E8D;
// System.HelperObject/<>c
struct U3CU3Ec_t9C407A5DC0C368A41DAACA036192AD2BC6222A05;
// System.HelperObject/<>c__DisplayClass3_0
struct U3CU3Ec__DisplayClass3_0_t715805D6146E8762D34660C36DE710592B4E74BC;
// System.HelperObject/<>c__DisplayClass3_1
struct U3CU3Ec__DisplayClass3_1_tB9452E9E43273A7EB9B4BEC3B43307E5DC1E2DAD;
// System.IAsyncResult
struct IAsyncResult_t8E194308510B375B42432981AE5E7488C458D598;
// System.Int32[0...,0...]
struct Int32U5BU2CU5D_tEFF95F718DC8948EF23BEE318FF51EDD788749D2;
// System.Int32[]
struct Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83;
// System.IntPtr[]
struct IntPtrU5BU5D_t4DC01DCB9A6DF6C9792A6513595D7A11E637DCDD;
// System.NotSupportedException
struct NotSupportedException_tE75B318D6590A02A5D9B29FD97409B1750FA0010;
// System.Object[]
struct ObjectU5BU5D_t3C9242B5C88A48B2A5BD9FDA6CD0024E792AF08A;
// System.ReferenceEqualityComparer
struct ReferenceEqualityComparer_t3840A1467D76B18290FA822E6B548D1079D91DA4;
// System.Reflection.Binder
struct Binder_t4D5CB06963501D32847C057B57157D6DC49CA759;
// System.Reflection.FieldInfo
struct FieldInfo_t;
// System.Reflection.MemberFilter
struct MemberFilter_t25C1BD92C42BE94426E300787C13C452CB89B381;
// System.Reflection.MethodBase
struct MethodBase_t;
// System.Reflection.MethodInfo
struct MethodInfo_t;
// System.Runtime.CompilerServices.IsReadOnlyAttribute
struct IsReadOnlyAttribute_t625BDB176EA5986CAF2228A6F2A61A9FABD2C344;
// System.Runtime.Serialization.SafeSerializationManager
struct SafeSerializationManager_t4A754D86B0F784B18CBC36C073BA564BED109770;
// System.String
struct String_t;
// System.Type
struct Type_t;
// System.Type[]
struct TypeU5BU5D_t7FE623A666B49176DE123306221193E888A12F5F;
// System.Void
struct Void_t22962CB4C05B1D89B55A6E1139F0E87A90987017;
// Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute
struct Il2CppSetOptionAttribute_t013DDBAF8F39A8C8395B51A2549BCF893259611E;
// UnityEngine.Animator
struct Animator_tF1A88E66B3B731DDA75A066DBAE9C55837660F5A;
// UnityEngine.GameObject
struct GameObject_tBD1244AD56B4E59AAD76E5E7C9282EC5CE434F0F;
// UnityEngine.MonoBehaviour
struct MonoBehaviour_t4A60845CF505405AF8BE8C61CC07F75CADEF6429;
// UnityEngine.MonoBehaviour[]
struct MonoBehaviourU5BU5D_tEC81C7491112CB97F70976A67ABB8C33168F5F0A;
// UnityEngine.Object
struct Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0;
// UnityEngine.PropertyAttribute
struct PropertyAttribute_t25BFFC093C9C96E3CCF4EAB36F5DC6F937B1FA54;
// UnityEngine.ScriptableObject
struct ScriptableObject_tAB015486CEAB714DA0D5C1BA389B84FB90427734;
// UnityEngine.Transform
struct Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA;
// UnityEngine.Transform[]
struct TransformU5BU5D_t3EB9781D1A1DE2674F0632C956A66AA423343139;
// UnityEngine.WaitForSeconds
struct WaitForSeconds_t3E9E78D3BB53F03F96C7F28BA9B9086CD1A5F4E8;

extern RuntimeClass* Action_2_tEEECFD1333A361FF85D469EF54DA8E989E6B0D11_il2cpp_TypeInfo_var;
extern RuntimeClass* Action_t591D2A86165F896B4B800BB5C25CE18672A55579_il2cpp_TypeInfo_var;
extern RuntimeClass* ArrayTraverse_tD07A6D4E93DB7941CE934AFF9F006788173C70A6_il2cpp_TypeInfo_var;
extern RuntimeClass* Box_t4C71F0C8AB96AC3964C40FE71BB42D9C121F81B1_il2cpp_TypeInfo_var;
extern RuntimeClass* Dictionary_2U5BU5D_t5A34008586C648E4C1725CB098BCFE11124FEC7E_il2cpp_TypeInfo_var;
extern RuntimeClass* Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884_il2cpp_TypeInfo_var;
extern RuntimeClass* Dictionary_2_t32F25F093828AA9F93CB11C2A2B4648FD62A09BA_il2cpp_TypeInfo_var;
extern RuntimeClass* Dictionary_2_t62CC83140A4EC1BB76940D6FD31E9B3B8417C850_il2cpp_TypeInfo_var;
extern RuntimeClass* Dictionary_2_t683E72069DD61C3D055254F6694A3E646C6B3622_il2cpp_TypeInfo_var;
extern RuntimeClass* Dictionary_2_t7A0A951F2ACBA1FC50C942EC15413C2011C7B386_il2cpp_TypeInfo_var;
extern RuntimeClass* Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8_il2cpp_TypeInfo_var;
extern RuntimeClass* EntityComposer_tB9CD47E805A3232A943F6CF48BB084FB1646CCD3_il2cpp_TypeInfo_var;
extern RuntimeClass* FastComparable_t85AACE6CEBE4B0D7FB16B2F3D09523B7BC4AA1A8_il2cpp_TypeInfo_var;
extern RuntimeClass* Func_2_t8B737A62DCD6BCDB37818A2DFF357973A9317E8D_il2cpp_TypeInfo_var;
extern RuntimeClass* HandleActorsAdd_t8D5278068F1EACBBF9799D835738C552E5550F9E_il2cpp_TypeInfo_var;
extern RuntimeClass* HandleEntities_t05CCD5B390B45C447D8FA2542EF8CC2761054D76_il2cpp_TypeInfo_var;
extern RuntimeClass* HandleFastPool_1_t717E0511090B921AEE3A8436B7B8AB6BC1A0C0AD_il2cpp_TypeInfo_var;
extern RuntimeClass* HandlePool_tBB031F11A1DE7E61E63146EF835372909BFCB665_il2cpp_TypeInfo_var;
extern RuntimeClass* HandleScene_t9A17EE1370450F47652A7C56B9D20A02A7BA1728_il2cpp_TypeInfo_var;
extern RuntimeClass* HandleTimer_tE0613FB7A046C7560F75BD4908092FA5A2260483_il2cpp_TypeInfo_var;
extern RuntimeClass* HandleUpdate_t2060842DBF2069E5F3DD3C37B41CA77A1C7B78A3_il2cpp_TypeInfo_var;
extern RuntimeClass* HelperObject_t8DDDC60CA23963941C841A0FF58CFFB85581665B_il2cpp_TypeInfo_var;
extern RuntimeClass* IAwake_tCD9519461B0D3E6CE3EAA3CF6194878CFEB0B1E5_il2cpp_TypeInfo_var;
extern RuntimeClass* IDictionary_2_tA5D15A38270F72A7D9BDD9FCE7DB02B7BEA5385E_il2cpp_TypeInfo_var;
extern RuntimeClass* IDisposable_t7218B22548186B208D65EA5B7870503810A2D15A_il2cpp_TypeInfo_var;
extern RuntimeClass* IKernel_t0B60B083684ECDD45B0EBB8E5E0555AE88F66112_il2cpp_TypeInfo_var;
extern RuntimeClass* IRequireStarter_t5149D99640196B893E1AE71434420EB865532225_il2cpp_TypeInfo_var;
extern RuntimeClass* Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83_il2cpp_TypeInfo_var;
extern RuntimeClass* Int32_t585191389E07734F19F3156FF88FB3EF4800D102_il2cpp_TypeInfo_var;
extern RuntimeClass* List_1_t186D2009EAF545D4056FD040D409D10C57CE8F97_il2cpp_TypeInfo_var;
extern RuntimeClass* List_1_t2D6D202FD59CE78CF20816E533E40E75EF42A211_il2cpp_TypeInfo_var;
extern RuntimeClass* List_1_t613852693859B0156A22267D914D17B30CFDE8F1_il2cpp_TypeInfo_var;
extern RuntimeClass* List_1_tE1526161A558A17A39A8B69D8EEF3801393B6226_il2cpp_TypeInfo_var;
extern RuntimeClass* List_1_tF89465888600A0DC538773BB071C4AFEA6A8597E_il2cpp_TypeInfo_var;
extern RuntimeClass* Math_tFB388E53C7FDC6FCCF9A19ABF5A4E521FBD52E19_il2cpp_TypeInfo_var;
extern RuntimeClass* NotSupportedException_tE75B318D6590A02A5D9B29FD97409B1750FA0010_il2cpp_TypeInfo_var;
extern RuntimeClass* Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0_il2cpp_TypeInfo_var;
extern RuntimeClass* RefEntity_t5823EB2D89C01C8E8581EC0091D5168FBA887089_il2cpp_TypeInfo_var;
extern RuntimeClass* ReferenceEqualityComparer_t3840A1467D76B18290FA822E6B548D1079D91DA4_il2cpp_TypeInfo_var;
extern RuntimeClass* RuntimeArray_il2cpp_TypeInfo_var;
extern RuntimeClass* ScriptableObject_tAB015486CEAB714DA0D5C1BA389B84FB90427734_il2cpp_TypeInfo_var;
extern RuntimeClass* Single_tDDDA9169C4E4E308AC6D7A824F9B28DC82204AE1_il2cpp_TypeInfo_var;
extern RuntimeClass* Singleton_1_t70D00C90A652BD47B1B663FC32A13A31E56C12C6_il2cpp_TypeInfo_var;
extern RuntimeClass* Starter_t094EE6CE9643F0578E88871EBE1EE57879A38146_il2cpp_TypeInfo_var;
extern RuntimeClass* StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_il2cpp_TypeInfo_var;
extern RuntimeClass* Storage_tDB77CB8CF4EE44D043E9BE9027A74B153B16E826_il2cpp_TypeInfo_var;
extern RuntimeClass* Time_t70920BA2C4C4BE707DAE9822ED553B006FFC0100_il2cpp_TypeInfo_var;
extern RuntimeClass* TimerKey_tCE6BF602B11E3FE849B05CC16BE0650A88755F89_il2cpp_TypeInfo_var;
extern RuntimeClass* Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA_il2cpp_TypeInfo_var;
extern RuntimeClass* Type_t_il2cpp_TypeInfo_var;
extern RuntimeClass* U3COnApplicationFocusU3Ed__4_t6A81BE9FFD6951A1410B57DFD8BCA01E3D3AF5E4_il2cpp_TypeInfo_var;
extern RuntimeClass* U3CU3Ec__DisplayClass3_0_t715805D6146E8762D34660C36DE710592B4E74BC_il2cpp_TypeInfo_var;
extern RuntimeClass* U3CU3Ec__DisplayClass3_1_tB9452E9E43273A7EB9B4BEC3B43307E5DC1E2DAD_il2cpp_TypeInfo_var;
extern RuntimeClass* U3CU3Ec_t9C407A5DC0C368A41DAACA036192AD2BC6222A05_il2cpp_TypeInfo_var;
extern RuntimeClass* WaitForSeconds_t3E9E78D3BB53F03F96C7F28BA9B9086CD1A5F4E8_il2cpp_TypeInfo_var;
extern RuntimeClass* ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622_il2cpp_TypeInfo_var;
extern String_t* _stringLiteral4CD94480549BFAE91F93062486ECEFE3D7A2D695;
extern String_t* _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709;
extern const RuntimeMethod* Action_2_Invoke_m30C71E5D73DDF8E22567F0AAEFE21B198D0F4CBF_RuntimeMethod_var;
extern const RuntimeMethod* Action_2__ctor_m5FC808B1B109AA3FBDD5E37AB68C9507E6E8E43E_RuntimeMethod_var;
extern const RuntimeMethod* Animator_GetBehaviours_TisBaseStateMachineBehavior_tC9B4D174C0E646DA37525E41FBB6A50C5DEEB064_mF2F48ED60DFB77DBA14E860AE010F54C9E4ED04B_RuntimeMethod_var;
extern const RuntimeMethod* ArrayTraverse_Step_m3D9533390B66FB0C727576BAEF5CE78EF602193E_RuntimeMethod_var;
extern const RuntimeMethod* ArrayTraverse__ctor_mCC997558A200828072F6A2B76B02E089FABE3741_RuntimeMethod_var;
extern const RuntimeMethod* Array_Resize_TisDelayTagEvent_tBFFD54C27E705D5B8CD1C5C49B4094A01A88BE02_mCF48F79088FD98AB2563B66CE05477C477974B0B_RuntimeMethod_var;
extern const RuntimeMethod* Array_Resize_TisDictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8_mD91BBCB688FE146E5FB901FDD5924A4C3D1D6742_RuntimeMethod_var;
extern const RuntimeMethod* Dictionary_2_Add_m6E61563D097FC91BEA0AB0B64E9B47ED7FA8667F_RuntimeMethod_var;
extern const RuntimeMethod* Dictionary_2_Add_mDC25A2F4744B497C39F127D97327CC7B56E68903_RuntimeMethod_var;
extern const RuntimeMethod* Dictionary_2_Add_mF7AEA0EFA07EEBC1A4B283A26A7CB720EE7A4C20_RuntimeMethod_var;
extern const RuntimeMethod* Dictionary_2_Clear_m7DE8E346650F09FFAB65ABCACFEBCB2FAB2F4499_RuntimeMethod_var;
extern const RuntimeMethod* Dictionary_2_Clear_m8B31D0EA3C1FCE4C6977A76829773DA0D127E217_RuntimeMethod_var;
extern const RuntimeMethod* Dictionary_2_ContainsKey_mBC44DAB119CBE7A4B7820ABF12AD024A4654471E_RuntimeMethod_var;
extern const RuntimeMethod* Dictionary_2_GetEnumerator_mE47C13FC1B2BACBEE6F795B0E40E6406CAC55D4B_RuntimeMethod_var;
extern const RuntimeMethod* Dictionary_2_Remove_m2204D6D532702FD13AB2A9AD8DB538E4E8FB1913_RuntimeMethod_var;
extern const RuntimeMethod* Dictionary_2_Remove_m8E04EF60FB32880A72708207DB1CC4555C2E476F_RuntimeMethod_var;
extern const RuntimeMethod* Dictionary_2_TryGetValue_m2AB95C81F55348A9264B1599CF302BF7D6A45673_RuntimeMethod_var;
extern const RuntimeMethod* Dictionary_2_TryGetValue_m867F6DA953678D0333A55270B7C6EF38EFC293FF_RuntimeMethod_var;
extern const RuntimeMethod* Dictionary_2_TryGetValue_mF63B7CEA87637EBDF9463BD38E61F29EB10148CC_RuntimeMethod_var;
extern const RuntimeMethod* Dictionary_2__ctor_m0F87B73520F2A9CD71CF45B4561785C1C42E8111_RuntimeMethod_var;
extern const RuntimeMethod* Dictionary_2__ctor_m114B4A2B0BD22B817FE14C1E5CB04881D63D4E20_RuntimeMethod_var;
extern const RuntimeMethod* Dictionary_2__ctor_m76CDCB0C7BECE95DBA94C7C98467F297E4451EE7_RuntimeMethod_var;
extern const RuntimeMethod* Dictionary_2__ctor_m7D745ADE56151C2895459668F4A4242985E526D8_RuntimeMethod_var;
extern const RuntimeMethod* Dictionary_2__ctor_m7E3DE5565E761320FA45B5A083B35E77466B2756_RuntimeMethod_var;
extern const RuntimeMethod* Dictionary_2__ctor_mAFB74AF308004F87E52B2F21945C4FFDADF4F8AF_RuntimeMethod_var;
extern const RuntimeMethod* Dictionary_2__ctor_mC01623E89CE60035A0AB4C3C0E973C959CC76790_RuntimeMethod_var;
extern const RuntimeMethod* Dictionary_2_get_Item_mFB950EA5BD4A89CD6EAA8D0CB45D665091FAA7E1_RuntimeMethod_var;
extern const RuntimeMethod* Dictionary_2_set_Item_mEA07C9AE7BBAF67BC9CFE20D200A464725D1F7FA_RuntimeMethod_var;
extern const RuntimeMethod* EntityComposer_Add_TisComponentRelease_t98EE3880490384D15031D69FB587E1C7D806E527_mB10072EEB7AAEBA7111D3FB268286C9C36E9FB47_RuntimeMethod_var;
extern const RuntimeMethod* Enumerator_Dispose_m00358105CD68F800EAC90C662F3CBA417D034906_RuntimeMethod_var;
extern const RuntimeMethod* Enumerator_Dispose_m772E7049D8DA96AF5021EA09C3E6322CD4BFBDFC_RuntimeMethod_var;
extern const RuntimeMethod* Enumerator_MoveNext_m637AE52AC4BDE5BEB1D89BE4B75E49B4C328EFC9_RuntimeMethod_var;
extern const RuntimeMethod* Enumerator_MoveNext_mB2585B01CD7E37F43666F5349D25C40BBF37DAB0_RuntimeMethod_var;
extern const RuntimeMethod* Enumerator_get_Current_m67516B76FD35F63A1B24DAA385BF84A83964D641_RuntimeMethod_var;
extern const RuntimeMethod* Enumerator_get_Current_m73F8FC135A20BDFEA0846D8FC876863ED85FEA49_RuntimeMethod_var;
extern const RuntimeMethod* EqualityComparer_1__ctor_m2B03FB26184C766345AA072BEA38AA745AE2E192_RuntimeMethod_var;
extern const RuntimeMethod* Func_2_Invoke_m549AD78F263B5521A0C932CDA2164CE8184B56C7_RuntimeMethod_var;
extern const RuntimeMethod* Func_2__ctor_mBCB78A823F554E0E602DAC379826320F3ECEDC4B_RuntimeMethod_var;
extern const RuntimeMethod* HandleFastPool_1_Populate_m9622D906DBE9E77119FF081D14CE50800C6B1CED_RuntimeMethod_var;
extern const RuntimeMethod* HelperArray_ForEach_mB81FAB6CA742EF47C4B9E2CA805351AFBB1FB0DB_RuntimeMethod_var;
extern const RuntimeMethod* HelperObject_CopyFields_m82911ECAA99D264F8D7B8D63C02CDC35A1B9657C_RuntimeMethod_var;
extern const RuntimeMethod* HelperObject_Copy_m0F1F1434D990C76B797BE3B746388D080E578EE1_RuntimeMethod_var;
extern const RuntimeMethod* HelperObject_InternalCopy_mACD63D41622BF6303A74BBCE7C77024CD5B97FB2_RuntimeMethod_var;
extern const RuntimeMethod* HelperObject_IsPrimitive_m7A8654F1FD5D1F421189A6552C8D3BCD2530ADBB_RuntimeMethod_var;
extern const RuntimeMethod* HelperObject_RecursiveCopyBaseTypePrivateFields_mC004C89E73C1BECCD83A4BC7F31ECBCA5E3DA6A7_RuntimeMethod_var;
extern const RuntimeMethod* HelperObject__cctor_m390F3EFE34A1F5910F6A723E8DA582D699698A29_RuntimeMethod_var;
extern const RuntimeMethod* Il2CppSetOptionAttribute__ctor_m959B784CDB72D7B9D9676F464C669AA059EA9B8F_RuntimeMethod_var;
extern const RuntimeMethod* Il2CppSetOptionAttribute_get_Option_m0E0DE57E57329D9C0870E600F1A3396AFB3C73AE_RuntimeMethod_var;
extern const RuntimeMethod* Il2CppSetOptionAttribute_get_Value_m2BA8D8B60E0237F26014F46196F6A433469FFF2A_RuntimeMethod_var;
extern const RuntimeMethod* Il2CppSetOptionAttribute_set_Option_mA79F66679078953ABC5CFF576AFE2714A0C840CA_RuntimeMethod_var;
extern const RuntimeMethod* Il2CppSetOptionAttribute_set_Value_m67B377532E1429A6AE787932FFA2250D04D09022_RuntimeMethod_var;
extern const RuntimeMethod* KeyValuePair_2_get_Key_m89B687D373FBE3D230647CA0C536235E12AD829C_RuntimeMethod_var;
extern const RuntimeMethod* KeyValuePair_2_get_Value_mAD6801F3BC9BA1E99D4E0F72B2B420182D0494FC_RuntimeMethod_var;
extern const RuntimeMethod* List_1_Add_m427CEBFF4473B9FF133591A38714298FA2E4BF08_RuntimeMethod_var;
extern const RuntimeMethod* List_1_Add_m50C0D1F69B2EF31137658E2F052EBBAC7BF82771_RuntimeMethod_var;
extern const RuntimeMethod* List_1_GetEnumerator_mCBF188196E6175158D5266EEDFD0D4BB30B62115_RuntimeMethod_var;
extern const RuntimeMethod* List_1_Remove_m2E8533F833815BDD8176A0DBC27DFCCDC8120FE6_RuntimeMethod_var;
extern const RuntimeMethod* List_1__ctor_m1DAC5E4BC778402B5E74A5A4FDCE1AA28E4B3EF5_RuntimeMethod_var;
extern const RuntimeMethod* List_1__ctor_m596CC86831CDC5B16D847683293A5E3090036F2E_RuntimeMethod_var;
extern const RuntimeMethod* List_1__ctor_m9461BD0419807AF9A434D9C6D4E95A1C4ABF4759_RuntimeMethod_var;
extern const RuntimeMethod* List_1__ctor_mA7F9F92F641CEECFD9D8CFDC667568A05FFD27B4_RuntimeMethod_var;
extern const RuntimeMethod* List_1__ctor_mABE1F8A5C40A227414A1BAC86E92EDD953F86FC1_RuntimeMethod_var;
extern const RuntimeMethod* List_1_get_Count_m52793036D5E41E8E25DCC5C033380C44D7596903_RuntimeMethod_var;
extern const RuntimeMethod* List_1_get_Count_m83C0B08646B75C0726AF3C49B42E96B63CF78BB0_RuntimeMethod_var;
extern const RuntimeMethod* List_1_get_Count_mEDAF9F74023B67E06EFC1B56D8F15202AE3E8C36_RuntimeMethod_var;
extern const RuntimeMethod* List_1_get_Item_m54372A031C118324F5CEE30AB6FFEDA511E874E8_RuntimeMethod_var;
extern const RuntimeMethod* List_1_get_Item_mAAD89C5F555E6D9E8A6BD72F7E8C6105B9E04789_RuntimeMethod_var;
extern const RuntimeMethod* List_1_get_Item_mB62D52423AF52EEC13B4317DD86E6A5BBDF41BD2_RuntimeMethod_var;
extern const RuntimeMethod* Object_FindObjectsOfType_TisMonoBehaviour_t4A60845CF505405AF8BE8C61CC07F75CADEF6429_m3BD4005DB6D046DA65FFD7427BE77F266D98D13B_RuntimeMethod_var;
extern const RuntimeMethod* Object_Instantiate_TisScriptableObject_tAB015486CEAB714DA0D5C1BA389B84FB90427734_mB3A1278CCDC8FA17C7D86C6C1C0D7676B0D18A03_RuntimeMethod_var;
extern const RuntimeMethod* ReferenceEqualityComparer_Equals_m96C511CA5702FDF53C7253762841E6D189A71366_RuntimeMethod_var;
extern const RuntimeMethod* ReferenceEqualityComparer_GetHashCode_mD5B3DD433D815E66BA01586CE51D7CDF0CF2129E_RuntimeMethod_var;
extern const RuntimeMethod* RequireAttribute__ctor_m6FDFFB2F320943CACF50F50B03844E53FAD6F549_RuntimeMethod_var;
extern const RuntimeMethod* RequireTagsAttribute__ctor_m111248AED735B1356206988A811D591618A089AB_RuntimeMethod_var;
extern const RuntimeMethod* SMUtilities_End_mF4ECA0F51F0459AA9782F89FAB30F778CA437920_RuntimeMethod_var;
extern const RuntimeMethod* SMUtilities_Initialize_m72D841439646754BD5DA0EE354CDB2DF01D56BEE_RuntimeMethod_var;
extern const RuntimeMethod* SceneReference__ctor_m5E587B2DAC13F4712610347BCBF5ECC6F73F932C_RuntimeMethod_var;
extern const RuntimeMethod* SceneReference_get_Path_mB04B812EFDB313EE0A501C4984EBD823BE8E146F_RuntimeMethod_var;
extern const RuntimeMethod* SceneReference_op_Implicit_m35979307D7E55413DD3A5D6B01BF7E4A1A376134_RuntimeMethod_var;
extern const RuntimeMethod* Singleton_1__ctor_m338353C6D6074D6C6AC75D270237A0CC32BE9BDF_RuntimeMethod_var;
extern const RuntimeMethod* Singleton_1_get_Instance_m9E601D43C461833AEAAC52704F1EFD611715C0A9_RuntimeMethod_var;
extern const RuntimeMethod* Singleton_1_isQuittingOrChangingScene_m4D5ABD228FA0FB2265D3D3BEEAD1FB0EFC43EDAF_RuntimeMethod_var;
extern const RuntimeMethod* StarterKernel_Awake_mB592AB780528F8CFE2DCDE25EFD7315EC73160F2_RuntimeMethod_var;
extern const RuntimeMethod* StarterKernel__ctor_mC262E406BBEAD3D23939BEA529B3FDB3DBCC25B3_RuntimeMethod_var;
extern const RuntimeMethod* Starter_Add_TisHandleActorsAdd_t8D5278068F1EACBBF9799D835738C552E5550F9E_mA560947496F70A63FF412D33E89301B4DF85B112_RuntimeMethod_var;
extern const RuntimeMethod* Starter_Add_TisHandleActorsRemove_t775454EB912F9A2B222D5E61FA84C2DE6EFFAEA7_m713D123155C4DAEC92D33D1F2DC1740CACDE86C5_RuntimeMethod_var;
extern const RuntimeMethod* Starter_Awake_m1120568736201A5193A79CAB44F7DAEB50EE902B_RuntimeMethod_var;
extern const RuntimeMethod* Starter_BindScene_m48FDC251F232774AE14DBE07598841EAA7D58C8A_RuntimeMethod_var;
extern const RuntimeMethod* Starter_OnDestroy_mFBFD3B6AEDA51D1E7D00BE36A8603F923B36EE21_RuntimeMethod_var;
extern const RuntimeMethod* Starter_PostSetup_mC00BA4E660755D48275215D267359E3D1F8D19F9_RuntimeMethod_var;
extern const RuntimeMethod* Starter_Setup_m7168F366433C5D66CEFDDDEF603B134B232C1B5A_RuntimeMethod_var;
extern const RuntimeMethod* Starter_U3CBindSceneU3Eb__6_0_m4D490AE422A931AD8455C3B08096DA81CD4C780E_RuntimeMethod_var;
extern const RuntimeMethod* Starter__ctor_m07462EA4F217E11C903BBCD94F02F056D27822FC_RuntimeMethod_var;
extern const RuntimeMethod* StorageTags_AddRaw_mFF874A7D557EF4E3EEA7114AB99F48EA2275ADF3_RuntimeMethod_var;
extern const RuntimeMethod* StorageTags_AddTagsRaw_m111EBC57E4E312E5A48549FD01856586C6114C75_RuntimeMethod_var;
extern const RuntimeMethod* StorageTags_Add_m2EDFBB0C3DA3265F46F93686EC416118D7B7DA9B_RuntimeMethod_var;
extern const RuntimeMethod* StorageTags_Add_mCD78809357CD1F06D61F3EDAC34F5F57EE21A09A_RuntimeMethod_var;
extern const RuntimeMethod* StorageTags_Add_mE206DD042FF32DAD99D33C47EF92D132579CE703_RuntimeMethod_var;
extern const RuntimeMethod* StorageTags_Clear_mE0CBF5CA09785CA919E3CD33BB3C9B1B47A9274C_RuntimeMethod_var;
extern const RuntimeMethod* StorageTags_HandleChange_m4BD1475868B1DBAA90A56C0F26FDD0471D120FA1_RuntimeMethod_var;
extern const RuntimeMethod* StorageTags_HasAnyRaw_m6516D8D46980ED0B0245DEC00D0FE4714A507403_RuntimeMethod_var;
extern const RuntimeMethod* StorageTags_HasAny_mF329799E84478B2102F2D511D6ABD2CBB24F21B0_RuntimeMethod_var;
extern const RuntimeMethod* StorageTags_HasRaw_m87F3357D1A697D9A2787BC29FCC0AD0AB2DC1967_RuntimeMethod_var;
extern const RuntimeMethod* StorageTags_Has_m1851387046ECDB6A342295BEBD984F3E0E23890D_RuntimeMethod_var;
extern const RuntimeMethod* StorageTags_Has_m359525595715BD7A6528801A898303C8571575A6_RuntimeMethod_var;
extern const RuntimeMethod* StorageTags_RemoveAll_m68B8B18E9B75F5575C4723491321180D335FBC79_RuntimeMethod_var;
extern const RuntimeMethod* StorageTags_RemoveTagsRaw_m9EB9CD5105697868437FEC1117A623ED4FA2BCFA_RuntimeMethod_var;
extern const RuntimeMethod* StorageTags_Remove_m874D77B822456F77BA6B8E7932479A3E318F9325_RuntimeMethod_var;
extern const RuntimeMethod* StorageTags_Remove_mCBF0DBADE40449247AEF16EC26133DA5C4086403_RuntimeMethod_var;
extern const RuntimeMethod* StorageTags__cctor_m30C3FAB242D20B1986B6E90FF2C12C88D1F8584D_RuntimeMethod_var;
extern const RuntimeMethod* Storage__cctor_mF95C1369CFB2D38F18B33AE72E9EA6897D8642FD_RuntimeMethod_var;
extern const RuntimeMethod* TagFieldAttribute__ctor_m3061DEC1FD335EDFCF60FBA5E7ED4F56F593C49F_RuntimeMethod_var;
extern const RuntimeMethod* TagFieldAttribute__ctor_m4E1C0C653496A9001D516369068B6AC407F93313_RuntimeMethod_var;
extern const RuntimeMethod* TagFieldAttribute__ctor_mC0BC1CB05E663416285FB3075485853B830412C1_RuntimeMethod_var;
extern const RuntimeMethod* TagFieldAttribute__ctor_mF96BDE8ED77B82AAEAD1EFDE853D210AE07C66A9_RuntimeMethod_var;
extern const RuntimeMethod* TagFieldAttribute__ctor_mFBDA7F394D479E0A759E12893343983C527E46C4_RuntimeMethod_var;
extern const RuntimeMethod* TagFilterAttribute__ctor_m61622BA04CE30CDC8286CFD9AFE2298BC5C1C830_RuntimeMethod_var;
extern const RuntimeMethod* TagFilterAttribute_get_Type_m91AD49C489EE8EF461DF823549C441E9F74EEE2C_RuntimeMethod_var;
extern const RuntimeMethod* Template_OnEnable_mA01BCE3BEE15DF82C5076784105F7A6172040420_RuntimeMethod_var;
extern const RuntimeMethod* Template_Setup_m25AD47E5A5EBF061264FA737B03B6BD5FB482111_RuntimeMethod_var;
extern const RuntimeMethod* Template__ctor_m32D7262047A32FFA3DF95D52245B00FA74CE2490_RuntimeMethod_var;
extern const RuntimeMethod* Time_Tick_m0AB7869FDF59F349A0C18C983C0E58BE0448747A_RuntimeMethod_var;
extern const RuntimeMethod* Time__cctor_m606A834823814E855B8A17EB1B6D987F86C5CFFF_RuntimeMethod_var;
extern const RuntimeMethod* Time__ctor_m3B49553DC238654DF564C95BE1F2C04A9AD0C22B_RuntimeMethod_var;
extern const RuntimeMethod* Time_get_deltaFixed_mC41C8B31BC0F5F34522AF1B72CE977D5E07A490E_RuntimeMethod_var;
extern const RuntimeMethod* Time_get_delta_m9AD3A71A628E62BF0E3A01D0E5A652DA9807585E_RuntimeMethod_var;
extern const RuntimeMethod* Time_get_frame_m6D7BB007C0B65BB540A2D26C6CB7A853EA0BA36F_RuntimeMethod_var;
extern const RuntimeMethod* TimerKey_Equals_m4E3403831CDAF7D5E0DF496FEF1335BEC18D82A2_RuntimeMethod_var;
extern const RuntimeMethod* TimerKey_Equals_m6345B28732D3D678C674DF49AEAB5182BCD83180_RuntimeMethod_var;
extern const RuntimeMethod* TimerKey_GetHashCode_mE22CDE5761F4F098F78D2671099DDFD795A59306_RuntimeMethod_var;
extern const RuntimeMethod* TimerKey__ctor_m51B474020E775F991C54479D9B55A309AEF513AF_RuntimeMethod_var;
extern const RuntimeMethod* Timer_AddID_mF75BF469BE1DCFC9D1EC91217E52F03354CB8122_RuntimeMethod_var;
extern const RuntimeMethod* Timer_Add_mFA7866CEC7552E59E915183E6405C77CFAA61207_RuntimeMethod_var;
extern const RuntimeMethod* Timer_Dispose_m8E57793C983E49F48EE17D66614532581624D71C_RuntimeMethod_var;
extern const RuntimeMethod* Timer_Execute_m2F9D39C42E0AB9B085388143528BEFD1DFCBB9B2_RuntimeMethod_var;
extern const RuntimeMethod* Timer_FindAllTimers_m24C54633D77906904C96B78DFCBB26CC41DF681B_RuntimeMethod_var;
extern const RuntimeMethod* Timer_Play_mB651AAAAE2F539E862FC75DB62C78B1641B8069A_RuntimeMethod_var;
extern const RuntimeMethod* Timer_Release_m149B5E117807CA56D6E1FE89E6A19B45DD7FCE31_RuntimeMethod_var;
extern const RuntimeMethod* Timer_Release_m897A3D2D802D3394A0F42929B6B746EDF50F2318_RuntimeMethod_var;
extern const RuntimeMethod* Timer_Restart_m3DB9882F8B6959F0E89FF55E0424E25FC784416C_RuntimeMethod_var;
extern const RuntimeMethod* Timer_Restart_m60B91E24E3F76CC9399B7490C55773B7E76EC6A9_RuntimeMethod_var;
extern const RuntimeMethod* Timer_SetTimeScale_m147642252A783B8D95C5EF479AA50D426C97EB06_RuntimeMethod_var;
extern const RuntimeMethod* Timer_Stop_m67DB897B6F803C7E8D24861682C3965EE7D94636_RuntimeMethod_var;
extern const RuntimeMethod* Timer_Stop_m70B9AEC7527FE1E55839D48BF815404834F6ABC8_RuntimeMethod_var;
extern const RuntimeMethod* Timer_Tick_m52CC13CAF2A4D0506274980348BA3DB0AA060A74_RuntimeMethod_var;
extern const RuntimeMethod* Timer__cctor_m0D3DF27227238E16464244D1566255E049F3C4A4_RuntimeMethod_var;
extern const RuntimeMethod* Timer__ctor_m110E02B64865D564EEC131D008E1B63F8C17ABA5_RuntimeMethod_var;
extern const RuntimeMethod* Timer__ctor_mA49C1E2BEBA494C51B822123E4F43E7FD41E69D0_RuntimeMethod_var;
extern const RuntimeMethod* Timer_get_IsRunning_m8FE712A6CD64FC8FC037D142ADC3EADE57871FE9_RuntimeMethod_var;
extern const RuntimeMethod* Timer_set_IsRunning_m9AA3554B76F6EB4CD9722620479886E61A599986_RuntimeMethod_var;
extern const RuntimeMethod* Toolbox_Add_mBDBD189E3DF0F0617BEB2FF6ECC08CC748DB4FF9_RuntimeMethod_var;
extern const RuntimeMethod* Toolbox_ClearSessionData_mE82F017CF39C883E598DB8129B876253C21CCCED_RuntimeMethod_var;
extern const RuntimeMethod* Toolbox_DisposeObject_mE303B4740B3F3657EFBB211699227741CC6B681A_RuntimeMethod_var;
extern const RuntimeMethod* Toolbox_Get_m0C31066657C1EDE23F50364E05BE3C56AB43E6A9_RuntimeMethod_var;
extern const RuntimeMethod* Toolbox_InitializeObject_m6675C399D61F9479D097A9D6E84A755F92EAF155_RuntimeMethod_var;
extern const RuntimeMethod* Toolbox_Remove_mA89ECC44101120B2FA1DA2121A30C3607EA1E30B_RuntimeMethod_var;
extern const RuntimeMethod* Toolbox__ctor_mFF865D9437C280405E8B57E77135276B8AD03B38_RuntimeMethod_var;
extern const RuntimeMethod* U3COnApplicationFocusU3Ed__4_MoveNext_m8E765B73A1FDF3C0707D50DC451596259629DB53_RuntimeMethod_var;
extern const RuntimeMethod* U3COnApplicationFocusU3Ed__4_System_Collections_IEnumerator_Reset_m790F4D8BB3789AC3E77BA2505D85C6326B6080AE_RuntimeMethod_var;
extern const RuntimeMethod* U3CU3Ec_U3CRecursiveCopyBaseTypePrivateFieldsU3Eb__4_0_m669A441D3EDA0C0C5F8DBD3A216252FCB5C5A3E6_RuntimeMethod_var;
extern const RuntimeMethod* U3CU3Ec__DisplayClass3_1_U3CInternalCopyU3Eb__0_m576CC120FC2610B5680C6EEC9437420E9CACF8EA_RuntimeMethod_var;
extern const RuntimeMethod* ent_CompareTo_m0B254BB7E07D9944123F1F542D006388839908EC_RuntimeMethod_var;
extern const RuntimeMethod* ent_CompareTo_mE8416899740A9FE48A8295ED4B796B13DD0A97BE_RuntimeMethod_var;
extern const RuntimeMethod* ent_Equals_m17106E28D6874576C7BC82063A2D7EDE88CB1F8C_RuntimeMethod_var;
extern const RuntimeMethod* ent_Equals_m6D047D20BE89EC823DDD217C6905F1B454A82049_RuntimeMethod_var;
extern const RuntimeMethod* ent_Exist_m7DF7BEF41163A226515F8EC5A7DAF61B227090D7_RuntimeMethod_var;
extern const RuntimeMethod* ent_GetHashCode_m0A4671ADC4A691FEC3BC1CFC742A114831A259A4_RuntimeMethod_var;
extern const RuntimeMethod* ent_Release_m8211BD2C827CC92F4B8D97385D87A463C3193441_RuntimeMethod_var;
extern const RuntimeMethod* ent__ctor_m687198B81484B7EA5A3EB6F226AA5CE1F2B52F6E_RuntimeMethod_var;
extern const RuntimeMethod* ent_op_Addition_m8DF8CC2936EEE52AFB9DD1B668222FAC4C802BA6_RuntimeMethod_var;
extern const RuntimeMethod* ent_op_Implicit_m16BC2A28ED2D8A104FC8CB8BF31A2CA6B2DD42CD_RuntimeMethod_var;
extern const RuntimeMethod* ent_op_Implicit_m7B45657F4A2AE01FC3A5AC35BF156D72DAD5ABFF_RuntimeMethod_var;
extern const RuntimeMethod* ent_op_Subtraction_m5A4B3BEA36BAFFF4EB8558BDAF7009313FD2A552_RuntimeMethod_var;
extern const RuntimeType* ArrayTraverse_tD07A6D4E93DB7941CE934AFF9F006788173C70A6_0_0_0_var;
extern const RuntimeType* BaseStateMachineBehaviorU5BU5D_t69541BC5FF78E6A8031B638080B9821EA0364911_0_0_0_var;
extern const RuntimeType* BaseStateMachineBehavior_tC9B4D174C0E646DA37525E41FBB6A50C5DEEB064_0_0_0_var;
extern const RuntimeType* Boolean_tB53F6830F670160873277339AA58F15CAED4399C_0_0_0_var;
extern const RuntimeType* DelayTagEvent_tBFFD54C27E705D5B8CD1C5C49B4094A01A88BE02_0_0_0_var;
extern const RuntimeType* Delegate_t_0_0_0_var;
extern const RuntimeType* Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8_0_0_0_var;
extern const RuntimeType* EntityComposer_tB9CD47E805A3232A943F6CF48BB084FB1646CCD3_0_0_0_var;
extern const RuntimeType* Enumerator_t72A8231827DB93FC8B25F08FF066377F7B773DA1_0_0_0_var;
extern const RuntimeType* Enumerator_tCCCA7DEF5437A9668FAB3E25F19542413527939A_0_0_0_var;
extern const RuntimeType* Factory_tFA5041074647498CBAB64B0C4ABD43314393E7A5_0_0_0_var;
extern const RuntimeType* FieldInfoU5BU5D_t9C36FA93372CA01DAF85946064B058CD9CE2E8BE_0_0_0_var;
extern const RuntimeType* FieldInfo_t_0_0_0_var;
extern const RuntimeType* IAwake_tCD9519461B0D3E6CE3EAA3CF6194878CFEB0B1E5_0_0_0_var;
extern const RuntimeType* IDisposable_t7218B22548186B208D65EA5B7870503810A2D15A_0_0_0_var;
extern const RuntimeType* IKernel_t0B60B083684ECDD45B0EBB8E5E0555AE88F66112_0_0_0_var;
extern const RuntimeType* IRequireStarter_t5149D99640196B893E1AE71434420EB865532225_0_0_0_var;
extern const RuntimeType* Il2CppSetOptionAttribute_t013DDBAF8F39A8C8395B51A2549BCF893259611E_0_0_0_var;
extern const RuntimeType* Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83_0_0_0_var;
extern const RuntimeType* Int32_t585191389E07734F19F3156FF88FB3EF4800D102_0_0_0_var;
extern const RuntimeType* KeyValuePair_2_t142B50DAD5164EBD2E1495FD821B1A4C3233FA26_0_0_0_var;
extern const RuntimeType* List_1_t613852693859B0156A22267D914D17B30CFDE8F1_0_0_0_var;
extern const RuntimeType* List_1_tE1526161A558A17A39A8B69D8EEF3801393B6226_0_0_0_var;
extern const RuntimeType* MonoBehaviourU5BU5D_tEC81C7491112CB97F70976A67ABB8C33168F5F0A_0_0_0_var;
extern const RuntimeType* MonoBehaviour_t4A60845CF505405AF8BE8C61CC07F75CADEF6429_0_0_0_var;
extern const RuntimeType* ReferenceEqualityComparer_t3840A1467D76B18290FA822E6B548D1079D91DA4_0_0_0_var;
extern const RuntimeType* RequireAttribute_t8B9E56505437ECBB6B0EA3FB2B9E1AA773C1CDEB_0_0_0_var;
extern const RuntimeType* RequireTagsAttribute_tB80A8FCE5689F37232DC22E17DF16EEE0F912257_0_0_0_var;
extern const RuntimeType* RuntimeObject_0_0_0_var;
extern const RuntimeType* SceneReference_t824B30D7B4AAF610B0DBC1F5F54227F2BB69685F_0_0_0_var;
extern const RuntimeType* ScriptableObject_tAB015486CEAB714DA0D5C1BA389B84FB90427734_0_0_0_var;
extern const RuntimeType* StarterKernel_t383AD5285BEE52A4F9F6FDBE97E01A368CE25E27_0_0_0_var;
extern const RuntimeType* Starter_t094EE6CE9643F0578E88871EBE1EE57879A38146_0_0_0_var;
extern const RuntimeType* String_t_0_0_0_var;
extern const RuntimeType* TagFieldAttribute_t44EBFA87585224B6D3C31F706F3CE1072F7C075D_0_0_0_var;
extern const RuntimeType* TagFilterAttribute_tCFBF8A9A03FC22D02803646A5564ECD11A6E2276_0_0_0_var;
extern const RuntimeType* Template_t5107412B0F7996BE75F25FE9E22600F4E7DA2CA9_0_0_0_var;
extern const RuntimeType* Time_t70920BA2C4C4BE707DAE9822ED553B006FFC0100_0_0_0_var;
extern const RuntimeType* TimerKey_tCE6BF602B11E3FE849B05CC16BE0650A88755F89_0_0_0_var;
extern const RuntimeType* Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA_0_0_0_var;
extern const RuntimeType* Toolbox_t081ED4540597D09C31B0F9430D6D377D6BA90E3A_0_0_0_var;
extern const RuntimeType* Type_t_0_0_0_var;
extern const RuntimeType* U3COnApplicationFocusU3Ed__4_t6A81BE9FFD6951A1410B57DFD8BCA01E3D3AF5E4_0_0_0_var;
extern const RuntimeType* U3CU3Ec__DisplayClass3_0_t715805D6146E8762D34660C36DE710592B4E74BC_0_0_0_var;
extern const RuntimeType* U3CU3Ec__DisplayClass3_1_tB9452E9E43273A7EB9B4BEC3B43307E5DC1E2DAD_0_0_0_var;
extern const RuntimeType* U3CU3Ec_t9C407A5DC0C368A41DAACA036192AD2BC6222A05_0_0_0_var;
extern const RuntimeType* ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622_0_0_0_var;
extern const uint32_t ArrayTraverse_Step_m3D9533390B66FB0C727576BAEF5CE78EF602193E_MetadataUsageId;
extern const uint32_t ArrayTraverse__ctor_mCC997558A200828072F6A2B76B02E089FABE3741_MetadataUsageId;
extern const uint32_t HelperArray_ForEach_mB81FAB6CA742EF47C4B9E2CA805351AFBB1FB0DB_MetadataUsageId;
extern const uint32_t HelperObject_CopyFields_m82911ECAA99D264F8D7B8D63C02CDC35A1B9657C_MetadataUsageId;
extern const uint32_t HelperObject_Copy_m0F1F1434D990C76B797BE3B746388D080E578EE1_MetadataUsageId;
extern const uint32_t HelperObject_InternalCopy_mACD63D41622BF6303A74BBCE7C77024CD5B97FB2_MetadataUsageId;
extern const uint32_t HelperObject_IsPrimitive_m7A8654F1FD5D1F421189A6552C8D3BCD2530ADBB_MetadataUsageId;
extern const uint32_t HelperObject_RecursiveCopyBaseTypePrivateFields_mC004C89E73C1BECCD83A4BC7F31ECBCA5E3DA6A7_MetadataUsageId;
extern const uint32_t HelperObject__cctor_m390F3EFE34A1F5910F6A723E8DA582D699698A29_MetadataUsageId;
extern const uint32_t Il2CppSetOptionAttribute__ctor_m959B784CDB72D7B9D9676F464C669AA059EA9B8F_MetadataUsageId;
extern const uint32_t Il2CppSetOptionAttribute_get_Option_m0E0DE57E57329D9C0870E600F1A3396AFB3C73AE_MetadataUsageId;
extern const uint32_t Il2CppSetOptionAttribute_get_Value_m2BA8D8B60E0237F26014F46196F6A433469FFF2A_MetadataUsageId;
extern const uint32_t Il2CppSetOptionAttribute_set_Option_mA79F66679078953ABC5CFF576AFE2714A0C840CA_MetadataUsageId;
extern const uint32_t Il2CppSetOptionAttribute_set_Value_m67B377532E1429A6AE787932FFA2250D04D09022_MetadataUsageId;
extern const uint32_t ReferenceEqualityComparer_Equals_m96C511CA5702FDF53C7253762841E6D189A71366_MetadataUsageId;
extern const uint32_t ReferenceEqualityComparer_GetHashCode_mD5B3DD433D815E66BA01586CE51D7CDF0CF2129E_MetadataUsageId;
extern const uint32_t ReferenceEqualityComparer__ctor_mF5BDE00932C85FFE5E2633F082A065724571C26D_MetadataUsageId;
extern const uint32_t RequireAttribute__ctor_m6FDFFB2F320943CACF50F50B03844E53FAD6F549_MetadataUsageId;
extern const uint32_t RequireTagsAttribute__ctor_m111248AED735B1356206988A811D591618A089AB_MetadataUsageId;
extern const uint32_t SMUtilities_End_mF4ECA0F51F0459AA9782F89FAB30F778CA437920_MetadataUsageId;
extern const uint32_t SMUtilities_Initialize_m72D841439646754BD5DA0EE354CDB2DF01D56BEE_MetadataUsageId;
extern const uint32_t SceneReference__ctor_m5E587B2DAC13F4712610347BCBF5ECC6F73F932C_MetadataUsageId;
extern const uint32_t SceneReference_get_Path_mB04B812EFDB313EE0A501C4984EBD823BE8E146F_MetadataUsageId;
extern const uint32_t SceneReference_op_Implicit_m35979307D7E55413DD3A5D6B01BF7E4A1A376134_MetadataUsageId;
extern const uint32_t StarterKernel_Awake_mB592AB780528F8CFE2DCDE25EFD7315EC73160F2_MetadataUsageId;
extern const uint32_t StarterKernel_OnApplicationFocus_m2D527AFF6687B25412E99269754DAF7232E10391_MetadataUsageId;
extern const uint32_t StarterKernel__ctor_mC262E406BBEAD3D23939BEA529B3FDB3DBCC25B3_MetadataUsageId;
extern const uint32_t Starter_Awake_m1120568736201A5193A79CAB44F7DAEB50EE902B_MetadataUsageId;
extern const uint32_t Starter_BindScene_m48FDC251F232774AE14DBE07598841EAA7D58C8A_MetadataUsageId;
extern const uint32_t Starter_OnDestroy_mFBFD3B6AEDA51D1E7D00BE36A8603F923B36EE21_MetadataUsageId;
extern const uint32_t Starter_PostSetup_mC00BA4E660755D48275215D267359E3D1F8D19F9_MetadataUsageId;
extern const uint32_t Starter_Setup_m7168F366433C5D66CEFDDDEF603B134B232C1B5A_MetadataUsageId;
extern const uint32_t Starter_U3CBindSceneU3Eb__6_0_m4D490AE422A931AD8455C3B08096DA81CD4C780E_MetadataUsageId;
extern const uint32_t Starter__ctor_m07462EA4F217E11C903BBCD94F02F056D27822FC_MetadataUsageId;
extern const uint32_t StorageTags_AddRaw_mFF874A7D557EF4E3EEA7114AB99F48EA2275ADF3_MetadataUsageId;
extern const uint32_t StorageTags_AddTagsRaw_m111EBC57E4E312E5A48549FD01856586C6114C75_MetadataUsageId;
extern const uint32_t StorageTags_Add_m2EDFBB0C3DA3265F46F93686EC416118D7B7DA9B_MetadataUsageId;
extern const uint32_t StorageTags_Add_mCD78809357CD1F06D61F3EDAC34F5F57EE21A09A_MetadataUsageId;
extern const uint32_t StorageTags_Add_mE206DD042FF32DAD99D33C47EF92D132579CE703_MetadataUsageId;
extern const uint32_t StorageTags_Clear_mE0CBF5CA09785CA919E3CD33BB3C9B1B47A9274C_MetadataUsageId;
extern const uint32_t StorageTags_HandleChange_m4BD1475868B1DBAA90A56C0F26FDD0471D120FA1_MetadataUsageId;
extern const uint32_t StorageTags_HasAnyRaw_m6516D8D46980ED0B0245DEC00D0FE4714A507403_MetadataUsageId;
extern const uint32_t StorageTags_HasAny_mF329799E84478B2102F2D511D6ABD2CBB24F21B0_MetadataUsageId;
extern const uint32_t StorageTags_HasRaw_m87F3357D1A697D9A2787BC29FCC0AD0AB2DC1967_MetadataUsageId;
extern const uint32_t StorageTags_Has_m1851387046ECDB6A342295BEBD984F3E0E23890D_MetadataUsageId;
extern const uint32_t StorageTags_Has_m359525595715BD7A6528801A898303C8571575A6_MetadataUsageId;
extern const uint32_t StorageTags_RemoveAll_m68B8B18E9B75F5575C4723491321180D335FBC79_MetadataUsageId;
extern const uint32_t StorageTags_RemoveTagsRaw_m9EB9CD5105697868437FEC1117A623ED4FA2BCFA_MetadataUsageId;
extern const uint32_t StorageTags_Remove_m874D77B822456F77BA6B8E7932479A3E318F9325_MetadataUsageId;
extern const uint32_t StorageTags_Remove_mCBF0DBADE40449247AEF16EC26133DA5C4086403_MetadataUsageId;
extern const uint32_t StorageTags__cctor_m30C3FAB242D20B1986B6E90FF2C12C88D1F8584D_MetadataUsageId;
extern const uint32_t Storage__cctor_mF95C1369CFB2D38F18B33AE72E9EA6897D8642FD_MetadataUsageId;
extern const uint32_t TagFieldAttribute__ctor_m3061DEC1FD335EDFCF60FBA5E7ED4F56F593C49F_MetadataUsageId;
extern const uint32_t TagFieldAttribute__ctor_m4E1C0C653496A9001D516369068B6AC407F93313_MetadataUsageId;
extern const uint32_t TagFieldAttribute__ctor_mC0BC1CB05E663416285FB3075485853B830412C1_MetadataUsageId;
extern const uint32_t TagFieldAttribute__ctor_mF96BDE8ED77B82AAEAD1EFDE853D210AE07C66A9_MetadataUsageId;
extern const uint32_t TagFieldAttribute__ctor_mFBDA7F394D479E0A759E12893343983C527E46C4_MetadataUsageId;
extern const uint32_t TagFilterAttribute__ctor_m61622BA04CE30CDC8286CFD9AFE2298BC5C1C830_MetadataUsageId;
extern const uint32_t TagFilterAttribute_get_Type_m91AD49C489EE8EF461DF823549C441E9F74EEE2C_MetadataUsageId;
extern const uint32_t Template_OnEnable_mA01BCE3BEE15DF82C5076784105F7A6172040420_MetadataUsageId;
extern const uint32_t Template_Setup_m25AD47E5A5EBF061264FA737B03B6BD5FB482111_MetadataUsageId;
extern const uint32_t Template__ctor_m32D7262047A32FFA3DF95D52245B00FA74CE2490_MetadataUsageId;
extern const uint32_t Time_Tick_m0AB7869FDF59F349A0C18C983C0E58BE0448747A_MetadataUsageId;
extern const uint32_t Time__cctor_m606A834823814E855B8A17EB1B6D987F86C5CFFF_MetadataUsageId;
extern const uint32_t Time__ctor_m3B49553DC238654DF564C95BE1F2C04A9AD0C22B_MetadataUsageId;
extern const uint32_t Time_get_deltaFixed_mC41C8B31BC0F5F34522AF1B72CE977D5E07A490E_MetadataUsageId;
extern const uint32_t Time_get_delta_m9AD3A71A628E62BF0E3A01D0E5A652DA9807585E_MetadataUsageId;
extern const uint32_t Time_get_frame_m6D7BB007C0B65BB540A2D26C6CB7A853EA0BA36F_MetadataUsageId;
extern const uint32_t TimerKey_Equals_m4E3403831CDAF7D5E0DF496FEF1335BEC18D82A2_MetadataUsageId;
extern const uint32_t TimerKey_Equals_m6345B28732D3D678C674DF49AEAB5182BCD83180_MetadataUsageId;
extern const uint32_t TimerKey_GetHashCode_mE22CDE5761F4F098F78D2671099DDFD795A59306_MetadataUsageId;
extern const uint32_t TimerKey__ctor_m51B474020E775F991C54479D9B55A309AEF513AF_MetadataUsageId;
extern const uint32_t Timer_AddID_mF75BF469BE1DCFC9D1EC91217E52F03354CB8122_MetadataUsageId;
extern const uint32_t Timer_Add_mFA7866CEC7552E59E915183E6405C77CFAA61207_MetadataUsageId;
extern const uint32_t Timer_Dispose_m8E57793C983E49F48EE17D66614532581624D71C_MetadataUsageId;
extern const uint32_t Timer_Execute_m2F9D39C42E0AB9B085388143528BEFD1DFCBB9B2_MetadataUsageId;
extern const uint32_t Timer_FindAllTimers_m24C54633D77906904C96B78DFCBB26CC41DF681B_MetadataUsageId;
extern const uint32_t Timer_Play_mB651AAAAE2F539E862FC75DB62C78B1641B8069A_MetadataUsageId;
extern const uint32_t Timer_Release_m149B5E117807CA56D6E1FE89E6A19B45DD7FCE31_MetadataUsageId;
extern const uint32_t Timer_Release_m897A3D2D802D3394A0F42929B6B746EDF50F2318_MetadataUsageId;
extern const uint32_t Timer_Restart_m3DB9882F8B6959F0E89FF55E0424E25FC784416C_MetadataUsageId;
extern const uint32_t Timer_Restart_m60B91E24E3F76CC9399B7490C55773B7E76EC6A9_MetadataUsageId;
extern const uint32_t Timer_SetTimeScale_m147642252A783B8D95C5EF479AA50D426C97EB06_MetadataUsageId;
extern const uint32_t Timer_Stop_m67DB897B6F803C7E8D24861682C3965EE7D94636_MetadataUsageId;
extern const uint32_t Timer_Stop_m70B9AEC7527FE1E55839D48BF815404834F6ABC8_MetadataUsageId;
extern const uint32_t Timer_Tick_m52CC13CAF2A4D0506274980348BA3DB0AA060A74_MetadataUsageId;
extern const uint32_t Timer__cctor_m0D3DF27227238E16464244D1566255E049F3C4A4_MetadataUsageId;
extern const uint32_t Timer__ctor_m110E02B64865D564EEC131D008E1B63F8C17ABA5_MetadataUsageId;
extern const uint32_t Timer__ctor_mA49C1E2BEBA494C51B822123E4F43E7FD41E69D0_MetadataUsageId;
extern const uint32_t Timer_get_IsRunning_m8FE712A6CD64FC8FC037D142ADC3EADE57871FE9_MetadataUsageId;
extern const uint32_t Timer_set_IsRunning_m9AA3554B76F6EB4CD9722620479886E61A599986_MetadataUsageId;
extern const uint32_t Toolbox_Add_mBDBD189E3DF0F0617BEB2FF6ECC08CC748DB4FF9_MetadataUsageId;
extern const uint32_t Toolbox_ClearSessionData_mE82F017CF39C883E598DB8129B876253C21CCCED_MetadataUsageId;
extern const uint32_t Toolbox_DisposeObject_mE303B4740B3F3657EFBB211699227741CC6B681A_MetadataUsageId;
extern const uint32_t Toolbox_Get_m0C31066657C1EDE23F50364E05BE3C56AB43E6A9_MetadataUsageId;
extern const uint32_t Toolbox_InitializeObject_m6675C399D61F9479D097A9D6E84A755F92EAF155_MetadataUsageId;
extern const uint32_t Toolbox_Remove_mA89ECC44101120B2FA1DA2121A30C3607EA1E30B_MetadataUsageId;
extern const uint32_t Toolbox__ctor_mFF865D9437C280405E8B57E77135276B8AD03B38_MetadataUsageId;
extern const uint32_t U3COnApplicationFocusU3Ed__4_MoveNext_m8E765B73A1FDF3C0707D50DC451596259629DB53_MetadataUsageId;
extern const uint32_t U3COnApplicationFocusU3Ed__4_System_Collections_IEnumerator_Reset_m790F4D8BB3789AC3E77BA2505D85C6326B6080AE_MetadataUsageId;
extern const uint32_t U3CU3Ec_U3CRecursiveCopyBaseTypePrivateFieldsU3Eb__4_0_m669A441D3EDA0C0C5F8DBD3A216252FCB5C5A3E6_MetadataUsageId;
extern const uint32_t U3CU3Ec__DisplayClass3_1_U3CInternalCopyU3Eb__0_m576CC120FC2610B5680C6EEC9437420E9CACF8EA_MetadataUsageId;
extern const uint32_t U3CU3Ec__cctor_m7A61BBB8A1F00EEAF2F965DCA334EB7147E51975_MetadataUsageId;
extern const uint32_t ent_CompareTo_m0B254BB7E07D9944123F1F542D006388839908EC_MetadataUsageId;
extern const uint32_t ent_CompareTo_mE8416899740A9FE48A8295ED4B796B13DD0A97BE_MetadataUsageId;
extern const uint32_t ent_Equals_m17106E28D6874576C7BC82063A2D7EDE88CB1F8C_MetadataUsageId;
extern const uint32_t ent_Equals_m6D047D20BE89EC823DDD217C6905F1B454A82049_MetadataUsageId;
extern const uint32_t ent_Exist_m7DF7BEF41163A226515F8EC5A7DAF61B227090D7_MetadataUsageId;
extern const uint32_t ent_GetHashCode_m0A4671ADC4A691FEC3BC1CFC742A114831A259A4_MetadataUsageId;
extern const uint32_t ent_Release_m8211BD2C827CC92F4B8D97385D87A463C3193441_MetadataUsageId;
extern const uint32_t ent__ctor_m687198B81484B7EA5A3EB6F226AA5CE1F2B52F6E_MetadataUsageId;
extern const uint32_t ent_op_Addition_m8DF8CC2936EEE52AFB9DD1B668222FAC4C802BA6_MetadataUsageId;
extern const uint32_t ent_op_Implicit_m16BC2A28ED2D8A104FC8CB8BF31A2CA6B2DD42CD_MetadataUsageId;
extern const uint32_t ent_op_Implicit_m7B45657F4A2AE01FC3A5AC35BF156D72DAD5ABFF_MetadataUsageId;
extern const uint32_t ent_op_Subtraction_m5A4B3BEA36BAFFF4EB8558BDAF7009313FD2A552_MetadataUsageId;
extern const uint32_t taskEntityTick_BeginInvoke_mA6EA9DB394B9BD9B9425F0983B7C90828FF071CC_MetadataUsageId;
extern const uint32_t taskEntity_BeginInvoke_mED189307ED4072A522DFF8A17361DE763F44897D_MetadataUsageId;
struct Delegate_t_marshaled_com;
struct Delegate_t_marshaled_pinvoke;
struct Exception_t_marshaled_com;
struct Exception_t_marshaled_pinvoke;

struct BaseStateMachineBehaviorU5BU5D_t69541BC5FF78E6A8031B638080B9821EA0364911;
struct DelayTagEventU5BU5D_t7C4AB33A74B954415C9AF4B6E5D707E0CF3AA45F;
struct BooleanU5BU5D_t192C7579715690E25BD5EFED47F3E0FC9DCB2040;
struct Dictionary_2U5BU5D_t5A34008586C648E4C1725CB098BCFE11124FEC7E;
struct DelegateU5BU5D_tDFCDEE2A6322F96C0FE49AF47E9ADB8C4B294E86;
struct Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83;
struct ObjectU5BU5D_t3C9242B5C88A48B2A5BD9FDA6CD0024E792AF08A;
struct FieldInfoU5BU5D_t9C36FA93372CA01DAF85946064B058CD9CE2E8BE;
struct TypeU5BU5D_t7FE623A666B49176DE123306221193E888A12F5F;
struct MonoBehaviourU5BU5D_tEC81C7491112CB97F70976A67ABB8C33168F5F0A;
struct TransformU5BU5D_t3EB9781D1A1DE2674F0632C956A66AA423343139;


#ifndef RUNTIMEOBJECT_H
#define RUNTIMEOBJECT_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Object

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // RUNTIMEOBJECT_H
#ifndef FASTCOMPARABLE_T85AACE6CEBE4B0D7FB16B2F3D09523B7BC4AA1A8_H
#define FASTCOMPARABLE_T85AACE6CEBE4B0D7FB16B2F3D09523B7BC4AA1A8_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// FastComparable
struct  FastComparable_t85AACE6CEBE4B0D7FB16B2F3D09523B7BC4AA1A8  : public RuntimeObject
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // FASTCOMPARABLE_T85AACE6CEBE4B0D7FB16B2F3D09523B7BC4AA1A8_H
#ifndef BOX_T4C71F0C8AB96AC3964C40FE71BB42D9C121F81B1_H
#define BOX_T4C71F0C8AB96AC3964C40FE71BB42D9C121F81B1_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Pixeye.Box
struct  Box_t4C71F0C8AB96AC3964C40FE71BB42D9C121F81B1  : public RuntimeObject
{
public:
	// System.Collections.Generic.Dictionary`2<System.Int32,UnityEngine.Object> Pixeye.Box::items
	Dictionary_2_t770A301203EE62B42C6E15A74786AB854F8FA099 * ___items_2;
	// System.Collections.Generic.Dictionary`2<System.Int32,System.String> Pixeye.Box::itemsPaths
	Dictionary_2_t4EFE6A1D6502662B911688316C6920444A18CF0C * ___itemsPaths_3;

public:
	inline static int32_t get_offset_of_items_2() { return static_cast<int32_t>(offsetof(Box_t4C71F0C8AB96AC3964C40FE71BB42D9C121F81B1, ___items_2)); }
	inline Dictionary_2_t770A301203EE62B42C6E15A74786AB854F8FA099 * get_items_2() const { return ___items_2; }
	inline Dictionary_2_t770A301203EE62B42C6E15A74786AB854F8FA099 ** get_address_of_items_2() { return &___items_2; }
	inline void set_items_2(Dictionary_2_t770A301203EE62B42C6E15A74786AB854F8FA099 * value)
	{
		___items_2 = value;
		Il2CppCodeGenWriteBarrier((&___items_2), value);
	}

	inline static int32_t get_offset_of_itemsPaths_3() { return static_cast<int32_t>(offsetof(Box_t4C71F0C8AB96AC3964C40FE71BB42D9C121F81B1, ___itemsPaths_3)); }
	inline Dictionary_2_t4EFE6A1D6502662B911688316C6920444A18CF0C * get_itemsPaths_3() const { return ___itemsPaths_3; }
	inline Dictionary_2_t4EFE6A1D6502662B911688316C6920444A18CF0C ** get_address_of_itemsPaths_3() { return &___itemsPaths_3; }
	inline void set_itemsPaths_3(Dictionary_2_t4EFE6A1D6502662B911688316C6920444A18CF0C * value)
	{
		___itemsPaths_3 = value;
		Il2CppCodeGenWriteBarrier((&___itemsPaths_3), value);
	}
};

struct Box_t4C71F0C8AB96AC3964C40FE71BB42D9C121F81B1_StaticFields
{
public:
	// Pixeye.Box Pixeye.Box::Default
	Box_t4C71F0C8AB96AC3964C40FE71BB42D9C121F81B1 * ___Default_0;
	// System.String Pixeye.Box::path
	String_t* ___path_1;

public:
	inline static int32_t get_offset_of_Default_0() { return static_cast<int32_t>(offsetof(Box_t4C71F0C8AB96AC3964C40FE71BB42D9C121F81B1_StaticFields, ___Default_0)); }
	inline Box_t4C71F0C8AB96AC3964C40FE71BB42D9C121F81B1 * get_Default_0() const { return ___Default_0; }
	inline Box_t4C71F0C8AB96AC3964C40FE71BB42D9C121F81B1 ** get_address_of_Default_0() { return &___Default_0; }
	inline void set_Default_0(Box_t4C71F0C8AB96AC3964C40FE71BB42D9C121F81B1 * value)
	{
		___Default_0 = value;
		Il2CppCodeGenWriteBarrier((&___Default_0), value);
	}

	inline static int32_t get_offset_of_path_1() { return static_cast<int32_t>(offsetof(Box_t4C71F0C8AB96AC3964C40FE71BB42D9C121F81B1_StaticFields, ___path_1)); }
	inline String_t* get_path_1() const { return ___path_1; }
	inline String_t** get_address_of_path_1() { return &___path_1; }
	inline void set_path_1(String_t* value)
	{
		___path_1 = value;
		Il2CppCodeGenWriteBarrier((&___path_1), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // BOX_T4C71F0C8AB96AC3964C40FE71BB42D9C121F81B1_H
#ifndef COMPONENTRELEASE_T98EE3880490384D15031D69FB587E1C7D806E527_H
#define COMPONENTRELEASE_T98EE3880490384D15031D69FB587E1C7D806E527_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Pixeye.ComponentRelease
struct  ComponentRelease_t98EE3880490384D15031D69FB587E1C7D806E527  : public RuntimeObject
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // COMPONENTRELEASE_T98EE3880490384D15031D69FB587E1C7D806E527_H
#ifndef HANDLEBASE_T2CC405783D210E33C249B92D210EC302F227D7EC_H
#define HANDLEBASE_T2CC405783D210E33C249B92D210EC302F227D7EC_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Pixeye.HandleBase
struct  HandleBase_t2CC405783D210E33C249B92D210EC302F227D7EC  : public RuntimeObject
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // HANDLEBASE_T2CC405783D210E33C249B92D210EC302F227D7EC_H
#ifndef HANDLEENTITIES_T05CCD5B390B45C447D8FA2542EF8CC2761054D76_H
#define HANDLEENTITIES_T05CCD5B390B45C447D8FA2542EF8CC2761054D76_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Pixeye.HandleEntities
struct  HandleEntities_t05CCD5B390B45C447D8FA2542EF8CC2761054D76  : public RuntimeObject
{
public:
	// Pixeye.GroupBase[] Pixeye.HandleEntities::GroupsBase
	GroupBaseU5BU5D_t66B1A0989D748227CC6DD39CC2748EC2551F0E85* ___GroupsBase_3;
	// System.Int32 Pixeye.HandleEntities::groupLength
	int32_t ___groupLength_4;

public:
	inline static int32_t get_offset_of_GroupsBase_3() { return static_cast<int32_t>(offsetof(HandleEntities_t05CCD5B390B45C447D8FA2542EF8CC2761054D76, ___GroupsBase_3)); }
	inline GroupBaseU5BU5D_t66B1A0989D748227CC6DD39CC2748EC2551F0E85* get_GroupsBase_3() const { return ___GroupsBase_3; }
	inline GroupBaseU5BU5D_t66B1A0989D748227CC6DD39CC2748EC2551F0E85** get_address_of_GroupsBase_3() { return &___GroupsBase_3; }
	inline void set_GroupsBase_3(GroupBaseU5BU5D_t66B1A0989D748227CC6DD39CC2748EC2551F0E85* value)
	{
		___GroupsBase_3 = value;
		Il2CppCodeGenWriteBarrier((&___GroupsBase_3), value);
	}

	inline static int32_t get_offset_of_groupLength_4() { return static_cast<int32_t>(offsetof(HandleEntities_t05CCD5B390B45C447D8FA2542EF8CC2761054D76, ___groupLength_4)); }
	inline int32_t get_groupLength_4() const { return ___groupLength_4; }
	inline int32_t* get_address_of_groupLength_4() { return &___groupLength_4; }
	inline void set_groupLength_4(int32_t value)
	{
		___groupLength_4 = value;
	}
};

struct HandleEntities_t05CCD5B390B45C447D8FA2542EF8CC2761054D76_StaticFields
{
public:
	// Pixeye.HandleEntities Pixeye.HandleEntities::Default
	HandleEntities_t05CCD5B390B45C447D8FA2542EF8CC2761054D76 * ___Default_0;
	// System.Collections.Generic.Stack`1<System.Int32> Pixeye.HandleEntities::prevID
	Stack_1_t7C4BBD98911741434BD5D2CC3B1FA31A32EF1819 * ___prevID_1;
	// System.Int32 Pixeye.HandleEntities::lastID
	int32_t ___lastID_2;

public:
	inline static int32_t get_offset_of_Default_0() { return static_cast<int32_t>(offsetof(HandleEntities_t05CCD5B390B45C447D8FA2542EF8CC2761054D76_StaticFields, ___Default_0)); }
	inline HandleEntities_t05CCD5B390B45C447D8FA2542EF8CC2761054D76 * get_Default_0() const { return ___Default_0; }
	inline HandleEntities_t05CCD5B390B45C447D8FA2542EF8CC2761054D76 ** get_address_of_Default_0() { return &___Default_0; }
	inline void set_Default_0(HandleEntities_t05CCD5B390B45C447D8FA2542EF8CC2761054D76 * value)
	{
		___Default_0 = value;
		Il2CppCodeGenWriteBarrier((&___Default_0), value);
	}

	inline static int32_t get_offset_of_prevID_1() { return static_cast<int32_t>(offsetof(HandleEntities_t05CCD5B390B45C447D8FA2542EF8CC2761054D76_StaticFields, ___prevID_1)); }
	inline Stack_1_t7C4BBD98911741434BD5D2CC3B1FA31A32EF1819 * get_prevID_1() const { return ___prevID_1; }
	inline Stack_1_t7C4BBD98911741434BD5D2CC3B1FA31A32EF1819 ** get_address_of_prevID_1() { return &___prevID_1; }
	inline void set_prevID_1(Stack_1_t7C4BBD98911741434BD5D2CC3B1FA31A32EF1819 * value)
	{
		___prevID_1 = value;
		Il2CppCodeGenWriteBarrier((&___prevID_1), value);
	}

	inline static int32_t get_offset_of_lastID_2() { return static_cast<int32_t>(offsetof(HandleEntities_t05CCD5B390B45C447D8FA2542EF8CC2761054D76_StaticFields, ___lastID_2)); }
	inline int32_t get_lastID_2() const { return ___lastID_2; }
	inline int32_t* get_address_of_lastID_2() { return &___lastID_2; }
	inline void set_lastID_2(int32_t value)
	{
		___lastID_2 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // HANDLEENTITIES_T05CCD5B390B45C447D8FA2542EF8CC2761054D76_H
#ifndef HANDLEFASTPOOL_1_T717E0511090B921AEE3A8436B7B8AB6BC1A0C0AD_H
#define HANDLEFASTPOOL_1_T717E0511090B921AEE3A8436B7B8AB6BC1A0C0AD_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Pixeye.HandleFastPool`1<Pixeye.Timer>
struct  HandleFastPool_1_t717E0511090B921AEE3A8436B7B8AB6BC1A0C0AD  : public RuntimeObject
{
public:
	// System.Collections.Generic.Stack`1<T> Pixeye.HandleFastPool`1::pool
	Stack_1_tF8554B34D8B53E76DA4B08AC899FF3811A8893A3 * ___pool_1;

public:
	inline static int32_t get_offset_of_pool_1() { return static_cast<int32_t>(offsetof(HandleFastPool_1_t717E0511090B921AEE3A8436B7B8AB6BC1A0C0AD, ___pool_1)); }
	inline Stack_1_tF8554B34D8B53E76DA4B08AC899FF3811A8893A3 * get_pool_1() const { return ___pool_1; }
	inline Stack_1_tF8554B34D8B53E76DA4B08AC899FF3811A8893A3 ** get_address_of_pool_1() { return &___pool_1; }
	inline void set_pool_1(Stack_1_tF8554B34D8B53E76DA4B08AC899FF3811A8893A3 * value)
	{
		___pool_1 = value;
		Il2CppCodeGenWriteBarrier((&___pool_1), value);
	}
};

struct HandleFastPool_1_t717E0511090B921AEE3A8436B7B8AB6BC1A0C0AD_StaticFields
{
public:
	// Pixeye.HandleFastPool`1<T> Pixeye.HandleFastPool`1::Instance
	HandleFastPool_1_t717E0511090B921AEE3A8436B7B8AB6BC1A0C0AD * ___Instance_0;

public:
	inline static int32_t get_offset_of_Instance_0() { return static_cast<int32_t>(offsetof(HandleFastPool_1_t717E0511090B921AEE3A8436B7B8AB6BC1A0C0AD_StaticFields, ___Instance_0)); }
	inline HandleFastPool_1_t717E0511090B921AEE3A8436B7B8AB6BC1A0C0AD * get_Instance_0() const { return ___Instance_0; }
	inline HandleFastPool_1_t717E0511090B921AEE3A8436B7B8AB6BC1A0C0AD ** get_address_of_Instance_0() { return &___Instance_0; }
	inline void set_Instance_0(HandleFastPool_1_t717E0511090B921AEE3A8436B7B8AB6BC1A0C0AD * value)
	{
		___Instance_0 = value;
		Il2CppCodeGenWriteBarrier((&___Instance_0), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // HANDLEFASTPOOL_1_T717E0511090B921AEE3A8436B7B8AB6BC1A0C0AD_H
#ifndef HANDLEPOOL_TBB031F11A1DE7E61E63146EF835372909BFCB665_H
#define HANDLEPOOL_TBB031F11A1DE7E61E63146EF835372909BFCB665_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Pixeye.HandlePool
struct  HandlePool_tBB031F11A1DE7E61E63146EF835372909BFCB665  : public RuntimeObject
{
public:

public:
};

struct HandlePool_tBB031F11A1DE7E61E63146EF835372909BFCB665_StaticFields
{
public:
	// System.Collections.Generic.Dictionary`2<System.Int32,Pixeye.PoolContainer> Pixeye.HandlePool::pools
	Dictionary_2_t97C22D3FBC16542FD0BDAC3BCD0893A7438EADD2 * ___pools_0;
	// Pixeye.HandlePool Pixeye.HandlePool::Default
	HandlePool_tBB031F11A1DE7E61E63146EF835372909BFCB665 * ___Default_1;

public:
	inline static int32_t get_offset_of_pools_0() { return static_cast<int32_t>(offsetof(HandlePool_tBB031F11A1DE7E61E63146EF835372909BFCB665_StaticFields, ___pools_0)); }
	inline Dictionary_2_t97C22D3FBC16542FD0BDAC3BCD0893A7438EADD2 * get_pools_0() const { return ___pools_0; }
	inline Dictionary_2_t97C22D3FBC16542FD0BDAC3BCD0893A7438EADD2 ** get_address_of_pools_0() { return &___pools_0; }
	inline void set_pools_0(Dictionary_2_t97C22D3FBC16542FD0BDAC3BCD0893A7438EADD2 * value)
	{
		___pools_0 = value;
		Il2CppCodeGenWriteBarrier((&___pools_0), value);
	}

	inline static int32_t get_offset_of_Default_1() { return static_cast<int32_t>(offsetof(HandlePool_tBB031F11A1DE7E61E63146EF835372909BFCB665_StaticFields, ___Default_1)); }
	inline HandlePool_tBB031F11A1DE7E61E63146EF835372909BFCB665 * get_Default_1() const { return ___Default_1; }
	inline HandlePool_tBB031F11A1DE7E61E63146EF835372909BFCB665 ** get_address_of_Default_1() { return &___Default_1; }
	inline void set_Default_1(HandlePool_tBB031F11A1DE7E61E63146EF835372909BFCB665 * value)
	{
		___Default_1 = value;
		Il2CppCodeGenWriteBarrier((&___Default_1), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // HANDLEPOOL_TBB031F11A1DE7E61E63146EF835372909BFCB665_H
#ifndef HANDLESCENE_T9A17EE1370450F47652A7C56B9D20A02A7BA1728_H
#define HANDLESCENE_T9A17EE1370450F47652A7C56B9D20A02A7BA1728_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Pixeye.HandleScene
struct  HandleScene_t9A17EE1370450F47652A7C56B9D20A02A7BA1728  : public RuntimeObject
{
public:
	// System.Action Pixeye.HandleScene::sceneLoaded
	Action_t591D2A86165F896B4B800BB5C25CE18672A55579 * ___sceneLoaded_1;
	// System.Action Pixeye.HandleScene::sceneClosing
	Action_t591D2A86165F896B4B800BB5C25CE18672A55579 * ___sceneClosing_2;
	// System.Collections.Generic.Dictionary`2<System.String,UnityEngine.Transform> Pixeye.HandleScene::sceneObjs
	Dictionary_2_tD568D405F77A6A44CE20C029082A82BEAC5EB63F * ___sceneObjs_3;
	// System.Collections.Generic.List`1<System.String> Pixeye.HandleScene::scenesToKeep
	List_1_tE8032E48C661C350FF9550E9063D595C0AB25CD3 * ___scenesToKeep_4;
	// System.Collections.Generic.List`1<System.String> Pixeye.HandleScene::sceneDependsOn
	List_1_tE8032E48C661C350FF9550E9063D595C0AB25CD3 * ___sceneDependsOn_5;
	// System.Collections.Generic.Dictionary`2<System.String,UnityEngine.SceneManagement.Scene> Pixeye.HandleScene::scenes
	Dictionary_2_t5D8E8B17B1B56C65697ED1A012BDB0A1BCB2451D * ___scenes_6;

public:
	inline static int32_t get_offset_of_sceneLoaded_1() { return static_cast<int32_t>(offsetof(HandleScene_t9A17EE1370450F47652A7C56B9D20A02A7BA1728, ___sceneLoaded_1)); }
	inline Action_t591D2A86165F896B4B800BB5C25CE18672A55579 * get_sceneLoaded_1() const { return ___sceneLoaded_1; }
	inline Action_t591D2A86165F896B4B800BB5C25CE18672A55579 ** get_address_of_sceneLoaded_1() { return &___sceneLoaded_1; }
	inline void set_sceneLoaded_1(Action_t591D2A86165F896B4B800BB5C25CE18672A55579 * value)
	{
		___sceneLoaded_1 = value;
		Il2CppCodeGenWriteBarrier((&___sceneLoaded_1), value);
	}

	inline static int32_t get_offset_of_sceneClosing_2() { return static_cast<int32_t>(offsetof(HandleScene_t9A17EE1370450F47652A7C56B9D20A02A7BA1728, ___sceneClosing_2)); }
	inline Action_t591D2A86165F896B4B800BB5C25CE18672A55579 * get_sceneClosing_2() const { return ___sceneClosing_2; }
	inline Action_t591D2A86165F896B4B800BB5C25CE18672A55579 ** get_address_of_sceneClosing_2() { return &___sceneClosing_2; }
	inline void set_sceneClosing_2(Action_t591D2A86165F896B4B800BB5C25CE18672A55579 * value)
	{
		___sceneClosing_2 = value;
		Il2CppCodeGenWriteBarrier((&___sceneClosing_2), value);
	}

	inline static int32_t get_offset_of_sceneObjs_3() { return static_cast<int32_t>(offsetof(HandleScene_t9A17EE1370450F47652A7C56B9D20A02A7BA1728, ___sceneObjs_3)); }
	inline Dictionary_2_tD568D405F77A6A44CE20C029082A82BEAC5EB63F * get_sceneObjs_3() const { return ___sceneObjs_3; }
	inline Dictionary_2_tD568D405F77A6A44CE20C029082A82BEAC5EB63F ** get_address_of_sceneObjs_3() { return &___sceneObjs_3; }
	inline void set_sceneObjs_3(Dictionary_2_tD568D405F77A6A44CE20C029082A82BEAC5EB63F * value)
	{
		___sceneObjs_3 = value;
		Il2CppCodeGenWriteBarrier((&___sceneObjs_3), value);
	}

	inline static int32_t get_offset_of_scenesToKeep_4() { return static_cast<int32_t>(offsetof(HandleScene_t9A17EE1370450F47652A7C56B9D20A02A7BA1728, ___scenesToKeep_4)); }
	inline List_1_tE8032E48C661C350FF9550E9063D595C0AB25CD3 * get_scenesToKeep_4() const { return ___scenesToKeep_4; }
	inline List_1_tE8032E48C661C350FF9550E9063D595C0AB25CD3 ** get_address_of_scenesToKeep_4() { return &___scenesToKeep_4; }
	inline void set_scenesToKeep_4(List_1_tE8032E48C661C350FF9550E9063D595C0AB25CD3 * value)
	{
		___scenesToKeep_4 = value;
		Il2CppCodeGenWriteBarrier((&___scenesToKeep_4), value);
	}

	inline static int32_t get_offset_of_sceneDependsOn_5() { return static_cast<int32_t>(offsetof(HandleScene_t9A17EE1370450F47652A7C56B9D20A02A7BA1728, ___sceneDependsOn_5)); }
	inline List_1_tE8032E48C661C350FF9550E9063D595C0AB25CD3 * get_sceneDependsOn_5() const { return ___sceneDependsOn_5; }
	inline List_1_tE8032E48C661C350FF9550E9063D595C0AB25CD3 ** get_address_of_sceneDependsOn_5() { return &___sceneDependsOn_5; }
	inline void set_sceneDependsOn_5(List_1_tE8032E48C661C350FF9550E9063D595C0AB25CD3 * value)
	{
		___sceneDependsOn_5 = value;
		Il2CppCodeGenWriteBarrier((&___sceneDependsOn_5), value);
	}

	inline static int32_t get_offset_of_scenes_6() { return static_cast<int32_t>(offsetof(HandleScene_t9A17EE1370450F47652A7C56B9D20A02A7BA1728, ___scenes_6)); }
	inline Dictionary_2_t5D8E8B17B1B56C65697ED1A012BDB0A1BCB2451D * get_scenes_6() const { return ___scenes_6; }
	inline Dictionary_2_t5D8E8B17B1B56C65697ED1A012BDB0A1BCB2451D ** get_address_of_scenes_6() { return &___scenes_6; }
	inline void set_scenes_6(Dictionary_2_t5D8E8B17B1B56C65697ED1A012BDB0A1BCB2451D * value)
	{
		___scenes_6 = value;
		Il2CppCodeGenWriteBarrier((&___scenes_6), value);
	}
};

struct HandleScene_t9A17EE1370450F47652A7C56B9D20A02A7BA1728_StaticFields
{
public:
	// Pixeye.HandleScene Pixeye.HandleScene::Default
	HandleScene_t9A17EE1370450F47652A7C56B9D20A02A7BA1728 * ___Default_0;

public:
	inline static int32_t get_offset_of_Default_0() { return static_cast<int32_t>(offsetof(HandleScene_t9A17EE1370450F47652A7C56B9D20A02A7BA1728_StaticFields, ___Default_0)); }
	inline HandleScene_t9A17EE1370450F47652A7C56B9D20A02A7BA1728 * get_Default_0() const { return ___Default_0; }
	inline HandleScene_t9A17EE1370450F47652A7C56B9D20A02A7BA1728 ** get_address_of_Default_0() { return &___Default_0; }
	inline void set_Default_0(HandleScene_t9A17EE1370450F47652A7C56B9D20A02A7BA1728 * value)
	{
		___Default_0 = value;
		Il2CppCodeGenWriteBarrier((&___Default_0), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // HANDLESCENE_T9A17EE1370450F47652A7C56B9D20A02A7BA1728_H
#ifndef HANDLETIMER_TE0613FB7A046C7560F75BD4908092FA5A2260483_H
#define HANDLETIMER_TE0613FB7A046C7560F75BD4908092FA5A2260483_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Pixeye.HandleTimer
struct  HandleTimer_tE0613FB7A046C7560F75BD4908092FA5A2260483  : public RuntimeObject
{
public:
	// System.Collections.Generic.List`1<Pixeye.Timer> Pixeye.HandleTimer::allWorkingTimers
	List_1_t613852693859B0156A22267D914D17B30CFDE8F1 * ___allWorkingTimers_1;

public:
	inline static int32_t get_offset_of_allWorkingTimers_1() { return static_cast<int32_t>(offsetof(HandleTimer_tE0613FB7A046C7560F75BD4908092FA5A2260483, ___allWorkingTimers_1)); }
	inline List_1_t613852693859B0156A22267D914D17B30CFDE8F1 * get_allWorkingTimers_1() const { return ___allWorkingTimers_1; }
	inline List_1_t613852693859B0156A22267D914D17B30CFDE8F1 ** get_address_of_allWorkingTimers_1() { return &___allWorkingTimers_1; }
	inline void set_allWorkingTimers_1(List_1_t613852693859B0156A22267D914D17B30CFDE8F1 * value)
	{
		___allWorkingTimers_1 = value;
		Il2CppCodeGenWriteBarrier((&___allWorkingTimers_1), value);
	}
};

struct HandleTimer_tE0613FB7A046C7560F75BD4908092FA5A2260483_StaticFields
{
public:
	// Pixeye.HandleTimer Pixeye.HandleTimer::Default
	HandleTimer_tE0613FB7A046C7560F75BD4908092FA5A2260483 * ___Default_0;

public:
	inline static int32_t get_offset_of_Default_0() { return static_cast<int32_t>(offsetof(HandleTimer_tE0613FB7A046C7560F75BD4908092FA5A2260483_StaticFields, ___Default_0)); }
	inline HandleTimer_tE0613FB7A046C7560F75BD4908092FA5A2260483 * get_Default_0() const { return ___Default_0; }
	inline HandleTimer_tE0613FB7A046C7560F75BD4908092FA5A2260483 ** get_address_of_Default_0() { return &___Default_0; }
	inline void set_Default_0(HandleTimer_tE0613FB7A046C7560F75BD4908092FA5A2260483 * value)
	{
		___Default_0 = value;
		Il2CppCodeGenWriteBarrier((&___Default_0), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // HANDLETIMER_TE0613FB7A046C7560F75BD4908092FA5A2260483_H
#ifndef POOLNODE_TD412A3A536E55E03495943E9F456B844ACBB2568_H
#define POOLNODE_TD412A3A536E55E03495943E9F456B844ACBB2568_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Pixeye.PoolNode
struct  PoolNode_tD412A3A536E55E03495943E9F456B844ACBB2568  : public RuntimeObject
{
public:
	// System.Int32 Pixeye.PoolNode::id
	int32_t ___id_0;
	// System.Int32 Pixeye.PoolNode::pool
	int32_t ___pool_1;
	// UnityEngine.GameObject Pixeye.PoolNode::prefab
	GameObject_tBD1244AD56B4E59AAD76E5E7C9282EC5CE434F0F * ___prefab_2;
	// System.Collections.Generic.List`1<UnityEngine.GameObject> Pixeye.PoolNode::createdObjs
	List_1_tBA8D772D87B6502B2A4D0EFE166C846285F50650 * ___createdObjs_3;

public:
	inline static int32_t get_offset_of_id_0() { return static_cast<int32_t>(offsetof(PoolNode_tD412A3A536E55E03495943E9F456B844ACBB2568, ___id_0)); }
	inline int32_t get_id_0() const { return ___id_0; }
	inline int32_t* get_address_of_id_0() { return &___id_0; }
	inline void set_id_0(int32_t value)
	{
		___id_0 = value;
	}

	inline static int32_t get_offset_of_pool_1() { return static_cast<int32_t>(offsetof(PoolNode_tD412A3A536E55E03495943E9F456B844ACBB2568, ___pool_1)); }
	inline int32_t get_pool_1() const { return ___pool_1; }
	inline int32_t* get_address_of_pool_1() { return &___pool_1; }
	inline void set_pool_1(int32_t value)
	{
		___pool_1 = value;
	}

	inline static int32_t get_offset_of_prefab_2() { return static_cast<int32_t>(offsetof(PoolNode_tD412A3A536E55E03495943E9F456B844ACBB2568, ___prefab_2)); }
	inline GameObject_tBD1244AD56B4E59AAD76E5E7C9282EC5CE434F0F * get_prefab_2() const { return ___prefab_2; }
	inline GameObject_tBD1244AD56B4E59AAD76E5E7C9282EC5CE434F0F ** get_address_of_prefab_2() { return &___prefab_2; }
	inline void set_prefab_2(GameObject_tBD1244AD56B4E59AAD76E5E7C9282EC5CE434F0F * value)
	{
		___prefab_2 = value;
		Il2CppCodeGenWriteBarrier((&___prefab_2), value);
	}

	inline static int32_t get_offset_of_createdObjs_3() { return static_cast<int32_t>(offsetof(PoolNode_tD412A3A536E55E03495943E9F456B844ACBB2568, ___createdObjs_3)); }
	inline List_1_tBA8D772D87B6502B2A4D0EFE166C846285F50650 * get_createdObjs_3() const { return ___createdObjs_3; }
	inline List_1_tBA8D772D87B6502B2A4D0EFE166C846285F50650 ** get_address_of_createdObjs_3() { return &___createdObjs_3; }
	inline void set_createdObjs_3(List_1_tBA8D772D87B6502B2A4D0EFE166C846285F50650 * value)
	{
		___createdObjs_3 = value;
		Il2CppCodeGenWriteBarrier((&___createdObjs_3), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // POOLNODE_TD412A3A536E55E03495943E9F456B844ACBB2568_H
#ifndef REFENTITY_T5823EB2D89C01C8E8581EC0091D5168FBA887089_H
#define REFENTITY_T5823EB2D89C01C8E8581EC0091D5168FBA887089_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Pixeye.RefEntity
struct  RefEntity_t5823EB2D89C01C8E8581EC0091D5168FBA887089  : public RuntimeObject
{
public:

public:
};

struct RefEntity_t5823EB2D89C01C8E8581EC0091D5168FBA887089_StaticFields
{
public:
	// System.Int32 Pixeye.RefEntity::self
	int32_t ___self_0;
	// System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.Dictionary`2<System.Int32,System.Object>>[] Pixeye.RefEntity::cacheMono
	Dictionary_2U5BU5D_t2188B0D28935CE1B5651F98445AD751B1536083F* ___cacheMono_1;
	// System.Int32[0...,0...] Pixeye.RefEntity::generations
	Int32U5BU2CU5D_tEFF95F718DC8948EF23BEE318FF51EDD788749D2* ___generations_2;
	// System.Boolean[] Pixeye.RefEntity::isAlive
	BooleanU5BU5D_t192C7579715690E25BD5EFED47F3E0FC9DCB2040* ___isAlive_3;
	// System.Int32[] Pixeye.RefEntity::blueprints
	Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* ___blueprints_4;
	// System.Int32[] Pixeye.RefEntity::poolIDS
	Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* ___poolIDS_5;
	// UnityEngine.Transform[] Pixeye.RefEntity::transforms
	TransformU5BU5D_t3EB9781D1A1DE2674F0632C956A66AA423343139* ___transforms_6;

public:
	inline static int32_t get_offset_of_self_0() { return static_cast<int32_t>(offsetof(RefEntity_t5823EB2D89C01C8E8581EC0091D5168FBA887089_StaticFields, ___self_0)); }
	inline int32_t get_self_0() const { return ___self_0; }
	inline int32_t* get_address_of_self_0() { return &___self_0; }
	inline void set_self_0(int32_t value)
	{
		___self_0 = value;
	}

	inline static int32_t get_offset_of_cacheMono_1() { return static_cast<int32_t>(offsetof(RefEntity_t5823EB2D89C01C8E8581EC0091D5168FBA887089_StaticFields, ___cacheMono_1)); }
	inline Dictionary_2U5BU5D_t2188B0D28935CE1B5651F98445AD751B1536083F* get_cacheMono_1() const { return ___cacheMono_1; }
	inline Dictionary_2U5BU5D_t2188B0D28935CE1B5651F98445AD751B1536083F** get_address_of_cacheMono_1() { return &___cacheMono_1; }
	inline void set_cacheMono_1(Dictionary_2U5BU5D_t2188B0D28935CE1B5651F98445AD751B1536083F* value)
	{
		___cacheMono_1 = value;
		Il2CppCodeGenWriteBarrier((&___cacheMono_1), value);
	}

	inline static int32_t get_offset_of_generations_2() { return static_cast<int32_t>(offsetof(RefEntity_t5823EB2D89C01C8E8581EC0091D5168FBA887089_StaticFields, ___generations_2)); }
	inline Int32U5BU2CU5D_tEFF95F718DC8948EF23BEE318FF51EDD788749D2* get_generations_2() const { return ___generations_2; }
	inline Int32U5BU2CU5D_tEFF95F718DC8948EF23BEE318FF51EDD788749D2** get_address_of_generations_2() { return &___generations_2; }
	inline void set_generations_2(Int32U5BU2CU5D_tEFF95F718DC8948EF23BEE318FF51EDD788749D2* value)
	{
		___generations_2 = value;
		Il2CppCodeGenWriteBarrier((&___generations_2), value);
	}

	inline static int32_t get_offset_of_isAlive_3() { return static_cast<int32_t>(offsetof(RefEntity_t5823EB2D89C01C8E8581EC0091D5168FBA887089_StaticFields, ___isAlive_3)); }
	inline BooleanU5BU5D_t192C7579715690E25BD5EFED47F3E0FC9DCB2040* get_isAlive_3() const { return ___isAlive_3; }
	inline BooleanU5BU5D_t192C7579715690E25BD5EFED47F3E0FC9DCB2040** get_address_of_isAlive_3() { return &___isAlive_3; }
	inline void set_isAlive_3(BooleanU5BU5D_t192C7579715690E25BD5EFED47F3E0FC9DCB2040* value)
	{
		___isAlive_3 = value;
		Il2CppCodeGenWriteBarrier((&___isAlive_3), value);
	}

	inline static int32_t get_offset_of_blueprints_4() { return static_cast<int32_t>(offsetof(RefEntity_t5823EB2D89C01C8E8581EC0091D5168FBA887089_StaticFields, ___blueprints_4)); }
	inline Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* get_blueprints_4() const { return ___blueprints_4; }
	inline Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83** get_address_of_blueprints_4() { return &___blueprints_4; }
	inline void set_blueprints_4(Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* value)
	{
		___blueprints_4 = value;
		Il2CppCodeGenWriteBarrier((&___blueprints_4), value);
	}

	inline static int32_t get_offset_of_poolIDS_5() { return static_cast<int32_t>(offsetof(RefEntity_t5823EB2D89C01C8E8581EC0091D5168FBA887089_StaticFields, ___poolIDS_5)); }
	inline Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* get_poolIDS_5() const { return ___poolIDS_5; }
	inline Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83** get_address_of_poolIDS_5() { return &___poolIDS_5; }
	inline void set_poolIDS_5(Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* value)
	{
		___poolIDS_5 = value;
		Il2CppCodeGenWriteBarrier((&___poolIDS_5), value);
	}

	inline static int32_t get_offset_of_transforms_6() { return static_cast<int32_t>(offsetof(RefEntity_t5823EB2D89C01C8E8581EC0091D5168FBA887089_StaticFields, ___transforms_6)); }
	inline TransformU5BU5D_t3EB9781D1A1DE2674F0632C956A66AA423343139* get_transforms_6() const { return ___transforms_6; }
	inline TransformU5BU5D_t3EB9781D1A1DE2674F0632C956A66AA423343139** get_address_of_transforms_6() { return &___transforms_6; }
	inline void set_transforms_6(TransformU5BU5D_t3EB9781D1A1DE2674F0632C956A66AA423343139* value)
	{
		___transforms_6 = value;
		Il2CppCodeGenWriteBarrier((&___transforms_6), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // REFENTITY_T5823EB2D89C01C8E8581EC0091D5168FBA887089_H
#ifndef REFERENCETYPE_TE3BEFC1D0A5EEAE313214E10535DAC824FCB1F2B_H
#define REFERENCETYPE_TE3BEFC1D0A5EEAE313214E10535DAC824FCB1F2B_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Pixeye.ReferenceType
struct  ReferenceType_tE3BEFC1D0A5EEAE313214E10535DAC824FCB1F2B  : public RuntimeObject
{
public:
	// System.Int32[] Pixeye.ReferenceType::siblings
	Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* ___siblings_0;
	// System.Int32 Pixeye.ReferenceType::hash
	int32_t ___hash_1;
	// System.String Pixeye.ReferenceType::path
	String_t* ___path_2;
	// System.String Pixeye.ReferenceType::name
	String_t* ___name_3;
	// System.Type Pixeye.ReferenceType::type
	Type_t * ___type_4;

public:
	inline static int32_t get_offset_of_siblings_0() { return static_cast<int32_t>(offsetof(ReferenceType_tE3BEFC1D0A5EEAE313214E10535DAC824FCB1F2B, ___siblings_0)); }
	inline Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* get_siblings_0() const { return ___siblings_0; }
	inline Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83** get_address_of_siblings_0() { return &___siblings_0; }
	inline void set_siblings_0(Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* value)
	{
		___siblings_0 = value;
		Il2CppCodeGenWriteBarrier((&___siblings_0), value);
	}

	inline static int32_t get_offset_of_hash_1() { return static_cast<int32_t>(offsetof(ReferenceType_tE3BEFC1D0A5EEAE313214E10535DAC824FCB1F2B, ___hash_1)); }
	inline int32_t get_hash_1() const { return ___hash_1; }
	inline int32_t* get_address_of_hash_1() { return &___hash_1; }
	inline void set_hash_1(int32_t value)
	{
		___hash_1 = value;
	}

	inline static int32_t get_offset_of_path_2() { return static_cast<int32_t>(offsetof(ReferenceType_tE3BEFC1D0A5EEAE313214E10535DAC824FCB1F2B, ___path_2)); }
	inline String_t* get_path_2() const { return ___path_2; }
	inline String_t** get_address_of_path_2() { return &___path_2; }
	inline void set_path_2(String_t* value)
	{
		___path_2 = value;
		Il2CppCodeGenWriteBarrier((&___path_2), value);
	}

	inline static int32_t get_offset_of_name_3() { return static_cast<int32_t>(offsetof(ReferenceType_tE3BEFC1D0A5EEAE313214E10535DAC824FCB1F2B, ___name_3)); }
	inline String_t* get_name_3() const { return ___name_3; }
	inline String_t** get_address_of_name_3() { return &___name_3; }
	inline void set_name_3(String_t* value)
	{
		___name_3 = value;
		Il2CppCodeGenWriteBarrier((&___name_3), value);
	}

	inline static int32_t get_offset_of_type_4() { return static_cast<int32_t>(offsetof(ReferenceType_tE3BEFC1D0A5EEAE313214E10535DAC824FCB1F2B, ___type_4)); }
	inline Type_t * get_type_4() const { return ___type_4; }
	inline Type_t ** get_address_of_type_4() { return &___type_4; }
	inline void set_type_4(Type_t * value)
	{
		___type_4 = value;
		Il2CppCodeGenWriteBarrier((&___type_4), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // REFERENCETYPE_TE3BEFC1D0A5EEAE313214E10535DAC824FCB1F2B_H
#ifndef SMUTILITIES_TBCB6E494C52B5A467F6037DD7C53A95B2A42499B_H
#define SMUTILITIES_TBCB6E494C52B5A467F6037DD7C53A95B2A42499B_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Pixeye.SMUtilities
struct  SMUtilities_tBCB6E494C52B5A467F6037DD7C53A95B2A42499B  : public RuntimeObject
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // SMUTILITIES_TBCB6E494C52B5A467F6037DD7C53A95B2A42499B_H
#ifndef SCENEREFERENCE_T824B30D7B4AAF610B0DBC1F5F54227F2BB69685F_H
#define SCENEREFERENCE_T824B30D7B4AAF610B0DBC1F5F54227F2BB69685F_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Pixeye.SceneReference
struct  SceneReference_t824B30D7B4AAF610B0DBC1F5F54227F2BB69685F  : public RuntimeObject
{
public:
	// UnityEngine.Object Pixeye.SceneReference::sceneAsset
	Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0 * ___sceneAsset_0;
	// System.String Pixeye.SceneReference::sceneName
	String_t* ___sceneName_1;

public:
	inline static int32_t get_offset_of_sceneAsset_0() { return static_cast<int32_t>(offsetof(SceneReference_t824B30D7B4AAF610B0DBC1F5F54227F2BB69685F, ___sceneAsset_0)); }
	inline Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0 * get_sceneAsset_0() const { return ___sceneAsset_0; }
	inline Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0 ** get_address_of_sceneAsset_0() { return &___sceneAsset_0; }
	inline void set_sceneAsset_0(Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0 * value)
	{
		___sceneAsset_0 = value;
		Il2CppCodeGenWriteBarrier((&___sceneAsset_0), value);
	}

	inline static int32_t get_offset_of_sceneName_1() { return static_cast<int32_t>(offsetof(SceneReference_t824B30D7B4AAF610B0DBC1F5F54227F2BB69685F, ___sceneName_1)); }
	inline String_t* get_sceneName_1() const { return ___sceneName_1; }
	inline String_t** get_address_of_sceneName_1() { return &___sceneName_1; }
	inline void set_sceneName_1(String_t* value)
	{
		___sceneName_1 = value;
		Il2CppCodeGenWriteBarrier((&___sceneName_1), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // SCENEREFERENCE_T824B30D7B4AAF610B0DBC1F5F54227F2BB69685F_H
#ifndef SETTINGSENGINE_TE5FAA3E51808E5B9F5820B753618576EE8035659_H
#define SETTINGSENGINE_TE5FAA3E51808E5B9F5820B753618576EE8035659_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Pixeye.SettingsEngine
struct  SettingsEngine_tE5FAA3E51808E5B9F5820B753618576EE8035659  : public RuntimeObject
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // SETTINGSENGINE_TE5FAA3E51808E5B9F5820B753618576EE8035659_H
#ifndef U3CONAPPLICATIONFOCUSU3ED__4_T6A81BE9FFD6951A1410B57DFD8BCA01E3D3AF5E4_H
#define U3CONAPPLICATIONFOCUSU3ED__4_T6A81BE9FFD6951A1410B57DFD8BCA01E3D3AF5E4_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Pixeye.StarterKernel_<OnApplicationFocus>d__4
struct  U3COnApplicationFocusU3Ed__4_t6A81BE9FFD6951A1410B57DFD8BCA01E3D3AF5E4  : public RuntimeObject
{
public:
	// System.Int32 Pixeye.StarterKernel_<OnApplicationFocus>d__4::<>1__state
	int32_t ___U3CU3E1__state_0;
	// System.Object Pixeye.StarterKernel_<OnApplicationFocus>d__4::<>2__current
	RuntimeObject * ___U3CU3E2__current_1;
	// System.Boolean Pixeye.StarterKernel_<OnApplicationFocus>d__4::hasFocus
	bool ___hasFocus_2;
	// Pixeye.StarterKernel Pixeye.StarterKernel_<OnApplicationFocus>d__4::<>4__this
	StarterKernel_t383AD5285BEE52A4F9F6FDBE97E01A368CE25E27 * ___U3CU3E4__this_3;

public:
	inline static int32_t get_offset_of_U3CU3E1__state_0() { return static_cast<int32_t>(offsetof(U3COnApplicationFocusU3Ed__4_t6A81BE9FFD6951A1410B57DFD8BCA01E3D3AF5E4, ___U3CU3E1__state_0)); }
	inline int32_t get_U3CU3E1__state_0() const { return ___U3CU3E1__state_0; }
	inline int32_t* get_address_of_U3CU3E1__state_0() { return &___U3CU3E1__state_0; }
	inline void set_U3CU3E1__state_0(int32_t value)
	{
		___U3CU3E1__state_0 = value;
	}

	inline static int32_t get_offset_of_U3CU3E2__current_1() { return static_cast<int32_t>(offsetof(U3COnApplicationFocusU3Ed__4_t6A81BE9FFD6951A1410B57DFD8BCA01E3D3AF5E4, ___U3CU3E2__current_1)); }
	inline RuntimeObject * get_U3CU3E2__current_1() const { return ___U3CU3E2__current_1; }
	inline RuntimeObject ** get_address_of_U3CU3E2__current_1() { return &___U3CU3E2__current_1; }
	inline void set_U3CU3E2__current_1(RuntimeObject * value)
	{
		___U3CU3E2__current_1 = value;
		Il2CppCodeGenWriteBarrier((&___U3CU3E2__current_1), value);
	}

	inline static int32_t get_offset_of_hasFocus_2() { return static_cast<int32_t>(offsetof(U3COnApplicationFocusU3Ed__4_t6A81BE9FFD6951A1410B57DFD8BCA01E3D3AF5E4, ___hasFocus_2)); }
	inline bool get_hasFocus_2() const { return ___hasFocus_2; }
	inline bool* get_address_of_hasFocus_2() { return &___hasFocus_2; }
	inline void set_hasFocus_2(bool value)
	{
		___hasFocus_2 = value;
	}

	inline static int32_t get_offset_of_U3CU3E4__this_3() { return static_cast<int32_t>(offsetof(U3COnApplicationFocusU3Ed__4_t6A81BE9FFD6951A1410B57DFD8BCA01E3D3AF5E4, ___U3CU3E4__this_3)); }
	inline StarterKernel_t383AD5285BEE52A4F9F6FDBE97E01A368CE25E27 * get_U3CU3E4__this_3() const { return ___U3CU3E4__this_3; }
	inline StarterKernel_t383AD5285BEE52A4F9F6FDBE97E01A368CE25E27 ** get_address_of_U3CU3E4__this_3() { return &___U3CU3E4__this_3; }
	inline void set_U3CU3E4__this_3(StarterKernel_t383AD5285BEE52A4F9F6FDBE97E01A368CE25E27 * value)
	{
		___U3CU3E4__this_3 = value;
		Il2CppCodeGenWriteBarrier((&___U3CU3E4__this_3), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // U3CONAPPLICATIONFOCUSU3ED__4_T6A81BE9FFD6951A1410B57DFD8BCA01E3D3AF5E4_H
#ifndef STORAGE_TDB77CB8CF4EE44D043E9BE9027A74B153B16E826_H
#define STORAGE_TDB77CB8CF4EE44D043E9BE9027A74B153B16E826_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Pixeye.Storage
struct  Storage_tDB77CB8CF4EE44D043E9BE9027A74B153B16E826  : public RuntimeObject
{
public:

public:
};

struct Storage_tDB77CB8CF4EE44D043E9BE9027A74B153B16E826_StaticFields
{
public:
	// System.Int32 Pixeye.Storage::lastID
	int32_t ___lastID_0;
	// System.Collections.Generic.List`1<Pixeye.Storage> Pixeye.Storage::all
	List_1_t186D2009EAF545D4056FD040D409D10C57CE8F97 * ___all_1;
	// System.Collections.Generic.Dictionary`2<System.Int32,Pixeye.Storage> Pixeye.Storage::allDict
	Dictionary_2_t683E72069DD61C3D055254F6694A3E646C6B3622 * ___allDict_2;

public:
	inline static int32_t get_offset_of_lastID_0() { return static_cast<int32_t>(offsetof(Storage_tDB77CB8CF4EE44D043E9BE9027A74B153B16E826_StaticFields, ___lastID_0)); }
	inline int32_t get_lastID_0() const { return ___lastID_0; }
	inline int32_t* get_address_of_lastID_0() { return &___lastID_0; }
	inline void set_lastID_0(int32_t value)
	{
		___lastID_0 = value;
	}

	inline static int32_t get_offset_of_all_1() { return static_cast<int32_t>(offsetof(Storage_tDB77CB8CF4EE44D043E9BE9027A74B153B16E826_StaticFields, ___all_1)); }
	inline List_1_t186D2009EAF545D4056FD040D409D10C57CE8F97 * get_all_1() const { return ___all_1; }
	inline List_1_t186D2009EAF545D4056FD040D409D10C57CE8F97 ** get_address_of_all_1() { return &___all_1; }
	inline void set_all_1(List_1_t186D2009EAF545D4056FD040D409D10C57CE8F97 * value)
	{
		___all_1 = value;
		Il2CppCodeGenWriteBarrier((&___all_1), value);
	}

	inline static int32_t get_offset_of_allDict_2() { return static_cast<int32_t>(offsetof(Storage_tDB77CB8CF4EE44D043E9BE9027A74B153B16E826_StaticFields, ___allDict_2)); }
	inline Dictionary_2_t683E72069DD61C3D055254F6694A3E646C6B3622 * get_allDict_2() const { return ___allDict_2; }
	inline Dictionary_2_t683E72069DD61C3D055254F6694A3E646C6B3622 ** get_address_of_allDict_2() { return &___allDict_2; }
	inline void set_allDict_2(Dictionary_2_t683E72069DD61C3D055254F6694A3E646C6B3622 * value)
	{
		___allDict_2 = value;
		Il2CppCodeGenWriteBarrier((&___allDict_2), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // STORAGE_TDB77CB8CF4EE44D043E9BE9027A74B153B16E826_H
#ifndef STORAGETAGS_T7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_H
#define STORAGETAGS_T7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Pixeye.StorageTags
struct  StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8  : public RuntimeObject
{
public:

public:
};

struct StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_StaticFields
{
public:
	// System.Collections.Generic.Dictionary`2<System.Int32,System.Int32>[] Pixeye.StorageTags::tags
	Dictionary_2U5BU5D_t5A34008586C648E4C1725CB098BCFE11124FEC7E* ___tags_0;
	// System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<Pixeye.GroupBase>> Pixeye.StorageTags::groupsInclude
	Dictionary_2_t62CC83140A4EC1BB76940D6FD31E9B3B8417C850 * ___groupsInclude_1;
	// System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<Pixeye.GroupBase>> Pixeye.StorageTags::groupsDeclude
	Dictionary_2_t62CC83140A4EC1BB76940D6FD31E9B3B8417C850 * ___groupsDeclude_2;
	// System.Int32 Pixeye.StorageTags::length
	int32_t ___length_3;

public:
	inline static int32_t get_offset_of_tags_0() { return static_cast<int32_t>(offsetof(StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_StaticFields, ___tags_0)); }
	inline Dictionary_2U5BU5D_t5A34008586C648E4C1725CB098BCFE11124FEC7E* get_tags_0() const { return ___tags_0; }
	inline Dictionary_2U5BU5D_t5A34008586C648E4C1725CB098BCFE11124FEC7E** get_address_of_tags_0() { return &___tags_0; }
	inline void set_tags_0(Dictionary_2U5BU5D_t5A34008586C648E4C1725CB098BCFE11124FEC7E* value)
	{
		___tags_0 = value;
		Il2CppCodeGenWriteBarrier((&___tags_0), value);
	}

	inline static int32_t get_offset_of_groupsInclude_1() { return static_cast<int32_t>(offsetof(StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_StaticFields, ___groupsInclude_1)); }
	inline Dictionary_2_t62CC83140A4EC1BB76940D6FD31E9B3B8417C850 * get_groupsInclude_1() const { return ___groupsInclude_1; }
	inline Dictionary_2_t62CC83140A4EC1BB76940D6FD31E9B3B8417C850 ** get_address_of_groupsInclude_1() { return &___groupsInclude_1; }
	inline void set_groupsInclude_1(Dictionary_2_t62CC83140A4EC1BB76940D6FD31E9B3B8417C850 * value)
	{
		___groupsInclude_1 = value;
		Il2CppCodeGenWriteBarrier((&___groupsInclude_1), value);
	}

	inline static int32_t get_offset_of_groupsDeclude_2() { return static_cast<int32_t>(offsetof(StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_StaticFields, ___groupsDeclude_2)); }
	inline Dictionary_2_t62CC83140A4EC1BB76940D6FD31E9B3B8417C850 * get_groupsDeclude_2() const { return ___groupsDeclude_2; }
	inline Dictionary_2_t62CC83140A4EC1BB76940D6FD31E9B3B8417C850 ** get_address_of_groupsDeclude_2() { return &___groupsDeclude_2; }
	inline void set_groupsDeclude_2(Dictionary_2_t62CC83140A4EC1BB76940D6FD31E9B3B8417C850 * value)
	{
		___groupsDeclude_2 = value;
		Il2CppCodeGenWriteBarrier((&___groupsDeclude_2), value);
	}

	inline static int32_t get_offset_of_length_3() { return static_cast<int32_t>(offsetof(StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_StaticFields, ___length_3)); }
	inline int32_t get_length_3() const { return ___length_3; }
	inline int32_t* get_address_of_length_3() { return &___length_3; }
	inline void set_length_3(int32_t value)
	{
		___length_3 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // STORAGETAGS_T7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_H
#ifndef TAGBASE_T00D73CADD76FB47F7A9EA7BC5DA9E359CCAAAC3F_H
#define TAGBASE_T00D73CADD76FB47F7A9EA7BC5DA9E359CCAAAC3F_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Pixeye.TagBase
struct  TagBase_t00D73CADD76FB47F7A9EA7BC5DA9E359CCAAAC3F  : public RuntimeObject
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // TAGBASE_T00D73CADD76FB47F7A9EA7BC5DA9E359CCAAAC3F_H
#ifndef TIME_T70920BA2C4C4BE707DAE9822ED553B006FFC0100_H
#define TIME_T70920BA2C4C4BE707DAE9822ED553B006FFC0100_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Pixeye.Time
struct  Time_t70920BA2C4C4BE707DAE9822ED553B006FFC0100  : public RuntimeObject
{
public:
	// System.Single Pixeye.Time::timeScale
	float ___timeScale_2;
	// System.Single Pixeye.Time::_deltaTimeFixed
	float ____deltaTimeFixed_3;
	// System.Single Pixeye.Time::_deltaTime
	float ____deltaTime_4;
	// System.Single Pixeye.Time::timeScaleCached
	float ___timeScaleCached_5;

public:
	inline static int32_t get_offset_of_timeScale_2() { return static_cast<int32_t>(offsetof(Time_t70920BA2C4C4BE707DAE9822ED553B006FFC0100, ___timeScale_2)); }
	inline float get_timeScale_2() const { return ___timeScale_2; }
	inline float* get_address_of_timeScale_2() { return &___timeScale_2; }
	inline void set_timeScale_2(float value)
	{
		___timeScale_2 = value;
	}

	inline static int32_t get_offset_of__deltaTimeFixed_3() { return static_cast<int32_t>(offsetof(Time_t70920BA2C4C4BE707DAE9822ED553B006FFC0100, ____deltaTimeFixed_3)); }
	inline float get__deltaTimeFixed_3() const { return ____deltaTimeFixed_3; }
	inline float* get_address_of__deltaTimeFixed_3() { return &____deltaTimeFixed_3; }
	inline void set__deltaTimeFixed_3(float value)
	{
		____deltaTimeFixed_3 = value;
	}

	inline static int32_t get_offset_of__deltaTime_4() { return static_cast<int32_t>(offsetof(Time_t70920BA2C4C4BE707DAE9822ED553B006FFC0100, ____deltaTime_4)); }
	inline float get__deltaTime_4() const { return ____deltaTime_4; }
	inline float* get_address_of__deltaTime_4() { return &____deltaTime_4; }
	inline void set__deltaTime_4(float value)
	{
		____deltaTime_4 = value;
	}

	inline static int32_t get_offset_of_timeScaleCached_5() { return static_cast<int32_t>(offsetof(Time_t70920BA2C4C4BE707DAE9822ED553B006FFC0100, ___timeScaleCached_5)); }
	inline float get_timeScaleCached_5() const { return ___timeScaleCached_5; }
	inline float* get_address_of_timeScaleCached_5() { return &___timeScaleCached_5; }
	inline void set_timeScaleCached_5(float value)
	{
		___timeScaleCached_5 = value;
	}
};

struct Time_t70920BA2C4C4BE707DAE9822ED553B006FFC0100_StaticFields
{
public:
	// Pixeye.Time Pixeye.Time::Default
	Time_t70920BA2C4C4BE707DAE9822ED553B006FFC0100 * ___Default_1;

public:
	inline static int32_t get_offset_of_Default_1() { return static_cast<int32_t>(offsetof(Time_t70920BA2C4C4BE707DAE9822ED553B006FFC0100_StaticFields, ___Default_1)); }
	inline Time_t70920BA2C4C4BE707DAE9822ED553B006FFC0100 * get_Default_1() const { return ___Default_1; }
	inline Time_t70920BA2C4C4BE707DAE9822ED553B006FFC0100 ** get_address_of_Default_1() { return &___Default_1; }
	inline void set_Default_1(Time_t70920BA2C4C4BE707DAE9822ED553B006FFC0100 * value)
	{
		___Default_1 = value;
		Il2CppCodeGenWriteBarrier((&___Default_1), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // TIME_T70920BA2C4C4BE707DAE9822ED553B006FFC0100_H
#ifndef TIMER_T2BCD710CCCB0E9AB7ABF0D388965B97320333DDA_H
#define TIMER_T2BCD710CCCB0E9AB7ABF0D388965B97320333DDA_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Pixeye.Timer
struct  Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA  : public RuntimeObject
{
public:
	// System.Single Pixeye.Timer::timer
	float ___timer_1;
	// System.Single Pixeye.Timer::finishTime
	float ___finishTime_2;
	// System.Single Pixeye.Timer::timeScale
	float ___timeScale_3;
	// System.Action Pixeye.Timer::callBackAction
	Action_t591D2A86165F896B4B800BB5C25CE18672A55579 * ___callBackAction_4;
	// System.Boolean Pixeye.Timer::isAutoKill
	bool ___isAutoKill_5;
	// System.Boolean Pixeye.Timer::<IsRunning>k__BackingField
	bool ___U3CIsRunningU3Ek__BackingField_6;

public:
	inline static int32_t get_offset_of_timer_1() { return static_cast<int32_t>(offsetof(Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA, ___timer_1)); }
	inline float get_timer_1() const { return ___timer_1; }
	inline float* get_address_of_timer_1() { return &___timer_1; }
	inline void set_timer_1(float value)
	{
		___timer_1 = value;
	}

	inline static int32_t get_offset_of_finishTime_2() { return static_cast<int32_t>(offsetof(Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA, ___finishTime_2)); }
	inline float get_finishTime_2() const { return ___finishTime_2; }
	inline float* get_address_of_finishTime_2() { return &___finishTime_2; }
	inline void set_finishTime_2(float value)
	{
		___finishTime_2 = value;
	}

	inline static int32_t get_offset_of_timeScale_3() { return static_cast<int32_t>(offsetof(Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA, ___timeScale_3)); }
	inline float get_timeScale_3() const { return ___timeScale_3; }
	inline float* get_address_of_timeScale_3() { return &___timeScale_3; }
	inline void set_timeScale_3(float value)
	{
		___timeScale_3 = value;
	}

	inline static int32_t get_offset_of_callBackAction_4() { return static_cast<int32_t>(offsetof(Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA, ___callBackAction_4)); }
	inline Action_t591D2A86165F896B4B800BB5C25CE18672A55579 * get_callBackAction_4() const { return ___callBackAction_4; }
	inline Action_t591D2A86165F896B4B800BB5C25CE18672A55579 ** get_address_of_callBackAction_4() { return &___callBackAction_4; }
	inline void set_callBackAction_4(Action_t591D2A86165F896B4B800BB5C25CE18672A55579 * value)
	{
		___callBackAction_4 = value;
		Il2CppCodeGenWriteBarrier((&___callBackAction_4), value);
	}

	inline static int32_t get_offset_of_isAutoKill_5() { return static_cast<int32_t>(offsetof(Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA, ___isAutoKill_5)); }
	inline bool get_isAutoKill_5() const { return ___isAutoKill_5; }
	inline bool* get_address_of_isAutoKill_5() { return &___isAutoKill_5; }
	inline void set_isAutoKill_5(bool value)
	{
		___isAutoKill_5 = value;
	}

	inline static int32_t get_offset_of_U3CIsRunningU3Ek__BackingField_6() { return static_cast<int32_t>(offsetof(Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA, ___U3CIsRunningU3Ek__BackingField_6)); }
	inline bool get_U3CIsRunningU3Ek__BackingField_6() const { return ___U3CIsRunningU3Ek__BackingField_6; }
	inline bool* get_address_of_U3CIsRunningU3Ek__BackingField_6() { return &___U3CIsRunningU3Ek__BackingField_6; }
	inline void set_U3CIsRunningU3Ek__BackingField_6(bool value)
	{
		___U3CIsRunningU3Ek__BackingField_6 = value;
	}
};

struct Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA_StaticFields
{
public:
	// System.Collections.Generic.Dictionary`2<Pixeye.TimerKey,System.Collections.Generic.List`1<Pixeye.Timer>> Pixeye.Timer::cachedTimers
	Dictionary_2_t7A0A951F2ACBA1FC50C942EC15413C2011C7B386 * ___cachedTimers_0;

public:
	inline static int32_t get_offset_of_cachedTimers_0() { return static_cast<int32_t>(offsetof(Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA_StaticFields, ___cachedTimers_0)); }
	inline Dictionary_2_t7A0A951F2ACBA1FC50C942EC15413C2011C7B386 * get_cachedTimers_0() const { return ___cachedTimers_0; }
	inline Dictionary_2_t7A0A951F2ACBA1FC50C942EC15413C2011C7B386 ** get_address_of_cachedTimers_0() { return &___cachedTimers_0; }
	inline void set_cachedTimers_0(Dictionary_2_t7A0A951F2ACBA1FC50C942EC15413C2011C7B386 * value)
	{
		___cachedTimers_0 = value;
		Il2CppCodeGenWriteBarrier((&___cachedTimers_0), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // TIMER_T2BCD710CCCB0E9AB7ABF0D388965B97320333DDA_H
struct Il2CppArrayBounds;
#ifndef RUNTIMEARRAY_H
#define RUNTIMEARRAY_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Array

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // RUNTIMEARRAY_H
#ifndef ARRAYTRAVERSE_TD07A6D4E93DB7941CE934AFF9F006788173C70A6_H
#define ARRAYTRAVERSE_TD07A6D4E93DB7941CE934AFF9F006788173C70A6_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.ArrayTraverse
struct  ArrayTraverse_tD07A6D4E93DB7941CE934AFF9F006788173C70A6  : public RuntimeObject
{
public:
	// System.Int32[] System.ArrayTraverse::Position
	Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* ___Position_0;
	// System.Int32[] System.ArrayTraverse::maxLengths
	Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* ___maxLengths_1;

public:
	inline static int32_t get_offset_of_Position_0() { return static_cast<int32_t>(offsetof(ArrayTraverse_tD07A6D4E93DB7941CE934AFF9F006788173C70A6, ___Position_0)); }
	inline Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* get_Position_0() const { return ___Position_0; }
	inline Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83** get_address_of_Position_0() { return &___Position_0; }
	inline void set_Position_0(Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* value)
	{
		___Position_0 = value;
		Il2CppCodeGenWriteBarrier((&___Position_0), value);
	}

	inline static int32_t get_offset_of_maxLengths_1() { return static_cast<int32_t>(offsetof(ArrayTraverse_tD07A6D4E93DB7941CE934AFF9F006788173C70A6, ___maxLengths_1)); }
	inline Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* get_maxLengths_1() const { return ___maxLengths_1; }
	inline Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83** get_address_of_maxLengths_1() { return &___maxLengths_1; }
	inline void set_maxLengths_1(Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* value)
	{
		___maxLengths_1 = value;
		Il2CppCodeGenWriteBarrier((&___maxLengths_1), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // ARRAYTRAVERSE_TD07A6D4E93DB7941CE934AFF9F006788173C70A6_H
#ifndef ATTRIBUTE_TF048C13FB3C8CFCC53F82290E4A3F621089F9A74_H
#define ATTRIBUTE_TF048C13FB3C8CFCC53F82290E4A3F621089F9A74_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Attribute
struct  Attribute_tF048C13FB3C8CFCC53F82290E4A3F621089F9A74  : public RuntimeObject
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // ATTRIBUTE_TF048C13FB3C8CFCC53F82290E4A3F621089F9A74_H
#ifndef DICTIONARY_2_T7A0A951F2ACBA1FC50C942EC15413C2011C7B386_H
#define DICTIONARY_2_T7A0A951F2ACBA1FC50C942EC15413C2011C7B386_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Collections.Generic.Dictionary`2<Pixeye.TimerKey,System.Collections.Generic.List`1<Pixeye.Timer>>
struct  Dictionary_2_t7A0A951F2ACBA1FC50C942EC15413C2011C7B386  : public RuntimeObject
{
public:
	// System.Int32[] System.Collections.Generic.Dictionary`2::buckets
	Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* ___buckets_0;
	// System.Collections.Generic.Dictionary`2_Entry<TKey,TValue>[] System.Collections.Generic.Dictionary`2::entries
	EntryU5BU5D_tB0C8C9FE1F0A5B27427A59AFC22D4465A72BED18* ___entries_1;
	// System.Int32 System.Collections.Generic.Dictionary`2::count
	int32_t ___count_2;
	// System.Int32 System.Collections.Generic.Dictionary`2::version
	int32_t ___version_3;
	// System.Int32 System.Collections.Generic.Dictionary`2::freeList
	int32_t ___freeList_4;
	// System.Int32 System.Collections.Generic.Dictionary`2::freeCount
	int32_t ___freeCount_5;
	// System.Collections.Generic.IEqualityComparer`1<TKey> System.Collections.Generic.Dictionary`2::comparer
	RuntimeObject* ___comparer_6;
	// System.Collections.Generic.Dictionary`2_KeyCollection<TKey,TValue> System.Collections.Generic.Dictionary`2::keys
	KeyCollection_t6784E9AE7A67E960F75FC3EAA50CC9E88D32842F * ___keys_7;
	// System.Collections.Generic.Dictionary`2_ValueCollection<TKey,TValue> System.Collections.Generic.Dictionary`2::values
	ValueCollection_tA9AA0526554037B0A9C58CC2785792BE193E4BDD * ___values_8;
	// System.Object System.Collections.Generic.Dictionary`2::_syncRoot
	RuntimeObject * ____syncRoot_9;

public:
	inline static int32_t get_offset_of_buckets_0() { return static_cast<int32_t>(offsetof(Dictionary_2_t7A0A951F2ACBA1FC50C942EC15413C2011C7B386, ___buckets_0)); }
	inline Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* get_buckets_0() const { return ___buckets_0; }
	inline Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83** get_address_of_buckets_0() { return &___buckets_0; }
	inline void set_buckets_0(Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* value)
	{
		___buckets_0 = value;
		Il2CppCodeGenWriteBarrier((&___buckets_0), value);
	}

	inline static int32_t get_offset_of_entries_1() { return static_cast<int32_t>(offsetof(Dictionary_2_t7A0A951F2ACBA1FC50C942EC15413C2011C7B386, ___entries_1)); }
	inline EntryU5BU5D_tB0C8C9FE1F0A5B27427A59AFC22D4465A72BED18* get_entries_1() const { return ___entries_1; }
	inline EntryU5BU5D_tB0C8C9FE1F0A5B27427A59AFC22D4465A72BED18** get_address_of_entries_1() { return &___entries_1; }
	inline void set_entries_1(EntryU5BU5D_tB0C8C9FE1F0A5B27427A59AFC22D4465A72BED18* value)
	{
		___entries_1 = value;
		Il2CppCodeGenWriteBarrier((&___entries_1), value);
	}

	inline static int32_t get_offset_of_count_2() { return static_cast<int32_t>(offsetof(Dictionary_2_t7A0A951F2ACBA1FC50C942EC15413C2011C7B386, ___count_2)); }
	inline int32_t get_count_2() const { return ___count_2; }
	inline int32_t* get_address_of_count_2() { return &___count_2; }
	inline void set_count_2(int32_t value)
	{
		___count_2 = value;
	}

	inline static int32_t get_offset_of_version_3() { return static_cast<int32_t>(offsetof(Dictionary_2_t7A0A951F2ACBA1FC50C942EC15413C2011C7B386, ___version_3)); }
	inline int32_t get_version_3() const { return ___version_3; }
	inline int32_t* get_address_of_version_3() { return &___version_3; }
	inline void set_version_3(int32_t value)
	{
		___version_3 = value;
	}

	inline static int32_t get_offset_of_freeList_4() { return static_cast<int32_t>(offsetof(Dictionary_2_t7A0A951F2ACBA1FC50C942EC15413C2011C7B386, ___freeList_4)); }
	inline int32_t get_freeList_4() const { return ___freeList_4; }
	inline int32_t* get_address_of_freeList_4() { return &___freeList_4; }
	inline void set_freeList_4(int32_t value)
	{
		___freeList_4 = value;
	}

	inline static int32_t get_offset_of_freeCount_5() { return static_cast<int32_t>(offsetof(Dictionary_2_t7A0A951F2ACBA1FC50C942EC15413C2011C7B386, ___freeCount_5)); }
	inline int32_t get_freeCount_5() const { return ___freeCount_5; }
	inline int32_t* get_address_of_freeCount_5() { return &___freeCount_5; }
	inline void set_freeCount_5(int32_t value)
	{
		___freeCount_5 = value;
	}

	inline static int32_t get_offset_of_comparer_6() { return static_cast<int32_t>(offsetof(Dictionary_2_t7A0A951F2ACBA1FC50C942EC15413C2011C7B386, ___comparer_6)); }
	inline RuntimeObject* get_comparer_6() const { return ___comparer_6; }
	inline RuntimeObject** get_address_of_comparer_6() { return &___comparer_6; }
	inline void set_comparer_6(RuntimeObject* value)
	{
		___comparer_6 = value;
		Il2CppCodeGenWriteBarrier((&___comparer_6), value);
	}

	inline static int32_t get_offset_of_keys_7() { return static_cast<int32_t>(offsetof(Dictionary_2_t7A0A951F2ACBA1FC50C942EC15413C2011C7B386, ___keys_7)); }
	inline KeyCollection_t6784E9AE7A67E960F75FC3EAA50CC9E88D32842F * get_keys_7() const { return ___keys_7; }
	inline KeyCollection_t6784E9AE7A67E960F75FC3EAA50CC9E88D32842F ** get_address_of_keys_7() { return &___keys_7; }
	inline void set_keys_7(KeyCollection_t6784E9AE7A67E960F75FC3EAA50CC9E88D32842F * value)
	{
		___keys_7 = value;
		Il2CppCodeGenWriteBarrier((&___keys_7), value);
	}

	inline static int32_t get_offset_of_values_8() { return static_cast<int32_t>(offsetof(Dictionary_2_t7A0A951F2ACBA1FC50C942EC15413C2011C7B386, ___values_8)); }
	inline ValueCollection_tA9AA0526554037B0A9C58CC2785792BE193E4BDD * get_values_8() const { return ___values_8; }
	inline ValueCollection_tA9AA0526554037B0A9C58CC2785792BE193E4BDD ** get_address_of_values_8() { return &___values_8; }
	inline void set_values_8(ValueCollection_tA9AA0526554037B0A9C58CC2785792BE193E4BDD * value)
	{
		___values_8 = value;
		Il2CppCodeGenWriteBarrier((&___values_8), value);
	}

	inline static int32_t get_offset_of__syncRoot_9() { return static_cast<int32_t>(offsetof(Dictionary_2_t7A0A951F2ACBA1FC50C942EC15413C2011C7B386, ____syncRoot_9)); }
	inline RuntimeObject * get__syncRoot_9() const { return ____syncRoot_9; }
	inline RuntimeObject ** get_address_of__syncRoot_9() { return &____syncRoot_9; }
	inline void set__syncRoot_9(RuntimeObject * value)
	{
		____syncRoot_9 = value;
		Il2CppCodeGenWriteBarrier((&____syncRoot_9), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // DICTIONARY_2_T7A0A951F2ACBA1FC50C942EC15413C2011C7B386_H
#ifndef DICTIONARY_2_T683E72069DD61C3D055254F6694A3E646C6B3622_H
#define DICTIONARY_2_T683E72069DD61C3D055254F6694A3E646C6B3622_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Collections.Generic.Dictionary`2<System.Int32,Pixeye.Storage>
struct  Dictionary_2_t683E72069DD61C3D055254F6694A3E646C6B3622  : public RuntimeObject
{
public:
	// System.Int32[] System.Collections.Generic.Dictionary`2::buckets
	Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* ___buckets_0;
	// System.Collections.Generic.Dictionary`2_Entry<TKey,TValue>[] System.Collections.Generic.Dictionary`2::entries
	EntryU5BU5D_t79BA14538CFA03A748F0E12FD93034FD4DB4ACF2* ___entries_1;
	// System.Int32 System.Collections.Generic.Dictionary`2::count
	int32_t ___count_2;
	// System.Int32 System.Collections.Generic.Dictionary`2::version
	int32_t ___version_3;
	// System.Int32 System.Collections.Generic.Dictionary`2::freeList
	int32_t ___freeList_4;
	// System.Int32 System.Collections.Generic.Dictionary`2::freeCount
	int32_t ___freeCount_5;
	// System.Collections.Generic.IEqualityComparer`1<TKey> System.Collections.Generic.Dictionary`2::comparer
	RuntimeObject* ___comparer_6;
	// System.Collections.Generic.Dictionary`2_KeyCollection<TKey,TValue> System.Collections.Generic.Dictionary`2::keys
	KeyCollection_t0FE37259FA097872B8DB53CFF4EEF0DF428EF876 * ___keys_7;
	// System.Collections.Generic.Dictionary`2_ValueCollection<TKey,TValue> System.Collections.Generic.Dictionary`2::values
	ValueCollection_t8789D0E84F8039FC237ED53BA2308B18E14F6AD1 * ___values_8;
	// System.Object System.Collections.Generic.Dictionary`2::_syncRoot
	RuntimeObject * ____syncRoot_9;

public:
	inline static int32_t get_offset_of_buckets_0() { return static_cast<int32_t>(offsetof(Dictionary_2_t683E72069DD61C3D055254F6694A3E646C6B3622, ___buckets_0)); }
	inline Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* get_buckets_0() const { return ___buckets_0; }
	inline Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83** get_address_of_buckets_0() { return &___buckets_0; }
	inline void set_buckets_0(Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* value)
	{
		___buckets_0 = value;
		Il2CppCodeGenWriteBarrier((&___buckets_0), value);
	}

	inline static int32_t get_offset_of_entries_1() { return static_cast<int32_t>(offsetof(Dictionary_2_t683E72069DD61C3D055254F6694A3E646C6B3622, ___entries_1)); }
	inline EntryU5BU5D_t79BA14538CFA03A748F0E12FD93034FD4DB4ACF2* get_entries_1() const { return ___entries_1; }
	inline EntryU5BU5D_t79BA14538CFA03A748F0E12FD93034FD4DB4ACF2** get_address_of_entries_1() { return &___entries_1; }
	inline void set_entries_1(EntryU5BU5D_t79BA14538CFA03A748F0E12FD93034FD4DB4ACF2* value)
	{
		___entries_1 = value;
		Il2CppCodeGenWriteBarrier((&___entries_1), value);
	}

	inline static int32_t get_offset_of_count_2() { return static_cast<int32_t>(offsetof(Dictionary_2_t683E72069DD61C3D055254F6694A3E646C6B3622, ___count_2)); }
	inline int32_t get_count_2() const { return ___count_2; }
	inline int32_t* get_address_of_count_2() { return &___count_2; }
	inline void set_count_2(int32_t value)
	{
		___count_2 = value;
	}

	inline static int32_t get_offset_of_version_3() { return static_cast<int32_t>(offsetof(Dictionary_2_t683E72069DD61C3D055254F6694A3E646C6B3622, ___version_3)); }
	inline int32_t get_version_3() const { return ___version_3; }
	inline int32_t* get_address_of_version_3() { return &___version_3; }
	inline void set_version_3(int32_t value)
	{
		___version_3 = value;
	}

	inline static int32_t get_offset_of_freeList_4() { return static_cast<int32_t>(offsetof(Dictionary_2_t683E72069DD61C3D055254F6694A3E646C6B3622, ___freeList_4)); }
	inline int32_t get_freeList_4() const { return ___freeList_4; }
	inline int32_t* get_address_of_freeList_4() { return &___freeList_4; }
	inline void set_freeList_4(int32_t value)
	{
		___freeList_4 = value;
	}

	inline static int32_t get_offset_of_freeCount_5() { return static_cast<int32_t>(offsetof(Dictionary_2_t683E72069DD61C3D055254F6694A3E646C6B3622, ___freeCount_5)); }
	inline int32_t get_freeCount_5() const { return ___freeCount_5; }
	inline int32_t* get_address_of_freeCount_5() { return &___freeCount_5; }
	inline void set_freeCount_5(int32_t value)
	{
		___freeCount_5 = value;
	}

	inline static int32_t get_offset_of_comparer_6() { return static_cast<int32_t>(offsetof(Dictionary_2_t683E72069DD61C3D055254F6694A3E646C6B3622, ___comparer_6)); }
	inline RuntimeObject* get_comparer_6() const { return ___comparer_6; }
	inline RuntimeObject** get_address_of_comparer_6() { return &___comparer_6; }
	inline void set_comparer_6(RuntimeObject* value)
	{
		___comparer_6 = value;
		Il2CppCodeGenWriteBarrier((&___comparer_6), value);
	}

	inline static int32_t get_offset_of_keys_7() { return static_cast<int32_t>(offsetof(Dictionary_2_t683E72069DD61C3D055254F6694A3E646C6B3622, ___keys_7)); }
	inline KeyCollection_t0FE37259FA097872B8DB53CFF4EEF0DF428EF876 * get_keys_7() const { return ___keys_7; }
	inline KeyCollection_t0FE37259FA097872B8DB53CFF4EEF0DF428EF876 ** get_address_of_keys_7() { return &___keys_7; }
	inline void set_keys_7(KeyCollection_t0FE37259FA097872B8DB53CFF4EEF0DF428EF876 * value)
	{
		___keys_7 = value;
		Il2CppCodeGenWriteBarrier((&___keys_7), value);
	}

	inline static int32_t get_offset_of_values_8() { return static_cast<int32_t>(offsetof(Dictionary_2_t683E72069DD61C3D055254F6694A3E646C6B3622, ___values_8)); }
	inline ValueCollection_t8789D0E84F8039FC237ED53BA2308B18E14F6AD1 * get_values_8() const { return ___values_8; }
	inline ValueCollection_t8789D0E84F8039FC237ED53BA2308B18E14F6AD1 ** get_address_of_values_8() { return &___values_8; }
	inline void set_values_8(ValueCollection_t8789D0E84F8039FC237ED53BA2308B18E14F6AD1 * value)
	{
		___values_8 = value;
		Il2CppCodeGenWriteBarrier((&___values_8), value);
	}

	inline static int32_t get_offset_of__syncRoot_9() { return static_cast<int32_t>(offsetof(Dictionary_2_t683E72069DD61C3D055254F6694A3E646C6B3622, ____syncRoot_9)); }
	inline RuntimeObject * get__syncRoot_9() const { return ____syncRoot_9; }
	inline RuntimeObject ** get_address_of__syncRoot_9() { return &____syncRoot_9; }
	inline void set__syncRoot_9(RuntimeObject * value)
	{
		____syncRoot_9 = value;
		Il2CppCodeGenWriteBarrier((&____syncRoot_9), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // DICTIONARY_2_T683E72069DD61C3D055254F6694A3E646C6B3622_H
#ifndef DICTIONARY_2_T62CC83140A4EC1BB76940D6FD31E9B3B8417C850_H
#define DICTIONARY_2_T62CC83140A4EC1BB76940D6FD31E9B3B8417C850_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<Pixeye.GroupBase>>
struct  Dictionary_2_t62CC83140A4EC1BB76940D6FD31E9B3B8417C850  : public RuntimeObject
{
public:
	// System.Int32[] System.Collections.Generic.Dictionary`2::buckets
	Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* ___buckets_0;
	// System.Collections.Generic.Dictionary`2_Entry<TKey,TValue>[] System.Collections.Generic.Dictionary`2::entries
	EntryU5BU5D_t85917DE4472FB88832B93AB341F781081FCF46F5* ___entries_1;
	// System.Int32 System.Collections.Generic.Dictionary`2::count
	int32_t ___count_2;
	// System.Int32 System.Collections.Generic.Dictionary`2::version
	int32_t ___version_3;
	// System.Int32 System.Collections.Generic.Dictionary`2::freeList
	int32_t ___freeList_4;
	// System.Int32 System.Collections.Generic.Dictionary`2::freeCount
	int32_t ___freeCount_5;
	// System.Collections.Generic.IEqualityComparer`1<TKey> System.Collections.Generic.Dictionary`2::comparer
	RuntimeObject* ___comparer_6;
	// System.Collections.Generic.Dictionary`2_KeyCollection<TKey,TValue> System.Collections.Generic.Dictionary`2::keys
	KeyCollection_tF77AE029A67C3A4099451E549B1C92D88BD5B4CF * ___keys_7;
	// System.Collections.Generic.Dictionary`2_ValueCollection<TKey,TValue> System.Collections.Generic.Dictionary`2::values
	ValueCollection_t56068C373977277F9A424F44602F32EF1E0BB391 * ___values_8;
	// System.Object System.Collections.Generic.Dictionary`2::_syncRoot
	RuntimeObject * ____syncRoot_9;

public:
	inline static int32_t get_offset_of_buckets_0() { return static_cast<int32_t>(offsetof(Dictionary_2_t62CC83140A4EC1BB76940D6FD31E9B3B8417C850, ___buckets_0)); }
	inline Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* get_buckets_0() const { return ___buckets_0; }
	inline Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83** get_address_of_buckets_0() { return &___buckets_0; }
	inline void set_buckets_0(Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* value)
	{
		___buckets_0 = value;
		Il2CppCodeGenWriteBarrier((&___buckets_0), value);
	}

	inline static int32_t get_offset_of_entries_1() { return static_cast<int32_t>(offsetof(Dictionary_2_t62CC83140A4EC1BB76940D6FD31E9B3B8417C850, ___entries_1)); }
	inline EntryU5BU5D_t85917DE4472FB88832B93AB341F781081FCF46F5* get_entries_1() const { return ___entries_1; }
	inline EntryU5BU5D_t85917DE4472FB88832B93AB341F781081FCF46F5** get_address_of_entries_1() { return &___entries_1; }
	inline void set_entries_1(EntryU5BU5D_t85917DE4472FB88832B93AB341F781081FCF46F5* value)
	{
		___entries_1 = value;
		Il2CppCodeGenWriteBarrier((&___entries_1), value);
	}

	inline static int32_t get_offset_of_count_2() { return static_cast<int32_t>(offsetof(Dictionary_2_t62CC83140A4EC1BB76940D6FD31E9B3B8417C850, ___count_2)); }
	inline int32_t get_count_2() const { return ___count_2; }
	inline int32_t* get_address_of_count_2() { return &___count_2; }
	inline void set_count_2(int32_t value)
	{
		___count_2 = value;
	}

	inline static int32_t get_offset_of_version_3() { return static_cast<int32_t>(offsetof(Dictionary_2_t62CC83140A4EC1BB76940D6FD31E9B3B8417C850, ___version_3)); }
	inline int32_t get_version_3() const { return ___version_3; }
	inline int32_t* get_address_of_version_3() { return &___version_3; }
	inline void set_version_3(int32_t value)
	{
		___version_3 = value;
	}

	inline static int32_t get_offset_of_freeList_4() { return static_cast<int32_t>(offsetof(Dictionary_2_t62CC83140A4EC1BB76940D6FD31E9B3B8417C850, ___freeList_4)); }
	inline int32_t get_freeList_4() const { return ___freeList_4; }
	inline int32_t* get_address_of_freeList_4() { return &___freeList_4; }
	inline void set_freeList_4(int32_t value)
	{
		___freeList_4 = value;
	}

	inline static int32_t get_offset_of_freeCount_5() { return static_cast<int32_t>(offsetof(Dictionary_2_t62CC83140A4EC1BB76940D6FD31E9B3B8417C850, ___freeCount_5)); }
	inline int32_t get_freeCount_5() const { return ___freeCount_5; }
	inline int32_t* get_address_of_freeCount_5() { return &___freeCount_5; }
	inline void set_freeCount_5(int32_t value)
	{
		___freeCount_5 = value;
	}

	inline static int32_t get_offset_of_comparer_6() { return static_cast<int32_t>(offsetof(Dictionary_2_t62CC83140A4EC1BB76940D6FD31E9B3B8417C850, ___comparer_6)); }
	inline RuntimeObject* get_comparer_6() const { return ___comparer_6; }
	inline RuntimeObject** get_address_of_comparer_6() { return &___comparer_6; }
	inline void set_comparer_6(RuntimeObject* value)
	{
		___comparer_6 = value;
		Il2CppCodeGenWriteBarrier((&___comparer_6), value);
	}

	inline static int32_t get_offset_of_keys_7() { return static_cast<int32_t>(offsetof(Dictionary_2_t62CC83140A4EC1BB76940D6FD31E9B3B8417C850, ___keys_7)); }
	inline KeyCollection_tF77AE029A67C3A4099451E549B1C92D88BD5B4CF * get_keys_7() const { return ___keys_7; }
	inline KeyCollection_tF77AE029A67C3A4099451E549B1C92D88BD5B4CF ** get_address_of_keys_7() { return &___keys_7; }
	inline void set_keys_7(KeyCollection_tF77AE029A67C3A4099451E549B1C92D88BD5B4CF * value)
	{
		___keys_7 = value;
		Il2CppCodeGenWriteBarrier((&___keys_7), value);
	}

	inline static int32_t get_offset_of_values_8() { return static_cast<int32_t>(offsetof(Dictionary_2_t62CC83140A4EC1BB76940D6FD31E9B3B8417C850, ___values_8)); }
	inline ValueCollection_t56068C373977277F9A424F44602F32EF1E0BB391 * get_values_8() const { return ___values_8; }
	inline ValueCollection_t56068C373977277F9A424F44602F32EF1E0BB391 ** get_address_of_values_8() { return &___values_8; }
	inline void set_values_8(ValueCollection_t56068C373977277F9A424F44602F32EF1E0BB391 * value)
	{
		___values_8 = value;
		Il2CppCodeGenWriteBarrier((&___values_8), value);
	}

	inline static int32_t get_offset_of__syncRoot_9() { return static_cast<int32_t>(offsetof(Dictionary_2_t62CC83140A4EC1BB76940D6FD31E9B3B8417C850, ____syncRoot_9)); }
	inline RuntimeObject * get__syncRoot_9() const { return ____syncRoot_9; }
	inline RuntimeObject ** get_address_of__syncRoot_9() { return &____syncRoot_9; }
	inline void set__syncRoot_9(RuntimeObject * value)
	{
		____syncRoot_9 = value;
		Il2CppCodeGenWriteBarrier((&____syncRoot_9), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // DICTIONARY_2_T62CC83140A4EC1BB76940D6FD31E9B3B8417C850_H
#ifndef DICTIONARY_2_TFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8_H
#define DICTIONARY_2_TFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Collections.Generic.Dictionary`2<System.Int32,System.Int32>
struct  Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8  : public RuntimeObject
{
public:
	// System.Int32[] System.Collections.Generic.Dictionary`2::buckets
	Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* ___buckets_0;
	// System.Collections.Generic.Dictionary`2_Entry<TKey,TValue>[] System.Collections.Generic.Dictionary`2::entries
	EntryU5BU5D_t771BA166F0450465AFAF66A1700FD2795A4BA1F9* ___entries_1;
	// System.Int32 System.Collections.Generic.Dictionary`2::count
	int32_t ___count_2;
	// System.Int32 System.Collections.Generic.Dictionary`2::version
	int32_t ___version_3;
	// System.Int32 System.Collections.Generic.Dictionary`2::freeList
	int32_t ___freeList_4;
	// System.Int32 System.Collections.Generic.Dictionary`2::freeCount
	int32_t ___freeCount_5;
	// System.Collections.Generic.IEqualityComparer`1<TKey> System.Collections.Generic.Dictionary`2::comparer
	RuntimeObject* ___comparer_6;
	// System.Collections.Generic.Dictionary`2_KeyCollection<TKey,TValue> System.Collections.Generic.Dictionary`2::keys
	KeyCollection_t07175316A062A97612A0750CD9FCFAC6C13270FA * ___keys_7;
	// System.Collections.Generic.Dictionary`2_ValueCollection<TKey,TValue> System.Collections.Generic.Dictionary`2::values
	ValueCollection_t4B03F142CD9DE8CA06D9CD246A5403B64C000D60 * ___values_8;
	// System.Object System.Collections.Generic.Dictionary`2::_syncRoot
	RuntimeObject * ____syncRoot_9;

public:
	inline static int32_t get_offset_of_buckets_0() { return static_cast<int32_t>(offsetof(Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8, ___buckets_0)); }
	inline Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* get_buckets_0() const { return ___buckets_0; }
	inline Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83** get_address_of_buckets_0() { return &___buckets_0; }
	inline void set_buckets_0(Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* value)
	{
		___buckets_0 = value;
		Il2CppCodeGenWriteBarrier((&___buckets_0), value);
	}

	inline static int32_t get_offset_of_entries_1() { return static_cast<int32_t>(offsetof(Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8, ___entries_1)); }
	inline EntryU5BU5D_t771BA166F0450465AFAF66A1700FD2795A4BA1F9* get_entries_1() const { return ___entries_1; }
	inline EntryU5BU5D_t771BA166F0450465AFAF66A1700FD2795A4BA1F9** get_address_of_entries_1() { return &___entries_1; }
	inline void set_entries_1(EntryU5BU5D_t771BA166F0450465AFAF66A1700FD2795A4BA1F9* value)
	{
		___entries_1 = value;
		Il2CppCodeGenWriteBarrier((&___entries_1), value);
	}

	inline static int32_t get_offset_of_count_2() { return static_cast<int32_t>(offsetof(Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8, ___count_2)); }
	inline int32_t get_count_2() const { return ___count_2; }
	inline int32_t* get_address_of_count_2() { return &___count_2; }
	inline void set_count_2(int32_t value)
	{
		___count_2 = value;
	}

	inline static int32_t get_offset_of_version_3() { return static_cast<int32_t>(offsetof(Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8, ___version_3)); }
	inline int32_t get_version_3() const { return ___version_3; }
	inline int32_t* get_address_of_version_3() { return &___version_3; }
	inline void set_version_3(int32_t value)
	{
		___version_3 = value;
	}

	inline static int32_t get_offset_of_freeList_4() { return static_cast<int32_t>(offsetof(Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8, ___freeList_4)); }
	inline int32_t get_freeList_4() const { return ___freeList_4; }
	inline int32_t* get_address_of_freeList_4() { return &___freeList_4; }
	inline void set_freeList_4(int32_t value)
	{
		___freeList_4 = value;
	}

	inline static int32_t get_offset_of_freeCount_5() { return static_cast<int32_t>(offsetof(Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8, ___freeCount_5)); }
	inline int32_t get_freeCount_5() const { return ___freeCount_5; }
	inline int32_t* get_address_of_freeCount_5() { return &___freeCount_5; }
	inline void set_freeCount_5(int32_t value)
	{
		___freeCount_5 = value;
	}

	inline static int32_t get_offset_of_comparer_6() { return static_cast<int32_t>(offsetof(Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8, ___comparer_6)); }
	inline RuntimeObject* get_comparer_6() const { return ___comparer_6; }
	inline RuntimeObject** get_address_of_comparer_6() { return &___comparer_6; }
	inline void set_comparer_6(RuntimeObject* value)
	{
		___comparer_6 = value;
		Il2CppCodeGenWriteBarrier((&___comparer_6), value);
	}

	inline static int32_t get_offset_of_keys_7() { return static_cast<int32_t>(offsetof(Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8, ___keys_7)); }
	inline KeyCollection_t07175316A062A97612A0750CD9FCFAC6C13270FA * get_keys_7() const { return ___keys_7; }
	inline KeyCollection_t07175316A062A97612A0750CD9FCFAC6C13270FA ** get_address_of_keys_7() { return &___keys_7; }
	inline void set_keys_7(KeyCollection_t07175316A062A97612A0750CD9FCFAC6C13270FA * value)
	{
		___keys_7 = value;
		Il2CppCodeGenWriteBarrier((&___keys_7), value);
	}

	inline static int32_t get_offset_of_values_8() { return static_cast<int32_t>(offsetof(Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8, ___values_8)); }
	inline ValueCollection_t4B03F142CD9DE8CA06D9CD246A5403B64C000D60 * get_values_8() const { return ___values_8; }
	inline ValueCollection_t4B03F142CD9DE8CA06D9CD246A5403B64C000D60 ** get_address_of_values_8() { return &___values_8; }
	inline void set_values_8(ValueCollection_t4B03F142CD9DE8CA06D9CD246A5403B64C000D60 * value)
	{
		___values_8 = value;
		Il2CppCodeGenWriteBarrier((&___values_8), value);
	}

	inline static int32_t get_offset_of__syncRoot_9() { return static_cast<int32_t>(offsetof(Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8, ____syncRoot_9)); }
	inline RuntimeObject * get__syncRoot_9() const { return ____syncRoot_9; }
	inline RuntimeObject ** get_address_of__syncRoot_9() { return &____syncRoot_9; }
	inline void set__syncRoot_9(RuntimeObject * value)
	{
		____syncRoot_9 = value;
		Il2CppCodeGenWriteBarrier((&____syncRoot_9), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // DICTIONARY_2_TFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8_H
#ifndef DICTIONARY_2_T03608389BB57475AA3F4B2B79D176A27807BC884_H
#define DICTIONARY_2_T03608389BB57475AA3F4B2B79D176A27807BC884_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Collections.Generic.Dictionary`2<System.Int32,System.Object>
struct  Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884  : public RuntimeObject
{
public:
	// System.Int32[] System.Collections.Generic.Dictionary`2::buckets
	Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* ___buckets_0;
	// System.Collections.Generic.Dictionary`2_Entry<TKey,TValue>[] System.Collections.Generic.Dictionary`2::entries
	EntryU5BU5D_t929130352D902B0F51DF5EAB0EB281F860E35FFC* ___entries_1;
	// System.Int32 System.Collections.Generic.Dictionary`2::count
	int32_t ___count_2;
	// System.Int32 System.Collections.Generic.Dictionary`2::version
	int32_t ___version_3;
	// System.Int32 System.Collections.Generic.Dictionary`2::freeList
	int32_t ___freeList_4;
	// System.Int32 System.Collections.Generic.Dictionary`2::freeCount
	int32_t ___freeCount_5;
	// System.Collections.Generic.IEqualityComparer`1<TKey> System.Collections.Generic.Dictionary`2::comparer
	RuntimeObject* ___comparer_6;
	// System.Collections.Generic.Dictionary`2_KeyCollection<TKey,TValue> System.Collections.Generic.Dictionary`2::keys
	KeyCollection_t247C6587A2D9DAFEFD3863012E19D5BE565D738E * ___keys_7;
	// System.Collections.Generic.Dictionary`2_ValueCollection<TKey,TValue> System.Collections.Generic.Dictionary`2::values
	ValueCollection_t4F0931CDBEC78250B6593DE976E46E2179187225 * ___values_8;
	// System.Object System.Collections.Generic.Dictionary`2::_syncRoot
	RuntimeObject * ____syncRoot_9;

public:
	inline static int32_t get_offset_of_buckets_0() { return static_cast<int32_t>(offsetof(Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884, ___buckets_0)); }
	inline Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* get_buckets_0() const { return ___buckets_0; }
	inline Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83** get_address_of_buckets_0() { return &___buckets_0; }
	inline void set_buckets_0(Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* value)
	{
		___buckets_0 = value;
		Il2CppCodeGenWriteBarrier((&___buckets_0), value);
	}

	inline static int32_t get_offset_of_entries_1() { return static_cast<int32_t>(offsetof(Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884, ___entries_1)); }
	inline EntryU5BU5D_t929130352D902B0F51DF5EAB0EB281F860E35FFC* get_entries_1() const { return ___entries_1; }
	inline EntryU5BU5D_t929130352D902B0F51DF5EAB0EB281F860E35FFC** get_address_of_entries_1() { return &___entries_1; }
	inline void set_entries_1(EntryU5BU5D_t929130352D902B0F51DF5EAB0EB281F860E35FFC* value)
	{
		___entries_1 = value;
		Il2CppCodeGenWriteBarrier((&___entries_1), value);
	}

	inline static int32_t get_offset_of_count_2() { return static_cast<int32_t>(offsetof(Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884, ___count_2)); }
	inline int32_t get_count_2() const { return ___count_2; }
	inline int32_t* get_address_of_count_2() { return &___count_2; }
	inline void set_count_2(int32_t value)
	{
		___count_2 = value;
	}

	inline static int32_t get_offset_of_version_3() { return static_cast<int32_t>(offsetof(Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884, ___version_3)); }
	inline int32_t get_version_3() const { return ___version_3; }
	inline int32_t* get_address_of_version_3() { return &___version_3; }
	inline void set_version_3(int32_t value)
	{
		___version_3 = value;
	}

	inline static int32_t get_offset_of_freeList_4() { return static_cast<int32_t>(offsetof(Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884, ___freeList_4)); }
	inline int32_t get_freeList_4() const { return ___freeList_4; }
	inline int32_t* get_address_of_freeList_4() { return &___freeList_4; }
	inline void set_freeList_4(int32_t value)
	{
		___freeList_4 = value;
	}

	inline static int32_t get_offset_of_freeCount_5() { return static_cast<int32_t>(offsetof(Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884, ___freeCount_5)); }
	inline int32_t get_freeCount_5() const { return ___freeCount_5; }
	inline int32_t* get_address_of_freeCount_5() { return &___freeCount_5; }
	inline void set_freeCount_5(int32_t value)
	{
		___freeCount_5 = value;
	}

	inline static int32_t get_offset_of_comparer_6() { return static_cast<int32_t>(offsetof(Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884, ___comparer_6)); }
	inline RuntimeObject* get_comparer_6() const { return ___comparer_6; }
	inline RuntimeObject** get_address_of_comparer_6() { return &___comparer_6; }
	inline void set_comparer_6(RuntimeObject* value)
	{
		___comparer_6 = value;
		Il2CppCodeGenWriteBarrier((&___comparer_6), value);
	}

	inline static int32_t get_offset_of_keys_7() { return static_cast<int32_t>(offsetof(Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884, ___keys_7)); }
	inline KeyCollection_t247C6587A2D9DAFEFD3863012E19D5BE565D738E * get_keys_7() const { return ___keys_7; }
	inline KeyCollection_t247C6587A2D9DAFEFD3863012E19D5BE565D738E ** get_address_of_keys_7() { return &___keys_7; }
	inline void set_keys_7(KeyCollection_t247C6587A2D9DAFEFD3863012E19D5BE565D738E * value)
	{
		___keys_7 = value;
		Il2CppCodeGenWriteBarrier((&___keys_7), value);
	}

	inline static int32_t get_offset_of_values_8() { return static_cast<int32_t>(offsetof(Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884, ___values_8)); }
	inline ValueCollection_t4F0931CDBEC78250B6593DE976E46E2179187225 * get_values_8() const { return ___values_8; }
	inline ValueCollection_t4F0931CDBEC78250B6593DE976E46E2179187225 ** get_address_of_values_8() { return &___values_8; }
	inline void set_values_8(ValueCollection_t4F0931CDBEC78250B6593DE976E46E2179187225 * value)
	{
		___values_8 = value;
		Il2CppCodeGenWriteBarrier((&___values_8), value);
	}

	inline static int32_t get_offset_of__syncRoot_9() { return static_cast<int32_t>(offsetof(Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884, ____syncRoot_9)); }
	inline RuntimeObject * get__syncRoot_9() const { return ____syncRoot_9; }
	inline RuntimeObject ** get_address_of__syncRoot_9() { return &____syncRoot_9; }
	inline void set__syncRoot_9(RuntimeObject * value)
	{
		____syncRoot_9 = value;
		Il2CppCodeGenWriteBarrier((&____syncRoot_9), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // DICTIONARY_2_T03608389BB57475AA3F4B2B79D176A27807BC884_H
#ifndef DICTIONARY_2_T32F25F093828AA9F93CB11C2A2B4648FD62A09BA_H
#define DICTIONARY_2_T32F25F093828AA9F93CB11C2A2B4648FD62A09BA_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Collections.Generic.Dictionary`2<System.Object,System.Object>
struct  Dictionary_2_t32F25F093828AA9F93CB11C2A2B4648FD62A09BA  : public RuntimeObject
{
public:
	// System.Int32[] System.Collections.Generic.Dictionary`2::buckets
	Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* ___buckets_0;
	// System.Collections.Generic.Dictionary`2_Entry<TKey,TValue>[] System.Collections.Generic.Dictionary`2::entries
	EntryU5BU5D_t9EC04215E0A25794290249C0F6D7EA694596D2BE* ___entries_1;
	// System.Int32 System.Collections.Generic.Dictionary`2::count
	int32_t ___count_2;
	// System.Int32 System.Collections.Generic.Dictionary`2::version
	int32_t ___version_3;
	// System.Int32 System.Collections.Generic.Dictionary`2::freeList
	int32_t ___freeList_4;
	// System.Int32 System.Collections.Generic.Dictionary`2::freeCount
	int32_t ___freeCount_5;
	// System.Collections.Generic.IEqualityComparer`1<TKey> System.Collections.Generic.Dictionary`2::comparer
	RuntimeObject* ___comparer_6;
	// System.Collections.Generic.Dictionary`2_KeyCollection<TKey,TValue> System.Collections.Generic.Dictionary`2::keys
	KeyCollection_t0394DE2BA7C2C82605C6E9DEBB21A8C5C792E97C * ___keys_7;
	// System.Collections.Generic.Dictionary`2_ValueCollection<TKey,TValue> System.Collections.Generic.Dictionary`2::values
	ValueCollection_t0816666499CBD11E58E1E7C79A4EFC2AA47E08A2 * ___values_8;
	// System.Object System.Collections.Generic.Dictionary`2::_syncRoot
	RuntimeObject * ____syncRoot_9;

public:
	inline static int32_t get_offset_of_buckets_0() { return static_cast<int32_t>(offsetof(Dictionary_2_t32F25F093828AA9F93CB11C2A2B4648FD62A09BA, ___buckets_0)); }
	inline Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* get_buckets_0() const { return ___buckets_0; }
	inline Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83** get_address_of_buckets_0() { return &___buckets_0; }
	inline void set_buckets_0(Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* value)
	{
		___buckets_0 = value;
		Il2CppCodeGenWriteBarrier((&___buckets_0), value);
	}

	inline static int32_t get_offset_of_entries_1() { return static_cast<int32_t>(offsetof(Dictionary_2_t32F25F093828AA9F93CB11C2A2B4648FD62A09BA, ___entries_1)); }
	inline EntryU5BU5D_t9EC04215E0A25794290249C0F6D7EA694596D2BE* get_entries_1() const { return ___entries_1; }
	inline EntryU5BU5D_t9EC04215E0A25794290249C0F6D7EA694596D2BE** get_address_of_entries_1() { return &___entries_1; }
	inline void set_entries_1(EntryU5BU5D_t9EC04215E0A25794290249C0F6D7EA694596D2BE* value)
	{
		___entries_1 = value;
		Il2CppCodeGenWriteBarrier((&___entries_1), value);
	}

	inline static int32_t get_offset_of_count_2() { return static_cast<int32_t>(offsetof(Dictionary_2_t32F25F093828AA9F93CB11C2A2B4648FD62A09BA, ___count_2)); }
	inline int32_t get_count_2() const { return ___count_2; }
	inline int32_t* get_address_of_count_2() { return &___count_2; }
	inline void set_count_2(int32_t value)
	{
		___count_2 = value;
	}

	inline static int32_t get_offset_of_version_3() { return static_cast<int32_t>(offsetof(Dictionary_2_t32F25F093828AA9F93CB11C2A2B4648FD62A09BA, ___version_3)); }
	inline int32_t get_version_3() const { return ___version_3; }
	inline int32_t* get_address_of_version_3() { return &___version_3; }
	inline void set_version_3(int32_t value)
	{
		___version_3 = value;
	}

	inline static int32_t get_offset_of_freeList_4() { return static_cast<int32_t>(offsetof(Dictionary_2_t32F25F093828AA9F93CB11C2A2B4648FD62A09BA, ___freeList_4)); }
	inline int32_t get_freeList_4() const { return ___freeList_4; }
	inline int32_t* get_address_of_freeList_4() { return &___freeList_4; }
	inline void set_freeList_4(int32_t value)
	{
		___freeList_4 = value;
	}

	inline static int32_t get_offset_of_freeCount_5() { return static_cast<int32_t>(offsetof(Dictionary_2_t32F25F093828AA9F93CB11C2A2B4648FD62A09BA, ___freeCount_5)); }
	inline int32_t get_freeCount_5() const { return ___freeCount_5; }
	inline int32_t* get_address_of_freeCount_5() { return &___freeCount_5; }
	inline void set_freeCount_5(int32_t value)
	{
		___freeCount_5 = value;
	}

	inline static int32_t get_offset_of_comparer_6() { return static_cast<int32_t>(offsetof(Dictionary_2_t32F25F093828AA9F93CB11C2A2B4648FD62A09BA, ___comparer_6)); }
	inline RuntimeObject* get_comparer_6() const { return ___comparer_6; }
	inline RuntimeObject** get_address_of_comparer_6() { return &___comparer_6; }
	inline void set_comparer_6(RuntimeObject* value)
	{
		___comparer_6 = value;
		Il2CppCodeGenWriteBarrier((&___comparer_6), value);
	}

	inline static int32_t get_offset_of_keys_7() { return static_cast<int32_t>(offsetof(Dictionary_2_t32F25F093828AA9F93CB11C2A2B4648FD62A09BA, ___keys_7)); }
	inline KeyCollection_t0394DE2BA7C2C82605C6E9DEBB21A8C5C792E97C * get_keys_7() const { return ___keys_7; }
	inline KeyCollection_t0394DE2BA7C2C82605C6E9DEBB21A8C5C792E97C ** get_address_of_keys_7() { return &___keys_7; }
	inline void set_keys_7(KeyCollection_t0394DE2BA7C2C82605C6E9DEBB21A8C5C792E97C * value)
	{
		___keys_7 = value;
		Il2CppCodeGenWriteBarrier((&___keys_7), value);
	}

	inline static int32_t get_offset_of_values_8() { return static_cast<int32_t>(offsetof(Dictionary_2_t32F25F093828AA9F93CB11C2A2B4648FD62A09BA, ___values_8)); }
	inline ValueCollection_t0816666499CBD11E58E1E7C79A4EFC2AA47E08A2 * get_values_8() const { return ___values_8; }
	inline ValueCollection_t0816666499CBD11E58E1E7C79A4EFC2AA47E08A2 ** get_address_of_values_8() { return &___values_8; }
	inline void set_values_8(ValueCollection_t0816666499CBD11E58E1E7C79A4EFC2AA47E08A2 * value)
	{
		___values_8 = value;
		Il2CppCodeGenWriteBarrier((&___values_8), value);
	}

	inline static int32_t get_offset_of__syncRoot_9() { return static_cast<int32_t>(offsetof(Dictionary_2_t32F25F093828AA9F93CB11C2A2B4648FD62A09BA, ____syncRoot_9)); }
	inline RuntimeObject * get__syncRoot_9() const { return ____syncRoot_9; }
	inline RuntimeObject ** get_address_of__syncRoot_9() { return &____syncRoot_9; }
	inline void set__syncRoot_9(RuntimeObject * value)
	{
		____syncRoot_9 = value;
		Il2CppCodeGenWriteBarrier((&____syncRoot_9), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // DICTIONARY_2_T32F25F093828AA9F93CB11C2A2B4648FD62A09BA_H
#ifndef EQUALITYCOMPARER_1_T54972BA287ED38B066E4BE7A3B21F49803B62EBA_H
#define EQUALITYCOMPARER_1_T54972BA287ED38B066E4BE7A3B21F49803B62EBA_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Collections.Generic.EqualityComparer`1<System.Object>
struct  EqualityComparer_1_t54972BA287ED38B066E4BE7A3B21F49803B62EBA  : public RuntimeObject
{
public:

public:
};

struct EqualityComparer_1_t54972BA287ED38B066E4BE7A3B21F49803B62EBA_StaticFields
{
public:
	// System.Collections.Generic.EqualityComparer`1<T> modreq(System.Runtime.CompilerServices.IsVolatile) System.Collections.Generic.EqualityComparer`1::defaultComparer
	EqualityComparer_1_t54972BA287ED38B066E4BE7A3B21F49803B62EBA * ___defaultComparer_0;

public:
	inline static int32_t get_offset_of_defaultComparer_0() { return static_cast<int32_t>(offsetof(EqualityComparer_1_t54972BA287ED38B066E4BE7A3B21F49803B62EBA_StaticFields, ___defaultComparer_0)); }
	inline EqualityComparer_1_t54972BA287ED38B066E4BE7A3B21F49803B62EBA * get_defaultComparer_0() const { return ___defaultComparer_0; }
	inline EqualityComparer_1_t54972BA287ED38B066E4BE7A3B21F49803B62EBA ** get_address_of_defaultComparer_0() { return &___defaultComparer_0; }
	inline void set_defaultComparer_0(EqualityComparer_1_t54972BA287ED38B066E4BE7A3B21F49803B62EBA * value)
	{
		___defaultComparer_0 = value;
		Il2CppCodeGenWriteBarrier((&___defaultComparer_0), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // EQUALITYCOMPARER_1_T54972BA287ED38B066E4BE7A3B21F49803B62EBA_H
#ifndef LIST_1_TA0E2AEAC02B0C34F5538C6D39174C6E22259F642_H
#define LIST_1_TA0E2AEAC02B0C34F5538C6D39174C6E22259F642_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Collections.Generic.List`1<Pixeye.Factory>
struct  List_1_tA0E2AEAC02B0C34F5538C6D39174C6E22259F642  : public RuntimeObject
{
public:
	// T[] System.Collections.Generic.List`1::_items
	FactoryU5BU5D_t7A8216D8ED74B1438E91899BC6A21F74EC123FD7* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject * ____syncRoot_4;

public:
	inline static int32_t get_offset_of__items_1() { return static_cast<int32_t>(offsetof(List_1_tA0E2AEAC02B0C34F5538C6D39174C6E22259F642, ____items_1)); }
	inline FactoryU5BU5D_t7A8216D8ED74B1438E91899BC6A21F74EC123FD7* get__items_1() const { return ____items_1; }
	inline FactoryU5BU5D_t7A8216D8ED74B1438E91899BC6A21F74EC123FD7** get_address_of__items_1() { return &____items_1; }
	inline void set__items_1(FactoryU5BU5D_t7A8216D8ED74B1438E91899BC6A21F74EC123FD7* value)
	{
		____items_1 = value;
		Il2CppCodeGenWriteBarrier((&____items_1), value);
	}

	inline static int32_t get_offset_of__size_2() { return static_cast<int32_t>(offsetof(List_1_tA0E2AEAC02B0C34F5538C6D39174C6E22259F642, ____size_2)); }
	inline int32_t get__size_2() const { return ____size_2; }
	inline int32_t* get_address_of__size_2() { return &____size_2; }
	inline void set__size_2(int32_t value)
	{
		____size_2 = value;
	}

	inline static int32_t get_offset_of__version_3() { return static_cast<int32_t>(offsetof(List_1_tA0E2AEAC02B0C34F5538C6D39174C6E22259F642, ____version_3)); }
	inline int32_t get__version_3() const { return ____version_3; }
	inline int32_t* get_address_of__version_3() { return &____version_3; }
	inline void set__version_3(int32_t value)
	{
		____version_3 = value;
	}

	inline static int32_t get_offset_of__syncRoot_4() { return static_cast<int32_t>(offsetof(List_1_tA0E2AEAC02B0C34F5538C6D39174C6E22259F642, ____syncRoot_4)); }
	inline RuntimeObject * get__syncRoot_4() const { return ____syncRoot_4; }
	inline RuntimeObject ** get_address_of__syncRoot_4() { return &____syncRoot_4; }
	inline void set__syncRoot_4(RuntimeObject * value)
	{
		____syncRoot_4 = value;
		Il2CppCodeGenWriteBarrier((&____syncRoot_4), value);
	}
};

struct List_1_tA0E2AEAC02B0C34F5538C6D39174C6E22259F642_StaticFields
{
public:
	// T[] System.Collections.Generic.List`1::_emptyArray
	FactoryU5BU5D_t7A8216D8ED74B1438E91899BC6A21F74EC123FD7* ____emptyArray_5;

public:
	inline static int32_t get_offset_of__emptyArray_5() { return static_cast<int32_t>(offsetof(List_1_tA0E2AEAC02B0C34F5538C6D39174C6E22259F642_StaticFields, ____emptyArray_5)); }
	inline FactoryU5BU5D_t7A8216D8ED74B1438E91899BC6A21F74EC123FD7* get__emptyArray_5() const { return ____emptyArray_5; }
	inline FactoryU5BU5D_t7A8216D8ED74B1438E91899BC6A21F74EC123FD7** get_address_of__emptyArray_5() { return &____emptyArray_5; }
	inline void set__emptyArray_5(FactoryU5BU5D_t7A8216D8ED74B1438E91899BC6A21F74EC123FD7* value)
	{
		____emptyArray_5 = value;
		Il2CppCodeGenWriteBarrier((&____emptyArray_5), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // LIST_1_TA0E2AEAC02B0C34F5538C6D39174C6E22259F642_H
#ifndef LIST_1_T2D6D202FD59CE78CF20816E533E40E75EF42A211_H
#define LIST_1_T2D6D202FD59CE78CF20816E533E40E75EF42A211_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Collections.Generic.List`1<Pixeye.Pluggable>
struct  List_1_t2D6D202FD59CE78CF20816E533E40E75EF42A211  : public RuntimeObject
{
public:
	// T[] System.Collections.Generic.List`1::_items
	PluggableU5BU5D_tE5D1CFECA820F0A38DD943A37A40C020341EC93F* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject * ____syncRoot_4;

public:
	inline static int32_t get_offset_of__items_1() { return static_cast<int32_t>(offsetof(List_1_t2D6D202FD59CE78CF20816E533E40E75EF42A211, ____items_1)); }
	inline PluggableU5BU5D_tE5D1CFECA820F0A38DD943A37A40C020341EC93F* get__items_1() const { return ____items_1; }
	inline PluggableU5BU5D_tE5D1CFECA820F0A38DD943A37A40C020341EC93F** get_address_of__items_1() { return &____items_1; }
	inline void set__items_1(PluggableU5BU5D_tE5D1CFECA820F0A38DD943A37A40C020341EC93F* value)
	{
		____items_1 = value;
		Il2CppCodeGenWriteBarrier((&____items_1), value);
	}

	inline static int32_t get_offset_of__size_2() { return static_cast<int32_t>(offsetof(List_1_t2D6D202FD59CE78CF20816E533E40E75EF42A211, ____size_2)); }
	inline int32_t get__size_2() const { return ____size_2; }
	inline int32_t* get_address_of__size_2() { return &____size_2; }
	inline void set__size_2(int32_t value)
	{
		____size_2 = value;
	}

	inline static int32_t get_offset_of__version_3() { return static_cast<int32_t>(offsetof(List_1_t2D6D202FD59CE78CF20816E533E40E75EF42A211, ____version_3)); }
	inline int32_t get__version_3() const { return ____version_3; }
	inline int32_t* get_address_of__version_3() { return &____version_3; }
	inline void set__version_3(int32_t value)
	{
		____version_3 = value;
	}

	inline static int32_t get_offset_of__syncRoot_4() { return static_cast<int32_t>(offsetof(List_1_t2D6D202FD59CE78CF20816E533E40E75EF42A211, ____syncRoot_4)); }
	inline RuntimeObject * get__syncRoot_4() const { return ____syncRoot_4; }
	inline RuntimeObject ** get_address_of__syncRoot_4() { return &____syncRoot_4; }
	inline void set__syncRoot_4(RuntimeObject * value)
	{
		____syncRoot_4 = value;
		Il2CppCodeGenWriteBarrier((&____syncRoot_4), value);
	}
};

struct List_1_t2D6D202FD59CE78CF20816E533E40E75EF42A211_StaticFields
{
public:
	// T[] System.Collections.Generic.List`1::_emptyArray
	PluggableU5BU5D_tE5D1CFECA820F0A38DD943A37A40C020341EC93F* ____emptyArray_5;

public:
	inline static int32_t get_offset_of__emptyArray_5() { return static_cast<int32_t>(offsetof(List_1_t2D6D202FD59CE78CF20816E533E40E75EF42A211_StaticFields, ____emptyArray_5)); }
	inline PluggableU5BU5D_tE5D1CFECA820F0A38DD943A37A40C020341EC93F* get__emptyArray_5() const { return ____emptyArray_5; }
	inline PluggableU5BU5D_tE5D1CFECA820F0A38DD943A37A40C020341EC93F** get_address_of__emptyArray_5() { return &____emptyArray_5; }
	inline void set__emptyArray_5(PluggableU5BU5D_tE5D1CFECA820F0A38DD943A37A40C020341EC93F* value)
	{
		____emptyArray_5 = value;
		Il2CppCodeGenWriteBarrier((&____emptyArray_5), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // LIST_1_T2D6D202FD59CE78CF20816E533E40E75EF42A211_H
#ifndef LIST_1_TF89465888600A0DC538773BB071C4AFEA6A8597E_H
#define LIST_1_TF89465888600A0DC538773BB071C4AFEA6A8597E_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Collections.Generic.List`1<Pixeye.PoolNode>
struct  List_1_tF89465888600A0DC538773BB071C4AFEA6A8597E  : public RuntimeObject
{
public:
	// T[] System.Collections.Generic.List`1::_items
	PoolNodeU5BU5D_t9F244CBEF1668899FB99F01BBECF817296022C0B* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject * ____syncRoot_4;

public:
	inline static int32_t get_offset_of__items_1() { return static_cast<int32_t>(offsetof(List_1_tF89465888600A0DC538773BB071C4AFEA6A8597E, ____items_1)); }
	inline PoolNodeU5BU5D_t9F244CBEF1668899FB99F01BBECF817296022C0B* get__items_1() const { return ____items_1; }
	inline PoolNodeU5BU5D_t9F244CBEF1668899FB99F01BBECF817296022C0B** get_address_of__items_1() { return &____items_1; }
	inline void set__items_1(PoolNodeU5BU5D_t9F244CBEF1668899FB99F01BBECF817296022C0B* value)
	{
		____items_1 = value;
		Il2CppCodeGenWriteBarrier((&____items_1), value);
	}

	inline static int32_t get_offset_of__size_2() { return static_cast<int32_t>(offsetof(List_1_tF89465888600A0DC538773BB071C4AFEA6A8597E, ____size_2)); }
	inline int32_t get__size_2() const { return ____size_2; }
	inline int32_t* get_address_of__size_2() { return &____size_2; }
	inline void set__size_2(int32_t value)
	{
		____size_2 = value;
	}

	inline static int32_t get_offset_of__version_3() { return static_cast<int32_t>(offsetof(List_1_tF89465888600A0DC538773BB071C4AFEA6A8597E, ____version_3)); }
	inline int32_t get__version_3() const { return ____version_3; }
	inline int32_t* get_address_of__version_3() { return &____version_3; }
	inline void set__version_3(int32_t value)
	{
		____version_3 = value;
	}

	inline static int32_t get_offset_of__syncRoot_4() { return static_cast<int32_t>(offsetof(List_1_tF89465888600A0DC538773BB071C4AFEA6A8597E, ____syncRoot_4)); }
	inline RuntimeObject * get__syncRoot_4() const { return ____syncRoot_4; }
	inline RuntimeObject ** get_address_of__syncRoot_4() { return &____syncRoot_4; }
	inline void set__syncRoot_4(RuntimeObject * value)
	{
		____syncRoot_4 = value;
		Il2CppCodeGenWriteBarrier((&____syncRoot_4), value);
	}
};

struct List_1_tF89465888600A0DC538773BB071C4AFEA6A8597E_StaticFields
{
public:
	// T[] System.Collections.Generic.List`1::_emptyArray
	PoolNodeU5BU5D_t9F244CBEF1668899FB99F01BBECF817296022C0B* ____emptyArray_5;

public:
	inline static int32_t get_offset_of__emptyArray_5() { return static_cast<int32_t>(offsetof(List_1_tF89465888600A0DC538773BB071C4AFEA6A8597E_StaticFields, ____emptyArray_5)); }
	inline PoolNodeU5BU5D_t9F244CBEF1668899FB99F01BBECF817296022C0B* get__emptyArray_5() const { return ____emptyArray_5; }
	inline PoolNodeU5BU5D_t9F244CBEF1668899FB99F01BBECF817296022C0B** get_address_of__emptyArray_5() { return &____emptyArray_5; }
	inline void set__emptyArray_5(PoolNodeU5BU5D_t9F244CBEF1668899FB99F01BBECF817296022C0B* value)
	{
		____emptyArray_5 = value;
		Il2CppCodeGenWriteBarrier((&____emptyArray_5), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // LIST_1_TF89465888600A0DC538773BB071C4AFEA6A8597E_H
#ifndef LIST_1_T80222E8941042447035EF5455CC2D2B763E5AE8B_H
#define LIST_1_T80222E8941042447035EF5455CC2D2B763E5AE8B_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Collections.Generic.List`1<Pixeye.SceneReference>
struct  List_1_t80222E8941042447035EF5455CC2D2B763E5AE8B  : public RuntimeObject
{
public:
	// T[] System.Collections.Generic.List`1::_items
	SceneReferenceU5BU5D_t0F8A5E1535280DDA1F3A78E9476F9CCC7D3CC8E1* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject * ____syncRoot_4;

public:
	inline static int32_t get_offset_of__items_1() { return static_cast<int32_t>(offsetof(List_1_t80222E8941042447035EF5455CC2D2B763E5AE8B, ____items_1)); }
	inline SceneReferenceU5BU5D_t0F8A5E1535280DDA1F3A78E9476F9CCC7D3CC8E1* get__items_1() const { return ____items_1; }
	inline SceneReferenceU5BU5D_t0F8A5E1535280DDA1F3A78E9476F9CCC7D3CC8E1** get_address_of__items_1() { return &____items_1; }
	inline void set__items_1(SceneReferenceU5BU5D_t0F8A5E1535280DDA1F3A78E9476F9CCC7D3CC8E1* value)
	{
		____items_1 = value;
		Il2CppCodeGenWriteBarrier((&____items_1), value);
	}

	inline static int32_t get_offset_of__size_2() { return static_cast<int32_t>(offsetof(List_1_t80222E8941042447035EF5455CC2D2B763E5AE8B, ____size_2)); }
	inline int32_t get__size_2() const { return ____size_2; }
	inline int32_t* get_address_of__size_2() { return &____size_2; }
	inline void set__size_2(int32_t value)
	{
		____size_2 = value;
	}

	inline static int32_t get_offset_of__version_3() { return static_cast<int32_t>(offsetof(List_1_t80222E8941042447035EF5455CC2D2B763E5AE8B, ____version_3)); }
	inline int32_t get__version_3() const { return ____version_3; }
	inline int32_t* get_address_of__version_3() { return &____version_3; }
	inline void set__version_3(int32_t value)
	{
		____version_3 = value;
	}

	inline static int32_t get_offset_of__syncRoot_4() { return static_cast<int32_t>(offsetof(List_1_t80222E8941042447035EF5455CC2D2B763E5AE8B, ____syncRoot_4)); }
	inline RuntimeObject * get__syncRoot_4() const { return ____syncRoot_4; }
	inline RuntimeObject ** get_address_of__syncRoot_4() { return &____syncRoot_4; }
	inline void set__syncRoot_4(RuntimeObject * value)
	{
		____syncRoot_4 = value;
		Il2CppCodeGenWriteBarrier((&____syncRoot_4), value);
	}
};

struct List_1_t80222E8941042447035EF5455CC2D2B763E5AE8B_StaticFields
{
public:
	// T[] System.Collections.Generic.List`1::_emptyArray
	SceneReferenceU5BU5D_t0F8A5E1535280DDA1F3A78E9476F9CCC7D3CC8E1* ____emptyArray_5;

public:
	inline static int32_t get_offset_of__emptyArray_5() { return static_cast<int32_t>(offsetof(List_1_t80222E8941042447035EF5455CC2D2B763E5AE8B_StaticFields, ____emptyArray_5)); }
	inline SceneReferenceU5BU5D_t0F8A5E1535280DDA1F3A78E9476F9CCC7D3CC8E1* get__emptyArray_5() const { return ____emptyArray_5; }
	inline SceneReferenceU5BU5D_t0F8A5E1535280DDA1F3A78E9476F9CCC7D3CC8E1** get_address_of__emptyArray_5() { return &____emptyArray_5; }
	inline void set__emptyArray_5(SceneReferenceU5BU5D_t0F8A5E1535280DDA1F3A78E9476F9CCC7D3CC8E1* value)
	{
		____emptyArray_5 = value;
		Il2CppCodeGenWriteBarrier((&____emptyArray_5), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // LIST_1_T80222E8941042447035EF5455CC2D2B763E5AE8B_H
#ifndef LIST_1_T186D2009EAF545D4056FD040D409D10C57CE8F97_H
#define LIST_1_T186D2009EAF545D4056FD040D409D10C57CE8F97_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Collections.Generic.List`1<Pixeye.Storage>
struct  List_1_t186D2009EAF545D4056FD040D409D10C57CE8F97  : public RuntimeObject
{
public:
	// T[] System.Collections.Generic.List`1::_items
	StorageU5BU5D_t5E23208F3504ECF09E6B9F1720C26F5D42D99FAA* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject * ____syncRoot_4;

public:
	inline static int32_t get_offset_of__items_1() { return static_cast<int32_t>(offsetof(List_1_t186D2009EAF545D4056FD040D409D10C57CE8F97, ____items_1)); }
	inline StorageU5BU5D_t5E23208F3504ECF09E6B9F1720C26F5D42D99FAA* get__items_1() const { return ____items_1; }
	inline StorageU5BU5D_t5E23208F3504ECF09E6B9F1720C26F5D42D99FAA** get_address_of__items_1() { return &____items_1; }
	inline void set__items_1(StorageU5BU5D_t5E23208F3504ECF09E6B9F1720C26F5D42D99FAA* value)
	{
		____items_1 = value;
		Il2CppCodeGenWriteBarrier((&____items_1), value);
	}

	inline static int32_t get_offset_of__size_2() { return static_cast<int32_t>(offsetof(List_1_t186D2009EAF545D4056FD040D409D10C57CE8F97, ____size_2)); }
	inline int32_t get__size_2() const { return ____size_2; }
	inline int32_t* get_address_of__size_2() { return &____size_2; }
	inline void set__size_2(int32_t value)
	{
		____size_2 = value;
	}

	inline static int32_t get_offset_of__version_3() { return static_cast<int32_t>(offsetof(List_1_t186D2009EAF545D4056FD040D409D10C57CE8F97, ____version_3)); }
	inline int32_t get__version_3() const { return ____version_3; }
	inline int32_t* get_address_of__version_3() { return &____version_3; }
	inline void set__version_3(int32_t value)
	{
		____version_3 = value;
	}

	inline static int32_t get_offset_of__syncRoot_4() { return static_cast<int32_t>(offsetof(List_1_t186D2009EAF545D4056FD040D409D10C57CE8F97, ____syncRoot_4)); }
	inline RuntimeObject * get__syncRoot_4() const { return ____syncRoot_4; }
	inline RuntimeObject ** get_address_of__syncRoot_4() { return &____syncRoot_4; }
	inline void set__syncRoot_4(RuntimeObject * value)
	{
		____syncRoot_4 = value;
		Il2CppCodeGenWriteBarrier((&____syncRoot_4), value);
	}
};

struct List_1_t186D2009EAF545D4056FD040D409D10C57CE8F97_StaticFields
{
public:
	// T[] System.Collections.Generic.List`1::_emptyArray
	StorageU5BU5D_t5E23208F3504ECF09E6B9F1720C26F5D42D99FAA* ____emptyArray_5;

public:
	inline static int32_t get_offset_of__emptyArray_5() { return static_cast<int32_t>(offsetof(List_1_t186D2009EAF545D4056FD040D409D10C57CE8F97_StaticFields, ____emptyArray_5)); }
	inline StorageU5BU5D_t5E23208F3504ECF09E6B9F1720C26F5D42D99FAA* get__emptyArray_5() const { return ____emptyArray_5; }
	inline StorageU5BU5D_t5E23208F3504ECF09E6B9F1720C26F5D42D99FAA** get_address_of__emptyArray_5() { return &____emptyArray_5; }
	inline void set__emptyArray_5(StorageU5BU5D_t5E23208F3504ECF09E6B9F1720C26F5D42D99FAA* value)
	{
		____emptyArray_5 = value;
		Il2CppCodeGenWriteBarrier((&____emptyArray_5), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // LIST_1_T186D2009EAF545D4056FD040D409D10C57CE8F97_H
#ifndef LIST_1_T613852693859B0156A22267D914D17B30CFDE8F1_H
#define LIST_1_T613852693859B0156A22267D914D17B30CFDE8F1_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Collections.Generic.List`1<Pixeye.Timer>
struct  List_1_t613852693859B0156A22267D914D17B30CFDE8F1  : public RuntimeObject
{
public:
	// T[] System.Collections.Generic.List`1::_items
	TimerU5BU5D_t9C867AC9076A4EF5F8DDE2EE43AF21B9788C19C6* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject * ____syncRoot_4;

public:
	inline static int32_t get_offset_of__items_1() { return static_cast<int32_t>(offsetof(List_1_t613852693859B0156A22267D914D17B30CFDE8F1, ____items_1)); }
	inline TimerU5BU5D_t9C867AC9076A4EF5F8DDE2EE43AF21B9788C19C6* get__items_1() const { return ____items_1; }
	inline TimerU5BU5D_t9C867AC9076A4EF5F8DDE2EE43AF21B9788C19C6** get_address_of__items_1() { return &____items_1; }
	inline void set__items_1(TimerU5BU5D_t9C867AC9076A4EF5F8DDE2EE43AF21B9788C19C6* value)
	{
		____items_1 = value;
		Il2CppCodeGenWriteBarrier((&____items_1), value);
	}

	inline static int32_t get_offset_of__size_2() { return static_cast<int32_t>(offsetof(List_1_t613852693859B0156A22267D914D17B30CFDE8F1, ____size_2)); }
	inline int32_t get__size_2() const { return ____size_2; }
	inline int32_t* get_address_of__size_2() { return &____size_2; }
	inline void set__size_2(int32_t value)
	{
		____size_2 = value;
	}

	inline static int32_t get_offset_of__version_3() { return static_cast<int32_t>(offsetof(List_1_t613852693859B0156A22267D914D17B30CFDE8F1, ____version_3)); }
	inline int32_t get__version_3() const { return ____version_3; }
	inline int32_t* get_address_of__version_3() { return &____version_3; }
	inline void set__version_3(int32_t value)
	{
		____version_3 = value;
	}

	inline static int32_t get_offset_of__syncRoot_4() { return static_cast<int32_t>(offsetof(List_1_t613852693859B0156A22267D914D17B30CFDE8F1, ____syncRoot_4)); }
	inline RuntimeObject * get__syncRoot_4() const { return ____syncRoot_4; }
	inline RuntimeObject ** get_address_of__syncRoot_4() { return &____syncRoot_4; }
	inline void set__syncRoot_4(RuntimeObject * value)
	{
		____syncRoot_4 = value;
		Il2CppCodeGenWriteBarrier((&____syncRoot_4), value);
	}
};

struct List_1_t613852693859B0156A22267D914D17B30CFDE8F1_StaticFields
{
public:
	// T[] System.Collections.Generic.List`1::_emptyArray
	TimerU5BU5D_t9C867AC9076A4EF5F8DDE2EE43AF21B9788C19C6* ____emptyArray_5;

public:
	inline static int32_t get_offset_of__emptyArray_5() { return static_cast<int32_t>(offsetof(List_1_t613852693859B0156A22267D914D17B30CFDE8F1_StaticFields, ____emptyArray_5)); }
	inline TimerU5BU5D_t9C867AC9076A4EF5F8DDE2EE43AF21B9788C19C6* get__emptyArray_5() const { return ____emptyArray_5; }
	inline TimerU5BU5D_t9C867AC9076A4EF5F8DDE2EE43AF21B9788C19C6** get_address_of__emptyArray_5() { return &____emptyArray_5; }
	inline void set__emptyArray_5(TimerU5BU5D_t9C867AC9076A4EF5F8DDE2EE43AF21B9788C19C6* value)
	{
		____emptyArray_5 = value;
		Il2CppCodeGenWriteBarrier((&____emptyArray_5), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // LIST_1_T613852693859B0156A22267D914D17B30CFDE8F1_H
#ifndef LIST_1_TE1526161A558A17A39A8B69D8EEF3801393B6226_H
#define LIST_1_TE1526161A558A17A39A8B69D8EEF3801393B6226_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Collections.Generic.List`1<System.Int32>
struct  List_1_tE1526161A558A17A39A8B69D8EEF3801393B6226  : public RuntimeObject
{
public:
	// T[] System.Collections.Generic.List`1::_items
	Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject * ____syncRoot_4;

public:
	inline static int32_t get_offset_of__items_1() { return static_cast<int32_t>(offsetof(List_1_tE1526161A558A17A39A8B69D8EEF3801393B6226, ____items_1)); }
	inline Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* get__items_1() const { return ____items_1; }
	inline Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83** get_address_of__items_1() { return &____items_1; }
	inline void set__items_1(Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* value)
	{
		____items_1 = value;
		Il2CppCodeGenWriteBarrier((&____items_1), value);
	}

	inline static int32_t get_offset_of__size_2() { return static_cast<int32_t>(offsetof(List_1_tE1526161A558A17A39A8B69D8EEF3801393B6226, ____size_2)); }
	inline int32_t get__size_2() const { return ____size_2; }
	inline int32_t* get_address_of__size_2() { return &____size_2; }
	inline void set__size_2(int32_t value)
	{
		____size_2 = value;
	}

	inline static int32_t get_offset_of__version_3() { return static_cast<int32_t>(offsetof(List_1_tE1526161A558A17A39A8B69D8EEF3801393B6226, ____version_3)); }
	inline int32_t get__version_3() const { return ____version_3; }
	inline int32_t* get_address_of__version_3() { return &____version_3; }
	inline void set__version_3(int32_t value)
	{
		____version_3 = value;
	}

	inline static int32_t get_offset_of__syncRoot_4() { return static_cast<int32_t>(offsetof(List_1_tE1526161A558A17A39A8B69D8EEF3801393B6226, ____syncRoot_4)); }
	inline RuntimeObject * get__syncRoot_4() const { return ____syncRoot_4; }
	inline RuntimeObject ** get_address_of__syncRoot_4() { return &____syncRoot_4; }
	inline void set__syncRoot_4(RuntimeObject * value)
	{
		____syncRoot_4 = value;
		Il2CppCodeGenWriteBarrier((&____syncRoot_4), value);
	}
};

struct List_1_tE1526161A558A17A39A8B69D8EEF3801393B6226_StaticFields
{
public:
	// T[] System.Collections.Generic.List`1::_emptyArray
	Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* ____emptyArray_5;

public:
	inline static int32_t get_offset_of__emptyArray_5() { return static_cast<int32_t>(offsetof(List_1_tE1526161A558A17A39A8B69D8EEF3801393B6226_StaticFields, ____emptyArray_5)); }
	inline Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* get__emptyArray_5() const { return ____emptyArray_5; }
	inline Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83** get_address_of__emptyArray_5() { return &____emptyArray_5; }
	inline void set__emptyArray_5(Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* value)
	{
		____emptyArray_5 = value;
		Il2CppCodeGenWriteBarrier((&____emptyArray_5), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // LIST_1_TE1526161A558A17A39A8B69D8EEF3801393B6226_H
#ifndef EXCEPTION_T_H
#define EXCEPTION_T_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Exception
struct  Exception_t  : public RuntimeObject
{
public:
	// System.String System.Exception::_className
	String_t* ____className_1;
	// System.String System.Exception::_message
	String_t* ____message_2;
	// System.Collections.IDictionary System.Exception::_data
	RuntimeObject* ____data_3;
	// System.Exception System.Exception::_innerException
	Exception_t * ____innerException_4;
	// System.String System.Exception::_helpURL
	String_t* ____helpURL_5;
	// System.Object System.Exception::_stackTrace
	RuntimeObject * ____stackTrace_6;
	// System.String System.Exception::_stackTraceString
	String_t* ____stackTraceString_7;
	// System.String System.Exception::_remoteStackTraceString
	String_t* ____remoteStackTraceString_8;
	// System.Int32 System.Exception::_remoteStackIndex
	int32_t ____remoteStackIndex_9;
	// System.Object System.Exception::_dynamicMethods
	RuntimeObject * ____dynamicMethods_10;
	// System.Int32 System.Exception::_HResult
	int32_t ____HResult_11;
	// System.String System.Exception::_source
	String_t* ____source_12;
	// System.Runtime.Serialization.SafeSerializationManager System.Exception::_safeSerializationManager
	SafeSerializationManager_t4A754D86B0F784B18CBC36C073BA564BED109770 * ____safeSerializationManager_13;
	// System.Diagnostics.StackTrace[] System.Exception::captured_traces
	StackTraceU5BU5D_t855F09649EA34DEE7C1B6F088E0538E3CCC3F196* ___captured_traces_14;
	// System.IntPtr[] System.Exception::native_trace_ips
	IntPtrU5BU5D_t4DC01DCB9A6DF6C9792A6513595D7A11E637DCDD* ___native_trace_ips_15;

public:
	inline static int32_t get_offset_of__className_1() { return static_cast<int32_t>(offsetof(Exception_t, ____className_1)); }
	inline String_t* get__className_1() const { return ____className_1; }
	inline String_t** get_address_of__className_1() { return &____className_1; }
	inline void set__className_1(String_t* value)
	{
		____className_1 = value;
		Il2CppCodeGenWriteBarrier((&____className_1), value);
	}

	inline static int32_t get_offset_of__message_2() { return static_cast<int32_t>(offsetof(Exception_t, ____message_2)); }
	inline String_t* get__message_2() const { return ____message_2; }
	inline String_t** get_address_of__message_2() { return &____message_2; }
	inline void set__message_2(String_t* value)
	{
		____message_2 = value;
		Il2CppCodeGenWriteBarrier((&____message_2), value);
	}

	inline static int32_t get_offset_of__data_3() { return static_cast<int32_t>(offsetof(Exception_t, ____data_3)); }
	inline RuntimeObject* get__data_3() const { return ____data_3; }
	inline RuntimeObject** get_address_of__data_3() { return &____data_3; }
	inline void set__data_3(RuntimeObject* value)
	{
		____data_3 = value;
		Il2CppCodeGenWriteBarrier((&____data_3), value);
	}

	inline static int32_t get_offset_of__innerException_4() { return static_cast<int32_t>(offsetof(Exception_t, ____innerException_4)); }
	inline Exception_t * get__innerException_4() const { return ____innerException_4; }
	inline Exception_t ** get_address_of__innerException_4() { return &____innerException_4; }
	inline void set__innerException_4(Exception_t * value)
	{
		____innerException_4 = value;
		Il2CppCodeGenWriteBarrier((&____innerException_4), value);
	}

	inline static int32_t get_offset_of__helpURL_5() { return static_cast<int32_t>(offsetof(Exception_t, ____helpURL_5)); }
	inline String_t* get__helpURL_5() const { return ____helpURL_5; }
	inline String_t** get_address_of__helpURL_5() { return &____helpURL_5; }
	inline void set__helpURL_5(String_t* value)
	{
		____helpURL_5 = value;
		Il2CppCodeGenWriteBarrier((&____helpURL_5), value);
	}

	inline static int32_t get_offset_of__stackTrace_6() { return static_cast<int32_t>(offsetof(Exception_t, ____stackTrace_6)); }
	inline RuntimeObject * get__stackTrace_6() const { return ____stackTrace_6; }
	inline RuntimeObject ** get_address_of__stackTrace_6() { return &____stackTrace_6; }
	inline void set__stackTrace_6(RuntimeObject * value)
	{
		____stackTrace_6 = value;
		Il2CppCodeGenWriteBarrier((&____stackTrace_6), value);
	}

	inline static int32_t get_offset_of__stackTraceString_7() { return static_cast<int32_t>(offsetof(Exception_t, ____stackTraceString_7)); }
	inline String_t* get__stackTraceString_7() const { return ____stackTraceString_7; }
	inline String_t** get_address_of__stackTraceString_7() { return &____stackTraceString_7; }
	inline void set__stackTraceString_7(String_t* value)
	{
		____stackTraceString_7 = value;
		Il2CppCodeGenWriteBarrier((&____stackTraceString_7), value);
	}

	inline static int32_t get_offset_of__remoteStackTraceString_8() { return static_cast<int32_t>(offsetof(Exception_t, ____remoteStackTraceString_8)); }
	inline String_t* get__remoteStackTraceString_8() const { return ____remoteStackTraceString_8; }
	inline String_t** get_address_of__remoteStackTraceString_8() { return &____remoteStackTraceString_8; }
	inline void set__remoteStackTraceString_8(String_t* value)
	{
		____remoteStackTraceString_8 = value;
		Il2CppCodeGenWriteBarrier((&____remoteStackTraceString_8), value);
	}

	inline static int32_t get_offset_of__remoteStackIndex_9() { return static_cast<int32_t>(offsetof(Exception_t, ____remoteStackIndex_9)); }
	inline int32_t get__remoteStackIndex_9() const { return ____remoteStackIndex_9; }
	inline int32_t* get_address_of__remoteStackIndex_9() { return &____remoteStackIndex_9; }
	inline void set__remoteStackIndex_9(int32_t value)
	{
		____remoteStackIndex_9 = value;
	}

	inline static int32_t get_offset_of__dynamicMethods_10() { return static_cast<int32_t>(offsetof(Exception_t, ____dynamicMethods_10)); }
	inline RuntimeObject * get__dynamicMethods_10() const { return ____dynamicMethods_10; }
	inline RuntimeObject ** get_address_of__dynamicMethods_10() { return &____dynamicMethods_10; }
	inline void set__dynamicMethods_10(RuntimeObject * value)
	{
		____dynamicMethods_10 = value;
		Il2CppCodeGenWriteBarrier((&____dynamicMethods_10), value);
	}

	inline static int32_t get_offset_of__HResult_11() { return static_cast<int32_t>(offsetof(Exception_t, ____HResult_11)); }
	inline int32_t get__HResult_11() const { return ____HResult_11; }
	inline int32_t* get_address_of__HResult_11() { return &____HResult_11; }
	inline void set__HResult_11(int32_t value)
	{
		____HResult_11 = value;
	}

	inline static int32_t get_offset_of__source_12() { return static_cast<int32_t>(offsetof(Exception_t, ____source_12)); }
	inline String_t* get__source_12() const { return ____source_12; }
	inline String_t** get_address_of__source_12() { return &____source_12; }
	inline void set__source_12(String_t* value)
	{
		____source_12 = value;
		Il2CppCodeGenWriteBarrier((&____source_12), value);
	}

	inline static int32_t get_offset_of__safeSerializationManager_13() { return static_cast<int32_t>(offsetof(Exception_t, ____safeSerializationManager_13)); }
	inline SafeSerializationManager_t4A754D86B0F784B18CBC36C073BA564BED109770 * get__safeSerializationManager_13() const { return ____safeSerializationManager_13; }
	inline SafeSerializationManager_t4A754D86B0F784B18CBC36C073BA564BED109770 ** get_address_of__safeSerializationManager_13() { return &____safeSerializationManager_13; }
	inline void set__safeSerializationManager_13(SafeSerializationManager_t4A754D86B0F784B18CBC36C073BA564BED109770 * value)
	{
		____safeSerializationManager_13 = value;
		Il2CppCodeGenWriteBarrier((&____safeSerializationManager_13), value);
	}

	inline static int32_t get_offset_of_captured_traces_14() { return static_cast<int32_t>(offsetof(Exception_t, ___captured_traces_14)); }
	inline StackTraceU5BU5D_t855F09649EA34DEE7C1B6F088E0538E3CCC3F196* get_captured_traces_14() const { return ___captured_traces_14; }
	inline StackTraceU5BU5D_t855F09649EA34DEE7C1B6F088E0538E3CCC3F196** get_address_of_captured_traces_14() { return &___captured_traces_14; }
	inline void set_captured_traces_14(StackTraceU5BU5D_t855F09649EA34DEE7C1B6F088E0538E3CCC3F196* value)
	{
		___captured_traces_14 = value;
		Il2CppCodeGenWriteBarrier((&___captured_traces_14), value);
	}

	inline static int32_t get_offset_of_native_trace_ips_15() { return static_cast<int32_t>(offsetof(Exception_t, ___native_trace_ips_15)); }
	inline IntPtrU5BU5D_t4DC01DCB9A6DF6C9792A6513595D7A11E637DCDD* get_native_trace_ips_15() const { return ___native_trace_ips_15; }
	inline IntPtrU5BU5D_t4DC01DCB9A6DF6C9792A6513595D7A11E637DCDD** get_address_of_native_trace_ips_15() { return &___native_trace_ips_15; }
	inline void set_native_trace_ips_15(IntPtrU5BU5D_t4DC01DCB9A6DF6C9792A6513595D7A11E637DCDD* value)
	{
		___native_trace_ips_15 = value;
		Il2CppCodeGenWriteBarrier((&___native_trace_ips_15), value);
	}
};

struct Exception_t_StaticFields
{
public:
	// System.Object System.Exception::s_EDILock
	RuntimeObject * ___s_EDILock_0;

public:
	inline static int32_t get_offset_of_s_EDILock_0() { return static_cast<int32_t>(offsetof(Exception_t_StaticFields, ___s_EDILock_0)); }
	inline RuntimeObject * get_s_EDILock_0() const { return ___s_EDILock_0; }
	inline RuntimeObject ** get_address_of_s_EDILock_0() { return &___s_EDILock_0; }
	inline void set_s_EDILock_0(RuntimeObject * value)
	{
		___s_EDILock_0 = value;
		Il2CppCodeGenWriteBarrier((&___s_EDILock_0), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// Native definition for P/Invoke marshalling of System.Exception
struct Exception_t_marshaled_pinvoke
{
	char* ____className_1;
	char* ____message_2;
	RuntimeObject* ____data_3;
	Exception_t_marshaled_pinvoke* ____innerException_4;
	char* ____helpURL_5;
	Il2CppIUnknown* ____stackTrace_6;
	char* ____stackTraceString_7;
	char* ____remoteStackTraceString_8;
	int32_t ____remoteStackIndex_9;
	Il2CppIUnknown* ____dynamicMethods_10;
	int32_t ____HResult_11;
	char* ____source_12;
	SafeSerializationManager_t4A754D86B0F784B18CBC36C073BA564BED109770 * ____safeSerializationManager_13;
	StackTraceU5BU5D_t855F09649EA34DEE7C1B6F088E0538E3CCC3F196* ___captured_traces_14;
	intptr_t* ___native_trace_ips_15;
};
// Native definition for COM marshalling of System.Exception
struct Exception_t_marshaled_com
{
	Il2CppChar* ____className_1;
	Il2CppChar* ____message_2;
	RuntimeObject* ____data_3;
	Exception_t_marshaled_com* ____innerException_4;
	Il2CppChar* ____helpURL_5;
	Il2CppIUnknown* ____stackTrace_6;
	Il2CppChar* ____stackTraceString_7;
	Il2CppChar* ____remoteStackTraceString_8;
	int32_t ____remoteStackIndex_9;
	Il2CppIUnknown* ____dynamicMethods_10;
	int32_t ____HResult_11;
	Il2CppChar* ____source_12;
	SafeSerializationManager_t4A754D86B0F784B18CBC36C073BA564BED109770 * ____safeSerializationManager_13;
	StackTraceU5BU5D_t855F09649EA34DEE7C1B6F088E0538E3CCC3F196* ___captured_traces_14;
	intptr_t* ___native_trace_ips_15;
};
#endif // EXCEPTION_T_H
#ifndef HELPERARRAY_T38244D09E69B8C1D19B2F5FA11E108A8E17F56B3_H
#define HELPERARRAY_T38244D09E69B8C1D19B2F5FA11E108A8E17F56B3_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.HelperArray
struct  HelperArray_t38244D09E69B8C1D19B2F5FA11E108A8E17F56B3  : public RuntimeObject
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // HELPERARRAY_T38244D09E69B8C1D19B2F5FA11E108A8E17F56B3_H
#ifndef HELPEROBJECT_T8DDDC60CA23963941C841A0FF58CFFB85581665B_H
#define HELPEROBJECT_T8DDDC60CA23963941C841A0FF58CFFB85581665B_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.HelperObject
struct  HelperObject_t8DDDC60CA23963941C841A0FF58CFFB85581665B  : public RuntimeObject
{
public:

public:
};

struct HelperObject_t8DDDC60CA23963941C841A0FF58CFFB85581665B_StaticFields
{
public:
	// System.Reflection.MethodInfo System.HelperObject::CloneMethod
	MethodInfo_t * ___CloneMethod_0;

public:
	inline static int32_t get_offset_of_CloneMethod_0() { return static_cast<int32_t>(offsetof(HelperObject_t8DDDC60CA23963941C841A0FF58CFFB85581665B_StaticFields, ___CloneMethod_0)); }
	inline MethodInfo_t * get_CloneMethod_0() const { return ___CloneMethod_0; }
	inline MethodInfo_t ** get_address_of_CloneMethod_0() { return &___CloneMethod_0; }
	inline void set_CloneMethod_0(MethodInfo_t * value)
	{
		___CloneMethod_0 = value;
		Il2CppCodeGenWriteBarrier((&___CloneMethod_0), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // HELPEROBJECT_T8DDDC60CA23963941C841A0FF58CFFB85581665B_H
#ifndef U3CU3EC_T9C407A5DC0C368A41DAACA036192AD2BC6222A05_H
#define U3CU3EC_T9C407A5DC0C368A41DAACA036192AD2BC6222A05_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.HelperObject_<>c
struct  U3CU3Ec_t9C407A5DC0C368A41DAACA036192AD2BC6222A05  : public RuntimeObject
{
public:

public:
};

struct U3CU3Ec_t9C407A5DC0C368A41DAACA036192AD2BC6222A05_StaticFields
{
public:
	// System.HelperObject_<>c System.HelperObject_<>c::<>9
	U3CU3Ec_t9C407A5DC0C368A41DAACA036192AD2BC6222A05 * ___U3CU3E9_0;
	// System.Func`2<System.Reflection.FieldInfo,System.Boolean> System.HelperObject_<>c::<>9__4_0
	Func_2_t8B737A62DCD6BCDB37818A2DFF357973A9317E8D * ___U3CU3E9__4_0_1;

public:
	inline static int32_t get_offset_of_U3CU3E9_0() { return static_cast<int32_t>(offsetof(U3CU3Ec_t9C407A5DC0C368A41DAACA036192AD2BC6222A05_StaticFields, ___U3CU3E9_0)); }
	inline U3CU3Ec_t9C407A5DC0C368A41DAACA036192AD2BC6222A05 * get_U3CU3E9_0() const { return ___U3CU3E9_0; }
	inline U3CU3Ec_t9C407A5DC0C368A41DAACA036192AD2BC6222A05 ** get_address_of_U3CU3E9_0() { return &___U3CU3E9_0; }
	inline void set_U3CU3E9_0(U3CU3Ec_t9C407A5DC0C368A41DAACA036192AD2BC6222A05 * value)
	{
		___U3CU3E9_0 = value;
		Il2CppCodeGenWriteBarrier((&___U3CU3E9_0), value);
	}

	inline static int32_t get_offset_of_U3CU3E9__4_0_1() { return static_cast<int32_t>(offsetof(U3CU3Ec_t9C407A5DC0C368A41DAACA036192AD2BC6222A05_StaticFields, ___U3CU3E9__4_0_1)); }
	inline Func_2_t8B737A62DCD6BCDB37818A2DFF357973A9317E8D * get_U3CU3E9__4_0_1() const { return ___U3CU3E9__4_0_1; }
	inline Func_2_t8B737A62DCD6BCDB37818A2DFF357973A9317E8D ** get_address_of_U3CU3E9__4_0_1() { return &___U3CU3E9__4_0_1; }
	inline void set_U3CU3E9__4_0_1(Func_2_t8B737A62DCD6BCDB37818A2DFF357973A9317E8D * value)
	{
		___U3CU3E9__4_0_1 = value;
		Il2CppCodeGenWriteBarrier((&___U3CU3E9__4_0_1), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // U3CU3EC_T9C407A5DC0C368A41DAACA036192AD2BC6222A05_H
#ifndef U3CU3EC__DISPLAYCLASS3_0_T715805D6146E8762D34660C36DE710592B4E74BC_H
#define U3CU3EC__DISPLAYCLASS3_0_T715805D6146E8762D34660C36DE710592B4E74BC_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.HelperObject_<>c__DisplayClass3_0
struct  U3CU3Ec__DisplayClass3_0_t715805D6146E8762D34660C36DE710592B4E74BC  : public RuntimeObject
{
public:
	// System.Collections.Generic.IDictionary`2<System.Object,System.Object> System.HelperObject_<>c__DisplayClass3_0::visited
	RuntimeObject* ___visited_0;

public:
	inline static int32_t get_offset_of_visited_0() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClass3_0_t715805D6146E8762D34660C36DE710592B4E74BC, ___visited_0)); }
	inline RuntimeObject* get_visited_0() const { return ___visited_0; }
	inline RuntimeObject** get_address_of_visited_0() { return &___visited_0; }
	inline void set_visited_0(RuntimeObject* value)
	{
		___visited_0 = value;
		Il2CppCodeGenWriteBarrier((&___visited_0), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // U3CU3EC__DISPLAYCLASS3_0_T715805D6146E8762D34660C36DE710592B4E74BC_H
#ifndef U3CU3EC__DISPLAYCLASS3_1_TB9452E9E43273A7EB9B4BEC3B43307E5DC1E2DAD_H
#define U3CU3EC__DISPLAYCLASS3_1_TB9452E9E43273A7EB9B4BEC3B43307E5DC1E2DAD_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.HelperObject_<>c__DisplayClass3_1
struct  U3CU3Ec__DisplayClass3_1_tB9452E9E43273A7EB9B4BEC3B43307E5DC1E2DAD  : public RuntimeObject
{
public:
	// System.Array System.HelperObject_<>c__DisplayClass3_1::clonedArray
	RuntimeArray * ___clonedArray_0;
	// System.HelperObject_<>c__DisplayClass3_0 System.HelperObject_<>c__DisplayClass3_1::CSU24<>8__locals1
	U3CU3Ec__DisplayClass3_0_t715805D6146E8762D34660C36DE710592B4E74BC * ___CSU24U3CU3E8__locals1_1;

public:
	inline static int32_t get_offset_of_clonedArray_0() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClass3_1_tB9452E9E43273A7EB9B4BEC3B43307E5DC1E2DAD, ___clonedArray_0)); }
	inline RuntimeArray * get_clonedArray_0() const { return ___clonedArray_0; }
	inline RuntimeArray ** get_address_of_clonedArray_0() { return &___clonedArray_0; }
	inline void set_clonedArray_0(RuntimeArray * value)
	{
		___clonedArray_0 = value;
		Il2CppCodeGenWriteBarrier((&___clonedArray_0), value);
	}

	inline static int32_t get_offset_of_CSU24U3CU3E8__locals1_1() { return static_cast<int32_t>(offsetof(U3CU3Ec__DisplayClass3_1_tB9452E9E43273A7EB9B4BEC3B43307E5DC1E2DAD, ___CSU24U3CU3E8__locals1_1)); }
	inline U3CU3Ec__DisplayClass3_0_t715805D6146E8762D34660C36DE710592B4E74BC * get_CSU24U3CU3E8__locals1_1() const { return ___CSU24U3CU3E8__locals1_1; }
	inline U3CU3Ec__DisplayClass3_0_t715805D6146E8762D34660C36DE710592B4E74BC ** get_address_of_CSU24U3CU3E8__locals1_1() { return &___CSU24U3CU3E8__locals1_1; }
	inline void set_CSU24U3CU3E8__locals1_1(U3CU3Ec__DisplayClass3_0_t715805D6146E8762D34660C36DE710592B4E74BC * value)
	{
		___CSU24U3CU3E8__locals1_1 = value;
		Il2CppCodeGenWriteBarrier((&___CSU24U3CU3E8__locals1_1), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // U3CU3EC__DISPLAYCLASS3_1_TB9452E9E43273A7EB9B4BEC3B43307E5DC1E2DAD_H
#ifndef MEMBERINFO_T_H
#define MEMBERINFO_T_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Reflection.MemberInfo
struct  MemberInfo_t  : public RuntimeObject
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // MEMBERINFO_T_H
#ifndef STRING_T_H
#define STRING_T_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.String
struct  String_t  : public RuntimeObject
{
public:
	// System.Int32 System.String::m_stringLength
	int32_t ___m_stringLength_0;
	// System.Char System.String::m_firstChar
	Il2CppChar ___m_firstChar_1;

public:
	inline static int32_t get_offset_of_m_stringLength_0() { return static_cast<int32_t>(offsetof(String_t, ___m_stringLength_0)); }
	inline int32_t get_m_stringLength_0() const { return ___m_stringLength_0; }
	inline int32_t* get_address_of_m_stringLength_0() { return &___m_stringLength_0; }
	inline void set_m_stringLength_0(int32_t value)
	{
		___m_stringLength_0 = value;
	}

	inline static int32_t get_offset_of_m_firstChar_1() { return static_cast<int32_t>(offsetof(String_t, ___m_firstChar_1)); }
	inline Il2CppChar get_m_firstChar_1() const { return ___m_firstChar_1; }
	inline Il2CppChar* get_address_of_m_firstChar_1() { return &___m_firstChar_1; }
	inline void set_m_firstChar_1(Il2CppChar value)
	{
		___m_firstChar_1 = value;
	}
};

struct String_t_StaticFields
{
public:
	// System.String System.String::Empty
	String_t* ___Empty_5;

public:
	inline static int32_t get_offset_of_Empty_5() { return static_cast<int32_t>(offsetof(String_t_StaticFields, ___Empty_5)); }
	inline String_t* get_Empty_5() const { return ___Empty_5; }
	inline String_t** get_address_of_Empty_5() { return &___Empty_5; }
	inline void set_Empty_5(String_t* value)
	{
		___Empty_5 = value;
		Il2CppCodeGenWriteBarrier((&___Empty_5), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // STRING_T_H
#ifndef VALUETYPE_T4D0C27076F7C36E76190FB3328E232BCB1CD1FFF_H
#define VALUETYPE_T4D0C27076F7C36E76190FB3328E232BCB1CD1FFF_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.ValueType
struct  ValueType_t4D0C27076F7C36E76190FB3328E232BCB1CD1FFF  : public RuntimeObject
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// Native definition for P/Invoke marshalling of System.ValueType
struct ValueType_t4D0C27076F7C36E76190FB3328E232BCB1CD1FFF_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.ValueType
struct ValueType_t4D0C27076F7C36E76190FB3328E232BCB1CD1FFF_marshaled_com
{
};
#endif // VALUETYPE_T4D0C27076F7C36E76190FB3328E232BCB1CD1FFF_H
#ifndef YIELDINSTRUCTION_T836035AC7BD07A3C7909F7AD2A5B42DE99D91C44_H
#define YIELDINSTRUCTION_T836035AC7BD07A3C7909F7AD2A5B42DE99D91C44_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.YieldInstruction
struct  YieldInstruction_t836035AC7BD07A3C7909F7AD2A5B42DE99D91C44  : public RuntimeObject
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// Native definition for P/Invoke marshalling of UnityEngine.YieldInstruction
struct YieldInstruction_t836035AC7BD07A3C7909F7AD2A5B42DE99D91C44_marshaled_pinvoke
{
};
// Native definition for COM marshalling of UnityEngine.YieldInstruction
struct YieldInstruction_t836035AC7BD07A3C7909F7AD2A5B42DE99D91C44_marshaled_com
{
};
#endif // YIELDINSTRUCTION_T836035AC7BD07A3C7909F7AD2A5B42DE99D91C44_H
#ifndef DELAYTAGEVENT_TBFFD54C27E705D5B8CD1C5C49B4094A01A88BE02_H
#define DELAYTAGEVENT_TBFFD54C27E705D5B8CD1C5C49B4094A01A88BE02_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Pixeye.DelayTagEvent
struct  DelayTagEvent_tBFFD54C27E705D5B8CD1C5C49B4094A01A88BE02 
{
public:
	// System.Int32 Pixeye.DelayTagEvent::entity
	int32_t ___entity_0;
	// System.Int32 Pixeye.DelayTagEvent::tag
	int32_t ___tag_1;

public:
	inline static int32_t get_offset_of_entity_0() { return static_cast<int32_t>(offsetof(DelayTagEvent_tBFFD54C27E705D5B8CD1C5C49B4094A01A88BE02, ___entity_0)); }
	inline int32_t get_entity_0() const { return ___entity_0; }
	inline int32_t* get_address_of_entity_0() { return &___entity_0; }
	inline void set_entity_0(int32_t value)
	{
		___entity_0 = value;
	}

	inline static int32_t get_offset_of_tag_1() { return static_cast<int32_t>(offsetof(DelayTagEvent_tBFFD54C27E705D5B8CD1C5C49B4094A01A88BE02, ___tag_1)); }
	inline int32_t get_tag_1() const { return ___tag_1; }
	inline int32_t* get_address_of_tag_1() { return &___tag_1; }
	inline void set_tag_1(int32_t value)
	{
		___tag_1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // DELAYTAGEVENT_TBFFD54C27E705D5B8CD1C5C49B4094A01A88BE02_H
#ifndef HANDLEACTORSADD_T8D5278068F1EACBBF9799D835738C552E5550F9E_H
#define HANDLEACTORSADD_T8D5278068F1EACBBF9799D835738C552E5550F9E_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Pixeye.HandleActorsAdd
struct  HandleActorsAdd_t8D5278068F1EACBBF9799D835738C552E5550F9E  : public HandleBase_t2CC405783D210E33C249B92D210EC302F227D7EC
{
public:

public:
};

struct HandleActorsAdd_t8D5278068F1EACBBF9799D835738C552E5550F9E_StaticFields
{
public:
	// System.Int32 Pixeye.HandleActorsAdd::lenTagsToChange
	int32_t ___lenTagsToChange_0;
	// Pixeye.DelayTagEvent[] Pixeye.HandleActorsAdd::tagsToChange
	DelayTagEventU5BU5D_t7C4AB33A74B954415C9AF4B6E5D707E0CF3AA45F* ___tagsToChange_1;
	// System.Collections.Generic.List`1<Pixeye.GroupBase> Pixeye.HandleActorsAdd::groups
	List_1_t9BDBBBDE445BCD28B6812218DD02E011357B5666 * ___groups_2;

public:
	inline static int32_t get_offset_of_lenTagsToChange_0() { return static_cast<int32_t>(offsetof(HandleActorsAdd_t8D5278068F1EACBBF9799D835738C552E5550F9E_StaticFields, ___lenTagsToChange_0)); }
	inline int32_t get_lenTagsToChange_0() const { return ___lenTagsToChange_0; }
	inline int32_t* get_address_of_lenTagsToChange_0() { return &___lenTagsToChange_0; }
	inline void set_lenTagsToChange_0(int32_t value)
	{
		___lenTagsToChange_0 = value;
	}

	inline static int32_t get_offset_of_tagsToChange_1() { return static_cast<int32_t>(offsetof(HandleActorsAdd_t8D5278068F1EACBBF9799D835738C552E5550F9E_StaticFields, ___tagsToChange_1)); }
	inline DelayTagEventU5BU5D_t7C4AB33A74B954415C9AF4B6E5D707E0CF3AA45F* get_tagsToChange_1() const { return ___tagsToChange_1; }
	inline DelayTagEventU5BU5D_t7C4AB33A74B954415C9AF4B6E5D707E0CF3AA45F** get_address_of_tagsToChange_1() { return &___tagsToChange_1; }
	inline void set_tagsToChange_1(DelayTagEventU5BU5D_t7C4AB33A74B954415C9AF4B6E5D707E0CF3AA45F* value)
	{
		___tagsToChange_1 = value;
		Il2CppCodeGenWriteBarrier((&___tagsToChange_1), value);
	}

	inline static int32_t get_offset_of_groups_2() { return static_cast<int32_t>(offsetof(HandleActorsAdd_t8D5278068F1EACBBF9799D835738C552E5550F9E_StaticFields, ___groups_2)); }
	inline List_1_t9BDBBBDE445BCD28B6812218DD02E011357B5666 * get_groups_2() const { return ___groups_2; }
	inline List_1_t9BDBBBDE445BCD28B6812218DD02E011357B5666 ** get_address_of_groups_2() { return &___groups_2; }
	inline void set_groups_2(List_1_t9BDBBBDE445BCD28B6812218DD02E011357B5666 * value)
	{
		___groups_2 = value;
		Il2CppCodeGenWriteBarrier((&___groups_2), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // HANDLEACTORSADD_T8D5278068F1EACBBF9799D835738C552E5550F9E_H
#ifndef HANDLEACTORSREMOVE_T775454EB912F9A2B222D5E61FA84C2DE6EFFAEA7_H
#define HANDLEACTORSREMOVE_T775454EB912F9A2B222D5E61FA84C2DE6EFFAEA7_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Pixeye.HandleActorsRemove
struct  HandleActorsRemove_t775454EB912F9A2B222D5E61FA84C2DE6EFFAEA7  : public HandleBase_t2CC405783D210E33C249B92D210EC302F227D7EC
{
public:
	// Pixeye.Group`1<Pixeye.ComponentRelease> Pixeye.HandleActorsRemove::groupRelease
	Group_1_t1D98F394A0A975D5B266B5A8EAC2FAA7F3FD5D54 * ___groupRelease_0;
	// System.Single Pixeye.HandleActorsRemove::t
	float ___t_1;

public:
	inline static int32_t get_offset_of_groupRelease_0() { return static_cast<int32_t>(offsetof(HandleActorsRemove_t775454EB912F9A2B222D5E61FA84C2DE6EFFAEA7, ___groupRelease_0)); }
	inline Group_1_t1D98F394A0A975D5B266B5A8EAC2FAA7F3FD5D54 * get_groupRelease_0() const { return ___groupRelease_0; }
	inline Group_1_t1D98F394A0A975D5B266B5A8EAC2FAA7F3FD5D54 ** get_address_of_groupRelease_0() { return &___groupRelease_0; }
	inline void set_groupRelease_0(Group_1_t1D98F394A0A975D5B266B5A8EAC2FAA7F3FD5D54 * value)
	{
		___groupRelease_0 = value;
		Il2CppCodeGenWriteBarrier((&___groupRelease_0), value);
	}

	inline static int32_t get_offset_of_t_1() { return static_cast<int32_t>(offsetof(HandleActorsRemove_t775454EB912F9A2B222D5E61FA84C2DE6EFFAEA7, ___t_1)); }
	inline float get_t_1() const { return ___t_1; }
	inline float* get_address_of_t_1() { return &___t_1; }
	inline void set_t_1(float value)
	{
		___t_1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // HANDLEACTORSREMOVE_T775454EB912F9A2B222D5E61FA84C2DE6EFFAEA7_H
#ifndef REQUIREATTRIBUTE_T8B9E56505437ECBB6B0EA3FB2B9E1AA773C1CDEB_H
#define REQUIREATTRIBUTE_T8B9E56505437ECBB6B0EA3FB2B9E1AA773C1CDEB_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Pixeye.RequireAttribute
struct  RequireAttribute_t8B9E56505437ECBB6B0EA3FB2B9E1AA773C1CDEB  : public Attribute_tF048C13FB3C8CFCC53F82290E4A3F621089F9A74
{
public:
	// System.Type[] Pixeye.RequireAttribute::types
	TypeU5BU5D_t7FE623A666B49176DE123306221193E888A12F5F* ___types_0;

public:
	inline static int32_t get_offset_of_types_0() { return static_cast<int32_t>(offsetof(RequireAttribute_t8B9E56505437ECBB6B0EA3FB2B9E1AA773C1CDEB, ___types_0)); }
	inline TypeU5BU5D_t7FE623A666B49176DE123306221193E888A12F5F* get_types_0() const { return ___types_0; }
	inline TypeU5BU5D_t7FE623A666B49176DE123306221193E888A12F5F** get_address_of_types_0() { return &___types_0; }
	inline void set_types_0(TypeU5BU5D_t7FE623A666B49176DE123306221193E888A12F5F* value)
	{
		___types_0 = value;
		Il2CppCodeGenWriteBarrier((&___types_0), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // REQUIREATTRIBUTE_T8B9E56505437ECBB6B0EA3FB2B9E1AA773C1CDEB_H
#ifndef REQUIRETAGSATTRIBUTE_TB80A8FCE5689F37232DC22E17DF16EEE0F912257_H
#define REQUIRETAGSATTRIBUTE_TB80A8FCE5689F37232DC22E17DF16EEE0F912257_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Pixeye.RequireTagsAttribute
struct  RequireTagsAttribute_tB80A8FCE5689F37232DC22E17DF16EEE0F912257  : public Attribute_tF048C13FB3C8CFCC53F82290E4A3F621089F9A74
{
public:
	// System.Int32[] Pixeye.RequireTagsAttribute::tags
	Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* ___tags_0;

public:
	inline static int32_t get_offset_of_tags_0() { return static_cast<int32_t>(offsetof(RequireTagsAttribute_tB80A8FCE5689F37232DC22E17DF16EEE0F912257, ___tags_0)); }
	inline Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* get_tags_0() const { return ___tags_0; }
	inline Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83** get_address_of_tags_0() { return &___tags_0; }
	inline void set_tags_0(Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* value)
	{
		___tags_0 = value;
		Il2CppCodeGenWriteBarrier((&___tags_0), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // REQUIRETAGSATTRIBUTE_TB80A8FCE5689F37232DC22E17DF16EEE0F912257_H
#ifndef TAGFIELDATTRIBUTE_T44EBFA87585224B6D3C31F706F3CE1072F7C075D_H
#define TAGFIELDATTRIBUTE_T44EBFA87585224B6D3C31F706F3CE1072F7C075D_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Pixeye.TagFieldAttribute
struct  TagFieldAttribute_t44EBFA87585224B6D3C31F706F3CE1072F7C075D  : public Attribute_tF048C13FB3C8CFCC53F82290E4A3F621089F9A74
{
public:
	// System.String Pixeye.TagFieldAttribute::categoryName
	String_t* ___categoryName_0;
	// System.String Pixeye.TagFieldAttribute::className
	String_t* ___className_1;

public:
	inline static int32_t get_offset_of_categoryName_0() { return static_cast<int32_t>(offsetof(TagFieldAttribute_t44EBFA87585224B6D3C31F706F3CE1072F7C075D, ___categoryName_0)); }
	inline String_t* get_categoryName_0() const { return ___categoryName_0; }
	inline String_t** get_address_of_categoryName_0() { return &___categoryName_0; }
	inline void set_categoryName_0(String_t* value)
	{
		___categoryName_0 = value;
		Il2CppCodeGenWriteBarrier((&___categoryName_0), value);
	}

	inline static int32_t get_offset_of_className_1() { return static_cast<int32_t>(offsetof(TagFieldAttribute_t44EBFA87585224B6D3C31F706F3CE1072F7C075D, ___className_1)); }
	inline String_t* get_className_1() const { return ___className_1; }
	inline String_t** get_address_of_className_1() { return &___className_1; }
	inline void set_className_1(String_t* value)
	{
		___className_1 = value;
		Il2CppCodeGenWriteBarrier((&___className_1), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // TAGFIELDATTRIBUTE_T44EBFA87585224B6D3C31F706F3CE1072F7C075D_H
#ifndef TIMERKEY_TCE6BF602B11E3FE849B05CC16BE0650A88755F89_H
#define TIMERKEY_TCE6BF602B11E3FE849B05CC16BE0650A88755F89_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Pixeye.TimerKey
struct  TimerKey_tCE6BF602B11E3FE849B05CC16BE0650A88755F89 
{
public:
	// System.Int32 Pixeye.TimerKey::entity
	int32_t ___entity_0;
	// System.Int32 Pixeye.TimerKey::state
	int32_t ___state_1;

public:
	inline static int32_t get_offset_of_entity_0() { return static_cast<int32_t>(offsetof(TimerKey_tCE6BF602B11E3FE849B05CC16BE0650A88755F89, ___entity_0)); }
	inline int32_t get_entity_0() const { return ___entity_0; }
	inline int32_t* get_address_of_entity_0() { return &___entity_0; }
	inline void set_entity_0(int32_t value)
	{
		___entity_0 = value;
	}

	inline static int32_t get_offset_of_state_1() { return static_cast<int32_t>(offsetof(TimerKey_tCE6BF602B11E3FE849B05CC16BE0650A88755F89, ___state_1)); }
	inline int32_t get_state_1() const { return ___state_1; }
	inline int32_t* get_address_of_state_1() { return &___state_1; }
	inline void set_state_1(int32_t value)
	{
		___state_1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // TIMERKEY_TCE6BF602B11E3FE849B05CC16BE0650A88755F89_H
#ifndef ENT_T588AEBB1ED982AC9A990883BC508B4CCD148C622_H
#define ENT_T588AEBB1ED982AC9A990883BC508B4CCD148C622_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Pixeye.ent
struct  ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 
{
public:
	// System.Int32 Pixeye.ent::id
	int32_t ___id_0;
	// System.Int32 Pixeye.ent::hash
	int32_t ___hash_1;

public:
	inline static int32_t get_offset_of_id_0() { return static_cast<int32_t>(offsetof(ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622, ___id_0)); }
	inline int32_t get_id_0() const { return ___id_0; }
	inline int32_t* get_address_of_id_0() { return &___id_0; }
	inline void set_id_0(int32_t value)
	{
		___id_0 = value;
	}

	inline static int32_t get_offset_of_hash_1() { return static_cast<int32_t>(offsetof(ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622, ___hash_1)); }
	inline int32_t get_hash_1() const { return ___hash_1; }
	inline int32_t* get_address_of_hash_1() { return &___hash_1; }
	inline void set_hash_1(int32_t value)
	{
		___hash_1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // ENT_T588AEBB1ED982AC9A990883BC508B4CCD148C622_H
#ifndef BOOLEAN_TB53F6830F670160873277339AA58F15CAED4399C_H
#define BOOLEAN_TB53F6830F670160873277339AA58F15CAED4399C_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Boolean
struct  Boolean_tB53F6830F670160873277339AA58F15CAED4399C 
{
public:
	// System.Boolean System.Boolean::m_value
	bool ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(Boolean_tB53F6830F670160873277339AA58F15CAED4399C, ___m_value_0)); }
	inline bool get_m_value_0() const { return ___m_value_0; }
	inline bool* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(bool value)
	{
		___m_value_0 = value;
	}
};

struct Boolean_tB53F6830F670160873277339AA58F15CAED4399C_StaticFields
{
public:
	// System.String System.Boolean::TrueString
	String_t* ___TrueString_5;
	// System.String System.Boolean::FalseString
	String_t* ___FalseString_6;

public:
	inline static int32_t get_offset_of_TrueString_5() { return static_cast<int32_t>(offsetof(Boolean_tB53F6830F670160873277339AA58F15CAED4399C_StaticFields, ___TrueString_5)); }
	inline String_t* get_TrueString_5() const { return ___TrueString_5; }
	inline String_t** get_address_of_TrueString_5() { return &___TrueString_5; }
	inline void set_TrueString_5(String_t* value)
	{
		___TrueString_5 = value;
		Il2CppCodeGenWriteBarrier((&___TrueString_5), value);
	}

	inline static int32_t get_offset_of_FalseString_6() { return static_cast<int32_t>(offsetof(Boolean_tB53F6830F670160873277339AA58F15CAED4399C_StaticFields, ___FalseString_6)); }
	inline String_t* get_FalseString_6() const { return ___FalseString_6; }
	inline String_t** get_address_of_FalseString_6() { return &___FalseString_6; }
	inline void set_FalseString_6(String_t* value)
	{
		___FalseString_6 = value;
		Il2CppCodeGenWriteBarrier((&___FalseString_6), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // BOOLEAN_TB53F6830F670160873277339AA58F15CAED4399C_H
#ifndef KEYVALUEPAIR_2_T142B50DAD5164EBD2E1495FD821B1A4C3233FA26_H
#define KEYVALUEPAIR_2_T142B50DAD5164EBD2E1495FD821B1A4C3233FA26_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Collections.Generic.KeyValuePair`2<System.Int32,System.Object>
struct  KeyValuePair_2_t142B50DAD5164EBD2E1495FD821B1A4C3233FA26 
{
public:
	// TKey System.Collections.Generic.KeyValuePair`2::key
	int32_t ___key_0;
	// TValue System.Collections.Generic.KeyValuePair`2::value
	RuntimeObject * ___value_1;

public:
	inline static int32_t get_offset_of_key_0() { return static_cast<int32_t>(offsetof(KeyValuePair_2_t142B50DAD5164EBD2E1495FD821B1A4C3233FA26, ___key_0)); }
	inline int32_t get_key_0() const { return ___key_0; }
	inline int32_t* get_address_of_key_0() { return &___key_0; }
	inline void set_key_0(int32_t value)
	{
		___key_0 = value;
	}

	inline static int32_t get_offset_of_value_1() { return static_cast<int32_t>(offsetof(KeyValuePair_2_t142B50DAD5164EBD2E1495FD821B1A4C3233FA26, ___value_1)); }
	inline RuntimeObject * get_value_1() const { return ___value_1; }
	inline RuntimeObject ** get_address_of_value_1() { return &___value_1; }
	inline void set_value_1(RuntimeObject * value)
	{
		___value_1 = value;
		Il2CppCodeGenWriteBarrier((&___value_1), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // KEYVALUEPAIR_2_T142B50DAD5164EBD2E1495FD821B1A4C3233FA26_H
#ifndef ENUMERATOR_TCCCA7DEF5437A9668FAB3E25F19542413527939A_H
#define ENUMERATOR_TCCCA7DEF5437A9668FAB3E25F19542413527939A_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Collections.Generic.List`1_Enumerator<Pixeye.Factory>
struct  Enumerator_tCCCA7DEF5437A9668FAB3E25F19542413527939A 
{
public:
	// System.Collections.Generic.List`1<T> System.Collections.Generic.List`1_Enumerator::list
	List_1_tA0E2AEAC02B0C34F5538C6D39174C6E22259F642 * ___list_0;
	// System.Int32 System.Collections.Generic.List`1_Enumerator::index
	int32_t ___index_1;
	// System.Int32 System.Collections.Generic.List`1_Enumerator::version
	int32_t ___version_2;
	// T System.Collections.Generic.List`1_Enumerator::current
	Factory_tFA5041074647498CBAB64B0C4ABD43314393E7A5 * ___current_3;

public:
	inline static int32_t get_offset_of_list_0() { return static_cast<int32_t>(offsetof(Enumerator_tCCCA7DEF5437A9668FAB3E25F19542413527939A, ___list_0)); }
	inline List_1_tA0E2AEAC02B0C34F5538C6D39174C6E22259F642 * get_list_0() const { return ___list_0; }
	inline List_1_tA0E2AEAC02B0C34F5538C6D39174C6E22259F642 ** get_address_of_list_0() { return &___list_0; }
	inline void set_list_0(List_1_tA0E2AEAC02B0C34F5538C6D39174C6E22259F642 * value)
	{
		___list_0 = value;
		Il2CppCodeGenWriteBarrier((&___list_0), value);
	}

	inline static int32_t get_offset_of_index_1() { return static_cast<int32_t>(offsetof(Enumerator_tCCCA7DEF5437A9668FAB3E25F19542413527939A, ___index_1)); }
	inline int32_t get_index_1() const { return ___index_1; }
	inline int32_t* get_address_of_index_1() { return &___index_1; }
	inline void set_index_1(int32_t value)
	{
		___index_1 = value;
	}

	inline static int32_t get_offset_of_version_2() { return static_cast<int32_t>(offsetof(Enumerator_tCCCA7DEF5437A9668FAB3E25F19542413527939A, ___version_2)); }
	inline int32_t get_version_2() const { return ___version_2; }
	inline int32_t* get_address_of_version_2() { return &___version_2; }
	inline void set_version_2(int32_t value)
	{
		___version_2 = value;
	}

	inline static int32_t get_offset_of_current_3() { return static_cast<int32_t>(offsetof(Enumerator_tCCCA7DEF5437A9668FAB3E25F19542413527939A, ___current_3)); }
	inline Factory_tFA5041074647498CBAB64B0C4ABD43314393E7A5 * get_current_3() const { return ___current_3; }
	inline Factory_tFA5041074647498CBAB64B0C4ABD43314393E7A5 ** get_address_of_current_3() { return &___current_3; }
	inline void set_current_3(Factory_tFA5041074647498CBAB64B0C4ABD43314393E7A5 * value)
	{
		___current_3 = value;
		Il2CppCodeGenWriteBarrier((&___current_3), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // ENUMERATOR_TCCCA7DEF5437A9668FAB3E25F19542413527939A_H
#ifndef ENUMERATOR_TE0C99528D3DCE5863566CE37BD94162A4C0431CD_H
#define ENUMERATOR_TE0C99528D3DCE5863566CE37BD94162A4C0431CD_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Collections.Generic.List`1_Enumerator<System.Object>
struct  Enumerator_tE0C99528D3DCE5863566CE37BD94162A4C0431CD 
{
public:
	// System.Collections.Generic.List`1<T> System.Collections.Generic.List`1_Enumerator::list
	List_1_t05CC3C859AB5E6024394EF9A42E3E696628CA02D * ___list_0;
	// System.Int32 System.Collections.Generic.List`1_Enumerator::index
	int32_t ___index_1;
	// System.Int32 System.Collections.Generic.List`1_Enumerator::version
	int32_t ___version_2;
	// T System.Collections.Generic.List`1_Enumerator::current
	RuntimeObject * ___current_3;

public:
	inline static int32_t get_offset_of_list_0() { return static_cast<int32_t>(offsetof(Enumerator_tE0C99528D3DCE5863566CE37BD94162A4C0431CD, ___list_0)); }
	inline List_1_t05CC3C859AB5E6024394EF9A42E3E696628CA02D * get_list_0() const { return ___list_0; }
	inline List_1_t05CC3C859AB5E6024394EF9A42E3E696628CA02D ** get_address_of_list_0() { return &___list_0; }
	inline void set_list_0(List_1_t05CC3C859AB5E6024394EF9A42E3E696628CA02D * value)
	{
		___list_0 = value;
		Il2CppCodeGenWriteBarrier((&___list_0), value);
	}

	inline static int32_t get_offset_of_index_1() { return static_cast<int32_t>(offsetof(Enumerator_tE0C99528D3DCE5863566CE37BD94162A4C0431CD, ___index_1)); }
	inline int32_t get_index_1() const { return ___index_1; }
	inline int32_t* get_address_of_index_1() { return &___index_1; }
	inline void set_index_1(int32_t value)
	{
		___index_1 = value;
	}

	inline static int32_t get_offset_of_version_2() { return static_cast<int32_t>(offsetof(Enumerator_tE0C99528D3DCE5863566CE37BD94162A4C0431CD, ___version_2)); }
	inline int32_t get_version_2() const { return ___version_2; }
	inline int32_t* get_address_of_version_2() { return &___version_2; }
	inline void set_version_2(int32_t value)
	{
		___version_2 = value;
	}

	inline static int32_t get_offset_of_current_3() { return static_cast<int32_t>(offsetof(Enumerator_tE0C99528D3DCE5863566CE37BD94162A4C0431CD, ___current_3)); }
	inline RuntimeObject * get_current_3() const { return ___current_3; }
	inline RuntimeObject ** get_address_of_current_3() { return &___current_3; }
	inline void set_current_3(RuntimeObject * value)
	{
		___current_3 = value;
		Il2CppCodeGenWriteBarrier((&___current_3), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // ENUMERATOR_TE0C99528D3DCE5863566CE37BD94162A4C0431CD_H
#ifndef ENUM_T2AF27C02B8653AE29442467390005ABC74D8F521_H
#define ENUM_T2AF27C02B8653AE29442467390005ABC74D8F521_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Enum
struct  Enum_t2AF27C02B8653AE29442467390005ABC74D8F521  : public ValueType_t4D0C27076F7C36E76190FB3328E232BCB1CD1FFF
{
public:

public:
};

struct Enum_t2AF27C02B8653AE29442467390005ABC74D8F521_StaticFields
{
public:
	// System.Char[] System.Enum::enumSeperatorCharArray
	CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2* ___enumSeperatorCharArray_0;

public:
	inline static int32_t get_offset_of_enumSeperatorCharArray_0() { return static_cast<int32_t>(offsetof(Enum_t2AF27C02B8653AE29442467390005ABC74D8F521_StaticFields, ___enumSeperatorCharArray_0)); }
	inline CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2* get_enumSeperatorCharArray_0() const { return ___enumSeperatorCharArray_0; }
	inline CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2** get_address_of_enumSeperatorCharArray_0() { return &___enumSeperatorCharArray_0; }
	inline void set_enumSeperatorCharArray_0(CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2* value)
	{
		___enumSeperatorCharArray_0 = value;
		Il2CppCodeGenWriteBarrier((&___enumSeperatorCharArray_0), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// Native definition for P/Invoke marshalling of System.Enum
struct Enum_t2AF27C02B8653AE29442467390005ABC74D8F521_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.Enum
struct Enum_t2AF27C02B8653AE29442467390005ABC74D8F521_marshaled_com
{
};
#endif // ENUM_T2AF27C02B8653AE29442467390005ABC74D8F521_H
#ifndef INT32_T585191389E07734F19F3156FF88FB3EF4800D102_H
#define INT32_T585191389E07734F19F3156FF88FB3EF4800D102_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Int32
struct  Int32_t585191389E07734F19F3156FF88FB3EF4800D102 
{
public:
	// System.Int32 System.Int32::m_value
	int32_t ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(Int32_t585191389E07734F19F3156FF88FB3EF4800D102, ___m_value_0)); }
	inline int32_t get_m_value_0() const { return ___m_value_0; }
	inline int32_t* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(int32_t value)
	{
		___m_value_0 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // INT32_T585191389E07734F19F3156FF88FB3EF4800D102_H
#ifndef INT64_T7A386C2FF7B0280A0F516992401DDFCF0FF7B436_H
#define INT64_T7A386C2FF7B0280A0F516992401DDFCF0FF7B436_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Int64
struct  Int64_t7A386C2FF7B0280A0F516992401DDFCF0FF7B436 
{
public:
	// System.Int64 System.Int64::m_value
	int64_t ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(Int64_t7A386C2FF7B0280A0F516992401DDFCF0FF7B436, ___m_value_0)); }
	inline int64_t get_m_value_0() const { return ___m_value_0; }
	inline int64_t* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(int64_t value)
	{
		___m_value_0 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // INT64_T7A386C2FF7B0280A0F516992401DDFCF0FF7B436_H
#ifndef INTPTR_T_H
#define INTPTR_T_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.IntPtr
struct  IntPtr_t 
{
public:
	// System.Void* System.IntPtr::m_value
	void* ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(IntPtr_t, ___m_value_0)); }
	inline void* get_m_value_0() const { return ___m_value_0; }
	inline void** get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(void* value)
	{
		___m_value_0 = value;
	}
};

struct IntPtr_t_StaticFields
{
public:
	// System.IntPtr System.IntPtr::Zero
	intptr_t ___Zero_1;

public:
	inline static int32_t get_offset_of_Zero_1() { return static_cast<int32_t>(offsetof(IntPtr_t_StaticFields, ___Zero_1)); }
	inline intptr_t get_Zero_1() const { return ___Zero_1; }
	inline intptr_t* get_address_of_Zero_1() { return &___Zero_1; }
	inline void set_Zero_1(intptr_t value)
	{
		___Zero_1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // INTPTR_T_H
#ifndef REFERENCEEQUALITYCOMPARER_T3840A1467D76B18290FA822E6B548D1079D91DA4_H
#define REFERENCEEQUALITYCOMPARER_T3840A1467D76B18290FA822E6B548D1079D91DA4_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.ReferenceEqualityComparer
struct  ReferenceEqualityComparer_t3840A1467D76B18290FA822E6B548D1079D91DA4  : public EqualityComparer_1_t54972BA287ED38B066E4BE7A3B21F49803B62EBA
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // REFERENCEEQUALITYCOMPARER_T3840A1467D76B18290FA822E6B548D1079D91DA4_H
#ifndef FIELDINFO_T_H
#define FIELDINFO_T_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Reflection.FieldInfo
struct  FieldInfo_t  : public MemberInfo_t
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // FIELDINFO_T_H
#ifndef METHODBASE_T_H
#define METHODBASE_T_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Reflection.MethodBase
struct  MethodBase_t  : public MemberInfo_t
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // METHODBASE_T_H
#ifndef ISREADONLYATTRIBUTE_T625BDB176EA5986CAF2228A6F2A61A9FABD2C344_H
#define ISREADONLYATTRIBUTE_T625BDB176EA5986CAF2228A6F2A61A9FABD2C344_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Runtime.CompilerServices.IsReadOnlyAttribute
struct  IsReadOnlyAttribute_t625BDB176EA5986CAF2228A6F2A61A9FABD2C344  : public Attribute_tF048C13FB3C8CFCC53F82290E4A3F621089F9A74
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // ISREADONLYATTRIBUTE_T625BDB176EA5986CAF2228A6F2A61A9FABD2C344_H
#ifndef SINGLE_TDDDA9169C4E4E308AC6D7A824F9B28DC82204AE1_H
#define SINGLE_TDDDA9169C4E4E308AC6D7A824F9B28DC82204AE1_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Single
struct  Single_tDDDA9169C4E4E308AC6D7A824F9B28DC82204AE1 
{
public:
	// System.Single System.Single::m_value
	float ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(Single_tDDDA9169C4E4E308AC6D7A824F9B28DC82204AE1, ___m_value_0)); }
	inline float get_m_value_0() const { return ___m_value_0; }
	inline float* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(float value)
	{
		___m_value_0 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // SINGLE_TDDDA9169C4E4E308AC6D7A824F9B28DC82204AE1_H
#ifndef SYSTEMEXCEPTION_T5380468142AA850BE4A341D7AF3EAB9C78746782_H
#define SYSTEMEXCEPTION_T5380468142AA850BE4A341D7AF3EAB9C78746782_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.SystemException
struct  SystemException_t5380468142AA850BE4A341D7AF3EAB9C78746782  : public Exception_t
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // SYSTEMEXCEPTION_T5380468142AA850BE4A341D7AF3EAB9C78746782_H
#ifndef VOID_T22962CB4C05B1D89B55A6E1139F0E87A90987017_H
#define VOID_T22962CB4C05B1D89B55A6E1139F0E87A90987017_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Void
struct  Void_t22962CB4C05B1D89B55A6E1139F0E87A90987017 
{
public:
	union
	{
		struct
		{
		};
		uint8_t Void_t22962CB4C05B1D89B55A6E1139F0E87A90987017__padding[1];
	};

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // VOID_T22962CB4C05B1D89B55A6E1139F0E87A90987017_H
#ifndef PROPERTYATTRIBUTE_T25BFFC093C9C96E3CCF4EAB36F5DC6F937B1FA54_H
#define PROPERTYATTRIBUTE_T25BFFC093C9C96E3CCF4EAB36F5DC6F937B1FA54_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.PropertyAttribute
struct  PropertyAttribute_t25BFFC093C9C96E3CCF4EAB36F5DC6F937B1FA54  : public Attribute_tF048C13FB3C8CFCC53F82290E4A3F621089F9A74
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // PROPERTYATTRIBUTE_T25BFFC093C9C96E3CCF4EAB36F5DC6F937B1FA54_H
#ifndef WAITFORSECONDS_T3E9E78D3BB53F03F96C7F28BA9B9086CD1A5F4E8_H
#define WAITFORSECONDS_T3E9E78D3BB53F03F96C7F28BA9B9086CD1A5F4E8_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.WaitForSeconds
struct  WaitForSeconds_t3E9E78D3BB53F03F96C7F28BA9B9086CD1A5F4E8  : public YieldInstruction_t836035AC7BD07A3C7909F7AD2A5B42DE99D91C44
{
public:
	// System.Single UnityEngine.WaitForSeconds::m_Seconds
	float ___m_Seconds_0;

public:
	inline static int32_t get_offset_of_m_Seconds_0() { return static_cast<int32_t>(offsetof(WaitForSeconds_t3E9E78D3BB53F03F96C7F28BA9B9086CD1A5F4E8, ___m_Seconds_0)); }
	inline float get_m_Seconds_0() const { return ___m_Seconds_0; }
	inline float* get_address_of_m_Seconds_0() { return &___m_Seconds_0; }
	inline void set_m_Seconds_0(float value)
	{
		___m_Seconds_0 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// Native definition for P/Invoke marshalling of UnityEngine.WaitForSeconds
struct WaitForSeconds_t3E9E78D3BB53F03F96C7F28BA9B9086CD1A5F4E8_marshaled_pinvoke : public YieldInstruction_t836035AC7BD07A3C7909F7AD2A5B42DE99D91C44_marshaled_pinvoke
{
	float ___m_Seconds_0;
};
// Native definition for COM marshalling of UnityEngine.WaitForSeconds
struct WaitForSeconds_t3E9E78D3BB53F03F96C7F28BA9B9086CD1A5F4E8_marshaled_com : public YieldInstruction_t836035AC7BD07A3C7909F7AD2A5B42DE99D91C44_marshaled_com
{
	float ___m_Seconds_0;
};
#endif // WAITFORSECONDS_T3E9E78D3BB53F03F96C7F28BA9B9086CD1A5F4E8_H
#ifndef ENTITYCOMPOSER_TB9CD47E805A3232A943F6CF48BB084FB1646CCD3_H
#define ENTITYCOMPOSER_TB9CD47E805A3232A943F6CF48BB084FB1646CCD3_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Pixeye.EntityComposer
struct  EntityComposer_tB9CD47E805A3232A943F6CF48BB084FB1646CCD3  : public RuntimeObject
{
public:
	// Pixeye.ent Pixeye.EntityComposer::entity
	ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622  ___entity_1;
	// Pixeye.Storage[] Pixeye.EntityComposer::storages
	StorageU5BU5D_t5E23208F3504ECF09E6B9F1720C26F5D42D99FAA* ___storages_2;
	// System.Int32 Pixeye.EntityComposer::length
	int32_t ___length_3;

public:
	inline static int32_t get_offset_of_entity_1() { return static_cast<int32_t>(offsetof(EntityComposer_tB9CD47E805A3232A943F6CF48BB084FB1646CCD3, ___entity_1)); }
	inline ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622  get_entity_1() const { return ___entity_1; }
	inline ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * get_address_of_entity_1() { return &___entity_1; }
	inline void set_entity_1(ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622  value)
	{
		___entity_1 = value;
	}

	inline static int32_t get_offset_of_storages_2() { return static_cast<int32_t>(offsetof(EntityComposer_tB9CD47E805A3232A943F6CF48BB084FB1646CCD3, ___storages_2)); }
	inline StorageU5BU5D_t5E23208F3504ECF09E6B9F1720C26F5D42D99FAA* get_storages_2() const { return ___storages_2; }
	inline StorageU5BU5D_t5E23208F3504ECF09E6B9F1720C26F5D42D99FAA** get_address_of_storages_2() { return &___storages_2; }
	inline void set_storages_2(StorageU5BU5D_t5E23208F3504ECF09E6B9F1720C26F5D42D99FAA* value)
	{
		___storages_2 = value;
		Il2CppCodeGenWriteBarrier((&___storages_2), value);
	}

	inline static int32_t get_offset_of_length_3() { return static_cast<int32_t>(offsetof(EntityComposer_tB9CD47E805A3232A943F6CF48BB084FB1646CCD3, ___length_3)); }
	inline int32_t get_length_3() const { return ___length_3; }
	inline int32_t* get_address_of_length_3() { return &___length_3; }
	inline void set_length_3(int32_t value)
	{
		___length_3 = value;
	}
};

struct EntityComposer_tB9CD47E805A3232A943F6CF48BB084FB1646CCD3_StaticFields
{
public:
	// Pixeye.EntityComposer Pixeye.EntityComposer::Default
	EntityComposer_tB9CD47E805A3232A943F6CF48BB084FB1646CCD3 * ___Default_0;

public:
	inline static int32_t get_offset_of_Default_0() { return static_cast<int32_t>(offsetof(EntityComposer_tB9CD47E805A3232A943F6CF48BB084FB1646CCD3_StaticFields, ___Default_0)); }
	inline EntityComposer_tB9CD47E805A3232A943F6CF48BB084FB1646CCD3 * get_Default_0() const { return ___Default_0; }
	inline EntityComposer_tB9CD47E805A3232A943F6CF48BB084FB1646CCD3 ** get_address_of_Default_0() { return &___Default_0; }
	inline void set_Default_0(EntityComposer_tB9CD47E805A3232A943F6CF48BB084FB1646CCD3 * value)
	{
		___Default_0 = value;
		Il2CppCodeGenWriteBarrier((&___Default_0), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // ENTITYCOMPOSER_TB9CD47E805A3232A943F6CF48BB084FB1646CCD3_H
#ifndef REFTYPE_T4430D47706A7DA7D5ACD5AA7A9D5538FE962A19C_H
#define REFTYPE_T4430D47706A7DA7D5ACD5AA7A9D5538FE962A19C_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Pixeye.RefType
struct  RefType_t4430D47706A7DA7D5ACD5AA7A9D5538FE962A19C 
{
public:
	// System.Int32 Pixeye.RefType::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(RefType_t4430D47706A7DA7D5ACD5AA7A9D5538FE962A19C, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // REFTYPE_T4430D47706A7DA7D5ACD5AA7A9D5538FE962A19C_H
#ifndef TAGFILTERATTRIBUTE_TCFBF8A9A03FC22D02803646A5564ECD11A6E2276_H
#define TAGFILTERATTRIBUTE_TCFBF8A9A03FC22D02803646A5564ECD11A6E2276_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Pixeye.TagFilterAttribute
struct  TagFilterAttribute_tCFBF8A9A03FC22D02803646A5564ECD11A6E2276  : public PropertyAttribute_t25BFFC093C9C96E3CCF4EAB36F5DC6F937B1FA54
{
public:
	// System.Type[] Pixeye.TagFilterAttribute::tagType
	TypeU5BU5D_t7FE623A666B49176DE123306221193E888A12F5F* ___tagType_0;

public:
	inline static int32_t get_offset_of_tagType_0() { return static_cast<int32_t>(offsetof(TagFilterAttribute_tCFBF8A9A03FC22D02803646A5564ECD11A6E2276, ___tagType_0)); }
	inline TypeU5BU5D_t7FE623A666B49176DE123306221193E888A12F5F* get_tagType_0() const { return ___tagType_0; }
	inline TypeU5BU5D_t7FE623A666B49176DE123306221193E888A12F5F** get_address_of_tagType_0() { return &___tagType_0; }
	inline void set_tagType_0(TypeU5BU5D_t7FE623A666B49176DE123306221193E888A12F5F* value)
	{
		___tagType_0 = value;
		Il2CppCodeGenWriteBarrier((&___tagType_0), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // TAGFILTERATTRIBUTE_TCFBF8A9A03FC22D02803646A5564ECD11A6E2276_H
#ifndef ENUMERATOR_T72A8231827DB93FC8B25F08FF066377F7B773DA1_H
#define ENUMERATOR_T72A8231827DB93FC8B25F08FF066377F7B773DA1_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Collections.Generic.Dictionary`2_Enumerator<System.Int32,System.Object>
struct  Enumerator_t72A8231827DB93FC8B25F08FF066377F7B773DA1 
{
public:
	// System.Collections.Generic.Dictionary`2<TKey,TValue> System.Collections.Generic.Dictionary`2_Enumerator::dictionary
	Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884 * ___dictionary_0;
	// System.Int32 System.Collections.Generic.Dictionary`2_Enumerator::version
	int32_t ___version_1;
	// System.Int32 System.Collections.Generic.Dictionary`2_Enumerator::index
	int32_t ___index_2;
	// System.Collections.Generic.KeyValuePair`2<TKey,TValue> System.Collections.Generic.Dictionary`2_Enumerator::current
	KeyValuePair_2_t142B50DAD5164EBD2E1495FD821B1A4C3233FA26  ___current_3;
	// System.Int32 System.Collections.Generic.Dictionary`2_Enumerator::getEnumeratorRetType
	int32_t ___getEnumeratorRetType_4;

public:
	inline static int32_t get_offset_of_dictionary_0() { return static_cast<int32_t>(offsetof(Enumerator_t72A8231827DB93FC8B25F08FF066377F7B773DA1, ___dictionary_0)); }
	inline Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884 * get_dictionary_0() const { return ___dictionary_0; }
	inline Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884 ** get_address_of_dictionary_0() { return &___dictionary_0; }
	inline void set_dictionary_0(Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884 * value)
	{
		___dictionary_0 = value;
		Il2CppCodeGenWriteBarrier((&___dictionary_0), value);
	}

	inline static int32_t get_offset_of_version_1() { return static_cast<int32_t>(offsetof(Enumerator_t72A8231827DB93FC8B25F08FF066377F7B773DA1, ___version_1)); }
	inline int32_t get_version_1() const { return ___version_1; }
	inline int32_t* get_address_of_version_1() { return &___version_1; }
	inline void set_version_1(int32_t value)
	{
		___version_1 = value;
	}

	inline static int32_t get_offset_of_index_2() { return static_cast<int32_t>(offsetof(Enumerator_t72A8231827DB93FC8B25F08FF066377F7B773DA1, ___index_2)); }
	inline int32_t get_index_2() const { return ___index_2; }
	inline int32_t* get_address_of_index_2() { return &___index_2; }
	inline void set_index_2(int32_t value)
	{
		___index_2 = value;
	}

	inline static int32_t get_offset_of_current_3() { return static_cast<int32_t>(offsetof(Enumerator_t72A8231827DB93FC8B25F08FF066377F7B773DA1, ___current_3)); }
	inline KeyValuePair_2_t142B50DAD5164EBD2E1495FD821B1A4C3233FA26  get_current_3() const { return ___current_3; }
	inline KeyValuePair_2_t142B50DAD5164EBD2E1495FD821B1A4C3233FA26 * get_address_of_current_3() { return &___current_3; }
	inline void set_current_3(KeyValuePair_2_t142B50DAD5164EBD2E1495FD821B1A4C3233FA26  value)
	{
		___current_3 = value;
	}

	inline static int32_t get_offset_of_getEnumeratorRetType_4() { return static_cast<int32_t>(offsetof(Enumerator_t72A8231827DB93FC8B25F08FF066377F7B773DA1, ___getEnumeratorRetType_4)); }
	inline int32_t get_getEnumeratorRetType_4() const { return ___getEnumeratorRetType_4; }
	inline int32_t* get_address_of_getEnumeratorRetType_4() { return &___getEnumeratorRetType_4; }
	inline void set_getEnumeratorRetType_4(int32_t value)
	{
		___getEnumeratorRetType_4 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // ENUMERATOR_T72A8231827DB93FC8B25F08FF066377F7B773DA1_H
#ifndef DELEGATE_T_H
#define DELEGATE_T_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Delegate
struct  Delegate_t  : public RuntimeObject
{
public:
	// System.IntPtr System.Delegate::method_ptr
	Il2CppMethodPointer ___method_ptr_0;
	// System.IntPtr System.Delegate::invoke_impl
	intptr_t ___invoke_impl_1;
	// System.Object System.Delegate::m_target
	RuntimeObject * ___m_target_2;
	// System.IntPtr System.Delegate::method
	intptr_t ___method_3;
	// System.IntPtr System.Delegate::delegate_trampoline
	intptr_t ___delegate_trampoline_4;
	// System.IntPtr System.Delegate::extra_arg
	intptr_t ___extra_arg_5;
	// System.IntPtr System.Delegate::method_code
	intptr_t ___method_code_6;
	// System.Reflection.MethodInfo System.Delegate::method_info
	MethodInfo_t * ___method_info_7;
	// System.Reflection.MethodInfo System.Delegate::original_method_info
	MethodInfo_t * ___original_method_info_8;
	// System.DelegateData System.Delegate::data
	DelegateData_t1BF9F691B56DAE5F8C28C5E084FDE94F15F27BBE * ___data_9;
	// System.Boolean System.Delegate::method_is_virtual
	bool ___method_is_virtual_10;

public:
	inline static int32_t get_offset_of_method_ptr_0() { return static_cast<int32_t>(offsetof(Delegate_t, ___method_ptr_0)); }
	inline Il2CppMethodPointer get_method_ptr_0() const { return ___method_ptr_0; }
	inline Il2CppMethodPointer* get_address_of_method_ptr_0() { return &___method_ptr_0; }
	inline void set_method_ptr_0(Il2CppMethodPointer value)
	{
		___method_ptr_0 = value;
	}

	inline static int32_t get_offset_of_invoke_impl_1() { return static_cast<int32_t>(offsetof(Delegate_t, ___invoke_impl_1)); }
	inline intptr_t get_invoke_impl_1() const { return ___invoke_impl_1; }
	inline intptr_t* get_address_of_invoke_impl_1() { return &___invoke_impl_1; }
	inline void set_invoke_impl_1(intptr_t value)
	{
		___invoke_impl_1 = value;
	}

	inline static int32_t get_offset_of_m_target_2() { return static_cast<int32_t>(offsetof(Delegate_t, ___m_target_2)); }
	inline RuntimeObject * get_m_target_2() const { return ___m_target_2; }
	inline RuntimeObject ** get_address_of_m_target_2() { return &___m_target_2; }
	inline void set_m_target_2(RuntimeObject * value)
	{
		___m_target_2 = value;
		Il2CppCodeGenWriteBarrier((&___m_target_2), value);
	}

	inline static int32_t get_offset_of_method_3() { return static_cast<int32_t>(offsetof(Delegate_t, ___method_3)); }
	inline intptr_t get_method_3() const { return ___method_3; }
	inline intptr_t* get_address_of_method_3() { return &___method_3; }
	inline void set_method_3(intptr_t value)
	{
		___method_3 = value;
	}

	inline static int32_t get_offset_of_delegate_trampoline_4() { return static_cast<int32_t>(offsetof(Delegate_t, ___delegate_trampoline_4)); }
	inline intptr_t get_delegate_trampoline_4() const { return ___delegate_trampoline_4; }
	inline intptr_t* get_address_of_delegate_trampoline_4() { return &___delegate_trampoline_4; }
	inline void set_delegate_trampoline_4(intptr_t value)
	{
		___delegate_trampoline_4 = value;
	}

	inline static int32_t get_offset_of_extra_arg_5() { return static_cast<int32_t>(offsetof(Delegate_t, ___extra_arg_5)); }
	inline intptr_t get_extra_arg_5() const { return ___extra_arg_5; }
	inline intptr_t* get_address_of_extra_arg_5() { return &___extra_arg_5; }
	inline void set_extra_arg_5(intptr_t value)
	{
		___extra_arg_5 = value;
	}

	inline static int32_t get_offset_of_method_code_6() { return static_cast<int32_t>(offsetof(Delegate_t, ___method_code_6)); }
	inline intptr_t get_method_code_6() const { return ___method_code_6; }
	inline intptr_t* get_address_of_method_code_6() { return &___method_code_6; }
	inline void set_method_code_6(intptr_t value)
	{
		___method_code_6 = value;
	}

	inline static int32_t get_offset_of_method_info_7() { return static_cast<int32_t>(offsetof(Delegate_t, ___method_info_7)); }
	inline MethodInfo_t * get_method_info_7() const { return ___method_info_7; }
	inline MethodInfo_t ** get_address_of_method_info_7() { return &___method_info_7; }
	inline void set_method_info_7(MethodInfo_t * value)
	{
		___method_info_7 = value;
		Il2CppCodeGenWriteBarrier((&___method_info_7), value);
	}

	inline static int32_t get_offset_of_original_method_info_8() { return static_cast<int32_t>(offsetof(Delegate_t, ___original_method_info_8)); }
	inline MethodInfo_t * get_original_method_info_8() const { return ___original_method_info_8; }
	inline MethodInfo_t ** get_address_of_original_method_info_8() { return &___original_method_info_8; }
	inline void set_original_method_info_8(MethodInfo_t * value)
	{
		___original_method_info_8 = value;
		Il2CppCodeGenWriteBarrier((&___original_method_info_8), value);
	}

	inline static int32_t get_offset_of_data_9() { return static_cast<int32_t>(offsetof(Delegate_t, ___data_9)); }
	inline DelegateData_t1BF9F691B56DAE5F8C28C5E084FDE94F15F27BBE * get_data_9() const { return ___data_9; }
	inline DelegateData_t1BF9F691B56DAE5F8C28C5E084FDE94F15F27BBE ** get_address_of_data_9() { return &___data_9; }
	inline void set_data_9(DelegateData_t1BF9F691B56DAE5F8C28C5E084FDE94F15F27BBE * value)
	{
		___data_9 = value;
		Il2CppCodeGenWriteBarrier((&___data_9), value);
	}

	inline static int32_t get_offset_of_method_is_virtual_10() { return static_cast<int32_t>(offsetof(Delegate_t, ___method_is_virtual_10)); }
	inline bool get_method_is_virtual_10() const { return ___method_is_virtual_10; }
	inline bool* get_address_of_method_is_virtual_10() { return &___method_is_virtual_10; }
	inline void set_method_is_virtual_10(bool value)
	{
		___method_is_virtual_10 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// Native definition for P/Invoke marshalling of System.Delegate
struct Delegate_t_marshaled_pinvoke
{
	intptr_t ___method_ptr_0;
	intptr_t ___invoke_impl_1;
	Il2CppIUnknown* ___m_target_2;
	intptr_t ___method_3;
	intptr_t ___delegate_trampoline_4;
	intptr_t ___extra_arg_5;
	intptr_t ___method_code_6;
	MethodInfo_t * ___method_info_7;
	MethodInfo_t * ___original_method_info_8;
	DelegateData_t1BF9F691B56DAE5F8C28C5E084FDE94F15F27BBE * ___data_9;
	int32_t ___method_is_virtual_10;
};
// Native definition for COM marshalling of System.Delegate
struct Delegate_t_marshaled_com
{
	intptr_t ___method_ptr_0;
	intptr_t ___invoke_impl_1;
	Il2CppIUnknown* ___m_target_2;
	intptr_t ___method_3;
	intptr_t ___delegate_trampoline_4;
	intptr_t ___extra_arg_5;
	intptr_t ___method_code_6;
	MethodInfo_t * ___method_info_7;
	MethodInfo_t * ___original_method_info_8;
	DelegateData_t1BF9F691B56DAE5F8C28C5E084FDE94F15F27BBE * ___data_9;
	int32_t ___method_is_virtual_10;
};
#endif // DELEGATE_T_H
#ifndef NOTSUPPORTEDEXCEPTION_TE75B318D6590A02A5D9B29FD97409B1750FA0010_H
#define NOTSUPPORTEDEXCEPTION_TE75B318D6590A02A5D9B29FD97409B1750FA0010_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.NotSupportedException
struct  NotSupportedException_tE75B318D6590A02A5D9B29FD97409B1750FA0010  : public SystemException_t5380468142AA850BE4A341D7AF3EAB9C78746782
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NOTSUPPORTEDEXCEPTION_TE75B318D6590A02A5D9B29FD97409B1750FA0010_H
#ifndef BINDINGFLAGS_TE35C91D046E63A1B92BB9AB909FCF9DA84379ED0_H
#define BINDINGFLAGS_TE35C91D046E63A1B92BB9AB909FCF9DA84379ED0_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Reflection.BindingFlags
struct  BindingFlags_tE35C91D046E63A1B92BB9AB909FCF9DA84379ED0 
{
public:
	// System.Int32 System.Reflection.BindingFlags::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(BindingFlags_tE35C91D046E63A1B92BB9AB909FCF9DA84379ED0, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // BINDINGFLAGS_TE35C91D046E63A1B92BB9AB909FCF9DA84379ED0_H
#ifndef METHODINFO_T_H
#define METHODINFO_T_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Reflection.MethodInfo
struct  MethodInfo_t  : public MethodBase_t
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // METHODINFO_T_H
#ifndef RUNTIMETYPEHANDLE_T7B542280A22F0EC4EAC2061C29178845847A8B2D_H
#define RUNTIMETYPEHANDLE_T7B542280A22F0EC4EAC2061C29178845847A8B2D_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.RuntimeTypeHandle
struct  RuntimeTypeHandle_t7B542280A22F0EC4EAC2061C29178845847A8B2D 
{
public:
	// System.IntPtr System.RuntimeTypeHandle::value
	intptr_t ___value_0;

public:
	inline static int32_t get_offset_of_value_0() { return static_cast<int32_t>(offsetof(RuntimeTypeHandle_t7B542280A22F0EC4EAC2061C29178845847A8B2D, ___value_0)); }
	inline intptr_t get_value_0() const { return ___value_0; }
	inline intptr_t* get_address_of_value_0() { return &___value_0; }
	inline void set_value_0(intptr_t value)
	{
		___value_0 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // RUNTIMETYPEHANDLE_T7B542280A22F0EC4EAC2061C29178845847A8B2D_H
#ifndef OPTION_TF88F96C5CA59FA7EEC847165A75BED3E96ECE0D9_H
#define OPTION_TF88F96C5CA59FA7EEC847165A75BED3E96ECE0D9_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Unity.IL2CPP.CompilerServices.Option
struct  Option_tF88F96C5CA59FA7EEC847165A75BED3E96ECE0D9 
{
public:
	// System.Int32 Unity.IL2CPP.CompilerServices.Option::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(Option_tF88F96C5CA59FA7EEC847165A75BED3E96ECE0D9, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // OPTION_TF88F96C5CA59FA7EEC847165A75BED3E96ECE0D9_H
#ifndef OBJECT_TAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0_H
#define OBJECT_TAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Object
struct  Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0  : public RuntimeObject
{
public:
	// System.IntPtr UnityEngine.Object::m_CachedPtr
	intptr_t ___m_CachedPtr_0;

public:
	inline static int32_t get_offset_of_m_CachedPtr_0() { return static_cast<int32_t>(offsetof(Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0, ___m_CachedPtr_0)); }
	inline intptr_t get_m_CachedPtr_0() const { return ___m_CachedPtr_0; }
	inline intptr_t* get_address_of_m_CachedPtr_0() { return &___m_CachedPtr_0; }
	inline void set_m_CachedPtr_0(intptr_t value)
	{
		___m_CachedPtr_0 = value;
	}
};

struct Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0_StaticFields
{
public:
	// System.Int32 UnityEngine.Object::OffsetOfInstanceIDInCPlusPlusObject
	int32_t ___OffsetOfInstanceIDInCPlusPlusObject_1;

public:
	inline static int32_t get_offset_of_OffsetOfInstanceIDInCPlusPlusObject_1() { return static_cast<int32_t>(offsetof(Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0_StaticFields, ___OffsetOfInstanceIDInCPlusPlusObject_1)); }
	inline int32_t get_OffsetOfInstanceIDInCPlusPlusObject_1() const { return ___OffsetOfInstanceIDInCPlusPlusObject_1; }
	inline int32_t* get_address_of_OffsetOfInstanceIDInCPlusPlusObject_1() { return &___OffsetOfInstanceIDInCPlusPlusObject_1; }
	inline void set_OffsetOfInstanceIDInCPlusPlusObject_1(int32_t value)
	{
		___OffsetOfInstanceIDInCPlusPlusObject_1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// Native definition for P/Invoke marshalling of UnityEngine.Object
struct Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0_marshaled_pinvoke
{
	intptr_t ___m_CachedPtr_0;
};
// Native definition for COM marshalling of UnityEngine.Object
struct Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0_marshaled_com
{
	intptr_t ___m_CachedPtr_0;
};
#endif // OBJECT_TAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0_H
#ifndef MULTICASTDELEGATE_T_H
#define MULTICASTDELEGATE_T_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.MulticastDelegate
struct  MulticastDelegate_t  : public Delegate_t
{
public:
	// System.Delegate[] System.MulticastDelegate::delegates
	DelegateU5BU5D_tDFCDEE2A6322F96C0FE49AF47E9ADB8C4B294E86* ___delegates_11;

public:
	inline static int32_t get_offset_of_delegates_11() { return static_cast<int32_t>(offsetof(MulticastDelegate_t, ___delegates_11)); }
	inline DelegateU5BU5D_tDFCDEE2A6322F96C0FE49AF47E9ADB8C4B294E86* get_delegates_11() const { return ___delegates_11; }
	inline DelegateU5BU5D_tDFCDEE2A6322F96C0FE49AF47E9ADB8C4B294E86** get_address_of_delegates_11() { return &___delegates_11; }
	inline void set_delegates_11(DelegateU5BU5D_tDFCDEE2A6322F96C0FE49AF47E9ADB8C4B294E86* value)
	{
		___delegates_11 = value;
		Il2CppCodeGenWriteBarrier((&___delegates_11), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// Native definition for P/Invoke marshalling of System.MulticastDelegate
struct MulticastDelegate_t_marshaled_pinvoke : public Delegate_t_marshaled_pinvoke
{
	Delegate_t_marshaled_pinvoke** ___delegates_11;
};
// Native definition for COM marshalling of System.MulticastDelegate
struct MulticastDelegate_t_marshaled_com : public Delegate_t_marshaled_com
{
	Delegate_t_marshaled_com** ___delegates_11;
};
#endif // MULTICASTDELEGATE_T_H
#ifndef TYPE_T_H
#define TYPE_T_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Type
struct  Type_t  : public MemberInfo_t
{
public:
	// System.RuntimeTypeHandle System.Type::_impl
	RuntimeTypeHandle_t7B542280A22F0EC4EAC2061C29178845847A8B2D  ____impl_9;

public:
	inline static int32_t get_offset_of__impl_9() { return static_cast<int32_t>(offsetof(Type_t, ____impl_9)); }
	inline RuntimeTypeHandle_t7B542280A22F0EC4EAC2061C29178845847A8B2D  get__impl_9() const { return ____impl_9; }
	inline RuntimeTypeHandle_t7B542280A22F0EC4EAC2061C29178845847A8B2D * get_address_of__impl_9() { return &____impl_9; }
	inline void set__impl_9(RuntimeTypeHandle_t7B542280A22F0EC4EAC2061C29178845847A8B2D  value)
	{
		____impl_9 = value;
	}
};

struct Type_t_StaticFields
{
public:
	// System.Reflection.MemberFilter System.Type::FilterAttribute
	MemberFilter_t25C1BD92C42BE94426E300787C13C452CB89B381 * ___FilterAttribute_0;
	// System.Reflection.MemberFilter System.Type::FilterName
	MemberFilter_t25C1BD92C42BE94426E300787C13C452CB89B381 * ___FilterName_1;
	// System.Reflection.MemberFilter System.Type::FilterNameIgnoreCase
	MemberFilter_t25C1BD92C42BE94426E300787C13C452CB89B381 * ___FilterNameIgnoreCase_2;
	// System.Object System.Type::Missing
	RuntimeObject * ___Missing_3;
	// System.Char System.Type::Delimiter
	Il2CppChar ___Delimiter_4;
	// System.Type[] System.Type::EmptyTypes
	TypeU5BU5D_t7FE623A666B49176DE123306221193E888A12F5F* ___EmptyTypes_5;
	// System.Reflection.Binder System.Type::defaultBinder
	Binder_t4D5CB06963501D32847C057B57157D6DC49CA759 * ___defaultBinder_6;

public:
	inline static int32_t get_offset_of_FilterAttribute_0() { return static_cast<int32_t>(offsetof(Type_t_StaticFields, ___FilterAttribute_0)); }
	inline MemberFilter_t25C1BD92C42BE94426E300787C13C452CB89B381 * get_FilterAttribute_0() const { return ___FilterAttribute_0; }
	inline MemberFilter_t25C1BD92C42BE94426E300787C13C452CB89B381 ** get_address_of_FilterAttribute_0() { return &___FilterAttribute_0; }
	inline void set_FilterAttribute_0(MemberFilter_t25C1BD92C42BE94426E300787C13C452CB89B381 * value)
	{
		___FilterAttribute_0 = value;
		Il2CppCodeGenWriteBarrier((&___FilterAttribute_0), value);
	}

	inline static int32_t get_offset_of_FilterName_1() { return static_cast<int32_t>(offsetof(Type_t_StaticFields, ___FilterName_1)); }
	inline MemberFilter_t25C1BD92C42BE94426E300787C13C452CB89B381 * get_FilterName_1() const { return ___FilterName_1; }
	inline MemberFilter_t25C1BD92C42BE94426E300787C13C452CB89B381 ** get_address_of_FilterName_1() { return &___FilterName_1; }
	inline void set_FilterName_1(MemberFilter_t25C1BD92C42BE94426E300787C13C452CB89B381 * value)
	{
		___FilterName_1 = value;
		Il2CppCodeGenWriteBarrier((&___FilterName_1), value);
	}

	inline static int32_t get_offset_of_FilterNameIgnoreCase_2() { return static_cast<int32_t>(offsetof(Type_t_StaticFields, ___FilterNameIgnoreCase_2)); }
	inline MemberFilter_t25C1BD92C42BE94426E300787C13C452CB89B381 * get_FilterNameIgnoreCase_2() const { return ___FilterNameIgnoreCase_2; }
	inline MemberFilter_t25C1BD92C42BE94426E300787C13C452CB89B381 ** get_address_of_FilterNameIgnoreCase_2() { return &___FilterNameIgnoreCase_2; }
	inline void set_FilterNameIgnoreCase_2(MemberFilter_t25C1BD92C42BE94426E300787C13C452CB89B381 * value)
	{
		___FilterNameIgnoreCase_2 = value;
		Il2CppCodeGenWriteBarrier((&___FilterNameIgnoreCase_2), value);
	}

	inline static int32_t get_offset_of_Missing_3() { return static_cast<int32_t>(offsetof(Type_t_StaticFields, ___Missing_3)); }
	inline RuntimeObject * get_Missing_3() const { return ___Missing_3; }
	inline RuntimeObject ** get_address_of_Missing_3() { return &___Missing_3; }
	inline void set_Missing_3(RuntimeObject * value)
	{
		___Missing_3 = value;
		Il2CppCodeGenWriteBarrier((&___Missing_3), value);
	}

	inline static int32_t get_offset_of_Delimiter_4() { return static_cast<int32_t>(offsetof(Type_t_StaticFields, ___Delimiter_4)); }
	inline Il2CppChar get_Delimiter_4() const { return ___Delimiter_4; }
	inline Il2CppChar* get_address_of_Delimiter_4() { return &___Delimiter_4; }
	inline void set_Delimiter_4(Il2CppChar value)
	{
		___Delimiter_4 = value;
	}

	inline static int32_t get_offset_of_EmptyTypes_5() { return static_cast<int32_t>(offsetof(Type_t_StaticFields, ___EmptyTypes_5)); }
	inline TypeU5BU5D_t7FE623A666B49176DE123306221193E888A12F5F* get_EmptyTypes_5() const { return ___EmptyTypes_5; }
	inline TypeU5BU5D_t7FE623A666B49176DE123306221193E888A12F5F** get_address_of_EmptyTypes_5() { return &___EmptyTypes_5; }
	inline void set_EmptyTypes_5(TypeU5BU5D_t7FE623A666B49176DE123306221193E888A12F5F* value)
	{
		___EmptyTypes_5 = value;
		Il2CppCodeGenWriteBarrier((&___EmptyTypes_5), value);
	}

	inline static int32_t get_offset_of_defaultBinder_6() { return static_cast<int32_t>(offsetof(Type_t_StaticFields, ___defaultBinder_6)); }
	inline Binder_t4D5CB06963501D32847C057B57157D6DC49CA759 * get_defaultBinder_6() const { return ___defaultBinder_6; }
	inline Binder_t4D5CB06963501D32847C057B57157D6DC49CA759 ** get_address_of_defaultBinder_6() { return &___defaultBinder_6; }
	inline void set_defaultBinder_6(Binder_t4D5CB06963501D32847C057B57157D6DC49CA759 * value)
	{
		___defaultBinder_6 = value;
		Il2CppCodeGenWriteBarrier((&___defaultBinder_6), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // TYPE_T_H
#ifndef IL2CPPSETOPTIONATTRIBUTE_T013DDBAF8F39A8C8395B51A2549BCF893259611E_H
#define IL2CPPSETOPTIONATTRIBUTE_T013DDBAF8F39A8C8395B51A2549BCF893259611E_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute
struct  Il2CppSetOptionAttribute_t013DDBAF8F39A8C8395B51A2549BCF893259611E  : public Attribute_tF048C13FB3C8CFCC53F82290E4A3F621089F9A74
{
public:
	// Unity.IL2CPP.CompilerServices.Option Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute::<Option>k__BackingField
	int32_t ___U3COptionU3Ek__BackingField_0;
	// System.Object Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute::<Value>k__BackingField
	RuntimeObject * ___U3CValueU3Ek__BackingField_1;

public:
	inline static int32_t get_offset_of_U3COptionU3Ek__BackingField_0() { return static_cast<int32_t>(offsetof(Il2CppSetOptionAttribute_t013DDBAF8F39A8C8395B51A2549BCF893259611E, ___U3COptionU3Ek__BackingField_0)); }
	inline int32_t get_U3COptionU3Ek__BackingField_0() const { return ___U3COptionU3Ek__BackingField_0; }
	inline int32_t* get_address_of_U3COptionU3Ek__BackingField_0() { return &___U3COptionU3Ek__BackingField_0; }
	inline void set_U3COptionU3Ek__BackingField_0(int32_t value)
	{
		___U3COptionU3Ek__BackingField_0 = value;
	}

	inline static int32_t get_offset_of_U3CValueU3Ek__BackingField_1() { return static_cast<int32_t>(offsetof(Il2CppSetOptionAttribute_t013DDBAF8F39A8C8395B51A2549BCF893259611E, ___U3CValueU3Ek__BackingField_1)); }
	inline RuntimeObject * get_U3CValueU3Ek__BackingField_1() const { return ___U3CValueU3Ek__BackingField_1; }
	inline RuntimeObject ** get_address_of_U3CValueU3Ek__BackingField_1() { return &___U3CValueU3Ek__BackingField_1; }
	inline void set_U3CValueU3Ek__BackingField_1(RuntimeObject * value)
	{
		___U3CValueU3Ek__BackingField_1 = value;
		Il2CppCodeGenWriteBarrier((&___U3CValueU3Ek__BackingField_1), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // IL2CPPSETOPTIONATTRIBUTE_T013DDBAF8F39A8C8395B51A2549BCF893259611E_H
#ifndef COMPONENT_T05064EF382ABCAF4B8C94F8A350EA85184C26621_H
#define COMPONENT_T05064EF382ABCAF4B8C94F8A350EA85184C26621_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Component
struct  Component_t05064EF382ABCAF4B8C94F8A350EA85184C26621  : public Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // COMPONENT_T05064EF382ABCAF4B8C94F8A350EA85184C26621_H
#ifndef SCRIPTABLEOBJECT_TAB015486CEAB714DA0D5C1BA389B84FB90427734_H
#define SCRIPTABLEOBJECT_TAB015486CEAB714DA0D5C1BA389B84FB90427734_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.ScriptableObject
struct  ScriptableObject_tAB015486CEAB714DA0D5C1BA389B84FB90427734  : public Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// Native definition for P/Invoke marshalling of UnityEngine.ScriptableObject
struct ScriptableObject_tAB015486CEAB714DA0D5C1BA389B84FB90427734_marshaled_pinvoke : public Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0_marshaled_pinvoke
{
};
// Native definition for COM marshalling of UnityEngine.ScriptableObject
struct ScriptableObject_tAB015486CEAB714DA0D5C1BA389B84FB90427734_marshaled_com : public Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0_marshaled_com
{
};
#endif // SCRIPTABLEOBJECT_TAB015486CEAB714DA0D5C1BA389B84FB90427734_H
#ifndef DATAGAME_T550789F8B729098267FD582F1E101BD29282BC52_H
#define DATAGAME_T550789F8B729098267FD582F1E101BD29282BC52_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Pixeye.DataGame
struct  DataGame_t550789F8B729098267FD582F1E101BD29282BC52  : public ScriptableObject_tAB015486CEAB714DA0D5C1BA389B84FB90427734
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // DATAGAME_T550789F8B729098267FD582F1E101BD29282BC52_H
#ifndef FACTORY_TFA5041074647498CBAB64B0C4ABD43314393E7A5_H
#define FACTORY_TFA5041074647498CBAB64B0C4ABD43314393E7A5_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Pixeye.Factory
struct  Factory_tFA5041074647498CBAB64B0C4ABD43314393E7A5  : public ScriptableObject_tAB015486CEAB714DA0D5C1BA389B84FB90427734
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // FACTORY_TFA5041074647498CBAB64B0C4ABD43314393E7A5_H
#ifndef PLUGGABLE_TED235F8443B870F25950EF2914429DA66218ADAD_H
#define PLUGGABLE_TED235F8443B870F25950EF2914429DA66218ADAD_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Pixeye.Pluggable
struct  Pluggable_tED235F8443B870F25950EF2914429DA66218ADAD  : public ScriptableObject_tAB015486CEAB714DA0D5C1BA389B84FB90427734
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // PLUGGABLE_TED235F8443B870F25950EF2914429DA66218ADAD_H
#ifndef SCRIPT_T5CAA335E115304E821B2CF96BCD8065B4397105D_H
#define SCRIPT_T5CAA335E115304E821B2CF96BCD8065B4397105D_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Pixeye.Script
struct  Script_t5CAA335E115304E821B2CF96BCD8065B4397105D  : public ScriptableObject_tAB015486CEAB714DA0D5C1BA389B84FB90427734
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // SCRIPT_T5CAA335E115304E821B2CF96BCD8065B4397105D_H
#ifndef TEMPLATE_T5107412B0F7996BE75F25FE9E22600F4E7DA2CA9_H
#define TEMPLATE_T5107412B0F7996BE75F25FE9E22600F4E7DA2CA9_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Pixeye.Template
struct  Template_t5107412B0F7996BE75F25FE9E22600F4E7DA2CA9  : public ScriptableObject_tAB015486CEAB714DA0D5C1BA389B84FB90427734
{
public:
	// System.Collections.Generic.Dictionary`2<System.Int32,System.Object> Pixeye.Template::storage
	Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884 * ___storage_4;

public:
	inline static int32_t get_offset_of_storage_4() { return static_cast<int32_t>(offsetof(Template_t5107412B0F7996BE75F25FE9E22600F4E7DA2CA9, ___storage_4)); }
	inline Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884 * get_storage_4() const { return ___storage_4; }
	inline Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884 ** get_address_of_storage_4() { return &___storage_4; }
	inline void set_storage_4(Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884 * value)
	{
		___storage_4 = value;
		Il2CppCodeGenWriteBarrier((&___storage_4), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // TEMPLATE_T5107412B0F7996BE75F25FE9E22600F4E7DA2CA9_H
#ifndef TASKENTITY_TB8531E29867EAB8E27F86237A4F1F4BD04F72D38_H
#define TASKENTITY_TB8531E29867EAB8E27F86237A4F1F4BD04F72D38_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Pixeye.taskEntity
struct  taskEntity_tB8531E29867EAB8E27F86237A4F1F4BD04F72D38  : public MulticastDelegate_t
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // TASKENTITY_TB8531E29867EAB8E27F86237A4F1F4BD04F72D38_H
#ifndef TASKENTITYTICK_T17493A17530F9C48141A795A60FC76E0C9E35567_H
#define TASKENTITYTICK_T17493A17530F9C48141A795A60FC76E0C9E35567_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Pixeye.taskEntityTick
struct  taskEntityTick_t17493A17530F9C48141A795A60FC76E0C9E35567  : public MulticastDelegate_t
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // TASKENTITYTICK_T17493A17530F9C48141A795A60FC76E0C9E35567_H
#ifndef ACTION_T591D2A86165F896B4B800BB5C25CE18672A55579_H
#define ACTION_T591D2A86165F896B4B800BB5C25CE18672A55579_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Action
struct  Action_t591D2A86165F896B4B800BB5C25CE18672A55579  : public MulticastDelegate_t
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // ACTION_T591D2A86165F896B4B800BB5C25CE18672A55579_H
#ifndef ACTION_2_TEEECFD1333A361FF85D469EF54DA8E989E6B0D11_H
#define ACTION_2_TEEECFD1333A361FF85D469EF54DA8E989E6B0D11_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Action`2<System.Array,System.Int32[]>
struct  Action_2_tEEECFD1333A361FF85D469EF54DA8E989E6B0D11  : public MulticastDelegate_t
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // ACTION_2_TEEECFD1333A361FF85D469EF54DA8E989E6B0D11_H
#ifndef ASYNCCALLBACK_T3F3DA3BEDAEE81DD1D24125DF8EB30E85EE14DA4_H
#define ASYNCCALLBACK_T3F3DA3BEDAEE81DD1D24125DF8EB30E85EE14DA4_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.AsyncCallback
struct  AsyncCallback_t3F3DA3BEDAEE81DD1D24125DF8EB30E85EE14DA4  : public MulticastDelegate_t
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // ASYNCCALLBACK_T3F3DA3BEDAEE81DD1D24125DF8EB30E85EE14DA4_H
#ifndef FUNC_2_T8B737A62DCD6BCDB37818A2DFF357973A9317E8D_H
#define FUNC_2_T8B737A62DCD6BCDB37818A2DFF357973A9317E8D_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Func`2<System.Reflection.FieldInfo,System.Boolean>
struct  Func_2_t8B737A62DCD6BCDB37818A2DFF357973A9317E8D  : public MulticastDelegate_t
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // FUNC_2_T8B737A62DCD6BCDB37818A2DFF357973A9317E8D_H
#ifndef BEHAVIOUR_TBDC7E9C3C898AD8348891B82D3E345801D920CA8_H
#define BEHAVIOUR_TBDC7E9C3C898AD8348891B82D3E345801D920CA8_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Behaviour
struct  Behaviour_tBDC7E9C3C898AD8348891B82D3E345801D920CA8  : public Component_t05064EF382ABCAF4B8C94F8A350EA85184C26621
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // BEHAVIOUR_TBDC7E9C3C898AD8348891B82D3E345801D920CA8_H
#ifndef STATEMACHINEBEHAVIOUR_T698612ED92024B087045C388731B7673550C786C_H
#define STATEMACHINEBEHAVIOUR_T698612ED92024B087045C388731B7673550C786C_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.StateMachineBehaviour
struct  StateMachineBehaviour_t698612ED92024B087045C388731B7673550C786C  : public ScriptableObject_tAB015486CEAB714DA0D5C1BA389B84FB90427734
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // STATEMACHINEBEHAVIOUR_T698612ED92024B087045C388731B7673550C786C_H
#ifndef TRANSFORM_TBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA_H
#define TRANSFORM_TBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Transform
struct  Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA  : public Component_t05064EF382ABCAF4B8C94F8A350EA85184C26621
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // TRANSFORM_TBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA_H
#ifndef BASESTATEMACHINEBEHAVIOR_TC9B4D174C0E646DA37525E41FBB6A50C5DEEB064_H
#define BASESTATEMACHINEBEHAVIOR_TC9B4D174C0E646DA37525E41FBB6A50C5DEEB064_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Pixeye.BaseStateMachineBehavior
struct  BaseStateMachineBehavior_tC9B4D174C0E646DA37525E41FBB6A50C5DEEB064  : public StateMachineBehaviour_t698612ED92024B087045C388731B7673550C786C
{
public:
	// Pixeye.Actor Pixeye.BaseStateMachineBehavior::actor
	Actor_tC8E7F2C0FBC6266BB4ACD3F1D091F6AD50A15FEB * ___actor_4;

public:
	inline static int32_t get_offset_of_actor_4() { return static_cast<int32_t>(offsetof(BaseStateMachineBehavior_tC9B4D174C0E646DA37525E41FBB6A50C5DEEB064, ___actor_4)); }
	inline Actor_tC8E7F2C0FBC6266BB4ACD3F1D091F6AD50A15FEB * get_actor_4() const { return ___actor_4; }
	inline Actor_tC8E7F2C0FBC6266BB4ACD3F1D091F6AD50A15FEB ** get_address_of_actor_4() { return &___actor_4; }
	inline void set_actor_4(Actor_tC8E7F2C0FBC6266BB4ACD3F1D091F6AD50A15FEB * value)
	{
		___actor_4 = value;
		Il2CppCodeGenWriteBarrier((&___actor_4), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // BASESTATEMACHINEBEHAVIOR_TC9B4D174C0E646DA37525E41FBB6A50C5DEEB064_H
#ifndef ANIMATOR_TF1A88E66B3B731DDA75A066DBAE9C55837660F5A_H
#define ANIMATOR_TF1A88E66B3B731DDA75A066DBAE9C55837660F5A_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Animator
struct  Animator_tF1A88E66B3B731DDA75A066DBAE9C55837660F5A  : public Behaviour_tBDC7E9C3C898AD8348891B82D3E345801D920CA8
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // ANIMATOR_TF1A88E66B3B731DDA75A066DBAE9C55837660F5A_H
#ifndef MONOBEHAVIOUR_T4A60845CF505405AF8BE8C61CC07F75CADEF6429_H
#define MONOBEHAVIOUR_T4A60845CF505405AF8BE8C61CC07F75CADEF6429_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.MonoBehaviour
struct  MonoBehaviour_t4A60845CF505405AF8BE8C61CC07F75CADEF6429  : public Behaviour_tBDC7E9C3C898AD8348891B82D3E345801D920CA8
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // MONOBEHAVIOUR_T4A60845CF505405AF8BE8C61CC07F75CADEF6429_H
#ifndef HANDLEUPDATE_T2060842DBF2069E5F3DD3C37B41CA77A1C7B78A3_H
#define HANDLEUPDATE_T2060842DBF2069E5F3DD3C37B41CA77A1C7B78A3_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Pixeye.HandleUpdate
struct  HandleUpdate_t2060842DBF2069E5F3DD3C37B41CA77A1C7B78A3  : public MonoBehaviour_t4A60845CF505405AF8BE8C61CC07F75CADEF6429
{
public:
	// System.Collections.Generic.List`1<Pixeye.ITick> Pixeye.HandleUpdate::ticks
	List_1_t9B111270E51DA37359653F88A712407C7B2EF77F * ___ticks_4;
	// System.Collections.Generic.List`1<Pixeye.ITickFixed> Pixeye.HandleUpdate::ticksFixed
	List_1_tD2240B3110A6D99A40AAF7A287B8C034196C29F1 * ___ticksFixed_5;
	// System.Collections.Generic.List`1<Pixeye.ITickLate> Pixeye.HandleUpdate::ticksLate
	List_1_tA453498B219D45B426E6E2843D5AC42720A711B9 * ___ticksLate_6;
	// System.Int32 Pixeye.HandleUpdate::countTicks
	int32_t ___countTicks_8;
	// System.Int32 Pixeye.HandleUpdate::countTicksFixed
	int32_t ___countTicksFixed_9;
	// System.Int32 Pixeye.HandleUpdate::countTicksLate
	int32_t ___countTicksLate_10;

public:
	inline static int32_t get_offset_of_ticks_4() { return static_cast<int32_t>(offsetof(HandleUpdate_t2060842DBF2069E5F3DD3C37B41CA77A1C7B78A3, ___ticks_4)); }
	inline List_1_t9B111270E51DA37359653F88A712407C7B2EF77F * get_ticks_4() const { return ___ticks_4; }
	inline List_1_t9B111270E51DA37359653F88A712407C7B2EF77F ** get_address_of_ticks_4() { return &___ticks_4; }
	inline void set_ticks_4(List_1_t9B111270E51DA37359653F88A712407C7B2EF77F * value)
	{
		___ticks_4 = value;
		Il2CppCodeGenWriteBarrier((&___ticks_4), value);
	}

	inline static int32_t get_offset_of_ticksFixed_5() { return static_cast<int32_t>(offsetof(HandleUpdate_t2060842DBF2069E5F3DD3C37B41CA77A1C7B78A3, ___ticksFixed_5)); }
	inline List_1_tD2240B3110A6D99A40AAF7A287B8C034196C29F1 * get_ticksFixed_5() const { return ___ticksFixed_5; }
	inline List_1_tD2240B3110A6D99A40AAF7A287B8C034196C29F1 ** get_address_of_ticksFixed_5() { return &___ticksFixed_5; }
	inline void set_ticksFixed_5(List_1_tD2240B3110A6D99A40AAF7A287B8C034196C29F1 * value)
	{
		___ticksFixed_5 = value;
		Il2CppCodeGenWriteBarrier((&___ticksFixed_5), value);
	}

	inline static int32_t get_offset_of_ticksLate_6() { return static_cast<int32_t>(offsetof(HandleUpdate_t2060842DBF2069E5F3DD3C37B41CA77A1C7B78A3, ___ticksLate_6)); }
	inline List_1_tA453498B219D45B426E6E2843D5AC42720A711B9 * get_ticksLate_6() const { return ___ticksLate_6; }
	inline List_1_tA453498B219D45B426E6E2843D5AC42720A711B9 ** get_address_of_ticksLate_6() { return &___ticksLate_6; }
	inline void set_ticksLate_6(List_1_tA453498B219D45B426E6E2843D5AC42720A711B9 * value)
	{
		___ticksLate_6 = value;
		Il2CppCodeGenWriteBarrier((&___ticksLate_6), value);
	}

	inline static int32_t get_offset_of_countTicks_8() { return static_cast<int32_t>(offsetof(HandleUpdate_t2060842DBF2069E5F3DD3C37B41CA77A1C7B78A3, ___countTicks_8)); }
	inline int32_t get_countTicks_8() const { return ___countTicks_8; }
	inline int32_t* get_address_of_countTicks_8() { return &___countTicks_8; }
	inline void set_countTicks_8(int32_t value)
	{
		___countTicks_8 = value;
	}

	inline static int32_t get_offset_of_countTicksFixed_9() { return static_cast<int32_t>(offsetof(HandleUpdate_t2060842DBF2069E5F3DD3C37B41CA77A1C7B78A3, ___countTicksFixed_9)); }
	inline int32_t get_countTicksFixed_9() const { return ___countTicksFixed_9; }
	inline int32_t* get_address_of_countTicksFixed_9() { return &___countTicksFixed_9; }
	inline void set_countTicksFixed_9(int32_t value)
	{
		___countTicksFixed_9 = value;
	}

	inline static int32_t get_offset_of_countTicksLate_10() { return static_cast<int32_t>(offsetof(HandleUpdate_t2060842DBF2069E5F3DD3C37B41CA77A1C7B78A3, ___countTicksLate_10)); }
	inline int32_t get_countTicksLate_10() const { return ___countTicksLate_10; }
	inline int32_t* get_address_of_countTicksLate_10() { return &___countTicksLate_10; }
	inline void set_countTicksLate_10(int32_t value)
	{
		___countTicksLate_10 = value;
	}
};

struct HandleUpdate_t2060842DBF2069E5F3DD3C37B41CA77A1C7B78A3_StaticFields
{
public:
	// Pixeye.HandleUpdate Pixeye.HandleUpdate::Default
	HandleUpdate_t2060842DBF2069E5F3DD3C37B41CA77A1C7B78A3 * ___Default_7;

public:
	inline static int32_t get_offset_of_Default_7() { return static_cast<int32_t>(offsetof(HandleUpdate_t2060842DBF2069E5F3DD3C37B41CA77A1C7B78A3_StaticFields, ___Default_7)); }
	inline HandleUpdate_t2060842DBF2069E5F3DD3C37B41CA77A1C7B78A3 * get_Default_7() const { return ___Default_7; }
	inline HandleUpdate_t2060842DBF2069E5F3DD3C37B41CA77A1C7B78A3 ** get_address_of_Default_7() { return &___Default_7; }
	inline void set_Default_7(HandleUpdate_t2060842DBF2069E5F3DD3C37B41CA77A1C7B78A3 * value)
	{
		___Default_7 = value;
		Il2CppCodeGenWriteBarrier((&___Default_7), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // HANDLEUPDATE_T2060842DBF2069E5F3DD3C37B41CA77A1C7B78A3_H
#ifndef MONOENTITY_T7830FB0F2B957EA7B8C139189FF090C7B4EF2AE5_H
#define MONOENTITY_T7830FB0F2B957EA7B8C139189FF090C7B4EF2AE5_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Pixeye.MonoEntity
struct  MonoEntity_t7830FB0F2B957EA7B8C139189FF090C7B4EF2AE5  : public MonoBehaviour_t4A60845CF505405AF8BE8C61CC07F75CADEF6429
{
public:
	// Pixeye.ent Pixeye.MonoEntity::entity
	ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622  ___entity_4;
	// System.Boolean Pixeye.MonoEntity::conditionInitialized
	bool ___conditionInitialized_5;

public:
	inline static int32_t get_offset_of_entity_4() { return static_cast<int32_t>(offsetof(MonoEntity_t7830FB0F2B957EA7B8C139189FF090C7B4EF2AE5, ___entity_4)); }
	inline ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622  get_entity_4() const { return ___entity_4; }
	inline ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * get_address_of_entity_4() { return &___entity_4; }
	inline void set_entity_4(ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622  value)
	{
		___entity_4 = value;
	}

	inline static int32_t get_offset_of_conditionInitialized_5() { return static_cast<int32_t>(offsetof(MonoEntity_t7830FB0F2B957EA7B8C139189FF090C7B4EF2AE5, ___conditionInitialized_5)); }
	inline bool get_conditionInitialized_5() const { return ___conditionInitialized_5; }
	inline bool* get_address_of_conditionInitialized_5() { return &___conditionInitialized_5; }
	inline void set_conditionInitialized_5(bool value)
	{
		___conditionInitialized_5 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // MONOENTITY_T7830FB0F2B957EA7B8C139189FF090C7B4EF2AE5_H
#ifndef STARTER_T094EE6CE9643F0578E88871EBE1EE57879A38146_H
#define STARTER_T094EE6CE9643F0578E88871EBE1EE57879A38146_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Pixeye.Starter
struct  Starter_t094EE6CE9643F0578E88871EBE1EE57879A38146  : public MonoBehaviour_t4A60845CF505405AF8BE8C61CC07F75CADEF6429
{
public:
	// System.Collections.Generic.List`1<Pixeye.Factory> Pixeye.Starter::factories
	List_1_tA0E2AEAC02B0C34F5538C6D39174C6E22259F642 * ___factories_5;
	// System.Collections.Generic.List`1<Pixeye.SceneReference> Pixeye.Starter::ScenesToKeep
	List_1_t80222E8941042447035EF5455CC2D2B763E5AE8B * ___ScenesToKeep_6;
	// System.Collections.Generic.List`1<Pixeye.SceneReference> Pixeye.Starter::SceneDependsOn
	List_1_t80222E8941042447035EF5455CC2D2B763E5AE8B * ___SceneDependsOn_7;
	// System.Collections.Generic.List`1<Pixeye.PoolNode> Pixeye.Starter::nodes
	List_1_tF89465888600A0DC538773BB071C4AFEA6A8597E * ___nodes_8;

public:
	inline static int32_t get_offset_of_factories_5() { return static_cast<int32_t>(offsetof(Starter_t094EE6CE9643F0578E88871EBE1EE57879A38146, ___factories_5)); }
	inline List_1_tA0E2AEAC02B0C34F5538C6D39174C6E22259F642 * get_factories_5() const { return ___factories_5; }
	inline List_1_tA0E2AEAC02B0C34F5538C6D39174C6E22259F642 ** get_address_of_factories_5() { return &___factories_5; }
	inline void set_factories_5(List_1_tA0E2AEAC02B0C34F5538C6D39174C6E22259F642 * value)
	{
		___factories_5 = value;
		Il2CppCodeGenWriteBarrier((&___factories_5), value);
	}

	inline static int32_t get_offset_of_ScenesToKeep_6() { return static_cast<int32_t>(offsetof(Starter_t094EE6CE9643F0578E88871EBE1EE57879A38146, ___ScenesToKeep_6)); }
	inline List_1_t80222E8941042447035EF5455CC2D2B763E5AE8B * get_ScenesToKeep_6() const { return ___ScenesToKeep_6; }
	inline List_1_t80222E8941042447035EF5455CC2D2B763E5AE8B ** get_address_of_ScenesToKeep_6() { return &___ScenesToKeep_6; }
	inline void set_ScenesToKeep_6(List_1_t80222E8941042447035EF5455CC2D2B763E5AE8B * value)
	{
		___ScenesToKeep_6 = value;
		Il2CppCodeGenWriteBarrier((&___ScenesToKeep_6), value);
	}

	inline static int32_t get_offset_of_SceneDependsOn_7() { return static_cast<int32_t>(offsetof(Starter_t094EE6CE9643F0578E88871EBE1EE57879A38146, ___SceneDependsOn_7)); }
	inline List_1_t80222E8941042447035EF5455CC2D2B763E5AE8B * get_SceneDependsOn_7() const { return ___SceneDependsOn_7; }
	inline List_1_t80222E8941042447035EF5455CC2D2B763E5AE8B ** get_address_of_SceneDependsOn_7() { return &___SceneDependsOn_7; }
	inline void set_SceneDependsOn_7(List_1_t80222E8941042447035EF5455CC2D2B763E5AE8B * value)
	{
		___SceneDependsOn_7 = value;
		Il2CppCodeGenWriteBarrier((&___SceneDependsOn_7), value);
	}

	inline static int32_t get_offset_of_nodes_8() { return static_cast<int32_t>(offsetof(Starter_t094EE6CE9643F0578E88871EBE1EE57879A38146, ___nodes_8)); }
	inline List_1_tF89465888600A0DC538773BB071C4AFEA6A8597E * get_nodes_8() const { return ___nodes_8; }
	inline List_1_tF89465888600A0DC538773BB071C4AFEA6A8597E ** get_address_of_nodes_8() { return &___nodes_8; }
	inline void set_nodes_8(List_1_tF89465888600A0DC538773BB071C4AFEA6A8597E * value)
	{
		___nodes_8 = value;
		Il2CppCodeGenWriteBarrier((&___nodes_8), value);
	}
};

struct Starter_t094EE6CE9643F0578E88871EBE1EE57879A38146_StaticFields
{
public:
	// System.Boolean Pixeye.Starter::initialized
	bool ___initialized_4;

public:
	inline static int32_t get_offset_of_initialized_4() { return static_cast<int32_t>(offsetof(Starter_t094EE6CE9643F0578E88871EBE1EE57879A38146_StaticFields, ___initialized_4)); }
	inline bool get_initialized_4() const { return ___initialized_4; }
	inline bool* get_address_of_initialized_4() { return &___initialized_4; }
	inline void set_initialized_4(bool value)
	{
		___initialized_4 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // STARTER_T094EE6CE9643F0578E88871EBE1EE57879A38146_H
#ifndef STARTERKERNEL_T383AD5285BEE52A4F9F6FDBE97E01A368CE25E27_H
#define STARTERKERNEL_T383AD5285BEE52A4F9F6FDBE97E01A368CE25E27_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Pixeye.StarterKernel
struct  StarterKernel_t383AD5285BEE52A4F9F6FDBE97E01A368CE25E27  : public MonoBehaviour_t4A60845CF505405AF8BE8C61CC07F75CADEF6429
{
public:
	// Pixeye.DataGame Pixeye.StarterKernel::gameSession
	DataGame_t550789F8B729098267FD582F1E101BD29282BC52 * ___gameSession_4;
	// Pixeye.DataGame Pixeye.StarterKernel::gameSettings
	DataGame_t550789F8B729098267FD582F1E101BD29282BC52 * ___gameSettings_5;
	// System.Collections.Generic.List`1<Pixeye.Pluggable> Pixeye.StarterKernel::pluggables
	List_1_t2D6D202FD59CE78CF20816E533E40E75EF42A211 * ___pluggables_6;

public:
	inline static int32_t get_offset_of_gameSession_4() { return static_cast<int32_t>(offsetof(StarterKernel_t383AD5285BEE52A4F9F6FDBE97E01A368CE25E27, ___gameSession_4)); }
	inline DataGame_t550789F8B729098267FD582F1E101BD29282BC52 * get_gameSession_4() const { return ___gameSession_4; }
	inline DataGame_t550789F8B729098267FD582F1E101BD29282BC52 ** get_address_of_gameSession_4() { return &___gameSession_4; }
	inline void set_gameSession_4(DataGame_t550789F8B729098267FD582F1E101BD29282BC52 * value)
	{
		___gameSession_4 = value;
		Il2CppCodeGenWriteBarrier((&___gameSession_4), value);
	}

	inline static int32_t get_offset_of_gameSettings_5() { return static_cast<int32_t>(offsetof(StarterKernel_t383AD5285BEE52A4F9F6FDBE97E01A368CE25E27, ___gameSettings_5)); }
	inline DataGame_t550789F8B729098267FD582F1E101BD29282BC52 * get_gameSettings_5() const { return ___gameSettings_5; }
	inline DataGame_t550789F8B729098267FD582F1E101BD29282BC52 ** get_address_of_gameSettings_5() { return &___gameSettings_5; }
	inline void set_gameSettings_5(DataGame_t550789F8B729098267FD582F1E101BD29282BC52 * value)
	{
		___gameSettings_5 = value;
		Il2CppCodeGenWriteBarrier((&___gameSettings_5), value);
	}

	inline static int32_t get_offset_of_pluggables_6() { return static_cast<int32_t>(offsetof(StarterKernel_t383AD5285BEE52A4F9F6FDBE97E01A368CE25E27, ___pluggables_6)); }
	inline List_1_t2D6D202FD59CE78CF20816E533E40E75EF42A211 * get_pluggables_6() const { return ___pluggables_6; }
	inline List_1_t2D6D202FD59CE78CF20816E533E40E75EF42A211 ** get_address_of_pluggables_6() { return &___pluggables_6; }
	inline void set_pluggables_6(List_1_t2D6D202FD59CE78CF20816E533E40E75EF42A211 * value)
	{
		___pluggables_6 = value;
		Il2CppCodeGenWriteBarrier((&___pluggables_6), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // STARTERKERNEL_T383AD5285BEE52A4F9F6FDBE97E01A368CE25E27_H
#ifndef SINGLETON_1_T70D00C90A652BD47B1B663FC32A13A31E56C12C6_H
#define SINGLETON_1_T70D00C90A652BD47B1B663FC32A13A31E56C12C6_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Singleton`1<Pixeye.Toolbox>
struct  Singleton_1_t70D00C90A652BD47B1B663FC32A13A31E56C12C6  : public MonoBehaviour_t4A60845CF505405AF8BE8C61CC07F75CADEF6429
{
public:

public:
};

struct Singleton_1_t70D00C90A652BD47B1B663FC32A13A31E56C12C6_StaticFields
{
public:
	// T Singleton`1::_instance
	Toolbox_t081ED4540597D09C31B0F9430D6D377D6BA90E3A * ____instance_4;
	// System.Object Singleton`1::_lock
	RuntimeObject * ____lock_5;
	// System.Boolean Singleton`1::changingScene
	bool ___changingScene_6;
	// System.Boolean Singleton`1::applicationIsQuitting
	bool ___applicationIsQuitting_7;

public:
	inline static int32_t get_offset_of__instance_4() { return static_cast<int32_t>(offsetof(Singleton_1_t70D00C90A652BD47B1B663FC32A13A31E56C12C6_StaticFields, ____instance_4)); }
	inline Toolbox_t081ED4540597D09C31B0F9430D6D377D6BA90E3A * get__instance_4() const { return ____instance_4; }
	inline Toolbox_t081ED4540597D09C31B0F9430D6D377D6BA90E3A ** get_address_of__instance_4() { return &____instance_4; }
	inline void set__instance_4(Toolbox_t081ED4540597D09C31B0F9430D6D377D6BA90E3A * value)
	{
		____instance_4 = value;
		Il2CppCodeGenWriteBarrier((&____instance_4), value);
	}

	inline static int32_t get_offset_of__lock_5() { return static_cast<int32_t>(offsetof(Singleton_1_t70D00C90A652BD47B1B663FC32A13A31E56C12C6_StaticFields, ____lock_5)); }
	inline RuntimeObject * get__lock_5() const { return ____lock_5; }
	inline RuntimeObject ** get_address_of__lock_5() { return &____lock_5; }
	inline void set__lock_5(RuntimeObject * value)
	{
		____lock_5 = value;
		Il2CppCodeGenWriteBarrier((&____lock_5), value);
	}

	inline static int32_t get_offset_of_changingScene_6() { return static_cast<int32_t>(offsetof(Singleton_1_t70D00C90A652BD47B1B663FC32A13A31E56C12C6_StaticFields, ___changingScene_6)); }
	inline bool get_changingScene_6() const { return ___changingScene_6; }
	inline bool* get_address_of_changingScene_6() { return &___changingScene_6; }
	inline void set_changingScene_6(bool value)
	{
		___changingScene_6 = value;
	}

	inline static int32_t get_offset_of_applicationIsQuitting_7() { return static_cast<int32_t>(offsetof(Singleton_1_t70D00C90A652BD47B1B663FC32A13A31E56C12C6_StaticFields, ___applicationIsQuitting_7)); }
	inline bool get_applicationIsQuitting_7() const { return ___applicationIsQuitting_7; }
	inline bool* get_address_of_applicationIsQuitting_7() { return &___applicationIsQuitting_7; }
	inline void set_applicationIsQuitting_7(bool value)
	{
		___applicationIsQuitting_7 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // SINGLETON_1_T70D00C90A652BD47B1B663FC32A13A31E56C12C6_H
#ifndef ACTOR_TC8E7F2C0FBC6266BB4ACD3F1D091F6AD50A15FEB_H
#define ACTOR_TC8E7F2C0FBC6266BB4ACD3F1D091F6AD50A15FEB_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Pixeye.Actor
struct  Actor_tC8E7F2C0FBC6266BB4ACD3F1D091F6AD50A15FEB  : public MonoEntity_t7830FB0F2B957EA7B8C139189FF090C7B4EF2AE5
{
public:
	// System.Int32 Pixeye.Actor::pool
	int32_t ___pool_6;
	// System.Boolean Pixeye.Actor::conditionManualDeploy
	bool ___conditionManualDeploy_7;

public:
	inline static int32_t get_offset_of_pool_6() { return static_cast<int32_t>(offsetof(Actor_tC8E7F2C0FBC6266BB4ACD3F1D091F6AD50A15FEB, ___pool_6)); }
	inline int32_t get_pool_6() const { return ___pool_6; }
	inline int32_t* get_address_of_pool_6() { return &___pool_6; }
	inline void set_pool_6(int32_t value)
	{
		___pool_6 = value;
	}

	inline static int32_t get_offset_of_conditionManualDeploy_7() { return static_cast<int32_t>(offsetof(Actor_tC8E7F2C0FBC6266BB4ACD3F1D091F6AD50A15FEB, ___conditionManualDeploy_7)); }
	inline bool get_conditionManualDeploy_7() const { return ___conditionManualDeploy_7; }
	inline bool* get_address_of_conditionManualDeploy_7() { return &___conditionManualDeploy_7; }
	inline void set_conditionManualDeploy_7(bool value)
	{
		___conditionManualDeploy_7 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // ACTOR_TC8E7F2C0FBC6266BB4ACD3F1D091F6AD50A15FEB_H
#ifndef TOOLBOX_T081ED4540597D09C31B0F9430D6D377D6BA90E3A_H
#define TOOLBOX_T081ED4540597D09C31B0F9430D6D377D6BA90E3A_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Pixeye.Toolbox
struct  Toolbox_t081ED4540597D09C31B0F9430D6D377D6BA90E3A  : public Singleton_1_t70D00C90A652BD47B1B663FC32A13A31E56C12C6
{
public:
	// System.Collections.Generic.Dictionary`2<System.Int32,System.Object> Pixeye.Toolbox::data
	Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884 * ___data_8;

public:
	inline static int32_t get_offset_of_data_8() { return static_cast<int32_t>(offsetof(Toolbox_t081ED4540597D09C31B0F9430D6D377D6BA90E3A, ___data_8)); }
	inline Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884 * get_data_8() const { return ___data_8; }
	inline Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884 ** get_address_of_data_8() { return &___data_8; }
	inline void set_data_8(Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884 * value)
	{
		___data_8 = value;
		Il2CppCodeGenWriteBarrier((&___data_8), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // TOOLBOX_T081ED4540597D09C31B0F9430D6D377D6BA90E3A_H
// System.Type[]
struct TypeU5BU5D_t7FE623A666B49176DE123306221193E888A12F5F  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) Type_t * m_Items[1];

public:
	inline Type_t * GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Type_t ** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Type_t * value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
	inline Type_t * GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Type_t ** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Type_t * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
};
// System.Int32[]
struct Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) int32_t m_Items[1];

public:
	inline int32_t GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline int32_t* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, int32_t value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline int32_t GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline int32_t* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, int32_t value)
	{
		m_Items[index] = value;
	}
};
// Pixeye.BaseStateMachineBehavior[]
struct BaseStateMachineBehaviorU5BU5D_t69541BC5FF78E6A8031B638080B9821EA0364911  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) BaseStateMachineBehavior_tC9B4D174C0E646DA37525E41FBB6A50C5DEEB064 * m_Items[1];

public:
	inline BaseStateMachineBehavior_tC9B4D174C0E646DA37525E41FBB6A50C5DEEB064 * GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline BaseStateMachineBehavior_tC9B4D174C0E646DA37525E41FBB6A50C5DEEB064 ** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, BaseStateMachineBehavior_tC9B4D174C0E646DA37525E41FBB6A50C5DEEB064 * value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
	inline BaseStateMachineBehavior_tC9B4D174C0E646DA37525E41FBB6A50C5DEEB064 * GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline BaseStateMachineBehavior_tC9B4D174C0E646DA37525E41FBB6A50C5DEEB064 ** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, BaseStateMachineBehavior_tC9B4D174C0E646DA37525E41FBB6A50C5DEEB064 * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
};
// UnityEngine.MonoBehaviour[]
struct MonoBehaviourU5BU5D_tEC81C7491112CB97F70976A67ABB8C33168F5F0A  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) MonoBehaviour_t4A60845CF505405AF8BE8C61CC07F75CADEF6429 * m_Items[1];

public:
	inline MonoBehaviour_t4A60845CF505405AF8BE8C61CC07F75CADEF6429 * GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline MonoBehaviour_t4A60845CF505405AF8BE8C61CC07F75CADEF6429 ** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, MonoBehaviour_t4A60845CF505405AF8BE8C61CC07F75CADEF6429 * value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
	inline MonoBehaviour_t4A60845CF505405AF8BE8C61CC07F75CADEF6429 * GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline MonoBehaviour_t4A60845CF505405AF8BE8C61CC07F75CADEF6429 ** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, MonoBehaviour_t4A60845CF505405AF8BE8C61CC07F75CADEF6429 * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
};
// System.Collections.Generic.Dictionary`2<System.Int32,System.Int32>[]
struct Dictionary_2U5BU5D_t5A34008586C648E4C1725CB098BCFE11124FEC7E  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * m_Items[1];

public:
	inline Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 ** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
	inline Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 ** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
};
// Pixeye.DelayTagEvent[]
struct DelayTagEventU5BU5D_t7C4AB33A74B954415C9AF4B6E5D707E0CF3AA45F  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) DelayTagEvent_tBFFD54C27E705D5B8CD1C5C49B4094A01A88BE02  m_Items[1];

public:
	inline DelayTagEvent_tBFFD54C27E705D5B8CD1C5C49B4094A01A88BE02  GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline DelayTagEvent_tBFFD54C27E705D5B8CD1C5C49B4094A01A88BE02 * GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, DelayTagEvent_tBFFD54C27E705D5B8CD1C5C49B4094A01A88BE02  value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline DelayTagEvent_tBFFD54C27E705D5B8CD1C5C49B4094A01A88BE02  GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline DelayTagEvent_tBFFD54C27E705D5B8CD1C5C49B4094A01A88BE02 * GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, DelayTagEvent_tBFFD54C27E705D5B8CD1C5C49B4094A01A88BE02  value)
	{
		m_Items[index] = value;
	}
};
// System.Boolean[]
struct BooleanU5BU5D_t192C7579715690E25BD5EFED47F3E0FC9DCB2040  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) bool m_Items[1];

public:
	inline bool GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline bool* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, bool value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline bool GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline bool* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, bool value)
	{
		m_Items[index] = value;
	}
};
// UnityEngine.Transform[]
struct TransformU5BU5D_t3EB9781D1A1DE2674F0632C956A66AA423343139  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * m_Items[1];

public:
	inline Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA ** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
	inline Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA ** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
};
// System.Delegate[]
struct DelegateU5BU5D_tDFCDEE2A6322F96C0FE49AF47E9ADB8C4B294E86  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) Delegate_t * m_Items[1];

public:
	inline Delegate_t * GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Delegate_t ** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Delegate_t * value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
	inline Delegate_t * GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Delegate_t ** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Delegate_t * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
};
// System.Object[]
struct ObjectU5BU5D_t3C9242B5C88A48B2A5BD9FDA6CD0024E792AF08A  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) RuntimeObject * m_Items[1];

public:
	inline RuntimeObject * GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline RuntimeObject ** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, RuntimeObject * value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
	inline RuntimeObject * GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline RuntimeObject ** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, RuntimeObject * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
};
// System.Reflection.FieldInfo[]
struct FieldInfoU5BU5D_t9C36FA93372CA01DAF85946064B058CD9CE2E8BE  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) FieldInfo_t * m_Items[1];

public:
	inline FieldInfo_t * GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline FieldInfo_t ** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, FieldInfo_t * value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
	inline FieldInfo_t * GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline FieldInfo_t ** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, FieldInfo_t * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
};


// !!0[] UnityEngine.Animator::GetBehaviours<System.Object>()
extern "C" IL2CPP_METHOD_ATTR ObjectU5BU5D_t3C9242B5C88A48B2A5BD9FDA6CD0024E792AF08A* Animator_GetBehaviours_TisRuntimeObject_m21725534AF83444538813F6C231D08139A051FBB_gshared (Animator_tF1A88E66B3B731DDA75A066DBAE9C55837660F5A * __this, const RuntimeMethod* method);
// !0 System.Collections.Generic.List`1<System.Object>::get_Item(System.Int32)
extern "C" IL2CPP_METHOD_ATTR RuntimeObject * List_1_get_Item_mFDB8AD680C600072736579BBF5F38F7416396588_gshared (List_1_t05CC3C859AB5E6024394EF9A42E3E696628CA02D * __this, int32_t p0, const RuntimeMethod* method);
// System.Int32 System.Collections.Generic.List`1<System.Object>::get_Count()
extern "C" IL2CPP_METHOD_ATTR int32_t List_1_get_Count_m507C9149FF7F83AAC72C29091E745D557DA47D22_gshared (List_1_t05CC3C859AB5E6024394EF9A42E3E696628CA02D * __this, const RuntimeMethod* method);
// System.Collections.Generic.List`1/Enumerator<!0> System.Collections.Generic.List`1<System.Object>::GetEnumerator()
extern "C" IL2CPP_METHOD_ATTR Enumerator_tE0C99528D3DCE5863566CE37BD94162A4C0431CD  List_1_GetEnumerator_m52CC760E475D226A2B75048D70C4E22692F9F68D_gshared (List_1_t05CC3C859AB5E6024394EF9A42E3E696628CA02D * __this, const RuntimeMethod* method);
// !0 System.Collections.Generic.List`1/Enumerator<System.Object>::get_Current()
extern "C" IL2CPP_METHOD_ATTR RuntimeObject * Enumerator_get_Current_mD7829C7E8CFBEDD463B15A951CDE9B90A12CC55C_gshared (Enumerator_tE0C99528D3DCE5863566CE37BD94162A4C0431CD * __this, const RuntimeMethod* method);
// System.Boolean System.Collections.Generic.List`1/Enumerator<System.Object>::MoveNext()
extern "C" IL2CPP_METHOD_ATTR bool Enumerator_MoveNext_m38B1099DDAD7EEDE2F4CDAB11C095AC784AC2E34_gshared (Enumerator_tE0C99528D3DCE5863566CE37BD94162A4C0431CD * __this, const RuntimeMethod* method);
// System.Void System.Collections.Generic.List`1/Enumerator<System.Object>::Dispose()
extern "C" IL2CPP_METHOD_ATTR void Enumerator_Dispose_m94D0DAE031619503CDA6E53C5C3CC78AF3139472_gshared (Enumerator_tE0C99528D3DCE5863566CE37BD94162A4C0431CD * __this, const RuntimeMethod* method);
// T Pixeye.Starter::Add<System.Object>()
extern "C" IL2CPP_METHOD_ATTR RuntimeObject * Starter_Add_TisRuntimeObject_m38853AD225572F57D051AE53C15A4976DEC4DA91_gshared (const RuntimeMethod* method);
// !!0[] UnityEngine.Object::FindObjectsOfType<System.Object>()
extern "C" IL2CPP_METHOD_ATTR ObjectU5BU5D_t3C9242B5C88A48B2A5BD9FDA6CD0024E792AF08A* Object_FindObjectsOfType_TisRuntimeObject_mE570B614F68E0A19BD5F65061CDA9BEE6EDBD159_gshared (const RuntimeMethod* method);
// System.Void System.Collections.Generic.List`1<System.Object>::.ctor()
extern "C" IL2CPP_METHOD_ATTR void List_1__ctor_mC832F1AC0F814BAEB19175F5D7972A7507508BC3_gshared (List_1_t05CC3C859AB5E6024394EF9A42E3E696628CA02D * __this, const RuntimeMethod* method);
// System.Void Pixeye.HandleFastPool`1<System.Object>::Populate(System.Int32)
extern "C" IL2CPP_METHOD_ATTR void HandleFastPool_1_Populate_m93D093F712C10355A05ED3194F7577FD914D4106_gshared (HandleFastPool_1_t1772C28F3B42E90C5AF36647F51804CD2E530834 * __this, int32_t p0, const RuntimeMethod* method);
// System.Void System.Collections.Generic.List`1<System.Object>::.ctor(System.Int32)
extern "C" IL2CPP_METHOD_ATTR void List_1__ctor_mEE468B81D8E7C140F567D10FF7F5894A50EEEA57_gshared (List_1_t05CC3C859AB5E6024394EF9A42E3E696628CA02D * __this, int32_t p0, const RuntimeMethod* method);
// System.Void System.Collections.Generic.Dictionary`2<System.Int32,System.Object>::.ctor(System.Collections.Generic.IEqualityComparer`1<!0>)
extern "C" IL2CPP_METHOD_ATTR void Dictionary_2__ctor_mF1DF43B33035DC426AFE5554E1095A2F1DDDD188_gshared (Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884 * __this, RuntimeObject* p0, const RuntimeMethod* method);
// System.Void System.Array::Resize<System.Object>(!!0[]&,System.Int32)
extern "C" IL2CPP_METHOD_ATTR void Array_Resize_TisRuntimeObject_m4D085923555AC38307156B34C6F0CBC2873E38B7_gshared (ObjectU5BU5D_t3C9242B5C88A48B2A5BD9FDA6CD0024E792AF08A** p0, int32_t p1, const RuntimeMethod* method);
// System.Void System.Collections.Generic.Dictionary`2<System.Int32,System.Int32>::.ctor(System.Int32,System.Collections.Generic.IEqualityComparer`1<!0>)
extern "C" IL2CPP_METHOD_ATTR void Dictionary_2__ctor_m114B4A2B0BD22B817FE14C1E5CB04881D63D4E20_gshared (Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * __this, int32_t p0, RuntimeObject* p1, const RuntimeMethod* method);
// System.Void System.Collections.Generic.Dictionary`2<System.Int32,System.Int32>::Clear()
extern "C" IL2CPP_METHOD_ATTR void Dictionary_2_Clear_m7DE8E346650F09FFAB65ABCACFEBCB2FAB2F4499_gshared (Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * __this, const RuntimeMethod* method);
// System.Boolean Singleton`1<System.Object>::isQuittingOrChangingScene()
extern "C" IL2CPP_METHOD_ATTR bool Singleton_1_isQuittingOrChangingScene_m5ECCE8338F17AEB58924A9F47901BAE5D91C4157_gshared (const RuntimeMethod* method);
// System.Void System.Array::Resize<Pixeye.DelayTagEvent>(!!0[]&,System.Int32)
extern "C" IL2CPP_METHOD_ATTR void Array_Resize_TisDelayTagEvent_tBFFD54C27E705D5B8CD1C5C49B4094A01A88BE02_mCF48F79088FD98AB2563B66CE05477C477974B0B_gshared (DelayTagEventU5BU5D_t7C4AB33A74B954415C9AF4B6E5D707E0CF3AA45F** p0, int32_t p1, const RuntimeMethod* method);
// System.Boolean System.Collections.Generic.Dictionary`2<System.Int32,System.Int32>::TryGetValue(!0,!1&)
extern "C" IL2CPP_METHOD_ATTR bool Dictionary_2_TryGetValue_mF63B7CEA87637EBDF9463BD38E61F29EB10148CC_gshared (Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * __this, int32_t p0, int32_t* p1, const RuntimeMethod* method);
// System.Boolean System.Collections.Generic.Dictionary`2<System.Int32,System.Int32>::Remove(!0)
extern "C" IL2CPP_METHOD_ATTR bool Dictionary_2_Remove_m8E04EF60FB32880A72708207DB1CC4555C2E476F_gshared (Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * __this, int32_t p0, const RuntimeMethod* method);
// System.Void System.Collections.Generic.Dictionary`2<System.Int32,System.Int32>::set_Item(!0,!1)
extern "C" IL2CPP_METHOD_ATTR void Dictionary_2_set_Item_mEA07C9AE7BBAF67BC9CFE20D200A464725D1F7FA_gshared (Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * __this, int32_t p0, int32_t p1, const RuntimeMethod* method);
// System.Boolean System.Collections.Generic.Dictionary`2<System.Int32,System.Int32>::ContainsKey(!0)
extern "C" IL2CPP_METHOD_ATTR bool Dictionary_2_ContainsKey_mBC44DAB119CBE7A4B7820ABF12AD024A4654471E_gshared (Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * __this, int32_t p0, const RuntimeMethod* method);
// !1 System.Collections.Generic.Dictionary`2<System.Int32,System.Int32>::get_Item(!0)
extern "C" IL2CPP_METHOD_ATTR int32_t Dictionary_2_get_Item_mFB950EA5BD4A89CD6EAA8D0CB45D665091FAA7E1_gshared (Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * __this, int32_t p0, const RuntimeMethod* method);
// System.Void System.Collections.Generic.Dictionary`2<System.Int32,System.Int32>::Add(!0,!1)
extern "C" IL2CPP_METHOD_ATTR void Dictionary_2_Add_mDC25A2F4744B497C39F127D97327CC7B56E68903_gshared (Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * __this, int32_t p0, int32_t p1, const RuntimeMethod* method);
// System.Void System.Collections.Generic.Dictionary`2<System.Int32,System.Object>::.ctor(System.Int32,System.Collections.Generic.IEqualityComparer`1<!0>)
extern "C" IL2CPP_METHOD_ATTR void Dictionary_2__ctor_m0F87B73520F2A9CD71CF45B4561785C1C42E8111_gshared (Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884 * __this, int32_t p0, RuntimeObject* p1, const RuntimeMethod* method);
// System.Void System.Collections.Generic.Dictionary`2<System.Int32,System.Object>::Clear()
extern "C" IL2CPP_METHOD_ATTR void Dictionary_2_Clear_m8B31D0EA3C1FCE4C6977A76829773DA0D127E217_gshared (Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884 * __this, const RuntimeMethod* method);
// System.Void System.Collections.Generic.Dictionary`2<System.Int32,System.Object>::.ctor()
extern "C" IL2CPP_METHOD_ATTR void Dictionary_2__ctor_m7D745ADE56151C2895459668F4A4242985E526D8_gshared (Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884 * __this, const RuntimeMethod* method);
// System.Boolean System.Collections.Generic.Dictionary`2<Pixeye.TimerKey,System.Object>::TryGetValue(!0,!1&)
extern "C" IL2CPP_METHOD_ATTR bool Dictionary_2_TryGetValue_m1C6AB025550FEB3B174D90CD732C3B2BED4C8CE2_gshared (Dictionary_2_t58EC087653A1C1C8F4A74F620C874867E3DE1D55 * __this, TimerKey_tCE6BF602B11E3FE849B05CC16BE0650A88755F89  p0, RuntimeObject ** p1, const RuntimeMethod* method);
// System.Void System.Collections.Generic.List`1<System.Object>::Add(!0)
extern "C" IL2CPP_METHOD_ATTR void List_1_Add_m6930161974C7504C80F52EC379EF012387D43138_gshared (List_1_t05CC3C859AB5E6024394EF9A42E3E696628CA02D * __this, RuntimeObject * p0, const RuntimeMethod* method);
// System.Void System.Collections.Generic.Dictionary`2<Pixeye.TimerKey,System.Object>::Add(!0,!1)
extern "C" IL2CPP_METHOD_ATTR void Dictionary_2_Add_m61952C05DDE1987456C5EA8B75194C0E6AD5CDA4_gshared (Dictionary_2_t58EC087653A1C1C8F4A74F620C874867E3DE1D55 * __this, TimerKey_tCE6BF602B11E3FE849B05CC16BE0650A88755F89  p0, RuntimeObject * p1, const RuntimeMethod* method);
// System.Boolean System.Collections.Generic.List`1<System.Object>::Remove(!0)
extern "C" IL2CPP_METHOD_ATTR bool List_1_Remove_m908B647BB9F807676DACE34E3E73475C3C3751D4_gshared (List_1_t05CC3C859AB5E6024394EF9A42E3E696628CA02D * __this, RuntimeObject * p0, const RuntimeMethod* method);
// System.Void System.Collections.Generic.Dictionary`2<Pixeye.TimerKey,System.Object>::.ctor(System.Int32)
extern "C" IL2CPP_METHOD_ATTR void Dictionary_2__ctor_m8B02BD7F77D1A2CE3373A561D558E915A86D253C_gshared (Dictionary_2_t58EC087653A1C1C8F4A74F620C874867E3DE1D55 * __this, int32_t p0, const RuntimeMethod* method);
// T Singleton`1<System.Object>::get_Instance()
extern "C" IL2CPP_METHOD_ATTR RuntimeObject * Singleton_1_get_Instance_m6013518CA5BC1AE89DD7A2B1024D53EBC0A2B529_gshared (const RuntimeMethod* method);
// System.Boolean System.Collections.Generic.Dictionary`2<System.Int32,System.Object>::TryGetValue(!0,!1&)
extern "C" IL2CPP_METHOD_ATTR bool Dictionary_2_TryGetValue_m867F6DA953678D0333A55270B7C6EF38EFC293FF_gshared (Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884 * __this, int32_t p0, RuntimeObject ** p1, const RuntimeMethod* method);
// !!0 UnityEngine.Object::Instantiate<System.Object>(!!0)
extern "C" IL2CPP_METHOD_ATTR RuntimeObject * Object_Instantiate_TisRuntimeObject_mEF511C369E0CA9462FD3427DFC2375E81469570F_gshared (RuntimeObject * p0, const RuntimeMethod* method);
// System.Void System.Collections.Generic.Dictionary`2<System.Int32,System.Object>::Add(!0,!1)
extern "C" IL2CPP_METHOD_ATTR void Dictionary_2_Add_mF7AEA0EFA07EEBC1A4B283A26A7CB720EE7A4C20_gshared (Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884 * __this, int32_t p0, RuntimeObject * p1, const RuntimeMethod* method);
// System.Boolean System.Collections.Generic.Dictionary`2<System.Int32,System.Object>::Remove(!0)
extern "C" IL2CPP_METHOD_ATTR bool Dictionary_2_Remove_m2204D6D532702FD13AB2A9AD8DB538E4E8FB1913_gshared (Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884 * __this, int32_t p0, const RuntimeMethod* method);
// System.Void System.Collections.Generic.List`1<System.Int32>::.ctor()
extern "C" IL2CPP_METHOD_ATTR void List_1__ctor_mA7F9F92F641CEECFD9D8CFDC667568A05FFD27B4_gshared (List_1_tE1526161A558A17A39A8B69D8EEF3801393B6226 * __this, const RuntimeMethod* method);
// System.Collections.Generic.Dictionary`2/Enumerator<!0,!1> System.Collections.Generic.Dictionary`2<System.Int32,System.Object>::GetEnumerator()
extern "C" IL2CPP_METHOD_ATTR Enumerator_t72A8231827DB93FC8B25F08FF066377F7B773DA1  Dictionary_2_GetEnumerator_mE47C13FC1B2BACBEE6F795B0E40E6406CAC55D4B_gshared (Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884 * __this, const RuntimeMethod* method);
// System.Collections.Generic.KeyValuePair`2<!0,!1> System.Collections.Generic.Dictionary`2/Enumerator<System.Int32,System.Object>::get_Current()
extern "C" IL2CPP_METHOD_ATTR KeyValuePair_2_t142B50DAD5164EBD2E1495FD821B1A4C3233FA26  Enumerator_get_Current_m73F8FC135A20BDFEA0846D8FC876863ED85FEA49_gshared (Enumerator_t72A8231827DB93FC8B25F08FF066377F7B773DA1 * __this, const RuntimeMethod* method);
// !1 System.Collections.Generic.KeyValuePair`2<System.Int32,System.Object>::get_Value()
extern "C" IL2CPP_METHOD_ATTR RuntimeObject * KeyValuePair_2_get_Value_mAD6801F3BC9BA1E99D4E0F72B2B420182D0494FC_gshared (KeyValuePair_2_t142B50DAD5164EBD2E1495FD821B1A4C3233FA26 * __this, const RuntimeMethod* method);
// !0 System.Collections.Generic.KeyValuePair`2<System.Int32,System.Object>::get_Key()
extern "C" IL2CPP_METHOD_ATTR int32_t KeyValuePair_2_get_Key_m89B687D373FBE3D230647CA0C536235E12AD829C_gshared (KeyValuePair_2_t142B50DAD5164EBD2E1495FD821B1A4C3233FA26 * __this, const RuntimeMethod* method);
// System.Void System.Collections.Generic.List`1<System.Int32>::Add(!0)
extern "C" IL2CPP_METHOD_ATTR void List_1_Add_m50C0D1F69B2EF31137658E2F052EBBAC7BF82771_gshared (List_1_tE1526161A558A17A39A8B69D8EEF3801393B6226 * __this, int32_t p0, const RuntimeMethod* method);
// System.Boolean System.Collections.Generic.Dictionary`2/Enumerator<System.Int32,System.Object>::MoveNext()
extern "C" IL2CPP_METHOD_ATTR bool Enumerator_MoveNext_m637AE52AC4BDE5BEB1D89BE4B75E49B4C328EFC9_gshared (Enumerator_t72A8231827DB93FC8B25F08FF066377F7B773DA1 * __this, const RuntimeMethod* method);
// System.Void System.Collections.Generic.Dictionary`2/Enumerator<System.Int32,System.Object>::Dispose()
extern "C" IL2CPP_METHOD_ATTR void Enumerator_Dispose_m772E7049D8DA96AF5021EA09C3E6322CD4BFBDFC_gshared (Enumerator_t72A8231827DB93FC8B25F08FF066377F7B773DA1 * __this, const RuntimeMethod* method);
// !0 System.Collections.Generic.List`1<System.Int32>::get_Item(System.Int32)
extern "C" IL2CPP_METHOD_ATTR int32_t List_1_get_Item_mB62D52423AF52EEC13B4317DD86E6A5BBDF41BD2_gshared (List_1_tE1526161A558A17A39A8B69D8EEF3801393B6226 * __this, int32_t p0, const RuntimeMethod* method);
// System.Int32 System.Collections.Generic.List`1<System.Int32>::get_Count()
extern "C" IL2CPP_METHOD_ATTR int32_t List_1_get_Count_m52793036D5E41E8E25DCC5C033380C44D7596903_gshared (List_1_tE1526161A558A17A39A8B69D8EEF3801393B6226 * __this, const RuntimeMethod* method);
// System.Void Singleton`1<System.Object>::.ctor()
extern "C" IL2CPP_METHOD_ATTR void Singleton_1__ctor_mF0D65AF0B365EBE4E51BE5CA42A2C65783AE80B0_gshared (Singleton_1_t0274AA8C219E3C1AC9EFC99CA9F0E94174205873 * __this, const RuntimeMethod* method);
// T Pixeye.EntityComposer::Add<System.Object>()
extern "C" IL2CPP_METHOD_ATTR RuntimeObject * EntityComposer_Add_TisRuntimeObject_mD60C78EFF966479F708D5EBD8842F0AF053034C7_gshared (EntityComposer_tB9CD47E805A3232A943F6CF48BB084FB1646CCD3 * __this, const RuntimeMethod* method);
// System.Void System.Action`2<System.Object,System.Object>::Invoke(!0,!1)
extern "C" IL2CPP_METHOD_ATTR void Action_2_Invoke_m1738FFAE74BE5E599FD42520FA2BEF69D1AC4709_gshared (Action_2_t0DB6FD6F515527EAB552B690A291778C6F00D48C * __this, RuntimeObject * p0, RuntimeObject * p1, const RuntimeMethod* method);
// System.Void System.Collections.Generic.Dictionary`2<System.Object,System.Object>::.ctor(System.Collections.Generic.IEqualityComparer`1<!0>)
extern "C" IL2CPP_METHOD_ATTR void Dictionary_2__ctor_m76CDCB0C7BECE95DBA94C7C98467F297E4451EE7_gshared (Dictionary_2_t32F25F093828AA9F93CB11C2A2B4648FD62A09BA * __this, RuntimeObject* p0, const RuntimeMethod* method);
// System.Void System.Action`2<System.Object,System.Object>::.ctor(System.Object,System.IntPtr)
extern "C" IL2CPP_METHOD_ATTR void Action_2__ctor_mB83B0C1C61CED5B54803D334FFC7187881D32EFB_gshared (Action_2_t0DB6FD6F515527EAB552B690A291778C6F00D48C * __this, RuntimeObject * p0, intptr_t p1, const RuntimeMethod* method);
// System.Void System.Func`2<System.Object,System.Boolean>::.ctor(System.Object,System.IntPtr)
extern "C" IL2CPP_METHOD_ATTR void Func_2__ctor_m5153AE6EE06BA488EF3D92A0DCF7E4EF530961B5_gshared (Func_2_t7EE965B791A606D187CCB69569A433D4CBB36879 * __this, RuntimeObject * p0, intptr_t p1, const RuntimeMethod* method);
// !1 System.Func`2<System.Object,System.Boolean>::Invoke(!0)
extern "C" IL2CPP_METHOD_ATTR bool Func_2_Invoke_mE25788DCE25515291EAA06F55BEF30F9F27FBBA9_gshared (Func_2_t7EE965B791A606D187CCB69569A433D4CBB36879 * __this, RuntimeObject * p0, const RuntimeMethod* method);
// System.Void System.Collections.Generic.EqualityComparer`1<System.Object>::.ctor()
extern "C" IL2CPP_METHOD_ATTR void EqualityComparer_1__ctor_m2B03FB26184C766345AA072BEA38AA745AE2E192_gshared (EqualityComparer_1_t54972BA287ED38B066E4BE7A3B21F49803B62EBA * __this, const RuntimeMethod* method);

// System.Void System.Object::.ctor()
extern "C" IL2CPP_METHOD_ATTR void Object__ctor_m925ECA5E85CA100E3FB86A4F9E15C120E9A184C0 (RuntimeObject * __this, const RuntimeMethod* method);
// System.Void System.Attribute::.ctor()
extern "C" IL2CPP_METHOD_ATTR void Attribute__ctor_m45CAD4B01265CC84CC5A84F62EE2DBE85DE89EC0 (Attribute_tF048C13FB3C8CFCC53F82290E4A3F621089F9A74 * __this, const RuntimeMethod* method);
// !!0[] UnityEngine.Animator::GetBehaviours<Pixeye.BaseStateMachineBehavior>()
inline BaseStateMachineBehaviorU5BU5D_t69541BC5FF78E6A8031B638080B9821EA0364911* Animator_GetBehaviours_TisBaseStateMachineBehavior_tC9B4D174C0E646DA37525E41FBB6A50C5DEEB064_mF2F48ED60DFB77DBA14E860AE010F54C9E4ED04B (Animator_tF1A88E66B3B731DDA75A066DBAE9C55837660F5A * __this, const RuntimeMethod* method)
{
	return ((  BaseStateMachineBehaviorU5BU5D_t69541BC5FF78E6A8031B638080B9821EA0364911* (*) (Animator_tF1A88E66B3B731DDA75A066DBAE9C55837660F5A *, const RuntimeMethod*))Animator_GetBehaviours_TisRuntimeObject_m21725534AF83444538813F6C231D08139A051FBB_gshared)(__this, method);
}
// System.Void Pixeye.BaseStateMachineBehavior::Setup(Pixeye.Actor)
extern "C" IL2CPP_METHOD_ATTR void BaseStateMachineBehavior_Setup_m021799DFB3AACCC67BDE6F6179B97567790F7A4B (BaseStateMachineBehavior_tC9B4D174C0E646DA37525E41FBB6A50C5DEEB064 * __this, Actor_tC8E7F2C0FBC6266BB4ACD3F1D091F6AD50A15FEB * ___actor0, const RuntimeMethod* method);
// System.String Pixeye.SceneReference::get_Path()
extern "C" IL2CPP_METHOD_ATTR String_t* SceneReference_get_Path_mB04B812EFDB313EE0A501C4984EBD823BE8E146F (SceneReference_t824B30D7B4AAF610B0DBC1F5F54227F2BB69685F * __this, const RuntimeMethod* method);
// System.Void UnityEngine.ScriptableObject::.ctor()
extern "C" IL2CPP_METHOD_ATTR void ScriptableObject__ctor_m6E2B3821A4A361556FC12E9B1C71E1D5DC002C5B (ScriptableObject_tAB015486CEAB714DA0D5C1BA389B84FB90427734 * __this, const RuntimeMethod* method);
// System.Boolean UnityEngine.Object::op_Equality(UnityEngine.Object,UnityEngine.Object)
extern "C" IL2CPP_METHOD_ATTR bool Object_op_Equality_mBC2401774F3BE33E8CF6F0A8148E66C95D6CFF1C (Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0 * p0, Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0 * p1, const RuntimeMethod* method);
// System.Void Pixeye.HandleUpdate::Create()
extern "C" IL2CPP_METHOD_ATTR void HandleUpdate_Create_m70DFEE53D4C60B71D3957265BA2D839C76A76072 (const RuntimeMethod* method);
// System.Void Pixeye.HandleScene::Setup(System.Collections.Generic.List`1<Pixeye.SceneReference>,System.Collections.Generic.List`1<Pixeye.SceneReference>,Pixeye.Starter)
extern "C" IL2CPP_METHOD_ATTR void HandleScene_Setup_m5A7756A3739938F1AA79C6373C8100A27A11BCD2 (HandleScene_t9A17EE1370450F47652A7C56B9D20A02A7BA1728 * __this, List_1_t80222E8941042447035EF5455CC2D2B763E5AE8B * ___scenesToKeep0, List_1_t80222E8941042447035EF5455CC2D2B763E5AE8B * ___sceneDependsOn1, Starter_t094EE6CE9643F0578E88871EBE1EE57879A38146 * ___starter2, const RuntimeMethod* method);
// !0 System.Collections.Generic.List`1<Pixeye.PoolNode>::get_Item(System.Int32)
inline PoolNode_tD412A3A536E55E03495943E9F456B844ACBB2568 * List_1_get_Item_mAAD89C5F555E6D9E8A6BD72F7E8C6105B9E04789 (List_1_tF89465888600A0DC538773BB071C4AFEA6A8597E * __this, int32_t p0, const RuntimeMethod* method)
{
	return ((  PoolNode_tD412A3A536E55E03495943E9F456B844ACBB2568 * (*) (List_1_tF89465888600A0DC538773BB071C4AFEA6A8597E *, int32_t, const RuntimeMethod*))List_1_get_Item_mFDB8AD680C600072736579BBF5F38F7416396588_gshared)(__this, p0, method);
}
// System.Void Pixeye.PoolNode::Populate()
extern "C" IL2CPP_METHOD_ATTR void PoolNode_Populate_m1820B61B055864A65E0FC800C94F84C65A88E2E5 (PoolNode_tD412A3A536E55E03495943E9F456B844ACBB2568 * __this, const RuntimeMethod* method);
// System.Int32 System.Collections.Generic.List`1<Pixeye.PoolNode>::get_Count()
inline int32_t List_1_get_Count_mEDAF9F74023B67E06EFC1B56D8F15202AE3E8C36 (List_1_tF89465888600A0DC538773BB071C4AFEA6A8597E * __this, const RuntimeMethod* method)
{
	return ((  int32_t (*) (List_1_tF89465888600A0DC538773BB071C4AFEA6A8597E *, const RuntimeMethod*))List_1_get_Count_m507C9149FF7F83AAC72C29091E745D557DA47D22_gshared)(__this, method);
}
// System.Collections.Generic.List`1/Enumerator<!0> System.Collections.Generic.List`1<Pixeye.Factory>::GetEnumerator()
inline Enumerator_tCCCA7DEF5437A9668FAB3E25F19542413527939A  List_1_GetEnumerator_mCBF188196E6175158D5266EEDFD0D4BB30B62115 (List_1_tA0E2AEAC02B0C34F5538C6D39174C6E22259F642 * __this, const RuntimeMethod* method)
{
	return ((  Enumerator_tCCCA7DEF5437A9668FAB3E25F19542413527939A  (*) (List_1_tA0E2AEAC02B0C34F5538C6D39174C6E22259F642 *, const RuntimeMethod*))List_1_GetEnumerator_m52CC760E475D226A2B75048D70C4E22692F9F68D_gshared)(__this, method);
}
// !0 System.Collections.Generic.List`1/Enumerator<Pixeye.Factory>::get_Current()
inline Factory_tFA5041074647498CBAB64B0C4ABD43314393E7A5 * Enumerator_get_Current_m67516B76FD35F63A1B24DAA385BF84A83964D641 (Enumerator_tCCCA7DEF5437A9668FAB3E25F19542413527939A * __this, const RuntimeMethod* method)
{
	return ((  Factory_tFA5041074647498CBAB64B0C4ABD43314393E7A5 * (*) (Enumerator_tCCCA7DEF5437A9668FAB3E25F19542413527939A *, const RuntimeMethod*))Enumerator_get_Current_mD7829C7E8CFBEDD463B15A951CDE9B90A12CC55C_gshared)(__this, method);
}
// System.Void Pixeye.Toolbox::Add(System.Object)
extern "C" IL2CPP_METHOD_ATTR void Toolbox_Add_mBDBD189E3DF0F0617BEB2FF6ECC08CC748DB4FF9 (RuntimeObject * ___obj0, const RuntimeMethod* method);
// System.Boolean System.Collections.Generic.List`1/Enumerator<Pixeye.Factory>::MoveNext()
inline bool Enumerator_MoveNext_mB2585B01CD7E37F43666F5349D25C40BBF37DAB0 (Enumerator_tCCCA7DEF5437A9668FAB3E25F19542413527939A * __this, const RuntimeMethod* method)
{
	return ((  bool (*) (Enumerator_tCCCA7DEF5437A9668FAB3E25F19542413527939A *, const RuntimeMethod*))Enumerator_MoveNext_m38B1099DDAD7EEDE2F4CDAB11C095AC784AC2E34_gshared)(__this, method);
}
// System.Void System.Collections.Generic.List`1/Enumerator<Pixeye.Factory>::Dispose()
inline void Enumerator_Dispose_m00358105CD68F800EAC90C662F3CBA417D034906 (Enumerator_tCCCA7DEF5437A9668FAB3E25F19542413527939A * __this, const RuntimeMethod* method)
{
	((  void (*) (Enumerator_tCCCA7DEF5437A9668FAB3E25F19542413527939A *, const RuntimeMethod*))Enumerator_Dispose_m94D0DAE031619503CDA6E53C5C3CC78AF3139472_gshared)(__this, method);
}
// T Pixeye.Starter::Add<Pixeye.HandleActorsAdd>()
inline HandleActorsAdd_t8D5278068F1EACBBF9799D835738C552E5550F9E * Starter_Add_TisHandleActorsAdd_t8D5278068F1EACBBF9799D835738C552E5550F9E_mA560947496F70A63FF412D33E89301B4DF85B112 (const RuntimeMethod* method)
{
	return ((  HandleActorsAdd_t8D5278068F1EACBBF9799D835738C552E5550F9E * (*) (const RuntimeMethod*))Starter_Add_TisRuntimeObject_m38853AD225572F57D051AE53C15A4976DEC4DA91_gshared)(method);
}
// !!0[] UnityEngine.Object::FindObjectsOfType<UnityEngine.MonoBehaviour>()
inline MonoBehaviourU5BU5D_tEC81C7491112CB97F70976A67ABB8C33168F5F0A* Object_FindObjectsOfType_TisMonoBehaviour_t4A60845CF505405AF8BE8C61CC07F75CADEF6429_m3BD4005DB6D046DA65FFD7427BE77F266D98D13B (const RuntimeMethod* method)
{
	return ((  MonoBehaviourU5BU5D_tEC81C7491112CB97F70976A67ABB8C33168F5F0A* (*) (const RuntimeMethod*))Object_FindObjectsOfType_TisRuntimeObject_mE570B614F68E0A19BD5F65061CDA9BEE6EDBD159_gshared)(method);
}
// System.Single Pixeye.Time::get_deltaFixed()
extern "C" IL2CPP_METHOD_ATTR float Time_get_deltaFixed_mC41C8B31BC0F5F34522AF1B72CE977D5E07A490E (const RuntimeMethod* method);
// System.Void System.Action::.ctor(System.Object,System.IntPtr)
extern "C" IL2CPP_METHOD_ATTR void Action__ctor_m570E96B2A0C48BC1DC6788460316191F24572760 (Action_t591D2A86165F896B4B800BB5C25CE18672A55579 * __this, RuntimeObject * p0, intptr_t p1, const RuntimeMethod* method);
// Pixeye.Timer Pixeye.Timer::Add(System.Single,System.Action)
extern "C" IL2CPP_METHOD_ATTR Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * Timer_Add_mFA7866CEC7552E59E915183E6405C77CFAA61207 (float ___finishTime0, Action_t591D2A86165F896B4B800BB5C25CE18672A55579 * ___action1, const RuntimeMethod* method);
// System.Void System.Collections.Generic.List`1<Pixeye.PoolNode>::.ctor()
inline void List_1__ctor_m9461BD0419807AF9A434D9C6D4E95A1C4ABF4759 (List_1_tF89465888600A0DC538773BB071C4AFEA6A8597E * __this, const RuntimeMethod* method)
{
	((  void (*) (List_1_tF89465888600A0DC538773BB071C4AFEA6A8597E *, const RuntimeMethod*))List_1__ctor_mC832F1AC0F814BAEB19175F5D7972A7507508BC3_gshared)(__this, method);
}
// System.Void UnityEngine.MonoBehaviour::.ctor()
extern "C" IL2CPP_METHOD_ATTR void MonoBehaviour__ctor_mEAEC84B222C60319D593E456D769B3311DFCEF97 (MonoBehaviour_t4A60845CF505405AF8BE8C61CC07F75CADEF6429 * __this, const RuntimeMethod* method);
// T Pixeye.Starter::Add<Pixeye.HandleActorsRemove>()
inline HandleActorsRemove_t775454EB912F9A2B222D5E61FA84C2DE6EFFAEA7 * Starter_Add_TisHandleActorsRemove_t775454EB912F9A2B222D5E61FA84C2DE6EFFAEA7_m713D123155C4DAEC92D33D1F2DC1740CACDE86C5 (const RuntimeMethod* method)
{
	return ((  HandleActorsRemove_t775454EB912F9A2B222D5E61FA84C2DE6EFFAEA7 * (*) (const RuntimeMethod*))Starter_Add_TisRuntimeObject_m38853AD225572F57D051AE53C15A4976DEC4DA91_gshared)(method);
}
// !0 System.Collections.Generic.List`1<Pixeye.Pluggable>::get_Item(System.Int32)
inline Pluggable_tED235F8443B870F25950EF2914429DA66218ADAD * List_1_get_Item_m54372A031C118324F5CEE30AB6FFEDA511E874E8 (List_1_t2D6D202FD59CE78CF20816E533E40E75EF42A211 * __this, int32_t p0, const RuntimeMethod* method)
{
	return ((  Pluggable_tED235F8443B870F25950EF2914429DA66218ADAD * (*) (List_1_t2D6D202FD59CE78CF20816E533E40E75EF42A211 *, int32_t, const RuntimeMethod*))List_1_get_Item_mFDB8AD680C600072736579BBF5F38F7416396588_gshared)(__this, p0, method);
}
// System.Int32 System.Collections.Generic.List`1<Pixeye.Pluggable>::get_Count()
inline int32_t List_1_get_Count_m83C0B08646B75C0726AF3C49B42E96B63CF78BB0 (List_1_t2D6D202FD59CE78CF20816E533E40E75EF42A211 * __this, const RuntimeMethod* method)
{
	return ((  int32_t (*) (List_1_t2D6D202FD59CE78CF20816E533E40E75EF42A211 *, const RuntimeMethod*))List_1_get_Count_m507C9149FF7F83AAC72C29091E745D557DA47D22_gshared)(__this, method);
}
// System.Boolean UnityEngine.Object::op_Inequality(UnityEngine.Object,UnityEngine.Object)
extern "C" IL2CPP_METHOD_ATTR bool Object_op_Inequality_m31EF58E217E8F4BDD3E409DEF79E1AEE95874FC1 (Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0 * p0, Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0 * p1, const RuntimeMethod* method);
// System.Void Pixeye.HandleFastPool`1<Pixeye.Timer>::Populate(System.Int32)
inline void HandleFastPool_1_Populate_m9622D906DBE9E77119FF081D14CE50800C6B1CED (HandleFastPool_1_t717E0511090B921AEE3A8436B7B8AB6BC1A0C0AD * __this, int32_t p0, const RuntimeMethod* method)
{
	((  void (*) (HandleFastPool_1_t717E0511090B921AEE3A8436B7B8AB6BC1A0C0AD *, int32_t, const RuntimeMethod*))HandleFastPool_1_Populate_m93D093F712C10355A05ED3194F7577FD914D4106_gshared)(__this, p0, method);
}
// System.Void Pixeye.StarterKernel/<OnApplicationFocus>d__4::.ctor(System.Int32)
extern "C" IL2CPP_METHOD_ATTR void U3COnApplicationFocusU3Ed__4__ctor_m6B39E880A6828370D4A2E2A3C4AF1E0C43796613 (U3COnApplicationFocusU3Ed__4_t6A81BE9FFD6951A1410B57DFD8BCA01E3D3AF5E4 * __this, int32_t ___U3CU3E1__state0, const RuntimeMethod* method);
// System.Void System.Collections.Generic.List`1<Pixeye.Pluggable>::.ctor()
inline void List_1__ctor_m1DAC5E4BC778402B5E74A5A4FDCE1AA28E4B3EF5 (List_1_t2D6D202FD59CE78CF20816E533E40E75EF42A211 * __this, const RuntimeMethod* method)
{
	((  void (*) (List_1_t2D6D202FD59CE78CF20816E533E40E75EF42A211 *, const RuntimeMethod*))List_1__ctor_mC832F1AC0F814BAEB19175F5D7972A7507508BC3_gshared)(__this, method);
}
// System.Boolean UnityEngine.Application::get_runInBackground()
extern "C" IL2CPP_METHOD_ATTR bool Application_get_runInBackground_m58DA93E02B92B98222A1F937265A1F6C13487D9B (const RuntimeMethod* method);
// System.Void UnityEngine.WaitForSeconds::.ctor(System.Single)
extern "C" IL2CPP_METHOD_ATTR void WaitForSeconds__ctor_m8E4BA3E27AEFFE5B74A815F26FF8AAB99743F559 (WaitForSeconds_t3E9E78D3BB53F03F96C7F28BA9B9086CD1A5F4E8 * __this, float p0, const RuntimeMethod* method);
// System.Void System.NotSupportedException::.ctor()
extern "C" IL2CPP_METHOD_ATTR void NotSupportedException__ctor_mA121DE1CAC8F25277DEB489DC7771209D91CAE33 (NotSupportedException_tE75B318D6590A02A5D9B29FD97409B1750FA0010 * __this, const RuntimeMethod* method);
// System.Void System.Collections.Generic.List`1<Pixeye.Storage>::.ctor(System.Int32)
inline void List_1__ctor_m596CC86831CDC5B16D847683293A5E3090036F2E (List_1_t186D2009EAF545D4056FD040D409D10C57CE8F97 * __this, int32_t p0, const RuntimeMethod* method)
{
	((  void (*) (List_1_t186D2009EAF545D4056FD040D409D10C57CE8F97 *, int32_t, const RuntimeMethod*))List_1__ctor_mEE468B81D8E7C140F567D10FF7F5894A50EEEA57_gshared)(__this, p0, method);
}
// System.Void FastComparable::.ctor()
extern "C" IL2CPP_METHOD_ATTR void FastComparable__ctor_m3F034079FFB5E1F69208BF84CF6F3FFDF2084997 (FastComparable_t85AACE6CEBE4B0D7FB16B2F3D09523B7BC4AA1A8 * __this, const RuntimeMethod* method);
// System.Void System.Collections.Generic.Dictionary`2<System.Int32,Pixeye.Storage>::.ctor(System.Collections.Generic.IEqualityComparer`1<!0>)
inline void Dictionary_2__ctor_mAFB74AF308004F87E52B2F21945C4FFDADF4F8AF (Dictionary_2_t683E72069DD61C3D055254F6694A3E646C6B3622 * __this, RuntimeObject* p0, const RuntimeMethod* method)
{
	((  void (*) (Dictionary_2_t683E72069DD61C3D055254F6694A3E646C6B3622 *, RuntimeObject*, const RuntimeMethod*))Dictionary_2__ctor_mF1DF43B33035DC426AFE5554E1095A2F1DDDD188_gshared)(__this, p0, method);
}
// System.Void System.Array::Resize<System.Collections.Generic.Dictionary`2<System.Int32,System.Int32>>(!!0[]&,System.Int32)
inline void Array_Resize_TisDictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8_mD91BBCB688FE146E5FB901FDD5924A4C3D1D6742 (Dictionary_2U5BU5D_t5A34008586C648E4C1725CB098BCFE11124FEC7E** p0, int32_t p1, const RuntimeMethod* method)
{
	((  void (*) (Dictionary_2U5BU5D_t5A34008586C648E4C1725CB098BCFE11124FEC7E**, int32_t, const RuntimeMethod*))Array_Resize_TisRuntimeObject_m4D085923555AC38307156B34C6F0CBC2873E38B7_gshared)(p0, p1, method);
}
// System.Void System.Collections.Generic.Dictionary`2<System.Int32,System.Int32>::.ctor(System.Int32,System.Collections.Generic.IEqualityComparer`1<!0>)
inline void Dictionary_2__ctor_m114B4A2B0BD22B817FE14C1E5CB04881D63D4E20 (Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * __this, int32_t p0, RuntimeObject* p1, const RuntimeMethod* method)
{
	((  void (*) (Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 *, int32_t, RuntimeObject*, const RuntimeMethod*))Dictionary_2__ctor_m114B4A2B0BD22B817FE14C1E5CB04881D63D4E20_gshared)(__this, p0, p1, method);
}
// System.Void System.Collections.Generic.Dictionary`2<System.Int32,System.Int32>::Clear()
inline void Dictionary_2_Clear_m7DE8E346650F09FFAB65ABCACFEBCB2FAB2F4499 (Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * __this, const RuntimeMethod* method)
{
	((  void (*) (Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 *, const RuntimeMethod*))Dictionary_2_Clear_m7DE8E346650F09FFAB65ABCACFEBCB2FAB2F4499_gshared)(__this, method);
}
// System.Boolean Singleton`1<Pixeye.Toolbox>::isQuittingOrChangingScene()
inline bool Singleton_1_isQuittingOrChangingScene_m4D5ABD228FA0FB2265D3D3BEEAD1FB0EFC43EDAF (const RuntimeMethod* method)
{
	return ((  bool (*) (const RuntimeMethod*))Singleton_1_isQuittingOrChangingScene_m5ECCE8338F17AEB58924A9F47901BAE5D91C4157_gshared)(method);
}
// System.Int32 Pixeye.ent::op_Implicit(Pixeye.ent)
extern "C" IL2CPP_METHOD_ATTR int32_t ent_op_Implicit_m16BC2A28ED2D8A104FC8CB8BF31A2CA6B2DD42CD (ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622  ___value0, const RuntimeMethod* method);
// System.Void System.Array::Resize<Pixeye.DelayTagEvent>(!!0[]&,System.Int32)
inline void Array_Resize_TisDelayTagEvent_tBFFD54C27E705D5B8CD1C5C49B4094A01A88BE02_mCF48F79088FD98AB2563B66CE05477C477974B0B (DelayTagEventU5BU5D_t7C4AB33A74B954415C9AF4B6E5D707E0CF3AA45F** p0, int32_t p1, const RuntimeMethod* method)
{
	((  void (*) (DelayTagEventU5BU5D_t7C4AB33A74B954415C9AF4B6E5D707E0CF3AA45F**, int32_t, const RuntimeMethod*))Array_Resize_TisDelayTagEvent_tBFFD54C27E705D5B8CD1C5C49B4094A01A88BE02_mCF48F79088FD98AB2563B66CE05477C477974B0B_gshared)(p0, p1, method);
}
// System.Boolean System.Collections.Generic.Dictionary`2<System.Int32,System.Int32>::TryGetValue(!0,!1&)
inline bool Dictionary_2_TryGetValue_mF63B7CEA87637EBDF9463BD38E61F29EB10148CC (Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * __this, int32_t p0, int32_t* p1, const RuntimeMethod* method)
{
	return ((  bool (*) (Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 *, int32_t, int32_t*, const RuntimeMethod*))Dictionary_2_TryGetValue_mF63B7CEA87637EBDF9463BD38E61F29EB10148CC_gshared)(__this, p0, p1, method);
}
// System.Int32 System.Math::Max(System.Int32,System.Int32)
extern "C" IL2CPP_METHOD_ATTR int32_t Math_Max_mA99E48BB021F2E4B62D4EA9F52EA6928EED618A2 (int32_t p0, int32_t p1, const RuntimeMethod* method);
// System.Boolean System.Collections.Generic.Dictionary`2<System.Int32,System.Int32>::Remove(!0)
inline bool Dictionary_2_Remove_m8E04EF60FB32880A72708207DB1CC4555C2E476F (Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * __this, int32_t p0, const RuntimeMethod* method)
{
	return ((  bool (*) (Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 *, int32_t, const RuntimeMethod*))Dictionary_2_Remove_m8E04EF60FB32880A72708207DB1CC4555C2E476F_gshared)(__this, p0, method);
}
// System.Void Pixeye.StorageTags::HandleChange(Pixeye.ent&,System.Int32)
extern "C" IL2CPP_METHOD_ATTR void StorageTags_HandleChange_m4BD1475868B1DBAA90A56C0F26FDD0471D120FA1 (ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * ___entity0, int32_t ___tag1, const RuntimeMethod* method);
// System.Void System.Collections.Generic.Dictionary`2<System.Int32,System.Int32>::set_Item(!0,!1)
inline void Dictionary_2_set_Item_mEA07C9AE7BBAF67BC9CFE20D200A464725D1F7FA (Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * __this, int32_t p0, int32_t p1, const RuntimeMethod* method)
{
	((  void (*) (Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 *, int32_t, int32_t, const RuntimeMethod*))Dictionary_2_set_Item_mEA07C9AE7BBAF67BC9CFE20D200A464725D1F7FA_gshared)(__this, p0, p1, method);
}
// System.Boolean System.Collections.Generic.Dictionary`2<System.Int32,System.Int32>::ContainsKey(!0)
inline bool Dictionary_2_ContainsKey_mBC44DAB119CBE7A4B7820ABF12AD024A4654471E (Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * __this, int32_t p0, const RuntimeMethod* method)
{
	return ((  bool (*) (Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 *, int32_t, const RuntimeMethod*))Dictionary_2_ContainsKey_mBC44DAB119CBE7A4B7820ABF12AD024A4654471E_gshared)(__this, p0, method);
}
// !1 System.Collections.Generic.Dictionary`2<System.Int32,System.Int32>::get_Item(!0)
inline int32_t Dictionary_2_get_Item_mFB950EA5BD4A89CD6EAA8D0CB45D665091FAA7E1 (Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * __this, int32_t p0, const RuntimeMethod* method)
{
	return ((  int32_t (*) (Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 *, int32_t, const RuntimeMethod*))Dictionary_2_get_Item_mFB950EA5BD4A89CD6EAA8D0CB45D665091FAA7E1_gshared)(__this, p0, method);
}
// System.Void System.Collections.Generic.Dictionary`2<System.Int32,System.Int32>::Add(!0,!1)
inline void Dictionary_2_Add_mDC25A2F4744B497C39F127D97327CC7B56E68903 (Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * __this, int32_t p0, int32_t p1, const RuntimeMethod* method)
{
	((  void (*) (Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 *, int32_t, int32_t, const RuntimeMethod*))Dictionary_2_Add_mDC25A2F4744B497C39F127D97327CC7B56E68903_gshared)(__this, p0, p1, method);
}
// System.Void System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<Pixeye.GroupBase>>::.ctor(System.Int32,System.Collections.Generic.IEqualityComparer`1<!0>)
inline void Dictionary_2__ctor_m7E3DE5565E761320FA45B5A083B35E77466B2756 (Dictionary_2_t62CC83140A4EC1BB76940D6FD31E9B3B8417C850 * __this, int32_t p0, RuntimeObject* p1, const RuntimeMethod* method)
{
	((  void (*) (Dictionary_2_t62CC83140A4EC1BB76940D6FD31E9B3B8417C850 *, int32_t, RuntimeObject*, const RuntimeMethod*))Dictionary_2__ctor_m0F87B73520F2A9CD71CF45B4561785C1C42E8111_gshared)(__this, p0, p1, method);
}
// System.Void UnityEngine.PropertyAttribute::.ctor()
extern "C" IL2CPP_METHOD_ATTR void PropertyAttribute__ctor_m7F5C473F39D5601486C1127DA0D52F2DC293FC35 (PropertyAttribute_t25BFFC093C9C96E3CCF4EAB36F5DC6F937B1FA54 * __this, const RuntimeMethod* method);
// System.Void System.Collections.Generic.Dictionary`2<System.Int32,System.Object>::Clear()
inline void Dictionary_2_Clear_m8B31D0EA3C1FCE4C6977A76829773DA0D127E217 (Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884 * __this, const RuntimeMethod* method)
{
	((  void (*) (Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884 *, const RuntimeMethod*))Dictionary_2_Clear_m8B31D0EA3C1FCE4C6977A76829773DA0D127E217_gshared)(__this, method);
}
// System.Void System.Collections.Generic.Dictionary`2<System.Int32,System.Object>::.ctor()
inline void Dictionary_2__ctor_m7D745ADE56151C2895459668F4A4242985E526D8 (Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884 * __this, const RuntimeMethod* method)
{
	((  void (*) (Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884 *, const RuntimeMethod*))Dictionary_2__ctor_m7D745ADE56151C2895459668F4A4242985E526D8_gshared)(__this, method);
}
// System.Int32 UnityEngine.Time::get_frameCount()
extern "C" IL2CPP_METHOD_ATTR int32_t Time_get_frameCount_m97573E267B487B8FD4BF37615AFC19BED7B4E436 (const RuntimeMethod* method);
// System.Void Pixeye.HandleUpdate::Add(System.Object)
extern "C" IL2CPP_METHOD_ATTR void HandleUpdate_Add_m06660D0523D78FD04AD4031ECABFE86BB6EB2FC8 (HandleUpdate_t2060842DBF2069E5F3DD3C37B41CA77A1C7B78A3 * __this, RuntimeObject * ___updateble0, const RuntimeMethod* method);
// System.Single UnityEngine.Time::get_unscaledDeltaTime()
extern "C" IL2CPP_METHOD_ATTR float Time_get_unscaledDeltaTime_mA0AE7A144C88AE8AABB42DF17B0F3F0714BA06B2 (const RuntimeMethod* method);
// System.Void Pixeye.Time::.ctor()
extern "C" IL2CPP_METHOD_ATTR void Time__ctor_m3B49553DC238654DF564C95BE1F2C04A9AD0C22B (Time_t70920BA2C4C4BE707DAE9822ED553B006FFC0100 * __this, const RuntimeMethod* method);
// System.Boolean System.Collections.Generic.Dictionary`2<Pixeye.TimerKey,System.Collections.Generic.List`1<Pixeye.Timer>>::TryGetValue(!0,!1&)
inline bool Dictionary_2_TryGetValue_m2AB95C81F55348A9264B1599CF302BF7D6A45673 (Dictionary_2_t7A0A951F2ACBA1FC50C942EC15413C2011C7B386 * __this, TimerKey_tCE6BF602B11E3FE849B05CC16BE0650A88755F89  p0, List_1_t613852693859B0156A22267D914D17B30CFDE8F1 ** p1, const RuntimeMethod* method)
{
	return ((  bool (*) (Dictionary_2_t7A0A951F2ACBA1FC50C942EC15413C2011C7B386 *, TimerKey_tCE6BF602B11E3FE849B05CC16BE0650A88755F89 , List_1_t613852693859B0156A22267D914D17B30CFDE8F1 **, const RuntimeMethod*))Dictionary_2_TryGetValue_m1C6AB025550FEB3B174D90CD732C3B2BED4C8CE2_gshared)(__this, p0, p1, method);
}
// System.Void System.Action::Invoke()
extern "C" IL2CPP_METHOD_ATTR void Action_Invoke_mC8D676E5DDF967EC5D23DD0E96FB52AA499817FD (Action_t591D2A86165F896B4B800BB5C25CE18672A55579 * __this, const RuntimeMethod* method);
// System.Void Pixeye.Timer::.ctor()
extern "C" IL2CPP_METHOD_ATTR void Timer__ctor_mA49C1E2BEBA494C51B822123E4F43E7FD41E69D0 (Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * __this, const RuntimeMethod* method);
// Pixeye.Timer Pixeye.Timer::Play()
extern "C" IL2CPP_METHOD_ATTR Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * Timer_Play_mB651AAAAE2F539E862FC75DB62C78B1641B8069A (Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * __this, const RuntimeMethod* method);
// System.Void System.Collections.Generic.List`1<Pixeye.Timer>::Add(!0)
inline void List_1_Add_m427CEBFF4473B9FF133591A38714298FA2E4BF08 (List_1_t613852693859B0156A22267D914D17B30CFDE8F1 * __this, Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * p0, const RuntimeMethod* method)
{
	((  void (*) (List_1_t613852693859B0156A22267D914D17B30CFDE8F1 *, Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA *, const RuntimeMethod*))List_1_Add_m6930161974C7504C80F52EC379EF012387D43138_gshared)(__this, p0, method);
}
// System.Void System.Collections.Generic.List`1<Pixeye.Timer>::.ctor(System.Int32)
inline void List_1__ctor_mABE1F8A5C40A227414A1BAC86E92EDD953F86FC1 (List_1_t613852693859B0156A22267D914D17B30CFDE8F1 * __this, int32_t p0, const RuntimeMethod* method)
{
	((  void (*) (List_1_t613852693859B0156A22267D914D17B30CFDE8F1 *, int32_t, const RuntimeMethod*))List_1__ctor_mEE468B81D8E7C140F567D10FF7F5894A50EEEA57_gshared)(__this, p0, method);
}
// System.Void System.Collections.Generic.Dictionary`2<Pixeye.TimerKey,System.Collections.Generic.List`1<Pixeye.Timer>>::Add(!0,!1)
inline void Dictionary_2_Add_m6E61563D097FC91BEA0AB0B64E9B47ED7FA8667F (Dictionary_2_t7A0A951F2ACBA1FC50C942EC15413C2011C7B386 * __this, TimerKey_tCE6BF602B11E3FE849B05CC16BE0650A88755F89  p0, List_1_t613852693859B0156A22267D914D17B30CFDE8F1 * p1, const RuntimeMethod* method)
{
	((  void (*) (Dictionary_2_t7A0A951F2ACBA1FC50C942EC15413C2011C7B386 *, TimerKey_tCE6BF602B11E3FE849B05CC16BE0650A88755F89 , List_1_t613852693859B0156A22267D914D17B30CFDE8F1 *, const RuntimeMethod*))Dictionary_2_Add_m61952C05DDE1987456C5EA8B75194C0E6AD5CDA4_gshared)(__this, p0, p1, method);
}
// System.Void Pixeye.Timer::Stop()
extern "C" IL2CPP_METHOD_ATTR void Timer_Stop_m67DB897B6F803C7E8D24861682C3965EE7D94636 (Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * __this, const RuntimeMethod* method);
// System.Void Pixeye.Timer::Dispose()
extern "C" IL2CPP_METHOD_ATTR void Timer_Dispose_m8E57793C983E49F48EE17D66614532581624D71C (Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * __this, const RuntimeMethod* method);
// System.Void Pixeye.HandleUpdate::Remove(System.Object)
extern "C" IL2CPP_METHOD_ATTR void HandleUpdate_Remove_m08C15D88B167205B0196A4D39DD82742B901AE53 (HandleUpdate_t2060842DBF2069E5F3DD3C37B41CA77A1C7B78A3 * __this, RuntimeObject * ___updateble0, const RuntimeMethod* method);
// System.Boolean System.Collections.Generic.List`1<Pixeye.Timer>::Remove(!0)
inline bool List_1_Remove_m2E8533F833815BDD8176A0DBC27DFCCDC8120FE6 (List_1_t613852693859B0156A22267D914D17B30CFDE8F1 * __this, Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * p0, const RuntimeMethod* method)
{
	return ((  bool (*) (List_1_t613852693859B0156A22267D914D17B30CFDE8F1 *, Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA *, const RuntimeMethod*))List_1_Remove_m908B647BB9F807676DACE34E3E73475C3C3751D4_gshared)(__this, p0, method);
}
// System.Void Pixeye.Timer::set_IsRunning(System.Boolean)
extern "C" IL2CPP_METHOD_ATTR void Timer_set_IsRunning_m9AA3554B76F6EB4CD9722620479886E61A599986 (Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * __this, bool ___value0, const RuntimeMethod* method);
// Pixeye.Timer Pixeye.Timer::Restart(System.Single)
extern "C" IL2CPP_METHOD_ATTR Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * Timer_Restart_m3DB9882F8B6959F0E89FF55E0424E25FC784416C (Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * __this, float ___finishTime0, const RuntimeMethod* method);
// System.Void Pixeye.Timer::Execute()
extern "C" IL2CPP_METHOD_ATTR void Timer_Execute_m2F9D39C42E0AB9B085388143528BEFD1DFCBB9B2 (Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * __this, const RuntimeMethod* method);
// System.Single Pixeye.Time::get_delta()
extern "C" IL2CPP_METHOD_ATTR float Time_get_delta_m9AD3A71A628E62BF0E3A01D0E5A652DA9807585E (const RuntimeMethod* method);
// System.Void Pixeye.Timer::Release()
extern "C" IL2CPP_METHOD_ATTR void Timer_Release_m897A3D2D802D3394A0F42929B6B746EDF50F2318 (Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * __this, const RuntimeMethod* method);
// System.Void System.Collections.Generic.Dictionary`2<Pixeye.TimerKey,System.Collections.Generic.List`1<Pixeye.Timer>>::.ctor(System.Int32)
inline void Dictionary_2__ctor_mC01623E89CE60035A0AB4C3C0E973C959CC76790 (Dictionary_2_t7A0A951F2ACBA1FC50C942EC15413C2011C7B386 * __this, int32_t p0, const RuntimeMethod* method)
{
	((  void (*) (Dictionary_2_t7A0A951F2ACBA1FC50C942EC15413C2011C7B386 *, int32_t, const RuntimeMethod*))Dictionary_2__ctor_m8B02BD7F77D1A2CE3373A561D558E915A86D253C_gshared)(__this, p0, method);
}
// System.Void Pixeye.TimerKey::.ctor(System.Int32,System.Int32)
extern "C" IL2CPP_METHOD_ATTR void TimerKey__ctor_m51B474020E775F991C54479D9B55A309AEF513AF (TimerKey_tCE6BF602B11E3FE849B05CC16BE0650A88755F89 * __this, int32_t ___x0, int32_t ___y1, const RuntimeMethod* method);
// System.Int32 Pixeye.TimerKey::GetHashCode()
extern "C" IL2CPP_METHOD_ATTR int32_t TimerKey_GetHashCode_mE22CDE5761F4F098F78D2671099DDFD795A59306 (TimerKey_tCE6BF602B11E3FE849B05CC16BE0650A88755F89 * __this, const RuntimeMethod* method);
// System.Boolean Pixeye.TimerKey::Equals(Pixeye.TimerKey)
extern "C" IL2CPP_METHOD_ATTR bool TimerKey_Equals_m6345B28732D3D678C674DF49AEAB5182BCD83180 (TimerKey_tCE6BF602B11E3FE849B05CC16BE0650A88755F89 * __this, TimerKey_tCE6BF602B11E3FE849B05CC16BE0650A88755F89  ___other0, const RuntimeMethod* method);
// System.Boolean Pixeye.TimerKey::Equals(System.Object)
extern "C" IL2CPP_METHOD_ATTR bool TimerKey_Equals_m4E3403831CDAF7D5E0DF496FEF1335BEC18D82A2 (TimerKey_tCE6BF602B11E3FE849B05CC16BE0650A88755F89 * __this, RuntimeObject * ___other0, const RuntimeMethod* method);
// T Singleton`1<Pixeye.Toolbox>::get_Instance()
inline Toolbox_t081ED4540597D09C31B0F9430D6D377D6BA90E3A * Singleton_1_get_Instance_m9E601D43C461833AEAAC52704F1EFD611715C0A9 (const RuntimeMethod* method)
{
	return ((  Toolbox_t081ED4540597D09C31B0F9430D6D377D6BA90E3A * (*) (const RuntimeMethod*))Singleton_1_get_Instance_m6013518CA5BC1AE89DD7A2B1024D53EBC0A2B529_gshared)(method);
}
// System.Boolean System.Collections.Generic.Dictionary`2<System.Int32,System.Object>::TryGetValue(!0,!1&)
inline bool Dictionary_2_TryGetValue_m867F6DA953678D0333A55270B7C6EF38EFC293FF (Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884 * __this, int32_t p0, RuntimeObject ** p1, const RuntimeMethod* method)
{
	return ((  bool (*) (Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884 *, int32_t, RuntimeObject **, const RuntimeMethod*))Dictionary_2_TryGetValue_m867F6DA953678D0333A55270B7C6EF38EFC293FF_gshared)(__this, p0, p1, method);
}
// System.Type System.Object::GetType()
extern "C" IL2CPP_METHOD_ATTR Type_t * Object_GetType_m2E0B62414ECCAA3094B703790CE88CBB2F83EA60 (RuntimeObject * __this, const RuntimeMethod* method);
// System.Void Pixeye.Toolbox::InitializeObject(System.Object)
extern "C" IL2CPP_METHOD_ATTR void Toolbox_InitializeObject_m6675C399D61F9479D097A9D6E84A755F92EAF155 (RuntimeObject * ___obj0, const RuntimeMethod* method);
// System.Boolean UnityEngine.Object::op_Implicit(UnityEngine.Object)
extern "C" IL2CPP_METHOD_ATTR bool Object_op_Implicit_m8B2A44B4B1406ED346D1AE6D962294FD58D0D534 (Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0 * p0, const RuntimeMethod* method);
// !!0 UnityEngine.Object::Instantiate<UnityEngine.ScriptableObject>(!!0)
inline ScriptableObject_tAB015486CEAB714DA0D5C1BA389B84FB90427734 * Object_Instantiate_TisScriptableObject_tAB015486CEAB714DA0D5C1BA389B84FB90427734_mB3A1278CCDC8FA17C7D86C6C1C0D7676B0D18A03 (ScriptableObject_tAB015486CEAB714DA0D5C1BA389B84FB90427734 * p0, const RuntimeMethod* method)
{
	return ((  ScriptableObject_tAB015486CEAB714DA0D5C1BA389B84FB90427734 * (*) (ScriptableObject_tAB015486CEAB714DA0D5C1BA389B84FB90427734 *, const RuntimeMethod*))Object_Instantiate_TisRuntimeObject_mEF511C369E0CA9462FD3427DFC2375E81469570F_gshared)(p0, method);
}
// System.Void System.Collections.Generic.Dictionary`2<System.Int32,System.Object>::Add(!0,!1)
inline void Dictionary_2_Add_mF7AEA0EFA07EEBC1A4B283A26A7CB720EE7A4C20 (Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884 * __this, int32_t p0, RuntimeObject * p1, const RuntimeMethod* method)
{
	((  void (*) (Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884 *, int32_t, RuntimeObject *, const RuntimeMethod*))Dictionary_2_Add_mF7AEA0EFA07EEBC1A4B283A26A7CB720EE7A4C20_gshared)(__this, p0, p1, method);
}
// System.Boolean System.Collections.Generic.Dictionary`2<System.Int32,System.Object>::Remove(!0)
inline bool Dictionary_2_Remove_m2204D6D532702FD13AB2A9AD8DB538E4E8FB1913 (Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884 * __this, int32_t p0, const RuntimeMethod* method)
{
	return ((  bool (*) (Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884 *, int32_t, const RuntimeMethod*))Dictionary_2_Remove_m2204D6D532702FD13AB2A9AD8DB538E4E8FB1913_gshared)(__this, p0, method);
}
// System.Void System.Collections.Generic.List`1<System.Int32>::.ctor()
inline void List_1__ctor_mA7F9F92F641CEECFD9D8CFDC667568A05FFD27B4 (List_1_tE1526161A558A17A39A8B69D8EEF3801393B6226 * __this, const RuntimeMethod* method)
{
	((  void (*) (List_1_tE1526161A558A17A39A8B69D8EEF3801393B6226 *, const RuntimeMethod*))List_1__ctor_mA7F9F92F641CEECFD9D8CFDC667568A05FFD27B4_gshared)(__this, method);
}
// System.Collections.Generic.Dictionary`2/Enumerator<!0,!1> System.Collections.Generic.Dictionary`2<System.Int32,System.Object>::GetEnumerator()
inline Enumerator_t72A8231827DB93FC8B25F08FF066377F7B773DA1  Dictionary_2_GetEnumerator_mE47C13FC1B2BACBEE6F795B0E40E6406CAC55D4B (Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884 * __this, const RuntimeMethod* method)
{
	return ((  Enumerator_t72A8231827DB93FC8B25F08FF066377F7B773DA1  (*) (Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884 *, const RuntimeMethod*))Dictionary_2_GetEnumerator_mE47C13FC1B2BACBEE6F795B0E40E6406CAC55D4B_gshared)(__this, method);
}
// System.Collections.Generic.KeyValuePair`2<!0,!1> System.Collections.Generic.Dictionary`2/Enumerator<System.Int32,System.Object>::get_Current()
inline KeyValuePair_2_t142B50DAD5164EBD2E1495FD821B1A4C3233FA26  Enumerator_get_Current_m73F8FC135A20BDFEA0846D8FC876863ED85FEA49 (Enumerator_t72A8231827DB93FC8B25F08FF066377F7B773DA1 * __this, const RuntimeMethod* method)
{
	return ((  KeyValuePair_2_t142B50DAD5164EBD2E1495FD821B1A4C3233FA26  (*) (Enumerator_t72A8231827DB93FC8B25F08FF066377F7B773DA1 *, const RuntimeMethod*))Enumerator_get_Current_m73F8FC135A20BDFEA0846D8FC876863ED85FEA49_gshared)(__this, method);
}
// !1 System.Collections.Generic.KeyValuePair`2<System.Int32,System.Object>::get_Value()
inline RuntimeObject * KeyValuePair_2_get_Value_mAD6801F3BC9BA1E99D4E0F72B2B420182D0494FC (KeyValuePair_2_t142B50DAD5164EBD2E1495FD821B1A4C3233FA26 * __this, const RuntimeMethod* method)
{
	return ((  RuntimeObject * (*) (KeyValuePair_2_t142B50DAD5164EBD2E1495FD821B1A4C3233FA26 *, const RuntimeMethod*))KeyValuePair_2_get_Value_mAD6801F3BC9BA1E99D4E0F72B2B420182D0494FC_gshared)(__this, method);
}
// !0 System.Collections.Generic.KeyValuePair`2<System.Int32,System.Object>::get_Key()
inline int32_t KeyValuePair_2_get_Key_m89B687D373FBE3D230647CA0C536235E12AD829C (KeyValuePair_2_t142B50DAD5164EBD2E1495FD821B1A4C3233FA26 * __this, const RuntimeMethod* method)
{
	return ((  int32_t (*) (KeyValuePair_2_t142B50DAD5164EBD2E1495FD821B1A4C3233FA26 *, const RuntimeMethod*))KeyValuePair_2_get_Key_m89B687D373FBE3D230647CA0C536235E12AD829C_gshared)(__this, method);
}
// System.Void System.Collections.Generic.List`1<System.Int32>::Add(!0)
inline void List_1_Add_m50C0D1F69B2EF31137658E2F052EBBAC7BF82771 (List_1_tE1526161A558A17A39A8B69D8EEF3801393B6226 * __this, int32_t p0, const RuntimeMethod* method)
{
	((  void (*) (List_1_tE1526161A558A17A39A8B69D8EEF3801393B6226 *, int32_t, const RuntimeMethod*))List_1_Add_m50C0D1F69B2EF31137658E2F052EBBAC7BF82771_gshared)(__this, p0, method);
}
// System.Boolean System.Collections.Generic.Dictionary`2/Enumerator<System.Int32,System.Object>::MoveNext()
inline bool Enumerator_MoveNext_m637AE52AC4BDE5BEB1D89BE4B75E49B4C328EFC9 (Enumerator_t72A8231827DB93FC8B25F08FF066377F7B773DA1 * __this, const RuntimeMethod* method)
{
	return ((  bool (*) (Enumerator_t72A8231827DB93FC8B25F08FF066377F7B773DA1 *, const RuntimeMethod*))Enumerator_MoveNext_m637AE52AC4BDE5BEB1D89BE4B75E49B4C328EFC9_gshared)(__this, method);
}
// System.Void System.Collections.Generic.Dictionary`2/Enumerator<System.Int32,System.Object>::Dispose()
inline void Enumerator_Dispose_m772E7049D8DA96AF5021EA09C3E6322CD4BFBDFC (Enumerator_t72A8231827DB93FC8B25F08FF066377F7B773DA1 * __this, const RuntimeMethod* method)
{
	((  void (*) (Enumerator_t72A8231827DB93FC8B25F08FF066377F7B773DA1 *, const RuntimeMethod*))Enumerator_Dispose_m772E7049D8DA96AF5021EA09C3E6322CD4BFBDFC_gshared)(__this, method);
}
// System.Void Pixeye.HandleTimer::Dispose()
extern "C" IL2CPP_METHOD_ATTR void HandleTimer_Dispose_mB70AEF1D54E7E16C3373534C49364617998D6EF1 (HandleTimer_tE0613FB7A046C7560F75BD4908092FA5A2260483 * __this, const RuntimeMethod* method);
// System.Void Pixeye.HandlePool::Dispose()
extern "C" IL2CPP_METHOD_ATTR void HandlePool_Dispose_m8BCFF4C7987C959A19EACEF4A42A2B2E96C92727 (HandlePool_tBB031F11A1DE7E61E63146EF835372909BFCB665 * __this, const RuntimeMethod* method);
// System.Void Pixeye.HandleEntities::Dispose()
extern "C" IL2CPP_METHOD_ATTR void HandleEntities_Dispose_m406AC662E2C2469B22DFB29358CE5D70E9858BEC (HandleEntities_t05CCD5B390B45C447D8FA2542EF8CC2761054D76 * __this, const RuntimeMethod* method);
// System.Void Pixeye.HandleScene::Dispose()
extern "C" IL2CPP_METHOD_ATTR void HandleScene_Dispose_m6648966B379C0A8408CBDA60C1D5206EB6BC3EFE (HandleScene_t9A17EE1370450F47652A7C56B9D20A02A7BA1728 * __this, const RuntimeMethod* method);
// System.Void Pixeye.HandleUpdate::Dispose()
extern "C" IL2CPP_METHOD_ATTR void HandleUpdate_Dispose_mDF558B8E86D5D0F1725D63E827055044C107395E (HandleUpdate_t2060842DBF2069E5F3DD3C37B41CA77A1C7B78A3 * __this, const RuntimeMethod* method);
// System.Void Pixeye.Box::Dispose()
extern "C" IL2CPP_METHOD_ATTR void Box_Dispose_m6C2344704C406FC80333DE53B1F77BC3E315C7D3 (Box_t4C71F0C8AB96AC3964C40FE71BB42D9C121F81B1 * __this, const RuntimeMethod* method);
// !0 System.Collections.Generic.List`1<System.Int32>::get_Item(System.Int32)
inline int32_t List_1_get_Item_mB62D52423AF52EEC13B4317DD86E6A5BBDF41BD2 (List_1_tE1526161A558A17A39A8B69D8EEF3801393B6226 * __this, int32_t p0, const RuntimeMethod* method)
{
	return ((  int32_t (*) (List_1_tE1526161A558A17A39A8B69D8EEF3801393B6226 *, int32_t, const RuntimeMethod*))List_1_get_Item_mB62D52423AF52EEC13B4317DD86E6A5BBDF41BD2_gshared)(__this, p0, method);
}
// System.Int32 System.Collections.Generic.List`1<System.Int32>::get_Count()
inline int32_t List_1_get_Count_m52793036D5E41E8E25DCC5C033380C44D7596903 (List_1_tE1526161A558A17A39A8B69D8EEF3801393B6226 * __this, const RuntimeMethod* method)
{
	return ((  int32_t (*) (List_1_tE1526161A558A17A39A8B69D8EEF3801393B6226 *, const RuntimeMethod*))List_1_get_Count_m52793036D5E41E8E25DCC5C033380C44D7596903_gshared)(__this, method);
}
// System.Void System.Collections.Generic.Dictionary`2<System.Int32,System.Object>::.ctor(System.Int32,System.Collections.Generic.IEqualityComparer`1<!0>)
inline void Dictionary_2__ctor_m0F87B73520F2A9CD71CF45B4561785C1C42E8111 (Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884 * __this, int32_t p0, RuntimeObject* p1, const RuntimeMethod* method)
{
	((  void (*) (Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884 *, int32_t, RuntimeObject*, const RuntimeMethod*))Dictionary_2__ctor_m0F87B73520F2A9CD71CF45B4561785C1C42E8111_gshared)(__this, p0, p1, method);
}
// System.Void Singleton`1<Pixeye.Toolbox>::.ctor()
inline void Singleton_1__ctor_m338353C6D6074D6C6AC75D270237A0CC32BE9BDF (Singleton_1_t70D00C90A652BD47B1B663FC32A13A31E56C12C6 * __this, const RuntimeMethod* method)
{
	((  void (*) (Singleton_1_t70D00C90A652BD47B1B663FC32A13A31E56C12C6 *, const RuntimeMethod*))Singleton_1__ctor_mF0D65AF0B365EBE4E51BE5CA42A2C65783AE80B0_gshared)(__this, method);
}
// System.Void Pixeye.ent::.ctor(System.Int32,System.Int32)
extern "C" IL2CPP_METHOD_ATTR void ent__ctor_m687198B81484B7EA5A3EB6F226AA5CE1F2B52F6E (ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * __this, int32_t ___id0, int32_t ___hash1, const RuntimeMethod* method);
// System.Int32 Pixeye.ent::CompareTo(System.Object)
extern "C" IL2CPP_METHOD_ATTR int32_t ent_CompareTo_mE8416899740A9FE48A8295ED4B796B13DD0A97BE (ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * __this, RuntimeObject * ___value0, const RuntimeMethod* method);
// System.Int32 Pixeye.ent::CompareTo(System.Int32)
extern "C" IL2CPP_METHOD_ATTR int32_t ent_CompareTo_m0B254BB7E07D9944123F1F542D006388839908EC (ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * __this, int32_t ___value0, const RuntimeMethod* method);
// System.Boolean Pixeye.ent::Equals(System.Object)
extern "C" IL2CPP_METHOD_ATTR bool ent_Equals_m6D047D20BE89EC823DDD217C6905F1B454A82049 (ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * __this, RuntimeObject * ___obj0, const RuntimeMethod* method);
// System.Boolean Pixeye.ent::Equals(System.Int32)
extern "C" IL2CPP_METHOD_ATTR bool ent_Equals_m17106E28D6874576C7BC82063A2D7EDE88CB1F8C (ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * __this, int32_t ___obj0, const RuntimeMethod* method);
// System.Int32 Pixeye.ent::GetHashCode()
extern "C" IL2CPP_METHOD_ATTR int32_t ent_GetHashCode_m0A4671ADC4A691FEC3BC1CFC742A114831A259A4 (ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * __this, const RuntimeMethod* method);
// Pixeye.EntityComposer Pixeye.EntityComposer::Create(Pixeye.ent&)
extern "C" IL2CPP_METHOD_ATTR EntityComposer_tB9CD47E805A3232A943F6CF48BB084FB1646CCD3 * EntityComposer_Create_m72594803BFEBDB2D4D5AD6A828E038E30E9969DF (ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * ___entity0, const RuntimeMethod* method);
// T Pixeye.EntityComposer::Add<Pixeye.ComponentRelease>()
inline ComponentRelease_t98EE3880490384D15031D69FB587E1C7D806E527 * EntityComposer_Add_TisComponentRelease_t98EE3880490384D15031D69FB587E1C7D806E527_mB10072EEB7AAEBA7111D3FB268286C9C36E9FB47 (EntityComposer_tB9CD47E805A3232A943F6CF48BB084FB1646CCD3 * __this, const RuntimeMethod* method)
{
	return ((  ComponentRelease_t98EE3880490384D15031D69FB587E1C7D806E527 * (*) (EntityComposer_tB9CD47E805A3232A943F6CF48BB084FB1646CCD3 *, const RuntimeMethod*))EntityComposer_Add_TisRuntimeObject_mD60C78EFF966479F708D5EBD8842F0AF053034C7_gshared)(__this, method);
}
// System.Void Pixeye.EntityComposer::Deploy()
extern "C" IL2CPP_METHOD_ATTR void EntityComposer_Deploy_m05DF6C2544245D2BFBD70A249C5DAFFC797AF318 (EntityComposer_tB9CD47E805A3232A943F6CF48BB084FB1646CCD3 * __this, const RuntimeMethod* method);
// System.Void Pixeye.ent::Release()
extern "C" IL2CPP_METHOD_ATTR void ent_Release_m8211BD2C827CC92F4B8D97385D87A463C3193441 (ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * __this, const RuntimeMethod* method);
// System.Boolean Pixeye.ent::Exist()
extern "C" IL2CPP_METHOD_ATTR bool ent_Exist_m7DF7BEF41163A226515F8EC5A7DAF61B227090D7 (ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * __this, const RuntimeMethod* method);
// System.Int32 System.Array::get_Rank()
extern "C" IL2CPP_METHOD_ATTR int32_t Array_get_Rank_m38145B59D67D75F9896A3F8CDA9B966641AE99E1 (RuntimeArray * __this, const RuntimeMethod* method);
// System.Int32 System.Array::GetLength(System.Int32)
extern "C" IL2CPP_METHOD_ATTR int32_t Array_GetLength_m318900B10C3A93A30ABDC67DE161C8F6ABA4D359 (RuntimeArray * __this, int32_t p0, const RuntimeMethod* method);
// System.Int64 System.Array::get_LongLength()
extern "C" IL2CPP_METHOD_ATTR int64_t Array_get_LongLength_m9C506B10DB4FB16C0A2F5059C5C08F8D3B0C2D9A (RuntimeArray * __this, const RuntimeMethod* method);
// System.Void System.ArrayTraverse::.ctor(System.Array)
extern "C" IL2CPP_METHOD_ATTR void ArrayTraverse__ctor_mCC997558A200828072F6A2B76B02E089FABE3741 (ArrayTraverse_tD07A6D4E93DB7941CE934AFF9F006788173C70A6 * __this, RuntimeArray * ___array0, const RuntimeMethod* method);
// System.Void System.Action`2<System.Array,System.Int32[]>::Invoke(!0,!1)
inline void Action_2_Invoke_m30C71E5D73DDF8E22567F0AAEFE21B198D0F4CBF (Action_2_tEEECFD1333A361FF85D469EF54DA8E989E6B0D11 * __this, RuntimeArray * p0, Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* p1, const RuntimeMethod* method)
{
	((  void (*) (Action_2_tEEECFD1333A361FF85D469EF54DA8E989E6B0D11 *, RuntimeArray *, Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83*, const RuntimeMethod*))Action_2_Invoke_m1738FFAE74BE5E599FD42520FA2BEF69D1AC4709_gshared)(__this, p0, p1, method);
}
// System.Boolean System.ArrayTraverse::Step()
extern "C" IL2CPP_METHOD_ATTR bool ArrayTraverse_Step_m3D9533390B66FB0C727576BAEF5CE78EF602193E (ArrayTraverse_tD07A6D4E93DB7941CE934AFF9F006788173C70A6 * __this, const RuntimeMethod* method);
// System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
extern "C" IL2CPP_METHOD_ATTR Type_t * Type_GetTypeFromHandle_m9DC58ADF0512987012A8A016FB64B068F3B1AFF6 (RuntimeTypeHandle_t7B542280A22F0EC4EAC2061C29178845847A8B2D  p0, const RuntimeMethod* method);
// System.Boolean System.Type::op_Equality(System.Type,System.Type)
extern "C" IL2CPP_METHOD_ATTR bool Type_op_Equality_m7040622C9E1037EFC73E1F0EDB1DD241282BE3D8 (Type_t * p0, Type_t * p1, const RuntimeMethod* method);
// System.Boolean System.Type::get_IsValueType()
extern "C" IL2CPP_METHOD_ATTR bool Type_get_IsValueType_mDDCCBAE9B59A483CBC3E5C02E3D68CEBEB2E41A8 (Type_t * __this, const RuntimeMethod* method);
// System.Boolean System.Type::get_IsPrimitive()
extern "C" IL2CPP_METHOD_ATTR bool Type_get_IsPrimitive_m8E39430EE4B70E1AE690B51E9BE681C7758DFF5A (Type_t * __this, const RuntimeMethod* method);
// System.Void System.ReferenceEqualityComparer::.ctor()
extern "C" IL2CPP_METHOD_ATTR void ReferenceEqualityComparer__ctor_mF5BDE00932C85FFE5E2633F082A065724571C26D (ReferenceEqualityComparer_t3840A1467D76B18290FA822E6B548D1079D91DA4 * __this, const RuntimeMethod* method);
// System.Void System.Collections.Generic.Dictionary`2<System.Object,System.Object>::.ctor(System.Collections.Generic.IEqualityComparer`1<!0>)
inline void Dictionary_2__ctor_m76CDCB0C7BECE95DBA94C7C98467F297E4451EE7 (Dictionary_2_t32F25F093828AA9F93CB11C2A2B4648FD62A09BA * __this, RuntimeObject* p0, const RuntimeMethod* method)
{
	((  void (*) (Dictionary_2_t32F25F093828AA9F93CB11C2A2B4648FD62A09BA *, RuntimeObject*, const RuntimeMethod*))Dictionary_2__ctor_m76CDCB0C7BECE95DBA94C7C98467F297E4451EE7_gshared)(__this, p0, method);
}
// System.Object System.HelperObject::InternalCopy(System.Object,System.Collections.Generic.IDictionary`2<System.Object,System.Object>)
extern "C" IL2CPP_METHOD_ATTR RuntimeObject * HelperObject_InternalCopy_mACD63D41622BF6303A74BBCE7C77024CD5B97FB2 (RuntimeObject * ___originalObject0, RuntimeObject* ___visited1, const RuntimeMethod* method);
// System.Void System.HelperObject/<>c__DisplayClass3_0::.ctor()
extern "C" IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass3_0__ctor_m93F361838BC3468967E3A661630E4F0CDE11DB93 (U3CU3Ec__DisplayClass3_0_t715805D6146E8762D34660C36DE710592B4E74BC * __this, const RuntimeMethod* method);
// System.Boolean System.HelperObject::IsPrimitive(System.Type)
extern "C" IL2CPP_METHOD_ATTR bool HelperObject_IsPrimitive_m7A8654F1FD5D1F421189A6552C8D3BCD2530ADBB (Type_t * ___type0, const RuntimeMethod* method);
// System.Object System.Reflection.MethodBase::Invoke(System.Object,System.Object[])
extern "C" IL2CPP_METHOD_ATTR RuntimeObject * MethodBase_Invoke_m471794D56262D9DB5B5A324883030AB16BD39674 (MethodBase_t * __this, RuntimeObject * p0, ObjectU5BU5D_t3C9242B5C88A48B2A5BD9FDA6CD0024E792AF08A* p1, const RuntimeMethod* method);
// System.Boolean System.Type::get_IsArray()
extern "C" IL2CPP_METHOD_ATTR bool Type_get_IsArray_m0B4E20F93B1B34C0B5C4B089F543D1AA338DC9FE (Type_t * __this, const RuntimeMethod* method);
// System.Void System.HelperObject/<>c__DisplayClass3_1::.ctor()
extern "C" IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass3_1__ctor_m481D2674B53A811C32FDF054B5155011F6910CA0 (U3CU3Ec__DisplayClass3_1_tB9452E9E43273A7EB9B4BEC3B43307E5DC1E2DAD * __this, const RuntimeMethod* method);
// System.Void System.Action`2<System.Array,System.Int32[]>::.ctor(System.Object,System.IntPtr)
inline void Action_2__ctor_m5FC808B1B109AA3FBDD5E37AB68C9507E6E8E43E (Action_2_tEEECFD1333A361FF85D469EF54DA8E989E6B0D11 * __this, RuntimeObject * p0, intptr_t p1, const RuntimeMethod* method)
{
	((  void (*) (Action_2_tEEECFD1333A361FF85D469EF54DA8E989E6B0D11 *, RuntimeObject *, intptr_t, const RuntimeMethod*))Action_2__ctor_mB83B0C1C61CED5B54803D334FFC7187881D32EFB_gshared)(__this, p0, p1, method);
}
// System.Void System.HelperArray::ForEach(System.Array,System.Action`2<System.Array,System.Int32[]>)
extern "C" IL2CPP_METHOD_ATTR void HelperArray_ForEach_mB81FAB6CA742EF47C4B9E2CA805351AFBB1FB0DB (RuntimeArray * ___array0, Action_2_tEEECFD1333A361FF85D469EF54DA8E989E6B0D11 * ___action1, const RuntimeMethod* method);
// System.Void System.HelperObject::CopyFields(System.Object,System.Collections.Generic.IDictionary`2<System.Object,System.Object>,System.Object,System.Type,System.Reflection.BindingFlags,System.Func`2<System.Reflection.FieldInfo,System.Boolean>)
extern "C" IL2CPP_METHOD_ATTR void HelperObject_CopyFields_m82911ECAA99D264F8D7B8D63C02CDC35A1B9657C (RuntimeObject * ___originalObject0, RuntimeObject* ___visited1, RuntimeObject * ___cloneObject2, Type_t * ___typeToReflect3, int32_t ___bindingFlags4, Func_2_t8B737A62DCD6BCDB37818A2DFF357973A9317E8D * ___filter5, const RuntimeMethod* method);
// System.Void System.HelperObject::RecursiveCopyBaseTypePrivateFields(System.Object,System.Collections.Generic.IDictionary`2<System.Object,System.Object>,System.Object,System.Type)
extern "C" IL2CPP_METHOD_ATTR void HelperObject_RecursiveCopyBaseTypePrivateFields_mC004C89E73C1BECCD83A4BC7F31ECBCA5E3DA6A7 (RuntimeObject * ___originalObject0, RuntimeObject* ___visited1, RuntimeObject * ___cloneObject2, Type_t * ___typeToReflect3, const RuntimeMethod* method);
// System.Void System.Func`2<System.Reflection.FieldInfo,System.Boolean>::.ctor(System.Object,System.IntPtr)
inline void Func_2__ctor_mBCB78A823F554E0E602DAC379826320F3ECEDC4B (Func_2_t8B737A62DCD6BCDB37818A2DFF357973A9317E8D * __this, RuntimeObject * p0, intptr_t p1, const RuntimeMethod* method)
{
	((  void (*) (Func_2_t8B737A62DCD6BCDB37818A2DFF357973A9317E8D *, RuntimeObject *, intptr_t, const RuntimeMethod*))Func_2__ctor_m5153AE6EE06BA488EF3D92A0DCF7E4EF530961B5_gshared)(__this, p0, p1, method);
}
// !1 System.Func`2<System.Reflection.FieldInfo,System.Boolean>::Invoke(!0)
inline bool Func_2_Invoke_m549AD78F263B5521A0C932CDA2164CE8184B56C7 (Func_2_t8B737A62DCD6BCDB37818A2DFF357973A9317E8D * __this, FieldInfo_t * p0, const RuntimeMethod* method)
{
	return ((  bool (*) (Func_2_t8B737A62DCD6BCDB37818A2DFF357973A9317E8D *, FieldInfo_t *, const RuntimeMethod*))Func_2_Invoke_mE25788DCE25515291EAA06F55BEF30F9F27FBBA9_gshared)(__this, p0, method);
}
// System.Void System.Reflection.FieldInfo::SetValue(System.Object,System.Object)
extern "C" IL2CPP_METHOD_ATTR void FieldInfo_SetValue_m9E7A4FBA27F835B6C26CC09CF609333967150E41 (FieldInfo_t * __this, RuntimeObject * p0, RuntimeObject * p1, const RuntimeMethod* method);
// System.Reflection.MethodInfo System.Type::GetMethod(System.String,System.Reflection.BindingFlags)
extern "C" IL2CPP_METHOD_ATTR MethodInfo_t * Type_GetMethod_m9EC42D4B1F765B882F516EE6D7970D51CF5D80DD (Type_t * __this, String_t* p0, int32_t p1, const RuntimeMethod* method);
// System.Void System.HelperObject/<>c::.ctor()
extern "C" IL2CPP_METHOD_ATTR void U3CU3Ec__ctor_m061CC4C8AA1906E5AFD92705600B19E5D2D76D1D (U3CU3Ec_t9C407A5DC0C368A41DAACA036192AD2BC6222A05 * __this, const RuntimeMethod* method);
// System.Boolean System.Reflection.FieldInfo::get_IsPrivate()
extern "C" IL2CPP_METHOD_ATTR bool FieldInfo_get_IsPrivate_m4CC9816E774224A4A143DD0748C90D02AF387F5C (FieldInfo_t * __this, const RuntimeMethod* method);
// System.Object System.Array::GetValue(System.Int32[])
extern "C" IL2CPP_METHOD_ATTR RuntimeObject * Array_GetValue_m3CEA4EB8E2DAB2C0B9CCC8D6E597F15F82C2C97C (RuntimeArray * __this, Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* p0, const RuntimeMethod* method);
// System.Void System.Array::SetValue(System.Object,System.Int32[])
extern "C" IL2CPP_METHOD_ATTR void Array_SetValue_m0480E07CF9A65B3C2B903CCBF5BAB94F93CF1380 (RuntimeArray * __this, RuntimeObject * p0, Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* p1, const RuntimeMethod* method);
// System.Void System.Collections.Generic.EqualityComparer`1<System.Object>::.ctor()
inline void EqualityComparer_1__ctor_m2B03FB26184C766345AA072BEA38AA745AE2E192 (EqualityComparer_1_t54972BA287ED38B066E4BE7A3B21F49803B62EBA * __this, const RuntimeMethod* method)
{
	((  void (*) (EqualityComparer_1_t54972BA287ED38B066E4BE7A3B21F49803B62EBA *, const RuntimeMethod*))EqualityComparer_1__ctor_m2B03FB26184C766345AA072BEA38AA745AE2E192_gshared)(__this, method);
}
// System.Void Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute::set_Option(Unity.IL2CPP.CompilerServices.Option)
extern "C" IL2CPP_METHOD_ATTR void Il2CppSetOptionAttribute_set_Option_mA79F66679078953ABC5CFF576AFE2714A0C840CA (Il2CppSetOptionAttribute_t013DDBAF8F39A8C8395B51A2549BCF893259611E * __this, int32_t ___value0, const RuntimeMethod* method);
// System.Void Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute::set_Value(System.Object)
extern "C" IL2CPP_METHOD_ATTR void Il2CppSetOptionAttribute_set_Value_m67B377532E1429A6AE787932FFA2250D04D09022 (Il2CppSetOptionAttribute_t013DDBAF8F39A8C8395B51A2549BCF893259611E * __this, RuntimeObject * ___value0, const RuntimeMethod* method);
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Pixeye.ReferenceType::.ctor()
extern "C" IL2CPP_METHOD_ATTR void ReferenceType__ctor_mE31D12422DEE05B0533FF7DA8EE075A67E4788B2 (ReferenceType_tE3BEFC1D0A5EEAE313214E10535DAC824FCB1F2B * __this, const RuntimeMethod* method)
{
	CHECK_PAUSE_POINT;
	{
		Object__ctor_m925ECA5E85CA100E3FB86A4F9E15C120E9A184C0(__this, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Pixeye.RequireAttribute::.ctor(System.Type[])
extern "C" IL2CPP_METHOD_ATTR void RequireAttribute__ctor_m6FDFFB2F320943CACF50F50B03844E53FAD6F549 (RequireAttribute_t8B9E56505437ECBB6B0EA3FB2B9E1AA773C1CDEB * __this, TypeU5BU5D_t7FE623A666B49176DE123306221193E888A12F5F* ___types0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (RequireAttribute__ctor_m6FDFFB2F320943CACF50F50B03844E53FAD6F549_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___types0));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, RequireAttribute__ctor_m6FDFFB2F320943CACF50F50B03844E53FAD6F549_RuntimeMethod_var, methodExecutionContextThis, methodExecutionContextParameters, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 57959);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 57960);
	{
		// public RequireAttribute(params Type[] types)
		CHECK_SEQ_POINT(methodExecutionContext, 57961);
		STORE_SEQ_POINT(methodExecutionContext, 57965);
		Attribute__ctor_m45CAD4B01265CC84CC5A84F62EE2DBE85DE89EC0(__this, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 57965);
		CHECK_SEQ_POINT(methodExecutionContext, 57962);
		// this.types = types;
		CHECK_SEQ_POINT(methodExecutionContext, 57963);
		TypeU5BU5D_t7FE623A666B49176DE123306221193E888A12F5F* L_0 = ___types0;
		__this->set_types_0(L_0);
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 57964);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Pixeye.RequireTagsAttribute::.ctor(System.Int32[])
extern "C" IL2CPP_METHOD_ATTR void RequireTagsAttribute__ctor_m111248AED735B1356206988A811D591618A089AB (RequireTagsAttribute_tB80A8FCE5689F37232DC22E17DF16EEE0F912257 * __this, Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* ___tags0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (RequireTagsAttribute__ctor_m111248AED735B1356206988A811D591618A089AB_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___tags0));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, RequireTagsAttribute__ctor_m111248AED735B1356206988A811D591618A089AB_RuntimeMethod_var, methodExecutionContextThis, methodExecutionContextParameters, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 57966);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 57967);
	{
		// public RequireTagsAttribute(params int[] tags)
		CHECK_SEQ_POINT(methodExecutionContext, 57968);
		STORE_SEQ_POINT(methodExecutionContext, 57972);
		Attribute__ctor_m45CAD4B01265CC84CC5A84F62EE2DBE85DE89EC0(__this, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 57972);
		CHECK_SEQ_POINT(methodExecutionContext, 57969);
		// this.tags = tags;
		CHECK_SEQ_POINT(methodExecutionContext, 57970);
		Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* L_0 = ___tags0;
		__this->set_tags_0(L_0);
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 57971);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Pixeye.SMUtilities::End(UnityEngine.Animator)
extern "C" IL2CPP_METHOD_ATTR void SMUtilities_End_mF4ECA0F51F0459AA9782F89FAB30F778CA437920 (Animator_tF1A88E66B3B731DDA75A066DBAE9C55837660F5A * ___animator0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (SMUtilities_End_mF4ECA0F51F0459AA9782F89FAB30F778CA437920_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	BaseStateMachineBehaviorU5BU5D_t69541BC5FF78E6A8031B638080B9821EA0364911* V_0 = NULL;
	BaseStateMachineBehaviorU5BU5D_t69541BC5FF78E6A8031B638080B9821EA0364911* V_1 = NULL;
	int32_t V_2 = 0;
	BaseStateMachineBehavior_tC9B4D174C0E646DA37525E41FBB6A50C5DEEB064 * V_3 = NULL;
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___animator0));
	DECLARE_METHOD_LOCALS(methodExecutionContextLocals, (&V_0), (&V_3));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, SMUtilities_End_mF4ECA0F51F0459AA9782F89FAB30F778CA437920_RuntimeMethod_var, NULL, methodExecutionContextParameters, methodExecutionContextLocals);
	CHECK_SEQ_POINT(methodExecutionContext, 59489);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 59490);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 59491);
		// var behaviors = animator.GetBehaviours<BaseStateMachineBehavior>();
		CHECK_SEQ_POINT(methodExecutionContext, 59492);
		Animator_tF1A88E66B3B731DDA75A066DBAE9C55837660F5A * L_0 = ___animator0;
		STORE_SEQ_POINT(methodExecutionContext, 59503);
		NullCheck(L_0, il2cpp_codegen_get_sequence_point(59492));
		BaseStateMachineBehaviorU5BU5D_t69541BC5FF78E6A8031B638080B9821EA0364911* L_1 = Animator_GetBehaviours_TisBaseStateMachineBehavior_tC9B4D174C0E646DA37525E41FBB6A50C5DEEB064_mF2F48ED60DFB77DBA14E860AE010F54C9E4ED04B(L_0, /*hidden argument*/Animator_GetBehaviours_TisBaseStateMachineBehavior_tC9B4D174C0E646DA37525E41FBB6A50C5DEEB064_mF2F48ED60DFB77DBA14E860AE010F54C9E4ED04B_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 59503);
		V_0 = L_1;
		CHECK_SEQ_POINT(methodExecutionContext, 59493);
		// foreach (var behavior in behaviors)
		CHECK_SEQ_POINT(methodExecutionContext, 59494);
		BaseStateMachineBehaviorU5BU5D_t69541BC5FF78E6A8031B638080B9821EA0364911* L_2 = V_0;
		V_1 = L_2;
		V_2 = 0;
		CHECK_SEQ_POINT(methodExecutionContext, 59495);
		goto IL_0020;
	}

IL_000f:
	{
		// foreach (var behavior in behaviors)
		CHECK_SEQ_POINT(methodExecutionContext, 59496);
		BaseStateMachineBehaviorU5BU5D_t69541BC5FF78E6A8031B638080B9821EA0364911* L_3 = V_1;
		int32_t L_4 = V_2;
		NullCheck(L_3, il2cpp_codegen_get_sequence_point(59496));
		int32_t L_5 = L_4;
		BaseStateMachineBehavior_tC9B4D174C0E646DA37525E41FBB6A50C5DEEB064 * L_6 = (L_3)->GetAt(static_cast<il2cpp_array_size_t>(L_5));
		V_3 = L_6;
		CHECK_SEQ_POINT(methodExecutionContext, 59497);
		// behavior.End();
		CHECK_SEQ_POINT(methodExecutionContext, 59498);
		BaseStateMachineBehavior_tC9B4D174C0E646DA37525E41FBB6A50C5DEEB064 * L_7 = V_3;
		STORE_SEQ_POINT(methodExecutionContext, 59504);
		NullCheck(L_7, il2cpp_codegen_get_sequence_point(59498));
		VirtActionInvoker0::Invoke(18 /* System.Void Pixeye.BaseStateMachineBehavior::End() */, L_7);
		CHECK_SEQ_POINT(methodExecutionContext, 59504);
		CHECK_SEQ_POINT(methodExecutionContext, 59499);
		CHECK_SEQ_POINT(methodExecutionContext, 59500);
		int32_t L_8 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add((int32_t)L_8, (int32_t)1));
	}

IL_0020:
	{
		// foreach (var behavior in behaviors)
		CHECK_SEQ_POINT(methodExecutionContext, 59501);
		int32_t L_9 = V_2;
		BaseStateMachineBehaviorU5BU5D_t69541BC5FF78E6A8031B638080B9821EA0364911* L_10 = V_1;
		NullCheck(L_10, il2cpp_codegen_get_sequence_point(59501));
		if ((((int32_t)L_9) < ((int32_t)(((int32_t)((int32_t)(((RuntimeArray *)L_10)->max_length)))))))
		{
			goto IL_000f;
		}
	}
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 59502);
		return;
	}
}
// System.Void Pixeye.SMUtilities::Initialize(UnityEngine.Animator,Pixeye.Actor)
extern "C" IL2CPP_METHOD_ATTR void SMUtilities_Initialize_m72D841439646754BD5DA0EE354CDB2DF01D56BEE (Animator_tF1A88E66B3B731DDA75A066DBAE9C55837660F5A * ___animator0, Actor_tC8E7F2C0FBC6266BB4ACD3F1D091F6AD50A15FEB * ___a1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (SMUtilities_Initialize_m72D841439646754BD5DA0EE354CDB2DF01D56BEE_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	BaseStateMachineBehaviorU5BU5D_t69541BC5FF78E6A8031B638080B9821EA0364911* V_0 = NULL;
	BaseStateMachineBehaviorU5BU5D_t69541BC5FF78E6A8031B638080B9821EA0364911* V_1 = NULL;
	int32_t V_2 = 0;
	BaseStateMachineBehavior_tC9B4D174C0E646DA37525E41FBB6A50C5DEEB064 * V_3 = NULL;
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___animator0), (&___a1));
	DECLARE_METHOD_LOCALS(methodExecutionContextLocals, (&V_0), (&V_3));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, SMUtilities_Initialize_m72D841439646754BD5DA0EE354CDB2DF01D56BEE_RuntimeMethod_var, NULL, methodExecutionContextParameters, methodExecutionContextLocals);
	CHECK_SEQ_POINT(methodExecutionContext, 59505);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 59506);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 59507);
		// var behaviors = animator.GetBehaviours<BaseStateMachineBehavior>();
		CHECK_SEQ_POINT(methodExecutionContext, 59508);
		Animator_tF1A88E66B3B731DDA75A066DBAE9C55837660F5A * L_0 = ___animator0;
		STORE_SEQ_POINT(methodExecutionContext, 59519);
		NullCheck(L_0, il2cpp_codegen_get_sequence_point(59508));
		BaseStateMachineBehaviorU5BU5D_t69541BC5FF78E6A8031B638080B9821EA0364911* L_1 = Animator_GetBehaviours_TisBaseStateMachineBehavior_tC9B4D174C0E646DA37525E41FBB6A50C5DEEB064_mF2F48ED60DFB77DBA14E860AE010F54C9E4ED04B(L_0, /*hidden argument*/Animator_GetBehaviours_TisBaseStateMachineBehavior_tC9B4D174C0E646DA37525E41FBB6A50C5DEEB064_mF2F48ED60DFB77DBA14E860AE010F54C9E4ED04B_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 59519);
		V_0 = L_1;
		CHECK_SEQ_POINT(methodExecutionContext, 59509);
		// foreach (var behavior in behaviors)
		CHECK_SEQ_POINT(methodExecutionContext, 59510);
		BaseStateMachineBehaviorU5BU5D_t69541BC5FF78E6A8031B638080B9821EA0364911* L_2 = V_0;
		V_1 = L_2;
		V_2 = 0;
		CHECK_SEQ_POINT(methodExecutionContext, 59511);
		goto IL_0021;
	}

IL_000f:
	{
		// foreach (var behavior in behaviors)
		CHECK_SEQ_POINT(methodExecutionContext, 59512);
		BaseStateMachineBehaviorU5BU5D_t69541BC5FF78E6A8031B638080B9821EA0364911* L_3 = V_1;
		int32_t L_4 = V_2;
		NullCheck(L_3, il2cpp_codegen_get_sequence_point(59512));
		int32_t L_5 = L_4;
		BaseStateMachineBehavior_tC9B4D174C0E646DA37525E41FBB6A50C5DEEB064 * L_6 = (L_3)->GetAt(static_cast<il2cpp_array_size_t>(L_5));
		V_3 = L_6;
		CHECK_SEQ_POINT(methodExecutionContext, 59513);
		// behavior.Setup(a);
		CHECK_SEQ_POINT(methodExecutionContext, 59514);
		BaseStateMachineBehavior_tC9B4D174C0E646DA37525E41FBB6A50C5DEEB064 * L_7 = V_3;
		Actor_tC8E7F2C0FBC6266BB4ACD3F1D091F6AD50A15FEB * L_8 = ___a1;
		STORE_SEQ_POINT(methodExecutionContext, 59520);
		NullCheck(L_7, il2cpp_codegen_get_sequence_point(59514));
		BaseStateMachineBehavior_Setup_m021799DFB3AACCC67BDE6F6179B97567790F7A4B(L_7, L_8, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 59520);
		CHECK_SEQ_POINT(methodExecutionContext, 59515);
		CHECK_SEQ_POINT(methodExecutionContext, 59516);
		int32_t L_9 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add((int32_t)L_9, (int32_t)1));
	}

IL_0021:
	{
		// foreach (var behavior in behaviors)
		CHECK_SEQ_POINT(methodExecutionContext, 59517);
		int32_t L_10 = V_2;
		BaseStateMachineBehaviorU5BU5D_t69541BC5FF78E6A8031B638080B9821EA0364911* L_11 = V_1;
		NullCheck(L_11, il2cpp_codegen_get_sequence_point(59517));
		if ((((int32_t)L_10) < ((int32_t)(((int32_t)((int32_t)(((RuntimeArray *)L_11)->max_length)))))))
		{
			goto IL_000f;
		}
	}
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 59518);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.String Pixeye.SceneReference::get_Path()
extern "C" IL2CPP_METHOD_ATTR String_t* SceneReference_get_Path_mB04B812EFDB313EE0A501C4984EBD823BE8E146F (SceneReference_t824B30D7B4AAF610B0DBC1F5F54227F2BB69685F * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (SceneReference_get_Path_mB04B812EFDB313EE0A501C4984EBD823BE8E146F_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, SceneReference_get_Path_mB04B812EFDB313EE0A501C4984EBD823BE8E146F_RuntimeMethod_var, methodExecutionContextThis, NULL, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 64974);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 64975);
	{
		// public string Path => sceneName;
		CHECK_SEQ_POINT(methodExecutionContext, 64976);
		String_t* L_0 = __this->get_sceneName_1();
		return L_0;
	}
}
// System.String Pixeye.SceneReference::op_Implicit(Pixeye.SceneReference)
extern "C" IL2CPP_METHOD_ATTR String_t* SceneReference_op_Implicit_m35979307D7E55413DD3A5D6B01BF7E4A1A376134 (SceneReference_t824B30D7B4AAF610B0DBC1F5F54227F2BB69685F * ___sceneReference0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (SceneReference_op_Implicit_m35979307D7E55413DD3A5D6B01BF7E4A1A376134_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	String_t* V_0 = NULL;
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___sceneReference0));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, SceneReference_op_Implicit_m35979307D7E55413DD3A5D6B01BF7E4A1A376134_RuntimeMethod_var, NULL, methodExecutionContextParameters, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 64977);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 64978);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 64979);
		// return sceneReference.Path;
		CHECK_SEQ_POINT(methodExecutionContext, 64980);
		SceneReference_t824B30D7B4AAF610B0DBC1F5F54227F2BB69685F * L_0 = ___sceneReference0;
		STORE_SEQ_POINT(methodExecutionContext, 64982);
		NullCheck(L_0, il2cpp_codegen_get_sequence_point(64980));
		String_t* L_1 = SceneReference_get_Path_mB04B812EFDB313EE0A501C4984EBD823BE8E146F(L_0, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 64982);
		V_0 = L_1;
		goto IL_000a;
	}

IL_000a:
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 64981);
		String_t* L_2 = V_0;
		return L_2;
	}
}
// System.Void Pixeye.SceneReference::.ctor()
extern "C" IL2CPP_METHOD_ATTR void SceneReference__ctor_m5E587B2DAC13F4712610347BCBF5ECC6F73F932C (SceneReference_t824B30D7B4AAF610B0DBC1F5F54227F2BB69685F * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (SceneReference__ctor_m5E587B2DAC13F4712610347BCBF5ECC6F73F932C_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, SceneReference__ctor_m5E587B2DAC13F4712610347BCBF5ECC6F73F932C_RuntimeMethod_var, methodExecutionContextThis, NULL, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 64983);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 64984);
	{
		// private string sceneName = "";
		CHECK_SEQ_POINT(methodExecutionContext, 64985);
		__this->set_sceneName_1(_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709);
		STORE_SEQ_POINT(methodExecutionContext, 64986);
		Object__ctor_m925ECA5E85CA100E3FB86A4F9E15C120E9A184C0(__this, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 64986);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Pixeye.Script::.ctor()
extern "C" IL2CPP_METHOD_ATTR void Script__ctor_m1DF89829C44D0073506F8D615E5CEB121FB6B809 (Script_t5CAA335E115304E821B2CF96BCD8065B4397105D * __this, const RuntimeMethod* method)
{
	CHECK_PAUSE_POINT;
	{
		ScriptableObject__ctor_m6E2B3821A4A361556FC12E9B1C71E1D5DC002C5B(__this, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Pixeye.SettingsEngine::.ctor()
extern "C" IL2CPP_METHOD_ATTR void SettingsEngine__ctor_m39FAC96D3B721C2008C87928FB995E47721720C7 (SettingsEngine_tE5FAA3E51808E5B9F5820B753618576EE8035659 * __this, const RuntimeMethod* method)
{
	CHECK_PAUSE_POINT;
	{
		Object__ctor_m925ECA5E85CA100E3FB86A4F9E15C120E9A184C0(__this, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Pixeye.Starter::Awake()
extern "C" IL2CPP_METHOD_ATTR void Starter_Awake_m1120568736201A5193A79CAB44F7DAEB50EE902B (Starter_t094EE6CE9643F0578E88871EBE1EE57879A38146 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Starter_Awake_m1120568736201A5193A79CAB44F7DAEB50EE902B_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, Starter_Awake_m1120568736201A5193A79CAB44F7DAEB50EE902B_RuntimeMethod_var, methodExecutionContextThis, NULL, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 64987);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 64988);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 64989);
		// if (HandleUpdate.Default == null)
		CHECK_SEQ_POINT(methodExecutionContext, 64990);
		HandleUpdate_t2060842DBF2069E5F3DD3C37B41CA77A1C7B78A3 * L_0 = ((HandleUpdate_t2060842DBF2069E5F3DD3C37B41CA77A1C7B78A3_StaticFields*)il2cpp_codegen_static_fields_for(HandleUpdate_t2060842DBF2069E5F3DD3C37B41CA77A1C7B78A3_il2cpp_TypeInfo_var))->get_Default_7();
		STORE_SEQ_POINT(methodExecutionContext, 64997);
		IL2CPP_RUNTIME_CLASS_INIT(Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0_il2cpp_TypeInfo_var);
		bool L_1 = Object_op_Equality_mBC2401774F3BE33E8CF6F0A8148E66C95D6CFF1C(L_0, (Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0 *)NULL, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 64997);
		V_0 = L_1;
		CHECK_SEQ_POINT(methodExecutionContext, 64991);
		bool L_2 = V_0;
		if (!L_2)
		{
			goto IL_0018;
		}
	}
	{
		CHECK_SEQ_POINT(methodExecutionContext, 64992);
		// HandleUpdate.Create();
		CHECK_SEQ_POINT(methodExecutionContext, 64993);
		STORE_SEQ_POINT(methodExecutionContext, 64998);
		HandleUpdate_Create_m70DFEE53D4C60B71D3957265BA2D839C76A76072(/*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 64998);
		CHECK_SEQ_POINT(methodExecutionContext, 64994);
	}

IL_0018:
	{
		// HandleScene.Default.Setup(ScenesToKeep, SceneDependsOn, this);
		CHECK_SEQ_POINT(methodExecutionContext, 64995);
		IL2CPP_RUNTIME_CLASS_INIT(HandleScene_t9A17EE1370450F47652A7C56B9D20A02A7BA1728_il2cpp_TypeInfo_var);
		HandleScene_t9A17EE1370450F47652A7C56B9D20A02A7BA1728 * L_3 = ((HandleScene_t9A17EE1370450F47652A7C56B9D20A02A7BA1728_StaticFields*)il2cpp_codegen_static_fields_for(HandleScene_t9A17EE1370450F47652A7C56B9D20A02A7BA1728_il2cpp_TypeInfo_var))->get_Default_0();
		List_1_t80222E8941042447035EF5455CC2D2B763E5AE8B * L_4 = __this->get_ScenesToKeep_6();
		List_1_t80222E8941042447035EF5455CC2D2B763E5AE8B * L_5 = __this->get_SceneDependsOn_7();
		STORE_SEQ_POINT(methodExecutionContext, 64999);
		NullCheck(L_3, il2cpp_codegen_get_sequence_point(64995));
		HandleScene_Setup_m5A7756A3739938F1AA79C6373C8100A27A11BCD2(L_3, L_4, L_5, __this, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 64999);
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 64996);
		return;
	}
}
// System.Void Pixeye.Starter::BindScene()
extern "C" IL2CPP_METHOD_ATTR void Starter_BindScene_m48FDC251F232774AE14DBE07598841EAA7D58C8A (Starter_t094EE6CE9643F0578E88871EBE1EE57879A38146 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Starter_BindScene_m48FDC251F232774AE14DBE07598841EAA7D58C8A_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	MonoBehaviourU5BU5D_tEC81C7491112CB97F70976A67ABB8C33168F5F0A* V_0 = NULL;
	int32_t V_1 = 0;
	bool V_2 = false;
	Enumerator_tCCCA7DEF5437A9668FAB3E25F19542413527939A  V_3;
	memset(&V_3, 0, sizeof(V_3));
	Factory_tFA5041074647498CBAB64B0C4ABD43314393E7A5 * V_4 = NULL;
	int32_t V_5 = 0;
	MonoBehaviour_t4A60845CF505405AF8BE8C61CC07F75CADEF6429 * V_6 = NULL;
	RuntimeObject* V_7 = NULL;
	bool V_8 = false;
	bool V_9 = false;
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_LOCALS(methodExecutionContextLocals, (&V_0), (&V_1), (&V_4), (&V_5), (&V_6), (&V_7));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, Starter_BindScene_m48FDC251F232774AE14DBE07598841EAA7D58C8A_RuntimeMethod_var, methodExecutionContextThis, NULL, methodExecutionContextLocals);
	CHECK_SEQ_POINT(methodExecutionContext, 65000);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 65001);
	Exception_t * __last_unhandled_exception = 0;
	NO_UNUSED_WARNING (__last_unhandled_exception);
	Exception_t * __exception_local = 0;
	NO_UNUSED_WARNING (__exception_local);
	int32_t __leave_target = -1;
	NO_UNUSED_WARNING (__leave_target);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 65002);
		// for ( int i = 0; i < nodes.Count; i++ )
		CHECK_SEQ_POINT(methodExecutionContext, 65003);
		V_1 = 0;
		CHECK_SEQ_POINT(methodExecutionContext, 65004);
		goto IL_001d;
	}

IL_0005:
	{
		CHECK_SEQ_POINT(methodExecutionContext, 65005);
		// nodes[i].Populate();
		CHECK_SEQ_POINT(methodExecutionContext, 65006);
		List_1_tF89465888600A0DC538773BB071C4AFEA6A8597E * L_0 = __this->get_nodes_8();
		int32_t L_1 = V_1;
		STORE_SEQ_POINT(methodExecutionContext, 65040);
		NullCheck(L_0, il2cpp_codegen_get_sequence_point(65006));
		PoolNode_tD412A3A536E55E03495943E9F456B844ACBB2568 * L_2 = List_1_get_Item_mAAD89C5F555E6D9E8A6BD72F7E8C6105B9E04789(L_0, L_1, /*hidden argument*/List_1_get_Item_mAAD89C5F555E6D9E8A6BD72F7E8C6105B9E04789_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 65040);
		STORE_SEQ_POINT(methodExecutionContext, 65041);
		NullCheck(L_2, il2cpp_codegen_get_sequence_point(65006));
		PoolNode_Populate_m1820B61B055864A65E0FC800C94F84C65A88E2E5(L_2, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 65041);
		CHECK_SEQ_POINT(methodExecutionContext, 65007);
		// for ( int i = 0; i < nodes.Count; i++ )
		CHECK_SEQ_POINT(methodExecutionContext, 65008);
		int32_t L_3 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add((int32_t)L_3, (int32_t)1));
	}

IL_001d:
	{
		// for ( int i = 0; i < nodes.Count; i++ )
		CHECK_SEQ_POINT(methodExecutionContext, 65009);
		int32_t L_4 = V_1;
		List_1_tF89465888600A0DC538773BB071C4AFEA6A8597E * L_5 = __this->get_nodes_8();
		STORE_SEQ_POINT(methodExecutionContext, 65042);
		NullCheck(L_5, il2cpp_codegen_get_sequence_point(65009));
		int32_t L_6 = List_1_get_Count_mEDAF9F74023B67E06EFC1B56D8F15202AE3E8C36(L_5, /*hidden argument*/List_1_get_Count_mEDAF9F74023B67E06EFC1B56D8F15202AE3E8C36_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 65042);
		V_2 = (bool)((((int32_t)L_4) < ((int32_t)L_6))? 1 : 0);
		CHECK_SEQ_POINT(methodExecutionContext, 65010);
		bool L_7 = V_2;
		if (L_7)
		{
			goto IL_0005;
		}
	}
	{
		CHECK_SEQ_POINT(methodExecutionContext, 65011);
		// foreach ( var factory in factories )
		CHECK_SEQ_POINT(methodExecutionContext, 65012);
		List_1_tA0E2AEAC02B0C34F5538C6D39174C6E22259F642 * L_8 = __this->get_factories_5();
		STORE_SEQ_POINT(methodExecutionContext, 65043);
		NullCheck(L_8, il2cpp_codegen_get_sequence_point(65012));
		Enumerator_tCCCA7DEF5437A9668FAB3E25F19542413527939A  L_9 = List_1_GetEnumerator_mCBF188196E6175158D5266EEDFD0D4BB30B62115(L_8, /*hidden argument*/List_1_GetEnumerator_mCBF188196E6175158D5266EEDFD0D4BB30B62115_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 65043);
		V_3 = L_9;
	}

IL_003c:
	try
	{ // begin try (depth: 1)
		{
			CHECK_SEQ_POINT(methodExecutionContext, 65013);
			goto IL_0051;
		}

IL_003e:
		{
			// foreach ( var factory in factories )
			CHECK_SEQ_POINT(methodExecutionContext, 65014);
			STORE_SEQ_POINT(methodExecutionContext, 65044);
			Factory_tFA5041074647498CBAB64B0C4ABD43314393E7A5 * L_10 = Enumerator_get_Current_m67516B76FD35F63A1B24DAA385BF84A83964D641((Enumerator_tCCCA7DEF5437A9668FAB3E25F19542413527939A *)(&V_3), /*hidden argument*/Enumerator_get_Current_m67516B76FD35F63A1B24DAA385BF84A83964D641_RuntimeMethod_var);
			CHECK_SEQ_POINT(methodExecutionContext, 65044);
			V_4 = L_10;
			CHECK_SEQ_POINT(methodExecutionContext, 65015);
			// Toolbox.Add(factory);
			CHECK_SEQ_POINT(methodExecutionContext, 65016);
			Factory_tFA5041074647498CBAB64B0C4ABD43314393E7A5 * L_11 = V_4;
			STORE_SEQ_POINT(methodExecutionContext, 65045);
			Toolbox_Add_mBDBD189E3DF0F0617BEB2FF6ECC08CC748DB4FF9(L_11, /*hidden argument*/NULL);
			CHECK_SEQ_POINT(methodExecutionContext, 65045);
			CHECK_SEQ_POINT(methodExecutionContext, 65017);
		}

IL_0051:
		{
			// foreach ( var factory in factories )
			CHECK_SEQ_POINT(methodExecutionContext, 65018);
			STORE_SEQ_POINT(methodExecutionContext, 65046);
			bool L_12 = Enumerator_MoveNext_mB2585B01CD7E37F43666F5349D25C40BBF37DAB0((Enumerator_tCCCA7DEF5437A9668FAB3E25F19542413527939A *)(&V_3), /*hidden argument*/Enumerator_MoveNext_mB2585B01CD7E37F43666F5349D25C40BBF37DAB0_RuntimeMethod_var);
			CHECK_SEQ_POINT(methodExecutionContext, 65046);
			if (L_12)
			{
				goto IL_003e;
			}
		}

IL_005a:
		{
			IL2CPP_LEAVE(0x6B, FINALLY_005c);
		}
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		__last_unhandled_exception = (Exception_t *)e.ex;
		goto FINALLY_005c;
	}

FINALLY_005c:
	{ // begin finally (depth: 1)
		CHECK_SEQ_POINT(methodExecutionContext, 65019);
		STORE_SEQ_POINT(methodExecutionContext, 65047);
		Enumerator_Dispose_m00358105CD68F800EAC90C662F3CBA417D034906((Enumerator_tCCCA7DEF5437A9668FAB3E25F19542413527939A *)(&V_3), /*hidden argument*/Enumerator_Dispose_m00358105CD68F800EAC90C662F3CBA417D034906_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 65047);
		IL2CPP_RESET_LEAVE(0x6B);
		IL2CPP_END_FINALLY(92)
	} // end finally (depth: 1)
	IL2CPP_CLEANUP(92)
	{
		IL2CPP_JUMP_TBL(0x6B, IL_006b)
		IL2CPP_RETHROW_IF_UNHANDLED(Exception_t *)
	}

IL_006b:
	{
		// Add<HandleActorsAdd>();
		CHECK_SEQ_POINT(methodExecutionContext, 65020);
		STORE_SEQ_POINT(methodExecutionContext, 65048);
		Starter_Add_TisHandleActorsAdd_t8D5278068F1EACBBF9799D835738C552E5550F9E_mA560947496F70A63FF412D33E89301B4DF85B112(/*hidden argument*/Starter_Add_TisHandleActorsAdd_t8D5278068F1EACBBF9799D835738C552E5550F9E_mA560947496F70A63FF412D33E89301B4DF85B112_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 65048);
		// Setup();
		CHECK_SEQ_POINT(methodExecutionContext, 65021);
		STORE_SEQ_POINT(methodExecutionContext, 65049);
		VirtActionInvoker0::Invoke(4 /* System.Void Pixeye.Starter::Setup() */, __this);
		CHECK_SEQ_POINT(methodExecutionContext, 65049);
		// initialized = true;
		CHECK_SEQ_POINT(methodExecutionContext, 65022);
		((Starter_t094EE6CE9643F0578E88871EBE1EE57879A38146_StaticFields*)il2cpp_codegen_static_fields_for(Starter_t094EE6CE9643F0578E88871EBE1EE57879A38146_il2cpp_TypeInfo_var))->set_initialized_4((bool)1);
		// var objs = FindObjectsOfType<MonoBehaviour>();
		CHECK_SEQ_POINT(methodExecutionContext, 65023);
		STORE_SEQ_POINT(methodExecutionContext, 65050);
		IL2CPP_RUNTIME_CLASS_INIT(Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0_il2cpp_TypeInfo_var);
		MonoBehaviourU5BU5D_tEC81C7491112CB97F70976A67ABB8C33168F5F0A* L_13 = Object_FindObjectsOfType_TisMonoBehaviour_t4A60845CF505405AF8BE8C61CC07F75CADEF6429_m3BD4005DB6D046DA65FFD7427BE77F266D98D13B(/*hidden argument*/Object_FindObjectsOfType_TisMonoBehaviour_t4A60845CF505405AF8BE8C61CC07F75CADEF6429_m3BD4005DB6D046DA65FFD7427BE77F266D98D13B_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 65050);
		V_0 = L_13;
		// for ( var i = 0; i < objs.Length; i++ )
		CHECK_SEQ_POINT(methodExecutionContext, 65024);
		V_5 = 0;
		CHECK_SEQ_POINT(methodExecutionContext, 65025);
		goto IL_00b5;
	}

IL_0089:
	{
		CHECK_SEQ_POINT(methodExecutionContext, 65026);
		// var obj  = objs[i];
		CHECK_SEQ_POINT(methodExecutionContext, 65027);
		MonoBehaviourU5BU5D_tEC81C7491112CB97F70976A67ABB8C33168F5F0A* L_14 = V_0;
		int32_t L_15 = V_5;
		NullCheck(L_14, il2cpp_codegen_get_sequence_point(65027));
		int32_t L_16 = L_15;
		MonoBehaviour_t4A60845CF505405AF8BE8C61CC07F75CADEF6429 * L_17 = (L_14)->GetAt(static_cast<il2cpp_array_size_t>(L_16));
		V_6 = L_17;
		// var ireq = obj as IRequireStarter;
		CHECK_SEQ_POINT(methodExecutionContext, 65028);
		MonoBehaviour_t4A60845CF505405AF8BE8C61CC07F75CADEF6429 * L_18 = V_6;
		V_7 = ((RuntimeObject*)IsInst((RuntimeObject*)L_18, IRequireStarter_t5149D99640196B893E1AE71434420EB865532225_il2cpp_TypeInfo_var));
		// if (ireq != null)
		CHECK_SEQ_POINT(methodExecutionContext, 65029);
		RuntimeObject* L_19 = V_7;
		V_8 = (bool)((!(((RuntimeObject*)(RuntimeObject*)L_19) <= ((RuntimeObject*)(RuntimeObject *)NULL)))? 1 : 0);
		CHECK_SEQ_POINT(methodExecutionContext, 65030);
		bool L_20 = V_8;
		if (!L_20)
		{
			goto IL_00ae;
		}
	}
	{
		CHECK_SEQ_POINT(methodExecutionContext, 65031);
		// ireq.SetupAfterStarter();
		CHECK_SEQ_POINT(methodExecutionContext, 65032);
		RuntimeObject* L_21 = V_7;
		STORE_SEQ_POINT(methodExecutionContext, 65051);
		NullCheck(L_21, il2cpp_codegen_get_sequence_point(65032));
		InterfaceActionInvoker0::Invoke(0 /* System.Void Pixeye.IRequireStarter::SetupAfterStarter() */, IRequireStarter_t5149D99640196B893E1AE71434420EB865532225_il2cpp_TypeInfo_var, L_21);
		CHECK_SEQ_POINT(methodExecutionContext, 65051);
		CHECK_SEQ_POINT(methodExecutionContext, 65033);
	}

IL_00ae:
	{
		CHECK_SEQ_POINT(methodExecutionContext, 65034);
		// for ( var i = 0; i < objs.Length; i++ )
		CHECK_SEQ_POINT(methodExecutionContext, 65035);
		int32_t L_22 = V_5;
		V_5 = ((int32_t)il2cpp_codegen_add((int32_t)L_22, (int32_t)1));
	}

IL_00b5:
	{
		// for ( var i = 0; i < objs.Length; i++ )
		CHECK_SEQ_POINT(methodExecutionContext, 65036);
		int32_t L_23 = V_5;
		MonoBehaviourU5BU5D_tEC81C7491112CB97F70976A67ABB8C33168F5F0A* L_24 = V_0;
		NullCheck(L_24, il2cpp_codegen_get_sequence_point(65036));
		V_9 = (bool)((((int32_t)L_23) < ((int32_t)(((int32_t)((int32_t)(((RuntimeArray *)L_24)->max_length))))))? 1 : 0);
		CHECK_SEQ_POINT(methodExecutionContext, 65037);
		bool L_25 = V_9;
		if (L_25)
		{
			goto IL_0089;
		}
	}
	{
		// Timer.Add(Time.deltaFixed * 2, () =>
		// {
		//     PostSetup();
		//     Add<HandleActorsRemove>();
		// });
		CHECK_SEQ_POINT(methodExecutionContext, 65038);
		STORE_SEQ_POINT(methodExecutionContext, 65052);
		IL2CPP_RUNTIME_CLASS_INIT(Time_t70920BA2C4C4BE707DAE9822ED553B006FFC0100_il2cpp_TypeInfo_var);
		float L_26 = Time_get_deltaFixed_mC41C8B31BC0F5F34522AF1B72CE977D5E07A490E(/*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 65052);
		STORE_SEQ_POINT(methodExecutionContext, 65053);
		Action_t591D2A86165F896B4B800BB5C25CE18672A55579 * L_27 = (Action_t591D2A86165F896B4B800BB5C25CE18672A55579 *)il2cpp_codegen_object_new(Action_t591D2A86165F896B4B800BB5C25CE18672A55579_il2cpp_TypeInfo_var);
		Action__ctor_m570E96B2A0C48BC1DC6788460316191F24572760(L_27, __this, (intptr_t)((intptr_t)Starter_U3CBindSceneU3Eb__6_0_m4D490AE422A931AD8455C3B08096DA81CD4C780E_RuntimeMethod_var), /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 65053);
		STORE_SEQ_POINT(methodExecutionContext, 65054);
		IL2CPP_RUNTIME_CLASS_INIT(Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA_il2cpp_TypeInfo_var);
		Timer_Add_mFA7866CEC7552E59E915183E6405C77CFAA61207(((float)il2cpp_codegen_multiply((float)L_26, (float)(2.0f))), L_27, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 65054);
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 65039);
		return;
	}
}
// System.Void Pixeye.Starter::Setup()
extern "C" IL2CPP_METHOD_ATTR void Starter_Setup_m7168F366433C5D66CEFDDDEF603B134B232C1B5A (Starter_t094EE6CE9643F0578E88871EBE1EE57879A38146 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Starter_Setup_m7168F366433C5D66CEFDDDEF603B134B232C1B5A_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, Starter_Setup_m7168F366433C5D66CEFDDDEF603B134B232C1B5A_RuntimeMethod_var, methodExecutionContextThis, NULL, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 65061);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 65062);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 65063);
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 65064);
		return;
	}
}
// System.Void Pixeye.Starter::PostSetup()
extern "C" IL2CPP_METHOD_ATTR void Starter_PostSetup_mC00BA4E660755D48275215D267359E3D1F8D19F9 (Starter_t094EE6CE9643F0578E88871EBE1EE57879A38146 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Starter_PostSetup_mC00BA4E660755D48275215D267359E3D1F8D19F9_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, Starter_PostSetup_mC00BA4E660755D48275215D267359E3D1F8D19F9_RuntimeMethod_var, methodExecutionContextThis, NULL, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 65065);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 65066);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 65067);
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 65068);
		return;
	}
}
// System.Void Pixeye.Starter::OnDestroy()
extern "C" IL2CPP_METHOD_ATTR void Starter_OnDestroy_mFBFD3B6AEDA51D1E7D00BE36A8603F923B36EE21 (Starter_t094EE6CE9643F0578E88871EBE1EE57879A38146 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Starter_OnDestroy_mFBFD3B6AEDA51D1E7D00BE36A8603F923B36EE21_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, Starter_OnDestroy_mFBFD3B6AEDA51D1E7D00BE36A8603F923B36EE21_RuntimeMethod_var, methodExecutionContextThis, NULL, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 65069);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 65070);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 65071);
		// initialized = false;
		CHECK_SEQ_POINT(methodExecutionContext, 65072);
		((Starter_t094EE6CE9643F0578E88871EBE1EE57879A38146_StaticFields*)il2cpp_codegen_static_fields_for(Starter_t094EE6CE9643F0578E88871EBE1EE57879A38146_il2cpp_TypeInfo_var))->set_initialized_4((bool)0);
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 65073);
		return;
	}
}
// System.Void Pixeye.Starter::.ctor()
extern "C" IL2CPP_METHOD_ATTR void Starter__ctor_m07462EA4F217E11C903BBCD94F02F056D27822FC (Starter_t094EE6CE9643F0578E88871EBE1EE57879A38146 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Starter__ctor_m07462EA4F217E11C903BBCD94F02F056D27822FC_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, Starter__ctor_m07462EA4F217E11C903BBCD94F02F056D27822FC_RuntimeMethod_var, methodExecutionContextThis, NULL, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 65074);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 65075);
	{
		// public List<PoolNode> nodes = new List<PoolNode>();
		CHECK_SEQ_POINT(methodExecutionContext, 65076);
		STORE_SEQ_POINT(methodExecutionContext, 65077);
		List_1_tF89465888600A0DC538773BB071C4AFEA6A8597E * L_0 = (List_1_tF89465888600A0DC538773BB071C4AFEA6A8597E *)il2cpp_codegen_object_new(List_1_tF89465888600A0DC538773BB071C4AFEA6A8597E_il2cpp_TypeInfo_var);
		List_1__ctor_m9461BD0419807AF9A434D9C6D4E95A1C4ABF4759(L_0, /*hidden argument*/List_1__ctor_m9461BD0419807AF9A434D9C6D4E95A1C4ABF4759_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 65077);
		__this->set_nodes_8(L_0);
		STORE_SEQ_POINT(methodExecutionContext, 65078);
		MonoBehaviour__ctor_mEAEC84B222C60319D593E456D769B3311DFCEF97(__this, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 65078);
		return;
	}
}
// System.Void Pixeye.Starter::<BindScene>b__6_0()
extern "C" IL2CPP_METHOD_ATTR void Starter_U3CBindSceneU3Eb__6_0_m4D490AE422A931AD8455C3B08096DA81CD4C780E (Starter_t094EE6CE9643F0578E88871EBE1EE57879A38146 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Starter_U3CBindSceneU3Eb__6_0_m4D490AE422A931AD8455C3B08096DA81CD4C780E_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, Starter_U3CBindSceneU3Eb__6_0_m4D490AE422A931AD8455C3B08096DA81CD4C780E_RuntimeMethod_var, methodExecutionContextThis, NULL, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 65079);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 65080);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 65081);
		// PostSetup();
		CHECK_SEQ_POINT(methodExecutionContext, 65082);
		STORE_SEQ_POINT(methodExecutionContext, 65085);
		VirtActionInvoker0::Invoke(5 /* System.Void Pixeye.Starter::PostSetup() */, __this);
		CHECK_SEQ_POINT(methodExecutionContext, 65085);
		// Add<HandleActorsRemove>();
		CHECK_SEQ_POINT(methodExecutionContext, 65083);
		STORE_SEQ_POINT(methodExecutionContext, 65086);
		Starter_Add_TisHandleActorsRemove_t775454EB912F9A2B222D5E61FA84C2DE6EFFAEA7_m713D123155C4DAEC92D33D1F2DC1740CACDE86C5(/*hidden argument*/Starter_Add_TisHandleActorsRemove_t775454EB912F9A2B222D5E61FA84C2DE6EFFAEA7_m713D123155C4DAEC92D33D1F2DC1740CACDE86C5_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 65086);
		// });
		CHECK_SEQ_POINT(methodExecutionContext, 65084);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Pixeye.StarterKernel::Awake()
extern "C" IL2CPP_METHOD_ATTR void StarterKernel_Awake_mB592AB780528F8CFE2DCDE25EFD7315EC73160F2 (StarterKernel_t383AD5285BEE52A4F9F6FDBE97E01A368CE25E27 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (StarterKernel_Awake_mB592AB780528F8CFE2DCDE25EFD7315EC73160F2_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	bool V_1 = false;
	bool V_2 = false;
	bool V_3 = false;
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_LOCALS(methodExecutionContextLocals, (&V_0));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, StarterKernel_Awake_mB592AB780528F8CFE2DCDE25EFD7315EC73160F2_RuntimeMethod_var, methodExecutionContextThis, NULL, methodExecutionContextLocals);
	CHECK_SEQ_POINT(methodExecutionContext, 65087);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 65088);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 65089);
		// for ( var i = 0; i < pluggables.Count; i++ )
		CHECK_SEQ_POINT(methodExecutionContext, 65090);
		V_0 = 0;
		CHECK_SEQ_POINT(methodExecutionContext, 65091);
		goto IL_001d;
	}

IL_0005:
	{
		CHECK_SEQ_POINT(methodExecutionContext, 65092);
		// pluggables[i].Plug();
		CHECK_SEQ_POINT(methodExecutionContext, 65093);
		List_1_t2D6D202FD59CE78CF20816E533E40E75EF42A211 * L_0 = __this->get_pluggables_6();
		int32_t L_1 = V_0;
		STORE_SEQ_POINT(methodExecutionContext, 65108);
		NullCheck(L_0, il2cpp_codegen_get_sequence_point(65093));
		Pluggable_tED235F8443B870F25950EF2914429DA66218ADAD * L_2 = List_1_get_Item_m54372A031C118324F5CEE30AB6FFEDA511E874E8(L_0, L_1, /*hidden argument*/List_1_get_Item_m54372A031C118324F5CEE30AB6FFEDA511E874E8_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 65108);
		STORE_SEQ_POINT(methodExecutionContext, 65109);
		NullCheck(L_2, il2cpp_codegen_get_sequence_point(65093));
		VirtActionInvoker0::Invoke(4 /* System.Void Pixeye.Pluggable::Plug() */, L_2);
		CHECK_SEQ_POINT(methodExecutionContext, 65109);
		CHECK_SEQ_POINT(methodExecutionContext, 65094);
		// for ( var i = 0; i < pluggables.Count; i++ )
		CHECK_SEQ_POINT(methodExecutionContext, 65095);
		int32_t L_3 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add((int32_t)L_3, (int32_t)1));
	}

IL_001d:
	{
		// for ( var i = 0; i < pluggables.Count; i++ )
		CHECK_SEQ_POINT(methodExecutionContext, 65096);
		int32_t L_4 = V_0;
		List_1_t2D6D202FD59CE78CF20816E533E40E75EF42A211 * L_5 = __this->get_pluggables_6();
		STORE_SEQ_POINT(methodExecutionContext, 65110);
		NullCheck(L_5, il2cpp_codegen_get_sequence_point(65096));
		int32_t L_6 = List_1_get_Count_m83C0B08646B75C0726AF3C49B42E96B63CF78BB0(L_5, /*hidden argument*/List_1_get_Count_m83C0B08646B75C0726AF3C49B42E96B63CF78BB0_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 65110);
		V_1 = (bool)((((int32_t)L_4) < ((int32_t)L_6))? 1 : 0);
		CHECK_SEQ_POINT(methodExecutionContext, 65097);
		bool L_7 = V_1;
		if (L_7)
		{
			goto IL_0005;
		}
	}
	{
		// if (gameSession != null)
		CHECK_SEQ_POINT(methodExecutionContext, 65098);
		DataGame_t550789F8B729098267FD582F1E101BD29282BC52 * L_8 = __this->get_gameSession_4();
		STORE_SEQ_POINT(methodExecutionContext, 65111);
		IL2CPP_RUNTIME_CLASS_INIT(Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0_il2cpp_TypeInfo_var);
		bool L_9 = Object_op_Inequality_m31EF58E217E8F4BDD3E409DEF79E1AEE95874FC1(L_8, (Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0 *)NULL, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 65111);
		V_2 = L_9;
		CHECK_SEQ_POINT(methodExecutionContext, 65099);
		bool L_10 = V_2;
		if (!L_10)
		{
			goto IL_004b;
		}
	}
	{
		// Toolbox.Add(gameSession);
		CHECK_SEQ_POINT(methodExecutionContext, 65100);
		DataGame_t550789F8B729098267FD582F1E101BD29282BC52 * L_11 = __this->get_gameSession_4();
		STORE_SEQ_POINT(methodExecutionContext, 65112);
		Toolbox_Add_mBDBD189E3DF0F0617BEB2FF6ECC08CC748DB4FF9(L_11, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 65112);
	}

IL_004b:
	{
		// if (gameSettings != null)
		CHECK_SEQ_POINT(methodExecutionContext, 65101);
		DataGame_t550789F8B729098267FD582F1E101BD29282BC52 * L_12 = __this->get_gameSettings_5();
		STORE_SEQ_POINT(methodExecutionContext, 65113);
		IL2CPP_RUNTIME_CLASS_INIT(Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0_il2cpp_TypeInfo_var);
		bool L_13 = Object_op_Inequality_m31EF58E217E8F4BDD3E409DEF79E1AEE95874FC1(L_12, (Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0 *)NULL, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 65113);
		V_3 = L_13;
		CHECK_SEQ_POINT(methodExecutionContext, 65102);
		bool L_14 = V_3;
		if (!L_14)
		{
			goto IL_0069;
		}
	}
	{
		CHECK_SEQ_POINT(methodExecutionContext, 65103);
		// Toolbox.Add(gameSettings);
		CHECK_SEQ_POINT(methodExecutionContext, 65104);
		DataGame_t550789F8B729098267FD582F1E101BD29282BC52 * L_15 = __this->get_gameSettings_5();
		STORE_SEQ_POINT(methodExecutionContext, 65114);
		Toolbox_Add_mBDBD189E3DF0F0617BEB2FF6ECC08CC748DB4FF9(L_15, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 65114);
		CHECK_SEQ_POINT(methodExecutionContext, 65105);
	}

IL_0069:
	{
		// HandleFastPool<Timer>.Instance.Populate(50);
		CHECK_SEQ_POINT(methodExecutionContext, 65106);
		IL2CPP_RUNTIME_CLASS_INIT(HandleFastPool_1_t717E0511090B921AEE3A8436B7B8AB6BC1A0C0AD_il2cpp_TypeInfo_var);
		HandleFastPool_1_t717E0511090B921AEE3A8436B7B8AB6BC1A0C0AD * L_16 = ((HandleFastPool_1_t717E0511090B921AEE3A8436B7B8AB6BC1A0C0AD_StaticFields*)il2cpp_codegen_static_fields_for(HandleFastPool_1_t717E0511090B921AEE3A8436B7B8AB6BC1A0C0AD_il2cpp_TypeInfo_var))->get_Instance_0();
		STORE_SEQ_POINT(methodExecutionContext, 65115);
		NullCheck(L_16, il2cpp_codegen_get_sequence_point(65106));
		HandleFastPool_1_Populate_m9622D906DBE9E77119FF081D14CE50800C6B1CED(L_16, ((int32_t)50), /*hidden argument*/HandleFastPool_1_Populate_m9622D906DBE9E77119FF081D14CE50800C6B1CED_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 65115);
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 65107);
		return;
	}
}
// System.Collections.IEnumerator Pixeye.StarterKernel::OnApplicationFocus(System.Boolean)
extern "C" IL2CPP_METHOD_ATTR RuntimeObject* StarterKernel_OnApplicationFocus_m2D527AFF6687B25412E99269754DAF7232E10391 (StarterKernel_t383AD5285BEE52A4F9F6FDBE97E01A368CE25E27 * __this, bool ___hasFocus0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (StarterKernel_OnApplicationFocus_m2D527AFF6687B25412E99269754DAF7232E10391_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	CHECK_PAUSE_POINT;
	{
		U3COnApplicationFocusU3Ed__4_t6A81BE9FFD6951A1410B57DFD8BCA01E3D3AF5E4 * L_0 = (U3COnApplicationFocusU3Ed__4_t6A81BE9FFD6951A1410B57DFD8BCA01E3D3AF5E4 *)il2cpp_codegen_object_new(U3COnApplicationFocusU3Ed__4_t6A81BE9FFD6951A1410B57DFD8BCA01E3D3AF5E4_il2cpp_TypeInfo_var);
		U3COnApplicationFocusU3Ed__4__ctor_m6B39E880A6828370D4A2E2A3C4AF1E0C43796613(L_0, 0, /*hidden argument*/NULL);
		U3COnApplicationFocusU3Ed__4_t6A81BE9FFD6951A1410B57DFD8BCA01E3D3AF5E4 * L_1 = L_0;
		NullCheck(L_1);
		L_1->set_U3CU3E4__this_3(__this);
		U3COnApplicationFocusU3Ed__4_t6A81BE9FFD6951A1410B57DFD8BCA01E3D3AF5E4 * L_2 = L_1;
		bool L_3 = ___hasFocus0;
		NullCheck(L_2);
		L_2->set_hasFocus_2(L_3);
		return L_2;
	}
}
// System.Void Pixeye.StarterKernel::.ctor()
extern "C" IL2CPP_METHOD_ATTR void StarterKernel__ctor_mC262E406BBEAD3D23939BEA529B3FDB3DBCC25B3 (StarterKernel_t383AD5285BEE52A4F9F6FDBE97E01A368CE25E27 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (StarterKernel__ctor_mC262E406BBEAD3D23939BEA529B3FDB3DBCC25B3_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, StarterKernel__ctor_mC262E406BBEAD3D23939BEA529B3FDB3DBCC25B3_RuntimeMethod_var, methodExecutionContextThis, NULL, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 65116);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 65117);
	{
		// public List<Pluggable> pluggables = new List<Pluggable>();
		CHECK_SEQ_POINT(methodExecutionContext, 65118);
		STORE_SEQ_POINT(methodExecutionContext, 65119);
		List_1_t2D6D202FD59CE78CF20816E533E40E75EF42A211 * L_0 = (List_1_t2D6D202FD59CE78CF20816E533E40E75EF42A211 *)il2cpp_codegen_object_new(List_1_t2D6D202FD59CE78CF20816E533E40E75EF42A211_il2cpp_TypeInfo_var);
		List_1__ctor_m1DAC5E4BC778402B5E74A5A4FDCE1AA28E4B3EF5(L_0, /*hidden argument*/List_1__ctor_m1DAC5E4BC778402B5E74A5A4FDCE1AA28E4B3EF5_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 65119);
		__this->set_pluggables_6(L_0);
		STORE_SEQ_POINT(methodExecutionContext, 65120);
		MonoBehaviour__ctor_mEAEC84B222C60319D593E456D769B3311DFCEF97(__this, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 65120);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Pixeye.StarterKernel_<OnApplicationFocus>d__4::.ctor(System.Int32)
extern "C" IL2CPP_METHOD_ATTR void U3COnApplicationFocusU3Ed__4__ctor_m6B39E880A6828370D4A2E2A3C4AF1E0C43796613 (U3COnApplicationFocusU3Ed__4_t6A81BE9FFD6951A1410B57DFD8BCA01E3D3AF5E4 * __this, int32_t ___U3CU3E1__state0, const RuntimeMethod* method)
{
	CHECK_PAUSE_POINT;
	{
		Object__ctor_m925ECA5E85CA100E3FB86A4F9E15C120E9A184C0(__this, /*hidden argument*/NULL);
		int32_t L_0 = ___U3CU3E1__state0;
		__this->set_U3CU3E1__state_0(L_0);
		return;
	}
}
// System.Void Pixeye.StarterKernel_<OnApplicationFocus>d__4::System.IDisposable.Dispose()
extern "C" IL2CPP_METHOD_ATTR void U3COnApplicationFocusU3Ed__4_System_IDisposable_Dispose_mAA25BF0AF023E964F8482339205949D5A563CB6D (U3COnApplicationFocusU3Ed__4_t6A81BE9FFD6951A1410B57DFD8BCA01E3D3AF5E4 * __this, const RuntimeMethod* method)
{
	CHECK_PAUSE_POINT;
	{
		return;
	}
}
// System.Boolean Pixeye.StarterKernel_<OnApplicationFocus>d__4::MoveNext()
extern "C" IL2CPP_METHOD_ATTR bool U3COnApplicationFocusU3Ed__4_MoveNext_m8E765B73A1FDF3C0707D50DC451596259629DB53 (U3COnApplicationFocusU3Ed__4_t6A81BE9FFD6951A1410B57DFD8BCA01E3D3AF5E4 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (U3COnApplicationFocusU3Ed__4_MoveNext_m8E765B73A1FDF3C0707D50DC451596259629DB53_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	bool V_1 = false;
	bool V_2 = false;
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, U3COnApplicationFocusU3Ed__4_MoveNext_m8E765B73A1FDF3C0707D50DC451596259629DB53_RuntimeMethod_var, methodExecutionContextThis, NULL, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 65121);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 65122);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 65123);
		int32_t L_0 = __this->get_U3CU3E1__state_0();
		V_0 = L_0;
		int32_t L_1 = V_0;
		if (!L_1)
		{
			goto IL_0012;
		}
	}
	{
		goto IL_000c;
	}

IL_000c:
	{
		int32_t L_2 = V_0;
		if ((((int32_t)L_2) == ((int32_t)1)))
		{
			goto IL_0014;
		}
	}
	{
		goto IL_0016;
	}

IL_0012:
	{
		goto IL_0018;
	}

IL_0014:
	{
		goto IL_0044;
	}

IL_0016:
	{
		return (bool)0;
	}

IL_0018:
	{
		__this->set_U3CU3E1__state_0((-1));
		CHECK_SEQ_POINT(methodExecutionContext, 65124);
		// if (Application.runInBackground) yield break;
		CHECK_SEQ_POINT(methodExecutionContext, 65125);
		STORE_SEQ_POINT(methodExecutionContext, 65140);
		bool L_3 = Application_get_runInBackground_m58DA93E02B92B98222A1F937265A1F6C13487D9B(/*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 65140);
		V_1 = L_3;
		CHECK_SEQ_POINT(methodExecutionContext, 65126);
		bool L_4 = V_1;
		if (!L_4)
		{
			goto IL_002b;
		}
	}
	{
		// if (Application.runInBackground) yield break;
		CHECK_SEQ_POINT(methodExecutionContext, 65127);
		return (bool)0;
	}

IL_002b:
	{
		// yield return new WaitForSeconds(0.01f);
		CHECK_SEQ_POINT(methodExecutionContext, 65128);
		STORE_SEQ_POINT(methodExecutionContext, 65141);
		WaitForSeconds_t3E9E78D3BB53F03F96C7F28BA9B9086CD1A5F4E8 * L_5 = (WaitForSeconds_t3E9E78D3BB53F03F96C7F28BA9B9086CD1A5F4E8 *)il2cpp_codegen_object_new(WaitForSeconds_t3E9E78D3BB53F03F96C7F28BA9B9086CD1A5F4E8_il2cpp_TypeInfo_var);
		WaitForSeconds__ctor_m8E4BA3E27AEFFE5B74A815F26FF8AAB99743F559(L_5, (0.01f), /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 65141);
		__this->set_U3CU3E2__current_1(L_5);
		__this->set_U3CU3E1__state_0(1);
		return (bool)1;
	}

IL_0044:
	{
		CHECK_SEQ_POINT(methodExecutionContext, 65129);
		__this->set_U3CU3E1__state_0((-1));
		// if (!hasFocus)
		CHECK_SEQ_POINT(methodExecutionContext, 65130);
		bool L_6 = __this->get_hasFocus_2();
		V_2 = (bool)((((int32_t)L_6) == ((int32_t)0))? 1 : 0);
		CHECK_SEQ_POINT(methodExecutionContext, 65131);
		bool L_7 = V_2;
		if (!L_7)
		{
			goto IL_007f;
		}
	}
	{
		CHECK_SEQ_POINT(methodExecutionContext, 65132);
		// Time.Default.timeScaleCached = Time.Default.timeScale;
		CHECK_SEQ_POINT(methodExecutionContext, 65133);
		IL2CPP_RUNTIME_CLASS_INIT(Time_t70920BA2C4C4BE707DAE9822ED553B006FFC0100_il2cpp_TypeInfo_var);
		Time_t70920BA2C4C4BE707DAE9822ED553B006FFC0100 * L_8 = ((Time_t70920BA2C4C4BE707DAE9822ED553B006FFC0100_StaticFields*)il2cpp_codegen_static_fields_for(Time_t70920BA2C4C4BE707DAE9822ED553B006FFC0100_il2cpp_TypeInfo_var))->get_Default_1();
		Time_t70920BA2C4C4BE707DAE9822ED553B006FFC0100 * L_9 = ((Time_t70920BA2C4C4BE707DAE9822ED553B006FFC0100_StaticFields*)il2cpp_codegen_static_fields_for(Time_t70920BA2C4C4BE707DAE9822ED553B006FFC0100_il2cpp_TypeInfo_var))->get_Default_1();
		NullCheck(L_9, il2cpp_codegen_get_sequence_point(65133));
		float L_10 = L_9->get_timeScale_2();
		NullCheck(L_8, il2cpp_codegen_get_sequence_point(65133));
		L_8->set_timeScaleCached_5(L_10);
		// Time.Default.timeScale = 0;
		CHECK_SEQ_POINT(methodExecutionContext, 65134);
		Time_t70920BA2C4C4BE707DAE9822ED553B006FFC0100 * L_11 = ((Time_t70920BA2C4C4BE707DAE9822ED553B006FFC0100_StaticFields*)il2cpp_codegen_static_fields_for(Time_t70920BA2C4C4BE707DAE9822ED553B006FFC0100_il2cpp_TypeInfo_var))->get_Default_1();
		NullCheck(L_11, il2cpp_codegen_get_sequence_point(65134));
		L_11->set_timeScale_2((0.0f));
		CHECK_SEQ_POINT(methodExecutionContext, 65135);
		goto IL_0095;
	}

IL_007f:
	{
		CHECK_SEQ_POINT(methodExecutionContext, 65136);
		// Time.Default.timeScale = Time.Default.timeScaleCached;
		CHECK_SEQ_POINT(methodExecutionContext, 65137);
		IL2CPP_RUNTIME_CLASS_INIT(Time_t70920BA2C4C4BE707DAE9822ED553B006FFC0100_il2cpp_TypeInfo_var);
		Time_t70920BA2C4C4BE707DAE9822ED553B006FFC0100 * L_12 = ((Time_t70920BA2C4C4BE707DAE9822ED553B006FFC0100_StaticFields*)il2cpp_codegen_static_fields_for(Time_t70920BA2C4C4BE707DAE9822ED553B006FFC0100_il2cpp_TypeInfo_var))->get_Default_1();
		Time_t70920BA2C4C4BE707DAE9822ED553B006FFC0100 * L_13 = ((Time_t70920BA2C4C4BE707DAE9822ED553B006FFC0100_StaticFields*)il2cpp_codegen_static_fields_for(Time_t70920BA2C4C4BE707DAE9822ED553B006FFC0100_il2cpp_TypeInfo_var))->get_Default_1();
		NullCheck(L_13, il2cpp_codegen_get_sequence_point(65137));
		float L_14 = L_13->get_timeScaleCached_5();
		NullCheck(L_12, il2cpp_codegen_get_sequence_point(65137));
		L_12->set_timeScale_2(L_14);
		CHECK_SEQ_POINT(methodExecutionContext, 65138);
	}

IL_0095:
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 65139);
		return (bool)0;
	}
}
// System.Object Pixeye.StarterKernel_<OnApplicationFocus>d__4::System.Collections.Generic.IEnumerator<System.Object>.get_Current()
extern "C" IL2CPP_METHOD_ATTR RuntimeObject * U3COnApplicationFocusU3Ed__4_System_Collections_Generic_IEnumeratorU3CSystem_ObjectU3E_get_Current_mC3A18BA641283ED49CEE80D8E2AF4FDE9F3EC49E (U3COnApplicationFocusU3Ed__4_t6A81BE9FFD6951A1410B57DFD8BCA01E3D3AF5E4 * __this, const RuntimeMethod* method)
{
	CHECK_PAUSE_POINT;
	{
		RuntimeObject * L_0 = __this->get_U3CU3E2__current_1();
		return L_0;
	}
}
// System.Void Pixeye.StarterKernel_<OnApplicationFocus>d__4::System.Collections.IEnumerator.Reset()
extern "C" IL2CPP_METHOD_ATTR void U3COnApplicationFocusU3Ed__4_System_Collections_IEnumerator_Reset_m790F4D8BB3789AC3E77BA2505D85C6326B6080AE (U3COnApplicationFocusU3Ed__4_t6A81BE9FFD6951A1410B57DFD8BCA01E3D3AF5E4 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (U3COnApplicationFocusU3Ed__4_System_Collections_IEnumerator_Reset_m790F4D8BB3789AC3E77BA2505D85C6326B6080AE_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	CHECK_PAUSE_POINT;
	{
		NotSupportedException_tE75B318D6590A02A5D9B29FD97409B1750FA0010 * L_0 = (NotSupportedException_tE75B318D6590A02A5D9B29FD97409B1750FA0010 *)il2cpp_codegen_object_new(NotSupportedException_tE75B318D6590A02A5D9B29FD97409B1750FA0010_il2cpp_TypeInfo_var);
		NotSupportedException__ctor_mA121DE1CAC8F25277DEB489DC7771209D91CAE33(L_0, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_0, NULL, U3COnApplicationFocusU3Ed__4_System_Collections_IEnumerator_Reset_m790F4D8BB3789AC3E77BA2505D85C6326B6080AE_RuntimeMethod_var);
	}
}
// System.Object Pixeye.StarterKernel_<OnApplicationFocus>d__4::System.Collections.IEnumerator.get_Current()
extern "C" IL2CPP_METHOD_ATTR RuntimeObject * U3COnApplicationFocusU3Ed__4_System_Collections_IEnumerator_get_Current_mA3EEF8F24C1F05FF2BA8B80E562FD2860CF148FF (U3COnApplicationFocusU3Ed__4_t6A81BE9FFD6951A1410B57DFD8BCA01E3D3AF5E4 * __this, const RuntimeMethod* method)
{
	CHECK_PAUSE_POINT;
	{
		RuntimeObject * L_0 = __this->get_U3CU3E2__current_1();
		return L_0;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Pixeye.Storage::.ctor()
extern "C" IL2CPP_METHOD_ATTR void Storage__ctor_m9998DAB8BBE9C9374000E2B007A4BC399BA5E8D6 (Storage_tDB77CB8CF4EE44D043E9BE9027A74B153B16E826 * __this, const RuntimeMethod* method)
{
	CHECK_PAUSE_POINT;
	{
		Object__ctor_m925ECA5E85CA100E3FB86A4F9E15C120E9A184C0(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void Pixeye.Storage::.cctor()
extern "C" IL2CPP_METHOD_ATTR void Storage__cctor_mF95C1369CFB2D38F18B33AE72E9EA6897D8642FD (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Storage__cctor_mF95C1369CFB2D38F18B33AE72E9EA6897D8642FD_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, Storage__cctor_mF95C1369CFB2D38F18B33AE72E9EA6897D8642FD_RuntimeMethod_var, NULL, NULL, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 63802);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 63803);
	{
		// internal static List<Storage> all = new List<Storage>(40);
		CHECK_SEQ_POINT(methodExecutionContext, 63804);
		STORE_SEQ_POINT(methodExecutionContext, 63806);
		List_1_t186D2009EAF545D4056FD040D409D10C57CE8F97 * L_0 = (List_1_t186D2009EAF545D4056FD040D409D10C57CE8F97 *)il2cpp_codegen_object_new(List_1_t186D2009EAF545D4056FD040D409D10C57CE8F97_il2cpp_TypeInfo_var);
		List_1__ctor_m596CC86831CDC5B16D847683293A5E3090036F2E(L_0, ((int32_t)40), /*hidden argument*/List_1__ctor_m596CC86831CDC5B16D847683293A5E3090036F2E_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 63806);
		((Storage_tDB77CB8CF4EE44D043E9BE9027A74B153B16E826_StaticFields*)il2cpp_codegen_static_fields_for(Storage_tDB77CB8CF4EE44D043E9BE9027A74B153B16E826_il2cpp_TypeInfo_var))->set_all_1(L_0);
		// internal static Dictionary<int, Storage> allDict = new Dictionary<int, Storage>(new FastComparable());
		CHECK_SEQ_POINT(methodExecutionContext, 63805);
		STORE_SEQ_POINT(methodExecutionContext, 63807);
		FastComparable_t85AACE6CEBE4B0D7FB16B2F3D09523B7BC4AA1A8 * L_1 = (FastComparable_t85AACE6CEBE4B0D7FB16B2F3D09523B7BC4AA1A8 *)il2cpp_codegen_object_new(FastComparable_t85AACE6CEBE4B0D7FB16B2F3D09523B7BC4AA1A8_il2cpp_TypeInfo_var);
		FastComparable__ctor_m3F034079FFB5E1F69208BF84CF6F3FFDF2084997(L_1, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 63807);
		STORE_SEQ_POINT(methodExecutionContext, 63808);
		Dictionary_2_t683E72069DD61C3D055254F6694A3E646C6B3622 * L_2 = (Dictionary_2_t683E72069DD61C3D055254F6694A3E646C6B3622 *)il2cpp_codegen_object_new(Dictionary_2_t683E72069DD61C3D055254F6694A3E646C6B3622_il2cpp_TypeInfo_var);
		Dictionary_2__ctor_mAFB74AF308004F87E52B2F21945C4FFDADF4F8AF(L_2, L_1, /*hidden argument*/Dictionary_2__ctor_mAFB74AF308004F87E52B2F21945C4FFDADF4F8AF_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 63808);
		((Storage_tDB77CB8CF4EE44D043E9BE9027A74B153B16E826_StaticFields*)il2cpp_codegen_static_fields_for(Storage_tDB77CB8CF4EE44D043E9BE9027A74B153B16E826_il2cpp_TypeInfo_var))->set_allDict_2(L_2);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Pixeye.StorageTags::Add(System.Int32)
extern "C" IL2CPP_METHOD_ATTR void StorageTags_Add_mE206DD042FF32DAD99D33C47EF92D132579CE703 (int32_t ___entityID0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (StorageTags_Add_mE206DD042FF32DAD99D33C47EF92D132579CE703_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	bool V_1 = false;
	int32_t V_2 = 0;
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___entityID0));
	DECLARE_METHOD_LOCALS(methodExecutionContextLocals, (&V_2));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, StorageTags_Add_mE206DD042FF32DAD99D33C47EF92D132579CE703_RuntimeMethod_var, NULL, methodExecutionContextParameters, methodExecutionContextLocals);
	CHECK_SEQ_POINT(methodExecutionContext, 64091);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 64092);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 64093);
		// if (length > entityID) return;
		CHECK_SEQ_POINT(methodExecutionContext, 64094);
		IL2CPP_RUNTIME_CLASS_INIT(StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_il2cpp_TypeInfo_var);
		int32_t L_0 = ((StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_StaticFields*)il2cpp_codegen_static_fields_for(StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_il2cpp_TypeInfo_var))->get_length_3();
		int32_t L_1 = ___entityID0;
		V_0 = (bool)((((int32_t)L_0) > ((int32_t)L_1))? 1 : 0);
		CHECK_SEQ_POINT(methodExecutionContext, 64095);
		bool L_2 = V_0;
		if (!L_2)
		{
			goto IL_000f;
		}
	}
	{
		// if (length > entityID) return;
		CHECK_SEQ_POINT(methodExecutionContext, 64096);
		goto IL_0050;
	}

IL_000f:
	{
		// if (entityID >= tags.Length)
		CHECK_SEQ_POINT(methodExecutionContext, 64097);
		int32_t L_3 = ___entityID0;
		IL2CPP_RUNTIME_CLASS_INIT(StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_il2cpp_TypeInfo_var);
		Dictionary_2U5BU5D_t5A34008586C648E4C1725CB098BCFE11124FEC7E* L_4 = ((StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_StaticFields*)il2cpp_codegen_static_fields_for(StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_il2cpp_TypeInfo_var))->get_tags_0();
		NullCheck(L_4, il2cpp_codegen_get_sequence_point(64097));
		V_1 = (bool)((((int32_t)((((int32_t)L_3) < ((int32_t)(((int32_t)((int32_t)(((RuntimeArray *)L_4)->max_length))))))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		CHECK_SEQ_POINT(methodExecutionContext, 64098);
		bool L_5 = V_1;
		if (!L_5)
		{
			goto IL_0032;
		}
	}
	{
		CHECK_SEQ_POINT(methodExecutionContext, 64099);
		// int l = entityID << 1;
		CHECK_SEQ_POINT(methodExecutionContext, 64100);
		int32_t L_6 = ___entityID0;
		V_2 = ((int32_t)((int32_t)L_6<<(int32_t)1));
		// Array.Resize(ref tags, l);
		CHECK_SEQ_POINT(methodExecutionContext, 64101);
		IL2CPP_RUNTIME_CLASS_INIT(StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_il2cpp_TypeInfo_var);
		int32_t L_7 = V_2;
		STORE_SEQ_POINT(methodExecutionContext, 64106);
		Array_Resize_TisDictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8_mD91BBCB688FE146E5FB901FDD5924A4C3D1D6742((Dictionary_2U5BU5D_t5A34008586C648E4C1725CB098BCFE11124FEC7E**)(((StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_StaticFields*)il2cpp_codegen_static_fields_for(StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_il2cpp_TypeInfo_var))->get_address_of_tags_0()), L_7, /*hidden argument*/Array_Resize_TisDictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8_mD91BBCB688FE146E5FB901FDD5924A4C3D1D6742_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64106);
		CHECK_SEQ_POINT(methodExecutionContext, 64102);
	}

IL_0032:
	{
		// length++;
		CHECK_SEQ_POINT(methodExecutionContext, 64103);
		IL2CPP_RUNTIME_CLASS_INIT(StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_il2cpp_TypeInfo_var);
		int32_t L_8 = ((StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_StaticFields*)il2cpp_codegen_static_fields_for(StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_il2cpp_TypeInfo_var))->get_length_3();
		((StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_StaticFields*)il2cpp_codegen_static_fields_for(StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_il2cpp_TypeInfo_var))->set_length_3(((int32_t)il2cpp_codegen_add((int32_t)L_8, (int32_t)1)));
		// tags[entityID] = new Dictionary<int, int>(4, new FastComparable());
		CHECK_SEQ_POINT(methodExecutionContext, 64104);
		Dictionary_2U5BU5D_t5A34008586C648E4C1725CB098BCFE11124FEC7E* L_9 = ((StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_StaticFields*)il2cpp_codegen_static_fields_for(StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_il2cpp_TypeInfo_var))->get_tags_0();
		int32_t L_10 = ___entityID0;
		STORE_SEQ_POINT(methodExecutionContext, 64107);
		FastComparable_t85AACE6CEBE4B0D7FB16B2F3D09523B7BC4AA1A8 * L_11 = (FastComparable_t85AACE6CEBE4B0D7FB16B2F3D09523B7BC4AA1A8 *)il2cpp_codegen_object_new(FastComparable_t85AACE6CEBE4B0D7FB16B2F3D09523B7BC4AA1A8_il2cpp_TypeInfo_var);
		FastComparable__ctor_m3F034079FFB5E1F69208BF84CF6F3FFDF2084997(L_11, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 64107);
		STORE_SEQ_POINT(methodExecutionContext, 64108);
		Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * L_12 = (Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 *)il2cpp_codegen_object_new(Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8_il2cpp_TypeInfo_var);
		Dictionary_2__ctor_m114B4A2B0BD22B817FE14C1E5CB04881D63D4E20(L_12, 4, L_11, /*hidden argument*/Dictionary_2__ctor_m114B4A2B0BD22B817FE14C1E5CB04881D63D4E20_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64108);
		NullCheck(L_9, il2cpp_codegen_get_sequence_point(64104));
		ArrayElementTypeCheck (L_9, L_12);
		(L_9)->SetAt(static_cast<il2cpp_array_size_t>(L_10), (Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 *)L_12);
	}

IL_0050:
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 64105);
		return;
	}
}
// System.Void Pixeye.StorageTags::Clear(System.Int32)
extern "C" IL2CPP_METHOD_ATTR void StorageTags_Clear_mE0CBF5CA09785CA919E3CD33BB3C9B1B47A9274C (int32_t ___id0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (StorageTags_Clear_mE0CBF5CA09785CA919E3CD33BB3C9B1B47A9274C_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___id0));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, StorageTags_Clear_mE0CBF5CA09785CA919E3CD33BB3C9B1B47A9274C_RuntimeMethod_var, NULL, methodExecutionContextParameters, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 64109);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 64110);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 64111);
		// tags[id].Clear();
		CHECK_SEQ_POINT(methodExecutionContext, 64112);
		IL2CPP_RUNTIME_CLASS_INIT(StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_il2cpp_TypeInfo_var);
		Dictionary_2U5BU5D_t5A34008586C648E4C1725CB098BCFE11124FEC7E* L_0 = ((StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_StaticFields*)il2cpp_codegen_static_fields_for(StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_il2cpp_TypeInfo_var))->get_tags_0();
		int32_t L_1 = ___id0;
		NullCheck(L_0, il2cpp_codegen_get_sequence_point(64112));
		int32_t L_2 = L_1;
		Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * L_3 = (Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 *)(L_0)->GetAt(static_cast<il2cpp_array_size_t>(L_2));
		STORE_SEQ_POINT(methodExecutionContext, 64114);
		NullCheck(L_3, il2cpp_codegen_get_sequence_point(64112));
		Dictionary_2_Clear_m7DE8E346650F09FFAB65ABCACFEBCB2FAB2F4499(L_3, /*hidden argument*/Dictionary_2_Clear_m7DE8E346650F09FFAB65ABCACFEBCB2FAB2F4499_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64114);
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 64113);
		return;
	}
}
// System.Void Pixeye.StorageTags::HandleChange(Pixeye.entU26,System.Int32)
extern "C" IL2CPP_METHOD_ATTR void StorageTags_HandleChange_m4BD1475868B1DBAA90A56C0F26FDD0471D120FA1 (ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * ___entity0, int32_t ___tag1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (StorageTags_HandleChange_m4BD1475868B1DBAA90A56C0F26FDD0471D120FA1_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	DelayTagEvent_tBFFD54C27E705D5B8CD1C5C49B4094A01A88BE02  V_0;
	memset(&V_0, 0, sizeof(V_0));
	bool V_1 = false;
	bool V_2 = false;
	int32_t V_3 = 0;
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___entity0), (&___tag1));
	DECLARE_METHOD_LOCALS(methodExecutionContextLocals, (&V_0), (&V_3));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, StorageTags_HandleChange_m4BD1475868B1DBAA90A56C0F26FDD0471D120FA1_RuntimeMethod_var, NULL, methodExecutionContextParameters, methodExecutionContextLocals);
	CHECK_SEQ_POINT(methodExecutionContext, 64115);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 64116);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 64117);
		// if (Toolbox.isQuittingOrChangingScene()) return;
		CHECK_SEQ_POINT(methodExecutionContext, 64118);
		STORE_SEQ_POINT(methodExecutionContext, 64131);
		IL2CPP_RUNTIME_CLASS_INIT(Singleton_1_t70D00C90A652BD47B1B663FC32A13A31E56C12C6_il2cpp_TypeInfo_var);
		bool L_0 = Singleton_1_isQuittingOrChangingScene_m4D5ABD228FA0FB2265D3D3BEEAD1FB0EFC43EDAF(/*hidden argument*/Singleton_1_isQuittingOrChangingScene_m4D5ABD228FA0FB2265D3D3BEEAD1FB0EFC43EDAF_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64131);
		V_1 = L_0;
		CHECK_SEQ_POINT(methodExecutionContext, 64119);
		bool L_1 = V_1;
		if (!L_1)
		{
			goto IL_000c;
		}
	}
	{
		// if (Toolbox.isQuittingOrChangingScene()) return;
		CHECK_SEQ_POINT(methodExecutionContext, 64120);
		goto IL_0069;
	}

IL_000c:
	{
		// dte.entity = entity;
		CHECK_SEQ_POINT(methodExecutionContext, 64121);
		ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * L_2 = ___entity0;
		STORE_SEQ_POINT(methodExecutionContext, 64132);
		int32_t L_3 = ent_op_Implicit_m16BC2A28ED2D8A104FC8CB8BF31A2CA6B2DD42CD((*(ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 *)L_2), /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 64132);
		(&V_0)->set_entity_0(L_3);
		// dte.tag = tag;
		CHECK_SEQ_POINT(methodExecutionContext, 64122);
		int32_t L_4 = ___tag1;
		(&V_0)->set_tag_1(L_4);
		// if (HandleActorsAdd.tagsToChange.Length <= HandleActorsAdd.lenTagsToChange)
		CHECK_SEQ_POINT(methodExecutionContext, 64123);
		IL2CPP_RUNTIME_CLASS_INIT(HandleActorsAdd_t8D5278068F1EACBBF9799D835738C552E5550F9E_il2cpp_TypeInfo_var);
		DelayTagEventU5BU5D_t7C4AB33A74B954415C9AF4B6E5D707E0CF3AA45F* L_5 = ((HandleActorsAdd_t8D5278068F1EACBBF9799D835738C552E5550F9E_StaticFields*)il2cpp_codegen_static_fields_for(HandleActorsAdd_t8D5278068F1EACBBF9799D835738C552E5550F9E_il2cpp_TypeInfo_var))->get_tagsToChange_1();
		NullCheck(L_5, il2cpp_codegen_get_sequence_point(64123));
		int32_t L_6 = ((HandleActorsAdd_t8D5278068F1EACBBF9799D835738C552E5550F9E_StaticFields*)il2cpp_codegen_static_fields_for(HandleActorsAdd_t8D5278068F1EACBBF9799D835738C552E5550F9E_il2cpp_TypeInfo_var))->get_lenTagsToChange_0();
		V_2 = (bool)((((int32_t)((((int32_t)(((int32_t)((int32_t)(((RuntimeArray *)L_5)->max_length))))) > ((int32_t)L_6))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		CHECK_SEQ_POINT(methodExecutionContext, 64124);
		bool L_7 = V_2;
		if (!L_7)
		{
			goto IL_0051;
		}
	}
	{
		CHECK_SEQ_POINT(methodExecutionContext, 64125);
		// int len = HandleActorsAdd.lenTagsToChange << 1;
		CHECK_SEQ_POINT(methodExecutionContext, 64126);
		IL2CPP_RUNTIME_CLASS_INIT(HandleActorsAdd_t8D5278068F1EACBBF9799D835738C552E5550F9E_il2cpp_TypeInfo_var);
		int32_t L_8 = ((HandleActorsAdd_t8D5278068F1EACBBF9799D835738C552E5550F9E_StaticFields*)il2cpp_codegen_static_fields_for(HandleActorsAdd_t8D5278068F1EACBBF9799D835738C552E5550F9E_il2cpp_TypeInfo_var))->get_lenTagsToChange_0();
		V_3 = ((int32_t)((int32_t)L_8<<(int32_t)1));
		// Array.Resize(ref HandleActorsAdd.tagsToChange, len);
		CHECK_SEQ_POINT(methodExecutionContext, 64127);
		int32_t L_9 = V_3;
		STORE_SEQ_POINT(methodExecutionContext, 64133);
		Array_Resize_TisDelayTagEvent_tBFFD54C27E705D5B8CD1C5C49B4094A01A88BE02_mCF48F79088FD98AB2563B66CE05477C477974B0B((DelayTagEventU5BU5D_t7C4AB33A74B954415C9AF4B6E5D707E0CF3AA45F**)(((HandleActorsAdd_t8D5278068F1EACBBF9799D835738C552E5550F9E_StaticFields*)il2cpp_codegen_static_fields_for(HandleActorsAdd_t8D5278068F1EACBBF9799D835738C552E5550F9E_il2cpp_TypeInfo_var))->get_address_of_tagsToChange_1()), L_9, /*hidden argument*/Array_Resize_TisDelayTagEvent_tBFFD54C27E705D5B8CD1C5C49B4094A01A88BE02_mCF48F79088FD98AB2563B66CE05477C477974B0B_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64133);
		CHECK_SEQ_POINT(methodExecutionContext, 64128);
	}

IL_0051:
	{
		// HandleActorsAdd.tagsToChange[HandleActorsAdd.lenTagsToChange++] = dte;
		CHECK_SEQ_POINT(methodExecutionContext, 64129);
		IL2CPP_RUNTIME_CLASS_INIT(HandleActorsAdd_t8D5278068F1EACBBF9799D835738C552E5550F9E_il2cpp_TypeInfo_var);
		DelayTagEventU5BU5D_t7C4AB33A74B954415C9AF4B6E5D707E0CF3AA45F* L_10 = ((HandleActorsAdd_t8D5278068F1EACBBF9799D835738C552E5550F9E_StaticFields*)il2cpp_codegen_static_fields_for(HandleActorsAdd_t8D5278068F1EACBBF9799D835738C552E5550F9E_il2cpp_TypeInfo_var))->get_tagsToChange_1();
		int32_t L_11 = ((HandleActorsAdd_t8D5278068F1EACBBF9799D835738C552E5550F9E_StaticFields*)il2cpp_codegen_static_fields_for(HandleActorsAdd_t8D5278068F1EACBBF9799D835738C552E5550F9E_il2cpp_TypeInfo_var))->get_lenTagsToChange_0();
		int32_t L_12 = L_11;
		((HandleActorsAdd_t8D5278068F1EACBBF9799D835738C552E5550F9E_StaticFields*)il2cpp_codegen_static_fields_for(HandleActorsAdd_t8D5278068F1EACBBF9799D835738C552E5550F9E_il2cpp_TypeInfo_var))->set_lenTagsToChange_0(((int32_t)il2cpp_codegen_add((int32_t)L_12, (int32_t)1)));
		DelayTagEvent_tBFFD54C27E705D5B8CD1C5C49B4094A01A88BE02  L_13 = V_0;
		NullCheck(L_10, il2cpp_codegen_get_sequence_point(64129));
		(L_10)->SetAt(static_cast<il2cpp_array_size_t>(L_12), (DelayTagEvent_tBFFD54C27E705D5B8CD1C5C49B4094A01A88BE02 )L_13);
	}

IL_0069:
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 64130);
		return;
	}
}
// System.Void Pixeye.StorageTags::Remove(Pixeye.entU26,System.Int32)
extern "C" IL2CPP_METHOD_ATTR void StorageTags_Remove_m874D77B822456F77BA6B8E7932479A3E318F9325 (ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * ___entityID0, int32_t ___tagID1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (StorageTags_Remove_m874D77B822456F77BA6B8E7932479A3E318F9325_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * V_0 = NULL;
	int32_t V_1 = 0;
	bool V_2 = false;
	bool V_3 = false;
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___entityID0), (&___tagID1));
	DECLARE_METHOD_LOCALS(methodExecutionContextLocals, (&V_0), (&V_1));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, StorageTags_Remove_m874D77B822456F77BA6B8E7932479A3E318F9325_RuntimeMethod_var, NULL, methodExecutionContextParameters, methodExecutionContextLocals);
	CHECK_SEQ_POINT(methodExecutionContext, 64134);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 64135);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 64136);
		// var dict = tags[entityID];
		CHECK_SEQ_POINT(methodExecutionContext, 64137);
		IL2CPP_RUNTIME_CLASS_INIT(StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_il2cpp_TypeInfo_var);
		Dictionary_2U5BU5D_t5A34008586C648E4C1725CB098BCFE11124FEC7E* L_0 = ((StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_StaticFields*)il2cpp_codegen_static_fields_for(StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_il2cpp_TypeInfo_var))->get_tags_0();
		ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * L_1 = ___entityID0;
		STORE_SEQ_POINT(methodExecutionContext, 64150);
		int32_t L_2 = ent_op_Implicit_m16BC2A28ED2D8A104FC8CB8BF31A2CA6B2DD42CD((*(ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 *)L_1), /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 64150);
		NullCheck(L_0, il2cpp_codegen_get_sequence_point(64137));
		int32_t L_3 = L_2;
		Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * L_4 = (Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 *)(L_0)->GetAt(static_cast<il2cpp_array_size_t>(L_3));
		V_0 = L_4;
		// if (!dict.TryGetValue(tagID, out val)) return;
		CHECK_SEQ_POINT(methodExecutionContext, 64138);
		Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * L_5 = V_0;
		int32_t L_6 = ___tagID1;
		STORE_SEQ_POINT(methodExecutionContext, 64151);
		NullCheck(L_5, il2cpp_codegen_get_sequence_point(64138));
		bool L_7 = Dictionary_2_TryGetValue_mF63B7CEA87637EBDF9463BD38E61F29EB10148CC(L_5, L_6, (int32_t*)(&V_1), /*hidden argument*/Dictionary_2_TryGetValue_mF63B7CEA87637EBDF9463BD38E61F29EB10148CC_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64151);
		V_2 = (bool)((((int32_t)L_7) == ((int32_t)0))? 1 : 0);
		CHECK_SEQ_POINT(methodExecutionContext, 64139);
		bool L_8 = V_2;
		if (!L_8)
		{
			goto IL_0025;
		}
	}
	{
		// if (!dict.TryGetValue(tagID, out val)) return;
		CHECK_SEQ_POINT(methodExecutionContext, 64140);
		goto IL_0054;
	}

IL_0025:
	{
		// val = Math.Max(0, val - 1);
		CHECK_SEQ_POINT(methodExecutionContext, 64141);
		int32_t L_9 = V_1;
		STORE_SEQ_POINT(methodExecutionContext, 64152);
		IL2CPP_RUNTIME_CLASS_INIT(Math_tFB388E53C7FDC6FCCF9A19ABF5A4E521FBD52E19_il2cpp_TypeInfo_var);
		int32_t L_10 = Math_Max_mA99E48BB021F2E4B62D4EA9F52EA6928EED618A2(0, ((int32_t)il2cpp_codegen_subtract((int32_t)L_9, (int32_t)1)), /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 64152);
		V_1 = L_10;
		// if (val == 0)
		CHECK_SEQ_POINT(methodExecutionContext, 64142);
		int32_t L_11 = V_1;
		V_3 = (bool)((((int32_t)L_11) == ((int32_t)0))? 1 : 0);
		CHECK_SEQ_POINT(methodExecutionContext, 64143);
		bool L_12 = V_3;
		if (!L_12)
		{
			goto IL_004b;
		}
	}
	{
		CHECK_SEQ_POINT(methodExecutionContext, 64144);
		// dict.Remove(tagID);
		CHECK_SEQ_POINT(methodExecutionContext, 64145);
		Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * L_13 = V_0;
		int32_t L_14 = ___tagID1;
		STORE_SEQ_POINT(methodExecutionContext, 64153);
		NullCheck(L_13, il2cpp_codegen_get_sequence_point(64145));
		Dictionary_2_Remove_m8E04EF60FB32880A72708207DB1CC4555C2E476F(L_13, L_14, /*hidden argument*/Dictionary_2_Remove_m8E04EF60FB32880A72708207DB1CC4555C2E476F_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64153);
		// HandleChange(entityID, tagID);
		CHECK_SEQ_POINT(methodExecutionContext, 64146);
		ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * L_15 = ___entityID0;
		int32_t L_16 = ___tagID1;
		STORE_SEQ_POINT(methodExecutionContext, 64154);
		IL2CPP_RUNTIME_CLASS_INIT(StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_il2cpp_TypeInfo_var);
		StorageTags_HandleChange_m4BD1475868B1DBAA90A56C0F26FDD0471D120FA1((ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 *)L_15, L_16, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 64154);
		CHECK_SEQ_POINT(methodExecutionContext, 64147);
		goto IL_0054;
	}

IL_004b:
	{
		// else dict[tagID] = val;
		CHECK_SEQ_POINT(methodExecutionContext, 64148);
		Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * L_17 = V_0;
		int32_t L_18 = ___tagID1;
		int32_t L_19 = V_1;
		STORE_SEQ_POINT(methodExecutionContext, 64155);
		NullCheck(L_17, il2cpp_codegen_get_sequence_point(64148));
		Dictionary_2_set_Item_mEA07C9AE7BBAF67BC9CFE20D200A464725D1F7FA(L_17, L_18, L_19, /*hidden argument*/Dictionary_2_set_Item_mEA07C9AE7BBAF67BC9CFE20D200A464725D1F7FA_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64155);
	}

IL_0054:
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 64149);
		return;
	}
}
// System.Void Pixeye.StorageTags::Remove(Pixeye.entU26,System.Int32[])
extern "C" IL2CPP_METHOD_ATTR void StorageTags_Remove_mCBF0DBADE40449247AEF16EC26133DA5C4086403 (ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * ___entityID0, Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* ___tagIds1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (StorageTags_Remove_mCBF0DBADE40449247AEF16EC26133DA5C4086403_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * V_0 = NULL;
	Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* V_1 = NULL;
	int32_t V_2 = 0;
	int32_t V_3 = 0;
	int32_t V_4 = 0;
	bool V_5 = false;
	bool V_6 = false;
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___entityID0), (&___tagIds1));
	DECLARE_METHOD_LOCALS(methodExecutionContextLocals, (&V_0), (&V_3), (&V_4));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, StorageTags_Remove_mCBF0DBADE40449247AEF16EC26133DA5C4086403_RuntimeMethod_var, NULL, methodExecutionContextParameters, methodExecutionContextLocals);
	CHECK_SEQ_POINT(methodExecutionContext, 64156);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 64157);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 64158);
		// var dict = tags[entityID];
		CHECK_SEQ_POINT(methodExecutionContext, 64159);
		IL2CPP_RUNTIME_CLASS_INIT(StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_il2cpp_TypeInfo_var);
		Dictionary_2U5BU5D_t5A34008586C648E4C1725CB098BCFE11124FEC7E* L_0 = ((StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_StaticFields*)il2cpp_codegen_static_fields_for(StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_il2cpp_TypeInfo_var))->get_tags_0();
		ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * L_1 = ___entityID0;
		STORE_SEQ_POINT(methodExecutionContext, 64180);
		int32_t L_2 = ent_op_Implicit_m16BC2A28ED2D8A104FC8CB8BF31A2CA6B2DD42CD((*(ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 *)L_1), /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 64180);
		NullCheck(L_0, il2cpp_codegen_get_sequence_point(64159));
		int32_t L_3 = L_2;
		Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * L_4 = (Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 *)(L_0)->GetAt(static_cast<il2cpp_array_size_t>(L_3));
		V_0 = L_4;
		CHECK_SEQ_POINT(methodExecutionContext, 64160);
		// foreach (int index in tagIds)
		CHECK_SEQ_POINT(methodExecutionContext, 64161);
		Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* L_5 = ___tagIds1;
		V_1 = L_5;
		V_2 = 0;
		CHECK_SEQ_POINT(methodExecutionContext, 64162);
		goto IL_006d;
	}

IL_001a:
	{
		// foreach (int index in tagIds)
		CHECK_SEQ_POINT(methodExecutionContext, 64163);
		Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* L_6 = V_1;
		int32_t L_7 = V_2;
		NullCheck(L_6, il2cpp_codegen_get_sequence_point(64163));
		int32_t L_8 = L_7;
		int32_t L_9 = (L_6)->GetAt(static_cast<il2cpp_array_size_t>(L_8));
		V_3 = L_9;
		CHECK_SEQ_POINT(methodExecutionContext, 64164);
		// if (!dict.TryGetValue(index, out val)) continue;
		CHECK_SEQ_POINT(methodExecutionContext, 64165);
		Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * L_10 = V_0;
		int32_t L_11 = V_3;
		STORE_SEQ_POINT(methodExecutionContext, 64181);
		NullCheck(L_10, il2cpp_codegen_get_sequence_point(64165));
		bool L_12 = Dictionary_2_TryGetValue_mF63B7CEA87637EBDF9463BD38E61F29EB10148CC(L_10, L_11, (int32_t*)(&V_4), /*hidden argument*/Dictionary_2_TryGetValue_mF63B7CEA87637EBDF9463BD38E61F29EB10148CC_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64181);
		V_5 = (bool)((((int32_t)L_12) == ((int32_t)0))? 1 : 0);
		CHECK_SEQ_POINT(methodExecutionContext, 64166);
		bool L_13 = V_5;
		if (!L_13)
		{
			goto IL_0033;
		}
	}
	{
		// if (!dict.TryGetValue(index, out val)) continue;
		CHECK_SEQ_POINT(methodExecutionContext, 64167);
		goto IL_0069;
	}

IL_0033:
	{
		// val = Math.Max(0, val - 1);
		CHECK_SEQ_POINT(methodExecutionContext, 64168);
		int32_t L_14 = V_4;
		STORE_SEQ_POINT(methodExecutionContext, 64182);
		IL2CPP_RUNTIME_CLASS_INIT(Math_tFB388E53C7FDC6FCCF9A19ABF5A4E521FBD52E19_il2cpp_TypeInfo_var);
		int32_t L_15 = Math_Max_mA99E48BB021F2E4B62D4EA9F52EA6928EED618A2(0, ((int32_t)il2cpp_codegen_subtract((int32_t)L_14, (int32_t)1)), /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 64182);
		V_4 = L_15;
		// if (val == 0)
		CHECK_SEQ_POINT(methodExecutionContext, 64169);
		int32_t L_16 = V_4;
		V_6 = (bool)((((int32_t)L_16) == ((int32_t)0))? 1 : 0);
		CHECK_SEQ_POINT(methodExecutionContext, 64170);
		bool L_17 = V_6;
		if (!L_17)
		{
			goto IL_005e;
		}
	}
	{
		CHECK_SEQ_POINT(methodExecutionContext, 64171);
		// dict.Remove(index);
		CHECK_SEQ_POINT(methodExecutionContext, 64172);
		Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * L_18 = V_0;
		int32_t L_19 = V_3;
		STORE_SEQ_POINT(methodExecutionContext, 64183);
		NullCheck(L_18, il2cpp_codegen_get_sequence_point(64172));
		Dictionary_2_Remove_m8E04EF60FB32880A72708207DB1CC4555C2E476F(L_18, L_19, /*hidden argument*/Dictionary_2_Remove_m8E04EF60FB32880A72708207DB1CC4555C2E476F_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64183);
		// HandleChange(entityID, index);
		CHECK_SEQ_POINT(methodExecutionContext, 64173);
		ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * L_20 = ___entityID0;
		int32_t L_21 = V_3;
		STORE_SEQ_POINT(methodExecutionContext, 64184);
		IL2CPP_RUNTIME_CLASS_INIT(StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_il2cpp_TypeInfo_var);
		StorageTags_HandleChange_m4BD1475868B1DBAA90A56C0F26FDD0471D120FA1((ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 *)L_20, L_21, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 64184);
		CHECK_SEQ_POINT(methodExecutionContext, 64174);
		goto IL_0068;
	}

IL_005e:
	{
		// else dict[index] = val;
		CHECK_SEQ_POINT(methodExecutionContext, 64175);
		Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * L_22 = V_0;
		int32_t L_23 = V_3;
		int32_t L_24 = V_4;
		STORE_SEQ_POINT(methodExecutionContext, 64185);
		NullCheck(L_22, il2cpp_codegen_get_sequence_point(64175));
		Dictionary_2_set_Item_mEA07C9AE7BBAF67BC9CFE20D200A464725D1F7FA(L_22, L_23, L_24, /*hidden argument*/Dictionary_2_set_Item_mEA07C9AE7BBAF67BC9CFE20D200A464725D1F7FA_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64185);
	}

IL_0068:
	{
		CHECK_SEQ_POINT(methodExecutionContext, 64176);
	}

IL_0069:
	{
		CHECK_SEQ_POINT(methodExecutionContext, 64177);
		int32_t L_25 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add((int32_t)L_25, (int32_t)1));
	}

IL_006d:
	{
		// foreach (int index in tagIds)
		CHECK_SEQ_POINT(methodExecutionContext, 64178);
		int32_t L_26 = V_2;
		Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* L_27 = V_1;
		NullCheck(L_27, il2cpp_codegen_get_sequence_point(64178));
		if ((((int32_t)L_26) < ((int32_t)(((int32_t)((int32_t)(((RuntimeArray *)L_27)->max_length)))))))
		{
			goto IL_001a;
		}
	}
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 64179);
		return;
	}
}
// System.Void Pixeye.StorageTags::RemoveAll(Pixeye.entU26,System.Int32[])
extern "C" IL2CPP_METHOD_ATTR void StorageTags_RemoveAll_m68B8B18E9B75F5575C4723491321180D335FBC79 (ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * ___entityID0, Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* ___tagIds1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (StorageTags_RemoveAll_m68B8B18E9B75F5575C4723491321180D335FBC79_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * V_0 = NULL;
	Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* V_1 = NULL;
	int32_t V_2 = 0;
	int32_t V_3 = 0;
	bool V_4 = false;
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___entityID0), (&___tagIds1));
	DECLARE_METHOD_LOCALS(methodExecutionContextLocals, (&V_0), (&V_3));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, StorageTags_RemoveAll_m68B8B18E9B75F5575C4723491321180D335FBC79_RuntimeMethod_var, NULL, methodExecutionContextParameters, methodExecutionContextLocals);
	CHECK_SEQ_POINT(methodExecutionContext, 64186);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 64187);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 64188);
		// var dict = tags[entityID];
		CHECK_SEQ_POINT(methodExecutionContext, 64189);
		IL2CPP_RUNTIME_CLASS_INIT(StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_il2cpp_TypeInfo_var);
		Dictionary_2U5BU5D_t5A34008586C648E4C1725CB098BCFE11124FEC7E* L_0 = ((StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_StaticFields*)il2cpp_codegen_static_fields_for(StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_il2cpp_TypeInfo_var))->get_tags_0();
		ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * L_1 = ___entityID0;
		STORE_SEQ_POINT(methodExecutionContext, 64204);
		int32_t L_2 = ent_op_Implicit_m16BC2A28ED2D8A104FC8CB8BF31A2CA6B2DD42CD((*(ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 *)L_1), /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 64204);
		NullCheck(L_0, il2cpp_codegen_get_sequence_point(64189));
		int32_t L_3 = L_2;
		Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * L_4 = (Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 *)(L_0)->GetAt(static_cast<il2cpp_array_size_t>(L_3));
		V_0 = L_4;
		CHECK_SEQ_POINT(methodExecutionContext, 64190);
		// foreach (int index in tagIds)
		CHECK_SEQ_POINT(methodExecutionContext, 64191);
		Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* L_5 = ___tagIds1;
		V_1 = L_5;
		V_2 = 0;
		CHECK_SEQ_POINT(methodExecutionContext, 64192);
		goto IL_0046;
	}

IL_001a:
	{
		// foreach (int index in tagIds)
		CHECK_SEQ_POINT(methodExecutionContext, 64193);
		Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* L_6 = V_1;
		int32_t L_7 = V_2;
		NullCheck(L_6, il2cpp_codegen_get_sequence_point(64193));
		int32_t L_8 = L_7;
		int32_t L_9 = (L_6)->GetAt(static_cast<il2cpp_array_size_t>(L_8));
		V_3 = L_9;
		CHECK_SEQ_POINT(methodExecutionContext, 64194);
		// if (!dict.ContainsKey(index)) continue;
		CHECK_SEQ_POINT(methodExecutionContext, 64195);
		Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * L_10 = V_0;
		int32_t L_11 = V_3;
		STORE_SEQ_POINT(methodExecutionContext, 64205);
		NullCheck(L_10, il2cpp_codegen_get_sequence_point(64195));
		bool L_12 = Dictionary_2_ContainsKey_mBC44DAB119CBE7A4B7820ABF12AD024A4654471E(L_10, L_11, /*hidden argument*/Dictionary_2_ContainsKey_mBC44DAB119CBE7A4B7820ABF12AD024A4654471E_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64205);
		V_4 = (bool)((((int32_t)L_12) == ((int32_t)0))? 1 : 0);
		CHECK_SEQ_POINT(methodExecutionContext, 64196);
		bool L_13 = V_4;
		if (!L_13)
		{
			goto IL_0031;
		}
	}
	{
		// if (!dict.ContainsKey(index)) continue;
		CHECK_SEQ_POINT(methodExecutionContext, 64197);
		goto IL_0042;
	}

IL_0031:
	{
		// dict.Remove(index);
		CHECK_SEQ_POINT(methodExecutionContext, 64198);
		Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * L_14 = V_0;
		int32_t L_15 = V_3;
		STORE_SEQ_POINT(methodExecutionContext, 64206);
		NullCheck(L_14, il2cpp_codegen_get_sequence_point(64198));
		Dictionary_2_Remove_m8E04EF60FB32880A72708207DB1CC4555C2E476F(L_14, L_15, /*hidden argument*/Dictionary_2_Remove_m8E04EF60FB32880A72708207DB1CC4555C2E476F_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64206);
		// HandleChange(entityID, index);
		CHECK_SEQ_POINT(methodExecutionContext, 64199);
		ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * L_16 = ___entityID0;
		int32_t L_17 = V_3;
		STORE_SEQ_POINT(methodExecutionContext, 64207);
		IL2CPP_RUNTIME_CLASS_INIT(StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_il2cpp_TypeInfo_var);
		StorageTags_HandleChange_m4BD1475868B1DBAA90A56C0F26FDD0471D120FA1((ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 *)L_16, L_17, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 64207);
		CHECK_SEQ_POINT(methodExecutionContext, 64200);
	}

IL_0042:
	{
		CHECK_SEQ_POINT(methodExecutionContext, 64201);
		int32_t L_18 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add((int32_t)L_18, (int32_t)1));
	}

IL_0046:
	{
		// foreach (int index in tagIds)
		CHECK_SEQ_POINT(methodExecutionContext, 64202);
		int32_t L_19 = V_2;
		Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* L_20 = V_1;
		NullCheck(L_20, il2cpp_codegen_get_sequence_point(64202));
		if ((((int32_t)L_19) < ((int32_t)(((int32_t)((int32_t)(((RuntimeArray *)L_20)->max_length)))))))
		{
			goto IL_001a;
		}
	}
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 64203);
		return;
	}
}
// System.Void Pixeye.StorageTags::Add(Pixeye.entU26,System.Int32)
extern "C" IL2CPP_METHOD_ATTR void StorageTags_Add_mCD78809357CD1F06D61F3EDAC34F5F57EE21A09A (ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * ___entity0, int32_t ___tagId1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (StorageTags_Add_mCD78809357CD1F06D61F3EDAC34F5F57EE21A09A_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * V_0 = NULL;
	bool V_1 = false;
	Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * V_2 = NULL;
	int32_t V_3 = 0;
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___entity0), (&___tagId1));
	DECLARE_METHOD_LOCALS(methodExecutionContextLocals, (&V_0));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, StorageTags_Add_mCD78809357CD1F06D61F3EDAC34F5F57EE21A09A_RuntimeMethod_var, NULL, methodExecutionContextParameters, methodExecutionContextLocals);
	CHECK_SEQ_POINT(methodExecutionContext, 64208);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 64209);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 64210);
		// var dict = tags[entity];
		CHECK_SEQ_POINT(methodExecutionContext, 64211);
		IL2CPP_RUNTIME_CLASS_INIT(StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_il2cpp_TypeInfo_var);
		Dictionary_2U5BU5D_t5A34008586C648E4C1725CB098BCFE11124FEC7E* L_0 = ((StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_StaticFields*)il2cpp_codegen_static_fields_for(StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_il2cpp_TypeInfo_var))->get_tags_0();
		ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * L_1 = ___entity0;
		STORE_SEQ_POINT(methodExecutionContext, 64220);
		int32_t L_2 = ent_op_Implicit_m16BC2A28ED2D8A104FC8CB8BF31A2CA6B2DD42CD((*(ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 *)L_1), /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 64220);
		NullCheck(L_0, il2cpp_codegen_get_sequence_point(64211));
		int32_t L_3 = L_2;
		Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * L_4 = (Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 *)(L_0)->GetAt(static_cast<il2cpp_array_size_t>(L_3));
		V_0 = L_4;
		// if (dict.ContainsKey(tagId))
		CHECK_SEQ_POINT(methodExecutionContext, 64212);
		Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * L_5 = V_0;
		int32_t L_6 = ___tagId1;
		STORE_SEQ_POINT(methodExecutionContext, 64221);
		NullCheck(L_5, il2cpp_codegen_get_sequence_point(64212));
		bool L_7 = Dictionary_2_ContainsKey_mBC44DAB119CBE7A4B7820ABF12AD024A4654471E(L_5, L_6, /*hidden argument*/Dictionary_2_ContainsKey_mBC44DAB119CBE7A4B7820ABF12AD024A4654471E_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64221);
		V_1 = L_7;
		CHECK_SEQ_POINT(methodExecutionContext, 64213);
		bool L_8 = V_1;
		if (!L_8)
		{
			goto IL_0036;
		}
	}
	{
		CHECK_SEQ_POINT(methodExecutionContext, 64214);
		// dict[tagId] += 1;
		CHECK_SEQ_POINT(methodExecutionContext, 64215);
		Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * L_9 = V_0;
		V_2 = L_9;
		int32_t L_10 = ___tagId1;
		V_3 = L_10;
		Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * L_11 = V_2;
		int32_t L_12 = V_3;
		Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * L_13 = V_2;
		int32_t L_14 = V_3;
		STORE_SEQ_POINT(methodExecutionContext, 64222);
		NullCheck(L_13, il2cpp_codegen_get_sequence_point(64215));
		int32_t L_15 = Dictionary_2_get_Item_mFB950EA5BD4A89CD6EAA8D0CB45D665091FAA7E1(L_13, L_14, /*hidden argument*/Dictionary_2_get_Item_mFB950EA5BD4A89CD6EAA8D0CB45D665091FAA7E1_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64222);
		STORE_SEQ_POINT(methodExecutionContext, 64223);
		NullCheck(L_11, il2cpp_codegen_get_sequence_point(64215));
		Dictionary_2_set_Item_mEA07C9AE7BBAF67BC9CFE20D200A464725D1F7FA(L_11, L_12, ((int32_t)il2cpp_codegen_add((int32_t)L_15, (int32_t)1)), /*hidden argument*/Dictionary_2_set_Item_mEA07C9AE7BBAF67BC9CFE20D200A464725D1F7FA_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64223);
		// return;
		CHECK_SEQ_POINT(methodExecutionContext, 64216);
		goto IL_0047;
	}

IL_0036:
	{
		// dict.Add(tagId, 1);
		CHECK_SEQ_POINT(methodExecutionContext, 64217);
		Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * L_16 = V_0;
		int32_t L_17 = ___tagId1;
		STORE_SEQ_POINT(methodExecutionContext, 64224);
		NullCheck(L_16, il2cpp_codegen_get_sequence_point(64217));
		Dictionary_2_Add_mDC25A2F4744B497C39F127D97327CC7B56E68903(L_16, L_17, 1, /*hidden argument*/Dictionary_2_Add_mDC25A2F4744B497C39F127D97327CC7B56E68903_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64224);
		// HandleChange(entity, tagId);
		CHECK_SEQ_POINT(methodExecutionContext, 64218);
		ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * L_18 = ___entity0;
		int32_t L_19 = ___tagId1;
		STORE_SEQ_POINT(methodExecutionContext, 64225);
		IL2CPP_RUNTIME_CLASS_INIT(StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_il2cpp_TypeInfo_var);
		StorageTags_HandleChange_m4BD1475868B1DBAA90A56C0F26FDD0471D120FA1((ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 *)L_18, L_19, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 64225);
	}

IL_0047:
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 64219);
		return;
	}
}
// System.Void Pixeye.StorageTags::Add(Pixeye.entU26,System.Int32[])
extern "C" IL2CPP_METHOD_ATTR void StorageTags_Add_m2EDFBB0C3DA3265F46F93686EC416118D7B7DA9B (ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * ___entity0, Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* ___tagIds1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (StorageTags_Add_m2EDFBB0C3DA3265F46F93686EC416118D7B7DA9B_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * V_0 = NULL;
	Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* V_1 = NULL;
	int32_t V_2 = 0;
	int32_t V_3 = 0;
	bool V_4 = false;
	Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * V_5 = NULL;
	int32_t V_6 = 0;
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___entity0), (&___tagIds1));
	DECLARE_METHOD_LOCALS(methodExecutionContextLocals, (&V_0), (&V_3));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, StorageTags_Add_m2EDFBB0C3DA3265F46F93686EC416118D7B7DA9B_RuntimeMethod_var, NULL, methodExecutionContextParameters, methodExecutionContextLocals);
	CHECK_SEQ_POINT(methodExecutionContext, 64226);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 64227);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 64228);
		// var dict = tags[entity];
		CHECK_SEQ_POINT(methodExecutionContext, 64229);
		IL2CPP_RUNTIME_CLASS_INIT(StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_il2cpp_TypeInfo_var);
		Dictionary_2U5BU5D_t5A34008586C648E4C1725CB098BCFE11124FEC7E* L_0 = ((StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_StaticFields*)il2cpp_codegen_static_fields_for(StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_il2cpp_TypeInfo_var))->get_tags_0();
		ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * L_1 = ___entity0;
		STORE_SEQ_POINT(methodExecutionContext, 64246);
		int32_t L_2 = ent_op_Implicit_m16BC2A28ED2D8A104FC8CB8BF31A2CA6B2DD42CD((*(ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 *)L_1), /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 64246);
		NullCheck(L_0, il2cpp_codegen_get_sequence_point(64229));
		int32_t L_3 = L_2;
		Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * L_4 = (Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 *)(L_0)->GetAt(static_cast<il2cpp_array_size_t>(L_3));
		V_0 = L_4;
		CHECK_SEQ_POINT(methodExecutionContext, 64230);
		// foreach (int index in tagIds)
		CHECK_SEQ_POINT(methodExecutionContext, 64231);
		Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* L_5 = ___tagIds1;
		V_1 = L_5;
		V_2 = 0;
		CHECK_SEQ_POINT(methodExecutionContext, 64232);
		goto IL_0060;
	}

IL_001a:
	{
		// foreach (int index in tagIds)
		CHECK_SEQ_POINT(methodExecutionContext, 64233);
		Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* L_6 = V_1;
		int32_t L_7 = V_2;
		NullCheck(L_6, il2cpp_codegen_get_sequence_point(64233));
		int32_t L_8 = L_7;
		int32_t L_9 = (L_6)->GetAt(static_cast<il2cpp_array_size_t>(L_8));
		V_3 = L_9;
		CHECK_SEQ_POINT(methodExecutionContext, 64234);
		// if (dict.ContainsKey(index))
		CHECK_SEQ_POINT(methodExecutionContext, 64235);
		Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * L_10 = V_0;
		int32_t L_11 = V_3;
		STORE_SEQ_POINT(methodExecutionContext, 64247);
		NullCheck(L_10, il2cpp_codegen_get_sequence_point(64235));
		bool L_12 = Dictionary_2_ContainsKey_mBC44DAB119CBE7A4B7820ABF12AD024A4654471E(L_10, L_11, /*hidden argument*/Dictionary_2_ContainsKey_mBC44DAB119CBE7A4B7820ABF12AD024A4654471E_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64247);
		V_4 = L_12;
		CHECK_SEQ_POINT(methodExecutionContext, 64236);
		bool L_13 = V_4;
		if (!L_13)
		{
			goto IL_004a;
		}
	}
	{
		CHECK_SEQ_POINT(methodExecutionContext, 64237);
		// dict[index] += 1;
		CHECK_SEQ_POINT(methodExecutionContext, 64238);
		Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * L_14 = V_0;
		V_5 = L_14;
		int32_t L_15 = V_3;
		V_6 = L_15;
		Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * L_16 = V_5;
		int32_t L_17 = V_6;
		Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * L_18 = V_5;
		int32_t L_19 = V_6;
		STORE_SEQ_POINT(methodExecutionContext, 64248);
		NullCheck(L_18, il2cpp_codegen_get_sequence_point(64238));
		int32_t L_20 = Dictionary_2_get_Item_mFB950EA5BD4A89CD6EAA8D0CB45D665091FAA7E1(L_18, L_19, /*hidden argument*/Dictionary_2_get_Item_mFB950EA5BD4A89CD6EAA8D0CB45D665091FAA7E1_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64248);
		STORE_SEQ_POINT(methodExecutionContext, 64249);
		NullCheck(L_16, il2cpp_codegen_get_sequence_point(64238));
		Dictionary_2_set_Item_mEA07C9AE7BBAF67BC9CFE20D200A464725D1F7FA(L_16, L_17, ((int32_t)il2cpp_codegen_add((int32_t)L_20, (int32_t)1)), /*hidden argument*/Dictionary_2_set_Item_mEA07C9AE7BBAF67BC9CFE20D200A464725D1F7FA_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64249);
		// continue;
		CHECK_SEQ_POINT(methodExecutionContext, 64239);
		goto IL_005c;
	}

IL_004a:
	{
		// dict.Add(index, 1);
		CHECK_SEQ_POINT(methodExecutionContext, 64240);
		Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * L_21 = V_0;
		int32_t L_22 = V_3;
		STORE_SEQ_POINT(methodExecutionContext, 64250);
		NullCheck(L_21, il2cpp_codegen_get_sequence_point(64240));
		Dictionary_2_Add_mDC25A2F4744B497C39F127D97327CC7B56E68903(L_21, L_22, 1, /*hidden argument*/Dictionary_2_Add_mDC25A2F4744B497C39F127D97327CC7B56E68903_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64250);
		// HandleChange(entity, index);
		CHECK_SEQ_POINT(methodExecutionContext, 64241);
		ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * L_23 = ___entity0;
		int32_t L_24 = V_3;
		STORE_SEQ_POINT(methodExecutionContext, 64251);
		IL2CPP_RUNTIME_CLASS_INIT(StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_il2cpp_TypeInfo_var);
		StorageTags_HandleChange_m4BD1475868B1DBAA90A56C0F26FDD0471D120FA1((ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 *)L_23, L_24, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 64251);
		CHECK_SEQ_POINT(methodExecutionContext, 64242);
	}

IL_005c:
	{
		CHECK_SEQ_POINT(methodExecutionContext, 64243);
		int32_t L_25 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add((int32_t)L_25, (int32_t)1));
	}

IL_0060:
	{
		// foreach (int index in tagIds)
		CHECK_SEQ_POINT(methodExecutionContext, 64244);
		int32_t L_26 = V_2;
		Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* L_27 = V_1;
		NullCheck(L_27, il2cpp_codegen_get_sequence_point(64244));
		if ((((int32_t)L_26) < ((int32_t)(((int32_t)((int32_t)(((RuntimeArray *)L_27)->max_length)))))))
		{
			goto IL_001a;
		}
	}
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 64245);
		return;
	}
}
// System.Void Pixeye.StorageTags::AddRaw(Pixeye.entU26,System.Int32)
extern "C" IL2CPP_METHOD_ATTR void StorageTags_AddRaw_mFF874A7D557EF4E3EEA7114AB99F48EA2275ADF3 (ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * ___entity0, int32_t ___tagId1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (StorageTags_AddRaw_mFF874A7D557EF4E3EEA7114AB99F48EA2275ADF3_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * V_0 = NULL;
	bool V_1 = false;
	Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * V_2 = NULL;
	int32_t V_3 = 0;
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___entity0), (&___tagId1));
	DECLARE_METHOD_LOCALS(methodExecutionContextLocals, (&V_0));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, StorageTags_AddRaw_mFF874A7D557EF4E3EEA7114AB99F48EA2275ADF3_RuntimeMethod_var, NULL, methodExecutionContextParameters, methodExecutionContextLocals);
	CHECK_SEQ_POINT(methodExecutionContext, 64252);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 64253);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 64254);
		// var dict = tags[entity];
		CHECK_SEQ_POINT(methodExecutionContext, 64255);
		IL2CPP_RUNTIME_CLASS_INIT(StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_il2cpp_TypeInfo_var);
		Dictionary_2U5BU5D_t5A34008586C648E4C1725CB098BCFE11124FEC7E* L_0 = ((StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_StaticFields*)il2cpp_codegen_static_fields_for(StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_il2cpp_TypeInfo_var))->get_tags_0();
		ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * L_1 = ___entity0;
		STORE_SEQ_POINT(methodExecutionContext, 64263);
		int32_t L_2 = ent_op_Implicit_m16BC2A28ED2D8A104FC8CB8BF31A2CA6B2DD42CD((*(ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 *)L_1), /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 64263);
		NullCheck(L_0, il2cpp_codegen_get_sequence_point(64255));
		int32_t L_3 = L_2;
		Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * L_4 = (Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 *)(L_0)->GetAt(static_cast<il2cpp_array_size_t>(L_3));
		V_0 = L_4;
		// if (dict.ContainsKey(tagId))
		CHECK_SEQ_POINT(methodExecutionContext, 64256);
		Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * L_5 = V_0;
		int32_t L_6 = ___tagId1;
		STORE_SEQ_POINT(methodExecutionContext, 64264);
		NullCheck(L_5, il2cpp_codegen_get_sequence_point(64256));
		bool L_7 = Dictionary_2_ContainsKey_mBC44DAB119CBE7A4B7820ABF12AD024A4654471E(L_5, L_6, /*hidden argument*/Dictionary_2_ContainsKey_mBC44DAB119CBE7A4B7820ABF12AD024A4654471E_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64264);
		V_1 = L_7;
		CHECK_SEQ_POINT(methodExecutionContext, 64257);
		bool L_8 = V_1;
		if (!L_8)
		{
			goto IL_0036;
		}
	}
	{
		CHECK_SEQ_POINT(methodExecutionContext, 64258);
		// dict[tagId] += 1;
		CHECK_SEQ_POINT(methodExecutionContext, 64259);
		Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * L_9 = V_0;
		V_2 = L_9;
		int32_t L_10 = ___tagId1;
		V_3 = L_10;
		Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * L_11 = V_2;
		int32_t L_12 = V_3;
		Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * L_13 = V_2;
		int32_t L_14 = V_3;
		STORE_SEQ_POINT(methodExecutionContext, 64265);
		NullCheck(L_13, il2cpp_codegen_get_sequence_point(64259));
		int32_t L_15 = Dictionary_2_get_Item_mFB950EA5BD4A89CD6EAA8D0CB45D665091FAA7E1(L_13, L_14, /*hidden argument*/Dictionary_2_get_Item_mFB950EA5BD4A89CD6EAA8D0CB45D665091FAA7E1_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64265);
		STORE_SEQ_POINT(methodExecutionContext, 64266);
		NullCheck(L_11, il2cpp_codegen_get_sequence_point(64259));
		Dictionary_2_set_Item_mEA07C9AE7BBAF67BC9CFE20D200A464725D1F7FA(L_11, L_12, ((int32_t)il2cpp_codegen_add((int32_t)L_15, (int32_t)1)), /*hidden argument*/Dictionary_2_set_Item_mEA07C9AE7BBAF67BC9CFE20D200A464725D1F7FA_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64266);
		// return;
		CHECK_SEQ_POINT(methodExecutionContext, 64260);
		goto IL_003f;
	}

IL_0036:
	{
		// dict.Add(tagId, 1);
		CHECK_SEQ_POINT(methodExecutionContext, 64261);
		Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * L_16 = V_0;
		int32_t L_17 = ___tagId1;
		STORE_SEQ_POINT(methodExecutionContext, 64267);
		NullCheck(L_16, il2cpp_codegen_get_sequence_point(64261));
		Dictionary_2_Add_mDC25A2F4744B497C39F127D97327CC7B56E68903(L_16, L_17, 1, /*hidden argument*/Dictionary_2_Add_mDC25A2F4744B497C39F127D97327CC7B56E68903_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64267);
	}

IL_003f:
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 64262);
		return;
	}
}
// System.Void Pixeye.StorageTags::AddTagsRaw(Pixeye.entU26,System.Int32[])
extern "C" IL2CPP_METHOD_ATTR void StorageTags_AddTagsRaw_m111EBC57E4E312E5A48549FD01856586C6114C75 (ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * ___entity0, Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* ___tagIds1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (StorageTags_AddTagsRaw_m111EBC57E4E312E5A48549FD01856586C6114C75_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * V_0 = NULL;
	Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* V_1 = NULL;
	int32_t V_2 = 0;
	int32_t V_3 = 0;
	bool V_4 = false;
	Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * V_5 = NULL;
	int32_t V_6 = 0;
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___entity0), (&___tagIds1));
	DECLARE_METHOD_LOCALS(methodExecutionContextLocals, (&V_0), (&V_3));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, StorageTags_AddTagsRaw_m111EBC57E4E312E5A48549FD01856586C6114C75_RuntimeMethod_var, NULL, methodExecutionContextParameters, methodExecutionContextLocals);
	CHECK_SEQ_POINT(methodExecutionContext, 64268);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 64269);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 64270);
		// var dict = tags[entity];
		CHECK_SEQ_POINT(methodExecutionContext, 64271);
		IL2CPP_RUNTIME_CLASS_INIT(StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_il2cpp_TypeInfo_var);
		Dictionary_2U5BU5D_t5A34008586C648E4C1725CB098BCFE11124FEC7E* L_0 = ((StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_StaticFields*)il2cpp_codegen_static_fields_for(StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_il2cpp_TypeInfo_var))->get_tags_0();
		ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * L_1 = ___entity0;
		STORE_SEQ_POINT(methodExecutionContext, 64287);
		int32_t L_2 = ent_op_Implicit_m16BC2A28ED2D8A104FC8CB8BF31A2CA6B2DD42CD((*(ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 *)L_1), /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 64287);
		NullCheck(L_0, il2cpp_codegen_get_sequence_point(64271));
		int32_t L_3 = L_2;
		Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * L_4 = (Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 *)(L_0)->GetAt(static_cast<il2cpp_array_size_t>(L_3));
		V_0 = L_4;
		CHECK_SEQ_POINT(methodExecutionContext, 64272);
		// foreach (int index in tagIds)
		CHECK_SEQ_POINT(methodExecutionContext, 64273);
		Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* L_5 = ___tagIds1;
		V_1 = L_5;
		V_2 = 0;
		CHECK_SEQ_POINT(methodExecutionContext, 64274);
		goto IL_0058;
	}

IL_001a:
	{
		// foreach (int index in tagIds)
		CHECK_SEQ_POINT(methodExecutionContext, 64275);
		Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* L_6 = V_1;
		int32_t L_7 = V_2;
		NullCheck(L_6, il2cpp_codegen_get_sequence_point(64275));
		int32_t L_8 = L_7;
		int32_t L_9 = (L_6)->GetAt(static_cast<il2cpp_array_size_t>(L_8));
		V_3 = L_9;
		CHECK_SEQ_POINT(methodExecutionContext, 64276);
		// if (dict.ContainsKey(index))
		CHECK_SEQ_POINT(methodExecutionContext, 64277);
		Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * L_10 = V_0;
		int32_t L_11 = V_3;
		STORE_SEQ_POINT(methodExecutionContext, 64288);
		NullCheck(L_10, il2cpp_codegen_get_sequence_point(64277));
		bool L_12 = Dictionary_2_ContainsKey_mBC44DAB119CBE7A4B7820ABF12AD024A4654471E(L_10, L_11, /*hidden argument*/Dictionary_2_ContainsKey_mBC44DAB119CBE7A4B7820ABF12AD024A4654471E_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64288);
		V_4 = L_12;
		CHECK_SEQ_POINT(methodExecutionContext, 64278);
		bool L_13 = V_4;
		if (!L_13)
		{
			goto IL_004a;
		}
	}
	{
		CHECK_SEQ_POINT(methodExecutionContext, 64279);
		// dict[index] += 1;
		CHECK_SEQ_POINT(methodExecutionContext, 64280);
		Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * L_14 = V_0;
		V_5 = L_14;
		int32_t L_15 = V_3;
		V_6 = L_15;
		Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * L_16 = V_5;
		int32_t L_17 = V_6;
		Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * L_18 = V_5;
		int32_t L_19 = V_6;
		STORE_SEQ_POINT(methodExecutionContext, 64289);
		NullCheck(L_18, il2cpp_codegen_get_sequence_point(64280));
		int32_t L_20 = Dictionary_2_get_Item_mFB950EA5BD4A89CD6EAA8D0CB45D665091FAA7E1(L_18, L_19, /*hidden argument*/Dictionary_2_get_Item_mFB950EA5BD4A89CD6EAA8D0CB45D665091FAA7E1_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64289);
		STORE_SEQ_POINT(methodExecutionContext, 64290);
		NullCheck(L_16, il2cpp_codegen_get_sequence_point(64280));
		Dictionary_2_set_Item_mEA07C9AE7BBAF67BC9CFE20D200A464725D1F7FA(L_16, L_17, ((int32_t)il2cpp_codegen_add((int32_t)L_20, (int32_t)1)), /*hidden argument*/Dictionary_2_set_Item_mEA07C9AE7BBAF67BC9CFE20D200A464725D1F7FA_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64290);
		// continue;
		CHECK_SEQ_POINT(methodExecutionContext, 64281);
		goto IL_0054;
	}

IL_004a:
	{
		// dict.Add(index, 1);
		CHECK_SEQ_POINT(methodExecutionContext, 64282);
		Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * L_21 = V_0;
		int32_t L_22 = V_3;
		STORE_SEQ_POINT(methodExecutionContext, 64291);
		NullCheck(L_21, il2cpp_codegen_get_sequence_point(64282));
		Dictionary_2_Add_mDC25A2F4744B497C39F127D97327CC7B56E68903(L_21, L_22, 1, /*hidden argument*/Dictionary_2_Add_mDC25A2F4744B497C39F127D97327CC7B56E68903_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64291);
		CHECK_SEQ_POINT(methodExecutionContext, 64283);
	}

IL_0054:
	{
		CHECK_SEQ_POINT(methodExecutionContext, 64284);
		int32_t L_23 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add((int32_t)L_23, (int32_t)1));
	}

IL_0058:
	{
		// foreach (int index in tagIds)
		CHECK_SEQ_POINT(methodExecutionContext, 64285);
		int32_t L_24 = V_2;
		Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* L_25 = V_1;
		NullCheck(L_25, il2cpp_codegen_get_sequence_point(64285));
		if ((((int32_t)L_24) < ((int32_t)(((int32_t)((int32_t)(((RuntimeArray *)L_25)->max_length)))))))
		{
			goto IL_001a;
		}
	}
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 64286);
		return;
	}
}
// System.Void Pixeye.StorageTags::RemoveTagsRaw(Pixeye.entU26,System.Int32[])
extern "C" IL2CPP_METHOD_ATTR void StorageTags_RemoveTagsRaw_m9EB9CD5105697868437FEC1117A623ED4FA2BCFA (ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * ___entity0, Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* ___tagIds1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (StorageTags_RemoveTagsRaw_m9EB9CD5105697868437FEC1117A623ED4FA2BCFA_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * V_0 = NULL;
	Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* V_1 = NULL;
	int32_t V_2 = 0;
	int32_t V_3 = 0;
	bool V_4 = false;
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___entity0), (&___tagIds1));
	DECLARE_METHOD_LOCALS(methodExecutionContextLocals, (&V_0), (&V_3));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, StorageTags_RemoveTagsRaw_m9EB9CD5105697868437FEC1117A623ED4FA2BCFA_RuntimeMethod_var, NULL, methodExecutionContextParameters, methodExecutionContextLocals);
	CHECK_SEQ_POINT(methodExecutionContext, 64292);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 64293);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 64294);
		// var dict = tags[entity];
		CHECK_SEQ_POINT(methodExecutionContext, 64295);
		IL2CPP_RUNTIME_CLASS_INIT(StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_il2cpp_TypeInfo_var);
		Dictionary_2U5BU5D_t5A34008586C648E4C1725CB098BCFE11124FEC7E* L_0 = ((StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_StaticFields*)il2cpp_codegen_static_fields_for(StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_il2cpp_TypeInfo_var))->get_tags_0();
		ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * L_1 = ___entity0;
		STORE_SEQ_POINT(methodExecutionContext, 64309);
		int32_t L_2 = ent_op_Implicit_m16BC2A28ED2D8A104FC8CB8BF31A2CA6B2DD42CD((*(ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 *)L_1), /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 64309);
		NullCheck(L_0, il2cpp_codegen_get_sequence_point(64295));
		int32_t L_3 = L_2;
		Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * L_4 = (Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 *)(L_0)->GetAt(static_cast<il2cpp_array_size_t>(L_3));
		V_0 = L_4;
		CHECK_SEQ_POINT(methodExecutionContext, 64296);
		// foreach (int index in tagIds)
		CHECK_SEQ_POINT(methodExecutionContext, 64297);
		Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* L_5 = ___tagIds1;
		V_1 = L_5;
		V_2 = 0;
		CHECK_SEQ_POINT(methodExecutionContext, 64298);
		goto IL_003e;
	}

IL_001a:
	{
		// foreach (int index in tagIds)
		CHECK_SEQ_POINT(methodExecutionContext, 64299);
		Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* L_6 = V_1;
		int32_t L_7 = V_2;
		NullCheck(L_6, il2cpp_codegen_get_sequence_point(64299));
		int32_t L_8 = L_7;
		int32_t L_9 = (L_6)->GetAt(static_cast<il2cpp_array_size_t>(L_8));
		V_3 = L_9;
		CHECK_SEQ_POINT(methodExecutionContext, 64300);
		// if (!dict.ContainsKey(index)) continue;
		CHECK_SEQ_POINT(methodExecutionContext, 64301);
		Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * L_10 = V_0;
		int32_t L_11 = V_3;
		STORE_SEQ_POINT(methodExecutionContext, 64310);
		NullCheck(L_10, il2cpp_codegen_get_sequence_point(64301));
		bool L_12 = Dictionary_2_ContainsKey_mBC44DAB119CBE7A4B7820ABF12AD024A4654471E(L_10, L_11, /*hidden argument*/Dictionary_2_ContainsKey_mBC44DAB119CBE7A4B7820ABF12AD024A4654471E_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64310);
		V_4 = (bool)((((int32_t)L_12) == ((int32_t)0))? 1 : 0);
		CHECK_SEQ_POINT(methodExecutionContext, 64302);
		bool L_13 = V_4;
		if (!L_13)
		{
			goto IL_0031;
		}
	}
	{
		// if (!dict.ContainsKey(index)) continue;
		CHECK_SEQ_POINT(methodExecutionContext, 64303);
		goto IL_003a;
	}

IL_0031:
	{
		// dict.Remove(index);
		CHECK_SEQ_POINT(methodExecutionContext, 64304);
		Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * L_14 = V_0;
		int32_t L_15 = V_3;
		STORE_SEQ_POINT(methodExecutionContext, 64311);
		NullCheck(L_14, il2cpp_codegen_get_sequence_point(64304));
		Dictionary_2_Remove_m8E04EF60FB32880A72708207DB1CC4555C2E476F(L_14, L_15, /*hidden argument*/Dictionary_2_Remove_m8E04EF60FB32880A72708207DB1CC4555C2E476F_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64311);
		CHECK_SEQ_POINT(methodExecutionContext, 64305);
	}

IL_003a:
	{
		CHECK_SEQ_POINT(methodExecutionContext, 64306);
		int32_t L_16 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add((int32_t)L_16, (int32_t)1));
	}

IL_003e:
	{
		// foreach (int index in tagIds)
		CHECK_SEQ_POINT(methodExecutionContext, 64307);
		int32_t L_17 = V_2;
		Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* L_18 = V_1;
		NullCheck(L_18, il2cpp_codegen_get_sequence_point(64307));
		if ((((int32_t)L_17) < ((int32_t)(((int32_t)((int32_t)(((RuntimeArray *)L_18)->max_length)))))))
		{
			goto IL_001a;
		}
	}
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 64308);
		return;
	}
}
// System.Boolean Pixeye.StorageTags::Has(Pixeye.entU26,System.Int32)
extern "C" IL2CPP_METHOD_ATTR bool StorageTags_Has_m359525595715BD7A6528801A898303C8571575A6 (ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * ___entity0, int32_t ___filter1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (StorageTags_Has_m359525595715BD7A6528801A898303C8571575A6_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * V_0 = NULL;
	bool V_1 = false;
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___entity0), (&___filter1));
	DECLARE_METHOD_LOCALS(methodExecutionContextLocals, (&V_0));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, StorageTags_Has_m359525595715BD7A6528801A898303C8571575A6_RuntimeMethod_var, NULL, methodExecutionContextParameters, methodExecutionContextLocals);
	CHECK_SEQ_POINT(methodExecutionContext, 64312);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 64313);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 64314);
		// var container = tags[entity];
		CHECK_SEQ_POINT(methodExecutionContext, 64315);
		IL2CPP_RUNTIME_CLASS_INIT(StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_il2cpp_TypeInfo_var);
		Dictionary_2U5BU5D_t5A34008586C648E4C1725CB098BCFE11124FEC7E* L_0 = ((StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_StaticFields*)il2cpp_codegen_static_fields_for(StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_il2cpp_TypeInfo_var))->get_tags_0();
		ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * L_1 = ___entity0;
		STORE_SEQ_POINT(methodExecutionContext, 64318);
		int32_t L_2 = ent_op_Implicit_m16BC2A28ED2D8A104FC8CB8BF31A2CA6B2DD42CD((*(ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 *)L_1), /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 64318);
		NullCheck(L_0, il2cpp_codegen_get_sequence_point(64315));
		int32_t L_3 = L_2;
		Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * L_4 = (Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 *)(L_0)->GetAt(static_cast<il2cpp_array_size_t>(L_3));
		V_0 = L_4;
		// return container.ContainsKey(filter);
		CHECK_SEQ_POINT(methodExecutionContext, 64316);
		Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * L_5 = V_0;
		int32_t L_6 = ___filter1;
		STORE_SEQ_POINT(methodExecutionContext, 64319);
		NullCheck(L_5, il2cpp_codegen_get_sequence_point(64316));
		bool L_7 = Dictionary_2_ContainsKey_mBC44DAB119CBE7A4B7820ABF12AD024A4654471E(L_5, L_6, /*hidden argument*/Dictionary_2_ContainsKey_mBC44DAB119CBE7A4B7820ABF12AD024A4654471E_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64319);
		V_1 = L_7;
		goto IL_001d;
	}

IL_001d:
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 64317);
		bool L_8 = V_1;
		return L_8;
	}
}
// System.Boolean Pixeye.StorageTags::HasRaw(Pixeye.entU26,System.Int32[]U26)
extern "C" IL2CPP_METHOD_ATTR bool StorageTags_HasRaw_m87F3357D1A697D9A2787BC29FCC0AD0AB2DC1967 (ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * ___entity0, Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83** ___filter1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (StorageTags_HasRaw_m87F3357D1A697D9A2787BC29FCC0AD0AB2DC1967_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * V_0 = NULL;
	int32_t V_1 = 0;
	bool V_2 = false;
	bool V_3 = false;
	bool V_4 = false;
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___entity0), (&___filter1));
	DECLARE_METHOD_LOCALS(methodExecutionContextLocals, (&V_0), (&V_1));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, StorageTags_HasRaw_m87F3357D1A697D9A2787BC29FCC0AD0AB2DC1967_RuntimeMethod_var, NULL, methodExecutionContextParameters, methodExecutionContextLocals);
	CHECK_SEQ_POINT(methodExecutionContext, 64320);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 64321);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 64322);
		// var container = tags[entity];
		CHECK_SEQ_POINT(methodExecutionContext, 64323);
		IL2CPP_RUNTIME_CLASS_INIT(StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_il2cpp_TypeInfo_var);
		Dictionary_2U5BU5D_t5A34008586C648E4C1725CB098BCFE11124FEC7E* L_0 = ((StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_StaticFields*)il2cpp_codegen_static_fields_for(StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_il2cpp_TypeInfo_var))->get_tags_0();
		ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * L_1 = ___entity0;
		STORE_SEQ_POINT(methodExecutionContext, 64336);
		int32_t L_2 = ent_op_Implicit_m16BC2A28ED2D8A104FC8CB8BF31A2CA6B2DD42CD((*(ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 *)L_1), /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 64336);
		NullCheck(L_0, il2cpp_codegen_get_sequence_point(64323));
		int32_t L_3 = L_2;
		Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * L_4 = (Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 *)(L_0)->GetAt(static_cast<il2cpp_array_size_t>(L_3));
		V_0 = L_4;
		// for (int i = 0; i < filter.Length; i++)
		CHECK_SEQ_POINT(methodExecutionContext, 64324);
		V_1 = 0;
		CHECK_SEQ_POINT(methodExecutionContext, 64325);
		goto IL_0032;
	}

IL_0017:
	{
		CHECK_SEQ_POINT(methodExecutionContext, 64326);
		// if (!container.ContainsKey(filter[i])) return false;
		CHECK_SEQ_POINT(methodExecutionContext, 64327);
		Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * L_5 = V_0;
		Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83** L_6 = ___filter1;
		Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* L_7 = *((Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83**)L_6);
		int32_t L_8 = V_1;
		NullCheck(L_7, il2cpp_codegen_get_sequence_point(64327));
		int32_t L_9 = L_8;
		int32_t L_10 = (L_7)->GetAt(static_cast<il2cpp_array_size_t>(L_9));
		STORE_SEQ_POINT(methodExecutionContext, 64337);
		NullCheck(L_5, il2cpp_codegen_get_sequence_point(64327));
		bool L_11 = Dictionary_2_ContainsKey_mBC44DAB119CBE7A4B7820ABF12AD024A4654471E(L_5, L_10, /*hidden argument*/Dictionary_2_ContainsKey_mBC44DAB119CBE7A4B7820ABF12AD024A4654471E_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64337);
		V_2 = (bool)((((int32_t)L_11) == ((int32_t)0))? 1 : 0);
		CHECK_SEQ_POINT(methodExecutionContext, 64328);
		bool L_12 = V_2;
		if (!L_12)
		{
			goto IL_002d;
		}
	}
	{
		// if (!container.ContainsKey(filter[i])) return false;
		CHECK_SEQ_POINT(methodExecutionContext, 64329);
		V_3 = (bool)0;
		goto IL_0043;
	}

IL_002d:
	{
		CHECK_SEQ_POINT(methodExecutionContext, 64330);
		// for (int i = 0; i < filter.Length; i++)
		CHECK_SEQ_POINT(methodExecutionContext, 64331);
		int32_t L_13 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add((int32_t)L_13, (int32_t)1));
	}

IL_0032:
	{
		// for (int i = 0; i < filter.Length; i++)
		CHECK_SEQ_POINT(methodExecutionContext, 64332);
		int32_t L_14 = V_1;
		Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83** L_15 = ___filter1;
		Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* L_16 = *((Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83**)L_15);
		NullCheck(L_16, il2cpp_codegen_get_sequence_point(64332));
		V_4 = (bool)((((int32_t)L_14) < ((int32_t)(((int32_t)((int32_t)(((RuntimeArray *)L_16)->max_length))))))? 1 : 0);
		CHECK_SEQ_POINT(methodExecutionContext, 64333);
		bool L_17 = V_4;
		if (L_17)
		{
			goto IL_0017;
		}
	}
	{
		// return true;
		CHECK_SEQ_POINT(methodExecutionContext, 64334);
		V_3 = (bool)1;
		goto IL_0043;
	}

IL_0043:
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 64335);
		bool L_18 = V_3;
		return L_18;
	}
}
// System.Boolean Pixeye.StorageTags::Has(Pixeye.entU26,System.Int32[])
extern "C" IL2CPP_METHOD_ATTR bool StorageTags_Has_m1851387046ECDB6A342295BEBD984F3E0E23890D (ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * ___entity0, Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* ___filter1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (StorageTags_Has_m1851387046ECDB6A342295BEBD984F3E0E23890D_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * V_0 = NULL;
	int32_t V_1 = 0;
	bool V_2 = false;
	bool V_3 = false;
	bool V_4 = false;
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___entity0), (&___filter1));
	DECLARE_METHOD_LOCALS(methodExecutionContextLocals, (&V_0), (&V_1));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, StorageTags_Has_m1851387046ECDB6A342295BEBD984F3E0E23890D_RuntimeMethod_var, NULL, methodExecutionContextParameters, methodExecutionContextLocals);
	CHECK_SEQ_POINT(methodExecutionContext, 64338);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 64339);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 64340);
		// var container = tags[entity];
		CHECK_SEQ_POINT(methodExecutionContext, 64341);
		IL2CPP_RUNTIME_CLASS_INIT(StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_il2cpp_TypeInfo_var);
		Dictionary_2U5BU5D_t5A34008586C648E4C1725CB098BCFE11124FEC7E* L_0 = ((StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_StaticFields*)il2cpp_codegen_static_fields_for(StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_il2cpp_TypeInfo_var))->get_tags_0();
		ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * L_1 = ___entity0;
		STORE_SEQ_POINT(methodExecutionContext, 64354);
		int32_t L_2 = ent_op_Implicit_m16BC2A28ED2D8A104FC8CB8BF31A2CA6B2DD42CD((*(ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 *)L_1), /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 64354);
		NullCheck(L_0, il2cpp_codegen_get_sequence_point(64341));
		int32_t L_3 = L_2;
		Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * L_4 = (Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 *)(L_0)->GetAt(static_cast<il2cpp_array_size_t>(L_3));
		V_0 = L_4;
		// for (int i = 0; i < filter.Length; i++)
		CHECK_SEQ_POINT(methodExecutionContext, 64342);
		V_1 = 0;
		CHECK_SEQ_POINT(methodExecutionContext, 64343);
		goto IL_0031;
	}

IL_0017:
	{
		CHECK_SEQ_POINT(methodExecutionContext, 64344);
		// if (!container.ContainsKey(filter[i])) return false;
		CHECK_SEQ_POINT(methodExecutionContext, 64345);
		Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * L_5 = V_0;
		Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* L_6 = ___filter1;
		int32_t L_7 = V_1;
		NullCheck(L_6, il2cpp_codegen_get_sequence_point(64345));
		int32_t L_8 = L_7;
		int32_t L_9 = (L_6)->GetAt(static_cast<il2cpp_array_size_t>(L_8));
		STORE_SEQ_POINT(methodExecutionContext, 64355);
		NullCheck(L_5, il2cpp_codegen_get_sequence_point(64345));
		bool L_10 = Dictionary_2_ContainsKey_mBC44DAB119CBE7A4B7820ABF12AD024A4654471E(L_5, L_9, /*hidden argument*/Dictionary_2_ContainsKey_mBC44DAB119CBE7A4B7820ABF12AD024A4654471E_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64355);
		V_2 = (bool)((((int32_t)L_10) == ((int32_t)0))? 1 : 0);
		CHECK_SEQ_POINT(methodExecutionContext, 64346);
		bool L_11 = V_2;
		if (!L_11)
		{
			goto IL_002c;
		}
	}
	{
		// if (!container.ContainsKey(filter[i])) return false;
		CHECK_SEQ_POINT(methodExecutionContext, 64347);
		V_3 = (bool)0;
		goto IL_0041;
	}

IL_002c:
	{
		CHECK_SEQ_POINT(methodExecutionContext, 64348);
		// for (int i = 0; i < filter.Length; i++)
		CHECK_SEQ_POINT(methodExecutionContext, 64349);
		int32_t L_12 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add((int32_t)L_12, (int32_t)1));
	}

IL_0031:
	{
		// for (int i = 0; i < filter.Length; i++)
		CHECK_SEQ_POINT(methodExecutionContext, 64350);
		int32_t L_13 = V_1;
		Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* L_14 = ___filter1;
		NullCheck(L_14, il2cpp_codegen_get_sequence_point(64350));
		V_4 = (bool)((((int32_t)L_13) < ((int32_t)(((int32_t)((int32_t)(((RuntimeArray *)L_14)->max_length))))))? 1 : 0);
		CHECK_SEQ_POINT(methodExecutionContext, 64351);
		bool L_15 = V_4;
		if (L_15)
		{
			goto IL_0017;
		}
	}
	{
		// return true;
		CHECK_SEQ_POINT(methodExecutionContext, 64352);
		V_3 = (bool)1;
		goto IL_0041;
	}

IL_0041:
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 64353);
		bool L_16 = V_3;
		return L_16;
	}
}
// System.Boolean Pixeye.StorageTags::HasAnyRaw(Pixeye.entU26,System.Int32[]U26)
extern "C" IL2CPP_METHOD_ATTR bool StorageTags_HasAnyRaw_m6516D8D46980ED0B0245DEC00D0FE4714A507403 (ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * ___entityID0, Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83** ___filter1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (StorageTags_HasAnyRaw_m6516D8D46980ED0B0245DEC00D0FE4714A507403_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * V_0 = NULL;
	int32_t V_1 = 0;
	bool V_2 = false;
	bool V_3 = false;
	bool V_4 = false;
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___entityID0), (&___filter1));
	DECLARE_METHOD_LOCALS(methodExecutionContextLocals, (&V_0), (&V_1));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, StorageTags_HasAnyRaw_m6516D8D46980ED0B0245DEC00D0FE4714A507403_RuntimeMethod_var, NULL, methodExecutionContextParameters, methodExecutionContextLocals);
	CHECK_SEQ_POINT(methodExecutionContext, 64356);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 64357);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 64358);
		// var container = tags[entityID];
		CHECK_SEQ_POINT(methodExecutionContext, 64359);
		IL2CPP_RUNTIME_CLASS_INIT(StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_il2cpp_TypeInfo_var);
		Dictionary_2U5BU5D_t5A34008586C648E4C1725CB098BCFE11124FEC7E* L_0 = ((StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_StaticFields*)il2cpp_codegen_static_fields_for(StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_il2cpp_TypeInfo_var))->get_tags_0();
		ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * L_1 = ___entityID0;
		STORE_SEQ_POINT(methodExecutionContext, 64372);
		int32_t L_2 = ent_op_Implicit_m16BC2A28ED2D8A104FC8CB8BF31A2CA6B2DD42CD((*(ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 *)L_1), /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 64372);
		NullCheck(L_0, il2cpp_codegen_get_sequence_point(64359));
		int32_t L_3 = L_2;
		Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * L_4 = (Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 *)(L_0)->GetAt(static_cast<il2cpp_array_size_t>(L_3));
		V_0 = L_4;
		// for (int i = 0; i < filter.Length; i++)
		CHECK_SEQ_POINT(methodExecutionContext, 64360);
		V_1 = 0;
		CHECK_SEQ_POINT(methodExecutionContext, 64361);
		goto IL_002f;
	}

IL_0017:
	{
		CHECK_SEQ_POINT(methodExecutionContext, 64362);
		// if (container.ContainsKey(filter[i]))
		CHECK_SEQ_POINT(methodExecutionContext, 64363);
		Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * L_5 = V_0;
		Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83** L_6 = ___filter1;
		Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* L_7 = *((Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83**)L_6);
		int32_t L_8 = V_1;
		NullCheck(L_7, il2cpp_codegen_get_sequence_point(64363));
		int32_t L_9 = L_8;
		int32_t L_10 = (L_7)->GetAt(static_cast<il2cpp_array_size_t>(L_9));
		STORE_SEQ_POINT(methodExecutionContext, 64373);
		NullCheck(L_5, il2cpp_codegen_get_sequence_point(64363));
		bool L_11 = Dictionary_2_ContainsKey_mBC44DAB119CBE7A4B7820ABF12AD024A4654471E(L_5, L_10, /*hidden argument*/Dictionary_2_ContainsKey_mBC44DAB119CBE7A4B7820ABF12AD024A4654471E_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64373);
		V_2 = L_11;
		CHECK_SEQ_POINT(methodExecutionContext, 64364);
		bool L_12 = V_2;
		if (!L_12)
		{
			goto IL_002a;
		}
	}
	{
		// return true;
		CHECK_SEQ_POINT(methodExecutionContext, 64365);
		V_3 = (bool)1;
		goto IL_0040;
	}

IL_002a:
	{
		CHECK_SEQ_POINT(methodExecutionContext, 64366);
		// for (int i = 0; i < filter.Length; i++)
		CHECK_SEQ_POINT(methodExecutionContext, 64367);
		int32_t L_13 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add((int32_t)L_13, (int32_t)1));
	}

IL_002f:
	{
		// for (int i = 0; i < filter.Length; i++)
		CHECK_SEQ_POINT(methodExecutionContext, 64368);
		int32_t L_14 = V_1;
		Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83** L_15 = ___filter1;
		Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* L_16 = *((Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83**)L_15);
		NullCheck(L_16, il2cpp_codegen_get_sequence_point(64368));
		V_4 = (bool)((((int32_t)L_14) < ((int32_t)(((int32_t)((int32_t)(((RuntimeArray *)L_16)->max_length))))))? 1 : 0);
		CHECK_SEQ_POINT(methodExecutionContext, 64369);
		bool L_17 = V_4;
		if (L_17)
		{
			goto IL_0017;
		}
	}
	{
		// return false;
		CHECK_SEQ_POINT(methodExecutionContext, 64370);
		V_3 = (bool)0;
		goto IL_0040;
	}

IL_0040:
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 64371);
		bool L_18 = V_3;
		return L_18;
	}
}
// System.Boolean Pixeye.StorageTags::HasAny(Pixeye.entU26,System.Int32[])
extern "C" IL2CPP_METHOD_ATTR bool StorageTags_HasAny_mF329799E84478B2102F2D511D6ABD2CBB24F21B0 (ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * ___entityID0, Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* ___filter1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (StorageTags_HasAny_mF329799E84478B2102F2D511D6ABD2CBB24F21B0_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * V_0 = NULL;
	int32_t V_1 = 0;
	bool V_2 = false;
	bool V_3 = false;
	bool V_4 = false;
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___entityID0), (&___filter1));
	DECLARE_METHOD_LOCALS(methodExecutionContextLocals, (&V_0), (&V_1));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, StorageTags_HasAny_mF329799E84478B2102F2D511D6ABD2CBB24F21B0_RuntimeMethod_var, NULL, methodExecutionContextParameters, methodExecutionContextLocals);
	CHECK_SEQ_POINT(methodExecutionContext, 64374);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 64375);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 64376);
		// var container = tags[entityID];
		CHECK_SEQ_POINT(methodExecutionContext, 64377);
		IL2CPP_RUNTIME_CLASS_INIT(StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_il2cpp_TypeInfo_var);
		Dictionary_2U5BU5D_t5A34008586C648E4C1725CB098BCFE11124FEC7E* L_0 = ((StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_StaticFields*)il2cpp_codegen_static_fields_for(StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_il2cpp_TypeInfo_var))->get_tags_0();
		ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * L_1 = ___entityID0;
		STORE_SEQ_POINT(methodExecutionContext, 64390);
		int32_t L_2 = ent_op_Implicit_m16BC2A28ED2D8A104FC8CB8BF31A2CA6B2DD42CD((*(ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 *)L_1), /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 64390);
		NullCheck(L_0, il2cpp_codegen_get_sequence_point(64377));
		int32_t L_3 = L_2;
		Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * L_4 = (Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 *)(L_0)->GetAt(static_cast<il2cpp_array_size_t>(L_3));
		V_0 = L_4;
		// for (int i = 0; i < filter.Length; i++)
		CHECK_SEQ_POINT(methodExecutionContext, 64378);
		V_1 = 0;
		CHECK_SEQ_POINT(methodExecutionContext, 64379);
		goto IL_002e;
	}

IL_0017:
	{
		CHECK_SEQ_POINT(methodExecutionContext, 64380);
		// if (container.ContainsKey(filter[i]))
		CHECK_SEQ_POINT(methodExecutionContext, 64381);
		Dictionary_2_tFE2A3F3BDE1290B85039D74816BB1FE1109BE0F8 * L_5 = V_0;
		Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* L_6 = ___filter1;
		int32_t L_7 = V_1;
		NullCheck(L_6, il2cpp_codegen_get_sequence_point(64381));
		int32_t L_8 = L_7;
		int32_t L_9 = (L_6)->GetAt(static_cast<il2cpp_array_size_t>(L_8));
		STORE_SEQ_POINT(methodExecutionContext, 64391);
		NullCheck(L_5, il2cpp_codegen_get_sequence_point(64381));
		bool L_10 = Dictionary_2_ContainsKey_mBC44DAB119CBE7A4B7820ABF12AD024A4654471E(L_5, L_9, /*hidden argument*/Dictionary_2_ContainsKey_mBC44DAB119CBE7A4B7820ABF12AD024A4654471E_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64391);
		V_2 = L_10;
		CHECK_SEQ_POINT(methodExecutionContext, 64382);
		bool L_11 = V_2;
		if (!L_11)
		{
			goto IL_0029;
		}
	}
	{
		// return true;
		CHECK_SEQ_POINT(methodExecutionContext, 64383);
		V_3 = (bool)1;
		goto IL_003e;
	}

IL_0029:
	{
		CHECK_SEQ_POINT(methodExecutionContext, 64384);
		// for (int i = 0; i < filter.Length; i++)
		CHECK_SEQ_POINT(methodExecutionContext, 64385);
		int32_t L_12 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add((int32_t)L_12, (int32_t)1));
	}

IL_002e:
	{
		// for (int i = 0; i < filter.Length; i++)
		CHECK_SEQ_POINT(methodExecutionContext, 64386);
		int32_t L_13 = V_1;
		Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* L_14 = ___filter1;
		NullCheck(L_14, il2cpp_codegen_get_sequence_point(64386));
		V_4 = (bool)((((int32_t)L_13) < ((int32_t)(((int32_t)((int32_t)(((RuntimeArray *)L_14)->max_length))))))? 1 : 0);
		CHECK_SEQ_POINT(methodExecutionContext, 64387);
		bool L_15 = V_4;
		if (L_15)
		{
			goto IL_0017;
		}
	}
	{
		// return false;
		CHECK_SEQ_POINT(methodExecutionContext, 64388);
		V_3 = (bool)0;
		goto IL_003e;
	}

IL_003e:
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 64389);
		bool L_16 = V_3;
		return L_16;
	}
}
// System.Void Pixeye.StorageTags::.cctor()
extern "C" IL2CPP_METHOD_ATTR void StorageTags__cctor_m30C3FAB242D20B1986B6E90FF2C12C88D1F8584D (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (StorageTags__cctor_m30C3FAB242D20B1986B6E90FF2C12C88D1F8584D_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, StorageTags__cctor_m30C3FAB242D20B1986B6E90FF2C12C88D1F8584D_RuntimeMethod_var, NULL, NULL, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 64392);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 64393);
	{
		// internal static Dictionary<int, int>[] tags = new Dictionary<int, int>[SettingsEngine.SizeEntities];
		CHECK_SEQ_POINT(methodExecutionContext, 64394);
		Dictionary_2U5BU5D_t5A34008586C648E4C1725CB098BCFE11124FEC7E* L_0 = (Dictionary_2U5BU5D_t5A34008586C648E4C1725CB098BCFE11124FEC7E*)SZArrayNew(Dictionary_2U5BU5D_t5A34008586C648E4C1725CB098BCFE11124FEC7E_il2cpp_TypeInfo_var, (uint32_t)((int32_t)256));
		((StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_StaticFields*)il2cpp_codegen_static_fields_for(StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_il2cpp_TypeInfo_var))->set_tags_0(L_0);
		// internal static Dictionary<int, List<GroupBase>> groupsInclude = new Dictionary<int, List<GroupBase>>(10, new FastComparable());
		CHECK_SEQ_POINT(methodExecutionContext, 64395);
		STORE_SEQ_POINT(methodExecutionContext, 64398);
		FastComparable_t85AACE6CEBE4B0D7FB16B2F3D09523B7BC4AA1A8 * L_1 = (FastComparable_t85AACE6CEBE4B0D7FB16B2F3D09523B7BC4AA1A8 *)il2cpp_codegen_object_new(FastComparable_t85AACE6CEBE4B0D7FB16B2F3D09523B7BC4AA1A8_il2cpp_TypeInfo_var);
		FastComparable__ctor_m3F034079FFB5E1F69208BF84CF6F3FFDF2084997(L_1, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 64398);
		STORE_SEQ_POINT(methodExecutionContext, 64399);
		Dictionary_2_t62CC83140A4EC1BB76940D6FD31E9B3B8417C850 * L_2 = (Dictionary_2_t62CC83140A4EC1BB76940D6FD31E9B3B8417C850 *)il2cpp_codegen_object_new(Dictionary_2_t62CC83140A4EC1BB76940D6FD31E9B3B8417C850_il2cpp_TypeInfo_var);
		Dictionary_2__ctor_m7E3DE5565E761320FA45B5A083B35E77466B2756(L_2, ((int32_t)10), L_1, /*hidden argument*/Dictionary_2__ctor_m7E3DE5565E761320FA45B5A083B35E77466B2756_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64399);
		((StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_StaticFields*)il2cpp_codegen_static_fields_for(StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_il2cpp_TypeInfo_var))->set_groupsInclude_1(L_2);
		// internal static Dictionary<int, List<GroupBase>> groupsDeclude = new Dictionary<int, List<GroupBase>>(10, new FastComparable());
		CHECK_SEQ_POINT(methodExecutionContext, 64396);
		STORE_SEQ_POINT(methodExecutionContext, 64400);
		FastComparable_t85AACE6CEBE4B0D7FB16B2F3D09523B7BC4AA1A8 * L_3 = (FastComparable_t85AACE6CEBE4B0D7FB16B2F3D09523B7BC4AA1A8 *)il2cpp_codegen_object_new(FastComparable_t85AACE6CEBE4B0D7FB16B2F3D09523B7BC4AA1A8_il2cpp_TypeInfo_var);
		FastComparable__ctor_m3F034079FFB5E1F69208BF84CF6F3FFDF2084997(L_3, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 64400);
		STORE_SEQ_POINT(methodExecutionContext, 64401);
		Dictionary_2_t62CC83140A4EC1BB76940D6FD31E9B3B8417C850 * L_4 = (Dictionary_2_t62CC83140A4EC1BB76940D6FD31E9B3B8417C850 *)il2cpp_codegen_object_new(Dictionary_2_t62CC83140A4EC1BB76940D6FD31E9B3B8417C850_il2cpp_TypeInfo_var);
		Dictionary_2__ctor_m7E3DE5565E761320FA45B5A083B35E77466B2756(L_4, ((int32_t)10), L_3, /*hidden argument*/Dictionary_2__ctor_m7E3DE5565E761320FA45B5A083B35E77466B2756_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64401);
		((StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_StaticFields*)il2cpp_codegen_static_fields_for(StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_il2cpp_TypeInfo_var))->set_groupsDeclude_2(L_4);
		// static internal int length = -1;
		CHECK_SEQ_POINT(methodExecutionContext, 64397);
		((StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_StaticFields*)il2cpp_codegen_static_fields_for(StorageTags_t7EABB0D96A685E12F8FDFF99F7827DAC5B2323F8_il2cpp_TypeInfo_var))->set_length_3((-1));
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Pixeye.TagBase::.ctor()
extern "C" IL2CPP_METHOD_ATTR void TagBase__ctor_m39019F77D7AC6222FF6D151497FFDEA452B99BA2 (TagBase_t00D73CADD76FB47F7A9EA7BC5DA9E359CCAAAC3F * __this, const RuntimeMethod* method)
{
	CHECK_PAUSE_POINT;
	{
		Object__ctor_m925ECA5E85CA100E3FB86A4F9E15C120E9A184C0(__this, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Pixeye.TagFieldAttribute::.ctor(System.String,System.Type)
extern "C" IL2CPP_METHOD_ATTR void TagFieldAttribute__ctor_m3061DEC1FD335EDFCF60FBA5E7ED4F56F593C49F (TagFieldAttribute_t44EBFA87585224B6D3C31F706F3CE1072F7C075D * __this, String_t* ___categoryName0, Type_t * ___clas1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (TagFieldAttribute__ctor_m3061DEC1FD335EDFCF60FBA5E7ED4F56F593C49F_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___categoryName0), (&___clas1));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, TagFieldAttribute__ctor_m3061DEC1FD335EDFCF60FBA5E7ED4F56F593C49F_RuntimeMethod_var, methodExecutionContextThis, methodExecutionContextParameters, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 57973);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 57974);
	{
		// public TagFieldAttribute(string categoryName, Type clas)
		CHECK_SEQ_POINT(methodExecutionContext, 57975);
		STORE_SEQ_POINT(methodExecutionContext, 57980);
		Attribute__ctor_m45CAD4B01265CC84CC5A84F62EE2DBE85DE89EC0(__this, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 57980);
		CHECK_SEQ_POINT(methodExecutionContext, 57976);
		// this.categoryName = categoryName;
		CHECK_SEQ_POINT(methodExecutionContext, 57977);
		String_t* L_0 = ___categoryName0;
		__this->set_categoryName_0(L_0);
		// className = clas.ToString();
		CHECK_SEQ_POINT(methodExecutionContext, 57978);
		Type_t * L_1 = ___clas1;
		STORE_SEQ_POINT(methodExecutionContext, 57981);
		NullCheck(L_1, il2cpp_codegen_get_sequence_point(57978));
		String_t* L_2 = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, L_1);
		CHECK_SEQ_POINT(methodExecutionContext, 57981);
		__this->set_className_1(L_2);
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 57979);
		return;
	}
}
// System.Void Pixeye.TagFieldAttribute::.ctor(System.Type,System.String)
extern "C" IL2CPP_METHOD_ATTR void TagFieldAttribute__ctor_mFBDA7F394D479E0A759E12893343983C527E46C4 (TagFieldAttribute_t44EBFA87585224B6D3C31F706F3CE1072F7C075D * __this, Type_t * ___clas0, String_t* ___categoryName1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (TagFieldAttribute__ctor_mFBDA7F394D479E0A759E12893343983C527E46C4_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___clas0), (&___categoryName1));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, TagFieldAttribute__ctor_mFBDA7F394D479E0A759E12893343983C527E46C4_RuntimeMethod_var, methodExecutionContextThis, methodExecutionContextParameters, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 57982);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 57983);
	{
		// public TagFieldAttribute(Type clas, string categoryName)
		CHECK_SEQ_POINT(methodExecutionContext, 57984);
		STORE_SEQ_POINT(methodExecutionContext, 57989);
		Attribute__ctor_m45CAD4B01265CC84CC5A84F62EE2DBE85DE89EC0(__this, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 57989);
		CHECK_SEQ_POINT(methodExecutionContext, 57985);
		// this.categoryName = categoryName;
		CHECK_SEQ_POINT(methodExecutionContext, 57986);
		String_t* L_0 = ___categoryName1;
		__this->set_categoryName_0(L_0);
		// className = clas.ToString();
		CHECK_SEQ_POINT(methodExecutionContext, 57987);
		Type_t * L_1 = ___clas0;
		STORE_SEQ_POINT(methodExecutionContext, 57990);
		NullCheck(L_1, il2cpp_codegen_get_sequence_point(57987));
		String_t* L_2 = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, L_1);
		CHECK_SEQ_POINT(methodExecutionContext, 57990);
		__this->set_className_1(L_2);
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 57988);
		return;
	}
}
// System.Void Pixeye.TagFieldAttribute::.ctor(System.String)
extern "C" IL2CPP_METHOD_ATTR void TagFieldAttribute__ctor_m4E1C0C653496A9001D516369068B6AC407F93313 (TagFieldAttribute_t44EBFA87585224B6D3C31F706F3CE1072F7C075D * __this, String_t* ___categoryName0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (TagFieldAttribute__ctor_m4E1C0C653496A9001D516369068B6AC407F93313_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___categoryName0));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, TagFieldAttribute__ctor_m4E1C0C653496A9001D516369068B6AC407F93313_RuntimeMethod_var, methodExecutionContextThis, methodExecutionContextParameters, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 57991);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 57992);
	{
		// public TagFieldAttribute(string categoryName)
		CHECK_SEQ_POINT(methodExecutionContext, 57993);
		STORE_SEQ_POINT(methodExecutionContext, 57997);
		Attribute__ctor_m45CAD4B01265CC84CC5A84F62EE2DBE85DE89EC0(__this, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 57997);
		CHECK_SEQ_POINT(methodExecutionContext, 57994);
		// this.categoryName = categoryName;
		CHECK_SEQ_POINT(methodExecutionContext, 57995);
		String_t* L_0 = ___categoryName0;
		__this->set_categoryName_0(L_0);
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 57996);
		return;
	}
}
// System.Void Pixeye.TagFieldAttribute::.ctor(System.Type)
extern "C" IL2CPP_METHOD_ATTR void TagFieldAttribute__ctor_mF96BDE8ED77B82AAEAD1EFDE853D210AE07C66A9 (TagFieldAttribute_t44EBFA87585224B6D3C31F706F3CE1072F7C075D * __this, Type_t * ___clas0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (TagFieldAttribute__ctor_mF96BDE8ED77B82AAEAD1EFDE853D210AE07C66A9_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___clas0));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, TagFieldAttribute__ctor_mF96BDE8ED77B82AAEAD1EFDE853D210AE07C66A9_RuntimeMethod_var, methodExecutionContextThis, methodExecutionContextParameters, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 57998);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 57999);
	{
		// public TagFieldAttribute(Type clas)
		CHECK_SEQ_POINT(methodExecutionContext, 58000);
		STORE_SEQ_POINT(methodExecutionContext, 58004);
		Attribute__ctor_m45CAD4B01265CC84CC5A84F62EE2DBE85DE89EC0(__this, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 58004);
		CHECK_SEQ_POINT(methodExecutionContext, 58001);
		// className = clas.ToString();
		CHECK_SEQ_POINT(methodExecutionContext, 58002);
		Type_t * L_0 = ___clas0;
		STORE_SEQ_POINT(methodExecutionContext, 58005);
		NullCheck(L_0, il2cpp_codegen_get_sequence_point(58002));
		String_t* L_1 = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, L_0);
		CHECK_SEQ_POINT(methodExecutionContext, 58005);
		__this->set_className_1(L_1);
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 58003);
		return;
	}
}
// System.Void Pixeye.TagFieldAttribute::.ctor()
extern "C" IL2CPP_METHOD_ATTR void TagFieldAttribute__ctor_mC0BC1CB05E663416285FB3075485853B830412C1 (TagFieldAttribute_t44EBFA87585224B6D3C31F706F3CE1072F7C075D * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (TagFieldAttribute__ctor_mC0BC1CB05E663416285FB3075485853B830412C1_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, TagFieldAttribute__ctor_mC0BC1CB05E663416285FB3075485853B830412C1_RuntimeMethod_var, methodExecutionContextThis, NULL, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 58006);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 58007);
	{
		// public TagFieldAttribute() { }
		CHECK_SEQ_POINT(methodExecutionContext, 58008);
		STORE_SEQ_POINT(methodExecutionContext, 58011);
		Attribute__ctor_m45CAD4B01265CC84CC5A84F62EE2DBE85DE89EC0(__this, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 58011);
		CHECK_SEQ_POINT(methodExecutionContext, 58009);
		// public TagFieldAttribute() { }
		CHECK_SEQ_POINT(methodExecutionContext, 58010);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Type[] Pixeye.TagFilterAttribute::get_Type()
extern "C" IL2CPP_METHOD_ATTR TypeU5BU5D_t7FE623A666B49176DE123306221193E888A12F5F* TagFilterAttribute_get_Type_m91AD49C489EE8EF461DF823549C441E9F74EEE2C (TagFilterAttribute_tCFBF8A9A03FC22D02803646A5564ECD11A6E2276 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (TagFilterAttribute_get_Type_m91AD49C489EE8EF461DF823549C441E9F74EEE2C_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, TagFilterAttribute_get_Type_m91AD49C489EE8EF461DF823549C441E9F74EEE2C_RuntimeMethod_var, methodExecutionContextThis, NULL, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 58012);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 58013);
	{
		// public System.Type[] Type => tagType;
		CHECK_SEQ_POINT(methodExecutionContext, 58014);
		TypeU5BU5D_t7FE623A666B49176DE123306221193E888A12F5F* L_0 = __this->get_tagType_0();
		return L_0;
	}
}
// System.Void Pixeye.TagFilterAttribute::.ctor(System.Type[])
extern "C" IL2CPP_METHOD_ATTR void TagFilterAttribute__ctor_m61622BA04CE30CDC8286CFD9AFE2298BC5C1C830 (TagFilterAttribute_tCFBF8A9A03FC22D02803646A5564ECD11A6E2276 * __this, TypeU5BU5D_t7FE623A666B49176DE123306221193E888A12F5F* ___type0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (TagFilterAttribute__ctor_m61622BA04CE30CDC8286CFD9AFE2298BC5C1C830_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___type0));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, TagFilterAttribute__ctor_m61622BA04CE30CDC8286CFD9AFE2298BC5C1C830_RuntimeMethod_var, methodExecutionContextThis, methodExecutionContextParameters, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 58015);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 58016);
	{
		// public TagFilterAttribute(params System.Type[] type)
		CHECK_SEQ_POINT(methodExecutionContext, 58017);
		STORE_SEQ_POINT(methodExecutionContext, 58021);
		PropertyAttribute__ctor_m7F5C473F39D5601486C1127DA0D52F2DC293FC35(__this, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 58021);
		CHECK_SEQ_POINT(methodExecutionContext, 58018);
		// tagType = type;
		CHECK_SEQ_POINT(methodExecutionContext, 58019);
		TypeU5BU5D_t7FE623A666B49176DE123306221193E888A12F5F* L_0 = ___type0;
		__this->set_tagType_0(L_0);
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 58020);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Pixeye.Template::OnEnable()
extern "C" IL2CPP_METHOD_ATTR void Template_OnEnable_mA01BCE3BEE15DF82C5076784105F7A6172040420 (Template_t5107412B0F7996BE75F25FE9E22600F4E7DA2CA9 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Template_OnEnable_mA01BCE3BEE15DF82C5076784105F7A6172040420_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, Template_OnEnable_mA01BCE3BEE15DF82C5076784105F7A6172040420_RuntimeMethod_var, methodExecutionContextThis, NULL, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 59776);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 59777);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 59778);
		// storage.Clear();
		CHECK_SEQ_POINT(methodExecutionContext, 59779);
		Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884 * L_0 = __this->get_storage_4();
		STORE_SEQ_POINT(methodExecutionContext, 59782);
		NullCheck(L_0, il2cpp_codegen_get_sequence_point(59779));
		Dictionary_2_Clear_m8B31D0EA3C1FCE4C6977A76829773DA0D127E217(L_0, /*hidden argument*/Dictionary_2_Clear_m8B31D0EA3C1FCE4C6977A76829773DA0D127E217_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 59782);
		// Setup();
		CHECK_SEQ_POINT(methodExecutionContext, 59780);
		STORE_SEQ_POINT(methodExecutionContext, 59783);
		VirtActionInvoker0::Invoke(4 /* System.Void Pixeye.Template::Setup() */, __this);
		CHECK_SEQ_POINT(methodExecutionContext, 59783);
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 59781);
		return;
	}
}
// System.Void Pixeye.Template::Setup()
extern "C" IL2CPP_METHOD_ATTR void Template_Setup_m25AD47E5A5EBF061264FA737B03B6BD5FB482111 (Template_t5107412B0F7996BE75F25FE9E22600F4E7DA2CA9 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Template_Setup_m25AD47E5A5EBF061264FA737B03B6BD5FB482111_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, Template_Setup_m25AD47E5A5EBF061264FA737B03B6BD5FB482111_RuntimeMethod_var, methodExecutionContextThis, NULL, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 59784);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 59785);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 59786);
		// protected virtual void Setup() { }
		CHECK_SEQ_POINT(methodExecutionContext, 59787);
		return;
	}
}
// System.Void Pixeye.Template::.ctor()
extern "C" IL2CPP_METHOD_ATTR void Template__ctor_m32D7262047A32FFA3DF95D52245B00FA74CE2490 (Template_t5107412B0F7996BE75F25FE9E22600F4E7DA2CA9 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Template__ctor_m32D7262047A32FFA3DF95D52245B00FA74CE2490_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, Template__ctor_m32D7262047A32FFA3DF95D52245B00FA74CE2490_RuntimeMethod_var, methodExecutionContextThis, NULL, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 59819);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 59820);
	{
		// Dictionary<int, object> storage = new Dictionary<int, object>();
		CHECK_SEQ_POINT(methodExecutionContext, 59821);
		STORE_SEQ_POINT(methodExecutionContext, 59822);
		Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884 * L_0 = (Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884 *)il2cpp_codegen_object_new(Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884_il2cpp_TypeInfo_var);
		Dictionary_2__ctor_m7D745ADE56151C2895459668F4A4242985E526D8(L_0, /*hidden argument*/Dictionary_2__ctor_m7D745ADE56151C2895459668F4A4242985E526D8_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 59822);
		__this->set_storage_4(L_0);
		STORE_SEQ_POINT(methodExecutionContext, 59823);
		ScriptableObject__ctor_m6E2B3821A4A361556FC12E9B1C71E1D5DC002C5B(__this, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 59823);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Int32 Pixeye.Time::get_frame()
extern "C" IL2CPP_METHOD_ATTR int32_t Time_get_frame_m6D7BB007C0B65BB540A2D26C6CB7A853EA0BA36F (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Time_get_frame_m6D7BB007C0B65BB540A2D26C6CB7A853EA0BA36F_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, Time_get_frame_m6D7BB007C0B65BB540A2D26C6CB7A853EA0BA36F_RuntimeMethod_var, NULL, NULL, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 65168);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 65169);
	{
		// public static int frame => UnityEngine.Time.frameCount;
		CHECK_SEQ_POINT(methodExecutionContext, 65170);
		STORE_SEQ_POINT(methodExecutionContext, 65171);
		int32_t L_0 = Time_get_frameCount_m97573E267B487B8FD4BF37615AFC19BED7B4E436(/*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 65171);
		return L_0;
	}
}
// System.Single Pixeye.Time::get_delta()
extern "C" IL2CPP_METHOD_ATTR float Time_get_delta_m9AD3A71A628E62BF0E3A01D0E5A652DA9807585E (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Time_get_delta_m9AD3A71A628E62BF0E3A01D0E5A652DA9807585E_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, Time_get_delta_m9AD3A71A628E62BF0E3A01D0E5A652DA9807585E_RuntimeMethod_var, NULL, NULL, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 65172);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 65173);
	{
		// public static float delta => Default._deltaTime;
		CHECK_SEQ_POINT(methodExecutionContext, 65174);
		IL2CPP_RUNTIME_CLASS_INIT(Time_t70920BA2C4C4BE707DAE9822ED553B006FFC0100_il2cpp_TypeInfo_var);
		Time_t70920BA2C4C4BE707DAE9822ED553B006FFC0100 * L_0 = ((Time_t70920BA2C4C4BE707DAE9822ED553B006FFC0100_StaticFields*)il2cpp_codegen_static_fields_for(Time_t70920BA2C4C4BE707DAE9822ED553B006FFC0100_il2cpp_TypeInfo_var))->get_Default_1();
		NullCheck(L_0, il2cpp_codegen_get_sequence_point(65174));
		float L_1 = L_0->get__deltaTime_4();
		return L_1;
	}
}
// System.Single Pixeye.Time::get_deltaFixed()
extern "C" IL2CPP_METHOD_ATTR float Time_get_deltaFixed_mC41C8B31BC0F5F34522AF1B72CE977D5E07A490E (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Time_get_deltaFixed_mC41C8B31BC0F5F34522AF1B72CE977D5E07A490E_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, Time_get_deltaFixed_mC41C8B31BC0F5F34522AF1B72CE977D5E07A490E_RuntimeMethod_var, NULL, NULL, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 65175);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 65176);
	{
		// public static float deltaFixed => Default._deltaTimeFixed;
		CHECK_SEQ_POINT(methodExecutionContext, 65177);
		IL2CPP_RUNTIME_CLASS_INIT(Time_t70920BA2C4C4BE707DAE9822ED553B006FFC0100_il2cpp_TypeInfo_var);
		Time_t70920BA2C4C4BE707DAE9822ED553B006FFC0100 * L_0 = ((Time_t70920BA2C4C4BE707DAE9822ED553B006FFC0100_StaticFields*)il2cpp_codegen_static_fields_for(Time_t70920BA2C4C4BE707DAE9822ED553B006FFC0100_il2cpp_TypeInfo_var))->get_Default_1();
		NullCheck(L_0, il2cpp_codegen_get_sequence_point(65177));
		float L_1 = L_0->get__deltaTimeFixed_3();
		return L_1;
	}
}
// System.Void Pixeye.Time::.ctor()
extern "C" IL2CPP_METHOD_ATTR void Time__ctor_m3B49553DC238654DF564C95BE1F2C04A9AD0C22B (Time_t70920BA2C4C4BE707DAE9822ED553B006FFC0100 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Time__ctor_m3B49553DC238654DF564C95BE1F2C04A9AD0C22B_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, Time__ctor_m3B49553DC238654DF564C95BE1F2C04A9AD0C22B_RuntimeMethod_var, methodExecutionContextThis, NULL, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 65178);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 65179);
	{
		// public float timeScale = 1.0f;
		CHECK_SEQ_POINT(methodExecutionContext, 65180);
		__this->set_timeScale_2((1.0f));
		// internal float timeScaleCached = 1.0f;
		CHECK_SEQ_POINT(methodExecutionContext, 65181);
		__this->set_timeScaleCached_5((1.0f));
		// public Time()
		CHECK_SEQ_POINT(methodExecutionContext, 65182);
		STORE_SEQ_POINT(methodExecutionContext, 65188);
		Object__ctor_m925ECA5E85CA100E3FB86A4F9E15C120E9A184C0(__this, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 65188);
		CHECK_SEQ_POINT(methodExecutionContext, 65183);
		// HandleUpdate.Default.Add(this);
		CHECK_SEQ_POINT(methodExecutionContext, 65184);
		HandleUpdate_t2060842DBF2069E5F3DD3C37B41CA77A1C7B78A3 * L_0 = ((HandleUpdate_t2060842DBF2069E5F3DD3C37B41CA77A1C7B78A3_StaticFields*)il2cpp_codegen_static_fields_for(HandleUpdate_t2060842DBF2069E5F3DD3C37B41CA77A1C7B78A3_il2cpp_TypeInfo_var))->get_Default_7();
		STORE_SEQ_POINT(methodExecutionContext, 65189);
		NullCheck(L_0, il2cpp_codegen_get_sequence_point(65184));
		HandleUpdate_Add_m06660D0523D78FD04AD4031ECABFE86BB6EB2FC8(L_0, __this, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 65189);
		// _deltaTimeFixed = 1 / fps;
		CHECK_SEQ_POINT(methodExecutionContext, 65185);
		__this->set__deltaTimeFixed_3((0.0166666675f));
		// _deltaTime = _deltaTimeFixed;
		CHECK_SEQ_POINT(methodExecutionContext, 65186);
		float L_1 = __this->get__deltaTimeFixed_3();
		__this->set__deltaTime_4(L_1);
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 65187);
		return;
	}
}
// System.Void Pixeye.Time::Tick()
extern "C" IL2CPP_METHOD_ATTR void Time_Tick_m0AB7869FDF59F349A0C18C983C0E58BE0448747A (Time_t70920BA2C4C4BE707DAE9822ED553B006FFC0100 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Time_Tick_m0AB7869FDF59F349A0C18C983C0E58BE0448747A_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, Time_Tick_m0AB7869FDF59F349A0C18C983C0E58BE0448747A_RuntimeMethod_var, methodExecutionContextThis, NULL, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 65190);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 65191);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 65192);
		// _deltaTime = UnityEngine.Time.unscaledDeltaTime * timeScale;
		CHECK_SEQ_POINT(methodExecutionContext, 65193);
		STORE_SEQ_POINT(methodExecutionContext, 65196);
		float L_0 = Time_get_unscaledDeltaTime_mA0AE7A144C88AE8AABB42DF17B0F3F0714BA06B2(/*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 65196);
		float L_1 = __this->get_timeScale_2();
		__this->set__deltaTime_4(((float)il2cpp_codegen_multiply((float)L_0, (float)L_1)));
		// _deltaTimeFixed *= timeScale;
		CHECK_SEQ_POINT(methodExecutionContext, 65194);
		float L_2 = __this->get__deltaTimeFixed_3();
		float L_3 = __this->get_timeScale_2();
		__this->set__deltaTimeFixed_3(((float)il2cpp_codegen_multiply((float)L_2, (float)L_3)));
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 65195);
		return;
	}
}
// System.Void Pixeye.Time::.cctor()
extern "C" IL2CPP_METHOD_ATTR void Time__cctor_m606A834823814E855B8A17EB1B6D987F86C5CFFF (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Time__cctor_m606A834823814E855B8A17EB1B6D987F86C5CFFF_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, Time__cctor_m606A834823814E855B8A17EB1B6D987F86C5CFFF_RuntimeMethod_var, NULL, NULL, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 65197);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 65198);
	{
		// public static Time Default = new Time();
		CHECK_SEQ_POINT(methodExecutionContext, 65199);
		STORE_SEQ_POINT(methodExecutionContext, 65200);
		Time_t70920BA2C4C4BE707DAE9822ED553B006FFC0100 * L_0 = (Time_t70920BA2C4C4BE707DAE9822ED553B006FFC0100 *)il2cpp_codegen_object_new(Time_t70920BA2C4C4BE707DAE9822ED553B006FFC0100_il2cpp_TypeInfo_var);
		Time__ctor_m3B49553DC238654DF564C95BE1F2C04A9AD0C22B(L_0, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 65200);
		((Time_t70920BA2C4C4BE707DAE9822ED553B006FFC0100_StaticFields*)il2cpp_codegen_static_fields_for(Time_t70920BA2C4C4BE707DAE9822ED553B006FFC0100_il2cpp_TypeInfo_var))->set_Default_1(L_0);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Boolean Pixeye.Timer::get_IsRunning()
extern "C" IL2CPP_METHOD_ATTR bool Timer_get_IsRunning_m8FE712A6CD64FC8FC037D142ADC3EADE57871FE9 (Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Timer_get_IsRunning_m8FE712A6CD64FC8FC037D142ADC3EADE57871FE9_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, Timer_get_IsRunning_m8FE712A6CD64FC8FC037D142ADC3EADE57871FE9_RuntimeMethod_var, methodExecutionContextThis, NULL, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 65201);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 65202);
	{
		// public bool IsRunning { get; set; }
		CHECK_SEQ_POINT(methodExecutionContext, 65203);
		bool L_0 = __this->get_U3CIsRunningU3Ek__BackingField_6();
		return L_0;
	}
}
// System.Void Pixeye.Timer::set_IsRunning(System.Boolean)
extern "C" IL2CPP_METHOD_ATTR void Timer_set_IsRunning_m9AA3554B76F6EB4CD9722620479886E61A599986 (Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * __this, bool ___value0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Timer_set_IsRunning_m9AA3554B76F6EB4CD9722620479886E61A599986_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___value0));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, Timer_set_IsRunning_m9AA3554B76F6EB4CD9722620479886E61A599986_RuntimeMethod_var, methodExecutionContextThis, methodExecutionContextParameters, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 65204);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 65205);
	{
		// public bool IsRunning { get; set; }
		CHECK_SEQ_POINT(methodExecutionContext, 65206);
		bool L_0 = ___value0;
		__this->set_U3CIsRunningU3Ek__BackingField_6(L_0);
		return;
	}
}
// System.Boolean Pixeye.Timer::FindAllTimers(System.Int32,System.Int32,System.Collections.Generic.List`1<Pixeye.Timer>U26)
extern "C" IL2CPP_METHOD_ATTR bool Timer_FindAllTimers_m24C54633D77906904C96B78DFCBB26CC41DF681B (int32_t ___entity0, int32_t ___state1, List_1_t613852693859B0156A22267D914D17B30CFDE8F1 ** ___timers2, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Timer_FindAllTimers_m24C54633D77906904C96B78DFCBB26CC41DF681B_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	TimerKey_tCE6BF602B11E3FE849B05CC16BE0650A88755F89  V_0;
	memset(&V_0, 0, sizeof(V_0));
	bool V_1 = false;
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___entity0), (&___state1), (&___timers2));
	DECLARE_METHOD_LOCALS(methodExecutionContextLocals, (&V_0));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, Timer_FindAllTimers_m24C54633D77906904C96B78DFCBB26CC41DF681B_RuntimeMethod_var, NULL, methodExecutionContextParameters, methodExecutionContextLocals);
	CHECK_SEQ_POINT(methodExecutionContext, 65207);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 65208);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 65209);
		// key.entity = entity;
		CHECK_SEQ_POINT(methodExecutionContext, 65210);
		int32_t L_0 = ___entity0;
		(&V_0)->set_entity_0(L_0);
		// key.state = state;
		CHECK_SEQ_POINT(methodExecutionContext, 65211);
		int32_t L_1 = ___state1;
		(&V_0)->set_state_1(L_1);
		// return cachedTimers.TryGetValue(key, out timers);
		CHECK_SEQ_POINT(methodExecutionContext, 65212);
		IL2CPP_RUNTIME_CLASS_INIT(Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA_il2cpp_TypeInfo_var);
		Dictionary_2_t7A0A951F2ACBA1FC50C942EC15413C2011C7B386 * L_2 = ((Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA_StaticFields*)il2cpp_codegen_static_fields_for(Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA_il2cpp_TypeInfo_var))->get_cachedTimers_0();
		TimerKey_tCE6BF602B11E3FE849B05CC16BE0650A88755F89  L_3 = V_0;
		List_1_t613852693859B0156A22267D914D17B30CFDE8F1 ** L_4 = ___timers2;
		STORE_SEQ_POINT(methodExecutionContext, 65214);
		NullCheck(L_2, il2cpp_codegen_get_sequence_point(65212));
		bool L_5 = Dictionary_2_TryGetValue_m2AB95C81F55348A9264B1599CF302BF7D6A45673(L_2, L_3, (List_1_t613852693859B0156A22267D914D17B30CFDE8F1 **)L_4, /*hidden argument*/Dictionary_2_TryGetValue_m2AB95C81F55348A9264B1599CF302BF7D6A45673_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 65214);
		V_1 = L_5;
		goto IL_0020;
	}

IL_0020:
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 65213);
		bool L_6 = V_1;
		return L_6;
	}
}
// Pixeye.Timer Pixeye.Timer::Add(System.Single,System.Action)
extern "C" IL2CPP_METHOD_ATTR Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * Timer_Add_mFA7866CEC7552E59E915183E6405C77CFAA61207 (float ___finishTime0, Action_t591D2A86165F896B4B800BB5C25CE18672A55579 * ___action1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Timer_Add_mFA7866CEC7552E59E915183E6405C77CFAA61207_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * V_0 = NULL;
	bool V_1 = false;
	Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * V_2 = NULL;
	bool V_3 = false;
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___finishTime0), (&___action1));
	DECLARE_METHOD_LOCALS(methodExecutionContextLocals, (&V_0));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, Timer_Add_mFA7866CEC7552E59E915183E6405C77CFAA61207_RuntimeMethod_var, NULL, methodExecutionContextParameters, methodExecutionContextLocals);
	CHECK_SEQ_POINT(methodExecutionContext, 65215);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 65216);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 65217);
		// if (finishTime == 0)
		CHECK_SEQ_POINT(methodExecutionContext, 65218);
		float L_0 = ___finishTime0;
		V_1 = (bool)((((float)L_0) == ((float)(0.0f)))? 1 : 0);
		CHECK_SEQ_POINT(methodExecutionContext, 65219);
		bool L_1 = V_1;
		if (!L_1)
		{
			goto IL_0019;
		}
	}
	{
		CHECK_SEQ_POINT(methodExecutionContext, 65220);
		// action();
		CHECK_SEQ_POINT(methodExecutionContext, 65221);
		Action_t591D2A86165F896B4B800BB5C25CE18672A55579 * L_2 = ___action1;
		STORE_SEQ_POINT(methodExecutionContext, 65232);
		NullCheck(L_2, il2cpp_codegen_get_sequence_point(65221));
		Action_Invoke_mC8D676E5DDF967EC5D23DD0E96FB52AA499817FD(L_2, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 65232);
		// return null;
		CHECK_SEQ_POINT(methodExecutionContext, 65222);
		V_2 = (Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA *)NULL;
		goto IL_0044;
	}

IL_0019:
	{
		// var timer = new Timer();
		CHECK_SEQ_POINT(methodExecutionContext, 65223);
		STORE_SEQ_POINT(methodExecutionContext, 65233);
		Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * L_3 = (Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA *)il2cpp_codegen_object_new(Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA_il2cpp_TypeInfo_var);
		Timer__ctor_mA49C1E2BEBA494C51B822123E4F43E7FD41E69D0(L_3, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 65233);
		V_0 = L_3;
		// timer.finishTime = finishTime;
		CHECK_SEQ_POINT(methodExecutionContext, 65224);
		Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * L_4 = V_0;
		float L_5 = ___finishTime0;
		NullCheck(L_4, il2cpp_codegen_get_sequence_point(65224));
		L_4->set_finishTime_2(L_5);
		// if (action == null) return timer;
		CHECK_SEQ_POINT(methodExecutionContext, 65225);
		Action_t591D2A86165F896B4B800BB5C25CE18672A55579 * L_6 = ___action1;
		V_3 = (bool)((((RuntimeObject*)(Action_t591D2A86165F896B4B800BB5C25CE18672A55579 *)L_6) == ((RuntimeObject*)(RuntimeObject *)NULL))? 1 : 0);
		CHECK_SEQ_POINT(methodExecutionContext, 65226);
		bool L_7 = V_3;
		if (!L_7)
		{
			goto IL_0032;
		}
	}
	{
		// if (action == null) return timer;
		CHECK_SEQ_POINT(methodExecutionContext, 65227);
		Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * L_8 = V_0;
		V_2 = L_8;
		goto IL_0044;
	}

IL_0032:
	{
		// timer.callBackAction = action;
		CHECK_SEQ_POINT(methodExecutionContext, 65228);
		Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * L_9 = V_0;
		Action_t591D2A86165F896B4B800BB5C25CE18672A55579 * L_10 = ___action1;
		NullCheck(L_9, il2cpp_codegen_get_sequence_point(65228));
		L_9->set_callBackAction_4(L_10);
		// timer.Play();
		CHECK_SEQ_POINT(methodExecutionContext, 65229);
		Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * L_11 = V_0;
		STORE_SEQ_POINT(methodExecutionContext, 65234);
		NullCheck(L_11, il2cpp_codegen_get_sequence_point(65229));
		Timer_Play_mB651AAAAE2F539E862FC75DB62C78B1641B8069A(L_11, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 65234);
		// return timer;
		CHECK_SEQ_POINT(methodExecutionContext, 65230);
		Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * L_12 = V_0;
		V_2 = L_12;
		goto IL_0044;
	}

IL_0044:
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 65231);
		Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * L_13 = V_2;
		return L_13;
	}
}
// System.Void Pixeye.Timer::.ctor()
extern "C" IL2CPP_METHOD_ATTR void Timer__ctor_mA49C1E2BEBA494C51B822123E4F43E7FD41E69D0 (Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Timer__ctor_mA49C1E2BEBA494C51B822123E4F43E7FD41E69D0_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, Timer__ctor_mA49C1E2BEBA494C51B822123E4F43E7FD41E69D0_RuntimeMethod_var, methodExecutionContextThis, NULL, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 65235);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 65236);
	{
		// public float timeScale = 1;
		CHECK_SEQ_POINT(methodExecutionContext, 65237);
		__this->set_timeScale_3((1.0f));
		// public bool isAutoKill = true;
		CHECK_SEQ_POINT(methodExecutionContext, 65238);
		__this->set_isAutoKill_5((bool)1);
		// public Timer()
		CHECK_SEQ_POINT(methodExecutionContext, 65239);
		STORE_SEQ_POINT(methodExecutionContext, 65242);
		Object__ctor_m925ECA5E85CA100E3FB86A4F9E15C120E9A184C0(__this, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 65242);
		CHECK_SEQ_POINT(methodExecutionContext, 65240);
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 65241);
		return;
	}
}
// System.Void Pixeye.Timer::.ctor(System.Action,System.Single,System.Boolean)
extern "C" IL2CPP_METHOD_ATTR void Timer__ctor_m110E02B64865D564EEC131D008E1B63F8C17ABA5 (Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * __this, Action_t591D2A86165F896B4B800BB5C25CE18672A55579 * ___callBackAction0, float ___finishTime1, bool ___isAutoKill2, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Timer__ctor_m110E02B64865D564EEC131D008E1B63F8C17ABA5_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___callBackAction0), (&___finishTime1), (&___isAutoKill2));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, Timer__ctor_m110E02B64865D564EEC131D008E1B63F8C17ABA5_RuntimeMethod_var, methodExecutionContextThis, methodExecutionContextParameters, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 65243);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 65244);
	{
		// public float timeScale = 1;
		CHECK_SEQ_POINT(methodExecutionContext, 65245);
		__this->set_timeScale_3((1.0f));
		// public bool isAutoKill = true;
		CHECK_SEQ_POINT(methodExecutionContext, 65246);
		__this->set_isAutoKill_5((bool)1);
		// public Timer(Action callBackAction, float finishTime, bool isAutoKill = false)
		CHECK_SEQ_POINT(methodExecutionContext, 65247);
		STORE_SEQ_POINT(methodExecutionContext, 65254);
		Object__ctor_m925ECA5E85CA100E3FB86A4F9E15C120E9A184C0(__this, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 65254);
		CHECK_SEQ_POINT(methodExecutionContext, 65248);
		// this.isAutoKill = isAutoKill;
		CHECK_SEQ_POINT(methodExecutionContext, 65249);
		bool L_0 = ___isAutoKill2;
		__this->set_isAutoKill_5(L_0);
		// this.finishTime = finishTime;
		CHECK_SEQ_POINT(methodExecutionContext, 65250);
		float L_1 = ___finishTime1;
		__this->set_finishTime_2(L_1);
		// this.callBackAction = callBackAction;
		CHECK_SEQ_POINT(methodExecutionContext, 65251);
		Action_t591D2A86165F896B4B800BB5C25CE18672A55579 * L_2 = ___callBackAction0;
		__this->set_callBackAction_4(L_2);
		// timer = 0.0f;
		CHECK_SEQ_POINT(methodExecutionContext, 65252);
		__this->set_timer_1((0.0f));
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 65253);
		return;
	}
}
// Pixeye.Timer Pixeye.Timer::AddID(System.Int32,System.Int32)
extern "C" IL2CPP_METHOD_ATTR Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * Timer_AddID_mF75BF469BE1DCFC9D1EC91217E52F03354CB8122 (Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * __this, int32_t ___entity0, int32_t ___state1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Timer_AddID_mF75BF469BE1DCFC9D1EC91217E52F03354CB8122_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	TimerKey_tCE6BF602B11E3FE849B05CC16BE0650A88755F89  V_0;
	memset(&V_0, 0, sizeof(V_0));
	List_1_t613852693859B0156A22267D914D17B30CFDE8F1 * V_1 = NULL;
	bool V_2 = false;
	Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * V_3 = NULL;
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___entity0), (&___state1));
	DECLARE_METHOD_LOCALS(methodExecutionContextLocals, (&V_0), (&V_1));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, Timer_AddID_mF75BF469BE1DCFC9D1EC91217E52F03354CB8122_RuntimeMethod_var, methodExecutionContextThis, methodExecutionContextParameters, methodExecutionContextLocals);
	CHECK_SEQ_POINT(methodExecutionContext, 65255);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 65256);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 65257);
		// key.entity = entity;
		CHECK_SEQ_POINT(methodExecutionContext, 65258);
		int32_t L_0 = ___entity0;
		(&V_0)->set_entity_0(L_0);
		// key.state = state;
		CHECK_SEQ_POINT(methodExecutionContext, 65259);
		int32_t L_1 = ___state1;
		(&V_0)->set_state_1(L_1);
		// if (cachedTimers.TryGetValue(key, out timers))
		CHECK_SEQ_POINT(methodExecutionContext, 65260);
		IL2CPP_RUNTIME_CLASS_INIT(Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA_il2cpp_TypeInfo_var);
		Dictionary_2_t7A0A951F2ACBA1FC50C942EC15413C2011C7B386 * L_2 = ((Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA_StaticFields*)il2cpp_codegen_static_fields_for(Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA_il2cpp_TypeInfo_var))->get_cachedTimers_0();
		TimerKey_tCE6BF602B11E3FE849B05CC16BE0650A88755F89  L_3 = V_0;
		STORE_SEQ_POINT(methodExecutionContext, 65270);
		NullCheck(L_2, il2cpp_codegen_get_sequence_point(65260));
		bool L_4 = Dictionary_2_TryGetValue_m2AB95C81F55348A9264B1599CF302BF7D6A45673(L_2, L_3, (List_1_t613852693859B0156A22267D914D17B30CFDE8F1 **)(&V_1), /*hidden argument*/Dictionary_2_TryGetValue_m2AB95C81F55348A9264B1599CF302BF7D6A45673_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 65270);
		V_2 = L_4;
		CHECK_SEQ_POINT(methodExecutionContext, 65261);
		bool L_5 = V_2;
		if (!L_5)
		{
			goto IL_002e;
		}
	}
	{
		CHECK_SEQ_POINT(methodExecutionContext, 65262);
		// timers.Add(this);
		CHECK_SEQ_POINT(methodExecutionContext, 65263);
		List_1_t613852693859B0156A22267D914D17B30CFDE8F1 * L_6 = V_1;
		STORE_SEQ_POINT(methodExecutionContext, 65271);
		NullCheck(L_6, il2cpp_codegen_get_sequence_point(65263));
		List_1_Add_m427CEBFF4473B9FF133591A38714298FA2E4BF08(L_6, __this, /*hidden argument*/List_1_Add_m427CEBFF4473B9FF133591A38714298FA2E4BF08_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 65271);
		CHECK_SEQ_POINT(methodExecutionContext, 65264);
		goto IL_004b;
	}

IL_002e:
	{
		CHECK_SEQ_POINT(methodExecutionContext, 65265);
		// cachedTimers.Add(key, new List<Timer>(10) {this});
		CHECK_SEQ_POINT(methodExecutionContext, 65266);
		IL2CPP_RUNTIME_CLASS_INIT(Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA_il2cpp_TypeInfo_var);
		Dictionary_2_t7A0A951F2ACBA1FC50C942EC15413C2011C7B386 * L_7 = ((Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA_StaticFields*)il2cpp_codegen_static_fields_for(Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA_il2cpp_TypeInfo_var))->get_cachedTimers_0();
		TimerKey_tCE6BF602B11E3FE849B05CC16BE0650A88755F89  L_8 = V_0;
		STORE_SEQ_POINT(methodExecutionContext, 65272);
		List_1_t613852693859B0156A22267D914D17B30CFDE8F1 * L_9 = (List_1_t613852693859B0156A22267D914D17B30CFDE8F1 *)il2cpp_codegen_object_new(List_1_t613852693859B0156A22267D914D17B30CFDE8F1_il2cpp_TypeInfo_var);
		List_1__ctor_mABE1F8A5C40A227414A1BAC86E92EDD953F86FC1(L_9, ((int32_t)10), /*hidden argument*/List_1__ctor_mABE1F8A5C40A227414A1BAC86E92EDD953F86FC1_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 65272);
		List_1_t613852693859B0156A22267D914D17B30CFDE8F1 * L_10 = L_9;
		STORE_SEQ_POINT(methodExecutionContext, 65273);
		NullCheck(L_10, il2cpp_codegen_get_sequence_point(65266));
		List_1_Add_m427CEBFF4473B9FF133591A38714298FA2E4BF08(L_10, __this, /*hidden argument*/List_1_Add_m427CEBFF4473B9FF133591A38714298FA2E4BF08_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 65273);
		STORE_SEQ_POINT(methodExecutionContext, 65274);
		NullCheck(L_7, il2cpp_codegen_get_sequence_point(65266));
		Dictionary_2_Add_m6E61563D097FC91BEA0AB0B64E9B47ED7FA8667F(L_7, L_8, L_10, /*hidden argument*/Dictionary_2_Add_m6E61563D097FC91BEA0AB0B64E9B47ED7FA8667F_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 65274);
		CHECK_SEQ_POINT(methodExecutionContext, 65267);
	}

IL_004b:
	{
		// return this;
		CHECK_SEQ_POINT(methodExecutionContext, 65268);
		V_3 = __this;
		goto IL_004f;
	}

IL_004f:
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 65269);
		Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * L_11 = V_3;
		return L_11;
	}
}
// System.Void Pixeye.Timer::Stop(Pixeye.Timer)
extern "C" IL2CPP_METHOD_ATTR void Timer_Stop_m70B9AEC7527FE1E55839D48BF815404834F6ABC8 (Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * ___obj0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Timer_Stop_m70B9AEC7527FE1E55839D48BF815404834F6ABC8_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___obj0));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, Timer_Stop_m70B9AEC7527FE1E55839D48BF815404834F6ABC8_RuntimeMethod_var, NULL, methodExecutionContextParameters, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 65275);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 65276);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 65277);
		// if (obj == null) return;
		CHECK_SEQ_POINT(methodExecutionContext, 65278);
		Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * L_0 = ___obj0;
		V_0 = (bool)((((RuntimeObject*)(Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA *)L_0) == ((RuntimeObject*)(RuntimeObject *)NULL))? 1 : 0);
		CHECK_SEQ_POINT(methodExecutionContext, 65279);
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_000b;
		}
	}
	{
		// if (obj == null) return;
		CHECK_SEQ_POINT(methodExecutionContext, 65280);
		goto IL_0012;
	}

IL_000b:
	{
		// obj.Stop();
		CHECK_SEQ_POINT(methodExecutionContext, 65281);
		Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * L_2 = ___obj0;
		STORE_SEQ_POINT(methodExecutionContext, 65283);
		NullCheck(L_2, il2cpp_codegen_get_sequence_point(65281));
		Timer_Stop_m67DB897B6F803C7E8D24861682C3965EE7D94636(L_2, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 65283);
	}

IL_0012:
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 65282);
		return;
	}
}
// System.Void Pixeye.Timer::Release(Pixeye.Timer)
extern "C" IL2CPP_METHOD_ATTR void Timer_Release_m149B5E117807CA56D6E1FE89E6A19B45DD7FCE31 (Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * ___obj0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Timer_Release_m149B5E117807CA56D6E1FE89E6A19B45DD7FCE31_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	bool V_1 = false;
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___obj0));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, Timer_Release_m149B5E117807CA56D6E1FE89E6A19B45DD7FCE31_RuntimeMethod_var, NULL, methodExecutionContextParameters, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 65284);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 65285);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 65286);
		// if (obj == null) return;
		CHECK_SEQ_POINT(methodExecutionContext, 65287);
		Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * L_0 = ___obj0;
		V_0 = (bool)((((RuntimeObject*)(Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA *)L_0) == ((RuntimeObject*)(RuntimeObject *)NULL))? 1 : 0);
		CHECK_SEQ_POINT(methodExecutionContext, 65288);
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_000b;
		}
	}
	{
		// if (obj == null) return;
		CHECK_SEQ_POINT(methodExecutionContext, 65289);
		goto IL_001d;
	}

IL_000b:
	{
		// if (Toolbox.applicationIsQuitting) return;
		CHECK_SEQ_POINT(methodExecutionContext, 65290);
		IL2CPP_RUNTIME_CLASS_INIT(Singleton_1_t70D00C90A652BD47B1B663FC32A13A31E56C12C6_il2cpp_TypeInfo_var);
		bool L_2 = ((Singleton_1_t70D00C90A652BD47B1B663FC32A13A31E56C12C6_StaticFields*)il2cpp_codegen_static_fields_for(Singleton_1_t70D00C90A652BD47B1B663FC32A13A31E56C12C6_il2cpp_TypeInfo_var))->get_applicationIsQuitting_7();
		V_1 = L_2;
		CHECK_SEQ_POINT(methodExecutionContext, 65291);
		bool L_3 = V_1;
		if (!L_3)
		{
			goto IL_0016;
		}
	}
	{
		// if (Toolbox.applicationIsQuitting) return;
		CHECK_SEQ_POINT(methodExecutionContext, 65292);
		goto IL_001d;
	}

IL_0016:
	{
		// obj.Dispose();
		CHECK_SEQ_POINT(methodExecutionContext, 65293);
		Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * L_4 = ___obj0;
		STORE_SEQ_POINT(methodExecutionContext, 65295);
		NullCheck(L_4, il2cpp_codegen_get_sequence_point(65293));
		Timer_Dispose_m8E57793C983E49F48EE17D66614532581624D71C(L_4, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 65295);
	}

IL_001d:
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 65294);
		return;
	}
}
// System.Void Pixeye.Timer::Stop()
extern "C" IL2CPP_METHOD_ATTR void Timer_Stop_m67DB897B6F803C7E8D24861682C3965EE7D94636 (Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Timer_Stop_m67DB897B6F803C7E8D24861682C3965EE7D94636_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, Timer_Stop_m67DB897B6F803C7E8D24861682C3965EE7D94636_RuntimeMethod_var, methodExecutionContextThis, NULL, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 65296);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 65297);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 65298);
		// HandleUpdate.Default.Remove(this);
		CHECK_SEQ_POINT(methodExecutionContext, 65299);
		HandleUpdate_t2060842DBF2069E5F3DD3C37B41CA77A1C7B78A3 * L_0 = ((HandleUpdate_t2060842DBF2069E5F3DD3C37B41CA77A1C7B78A3_StaticFields*)il2cpp_codegen_static_fields_for(HandleUpdate_t2060842DBF2069E5F3DD3C37B41CA77A1C7B78A3_il2cpp_TypeInfo_var))->get_Default_7();
		STORE_SEQ_POINT(methodExecutionContext, 65304);
		NullCheck(L_0, il2cpp_codegen_get_sequence_point(65299));
		HandleUpdate_Remove_m08C15D88B167205B0196A4D39DD82742B901AE53(L_0, __this, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 65304);
		// HandleTimer.Default.allWorkingTimers.Remove(this);
		CHECK_SEQ_POINT(methodExecutionContext, 65300);
		IL2CPP_RUNTIME_CLASS_INIT(HandleTimer_tE0613FB7A046C7560F75BD4908092FA5A2260483_il2cpp_TypeInfo_var);
		HandleTimer_tE0613FB7A046C7560F75BD4908092FA5A2260483 * L_1 = ((HandleTimer_tE0613FB7A046C7560F75BD4908092FA5A2260483_StaticFields*)il2cpp_codegen_static_fields_for(HandleTimer_tE0613FB7A046C7560F75BD4908092FA5A2260483_il2cpp_TypeInfo_var))->get_Default_0();
		NullCheck(L_1, il2cpp_codegen_get_sequence_point(65300));
		List_1_t613852693859B0156A22267D914D17B30CFDE8F1 * L_2 = L_1->get_allWorkingTimers_1();
		STORE_SEQ_POINT(methodExecutionContext, 65305);
		NullCheck(L_2, il2cpp_codegen_get_sequence_point(65300));
		List_1_Remove_m2E8533F833815BDD8176A0DBC27DFCCDC8120FE6(L_2, __this, /*hidden argument*/List_1_Remove_m2E8533F833815BDD8176A0DBC27DFCCDC8120FE6_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 65305);
		// IsRunning = false;
		CHECK_SEQ_POINT(methodExecutionContext, 65301);
		STORE_SEQ_POINT(methodExecutionContext, 65306);
		Timer_set_IsRunning_m9AA3554B76F6EB4CD9722620479886E61A599986(__this, (bool)0, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 65306);
		// timer = 0.0f;
		CHECK_SEQ_POINT(methodExecutionContext, 65302);
		__this->set_timer_1((0.0f));
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 65303);
		return;
	}
}
// Pixeye.Timer Pixeye.Timer::SetTimeScale(System.Single)
extern "C" IL2CPP_METHOD_ATTR Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * Timer_SetTimeScale_m147642252A783B8D95C5EF479AA50D426C97EB06 (Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * __this, float ___timeScale0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Timer_SetTimeScale_m147642252A783B8D95C5EF479AA50D426C97EB06_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * V_0 = NULL;
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___timeScale0));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, Timer_SetTimeScale_m147642252A783B8D95C5EF479AA50D426C97EB06_RuntimeMethod_var, methodExecutionContextThis, methodExecutionContextParameters, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 65307);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 65308);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 65309);
		// this.timeScale = timeScale;
		CHECK_SEQ_POINT(methodExecutionContext, 65310);
		float L_0 = ___timeScale0;
		__this->set_timeScale_3(L_0);
		// return this;
		CHECK_SEQ_POINT(methodExecutionContext, 65311);
		V_0 = __this;
		goto IL_000c;
	}

IL_000c:
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 65312);
		Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * L_1 = V_0;
		return L_1;
	}
}
// Pixeye.Timer Pixeye.Timer::Play()
extern "C" IL2CPP_METHOD_ATTR Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * Timer_Play_mB651AAAAE2F539E862FC75DB62C78B1641B8069A (Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Timer_Play_mB651AAAAE2F539E862FC75DB62C78B1641B8069A_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * V_0 = NULL;
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, Timer_Play_mB651AAAAE2F539E862FC75DB62C78B1641B8069A_RuntimeMethod_var, methodExecutionContextThis, NULL, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 65313);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 65314);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 65315);
		// timer = 0.0f;
		CHECK_SEQ_POINT(methodExecutionContext, 65316);
		__this->set_timer_1((0.0f));
		// IsRunning = true;
		CHECK_SEQ_POINT(methodExecutionContext, 65317);
		STORE_SEQ_POINT(methodExecutionContext, 65322);
		Timer_set_IsRunning_m9AA3554B76F6EB4CD9722620479886E61A599986(__this, (bool)1, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 65322);
		// HandleTimer.Default.allWorkingTimers.Add(this);
		CHECK_SEQ_POINT(methodExecutionContext, 65318);
		IL2CPP_RUNTIME_CLASS_INIT(HandleTimer_tE0613FB7A046C7560F75BD4908092FA5A2260483_il2cpp_TypeInfo_var);
		HandleTimer_tE0613FB7A046C7560F75BD4908092FA5A2260483 * L_0 = ((HandleTimer_tE0613FB7A046C7560F75BD4908092FA5A2260483_StaticFields*)il2cpp_codegen_static_fields_for(HandleTimer_tE0613FB7A046C7560F75BD4908092FA5A2260483_il2cpp_TypeInfo_var))->get_Default_0();
		NullCheck(L_0, il2cpp_codegen_get_sequence_point(65318));
		List_1_t613852693859B0156A22267D914D17B30CFDE8F1 * L_1 = L_0->get_allWorkingTimers_1();
		STORE_SEQ_POINT(methodExecutionContext, 65323);
		NullCheck(L_1, il2cpp_codegen_get_sequence_point(65318));
		List_1_Add_m427CEBFF4473B9FF133591A38714298FA2E4BF08(L_1, __this, /*hidden argument*/List_1_Add_m427CEBFF4473B9FF133591A38714298FA2E4BF08_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 65323);
		// HandleUpdate.Default.Add(this);
		CHECK_SEQ_POINT(methodExecutionContext, 65319);
		HandleUpdate_t2060842DBF2069E5F3DD3C37B41CA77A1C7B78A3 * L_2 = ((HandleUpdate_t2060842DBF2069E5F3DD3C37B41CA77A1C7B78A3_StaticFields*)il2cpp_codegen_static_fields_for(HandleUpdate_t2060842DBF2069E5F3DD3C37B41CA77A1C7B78A3_il2cpp_TypeInfo_var))->get_Default_7();
		STORE_SEQ_POINT(methodExecutionContext, 65324);
		NullCheck(L_2, il2cpp_codegen_get_sequence_point(65319));
		HandleUpdate_Add_m06660D0523D78FD04AD4031ECABFE86BB6EB2FC8(L_2, __this, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 65324);
		// return this;
		CHECK_SEQ_POINT(methodExecutionContext, 65320);
		V_0 = __this;
		goto IL_0035;
	}

IL_0035:
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 65321);
		Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * L_3 = V_0;
		return L_3;
	}
}
// Pixeye.Timer Pixeye.Timer::Restart(System.Single)
extern "C" IL2CPP_METHOD_ATTR Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * Timer_Restart_m3DB9882F8B6959F0E89FF55E0424E25FC784416C (Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * __this, float ___finishTime0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Timer_Restart_m3DB9882F8B6959F0E89FF55E0424E25FC784416C_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	bool V_1 = false;
	Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * V_2 = NULL;
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___finishTime0));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, Timer_Restart_m3DB9882F8B6959F0E89FF55E0424E25FC784416C_RuntimeMethod_var, methodExecutionContextThis, methodExecutionContextParameters, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 65325);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 65326);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 65327);
		// if (finishTime != 0.0f)
		CHECK_SEQ_POINT(methodExecutionContext, 65328);
		float L_0 = ___finishTime0;
		V_0 = (bool)((((int32_t)((((float)L_0) == ((float)(0.0f)))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		CHECK_SEQ_POINT(methodExecutionContext, 65329);
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_0017;
		}
	}
	{
		// this.finishTime = finishTime;
		CHECK_SEQ_POINT(methodExecutionContext, 65330);
		float L_2 = ___finishTime0;
		__this->set_finishTime_2(L_2);
	}

IL_0017:
	{
		// if (timer > 0)
		CHECK_SEQ_POINT(methodExecutionContext, 65331);
		float L_3 = __this->get_timer_1();
		V_1 = (bool)((((float)L_3) > ((float)(0.0f)))? 1 : 0);
		CHECK_SEQ_POINT(methodExecutionContext, 65332);
		bool L_4 = V_1;
		if (!L_4)
		{
			goto IL_0040;
		}
	}
	{
		CHECK_SEQ_POINT(methodExecutionContext, 65333);
		// timer = 0.0f;
		CHECK_SEQ_POINT(methodExecutionContext, 65334);
		__this->set_timer_1((0.0f));
		// IsRunning = true;
		CHECK_SEQ_POINT(methodExecutionContext, 65335);
		STORE_SEQ_POINT(methodExecutionContext, 65343);
		Timer_set_IsRunning_m9AA3554B76F6EB4CD9722620479886E61A599986(__this, (bool)1, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 65343);
		// return this;
		CHECK_SEQ_POINT(methodExecutionContext, 65336);
		V_2 = __this;
		goto IL_0074;
	}

IL_0040:
	{
		// timer = 0.0f;
		CHECK_SEQ_POINT(methodExecutionContext, 65337);
		__this->set_timer_1((0.0f));
		// IsRunning = true;
		CHECK_SEQ_POINT(methodExecutionContext, 65338);
		STORE_SEQ_POINT(methodExecutionContext, 65344);
		Timer_set_IsRunning_m9AA3554B76F6EB4CD9722620479886E61A599986(__this, (bool)1, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 65344);
		// HandleTimer.Default.allWorkingTimers.Add(this);
		CHECK_SEQ_POINT(methodExecutionContext, 65339);
		IL2CPP_RUNTIME_CLASS_INIT(HandleTimer_tE0613FB7A046C7560F75BD4908092FA5A2260483_il2cpp_TypeInfo_var);
		HandleTimer_tE0613FB7A046C7560F75BD4908092FA5A2260483 * L_5 = ((HandleTimer_tE0613FB7A046C7560F75BD4908092FA5A2260483_StaticFields*)il2cpp_codegen_static_fields_for(HandleTimer_tE0613FB7A046C7560F75BD4908092FA5A2260483_il2cpp_TypeInfo_var))->get_Default_0();
		NullCheck(L_5, il2cpp_codegen_get_sequence_point(65339));
		List_1_t613852693859B0156A22267D914D17B30CFDE8F1 * L_6 = L_5->get_allWorkingTimers_1();
		STORE_SEQ_POINT(methodExecutionContext, 65345);
		NullCheck(L_6, il2cpp_codegen_get_sequence_point(65339));
		List_1_Add_m427CEBFF4473B9FF133591A38714298FA2E4BF08(L_6, __this, /*hidden argument*/List_1_Add_m427CEBFF4473B9FF133591A38714298FA2E4BF08_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 65345);
		// HandleUpdate.Default.Add(this);
		CHECK_SEQ_POINT(methodExecutionContext, 65340);
		HandleUpdate_t2060842DBF2069E5F3DD3C37B41CA77A1C7B78A3 * L_7 = ((HandleUpdate_t2060842DBF2069E5F3DD3C37B41CA77A1C7B78A3_StaticFields*)il2cpp_codegen_static_fields_for(HandleUpdate_t2060842DBF2069E5F3DD3C37B41CA77A1C7B78A3_il2cpp_TypeInfo_var))->get_Default_7();
		STORE_SEQ_POINT(methodExecutionContext, 65346);
		NullCheck(L_7, il2cpp_codegen_get_sequence_point(65340));
		HandleUpdate_Add_m06660D0523D78FD04AD4031ECABFE86BB6EB2FC8(L_7, __this, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 65346);
		// return this;
		CHECK_SEQ_POINT(methodExecutionContext, 65341);
		V_2 = __this;
		goto IL_0074;
	}

IL_0074:
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 65342);
		Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * L_8 = V_2;
		return L_8;
	}
}
// Pixeye.Timer Pixeye.Timer::Restart(System.Action,System.Single)
extern "C" IL2CPP_METHOD_ATTR Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * Timer_Restart_m60B91E24E3F76CC9399B7490C55773B7E76EC6A9 (Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * __this, Action_t591D2A86165F896B4B800BB5C25CE18672A55579 * ___callBackAction0, float ___finishTime1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Timer_Restart_m60B91E24E3F76CC9399B7490C55773B7E76EC6A9_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * V_0 = NULL;
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___callBackAction0), (&___finishTime1));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, Timer_Restart_m60B91E24E3F76CC9399B7490C55773B7E76EC6A9_RuntimeMethod_var, methodExecutionContextThis, methodExecutionContextParameters, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 65347);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 65348);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 65349);
		// this.callBackAction = callBackAction;
		CHECK_SEQ_POINT(methodExecutionContext, 65350);
		Action_t591D2A86165F896B4B800BB5C25CE18672A55579 * L_0 = ___callBackAction0;
		__this->set_callBackAction_4(L_0);
		// return Restart(finishTime);
		CHECK_SEQ_POINT(methodExecutionContext, 65351);
		float L_1 = ___finishTime1;
		STORE_SEQ_POINT(methodExecutionContext, 65353);
		Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * L_2 = Timer_Restart_m3DB9882F8B6959F0E89FF55E0424E25FC784416C(__this, L_1, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 65353);
		V_0 = L_2;
		goto IL_0012;
	}

IL_0012:
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 65352);
		Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * L_3 = V_0;
		return L_3;
	}
}
// System.Void Pixeye.Timer::Tick()
extern "C" IL2CPP_METHOD_ATTR void Timer_Tick_m52CC13CAF2A4D0506274980348BA3DB0AA060A74 (Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Timer_Tick_m52CC13CAF2A4D0506274980348BA3DB0AA060A74_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, Timer_Tick_m52CC13CAF2A4D0506274980348BA3DB0AA060A74_RuntimeMethod_var, methodExecutionContextThis, NULL, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 65354);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 65355);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 65356);
		// Execute();
		CHECK_SEQ_POINT(methodExecutionContext, 65357);
		STORE_SEQ_POINT(methodExecutionContext, 65359);
		Timer_Execute_m2F9D39C42E0AB9B085388143528BEFD1DFCBB9B2(__this, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 65359);
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 65358);
		return;
	}
}
// System.Void Pixeye.Timer::Execute()
extern "C" IL2CPP_METHOD_ATTR void Timer_Execute_m2F9D39C42E0AB9B085388143528BEFD1DFCBB9B2 (Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Timer_Execute_m2F9D39C42E0AB9B085388143528BEFD1DFCBB9B2_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	bool V_1 = false;
	bool V_2 = false;
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, Timer_Execute_m2F9D39C42E0AB9B085388143528BEFD1DFCBB9B2_RuntimeMethod_var, methodExecutionContextThis, NULL, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 65360);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 65361);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 65362);
		// timer += Time.delta * timeScale;
		CHECK_SEQ_POINT(methodExecutionContext, 65363);
		float L_0 = __this->get_timer_1();
		STORE_SEQ_POINT(methodExecutionContext, 65380);
		IL2CPP_RUNTIME_CLASS_INIT(Time_t70920BA2C4C4BE707DAE9822ED553B006FFC0100_il2cpp_TypeInfo_var);
		float L_1 = Time_get_delta_m9AD3A71A628E62BF0E3A01D0E5A652DA9807585E(/*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 65380);
		float L_2 = __this->get_timeScale_3();
		__this->set_timer_1(((float)il2cpp_codegen_add((float)L_0, (float)((float)il2cpp_codegen_multiply((float)L_1, (float)L_2)))));
		// if (timer < finishTime) return;
		CHECK_SEQ_POINT(methodExecutionContext, 65364);
		float L_3 = __this->get_timer_1();
		float L_4 = __this->get_finishTime_2();
		V_0 = (bool)((((float)L_3) < ((float)L_4))? 1 : 0);
		CHECK_SEQ_POINT(methodExecutionContext, 65365);
		bool L_5 = V_0;
		if (!L_5)
		{
			goto IL_002e;
		}
	}
	{
		// if (timer < finishTime) return;
		CHECK_SEQ_POINT(methodExecutionContext, 65366);
		goto IL_008c;
	}

IL_002e:
	{
		// timer = 0.0f;
		CHECK_SEQ_POINT(methodExecutionContext, 65367);
		__this->set_timer_1((0.0f));
		// IsRunning = false;
		CHECK_SEQ_POINT(methodExecutionContext, 65368);
		STORE_SEQ_POINT(methodExecutionContext, 65381);
		Timer_set_IsRunning_m9AA3554B76F6EB4CD9722620479886E61A599986(__this, (bool)0, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 65381);
		// if (callBackAction != null)
		CHECK_SEQ_POINT(methodExecutionContext, 65369);
		Action_t591D2A86165F896B4B800BB5C25CE18672A55579 * L_6 = __this->get_callBackAction_4();
		V_1 = (bool)((!(((RuntimeObject*)(Action_t591D2A86165F896B4B800BB5C25CE18672A55579 *)L_6) <= ((RuntimeObject*)(RuntimeObject *)NULL)))? 1 : 0);
		CHECK_SEQ_POINT(methodExecutionContext, 65370);
		bool L_7 = V_1;
		if (!L_7)
		{
			goto IL_005a;
		}
	}
	{
		// callBackAction();
		CHECK_SEQ_POINT(methodExecutionContext, 65371);
		Action_t591D2A86165F896B4B800BB5C25CE18672A55579 * L_8 = __this->get_callBackAction_4();
		STORE_SEQ_POINT(methodExecutionContext, 65382);
		NullCheck(L_8, il2cpp_codegen_get_sequence_point(65371));
		Action_Invoke_mC8D676E5DDF967EC5D23DD0E96FB52AA499817FD(L_8, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 65382);
	}

IL_005a:
	{
		// if (isAutoKill) Release();
		CHECK_SEQ_POINT(methodExecutionContext, 65372);
		bool L_9 = __this->get_isAutoKill_5();
		V_2 = L_9;
		CHECK_SEQ_POINT(methodExecutionContext, 65373);
		bool L_10 = V_2;
		if (!L_10)
		{
			goto IL_006d;
		}
	}
	{
		// if (isAutoKill) Release();
		CHECK_SEQ_POINT(methodExecutionContext, 65374);
		STORE_SEQ_POINT(methodExecutionContext, 65383);
		Timer_Release_m897A3D2D802D3394A0F42929B6B746EDF50F2318(__this, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 65383);
		goto IL_008c;
	}

IL_006d:
	{
		CHECK_SEQ_POINT(methodExecutionContext, 65375);
		// HandleUpdate.Default.Remove(this);
		CHECK_SEQ_POINT(methodExecutionContext, 65376);
		HandleUpdate_t2060842DBF2069E5F3DD3C37B41CA77A1C7B78A3 * L_11 = ((HandleUpdate_t2060842DBF2069E5F3DD3C37B41CA77A1C7B78A3_StaticFields*)il2cpp_codegen_static_fields_for(HandleUpdate_t2060842DBF2069E5F3DD3C37B41CA77A1C7B78A3_il2cpp_TypeInfo_var))->get_Default_7();
		STORE_SEQ_POINT(methodExecutionContext, 65384);
		NullCheck(L_11, il2cpp_codegen_get_sequence_point(65376));
		HandleUpdate_Remove_m08C15D88B167205B0196A4D39DD82742B901AE53(L_11, __this, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 65384);
		// HandleTimer.Default.allWorkingTimers.Remove(this);
		CHECK_SEQ_POINT(methodExecutionContext, 65377);
		IL2CPP_RUNTIME_CLASS_INIT(HandleTimer_tE0613FB7A046C7560F75BD4908092FA5A2260483_il2cpp_TypeInfo_var);
		HandleTimer_tE0613FB7A046C7560F75BD4908092FA5A2260483 * L_12 = ((HandleTimer_tE0613FB7A046C7560F75BD4908092FA5A2260483_StaticFields*)il2cpp_codegen_static_fields_for(HandleTimer_tE0613FB7A046C7560F75BD4908092FA5A2260483_il2cpp_TypeInfo_var))->get_Default_0();
		NullCheck(L_12, il2cpp_codegen_get_sequence_point(65377));
		List_1_t613852693859B0156A22267D914D17B30CFDE8F1 * L_13 = L_12->get_allWorkingTimers_1();
		STORE_SEQ_POINT(methodExecutionContext, 65385);
		NullCheck(L_13, il2cpp_codegen_get_sequence_point(65377));
		List_1_Remove_m2E8533F833815BDD8176A0DBC27DFCCDC8120FE6(L_13, __this, /*hidden argument*/List_1_Remove_m2E8533F833815BDD8176A0DBC27DFCCDC8120FE6_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 65385);
		CHECK_SEQ_POINT(methodExecutionContext, 65378);
	}

IL_008c:
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 65379);
		return;
	}
}
// System.Void Pixeye.Timer::Release()
extern "C" IL2CPP_METHOD_ATTR void Timer_Release_m897A3D2D802D3394A0F42929B6B746EDF50F2318 (Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Timer_Release_m897A3D2D802D3394A0F42929B6B746EDF50F2318_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, Timer_Release_m897A3D2D802D3394A0F42929B6B746EDF50F2318_RuntimeMethod_var, methodExecutionContextThis, NULL, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 65386);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 65387);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 65388);
		// if (Toolbox.applicationIsQuitting) return;
		CHECK_SEQ_POINT(methodExecutionContext, 65389);
		IL2CPP_RUNTIME_CLASS_INIT(Singleton_1_t70D00C90A652BD47B1B663FC32A13A31E56C12C6_il2cpp_TypeInfo_var);
		bool L_0 = ((Singleton_1_t70D00C90A652BD47B1B663FC32A13A31E56C12C6_StaticFields*)il2cpp_codegen_static_fields_for(Singleton_1_t70D00C90A652BD47B1B663FC32A13A31E56C12C6_il2cpp_TypeInfo_var))->get_applicationIsQuitting_7();
		V_0 = L_0;
		CHECK_SEQ_POINT(methodExecutionContext, 65390);
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_000c;
		}
	}
	{
		// if (Toolbox.applicationIsQuitting) return;
		CHECK_SEQ_POINT(methodExecutionContext, 65391);
		goto IL_0013;
	}

IL_000c:
	{
		// Dispose();
		CHECK_SEQ_POINT(methodExecutionContext, 65392);
		STORE_SEQ_POINT(methodExecutionContext, 65394);
		Timer_Dispose_m8E57793C983E49F48EE17D66614532581624D71C(__this, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 65394);
	}

IL_0013:
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 65393);
		return;
	}
}
// System.Void Pixeye.Timer::Dispose()
extern "C" IL2CPP_METHOD_ATTR void Timer_Dispose_m8E57793C983E49F48EE17D66614532581624D71C (Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Timer_Dispose_m8E57793C983E49F48EE17D66614532581624D71C_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, Timer_Dispose_m8E57793C983E49F48EE17D66614532581624D71C_RuntimeMethod_var, methodExecutionContextThis, NULL, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 65395);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 65396);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 65397);
		// HandleUpdate.Default.Remove(this);
		CHECK_SEQ_POINT(methodExecutionContext, 65398);
		HandleUpdate_t2060842DBF2069E5F3DD3C37B41CA77A1C7B78A3 * L_0 = ((HandleUpdate_t2060842DBF2069E5F3DD3C37B41CA77A1C7B78A3_StaticFields*)il2cpp_codegen_static_fields_for(HandleUpdate_t2060842DBF2069E5F3DD3C37B41CA77A1C7B78A3_il2cpp_TypeInfo_var))->get_Default_7();
		STORE_SEQ_POINT(methodExecutionContext, 65405);
		NullCheck(L_0, il2cpp_codegen_get_sequence_point(65398));
		HandleUpdate_Remove_m08C15D88B167205B0196A4D39DD82742B901AE53(L_0, __this, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 65405);
		// HandleTimer.Default.allWorkingTimers.Remove(this);
		CHECK_SEQ_POINT(methodExecutionContext, 65399);
		IL2CPP_RUNTIME_CLASS_INIT(HandleTimer_tE0613FB7A046C7560F75BD4908092FA5A2260483_il2cpp_TypeInfo_var);
		HandleTimer_tE0613FB7A046C7560F75BD4908092FA5A2260483 * L_1 = ((HandleTimer_tE0613FB7A046C7560F75BD4908092FA5A2260483_StaticFields*)il2cpp_codegen_static_fields_for(HandleTimer_tE0613FB7A046C7560F75BD4908092FA5A2260483_il2cpp_TypeInfo_var))->get_Default_0();
		NullCheck(L_1, il2cpp_codegen_get_sequence_point(65399));
		List_1_t613852693859B0156A22267D914D17B30CFDE8F1 * L_2 = L_1->get_allWorkingTimers_1();
		STORE_SEQ_POINT(methodExecutionContext, 65406);
		NullCheck(L_2, il2cpp_codegen_get_sequence_point(65399));
		List_1_Remove_m2E8533F833815BDD8176A0DBC27DFCCDC8120FE6(L_2, __this, /*hidden argument*/List_1_Remove_m2E8533F833815BDD8176A0DBC27DFCCDC8120FE6_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 65406);
		// timer = 0.0f;
		CHECK_SEQ_POINT(methodExecutionContext, 65400);
		__this->set_timer_1((0.0f));
		// IsRunning = false;
		CHECK_SEQ_POINT(methodExecutionContext, 65401);
		STORE_SEQ_POINT(methodExecutionContext, 65407);
		Timer_set_IsRunning_m9AA3554B76F6EB4CD9722620479886E61A599986(__this, (bool)0, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 65407);
		// isAutoKill = true;
		CHECK_SEQ_POINT(methodExecutionContext, 65402);
		__this->set_isAutoKill_5((bool)1);
		// callBackAction = null;
		CHECK_SEQ_POINT(methodExecutionContext, 65403);
		__this->set_callBackAction_4((Action_t591D2A86165F896B4B800BB5C25CE18672A55579 *)NULL);
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 65404);
		return;
	}
}
// System.Void Pixeye.Timer::.cctor()
extern "C" IL2CPP_METHOD_ATTR void Timer__cctor_m0D3DF27227238E16464244D1566255E049F3C4A4 (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Timer__cctor_m0D3DF27227238E16464244D1566255E049F3C4A4_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, Timer__cctor_m0D3DF27227238E16464244D1566255E049F3C4A4_RuntimeMethod_var, NULL, NULL, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 65408);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 65409);
	{
		// internal static Dictionary<TimerKey, List<Timer>> cachedTimers = new Dictionary<TimerKey, List<Timer>>(10);
		CHECK_SEQ_POINT(methodExecutionContext, 65410);
		STORE_SEQ_POINT(methodExecutionContext, 65411);
		Dictionary_2_t7A0A951F2ACBA1FC50C942EC15413C2011C7B386 * L_0 = (Dictionary_2_t7A0A951F2ACBA1FC50C942EC15413C2011C7B386 *)il2cpp_codegen_object_new(Dictionary_2_t7A0A951F2ACBA1FC50C942EC15413C2011C7B386_il2cpp_TypeInfo_var);
		Dictionary_2__ctor_mC01623E89CE60035A0AB4C3C0E973C959CC76790(L_0, ((int32_t)10), /*hidden argument*/Dictionary_2__ctor_mC01623E89CE60035A0AB4C3C0E973C959CC76790_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 65411);
		((Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA_StaticFields*)il2cpp_codegen_static_fields_for(Timer_t2BCD710CCCB0E9AB7ABF0D388965B97320333DDA_il2cpp_TypeInfo_var))->set_cachedTimers_0(L_0);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Pixeye.TimerKey::.ctor(System.Int32,System.Int32)
extern "C" IL2CPP_METHOD_ATTR void TimerKey__ctor_m51B474020E775F991C54479D9B55A309AEF513AF (TimerKey_tCE6BF602B11E3FE849B05CC16BE0650A88755F89 * __this, int32_t ___x0, int32_t ___y1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (TimerKey__ctor_m51B474020E775F991C54479D9B55A309AEF513AF_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___x0), (&___y1));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, TimerKey__ctor_m51B474020E775F991C54479D9B55A309AEF513AF_RuntimeMethod_var, methodExecutionContextThis, methodExecutionContextParameters, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 65432);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 65433);
	{
		// public TimerKey(int x, int y) : this()
		CHECK_SEQ_POINT(methodExecutionContext, 65434);
		il2cpp_codegen_initobj(__this, sizeof(TimerKey_tCE6BF602B11E3FE849B05CC16BE0650A88755F89 ));
		CHECK_SEQ_POINT(methodExecutionContext, 65435);
		// entity = x;
		CHECK_SEQ_POINT(methodExecutionContext, 65436);
		int32_t L_0 = ___x0;
		__this->set_entity_0(L_0);
		// state = y;
		CHECK_SEQ_POINT(methodExecutionContext, 65437);
		int32_t L_1 = ___y1;
		__this->set_state_1(L_1);
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 65438);
		return;
	}
}
extern "C"  void TimerKey__ctor_m51B474020E775F991C54479D9B55A309AEF513AF_AdjustorThunk (RuntimeObject * __this, int32_t ___x0, int32_t ___y1, const RuntimeMethod* method)
{
	TimerKey_tCE6BF602B11E3FE849B05CC16BE0650A88755F89 * _thisAdjusted = reinterpret_cast<TimerKey_tCE6BF602B11E3FE849B05CC16BE0650A88755F89 *>(__this + 1);
	TimerKey__ctor_m51B474020E775F991C54479D9B55A309AEF513AF(_thisAdjusted, ___x0, ___y1, method);
}
// System.Int32 Pixeye.TimerKey::GetHashCode()
extern "C" IL2CPP_METHOD_ATTR int32_t TimerKey_GetHashCode_mE22CDE5761F4F098F78D2671099DDFD795A59306 (TimerKey_tCE6BF602B11E3FE849B05CC16BE0650A88755F89 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (TimerKey_GetHashCode_mE22CDE5761F4F098F78D2671099DDFD795A59306_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, TimerKey_GetHashCode_mE22CDE5761F4F098F78D2671099DDFD795A59306_RuntimeMethod_var, methodExecutionContextThis, NULL, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 65439);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 65440);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 65441);
		CHECK_SEQ_POINT(methodExecutionContext, 65442);
		// return (entity * 397) ^ state;
		CHECK_SEQ_POINT(methodExecutionContext, 65443);
		int32_t L_0 = __this->get_entity_0();
		int32_t L_1 = __this->get_state_1();
		V_0 = ((int32_t)((int32_t)((int32_t)il2cpp_codegen_multiply((int32_t)L_0, (int32_t)((int32_t)397)))^(int32_t)L_1));
		goto IL_0018;
	}

IL_0018:
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 65444);
		int32_t L_2 = V_0;
		return L_2;
	}
}
extern "C"  int32_t TimerKey_GetHashCode_mE22CDE5761F4F098F78D2671099DDFD795A59306_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	TimerKey_tCE6BF602B11E3FE849B05CC16BE0650A88755F89 * _thisAdjusted = reinterpret_cast<TimerKey_tCE6BF602B11E3FE849B05CC16BE0650A88755F89 *>(__this + 1);
	return TimerKey_GetHashCode_mE22CDE5761F4F098F78D2671099DDFD795A59306(_thisAdjusted, method);
}
// System.Boolean Pixeye.TimerKey::Equals(System.Object)
extern "C" IL2CPP_METHOD_ATTR bool TimerKey_Equals_m4E3403831CDAF7D5E0DF496FEF1335BEC18D82A2 (TimerKey_tCE6BF602B11E3FE849B05CC16BE0650A88755F89 * __this, RuntimeObject * ___other0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (TimerKey_Equals_m4E3403831CDAF7D5E0DF496FEF1335BEC18D82A2_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	bool V_1 = false;
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___other0));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, TimerKey_Equals_m4E3403831CDAF7D5E0DF496FEF1335BEC18D82A2_RuntimeMethod_var, methodExecutionContextThis, methodExecutionContextParameters, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 65445);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 65446);
	int32_t G_B5_0 = 0;
	{
		CHECK_SEQ_POINT(methodExecutionContext, 65447);
		// if (ReferenceEquals(null, other)) return false;
		CHECK_SEQ_POINT(methodExecutionContext, 65448);
		RuntimeObject * L_0 = ___other0;
		V_0 = (bool)((((RuntimeObject*)(RuntimeObject *)L_0) == ((RuntimeObject*)(RuntimeObject *)NULL))? 1 : 0);
		CHECK_SEQ_POINT(methodExecutionContext, 65449);
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_000d;
		}
	}
	{
		// if (ReferenceEquals(null, other)) return false;
		CHECK_SEQ_POINT(methodExecutionContext, 65450);
		V_1 = (bool)0;
		goto IL_0027;
	}

IL_000d:
	{
		// return other is TimerKey && Equals((TimerKey) other);
		CHECK_SEQ_POINT(methodExecutionContext, 65451);
		RuntimeObject * L_2 = ___other0;
		if (!((RuntimeObject *)IsInstSealed((RuntimeObject*)L_2, TimerKey_tCE6BF602B11E3FE849B05CC16BE0650A88755F89_il2cpp_TypeInfo_var)))
		{
			goto IL_0023;
		}
	}
	{
		RuntimeObject * L_3 = ___other0;
		STORE_SEQ_POINT(methodExecutionContext, 65453);
		bool L_4 = TimerKey_Equals_m6345B28732D3D678C674DF49AEAB5182BCD83180((TimerKey_tCE6BF602B11E3FE849B05CC16BE0650A88755F89 *)__this, ((*(TimerKey_tCE6BF602B11E3FE849B05CC16BE0650A88755F89 *)((TimerKey_tCE6BF602B11E3FE849B05CC16BE0650A88755F89 *)UnBox(L_3, TimerKey_tCE6BF602B11E3FE849B05CC16BE0650A88755F89_il2cpp_TypeInfo_var)))), /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 65453);
		G_B5_0 = ((int32_t)(L_4));
		goto IL_0024;
	}

IL_0023:
	{
		G_B5_0 = 0;
	}

IL_0024:
	{
		V_1 = (bool)G_B5_0;
		goto IL_0027;
	}

IL_0027:
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 65452);
		bool L_5 = V_1;
		return L_5;
	}
}
extern "C"  bool TimerKey_Equals_m4E3403831CDAF7D5E0DF496FEF1335BEC18D82A2_AdjustorThunk (RuntimeObject * __this, RuntimeObject * ___other0, const RuntimeMethod* method)
{
	TimerKey_tCE6BF602B11E3FE849B05CC16BE0650A88755F89 * _thisAdjusted = reinterpret_cast<TimerKey_tCE6BF602B11E3FE849B05CC16BE0650A88755F89 *>(__this + 1);
	return TimerKey_Equals_m4E3403831CDAF7D5E0DF496FEF1335BEC18D82A2(_thisAdjusted, ___other0, method);
}
// System.Boolean Pixeye.TimerKey::Equals(Pixeye.TimerKey)
extern "C" IL2CPP_METHOD_ATTR bool TimerKey_Equals_m6345B28732D3D678C674DF49AEAB5182BCD83180 (TimerKey_tCE6BF602B11E3FE849B05CC16BE0650A88755F89 * __this, TimerKey_tCE6BF602B11E3FE849B05CC16BE0650A88755F89  ___other0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (TimerKey_Equals_m6345B28732D3D678C674DF49AEAB5182BCD83180_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___other0));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, TimerKey_Equals_m6345B28732D3D678C674DF49AEAB5182BCD83180_RuntimeMethod_var, methodExecutionContextThis, methodExecutionContextParameters, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 65454);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 65455);
	int32_t G_B3_0 = 0;
	{
		CHECK_SEQ_POINT(methodExecutionContext, 65456);
		// return entity == other.entity && state == other.state;
		CHECK_SEQ_POINT(methodExecutionContext, 65457);
		int32_t L_0 = __this->get_entity_0();
		TimerKey_tCE6BF602B11E3FE849B05CC16BE0650A88755F89  L_1 = ___other0;
		int32_t L_2 = L_1.get_entity_0();
		if ((!(((uint32_t)L_0) == ((uint32_t)L_2))))
		{
			goto IL_001f;
		}
	}
	{
		int32_t L_3 = __this->get_state_1();
		TimerKey_tCE6BF602B11E3FE849B05CC16BE0650A88755F89  L_4 = ___other0;
		int32_t L_5 = L_4.get_state_1();
		G_B3_0 = ((((int32_t)L_3) == ((int32_t)L_5))? 1 : 0);
		goto IL_0020;
	}

IL_001f:
	{
		G_B3_0 = 0;
	}

IL_0020:
	{
		V_0 = (bool)G_B3_0;
		goto IL_0023;
	}

IL_0023:
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 65458);
		bool L_6 = V_0;
		return L_6;
	}
}
extern "C"  bool TimerKey_Equals_m6345B28732D3D678C674DF49AEAB5182BCD83180_AdjustorThunk (RuntimeObject * __this, TimerKey_tCE6BF602B11E3FE849B05CC16BE0650A88755F89  ___other0, const RuntimeMethod* method)
{
	TimerKey_tCE6BF602B11E3FE849B05CC16BE0650A88755F89 * _thisAdjusted = reinterpret_cast<TimerKey_tCE6BF602B11E3FE849B05CC16BE0650A88755F89 *>(__this + 1);
	return TimerKey_Equals_m6345B28732D3D678C674DF49AEAB5182BCD83180(_thisAdjusted, ___other0, method);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Object Pixeye.Toolbox::Get(System.Type)
extern "C" IL2CPP_METHOD_ATTR RuntimeObject * Toolbox_Get_m0C31066657C1EDE23F50364E05BE3C56AB43E6A9 (Type_t * ___t0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Toolbox_Get_m0C31066657C1EDE23F50364E05BE3C56AB43E6A9_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject * V_0 = NULL;
	RuntimeObject * V_1 = NULL;
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___t0));
	DECLARE_METHOD_LOCALS(methodExecutionContextLocals, (&V_0));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, Toolbox_Get_m0C31066657C1EDE23F50364E05BE3C56AB43E6A9_RuntimeMethod_var, NULL, methodExecutionContextParameters, methodExecutionContextLocals);
	CHECK_SEQ_POINT(methodExecutionContext, 64825);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 64826);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 64827);
		// Instance.data.TryGetValue(t.GetHashCode(), out resolve);
		CHECK_SEQ_POINT(methodExecutionContext, 64828);
		STORE_SEQ_POINT(methodExecutionContext, 64831);
		IL2CPP_RUNTIME_CLASS_INIT(Singleton_1_t70D00C90A652BD47B1B663FC32A13A31E56C12C6_il2cpp_TypeInfo_var);
		Toolbox_t081ED4540597D09C31B0F9430D6D377D6BA90E3A * L_0 = Singleton_1_get_Instance_m9E601D43C461833AEAAC52704F1EFD611715C0A9(/*hidden argument*/Singleton_1_get_Instance_m9E601D43C461833AEAAC52704F1EFD611715C0A9_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64831);
		NullCheck(L_0, il2cpp_codegen_get_sequence_point(64828));
		Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884 * L_1 = L_0->get_data_8();
		Type_t * L_2 = ___t0;
		STORE_SEQ_POINT(methodExecutionContext, 64832);
		NullCheck(L_2, il2cpp_codegen_get_sequence_point(64828));
		int32_t L_3 = VirtFuncInvoker0< int32_t >::Invoke(2 /* System.Int32 System.Object::GetHashCode() */, L_2);
		CHECK_SEQ_POINT(methodExecutionContext, 64832);
		STORE_SEQ_POINT(methodExecutionContext, 64833);
		NullCheck(L_1, il2cpp_codegen_get_sequence_point(64828));
		Dictionary_2_TryGetValue_m867F6DA953678D0333A55270B7C6EF38EFC293FF(L_1, L_3, (RuntimeObject **)(&V_0), /*hidden argument*/Dictionary_2_TryGetValue_m867F6DA953678D0333A55270B7C6EF38EFC293FF_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64833);
		// return resolve;
		CHECK_SEQ_POINT(methodExecutionContext, 64829);
		RuntimeObject * L_4 = V_0;
		V_1 = L_4;
		goto IL_001d;
	}

IL_001d:
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 64830);
		RuntimeObject * L_5 = V_1;
		return L_5;
	}
}
// System.Void Pixeye.Toolbox::Add(System.Object)
extern "C" IL2CPP_METHOD_ATTR void Toolbox_Add_mBDBD189E3DF0F0617BEB2FF6ECC08CC748DB4FF9 (RuntimeObject * ___obj0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Toolbox_Add_mBDBD189E3DF0F0617BEB2FF6ECC08CC748DB4FF9_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject * V_0 = NULL;
	RuntimeObject * V_1 = NULL;
	ScriptableObject_tAB015486CEAB714DA0D5C1BA389B84FB90427734 * V_2 = NULL;
	bool V_3 = false;
	bool V_4 = false;
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___obj0));
	DECLARE_METHOD_LOCALS(methodExecutionContextLocals, (&V_0), (&V_1), (&V_2));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, Toolbox_Add_mBDBD189E3DF0F0617BEB2FF6ECC08CC748DB4FF9_RuntimeMethod_var, NULL, methodExecutionContextParameters, methodExecutionContextLocals);
	CHECK_SEQ_POINT(methodExecutionContext, 64834);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 64835);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 64836);
		// if (Instance.data.TryGetValue(obj.GetType().GetHashCode(), out possibleObj))
		CHECK_SEQ_POINT(methodExecutionContext, 64837);
		STORE_SEQ_POINT(methodExecutionContext, 64850);
		IL2CPP_RUNTIME_CLASS_INIT(Singleton_1_t70D00C90A652BD47B1B663FC32A13A31E56C12C6_il2cpp_TypeInfo_var);
		Toolbox_t081ED4540597D09C31B0F9430D6D377D6BA90E3A * L_0 = Singleton_1_get_Instance_m9E601D43C461833AEAAC52704F1EFD611715C0A9(/*hidden argument*/Singleton_1_get_Instance_m9E601D43C461833AEAAC52704F1EFD611715C0A9_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64850);
		NullCheck(L_0, il2cpp_codegen_get_sequence_point(64837));
		Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884 * L_1 = L_0->get_data_8();
		RuntimeObject * L_2 = ___obj0;
		STORE_SEQ_POINT(methodExecutionContext, 64851);
		NullCheck(L_2, il2cpp_codegen_get_sequence_point(64837));
		Type_t * L_3 = Object_GetType_m2E0B62414ECCAA3094B703790CE88CBB2F83EA60(L_2, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 64851);
		STORE_SEQ_POINT(methodExecutionContext, 64852);
		NullCheck(L_3, il2cpp_codegen_get_sequence_point(64837));
		int32_t L_4 = VirtFuncInvoker0< int32_t >::Invoke(2 /* System.Int32 System.Object::GetHashCode() */, L_3);
		CHECK_SEQ_POINT(methodExecutionContext, 64852);
		STORE_SEQ_POINT(methodExecutionContext, 64853);
		NullCheck(L_1, il2cpp_codegen_get_sequence_point(64837));
		bool L_5 = Dictionary_2_TryGetValue_m867F6DA953678D0333A55270B7C6EF38EFC293FF(L_1, L_4, (RuntimeObject **)(&V_0), /*hidden argument*/Dictionary_2_TryGetValue_m867F6DA953678D0333A55270B7C6EF38EFC293FF_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64853);
		V_3 = L_5;
		CHECK_SEQ_POINT(methodExecutionContext, 64838);
		bool L_6 = V_3;
		if (!L_6)
		{
			goto IL_002a;
		}
	}
	{
		CHECK_SEQ_POINT(methodExecutionContext, 64839);
		// InitializeObject(possibleObj);
		CHECK_SEQ_POINT(methodExecutionContext, 64840);
		RuntimeObject * L_7 = V_0;
		STORE_SEQ_POINT(methodExecutionContext, 64854);
		Toolbox_InitializeObject_m6675C399D61F9479D097A9D6E84A755F92EAF155(L_7, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 64854);
		CHECK_SEQ_POINT(methodExecutionContext, 64841);
	}

IL_002a:
	{
		// var add        = obj;
		CHECK_SEQ_POINT(methodExecutionContext, 64842);
		RuntimeObject * L_8 = ___obj0;
		V_1 = L_8;
		// var scriptable = obj as ScriptableObject;
		CHECK_SEQ_POINT(methodExecutionContext, 64843);
		RuntimeObject * L_9 = ___obj0;
		V_2 = ((ScriptableObject_tAB015486CEAB714DA0D5C1BA389B84FB90427734 *)IsInstClass((RuntimeObject*)L_9, ScriptableObject_tAB015486CEAB714DA0D5C1BA389B84FB90427734_il2cpp_TypeInfo_var));
		// if (scriptable) add = Instantiate(scriptable);
		CHECK_SEQ_POINT(methodExecutionContext, 64844);
		ScriptableObject_tAB015486CEAB714DA0D5C1BA389B84FB90427734 * L_10 = V_2;
		STORE_SEQ_POINT(methodExecutionContext, 64855);
		IL2CPP_RUNTIME_CLASS_INIT(Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0_il2cpp_TypeInfo_var);
		bool L_11 = Object_op_Implicit_m8B2A44B4B1406ED346D1AE6D962294FD58D0D534(L_10, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 64855);
		V_4 = L_11;
		CHECK_SEQ_POINT(methodExecutionContext, 64845);
		bool L_12 = V_4;
		if (!L_12)
		{
			goto IL_0046;
		}
	}
	{
		// if (scriptable) add = Instantiate(scriptable);
		CHECK_SEQ_POINT(methodExecutionContext, 64846);
		ScriptableObject_tAB015486CEAB714DA0D5C1BA389B84FB90427734 * L_13 = V_2;
		STORE_SEQ_POINT(methodExecutionContext, 64856);
		IL2CPP_RUNTIME_CLASS_INIT(Object_tAE11E5E46CD5C37C9F3E8950C00CD8B45666A2D0_il2cpp_TypeInfo_var);
		ScriptableObject_tAB015486CEAB714DA0D5C1BA389B84FB90427734 * L_14 = Object_Instantiate_TisScriptableObject_tAB015486CEAB714DA0D5C1BA389B84FB90427734_mB3A1278CCDC8FA17C7D86C6C1C0D7676B0D18A03(L_13, /*hidden argument*/Object_Instantiate_TisScriptableObject_tAB015486CEAB714DA0D5C1BA389B84FB90427734_mB3A1278CCDC8FA17C7D86C6C1C0D7676B0D18A03_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64856);
		V_1 = L_14;
	}

IL_0046:
	{
		// InitializeObject(obj);
		CHECK_SEQ_POINT(methodExecutionContext, 64847);
		RuntimeObject * L_15 = ___obj0;
		STORE_SEQ_POINT(methodExecutionContext, 64857);
		Toolbox_InitializeObject_m6675C399D61F9479D097A9D6E84A755F92EAF155(L_15, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 64857);
		// Instance.data.Add(obj.GetType().GetHashCode(), add);
		CHECK_SEQ_POINT(methodExecutionContext, 64848);
		STORE_SEQ_POINT(methodExecutionContext, 64858);
		IL2CPP_RUNTIME_CLASS_INIT(Singleton_1_t70D00C90A652BD47B1B663FC32A13A31E56C12C6_il2cpp_TypeInfo_var);
		Toolbox_t081ED4540597D09C31B0F9430D6D377D6BA90E3A * L_16 = Singleton_1_get_Instance_m9E601D43C461833AEAAC52704F1EFD611715C0A9(/*hidden argument*/Singleton_1_get_Instance_m9E601D43C461833AEAAC52704F1EFD611715C0A9_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64858);
		NullCheck(L_16, il2cpp_codegen_get_sequence_point(64848));
		Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884 * L_17 = L_16->get_data_8();
		RuntimeObject * L_18 = ___obj0;
		STORE_SEQ_POINT(methodExecutionContext, 64859);
		NullCheck(L_18, il2cpp_codegen_get_sequence_point(64848));
		Type_t * L_19 = Object_GetType_m2E0B62414ECCAA3094B703790CE88CBB2F83EA60(L_18, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 64859);
		STORE_SEQ_POINT(methodExecutionContext, 64860);
		NullCheck(L_19, il2cpp_codegen_get_sequence_point(64848));
		int32_t L_20 = VirtFuncInvoker0< int32_t >::Invoke(2 /* System.Int32 System.Object::GetHashCode() */, L_19);
		CHECK_SEQ_POINT(methodExecutionContext, 64860);
		RuntimeObject * L_21 = V_1;
		STORE_SEQ_POINT(methodExecutionContext, 64861);
		NullCheck(L_17, il2cpp_codegen_get_sequence_point(64848));
		Dictionary_2_Add_mF7AEA0EFA07EEBC1A4B283A26A7CB720EE7A4C20(L_17, L_20, L_21, /*hidden argument*/Dictionary_2_Add_mF7AEA0EFA07EEBC1A4B283A26A7CB720EE7A4C20_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64861);
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 64849);
		return;
	}
}
// System.Void Pixeye.Toolbox::Remove(System.Object)
extern "C" IL2CPP_METHOD_ATTR void Toolbox_Remove_mA89ECC44101120B2FA1DA2121A30C3607EA1E30B (RuntimeObject * ___obj0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Toolbox_Remove_mA89ECC44101120B2FA1DA2121A30C3607EA1E30B_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___obj0));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, Toolbox_Remove_mA89ECC44101120B2FA1DA2121A30C3607EA1E30B_RuntimeMethod_var, NULL, methodExecutionContextParameters, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 64862);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 64863);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 64864);
		// if (applicationIsQuitting) return;
		CHECK_SEQ_POINT(methodExecutionContext, 64865);
		IL2CPP_RUNTIME_CLASS_INIT(Singleton_1_t70D00C90A652BD47B1B663FC32A13A31E56C12C6_il2cpp_TypeInfo_var);
		bool L_0 = ((Singleton_1_t70D00C90A652BD47B1B663FC32A13A31E56C12C6_StaticFields*)il2cpp_codegen_static_fields_for(Singleton_1_t70D00C90A652BD47B1B663FC32A13A31E56C12C6_il2cpp_TypeInfo_var))->get_applicationIsQuitting_7();
		V_0 = L_0;
		CHECK_SEQ_POINT(methodExecutionContext, 64866);
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_000c;
		}
	}
	{
		// if (applicationIsQuitting) return;
		CHECK_SEQ_POINT(methodExecutionContext, 64867);
		goto IL_0027;
	}

IL_000c:
	{
		// Instance.data.Remove(obj.GetType().GetHashCode());
		CHECK_SEQ_POINT(methodExecutionContext, 64868);
		STORE_SEQ_POINT(methodExecutionContext, 64870);
		IL2CPP_RUNTIME_CLASS_INIT(Singleton_1_t70D00C90A652BD47B1B663FC32A13A31E56C12C6_il2cpp_TypeInfo_var);
		Toolbox_t081ED4540597D09C31B0F9430D6D377D6BA90E3A * L_2 = Singleton_1_get_Instance_m9E601D43C461833AEAAC52704F1EFD611715C0A9(/*hidden argument*/Singleton_1_get_Instance_m9E601D43C461833AEAAC52704F1EFD611715C0A9_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64870);
		NullCheck(L_2, il2cpp_codegen_get_sequence_point(64868));
		Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884 * L_3 = L_2->get_data_8();
		RuntimeObject * L_4 = ___obj0;
		STORE_SEQ_POINT(methodExecutionContext, 64871);
		NullCheck(L_4, il2cpp_codegen_get_sequence_point(64868));
		Type_t * L_5 = Object_GetType_m2E0B62414ECCAA3094B703790CE88CBB2F83EA60(L_4, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 64871);
		STORE_SEQ_POINT(methodExecutionContext, 64872);
		NullCheck(L_5, il2cpp_codegen_get_sequence_point(64868));
		int32_t L_6 = VirtFuncInvoker0< int32_t >::Invoke(2 /* System.Int32 System.Object::GetHashCode() */, L_5);
		CHECK_SEQ_POINT(methodExecutionContext, 64872);
		STORE_SEQ_POINT(methodExecutionContext, 64873);
		NullCheck(L_3, il2cpp_codegen_get_sequence_point(64868));
		Dictionary_2_Remove_m2204D6D532702FD13AB2A9AD8DB538E4E8FB1913(L_3, L_6, /*hidden argument*/Dictionary_2_Remove_m2204D6D532702FD13AB2A9AD8DB538E4E8FB1913_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64873);
	}

IL_0027:
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 64869);
		return;
	}
}
// System.Void Pixeye.Toolbox::InitializeObject(System.Object)
extern "C" IL2CPP_METHOD_ATTR void Toolbox_InitializeObject_m6675C399D61F9479D097A9D6E84A755F92EAF155 (RuntimeObject * ___obj0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Toolbox_InitializeObject_m6675C399D61F9479D097A9D6E84A755F92EAF155_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject* V_0 = NULL;
	bool V_1 = false;
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___obj0));
	DECLARE_METHOD_LOCALS(methodExecutionContextLocals, (&V_0));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, Toolbox_InitializeObject_m6675C399D61F9479D097A9D6E84A755F92EAF155_RuntimeMethod_var, NULL, methodExecutionContextParameters, methodExecutionContextLocals);
	CHECK_SEQ_POINT(methodExecutionContext, 64874);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 64875);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 64876);
		// var awakeble = obj as IAwake;
		CHECK_SEQ_POINT(methodExecutionContext, 64877);
		RuntimeObject * L_0 = ___obj0;
		V_0 = ((RuntimeObject*)IsInst((RuntimeObject*)L_0, IAwake_tCD9519461B0D3E6CE3EAA3CF6194878CFEB0B1E5_il2cpp_TypeInfo_var));
		// if (awakeble != null) awakeble.OnAwake();
		CHECK_SEQ_POINT(methodExecutionContext, 64878);
		RuntimeObject* L_1 = V_0;
		V_1 = (bool)((!(((RuntimeObject*)(RuntimeObject*)L_1) <= ((RuntimeObject*)(RuntimeObject *)NULL)))? 1 : 0);
		CHECK_SEQ_POINT(methodExecutionContext, 64879);
		bool L_2 = V_1;
		if (!L_2)
		{
			goto IL_0017;
		}
	}
	{
		// if (awakeble != null) awakeble.OnAwake();
		CHECK_SEQ_POINT(methodExecutionContext, 64880);
		RuntimeObject* L_3 = V_0;
		STORE_SEQ_POINT(methodExecutionContext, 64883);
		NullCheck(L_3, il2cpp_codegen_get_sequence_point(64880));
		InterfaceActionInvoker0::Invoke(0 /* System.Void Pixeye.IAwake::OnAwake() */, IAwake_tCD9519461B0D3E6CE3EAA3CF6194878CFEB0B1E5_il2cpp_TypeInfo_var, L_3);
		CHECK_SEQ_POINT(methodExecutionContext, 64883);
	}

IL_0017:
	{
		// HandleUpdate.Default.Add(obj);
		CHECK_SEQ_POINT(methodExecutionContext, 64881);
		HandleUpdate_t2060842DBF2069E5F3DD3C37B41CA77A1C7B78A3 * L_4 = ((HandleUpdate_t2060842DBF2069E5F3DD3C37B41CA77A1C7B78A3_StaticFields*)il2cpp_codegen_static_fields_for(HandleUpdate_t2060842DBF2069E5F3DD3C37B41CA77A1C7B78A3_il2cpp_TypeInfo_var))->get_Default_7();
		RuntimeObject * L_5 = ___obj0;
		STORE_SEQ_POINT(methodExecutionContext, 64884);
		NullCheck(L_4, il2cpp_codegen_get_sequence_point(64881));
		HandleUpdate_Add_m06660D0523D78FD04AD4031ECABFE86BB6EB2FC8(L_4, L_5, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 64884);
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 64882);
		return;
	}
}
// System.Void Pixeye.Toolbox::ClearSessionData()
extern "C" IL2CPP_METHOD_ATTR void Toolbox_ClearSessionData_mE82F017CF39C883E598DB8129B876253C21CCCED (Toolbox_t081ED4540597D09C31B0F9430D6D377D6BA90E3A * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Toolbox_ClearSessionData_mE82F017CF39C883E598DB8129B876253C21CCCED_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	List_1_tE1526161A558A17A39A8B69D8EEF3801393B6226 * V_0 = NULL;
	bool V_1 = false;
	Enumerator_t72A8231827DB93FC8B25F08FF066377F7B773DA1  V_2;
	memset(&V_2, 0, sizeof(V_2));
	KeyValuePair_2_t142B50DAD5164EBD2E1495FD821B1A4C3233FA26  V_3;
	memset(&V_3, 0, sizeof(V_3));
	RuntimeObject* V_4 = NULL;
	RuntimeObject* V_5 = NULL;
	bool V_6 = false;
	bool V_7 = false;
	int32_t V_8 = 0;
	bool V_9 = false;
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_LOCALS(methodExecutionContextLocals, (&V_0), (&V_3), (&V_4), (&V_5), (&V_8));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, Toolbox_ClearSessionData_mE82F017CF39C883E598DB8129B876253C21CCCED_RuntimeMethod_var, methodExecutionContextThis, NULL, methodExecutionContextLocals);
	CHECK_SEQ_POINT(methodExecutionContext, 64895);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 64896);
	Exception_t * __last_unhandled_exception = 0;
	NO_UNUSED_WARNING (__last_unhandled_exception);
	Exception_t * __exception_local = 0;
	NO_UNUSED_WARNING (__exception_local);
	int32_t __leave_target = -1;
	NO_UNUSED_WARNING (__leave_target);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 64897);
		// if (applicationIsQuitting) return;
		CHECK_SEQ_POINT(methodExecutionContext, 64898);
		IL2CPP_RUNTIME_CLASS_INIT(Singleton_1_t70D00C90A652BD47B1B663FC32A13A31E56C12C6_il2cpp_TypeInfo_var);
		bool L_0 = ((Singleton_1_t70D00C90A652BD47B1B663FC32A13A31E56C12C6_StaticFields*)il2cpp_codegen_static_fields_for(Singleton_1_t70D00C90A652BD47B1B663FC32A13A31E56C12C6_il2cpp_TypeInfo_var))->get_applicationIsQuitting_7();
		V_1 = L_0;
		CHECK_SEQ_POINT(methodExecutionContext, 64899);
		bool L_1 = V_1;
		if (!L_1)
		{
			goto IL_000f;
		}
	}
	{
		// if (applicationIsQuitting) return;
		CHECK_SEQ_POINT(methodExecutionContext, 64900);
		goto IL_0105;
	}

IL_000f:
	{
		// var toWipe = new List<int>();
		CHECK_SEQ_POINT(methodExecutionContext, 64901);
		STORE_SEQ_POINT(methodExecutionContext, 64934);
		List_1_tE1526161A558A17A39A8B69D8EEF3801393B6226 * L_2 = (List_1_tE1526161A558A17A39A8B69D8EEF3801393B6226 *)il2cpp_codegen_object_new(List_1_tE1526161A558A17A39A8B69D8EEF3801393B6226_il2cpp_TypeInfo_var);
		List_1__ctor_mA7F9F92F641CEECFD9D8CFDC667568A05FFD27B4(L_2, /*hidden argument*/List_1__ctor_mA7F9F92F641CEECFD9D8CFDC667568A05FFD27B4_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64934);
		V_0 = L_2;
		CHECK_SEQ_POINT(methodExecutionContext, 64902);
		// foreach (var pair in data)
		CHECK_SEQ_POINT(methodExecutionContext, 64903);
		Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884 * L_3 = __this->get_data_8();
		STORE_SEQ_POINT(methodExecutionContext, 64935);
		NullCheck(L_3, il2cpp_codegen_get_sequence_point(64903));
		Enumerator_t72A8231827DB93FC8B25F08FF066377F7B773DA1  L_4 = Dictionary_2_GetEnumerator_mE47C13FC1B2BACBEE6F795B0E40E6406CAC55D4B(L_3, /*hidden argument*/Dictionary_2_GetEnumerator_mE47C13FC1B2BACBEE6F795B0E40E6406CAC55D4B_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64935);
		V_2 = L_4;
	}

IL_0022:
	try
	{ // begin try (depth: 1)
		{
			CHECK_SEQ_POINT(methodExecutionContext, 64904);
			goto IL_0078;
		}

IL_0024:
		{
			// foreach (var pair in data)
			CHECK_SEQ_POINT(methodExecutionContext, 64905);
			STORE_SEQ_POINT(methodExecutionContext, 64936);
			KeyValuePair_2_t142B50DAD5164EBD2E1495FD821B1A4C3233FA26  L_5 = Enumerator_get_Current_m73F8FC135A20BDFEA0846D8FC876863ED85FEA49((Enumerator_t72A8231827DB93FC8B25F08FF066377F7B773DA1 *)(&V_2), /*hidden argument*/Enumerator_get_Current_m73F8FC135A20BDFEA0846D8FC876863ED85FEA49_RuntimeMethod_var);
			CHECK_SEQ_POINT(methodExecutionContext, 64936);
			V_3 = L_5;
			CHECK_SEQ_POINT(methodExecutionContext, 64906);
			// var isKernel = pair.Value as IKernel;
			CHECK_SEQ_POINT(methodExecutionContext, 64907);
			STORE_SEQ_POINT(methodExecutionContext, 64937);
			RuntimeObject * L_6 = KeyValuePair_2_get_Value_mAD6801F3BC9BA1E99D4E0F72B2B420182D0494FC((KeyValuePair_2_t142B50DAD5164EBD2E1495FD821B1A4C3233FA26 *)(&V_3), /*hidden argument*/KeyValuePair_2_get_Value_mAD6801F3BC9BA1E99D4E0F72B2B420182D0494FC_RuntimeMethod_var);
			CHECK_SEQ_POINT(methodExecutionContext, 64937);
			V_4 = ((RuntimeObject*)IsInst((RuntimeObject*)L_6, IKernel_t0B60B083684ECDD45B0EBB8E5E0555AE88F66112_il2cpp_TypeInfo_var));
			// if (isKernel == null) toWipe.Add(pair.Key);
			CHECK_SEQ_POINT(methodExecutionContext, 64908);
			RuntimeObject* L_7 = V_4;
			V_6 = (bool)((((RuntimeObject*)(RuntimeObject*)L_7) == ((RuntimeObject*)(RuntimeObject *)NULL))? 1 : 0);
			CHECK_SEQ_POINT(methodExecutionContext, 64909);
			bool L_8 = V_6;
			if (!L_8)
			{
				goto IL_0054;
			}
		}

IL_0046:
		{
			// if (isKernel == null) toWipe.Add(pair.Key);
			CHECK_SEQ_POINT(methodExecutionContext, 64910);
			List_1_tE1526161A558A17A39A8B69D8EEF3801393B6226 * L_9 = V_0;
			STORE_SEQ_POINT(methodExecutionContext, 64938);
			int32_t L_10 = KeyValuePair_2_get_Key_m89B687D373FBE3D230647CA0C536235E12AD829C((KeyValuePair_2_t142B50DAD5164EBD2E1495FD821B1A4C3233FA26 *)(&V_3), /*hidden argument*/KeyValuePair_2_get_Key_m89B687D373FBE3D230647CA0C536235E12AD829C_RuntimeMethod_var);
			CHECK_SEQ_POINT(methodExecutionContext, 64938);
			STORE_SEQ_POINT(methodExecutionContext, 64939);
			NullCheck(L_9, il2cpp_codegen_get_sequence_point(64910));
			List_1_Add_m50C0D1F69B2EF31137658E2F052EBBAC7BF82771(L_9, L_10, /*hidden argument*/List_1_Add_m50C0D1F69B2EF31137658E2F052EBBAC7BF82771_RuntimeMethod_var);
			CHECK_SEQ_POINT(methodExecutionContext, 64939);
		}

IL_0054:
		{
			// var needToBeCleaned = pair.Value as IDisposable;
			CHECK_SEQ_POINT(methodExecutionContext, 64911);
			STORE_SEQ_POINT(methodExecutionContext, 64940);
			RuntimeObject * L_11 = KeyValuePair_2_get_Value_mAD6801F3BC9BA1E99D4E0F72B2B420182D0494FC((KeyValuePair_2_t142B50DAD5164EBD2E1495FD821B1A4C3233FA26 *)(&V_3), /*hidden argument*/KeyValuePair_2_get_Value_mAD6801F3BC9BA1E99D4E0F72B2B420182D0494FC_RuntimeMethod_var);
			CHECK_SEQ_POINT(methodExecutionContext, 64940);
			V_5 = ((RuntimeObject*)IsInst((RuntimeObject*)L_11, IDisposable_t7218B22548186B208D65EA5B7870503810A2D15A_il2cpp_TypeInfo_var));
			// if (needToBeCleaned == null) continue;
			CHECK_SEQ_POINT(methodExecutionContext, 64912);
			RuntimeObject* L_12 = V_5;
			V_7 = (bool)((((RuntimeObject*)(RuntimeObject*)L_12) == ((RuntimeObject*)(RuntimeObject *)NULL))? 1 : 0);
			CHECK_SEQ_POINT(methodExecutionContext, 64913);
			bool L_13 = V_7;
			if (!L_13)
			{
				goto IL_006f;
			}
		}

IL_006d:
		{
			// if (needToBeCleaned == null) continue;
			CHECK_SEQ_POINT(methodExecutionContext, 64914);
			goto IL_0078;
		}

IL_006f:
		{
			// needToBeCleaned.Dispose();
			CHECK_SEQ_POINT(methodExecutionContext, 64915);
			RuntimeObject* L_14 = V_5;
			STORE_SEQ_POINT(methodExecutionContext, 64941);
			NullCheck(L_14, il2cpp_codegen_get_sequence_point(64915));
			InterfaceActionInvoker0::Invoke(0 /* System.Void System.IDisposable::Dispose() */, IDisposable_t7218B22548186B208D65EA5B7870503810A2D15A_il2cpp_TypeInfo_var, L_14);
			CHECK_SEQ_POINT(methodExecutionContext, 64941);
			CHECK_SEQ_POINT(methodExecutionContext, 64916);
		}

IL_0078:
		{
			// foreach (var pair in data)
			CHECK_SEQ_POINT(methodExecutionContext, 64917);
			STORE_SEQ_POINT(methodExecutionContext, 64942);
			bool L_15 = Enumerator_MoveNext_m637AE52AC4BDE5BEB1D89BE4B75E49B4C328EFC9((Enumerator_t72A8231827DB93FC8B25F08FF066377F7B773DA1 *)(&V_2), /*hidden argument*/Enumerator_MoveNext_m637AE52AC4BDE5BEB1D89BE4B75E49B4C328EFC9_RuntimeMethod_var);
			CHECK_SEQ_POINT(methodExecutionContext, 64942);
			if (L_15)
			{
				goto IL_0024;
			}
		}

IL_0081:
		{
			IL2CPP_LEAVE(0x92, FINALLY_0083);
		}
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		__last_unhandled_exception = (Exception_t *)e.ex;
		goto FINALLY_0083;
	}

FINALLY_0083:
	{ // begin finally (depth: 1)
		CHECK_SEQ_POINT(methodExecutionContext, 64918);
		STORE_SEQ_POINT(methodExecutionContext, 64943);
		Enumerator_Dispose_m772E7049D8DA96AF5021EA09C3E6322CD4BFBDFC((Enumerator_t72A8231827DB93FC8B25F08FF066377F7B773DA1 *)(&V_2), /*hidden argument*/Enumerator_Dispose_m772E7049D8DA96AF5021EA09C3E6322CD4BFBDFC_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64943);
		IL2CPP_RESET_LEAVE(0x92);
		IL2CPP_END_FINALLY(131)
	} // end finally (depth: 1)
	IL2CPP_CLEANUP(131)
	{
		IL2CPP_JUMP_TBL(0x92, IL_0092)
		IL2CPP_RETHROW_IF_UNHANDLED(Exception_t *)
	}

IL_0092:
	{
		// HandleTimer.Default.Dispose();
		CHECK_SEQ_POINT(methodExecutionContext, 64919);
		IL2CPP_RUNTIME_CLASS_INIT(HandleTimer_tE0613FB7A046C7560F75BD4908092FA5A2260483_il2cpp_TypeInfo_var);
		HandleTimer_tE0613FB7A046C7560F75BD4908092FA5A2260483 * L_16 = ((HandleTimer_tE0613FB7A046C7560F75BD4908092FA5A2260483_StaticFields*)il2cpp_codegen_static_fields_for(HandleTimer_tE0613FB7A046C7560F75BD4908092FA5A2260483_il2cpp_TypeInfo_var))->get_Default_0();
		STORE_SEQ_POINT(methodExecutionContext, 64944);
		NullCheck(L_16, il2cpp_codegen_get_sequence_point(64919));
		HandleTimer_Dispose_mB70AEF1D54E7E16C3373534C49364617998D6EF1(L_16, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 64944);
		// HandlePool.Default.Dispose();
		CHECK_SEQ_POINT(methodExecutionContext, 64920);
		IL2CPP_RUNTIME_CLASS_INIT(HandlePool_tBB031F11A1DE7E61E63146EF835372909BFCB665_il2cpp_TypeInfo_var);
		HandlePool_tBB031F11A1DE7E61E63146EF835372909BFCB665 * L_17 = ((HandlePool_tBB031F11A1DE7E61E63146EF835372909BFCB665_StaticFields*)il2cpp_codegen_static_fields_for(HandlePool_tBB031F11A1DE7E61E63146EF835372909BFCB665_il2cpp_TypeInfo_var))->get_Default_1();
		STORE_SEQ_POINT(methodExecutionContext, 64945);
		NullCheck(L_17, il2cpp_codegen_get_sequence_point(64920));
		HandlePool_Dispose_m8BCFF4C7987C959A19EACEF4A42A2B2E96C92727(L_17, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 64945);
		// HandleEntities.Default.Dispose();
		CHECK_SEQ_POINT(methodExecutionContext, 64921);
		IL2CPP_RUNTIME_CLASS_INIT(HandleEntities_t05CCD5B390B45C447D8FA2542EF8CC2761054D76_il2cpp_TypeInfo_var);
		HandleEntities_t05CCD5B390B45C447D8FA2542EF8CC2761054D76 * L_18 = ((HandleEntities_t05CCD5B390B45C447D8FA2542EF8CC2761054D76_StaticFields*)il2cpp_codegen_static_fields_for(HandleEntities_t05CCD5B390B45C447D8FA2542EF8CC2761054D76_il2cpp_TypeInfo_var))->get_Default_0();
		STORE_SEQ_POINT(methodExecutionContext, 64946);
		NullCheck(L_18, il2cpp_codegen_get_sequence_point(64921));
		HandleEntities_Dispose_m406AC662E2C2469B22DFB29358CE5D70E9858BEC(L_18, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 64946);
		// HandleScene.Default.Dispose();
		CHECK_SEQ_POINT(methodExecutionContext, 64922);
		IL2CPP_RUNTIME_CLASS_INIT(HandleScene_t9A17EE1370450F47652A7C56B9D20A02A7BA1728_il2cpp_TypeInfo_var);
		HandleScene_t9A17EE1370450F47652A7C56B9D20A02A7BA1728 * L_19 = ((HandleScene_t9A17EE1370450F47652A7C56B9D20A02A7BA1728_StaticFields*)il2cpp_codegen_static_fields_for(HandleScene_t9A17EE1370450F47652A7C56B9D20A02A7BA1728_il2cpp_TypeInfo_var))->get_Default_0();
		STORE_SEQ_POINT(methodExecutionContext, 64947);
		NullCheck(L_19, il2cpp_codegen_get_sequence_point(64922));
		HandleScene_Dispose_m6648966B379C0A8408CBDA60C1D5206EB6BC3EFE(L_19, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 64947);
		// HandleUpdate.Default.Dispose();
		CHECK_SEQ_POINT(methodExecutionContext, 64923);
		HandleUpdate_t2060842DBF2069E5F3DD3C37B41CA77A1C7B78A3 * L_20 = ((HandleUpdate_t2060842DBF2069E5F3DD3C37B41CA77A1C7B78A3_StaticFields*)il2cpp_codegen_static_fields_for(HandleUpdate_t2060842DBF2069E5F3DD3C37B41CA77A1C7B78A3_il2cpp_TypeInfo_var))->get_Default_7();
		STORE_SEQ_POINT(methodExecutionContext, 64948);
		NullCheck(L_20, il2cpp_codegen_get_sequence_point(64923));
		HandleUpdate_Dispose_mDF558B8E86D5D0F1725D63E827055044C107395E(L_20, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 64948);
		// Box.Default.Dispose();
		CHECK_SEQ_POINT(methodExecutionContext, 64924);
		IL2CPP_RUNTIME_CLASS_INIT(Box_t4C71F0C8AB96AC3964C40FE71BB42D9C121F81B1_il2cpp_TypeInfo_var);
		Box_t4C71F0C8AB96AC3964C40FE71BB42D9C121F81B1 * L_21 = ((Box_t4C71F0C8AB96AC3964C40FE71BB42D9C121F81B1_StaticFields*)il2cpp_codegen_static_fields_for(Box_t4C71F0C8AB96AC3964C40FE71BB42D9C121F81B1_il2cpp_TypeInfo_var))->get_Default_0();
		STORE_SEQ_POINT(methodExecutionContext, 64949);
		NullCheck(L_21, il2cpp_codegen_get_sequence_point(64924));
		Box_Dispose_m6C2344704C406FC80333DE53B1F77BC3E315C7D3(L_21, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 64949);
		// for (var i = 0; i < toWipe.Count; i++)
		CHECK_SEQ_POINT(methodExecutionContext, 64925);
		V_8 = 0;
		CHECK_SEQ_POINT(methodExecutionContext, 64926);
		goto IL_00f5;
	}

IL_00d9:
	{
		CHECK_SEQ_POINT(methodExecutionContext, 64927);
		// data.Remove(toWipe[i]);
		CHECK_SEQ_POINT(methodExecutionContext, 64928);
		Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884 * L_22 = __this->get_data_8();
		List_1_tE1526161A558A17A39A8B69D8EEF3801393B6226 * L_23 = V_0;
		int32_t L_24 = V_8;
		STORE_SEQ_POINT(methodExecutionContext, 64950);
		NullCheck(L_23, il2cpp_codegen_get_sequence_point(64928));
		int32_t L_25 = List_1_get_Item_mB62D52423AF52EEC13B4317DD86E6A5BBDF41BD2(L_23, L_24, /*hidden argument*/List_1_get_Item_mB62D52423AF52EEC13B4317DD86E6A5BBDF41BD2_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64950);
		STORE_SEQ_POINT(methodExecutionContext, 64951);
		NullCheck(L_22, il2cpp_codegen_get_sequence_point(64928));
		Dictionary_2_Remove_m2204D6D532702FD13AB2A9AD8DB538E4E8FB1913(L_22, L_25, /*hidden argument*/Dictionary_2_Remove_m2204D6D532702FD13AB2A9AD8DB538E4E8FB1913_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64951);
		CHECK_SEQ_POINT(methodExecutionContext, 64929);
		// for (var i = 0; i < toWipe.Count; i++)
		CHECK_SEQ_POINT(methodExecutionContext, 64930);
		int32_t L_26 = V_8;
		V_8 = ((int32_t)il2cpp_codegen_add((int32_t)L_26, (int32_t)1));
	}

IL_00f5:
	{
		// for (var i = 0; i < toWipe.Count; i++)
		CHECK_SEQ_POINT(methodExecutionContext, 64931);
		int32_t L_27 = V_8;
		List_1_tE1526161A558A17A39A8B69D8EEF3801393B6226 * L_28 = V_0;
		STORE_SEQ_POINT(methodExecutionContext, 64952);
		NullCheck(L_28, il2cpp_codegen_get_sequence_point(64931));
		int32_t L_29 = List_1_get_Count_m52793036D5E41E8E25DCC5C033380C44D7596903(L_28, /*hidden argument*/List_1_get_Count_m52793036D5E41E8E25DCC5C033380C44D7596903_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64952);
		V_9 = (bool)((((int32_t)L_27) < ((int32_t)L_29))? 1 : 0);
		CHECK_SEQ_POINT(methodExecutionContext, 64932);
		bool L_30 = V_9;
		if (L_30)
		{
			goto IL_00d9;
		}
	}

IL_0105:
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 64933);
		return;
	}
}
// System.Void Pixeye.Toolbox::DisposeObject(System.Object)
extern "C" IL2CPP_METHOD_ATTR void Toolbox_DisposeObject_mE303B4740B3F3657EFBB211699227741CC6B681A (RuntimeObject * ___obj0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Toolbox_DisposeObject_mE303B4740B3F3657EFBB211699227741CC6B681A_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject* V_0 = NULL;
	bool V_1 = false;
	bool V_2 = false;
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___obj0));
	DECLARE_METHOD_LOCALS(methodExecutionContextLocals, (&V_0));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, Toolbox_DisposeObject_mE303B4740B3F3657EFBB211699227741CC6B681A_RuntimeMethod_var, NULL, methodExecutionContextParameters, methodExecutionContextLocals);
	CHECK_SEQ_POINT(methodExecutionContext, 64953);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 64954);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 64955);
		// if (isQuittingOrChangingScene()) return;
		CHECK_SEQ_POINT(methodExecutionContext, 64956);
		STORE_SEQ_POINT(methodExecutionContext, 64966);
		IL2CPP_RUNTIME_CLASS_INIT(Singleton_1_t70D00C90A652BD47B1B663FC32A13A31E56C12C6_il2cpp_TypeInfo_var);
		bool L_0 = Singleton_1_isQuittingOrChangingScene_m4D5ABD228FA0FB2265D3D3BEEAD1FB0EFC43EDAF(/*hidden argument*/Singleton_1_isQuittingOrChangingScene_m4D5ABD228FA0FB2265D3D3BEEAD1FB0EFC43EDAF_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64966);
		V_1 = L_0;
		CHECK_SEQ_POINT(methodExecutionContext, 64957);
		bool L_1 = V_1;
		if (!L_1)
		{
			goto IL_000c;
		}
	}
	{
		// if (isQuittingOrChangingScene()) return;
		CHECK_SEQ_POINT(methodExecutionContext, 64958);
		goto IL_0024;
	}

IL_000c:
	{
		// var disposable = obj as IDisposable;
		CHECK_SEQ_POINT(methodExecutionContext, 64959);
		RuntimeObject * L_2 = ___obj0;
		V_0 = ((RuntimeObject*)IsInst((RuntimeObject*)L_2, IDisposable_t7218B22548186B208D65EA5B7870503810A2D15A_il2cpp_TypeInfo_var));
		// if (disposable != null)
		CHECK_SEQ_POINT(methodExecutionContext, 64960);
		RuntimeObject* L_3 = V_0;
		V_2 = (bool)((!(((RuntimeObject*)(RuntimeObject*)L_3) <= ((RuntimeObject*)(RuntimeObject *)NULL)))? 1 : 0);
		CHECK_SEQ_POINT(methodExecutionContext, 64961);
		bool L_4 = V_2;
		if (!L_4)
		{
			goto IL_0024;
		}
	}
	{
		CHECK_SEQ_POINT(methodExecutionContext, 64962);
		// disposable.Dispose();
		CHECK_SEQ_POINT(methodExecutionContext, 64963);
		RuntimeObject* L_5 = V_0;
		STORE_SEQ_POINT(methodExecutionContext, 64967);
		NullCheck(L_5, il2cpp_codegen_get_sequence_point(64963));
		InterfaceActionInvoker0::Invoke(0 /* System.Void System.IDisposable::Dispose() */, IDisposable_t7218B22548186B208D65EA5B7870503810A2D15A_il2cpp_TypeInfo_var, L_5);
		CHECK_SEQ_POINT(methodExecutionContext, 64967);
		CHECK_SEQ_POINT(methodExecutionContext, 64964);
	}

IL_0024:
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 64965);
		return;
	}
}
// System.Void Pixeye.Toolbox::.ctor()
extern "C" IL2CPP_METHOD_ATTR void Toolbox__ctor_mFF865D9437C280405E8B57E77135276B8AD03B38 (Toolbox_t081ED4540597D09C31B0F9430D6D377D6BA90E3A * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Toolbox__ctor_mFF865D9437C280405E8B57E77135276B8AD03B38_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, Toolbox__ctor_mFF865D9437C280405E8B57E77135276B8AD03B38_RuntimeMethod_var, methodExecutionContextThis, NULL, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 64968);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 64969);
	{
		// [SerializeField] Dictionary<int, object> data = new Dictionary<int, object>(5, new FastComparable());
		CHECK_SEQ_POINT(methodExecutionContext, 64970);
		STORE_SEQ_POINT(methodExecutionContext, 64971);
		FastComparable_t85AACE6CEBE4B0D7FB16B2F3D09523B7BC4AA1A8 * L_0 = (FastComparable_t85AACE6CEBE4B0D7FB16B2F3D09523B7BC4AA1A8 *)il2cpp_codegen_object_new(FastComparable_t85AACE6CEBE4B0D7FB16B2F3D09523B7BC4AA1A8_il2cpp_TypeInfo_var);
		FastComparable__ctor_m3F034079FFB5E1F69208BF84CF6F3FFDF2084997(L_0, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 64971);
		STORE_SEQ_POINT(methodExecutionContext, 64972);
		Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884 * L_1 = (Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884 *)il2cpp_codegen_object_new(Dictionary_2_t03608389BB57475AA3F4B2B79D176A27807BC884_il2cpp_TypeInfo_var);
		Dictionary_2__ctor_m0F87B73520F2A9CD71CF45B4561785C1C42E8111(L_1, 5, L_0, /*hidden argument*/Dictionary_2__ctor_m0F87B73520F2A9CD71CF45B4561785C1C42E8111_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64972);
		__this->set_data_8(L_1);
		STORE_SEQ_POINT(methodExecutionContext, 64973);
		IL2CPP_RUNTIME_CLASS_INIT(Singleton_1_t70D00C90A652BD47B1B663FC32A13A31E56C12C6_il2cpp_TypeInfo_var);
		Singleton_1__ctor_m338353C6D6074D6C6AC75D270237A0CC32BE9BDF(__this, /*hidden argument*/Singleton_1__ctor_m338353C6D6074D6C6AC75D270237A0CC32BE9BDF_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 64973);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Pixeye.ent::.ctor(System.Int32,System.Int32)
extern "C" IL2CPP_METHOD_ATTR void ent__ctor_m687198B81484B7EA5A3EB6F226AA5CE1F2B52F6E (ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * __this, int32_t ___id0, int32_t ___hash1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (ent__ctor_m687198B81484B7EA5A3EB6F226AA5CE1F2B52F6E_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___id0), (&___hash1));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, ent__ctor_m687198B81484B7EA5A3EB6F226AA5CE1F2B52F6E_RuntimeMethod_var, methodExecutionContextThis, methodExecutionContextParameters, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 59917);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 59918);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 59919);
		// this.id = id;
		CHECK_SEQ_POINT(methodExecutionContext, 59920);
		int32_t L_0 = ___id0;
		__this->set_id_0(L_0);
		// this.hash = hash;
		CHECK_SEQ_POINT(methodExecutionContext, 59921);
		int32_t L_1 = ___hash1;
		__this->set_hash_1(L_1);
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 59922);
		return;
	}
}
extern "C"  void ent__ctor_m687198B81484B7EA5A3EB6F226AA5CE1F2B52F6E_AdjustorThunk (RuntimeObject * __this, int32_t ___id0, int32_t ___hash1, const RuntimeMethod* method)
{
	ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * _thisAdjusted = reinterpret_cast<ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 *>(__this + 1);
	ent__ctor_m687198B81484B7EA5A3EB6F226AA5CE1F2B52F6E(_thisAdjusted, ___id0, ___hash1, method);
}
// System.Int32 Pixeye.ent::op_Implicit(Pixeye.ent)
extern "C" IL2CPP_METHOD_ATTR int32_t ent_op_Implicit_m16BC2A28ED2D8A104FC8CB8BF31A2CA6B2DD42CD (ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622  ___value0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (ent_op_Implicit_m16BC2A28ED2D8A104FC8CB8BF31A2CA6B2DD42CD_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___value0));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, ent_op_Implicit_m16BC2A28ED2D8A104FC8CB8BF31A2CA6B2DD42CD_RuntimeMethod_var, NULL, methodExecutionContextParameters, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 59923);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 59924);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 59925);
		// return value.id;
		CHECK_SEQ_POINT(methodExecutionContext, 59926);
		ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622  L_0 = ___value0;
		int32_t L_1 = L_0.get_id_0();
		V_0 = L_1;
		goto IL_000a;
	}

IL_000a:
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 59927);
		int32_t L_2 = V_0;
		return L_2;
	}
}
// Pixeye.ent Pixeye.ent::op_Implicit(System.Int32)
extern "C" IL2CPP_METHOD_ATTR ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622  ent_op_Implicit_m7B45657F4A2AE01FC3A5AC35BF156D72DAD5ABFF (int32_t ___value0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (ent_op_Implicit_m7B45657F4A2AE01FC3A5AC35BF156D72DAD5ABFF_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622  V_0;
	memset(&V_0, 0, sizeof(V_0));
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___value0));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, ent_op_Implicit_m7B45657F4A2AE01FC3A5AC35BF156D72DAD5ABFF_RuntimeMethod_var, NULL, methodExecutionContextParameters, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 59928);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 59929);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 59930);
		// return new ent(value);
		CHECK_SEQ_POINT(methodExecutionContext, 59931);
		int32_t L_0 = ___value0;
		STORE_SEQ_POINT(methodExecutionContext, 59933);
		ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622  L_1;
		memset(&L_1, 0, sizeof(L_1));
		ent__ctor_m687198B81484B7EA5A3EB6F226AA5CE1F2B52F6E((&L_1), L_0, (-1), /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 59933);
		V_0 = L_1;
		goto IL_000b;
	}

IL_000b:
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 59932);
		ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622  L_2 = V_0;
		return L_2;
	}
}
// Pixeye.ent Pixeye.ent::op_Addition(Pixeye.ent,System.Int32)
extern "C" IL2CPP_METHOD_ATTR ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622  ent_op_Addition_m8DF8CC2936EEE52AFB9DD1B668222FAC4C802BA6 (ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622  ___a0, int32_t ___b1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (ent_op_Addition_m8DF8CC2936EEE52AFB9DD1B668222FAC4C802BA6_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622  V_0;
	memset(&V_0, 0, sizeof(V_0));
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___a0), (&___b1));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, ent_op_Addition_m8DF8CC2936EEE52AFB9DD1B668222FAC4C802BA6_RuntimeMethod_var, NULL, methodExecutionContextParameters, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 59934);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 59935);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 59936);
		// return new ent(a.id + b, a.hash);
		CHECK_SEQ_POINT(methodExecutionContext, 59937);
		ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622  L_0 = ___a0;
		int32_t L_1 = L_0.get_id_0();
		int32_t L_2 = ___b1;
		ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622  L_3 = ___a0;
		int32_t L_4 = L_3.get_hash_1();
		STORE_SEQ_POINT(methodExecutionContext, 59939);
		ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622  L_5;
		memset(&L_5, 0, sizeof(L_5));
		ent__ctor_m687198B81484B7EA5A3EB6F226AA5CE1F2B52F6E((&L_5), ((int32_t)il2cpp_codegen_add((int32_t)L_1, (int32_t)L_2)), L_4, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 59939);
		V_0 = L_5;
		goto IL_0017;
	}

IL_0017:
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 59938);
		ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622  L_6 = V_0;
		return L_6;
	}
}
// Pixeye.ent Pixeye.ent::op_Subtraction(Pixeye.ent,System.Int32)
extern "C" IL2CPP_METHOD_ATTR ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622  ent_op_Subtraction_m5A4B3BEA36BAFFF4EB8558BDAF7009313FD2A552 (ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622  ___a0, int32_t ___b1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (ent_op_Subtraction_m5A4B3BEA36BAFFF4EB8558BDAF7009313FD2A552_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622  V_0;
	memset(&V_0, 0, sizeof(V_0));
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___a0), (&___b1));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, ent_op_Subtraction_m5A4B3BEA36BAFFF4EB8558BDAF7009313FD2A552_RuntimeMethod_var, NULL, methodExecutionContextParameters, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 59940);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 59941);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 59942);
		// return new ent(a.id - b, a.hash);
		CHECK_SEQ_POINT(methodExecutionContext, 59943);
		ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622  L_0 = ___a0;
		int32_t L_1 = L_0.get_id_0();
		int32_t L_2 = ___b1;
		ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622  L_3 = ___a0;
		int32_t L_4 = L_3.get_hash_1();
		STORE_SEQ_POINT(methodExecutionContext, 59945);
		ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622  L_5;
		memset(&L_5, 0, sizeof(L_5));
		ent__ctor_m687198B81484B7EA5A3EB6F226AA5CE1F2B52F6E((&L_5), ((int32_t)il2cpp_codegen_subtract((int32_t)L_1, (int32_t)L_2)), L_4, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 59945);
		V_0 = L_5;
		goto IL_0017;
	}

IL_0017:
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 59944);
		ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622  L_6 = V_0;
		return L_6;
	}
}
// System.Int32 Pixeye.ent::CompareTo(System.Object)
extern "C" IL2CPP_METHOD_ATTR int32_t ent_CompareTo_mE8416899740A9FE48A8295ED4B796B13DD0A97BE (ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * __this, RuntimeObject * ___value0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (ent_CompareTo_mE8416899740A9FE48A8295ED4B796B13DD0A97BE_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	bool V_1 = false;
	int32_t V_2 = 0;
	bool V_3 = false;
	bool V_4 = false;
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___value0));
	DECLARE_METHOD_LOCALS(methodExecutionContextLocals, (&V_0));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, ent_CompareTo_mE8416899740A9FE48A8295ED4B796B13DD0A97BE_RuntimeMethod_var, methodExecutionContextThis, methodExecutionContextParameters, methodExecutionContextLocals);
	CHECK_SEQ_POINT(methodExecutionContext, 59946);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 59947);
	int32_t G_B9_0 = 0;
	{
		CHECK_SEQ_POINT(methodExecutionContext, 59948);
		// if (value == null)
		CHECK_SEQ_POINT(methodExecutionContext, 59949);
		RuntimeObject * L_0 = ___value0;
		V_1 = (bool)((((RuntimeObject*)(RuntimeObject *)L_0) == ((RuntimeObject*)(RuntimeObject *)NULL))? 1 : 0);
		CHECK_SEQ_POINT(methodExecutionContext, 59950);
		bool L_1 = V_1;
		if (!L_1)
		{
			goto IL_000d;
		}
	}
	{
		// return 1;
		CHECK_SEQ_POINT(methodExecutionContext, 59951);
		V_2 = 1;
		goto IL_0049;
	}

IL_000d:
	{
		// if (!(value is int))
		CHECK_SEQ_POINT(methodExecutionContext, 59952);
		RuntimeObject * L_2 = ___value0;
		V_3 = (bool)((((int32_t)((!(((RuntimeObject*)(RuntimeObject *)((RuntimeObject *)IsInstSealed((RuntimeObject*)L_2, Int32_t585191389E07734F19F3156FF88FB3EF4800D102_il2cpp_TypeInfo_var))) <= ((RuntimeObject*)(RuntimeObject *)NULL)))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		CHECK_SEQ_POINT(methodExecutionContext, 59953);
		bool L_3 = V_3;
		if (!L_3)
		{
			goto IL_001f;
		}
	}
	{
		CHECK_SEQ_POINT(methodExecutionContext, 59954);
		CHECK_SEQ_POINT(methodExecutionContext, 59955);
	}

IL_001f:
	{
		// int num = (int) value;
		CHECK_SEQ_POINT(methodExecutionContext, 59956);
		RuntimeObject * L_4 = ___value0;
		V_0 = ((*(int32_t*)((int32_t*)UnBox(L_4, Int32_t585191389E07734F19F3156FF88FB3EF4800D102_il2cpp_TypeInfo_var))));
		// if (id < num)
		CHECK_SEQ_POINT(methodExecutionContext, 59957);
		int32_t L_5 = __this->get_id_0();
		int32_t L_6 = V_0;
		V_4 = (bool)((((int32_t)L_5) < ((int32_t)L_6))? 1 : 0);
		CHECK_SEQ_POINT(methodExecutionContext, 59958);
		bool L_7 = V_4;
		if (!L_7)
		{
			goto IL_0039;
		}
	}
	{
		// return -1;
		CHECK_SEQ_POINT(methodExecutionContext, 59959);
		V_2 = (-1);
		goto IL_0049;
	}

IL_0039:
	{
		// return id > num ? 1 : 0;
		CHECK_SEQ_POINT(methodExecutionContext, 59960);
		int32_t L_8 = __this->get_id_0();
		int32_t L_9 = V_0;
		if ((((int32_t)L_8) > ((int32_t)L_9)))
		{
			goto IL_0045;
		}
	}
	{
		G_B9_0 = 0;
		goto IL_0046;
	}

IL_0045:
	{
		G_B9_0 = 1;
	}

IL_0046:
	{
		V_2 = G_B9_0;
		goto IL_0049;
	}

IL_0049:
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 59961);
		int32_t L_10 = V_2;
		return L_10;
	}
}
extern "C"  int32_t ent_CompareTo_mE8416899740A9FE48A8295ED4B796B13DD0A97BE_AdjustorThunk (RuntimeObject * __this, RuntimeObject * ___value0, const RuntimeMethod* method)
{
	ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * _thisAdjusted = reinterpret_cast<ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 *>(__this + 1);
	return ent_CompareTo_mE8416899740A9FE48A8295ED4B796B13DD0A97BE(_thisAdjusted, ___value0, method);
}
// System.Int32 Pixeye.ent::CompareTo(System.Int32)
extern "C" IL2CPP_METHOD_ATTR int32_t ent_CompareTo_m0B254BB7E07D9944123F1F542D006388839908EC (ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * __this, int32_t ___value0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (ent_CompareTo_m0B254BB7E07D9944123F1F542D006388839908EC_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	int32_t V_1 = 0;
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___value0));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, ent_CompareTo_m0B254BB7E07D9944123F1F542D006388839908EC_RuntimeMethod_var, methodExecutionContextThis, methodExecutionContextParameters, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 59962);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 59963);
	int32_t G_B5_0 = 0;
	{
		CHECK_SEQ_POINT(methodExecutionContext, 59964);
		// if (id < value)
		CHECK_SEQ_POINT(methodExecutionContext, 59965);
		int32_t L_0 = __this->get_id_0();
		int32_t L_1 = ___value0;
		V_0 = (bool)((((int32_t)L_0) < ((int32_t)L_1))? 1 : 0);
		CHECK_SEQ_POINT(methodExecutionContext, 59966);
		bool L_2 = V_0;
		if (!L_2)
		{
			goto IL_0012;
		}
	}
	{
		// return -1;
		CHECK_SEQ_POINT(methodExecutionContext, 59967);
		V_1 = (-1);
		goto IL_0022;
	}

IL_0012:
	{
		// return id > value ? 1 : 0;
		CHECK_SEQ_POINT(methodExecutionContext, 59968);
		int32_t L_3 = __this->get_id_0();
		int32_t L_4 = ___value0;
		if ((((int32_t)L_3) > ((int32_t)L_4)))
		{
			goto IL_001e;
		}
	}
	{
		G_B5_0 = 0;
		goto IL_001f;
	}

IL_001e:
	{
		G_B5_0 = 1;
	}

IL_001f:
	{
		V_1 = G_B5_0;
		goto IL_0022;
	}

IL_0022:
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 59969);
		int32_t L_5 = V_1;
		return L_5;
	}
}
extern "C"  int32_t ent_CompareTo_m0B254BB7E07D9944123F1F542D006388839908EC_AdjustorThunk (RuntimeObject * __this, int32_t ___value0, const RuntimeMethod* method)
{
	ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * _thisAdjusted = reinterpret_cast<ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 *>(__this + 1);
	return ent_CompareTo_m0B254BB7E07D9944123F1F542D006388839908EC(_thisAdjusted, ___value0, method);
}
// System.Boolean Pixeye.ent::Equals(System.Object)
extern "C" IL2CPP_METHOD_ATTR bool ent_Equals_m6D047D20BE89EC823DDD217C6905F1B454A82049 (ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * __this, RuntimeObject * ___obj0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (ent_Equals_m6D047D20BE89EC823DDD217C6905F1B454A82049_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	bool V_1 = false;
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___obj0));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, ent_Equals_m6D047D20BE89EC823DDD217C6905F1B454A82049_RuntimeMethod_var, methodExecutionContextThis, methodExecutionContextParameters, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 59970);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 59971);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 59972);
		// if (!(obj is int))
		CHECK_SEQ_POINT(methodExecutionContext, 59973);
		RuntimeObject * L_0 = ___obj0;
		V_0 = (bool)((((int32_t)((!(((RuntimeObject*)(RuntimeObject *)((RuntimeObject *)IsInstSealed((RuntimeObject*)L_0, Int32_t585191389E07734F19F3156FF88FB3EF4800D102_il2cpp_TypeInfo_var))) <= ((RuntimeObject*)(RuntimeObject *)NULL)))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		CHECK_SEQ_POINT(methodExecutionContext, 59974);
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_0015;
		}
	}
	{
		// return false;
		CHECK_SEQ_POINT(methodExecutionContext, 59975);
		V_1 = (bool)0;
		goto IL_0026;
	}

IL_0015:
	{
		// return id == (int) obj;
		CHECK_SEQ_POINT(methodExecutionContext, 59976);
		int32_t L_2 = __this->get_id_0();
		RuntimeObject * L_3 = ___obj0;
		V_1 = (bool)((((int32_t)L_2) == ((int32_t)((*(int32_t*)((int32_t*)UnBox(L_3, Int32_t585191389E07734F19F3156FF88FB3EF4800D102_il2cpp_TypeInfo_var))))))? 1 : 0);
		goto IL_0026;
	}

IL_0026:
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 59977);
		bool L_4 = V_1;
		return L_4;
	}
}
extern "C"  bool ent_Equals_m6D047D20BE89EC823DDD217C6905F1B454A82049_AdjustorThunk (RuntimeObject * __this, RuntimeObject * ___obj0, const RuntimeMethod* method)
{
	ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * _thisAdjusted = reinterpret_cast<ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 *>(__this + 1);
	return ent_Equals_m6D047D20BE89EC823DDD217C6905F1B454A82049(_thisAdjusted, ___obj0, method);
}
// System.Boolean Pixeye.ent::Equals(System.Int32)
extern "C" IL2CPP_METHOD_ATTR bool ent_Equals_m17106E28D6874576C7BC82063A2D7EDE88CB1F8C (ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * __this, int32_t ___obj0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (ent_Equals_m17106E28D6874576C7BC82063A2D7EDE88CB1F8C_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___obj0));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, ent_Equals_m17106E28D6874576C7BC82063A2D7EDE88CB1F8C_RuntimeMethod_var, methodExecutionContextThis, methodExecutionContextParameters, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 59978);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 59979);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 59980);
		// return id == obj;
		CHECK_SEQ_POINT(methodExecutionContext, 59981);
		int32_t L_0 = __this->get_id_0();
		int32_t L_1 = ___obj0;
		V_0 = (bool)((((int32_t)L_0) == ((int32_t)L_1))? 1 : 0);
		goto IL_000d;
	}

IL_000d:
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 59982);
		bool L_2 = V_0;
		return L_2;
	}
}
extern "C"  bool ent_Equals_m17106E28D6874576C7BC82063A2D7EDE88CB1F8C_AdjustorThunk (RuntimeObject * __this, int32_t ___obj0, const RuntimeMethod* method)
{
	ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * _thisAdjusted = reinterpret_cast<ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 *>(__this + 1);
	return ent_Equals_m17106E28D6874576C7BC82063A2D7EDE88CB1F8C(_thisAdjusted, ___obj0, method);
}
// System.Int32 Pixeye.ent::GetHashCode()
extern "C" IL2CPP_METHOD_ATTR int32_t ent_GetHashCode_m0A4671ADC4A691FEC3BC1CFC742A114831A259A4 (ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (ent_GetHashCode_m0A4671ADC4A691FEC3BC1CFC742A114831A259A4_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, ent_GetHashCode_m0A4671ADC4A691FEC3BC1CFC742A114831A259A4_RuntimeMethod_var, methodExecutionContextThis, NULL, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 59983);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 59984);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 59985);
		// return hash;
		CHECK_SEQ_POINT(methodExecutionContext, 59986);
		int32_t L_0 = __this->get_hash_1();
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 59987);
		int32_t L_1 = V_0;
		return L_1;
	}
}
extern "C"  int32_t ent_GetHashCode_m0A4671ADC4A691FEC3BC1CFC742A114831A259A4_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * _thisAdjusted = reinterpret_cast<ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 *>(__this + 1);
	return ent_GetHashCode_m0A4671ADC4A691FEC3BC1CFC742A114831A259A4(_thisAdjusted, method);
}
// System.Void Pixeye.ent::Release()
extern "C" IL2CPP_METHOD_ATTR void ent_Release_m8211BD2C827CC92F4B8D97385D87A463C3193441 (ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (ent_Release_m8211BD2C827CC92F4B8D97385D87A463C3193441_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	EntityComposer_tB9CD47E805A3232A943F6CF48BB084FB1646CCD3 * V_0 = NULL;
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_LOCALS(methodExecutionContextLocals, (&V_0));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, ent_Release_m8211BD2C827CC92F4B8D97385D87A463C3193441_RuntimeMethod_var, methodExecutionContextThis, NULL, methodExecutionContextLocals);
	CHECK_SEQ_POINT(methodExecutionContext, 59995);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 59996);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 59997);
		// var composer = EntityComposer.Create(this);
		CHECK_SEQ_POINT(methodExecutionContext, 59998);
		STORE_SEQ_POINT(methodExecutionContext, 60002);
		IL2CPP_RUNTIME_CLASS_INIT(EntityComposer_tB9CD47E805A3232A943F6CF48BB084FB1646CCD3_il2cpp_TypeInfo_var);
		EntityComposer_tB9CD47E805A3232A943F6CF48BB084FB1646CCD3 * L_0 = EntityComposer_Create_m72594803BFEBDB2D4D5AD6A828E038E30E9969DF((ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 *)__this, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 60002);
		V_0 = L_0;
		// composer.Add<ComponentRelease>();
		CHECK_SEQ_POINT(methodExecutionContext, 59999);
		EntityComposer_tB9CD47E805A3232A943F6CF48BB084FB1646CCD3 * L_1 = V_0;
		STORE_SEQ_POINT(methodExecutionContext, 60003);
		NullCheck(L_1, il2cpp_codegen_get_sequence_point(59999));
		EntityComposer_Add_TisComponentRelease_t98EE3880490384D15031D69FB587E1C7D806E527_mB10072EEB7AAEBA7111D3FB268286C9C36E9FB47(L_1, /*hidden argument*/EntityComposer_Add_TisComponentRelease_t98EE3880490384D15031D69FB587E1C7D806E527_mB10072EEB7AAEBA7111D3FB268286C9C36E9FB47_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 60003);
		// composer.Deploy();
		CHECK_SEQ_POINT(methodExecutionContext, 60000);
		EntityComposer_tB9CD47E805A3232A943F6CF48BB084FB1646CCD3 * L_2 = V_0;
		STORE_SEQ_POINT(methodExecutionContext, 60004);
		NullCheck(L_2, il2cpp_codegen_get_sequence_point(60000));
		EntityComposer_Deploy_m05DF6C2544245D2BFBD70A249C5DAFFC797AF318(L_2, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 60004);
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 60001);
		return;
	}
}
extern "C"  void ent_Release_m8211BD2C827CC92F4B8D97385D87A463C3193441_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * _thisAdjusted = reinterpret_cast<ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 *>(__this + 1);
	ent_Release_m8211BD2C827CC92F4B8D97385D87A463C3193441(_thisAdjusted, method);
}
// System.Boolean Pixeye.ent::Exist()
extern "C" IL2CPP_METHOD_ATTR bool ent_Exist_m7DF7BEF41163A226515F8EC5A7DAF61B227090D7 (ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (ent_Exist_m7DF7BEF41163A226515F8EC5A7DAF61B227090D7_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, ent_Exist_m7DF7BEF41163A226515F8EC5A7DAF61B227090D7_RuntimeMethod_var, methodExecutionContextThis, NULL, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 60005);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 60006);
	int32_t G_B4_0 = 0;
	{
		CHECK_SEQ_POINT(methodExecutionContext, 60007);
		// return id > -1 && RefEntity.isAlive[id] && RefEntity.transforms[id].GetHashCode() == hash;
		CHECK_SEQ_POINT(methodExecutionContext, 60008);
		int32_t L_0 = __this->get_id_0();
		if ((((int32_t)L_0) <= ((int32_t)(-1))))
		{
			goto IL_0033;
		}
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(RefEntity_t5823EB2D89C01C8E8581EC0091D5168FBA887089_il2cpp_TypeInfo_var);
		BooleanU5BU5D_t192C7579715690E25BD5EFED47F3E0FC9DCB2040* L_1 = ((RefEntity_t5823EB2D89C01C8E8581EC0091D5168FBA887089_StaticFields*)il2cpp_codegen_static_fields_for(RefEntity_t5823EB2D89C01C8E8581EC0091D5168FBA887089_il2cpp_TypeInfo_var))->get_isAlive_3();
		int32_t L_2 = __this->get_id_0();
		NullCheck(L_1, il2cpp_codegen_get_sequence_point(60008));
		int32_t L_3 = L_2;
		uint8_t L_4 = (uint8_t)(L_1)->GetAt(static_cast<il2cpp_array_size_t>(L_3));
		if (!L_4)
		{
			goto IL_0033;
		}
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(RefEntity_t5823EB2D89C01C8E8581EC0091D5168FBA887089_il2cpp_TypeInfo_var);
		TransformU5BU5D_t3EB9781D1A1DE2674F0632C956A66AA423343139* L_5 = ((RefEntity_t5823EB2D89C01C8E8581EC0091D5168FBA887089_StaticFields*)il2cpp_codegen_static_fields_for(RefEntity_t5823EB2D89C01C8E8581EC0091D5168FBA887089_il2cpp_TypeInfo_var))->get_transforms_6();
		int32_t L_6 = __this->get_id_0();
		NullCheck(L_5, il2cpp_codegen_get_sequence_point(60008));
		int32_t L_7 = L_6;
		Transform_tBB9E78A2766C3C83599A8F66EDE7D1FCAFC66EDA * L_8 = (L_5)->GetAt(static_cast<il2cpp_array_size_t>(L_7));
		STORE_SEQ_POINT(methodExecutionContext, 60010);
		NullCheck(L_8, il2cpp_codegen_get_sequence_point(60008));
		int32_t L_9 = VirtFuncInvoker0< int32_t >::Invoke(2 /* System.Int32 System.Object::GetHashCode() */, L_8);
		CHECK_SEQ_POINT(methodExecutionContext, 60010);
		int32_t L_10 = __this->get_hash_1();
		G_B4_0 = ((((int32_t)L_9) == ((int32_t)L_10))? 1 : 0);
		goto IL_0034;
	}

IL_0033:
	{
		G_B4_0 = 0;
	}

IL_0034:
	{
		V_0 = (bool)G_B4_0;
		goto IL_0037;
	}

IL_0037:
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 60009);
		bool L_11 = V_0;
		return L_11;
	}
}
extern "C"  bool ent_Exist_m7DF7BEF41163A226515F8EC5A7DAF61B227090D7_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 * _thisAdjusted = reinterpret_cast<ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 *>(__this + 1);
	return ent_Exist_m7DF7BEF41163A226515F8EC5A7DAF61B227090D7(_thisAdjusted, method);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
extern "C"  void DelegatePInvokeWrapper_taskEntity_tB8531E29867EAB8E27F86237A4F1F4BD04F72D38 (taskEntity_tB8531E29867EAB8E27F86237A4F1F4BD04F72D38 * __this, ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622  ___entity0, const RuntimeMethod* method)
{
	typedef void (DEFAULT_CALL *PInvokeFunc)(ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 );
	PInvokeFunc il2cppPInvokeFunc = reinterpret_cast<PInvokeFunc>(il2cpp_codegen_get_method_pointer(((RuntimeDelegate*)__this)->method));

	// Native function invocation
	il2cppPInvokeFunc(___entity0);

}
// System.Void Pixeye.taskEntity::.ctor(System.Object,System.IntPtr)
extern "C" IL2CPP_METHOD_ATTR void taskEntity__ctor_m9D716324AAEFBF18D711C2798E720F942DB7ACC9 (taskEntity_tB8531E29867EAB8E27F86237A4F1F4BD04F72D38 * __this, RuntimeObject * ___object0, intptr_t ___method1, const RuntimeMethod* method)
{
	__this->set_method_ptr_0(il2cpp_codegen_get_method_pointer((RuntimeMethod*)___method1));
	__this->set_method_3(___method1);
	__this->set_m_target_2(___object0);
}
// System.Void Pixeye.taskEntity::Invoke(Pixeye.ent)
extern "C" IL2CPP_METHOD_ATTR void taskEntity_Invoke_m64C52E3ECA7439463E402619F72AFA8E1AF1942B (taskEntity_tB8531E29867EAB8E27F86237A4F1F4BD04F72D38 * __this, ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622  ___entity0, const RuntimeMethod* method)
{
	DelegateU5BU5D_tDFCDEE2A6322F96C0FE49AF47E9ADB8C4B294E86* delegatesToInvoke = __this->get_delegates_11();
	if (delegatesToInvoke != NULL)
	{
		il2cpp_array_size_t length = delegatesToInvoke->max_length;
		for (il2cpp_array_size_t i = 0; i < length; i++)
		{
			Delegate_t* currentDelegate = (delegatesToInvoke)->GetAtUnchecked(static_cast<il2cpp_array_size_t>(i));
			Il2CppMethodPointer targetMethodPointer = currentDelegate->get_method_ptr_0();
			RuntimeMethod* targetMethod = (RuntimeMethod*)(currentDelegate->get_method_3());
			RuntimeObject* targetThis = currentDelegate->get_m_target_2();
			if (!il2cpp_codegen_method_is_virtual(targetMethod))
			{
				il2cpp_codegen_raise_execution_engine_exception_if_method_is_not_found(targetMethod);
			}
			bool ___methodIsStatic = MethodIsStatic(targetMethod);
			int ___parameterCount = il2cpp_codegen_method_parameter_count(targetMethod);
			if (___methodIsStatic)
			{
				if (___parameterCount == 1)
				{
					// open
					typedef void (*FunctionPointerType) (ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 , const RuntimeMethod*);
					((FunctionPointerType)targetMethodPointer)(___entity0, targetMethod);
				}
				else
				{
					// closed
					typedef void (*FunctionPointerType) (void*, ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 , const RuntimeMethod*);
					((FunctionPointerType)targetMethodPointer)(targetThis, ___entity0, targetMethod);
				}
			}
			else
			{
				// closed
				if (il2cpp_codegen_method_is_virtual(targetMethod) && !il2cpp_codegen_object_is_of_sealed_type(targetThis) && il2cpp_codegen_delegate_has_invoker((Il2CppDelegate*)__this))
				{
					if (il2cpp_codegen_method_is_virtual(targetMethod) && !il2cpp_codegen_object_is_of_sealed_type(targetThis) && il2cpp_codegen_delegate_has_invoker((Il2CppDelegate*)__this))
					{
						if (targetThis == NULL)
						{
							typedef void (*FunctionPointerType) (ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 , const RuntimeMethod*);
							((FunctionPointerType)targetMethodPointer)(___entity0, targetMethod);
						}
						else if (il2cpp_codegen_method_is_generic_instance(targetMethod))
						{
							if (il2cpp_codegen_method_is_interface_method(targetMethod))
								GenericInterfaceActionInvoker1< ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622  >::Invoke(targetMethod, targetThis, ___entity0);
							else
								GenericVirtActionInvoker1< ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622  >::Invoke(targetMethod, targetThis, ___entity0);
						}
						else
						{
							if (il2cpp_codegen_method_is_interface_method(targetMethod))
								InterfaceActionInvoker1< ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622  >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), il2cpp_codegen_method_get_declaring_type(targetMethod), targetThis, ___entity0);
							else
								VirtActionInvoker1< ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622  >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), targetThis, ___entity0);
						}
					}
				}
				else
				{
					typedef void (*FunctionPointerType) (void*, ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 , const RuntimeMethod*);
					((FunctionPointerType)targetMethodPointer)(targetThis, ___entity0, targetMethod);
				}
			}
		}
	}
	else
	{
		Il2CppMethodPointer targetMethodPointer = __this->get_method_ptr_0();
		RuntimeMethod* targetMethod = (RuntimeMethod*)(__this->get_method_3());
		RuntimeObject* targetThis = __this->get_m_target_2();
		if (!il2cpp_codegen_method_is_virtual(targetMethod))
		{
			il2cpp_codegen_raise_execution_engine_exception_if_method_is_not_found(targetMethod);
		}
		bool ___methodIsStatic = MethodIsStatic(targetMethod);
		int ___parameterCount = il2cpp_codegen_method_parameter_count(targetMethod);
		if (___methodIsStatic)
		{
			if (___parameterCount == 1)
			{
				// open
				typedef void (*FunctionPointerType) (ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 , const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(___entity0, targetMethod);
			}
			else
			{
				// closed
				typedef void (*FunctionPointerType) (void*, ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 , const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetThis, ___entity0, targetMethod);
			}
		}
		else
		{
			// closed
			if (il2cpp_codegen_method_is_virtual(targetMethod) && !il2cpp_codegen_object_is_of_sealed_type(targetThis) && il2cpp_codegen_delegate_has_invoker((Il2CppDelegate*)__this))
			{
				if (il2cpp_codegen_method_is_virtual(targetMethod) && !il2cpp_codegen_object_is_of_sealed_type(targetThis) && il2cpp_codegen_delegate_has_invoker((Il2CppDelegate*)__this))
				{
					if (targetThis == NULL)
					{
						typedef void (*FunctionPointerType) (ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 , const RuntimeMethod*);
						((FunctionPointerType)targetMethodPointer)(___entity0, targetMethod);
					}
					else if (il2cpp_codegen_method_is_generic_instance(targetMethod))
					{
						if (il2cpp_codegen_method_is_interface_method(targetMethod))
							GenericInterfaceActionInvoker1< ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622  >::Invoke(targetMethod, targetThis, ___entity0);
						else
							GenericVirtActionInvoker1< ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622  >::Invoke(targetMethod, targetThis, ___entity0);
					}
					else
					{
						if (il2cpp_codegen_method_is_interface_method(targetMethod))
							InterfaceActionInvoker1< ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622  >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), il2cpp_codegen_method_get_declaring_type(targetMethod), targetThis, ___entity0);
						else
							VirtActionInvoker1< ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622  >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), targetThis, ___entity0);
					}
				}
			}
			else
			{
				typedef void (*FunctionPointerType) (void*, ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 , const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetThis, ___entity0, targetMethod);
			}
		}
	}
}
// System.IAsyncResult Pixeye.taskEntity::BeginInvoke(Pixeye.ent,System.AsyncCallback,System.Object)
extern "C" IL2CPP_METHOD_ATTR RuntimeObject* taskEntity_BeginInvoke_mED189307ED4072A522DFF8A17361DE763F44897D (taskEntity_tB8531E29867EAB8E27F86237A4F1F4BD04F72D38 * __this, ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622  ___entity0, AsyncCallback_t3F3DA3BEDAEE81DD1D24125DF8EB30E85EE14DA4 * ___callback1, RuntimeObject * ___object2, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (taskEntity_BeginInvoke_mED189307ED4072A522DFF8A17361DE763F44897D_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	void *__d_args[2] = {0};
	__d_args[0] = Box(ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622_il2cpp_TypeInfo_var, &___entity0);
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___callback1, (RuntimeObject*)___object2);
}
// System.Void Pixeye.taskEntity::EndInvoke(System.IAsyncResult)
extern "C" IL2CPP_METHOD_ATTR void taskEntity_EndInvoke_mBC61EB40C3250B7023F6017D1D46999A135607CA (taskEntity_tB8531E29867EAB8E27F86237A4F1F4BD04F72D38 * __this, RuntimeObject* ___result0, const RuntimeMethod* method)
{
	il2cpp_codegen_delegate_end_invoke((Il2CppAsyncResult*) ___result0, 0);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
extern "C"  void DelegatePInvokeWrapper_taskEntityTick_t17493A17530F9C48141A795A60FC76E0C9E35567 (taskEntityTick_t17493A17530F9C48141A795A60FC76E0C9E35567 * __this, ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622  ___entity0, float ___delta1, const RuntimeMethod* method)
{
	typedef void (DEFAULT_CALL *PInvokeFunc)(ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 , float);
	PInvokeFunc il2cppPInvokeFunc = reinterpret_cast<PInvokeFunc>(il2cpp_codegen_get_method_pointer(((RuntimeDelegate*)__this)->method));

	// Native function invocation
	il2cppPInvokeFunc(___entity0, ___delta1);

}
// System.Void Pixeye.taskEntityTick::.ctor(System.Object,System.IntPtr)
extern "C" IL2CPP_METHOD_ATTR void taskEntityTick__ctor_m401BCAD93A07CB05243FCAAF90F25430FAA0C531 (taskEntityTick_t17493A17530F9C48141A795A60FC76E0C9E35567 * __this, RuntimeObject * ___object0, intptr_t ___method1, const RuntimeMethod* method)
{
	__this->set_method_ptr_0(il2cpp_codegen_get_method_pointer((RuntimeMethod*)___method1));
	__this->set_method_3(___method1);
	__this->set_m_target_2(___object0);
}
// System.Void Pixeye.taskEntityTick::Invoke(Pixeye.ent,System.Single)
extern "C" IL2CPP_METHOD_ATTR void taskEntityTick_Invoke_mA1B853710854924039B80263998C90725CB2E9CF (taskEntityTick_t17493A17530F9C48141A795A60FC76E0C9E35567 * __this, ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622  ___entity0, float ___delta1, const RuntimeMethod* method)
{
	DelegateU5BU5D_tDFCDEE2A6322F96C0FE49AF47E9ADB8C4B294E86* delegatesToInvoke = __this->get_delegates_11();
	if (delegatesToInvoke != NULL)
	{
		il2cpp_array_size_t length = delegatesToInvoke->max_length;
		for (il2cpp_array_size_t i = 0; i < length; i++)
		{
			Delegate_t* currentDelegate = (delegatesToInvoke)->GetAtUnchecked(static_cast<il2cpp_array_size_t>(i));
			Il2CppMethodPointer targetMethodPointer = currentDelegate->get_method_ptr_0();
			RuntimeMethod* targetMethod = (RuntimeMethod*)(currentDelegate->get_method_3());
			RuntimeObject* targetThis = currentDelegate->get_m_target_2();
			if (!il2cpp_codegen_method_is_virtual(targetMethod))
			{
				il2cpp_codegen_raise_execution_engine_exception_if_method_is_not_found(targetMethod);
			}
			bool ___methodIsStatic = MethodIsStatic(targetMethod);
			int ___parameterCount = il2cpp_codegen_method_parameter_count(targetMethod);
			if (___methodIsStatic)
			{
				if (___parameterCount == 2)
				{
					// open
					typedef void (*FunctionPointerType) (ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 , float, const RuntimeMethod*);
					((FunctionPointerType)targetMethodPointer)(___entity0, ___delta1, targetMethod);
				}
				else
				{
					// closed
					typedef void (*FunctionPointerType) (void*, ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 , float, const RuntimeMethod*);
					((FunctionPointerType)targetMethodPointer)(targetThis, ___entity0, ___delta1, targetMethod);
				}
			}
			else
			{
				// closed
				if (il2cpp_codegen_method_is_virtual(targetMethod) && !il2cpp_codegen_object_is_of_sealed_type(targetThis) && il2cpp_codegen_delegate_has_invoker((Il2CppDelegate*)__this))
				{
					if (il2cpp_codegen_method_is_virtual(targetMethod) && !il2cpp_codegen_object_is_of_sealed_type(targetThis) && il2cpp_codegen_delegate_has_invoker((Il2CppDelegate*)__this))
					{
						if (targetThis == NULL)
						{
							typedef void (*FunctionPointerType) (ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 , float, const RuntimeMethod*);
							((FunctionPointerType)targetMethodPointer)(___entity0, ___delta1, targetMethod);
						}
						else if (il2cpp_codegen_method_is_generic_instance(targetMethod))
						{
							if (il2cpp_codegen_method_is_interface_method(targetMethod))
								GenericInterfaceActionInvoker2< ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 , float >::Invoke(targetMethod, targetThis, ___entity0, ___delta1);
							else
								GenericVirtActionInvoker2< ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 , float >::Invoke(targetMethod, targetThis, ___entity0, ___delta1);
						}
						else
						{
							if (il2cpp_codegen_method_is_interface_method(targetMethod))
								InterfaceActionInvoker2< ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 , float >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), il2cpp_codegen_method_get_declaring_type(targetMethod), targetThis, ___entity0, ___delta1);
							else
								VirtActionInvoker2< ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 , float >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), targetThis, ___entity0, ___delta1);
						}
					}
				}
				else
				{
					typedef void (*FunctionPointerType) (void*, ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 , float, const RuntimeMethod*);
					((FunctionPointerType)targetMethodPointer)(targetThis, ___entity0, ___delta1, targetMethod);
				}
			}
		}
	}
	else
	{
		Il2CppMethodPointer targetMethodPointer = __this->get_method_ptr_0();
		RuntimeMethod* targetMethod = (RuntimeMethod*)(__this->get_method_3());
		RuntimeObject* targetThis = __this->get_m_target_2();
		if (!il2cpp_codegen_method_is_virtual(targetMethod))
		{
			il2cpp_codegen_raise_execution_engine_exception_if_method_is_not_found(targetMethod);
		}
		bool ___methodIsStatic = MethodIsStatic(targetMethod);
		int ___parameterCount = il2cpp_codegen_method_parameter_count(targetMethod);
		if (___methodIsStatic)
		{
			if (___parameterCount == 2)
			{
				// open
				typedef void (*FunctionPointerType) (ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 , float, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(___entity0, ___delta1, targetMethod);
			}
			else
			{
				// closed
				typedef void (*FunctionPointerType) (void*, ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 , float, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetThis, ___entity0, ___delta1, targetMethod);
			}
		}
		else
		{
			// closed
			if (il2cpp_codegen_method_is_virtual(targetMethod) && !il2cpp_codegen_object_is_of_sealed_type(targetThis) && il2cpp_codegen_delegate_has_invoker((Il2CppDelegate*)__this))
			{
				if (il2cpp_codegen_method_is_virtual(targetMethod) && !il2cpp_codegen_object_is_of_sealed_type(targetThis) && il2cpp_codegen_delegate_has_invoker((Il2CppDelegate*)__this))
				{
					if (targetThis == NULL)
					{
						typedef void (*FunctionPointerType) (ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 , float, const RuntimeMethod*);
						((FunctionPointerType)targetMethodPointer)(___entity0, ___delta1, targetMethod);
					}
					else if (il2cpp_codegen_method_is_generic_instance(targetMethod))
					{
						if (il2cpp_codegen_method_is_interface_method(targetMethod))
							GenericInterfaceActionInvoker2< ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 , float >::Invoke(targetMethod, targetThis, ___entity0, ___delta1);
						else
							GenericVirtActionInvoker2< ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 , float >::Invoke(targetMethod, targetThis, ___entity0, ___delta1);
					}
					else
					{
						if (il2cpp_codegen_method_is_interface_method(targetMethod))
							InterfaceActionInvoker2< ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 , float >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), il2cpp_codegen_method_get_declaring_type(targetMethod), targetThis, ___entity0, ___delta1);
						else
							VirtActionInvoker2< ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 , float >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), targetThis, ___entity0, ___delta1);
					}
				}
			}
			else
			{
				typedef void (*FunctionPointerType) (void*, ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622 , float, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetThis, ___entity0, ___delta1, targetMethod);
			}
		}
	}
}
// System.IAsyncResult Pixeye.taskEntityTick::BeginInvoke(Pixeye.ent,System.Single,System.AsyncCallback,System.Object)
extern "C" IL2CPP_METHOD_ATTR RuntimeObject* taskEntityTick_BeginInvoke_mA6EA9DB394B9BD9B9425F0983B7C90828FF071CC (taskEntityTick_t17493A17530F9C48141A795A60FC76E0C9E35567 * __this, ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622  ___entity0, float ___delta1, AsyncCallback_t3F3DA3BEDAEE81DD1D24125DF8EB30E85EE14DA4 * ___callback2, RuntimeObject * ___object3, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (taskEntityTick_BeginInvoke_mA6EA9DB394B9BD9B9425F0983B7C90828FF071CC_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	void *__d_args[3] = {0};
	__d_args[0] = Box(ent_t588AEBB1ED982AC9A990883BC508B4CCD148C622_il2cpp_TypeInfo_var, &___entity0);
	__d_args[1] = Box(Single_tDDDA9169C4E4E308AC6D7A824F9B28DC82204AE1_il2cpp_TypeInfo_var, &___delta1);
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___callback2, (RuntimeObject*)___object3);
}
// System.Void Pixeye.taskEntityTick::EndInvoke(System.IAsyncResult)
extern "C" IL2CPP_METHOD_ATTR void taskEntityTick_EndInvoke_mE0060513F7B9D7FD85803AFB2BEEBB22A68A793D (taskEntityTick_t17493A17530F9C48141A795A60FC76E0C9E35567 * __this, RuntimeObject* ___result0, const RuntimeMethod* method)
{
	il2cpp_codegen_delegate_end_invoke((Il2CppAsyncResult*) ___result0, 0);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void System.ArrayTraverse::.ctor(System.Array)
extern "C" IL2CPP_METHOD_ATTR void ArrayTraverse__ctor_mCC997558A200828072F6A2B76B02E089FABE3741 (ArrayTraverse_tD07A6D4E93DB7941CE934AFF9F006788173C70A6 * __this, RuntimeArray * ___array0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (ArrayTraverse__ctor_mCC997558A200828072F6A2B76B02E089FABE3741_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	bool V_1 = false;
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___array0));
	DECLARE_METHOD_LOCALS(methodExecutionContextLocals, (&V_0));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, ArrayTraverse__ctor_mCC997558A200828072F6A2B76B02E089FABE3741_RuntimeMethod_var, methodExecutionContextThis, methodExecutionContextParameters, methodExecutionContextLocals);
	CHECK_SEQ_POINT(methodExecutionContext, 57866);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 57867);
	{
		// public ArrayTraverse(Array array)
		CHECK_SEQ_POINT(methodExecutionContext, 57868);
		STORE_SEQ_POINT(methodExecutionContext, 57881);
		Object__ctor_m925ECA5E85CA100E3FB86A4F9E15C120E9A184C0(__this, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 57881);
		CHECK_SEQ_POINT(methodExecutionContext, 57869);
		// maxLengths = new int[array.Rank];
		CHECK_SEQ_POINT(methodExecutionContext, 57870);
		RuntimeArray * L_0 = ___array0;
		STORE_SEQ_POINT(methodExecutionContext, 57882);
		NullCheck(L_0, il2cpp_codegen_get_sequence_point(57870));
		int32_t L_1 = Array_get_Rank_m38145B59D67D75F9896A3F8CDA9B966641AE99E1(L_0, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 57882);
		Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* L_2 = (Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83*)SZArrayNew(Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83_il2cpp_TypeInfo_var, (uint32_t)L_1);
		__this->set_maxLengths_1(L_2);
		// for ( int i = 0; i < array.Rank; ++i )
		CHECK_SEQ_POINT(methodExecutionContext, 57871);
		V_0 = 0;
		CHECK_SEQ_POINT(methodExecutionContext, 57872);
		goto IL_0034;
	}

IL_001d:
	{
		CHECK_SEQ_POINT(methodExecutionContext, 57873);
		// maxLengths[i] = array.GetLength(i) - 1;
		CHECK_SEQ_POINT(methodExecutionContext, 57874);
		Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* L_3 = __this->get_maxLengths_1();
		int32_t L_4 = V_0;
		RuntimeArray * L_5 = ___array0;
		int32_t L_6 = V_0;
		STORE_SEQ_POINT(methodExecutionContext, 57883);
		NullCheck(L_5, il2cpp_codegen_get_sequence_point(57874));
		int32_t L_7 = Array_GetLength_m318900B10C3A93A30ABDC67DE161C8F6ABA4D359(L_5, L_6, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 57883);
		NullCheck(L_3, il2cpp_codegen_get_sequence_point(57874));
		(L_3)->SetAt(static_cast<il2cpp_array_size_t>(L_4), (int32_t)((int32_t)il2cpp_codegen_subtract((int32_t)L_7, (int32_t)1)));
		CHECK_SEQ_POINT(methodExecutionContext, 57875);
		// for ( int i = 0; i < array.Rank; ++i )
		CHECK_SEQ_POINT(methodExecutionContext, 57876);
		int32_t L_8 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add((int32_t)L_8, (int32_t)1));
	}

IL_0034:
	{
		// for ( int i = 0; i < array.Rank; ++i )
		CHECK_SEQ_POINT(methodExecutionContext, 57877);
		int32_t L_9 = V_0;
		RuntimeArray * L_10 = ___array0;
		STORE_SEQ_POINT(methodExecutionContext, 57884);
		NullCheck(L_10, il2cpp_codegen_get_sequence_point(57877));
		int32_t L_11 = Array_get_Rank_m38145B59D67D75F9896A3F8CDA9B966641AE99E1(L_10, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 57884);
		V_1 = (bool)((((int32_t)L_9) < ((int32_t)L_11))? 1 : 0);
		CHECK_SEQ_POINT(methodExecutionContext, 57878);
		bool L_12 = V_1;
		if (L_12)
		{
			goto IL_001d;
		}
	}
	{
		// Position = new int[array.Rank];
		CHECK_SEQ_POINT(methodExecutionContext, 57879);
		RuntimeArray * L_13 = ___array0;
		STORE_SEQ_POINT(methodExecutionContext, 57885);
		NullCheck(L_13, il2cpp_codegen_get_sequence_point(57879));
		int32_t L_14 = Array_get_Rank_m38145B59D67D75F9896A3F8CDA9B966641AE99E1(L_13, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 57885);
		Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* L_15 = (Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83*)SZArrayNew(Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83_il2cpp_TypeInfo_var, (uint32_t)L_14);
		__this->set_Position_0(L_15);
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 57880);
		return;
	}
}
// System.Boolean System.ArrayTraverse::Step()
extern "C" IL2CPP_METHOD_ATTR bool ArrayTraverse_Step_m3D9533390B66FB0C727576BAEF5CE78EF602193E (ArrayTraverse_tD07A6D4E93DB7941CE934AFF9F006788173C70A6 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (ArrayTraverse_Step_m3D9533390B66FB0C727576BAEF5CE78EF602193E_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	bool V_1 = false;
	int32_t V_2 = 0;
	bool V_3 = false;
	bool V_4 = false;
	bool V_5 = false;
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_LOCALS(methodExecutionContextLocals, (&V_0), (&V_2));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, ArrayTraverse_Step_m3D9533390B66FB0C727576BAEF5CE78EF602193E_RuntimeMethod_var, methodExecutionContextThis, NULL, methodExecutionContextLocals);
	CHECK_SEQ_POINT(methodExecutionContext, 57886);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 57887);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 57888);
		// for ( int i = 0; i < Position.Length; ++i )
		CHECK_SEQ_POINT(methodExecutionContext, 57889);
		V_0 = 0;
		CHECK_SEQ_POINT(methodExecutionContext, 57890);
		goto IL_0056;
	}

IL_0005:
	{
		CHECK_SEQ_POINT(methodExecutionContext, 57891);
		// if (Position[i] >= maxLengths[i]) continue;
		CHECK_SEQ_POINT(methodExecutionContext, 57892);
		Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* L_0 = __this->get_Position_0();
		int32_t L_1 = V_0;
		NullCheck(L_0, il2cpp_codegen_get_sequence_point(57892));
		int32_t L_2 = L_1;
		int32_t L_3 = (L_0)->GetAt(static_cast<il2cpp_array_size_t>(L_2));
		Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* L_4 = __this->get_maxLengths_1();
		int32_t L_5 = V_0;
		NullCheck(L_4, il2cpp_codegen_get_sequence_point(57892));
		int32_t L_6 = L_5;
		int32_t L_7 = (L_4)->GetAt(static_cast<il2cpp_array_size_t>(L_6));
		V_1 = (bool)((((int32_t)((((int32_t)L_3) < ((int32_t)L_7))? 1 : 0)) == ((int32_t)0))? 1 : 0);
		CHECK_SEQ_POINT(methodExecutionContext, 57893);
		bool L_8 = V_1;
		if (!L_8)
		{
			goto IL_0021;
		}
	}
	{
		// if (Position[i] >= maxLengths[i]) continue;
		CHECK_SEQ_POINT(methodExecutionContext, 57894);
		goto IL_0052;
	}

IL_0021:
	{
		// Position[i]++;
		CHECK_SEQ_POINT(methodExecutionContext, 57895);
		Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* L_9 = __this->get_Position_0();
		int32_t L_10 = V_0;
		NullCheck(L_9, il2cpp_codegen_get_sequence_point(57895));
		int32_t* L_11 = ((L_9)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_10)));
		int32_t L_12 = *((int32_t*)L_11);
		*((int32_t*)L_11) = (int32_t)((int32_t)il2cpp_codegen_add((int32_t)L_12, (int32_t)1));
		// for ( int j = 0; j < i; j++ )
		CHECK_SEQ_POINT(methodExecutionContext, 57896);
		V_2 = 0;
		CHECK_SEQ_POINT(methodExecutionContext, 57897);
		goto IL_0045;
	}

IL_0036:
	{
		CHECK_SEQ_POINT(methodExecutionContext, 57898);
		// Position[j] = 0;
		CHECK_SEQ_POINT(methodExecutionContext, 57899);
		Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* L_13 = __this->get_Position_0();
		int32_t L_14 = V_2;
		NullCheck(L_13, il2cpp_codegen_get_sequence_point(57899));
		(L_13)->SetAt(static_cast<il2cpp_array_size_t>(L_14), (int32_t)0);
		CHECK_SEQ_POINT(methodExecutionContext, 57900);
		// for ( int j = 0; j < i; j++ )
		CHECK_SEQ_POINT(methodExecutionContext, 57901);
		int32_t L_15 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add((int32_t)L_15, (int32_t)1));
	}

IL_0045:
	{
		// for ( int j = 0; j < i; j++ )
		CHECK_SEQ_POINT(methodExecutionContext, 57902);
		int32_t L_16 = V_2;
		int32_t L_17 = V_0;
		V_3 = (bool)((((int32_t)L_16) < ((int32_t)L_17))? 1 : 0);
		CHECK_SEQ_POINT(methodExecutionContext, 57903);
		bool L_18 = V_3;
		if (L_18)
		{
			goto IL_0036;
		}
	}
	{
		// return true;
		CHECK_SEQ_POINT(methodExecutionContext, 57904);
		V_4 = (bool)1;
		goto IL_006c;
	}

IL_0052:
	{
		// for ( int i = 0; i < Position.Length; ++i )
		CHECK_SEQ_POINT(methodExecutionContext, 57905);
		int32_t L_19 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add((int32_t)L_19, (int32_t)1));
	}

IL_0056:
	{
		// for ( int i = 0; i < Position.Length; ++i )
		CHECK_SEQ_POINT(methodExecutionContext, 57906);
		int32_t L_20 = V_0;
		Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* L_21 = __this->get_Position_0();
		NullCheck(L_21, il2cpp_codegen_get_sequence_point(57906));
		V_5 = (bool)((((int32_t)L_20) < ((int32_t)(((int32_t)((int32_t)(((RuntimeArray *)L_21)->max_length))))))? 1 : 0);
		CHECK_SEQ_POINT(methodExecutionContext, 57907);
		bool L_22 = V_5;
		if (L_22)
		{
			goto IL_0005;
		}
	}
	{
		// return false;
		CHECK_SEQ_POINT(methodExecutionContext, 57908);
		V_4 = (bool)0;
		goto IL_006c;
	}

IL_006c:
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 57909);
		bool L_23 = V_4;
		return L_23;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void System.HelperArray::ForEach(System.Array,System.Action`2<System.Array,System.Int32[]>)
extern "C" IL2CPP_METHOD_ATTR void HelperArray_ForEach_mB81FAB6CA742EF47C4B9E2CA805351AFBB1FB0DB (RuntimeArray * ___array0, Action_2_tEEECFD1333A361FF85D469EF54DA8E989E6B0D11 * ___action1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (HelperArray_ForEach_mB81FAB6CA742EF47C4B9E2CA805351AFBB1FB0DB_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	ArrayTraverse_tD07A6D4E93DB7941CE934AFF9F006788173C70A6 * V_0 = NULL;
	bool V_1 = false;
	bool V_2 = false;
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___array0), (&___action1));
	DECLARE_METHOD_LOCALS(methodExecutionContextLocals, (&V_0));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, HelperArray_ForEach_mB81FAB6CA742EF47C4B9E2CA805351AFBB1FB0DB_RuntimeMethod_var, NULL, methodExecutionContextParameters, methodExecutionContextLocals);
	CHECK_SEQ_POINT(methodExecutionContext, 57851);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 57852);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 57853);
		// if (array.LongLength == 0) return;
		CHECK_SEQ_POINT(methodExecutionContext, 57854);
		RuntimeArray * L_0 = ___array0;
		STORE_SEQ_POINT(methodExecutionContext, 57862);
		NullCheck(L_0, il2cpp_codegen_get_sequence_point(57854));
		int64_t L_1 = Array_get_LongLength_m9C506B10DB4FB16C0A2F5059C5C08F8D3B0C2D9A(L_0, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 57862);
		V_1 = (bool)((((int64_t)L_1) == ((int64_t)(((int64_t)((int64_t)0)))))? 1 : 0);
		CHECK_SEQ_POINT(methodExecutionContext, 57855);
		bool L_2 = V_1;
		if (!L_2)
		{
			goto IL_0011;
		}
	}
	{
		// if (array.LongLength == 0) return;
		CHECK_SEQ_POINT(methodExecutionContext, 57856);
		goto IL_0030;
	}

IL_0011:
	{
		// var walker = new ArrayTraverse(array);
		CHECK_SEQ_POINT(methodExecutionContext, 57857);
		RuntimeArray * L_3 = ___array0;
		STORE_SEQ_POINT(methodExecutionContext, 57863);
		ArrayTraverse_tD07A6D4E93DB7941CE934AFF9F006788173C70A6 * L_4 = (ArrayTraverse_tD07A6D4E93DB7941CE934AFF9F006788173C70A6 *)il2cpp_codegen_object_new(ArrayTraverse_tD07A6D4E93DB7941CE934AFF9F006788173C70A6_il2cpp_TypeInfo_var);
		ArrayTraverse__ctor_mCC997558A200828072F6A2B76B02E089FABE3741(L_4, L_3, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 57863);
		V_0 = L_4;
	}

IL_0018:
	{
		// do action(array, walker.Position);
		CHECK_SEQ_POINT(methodExecutionContext, 57858);
		Action_2_tEEECFD1333A361FF85D469EF54DA8E989E6B0D11 * L_5 = ___action1;
		RuntimeArray * L_6 = ___array0;
		ArrayTraverse_tD07A6D4E93DB7941CE934AFF9F006788173C70A6 * L_7 = V_0;
		NullCheck(L_7, il2cpp_codegen_get_sequence_point(57858));
		Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* L_8 = L_7->get_Position_0();
		STORE_SEQ_POINT(methodExecutionContext, 57864);
		NullCheck(L_5, il2cpp_codegen_get_sequence_point(57858));
		Action_2_Invoke_m30C71E5D73DDF8E22567F0AAEFE21B198D0F4CBF(L_5, L_6, L_8, /*hidden argument*/Action_2_Invoke_m30C71E5D73DDF8E22567F0AAEFE21B198D0F4CBF_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 57864);
		// while (walker.Step());
		CHECK_SEQ_POINT(methodExecutionContext, 57859);
		ArrayTraverse_tD07A6D4E93DB7941CE934AFF9F006788173C70A6 * L_9 = V_0;
		STORE_SEQ_POINT(methodExecutionContext, 57865);
		NullCheck(L_9, il2cpp_codegen_get_sequence_point(57859));
		bool L_10 = ArrayTraverse_Step_m3D9533390B66FB0C727576BAEF5CE78EF602193E(L_9, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 57865);
		V_2 = L_10;
		CHECK_SEQ_POINT(methodExecutionContext, 57860);
		bool L_11 = V_2;
		if (L_11)
		{
			goto IL_0018;
		}
	}

IL_0030:
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 57861);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Boolean System.HelperObject::IsPrimitive(System.Type)
extern "C" IL2CPP_METHOD_ATTR bool HelperObject_IsPrimitive_m7A8654F1FD5D1F421189A6552C8D3BCD2530ADBB (Type_t * ___type0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (HelperObject_IsPrimitive_m7A8654F1FD5D1F421189A6552C8D3BCD2530ADBB_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	bool V_1 = false;
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___type0));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, HelperObject_IsPrimitive_m7A8654F1FD5D1F421189A6552C8D3BCD2530ADBB_RuntimeMethod_var, NULL, methodExecutionContextParameters, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 57703);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 57704);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 57705);
		// if (type == typeof(String)) return true;
		CHECK_SEQ_POINT(methodExecutionContext, 57706);
		Type_t * L_0 = ___type0;
		RuntimeTypeHandle_t7B542280A22F0EC4EAC2061C29178845847A8B2D  L_1 = { reinterpret_cast<intptr_t> (String_t_0_0_0_var) };
		STORE_SEQ_POINT(methodExecutionContext, 57711);
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_2 = Type_GetTypeFromHandle_m9DC58ADF0512987012A8A016FB64B068F3B1AFF6(L_1, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 57711);
		STORE_SEQ_POINT(methodExecutionContext, 57712);
		bool L_3 = Type_op_Equality_m7040622C9E1037EFC73E1F0EDB1DD241282BE3D8(L_0, L_2, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 57712);
		V_0 = L_3;
		CHECK_SEQ_POINT(methodExecutionContext, 57707);
		bool L_4 = V_0;
		if (!L_4)
		{
			goto IL_0019;
		}
	}
	{
		// if (type == typeof(String)) return true;
		CHECK_SEQ_POINT(methodExecutionContext, 57708);
		V_1 = (bool)1;
		goto IL_0029;
	}

IL_0019:
	{
		// return (type.IsValueType & type.IsPrimitive);
		CHECK_SEQ_POINT(methodExecutionContext, 57709);
		Type_t * L_5 = ___type0;
		STORE_SEQ_POINT(methodExecutionContext, 57713);
		NullCheck(L_5, il2cpp_codegen_get_sequence_point(57709));
		bool L_6 = Type_get_IsValueType_mDDCCBAE9B59A483CBC3E5C02E3D68CEBEB2E41A8(L_5, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 57713);
		Type_t * L_7 = ___type0;
		STORE_SEQ_POINT(methodExecutionContext, 57714);
		NullCheck(L_7, il2cpp_codegen_get_sequence_point(57709));
		bool L_8 = Type_get_IsPrimitive_m8E39430EE4B70E1AE690B51E9BE681C7758DFF5A(L_7, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 57714);
		V_1 = (bool)((int32_t)((int32_t)L_6&(int32_t)L_8));
		goto IL_0029;
	}

IL_0029:
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 57710);
		bool L_9 = V_1;
		return L_9;
	}
}
// System.Object System.HelperObject::Copy(System.Object)
extern "C" IL2CPP_METHOD_ATTR RuntimeObject * HelperObject_Copy_m0F1F1434D990C76B797BE3B746388D080E578EE1 (RuntimeObject * ___originalObject0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (HelperObject_Copy_m0F1F1434D990C76B797BE3B746388D080E578EE1_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject * V_0 = NULL;
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___originalObject0));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, HelperObject_Copy_m0F1F1434D990C76B797BE3B746388D080E578EE1_RuntimeMethod_var, NULL, methodExecutionContextParameters, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 57715);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 57716);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 57717);
		// return InternalCopy(originalObject, new Dictionary<Object, Object>(new ReferenceEqualityComparer()));
		CHECK_SEQ_POINT(methodExecutionContext, 57718);
		RuntimeObject * L_0 = ___originalObject0;
		STORE_SEQ_POINT(methodExecutionContext, 57720);
		ReferenceEqualityComparer_t3840A1467D76B18290FA822E6B548D1079D91DA4 * L_1 = (ReferenceEqualityComparer_t3840A1467D76B18290FA822E6B548D1079D91DA4 *)il2cpp_codegen_object_new(ReferenceEqualityComparer_t3840A1467D76B18290FA822E6B548D1079D91DA4_il2cpp_TypeInfo_var);
		ReferenceEqualityComparer__ctor_mF5BDE00932C85FFE5E2633F082A065724571C26D(L_1, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 57720);
		STORE_SEQ_POINT(methodExecutionContext, 57721);
		Dictionary_2_t32F25F093828AA9F93CB11C2A2B4648FD62A09BA * L_2 = (Dictionary_2_t32F25F093828AA9F93CB11C2A2B4648FD62A09BA *)il2cpp_codegen_object_new(Dictionary_2_t32F25F093828AA9F93CB11C2A2B4648FD62A09BA_il2cpp_TypeInfo_var);
		Dictionary_2__ctor_m76CDCB0C7BECE95DBA94C7C98467F297E4451EE7(L_2, L_1, /*hidden argument*/Dictionary_2__ctor_m76CDCB0C7BECE95DBA94C7C98467F297E4451EE7_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 57721);
		STORE_SEQ_POINT(methodExecutionContext, 57722);
		IL2CPP_RUNTIME_CLASS_INIT(HelperObject_t8DDDC60CA23963941C841A0FF58CFFB85581665B_il2cpp_TypeInfo_var);
		RuntimeObject * L_3 = HelperObject_InternalCopy_mACD63D41622BF6303A74BBCE7C77024CD5B97FB2(L_0, L_2, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 57722);
		V_0 = L_3;
		goto IL_0014;
	}

IL_0014:
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 57719);
		RuntimeObject * L_4 = V_0;
		return L_4;
	}
}
// System.Object System.HelperObject::InternalCopy(System.Object,System.Collections.Generic.IDictionary`2<System.Object,System.Object>)
extern "C" IL2CPP_METHOD_ATTR RuntimeObject * HelperObject_InternalCopy_mACD63D41622BF6303A74BBCE7C77024CD5B97FB2 (RuntimeObject * ___originalObject0, RuntimeObject* ___visited1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (HelperObject_InternalCopy_mACD63D41622BF6303A74BBCE7C77024CD5B97FB2_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	U3CU3Ec__DisplayClass3_0_t715805D6146E8762D34660C36DE710592B4E74BC * V_0 = NULL;
	Type_t * V_1 = NULL;
	RuntimeObject * V_2 = NULL;
	bool V_3 = false;
	RuntimeObject * V_4 = NULL;
	bool V_5 = false;
	bool V_6 = false;
	bool V_7 = false;
	bool V_8 = false;
	Type_t * V_9 = NULL;
	bool V_10 = false;
	U3CU3Ec__DisplayClass3_1_tB9452E9E43273A7EB9B4BEC3B43307E5DC1E2DAD * V_11 = NULL;
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___originalObject0), (&___visited1));
	DECLARE_METHOD_LOCALS(methodExecutionContextLocals, (&V_0), (&V_1), (&V_2), (&V_9), (&V_11));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, HelperObject_InternalCopy_mACD63D41622BF6303A74BBCE7C77024CD5B97FB2_RuntimeMethod_var, NULL, methodExecutionContextParameters, methodExecutionContextLocals);
	CHECK_SEQ_POINT(methodExecutionContext, 57723);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 57724);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 57725);
		STORE_SEQ_POINT(methodExecutionContext, 57758);
		U3CU3Ec__DisplayClass3_0_t715805D6146E8762D34660C36DE710592B4E74BC * L_0 = (U3CU3Ec__DisplayClass3_0_t715805D6146E8762D34660C36DE710592B4E74BC *)il2cpp_codegen_object_new(U3CU3Ec__DisplayClass3_0_t715805D6146E8762D34660C36DE710592B4E74BC_il2cpp_TypeInfo_var);
		U3CU3Ec__DisplayClass3_0__ctor_m93F361838BC3468967E3A661630E4F0CDE11DB93(L_0, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 57758);
		V_0 = L_0;
		U3CU3Ec__DisplayClass3_0_t715805D6146E8762D34660C36DE710592B4E74BC * L_1 = V_0;
		RuntimeObject* L_2 = ___visited1;
		NullCheck(L_1, il2cpp_codegen_get_sequence_point(57725));
		L_1->set_visited_0(L_2);
		CHECK_SEQ_POINT(methodExecutionContext, 57726);
		// if (originalObject == null) return null;
		CHECK_SEQ_POINT(methodExecutionContext, 57727);
		RuntimeObject * L_3 = ___originalObject0;
		V_3 = (bool)((((RuntimeObject*)(RuntimeObject *)L_3) == ((RuntimeObject*)(RuntimeObject *)NULL))? 1 : 0);
		CHECK_SEQ_POINT(methodExecutionContext, 57728);
		bool L_4 = V_3;
		if (!L_4)
		{
			goto IL_001e;
		}
	}
	{
		// if (originalObject == null) return null;
		CHECK_SEQ_POINT(methodExecutionContext, 57729);
		V_4 = NULL;
		goto IL_011b;
	}

IL_001e:
	{
		// var typeToReflect = originalObject.GetType();
		CHECK_SEQ_POINT(methodExecutionContext, 57730);
		RuntimeObject * L_5 = ___originalObject0;
		STORE_SEQ_POINT(methodExecutionContext, 57759);
		NullCheck(L_5, il2cpp_codegen_get_sequence_point(57730));
		Type_t * L_6 = Object_GetType_m2E0B62414ECCAA3094B703790CE88CBB2F83EA60(L_5, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 57759);
		V_1 = L_6;
		// if (IsPrimitive(typeToReflect)) return originalObject;
		CHECK_SEQ_POINT(methodExecutionContext, 57731);
		Type_t * L_7 = V_1;
		STORE_SEQ_POINT(methodExecutionContext, 57760);
		IL2CPP_RUNTIME_CLASS_INIT(HelperObject_t8DDDC60CA23963941C841A0FF58CFFB85581665B_il2cpp_TypeInfo_var);
		bool L_8 = HelperObject_IsPrimitive_m7A8654F1FD5D1F421189A6552C8D3BCD2530ADBB(L_7, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 57760);
		V_5 = L_8;
		CHECK_SEQ_POINT(methodExecutionContext, 57732);
		bool L_9 = V_5;
		if (!L_9)
		{
			goto IL_0039;
		}
	}
	{
		// if (IsPrimitive(typeToReflect)) return originalObject;
		CHECK_SEQ_POINT(methodExecutionContext, 57733);
		RuntimeObject * L_10 = ___originalObject0;
		V_4 = L_10;
		goto IL_011b;
	}

IL_0039:
	{
		// if (visited.ContainsKey(originalObject)) return visited[originalObject];
		CHECK_SEQ_POINT(methodExecutionContext, 57734);
		U3CU3Ec__DisplayClass3_0_t715805D6146E8762D34660C36DE710592B4E74BC * L_11 = V_0;
		NullCheck(L_11, il2cpp_codegen_get_sequence_point(57734));
		RuntimeObject* L_12 = L_11->get_visited_0();
		RuntimeObject * L_13 = ___originalObject0;
		STORE_SEQ_POINT(methodExecutionContext, 57761);
		NullCheck(L_12, il2cpp_codegen_get_sequence_point(57734));
		bool L_14 = InterfaceFuncInvoker1< bool, RuntimeObject * >::Invoke(4 /* System.Boolean System.Collections.Generic.IDictionary`2<System.Object,System.Object>::ContainsKey(!0) */, IDictionary_2_tA5D15A38270F72A7D9BDD9FCE7DB02B7BEA5385E_il2cpp_TypeInfo_var, L_12, L_13);
		CHECK_SEQ_POINT(methodExecutionContext, 57761);
		V_6 = L_14;
		CHECK_SEQ_POINT(methodExecutionContext, 57735);
		bool L_15 = V_6;
		if (!L_15)
		{
			goto IL_005e;
		}
	}
	{
		// if (visited.ContainsKey(originalObject)) return visited[originalObject];
		CHECK_SEQ_POINT(methodExecutionContext, 57736);
		U3CU3Ec__DisplayClass3_0_t715805D6146E8762D34660C36DE710592B4E74BC * L_16 = V_0;
		NullCheck(L_16, il2cpp_codegen_get_sequence_point(57736));
		RuntimeObject* L_17 = L_16->get_visited_0();
		RuntimeObject * L_18 = ___originalObject0;
		STORE_SEQ_POINT(methodExecutionContext, 57762);
		NullCheck(L_17, il2cpp_codegen_get_sequence_point(57736));
		RuntimeObject * L_19 = InterfaceFuncInvoker1< RuntimeObject *, RuntimeObject * >::Invoke(0 /* !1 System.Collections.Generic.IDictionary`2<System.Object,System.Object>::get_Item(!0) */, IDictionary_2_tA5D15A38270F72A7D9BDD9FCE7DB02B7BEA5385E_il2cpp_TypeInfo_var, L_17, L_18);
		CHECK_SEQ_POINT(methodExecutionContext, 57762);
		V_4 = L_19;
		goto IL_011b;
	}

IL_005e:
	{
		// if (typeof(Delegate).IsAssignableFrom(typeToReflect)) return null;
		CHECK_SEQ_POINT(methodExecutionContext, 57737);
		RuntimeTypeHandle_t7B542280A22F0EC4EAC2061C29178845847A8B2D  L_20 = { reinterpret_cast<intptr_t> (Delegate_t_0_0_0_var) };
		STORE_SEQ_POINT(methodExecutionContext, 57763);
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_21 = Type_GetTypeFromHandle_m9DC58ADF0512987012A8A016FB64B068F3B1AFF6(L_20, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 57763);
		Type_t * L_22 = V_1;
		STORE_SEQ_POINT(methodExecutionContext, 57764);
		NullCheck(L_21, il2cpp_codegen_get_sequence_point(57737));
		bool L_23 = VirtFuncInvoker1< bool, Type_t * >::Invoke(108 /* System.Boolean System.Type::IsAssignableFrom(System.Type) */, L_21, L_22);
		CHECK_SEQ_POINT(methodExecutionContext, 57764);
		V_7 = L_23;
		CHECK_SEQ_POINT(methodExecutionContext, 57738);
		bool L_24 = V_7;
		if (!L_24)
		{
			goto IL_007c;
		}
	}
	{
		// if (typeof(Delegate).IsAssignableFrom(typeToReflect)) return null;
		CHECK_SEQ_POINT(methodExecutionContext, 57739);
		V_4 = NULL;
		goto IL_011b;
	}

IL_007c:
	{
		// var cloneObject = CloneMethod.Invoke(originalObject, null);
		CHECK_SEQ_POINT(methodExecutionContext, 57740);
		IL2CPP_RUNTIME_CLASS_INIT(HelperObject_t8DDDC60CA23963941C841A0FF58CFFB85581665B_il2cpp_TypeInfo_var);
		MethodInfo_t * L_25 = ((HelperObject_t8DDDC60CA23963941C841A0FF58CFFB85581665B_StaticFields*)il2cpp_codegen_static_fields_for(HelperObject_t8DDDC60CA23963941C841A0FF58CFFB85581665B_il2cpp_TypeInfo_var))->get_CloneMethod_0();
		RuntimeObject * L_26 = ___originalObject0;
		STORE_SEQ_POINT(methodExecutionContext, 57765);
		NullCheck(L_25, il2cpp_codegen_get_sequence_point(57740));
		RuntimeObject * L_27 = MethodBase_Invoke_m471794D56262D9DB5B5A324883030AB16BD39674(L_25, L_26, (ObjectU5BU5D_t3C9242B5C88A48B2A5BD9FDA6CD0024E792AF08A*)(ObjectU5BU5D_t3C9242B5C88A48B2A5BD9FDA6CD0024E792AF08A*)NULL, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 57765);
		V_2 = L_27;
		// if (typeToReflect.IsArray)
		CHECK_SEQ_POINT(methodExecutionContext, 57741);
		Type_t * L_28 = V_1;
		STORE_SEQ_POINT(methodExecutionContext, 57766);
		NullCheck(L_28, il2cpp_codegen_get_sequence_point(57741));
		bool L_29 = Type_get_IsArray_m0B4E20F93B1B34C0B5C4B089F543D1AA338DC9FE(L_28, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 57766);
		V_8 = L_29;
		CHECK_SEQ_POINT(methodExecutionContext, 57742);
		bool L_30 = V_8;
		if (!L_30)
		{
			goto IL_00e7;
		}
	}
	{
		CHECK_SEQ_POINT(methodExecutionContext, 57743);
		// var arrayType = typeToReflect.GetElementType();
		CHECK_SEQ_POINT(methodExecutionContext, 57744);
		Type_t * L_31 = V_1;
		STORE_SEQ_POINT(methodExecutionContext, 57767);
		NullCheck(L_31, il2cpp_codegen_get_sequence_point(57744));
		Type_t * L_32 = VirtFuncInvoker0< Type_t * >::Invoke(96 /* System.Type System.Type::GetElementType() */, L_31);
		CHECK_SEQ_POINT(methodExecutionContext, 57767);
		V_9 = L_32;
		// if (IsPrimitive(arrayType) == false)
		CHECK_SEQ_POINT(methodExecutionContext, 57745);
		Type_t * L_33 = V_9;
		STORE_SEQ_POINT(methodExecutionContext, 57768);
		IL2CPP_RUNTIME_CLASS_INIT(HelperObject_t8DDDC60CA23963941C841A0FF58CFFB85581665B_il2cpp_TypeInfo_var);
		bool L_34 = HelperObject_IsPrimitive_m7A8654F1FD5D1F421189A6552C8D3BCD2530ADBB(L_33, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 57768);
		V_10 = (bool)((((int32_t)L_34) == ((int32_t)0))? 1 : 0);
		CHECK_SEQ_POINT(methodExecutionContext, 57746);
		bool L_35 = V_10;
		if (!L_35)
		{
			goto IL_00e6;
		}
	}
	{
		CHECK_SEQ_POINT(methodExecutionContext, 57747);
		STORE_SEQ_POINT(methodExecutionContext, 57769);
		U3CU3Ec__DisplayClass3_1_tB9452E9E43273A7EB9B4BEC3B43307E5DC1E2DAD * L_36 = (U3CU3Ec__DisplayClass3_1_tB9452E9E43273A7EB9B4BEC3B43307E5DC1E2DAD *)il2cpp_codegen_object_new(U3CU3Ec__DisplayClass3_1_tB9452E9E43273A7EB9B4BEC3B43307E5DC1E2DAD_il2cpp_TypeInfo_var);
		U3CU3Ec__DisplayClass3_1__ctor_m481D2674B53A811C32FDF054B5155011F6910CA0(L_36, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 57769);
		V_11 = L_36;
		U3CU3Ec__DisplayClass3_1_tB9452E9E43273A7EB9B4BEC3B43307E5DC1E2DAD * L_37 = V_11;
		U3CU3Ec__DisplayClass3_0_t715805D6146E8762D34660C36DE710592B4E74BC * L_38 = V_0;
		NullCheck(L_37, il2cpp_codegen_get_sequence_point(57747));
		L_37->set_CSU24U3CU3E8__locals1_1(L_38);
		CHECK_SEQ_POINT(methodExecutionContext, 57748);
		// var clonedArray = (Array) cloneObject;
		CHECK_SEQ_POINT(methodExecutionContext, 57749);
		U3CU3Ec__DisplayClass3_1_tB9452E9E43273A7EB9B4BEC3B43307E5DC1E2DAD * L_39 = V_11;
		RuntimeObject * L_40 = V_2;
		NullCheck(L_39, il2cpp_codegen_get_sequence_point(57749));
		L_39->set_clonedArray_0(((RuntimeArray *)CastclassClass((RuntimeObject*)L_40, RuntimeArray_il2cpp_TypeInfo_var)));
		// clonedArray.ForEach((array, indices) => array.SetValue(InternalCopy(clonedArray.GetValue(indices), visited), indices));
		CHECK_SEQ_POINT(methodExecutionContext, 57750);
		U3CU3Ec__DisplayClass3_1_tB9452E9E43273A7EB9B4BEC3B43307E5DC1E2DAD * L_41 = V_11;
		NullCheck(L_41, il2cpp_codegen_get_sequence_point(57750));
		RuntimeArray * L_42 = L_41->get_clonedArray_0();
		U3CU3Ec__DisplayClass3_1_tB9452E9E43273A7EB9B4BEC3B43307E5DC1E2DAD * L_43 = V_11;
		STORE_SEQ_POINT(methodExecutionContext, 57770);
		Action_2_tEEECFD1333A361FF85D469EF54DA8E989E6B0D11 * L_44 = (Action_2_tEEECFD1333A361FF85D469EF54DA8E989E6B0D11 *)il2cpp_codegen_object_new(Action_2_tEEECFD1333A361FF85D469EF54DA8E989E6B0D11_il2cpp_TypeInfo_var);
		Action_2__ctor_m5FC808B1B109AA3FBDD5E37AB68C9507E6E8E43E(L_44, L_43, (intptr_t)((intptr_t)U3CU3Ec__DisplayClass3_1_U3CInternalCopyU3Eb__0_m576CC120FC2610B5680C6EEC9437420E9CACF8EA_RuntimeMethod_var), /*hidden argument*/Action_2__ctor_m5FC808B1B109AA3FBDD5E37AB68C9507E6E8E43E_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 57770);
		STORE_SEQ_POINT(methodExecutionContext, 57771);
		HelperArray_ForEach_mB81FAB6CA742EF47C4B9E2CA805351AFBB1FB0DB(L_42, L_44, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 57771);
		CHECK_SEQ_POINT(methodExecutionContext, 57751);
	}

IL_00e6:
	{
		CHECK_SEQ_POINT(methodExecutionContext, 57752);
	}

IL_00e7:
	{
		// visited.Add(originalObject, cloneObject);
		CHECK_SEQ_POINT(methodExecutionContext, 57753);
		U3CU3Ec__DisplayClass3_0_t715805D6146E8762D34660C36DE710592B4E74BC * L_45 = V_0;
		NullCheck(L_45, il2cpp_codegen_get_sequence_point(57753));
		RuntimeObject* L_46 = L_45->get_visited_0();
		RuntimeObject * L_47 = ___originalObject0;
		RuntimeObject * L_48 = V_2;
		STORE_SEQ_POINT(methodExecutionContext, 57772);
		NullCheck(L_46, il2cpp_codegen_get_sequence_point(57753));
		InterfaceActionInvoker2< RuntimeObject *, RuntimeObject * >::Invoke(5 /* System.Void System.Collections.Generic.IDictionary`2<System.Object,System.Object>::Add(!0,!1) */, IDictionary_2_tA5D15A38270F72A7D9BDD9FCE7DB02B7BEA5385E_il2cpp_TypeInfo_var, L_46, L_47, L_48);
		CHECK_SEQ_POINT(methodExecutionContext, 57772);
		// CopyFields(originalObject, visited, cloneObject, typeToReflect);
		CHECK_SEQ_POINT(methodExecutionContext, 57754);
		RuntimeObject * L_49 = ___originalObject0;
		U3CU3Ec__DisplayClass3_0_t715805D6146E8762D34660C36DE710592B4E74BC * L_50 = V_0;
		NullCheck(L_50, il2cpp_codegen_get_sequence_point(57754));
		RuntimeObject* L_51 = L_50->get_visited_0();
		RuntimeObject * L_52 = V_2;
		Type_t * L_53 = V_1;
		STORE_SEQ_POINT(methodExecutionContext, 57773);
		IL2CPP_RUNTIME_CLASS_INIT(HelperObject_t8DDDC60CA23963941C841A0FF58CFFB85581665B_il2cpp_TypeInfo_var);
		HelperObject_CopyFields_m82911ECAA99D264F8D7B8D63C02CDC35A1B9657C(L_49, L_51, L_52, L_53, ((int32_t)116), (Func_2_t8B737A62DCD6BCDB37818A2DFF357973A9317E8D *)NULL, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 57773);
		// RecursiveCopyBaseTypePrivateFields(originalObject, visited, cloneObject, typeToReflect);
		CHECK_SEQ_POINT(methodExecutionContext, 57755);
		RuntimeObject * L_54 = ___originalObject0;
		U3CU3Ec__DisplayClass3_0_t715805D6146E8762D34660C36DE710592B4E74BC * L_55 = V_0;
		NullCheck(L_55, il2cpp_codegen_get_sequence_point(57755));
		RuntimeObject* L_56 = L_55->get_visited_0();
		RuntimeObject * L_57 = V_2;
		Type_t * L_58 = V_1;
		STORE_SEQ_POINT(methodExecutionContext, 57774);
		HelperObject_RecursiveCopyBaseTypePrivateFields_mC004C89E73C1BECCD83A4BC7F31ECBCA5E3DA6A7(L_54, L_56, L_57, L_58, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 57774);
		// return cloneObject;
		CHECK_SEQ_POINT(methodExecutionContext, 57756);
		RuntimeObject * L_59 = V_2;
		V_4 = L_59;
		goto IL_011b;
	}

IL_011b:
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 57757);
		RuntimeObject * L_60 = V_4;
		return L_60;
	}
}
// System.Void System.HelperObject::RecursiveCopyBaseTypePrivateFields(System.Object,System.Collections.Generic.IDictionary`2<System.Object,System.Object>,System.Object,System.Type)
extern "C" IL2CPP_METHOD_ATTR void HelperObject_RecursiveCopyBaseTypePrivateFields_mC004C89E73C1BECCD83A4BC7F31ECBCA5E3DA6A7 (RuntimeObject * ___originalObject0, RuntimeObject* ___visited1, RuntimeObject * ___cloneObject2, Type_t * ___typeToReflect3, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (HelperObject_RecursiveCopyBaseTypePrivateFields_mC004C89E73C1BECCD83A4BC7F31ECBCA5E3DA6A7_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___originalObject0), (&___visited1), (&___cloneObject2), (&___typeToReflect3));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, HelperObject_RecursiveCopyBaseTypePrivateFields_mC004C89E73C1BECCD83A4BC7F31ECBCA5E3DA6A7_RuntimeMethod_var, NULL, methodExecutionContextParameters, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 57775);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 57776);
	Func_2_t8B737A62DCD6BCDB37818A2DFF357973A9317E8D * G_B4_0 = NULL;
	int32_t G_B4_1 = 0;
	Type_t * G_B4_2 = NULL;
	RuntimeObject * G_B4_3 = NULL;
	RuntimeObject* G_B4_4 = NULL;
	RuntimeObject * G_B4_5 = NULL;
	Func_2_t8B737A62DCD6BCDB37818A2DFF357973A9317E8D * G_B3_0 = NULL;
	int32_t G_B3_1 = 0;
	Type_t * G_B3_2 = NULL;
	RuntimeObject * G_B3_3 = NULL;
	RuntimeObject* G_B3_4 = NULL;
	RuntimeObject * G_B3_5 = NULL;
	{
		CHECK_SEQ_POINT(methodExecutionContext, 57777);
		// if (typeToReflect.BaseType == null) return;
		CHECK_SEQ_POINT(methodExecutionContext, 57778);
		Type_t * L_0 = ___typeToReflect3;
		STORE_SEQ_POINT(methodExecutionContext, 57784);
		NullCheck(L_0, il2cpp_codegen_get_sequence_point(57778));
		Type_t * L_1 = VirtFuncInvoker0< Type_t * >::Invoke(29 /* System.Type System.Type::get_BaseType() */, L_0);
		CHECK_SEQ_POINT(methodExecutionContext, 57784);
		STORE_SEQ_POINT(methodExecutionContext, 57785);
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		bool L_2 = Type_op_Equality_m7040622C9E1037EFC73E1F0EDB1DD241282BE3D8(L_1, (Type_t *)NULL, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 57785);
		V_0 = L_2;
		CHECK_SEQ_POINT(methodExecutionContext, 57779);
		bool L_3 = V_0;
		if (!L_3)
		{
			goto IL_0013;
		}
	}
	{
		// if (typeToReflect.BaseType == null) return;
		CHECK_SEQ_POINT(methodExecutionContext, 57780);
		goto IL_0052;
	}

IL_0013:
	{
		// RecursiveCopyBaseTypePrivateFields(originalObject, visited, cloneObject, typeToReflect.BaseType);
		CHECK_SEQ_POINT(methodExecutionContext, 57781);
		RuntimeObject * L_4 = ___originalObject0;
		RuntimeObject* L_5 = ___visited1;
		RuntimeObject * L_6 = ___cloneObject2;
		Type_t * L_7 = ___typeToReflect3;
		STORE_SEQ_POINT(methodExecutionContext, 57786);
		NullCheck(L_7, il2cpp_codegen_get_sequence_point(57781));
		Type_t * L_8 = VirtFuncInvoker0< Type_t * >::Invoke(29 /* System.Type System.Type::get_BaseType() */, L_7);
		CHECK_SEQ_POINT(methodExecutionContext, 57786);
		STORE_SEQ_POINT(methodExecutionContext, 57787);
		IL2CPP_RUNTIME_CLASS_INIT(HelperObject_t8DDDC60CA23963941C841A0FF58CFFB85581665B_il2cpp_TypeInfo_var);
		HelperObject_RecursiveCopyBaseTypePrivateFields_mC004C89E73C1BECCD83A4BC7F31ECBCA5E3DA6A7(L_4, L_5, L_6, L_8, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 57787);
		// CopyFields(originalObject, visited, cloneObject, typeToReflect.BaseType, BindingFlags.Instance | BindingFlags.NonPublic, info => info.IsPrivate);
		CHECK_SEQ_POINT(methodExecutionContext, 57782);
		RuntimeObject * L_9 = ___originalObject0;
		RuntimeObject* L_10 = ___visited1;
		RuntimeObject * L_11 = ___cloneObject2;
		Type_t * L_12 = ___typeToReflect3;
		STORE_SEQ_POINT(methodExecutionContext, 57788);
		NullCheck(L_12, il2cpp_codegen_get_sequence_point(57782));
		Type_t * L_13 = VirtFuncInvoker0< Type_t * >::Invoke(29 /* System.Type System.Type::get_BaseType() */, L_12);
		CHECK_SEQ_POINT(methodExecutionContext, 57788);
		IL2CPP_RUNTIME_CLASS_INIT(U3CU3Ec_t9C407A5DC0C368A41DAACA036192AD2BC6222A05_il2cpp_TypeInfo_var);
		Func_2_t8B737A62DCD6BCDB37818A2DFF357973A9317E8D * L_14 = ((U3CU3Ec_t9C407A5DC0C368A41DAACA036192AD2BC6222A05_StaticFields*)il2cpp_codegen_static_fields_for(U3CU3Ec_t9C407A5DC0C368A41DAACA036192AD2BC6222A05_il2cpp_TypeInfo_var))->get_U3CU3E9__4_0_1();
		Func_2_t8B737A62DCD6BCDB37818A2DFF357973A9317E8D * L_15 = L_14;
		G_B3_0 = L_15;
		G_B3_1 = ((int32_t)36);
		G_B3_2 = L_13;
		G_B3_3 = L_11;
		G_B3_4 = L_10;
		G_B3_5 = L_9;
		if (L_15)
		{
			G_B4_0 = L_15;
			G_B4_1 = ((int32_t)36);
			G_B4_2 = L_13;
			G_B4_3 = L_11;
			G_B4_4 = L_10;
			G_B4_5 = L_9;
			goto IL_004c;
		}
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(U3CU3Ec_t9C407A5DC0C368A41DAACA036192AD2BC6222A05_il2cpp_TypeInfo_var);
		U3CU3Ec_t9C407A5DC0C368A41DAACA036192AD2BC6222A05 * L_16 = ((U3CU3Ec_t9C407A5DC0C368A41DAACA036192AD2BC6222A05_StaticFields*)il2cpp_codegen_static_fields_for(U3CU3Ec_t9C407A5DC0C368A41DAACA036192AD2BC6222A05_il2cpp_TypeInfo_var))->get_U3CU3E9_0();
		STORE_SEQ_POINT(methodExecutionContext, 57789);
		Func_2_t8B737A62DCD6BCDB37818A2DFF357973A9317E8D * L_17 = (Func_2_t8B737A62DCD6BCDB37818A2DFF357973A9317E8D *)il2cpp_codegen_object_new(Func_2_t8B737A62DCD6BCDB37818A2DFF357973A9317E8D_il2cpp_TypeInfo_var);
		Func_2__ctor_mBCB78A823F554E0E602DAC379826320F3ECEDC4B(L_17, L_16, (intptr_t)((intptr_t)U3CU3Ec_U3CRecursiveCopyBaseTypePrivateFieldsU3Eb__4_0_m669A441D3EDA0C0C5F8DBD3A216252FCB5C5A3E6_RuntimeMethod_var), /*hidden argument*/Func_2__ctor_mBCB78A823F554E0E602DAC379826320F3ECEDC4B_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 57789);
		Func_2_t8B737A62DCD6BCDB37818A2DFF357973A9317E8D * L_18 = L_17;
		((U3CU3Ec_t9C407A5DC0C368A41DAACA036192AD2BC6222A05_StaticFields*)il2cpp_codegen_static_fields_for(U3CU3Ec_t9C407A5DC0C368A41DAACA036192AD2BC6222A05_il2cpp_TypeInfo_var))->set_U3CU3E9__4_0_1(L_18);
		G_B4_0 = L_18;
		G_B4_1 = G_B3_1;
		G_B4_2 = G_B3_2;
		G_B4_3 = G_B3_3;
		G_B4_4 = G_B3_4;
		G_B4_5 = G_B3_5;
	}

IL_004c:
	{
		STORE_SEQ_POINT(methodExecutionContext, 57790);
		IL2CPP_RUNTIME_CLASS_INIT(HelperObject_t8DDDC60CA23963941C841A0FF58CFFB85581665B_il2cpp_TypeInfo_var);
		HelperObject_CopyFields_m82911ECAA99D264F8D7B8D63C02CDC35A1B9657C(G_B4_5, G_B4_4, G_B4_3, G_B4_2, G_B4_1, G_B4_0, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 57790);
	}

IL_0052:
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 57783);
		return;
	}
}
// System.Void System.HelperObject::CopyFields(System.Object,System.Collections.Generic.IDictionary`2<System.Object,System.Object>,System.Object,System.Type,System.Reflection.BindingFlags,System.Func`2<System.Reflection.FieldInfo,System.Boolean>)
extern "C" IL2CPP_METHOD_ATTR void HelperObject_CopyFields_m82911ECAA99D264F8D7B8D63C02CDC35A1B9657C (RuntimeObject * ___originalObject0, RuntimeObject* ___visited1, RuntimeObject * ___cloneObject2, Type_t * ___typeToReflect3, int32_t ___bindingFlags4, Func_2_t8B737A62DCD6BCDB37818A2DFF357973A9317E8D * ___filter5, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (HelperObject_CopyFields_m82911ECAA99D264F8D7B8D63C02CDC35A1B9657C_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	FieldInfoU5BU5D_t9C36FA93372CA01DAF85946064B058CD9CE2E8BE* V_0 = NULL;
	int32_t V_1 = 0;
	FieldInfo_t * V_2 = NULL;
	RuntimeObject * V_3 = NULL;
	RuntimeObject * V_4 = NULL;
	bool V_5 = false;
	bool V_6 = false;
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___originalObject0), (&___visited1), (&___cloneObject2), (&___typeToReflect3), (&___bindingFlags4), (&___filter5));
	DECLARE_METHOD_LOCALS(methodExecutionContextLocals, (&V_2), (&V_3), (&V_4));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, HelperObject_CopyFields_m82911ECAA99D264F8D7B8D63C02CDC35A1B9657C_RuntimeMethod_var, NULL, methodExecutionContextParameters, methodExecutionContextLocals);
	CHECK_SEQ_POINT(methodExecutionContext, 57791);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 57792);
	int32_t G_B4_0 = 0;
	{
		CHECK_SEQ_POINT(methodExecutionContext, 57793);
		CHECK_SEQ_POINT(methodExecutionContext, 57794);
		// foreach ( var fieldInfo in typeToReflect.GetFields(bindingFlags) )
		CHECK_SEQ_POINT(methodExecutionContext, 57795);
		Type_t * L_0 = ___typeToReflect3;
		int32_t L_1 = ___bindingFlags4;
		STORE_SEQ_POINT(methodExecutionContext, 57812);
		NullCheck(L_0, il2cpp_codegen_get_sequence_point(57795));
		FieldInfoU5BU5D_t9C36FA93372CA01DAF85946064B058CD9CE2E8BE* L_2 = VirtFuncInvoker1< FieldInfoU5BU5D_t9C36FA93372CA01DAF85946064B058CD9CE2E8BE*, int32_t >::Invoke(43 /* System.Reflection.FieldInfo[] System.Type::GetFields(System.Reflection.BindingFlags) */, L_0, L_1);
		CHECK_SEQ_POINT(methodExecutionContext, 57812);
		V_0 = L_2;
		V_1 = 0;
		CHECK_SEQ_POINT(methodExecutionContext, 57796);
		goto IL_0061;
	}

IL_000f:
	{
		// foreach ( var fieldInfo in typeToReflect.GetFields(bindingFlags) )
		CHECK_SEQ_POINT(methodExecutionContext, 57797);
		FieldInfoU5BU5D_t9C36FA93372CA01DAF85946064B058CD9CE2E8BE* L_3 = V_0;
		int32_t L_4 = V_1;
		NullCheck(L_3, il2cpp_codegen_get_sequence_point(57797));
		int32_t L_5 = L_4;
		FieldInfo_t * L_6 = (L_3)->GetAt(static_cast<il2cpp_array_size_t>(L_5));
		V_2 = L_6;
		CHECK_SEQ_POINT(methodExecutionContext, 57798);
		// if (filter != null && filter(fieldInfo) == false) continue;
		CHECK_SEQ_POINT(methodExecutionContext, 57799);
		Func_2_t8B737A62DCD6BCDB37818A2DFF357973A9317E8D * L_7 = ___filter5;
		if (!L_7)
		{
			goto IL_0025;
		}
	}
	{
		Func_2_t8B737A62DCD6BCDB37818A2DFF357973A9317E8D * L_8 = ___filter5;
		FieldInfo_t * L_9 = V_2;
		STORE_SEQ_POINT(methodExecutionContext, 57813);
		NullCheck(L_8, il2cpp_codegen_get_sequence_point(57799));
		bool L_10 = Func_2_Invoke_m549AD78F263B5521A0C932CDA2164CE8184B56C7(L_8, L_9, /*hidden argument*/Func_2_Invoke_m549AD78F263B5521A0C932CDA2164CE8184B56C7_RuntimeMethod_var);
		CHECK_SEQ_POINT(methodExecutionContext, 57813);
		G_B4_0 = ((((int32_t)L_10) == ((int32_t)0))? 1 : 0);
		goto IL_0026;
	}

IL_0025:
	{
		G_B4_0 = 0;
	}

IL_0026:
	{
		V_5 = (bool)G_B4_0;
		CHECK_SEQ_POINT(methodExecutionContext, 57800);
		bool L_11 = V_5;
		if (!L_11)
		{
			goto IL_002e;
		}
	}
	{
		// if (filter != null && filter(fieldInfo) == false) continue;
		CHECK_SEQ_POINT(methodExecutionContext, 57801);
		goto IL_005d;
	}

IL_002e:
	{
		// if (IsPrimitive(fieldInfo.FieldType)) continue;
		CHECK_SEQ_POINT(methodExecutionContext, 57802);
		FieldInfo_t * L_12 = V_2;
		STORE_SEQ_POINT(methodExecutionContext, 57814);
		NullCheck(L_12, il2cpp_codegen_get_sequence_point(57802));
		Type_t * L_13 = VirtFuncInvoker0< Type_t * >::Invoke(18 /* System.Type System.Reflection.FieldInfo::get_FieldType() */, L_12);
		CHECK_SEQ_POINT(methodExecutionContext, 57814);
		STORE_SEQ_POINT(methodExecutionContext, 57815);
		IL2CPP_RUNTIME_CLASS_INIT(HelperObject_t8DDDC60CA23963941C841A0FF58CFFB85581665B_il2cpp_TypeInfo_var);
		bool L_14 = HelperObject_IsPrimitive_m7A8654F1FD5D1F421189A6552C8D3BCD2530ADBB(L_13, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 57815);
		V_6 = L_14;
		CHECK_SEQ_POINT(methodExecutionContext, 57803);
		bool L_15 = V_6;
		if (!L_15)
		{
			goto IL_0041;
		}
	}
	{
		// if (IsPrimitive(fieldInfo.FieldType)) continue;
		CHECK_SEQ_POINT(methodExecutionContext, 57804);
		goto IL_005d;
	}

IL_0041:
	{
		// var originalFieldValue = fieldInfo.GetValue(originalObject);
		CHECK_SEQ_POINT(methodExecutionContext, 57805);
		FieldInfo_t * L_16 = V_2;
		RuntimeObject * L_17 = ___originalObject0;
		STORE_SEQ_POINT(methodExecutionContext, 57816);
		NullCheck(L_16, il2cpp_codegen_get_sequence_point(57805));
		RuntimeObject * L_18 = VirtFuncInvoker1< RuntimeObject *, RuntimeObject * >::Invoke(19 /* System.Object System.Reflection.FieldInfo::GetValue(System.Object) */, L_16, L_17);
		CHECK_SEQ_POINT(methodExecutionContext, 57816);
		V_3 = L_18;
		// var clonedFieldValue   = InternalCopy(originalFieldValue, visited);
		CHECK_SEQ_POINT(methodExecutionContext, 57806);
		RuntimeObject * L_19 = V_3;
		RuntimeObject* L_20 = ___visited1;
		STORE_SEQ_POINT(methodExecutionContext, 57817);
		IL2CPP_RUNTIME_CLASS_INIT(HelperObject_t8DDDC60CA23963941C841A0FF58CFFB85581665B_il2cpp_TypeInfo_var);
		RuntimeObject * L_21 = HelperObject_InternalCopy_mACD63D41622BF6303A74BBCE7C77024CD5B97FB2(L_19, L_20, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 57817);
		V_4 = L_21;
		// fieldInfo.SetValue(cloneObject, clonedFieldValue);
		CHECK_SEQ_POINT(methodExecutionContext, 57807);
		FieldInfo_t * L_22 = V_2;
		RuntimeObject * L_23 = ___cloneObject2;
		RuntimeObject * L_24 = V_4;
		STORE_SEQ_POINT(methodExecutionContext, 57818);
		NullCheck(L_22, il2cpp_codegen_get_sequence_point(57807));
		FieldInfo_SetValue_m9E7A4FBA27F835B6C26CC09CF609333967150E41(L_22, L_23, L_24, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 57818);
		CHECK_SEQ_POINT(methodExecutionContext, 57808);
	}

IL_005d:
	{
		CHECK_SEQ_POINT(methodExecutionContext, 57809);
		int32_t L_25 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add((int32_t)L_25, (int32_t)1));
	}

IL_0061:
	{
		// foreach ( var fieldInfo in typeToReflect.GetFields(bindingFlags) )
		CHECK_SEQ_POINT(methodExecutionContext, 57810);
		int32_t L_26 = V_1;
		FieldInfoU5BU5D_t9C36FA93372CA01DAF85946064B058CD9CE2E8BE* L_27 = V_0;
		NullCheck(L_27, il2cpp_codegen_get_sequence_point(57810));
		if ((((int32_t)L_26) < ((int32_t)(((int32_t)((int32_t)(((RuntimeArray *)L_27)->max_length)))))))
		{
			goto IL_000f;
		}
	}
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 57811);
		return;
	}
}
// System.Void System.HelperObject::.cctor()
extern "C" IL2CPP_METHOD_ATTR void HelperObject__cctor_m390F3EFE34A1F5910F6A723E8DA582D699698A29 (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (HelperObject__cctor_m390F3EFE34A1F5910F6A723E8DA582D699698A29_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, HelperObject__cctor_m390F3EFE34A1F5910F6A723E8DA582D699698A29_RuntimeMethod_var, NULL, NULL, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 57825);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 57826);
	{
		// static readonly MethodInfo CloneMethod = typeof(Object).GetMethod("MemberwiseClone", BindingFlags.NonPublic | BindingFlags.Instance);
		CHECK_SEQ_POINT(methodExecutionContext, 57827);
		RuntimeTypeHandle_t7B542280A22F0EC4EAC2061C29178845847A8B2D  L_0 = { reinterpret_cast<intptr_t> (RuntimeObject_0_0_0_var) };
		STORE_SEQ_POINT(methodExecutionContext, 57828);
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_1 = Type_GetTypeFromHandle_m9DC58ADF0512987012A8A016FB64B068F3B1AFF6(L_0, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 57828);
		STORE_SEQ_POINT(methodExecutionContext, 57829);
		NullCheck(L_1, il2cpp_codegen_get_sequence_point(57827));
		MethodInfo_t * L_2 = Type_GetMethod_m9EC42D4B1F765B882F516EE6D7970D51CF5D80DD(L_1, _stringLiteral4CD94480549BFAE91F93062486ECEFE3D7A2D695, ((int32_t)36), /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 57829);
		((HelperObject_t8DDDC60CA23963941C841A0FF58CFFB85581665B_StaticFields*)il2cpp_codegen_static_fields_for(HelperObject_t8DDDC60CA23963941C841A0FF58CFFB85581665B_il2cpp_TypeInfo_var))->set_CloneMethod_0(L_2);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void System.HelperObject_<>c::.cctor()
extern "C" IL2CPP_METHOD_ATTR void U3CU3Ec__cctor_m7A61BBB8A1F00EEAF2F965DCA334EB7147E51975 (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (U3CU3Ec__cctor_m7A61BBB8A1F00EEAF2F965DCA334EB7147E51975_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	CHECK_PAUSE_POINT;
	{
		U3CU3Ec_t9C407A5DC0C368A41DAACA036192AD2BC6222A05 * L_0 = (U3CU3Ec_t9C407A5DC0C368A41DAACA036192AD2BC6222A05 *)il2cpp_codegen_object_new(U3CU3Ec_t9C407A5DC0C368A41DAACA036192AD2BC6222A05_il2cpp_TypeInfo_var);
		U3CU3Ec__ctor_m061CC4C8AA1906E5AFD92705600B19E5D2D76D1D(L_0, /*hidden argument*/NULL);
		((U3CU3Ec_t9C407A5DC0C368A41DAACA036192AD2BC6222A05_StaticFields*)il2cpp_codegen_static_fields_for(U3CU3Ec_t9C407A5DC0C368A41DAACA036192AD2BC6222A05_il2cpp_TypeInfo_var))->set_U3CU3E9_0(L_0);
		return;
	}
}
// System.Void System.HelperObject_<>c::.ctor()
extern "C" IL2CPP_METHOD_ATTR void U3CU3Ec__ctor_m061CC4C8AA1906E5AFD92705600B19E5D2D76D1D (U3CU3Ec_t9C407A5DC0C368A41DAACA036192AD2BC6222A05 * __this, const RuntimeMethod* method)
{
	CHECK_PAUSE_POINT;
	{
		Object__ctor_m925ECA5E85CA100E3FB86A4F9E15C120E9A184C0(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Boolean System.HelperObject_<>c::<RecursiveCopyBaseTypePrivateFields>b__4_0(System.Reflection.FieldInfo)
extern "C" IL2CPP_METHOD_ATTR bool U3CU3Ec_U3CRecursiveCopyBaseTypePrivateFieldsU3Eb__4_0_m669A441D3EDA0C0C5F8DBD3A216252FCB5C5A3E6 (U3CU3Ec_t9C407A5DC0C368A41DAACA036192AD2BC6222A05 * __this, FieldInfo_t * ___info0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (U3CU3Ec_U3CRecursiveCopyBaseTypePrivateFieldsU3Eb__4_0_m669A441D3EDA0C0C5F8DBD3A216252FCB5C5A3E6_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___info0));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, U3CU3Ec_U3CRecursiveCopyBaseTypePrivateFieldsU3Eb__4_0_m669A441D3EDA0C0C5F8DBD3A216252FCB5C5A3E6_RuntimeMethod_var, methodExecutionContextThis, methodExecutionContextParameters, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 57836);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 57837);
	{
		// CopyFields(originalObject, visited, cloneObject, typeToReflect.BaseType, BindingFlags.Instance | BindingFlags.NonPublic, info => info.IsPrivate);
		CHECK_SEQ_POINT(methodExecutionContext, 57838);
		FieldInfo_t * L_0 = ___info0;
		STORE_SEQ_POINT(methodExecutionContext, 57839);
		NullCheck(L_0, il2cpp_codegen_get_sequence_point(57838));
		bool L_1 = FieldInfo_get_IsPrivate_m4CC9816E774224A4A143DD0748C90D02AF387F5C(L_0, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 57839);
		return L_1;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void System.HelperObject_<>c__DisplayClass3_0::.ctor()
extern "C" IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass3_0__ctor_m93F361838BC3468967E3A661630E4F0CDE11DB93 (U3CU3Ec__DisplayClass3_0_t715805D6146E8762D34660C36DE710592B4E74BC * __this, const RuntimeMethod* method)
{
	CHECK_PAUSE_POINT;
	{
		Object__ctor_m925ECA5E85CA100E3FB86A4F9E15C120E9A184C0(__this, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void System.HelperObject_<>c__DisplayClass3_1::.ctor()
extern "C" IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass3_1__ctor_m481D2674B53A811C32FDF054B5155011F6910CA0 (U3CU3Ec__DisplayClass3_1_tB9452E9E43273A7EB9B4BEC3B43307E5DC1E2DAD * __this, const RuntimeMethod* method)
{
	CHECK_PAUSE_POINT;
	{
		Object__ctor_m925ECA5E85CA100E3FB86A4F9E15C120E9A184C0(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void System.HelperObject_<>c__DisplayClass3_1::<InternalCopy>b__0(System.Array,System.Int32[])
extern "C" IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass3_1_U3CInternalCopyU3Eb__0_m576CC120FC2610B5680C6EEC9437420E9CACF8EA (U3CU3Ec__DisplayClass3_1_tB9452E9E43273A7EB9B4BEC3B43307E5DC1E2DAD * __this, RuntimeArray * ___array0, Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* ___indices1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (U3CU3Ec__DisplayClass3_1_U3CInternalCopyU3Eb__0_m576CC120FC2610B5680C6EEC9437420E9CACF8EA_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___array0), (&___indices1));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, U3CU3Ec__DisplayClass3_1_U3CInternalCopyU3Eb__0_m576CC120FC2610B5680C6EEC9437420E9CACF8EA_RuntimeMethod_var, methodExecutionContextThis, methodExecutionContextParameters, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 57830);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 57831);
	{
		// clonedArray.ForEach((array, indices) => array.SetValue(InternalCopy(clonedArray.GetValue(indices), visited), indices));
		CHECK_SEQ_POINT(methodExecutionContext, 57832);
		RuntimeArray * L_0 = ___array0;
		RuntimeArray * L_1 = __this->get_clonedArray_0();
		Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* L_2 = ___indices1;
		STORE_SEQ_POINT(methodExecutionContext, 57833);
		NullCheck(L_1, il2cpp_codegen_get_sequence_point(57832));
		RuntimeObject * L_3 = Array_GetValue_m3CEA4EB8E2DAB2C0B9CCC8D6E597F15F82C2C97C(L_1, L_2, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 57833);
		U3CU3Ec__DisplayClass3_0_t715805D6146E8762D34660C36DE710592B4E74BC * L_4 = __this->get_CSU24U3CU3E8__locals1_1();
		NullCheck(L_4, il2cpp_codegen_get_sequence_point(57832));
		RuntimeObject* L_5 = L_4->get_visited_0();
		STORE_SEQ_POINT(methodExecutionContext, 57834);
		IL2CPP_RUNTIME_CLASS_INIT(HelperObject_t8DDDC60CA23963941C841A0FF58CFFB85581665B_il2cpp_TypeInfo_var);
		RuntimeObject * L_6 = HelperObject_InternalCopy_mACD63D41622BF6303A74BBCE7C77024CD5B97FB2(L_3, L_5, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 57834);
		Int32U5BU5D_t2B9E4FDDDB9F0A00EC0AC631BA2DA915EB1ECF83* L_7 = ___indices1;
		STORE_SEQ_POINT(methodExecutionContext, 57835);
		NullCheck(L_0, il2cpp_codegen_get_sequence_point(57832));
		Array_SetValue_m0480E07CF9A65B3C2B903CCBF5BAB94F93CF1380(L_0, L_6, L_7, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 57835);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Boolean System.ReferenceEqualityComparer::Equals(System.Object,System.Object)
extern "C" IL2CPP_METHOD_ATTR bool ReferenceEqualityComparer_Equals_m96C511CA5702FDF53C7253762841E6D189A71366 (ReferenceEqualityComparer_t3840A1467D76B18290FA822E6B548D1079D91DA4 * __this, RuntimeObject * ___x0, RuntimeObject * ___y1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (ReferenceEqualityComparer_Equals_m96C511CA5702FDF53C7253762841E6D189A71366_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___x0), (&___y1));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, ReferenceEqualityComparer_Equals_m96C511CA5702FDF53C7253762841E6D189A71366_RuntimeMethod_var, methodExecutionContextThis, methodExecutionContextParameters, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 57840);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 57841);
	{
		CHECK_SEQ_POINT(methodExecutionContext, 57842);
		// return ReferenceEquals(x, y);
		CHECK_SEQ_POINT(methodExecutionContext, 57843);
		RuntimeObject * L_0 = ___x0;
		RuntimeObject * L_1 = ___y1;
		V_0 = (bool)((((RuntimeObject*)(RuntimeObject *)L_0) == ((RuntimeObject*)(RuntimeObject *)L_1))? 1 : 0);
		goto IL_0008;
	}

IL_0008:
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 57844);
		bool L_2 = V_0;
		return L_2;
	}
}
// System.Int32 System.ReferenceEqualityComparer::GetHashCode(System.Object)
extern "C" IL2CPP_METHOD_ATTR int32_t ReferenceEqualityComparer_GetHashCode_mD5B3DD433D815E66BA01586CE51D7CDF0CF2129E (ReferenceEqualityComparer_t3840A1467D76B18290FA822E6B548D1079D91DA4 * __this, RuntimeObject * ___obj0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (ReferenceEqualityComparer_GetHashCode_mD5B3DD433D815E66BA01586CE51D7CDF0CF2129E_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___obj0));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, ReferenceEqualityComparer_GetHashCode_mD5B3DD433D815E66BA01586CE51D7CDF0CF2129E_RuntimeMethod_var, methodExecutionContextThis, methodExecutionContextParameters, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 57845);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 57846);
	int32_t G_B3_0 = 0;
	{
		CHECK_SEQ_POINT(methodExecutionContext, 57847);
		// return obj == null ? 0 : obj.GetHashCode();
		CHECK_SEQ_POINT(methodExecutionContext, 57848);
		RuntimeObject * L_0 = ___obj0;
		if (!L_0)
		{
			goto IL_000c;
		}
	}
	{
		RuntimeObject * L_1 = ___obj0;
		STORE_SEQ_POINT(methodExecutionContext, 57850);
		NullCheck(L_1, il2cpp_codegen_get_sequence_point(57848));
		int32_t L_2 = VirtFuncInvoker0< int32_t >::Invoke(2 /* System.Int32 System.Object::GetHashCode() */, L_1);
		CHECK_SEQ_POINT(methodExecutionContext, 57850);
		G_B3_0 = L_2;
		goto IL_000d;
	}

IL_000c:
	{
		G_B3_0 = 0;
	}

IL_000d:
	{
		V_0 = G_B3_0;
		goto IL_0010;
	}

IL_0010:
	{
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 57849);
		int32_t L_3 = V_0;
		return L_3;
	}
}
// System.Void System.ReferenceEqualityComparer::.ctor()
extern "C" IL2CPP_METHOD_ATTR void ReferenceEqualityComparer__ctor_mF5BDE00932C85FFE5E2633F082A065724571C26D (ReferenceEqualityComparer_t3840A1467D76B18290FA822E6B548D1079D91DA4 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (ReferenceEqualityComparer__ctor_mF5BDE00932C85FFE5E2633F082A065724571C26D_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	CHECK_PAUSE_POINT;
	{
		EqualityComparer_1__ctor_m2B03FB26184C766345AA072BEA38AA745AE2E192(__this, /*hidden argument*/EqualityComparer_1__ctor_m2B03FB26184C766345AA072BEA38AA745AE2E192_RuntimeMethod_var);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void System.Runtime.CompilerServices.IsReadOnlyAttribute::.ctor()
extern "C" IL2CPP_METHOD_ATTR void IsReadOnlyAttribute__ctor_m8C573496C0EACBCB9E7BC181C16145A8F20261AB (IsReadOnlyAttribute_t625BDB176EA5986CAF2228A6F2A61A9FABD2C344 * __this, const RuntimeMethod* method)
{
	CHECK_PAUSE_POINT;
	{
		Attribute__ctor_m45CAD4B01265CC84CC5A84F62EE2DBE85DE89EC0(__this, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Unity.IL2CPP.CompilerServices.Option Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute::get_Option()
extern "C" IL2CPP_METHOD_ATTR int32_t Il2CppSetOptionAttribute_get_Option_m0E0DE57E57329D9C0870E600F1A3396AFB3C73AE (Il2CppSetOptionAttribute_t013DDBAF8F39A8C8395B51A2549BCF893259611E * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Il2CppSetOptionAttribute_get_Option_m0E0DE57E57329D9C0870E600F1A3396AFB3C73AE_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, Il2CppSetOptionAttribute_get_Option_m0E0DE57E57329D9C0870E600F1A3396AFB3C73AE_RuntimeMethod_var, methodExecutionContextThis, NULL, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 57910);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 57911);
	{
		// public Option Option { get; private set; }
		CHECK_SEQ_POINT(methodExecutionContext, 57912);
		int32_t L_0 = __this->get_U3COptionU3Ek__BackingField_0();
		return L_0;
	}
}
// System.Void Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute::set_Option(Unity.IL2CPP.CompilerServices.Option)
extern "C" IL2CPP_METHOD_ATTR void Il2CppSetOptionAttribute_set_Option_mA79F66679078953ABC5CFF576AFE2714A0C840CA (Il2CppSetOptionAttribute_t013DDBAF8F39A8C8395B51A2549BCF893259611E * __this, int32_t ___value0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Il2CppSetOptionAttribute_set_Option_mA79F66679078953ABC5CFF576AFE2714A0C840CA_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___value0));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, Il2CppSetOptionAttribute_set_Option_mA79F66679078953ABC5CFF576AFE2714A0C840CA_RuntimeMethod_var, methodExecutionContextThis, methodExecutionContextParameters, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 57913);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 57914);
	{
		// public Option Option { get; private set; }
		CHECK_SEQ_POINT(methodExecutionContext, 57915);
		int32_t L_0 = ___value0;
		__this->set_U3COptionU3Ek__BackingField_0(L_0);
		return;
	}
}
// System.Object Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute::get_Value()
extern "C" IL2CPP_METHOD_ATTR RuntimeObject * Il2CppSetOptionAttribute_get_Value_m2BA8D8B60E0237F26014F46196F6A433469FFF2A (Il2CppSetOptionAttribute_t013DDBAF8F39A8C8395B51A2549BCF893259611E * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Il2CppSetOptionAttribute_get_Value_m2BA8D8B60E0237F26014F46196F6A433469FFF2A_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, Il2CppSetOptionAttribute_get_Value_m2BA8D8B60E0237F26014F46196F6A433469FFF2A_RuntimeMethod_var, methodExecutionContextThis, NULL, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 57916);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 57917);
	{
		// public object Value { get; private set; }
		CHECK_SEQ_POINT(methodExecutionContext, 57918);
		RuntimeObject * L_0 = __this->get_U3CValueU3Ek__BackingField_1();
		return L_0;
	}
}
// System.Void Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute::set_Value(System.Object)
extern "C" IL2CPP_METHOD_ATTR void Il2CppSetOptionAttribute_set_Value_m67B377532E1429A6AE787932FFA2250D04D09022 (Il2CppSetOptionAttribute_t013DDBAF8F39A8C8395B51A2549BCF893259611E * __this, RuntimeObject * ___value0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Il2CppSetOptionAttribute_set_Value_m67B377532E1429A6AE787932FFA2250D04D09022_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___value0));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, Il2CppSetOptionAttribute_set_Value_m67B377532E1429A6AE787932FFA2250D04D09022_RuntimeMethod_var, methodExecutionContextThis, methodExecutionContextParameters, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 57919);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 57920);
	{
		// public object Value { get; private set; }
		CHECK_SEQ_POINT(methodExecutionContext, 57921);
		RuntimeObject * L_0 = ___value0;
		__this->set_U3CValueU3Ek__BackingField_1(L_0);
		return;
	}
}
// System.Void Unity.IL2CPP.CompilerServices.Il2CppSetOptionAttribute::.ctor(Unity.IL2CPP.CompilerServices.Option,System.Object)
extern "C" IL2CPP_METHOD_ATTR void Il2CppSetOptionAttribute__ctor_m959B784CDB72D7B9D9676F464C669AA059EA9B8F (Il2CppSetOptionAttribute_t013DDBAF8F39A8C8395B51A2549BCF893259611E * __this, int32_t ___option0, RuntimeObject * ___value1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Il2CppSetOptionAttribute__ctor_m959B784CDB72D7B9D9676F464C669AA059EA9B8F_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	DECLARE_METHOD_THIS(methodExecutionContextThis, (&__this));
	DECLARE_METHOD_PARAMS(methodExecutionContextParameters, (&___option0), (&___value1));
	DECLARE_METHOD_EXEC_CTX(methodExecutionContext, Il2CppSetOptionAttribute__ctor_m959B784CDB72D7B9D9676F464C669AA059EA9B8F_RuntimeMethod_var, methodExecutionContextThis, methodExecutionContextParameters, NULL);
	CHECK_SEQ_POINT(methodExecutionContext, 57922);
	CHECK_METHOD_EXIT_SEQ_POINT(methodExitChecker, methodExecutionContext, 57923);
	{
		// public Il2CppSetOptionAttribute(Option option, object value)
		CHECK_SEQ_POINT(methodExecutionContext, 57924);
		STORE_SEQ_POINT(methodExecutionContext, 57929);
		Attribute__ctor_m45CAD4B01265CC84CC5A84F62EE2DBE85DE89EC0(__this, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 57929);
		CHECK_SEQ_POINT(methodExecutionContext, 57925);
		// Option = option;
		CHECK_SEQ_POINT(methodExecutionContext, 57926);
		int32_t L_0 = ___option0;
		STORE_SEQ_POINT(methodExecutionContext, 57930);
		Il2CppSetOptionAttribute_set_Option_mA79F66679078953ABC5CFF576AFE2714A0C840CA(__this, L_0, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 57930);
		// Value = value;
		CHECK_SEQ_POINT(methodExecutionContext, 57927);
		RuntimeObject * L_1 = ___value1;
		STORE_SEQ_POINT(methodExecutionContext, 57931);
		Il2CppSetOptionAttribute_set_Value_m67B377532E1429A6AE787932FFA2250D04D09022(__this, L_1, /*hidden argument*/NULL);
		CHECK_SEQ_POINT(methodExecutionContext, 57931);
		// }
		CHECK_SEQ_POINT(methodExecutionContext, 57928);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
