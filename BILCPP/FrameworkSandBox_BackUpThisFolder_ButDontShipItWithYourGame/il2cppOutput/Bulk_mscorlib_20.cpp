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

// System.Byte[]
struct ByteU5BU5D_tD06FDBE8142446525DF1C40351D523A228373821;
// System.Char[]
struct CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2;
// System.Collections.IDictionary
struct IDictionary_t1BD5C1546718A374EA8122FBD6C6EE45331E8CE7;
// System.Diagnostics.StackTrace[]
struct StackTraceU5BU5D_t855F09649EA34DEE7C1B6F088E0538E3CCC3F196;
// System.IntPtr[]
struct IntPtrU5BU5D_t4DC01DCB9A6DF6C9792A6513595D7A11E637DCDD;
// System.PlatformNotSupportedException
struct PlatformNotSupportedException_t14FE109377F8FA8B3B2F9A0C4FE3BF10662C73B5;
// System.Reflection.InvalidFilterCriteriaException
struct InvalidFilterCriteriaException_tB11C87F151CD79ACA0837773B9BFD8791CA715BA;
// System.Reflection.MemberInfo
struct MemberInfo_t;
// System.Runtime.Serialization.SafeSerializationManager
struct SafeSerializationManager_t4A754D86B0F784B18CBC36C073BA564BED109770;
// System.String
struct String_t;
// System.__Filters
struct __Filters_tDD9D6B7C7A31B12AB3D5CCF1B115DD693F62DB34;
// System.__Il2CppComDelegate
struct __Il2CppComDelegate_t0A30496F74225C39A0CF7FADB94934C0536120FD;
// System.__Il2CppComObject
struct Il2CppComObject;

extern RuntimeClass* ConstructorInfo_t9CB51BFC178DF1CBCA5FD16B2D58229618F23EFF_il2cpp_TypeInfo_var;
extern RuntimeClass* FieldInfo_t_il2cpp_TypeInfo_var;
extern RuntimeClass* Int32_t585191389E07734F19F3156FF88FB3EF4800D102_il2cpp_TypeInfo_var;
extern RuntimeClass* InvalidFilterCriteriaException_tB11C87F151CD79ACA0837773B9BFD8791CA715BA_il2cpp_TypeInfo_var;
extern RuntimeClass* MethodInfo_t_il2cpp_TypeInfo_var;
extern RuntimeClass* PlatformNotSupportedException_t14FE109377F8FA8B3B2F9A0C4FE3BF10662C73B5_il2cpp_TypeInfo_var;
extern RuntimeClass* RuntimeObject_il2cpp_TypeInfo_var;
extern RuntimeClass* String_t_il2cpp_TypeInfo_var;
extern RuntimeClass* __Filters_tDD9D6B7C7A31B12AB3D5CCF1B115DD693F62DB34_il2cpp_TypeInfo_var;
extern String_t* _stringLiteralE8C2E73741ABBBE9D320E65848D6DB0BCF7D63A5;
extern String_t* _stringLiteralFA8B27A553F27F158C5E4C81F3AA90D26451F922;
extern const RuntimeMethod* ThrowStub_ThrowNotSupportedException_mA248D7D785682F31CDF02FDC1FAB3173EE1B1E19_RuntimeMethod_var;
extern const RuntimeMethod* __Filters_FilterAttribute_mBF9879ECFB908212C56CAE0B42C9E29BFCB347C1_RuntimeMethod_var;
extern const RuntimeMethod* __Filters_FilterIgnoreCase_m883976C13C53B21BE3430DE51D4317CBCF89F53A_RuntimeMethod_var;
extern const RuntimeMethod* __Filters_FilterName_m768C2766720890EE1D07554E3433C0F828D427DB_RuntimeMethod_var;
extern const uint32_t ThrowStub_ThrowNotSupportedException_mA248D7D785682F31CDF02FDC1FAB3173EE1B1E19_MetadataUsageId;
extern const uint32_t __Filters_FilterAttribute_mBF9879ECFB908212C56CAE0B42C9E29BFCB347C1_MetadataUsageId;
extern const uint32_t __Filters_FilterIgnoreCase_m883976C13C53B21BE3430DE51D4317CBCF89F53A_MetadataUsageId;
extern const uint32_t __Filters_FilterName_m768C2766720890EE1D07554E3433C0F828D427DB_MetadataUsageId;
extern const uint32_t __Filters__cctor_mAC913CDF08E7AB6541101C4B96483BF49C6E2F14_MetadataUsageId;
struct Exception_t_marshaled_com;
struct Exception_t_marshaled_pinvoke;



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
#ifndef __FILTERS_TDD9D6B7C7A31B12AB3D5CCF1B115DD693F62DB34_H
#define __FILTERS_TDD9D6B7C7A31B12AB3D5CCF1B115DD693F62DB34_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.__Filters
struct  __Filters_tDD9D6B7C7A31B12AB3D5CCF1B115DD693F62DB34  : public RuntimeObject
{
public:

public:
};

struct __Filters_tDD9D6B7C7A31B12AB3D5CCF1B115DD693F62DB34_StaticFields
{
public:
	// System.__Filters System.__Filters::Instance
	__Filters_tDD9D6B7C7A31B12AB3D5CCF1B115DD693F62DB34 * ___Instance_0;

public:
	inline static int32_t get_offset_of_Instance_0() { return static_cast<int32_t>(offsetof(__Filters_tDD9D6B7C7A31B12AB3D5CCF1B115DD693F62DB34_StaticFields, ___Instance_0)); }
	inline __Filters_tDD9D6B7C7A31B12AB3D5CCF1B115DD693F62DB34 * get_Instance_0() const { return ___Instance_0; }
	inline __Filters_tDD9D6B7C7A31B12AB3D5CCF1B115DD693F62DB34 ** get_address_of_Instance_0() { return &___Instance_0; }
	inline void set_Instance_0(__Filters_tDD9D6B7C7A31B12AB3D5CCF1B115DD693F62DB34 * value)
	{
		___Instance_0 = value;
		Il2CppCodeGenWriteBarrier((&___Instance_0), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // __FILTERS_TDD9D6B7C7A31B12AB3D5CCF1B115DD693F62DB34_H
#ifndef IL2CPPCOMOBJECT_H
#define IL2CPPCOMOBJECT_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.__Il2CppComObject

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // IL2CPPCOMOBJECT_H
#ifndef APPLICATIONEXCEPTION_T664823C3E0D3E1E7C7FA1C0DB4E19E98E9811C74_H
#define APPLICATIONEXCEPTION_T664823C3E0D3E1E7C7FA1C0DB4E19E98E9811C74_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.ApplicationException
struct  ApplicationException_t664823C3E0D3E1E7C7FA1C0DB4E19E98E9811C74  : public Exception_t
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // APPLICATIONEXCEPTION_T664823C3E0D3E1E7C7FA1C0DB4E19E98E9811C74_H
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
#ifndef CHAR_TBF22D9FC341BE970735250BB6FF1A4A92BBA58B9_H
#define CHAR_TBF22D9FC341BE970735250BB6FF1A4A92BBA58B9_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Char
struct  Char_tBF22D9FC341BE970735250BB6FF1A4A92BBA58B9 
{
public:
	// System.Char System.Char::m_value
	Il2CppChar ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(Char_tBF22D9FC341BE970735250BB6FF1A4A92BBA58B9, ___m_value_0)); }
	inline Il2CppChar get_m_value_0() const { return ___m_value_0; }
	inline Il2CppChar* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(Il2CppChar value)
	{
		___m_value_0 = value;
	}
};

struct Char_tBF22D9FC341BE970735250BB6FF1A4A92BBA58B9_StaticFields
{
public:
	// System.Byte[] System.Char::categoryForLatin1
	ByteU5BU5D_tD06FDBE8142446525DF1C40351D523A228373821* ___categoryForLatin1_3;

public:
	inline static int32_t get_offset_of_categoryForLatin1_3() { return static_cast<int32_t>(offsetof(Char_tBF22D9FC341BE970735250BB6FF1A4A92BBA58B9_StaticFields, ___categoryForLatin1_3)); }
	inline ByteU5BU5D_tD06FDBE8142446525DF1C40351D523A228373821* get_categoryForLatin1_3() const { return ___categoryForLatin1_3; }
	inline ByteU5BU5D_tD06FDBE8142446525DF1C40351D523A228373821** get_address_of_categoryForLatin1_3() { return &___categoryForLatin1_3; }
	inline void set_categoryForLatin1_3(ByteU5BU5D_tD06FDBE8142446525DF1C40351D523A228373821* value)
	{
		___categoryForLatin1_3 = value;
		Il2CppCodeGenWriteBarrier((&___categoryForLatin1_3), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // CHAR_TBF22D9FC341BE970735250BB6FF1A4A92BBA58B9_H
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
#ifndef __IL2CPPCOMDELEGATE_T0A30496F74225C39A0CF7FADB94934C0536120FD_H
#define __IL2CPPCOMDELEGATE_T0A30496F74225C39A0CF7FADB94934C0536120FD_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.__Il2CppComDelegate
struct  __Il2CppComDelegate_t0A30496F74225C39A0CF7FADB94934C0536120FD  : public Il2CppComObject
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // __IL2CPPCOMDELEGATE_T0A30496F74225C39A0CF7FADB94934C0536120FD_H
#ifndef INVALIDOPERATIONEXCEPTION_T0530E734D823F78310CAFAFA424CA5164D93A1F1_H
#define INVALIDOPERATIONEXCEPTION_T0530E734D823F78310CAFAFA424CA5164D93A1F1_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.InvalidOperationException
struct  InvalidOperationException_t0530E734D823F78310CAFAFA424CA5164D93A1F1  : public SystemException_t5380468142AA850BE4A341D7AF3EAB9C78746782
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // INVALIDOPERATIONEXCEPTION_T0530E734D823F78310CAFAFA424CA5164D93A1F1_H
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
#ifndef CONSTRUCTORINFO_T9CB51BFC178DF1CBCA5FD16B2D58229618F23EFF_H
#define CONSTRUCTORINFO_T9CB51BFC178DF1CBCA5FD16B2D58229618F23EFF_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Reflection.ConstructorInfo
struct  ConstructorInfo_t9CB51BFC178DF1CBCA5FD16B2D58229618F23EFF  : public MethodBase_t
{
public:

public:
};

struct ConstructorInfo_t9CB51BFC178DF1CBCA5FD16B2D58229618F23EFF_StaticFields
{
public:
	// System.String System.Reflection.ConstructorInfo::ConstructorName
	String_t* ___ConstructorName_0;
	// System.String System.Reflection.ConstructorInfo::TypeConstructorName
	String_t* ___TypeConstructorName_1;

public:
	inline static int32_t get_offset_of_ConstructorName_0() { return static_cast<int32_t>(offsetof(ConstructorInfo_t9CB51BFC178DF1CBCA5FD16B2D58229618F23EFF_StaticFields, ___ConstructorName_0)); }
	inline String_t* get_ConstructorName_0() const { return ___ConstructorName_0; }
	inline String_t** get_address_of_ConstructorName_0() { return &___ConstructorName_0; }
	inline void set_ConstructorName_0(String_t* value)
	{
		___ConstructorName_0 = value;
		Il2CppCodeGenWriteBarrier((&___ConstructorName_0), value);
	}

	inline static int32_t get_offset_of_TypeConstructorName_1() { return static_cast<int32_t>(offsetof(ConstructorInfo_t9CB51BFC178DF1CBCA5FD16B2D58229618F23EFF_StaticFields, ___TypeConstructorName_1)); }
	inline String_t* get_TypeConstructorName_1() const { return ___TypeConstructorName_1; }
	inline String_t** get_address_of_TypeConstructorName_1() { return &___TypeConstructorName_1; }
	inline void set_TypeConstructorName_1(String_t* value)
	{
		___TypeConstructorName_1 = value;
		Il2CppCodeGenWriteBarrier((&___TypeConstructorName_1), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // CONSTRUCTORINFO_T9CB51BFC178DF1CBCA5FD16B2D58229618F23EFF_H
#ifndef FIELDATTRIBUTES_T53FAFABBE4087C280EE0ED26F8F0EF29D24CC0B1_H
#define FIELDATTRIBUTES_T53FAFABBE4087C280EE0ED26F8F0EF29D24CC0B1_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Reflection.FieldAttributes
struct  FieldAttributes_t53FAFABBE4087C280EE0ED26F8F0EF29D24CC0B1 
{
public:
	// System.Int32 System.Reflection.FieldAttributes::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(FieldAttributes_t53FAFABBE4087C280EE0ED26F8F0EF29D24CC0B1, ___value___2)); }
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
#endif // FIELDATTRIBUTES_T53FAFABBE4087C280EE0ED26F8F0EF29D24CC0B1_H
#ifndef INVALIDFILTERCRITERIAEXCEPTION_TB11C87F151CD79ACA0837773B9BFD8791CA715BA_H
#define INVALIDFILTERCRITERIAEXCEPTION_TB11C87F151CD79ACA0837773B9BFD8791CA715BA_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Reflection.InvalidFilterCriteriaException
struct  InvalidFilterCriteriaException_tB11C87F151CD79ACA0837773B9BFD8791CA715BA  : public ApplicationException_t664823C3E0D3E1E7C7FA1C0DB4E19E98E9811C74
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // INVALIDFILTERCRITERIAEXCEPTION_TB11C87F151CD79ACA0837773B9BFD8791CA715BA_H
#ifndef MEMBERTYPES_T3FEDC67D8B994D09AF155FFB2CFD26023F245041_H
#define MEMBERTYPES_T3FEDC67D8B994D09AF155FFB2CFD26023F245041_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Reflection.MemberTypes
struct  MemberTypes_t3FEDC67D8B994D09AF155FFB2CFD26023F245041 
{
public:
	// System.Int32 System.Reflection.MemberTypes::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(MemberTypes_t3FEDC67D8B994D09AF155FFB2CFD26023F245041, ___value___2)); }
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
#endif // MEMBERTYPES_T3FEDC67D8B994D09AF155FFB2CFD26023F245041_H
#ifndef METHODATTRIBUTES_TBEF3274421B682BFF8D0FF0BEA84C8FD9D63F202_H
#define METHODATTRIBUTES_TBEF3274421B682BFF8D0FF0BEA84C8FD9D63F202_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Reflection.MethodAttributes
struct  MethodAttributes_tBEF3274421B682BFF8D0FF0BEA84C8FD9D63F202 
{
public:
	// System.Int32 System.Reflection.MethodAttributes::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(MethodAttributes_tBEF3274421B682BFF8D0FF0BEA84C8FD9D63F202, ___value___2)); }
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
#endif // METHODATTRIBUTES_TBEF3274421B682BFF8D0FF0BEA84C8FD9D63F202_H
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
#ifndef STRINGCOMPARISON_T02BAA95468CE9E91115C604577611FDF58FEDCF0_H
#define STRINGCOMPARISON_T02BAA95468CE9E91115C604577611FDF58FEDCF0_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.StringComparison
struct  StringComparison_t02BAA95468CE9E91115C604577611FDF58FEDCF0 
{
public:
	// System.Int32 System.StringComparison::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(StringComparison_t02BAA95468CE9E91115C604577611FDF58FEDCF0, ___value___2)); }
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
#endif // STRINGCOMPARISON_T02BAA95468CE9E91115C604577611FDF58FEDCF0_H
#ifndef OBJECTDISPOSEDEXCEPTION_TF68E471ECD1419AD7C51137B742837395F50B69A_H
#define OBJECTDISPOSEDEXCEPTION_TF68E471ECD1419AD7C51137B742837395F50B69A_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.ObjectDisposedException
struct  ObjectDisposedException_tF68E471ECD1419AD7C51137B742837395F50B69A  : public InvalidOperationException_t0530E734D823F78310CAFAFA424CA5164D93A1F1
{
public:
	// System.String System.ObjectDisposedException::objectName
	String_t* ___objectName_17;

public:
	inline static int32_t get_offset_of_objectName_17() { return static_cast<int32_t>(offsetof(ObjectDisposedException_tF68E471ECD1419AD7C51137B742837395F50B69A, ___objectName_17)); }
	inline String_t* get_objectName_17() const { return ___objectName_17; }
	inline String_t** get_address_of_objectName_17() { return &___objectName_17; }
	inline void set_objectName_17(String_t* value)
	{
		___objectName_17 = value;
		Il2CppCodeGenWriteBarrier((&___objectName_17), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // OBJECTDISPOSEDEXCEPTION_TF68E471ECD1419AD7C51137B742837395F50B69A_H
#ifndef PLATFORMNOTSUPPORTEDEXCEPTION_T14FE109377F8FA8B3B2F9A0C4FE3BF10662C73B5_H
#define PLATFORMNOTSUPPORTEDEXCEPTION_T14FE109377F8FA8B3B2F9A0C4FE3BF10662C73B5_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.PlatformNotSupportedException
struct  PlatformNotSupportedException_t14FE109377F8FA8B3B2F9A0C4FE3BF10662C73B5  : public NotSupportedException_tE75B318D6590A02A5D9B29FD97409B1750FA0010
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // PLATFORMNOTSUPPORTEDEXCEPTION_T14FE109377F8FA8B3B2F9A0C4FE3BF10662C73B5_H
#ifndef THROWSTUB_TFA0E21DBAA52F61535595DCC8B44B0CD087A0406_H
#define THROWSTUB_TFA0E21DBAA52F61535595DCC8B44B0CD087A0406_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Unity.ThrowStub
struct  ThrowStub_tFA0E21DBAA52F61535595DCC8B44B0CD087A0406  : public ObjectDisposedException_tF68E471ECD1419AD7C51137B742837395F50B69A
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // THROWSTUB_TFA0E21DBAA52F61535595DCC8B44B0CD087A0406_H



// System.String System.Environment::GetResourceString(System.String)
extern "C" IL2CPP_METHOD_ATTR String_t* Environment_GetResourceString_m2C75C2AF268F01E2BF34AD1C2E1352CF4BA51AD9 (String_t* ___key0, const RuntimeMethod* method);
// System.Void System.Reflection.InvalidFilterCriteriaException::.ctor(System.String)
extern "C" IL2CPP_METHOD_ATTR void InvalidFilterCriteriaException__ctor_m8A7E7373F5BFA58916AA7A8D99E49AA3C6861031 (InvalidFilterCriteriaException_tB11C87F151CD79ACA0837773B9BFD8791CA715BA * __this, String_t* ___message0, const RuntimeMethod* method);
// System.String System.String::Trim()
extern "C" IL2CPP_METHOD_ATTR String_t* String_Trim_mB52EB7876C7132358B76B7DC95DEACA20722EF4D (String_t* __this, const RuntimeMethod* method);
// System.Int32 System.String::LastIndexOf(System.Char)
extern "C" IL2CPP_METHOD_ATTR int32_t String_LastIndexOf_m76C37E3915E802044761572007B8FB0635995F59 (String_t* __this, Il2CppChar ___value0, const RuntimeMethod* method);
// System.String System.String::Substring(System.Int32)
extern "C" IL2CPP_METHOD_ATTR String_t* String_Substring_m2C4AFF5E79DD8BADFD2DFBCF156BF728FBB8E1AE (String_t* __this, int32_t ___startIndex0, const RuntimeMethod* method);
// System.Int32 System.String::get_Length()
extern "C" IL2CPP_METHOD_ATTR int32_t String_get_Length_mD48C8A16A5CF1914F330DCE82D9BE15C3BEDD018 (String_t* __this, const RuntimeMethod* method);
// System.Char System.String::get_Chars(System.Int32)
extern "C" IL2CPP_METHOD_ATTR Il2CppChar String_get_Chars_m14308AC3B95F8C1D9F1D1055B116B37D595F1D96 (String_t* __this, int32_t ___index0, const RuntimeMethod* method);
// System.String System.String::Substring(System.Int32,System.Int32)
extern "C" IL2CPP_METHOD_ATTR String_t* String_Substring_mB593C0A320C683E6E47EFFC0A12B7A465E5E43BB (String_t* __this, int32_t ___startIndex0, int32_t ___length1, const RuntimeMethod* method);
// System.Boolean System.String::StartsWith(System.String,System.StringComparison)
extern "C" IL2CPP_METHOD_ATTR bool String_StartsWith_m844A95C9A205A0F951B0C45634E0C222E73D0B49 (String_t* __this, String_t* ___value0, int32_t ___comparisonType1, const RuntimeMethod* method);
// System.Boolean System.String::Equals(System.String)
extern "C" IL2CPP_METHOD_ATTR bool String_Equals_m9C4D78DFA0979504FE31429B64A4C26DF48020D1 (String_t* __this, String_t* ___value0, const RuntimeMethod* method);
// System.Int32 System.String::Compare(System.String,System.Int32,System.String,System.Int32,System.Int32,System.StringComparison)
extern "C" IL2CPP_METHOD_ATTR int32_t String_Compare_m208E4853037D81DD5C91DCA060C339DADC3A6064 (String_t* ___strA0, int32_t ___indexA1, String_t* ___strB2, int32_t ___indexB3, int32_t ___length4, int32_t ___comparisonType5, const RuntimeMethod* method);
// System.Int32 System.String::Compare(System.String,System.String,System.StringComparison)
extern "C" IL2CPP_METHOD_ATTR int32_t String_Compare_m5BD1EF8904C9B13BEDB7A876B122F117B317B442 (String_t* ___strA0, String_t* ___strB1, int32_t ___comparisonType2, const RuntimeMethod* method);
// System.Void System.Object::.ctor()
extern "C" IL2CPP_METHOD_ATTR void Object__ctor_m925ECA5E85CA100E3FB86A4F9E15C120E9A184C0 (RuntimeObject * __this, const RuntimeMethod* method);
// System.Void System.__Filters::.ctor()
extern "C" IL2CPP_METHOD_ATTR void __Filters__ctor_mA9DEA9B853B953C85A78E101A8001E9EE0E66B35 (__Filters_tDD9D6B7C7A31B12AB3D5CCF1B115DD693F62DB34 * __this, const RuntimeMethod* method);
// System.Void System.__Il2CppComObject::Finalize()
extern "C" IL2CPP_METHOD_ATTR void __Il2CppComObject_Finalize_m98123DBAAA7974D2616F9E90F2574955714CA9A9 (Il2CppComObject * __this, const RuntimeMethod* method);
// System.Void System.Object::Finalize()
extern "C" IL2CPP_METHOD_ATTR void Object_Finalize_m4015B7D3A44DE125C5FE34D7276CD4697C06F380 (RuntimeObject * __this, const RuntimeMethod* method);
// System.Void System.PlatformNotSupportedException::.ctor()
extern "C" IL2CPP_METHOD_ATTR void PlatformNotSupportedException__ctor_m651139B17C9EE918551490BC675754EA8EA3E7C7 (PlatformNotSupportedException_t14FE109377F8FA8B3B2F9A0C4FE3BF10662C73B5 * __this, const RuntimeMethod* method);
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Boolean System.__Filters::FilterAttribute(System.Reflection.MemberInfo,System.Object)
extern "C" IL2CPP_METHOD_ATTR bool __Filters_FilterAttribute_mBF9879ECFB908212C56CAE0B42C9E29BFCB347C1 (__Filters_tDD9D6B7C7A31B12AB3D5CCF1B115DD693F62DB34 * __this, MemberInfo_t * ___m0, RuntimeObject * ___filterCriteria1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (__Filters_FilterAttribute_mBF9879ECFB908212C56CAE0B42C9E29BFCB347C1_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	int32_t V_2 = 0;
	int32_t V_3 = 0;
	int32_t V_4 = 0;
	CHECK_PAUSE_POINT;
	Exception_t * __last_unhandled_exception = 0;
	NO_UNUSED_WARNING (__last_unhandled_exception);
	Exception_t * __exception_local = 0;
	NO_UNUSED_WARNING (__exception_local);
	int32_t __leave_target = -1;
	NO_UNUSED_WARNING (__leave_target);
	{
		RuntimeObject * L_0 = ___filterCriteria1;
		if (L_0)
		{
			goto IL_0013;
		}
	}
	{
		String_t* L_1 = Environment_GetResourceString_m2C75C2AF268F01E2BF34AD1C2E1352CF4BA51AD9(_stringLiteralE8C2E73741ABBBE9D320E65848D6DB0BCF7D63A5, /*hidden argument*/NULL);
		InvalidFilterCriteriaException_tB11C87F151CD79ACA0837773B9BFD8791CA715BA * L_2 = (InvalidFilterCriteriaException_tB11C87F151CD79ACA0837773B9BFD8791CA715BA *)il2cpp_codegen_object_new(InvalidFilterCriteriaException_tB11C87F151CD79ACA0837773B9BFD8791CA715BA_il2cpp_TypeInfo_var);
		InvalidFilterCriteriaException__ctor_m8A7E7373F5BFA58916AA7A8D99E49AA3C6861031(L_2, L_1, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_2, NULL, __Filters_FilterAttribute_mBF9879ECFB908212C56CAE0B42C9E29BFCB347C1_RuntimeMethod_var);
	}

IL_0013:
	{
		MemberInfo_t * L_3 = ___m0;
		NullCheck(L_3);
		int32_t L_4 = VirtFuncInvoker0< int32_t >::Invoke(6 /* System.Reflection.MemberTypes System.Reflection.MemberInfo::get_MemberType() */, L_3);
		V_0 = L_4;
		int32_t L_5 = V_0;
		if ((((int32_t)L_5) == ((int32_t)1)))
		{
			goto IL_002c;
		}
	}
	{
		int32_t L_6 = V_0;
		if ((((int32_t)L_6) == ((int32_t)4)))
		{
			goto IL_00ce;
		}
	}
	{
		int32_t L_7 = V_0;
		if ((!(((uint32_t)L_7) == ((uint32_t)8))))
		{
			goto IL_0160;
		}
	}

IL_002c:
	{
		V_1 = 0;
	}

IL_002e:
	try
	{ // begin try (depth: 1)
		RuntimeObject * L_8 = ___filterCriteria1;
		V_1 = ((*(int32_t*)((int32_t*)UnBox(L_8, Int32_t585191389E07734F19F3156FF88FB3EF4800D102_il2cpp_TypeInfo_var))));
		goto IL_0048;
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		__exception_local = (Exception_t *)e.ex;
		if(il2cpp_codegen_class_is_assignable_from (RuntimeObject_il2cpp_TypeInfo_var, il2cpp_codegen_object_class(e.ex)))
			goto CATCH_0037;
		throw e;
	}

CATCH_0037:
	{ // begin catch(System.Object)
		String_t* L_9 = Environment_GetResourceString_m2C75C2AF268F01E2BF34AD1C2E1352CF4BA51AD9(_stringLiteralE8C2E73741ABBBE9D320E65848D6DB0BCF7D63A5, /*hidden argument*/NULL);
		InvalidFilterCriteriaException_tB11C87F151CD79ACA0837773B9BFD8791CA715BA * L_10 = (InvalidFilterCriteriaException_tB11C87F151CD79ACA0837773B9BFD8791CA715BA *)il2cpp_codegen_object_new(InvalidFilterCriteriaException_tB11C87F151CD79ACA0837773B9BFD8791CA715BA_il2cpp_TypeInfo_var);
		InvalidFilterCriteriaException__ctor_m8A7E7373F5BFA58916AA7A8D99E49AA3C6861031(L_10, L_9, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_10, NULL, __Filters_FilterAttribute_mBF9879ECFB908212C56CAE0B42C9E29BFCB347C1_RuntimeMethod_var);
	} // end catch (depth: 1)

IL_0048:
	{
		MemberInfo_t * L_11 = ___m0;
		NullCheck(L_11);
		int32_t L_12 = VirtFuncInvoker0< int32_t >::Invoke(6 /* System.Reflection.MemberTypes System.Reflection.MemberInfo::get_MemberType() */, L_11);
		if ((!(((uint32_t)L_12) == ((uint32_t)8))))
		{
			goto IL_005f;
		}
	}
	{
		MemberInfo_t * L_13 = ___m0;
		NullCheck(((MethodInfo_t *)CastclassClass((RuntimeObject*)L_13, MethodInfo_t_il2cpp_TypeInfo_var)));
		int32_t L_14 = VirtFuncInvoker0< int32_t >::Invoke(20 /* System.Reflection.MethodAttributes System.Reflection.MethodBase::get_Attributes() */, ((MethodInfo_t *)CastclassClass((RuntimeObject*)L_13, MethodInfo_t_il2cpp_TypeInfo_var)));
		V_2 = L_14;
		goto IL_006b;
	}

IL_005f:
	{
		MemberInfo_t * L_15 = ___m0;
		NullCheck(((ConstructorInfo_t9CB51BFC178DF1CBCA5FD16B2D58229618F23EFF *)CastclassClass((RuntimeObject*)L_15, ConstructorInfo_t9CB51BFC178DF1CBCA5FD16B2D58229618F23EFF_il2cpp_TypeInfo_var)));
		int32_t L_16 = VirtFuncInvoker0< int32_t >::Invoke(20 /* System.Reflection.MethodAttributes System.Reflection.MethodBase::get_Attributes() */, ((ConstructorInfo_t9CB51BFC178DF1CBCA5FD16B2D58229618F23EFF *)CastclassClass((RuntimeObject*)L_15, ConstructorInfo_t9CB51BFC178DF1CBCA5FD16B2D58229618F23EFF_il2cpp_TypeInfo_var)));
		V_2 = L_16;
	}

IL_006b:
	{
		int32_t L_17 = V_1;
		if (!((int32_t)((int32_t)L_17&(int32_t)7)))
		{
			goto IL_007a;
		}
	}
	{
		int32_t L_18 = V_2;
		int32_t L_19 = V_1;
		if ((((int32_t)((int32_t)((int32_t)L_18&(int32_t)7))) == ((int32_t)((int32_t)((int32_t)L_19&(int32_t)7)))))
		{
			goto IL_007a;
		}
	}
	{
		return (bool)0;
	}

IL_007a:
	{
		int32_t L_20 = V_1;
		if (!((int32_t)((int32_t)L_20&(int32_t)((int32_t)16))))
		{
			goto IL_0088;
		}
	}
	{
		int32_t L_21 = V_2;
		if (((int32_t)((int32_t)L_21&(int32_t)((int32_t)16))))
		{
			goto IL_0088;
		}
	}
	{
		return (bool)0;
	}

IL_0088:
	{
		int32_t L_22 = V_1;
		if (!((int32_t)((int32_t)L_22&(int32_t)((int32_t)32))))
		{
			goto IL_0096;
		}
	}
	{
		int32_t L_23 = V_2;
		if (((int32_t)((int32_t)L_23&(int32_t)((int32_t)32))))
		{
			goto IL_0096;
		}
	}
	{
		return (bool)0;
	}

IL_0096:
	{
		int32_t L_24 = V_1;
		if (!((int32_t)((int32_t)L_24&(int32_t)((int32_t)64))))
		{
			goto IL_00a4;
		}
	}
	{
		int32_t L_25 = V_2;
		if (((int32_t)((int32_t)L_25&(int32_t)((int32_t)64))))
		{
			goto IL_00a4;
		}
	}
	{
		return (bool)0;
	}

IL_00a4:
	{
		int32_t L_26 = V_1;
		if (!((int32_t)((int32_t)L_26&(int32_t)((int32_t)1024))))
		{
			goto IL_00b8;
		}
	}
	{
		int32_t L_27 = V_2;
		if (((int32_t)((int32_t)L_27&(int32_t)((int32_t)1024))))
		{
			goto IL_00b8;
		}
	}
	{
		return (bool)0;
	}

IL_00b8:
	{
		int32_t L_28 = V_1;
		if (!((int32_t)((int32_t)L_28&(int32_t)((int32_t)2048))))
		{
			goto IL_00cc;
		}
	}
	{
		int32_t L_29 = V_2;
		if (((int32_t)((int32_t)L_29&(int32_t)((int32_t)2048))))
		{
			goto IL_00cc;
		}
	}
	{
		return (bool)0;
	}

IL_00cc:
	{
		return (bool)1;
	}

IL_00ce:
	{
		V_3 = 0;
	}

IL_00d0:
	try
	{ // begin try (depth: 1)
		RuntimeObject * L_30 = ___filterCriteria1;
		V_3 = ((*(int32_t*)((int32_t*)UnBox(L_30, Int32_t585191389E07734F19F3156FF88FB3EF4800D102_il2cpp_TypeInfo_var))));
		goto IL_00ea;
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		__exception_local = (Exception_t *)e.ex;
		if(il2cpp_codegen_class_is_assignable_from (RuntimeObject_il2cpp_TypeInfo_var, il2cpp_codegen_object_class(e.ex)))
			goto CATCH_00d9;
		throw e;
	}

CATCH_00d9:
	{ // begin catch(System.Object)
		String_t* L_31 = Environment_GetResourceString_m2C75C2AF268F01E2BF34AD1C2E1352CF4BA51AD9(_stringLiteralE8C2E73741ABBBE9D320E65848D6DB0BCF7D63A5, /*hidden argument*/NULL);
		InvalidFilterCriteriaException_tB11C87F151CD79ACA0837773B9BFD8791CA715BA * L_32 = (InvalidFilterCriteriaException_tB11C87F151CD79ACA0837773B9BFD8791CA715BA *)il2cpp_codegen_object_new(InvalidFilterCriteriaException_tB11C87F151CD79ACA0837773B9BFD8791CA715BA_il2cpp_TypeInfo_var);
		InvalidFilterCriteriaException__ctor_m8A7E7373F5BFA58916AA7A8D99E49AA3C6861031(L_32, L_31, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_32, NULL, __Filters_FilterAttribute_mBF9879ECFB908212C56CAE0B42C9E29BFCB347C1_RuntimeMethod_var);
	} // end catch (depth: 1)

IL_00ea:
	{
		MemberInfo_t * L_33 = ___m0;
		NullCheck(((FieldInfo_t *)CastclassClass((RuntimeObject*)L_33, FieldInfo_t_il2cpp_TypeInfo_var)));
		int32_t L_34 = VirtFuncInvoker0< int32_t >::Invoke(16 /* System.Reflection.FieldAttributes System.Reflection.FieldInfo::get_Attributes() */, ((FieldInfo_t *)CastclassClass((RuntimeObject*)L_33, FieldInfo_t_il2cpp_TypeInfo_var)));
		V_4 = L_34;
		int32_t L_35 = V_3;
		if (!((int32_t)((int32_t)L_35&(int32_t)7)))
		{
			goto IL_0107;
		}
	}
	{
		int32_t L_36 = V_4;
		int32_t L_37 = V_3;
		if ((((int32_t)((int32_t)((int32_t)L_36&(int32_t)7))) == ((int32_t)((int32_t)((int32_t)L_37&(int32_t)7)))))
		{
			goto IL_0107;
		}
	}
	{
		return (bool)0;
	}

IL_0107:
	{
		int32_t L_38 = V_3;
		if (!((int32_t)((int32_t)L_38&(int32_t)((int32_t)16))))
		{
			goto IL_0116;
		}
	}
	{
		int32_t L_39 = V_4;
		if (((int32_t)((int32_t)L_39&(int32_t)((int32_t)16))))
		{
			goto IL_0116;
		}
	}
	{
		return (bool)0;
	}

IL_0116:
	{
		int32_t L_40 = V_3;
		if (!((int32_t)((int32_t)L_40&(int32_t)((int32_t)32))))
		{
			goto IL_0125;
		}
	}
	{
		int32_t L_41 = V_4;
		if (((int32_t)((int32_t)L_41&(int32_t)((int32_t)32))))
		{
			goto IL_0125;
		}
	}
	{
		return (bool)0;
	}

IL_0125:
	{
		int32_t L_42 = V_3;
		if (!((int32_t)((int32_t)L_42&(int32_t)((int32_t)64))))
		{
			goto IL_0134;
		}
	}
	{
		int32_t L_43 = V_4;
		if (((int32_t)((int32_t)L_43&(int32_t)((int32_t)64))))
		{
			goto IL_0134;
		}
	}
	{
		return (bool)0;
	}

IL_0134:
	{
		int32_t L_44 = V_3;
		if (!((int32_t)((int32_t)L_44&(int32_t)((int32_t)128))))
		{
			goto IL_0149;
		}
	}
	{
		int32_t L_45 = V_4;
		if (((int32_t)((int32_t)L_45&(int32_t)((int32_t)128))))
		{
			goto IL_0149;
		}
	}
	{
		return (bool)0;
	}

IL_0149:
	{
		int32_t L_46 = V_3;
		if (!((int32_t)((int32_t)L_46&(int32_t)((int32_t)8192))))
		{
			goto IL_015e;
		}
	}
	{
		int32_t L_47 = V_4;
		if (((int32_t)((int32_t)L_47&(int32_t)((int32_t)8192))))
		{
			goto IL_015e;
		}
	}
	{
		return (bool)0;
	}

IL_015e:
	{
		return (bool)1;
	}

IL_0160:
	{
		return (bool)0;
	}
}
// System.Boolean System.__Filters::FilterName(System.Reflection.MemberInfo,System.Object)
extern "C" IL2CPP_METHOD_ATTR bool __Filters_FilterName_m768C2766720890EE1D07554E3433C0F828D427DB (__Filters_tDD9D6B7C7A31B12AB3D5CCF1B115DD693F62DB34 * __this, MemberInfo_t * ___m0, RuntimeObject * ___filterCriteria1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (__Filters_FilterName_m768C2766720890EE1D07554E3433C0F828D427DB_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	String_t* V_0 = NULL;
	String_t* V_1 = NULL;
	CHECK_PAUSE_POINT;
	{
		RuntimeObject * L_0 = ___filterCriteria1;
		if (!L_0)
		{
			goto IL_000b;
		}
	}
	{
		RuntimeObject * L_1 = ___filterCriteria1;
		if (((String_t*)IsInstSealed((RuntimeObject*)L_1, String_t_il2cpp_TypeInfo_var)))
		{
			goto IL_001b;
		}
	}

IL_000b:
	{
		String_t* L_2 = Environment_GetResourceString_m2C75C2AF268F01E2BF34AD1C2E1352CF4BA51AD9(_stringLiteralFA8B27A553F27F158C5E4C81F3AA90D26451F922, /*hidden argument*/NULL);
		InvalidFilterCriteriaException_tB11C87F151CD79ACA0837773B9BFD8791CA715BA * L_3 = (InvalidFilterCriteriaException_tB11C87F151CD79ACA0837773B9BFD8791CA715BA *)il2cpp_codegen_object_new(InvalidFilterCriteriaException_tB11C87F151CD79ACA0837773B9BFD8791CA715BA_il2cpp_TypeInfo_var);
		InvalidFilterCriteriaException__ctor_m8A7E7373F5BFA58916AA7A8D99E49AA3C6861031(L_3, L_2, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_3, NULL, __Filters_FilterName_m768C2766720890EE1D07554E3433C0F828D427DB_RuntimeMethod_var);
	}

IL_001b:
	{
		RuntimeObject * L_4 = ___filterCriteria1;
		V_0 = ((String_t*)CastclassSealed((RuntimeObject*)L_4, String_t_il2cpp_TypeInfo_var));
		String_t* L_5 = V_0;
		NullCheck(L_5);
		String_t* L_6 = String_Trim_mB52EB7876C7132358B76B7DC95DEACA20722EF4D(L_5, /*hidden argument*/NULL);
		V_0 = L_6;
		MemberInfo_t * L_7 = ___m0;
		NullCheck(L_7);
		String_t* L_8 = VirtFuncInvoker0< String_t* >::Invoke(7 /* System.String System.Reflection.MemberInfo::get_Name() */, L_7);
		V_1 = L_8;
		MemberInfo_t * L_9 = ___m0;
		NullCheck(L_9);
		int32_t L_10 = VirtFuncInvoker0< int32_t >::Invoke(6 /* System.Reflection.MemberTypes System.Reflection.MemberInfo::get_MemberType() */, L_9);
		if ((!(((uint32_t)L_10) == ((uint32_t)((int32_t)128)))))
		{
			goto IL_004e;
		}
	}
	{
		String_t* L_11 = V_1;
		String_t* L_12 = V_1;
		NullCheck(L_12);
		int32_t L_13 = String_LastIndexOf_m76C37E3915E802044761572007B8FB0635995F59(L_12, ((int32_t)43), /*hidden argument*/NULL);
		NullCheck(L_11);
		String_t* L_14 = String_Substring_m2C4AFF5E79DD8BADFD2DFBCF156BF728FBB8E1AE(L_11, ((int32_t)il2cpp_codegen_add((int32_t)L_13, (int32_t)1)), /*hidden argument*/NULL);
		V_1 = L_14;
	}

IL_004e:
	{
		String_t* L_15 = V_0;
		NullCheck(L_15);
		int32_t L_16 = String_get_Length_mD48C8A16A5CF1914F330DCE82D9BE15C3BEDD018(L_15, /*hidden argument*/NULL);
		if ((((int32_t)L_16) <= ((int32_t)0)))
		{
			goto IL_0082;
		}
	}
	{
		String_t* L_17 = V_0;
		String_t* L_18 = V_0;
		NullCheck(L_18);
		int32_t L_19 = String_get_Length_mD48C8A16A5CF1914F330DCE82D9BE15C3BEDD018(L_18, /*hidden argument*/NULL);
		NullCheck(L_17);
		Il2CppChar L_20 = String_get_Chars_m14308AC3B95F8C1D9F1D1055B116B37D595F1D96(L_17, ((int32_t)il2cpp_codegen_subtract((int32_t)L_19, (int32_t)1)), /*hidden argument*/NULL);
		if ((!(((uint32_t)L_20) == ((uint32_t)((int32_t)42)))))
		{
			goto IL_0082;
		}
	}
	{
		String_t* L_21 = V_0;
		String_t* L_22 = V_0;
		NullCheck(L_22);
		int32_t L_23 = String_get_Length_mD48C8A16A5CF1914F330DCE82D9BE15C3BEDD018(L_22, /*hidden argument*/NULL);
		NullCheck(L_21);
		String_t* L_24 = String_Substring_mB593C0A320C683E6E47EFFC0A12B7A465E5E43BB(L_21, 0, ((int32_t)il2cpp_codegen_subtract((int32_t)L_23, (int32_t)1)), /*hidden argument*/NULL);
		V_0 = L_24;
		String_t* L_25 = V_1;
		String_t* L_26 = V_0;
		NullCheck(L_25);
		bool L_27 = String_StartsWith_m844A95C9A205A0F951B0C45634E0C222E73D0B49(L_25, L_26, 4, /*hidden argument*/NULL);
		return L_27;
	}

IL_0082:
	{
		String_t* L_28 = V_1;
		String_t* L_29 = V_0;
		NullCheck(L_28);
		bool L_30 = String_Equals_m9C4D78DFA0979504FE31429B64A4C26DF48020D1(L_28, L_29, /*hidden argument*/NULL);
		return L_30;
	}
}
// System.Boolean System.__Filters::FilterIgnoreCase(System.Reflection.MemberInfo,System.Object)
extern "C" IL2CPP_METHOD_ATTR bool __Filters_FilterIgnoreCase_m883976C13C53B21BE3430DE51D4317CBCF89F53A (__Filters_tDD9D6B7C7A31B12AB3D5CCF1B115DD693F62DB34 * __this, MemberInfo_t * ___m0, RuntimeObject * ___filterCriteria1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (__Filters_FilterIgnoreCase_m883976C13C53B21BE3430DE51D4317CBCF89F53A_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	String_t* V_0 = NULL;
	String_t* V_1 = NULL;
	CHECK_PAUSE_POINT;
	{
		RuntimeObject * L_0 = ___filterCriteria1;
		if (!L_0)
		{
			goto IL_000b;
		}
	}
	{
		RuntimeObject * L_1 = ___filterCriteria1;
		if (((String_t*)IsInstSealed((RuntimeObject*)L_1, String_t_il2cpp_TypeInfo_var)))
		{
			goto IL_001b;
		}
	}

IL_000b:
	{
		String_t* L_2 = Environment_GetResourceString_m2C75C2AF268F01E2BF34AD1C2E1352CF4BA51AD9(_stringLiteralFA8B27A553F27F158C5E4C81F3AA90D26451F922, /*hidden argument*/NULL);
		InvalidFilterCriteriaException_tB11C87F151CD79ACA0837773B9BFD8791CA715BA * L_3 = (InvalidFilterCriteriaException_tB11C87F151CD79ACA0837773B9BFD8791CA715BA *)il2cpp_codegen_object_new(InvalidFilterCriteriaException_tB11C87F151CD79ACA0837773B9BFD8791CA715BA_il2cpp_TypeInfo_var);
		InvalidFilterCriteriaException__ctor_m8A7E7373F5BFA58916AA7A8D99E49AA3C6861031(L_3, L_2, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_3, NULL, __Filters_FilterIgnoreCase_m883976C13C53B21BE3430DE51D4317CBCF89F53A_RuntimeMethod_var);
	}

IL_001b:
	{
		RuntimeObject * L_4 = ___filterCriteria1;
		V_0 = ((String_t*)CastclassSealed((RuntimeObject*)L_4, String_t_il2cpp_TypeInfo_var));
		String_t* L_5 = V_0;
		NullCheck(L_5);
		String_t* L_6 = String_Trim_mB52EB7876C7132358B76B7DC95DEACA20722EF4D(L_5, /*hidden argument*/NULL);
		V_0 = L_6;
		MemberInfo_t * L_7 = ___m0;
		NullCheck(L_7);
		String_t* L_8 = VirtFuncInvoker0< String_t* >::Invoke(7 /* System.String System.Reflection.MemberInfo::get_Name() */, L_7);
		V_1 = L_8;
		MemberInfo_t * L_9 = ___m0;
		NullCheck(L_9);
		int32_t L_10 = VirtFuncInvoker0< int32_t >::Invoke(6 /* System.Reflection.MemberTypes System.Reflection.MemberInfo::get_MemberType() */, L_9);
		if ((!(((uint32_t)L_10) == ((uint32_t)((int32_t)128)))))
		{
			goto IL_004e;
		}
	}
	{
		String_t* L_11 = V_1;
		String_t* L_12 = V_1;
		NullCheck(L_12);
		int32_t L_13 = String_LastIndexOf_m76C37E3915E802044761572007B8FB0635995F59(L_12, ((int32_t)43), /*hidden argument*/NULL);
		NullCheck(L_11);
		String_t* L_14 = String_Substring_m2C4AFF5E79DD8BADFD2DFBCF156BF728FBB8E1AE(L_11, ((int32_t)il2cpp_codegen_add((int32_t)L_13, (int32_t)1)), /*hidden argument*/NULL);
		V_1 = L_14;
	}

IL_004e:
	{
		String_t* L_15 = V_0;
		NullCheck(L_15);
		int32_t L_16 = String_get_Length_mD48C8A16A5CF1914F330DCE82D9BE15C3BEDD018(L_15, /*hidden argument*/NULL);
		if ((((int32_t)L_16) <= ((int32_t)0)))
		{
			goto IL_008d;
		}
	}
	{
		String_t* L_17 = V_0;
		String_t* L_18 = V_0;
		NullCheck(L_18);
		int32_t L_19 = String_get_Length_mD48C8A16A5CF1914F330DCE82D9BE15C3BEDD018(L_18, /*hidden argument*/NULL);
		NullCheck(L_17);
		Il2CppChar L_20 = String_get_Chars_m14308AC3B95F8C1D9F1D1055B116B37D595F1D96(L_17, ((int32_t)il2cpp_codegen_subtract((int32_t)L_19, (int32_t)1)), /*hidden argument*/NULL);
		if ((!(((uint32_t)L_20) == ((uint32_t)((int32_t)42)))))
		{
			goto IL_008d;
		}
	}
	{
		String_t* L_21 = V_0;
		String_t* L_22 = V_0;
		NullCheck(L_22);
		int32_t L_23 = String_get_Length_mD48C8A16A5CF1914F330DCE82D9BE15C3BEDD018(L_22, /*hidden argument*/NULL);
		NullCheck(L_21);
		String_t* L_24 = String_Substring_mB593C0A320C683E6E47EFFC0A12B7A465E5E43BB(L_21, 0, ((int32_t)il2cpp_codegen_subtract((int32_t)L_23, (int32_t)1)), /*hidden argument*/NULL);
		V_0 = L_24;
		String_t* L_25 = V_1;
		String_t* L_26 = V_0;
		String_t* L_27 = V_0;
		NullCheck(L_27);
		int32_t L_28 = String_get_Length_mD48C8A16A5CF1914F330DCE82D9BE15C3BEDD018(L_27, /*hidden argument*/NULL);
		int32_t L_29 = String_Compare_m208E4853037D81DD5C91DCA060C339DADC3A6064(L_25, 0, L_26, 0, L_28, 5, /*hidden argument*/NULL);
		return (bool)((((int32_t)L_29) == ((int32_t)0))? 1 : 0);
	}

IL_008d:
	{
		String_t* L_30 = V_0;
		String_t* L_31 = V_1;
		int32_t L_32 = String_Compare_m5BD1EF8904C9B13BEDB7A876B122F117B317B442(L_30, L_31, 5, /*hidden argument*/NULL);
		return (bool)((((int32_t)L_32) == ((int32_t)0))? 1 : 0);
	}
}
// System.Void System.__Filters::.ctor()
extern "C" IL2CPP_METHOD_ATTR void __Filters__ctor_mA9DEA9B853B953C85A78E101A8001E9EE0E66B35 (__Filters_tDD9D6B7C7A31B12AB3D5CCF1B115DD693F62DB34 * __this, const RuntimeMethod* method)
{
	CHECK_PAUSE_POINT;
	{
		Object__ctor_m925ECA5E85CA100E3FB86A4F9E15C120E9A184C0(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void System.__Filters::.cctor()
extern "C" IL2CPP_METHOD_ATTR void __Filters__cctor_mAC913CDF08E7AB6541101C4B96483BF49C6E2F14 (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (__Filters__cctor_mAC913CDF08E7AB6541101C4B96483BF49C6E2F14_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	CHECK_PAUSE_POINT;
	{
		__Filters_tDD9D6B7C7A31B12AB3D5CCF1B115DD693F62DB34 * L_0 = (__Filters_tDD9D6B7C7A31B12AB3D5CCF1B115DD693F62DB34 *)il2cpp_codegen_object_new(__Filters_tDD9D6B7C7A31B12AB3D5CCF1B115DD693F62DB34_il2cpp_TypeInfo_var);
		__Filters__ctor_mA9DEA9B853B953C85A78E101A8001E9EE0E66B35(L_0, /*hidden argument*/NULL);
		((__Filters_tDD9D6B7C7A31B12AB3D5CCF1B115DD693F62DB34_StaticFields*)il2cpp_codegen_static_fields_for(__Filters_tDD9D6B7C7A31B12AB3D5CCF1B115DD693F62DB34_il2cpp_TypeInfo_var))->set_Instance_0(L_0);
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
// System.Void System.__Il2CppComDelegate::Finalize()
extern "C" IL2CPP_METHOD_ATTR void __Il2CppComDelegate_Finalize_m893C22F7BEDFBDF8F015EA584CC1419D144D2187 (__Il2CppComDelegate_t0A30496F74225C39A0CF7FADB94934C0536120FD * __this, const RuntimeMethod* method)
{
	__Il2CppComObject_Finalize_m98123DBAAA7974D2616F9E90F2574955714CA9A9(__this, NULL);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void System.__Il2CppComObject::Finalize()
extern "C" IL2CPP_METHOD_ATTR void __Il2CppComObject_Finalize_m98123DBAAA7974D2616F9E90F2574955714CA9A9 (Il2CppComObject * __this, const RuntimeMethod* method)
{
	if (__this->identity != NULL)
	{
		if (il2cpp_codegen_is_import_or_windows_runtime((RuntimeObject*)__this))
		{
			il2cpp_codegen_il2cpp_com_object_cleanup(__this);
		}
		__this->identity->Release();
		__this->identity = NULL;
	}

	Object_Finalize_m4015B7D3A44DE125C5FE34D7276CD4697C06F380(__this, NULL);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Unity.ThrowStub::ThrowNotSupportedException()
extern "C" IL2CPP_METHOD_ATTR void ThrowStub_ThrowNotSupportedException_mA248D7D785682F31CDF02FDC1FAB3173EE1B1E19 (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (ThrowStub_ThrowNotSupportedException_mA248D7D785682F31CDF02FDC1FAB3173EE1B1E19_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	CHECK_PAUSE_POINT;
	{
		PlatformNotSupportedException_t14FE109377F8FA8B3B2F9A0C4FE3BF10662C73B5 * L_0 = (PlatformNotSupportedException_t14FE109377F8FA8B3B2F9A0C4FE3BF10662C73B5 *)il2cpp_codegen_object_new(PlatformNotSupportedException_t14FE109377F8FA8B3B2F9A0C4FE3BF10662C73B5_il2cpp_TypeInfo_var);
		PlatformNotSupportedException__ctor_m651139B17C9EE918551490BC675754EA8EA3E7C7(L_0, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_0, NULL, ThrowStub_ThrowNotSupportedException_mA248D7D785682F31CDF02FDC1FAB3173EE1B1E19_RuntimeMethod_var);
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
