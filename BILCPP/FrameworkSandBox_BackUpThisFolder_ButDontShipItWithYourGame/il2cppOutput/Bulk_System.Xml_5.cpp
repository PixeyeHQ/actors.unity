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
template <typename R, typename T1, typename T2, typename T3>
struct VirtFuncInvoker3
{
	typedef R (*Func)(void*, T1, T2, T3, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1, T2 p2, T3 p3)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		return ((Func)invokeData.methodPtr)(obj, p1, p2, p3, invokeData.method);
	}
};
template <typename T1, typename T2, typename T3>
struct VirtActionInvoker3
{
	typedef void (*Action)(void*, T1, T2, T3, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1, T2 p2, T3 p3)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		((Action)invokeData.methodPtr)(obj, p1, p2, p3, invokeData.method);
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
template <typename R>
struct InterfaceFuncInvoker0
{
	typedef R (*Func)(void*, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		return ((Func)invokeData.methodPtr)(obj, invokeData.method);
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

// System.Action
struct Action_t591D2A86165F896B4B800BB5C25CE18672A55579;
// System.Action`1<System.Object>
struct Action_1_t551A279CEADCF6EEAE8FA2B1E1E757D0D15290D0;
// System.ArgumentException
struct ArgumentException_tEDCD16F20A09ECE461C3DA766C16EDA8864057D1;
// System.AsyncCallback
struct AsyncCallback_t3F3DA3BEDAEE81DD1D24125DF8EB30E85EE14DA4;
// System.Byte[]
struct ByteU5BU5D_tD06FDBE8142446525DF1C40351D523A228373821;
// System.Char[]
struct CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2;
// System.Collections.Generic.Dictionary`2<System.Int32,System.Threading.Tasks.Task>
struct Dictionary_2_t70161CFEB8DA3C79E19E31D0ED948D3C2925095F;
// System.Collections.Generic.Dictionary`2<System.String,System.Int32>
struct Dictionary_2_tD6E204872BA9FD506A0287EF68E285BEB9EC0DFB;
// System.Collections.Generic.Dictionary`2<System.Xml.IDtdEntityInfo,System.Xml.IDtdEntityInfo>
struct Dictionary_2_tD00930653EC02E03C14ADE0FF8737B6193A5FE1B;
// System.Collections.Generic.IComparer`1<System.Object>
struct IComparer_1_tFF77EB203CF12E843446A71A6581145AB929D681;
// System.Collections.Hashtable
struct Hashtable_t978F65B8006C8F5504B286526AEC6608FF983FC9;
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
// System.Exception
struct Exception_t;
// System.Func`1<System.Threading.Tasks.Task/ContingentProperties>
struct Func_1_t48C2978A48CE3F2F6EB5B6DE269D00746483BB1F;
// System.Func`2<System.Object,System.Int32>
struct Func_2_t8B2DA3FB30280CE3D92F50E9CCAACEE4828789A6;
// System.Func`2<System.Object,System.String>
struct Func_2_t44B347E67E515867D995E8BD5EFD67FA88CE53CF;
// System.Func`2<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task`1<System.IO.Stream>>
struct Func_2_t97AE46232676B6C4CB84D0101A45061F2288FCE5;
// System.Func`2<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task`1<System.Object>>
struct Func_2_tDAE4310E42C13AE378CDF0371BD31D6BF4E61EBD;
// System.Globalization.CodePageDataItem
struct CodePageDataItem_t6E34BEE9CCCBB35C88D714664633AF6E5F5671FB;
// System.IAsyncResult
struct IAsyncResult_t8E194308510B375B42432981AE5E7488C458D598;
// System.IO.Stream
struct Stream_tFC50657DD5AAB87770987F9179D934A51D99D5E7;
// System.IO.Stream/ReadWriteTask
struct ReadWriteTask_tFA17EEE8BC5C4C83EAEFCC3662A30DE351ABAA80;
// System.IO.TextReader
struct TextReader_t7DF8314B601D202ECFEDF623093A87BFDAB58D0A;
// System.IntPtr[]
struct IntPtrU5BU5D_t4DC01DCB9A6DF6C9792A6513595D7A11E637DCDD;
// System.Net.Cache.RequestCachePolicy
struct RequestCachePolicy_t30D7352C7E9D49EEADD492A70EC92C118D90CD61;
// System.Net.ICredentials
struct ICredentials_t1A41F1096B037CAB53AE01434DF0747881455344;
// System.Net.IWebProxy
struct IWebProxy_tA24C0862A1ACA35D20FD079E2672CA5786C1A67E;
// System.Predicate`1<System.Object>
struct Predicate_1_t4AA10EFD4C5497CA1CD0FE35A6AF5990FF5D0979;
// System.Predicate`1<System.Threading.Tasks.Task>
struct Predicate_1_tF4286C34BB184CE5690FDCEBA7F09FC68D229335;
// System.Reflection.Binder
struct Binder_t4D5CB06963501D32847C057B57157D6DC49CA759;
// System.Reflection.MemberFilter
struct MemberFilter_t25C1BD92C42BE94426E300787C13C452CB89B381;
// System.Reflection.MethodInfo
struct MethodInfo_t;
// System.Runtime.CompilerServices.IAsyncStateMachine
struct IAsyncStateMachine_tEFDFBE18E061A6065AB2FF735F1425FB59F919BC;
// System.Runtime.Serialization.SafeSerializationManager
struct SafeSerializationManager_t4A754D86B0F784B18CBC36C073BA564BED109770;
// System.String
struct String_t;
// System.String[]
struct StringU5BU5D_t933FB07893230EA91C40FF900D5400665E87B14E;
// System.Text.Decoder
struct Decoder_tEEF45EB6F965222036C49E8EC6BA8A0692AA1F26;
// System.Text.DecoderFallback
struct DecoderFallback_t128445EB7676870485230893338EF044F6B72F60;
// System.Text.DecoderFallbackBuffer
struct DecoderFallbackBuffer_t41EB1B3F5748BEEF5BE883DA09DBDB937441A83C;
// System.Text.EncoderFallback
struct EncoderFallback_tDE342346D01608628F1BCEBB652D31009852CF63;
// System.Text.Encoding
struct Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4;
// System.Text.StringBuilder
struct StringBuilder_t;
// System.Threading.ContextCallback
struct ContextCallback_t8AE8A965AC6C7ECD396F527F15CDC8E683BE1676;
// System.Threading.SemaphoreSlim
struct SemaphoreSlim_t2E2888D1C0C8FAB80823C76F1602E4434B8FA048;
// System.Threading.Tasks.StackGuard
struct StackGuard_tE431ED3BBD1A18705FEE6F948EBF7FA2E99D64A9;
// System.Threading.Tasks.Task/ContingentProperties
struct ContingentProperties_t7149A27D01507C74E8BDAAA3848B45D2644FDF08;
// System.Threading.Tasks.TaskFactory
struct TaskFactory_tF3C6D983390ACFB40B4979E225368F78006D6155;
// System.Threading.Tasks.TaskFactory`1<System.IO.Stream>
struct TaskFactory_1_tE7B6DC2F22643759D47ED49CDDBD8C35D9383D8F;
// System.Threading.Tasks.TaskFactory`1<System.Object>
struct TaskFactory_1_tA50D9207CAE2C505277DD5F03CBE64700177257C;
// System.Threading.Tasks.TaskScheduler
struct TaskScheduler_t966F2798F198FA90A0DA8EFC92BAC08297793114;
// System.Threading.Tasks.Task`1<System.IO.Stream>
struct Task_1_tAA7557E5A6A8B2C89E44907CB5B0502A618E9D01;
// System.Threading.Tasks.Task`1<System.Object>
struct Task_1_tA56001ED5270173CA1432EDFCD84EABB1024BC09;
// System.Threading.Tasks.Task`1<System.Tuple`4<System.Int32,System.Int32,System.Int32,System.Boolean>>
struct Task_1_tFB42A7666202CD6CD81E6BF0FF63815EE40E621D;
// System.Type
struct Type_t;
// System.Type[]
struct TypeU5BU5D_t7FE623A666B49176DE123306221193E888A12F5F;
// System.Uri
struct Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E;
// System.Uri/UriInfo
struct UriInfo_t9FCC6BD4EC1EA14D75209E6A35417057BF6EDC5E;
// System.UriParser
struct UriParser_t07C77D673CCE8D2DA253B8A7ACCB010147F1A4AC;
// System.Void
struct Void_t22962CB4C05B1D89B55A6E1139F0E87A90987017;
// System.Xml.DomNameTable
struct DomNameTable_t09CF0ACAE0D0EA06D0D6892AE0E7D17C7F931C9A;
// System.Xml.EmptyEnumerator
struct EmptyEnumerator_t7702FAD652CDD694DC3D136712CA48C48FFB0DC3;
// System.Xml.IDtdDefaultAttributeInfo
struct IDtdDefaultAttributeInfo_tA4B426A7E92054F6EF626DC0E493CA19C4ECB26A;
// System.Xml.IDtdEntityInfo
struct IDtdEntityInfo_t4477A2221D64D9E3DB7F89E82E963BB4858A38D2;
// System.Xml.IDtdInfo
struct IDtdInfo_t5971A8C09914EDB816FE7A86A38288FDC4B6F80C;
// System.Xml.IValidationEventHandling
struct IValidationEventHandling_tABD39B6B973C0A0DC259D55D8C4179A43ACAB41B;
// System.Xml.IXmlNamespaceResolver
struct IXmlNamespaceResolver_t252EBD93E225063727450B6A8B4BE94F5F2E8427;
// System.Xml.IncrementalReadDecoder
struct IncrementalReadDecoder_t787BFB5889B01B88DDA030C503A0C2E0525CA723;
// System.Xml.Schema.IXmlSchemaInfo
struct IXmlSchemaInfo_t2FE768B806BA73C644AEE436491F2C3E04039CF1;
// System.Xml.Schema.SchemaInfo
struct SchemaInfo_tD9774489795A78B9235BAD315E5242C974183A41;
// System.Xml.Schema.XmlSchemaSet
struct XmlSchemaSet_tD92B4BF5F65FBF5B106399A36284FDC64E602F7F;
// System.Xml.XmlAttribute
struct XmlAttribute_tEAB5F066D1D6965D6528617BD89826AE7114DEFA;
// System.Xml.XmlCharacterData
struct XmlCharacterData_tA7587D706680E42BD7A094F87CB0859C840A8531;
// System.Xml.XmlDocument
struct XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97;
// System.Xml.XmlDownloadManager
struct XmlDownloadManager_tF864449330C09DCF4353B7F17EA226CE28C4D752;
// System.Xml.XmlException
struct XmlException_tD7DA2CBE07488D18EE7A284862B7523E3CD4365D;
// System.Xml.XmlImplementation
struct XmlImplementation_t7C01D70C3943C7AA929C106D360E90E2D576E1EF;
// System.Xml.XmlLinkedNode
struct XmlLinkedNode_t4F76C8580C2E6D2908D88AC84A86060FA9289A0E;
// System.Xml.XmlName
struct XmlName_t993BD9C827C8B0B6A0B7C49A03F2D14740AC2682;
// System.Xml.XmlNameTable
struct XmlNameTable_t3C1CDAB4E7D97DE41A409D6D9ADD2C10B1F281A6;
// System.Xml.XmlNamedNodeMap
struct XmlNamedNodeMap_t260246787BA7B6747AB878378D22EC7693465E31;
// System.Xml.XmlNamespaceManager
struct XmlNamespaceManager_t8323BEB96BBE8F75207DC2AAFE9430E7F473658F;
// System.Xml.XmlNamespaceManager/NamespaceDeclaration[]
struct NamespaceDeclarationU5BU5D_t92995CBBEC52166860E77B72B8EEFF00E4D64E84;
// System.Xml.XmlNode
struct XmlNode_t07D70045D843753E4FE8AFE40FD36244E6B6D7FB;
// System.Xml.XmlNodeChangedEventHandler
struct XmlNodeChangedEventHandler_t730DECDAE07BB728186F47DDF2A569F50A889838;
// System.Xml.XmlParserContext
struct XmlParserContext_tDC3A95452BC683F0D64EC3C4AF9934D3FC732279;
// System.Xml.XmlReader
struct XmlReader_t13F08E3C651EB9F2AE882342BCD5E2CA86F29ABB;
// System.Xml.XmlResolver
struct XmlResolver_t93269F14B2F8750D040AED2FB7A303CE85016280;
// System.Xml.XmlTextReaderImpl
struct XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61;
// System.Xml.XmlTextReaderImpl/DtdDefaultAttributeInfoToNodeDataComparer
struct DtdDefaultAttributeInfoToNodeDataComparer_t0B9FEF7A80832980C3E32D47BE835964E8B423B7;
// System.Xml.XmlTextReaderImpl/DtdParserProxy
struct DtdParserProxy_tF94C8FBE3EC41EF7C960BEDC0CD3DD25090265B7;
// System.Xml.XmlTextReaderImpl/LaterInitParam
struct LaterInitParam_tE2FFFA55A2C7B183721762B4AC4B0DF93485A1AF;
// System.Xml.XmlTextReaderImpl/NoNamespaceManager
struct NoNamespaceManager_t11014200BFBB3974A5E72A75867B9730C7D7E883;
// System.Xml.XmlTextReaderImpl/NodeData
struct NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF;
// System.Xml.XmlTextReaderImpl/NodeData[]
struct NodeDataU5BU5D_tD5EBFFECEF67B4D0D7D521A99182D3B2814E07BE;
// System.Xml.XmlTextReaderImpl/OnDefaultAttributeUseDelegate
struct OnDefaultAttributeUseDelegate_tE83A97BD37E08D3C5AA377CEA6388782D99EA34D;
// System.Xml.XmlTextReaderImpl/ParsingState[]
struct ParsingStateU5BU5D_t7A5096046F9BF1BA70E9696B2A2479272FC65739;
// System.Xml.XmlTextReaderImpl/XmlContext
struct XmlContext_tC94B1A0D023B096ADF338FA72FB55D0E2DBF9B52;
// System.Xml.XmlUnspecifiedAttribute
struct XmlUnspecifiedAttribute_t1C82B285B60096D164B703202A8BD91A2009DE5D;
// System.Xml.XmlUrlResolver
struct XmlUrlResolver_t43FE24F4601B4197354EFB5783E5CB9F57997EC9;
// System.Xml.XmlWhitespace
struct XmlWhitespace_tF5EA718743A148EBF7594ADF5A06B3224857AD4D;

extern RuntimeClass* ArgumentException_tEDCD16F20A09ECE461C3DA766C16EDA8864057D1_il2cpp_TypeInfo_var;
extern RuntimeClass* AsyncTaskMethodBuilder_1_t2A9513A084F4B19851B91EF1F22BB57776D35663_il2cpp_TypeInfo_var;
extern RuntimeClass* DtdDefaultAttributeInfoToNodeDataComparer_t0B9FEF7A80832980C3E32D47BE835964E8B423B7_il2cpp_TypeInfo_var;
extern RuntimeClass* Exception_t_il2cpp_TypeInfo_var;
extern RuntimeClass* IDtdAttributeInfo_t650C2A35C205461E5ECF38D70B0D9CD8A4B46068_il2cpp_TypeInfo_var;
extern RuntimeClass* IDtdDefaultAttributeInfo_tA4B426A7E92054F6EF626DC0E493CA19C4ECB26A_il2cpp_TypeInfo_var;
extern RuntimeClass* NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF_il2cpp_TypeInfo_var;
extern RuntimeClass* String_t_il2cpp_TypeInfo_var;
extern RuntimeClass* Type_t_il2cpp_TypeInfo_var;
extern RuntimeClass* XmlDownloadManager_tF864449330C09DCF4353B7F17EA226CE28C4D752_il2cpp_TypeInfo_var;
extern RuntimeClass* XmlException_tD7DA2CBE07488D18EE7A284862B7523E3CD4365D_il2cpp_TypeInfo_var;
extern RuntimeClass* XmlUnspecifiedAttribute_t1C82B285B60096D164B703202A8BD91A2009DE5D_il2cpp_TypeInfo_var;
extern RuntimeClass* XmlUrlResolver_t43FE24F4601B4197354EFB5783E5CB9F57997EC9_il2cpp_TypeInfo_var;
extern String_t* _stringLiteral05A79F06CF3F67F726DAE68D18A2290F6C9A50C9;
extern String_t* _stringLiteral16A3C2A876EADFBFB7EF0193C48BCF6088E0B6AD;
extern String_t* _stringLiteral4599D801351B053589C8FB8B5E3D7A2604B79DE2;
extern String_t* _stringLiteralB8C1626447FA8716F0689D3C8B247CF5BDA4ED6D;
extern const RuntimeMethod* AsyncTaskMethodBuilder_1_AwaitUnsafeOnCompleted_TisConfiguredTaskAwaiter_t27ECAA4B74502BD3AC7E68F47088D46DAA13D133_TisU3CGetEntityAsyncU3Ed__15_t383C4608618A66FB04F41F38C0534EE9E14CC934_m2ADCCD4826BB678962D141602B12B2B0F69CC672_RuntimeMethod_var;
extern const RuntimeMethod* AsyncTaskMethodBuilder_1_Create_mC7806A5C115ED2239A5073313AA3564D8244156E_RuntimeMethod_var;
extern const RuntimeMethod* AsyncTaskMethodBuilder_1_SetException_m4C0B5462ECCB520FACA3C90B353DF596DAAF586D_RuntimeMethod_var;
extern const RuntimeMethod* AsyncTaskMethodBuilder_1_SetResult_mD7DA7A17DC0610B11A0AAA364C3CA51FEC1271DB_RuntimeMethod_var;
extern const RuntimeMethod* AsyncTaskMethodBuilder_1_SetStateMachine_m5CC21A02320CF3D2DD7894A31123DFD82A428E4C_RuntimeMethod_var;
extern const RuntimeMethod* AsyncTaskMethodBuilder_1_Start_TisU3CGetEntityAsyncU3Ed__15_t383C4608618A66FB04F41F38C0534EE9E14CC934_mF03E454780149AFBE6F88C60A4283797936195AD_RuntimeMethod_var;
extern const RuntimeMethod* AsyncTaskMethodBuilder_1_get_Task_m19C5664D70C4FC799BEFB8D0FC98E687F97059FA_RuntimeMethod_var;
extern const RuntimeMethod* ConfiguredTaskAwaitable_1_GetAwaiter_m7A0F2D7CFD71CFFC2586B93E3A1FAD30221784BC_RuntimeMethod_var;
extern const RuntimeMethod* ConfiguredTaskAwaiter_GetResult_m4F8B73FFFC823973FDD6AD1386EE0D8B7CEDF8ED_RuntimeMethod_var;
extern const RuntimeMethod* ConfiguredTaskAwaiter_get_IsCompleted_m0720F20A96AD14393558BEB67540D8545A45FABF_RuntimeMethod_var;
extern const RuntimeMethod* DtdDefaultAttributeInfoToNodeDataComparer_Compare_m9F094BA85561258B6DAA077B369BD4380599FDE3_RuntimeMethod_var;
extern const RuntimeMethod* Task_1_ConfigureAwait_m190880408777F02426C980806C63032BEC154505_RuntimeMethod_var;
extern const RuntimeMethod* U3CGetEntityAsyncU3Ed__15_MoveNext_m025A24D8C9AF0CAE7D6470F3BE1FD32F71BD1966_RuntimeMethod_var;
extern const RuntimeMethod* XmlUrlResolver_GetEntity_m48F7349856F393B8FF6990C85993D607989E8663_RuntimeMethod_var;
extern const RuntimeMethod* XmlWhitespace__ctor_m016512E3F1D4094C7B53F02D9799AF5303E34A64_RuntimeMethod_var;
extern const RuntimeType* RuntimeObject_0_0_0_var;
extern const RuntimeType* Stream_tFC50657DD5AAB87770987F9179D934A51D99D5E7_0_0_0_var;
extern const uint32_t DtdDefaultAttributeInfoToNodeDataComparer_Compare_m9F094BA85561258B6DAA077B369BD4380599FDE3_MetadataUsageId;
extern const uint32_t DtdDefaultAttributeInfoToNodeDataComparer__cctor_m0C04DBA55773309DA7070567B915912CC7C1A59D_MetadataUsageId;
extern const uint32_t DtdDefaultAttributeInfoToNodeDataComparer_get_Instance_m874469D09ABF5CCAC32A665B40B6CC9FD88B3638_MetadataUsageId;
extern const uint32_t NoNamespaceManager_LookupNamespace_m99593EEE9A0B2EE9505F98C205A63B35B07C273B_MetadataUsageId;
extern const uint32_t NoNamespaceManager_get_DefaultNamespace_mF2EE6849B1F51B0A441399EB7FF3F1F36869C4C4_MetadataUsageId;
extern const uint32_t NodeData_ClearName_m4EEEF5315A52473FC6470BB297C8E506FECD764B_MetadataUsageId;
extern const uint32_t NodeData_Clear_mD71A1EC98F0BE924739AE49F5457A45ADA7A5C4D_MetadataUsageId;
extern const uint32_t NodeData_CreateNameWPrefix_m5D8818A7500ABBADB43B2923EEC59CCDC28B3F97_MetadataUsageId;
extern const uint32_t NodeData_SetNamedNode_m5BE05A811DCE5E36A09613E92B6EB7C69F291949_MetadataUsageId;
extern const uint32_t NodeData_SetNamedNode_m77D0D37FB571646037FE64C72649995D06218A5F_MetadataUsageId;
extern const uint32_t NodeData_System_IComparable_CompareTo_m4E92445E817BC3141166CBED8CFCD9C1C8577F62_MetadataUsageId;
extern const uint32_t NodeData_get_None_m439866B97299F03866A79F6A178B2FD4A45F6E6B_MetadataUsageId;
extern const uint32_t ParsingState_Clear_mB03C277E58A91CB626BBE6EC5CF2D6E97ECE48E2_MetadataUsageId;
extern const uint32_t U3CGetEntityAsyncU3Ed__15_MoveNext_m025A24D8C9AF0CAE7D6470F3BE1FD32F71BD1966_MetadataUsageId;
extern const uint32_t U3CGetEntityAsyncU3Ed__15_SetStateMachine_m102A8E0E12BF7F318C7880C850455EF3AF4B8D0B_MetadataUsageId;
extern const uint32_t XmlContext__ctor_m286116CAF14DF829F24584EA85FC55DA1A507DBF_MetadataUsageId;
extern const uint32_t XmlUnspecifiedAttribute_CloneNode_mC54FB5A0257784A556FC0789575EB4DE4DA0EC38_MetadataUsageId;
extern const uint32_t XmlUrlResolver_GetEntityAsync_m95A9D45B7E41B78FD1784BB897FEC70567CB06E8_MetadataUsageId;
extern const uint32_t XmlUrlResolver_GetEntity_m48F7349856F393B8FF6990C85993D607989E8663_MetadataUsageId;
extern const uint32_t XmlUrlResolver_get_DownloadManager_m420E0324A705EBAF4320453656ABAAC232A173C0_MetadataUsageId;
extern const uint32_t XmlWhitespace__ctor_m016512E3F1D4094C7B53F02D9799AF5303E34A64_MetadataUsageId;
struct Delegate_t_marshaled_com;
struct Delegate_t_marshaled_pinvoke;
struct Exception_t_marshaled_com;
struct Exception_t_marshaled_pinvoke;

struct ByteU5BU5D_tD06FDBE8142446525DF1C40351D523A228373821;
struct CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2;
struct DelegateU5BU5D_tDFCDEE2A6322F96C0FE49AF47E9ADB8C4B294E86;


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
#ifndef MARSHALBYREFOBJECT_TC4577953D0A44D0AB8597CFA868E01C858B1C9AF_H
#define MARSHALBYREFOBJECT_TC4577953D0A44D0AB8597CFA868E01C858B1C9AF_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.MarshalByRefObject
struct  MarshalByRefObject_tC4577953D0A44D0AB8597CFA868E01C858B1C9AF  : public RuntimeObject
{
public:
	// System.Object System.MarshalByRefObject::_identity
	RuntimeObject * ____identity_0;

public:
	inline static int32_t get_offset_of__identity_0() { return static_cast<int32_t>(offsetof(MarshalByRefObject_tC4577953D0A44D0AB8597CFA868E01C858B1C9AF, ____identity_0)); }
	inline RuntimeObject * get__identity_0() const { return ____identity_0; }
	inline RuntimeObject ** get_address_of__identity_0() { return &____identity_0; }
	inline void set__identity_0(RuntimeObject * value)
	{
		____identity_0 = value;
		Il2CppCodeGenWriteBarrier((&____identity_0), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// Native definition for P/Invoke marshalling of System.MarshalByRefObject
struct MarshalByRefObject_tC4577953D0A44D0AB8597CFA868E01C858B1C9AF_marshaled_pinvoke
{
	Il2CppIUnknown* ____identity_0;
};
// Native definition for COM marshalling of System.MarshalByRefObject
struct MarshalByRefObject_tC4577953D0A44D0AB8597CFA868E01C858B1C9AF_marshaled_com
{
	Il2CppIUnknown* ____identity_0;
};
#endif // MARSHALBYREFOBJECT_TC4577953D0A44D0AB8597CFA868E01C858B1C9AF_H
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
#ifndef DECODER_TEEF45EB6F965222036C49E8EC6BA8A0692AA1F26_H
#define DECODER_TEEF45EB6F965222036C49E8EC6BA8A0692AA1F26_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Text.Decoder
struct  Decoder_tEEF45EB6F965222036C49E8EC6BA8A0692AA1F26  : public RuntimeObject
{
public:
	// System.Text.DecoderFallback System.Text.Decoder::m_fallback
	DecoderFallback_t128445EB7676870485230893338EF044F6B72F60 * ___m_fallback_0;
	// System.Text.DecoderFallbackBuffer System.Text.Decoder::m_fallbackBuffer
	DecoderFallbackBuffer_t41EB1B3F5748BEEF5BE883DA09DBDB937441A83C * ___m_fallbackBuffer_1;

public:
	inline static int32_t get_offset_of_m_fallback_0() { return static_cast<int32_t>(offsetof(Decoder_tEEF45EB6F965222036C49E8EC6BA8A0692AA1F26, ___m_fallback_0)); }
	inline DecoderFallback_t128445EB7676870485230893338EF044F6B72F60 * get_m_fallback_0() const { return ___m_fallback_0; }
	inline DecoderFallback_t128445EB7676870485230893338EF044F6B72F60 ** get_address_of_m_fallback_0() { return &___m_fallback_0; }
	inline void set_m_fallback_0(DecoderFallback_t128445EB7676870485230893338EF044F6B72F60 * value)
	{
		___m_fallback_0 = value;
		Il2CppCodeGenWriteBarrier((&___m_fallback_0), value);
	}

	inline static int32_t get_offset_of_m_fallbackBuffer_1() { return static_cast<int32_t>(offsetof(Decoder_tEEF45EB6F965222036C49E8EC6BA8A0692AA1F26, ___m_fallbackBuffer_1)); }
	inline DecoderFallbackBuffer_t41EB1B3F5748BEEF5BE883DA09DBDB937441A83C * get_m_fallbackBuffer_1() const { return ___m_fallbackBuffer_1; }
	inline DecoderFallbackBuffer_t41EB1B3F5748BEEF5BE883DA09DBDB937441A83C ** get_address_of_m_fallbackBuffer_1() { return &___m_fallbackBuffer_1; }
	inline void set_m_fallbackBuffer_1(DecoderFallbackBuffer_t41EB1B3F5748BEEF5BE883DA09DBDB937441A83C * value)
	{
		___m_fallbackBuffer_1 = value;
		Il2CppCodeGenWriteBarrier((&___m_fallbackBuffer_1), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // DECODER_TEEF45EB6F965222036C49E8EC6BA8A0692AA1F26_H
#ifndef ENCODING_T7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4_H
#define ENCODING_T7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Text.Encoding
struct  Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4  : public RuntimeObject
{
public:
	// System.Int32 System.Text.Encoding::m_codePage
	int32_t ___m_codePage_9;
	// System.Globalization.CodePageDataItem System.Text.Encoding::dataItem
	CodePageDataItem_t6E34BEE9CCCBB35C88D714664633AF6E5F5671FB * ___dataItem_10;
	// System.Boolean System.Text.Encoding::m_deserializedFromEverett
	bool ___m_deserializedFromEverett_11;
	// System.Boolean System.Text.Encoding::m_isReadOnly
	bool ___m_isReadOnly_12;
	// System.Text.EncoderFallback System.Text.Encoding::encoderFallback
	EncoderFallback_tDE342346D01608628F1BCEBB652D31009852CF63 * ___encoderFallback_13;
	// System.Text.DecoderFallback System.Text.Encoding::decoderFallback
	DecoderFallback_t128445EB7676870485230893338EF044F6B72F60 * ___decoderFallback_14;

public:
	inline static int32_t get_offset_of_m_codePage_9() { return static_cast<int32_t>(offsetof(Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4, ___m_codePage_9)); }
	inline int32_t get_m_codePage_9() const { return ___m_codePage_9; }
	inline int32_t* get_address_of_m_codePage_9() { return &___m_codePage_9; }
	inline void set_m_codePage_9(int32_t value)
	{
		___m_codePage_9 = value;
	}

	inline static int32_t get_offset_of_dataItem_10() { return static_cast<int32_t>(offsetof(Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4, ___dataItem_10)); }
	inline CodePageDataItem_t6E34BEE9CCCBB35C88D714664633AF6E5F5671FB * get_dataItem_10() const { return ___dataItem_10; }
	inline CodePageDataItem_t6E34BEE9CCCBB35C88D714664633AF6E5F5671FB ** get_address_of_dataItem_10() { return &___dataItem_10; }
	inline void set_dataItem_10(CodePageDataItem_t6E34BEE9CCCBB35C88D714664633AF6E5F5671FB * value)
	{
		___dataItem_10 = value;
		Il2CppCodeGenWriteBarrier((&___dataItem_10), value);
	}

	inline static int32_t get_offset_of_m_deserializedFromEverett_11() { return static_cast<int32_t>(offsetof(Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4, ___m_deserializedFromEverett_11)); }
	inline bool get_m_deserializedFromEverett_11() const { return ___m_deserializedFromEverett_11; }
	inline bool* get_address_of_m_deserializedFromEverett_11() { return &___m_deserializedFromEverett_11; }
	inline void set_m_deserializedFromEverett_11(bool value)
	{
		___m_deserializedFromEverett_11 = value;
	}

	inline static int32_t get_offset_of_m_isReadOnly_12() { return static_cast<int32_t>(offsetof(Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4, ___m_isReadOnly_12)); }
	inline bool get_m_isReadOnly_12() const { return ___m_isReadOnly_12; }
	inline bool* get_address_of_m_isReadOnly_12() { return &___m_isReadOnly_12; }
	inline void set_m_isReadOnly_12(bool value)
	{
		___m_isReadOnly_12 = value;
	}

	inline static int32_t get_offset_of_encoderFallback_13() { return static_cast<int32_t>(offsetof(Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4, ___encoderFallback_13)); }
	inline EncoderFallback_tDE342346D01608628F1BCEBB652D31009852CF63 * get_encoderFallback_13() const { return ___encoderFallback_13; }
	inline EncoderFallback_tDE342346D01608628F1BCEBB652D31009852CF63 ** get_address_of_encoderFallback_13() { return &___encoderFallback_13; }
	inline void set_encoderFallback_13(EncoderFallback_tDE342346D01608628F1BCEBB652D31009852CF63 * value)
	{
		___encoderFallback_13 = value;
		Il2CppCodeGenWriteBarrier((&___encoderFallback_13), value);
	}

	inline static int32_t get_offset_of_decoderFallback_14() { return static_cast<int32_t>(offsetof(Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4, ___decoderFallback_14)); }
	inline DecoderFallback_t128445EB7676870485230893338EF044F6B72F60 * get_decoderFallback_14() const { return ___decoderFallback_14; }
	inline DecoderFallback_t128445EB7676870485230893338EF044F6B72F60 ** get_address_of_decoderFallback_14() { return &___decoderFallback_14; }
	inline void set_decoderFallback_14(DecoderFallback_t128445EB7676870485230893338EF044F6B72F60 * value)
	{
		___decoderFallback_14 = value;
		Il2CppCodeGenWriteBarrier((&___decoderFallback_14), value);
	}
};

struct Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4_StaticFields
{
public:
	// System.Text.Encoding modreq(System.Runtime.CompilerServices.IsVolatile) System.Text.Encoding::defaultEncoding
	Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4 * ___defaultEncoding_0;
	// System.Text.Encoding modreq(System.Runtime.CompilerServices.IsVolatile) System.Text.Encoding::unicodeEncoding
	Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4 * ___unicodeEncoding_1;
	// System.Text.Encoding modreq(System.Runtime.CompilerServices.IsVolatile) System.Text.Encoding::bigEndianUnicode
	Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4 * ___bigEndianUnicode_2;
	// System.Text.Encoding modreq(System.Runtime.CompilerServices.IsVolatile) System.Text.Encoding::utf7Encoding
	Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4 * ___utf7Encoding_3;
	// System.Text.Encoding modreq(System.Runtime.CompilerServices.IsVolatile) System.Text.Encoding::utf8Encoding
	Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4 * ___utf8Encoding_4;
	// System.Text.Encoding modreq(System.Runtime.CompilerServices.IsVolatile) System.Text.Encoding::utf32Encoding
	Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4 * ___utf32Encoding_5;
	// System.Text.Encoding modreq(System.Runtime.CompilerServices.IsVolatile) System.Text.Encoding::asciiEncoding
	Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4 * ___asciiEncoding_6;
	// System.Text.Encoding modreq(System.Runtime.CompilerServices.IsVolatile) System.Text.Encoding::latin1Encoding
	Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4 * ___latin1Encoding_7;
	// System.Collections.Hashtable modreq(System.Runtime.CompilerServices.IsVolatile) System.Text.Encoding::encodings
	Hashtable_t978F65B8006C8F5504B286526AEC6608FF983FC9 * ___encodings_8;
	// System.Object System.Text.Encoding::s_InternalSyncObject
	RuntimeObject * ___s_InternalSyncObject_15;

public:
	inline static int32_t get_offset_of_defaultEncoding_0() { return static_cast<int32_t>(offsetof(Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4_StaticFields, ___defaultEncoding_0)); }
	inline Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4 * get_defaultEncoding_0() const { return ___defaultEncoding_0; }
	inline Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4 ** get_address_of_defaultEncoding_0() { return &___defaultEncoding_0; }
	inline void set_defaultEncoding_0(Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4 * value)
	{
		___defaultEncoding_0 = value;
		Il2CppCodeGenWriteBarrier((&___defaultEncoding_0), value);
	}

	inline static int32_t get_offset_of_unicodeEncoding_1() { return static_cast<int32_t>(offsetof(Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4_StaticFields, ___unicodeEncoding_1)); }
	inline Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4 * get_unicodeEncoding_1() const { return ___unicodeEncoding_1; }
	inline Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4 ** get_address_of_unicodeEncoding_1() { return &___unicodeEncoding_1; }
	inline void set_unicodeEncoding_1(Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4 * value)
	{
		___unicodeEncoding_1 = value;
		Il2CppCodeGenWriteBarrier((&___unicodeEncoding_1), value);
	}

	inline static int32_t get_offset_of_bigEndianUnicode_2() { return static_cast<int32_t>(offsetof(Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4_StaticFields, ___bigEndianUnicode_2)); }
	inline Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4 * get_bigEndianUnicode_2() const { return ___bigEndianUnicode_2; }
	inline Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4 ** get_address_of_bigEndianUnicode_2() { return &___bigEndianUnicode_2; }
	inline void set_bigEndianUnicode_2(Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4 * value)
	{
		___bigEndianUnicode_2 = value;
		Il2CppCodeGenWriteBarrier((&___bigEndianUnicode_2), value);
	}

	inline static int32_t get_offset_of_utf7Encoding_3() { return static_cast<int32_t>(offsetof(Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4_StaticFields, ___utf7Encoding_3)); }
	inline Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4 * get_utf7Encoding_3() const { return ___utf7Encoding_3; }
	inline Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4 ** get_address_of_utf7Encoding_3() { return &___utf7Encoding_3; }
	inline void set_utf7Encoding_3(Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4 * value)
	{
		___utf7Encoding_3 = value;
		Il2CppCodeGenWriteBarrier((&___utf7Encoding_3), value);
	}

	inline static int32_t get_offset_of_utf8Encoding_4() { return static_cast<int32_t>(offsetof(Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4_StaticFields, ___utf8Encoding_4)); }
	inline Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4 * get_utf8Encoding_4() const { return ___utf8Encoding_4; }
	inline Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4 ** get_address_of_utf8Encoding_4() { return &___utf8Encoding_4; }
	inline void set_utf8Encoding_4(Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4 * value)
	{
		___utf8Encoding_4 = value;
		Il2CppCodeGenWriteBarrier((&___utf8Encoding_4), value);
	}

	inline static int32_t get_offset_of_utf32Encoding_5() { return static_cast<int32_t>(offsetof(Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4_StaticFields, ___utf32Encoding_5)); }
	inline Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4 * get_utf32Encoding_5() const { return ___utf32Encoding_5; }
	inline Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4 ** get_address_of_utf32Encoding_5() { return &___utf32Encoding_5; }
	inline void set_utf32Encoding_5(Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4 * value)
	{
		___utf32Encoding_5 = value;
		Il2CppCodeGenWriteBarrier((&___utf32Encoding_5), value);
	}

	inline static int32_t get_offset_of_asciiEncoding_6() { return static_cast<int32_t>(offsetof(Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4_StaticFields, ___asciiEncoding_6)); }
	inline Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4 * get_asciiEncoding_6() const { return ___asciiEncoding_6; }
	inline Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4 ** get_address_of_asciiEncoding_6() { return &___asciiEncoding_6; }
	inline void set_asciiEncoding_6(Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4 * value)
	{
		___asciiEncoding_6 = value;
		Il2CppCodeGenWriteBarrier((&___asciiEncoding_6), value);
	}

	inline static int32_t get_offset_of_latin1Encoding_7() { return static_cast<int32_t>(offsetof(Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4_StaticFields, ___latin1Encoding_7)); }
	inline Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4 * get_latin1Encoding_7() const { return ___latin1Encoding_7; }
	inline Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4 ** get_address_of_latin1Encoding_7() { return &___latin1Encoding_7; }
	inline void set_latin1Encoding_7(Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4 * value)
	{
		___latin1Encoding_7 = value;
		Il2CppCodeGenWriteBarrier((&___latin1Encoding_7), value);
	}

	inline static int32_t get_offset_of_encodings_8() { return static_cast<int32_t>(offsetof(Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4_StaticFields, ___encodings_8)); }
	inline Hashtable_t978F65B8006C8F5504B286526AEC6608FF983FC9 * get_encodings_8() const { return ___encodings_8; }
	inline Hashtable_t978F65B8006C8F5504B286526AEC6608FF983FC9 ** get_address_of_encodings_8() { return &___encodings_8; }
	inline void set_encodings_8(Hashtable_t978F65B8006C8F5504B286526AEC6608FF983FC9 * value)
	{
		___encodings_8 = value;
		Il2CppCodeGenWriteBarrier((&___encodings_8), value);
	}

	inline static int32_t get_offset_of_s_InternalSyncObject_15() { return static_cast<int32_t>(offsetof(Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4_StaticFields, ___s_InternalSyncObject_15)); }
	inline RuntimeObject * get_s_InternalSyncObject_15() const { return ___s_InternalSyncObject_15; }
	inline RuntimeObject ** get_address_of_s_InternalSyncObject_15() { return &___s_InternalSyncObject_15; }
	inline void set_s_InternalSyncObject_15(RuntimeObject * value)
	{
		___s_InternalSyncObject_15 = value;
		Il2CppCodeGenWriteBarrier((&___s_InternalSyncObject_15), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // ENCODING_T7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4_H
#ifndef STRINGBUILDER_T_H
#define STRINGBUILDER_T_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Text.StringBuilder
struct  StringBuilder_t  : public RuntimeObject
{
public:
	// System.Char[] System.Text.StringBuilder::m_ChunkChars
	CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2* ___m_ChunkChars_0;
	// System.Text.StringBuilder System.Text.StringBuilder::m_ChunkPrevious
	StringBuilder_t * ___m_ChunkPrevious_1;
	// System.Int32 System.Text.StringBuilder::m_ChunkLength
	int32_t ___m_ChunkLength_2;
	// System.Int32 System.Text.StringBuilder::m_ChunkOffset
	int32_t ___m_ChunkOffset_3;
	// System.Int32 System.Text.StringBuilder::m_MaxCapacity
	int32_t ___m_MaxCapacity_4;

public:
	inline static int32_t get_offset_of_m_ChunkChars_0() { return static_cast<int32_t>(offsetof(StringBuilder_t, ___m_ChunkChars_0)); }
	inline CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2* get_m_ChunkChars_0() const { return ___m_ChunkChars_0; }
	inline CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2** get_address_of_m_ChunkChars_0() { return &___m_ChunkChars_0; }
	inline void set_m_ChunkChars_0(CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2* value)
	{
		___m_ChunkChars_0 = value;
		Il2CppCodeGenWriteBarrier((&___m_ChunkChars_0), value);
	}

	inline static int32_t get_offset_of_m_ChunkPrevious_1() { return static_cast<int32_t>(offsetof(StringBuilder_t, ___m_ChunkPrevious_1)); }
	inline StringBuilder_t * get_m_ChunkPrevious_1() const { return ___m_ChunkPrevious_1; }
	inline StringBuilder_t ** get_address_of_m_ChunkPrevious_1() { return &___m_ChunkPrevious_1; }
	inline void set_m_ChunkPrevious_1(StringBuilder_t * value)
	{
		___m_ChunkPrevious_1 = value;
		Il2CppCodeGenWriteBarrier((&___m_ChunkPrevious_1), value);
	}

	inline static int32_t get_offset_of_m_ChunkLength_2() { return static_cast<int32_t>(offsetof(StringBuilder_t, ___m_ChunkLength_2)); }
	inline int32_t get_m_ChunkLength_2() const { return ___m_ChunkLength_2; }
	inline int32_t* get_address_of_m_ChunkLength_2() { return &___m_ChunkLength_2; }
	inline void set_m_ChunkLength_2(int32_t value)
	{
		___m_ChunkLength_2 = value;
	}

	inline static int32_t get_offset_of_m_ChunkOffset_3() { return static_cast<int32_t>(offsetof(StringBuilder_t, ___m_ChunkOffset_3)); }
	inline int32_t get_m_ChunkOffset_3() const { return ___m_ChunkOffset_3; }
	inline int32_t* get_address_of_m_ChunkOffset_3() { return &___m_ChunkOffset_3; }
	inline void set_m_ChunkOffset_3(int32_t value)
	{
		___m_ChunkOffset_3 = value;
	}

	inline static int32_t get_offset_of_m_MaxCapacity_4() { return static_cast<int32_t>(offsetof(StringBuilder_t, ___m_MaxCapacity_4)); }
	inline int32_t get_m_MaxCapacity_4() const { return ___m_MaxCapacity_4; }
	inline int32_t* get_address_of_m_MaxCapacity_4() { return &___m_MaxCapacity_4; }
	inline void set_m_MaxCapacity_4(int32_t value)
	{
		___m_MaxCapacity_4 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // STRINGBUILDER_T_H
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
#ifndef XMLDOWNLOADMANAGER_TF864449330C09DCF4353B7F17EA226CE28C4D752_H
#define XMLDOWNLOADMANAGER_TF864449330C09DCF4353B7F17EA226CE28C4D752_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.XmlDownloadManager
struct  XmlDownloadManager_tF864449330C09DCF4353B7F17EA226CE28C4D752  : public RuntimeObject
{
public:
	// System.Collections.Hashtable System.Xml.XmlDownloadManager::connections
	Hashtable_t978F65B8006C8F5504B286526AEC6608FF983FC9 * ___connections_0;

public:
	inline static int32_t get_offset_of_connections_0() { return static_cast<int32_t>(offsetof(XmlDownloadManager_tF864449330C09DCF4353B7F17EA226CE28C4D752, ___connections_0)); }
	inline Hashtable_t978F65B8006C8F5504B286526AEC6608FF983FC9 * get_connections_0() const { return ___connections_0; }
	inline Hashtable_t978F65B8006C8F5504B286526AEC6608FF983FC9 ** get_address_of_connections_0() { return &___connections_0; }
	inline void set_connections_0(Hashtable_t978F65B8006C8F5504B286526AEC6608FF983FC9 * value)
	{
		___connections_0 = value;
		Il2CppCodeGenWriteBarrier((&___connections_0), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // XMLDOWNLOADMANAGER_TF864449330C09DCF4353B7F17EA226CE28C4D752_H
#ifndef XMLNAMETABLE_T3C1CDAB4E7D97DE41A409D6D9ADD2C10B1F281A6_H
#define XMLNAMETABLE_T3C1CDAB4E7D97DE41A409D6D9ADD2C10B1F281A6_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.XmlNameTable
struct  XmlNameTable_t3C1CDAB4E7D97DE41A409D6D9ADD2C10B1F281A6  : public RuntimeObject
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // XMLNAMETABLE_T3C1CDAB4E7D97DE41A409D6D9ADD2C10B1F281A6_H
#ifndef XMLNAMESPACEMANAGER_T8323BEB96BBE8F75207DC2AAFE9430E7F473658F_H
#define XMLNAMESPACEMANAGER_T8323BEB96BBE8F75207DC2AAFE9430E7F473658F_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.XmlNamespaceManager
struct  XmlNamespaceManager_t8323BEB96BBE8F75207DC2AAFE9430E7F473658F  : public RuntimeObject
{
public:
	// System.Xml.XmlNamespaceManager_NamespaceDeclaration[] System.Xml.XmlNamespaceManager::nsdecls
	NamespaceDeclarationU5BU5D_t92995CBBEC52166860E77B72B8EEFF00E4D64E84* ___nsdecls_0;
	// System.Int32 System.Xml.XmlNamespaceManager::lastDecl
	int32_t ___lastDecl_1;
	// System.Xml.XmlNameTable System.Xml.XmlNamespaceManager::nameTable
	XmlNameTable_t3C1CDAB4E7D97DE41A409D6D9ADD2C10B1F281A6 * ___nameTable_2;
	// System.Int32 System.Xml.XmlNamespaceManager::scopeId
	int32_t ___scopeId_3;
	// System.Collections.Generic.Dictionary`2<System.String,System.Int32> System.Xml.XmlNamespaceManager::hashTable
	Dictionary_2_tD6E204872BA9FD506A0287EF68E285BEB9EC0DFB * ___hashTable_4;
	// System.Boolean System.Xml.XmlNamespaceManager::useHashtable
	bool ___useHashtable_5;
	// System.String System.Xml.XmlNamespaceManager::xml
	String_t* ___xml_6;
	// System.String System.Xml.XmlNamespaceManager::xmlNs
	String_t* ___xmlNs_7;

public:
	inline static int32_t get_offset_of_nsdecls_0() { return static_cast<int32_t>(offsetof(XmlNamespaceManager_t8323BEB96BBE8F75207DC2AAFE9430E7F473658F, ___nsdecls_0)); }
	inline NamespaceDeclarationU5BU5D_t92995CBBEC52166860E77B72B8EEFF00E4D64E84* get_nsdecls_0() const { return ___nsdecls_0; }
	inline NamespaceDeclarationU5BU5D_t92995CBBEC52166860E77B72B8EEFF00E4D64E84** get_address_of_nsdecls_0() { return &___nsdecls_0; }
	inline void set_nsdecls_0(NamespaceDeclarationU5BU5D_t92995CBBEC52166860E77B72B8EEFF00E4D64E84* value)
	{
		___nsdecls_0 = value;
		Il2CppCodeGenWriteBarrier((&___nsdecls_0), value);
	}

	inline static int32_t get_offset_of_lastDecl_1() { return static_cast<int32_t>(offsetof(XmlNamespaceManager_t8323BEB96BBE8F75207DC2AAFE9430E7F473658F, ___lastDecl_1)); }
	inline int32_t get_lastDecl_1() const { return ___lastDecl_1; }
	inline int32_t* get_address_of_lastDecl_1() { return &___lastDecl_1; }
	inline void set_lastDecl_1(int32_t value)
	{
		___lastDecl_1 = value;
	}

	inline static int32_t get_offset_of_nameTable_2() { return static_cast<int32_t>(offsetof(XmlNamespaceManager_t8323BEB96BBE8F75207DC2AAFE9430E7F473658F, ___nameTable_2)); }
	inline XmlNameTable_t3C1CDAB4E7D97DE41A409D6D9ADD2C10B1F281A6 * get_nameTable_2() const { return ___nameTable_2; }
	inline XmlNameTable_t3C1CDAB4E7D97DE41A409D6D9ADD2C10B1F281A6 ** get_address_of_nameTable_2() { return &___nameTable_2; }
	inline void set_nameTable_2(XmlNameTable_t3C1CDAB4E7D97DE41A409D6D9ADD2C10B1F281A6 * value)
	{
		___nameTable_2 = value;
		Il2CppCodeGenWriteBarrier((&___nameTable_2), value);
	}

	inline static int32_t get_offset_of_scopeId_3() { return static_cast<int32_t>(offsetof(XmlNamespaceManager_t8323BEB96BBE8F75207DC2AAFE9430E7F473658F, ___scopeId_3)); }
	inline int32_t get_scopeId_3() const { return ___scopeId_3; }
	inline int32_t* get_address_of_scopeId_3() { return &___scopeId_3; }
	inline void set_scopeId_3(int32_t value)
	{
		___scopeId_3 = value;
	}

	inline static int32_t get_offset_of_hashTable_4() { return static_cast<int32_t>(offsetof(XmlNamespaceManager_t8323BEB96BBE8F75207DC2AAFE9430E7F473658F, ___hashTable_4)); }
	inline Dictionary_2_tD6E204872BA9FD506A0287EF68E285BEB9EC0DFB * get_hashTable_4() const { return ___hashTable_4; }
	inline Dictionary_2_tD6E204872BA9FD506A0287EF68E285BEB9EC0DFB ** get_address_of_hashTable_4() { return &___hashTable_4; }
	inline void set_hashTable_4(Dictionary_2_tD6E204872BA9FD506A0287EF68E285BEB9EC0DFB * value)
	{
		___hashTable_4 = value;
		Il2CppCodeGenWriteBarrier((&___hashTable_4), value);
	}

	inline static int32_t get_offset_of_useHashtable_5() { return static_cast<int32_t>(offsetof(XmlNamespaceManager_t8323BEB96BBE8F75207DC2AAFE9430E7F473658F, ___useHashtable_5)); }
	inline bool get_useHashtable_5() const { return ___useHashtable_5; }
	inline bool* get_address_of_useHashtable_5() { return &___useHashtable_5; }
	inline void set_useHashtable_5(bool value)
	{
		___useHashtable_5 = value;
	}

	inline static int32_t get_offset_of_xml_6() { return static_cast<int32_t>(offsetof(XmlNamespaceManager_t8323BEB96BBE8F75207DC2AAFE9430E7F473658F, ___xml_6)); }
	inline String_t* get_xml_6() const { return ___xml_6; }
	inline String_t** get_address_of_xml_6() { return &___xml_6; }
	inline void set_xml_6(String_t* value)
	{
		___xml_6 = value;
		Il2CppCodeGenWriteBarrier((&___xml_6), value);
	}

	inline static int32_t get_offset_of_xmlNs_7() { return static_cast<int32_t>(offsetof(XmlNamespaceManager_t8323BEB96BBE8F75207DC2AAFE9430E7F473658F, ___xmlNs_7)); }
	inline String_t* get_xmlNs_7() const { return ___xmlNs_7; }
	inline String_t** get_address_of_xmlNs_7() { return &___xmlNs_7; }
	inline void set_xmlNs_7(String_t* value)
	{
		___xmlNs_7 = value;
		Il2CppCodeGenWriteBarrier((&___xmlNs_7), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // XMLNAMESPACEMANAGER_T8323BEB96BBE8F75207DC2AAFE9430E7F473658F_H
#ifndef XMLNODE_T07D70045D843753E4FE8AFE40FD36244E6B6D7FB_H
#define XMLNODE_T07D70045D843753E4FE8AFE40FD36244E6B6D7FB_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.XmlNode
struct  XmlNode_t07D70045D843753E4FE8AFE40FD36244E6B6D7FB  : public RuntimeObject
{
public:
	// System.Xml.XmlNode System.Xml.XmlNode::parentNode
	XmlNode_t07D70045D843753E4FE8AFE40FD36244E6B6D7FB * ___parentNode_0;

public:
	inline static int32_t get_offset_of_parentNode_0() { return static_cast<int32_t>(offsetof(XmlNode_t07D70045D843753E4FE8AFE40FD36244E6B6D7FB, ___parentNode_0)); }
	inline XmlNode_t07D70045D843753E4FE8AFE40FD36244E6B6D7FB * get_parentNode_0() const { return ___parentNode_0; }
	inline XmlNode_t07D70045D843753E4FE8AFE40FD36244E6B6D7FB ** get_address_of_parentNode_0() { return &___parentNode_0; }
	inline void set_parentNode_0(XmlNode_t07D70045D843753E4FE8AFE40FD36244E6B6D7FB * value)
	{
		___parentNode_0 = value;
		Il2CppCodeGenWriteBarrier((&___parentNode_0), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // XMLNODE_T07D70045D843753E4FE8AFE40FD36244E6B6D7FB_H
#ifndef XMLREADER_T13F08E3C651EB9F2AE882342BCD5E2CA86F29ABB_H
#define XMLREADER_T13F08E3C651EB9F2AE882342BCD5E2CA86F29ABB_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.XmlReader
struct  XmlReader_t13F08E3C651EB9F2AE882342BCD5E2CA86F29ABB  : public RuntimeObject
{
public:

public:
};

struct XmlReader_t13F08E3C651EB9F2AE882342BCD5E2CA86F29ABB_StaticFields
{
public:
	// System.UInt32 System.Xml.XmlReader::IsTextualNodeBitmap
	uint32_t ___IsTextualNodeBitmap_0;
	// System.UInt32 System.Xml.XmlReader::CanReadContentAsBitmap
	uint32_t ___CanReadContentAsBitmap_1;
	// System.UInt32 System.Xml.XmlReader::HasValueBitmap
	uint32_t ___HasValueBitmap_2;

public:
	inline static int32_t get_offset_of_IsTextualNodeBitmap_0() { return static_cast<int32_t>(offsetof(XmlReader_t13F08E3C651EB9F2AE882342BCD5E2CA86F29ABB_StaticFields, ___IsTextualNodeBitmap_0)); }
	inline uint32_t get_IsTextualNodeBitmap_0() const { return ___IsTextualNodeBitmap_0; }
	inline uint32_t* get_address_of_IsTextualNodeBitmap_0() { return &___IsTextualNodeBitmap_0; }
	inline void set_IsTextualNodeBitmap_0(uint32_t value)
	{
		___IsTextualNodeBitmap_0 = value;
	}

	inline static int32_t get_offset_of_CanReadContentAsBitmap_1() { return static_cast<int32_t>(offsetof(XmlReader_t13F08E3C651EB9F2AE882342BCD5E2CA86F29ABB_StaticFields, ___CanReadContentAsBitmap_1)); }
	inline uint32_t get_CanReadContentAsBitmap_1() const { return ___CanReadContentAsBitmap_1; }
	inline uint32_t* get_address_of_CanReadContentAsBitmap_1() { return &___CanReadContentAsBitmap_1; }
	inline void set_CanReadContentAsBitmap_1(uint32_t value)
	{
		___CanReadContentAsBitmap_1 = value;
	}

	inline static int32_t get_offset_of_HasValueBitmap_2() { return static_cast<int32_t>(offsetof(XmlReader_t13F08E3C651EB9F2AE882342BCD5E2CA86F29ABB_StaticFields, ___HasValueBitmap_2)); }
	inline uint32_t get_HasValueBitmap_2() const { return ___HasValueBitmap_2; }
	inline uint32_t* get_address_of_HasValueBitmap_2() { return &___HasValueBitmap_2; }
	inline void set_HasValueBitmap_2(uint32_t value)
	{
		___HasValueBitmap_2 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // XMLREADER_T13F08E3C651EB9F2AE882342BCD5E2CA86F29ABB_H
#ifndef XMLRESOLVER_T93269F14B2F8750D040AED2FB7A303CE85016280_H
#define XMLRESOLVER_T93269F14B2F8750D040AED2FB7A303CE85016280_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.XmlResolver
struct  XmlResolver_t93269F14B2F8750D040AED2FB7A303CE85016280  : public RuntimeObject
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // XMLRESOLVER_T93269F14B2F8750D040AED2FB7A303CE85016280_H
#ifndef DTDDEFAULTATTRIBUTEINFOTONODEDATACOMPARER_T0B9FEF7A80832980C3E32D47BE835964E8B423B7_H
#define DTDDEFAULTATTRIBUTEINFOTONODEDATACOMPARER_T0B9FEF7A80832980C3E32D47BE835964E8B423B7_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.XmlTextReaderImpl_DtdDefaultAttributeInfoToNodeDataComparer
struct  DtdDefaultAttributeInfoToNodeDataComparer_t0B9FEF7A80832980C3E32D47BE835964E8B423B7  : public RuntimeObject
{
public:

public:
};

struct DtdDefaultAttributeInfoToNodeDataComparer_t0B9FEF7A80832980C3E32D47BE835964E8B423B7_StaticFields
{
public:
	// System.Collections.Generic.IComparer`1<System.Object> System.Xml.XmlTextReaderImpl_DtdDefaultAttributeInfoToNodeDataComparer::s_instance
	RuntimeObject* ___s_instance_0;

public:
	inline static int32_t get_offset_of_s_instance_0() { return static_cast<int32_t>(offsetof(DtdDefaultAttributeInfoToNodeDataComparer_t0B9FEF7A80832980C3E32D47BE835964E8B423B7_StaticFields, ___s_instance_0)); }
	inline RuntimeObject* get_s_instance_0() const { return ___s_instance_0; }
	inline RuntimeObject** get_address_of_s_instance_0() { return &___s_instance_0; }
	inline void set_s_instance_0(RuntimeObject* value)
	{
		___s_instance_0 = value;
		Il2CppCodeGenWriteBarrier((&___s_instance_0), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // DTDDEFAULTATTRIBUTEINFOTONODEDATACOMPARER_T0B9FEF7A80832980C3E32D47BE835964E8B423B7_H
#ifndef DTDPARSERPROXY_TF94C8FBE3EC41EF7C960BEDC0CD3DD25090265B7_H
#define DTDPARSERPROXY_TF94C8FBE3EC41EF7C960BEDC0CD3DD25090265B7_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.XmlTextReaderImpl_DtdParserProxy
struct  DtdParserProxy_tF94C8FBE3EC41EF7C960BEDC0CD3DD25090265B7  : public RuntimeObject
{
public:
	// System.Xml.XmlTextReaderImpl System.Xml.XmlTextReaderImpl_DtdParserProxy::reader
	XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * ___reader_0;

public:
	inline static int32_t get_offset_of_reader_0() { return static_cast<int32_t>(offsetof(DtdParserProxy_tF94C8FBE3EC41EF7C960BEDC0CD3DD25090265B7, ___reader_0)); }
	inline XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * get_reader_0() const { return ___reader_0; }
	inline XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 ** get_address_of_reader_0() { return &___reader_0; }
	inline void set_reader_0(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * value)
	{
		___reader_0 = value;
		Il2CppCodeGenWriteBarrier((&___reader_0), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // DTDPARSERPROXY_TF94C8FBE3EC41EF7C960BEDC0CD3DD25090265B7_H
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
#ifndef BYTE_TF87C579059BD4633E6840EBBBEEF899C6E33EF07_H
#define BYTE_TF87C579059BD4633E6840EBBBEEF899C6E33EF07_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Byte
struct  Byte_tF87C579059BD4633E6840EBBBEEF899C6E33EF07 
{
public:
	// System.Byte System.Byte::m_value
	uint8_t ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(Byte_tF87C579059BD4633E6840EBBBEEF899C6E33EF07, ___m_value_0)); }
	inline uint8_t get_m_value_0() const { return ___m_value_0; }
	inline uint8_t* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(uint8_t value)
	{
		___m_value_0 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // BYTE_TF87C579059BD4633E6840EBBBEEF899C6E33EF07_H
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
#ifndef STREAM_TFC50657DD5AAB87770987F9179D934A51D99D5E7_H
#define STREAM_TFC50657DD5AAB87770987F9179D934A51D99D5E7_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.IO.Stream
struct  Stream_tFC50657DD5AAB87770987F9179D934A51D99D5E7  : public MarshalByRefObject_tC4577953D0A44D0AB8597CFA868E01C858B1C9AF
{
public:
	// System.IO.Stream_ReadWriteTask System.IO.Stream::_activeReadWriteTask
	ReadWriteTask_tFA17EEE8BC5C4C83EAEFCC3662A30DE351ABAA80 * ____activeReadWriteTask_2;
	// System.Threading.SemaphoreSlim System.IO.Stream::_asyncActiveSemaphore
	SemaphoreSlim_t2E2888D1C0C8FAB80823C76F1602E4434B8FA048 * ____asyncActiveSemaphore_3;

public:
	inline static int32_t get_offset_of__activeReadWriteTask_2() { return static_cast<int32_t>(offsetof(Stream_tFC50657DD5AAB87770987F9179D934A51D99D5E7, ____activeReadWriteTask_2)); }
	inline ReadWriteTask_tFA17EEE8BC5C4C83EAEFCC3662A30DE351ABAA80 * get__activeReadWriteTask_2() const { return ____activeReadWriteTask_2; }
	inline ReadWriteTask_tFA17EEE8BC5C4C83EAEFCC3662A30DE351ABAA80 ** get_address_of__activeReadWriteTask_2() { return &____activeReadWriteTask_2; }
	inline void set__activeReadWriteTask_2(ReadWriteTask_tFA17EEE8BC5C4C83EAEFCC3662A30DE351ABAA80 * value)
	{
		____activeReadWriteTask_2 = value;
		Il2CppCodeGenWriteBarrier((&____activeReadWriteTask_2), value);
	}

	inline static int32_t get_offset_of__asyncActiveSemaphore_3() { return static_cast<int32_t>(offsetof(Stream_tFC50657DD5AAB87770987F9179D934A51D99D5E7, ____asyncActiveSemaphore_3)); }
	inline SemaphoreSlim_t2E2888D1C0C8FAB80823C76F1602E4434B8FA048 * get__asyncActiveSemaphore_3() const { return ____asyncActiveSemaphore_3; }
	inline SemaphoreSlim_t2E2888D1C0C8FAB80823C76F1602E4434B8FA048 ** get_address_of__asyncActiveSemaphore_3() { return &____asyncActiveSemaphore_3; }
	inline void set__asyncActiveSemaphore_3(SemaphoreSlim_t2E2888D1C0C8FAB80823C76F1602E4434B8FA048 * value)
	{
		____asyncActiveSemaphore_3 = value;
		Il2CppCodeGenWriteBarrier((&____asyncActiveSemaphore_3), value);
	}
};

struct Stream_tFC50657DD5AAB87770987F9179D934A51D99D5E7_StaticFields
{
public:
	// System.IO.Stream System.IO.Stream::Null
	Stream_tFC50657DD5AAB87770987F9179D934A51D99D5E7 * ___Null_1;

public:
	inline static int32_t get_offset_of_Null_1() { return static_cast<int32_t>(offsetof(Stream_tFC50657DD5AAB87770987F9179D934A51D99D5E7_StaticFields, ___Null_1)); }
	inline Stream_tFC50657DD5AAB87770987F9179D934A51D99D5E7 * get_Null_1() const { return ___Null_1; }
	inline Stream_tFC50657DD5AAB87770987F9179D934A51D99D5E7 ** get_address_of_Null_1() { return &___Null_1; }
	inline void set_Null_1(Stream_tFC50657DD5AAB87770987F9179D934A51D99D5E7 * value)
	{
		___Null_1 = value;
		Il2CppCodeGenWriteBarrier((&___Null_1), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // STREAM_TFC50657DD5AAB87770987F9179D934A51D99D5E7_H
#ifndef TEXTREADER_T7DF8314B601D202ECFEDF623093A87BFDAB58D0A_H
#define TEXTREADER_T7DF8314B601D202ECFEDF623093A87BFDAB58D0A_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.IO.TextReader
struct  TextReader_t7DF8314B601D202ECFEDF623093A87BFDAB58D0A  : public MarshalByRefObject_tC4577953D0A44D0AB8597CFA868E01C858B1C9AF
{
public:

public:
};

struct TextReader_t7DF8314B601D202ECFEDF623093A87BFDAB58D0A_StaticFields
{
public:
	// System.Func`2<System.Object,System.String> System.IO.TextReader::_ReadLineDelegate
	Func_2_t44B347E67E515867D995E8BD5EFD67FA88CE53CF * ____ReadLineDelegate_1;
	// System.Func`2<System.Object,System.Int32> System.IO.TextReader::_ReadDelegate
	Func_2_t8B2DA3FB30280CE3D92F50E9CCAACEE4828789A6 * ____ReadDelegate_2;
	// System.IO.TextReader System.IO.TextReader::Null
	TextReader_t7DF8314B601D202ECFEDF623093A87BFDAB58D0A * ___Null_3;

public:
	inline static int32_t get_offset_of__ReadLineDelegate_1() { return static_cast<int32_t>(offsetof(TextReader_t7DF8314B601D202ECFEDF623093A87BFDAB58D0A_StaticFields, ____ReadLineDelegate_1)); }
	inline Func_2_t44B347E67E515867D995E8BD5EFD67FA88CE53CF * get__ReadLineDelegate_1() const { return ____ReadLineDelegate_1; }
	inline Func_2_t44B347E67E515867D995E8BD5EFD67FA88CE53CF ** get_address_of__ReadLineDelegate_1() { return &____ReadLineDelegate_1; }
	inline void set__ReadLineDelegate_1(Func_2_t44B347E67E515867D995E8BD5EFD67FA88CE53CF * value)
	{
		____ReadLineDelegate_1 = value;
		Il2CppCodeGenWriteBarrier((&____ReadLineDelegate_1), value);
	}

	inline static int32_t get_offset_of__ReadDelegate_2() { return static_cast<int32_t>(offsetof(TextReader_t7DF8314B601D202ECFEDF623093A87BFDAB58D0A_StaticFields, ____ReadDelegate_2)); }
	inline Func_2_t8B2DA3FB30280CE3D92F50E9CCAACEE4828789A6 * get__ReadDelegate_2() const { return ____ReadDelegate_2; }
	inline Func_2_t8B2DA3FB30280CE3D92F50E9CCAACEE4828789A6 ** get_address_of__ReadDelegate_2() { return &____ReadDelegate_2; }
	inline void set__ReadDelegate_2(Func_2_t8B2DA3FB30280CE3D92F50E9CCAACEE4828789A6 * value)
	{
		____ReadDelegate_2 = value;
		Il2CppCodeGenWriteBarrier((&____ReadDelegate_2), value);
	}

	inline static int32_t get_offset_of_Null_3() { return static_cast<int32_t>(offsetof(TextReader_t7DF8314B601D202ECFEDF623093A87BFDAB58D0A_StaticFields, ___Null_3)); }
	inline TextReader_t7DF8314B601D202ECFEDF623093A87BFDAB58D0A * get_Null_3() const { return ___Null_3; }
	inline TextReader_t7DF8314B601D202ECFEDF623093A87BFDAB58D0A ** get_address_of_Null_3() { return &___Null_3; }
	inline void set_Null_3(TextReader_t7DF8314B601D202ECFEDF623093A87BFDAB58D0A * value)
	{
		___Null_3 = value;
		Il2CppCodeGenWriteBarrier((&___Null_3), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // TEXTREADER_T7DF8314B601D202ECFEDF623093A87BFDAB58D0A_H
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
#ifndef ASYNCMETHODBUILDERCORE_T4CE6C1E4B0621A6EC45CF6E0E8F1F633FFF9FF01_H
#define ASYNCMETHODBUILDERCORE_T4CE6C1E4B0621A6EC45CF6E0E8F1F633FFF9FF01_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Runtime.CompilerServices.AsyncMethodBuilderCore
struct  AsyncMethodBuilderCore_t4CE6C1E4B0621A6EC45CF6E0E8F1F633FFF9FF01 
{
public:
	// System.Runtime.CompilerServices.IAsyncStateMachine System.Runtime.CompilerServices.AsyncMethodBuilderCore::m_stateMachine
	RuntimeObject* ___m_stateMachine_0;
	// System.Action System.Runtime.CompilerServices.AsyncMethodBuilderCore::m_defaultContextAction
	Action_t591D2A86165F896B4B800BB5C25CE18672A55579 * ___m_defaultContextAction_1;

public:
	inline static int32_t get_offset_of_m_stateMachine_0() { return static_cast<int32_t>(offsetof(AsyncMethodBuilderCore_t4CE6C1E4B0621A6EC45CF6E0E8F1F633FFF9FF01, ___m_stateMachine_0)); }
	inline RuntimeObject* get_m_stateMachine_0() const { return ___m_stateMachine_0; }
	inline RuntimeObject** get_address_of_m_stateMachine_0() { return &___m_stateMachine_0; }
	inline void set_m_stateMachine_0(RuntimeObject* value)
	{
		___m_stateMachine_0 = value;
		Il2CppCodeGenWriteBarrier((&___m_stateMachine_0), value);
	}

	inline static int32_t get_offset_of_m_defaultContextAction_1() { return static_cast<int32_t>(offsetof(AsyncMethodBuilderCore_t4CE6C1E4B0621A6EC45CF6E0E8F1F633FFF9FF01, ___m_defaultContextAction_1)); }
	inline Action_t591D2A86165F896B4B800BB5C25CE18672A55579 * get_m_defaultContextAction_1() const { return ___m_defaultContextAction_1; }
	inline Action_t591D2A86165F896B4B800BB5C25CE18672A55579 ** get_address_of_m_defaultContextAction_1() { return &___m_defaultContextAction_1; }
	inline void set_m_defaultContextAction_1(Action_t591D2A86165F896B4B800BB5C25CE18672A55579 * value)
	{
		___m_defaultContextAction_1 = value;
		Il2CppCodeGenWriteBarrier((&___m_defaultContextAction_1), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// Native definition for P/Invoke marshalling of System.Runtime.CompilerServices.AsyncMethodBuilderCore
struct AsyncMethodBuilderCore_t4CE6C1E4B0621A6EC45CF6E0E8F1F633FFF9FF01_marshaled_pinvoke
{
	RuntimeObject* ___m_stateMachine_0;
	Il2CppMethodPointer ___m_defaultContextAction_1;
};
// Native definition for COM marshalling of System.Runtime.CompilerServices.AsyncMethodBuilderCore
struct AsyncMethodBuilderCore_t4CE6C1E4B0621A6EC45CF6E0E8F1F633FFF9FF01_marshaled_com
{
	RuntimeObject* ___m_stateMachine_0;
	Il2CppMethodPointer ___m_defaultContextAction_1;
};
#endif // ASYNCMETHODBUILDERCORE_T4CE6C1E4B0621A6EC45CF6E0E8F1F633FFF9FF01_H
#ifndef CONFIGUREDTASKAWAITER_T27ECAA4B74502BD3AC7E68F47088D46DAA13D133_H
#define CONFIGUREDTASKAWAITER_T27ECAA4B74502BD3AC7E68F47088D46DAA13D133_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1_ConfiguredTaskAwaiter<System.IO.Stream>
struct  ConfiguredTaskAwaiter_t27ECAA4B74502BD3AC7E68F47088D46DAA13D133 
{
public:
	// System.Threading.Tasks.Task`1<TResult> System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1_ConfiguredTaskAwaiter::m_task
	Task_1_tAA7557E5A6A8B2C89E44907CB5B0502A618E9D01 * ___m_task_0;
	// System.Boolean System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1_ConfiguredTaskAwaiter::m_continueOnCapturedContext
	bool ___m_continueOnCapturedContext_1;

public:
	inline static int32_t get_offset_of_m_task_0() { return static_cast<int32_t>(offsetof(ConfiguredTaskAwaiter_t27ECAA4B74502BD3AC7E68F47088D46DAA13D133, ___m_task_0)); }
	inline Task_1_tAA7557E5A6A8B2C89E44907CB5B0502A618E9D01 * get_m_task_0() const { return ___m_task_0; }
	inline Task_1_tAA7557E5A6A8B2C89E44907CB5B0502A618E9D01 ** get_address_of_m_task_0() { return &___m_task_0; }
	inline void set_m_task_0(Task_1_tAA7557E5A6A8B2C89E44907CB5B0502A618E9D01 * value)
	{
		___m_task_0 = value;
		Il2CppCodeGenWriteBarrier((&___m_task_0), value);
	}

	inline static int32_t get_offset_of_m_continueOnCapturedContext_1() { return static_cast<int32_t>(offsetof(ConfiguredTaskAwaiter_t27ECAA4B74502BD3AC7E68F47088D46DAA13D133, ___m_continueOnCapturedContext_1)); }
	inline bool get_m_continueOnCapturedContext_1() const { return ___m_continueOnCapturedContext_1; }
	inline bool* get_address_of_m_continueOnCapturedContext_1() { return &___m_continueOnCapturedContext_1; }
	inline void set_m_continueOnCapturedContext_1(bool value)
	{
		___m_continueOnCapturedContext_1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // CONFIGUREDTASKAWAITER_T27ECAA4B74502BD3AC7E68F47088D46DAA13D133_H
#ifndef CONFIGUREDTASKAWAITER_TFB3C4197768C6CF02BE088F703AA6E46D703D46E_H
#define CONFIGUREDTASKAWAITER_TFB3C4197768C6CF02BE088F703AA6E46D703D46E_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1_ConfiguredTaskAwaiter<System.Object>
struct  ConfiguredTaskAwaiter_tFB3C4197768C6CF02BE088F703AA6E46D703D46E 
{
public:
	// System.Threading.Tasks.Task`1<TResult> System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1_ConfiguredTaskAwaiter::m_task
	Task_1_tA56001ED5270173CA1432EDFCD84EABB1024BC09 * ___m_task_0;
	// System.Boolean System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1_ConfiguredTaskAwaiter::m_continueOnCapturedContext
	bool ___m_continueOnCapturedContext_1;

public:
	inline static int32_t get_offset_of_m_task_0() { return static_cast<int32_t>(offsetof(ConfiguredTaskAwaiter_tFB3C4197768C6CF02BE088F703AA6E46D703D46E, ___m_task_0)); }
	inline Task_1_tA56001ED5270173CA1432EDFCD84EABB1024BC09 * get_m_task_0() const { return ___m_task_0; }
	inline Task_1_tA56001ED5270173CA1432EDFCD84EABB1024BC09 ** get_address_of_m_task_0() { return &___m_task_0; }
	inline void set_m_task_0(Task_1_tA56001ED5270173CA1432EDFCD84EABB1024BC09 * value)
	{
		___m_task_0 = value;
		Il2CppCodeGenWriteBarrier((&___m_task_0), value);
	}

	inline static int32_t get_offset_of_m_continueOnCapturedContext_1() { return static_cast<int32_t>(offsetof(ConfiguredTaskAwaiter_tFB3C4197768C6CF02BE088F703AA6E46D703D46E, ___m_continueOnCapturedContext_1)); }
	inline bool get_m_continueOnCapturedContext_1() const { return ___m_continueOnCapturedContext_1; }
	inline bool* get_address_of_m_continueOnCapturedContext_1() { return &___m_continueOnCapturedContext_1; }
	inline void set_m_continueOnCapturedContext_1(bool value)
	{
		___m_continueOnCapturedContext_1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // CONFIGUREDTASKAWAITER_TFB3C4197768C6CF02BE088F703AA6E46D703D46E_H
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
#ifndef LINEINFO_T7E3D50496C7BA51B84D485D0A30B9006943544E5_H
#define LINEINFO_T7E3D50496C7BA51B84D485D0A30B9006943544E5_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.LineInfo
struct  LineInfo_t7E3D50496C7BA51B84D485D0A30B9006943544E5 
{
public:
	// System.Int32 System.Xml.LineInfo::lineNo
	int32_t ___lineNo_0;
	// System.Int32 System.Xml.LineInfo::linePos
	int32_t ___linePos_1;

public:
	inline static int32_t get_offset_of_lineNo_0() { return static_cast<int32_t>(offsetof(LineInfo_t7E3D50496C7BA51B84D485D0A30B9006943544E5, ___lineNo_0)); }
	inline int32_t get_lineNo_0() const { return ___lineNo_0; }
	inline int32_t* get_address_of_lineNo_0() { return &___lineNo_0; }
	inline void set_lineNo_0(int32_t value)
	{
		___lineNo_0 = value;
	}

	inline static int32_t get_offset_of_linePos_1() { return static_cast<int32_t>(offsetof(LineInfo_t7E3D50496C7BA51B84D485D0A30B9006943544E5, ___linePos_1)); }
	inline int32_t get_linePos_1() const { return ___linePos_1; }
	inline int32_t* get_address_of_linePos_1() { return &___linePos_1; }
	inline void set_linePos_1(int32_t value)
	{
		___linePos_1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // LINEINFO_T7E3D50496C7BA51B84D485D0A30B9006943544E5_H
#ifndef XMLATTRIBUTE_TEAB5F066D1D6965D6528617BD89826AE7114DEFA_H
#define XMLATTRIBUTE_TEAB5F066D1D6965D6528617BD89826AE7114DEFA_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.XmlAttribute
struct  XmlAttribute_tEAB5F066D1D6965D6528617BD89826AE7114DEFA  : public XmlNode_t07D70045D843753E4FE8AFE40FD36244E6B6D7FB
{
public:
	// System.Xml.XmlName System.Xml.XmlAttribute::name
	XmlName_t993BD9C827C8B0B6A0B7C49A03F2D14740AC2682 * ___name_1;
	// System.Xml.XmlLinkedNode System.Xml.XmlAttribute::lastChild
	XmlLinkedNode_t4F76C8580C2E6D2908D88AC84A86060FA9289A0E * ___lastChild_2;

public:
	inline static int32_t get_offset_of_name_1() { return static_cast<int32_t>(offsetof(XmlAttribute_tEAB5F066D1D6965D6528617BD89826AE7114DEFA, ___name_1)); }
	inline XmlName_t993BD9C827C8B0B6A0B7C49A03F2D14740AC2682 * get_name_1() const { return ___name_1; }
	inline XmlName_t993BD9C827C8B0B6A0B7C49A03F2D14740AC2682 ** get_address_of_name_1() { return &___name_1; }
	inline void set_name_1(XmlName_t993BD9C827C8B0B6A0B7C49A03F2D14740AC2682 * value)
	{
		___name_1 = value;
		Il2CppCodeGenWriteBarrier((&___name_1), value);
	}

	inline static int32_t get_offset_of_lastChild_2() { return static_cast<int32_t>(offsetof(XmlAttribute_tEAB5F066D1D6965D6528617BD89826AE7114DEFA, ___lastChild_2)); }
	inline XmlLinkedNode_t4F76C8580C2E6D2908D88AC84A86060FA9289A0E * get_lastChild_2() const { return ___lastChild_2; }
	inline XmlLinkedNode_t4F76C8580C2E6D2908D88AC84A86060FA9289A0E ** get_address_of_lastChild_2() { return &___lastChild_2; }
	inline void set_lastChild_2(XmlLinkedNode_t4F76C8580C2E6D2908D88AC84A86060FA9289A0E * value)
	{
		___lastChild_2 = value;
		Il2CppCodeGenWriteBarrier((&___lastChild_2), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // XMLATTRIBUTE_TEAB5F066D1D6965D6528617BD89826AE7114DEFA_H
#ifndef XMLCHARTYPE_T7F6CCEEB0A0BC8FC40F161B8928A766BE7B234E9_H
#define XMLCHARTYPE_T7F6CCEEB0A0BC8FC40F161B8928A766BE7B234E9_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.XmlCharType
struct  XmlCharType_t7F6CCEEB0A0BC8FC40F161B8928A766BE7B234E9 
{
public:
	// System.Byte[] System.Xml.XmlCharType::charProperties
	ByteU5BU5D_tD06FDBE8142446525DF1C40351D523A228373821* ___charProperties_2;

public:
	inline static int32_t get_offset_of_charProperties_2() { return static_cast<int32_t>(offsetof(XmlCharType_t7F6CCEEB0A0BC8FC40F161B8928A766BE7B234E9, ___charProperties_2)); }
	inline ByteU5BU5D_tD06FDBE8142446525DF1C40351D523A228373821* get_charProperties_2() const { return ___charProperties_2; }
	inline ByteU5BU5D_tD06FDBE8142446525DF1C40351D523A228373821** get_address_of_charProperties_2() { return &___charProperties_2; }
	inline void set_charProperties_2(ByteU5BU5D_tD06FDBE8142446525DF1C40351D523A228373821* value)
	{
		___charProperties_2 = value;
		Il2CppCodeGenWriteBarrier((&___charProperties_2), value);
	}
};

struct XmlCharType_t7F6CCEEB0A0BC8FC40F161B8928A766BE7B234E9_StaticFields
{
public:
	// System.Object System.Xml.XmlCharType::s_Lock
	RuntimeObject * ___s_Lock_0;
	// System.Byte[] modreq(System.Runtime.CompilerServices.IsVolatile) System.Xml.XmlCharType::s_CharProperties
	ByteU5BU5D_tD06FDBE8142446525DF1C40351D523A228373821* ___s_CharProperties_1;

public:
	inline static int32_t get_offset_of_s_Lock_0() { return static_cast<int32_t>(offsetof(XmlCharType_t7F6CCEEB0A0BC8FC40F161B8928A766BE7B234E9_StaticFields, ___s_Lock_0)); }
	inline RuntimeObject * get_s_Lock_0() const { return ___s_Lock_0; }
	inline RuntimeObject ** get_address_of_s_Lock_0() { return &___s_Lock_0; }
	inline void set_s_Lock_0(RuntimeObject * value)
	{
		___s_Lock_0 = value;
		Il2CppCodeGenWriteBarrier((&___s_Lock_0), value);
	}

	inline static int32_t get_offset_of_s_CharProperties_1() { return static_cast<int32_t>(offsetof(XmlCharType_t7F6CCEEB0A0BC8FC40F161B8928A766BE7B234E9_StaticFields, ___s_CharProperties_1)); }
	inline ByteU5BU5D_tD06FDBE8142446525DF1C40351D523A228373821* get_s_CharProperties_1() const { return ___s_CharProperties_1; }
	inline ByteU5BU5D_tD06FDBE8142446525DF1C40351D523A228373821** get_address_of_s_CharProperties_1() { return &___s_CharProperties_1; }
	inline void set_s_CharProperties_1(ByteU5BU5D_tD06FDBE8142446525DF1C40351D523A228373821* value)
	{
		___s_CharProperties_1 = value;
		Il2CppCodeGenWriteBarrier((&___s_CharProperties_1), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // XMLCHARTYPE_T7F6CCEEB0A0BC8FC40F161B8928A766BE7B234E9_H
#ifndef XMLDOCUMENT_T448325D04430147AF19F2955BD6A5F1551003C97_H
#define XMLDOCUMENT_T448325D04430147AF19F2955BD6A5F1551003C97_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.XmlDocument
struct  XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97  : public XmlNode_t07D70045D843753E4FE8AFE40FD36244E6B6D7FB
{
public:
	// System.Xml.XmlImplementation System.Xml.XmlDocument::implementation
	XmlImplementation_t7C01D70C3943C7AA929C106D360E90E2D576E1EF * ___implementation_1;
	// System.Xml.DomNameTable System.Xml.XmlDocument::domNameTable
	DomNameTable_t09CF0ACAE0D0EA06D0D6892AE0E7D17C7F931C9A * ___domNameTable_2;
	// System.Xml.XmlLinkedNode System.Xml.XmlDocument::lastChild
	XmlLinkedNode_t4F76C8580C2E6D2908D88AC84A86060FA9289A0E * ___lastChild_3;
	// System.Xml.XmlNamedNodeMap System.Xml.XmlDocument::entities
	XmlNamedNodeMap_t260246787BA7B6747AB878378D22EC7693465E31 * ___entities_4;
	// System.Collections.Hashtable System.Xml.XmlDocument::htElementIdMap
	Hashtable_t978F65B8006C8F5504B286526AEC6608FF983FC9 * ___htElementIdMap_5;
	// System.Collections.Hashtable System.Xml.XmlDocument::htElementIDAttrDecl
	Hashtable_t978F65B8006C8F5504B286526AEC6608FF983FC9 * ___htElementIDAttrDecl_6;
	// System.Xml.Schema.SchemaInfo System.Xml.XmlDocument::schemaInfo
	SchemaInfo_tD9774489795A78B9235BAD315E5242C974183A41 * ___schemaInfo_7;
	// System.Xml.Schema.XmlSchemaSet System.Xml.XmlDocument::schemas
	XmlSchemaSet_tD92B4BF5F65FBF5B106399A36284FDC64E602F7F * ___schemas_8;
	// System.Boolean System.Xml.XmlDocument::reportValidity
	bool ___reportValidity_9;
	// System.Boolean System.Xml.XmlDocument::actualLoadingStatus
	bool ___actualLoadingStatus_10;
	// System.Xml.XmlNodeChangedEventHandler System.Xml.XmlDocument::onNodeInsertingDelegate
	XmlNodeChangedEventHandler_t730DECDAE07BB728186F47DDF2A569F50A889838 * ___onNodeInsertingDelegate_11;
	// System.Xml.XmlNodeChangedEventHandler System.Xml.XmlDocument::onNodeInsertedDelegate
	XmlNodeChangedEventHandler_t730DECDAE07BB728186F47DDF2A569F50A889838 * ___onNodeInsertedDelegate_12;
	// System.Xml.XmlNodeChangedEventHandler System.Xml.XmlDocument::onNodeRemovingDelegate
	XmlNodeChangedEventHandler_t730DECDAE07BB728186F47DDF2A569F50A889838 * ___onNodeRemovingDelegate_13;
	// System.Xml.XmlNodeChangedEventHandler System.Xml.XmlDocument::onNodeRemovedDelegate
	XmlNodeChangedEventHandler_t730DECDAE07BB728186F47DDF2A569F50A889838 * ___onNodeRemovedDelegate_14;
	// System.Xml.XmlNodeChangedEventHandler System.Xml.XmlDocument::onNodeChangingDelegate
	XmlNodeChangedEventHandler_t730DECDAE07BB728186F47DDF2A569F50A889838 * ___onNodeChangingDelegate_15;
	// System.Xml.XmlNodeChangedEventHandler System.Xml.XmlDocument::onNodeChangedDelegate
	XmlNodeChangedEventHandler_t730DECDAE07BB728186F47DDF2A569F50A889838 * ___onNodeChangedDelegate_16;
	// System.Boolean System.Xml.XmlDocument::fEntRefNodesPresent
	bool ___fEntRefNodesPresent_17;
	// System.Boolean System.Xml.XmlDocument::fCDataNodesPresent
	bool ___fCDataNodesPresent_18;
	// System.Boolean System.Xml.XmlDocument::preserveWhitespace
	bool ___preserveWhitespace_19;
	// System.Boolean System.Xml.XmlDocument::isLoading
	bool ___isLoading_20;
	// System.String System.Xml.XmlDocument::strDocumentName
	String_t* ___strDocumentName_21;
	// System.String System.Xml.XmlDocument::strDocumentFragmentName
	String_t* ___strDocumentFragmentName_22;
	// System.String System.Xml.XmlDocument::strCommentName
	String_t* ___strCommentName_23;
	// System.String System.Xml.XmlDocument::strTextName
	String_t* ___strTextName_24;
	// System.String System.Xml.XmlDocument::strCDataSectionName
	String_t* ___strCDataSectionName_25;
	// System.String System.Xml.XmlDocument::strEntityName
	String_t* ___strEntityName_26;
	// System.String System.Xml.XmlDocument::strID
	String_t* ___strID_27;
	// System.String System.Xml.XmlDocument::strXmlns
	String_t* ___strXmlns_28;
	// System.String System.Xml.XmlDocument::strXml
	String_t* ___strXml_29;
	// System.String System.Xml.XmlDocument::strSpace
	String_t* ___strSpace_30;
	// System.String System.Xml.XmlDocument::strLang
	String_t* ___strLang_31;
	// System.String System.Xml.XmlDocument::strEmpty
	String_t* ___strEmpty_32;
	// System.String System.Xml.XmlDocument::strNonSignificantWhitespaceName
	String_t* ___strNonSignificantWhitespaceName_33;
	// System.String System.Xml.XmlDocument::strSignificantWhitespaceName
	String_t* ___strSignificantWhitespaceName_34;
	// System.String System.Xml.XmlDocument::strReservedXmlns
	String_t* ___strReservedXmlns_35;
	// System.String System.Xml.XmlDocument::strReservedXml
	String_t* ___strReservedXml_36;
	// System.String System.Xml.XmlDocument::baseURI
	String_t* ___baseURI_37;
	// System.Xml.XmlResolver System.Xml.XmlDocument::resolver
	XmlResolver_t93269F14B2F8750D040AED2FB7A303CE85016280 * ___resolver_38;
	// System.Boolean System.Xml.XmlDocument::bSetResolver
	bool ___bSetResolver_39;
	// System.Object System.Xml.XmlDocument::objLock
	RuntimeObject * ___objLock_40;

public:
	inline static int32_t get_offset_of_implementation_1() { return static_cast<int32_t>(offsetof(XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97, ___implementation_1)); }
	inline XmlImplementation_t7C01D70C3943C7AA929C106D360E90E2D576E1EF * get_implementation_1() const { return ___implementation_1; }
	inline XmlImplementation_t7C01D70C3943C7AA929C106D360E90E2D576E1EF ** get_address_of_implementation_1() { return &___implementation_1; }
	inline void set_implementation_1(XmlImplementation_t7C01D70C3943C7AA929C106D360E90E2D576E1EF * value)
	{
		___implementation_1 = value;
		Il2CppCodeGenWriteBarrier((&___implementation_1), value);
	}

	inline static int32_t get_offset_of_domNameTable_2() { return static_cast<int32_t>(offsetof(XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97, ___domNameTable_2)); }
	inline DomNameTable_t09CF0ACAE0D0EA06D0D6892AE0E7D17C7F931C9A * get_domNameTable_2() const { return ___domNameTable_2; }
	inline DomNameTable_t09CF0ACAE0D0EA06D0D6892AE0E7D17C7F931C9A ** get_address_of_domNameTable_2() { return &___domNameTable_2; }
	inline void set_domNameTable_2(DomNameTable_t09CF0ACAE0D0EA06D0D6892AE0E7D17C7F931C9A * value)
	{
		___domNameTable_2 = value;
		Il2CppCodeGenWriteBarrier((&___domNameTable_2), value);
	}

	inline static int32_t get_offset_of_lastChild_3() { return static_cast<int32_t>(offsetof(XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97, ___lastChild_3)); }
	inline XmlLinkedNode_t4F76C8580C2E6D2908D88AC84A86060FA9289A0E * get_lastChild_3() const { return ___lastChild_3; }
	inline XmlLinkedNode_t4F76C8580C2E6D2908D88AC84A86060FA9289A0E ** get_address_of_lastChild_3() { return &___lastChild_3; }
	inline void set_lastChild_3(XmlLinkedNode_t4F76C8580C2E6D2908D88AC84A86060FA9289A0E * value)
	{
		___lastChild_3 = value;
		Il2CppCodeGenWriteBarrier((&___lastChild_3), value);
	}

	inline static int32_t get_offset_of_entities_4() { return static_cast<int32_t>(offsetof(XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97, ___entities_4)); }
	inline XmlNamedNodeMap_t260246787BA7B6747AB878378D22EC7693465E31 * get_entities_4() const { return ___entities_4; }
	inline XmlNamedNodeMap_t260246787BA7B6747AB878378D22EC7693465E31 ** get_address_of_entities_4() { return &___entities_4; }
	inline void set_entities_4(XmlNamedNodeMap_t260246787BA7B6747AB878378D22EC7693465E31 * value)
	{
		___entities_4 = value;
		Il2CppCodeGenWriteBarrier((&___entities_4), value);
	}

	inline static int32_t get_offset_of_htElementIdMap_5() { return static_cast<int32_t>(offsetof(XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97, ___htElementIdMap_5)); }
	inline Hashtable_t978F65B8006C8F5504B286526AEC6608FF983FC9 * get_htElementIdMap_5() const { return ___htElementIdMap_5; }
	inline Hashtable_t978F65B8006C8F5504B286526AEC6608FF983FC9 ** get_address_of_htElementIdMap_5() { return &___htElementIdMap_5; }
	inline void set_htElementIdMap_5(Hashtable_t978F65B8006C8F5504B286526AEC6608FF983FC9 * value)
	{
		___htElementIdMap_5 = value;
		Il2CppCodeGenWriteBarrier((&___htElementIdMap_5), value);
	}

	inline static int32_t get_offset_of_htElementIDAttrDecl_6() { return static_cast<int32_t>(offsetof(XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97, ___htElementIDAttrDecl_6)); }
	inline Hashtable_t978F65B8006C8F5504B286526AEC6608FF983FC9 * get_htElementIDAttrDecl_6() const { return ___htElementIDAttrDecl_6; }
	inline Hashtable_t978F65B8006C8F5504B286526AEC6608FF983FC9 ** get_address_of_htElementIDAttrDecl_6() { return &___htElementIDAttrDecl_6; }
	inline void set_htElementIDAttrDecl_6(Hashtable_t978F65B8006C8F5504B286526AEC6608FF983FC9 * value)
	{
		___htElementIDAttrDecl_6 = value;
		Il2CppCodeGenWriteBarrier((&___htElementIDAttrDecl_6), value);
	}

	inline static int32_t get_offset_of_schemaInfo_7() { return static_cast<int32_t>(offsetof(XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97, ___schemaInfo_7)); }
	inline SchemaInfo_tD9774489795A78B9235BAD315E5242C974183A41 * get_schemaInfo_7() const { return ___schemaInfo_7; }
	inline SchemaInfo_tD9774489795A78B9235BAD315E5242C974183A41 ** get_address_of_schemaInfo_7() { return &___schemaInfo_7; }
	inline void set_schemaInfo_7(SchemaInfo_tD9774489795A78B9235BAD315E5242C974183A41 * value)
	{
		___schemaInfo_7 = value;
		Il2CppCodeGenWriteBarrier((&___schemaInfo_7), value);
	}

	inline static int32_t get_offset_of_schemas_8() { return static_cast<int32_t>(offsetof(XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97, ___schemas_8)); }
	inline XmlSchemaSet_tD92B4BF5F65FBF5B106399A36284FDC64E602F7F * get_schemas_8() const { return ___schemas_8; }
	inline XmlSchemaSet_tD92B4BF5F65FBF5B106399A36284FDC64E602F7F ** get_address_of_schemas_8() { return &___schemas_8; }
	inline void set_schemas_8(XmlSchemaSet_tD92B4BF5F65FBF5B106399A36284FDC64E602F7F * value)
	{
		___schemas_8 = value;
		Il2CppCodeGenWriteBarrier((&___schemas_8), value);
	}

	inline static int32_t get_offset_of_reportValidity_9() { return static_cast<int32_t>(offsetof(XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97, ___reportValidity_9)); }
	inline bool get_reportValidity_9() const { return ___reportValidity_9; }
	inline bool* get_address_of_reportValidity_9() { return &___reportValidity_9; }
	inline void set_reportValidity_9(bool value)
	{
		___reportValidity_9 = value;
	}

	inline static int32_t get_offset_of_actualLoadingStatus_10() { return static_cast<int32_t>(offsetof(XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97, ___actualLoadingStatus_10)); }
	inline bool get_actualLoadingStatus_10() const { return ___actualLoadingStatus_10; }
	inline bool* get_address_of_actualLoadingStatus_10() { return &___actualLoadingStatus_10; }
	inline void set_actualLoadingStatus_10(bool value)
	{
		___actualLoadingStatus_10 = value;
	}

	inline static int32_t get_offset_of_onNodeInsertingDelegate_11() { return static_cast<int32_t>(offsetof(XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97, ___onNodeInsertingDelegate_11)); }
	inline XmlNodeChangedEventHandler_t730DECDAE07BB728186F47DDF2A569F50A889838 * get_onNodeInsertingDelegate_11() const { return ___onNodeInsertingDelegate_11; }
	inline XmlNodeChangedEventHandler_t730DECDAE07BB728186F47DDF2A569F50A889838 ** get_address_of_onNodeInsertingDelegate_11() { return &___onNodeInsertingDelegate_11; }
	inline void set_onNodeInsertingDelegate_11(XmlNodeChangedEventHandler_t730DECDAE07BB728186F47DDF2A569F50A889838 * value)
	{
		___onNodeInsertingDelegate_11 = value;
		Il2CppCodeGenWriteBarrier((&___onNodeInsertingDelegate_11), value);
	}

	inline static int32_t get_offset_of_onNodeInsertedDelegate_12() { return static_cast<int32_t>(offsetof(XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97, ___onNodeInsertedDelegate_12)); }
	inline XmlNodeChangedEventHandler_t730DECDAE07BB728186F47DDF2A569F50A889838 * get_onNodeInsertedDelegate_12() const { return ___onNodeInsertedDelegate_12; }
	inline XmlNodeChangedEventHandler_t730DECDAE07BB728186F47DDF2A569F50A889838 ** get_address_of_onNodeInsertedDelegate_12() { return &___onNodeInsertedDelegate_12; }
	inline void set_onNodeInsertedDelegate_12(XmlNodeChangedEventHandler_t730DECDAE07BB728186F47DDF2A569F50A889838 * value)
	{
		___onNodeInsertedDelegate_12 = value;
		Il2CppCodeGenWriteBarrier((&___onNodeInsertedDelegate_12), value);
	}

	inline static int32_t get_offset_of_onNodeRemovingDelegate_13() { return static_cast<int32_t>(offsetof(XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97, ___onNodeRemovingDelegate_13)); }
	inline XmlNodeChangedEventHandler_t730DECDAE07BB728186F47DDF2A569F50A889838 * get_onNodeRemovingDelegate_13() const { return ___onNodeRemovingDelegate_13; }
	inline XmlNodeChangedEventHandler_t730DECDAE07BB728186F47DDF2A569F50A889838 ** get_address_of_onNodeRemovingDelegate_13() { return &___onNodeRemovingDelegate_13; }
	inline void set_onNodeRemovingDelegate_13(XmlNodeChangedEventHandler_t730DECDAE07BB728186F47DDF2A569F50A889838 * value)
	{
		___onNodeRemovingDelegate_13 = value;
		Il2CppCodeGenWriteBarrier((&___onNodeRemovingDelegate_13), value);
	}

	inline static int32_t get_offset_of_onNodeRemovedDelegate_14() { return static_cast<int32_t>(offsetof(XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97, ___onNodeRemovedDelegate_14)); }
	inline XmlNodeChangedEventHandler_t730DECDAE07BB728186F47DDF2A569F50A889838 * get_onNodeRemovedDelegate_14() const { return ___onNodeRemovedDelegate_14; }
	inline XmlNodeChangedEventHandler_t730DECDAE07BB728186F47DDF2A569F50A889838 ** get_address_of_onNodeRemovedDelegate_14() { return &___onNodeRemovedDelegate_14; }
	inline void set_onNodeRemovedDelegate_14(XmlNodeChangedEventHandler_t730DECDAE07BB728186F47DDF2A569F50A889838 * value)
	{
		___onNodeRemovedDelegate_14 = value;
		Il2CppCodeGenWriteBarrier((&___onNodeRemovedDelegate_14), value);
	}

	inline static int32_t get_offset_of_onNodeChangingDelegate_15() { return static_cast<int32_t>(offsetof(XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97, ___onNodeChangingDelegate_15)); }
	inline XmlNodeChangedEventHandler_t730DECDAE07BB728186F47DDF2A569F50A889838 * get_onNodeChangingDelegate_15() const { return ___onNodeChangingDelegate_15; }
	inline XmlNodeChangedEventHandler_t730DECDAE07BB728186F47DDF2A569F50A889838 ** get_address_of_onNodeChangingDelegate_15() { return &___onNodeChangingDelegate_15; }
	inline void set_onNodeChangingDelegate_15(XmlNodeChangedEventHandler_t730DECDAE07BB728186F47DDF2A569F50A889838 * value)
	{
		___onNodeChangingDelegate_15 = value;
		Il2CppCodeGenWriteBarrier((&___onNodeChangingDelegate_15), value);
	}

	inline static int32_t get_offset_of_onNodeChangedDelegate_16() { return static_cast<int32_t>(offsetof(XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97, ___onNodeChangedDelegate_16)); }
	inline XmlNodeChangedEventHandler_t730DECDAE07BB728186F47DDF2A569F50A889838 * get_onNodeChangedDelegate_16() const { return ___onNodeChangedDelegate_16; }
	inline XmlNodeChangedEventHandler_t730DECDAE07BB728186F47DDF2A569F50A889838 ** get_address_of_onNodeChangedDelegate_16() { return &___onNodeChangedDelegate_16; }
	inline void set_onNodeChangedDelegate_16(XmlNodeChangedEventHandler_t730DECDAE07BB728186F47DDF2A569F50A889838 * value)
	{
		___onNodeChangedDelegate_16 = value;
		Il2CppCodeGenWriteBarrier((&___onNodeChangedDelegate_16), value);
	}

	inline static int32_t get_offset_of_fEntRefNodesPresent_17() { return static_cast<int32_t>(offsetof(XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97, ___fEntRefNodesPresent_17)); }
	inline bool get_fEntRefNodesPresent_17() const { return ___fEntRefNodesPresent_17; }
	inline bool* get_address_of_fEntRefNodesPresent_17() { return &___fEntRefNodesPresent_17; }
	inline void set_fEntRefNodesPresent_17(bool value)
	{
		___fEntRefNodesPresent_17 = value;
	}

	inline static int32_t get_offset_of_fCDataNodesPresent_18() { return static_cast<int32_t>(offsetof(XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97, ___fCDataNodesPresent_18)); }
	inline bool get_fCDataNodesPresent_18() const { return ___fCDataNodesPresent_18; }
	inline bool* get_address_of_fCDataNodesPresent_18() { return &___fCDataNodesPresent_18; }
	inline void set_fCDataNodesPresent_18(bool value)
	{
		___fCDataNodesPresent_18 = value;
	}

	inline static int32_t get_offset_of_preserveWhitespace_19() { return static_cast<int32_t>(offsetof(XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97, ___preserveWhitespace_19)); }
	inline bool get_preserveWhitespace_19() const { return ___preserveWhitespace_19; }
	inline bool* get_address_of_preserveWhitespace_19() { return &___preserveWhitespace_19; }
	inline void set_preserveWhitespace_19(bool value)
	{
		___preserveWhitespace_19 = value;
	}

	inline static int32_t get_offset_of_isLoading_20() { return static_cast<int32_t>(offsetof(XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97, ___isLoading_20)); }
	inline bool get_isLoading_20() const { return ___isLoading_20; }
	inline bool* get_address_of_isLoading_20() { return &___isLoading_20; }
	inline void set_isLoading_20(bool value)
	{
		___isLoading_20 = value;
	}

	inline static int32_t get_offset_of_strDocumentName_21() { return static_cast<int32_t>(offsetof(XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97, ___strDocumentName_21)); }
	inline String_t* get_strDocumentName_21() const { return ___strDocumentName_21; }
	inline String_t** get_address_of_strDocumentName_21() { return &___strDocumentName_21; }
	inline void set_strDocumentName_21(String_t* value)
	{
		___strDocumentName_21 = value;
		Il2CppCodeGenWriteBarrier((&___strDocumentName_21), value);
	}

	inline static int32_t get_offset_of_strDocumentFragmentName_22() { return static_cast<int32_t>(offsetof(XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97, ___strDocumentFragmentName_22)); }
	inline String_t* get_strDocumentFragmentName_22() const { return ___strDocumentFragmentName_22; }
	inline String_t** get_address_of_strDocumentFragmentName_22() { return &___strDocumentFragmentName_22; }
	inline void set_strDocumentFragmentName_22(String_t* value)
	{
		___strDocumentFragmentName_22 = value;
		Il2CppCodeGenWriteBarrier((&___strDocumentFragmentName_22), value);
	}

	inline static int32_t get_offset_of_strCommentName_23() { return static_cast<int32_t>(offsetof(XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97, ___strCommentName_23)); }
	inline String_t* get_strCommentName_23() const { return ___strCommentName_23; }
	inline String_t** get_address_of_strCommentName_23() { return &___strCommentName_23; }
	inline void set_strCommentName_23(String_t* value)
	{
		___strCommentName_23 = value;
		Il2CppCodeGenWriteBarrier((&___strCommentName_23), value);
	}

	inline static int32_t get_offset_of_strTextName_24() { return static_cast<int32_t>(offsetof(XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97, ___strTextName_24)); }
	inline String_t* get_strTextName_24() const { return ___strTextName_24; }
	inline String_t** get_address_of_strTextName_24() { return &___strTextName_24; }
	inline void set_strTextName_24(String_t* value)
	{
		___strTextName_24 = value;
		Il2CppCodeGenWriteBarrier((&___strTextName_24), value);
	}

	inline static int32_t get_offset_of_strCDataSectionName_25() { return static_cast<int32_t>(offsetof(XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97, ___strCDataSectionName_25)); }
	inline String_t* get_strCDataSectionName_25() const { return ___strCDataSectionName_25; }
	inline String_t** get_address_of_strCDataSectionName_25() { return &___strCDataSectionName_25; }
	inline void set_strCDataSectionName_25(String_t* value)
	{
		___strCDataSectionName_25 = value;
		Il2CppCodeGenWriteBarrier((&___strCDataSectionName_25), value);
	}

	inline static int32_t get_offset_of_strEntityName_26() { return static_cast<int32_t>(offsetof(XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97, ___strEntityName_26)); }
	inline String_t* get_strEntityName_26() const { return ___strEntityName_26; }
	inline String_t** get_address_of_strEntityName_26() { return &___strEntityName_26; }
	inline void set_strEntityName_26(String_t* value)
	{
		___strEntityName_26 = value;
		Il2CppCodeGenWriteBarrier((&___strEntityName_26), value);
	}

	inline static int32_t get_offset_of_strID_27() { return static_cast<int32_t>(offsetof(XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97, ___strID_27)); }
	inline String_t* get_strID_27() const { return ___strID_27; }
	inline String_t** get_address_of_strID_27() { return &___strID_27; }
	inline void set_strID_27(String_t* value)
	{
		___strID_27 = value;
		Il2CppCodeGenWriteBarrier((&___strID_27), value);
	}

	inline static int32_t get_offset_of_strXmlns_28() { return static_cast<int32_t>(offsetof(XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97, ___strXmlns_28)); }
	inline String_t* get_strXmlns_28() const { return ___strXmlns_28; }
	inline String_t** get_address_of_strXmlns_28() { return &___strXmlns_28; }
	inline void set_strXmlns_28(String_t* value)
	{
		___strXmlns_28 = value;
		Il2CppCodeGenWriteBarrier((&___strXmlns_28), value);
	}

	inline static int32_t get_offset_of_strXml_29() { return static_cast<int32_t>(offsetof(XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97, ___strXml_29)); }
	inline String_t* get_strXml_29() const { return ___strXml_29; }
	inline String_t** get_address_of_strXml_29() { return &___strXml_29; }
	inline void set_strXml_29(String_t* value)
	{
		___strXml_29 = value;
		Il2CppCodeGenWriteBarrier((&___strXml_29), value);
	}

	inline static int32_t get_offset_of_strSpace_30() { return static_cast<int32_t>(offsetof(XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97, ___strSpace_30)); }
	inline String_t* get_strSpace_30() const { return ___strSpace_30; }
	inline String_t** get_address_of_strSpace_30() { return &___strSpace_30; }
	inline void set_strSpace_30(String_t* value)
	{
		___strSpace_30 = value;
		Il2CppCodeGenWriteBarrier((&___strSpace_30), value);
	}

	inline static int32_t get_offset_of_strLang_31() { return static_cast<int32_t>(offsetof(XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97, ___strLang_31)); }
	inline String_t* get_strLang_31() const { return ___strLang_31; }
	inline String_t** get_address_of_strLang_31() { return &___strLang_31; }
	inline void set_strLang_31(String_t* value)
	{
		___strLang_31 = value;
		Il2CppCodeGenWriteBarrier((&___strLang_31), value);
	}

	inline static int32_t get_offset_of_strEmpty_32() { return static_cast<int32_t>(offsetof(XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97, ___strEmpty_32)); }
	inline String_t* get_strEmpty_32() const { return ___strEmpty_32; }
	inline String_t** get_address_of_strEmpty_32() { return &___strEmpty_32; }
	inline void set_strEmpty_32(String_t* value)
	{
		___strEmpty_32 = value;
		Il2CppCodeGenWriteBarrier((&___strEmpty_32), value);
	}

	inline static int32_t get_offset_of_strNonSignificantWhitespaceName_33() { return static_cast<int32_t>(offsetof(XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97, ___strNonSignificantWhitespaceName_33)); }
	inline String_t* get_strNonSignificantWhitespaceName_33() const { return ___strNonSignificantWhitespaceName_33; }
	inline String_t** get_address_of_strNonSignificantWhitespaceName_33() { return &___strNonSignificantWhitespaceName_33; }
	inline void set_strNonSignificantWhitespaceName_33(String_t* value)
	{
		___strNonSignificantWhitespaceName_33 = value;
		Il2CppCodeGenWriteBarrier((&___strNonSignificantWhitespaceName_33), value);
	}

	inline static int32_t get_offset_of_strSignificantWhitespaceName_34() { return static_cast<int32_t>(offsetof(XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97, ___strSignificantWhitespaceName_34)); }
	inline String_t* get_strSignificantWhitespaceName_34() const { return ___strSignificantWhitespaceName_34; }
	inline String_t** get_address_of_strSignificantWhitespaceName_34() { return &___strSignificantWhitespaceName_34; }
	inline void set_strSignificantWhitespaceName_34(String_t* value)
	{
		___strSignificantWhitespaceName_34 = value;
		Il2CppCodeGenWriteBarrier((&___strSignificantWhitespaceName_34), value);
	}

	inline static int32_t get_offset_of_strReservedXmlns_35() { return static_cast<int32_t>(offsetof(XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97, ___strReservedXmlns_35)); }
	inline String_t* get_strReservedXmlns_35() const { return ___strReservedXmlns_35; }
	inline String_t** get_address_of_strReservedXmlns_35() { return &___strReservedXmlns_35; }
	inline void set_strReservedXmlns_35(String_t* value)
	{
		___strReservedXmlns_35 = value;
		Il2CppCodeGenWriteBarrier((&___strReservedXmlns_35), value);
	}

	inline static int32_t get_offset_of_strReservedXml_36() { return static_cast<int32_t>(offsetof(XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97, ___strReservedXml_36)); }
	inline String_t* get_strReservedXml_36() const { return ___strReservedXml_36; }
	inline String_t** get_address_of_strReservedXml_36() { return &___strReservedXml_36; }
	inline void set_strReservedXml_36(String_t* value)
	{
		___strReservedXml_36 = value;
		Il2CppCodeGenWriteBarrier((&___strReservedXml_36), value);
	}

	inline static int32_t get_offset_of_baseURI_37() { return static_cast<int32_t>(offsetof(XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97, ___baseURI_37)); }
	inline String_t* get_baseURI_37() const { return ___baseURI_37; }
	inline String_t** get_address_of_baseURI_37() { return &___baseURI_37; }
	inline void set_baseURI_37(String_t* value)
	{
		___baseURI_37 = value;
		Il2CppCodeGenWriteBarrier((&___baseURI_37), value);
	}

	inline static int32_t get_offset_of_resolver_38() { return static_cast<int32_t>(offsetof(XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97, ___resolver_38)); }
	inline XmlResolver_t93269F14B2F8750D040AED2FB7A303CE85016280 * get_resolver_38() const { return ___resolver_38; }
	inline XmlResolver_t93269F14B2F8750D040AED2FB7A303CE85016280 ** get_address_of_resolver_38() { return &___resolver_38; }
	inline void set_resolver_38(XmlResolver_t93269F14B2F8750D040AED2FB7A303CE85016280 * value)
	{
		___resolver_38 = value;
		Il2CppCodeGenWriteBarrier((&___resolver_38), value);
	}

	inline static int32_t get_offset_of_bSetResolver_39() { return static_cast<int32_t>(offsetof(XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97, ___bSetResolver_39)); }
	inline bool get_bSetResolver_39() const { return ___bSetResolver_39; }
	inline bool* get_address_of_bSetResolver_39() { return &___bSetResolver_39; }
	inline void set_bSetResolver_39(bool value)
	{
		___bSetResolver_39 = value;
	}

	inline static int32_t get_offset_of_objLock_40() { return static_cast<int32_t>(offsetof(XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97, ___objLock_40)); }
	inline RuntimeObject * get_objLock_40() const { return ___objLock_40; }
	inline RuntimeObject ** get_address_of_objLock_40() { return &___objLock_40; }
	inline void set_objLock_40(RuntimeObject * value)
	{
		___objLock_40 = value;
		Il2CppCodeGenWriteBarrier((&___objLock_40), value);
	}
};

struct XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97_StaticFields
{
public:
	// System.Xml.EmptyEnumerator System.Xml.XmlDocument::EmptyEnumerator
	EmptyEnumerator_t7702FAD652CDD694DC3D136712CA48C48FFB0DC3 * ___EmptyEnumerator_41;
	// System.Xml.Schema.IXmlSchemaInfo System.Xml.XmlDocument::NotKnownSchemaInfo
	RuntimeObject* ___NotKnownSchemaInfo_42;
	// System.Xml.Schema.IXmlSchemaInfo System.Xml.XmlDocument::ValidSchemaInfo
	RuntimeObject* ___ValidSchemaInfo_43;
	// System.Xml.Schema.IXmlSchemaInfo System.Xml.XmlDocument::InvalidSchemaInfo
	RuntimeObject* ___InvalidSchemaInfo_44;

public:
	inline static int32_t get_offset_of_EmptyEnumerator_41() { return static_cast<int32_t>(offsetof(XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97_StaticFields, ___EmptyEnumerator_41)); }
	inline EmptyEnumerator_t7702FAD652CDD694DC3D136712CA48C48FFB0DC3 * get_EmptyEnumerator_41() const { return ___EmptyEnumerator_41; }
	inline EmptyEnumerator_t7702FAD652CDD694DC3D136712CA48C48FFB0DC3 ** get_address_of_EmptyEnumerator_41() { return &___EmptyEnumerator_41; }
	inline void set_EmptyEnumerator_41(EmptyEnumerator_t7702FAD652CDD694DC3D136712CA48C48FFB0DC3 * value)
	{
		___EmptyEnumerator_41 = value;
		Il2CppCodeGenWriteBarrier((&___EmptyEnumerator_41), value);
	}

	inline static int32_t get_offset_of_NotKnownSchemaInfo_42() { return static_cast<int32_t>(offsetof(XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97_StaticFields, ___NotKnownSchemaInfo_42)); }
	inline RuntimeObject* get_NotKnownSchemaInfo_42() const { return ___NotKnownSchemaInfo_42; }
	inline RuntimeObject** get_address_of_NotKnownSchemaInfo_42() { return &___NotKnownSchemaInfo_42; }
	inline void set_NotKnownSchemaInfo_42(RuntimeObject* value)
	{
		___NotKnownSchemaInfo_42 = value;
		Il2CppCodeGenWriteBarrier((&___NotKnownSchemaInfo_42), value);
	}

	inline static int32_t get_offset_of_ValidSchemaInfo_43() { return static_cast<int32_t>(offsetof(XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97_StaticFields, ___ValidSchemaInfo_43)); }
	inline RuntimeObject* get_ValidSchemaInfo_43() const { return ___ValidSchemaInfo_43; }
	inline RuntimeObject** get_address_of_ValidSchemaInfo_43() { return &___ValidSchemaInfo_43; }
	inline void set_ValidSchemaInfo_43(RuntimeObject* value)
	{
		___ValidSchemaInfo_43 = value;
		Il2CppCodeGenWriteBarrier((&___ValidSchemaInfo_43), value);
	}

	inline static int32_t get_offset_of_InvalidSchemaInfo_44() { return static_cast<int32_t>(offsetof(XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97_StaticFields, ___InvalidSchemaInfo_44)); }
	inline RuntimeObject* get_InvalidSchemaInfo_44() const { return ___InvalidSchemaInfo_44; }
	inline RuntimeObject** get_address_of_InvalidSchemaInfo_44() { return &___InvalidSchemaInfo_44; }
	inline void set_InvalidSchemaInfo_44(RuntimeObject* value)
	{
		___InvalidSchemaInfo_44 = value;
		Il2CppCodeGenWriteBarrier((&___InvalidSchemaInfo_44), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // XMLDOCUMENT_T448325D04430147AF19F2955BD6A5F1551003C97_H
#ifndef XMLLINKEDNODE_T4F76C8580C2E6D2908D88AC84A86060FA9289A0E_H
#define XMLLINKEDNODE_T4F76C8580C2E6D2908D88AC84A86060FA9289A0E_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.XmlLinkedNode
struct  XmlLinkedNode_t4F76C8580C2E6D2908D88AC84A86060FA9289A0E  : public XmlNode_t07D70045D843753E4FE8AFE40FD36244E6B6D7FB
{
public:
	// System.Xml.XmlLinkedNode System.Xml.XmlLinkedNode::next
	XmlLinkedNode_t4F76C8580C2E6D2908D88AC84A86060FA9289A0E * ___next_1;

public:
	inline static int32_t get_offset_of_next_1() { return static_cast<int32_t>(offsetof(XmlLinkedNode_t4F76C8580C2E6D2908D88AC84A86060FA9289A0E, ___next_1)); }
	inline XmlLinkedNode_t4F76C8580C2E6D2908D88AC84A86060FA9289A0E * get_next_1() const { return ___next_1; }
	inline XmlLinkedNode_t4F76C8580C2E6D2908D88AC84A86060FA9289A0E ** get_address_of_next_1() { return &___next_1; }
	inline void set_next_1(XmlLinkedNode_t4F76C8580C2E6D2908D88AC84A86060FA9289A0E * value)
	{
		___next_1 = value;
		Il2CppCodeGenWriteBarrier((&___next_1), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // XMLLINKEDNODE_T4F76C8580C2E6D2908D88AC84A86060FA9289A0E_H
#ifndef NONAMESPACEMANAGER_T11014200BFBB3974A5E72A75867B9730C7D7E883_H
#define NONAMESPACEMANAGER_T11014200BFBB3974A5E72A75867B9730C7D7E883_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.XmlTextReaderImpl_NoNamespaceManager
struct  NoNamespaceManager_t11014200BFBB3974A5E72A75867B9730C7D7E883  : public XmlNamespaceManager_t8323BEB96BBE8F75207DC2AAFE9430E7F473658F
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NONAMESPACEMANAGER_T11014200BFBB3974A5E72A75867B9730C7D7E883_H
#ifndef PARSINGSTATE_TE4A8E7F14B2068AE43ECF99F81F55B0301A551A2_H
#define PARSINGSTATE_TE4A8E7F14B2068AE43ECF99F81F55B0301A551A2_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.XmlTextReaderImpl_ParsingState
struct  ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2 
{
public:
	// System.Char[] System.Xml.XmlTextReaderImpl_ParsingState::chars
	CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2* ___chars_0;
	// System.Int32 System.Xml.XmlTextReaderImpl_ParsingState::charPos
	int32_t ___charPos_1;
	// System.Int32 System.Xml.XmlTextReaderImpl_ParsingState::charsUsed
	int32_t ___charsUsed_2;
	// System.Text.Encoding System.Xml.XmlTextReaderImpl_ParsingState::encoding
	Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4 * ___encoding_3;
	// System.Boolean System.Xml.XmlTextReaderImpl_ParsingState::appendMode
	bool ___appendMode_4;
	// System.IO.Stream System.Xml.XmlTextReaderImpl_ParsingState::stream
	Stream_tFC50657DD5AAB87770987F9179D934A51D99D5E7 * ___stream_5;
	// System.Text.Decoder System.Xml.XmlTextReaderImpl_ParsingState::decoder
	Decoder_tEEF45EB6F965222036C49E8EC6BA8A0692AA1F26 * ___decoder_6;
	// System.Byte[] System.Xml.XmlTextReaderImpl_ParsingState::bytes
	ByteU5BU5D_tD06FDBE8142446525DF1C40351D523A228373821* ___bytes_7;
	// System.Int32 System.Xml.XmlTextReaderImpl_ParsingState::bytePos
	int32_t ___bytePos_8;
	// System.Int32 System.Xml.XmlTextReaderImpl_ParsingState::bytesUsed
	int32_t ___bytesUsed_9;
	// System.IO.TextReader System.Xml.XmlTextReaderImpl_ParsingState::textReader
	TextReader_t7DF8314B601D202ECFEDF623093A87BFDAB58D0A * ___textReader_10;
	// System.Int32 System.Xml.XmlTextReaderImpl_ParsingState::lineNo
	int32_t ___lineNo_11;
	// System.Int32 System.Xml.XmlTextReaderImpl_ParsingState::lineStartPos
	int32_t ___lineStartPos_12;
	// System.String System.Xml.XmlTextReaderImpl_ParsingState::baseUriStr
	String_t* ___baseUriStr_13;
	// System.Uri System.Xml.XmlTextReaderImpl_ParsingState::baseUri
	Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E * ___baseUri_14;
	// System.Boolean System.Xml.XmlTextReaderImpl_ParsingState::isEof
	bool ___isEof_15;
	// System.Boolean System.Xml.XmlTextReaderImpl_ParsingState::isStreamEof
	bool ___isStreamEof_16;
	// System.Xml.IDtdEntityInfo System.Xml.XmlTextReaderImpl_ParsingState::entity
	RuntimeObject* ___entity_17;
	// System.Int32 System.Xml.XmlTextReaderImpl_ParsingState::entityId
	int32_t ___entityId_18;
	// System.Boolean System.Xml.XmlTextReaderImpl_ParsingState::eolNormalized
	bool ___eolNormalized_19;
	// System.Boolean System.Xml.XmlTextReaderImpl_ParsingState::entityResolvedManually
	bool ___entityResolvedManually_20;

public:
	inline static int32_t get_offset_of_chars_0() { return static_cast<int32_t>(offsetof(ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2, ___chars_0)); }
	inline CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2* get_chars_0() const { return ___chars_0; }
	inline CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2** get_address_of_chars_0() { return &___chars_0; }
	inline void set_chars_0(CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2* value)
	{
		___chars_0 = value;
		Il2CppCodeGenWriteBarrier((&___chars_0), value);
	}

	inline static int32_t get_offset_of_charPos_1() { return static_cast<int32_t>(offsetof(ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2, ___charPos_1)); }
	inline int32_t get_charPos_1() const { return ___charPos_1; }
	inline int32_t* get_address_of_charPos_1() { return &___charPos_1; }
	inline void set_charPos_1(int32_t value)
	{
		___charPos_1 = value;
	}

	inline static int32_t get_offset_of_charsUsed_2() { return static_cast<int32_t>(offsetof(ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2, ___charsUsed_2)); }
	inline int32_t get_charsUsed_2() const { return ___charsUsed_2; }
	inline int32_t* get_address_of_charsUsed_2() { return &___charsUsed_2; }
	inline void set_charsUsed_2(int32_t value)
	{
		___charsUsed_2 = value;
	}

	inline static int32_t get_offset_of_encoding_3() { return static_cast<int32_t>(offsetof(ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2, ___encoding_3)); }
	inline Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4 * get_encoding_3() const { return ___encoding_3; }
	inline Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4 ** get_address_of_encoding_3() { return &___encoding_3; }
	inline void set_encoding_3(Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4 * value)
	{
		___encoding_3 = value;
		Il2CppCodeGenWriteBarrier((&___encoding_3), value);
	}

	inline static int32_t get_offset_of_appendMode_4() { return static_cast<int32_t>(offsetof(ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2, ___appendMode_4)); }
	inline bool get_appendMode_4() const { return ___appendMode_4; }
	inline bool* get_address_of_appendMode_4() { return &___appendMode_4; }
	inline void set_appendMode_4(bool value)
	{
		___appendMode_4 = value;
	}

	inline static int32_t get_offset_of_stream_5() { return static_cast<int32_t>(offsetof(ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2, ___stream_5)); }
	inline Stream_tFC50657DD5AAB87770987F9179D934A51D99D5E7 * get_stream_5() const { return ___stream_5; }
	inline Stream_tFC50657DD5AAB87770987F9179D934A51D99D5E7 ** get_address_of_stream_5() { return &___stream_5; }
	inline void set_stream_5(Stream_tFC50657DD5AAB87770987F9179D934A51D99D5E7 * value)
	{
		___stream_5 = value;
		Il2CppCodeGenWriteBarrier((&___stream_5), value);
	}

	inline static int32_t get_offset_of_decoder_6() { return static_cast<int32_t>(offsetof(ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2, ___decoder_6)); }
	inline Decoder_tEEF45EB6F965222036C49E8EC6BA8A0692AA1F26 * get_decoder_6() const { return ___decoder_6; }
	inline Decoder_tEEF45EB6F965222036C49E8EC6BA8A0692AA1F26 ** get_address_of_decoder_6() { return &___decoder_6; }
	inline void set_decoder_6(Decoder_tEEF45EB6F965222036C49E8EC6BA8A0692AA1F26 * value)
	{
		___decoder_6 = value;
		Il2CppCodeGenWriteBarrier((&___decoder_6), value);
	}

	inline static int32_t get_offset_of_bytes_7() { return static_cast<int32_t>(offsetof(ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2, ___bytes_7)); }
	inline ByteU5BU5D_tD06FDBE8142446525DF1C40351D523A228373821* get_bytes_7() const { return ___bytes_7; }
	inline ByteU5BU5D_tD06FDBE8142446525DF1C40351D523A228373821** get_address_of_bytes_7() { return &___bytes_7; }
	inline void set_bytes_7(ByteU5BU5D_tD06FDBE8142446525DF1C40351D523A228373821* value)
	{
		___bytes_7 = value;
		Il2CppCodeGenWriteBarrier((&___bytes_7), value);
	}

	inline static int32_t get_offset_of_bytePos_8() { return static_cast<int32_t>(offsetof(ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2, ___bytePos_8)); }
	inline int32_t get_bytePos_8() const { return ___bytePos_8; }
	inline int32_t* get_address_of_bytePos_8() { return &___bytePos_8; }
	inline void set_bytePos_8(int32_t value)
	{
		___bytePos_8 = value;
	}

	inline static int32_t get_offset_of_bytesUsed_9() { return static_cast<int32_t>(offsetof(ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2, ___bytesUsed_9)); }
	inline int32_t get_bytesUsed_9() const { return ___bytesUsed_9; }
	inline int32_t* get_address_of_bytesUsed_9() { return &___bytesUsed_9; }
	inline void set_bytesUsed_9(int32_t value)
	{
		___bytesUsed_9 = value;
	}

	inline static int32_t get_offset_of_textReader_10() { return static_cast<int32_t>(offsetof(ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2, ___textReader_10)); }
	inline TextReader_t7DF8314B601D202ECFEDF623093A87BFDAB58D0A * get_textReader_10() const { return ___textReader_10; }
	inline TextReader_t7DF8314B601D202ECFEDF623093A87BFDAB58D0A ** get_address_of_textReader_10() { return &___textReader_10; }
	inline void set_textReader_10(TextReader_t7DF8314B601D202ECFEDF623093A87BFDAB58D0A * value)
	{
		___textReader_10 = value;
		Il2CppCodeGenWriteBarrier((&___textReader_10), value);
	}

	inline static int32_t get_offset_of_lineNo_11() { return static_cast<int32_t>(offsetof(ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2, ___lineNo_11)); }
	inline int32_t get_lineNo_11() const { return ___lineNo_11; }
	inline int32_t* get_address_of_lineNo_11() { return &___lineNo_11; }
	inline void set_lineNo_11(int32_t value)
	{
		___lineNo_11 = value;
	}

	inline static int32_t get_offset_of_lineStartPos_12() { return static_cast<int32_t>(offsetof(ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2, ___lineStartPos_12)); }
	inline int32_t get_lineStartPos_12() const { return ___lineStartPos_12; }
	inline int32_t* get_address_of_lineStartPos_12() { return &___lineStartPos_12; }
	inline void set_lineStartPos_12(int32_t value)
	{
		___lineStartPos_12 = value;
	}

	inline static int32_t get_offset_of_baseUriStr_13() { return static_cast<int32_t>(offsetof(ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2, ___baseUriStr_13)); }
	inline String_t* get_baseUriStr_13() const { return ___baseUriStr_13; }
	inline String_t** get_address_of_baseUriStr_13() { return &___baseUriStr_13; }
	inline void set_baseUriStr_13(String_t* value)
	{
		___baseUriStr_13 = value;
		Il2CppCodeGenWriteBarrier((&___baseUriStr_13), value);
	}

	inline static int32_t get_offset_of_baseUri_14() { return static_cast<int32_t>(offsetof(ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2, ___baseUri_14)); }
	inline Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E * get_baseUri_14() const { return ___baseUri_14; }
	inline Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E ** get_address_of_baseUri_14() { return &___baseUri_14; }
	inline void set_baseUri_14(Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E * value)
	{
		___baseUri_14 = value;
		Il2CppCodeGenWriteBarrier((&___baseUri_14), value);
	}

	inline static int32_t get_offset_of_isEof_15() { return static_cast<int32_t>(offsetof(ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2, ___isEof_15)); }
	inline bool get_isEof_15() const { return ___isEof_15; }
	inline bool* get_address_of_isEof_15() { return &___isEof_15; }
	inline void set_isEof_15(bool value)
	{
		___isEof_15 = value;
	}

	inline static int32_t get_offset_of_isStreamEof_16() { return static_cast<int32_t>(offsetof(ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2, ___isStreamEof_16)); }
	inline bool get_isStreamEof_16() const { return ___isStreamEof_16; }
	inline bool* get_address_of_isStreamEof_16() { return &___isStreamEof_16; }
	inline void set_isStreamEof_16(bool value)
	{
		___isStreamEof_16 = value;
	}

	inline static int32_t get_offset_of_entity_17() { return static_cast<int32_t>(offsetof(ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2, ___entity_17)); }
	inline RuntimeObject* get_entity_17() const { return ___entity_17; }
	inline RuntimeObject** get_address_of_entity_17() { return &___entity_17; }
	inline void set_entity_17(RuntimeObject* value)
	{
		___entity_17 = value;
		Il2CppCodeGenWriteBarrier((&___entity_17), value);
	}

	inline static int32_t get_offset_of_entityId_18() { return static_cast<int32_t>(offsetof(ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2, ___entityId_18)); }
	inline int32_t get_entityId_18() const { return ___entityId_18; }
	inline int32_t* get_address_of_entityId_18() { return &___entityId_18; }
	inline void set_entityId_18(int32_t value)
	{
		___entityId_18 = value;
	}

	inline static int32_t get_offset_of_eolNormalized_19() { return static_cast<int32_t>(offsetof(ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2, ___eolNormalized_19)); }
	inline bool get_eolNormalized_19() const { return ___eolNormalized_19; }
	inline bool* get_address_of_eolNormalized_19() { return &___eolNormalized_19; }
	inline void set_eolNormalized_19(bool value)
	{
		___eolNormalized_19 = value;
	}

	inline static int32_t get_offset_of_entityResolvedManually_20() { return static_cast<int32_t>(offsetof(ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2, ___entityResolvedManually_20)); }
	inline bool get_entityResolvedManually_20() const { return ___entityResolvedManually_20; }
	inline bool* get_address_of_entityResolvedManually_20() { return &___entityResolvedManually_20; }
	inline void set_entityResolvedManually_20(bool value)
	{
		___entityResolvedManually_20 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// Native definition for P/Invoke marshalling of System.Xml.XmlTextReaderImpl/ParsingState
struct ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2_marshaled_pinvoke
{
	uint8_t* ___chars_0;
	int32_t ___charPos_1;
	int32_t ___charsUsed_2;
	Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4 * ___encoding_3;
	int32_t ___appendMode_4;
	Stream_tFC50657DD5AAB87770987F9179D934A51D99D5E7 * ___stream_5;
	Decoder_tEEF45EB6F965222036C49E8EC6BA8A0692AA1F26 * ___decoder_6;
	uint8_t* ___bytes_7;
	int32_t ___bytePos_8;
	int32_t ___bytesUsed_9;
	TextReader_t7DF8314B601D202ECFEDF623093A87BFDAB58D0A * ___textReader_10;
	int32_t ___lineNo_11;
	int32_t ___lineStartPos_12;
	char* ___baseUriStr_13;
	Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E * ___baseUri_14;
	int32_t ___isEof_15;
	int32_t ___isStreamEof_16;
	RuntimeObject* ___entity_17;
	int32_t ___entityId_18;
	int32_t ___eolNormalized_19;
	int32_t ___entityResolvedManually_20;
};
// Native definition for COM marshalling of System.Xml.XmlTextReaderImpl/ParsingState
struct ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2_marshaled_com
{
	uint8_t* ___chars_0;
	int32_t ___charPos_1;
	int32_t ___charsUsed_2;
	Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4 * ___encoding_3;
	int32_t ___appendMode_4;
	Stream_tFC50657DD5AAB87770987F9179D934A51D99D5E7 * ___stream_5;
	Decoder_tEEF45EB6F965222036C49E8EC6BA8A0692AA1F26 * ___decoder_6;
	uint8_t* ___bytes_7;
	int32_t ___bytePos_8;
	int32_t ___bytesUsed_9;
	TextReader_t7DF8314B601D202ECFEDF623093A87BFDAB58D0A * ___textReader_10;
	int32_t ___lineNo_11;
	int32_t ___lineStartPos_12;
	Il2CppChar* ___baseUriStr_13;
	Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E * ___baseUri_14;
	int32_t ___isEof_15;
	int32_t ___isStreamEof_16;
	RuntimeObject* ___entity_17;
	int32_t ___entityId_18;
	int32_t ___eolNormalized_19;
	int32_t ___entityResolvedManually_20;
};
#endif // PARSINGSTATE_TE4A8E7F14B2068AE43ECF99F81F55B0301A551A2_H
#ifndef XMLURLRESOLVER_T43FE24F4601B4197354EFB5783E5CB9F57997EC9_H
#define XMLURLRESOLVER_T43FE24F4601B4197354EFB5783E5CB9F57997EC9_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.XmlUrlResolver
struct  XmlUrlResolver_t43FE24F4601B4197354EFB5783E5CB9F57997EC9  : public XmlResolver_t93269F14B2F8750D040AED2FB7A303CE85016280
{
public:
	// System.Net.ICredentials System.Xml.XmlUrlResolver::_credentials
	RuntimeObject* ____credentials_1;
	// System.Net.IWebProxy System.Xml.XmlUrlResolver::_proxy
	RuntimeObject* ____proxy_2;
	// System.Net.Cache.RequestCachePolicy System.Xml.XmlUrlResolver::_cachePolicy
	RequestCachePolicy_t30D7352C7E9D49EEADD492A70EC92C118D90CD61 * ____cachePolicy_3;

public:
	inline static int32_t get_offset_of__credentials_1() { return static_cast<int32_t>(offsetof(XmlUrlResolver_t43FE24F4601B4197354EFB5783E5CB9F57997EC9, ____credentials_1)); }
	inline RuntimeObject* get__credentials_1() const { return ____credentials_1; }
	inline RuntimeObject** get_address_of__credentials_1() { return &____credentials_1; }
	inline void set__credentials_1(RuntimeObject* value)
	{
		____credentials_1 = value;
		Il2CppCodeGenWriteBarrier((&____credentials_1), value);
	}

	inline static int32_t get_offset_of__proxy_2() { return static_cast<int32_t>(offsetof(XmlUrlResolver_t43FE24F4601B4197354EFB5783E5CB9F57997EC9, ____proxy_2)); }
	inline RuntimeObject* get__proxy_2() const { return ____proxy_2; }
	inline RuntimeObject** get_address_of__proxy_2() { return &____proxy_2; }
	inline void set__proxy_2(RuntimeObject* value)
	{
		____proxy_2 = value;
		Il2CppCodeGenWriteBarrier((&____proxy_2), value);
	}

	inline static int32_t get_offset_of__cachePolicy_3() { return static_cast<int32_t>(offsetof(XmlUrlResolver_t43FE24F4601B4197354EFB5783E5CB9F57997EC9, ____cachePolicy_3)); }
	inline RequestCachePolicy_t30D7352C7E9D49EEADD492A70EC92C118D90CD61 * get__cachePolicy_3() const { return ____cachePolicy_3; }
	inline RequestCachePolicy_t30D7352C7E9D49EEADD492A70EC92C118D90CD61 ** get_address_of__cachePolicy_3() { return &____cachePolicy_3; }
	inline void set__cachePolicy_3(RequestCachePolicy_t30D7352C7E9D49EEADD492A70EC92C118D90CD61 * value)
	{
		____cachePolicy_3 = value;
		Il2CppCodeGenWriteBarrier((&____cachePolicy_3), value);
	}
};

struct XmlUrlResolver_t43FE24F4601B4197354EFB5783E5CB9F57997EC9_StaticFields
{
public:
	// System.Object System.Xml.XmlUrlResolver::s_DownloadManager
	RuntimeObject * ___s_DownloadManager_0;

public:
	inline static int32_t get_offset_of_s_DownloadManager_0() { return static_cast<int32_t>(offsetof(XmlUrlResolver_t43FE24F4601B4197354EFB5783E5CB9F57997EC9_StaticFields, ___s_DownloadManager_0)); }
	inline RuntimeObject * get_s_DownloadManager_0() const { return ___s_DownloadManager_0; }
	inline RuntimeObject ** get_address_of_s_DownloadManager_0() { return &___s_DownloadManager_0; }
	inline void set_s_DownloadManager_0(RuntimeObject * value)
	{
		___s_DownloadManager_0 = value;
		Il2CppCodeGenWriteBarrier((&___s_DownloadManager_0), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // XMLURLRESOLVER_T43FE24F4601B4197354EFB5783E5CB9F57997EC9_H
#ifndef ARGUMENTEXCEPTION_TEDCD16F20A09ECE461C3DA766C16EDA8864057D1_H
#define ARGUMENTEXCEPTION_TEDCD16F20A09ECE461C3DA766C16EDA8864057D1_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.ArgumentException
struct  ArgumentException_tEDCD16F20A09ECE461C3DA766C16EDA8864057D1  : public SystemException_t5380468142AA850BE4A341D7AF3EAB9C78746782
{
public:
	// System.String System.ArgumentException::m_paramName
	String_t* ___m_paramName_17;

public:
	inline static int32_t get_offset_of_m_paramName_17() { return static_cast<int32_t>(offsetof(ArgumentException_tEDCD16F20A09ECE461C3DA766C16EDA8864057D1, ___m_paramName_17)); }
	inline String_t* get_m_paramName_17() const { return ___m_paramName_17; }
	inline String_t** get_address_of_m_paramName_17() { return &___m_paramName_17; }
	inline void set_m_paramName_17(String_t* value)
	{
		___m_paramName_17 = value;
		Il2CppCodeGenWriteBarrier((&___m_paramName_17), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // ARGUMENTEXCEPTION_TEDCD16F20A09ECE461C3DA766C16EDA8864057D1_H
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
#ifndef REQUESTCACHELEVEL_TB7692FD08BFC2E0F0CDB6499F58D77BEFD576D8B_H
#define REQUESTCACHELEVEL_TB7692FD08BFC2E0F0CDB6499F58D77BEFD576D8B_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Net.Cache.RequestCacheLevel
struct  RequestCacheLevel_tB7692FD08BFC2E0F0CDB6499F58D77BEFD576D8B 
{
public:
	// System.Int32 System.Net.Cache.RequestCacheLevel::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(RequestCacheLevel_tB7692FD08BFC2E0F0CDB6499F58D77BEFD576D8B, ___value___2)); }
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
#endif // REQUESTCACHELEVEL_TB7692FD08BFC2E0F0CDB6499F58D77BEFD576D8B_H
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
#ifndef ASYNCTASKMETHODBUILDER_1_T2A9513A084F4B19851B91EF1F22BB57776D35663_H
#define ASYNCTASKMETHODBUILDER_1_T2A9513A084F4B19851B91EF1F22BB57776D35663_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>
struct  AsyncTaskMethodBuilder_1_t2A9513A084F4B19851B91EF1F22BB57776D35663 
{
public:
	// System.Runtime.CompilerServices.AsyncMethodBuilderCore System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1::m_coreState
	AsyncMethodBuilderCore_t4CE6C1E4B0621A6EC45CF6E0E8F1F633FFF9FF01  ___m_coreState_1;
	// System.Threading.Tasks.Task`1<TResult> System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1::m_task
	Task_1_tA56001ED5270173CA1432EDFCD84EABB1024BC09 * ___m_task_2;

public:
	inline static int32_t get_offset_of_m_coreState_1() { return static_cast<int32_t>(offsetof(AsyncTaskMethodBuilder_1_t2A9513A084F4B19851B91EF1F22BB57776D35663, ___m_coreState_1)); }
	inline AsyncMethodBuilderCore_t4CE6C1E4B0621A6EC45CF6E0E8F1F633FFF9FF01  get_m_coreState_1() const { return ___m_coreState_1; }
	inline AsyncMethodBuilderCore_t4CE6C1E4B0621A6EC45CF6E0E8F1F633FFF9FF01 * get_address_of_m_coreState_1() { return &___m_coreState_1; }
	inline void set_m_coreState_1(AsyncMethodBuilderCore_t4CE6C1E4B0621A6EC45CF6E0E8F1F633FFF9FF01  value)
	{
		___m_coreState_1 = value;
	}

	inline static int32_t get_offset_of_m_task_2() { return static_cast<int32_t>(offsetof(AsyncTaskMethodBuilder_1_t2A9513A084F4B19851B91EF1F22BB57776D35663, ___m_task_2)); }
	inline Task_1_tA56001ED5270173CA1432EDFCD84EABB1024BC09 * get_m_task_2() const { return ___m_task_2; }
	inline Task_1_tA56001ED5270173CA1432EDFCD84EABB1024BC09 ** get_address_of_m_task_2() { return &___m_task_2; }
	inline void set_m_task_2(Task_1_tA56001ED5270173CA1432EDFCD84EABB1024BC09 * value)
	{
		___m_task_2 = value;
		Il2CppCodeGenWriteBarrier((&___m_task_2), value);
	}
};

struct AsyncTaskMethodBuilder_1_t2A9513A084F4B19851B91EF1F22BB57776D35663_StaticFields
{
public:
	// System.Threading.Tasks.Task`1<TResult> System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1::s_defaultResultTask
	Task_1_tA56001ED5270173CA1432EDFCD84EABB1024BC09 * ___s_defaultResultTask_0;

public:
	inline static int32_t get_offset_of_s_defaultResultTask_0() { return static_cast<int32_t>(offsetof(AsyncTaskMethodBuilder_1_t2A9513A084F4B19851B91EF1F22BB57776D35663_StaticFields, ___s_defaultResultTask_0)); }
	inline Task_1_tA56001ED5270173CA1432EDFCD84EABB1024BC09 * get_s_defaultResultTask_0() const { return ___s_defaultResultTask_0; }
	inline Task_1_tA56001ED5270173CA1432EDFCD84EABB1024BC09 ** get_address_of_s_defaultResultTask_0() { return &___s_defaultResultTask_0; }
	inline void set_s_defaultResultTask_0(Task_1_tA56001ED5270173CA1432EDFCD84EABB1024BC09 * value)
	{
		___s_defaultResultTask_0 = value;
		Il2CppCodeGenWriteBarrier((&___s_defaultResultTask_0), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // ASYNCTASKMETHODBUILDER_1_T2A9513A084F4B19851B91EF1F22BB57776D35663_H
#ifndef CONFIGUREDTASKAWAITABLE_1_T8F8087337FA5C6475CA153C95469983DDDED9F48_H
#define CONFIGUREDTASKAWAITABLE_1_T8F8087337FA5C6475CA153C95469983DDDED9F48_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<System.IO.Stream>
struct  ConfiguredTaskAwaitable_1_t8F8087337FA5C6475CA153C95469983DDDED9F48 
{
public:
	// System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1_ConfiguredTaskAwaiter<TResult> System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1::m_configuredTaskAwaiter
	ConfiguredTaskAwaiter_t27ECAA4B74502BD3AC7E68F47088D46DAA13D133  ___m_configuredTaskAwaiter_0;

public:
	inline static int32_t get_offset_of_m_configuredTaskAwaiter_0() { return static_cast<int32_t>(offsetof(ConfiguredTaskAwaitable_1_t8F8087337FA5C6475CA153C95469983DDDED9F48, ___m_configuredTaskAwaiter_0)); }
	inline ConfiguredTaskAwaiter_t27ECAA4B74502BD3AC7E68F47088D46DAA13D133  get_m_configuredTaskAwaiter_0() const { return ___m_configuredTaskAwaiter_0; }
	inline ConfiguredTaskAwaiter_t27ECAA4B74502BD3AC7E68F47088D46DAA13D133 * get_address_of_m_configuredTaskAwaiter_0() { return &___m_configuredTaskAwaiter_0; }
	inline void set_m_configuredTaskAwaiter_0(ConfiguredTaskAwaiter_t27ECAA4B74502BD3AC7E68F47088D46DAA13D133  value)
	{
		___m_configuredTaskAwaiter_0 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // CONFIGUREDTASKAWAITABLE_1_T8F8087337FA5C6475CA153C95469983DDDED9F48_H
#ifndef CONFIGUREDTASKAWAITABLE_1_TA36F8230F9392F8C09FD6FDBAEA3F1A41388CCA8_H
#define CONFIGUREDTASKAWAITABLE_1_TA36F8230F9392F8C09FD6FDBAEA3F1A41388CCA8_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<System.Object>
struct  ConfiguredTaskAwaitable_1_tA36F8230F9392F8C09FD6FDBAEA3F1A41388CCA8 
{
public:
	// System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1_ConfiguredTaskAwaiter<TResult> System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1::m_configuredTaskAwaiter
	ConfiguredTaskAwaiter_tFB3C4197768C6CF02BE088F703AA6E46D703D46E  ___m_configuredTaskAwaiter_0;

public:
	inline static int32_t get_offset_of_m_configuredTaskAwaiter_0() { return static_cast<int32_t>(offsetof(ConfiguredTaskAwaitable_1_tA36F8230F9392F8C09FD6FDBAEA3F1A41388CCA8, ___m_configuredTaskAwaiter_0)); }
	inline ConfiguredTaskAwaiter_tFB3C4197768C6CF02BE088F703AA6E46D703D46E  get_m_configuredTaskAwaiter_0() const { return ___m_configuredTaskAwaiter_0; }
	inline ConfiguredTaskAwaiter_tFB3C4197768C6CF02BE088F703AA6E46D703D46E * get_address_of_m_configuredTaskAwaiter_0() { return &___m_configuredTaskAwaiter_0; }
	inline void set_m_configuredTaskAwaiter_0(ConfiguredTaskAwaiter_tFB3C4197768C6CF02BE088F703AA6E46D703D46E  value)
	{
		___m_configuredTaskAwaiter_0 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // CONFIGUREDTASKAWAITABLE_1_TA36F8230F9392F8C09FD6FDBAEA3F1A41388CCA8_H
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
#ifndef TASK_T1F48C203E163126EBC69ACCA679D1A462DEE9EB2_H
#define TASK_T1F48C203E163126EBC69ACCA679D1A462DEE9EB2_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Threading.Tasks.Task
struct  Task_t1F48C203E163126EBC69ACCA679D1A462DEE9EB2  : public RuntimeObject
{
public:
	// System.Int32 modreq(System.Runtime.CompilerServices.IsVolatile) System.Threading.Tasks.Task::m_taskId
	int32_t ___m_taskId_4;
	// System.Object System.Threading.Tasks.Task::m_action
	RuntimeObject * ___m_action_5;
	// System.Object System.Threading.Tasks.Task::m_stateObject
	RuntimeObject * ___m_stateObject_6;
	// System.Threading.Tasks.TaskScheduler System.Threading.Tasks.Task::m_taskScheduler
	TaskScheduler_t966F2798F198FA90A0DA8EFC92BAC08297793114 * ___m_taskScheduler_7;
	// System.Threading.Tasks.Task System.Threading.Tasks.Task::m_parent
	Task_t1F48C203E163126EBC69ACCA679D1A462DEE9EB2 * ___m_parent_8;
	// System.Int32 modreq(System.Runtime.CompilerServices.IsVolatile) System.Threading.Tasks.Task::m_stateFlags
	int32_t ___m_stateFlags_9;
	// System.Object modreq(System.Runtime.CompilerServices.IsVolatile) System.Threading.Tasks.Task::m_continuationObject
	RuntimeObject * ___m_continuationObject_28;
	// System.Threading.Tasks.Task_ContingentProperties modreq(System.Runtime.CompilerServices.IsVolatile) System.Threading.Tasks.Task::m_contingentProperties
	ContingentProperties_t7149A27D01507C74E8BDAAA3848B45D2644FDF08 * ___m_contingentProperties_33;

public:
	inline static int32_t get_offset_of_m_taskId_4() { return static_cast<int32_t>(offsetof(Task_t1F48C203E163126EBC69ACCA679D1A462DEE9EB2, ___m_taskId_4)); }
	inline int32_t get_m_taskId_4() const { return ___m_taskId_4; }
	inline int32_t* get_address_of_m_taskId_4() { return &___m_taskId_4; }
	inline void set_m_taskId_4(int32_t value)
	{
		___m_taskId_4 = value;
	}

	inline static int32_t get_offset_of_m_action_5() { return static_cast<int32_t>(offsetof(Task_t1F48C203E163126EBC69ACCA679D1A462DEE9EB2, ___m_action_5)); }
	inline RuntimeObject * get_m_action_5() const { return ___m_action_5; }
	inline RuntimeObject ** get_address_of_m_action_5() { return &___m_action_5; }
	inline void set_m_action_5(RuntimeObject * value)
	{
		___m_action_5 = value;
		Il2CppCodeGenWriteBarrier((&___m_action_5), value);
	}

	inline static int32_t get_offset_of_m_stateObject_6() { return static_cast<int32_t>(offsetof(Task_t1F48C203E163126EBC69ACCA679D1A462DEE9EB2, ___m_stateObject_6)); }
	inline RuntimeObject * get_m_stateObject_6() const { return ___m_stateObject_6; }
	inline RuntimeObject ** get_address_of_m_stateObject_6() { return &___m_stateObject_6; }
	inline void set_m_stateObject_6(RuntimeObject * value)
	{
		___m_stateObject_6 = value;
		Il2CppCodeGenWriteBarrier((&___m_stateObject_6), value);
	}

	inline static int32_t get_offset_of_m_taskScheduler_7() { return static_cast<int32_t>(offsetof(Task_t1F48C203E163126EBC69ACCA679D1A462DEE9EB2, ___m_taskScheduler_7)); }
	inline TaskScheduler_t966F2798F198FA90A0DA8EFC92BAC08297793114 * get_m_taskScheduler_7() const { return ___m_taskScheduler_7; }
	inline TaskScheduler_t966F2798F198FA90A0DA8EFC92BAC08297793114 ** get_address_of_m_taskScheduler_7() { return &___m_taskScheduler_7; }
	inline void set_m_taskScheduler_7(TaskScheduler_t966F2798F198FA90A0DA8EFC92BAC08297793114 * value)
	{
		___m_taskScheduler_7 = value;
		Il2CppCodeGenWriteBarrier((&___m_taskScheduler_7), value);
	}

	inline static int32_t get_offset_of_m_parent_8() { return static_cast<int32_t>(offsetof(Task_t1F48C203E163126EBC69ACCA679D1A462DEE9EB2, ___m_parent_8)); }
	inline Task_t1F48C203E163126EBC69ACCA679D1A462DEE9EB2 * get_m_parent_8() const { return ___m_parent_8; }
	inline Task_t1F48C203E163126EBC69ACCA679D1A462DEE9EB2 ** get_address_of_m_parent_8() { return &___m_parent_8; }
	inline void set_m_parent_8(Task_t1F48C203E163126EBC69ACCA679D1A462DEE9EB2 * value)
	{
		___m_parent_8 = value;
		Il2CppCodeGenWriteBarrier((&___m_parent_8), value);
	}

	inline static int32_t get_offset_of_m_stateFlags_9() { return static_cast<int32_t>(offsetof(Task_t1F48C203E163126EBC69ACCA679D1A462DEE9EB2, ___m_stateFlags_9)); }
	inline int32_t get_m_stateFlags_9() const { return ___m_stateFlags_9; }
	inline int32_t* get_address_of_m_stateFlags_9() { return &___m_stateFlags_9; }
	inline void set_m_stateFlags_9(int32_t value)
	{
		___m_stateFlags_9 = value;
	}

	inline static int32_t get_offset_of_m_continuationObject_28() { return static_cast<int32_t>(offsetof(Task_t1F48C203E163126EBC69ACCA679D1A462DEE9EB2, ___m_continuationObject_28)); }
	inline RuntimeObject * get_m_continuationObject_28() const { return ___m_continuationObject_28; }
	inline RuntimeObject ** get_address_of_m_continuationObject_28() { return &___m_continuationObject_28; }
	inline void set_m_continuationObject_28(RuntimeObject * value)
	{
		___m_continuationObject_28 = value;
		Il2CppCodeGenWriteBarrier((&___m_continuationObject_28), value);
	}

	inline static int32_t get_offset_of_m_contingentProperties_33() { return static_cast<int32_t>(offsetof(Task_t1F48C203E163126EBC69ACCA679D1A462DEE9EB2, ___m_contingentProperties_33)); }
	inline ContingentProperties_t7149A27D01507C74E8BDAAA3848B45D2644FDF08 * get_m_contingentProperties_33() const { return ___m_contingentProperties_33; }
	inline ContingentProperties_t7149A27D01507C74E8BDAAA3848B45D2644FDF08 ** get_address_of_m_contingentProperties_33() { return &___m_contingentProperties_33; }
	inline void set_m_contingentProperties_33(ContingentProperties_t7149A27D01507C74E8BDAAA3848B45D2644FDF08 * value)
	{
		___m_contingentProperties_33 = value;
		Il2CppCodeGenWriteBarrier((&___m_contingentProperties_33), value);
	}
};

struct Task_t1F48C203E163126EBC69ACCA679D1A462DEE9EB2_StaticFields
{
public:
	// System.Int32 System.Threading.Tasks.Task::s_taskIdCounter
	int32_t ___s_taskIdCounter_2;
	// System.Threading.Tasks.TaskFactory System.Threading.Tasks.Task::s_factory
	TaskFactory_tF3C6D983390ACFB40B4979E225368F78006D6155 * ___s_factory_3;
	// System.Object System.Threading.Tasks.Task::s_taskCompletionSentinel
	RuntimeObject * ___s_taskCompletionSentinel_29;
	// System.Boolean System.Threading.Tasks.Task::s_asyncDebuggingEnabled
	bool ___s_asyncDebuggingEnabled_30;
	// System.Collections.Generic.Dictionary`2<System.Int32,System.Threading.Tasks.Task> System.Threading.Tasks.Task::s_currentActiveTasks
	Dictionary_2_t70161CFEB8DA3C79E19E31D0ED948D3C2925095F * ___s_currentActiveTasks_31;
	// System.Object System.Threading.Tasks.Task::s_activeTasksLock
	RuntimeObject * ___s_activeTasksLock_32;
	// System.Action`1<System.Object> System.Threading.Tasks.Task::s_taskCancelCallback
	Action_1_t551A279CEADCF6EEAE8FA2B1E1E757D0D15290D0 * ___s_taskCancelCallback_34;
	// System.Func`1<System.Threading.Tasks.Task_ContingentProperties> System.Threading.Tasks.Task::s_createContingentProperties
	Func_1_t48C2978A48CE3F2F6EB5B6DE269D00746483BB1F * ___s_createContingentProperties_35;
	// System.Threading.Tasks.Task System.Threading.Tasks.Task::s_completedTask
	Task_t1F48C203E163126EBC69ACCA679D1A462DEE9EB2 * ___s_completedTask_36;
	// System.Predicate`1<System.Threading.Tasks.Task> System.Threading.Tasks.Task::s_IsExceptionObservedByParentPredicate
	Predicate_1_tF4286C34BB184CE5690FDCEBA7F09FC68D229335 * ___s_IsExceptionObservedByParentPredicate_37;
	// System.Threading.ContextCallback System.Threading.Tasks.Task::s_ecCallback
	ContextCallback_t8AE8A965AC6C7ECD396F527F15CDC8E683BE1676 * ___s_ecCallback_38;
	// System.Predicate`1<System.Object> System.Threading.Tasks.Task::s_IsTaskContinuationNullPredicate
	Predicate_1_t4AA10EFD4C5497CA1CD0FE35A6AF5990FF5D0979 * ___s_IsTaskContinuationNullPredicate_39;

public:
	inline static int32_t get_offset_of_s_taskIdCounter_2() { return static_cast<int32_t>(offsetof(Task_t1F48C203E163126EBC69ACCA679D1A462DEE9EB2_StaticFields, ___s_taskIdCounter_2)); }
	inline int32_t get_s_taskIdCounter_2() const { return ___s_taskIdCounter_2; }
	inline int32_t* get_address_of_s_taskIdCounter_2() { return &___s_taskIdCounter_2; }
	inline void set_s_taskIdCounter_2(int32_t value)
	{
		___s_taskIdCounter_2 = value;
	}

	inline static int32_t get_offset_of_s_factory_3() { return static_cast<int32_t>(offsetof(Task_t1F48C203E163126EBC69ACCA679D1A462DEE9EB2_StaticFields, ___s_factory_3)); }
	inline TaskFactory_tF3C6D983390ACFB40B4979E225368F78006D6155 * get_s_factory_3() const { return ___s_factory_3; }
	inline TaskFactory_tF3C6D983390ACFB40B4979E225368F78006D6155 ** get_address_of_s_factory_3() { return &___s_factory_3; }
	inline void set_s_factory_3(TaskFactory_tF3C6D983390ACFB40B4979E225368F78006D6155 * value)
	{
		___s_factory_3 = value;
		Il2CppCodeGenWriteBarrier((&___s_factory_3), value);
	}

	inline static int32_t get_offset_of_s_taskCompletionSentinel_29() { return static_cast<int32_t>(offsetof(Task_t1F48C203E163126EBC69ACCA679D1A462DEE9EB2_StaticFields, ___s_taskCompletionSentinel_29)); }
	inline RuntimeObject * get_s_taskCompletionSentinel_29() const { return ___s_taskCompletionSentinel_29; }
	inline RuntimeObject ** get_address_of_s_taskCompletionSentinel_29() { return &___s_taskCompletionSentinel_29; }
	inline void set_s_taskCompletionSentinel_29(RuntimeObject * value)
	{
		___s_taskCompletionSentinel_29 = value;
		Il2CppCodeGenWriteBarrier((&___s_taskCompletionSentinel_29), value);
	}

	inline static int32_t get_offset_of_s_asyncDebuggingEnabled_30() { return static_cast<int32_t>(offsetof(Task_t1F48C203E163126EBC69ACCA679D1A462DEE9EB2_StaticFields, ___s_asyncDebuggingEnabled_30)); }
	inline bool get_s_asyncDebuggingEnabled_30() const { return ___s_asyncDebuggingEnabled_30; }
	inline bool* get_address_of_s_asyncDebuggingEnabled_30() { return &___s_asyncDebuggingEnabled_30; }
	inline void set_s_asyncDebuggingEnabled_30(bool value)
	{
		___s_asyncDebuggingEnabled_30 = value;
	}

	inline static int32_t get_offset_of_s_currentActiveTasks_31() { return static_cast<int32_t>(offsetof(Task_t1F48C203E163126EBC69ACCA679D1A462DEE9EB2_StaticFields, ___s_currentActiveTasks_31)); }
	inline Dictionary_2_t70161CFEB8DA3C79E19E31D0ED948D3C2925095F * get_s_currentActiveTasks_31() const { return ___s_currentActiveTasks_31; }
	inline Dictionary_2_t70161CFEB8DA3C79E19E31D0ED948D3C2925095F ** get_address_of_s_currentActiveTasks_31() { return &___s_currentActiveTasks_31; }
	inline void set_s_currentActiveTasks_31(Dictionary_2_t70161CFEB8DA3C79E19E31D0ED948D3C2925095F * value)
	{
		___s_currentActiveTasks_31 = value;
		Il2CppCodeGenWriteBarrier((&___s_currentActiveTasks_31), value);
	}

	inline static int32_t get_offset_of_s_activeTasksLock_32() { return static_cast<int32_t>(offsetof(Task_t1F48C203E163126EBC69ACCA679D1A462DEE9EB2_StaticFields, ___s_activeTasksLock_32)); }
	inline RuntimeObject * get_s_activeTasksLock_32() const { return ___s_activeTasksLock_32; }
	inline RuntimeObject ** get_address_of_s_activeTasksLock_32() { return &___s_activeTasksLock_32; }
	inline void set_s_activeTasksLock_32(RuntimeObject * value)
	{
		___s_activeTasksLock_32 = value;
		Il2CppCodeGenWriteBarrier((&___s_activeTasksLock_32), value);
	}

	inline static int32_t get_offset_of_s_taskCancelCallback_34() { return static_cast<int32_t>(offsetof(Task_t1F48C203E163126EBC69ACCA679D1A462DEE9EB2_StaticFields, ___s_taskCancelCallback_34)); }
	inline Action_1_t551A279CEADCF6EEAE8FA2B1E1E757D0D15290D0 * get_s_taskCancelCallback_34() const { return ___s_taskCancelCallback_34; }
	inline Action_1_t551A279CEADCF6EEAE8FA2B1E1E757D0D15290D0 ** get_address_of_s_taskCancelCallback_34() { return &___s_taskCancelCallback_34; }
	inline void set_s_taskCancelCallback_34(Action_1_t551A279CEADCF6EEAE8FA2B1E1E757D0D15290D0 * value)
	{
		___s_taskCancelCallback_34 = value;
		Il2CppCodeGenWriteBarrier((&___s_taskCancelCallback_34), value);
	}

	inline static int32_t get_offset_of_s_createContingentProperties_35() { return static_cast<int32_t>(offsetof(Task_t1F48C203E163126EBC69ACCA679D1A462DEE9EB2_StaticFields, ___s_createContingentProperties_35)); }
	inline Func_1_t48C2978A48CE3F2F6EB5B6DE269D00746483BB1F * get_s_createContingentProperties_35() const { return ___s_createContingentProperties_35; }
	inline Func_1_t48C2978A48CE3F2F6EB5B6DE269D00746483BB1F ** get_address_of_s_createContingentProperties_35() { return &___s_createContingentProperties_35; }
	inline void set_s_createContingentProperties_35(Func_1_t48C2978A48CE3F2F6EB5B6DE269D00746483BB1F * value)
	{
		___s_createContingentProperties_35 = value;
		Il2CppCodeGenWriteBarrier((&___s_createContingentProperties_35), value);
	}

	inline static int32_t get_offset_of_s_completedTask_36() { return static_cast<int32_t>(offsetof(Task_t1F48C203E163126EBC69ACCA679D1A462DEE9EB2_StaticFields, ___s_completedTask_36)); }
	inline Task_t1F48C203E163126EBC69ACCA679D1A462DEE9EB2 * get_s_completedTask_36() const { return ___s_completedTask_36; }
	inline Task_t1F48C203E163126EBC69ACCA679D1A462DEE9EB2 ** get_address_of_s_completedTask_36() { return &___s_completedTask_36; }
	inline void set_s_completedTask_36(Task_t1F48C203E163126EBC69ACCA679D1A462DEE9EB2 * value)
	{
		___s_completedTask_36 = value;
		Il2CppCodeGenWriteBarrier((&___s_completedTask_36), value);
	}

	inline static int32_t get_offset_of_s_IsExceptionObservedByParentPredicate_37() { return static_cast<int32_t>(offsetof(Task_t1F48C203E163126EBC69ACCA679D1A462DEE9EB2_StaticFields, ___s_IsExceptionObservedByParentPredicate_37)); }
	inline Predicate_1_tF4286C34BB184CE5690FDCEBA7F09FC68D229335 * get_s_IsExceptionObservedByParentPredicate_37() const { return ___s_IsExceptionObservedByParentPredicate_37; }
	inline Predicate_1_tF4286C34BB184CE5690FDCEBA7F09FC68D229335 ** get_address_of_s_IsExceptionObservedByParentPredicate_37() { return &___s_IsExceptionObservedByParentPredicate_37; }
	inline void set_s_IsExceptionObservedByParentPredicate_37(Predicate_1_tF4286C34BB184CE5690FDCEBA7F09FC68D229335 * value)
	{
		___s_IsExceptionObservedByParentPredicate_37 = value;
		Il2CppCodeGenWriteBarrier((&___s_IsExceptionObservedByParentPredicate_37), value);
	}

	inline static int32_t get_offset_of_s_ecCallback_38() { return static_cast<int32_t>(offsetof(Task_t1F48C203E163126EBC69ACCA679D1A462DEE9EB2_StaticFields, ___s_ecCallback_38)); }
	inline ContextCallback_t8AE8A965AC6C7ECD396F527F15CDC8E683BE1676 * get_s_ecCallback_38() const { return ___s_ecCallback_38; }
	inline ContextCallback_t8AE8A965AC6C7ECD396F527F15CDC8E683BE1676 ** get_address_of_s_ecCallback_38() { return &___s_ecCallback_38; }
	inline void set_s_ecCallback_38(ContextCallback_t8AE8A965AC6C7ECD396F527F15CDC8E683BE1676 * value)
	{
		___s_ecCallback_38 = value;
		Il2CppCodeGenWriteBarrier((&___s_ecCallback_38), value);
	}

	inline static int32_t get_offset_of_s_IsTaskContinuationNullPredicate_39() { return static_cast<int32_t>(offsetof(Task_t1F48C203E163126EBC69ACCA679D1A462DEE9EB2_StaticFields, ___s_IsTaskContinuationNullPredicate_39)); }
	inline Predicate_1_t4AA10EFD4C5497CA1CD0FE35A6AF5990FF5D0979 * get_s_IsTaskContinuationNullPredicate_39() const { return ___s_IsTaskContinuationNullPredicate_39; }
	inline Predicate_1_t4AA10EFD4C5497CA1CD0FE35A6AF5990FF5D0979 ** get_address_of_s_IsTaskContinuationNullPredicate_39() { return &___s_IsTaskContinuationNullPredicate_39; }
	inline void set_s_IsTaskContinuationNullPredicate_39(Predicate_1_t4AA10EFD4C5497CA1CD0FE35A6AF5990FF5D0979 * value)
	{
		___s_IsTaskContinuationNullPredicate_39 = value;
		Il2CppCodeGenWriteBarrier((&___s_IsTaskContinuationNullPredicate_39), value);
	}
};

struct Task_t1F48C203E163126EBC69ACCA679D1A462DEE9EB2_ThreadStaticFields
{
public:
	// System.Threading.Tasks.Task System.Threading.Tasks.Task::t_currentTask
	Task_t1F48C203E163126EBC69ACCA679D1A462DEE9EB2 * ___t_currentTask_0;
	// System.Threading.Tasks.StackGuard System.Threading.Tasks.Task::t_stackGuard
	StackGuard_tE431ED3BBD1A18705FEE6F948EBF7FA2E99D64A9 * ___t_stackGuard_1;

public:
	inline static int32_t get_offset_of_t_currentTask_0() { return static_cast<int32_t>(offsetof(Task_t1F48C203E163126EBC69ACCA679D1A462DEE9EB2_ThreadStaticFields, ___t_currentTask_0)); }
	inline Task_t1F48C203E163126EBC69ACCA679D1A462DEE9EB2 * get_t_currentTask_0() const { return ___t_currentTask_0; }
	inline Task_t1F48C203E163126EBC69ACCA679D1A462DEE9EB2 ** get_address_of_t_currentTask_0() { return &___t_currentTask_0; }
	inline void set_t_currentTask_0(Task_t1F48C203E163126EBC69ACCA679D1A462DEE9EB2 * value)
	{
		___t_currentTask_0 = value;
		Il2CppCodeGenWriteBarrier((&___t_currentTask_0), value);
	}

	inline static int32_t get_offset_of_t_stackGuard_1() { return static_cast<int32_t>(offsetof(Task_t1F48C203E163126EBC69ACCA679D1A462DEE9EB2_ThreadStaticFields, ___t_stackGuard_1)); }
	inline StackGuard_tE431ED3BBD1A18705FEE6F948EBF7FA2E99D64A9 * get_t_stackGuard_1() const { return ___t_stackGuard_1; }
	inline StackGuard_tE431ED3BBD1A18705FEE6F948EBF7FA2E99D64A9 ** get_address_of_t_stackGuard_1() { return &___t_stackGuard_1; }
	inline void set_t_stackGuard_1(StackGuard_tE431ED3BBD1A18705FEE6F948EBF7FA2E99D64A9 * value)
	{
		___t_stackGuard_1 = value;
		Il2CppCodeGenWriteBarrier((&___t_stackGuard_1), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // TASK_T1F48C203E163126EBC69ACCA679D1A462DEE9EB2_H
#ifndef FLAGS_TEBE7CABEBD13F16920D6950B384EB8F988250A2A_H
#define FLAGS_TEBE7CABEBD13F16920D6950B384EB8F988250A2A_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Uri_Flags
struct  Flags_tEBE7CABEBD13F16920D6950B384EB8F988250A2A 
{
public:
	// System.UInt64 System.Uri_Flags::value__
	uint64_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(Flags_tEBE7CABEBD13F16920D6950B384EB8F988250A2A, ___value___2)); }
	inline uint64_t get_value___2() const { return ___value___2; }
	inline uint64_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(uint64_t value)
	{
		___value___2 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // FLAGS_TEBE7CABEBD13F16920D6950B384EB8F988250A2A_H
#ifndef URIIDNSCOPE_TE1574B39C7492C761EFE2FC12DDE82DE013AC9D1_H
#define URIIDNSCOPE_TE1574B39C7492C761EFE2FC12DDE82DE013AC9D1_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.UriIdnScope
struct  UriIdnScope_tE1574B39C7492C761EFE2FC12DDE82DE013AC9D1 
{
public:
	// System.Int32 System.UriIdnScope::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(UriIdnScope_tE1574B39C7492C761EFE2FC12DDE82DE013AC9D1, ___value___2)); }
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
#endif // URIIDNSCOPE_TE1574B39C7492C761EFE2FC12DDE82DE013AC9D1_H
#ifndef DTDPROCESSING_TAB3B800A5365ED9C5841D71F40E5A38840D32DB3_H
#define DTDPROCESSING_TAB3B800A5365ED9C5841D71F40E5A38840D32DB3_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.DtdProcessing
struct  DtdProcessing_tAB3B800A5365ED9C5841D71F40E5A38840D32DB3 
{
public:
	// System.Int32 System.Xml.DtdProcessing::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(DtdProcessing_tAB3B800A5365ED9C5841D71F40E5A38840D32DB3, ___value___2)); }
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
#endif // DTDPROCESSING_TAB3B800A5365ED9C5841D71F40E5A38840D32DB3_H
#ifndef ENTITYHANDLING_T15C89E916C1AC46126DCF896A6317CE364B8F89B_H
#define ENTITYHANDLING_T15C89E916C1AC46126DCF896A6317CE364B8F89B_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.EntityHandling
struct  EntityHandling_t15C89E916C1AC46126DCF896A6317CE364B8F89B 
{
public:
	// System.Int32 System.Xml.EntityHandling::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(EntityHandling_t15C89E916C1AC46126DCF896A6317CE364B8F89B, ___value___2)); }
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
#endif // ENTITYHANDLING_T15C89E916C1AC46126DCF896A6317CE364B8F89B_H
#ifndef READSTATE_TAAF15D8DE96B6A22379D2B6FEF22764640D05DD0_H
#define READSTATE_TAAF15D8DE96B6A22379D2B6FEF22764640D05DD0_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.ReadState
struct  ReadState_tAAF15D8DE96B6A22379D2B6FEF22764640D05DD0 
{
public:
	// System.Int32 System.Xml.ReadState::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(ReadState_tAAF15D8DE96B6A22379D2B6FEF22764640D05DD0, ___value___2)); }
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
#endif // READSTATE_TAAF15D8DE96B6A22379D2B6FEF22764640D05DD0_H
#ifndef WHITESPACEHANDLING_T46A500512D84C27CBFB4580E40C5D583F4B149DC_H
#define WHITESPACEHANDLING_T46A500512D84C27CBFB4580E40C5D583F4B149DC_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.WhitespaceHandling
struct  WhitespaceHandling_t46A500512D84C27CBFB4580E40C5D583F4B149DC 
{
public:
	// System.Int32 System.Xml.WhitespaceHandling::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(WhitespaceHandling_t46A500512D84C27CBFB4580E40C5D583F4B149DC, ___value___2)); }
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
#endif // WHITESPACEHANDLING_T46A500512D84C27CBFB4580E40C5D583F4B149DC_H
#ifndef XMLCHARACTERDATA_TA7587D706680E42BD7A094F87CB0859C840A8531_H
#define XMLCHARACTERDATA_TA7587D706680E42BD7A094F87CB0859C840A8531_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.XmlCharacterData
struct  XmlCharacterData_tA7587D706680E42BD7A094F87CB0859C840A8531  : public XmlLinkedNode_t4F76C8580C2E6D2908D88AC84A86060FA9289A0E
{
public:
	// System.String System.Xml.XmlCharacterData::data
	String_t* ___data_2;

public:
	inline static int32_t get_offset_of_data_2() { return static_cast<int32_t>(offsetof(XmlCharacterData_tA7587D706680E42BD7A094F87CB0859C840A8531, ___data_2)); }
	inline String_t* get_data_2() const { return ___data_2; }
	inline String_t** get_address_of_data_2() { return &___data_2; }
	inline void set_data_2(String_t* value)
	{
		___data_2 = value;
		Il2CppCodeGenWriteBarrier((&___data_2), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // XMLCHARACTERDATA_TA7587D706680E42BD7A094F87CB0859C840A8531_H
#ifndef XMLEXCEPTION_TD7DA2CBE07488D18EE7A284862B7523E3CD4365D_H
#define XMLEXCEPTION_TD7DA2CBE07488D18EE7A284862B7523E3CD4365D_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.XmlException
struct  XmlException_tD7DA2CBE07488D18EE7A284862B7523E3CD4365D  : public SystemException_t5380468142AA850BE4A341D7AF3EAB9C78746782
{
public:
	// System.String System.Xml.XmlException::res
	String_t* ___res_17;
	// System.String[] System.Xml.XmlException::args
	StringU5BU5D_t933FB07893230EA91C40FF900D5400665E87B14E* ___args_18;
	// System.Int32 System.Xml.XmlException::lineNumber
	int32_t ___lineNumber_19;
	// System.Int32 System.Xml.XmlException::linePosition
	int32_t ___linePosition_20;
	// System.String System.Xml.XmlException::sourceUri
	String_t* ___sourceUri_21;
	// System.String System.Xml.XmlException::message
	String_t* ___message_22;

public:
	inline static int32_t get_offset_of_res_17() { return static_cast<int32_t>(offsetof(XmlException_tD7DA2CBE07488D18EE7A284862B7523E3CD4365D, ___res_17)); }
	inline String_t* get_res_17() const { return ___res_17; }
	inline String_t** get_address_of_res_17() { return &___res_17; }
	inline void set_res_17(String_t* value)
	{
		___res_17 = value;
		Il2CppCodeGenWriteBarrier((&___res_17), value);
	}

	inline static int32_t get_offset_of_args_18() { return static_cast<int32_t>(offsetof(XmlException_tD7DA2CBE07488D18EE7A284862B7523E3CD4365D, ___args_18)); }
	inline StringU5BU5D_t933FB07893230EA91C40FF900D5400665E87B14E* get_args_18() const { return ___args_18; }
	inline StringU5BU5D_t933FB07893230EA91C40FF900D5400665E87B14E** get_address_of_args_18() { return &___args_18; }
	inline void set_args_18(StringU5BU5D_t933FB07893230EA91C40FF900D5400665E87B14E* value)
	{
		___args_18 = value;
		Il2CppCodeGenWriteBarrier((&___args_18), value);
	}

	inline static int32_t get_offset_of_lineNumber_19() { return static_cast<int32_t>(offsetof(XmlException_tD7DA2CBE07488D18EE7A284862B7523E3CD4365D, ___lineNumber_19)); }
	inline int32_t get_lineNumber_19() const { return ___lineNumber_19; }
	inline int32_t* get_address_of_lineNumber_19() { return &___lineNumber_19; }
	inline void set_lineNumber_19(int32_t value)
	{
		___lineNumber_19 = value;
	}

	inline static int32_t get_offset_of_linePosition_20() { return static_cast<int32_t>(offsetof(XmlException_tD7DA2CBE07488D18EE7A284862B7523E3CD4365D, ___linePosition_20)); }
	inline int32_t get_linePosition_20() const { return ___linePosition_20; }
	inline int32_t* get_address_of_linePosition_20() { return &___linePosition_20; }
	inline void set_linePosition_20(int32_t value)
	{
		___linePosition_20 = value;
	}

	inline static int32_t get_offset_of_sourceUri_21() { return static_cast<int32_t>(offsetof(XmlException_tD7DA2CBE07488D18EE7A284862B7523E3CD4365D, ___sourceUri_21)); }
	inline String_t* get_sourceUri_21() const { return ___sourceUri_21; }
	inline String_t** get_address_of_sourceUri_21() { return &___sourceUri_21; }
	inline void set_sourceUri_21(String_t* value)
	{
		___sourceUri_21 = value;
		Il2CppCodeGenWriteBarrier((&___sourceUri_21), value);
	}

	inline static int32_t get_offset_of_message_22() { return static_cast<int32_t>(offsetof(XmlException_tD7DA2CBE07488D18EE7A284862B7523E3CD4365D, ___message_22)); }
	inline String_t* get_message_22() const { return ___message_22; }
	inline String_t** get_address_of_message_22() { return &___message_22; }
	inline void set_message_22(String_t* value)
	{
		___message_22 = value;
		Il2CppCodeGenWriteBarrier((&___message_22), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // XMLEXCEPTION_TD7DA2CBE07488D18EE7A284862B7523E3CD4365D_H
#ifndef XMLNODETYPE_TEE56AC4F9EC36B979516EA5836C4DA730B0A21E1_H
#define XMLNODETYPE_TEE56AC4F9EC36B979516EA5836C4DA730B0A21E1_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.XmlNodeType
struct  XmlNodeType_tEE56AC4F9EC36B979516EA5836C4DA730B0A21E1 
{
public:
	// System.Int32 System.Xml.XmlNodeType::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(XmlNodeType_tEE56AC4F9EC36B979516EA5836C4DA730B0A21E1, ___value___2)); }
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
#endif // XMLNODETYPE_TEE56AC4F9EC36B979516EA5836C4DA730B0A21E1_H
#ifndef XMLSPACE_TC1A644D65B6BE72CF02BA2687B5AE169713271AB_H
#define XMLSPACE_TC1A644D65B6BE72CF02BA2687B5AE169713271AB_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.XmlSpace
struct  XmlSpace_tC1A644D65B6BE72CF02BA2687B5AE169713271AB 
{
public:
	// System.Int32 System.Xml.XmlSpace::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(XmlSpace_tC1A644D65B6BE72CF02BA2687B5AE169713271AB, ___value___2)); }
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
#endif // XMLSPACE_TC1A644D65B6BE72CF02BA2687B5AE169713271AB_H
#ifndef ENTITYEXPANDTYPE_TC9953664AB0CE6F0813792286A9F3F6D6EF4A878_H
#define ENTITYEXPANDTYPE_TC9953664AB0CE6F0813792286A9F3F6D6EF4A878_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.XmlTextReaderImpl_EntityExpandType
struct  EntityExpandType_tC9953664AB0CE6F0813792286A9F3F6D6EF4A878 
{
public:
	// System.Int32 System.Xml.XmlTextReaderImpl_EntityExpandType::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(EntityExpandType_tC9953664AB0CE6F0813792286A9F3F6D6EF4A878, ___value___2)); }
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
#endif // ENTITYEXPANDTYPE_TC9953664AB0CE6F0813792286A9F3F6D6EF4A878_H
#ifndef ENTITYTYPE_TD1C5D0F2F43C096B07783E681D885A6F511F0657_H
#define ENTITYTYPE_TD1C5D0F2F43C096B07783E681D885A6F511F0657_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.XmlTextReaderImpl_EntityType
struct  EntityType_tD1C5D0F2F43C096B07783E681D885A6F511F0657 
{
public:
	// System.Int32 System.Xml.XmlTextReaderImpl_EntityType::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(EntityType_tD1C5D0F2F43C096B07783E681D885A6F511F0657, ___value___2)); }
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
#endif // ENTITYTYPE_TD1C5D0F2F43C096B07783E681D885A6F511F0657_H
#ifndef INCREMENTALREADSTATE_T9D04D5EB17C9FE284AD3C7D5F3BB74EAA765653C_H
#define INCREMENTALREADSTATE_T9D04D5EB17C9FE284AD3C7D5F3BB74EAA765653C_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.XmlTextReaderImpl_IncrementalReadState
struct  IncrementalReadState_t9D04D5EB17C9FE284AD3C7D5F3BB74EAA765653C 
{
public:
	// System.Int32 System.Xml.XmlTextReaderImpl_IncrementalReadState::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(IncrementalReadState_t9D04D5EB17C9FE284AD3C7D5F3BB74EAA765653C, ___value___2)); }
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
#endif // INCREMENTALREADSTATE_T9D04D5EB17C9FE284AD3C7D5F3BB74EAA765653C_H
#ifndef INITINPUTTYPE_TBF51CCB79B0C9D912C92528B2B8F1DBCC3649175_H
#define INITINPUTTYPE_TBF51CCB79B0C9D912C92528B2B8F1DBCC3649175_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.XmlTextReaderImpl_InitInputType
struct  InitInputType_tBF51CCB79B0C9D912C92528B2B8F1DBCC3649175 
{
public:
	// System.Int32 System.Xml.XmlTextReaderImpl_InitInputType::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(InitInputType_tBF51CCB79B0C9D912C92528B2B8F1DBCC3649175, ___value___2)); }
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
#endif // INITINPUTTYPE_TBF51CCB79B0C9D912C92528B2B8F1DBCC3649175_H
#ifndef PARSINGFUNCTION_T257574D1598B3E416A38FAB3204B4298FB2672B7_H
#define PARSINGFUNCTION_T257574D1598B3E416A38FAB3204B4298FB2672B7_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.XmlTextReaderImpl_ParsingFunction
struct  ParsingFunction_t257574D1598B3E416A38FAB3204B4298FB2672B7 
{
public:
	// System.Int32 System.Xml.XmlTextReaderImpl_ParsingFunction::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(ParsingFunction_t257574D1598B3E416A38FAB3204B4298FB2672B7, ___value___2)); }
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
#endif // PARSINGFUNCTION_T257574D1598B3E416A38FAB3204B4298FB2672B7_H
#ifndef PARSINGMODE_T16C9A13D4CD287424B850D09ABF6377BAA2A32EB_H
#define PARSINGMODE_T16C9A13D4CD287424B850D09ABF6377BAA2A32EB_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.XmlTextReaderImpl_ParsingMode
struct  ParsingMode_t16C9A13D4CD287424B850D09ABF6377BAA2A32EB 
{
public:
	// System.Int32 System.Xml.XmlTextReaderImpl_ParsingMode::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(ParsingMode_t16C9A13D4CD287424B850D09ABF6377BAA2A32EB, ___value___2)); }
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
#endif // PARSINGMODE_T16C9A13D4CD287424B850D09ABF6377BAA2A32EB_H
#ifndef XMLTOKENIZEDTYPE_T1D002F010C2E5CAC616DA28F4B39F7AAA2ADE4DA_H
#define XMLTOKENIZEDTYPE_T1D002F010C2E5CAC616DA28F4B39F7AAA2ADE4DA_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.XmlTokenizedType
struct  XmlTokenizedType_t1D002F010C2E5CAC616DA28F4B39F7AAA2ADE4DA 
{
public:
	// System.Int32 System.Xml.XmlTokenizedType::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(XmlTokenizedType_t1D002F010C2E5CAC616DA28F4B39F7AAA2ADE4DA, ___value___2)); }
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
#endif // XMLTOKENIZEDTYPE_T1D002F010C2E5CAC616DA28F4B39F7AAA2ADE4DA_H
#ifndef XMLUNSPECIFIEDATTRIBUTE_T1C82B285B60096D164B703202A8BD91A2009DE5D_H
#define XMLUNSPECIFIEDATTRIBUTE_T1C82B285B60096D164B703202A8BD91A2009DE5D_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.XmlUnspecifiedAttribute
struct  XmlUnspecifiedAttribute_t1C82B285B60096D164B703202A8BD91A2009DE5D  : public XmlAttribute_tEAB5F066D1D6965D6528617BD89826AE7114DEFA
{
public:
	// System.Boolean System.Xml.XmlUnspecifiedAttribute::fSpecified
	bool ___fSpecified_3;

public:
	inline static int32_t get_offset_of_fSpecified_3() { return static_cast<int32_t>(offsetof(XmlUnspecifiedAttribute_t1C82B285B60096D164B703202A8BD91A2009DE5D, ___fSpecified_3)); }
	inline bool get_fSpecified_3() const { return ___fSpecified_3; }
	inline bool* get_address_of_fSpecified_3() { return &___fSpecified_3; }
	inline void set_fSpecified_3(bool value)
	{
		___fSpecified_3 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // XMLUNSPECIFIEDATTRIBUTE_T1C82B285B60096D164B703202A8BD91A2009DE5D_H
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
#ifndef REQUESTCACHEPOLICY_T30D7352C7E9D49EEADD492A70EC92C118D90CD61_H
#define REQUESTCACHEPOLICY_T30D7352C7E9D49EEADD492A70EC92C118D90CD61_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Net.Cache.RequestCachePolicy
struct  RequestCachePolicy_t30D7352C7E9D49EEADD492A70EC92C118D90CD61  : public RuntimeObject
{
public:
	// System.Net.Cache.RequestCacheLevel System.Net.Cache.RequestCachePolicy::m_Level
	int32_t ___m_Level_0;

public:
	inline static int32_t get_offset_of_m_Level_0() { return static_cast<int32_t>(offsetof(RequestCachePolicy_t30D7352C7E9D49EEADD492A70EC92C118D90CD61, ___m_Level_0)); }
	inline int32_t get_m_Level_0() const { return ___m_Level_0; }
	inline int32_t* get_address_of_m_Level_0() { return &___m_Level_0; }
	inline void set_m_Level_0(int32_t value)
	{
		___m_Level_0 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // REQUESTCACHEPOLICY_T30D7352C7E9D49EEADD492A70EC92C118D90CD61_H
#ifndef TASK_1_TAA7557E5A6A8B2C89E44907CB5B0502A618E9D01_H
#define TASK_1_TAA7557E5A6A8B2C89E44907CB5B0502A618E9D01_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Threading.Tasks.Task`1<System.IO.Stream>
struct  Task_1_tAA7557E5A6A8B2C89E44907CB5B0502A618E9D01  : public Task_t1F48C203E163126EBC69ACCA679D1A462DEE9EB2
{
public:
	// TResult System.Threading.Tasks.Task`1::m_result
	Stream_tFC50657DD5AAB87770987F9179D934A51D99D5E7 * ___m_result_40;

public:
	inline static int32_t get_offset_of_m_result_40() { return static_cast<int32_t>(offsetof(Task_1_tAA7557E5A6A8B2C89E44907CB5B0502A618E9D01, ___m_result_40)); }
	inline Stream_tFC50657DD5AAB87770987F9179D934A51D99D5E7 * get_m_result_40() const { return ___m_result_40; }
	inline Stream_tFC50657DD5AAB87770987F9179D934A51D99D5E7 ** get_address_of_m_result_40() { return &___m_result_40; }
	inline void set_m_result_40(Stream_tFC50657DD5AAB87770987F9179D934A51D99D5E7 * value)
	{
		___m_result_40 = value;
		Il2CppCodeGenWriteBarrier((&___m_result_40), value);
	}
};

struct Task_1_tAA7557E5A6A8B2C89E44907CB5B0502A618E9D01_StaticFields
{
public:
	// System.Threading.Tasks.TaskFactory`1<TResult> System.Threading.Tasks.Task`1::s_Factory
	TaskFactory_1_tE7B6DC2F22643759D47ED49CDDBD8C35D9383D8F * ___s_Factory_41;
	// System.Func`2<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task`1<TResult>> System.Threading.Tasks.Task`1::TaskWhenAnyCast
	Func_2_t97AE46232676B6C4CB84D0101A45061F2288FCE5 * ___TaskWhenAnyCast_42;

public:
	inline static int32_t get_offset_of_s_Factory_41() { return static_cast<int32_t>(offsetof(Task_1_tAA7557E5A6A8B2C89E44907CB5B0502A618E9D01_StaticFields, ___s_Factory_41)); }
	inline TaskFactory_1_tE7B6DC2F22643759D47ED49CDDBD8C35D9383D8F * get_s_Factory_41() const { return ___s_Factory_41; }
	inline TaskFactory_1_tE7B6DC2F22643759D47ED49CDDBD8C35D9383D8F ** get_address_of_s_Factory_41() { return &___s_Factory_41; }
	inline void set_s_Factory_41(TaskFactory_1_tE7B6DC2F22643759D47ED49CDDBD8C35D9383D8F * value)
	{
		___s_Factory_41 = value;
		Il2CppCodeGenWriteBarrier((&___s_Factory_41), value);
	}

	inline static int32_t get_offset_of_TaskWhenAnyCast_42() { return static_cast<int32_t>(offsetof(Task_1_tAA7557E5A6A8B2C89E44907CB5B0502A618E9D01_StaticFields, ___TaskWhenAnyCast_42)); }
	inline Func_2_t97AE46232676B6C4CB84D0101A45061F2288FCE5 * get_TaskWhenAnyCast_42() const { return ___TaskWhenAnyCast_42; }
	inline Func_2_t97AE46232676B6C4CB84D0101A45061F2288FCE5 ** get_address_of_TaskWhenAnyCast_42() { return &___TaskWhenAnyCast_42; }
	inline void set_TaskWhenAnyCast_42(Func_2_t97AE46232676B6C4CB84D0101A45061F2288FCE5 * value)
	{
		___TaskWhenAnyCast_42 = value;
		Il2CppCodeGenWriteBarrier((&___TaskWhenAnyCast_42), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // TASK_1_TAA7557E5A6A8B2C89E44907CB5B0502A618E9D01_H
#ifndef TASK_1_TA56001ED5270173CA1432EDFCD84EABB1024BC09_H
#define TASK_1_TA56001ED5270173CA1432EDFCD84EABB1024BC09_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Threading.Tasks.Task`1<System.Object>
struct  Task_1_tA56001ED5270173CA1432EDFCD84EABB1024BC09  : public Task_t1F48C203E163126EBC69ACCA679D1A462DEE9EB2
{
public:
	// TResult System.Threading.Tasks.Task`1::m_result
	RuntimeObject * ___m_result_40;

public:
	inline static int32_t get_offset_of_m_result_40() { return static_cast<int32_t>(offsetof(Task_1_tA56001ED5270173CA1432EDFCD84EABB1024BC09, ___m_result_40)); }
	inline RuntimeObject * get_m_result_40() const { return ___m_result_40; }
	inline RuntimeObject ** get_address_of_m_result_40() { return &___m_result_40; }
	inline void set_m_result_40(RuntimeObject * value)
	{
		___m_result_40 = value;
		Il2CppCodeGenWriteBarrier((&___m_result_40), value);
	}
};

struct Task_1_tA56001ED5270173CA1432EDFCD84EABB1024BC09_StaticFields
{
public:
	// System.Threading.Tasks.TaskFactory`1<TResult> System.Threading.Tasks.Task`1::s_Factory
	TaskFactory_1_tA50D9207CAE2C505277DD5F03CBE64700177257C * ___s_Factory_41;
	// System.Func`2<System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>,System.Threading.Tasks.Task`1<TResult>> System.Threading.Tasks.Task`1::TaskWhenAnyCast
	Func_2_tDAE4310E42C13AE378CDF0371BD31D6BF4E61EBD * ___TaskWhenAnyCast_42;

public:
	inline static int32_t get_offset_of_s_Factory_41() { return static_cast<int32_t>(offsetof(Task_1_tA56001ED5270173CA1432EDFCD84EABB1024BC09_StaticFields, ___s_Factory_41)); }
	inline TaskFactory_1_tA50D9207CAE2C505277DD5F03CBE64700177257C * get_s_Factory_41() const { return ___s_Factory_41; }
	inline TaskFactory_1_tA50D9207CAE2C505277DD5F03CBE64700177257C ** get_address_of_s_Factory_41() { return &___s_Factory_41; }
	inline void set_s_Factory_41(TaskFactory_1_tA50D9207CAE2C505277DD5F03CBE64700177257C * value)
	{
		___s_Factory_41 = value;
		Il2CppCodeGenWriteBarrier((&___s_Factory_41), value);
	}

	inline static int32_t get_offset_of_TaskWhenAnyCast_42() { return static_cast<int32_t>(offsetof(Task_1_tA56001ED5270173CA1432EDFCD84EABB1024BC09_StaticFields, ___TaskWhenAnyCast_42)); }
	inline Func_2_tDAE4310E42C13AE378CDF0371BD31D6BF4E61EBD * get_TaskWhenAnyCast_42() const { return ___TaskWhenAnyCast_42; }
	inline Func_2_tDAE4310E42C13AE378CDF0371BD31D6BF4E61EBD ** get_address_of_TaskWhenAnyCast_42() { return &___TaskWhenAnyCast_42; }
	inline void set_TaskWhenAnyCast_42(Func_2_tDAE4310E42C13AE378CDF0371BD31D6BF4E61EBD * value)
	{
		___TaskWhenAnyCast_42 = value;
		Il2CppCodeGenWriteBarrier((&___TaskWhenAnyCast_42), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // TASK_1_TA56001ED5270173CA1432EDFCD84EABB1024BC09_H
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
#ifndef URI_T87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E_H
#define URI_T87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Uri
struct  Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E  : public RuntimeObject
{
public:
	// System.String System.Uri::m_String
	String_t* ___m_String_13;
	// System.String System.Uri::m_originalUnicodeString
	String_t* ___m_originalUnicodeString_14;
	// System.UriParser System.Uri::m_Syntax
	UriParser_t07C77D673CCE8D2DA253B8A7ACCB010147F1A4AC * ___m_Syntax_15;
	// System.String System.Uri::m_DnsSafeHost
	String_t* ___m_DnsSafeHost_16;
	// System.Uri_Flags System.Uri::m_Flags
	uint64_t ___m_Flags_17;
	// System.Uri_UriInfo System.Uri::m_Info
	UriInfo_t9FCC6BD4EC1EA14D75209E6A35417057BF6EDC5E * ___m_Info_18;
	// System.Boolean System.Uri::m_iriParsing
	bool ___m_iriParsing_19;

public:
	inline static int32_t get_offset_of_m_String_13() { return static_cast<int32_t>(offsetof(Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E, ___m_String_13)); }
	inline String_t* get_m_String_13() const { return ___m_String_13; }
	inline String_t** get_address_of_m_String_13() { return &___m_String_13; }
	inline void set_m_String_13(String_t* value)
	{
		___m_String_13 = value;
		Il2CppCodeGenWriteBarrier((&___m_String_13), value);
	}

	inline static int32_t get_offset_of_m_originalUnicodeString_14() { return static_cast<int32_t>(offsetof(Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E, ___m_originalUnicodeString_14)); }
	inline String_t* get_m_originalUnicodeString_14() const { return ___m_originalUnicodeString_14; }
	inline String_t** get_address_of_m_originalUnicodeString_14() { return &___m_originalUnicodeString_14; }
	inline void set_m_originalUnicodeString_14(String_t* value)
	{
		___m_originalUnicodeString_14 = value;
		Il2CppCodeGenWriteBarrier((&___m_originalUnicodeString_14), value);
	}

	inline static int32_t get_offset_of_m_Syntax_15() { return static_cast<int32_t>(offsetof(Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E, ___m_Syntax_15)); }
	inline UriParser_t07C77D673CCE8D2DA253B8A7ACCB010147F1A4AC * get_m_Syntax_15() const { return ___m_Syntax_15; }
	inline UriParser_t07C77D673CCE8D2DA253B8A7ACCB010147F1A4AC ** get_address_of_m_Syntax_15() { return &___m_Syntax_15; }
	inline void set_m_Syntax_15(UriParser_t07C77D673CCE8D2DA253B8A7ACCB010147F1A4AC * value)
	{
		___m_Syntax_15 = value;
		Il2CppCodeGenWriteBarrier((&___m_Syntax_15), value);
	}

	inline static int32_t get_offset_of_m_DnsSafeHost_16() { return static_cast<int32_t>(offsetof(Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E, ___m_DnsSafeHost_16)); }
	inline String_t* get_m_DnsSafeHost_16() const { return ___m_DnsSafeHost_16; }
	inline String_t** get_address_of_m_DnsSafeHost_16() { return &___m_DnsSafeHost_16; }
	inline void set_m_DnsSafeHost_16(String_t* value)
	{
		___m_DnsSafeHost_16 = value;
		Il2CppCodeGenWriteBarrier((&___m_DnsSafeHost_16), value);
	}

	inline static int32_t get_offset_of_m_Flags_17() { return static_cast<int32_t>(offsetof(Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E, ___m_Flags_17)); }
	inline uint64_t get_m_Flags_17() const { return ___m_Flags_17; }
	inline uint64_t* get_address_of_m_Flags_17() { return &___m_Flags_17; }
	inline void set_m_Flags_17(uint64_t value)
	{
		___m_Flags_17 = value;
	}

	inline static int32_t get_offset_of_m_Info_18() { return static_cast<int32_t>(offsetof(Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E, ___m_Info_18)); }
	inline UriInfo_t9FCC6BD4EC1EA14D75209E6A35417057BF6EDC5E * get_m_Info_18() const { return ___m_Info_18; }
	inline UriInfo_t9FCC6BD4EC1EA14D75209E6A35417057BF6EDC5E ** get_address_of_m_Info_18() { return &___m_Info_18; }
	inline void set_m_Info_18(UriInfo_t9FCC6BD4EC1EA14D75209E6A35417057BF6EDC5E * value)
	{
		___m_Info_18 = value;
		Il2CppCodeGenWriteBarrier((&___m_Info_18), value);
	}

	inline static int32_t get_offset_of_m_iriParsing_19() { return static_cast<int32_t>(offsetof(Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E, ___m_iriParsing_19)); }
	inline bool get_m_iriParsing_19() const { return ___m_iriParsing_19; }
	inline bool* get_address_of_m_iriParsing_19() { return &___m_iriParsing_19; }
	inline void set_m_iriParsing_19(bool value)
	{
		___m_iriParsing_19 = value;
	}
};

struct Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E_StaticFields
{
public:
	// System.String System.Uri::UriSchemeFile
	String_t* ___UriSchemeFile_0;
	// System.String System.Uri::UriSchemeFtp
	String_t* ___UriSchemeFtp_1;
	// System.String System.Uri::UriSchemeGopher
	String_t* ___UriSchemeGopher_2;
	// System.String System.Uri::UriSchemeHttp
	String_t* ___UriSchemeHttp_3;
	// System.String System.Uri::UriSchemeHttps
	String_t* ___UriSchemeHttps_4;
	// System.String System.Uri::UriSchemeWs
	String_t* ___UriSchemeWs_5;
	// System.String System.Uri::UriSchemeWss
	String_t* ___UriSchemeWss_6;
	// System.String System.Uri::UriSchemeMailto
	String_t* ___UriSchemeMailto_7;
	// System.String System.Uri::UriSchemeNews
	String_t* ___UriSchemeNews_8;
	// System.String System.Uri::UriSchemeNntp
	String_t* ___UriSchemeNntp_9;
	// System.String System.Uri::UriSchemeNetTcp
	String_t* ___UriSchemeNetTcp_10;
	// System.String System.Uri::UriSchemeNetPipe
	String_t* ___UriSchemeNetPipe_11;
	// System.String System.Uri::SchemeDelimiter
	String_t* ___SchemeDelimiter_12;
	// System.Boolean modreq(System.Runtime.CompilerServices.IsVolatile) System.Uri::s_ConfigInitialized
	bool ___s_ConfigInitialized_20;
	// System.Boolean modreq(System.Runtime.CompilerServices.IsVolatile) System.Uri::s_ConfigInitializing
	bool ___s_ConfigInitializing_21;
	// System.UriIdnScope modreq(System.Runtime.CompilerServices.IsVolatile) System.Uri::s_IdnScope
	int32_t ___s_IdnScope_22;
	// System.Boolean modreq(System.Runtime.CompilerServices.IsVolatile) System.Uri::s_IriParsing
	bool ___s_IriParsing_23;
	// System.Boolean System.Uri::useDotNetRelativeOrAbsolute
	bool ___useDotNetRelativeOrAbsolute_24;
	// System.Boolean System.Uri::IsWindowsFileSystem
	bool ___IsWindowsFileSystem_25;
	// System.Object System.Uri::s_initLock
	RuntimeObject * ___s_initLock_26;
	// System.Char[] System.Uri::HexLowerChars
	CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2* ___HexLowerChars_27;
	// System.Char[] System.Uri::_WSchars
	CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2* ____WSchars_28;

public:
	inline static int32_t get_offset_of_UriSchemeFile_0() { return static_cast<int32_t>(offsetof(Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E_StaticFields, ___UriSchemeFile_0)); }
	inline String_t* get_UriSchemeFile_0() const { return ___UriSchemeFile_0; }
	inline String_t** get_address_of_UriSchemeFile_0() { return &___UriSchemeFile_0; }
	inline void set_UriSchemeFile_0(String_t* value)
	{
		___UriSchemeFile_0 = value;
		Il2CppCodeGenWriteBarrier((&___UriSchemeFile_0), value);
	}

	inline static int32_t get_offset_of_UriSchemeFtp_1() { return static_cast<int32_t>(offsetof(Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E_StaticFields, ___UriSchemeFtp_1)); }
	inline String_t* get_UriSchemeFtp_1() const { return ___UriSchemeFtp_1; }
	inline String_t** get_address_of_UriSchemeFtp_1() { return &___UriSchemeFtp_1; }
	inline void set_UriSchemeFtp_1(String_t* value)
	{
		___UriSchemeFtp_1 = value;
		Il2CppCodeGenWriteBarrier((&___UriSchemeFtp_1), value);
	}

	inline static int32_t get_offset_of_UriSchemeGopher_2() { return static_cast<int32_t>(offsetof(Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E_StaticFields, ___UriSchemeGopher_2)); }
	inline String_t* get_UriSchemeGopher_2() const { return ___UriSchemeGopher_2; }
	inline String_t** get_address_of_UriSchemeGopher_2() { return &___UriSchemeGopher_2; }
	inline void set_UriSchemeGopher_2(String_t* value)
	{
		___UriSchemeGopher_2 = value;
		Il2CppCodeGenWriteBarrier((&___UriSchemeGopher_2), value);
	}

	inline static int32_t get_offset_of_UriSchemeHttp_3() { return static_cast<int32_t>(offsetof(Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E_StaticFields, ___UriSchemeHttp_3)); }
	inline String_t* get_UriSchemeHttp_3() const { return ___UriSchemeHttp_3; }
	inline String_t** get_address_of_UriSchemeHttp_3() { return &___UriSchemeHttp_3; }
	inline void set_UriSchemeHttp_3(String_t* value)
	{
		___UriSchemeHttp_3 = value;
		Il2CppCodeGenWriteBarrier((&___UriSchemeHttp_3), value);
	}

	inline static int32_t get_offset_of_UriSchemeHttps_4() { return static_cast<int32_t>(offsetof(Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E_StaticFields, ___UriSchemeHttps_4)); }
	inline String_t* get_UriSchemeHttps_4() const { return ___UriSchemeHttps_4; }
	inline String_t** get_address_of_UriSchemeHttps_4() { return &___UriSchemeHttps_4; }
	inline void set_UriSchemeHttps_4(String_t* value)
	{
		___UriSchemeHttps_4 = value;
		Il2CppCodeGenWriteBarrier((&___UriSchemeHttps_4), value);
	}

	inline static int32_t get_offset_of_UriSchemeWs_5() { return static_cast<int32_t>(offsetof(Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E_StaticFields, ___UriSchemeWs_5)); }
	inline String_t* get_UriSchemeWs_5() const { return ___UriSchemeWs_5; }
	inline String_t** get_address_of_UriSchemeWs_5() { return &___UriSchemeWs_5; }
	inline void set_UriSchemeWs_5(String_t* value)
	{
		___UriSchemeWs_5 = value;
		Il2CppCodeGenWriteBarrier((&___UriSchemeWs_5), value);
	}

	inline static int32_t get_offset_of_UriSchemeWss_6() { return static_cast<int32_t>(offsetof(Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E_StaticFields, ___UriSchemeWss_6)); }
	inline String_t* get_UriSchemeWss_6() const { return ___UriSchemeWss_6; }
	inline String_t** get_address_of_UriSchemeWss_6() { return &___UriSchemeWss_6; }
	inline void set_UriSchemeWss_6(String_t* value)
	{
		___UriSchemeWss_6 = value;
		Il2CppCodeGenWriteBarrier((&___UriSchemeWss_6), value);
	}

	inline static int32_t get_offset_of_UriSchemeMailto_7() { return static_cast<int32_t>(offsetof(Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E_StaticFields, ___UriSchemeMailto_7)); }
	inline String_t* get_UriSchemeMailto_7() const { return ___UriSchemeMailto_7; }
	inline String_t** get_address_of_UriSchemeMailto_7() { return &___UriSchemeMailto_7; }
	inline void set_UriSchemeMailto_7(String_t* value)
	{
		___UriSchemeMailto_7 = value;
		Il2CppCodeGenWriteBarrier((&___UriSchemeMailto_7), value);
	}

	inline static int32_t get_offset_of_UriSchemeNews_8() { return static_cast<int32_t>(offsetof(Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E_StaticFields, ___UriSchemeNews_8)); }
	inline String_t* get_UriSchemeNews_8() const { return ___UriSchemeNews_8; }
	inline String_t** get_address_of_UriSchemeNews_8() { return &___UriSchemeNews_8; }
	inline void set_UriSchemeNews_8(String_t* value)
	{
		___UriSchemeNews_8 = value;
		Il2CppCodeGenWriteBarrier((&___UriSchemeNews_8), value);
	}

	inline static int32_t get_offset_of_UriSchemeNntp_9() { return static_cast<int32_t>(offsetof(Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E_StaticFields, ___UriSchemeNntp_9)); }
	inline String_t* get_UriSchemeNntp_9() const { return ___UriSchemeNntp_9; }
	inline String_t** get_address_of_UriSchemeNntp_9() { return &___UriSchemeNntp_9; }
	inline void set_UriSchemeNntp_9(String_t* value)
	{
		___UriSchemeNntp_9 = value;
		Il2CppCodeGenWriteBarrier((&___UriSchemeNntp_9), value);
	}

	inline static int32_t get_offset_of_UriSchemeNetTcp_10() { return static_cast<int32_t>(offsetof(Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E_StaticFields, ___UriSchemeNetTcp_10)); }
	inline String_t* get_UriSchemeNetTcp_10() const { return ___UriSchemeNetTcp_10; }
	inline String_t** get_address_of_UriSchemeNetTcp_10() { return &___UriSchemeNetTcp_10; }
	inline void set_UriSchemeNetTcp_10(String_t* value)
	{
		___UriSchemeNetTcp_10 = value;
		Il2CppCodeGenWriteBarrier((&___UriSchemeNetTcp_10), value);
	}

	inline static int32_t get_offset_of_UriSchemeNetPipe_11() { return static_cast<int32_t>(offsetof(Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E_StaticFields, ___UriSchemeNetPipe_11)); }
	inline String_t* get_UriSchemeNetPipe_11() const { return ___UriSchemeNetPipe_11; }
	inline String_t** get_address_of_UriSchemeNetPipe_11() { return &___UriSchemeNetPipe_11; }
	inline void set_UriSchemeNetPipe_11(String_t* value)
	{
		___UriSchemeNetPipe_11 = value;
		Il2CppCodeGenWriteBarrier((&___UriSchemeNetPipe_11), value);
	}

	inline static int32_t get_offset_of_SchemeDelimiter_12() { return static_cast<int32_t>(offsetof(Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E_StaticFields, ___SchemeDelimiter_12)); }
	inline String_t* get_SchemeDelimiter_12() const { return ___SchemeDelimiter_12; }
	inline String_t** get_address_of_SchemeDelimiter_12() { return &___SchemeDelimiter_12; }
	inline void set_SchemeDelimiter_12(String_t* value)
	{
		___SchemeDelimiter_12 = value;
		Il2CppCodeGenWriteBarrier((&___SchemeDelimiter_12), value);
	}

	inline static int32_t get_offset_of_s_ConfigInitialized_20() { return static_cast<int32_t>(offsetof(Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E_StaticFields, ___s_ConfigInitialized_20)); }
	inline bool get_s_ConfigInitialized_20() const { return ___s_ConfigInitialized_20; }
	inline bool* get_address_of_s_ConfigInitialized_20() { return &___s_ConfigInitialized_20; }
	inline void set_s_ConfigInitialized_20(bool value)
	{
		___s_ConfigInitialized_20 = value;
	}

	inline static int32_t get_offset_of_s_ConfigInitializing_21() { return static_cast<int32_t>(offsetof(Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E_StaticFields, ___s_ConfigInitializing_21)); }
	inline bool get_s_ConfigInitializing_21() const { return ___s_ConfigInitializing_21; }
	inline bool* get_address_of_s_ConfigInitializing_21() { return &___s_ConfigInitializing_21; }
	inline void set_s_ConfigInitializing_21(bool value)
	{
		___s_ConfigInitializing_21 = value;
	}

	inline static int32_t get_offset_of_s_IdnScope_22() { return static_cast<int32_t>(offsetof(Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E_StaticFields, ___s_IdnScope_22)); }
	inline int32_t get_s_IdnScope_22() const { return ___s_IdnScope_22; }
	inline int32_t* get_address_of_s_IdnScope_22() { return &___s_IdnScope_22; }
	inline void set_s_IdnScope_22(int32_t value)
	{
		___s_IdnScope_22 = value;
	}

	inline static int32_t get_offset_of_s_IriParsing_23() { return static_cast<int32_t>(offsetof(Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E_StaticFields, ___s_IriParsing_23)); }
	inline bool get_s_IriParsing_23() const { return ___s_IriParsing_23; }
	inline bool* get_address_of_s_IriParsing_23() { return &___s_IriParsing_23; }
	inline void set_s_IriParsing_23(bool value)
	{
		___s_IriParsing_23 = value;
	}

	inline static int32_t get_offset_of_useDotNetRelativeOrAbsolute_24() { return static_cast<int32_t>(offsetof(Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E_StaticFields, ___useDotNetRelativeOrAbsolute_24)); }
	inline bool get_useDotNetRelativeOrAbsolute_24() const { return ___useDotNetRelativeOrAbsolute_24; }
	inline bool* get_address_of_useDotNetRelativeOrAbsolute_24() { return &___useDotNetRelativeOrAbsolute_24; }
	inline void set_useDotNetRelativeOrAbsolute_24(bool value)
	{
		___useDotNetRelativeOrAbsolute_24 = value;
	}

	inline static int32_t get_offset_of_IsWindowsFileSystem_25() { return static_cast<int32_t>(offsetof(Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E_StaticFields, ___IsWindowsFileSystem_25)); }
	inline bool get_IsWindowsFileSystem_25() const { return ___IsWindowsFileSystem_25; }
	inline bool* get_address_of_IsWindowsFileSystem_25() { return &___IsWindowsFileSystem_25; }
	inline void set_IsWindowsFileSystem_25(bool value)
	{
		___IsWindowsFileSystem_25 = value;
	}

	inline static int32_t get_offset_of_s_initLock_26() { return static_cast<int32_t>(offsetof(Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E_StaticFields, ___s_initLock_26)); }
	inline RuntimeObject * get_s_initLock_26() const { return ___s_initLock_26; }
	inline RuntimeObject ** get_address_of_s_initLock_26() { return &___s_initLock_26; }
	inline void set_s_initLock_26(RuntimeObject * value)
	{
		___s_initLock_26 = value;
		Il2CppCodeGenWriteBarrier((&___s_initLock_26), value);
	}

	inline static int32_t get_offset_of_HexLowerChars_27() { return static_cast<int32_t>(offsetof(Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E_StaticFields, ___HexLowerChars_27)); }
	inline CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2* get_HexLowerChars_27() const { return ___HexLowerChars_27; }
	inline CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2** get_address_of_HexLowerChars_27() { return &___HexLowerChars_27; }
	inline void set_HexLowerChars_27(CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2* value)
	{
		___HexLowerChars_27 = value;
		Il2CppCodeGenWriteBarrier((&___HexLowerChars_27), value);
	}

	inline static int32_t get_offset_of__WSchars_28() { return static_cast<int32_t>(offsetof(Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E_StaticFields, ____WSchars_28)); }
	inline CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2* get__WSchars_28() const { return ____WSchars_28; }
	inline CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2** get_address_of__WSchars_28() { return &____WSchars_28; }
	inline void set__WSchars_28(CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2* value)
	{
		____WSchars_28 = value;
		Il2CppCodeGenWriteBarrier((&____WSchars_28), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // URI_T87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E_H
#ifndef XMLTEXTREADERIMPL_T393737BE3F9168D966F164C2FD840C3494DEDE61_H
#define XMLTEXTREADERIMPL_T393737BE3F9168D966F164C2FD840C3494DEDE61_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.XmlTextReaderImpl
struct  XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61  : public XmlReader_t13F08E3C651EB9F2AE882342BCD5E2CA86F29ABB
{
public:
	// System.Xml.XmlTextReaderImpl_LaterInitParam System.Xml.XmlTextReaderImpl::laterInitParam
	LaterInitParam_tE2FFFA55A2C7B183721762B4AC4B0DF93485A1AF * ___laterInitParam_3;
	// System.Xml.XmlCharType System.Xml.XmlTextReaderImpl::xmlCharType
	XmlCharType_t7F6CCEEB0A0BC8FC40F161B8928A766BE7B234E9  ___xmlCharType_4;
	// System.Xml.XmlTextReaderImpl_ParsingState System.Xml.XmlTextReaderImpl::ps
	ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2  ___ps_5;
	// System.Xml.XmlTextReaderImpl_ParsingFunction System.Xml.XmlTextReaderImpl::parsingFunction
	int32_t ___parsingFunction_6;
	// System.Xml.XmlTextReaderImpl_ParsingFunction System.Xml.XmlTextReaderImpl::nextParsingFunction
	int32_t ___nextParsingFunction_7;
	// System.Xml.XmlTextReaderImpl_ParsingFunction System.Xml.XmlTextReaderImpl::nextNextParsingFunction
	int32_t ___nextNextParsingFunction_8;
	// System.Xml.XmlTextReaderImpl_NodeData[] System.Xml.XmlTextReaderImpl::nodes
	NodeDataU5BU5D_tD5EBFFECEF67B4D0D7D521A99182D3B2814E07BE* ___nodes_9;
	// System.Xml.XmlTextReaderImpl_NodeData System.Xml.XmlTextReaderImpl::curNode
	NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * ___curNode_10;
	// System.Int32 System.Xml.XmlTextReaderImpl::index
	int32_t ___index_11;
	// System.Int32 System.Xml.XmlTextReaderImpl::curAttrIndex
	int32_t ___curAttrIndex_12;
	// System.Int32 System.Xml.XmlTextReaderImpl::attrCount
	int32_t ___attrCount_13;
	// System.Int32 System.Xml.XmlTextReaderImpl::attrHashtable
	int32_t ___attrHashtable_14;
	// System.Int32 System.Xml.XmlTextReaderImpl::attrDuplWalkCount
	int32_t ___attrDuplWalkCount_15;
	// System.Boolean System.Xml.XmlTextReaderImpl::attrNeedNamespaceLookup
	bool ___attrNeedNamespaceLookup_16;
	// System.Boolean System.Xml.XmlTextReaderImpl::fullAttrCleanup
	bool ___fullAttrCleanup_17;
	// System.Xml.XmlTextReaderImpl_NodeData[] System.Xml.XmlTextReaderImpl::attrDuplSortingArray
	NodeDataU5BU5D_tD5EBFFECEF67B4D0D7D521A99182D3B2814E07BE* ___attrDuplSortingArray_18;
	// System.Xml.XmlNameTable System.Xml.XmlTextReaderImpl::nameTable
	XmlNameTable_t3C1CDAB4E7D97DE41A409D6D9ADD2C10B1F281A6 * ___nameTable_19;
	// System.Boolean System.Xml.XmlTextReaderImpl::nameTableFromSettings
	bool ___nameTableFromSettings_20;
	// System.Xml.XmlResolver System.Xml.XmlTextReaderImpl::xmlResolver
	XmlResolver_t93269F14B2F8750D040AED2FB7A303CE85016280 * ___xmlResolver_21;
	// System.String System.Xml.XmlTextReaderImpl::url
	String_t* ___url_22;
	// System.Boolean System.Xml.XmlTextReaderImpl::normalize
	bool ___normalize_23;
	// System.Boolean System.Xml.XmlTextReaderImpl::supportNamespaces
	bool ___supportNamespaces_24;
	// System.Xml.WhitespaceHandling System.Xml.XmlTextReaderImpl::whitespaceHandling
	int32_t ___whitespaceHandling_25;
	// System.Xml.DtdProcessing System.Xml.XmlTextReaderImpl::dtdProcessing
	int32_t ___dtdProcessing_26;
	// System.Xml.EntityHandling System.Xml.XmlTextReaderImpl::entityHandling
	int32_t ___entityHandling_27;
	// System.Boolean System.Xml.XmlTextReaderImpl::ignorePIs
	bool ___ignorePIs_28;
	// System.Boolean System.Xml.XmlTextReaderImpl::ignoreComments
	bool ___ignoreComments_29;
	// System.Boolean System.Xml.XmlTextReaderImpl::checkCharacters
	bool ___checkCharacters_30;
	// System.Int32 System.Xml.XmlTextReaderImpl::lineNumberOffset
	int32_t ___lineNumberOffset_31;
	// System.Int32 System.Xml.XmlTextReaderImpl::linePositionOffset
	int32_t ___linePositionOffset_32;
	// System.Boolean System.Xml.XmlTextReaderImpl::closeInput
	bool ___closeInput_33;
	// System.Int64 System.Xml.XmlTextReaderImpl::maxCharactersInDocument
	int64_t ___maxCharactersInDocument_34;
	// System.Int64 System.Xml.XmlTextReaderImpl::maxCharactersFromEntities
	int64_t ___maxCharactersFromEntities_35;
	// System.Boolean System.Xml.XmlTextReaderImpl::v1Compat
	bool ___v1Compat_36;
	// System.Xml.XmlNamespaceManager System.Xml.XmlTextReaderImpl::namespaceManager
	XmlNamespaceManager_t8323BEB96BBE8F75207DC2AAFE9430E7F473658F * ___namespaceManager_37;
	// System.String System.Xml.XmlTextReaderImpl::lastPrefix
	String_t* ___lastPrefix_38;
	// System.Xml.XmlTextReaderImpl_XmlContext System.Xml.XmlTextReaderImpl::xmlContext
	XmlContext_tC94B1A0D023B096ADF338FA72FB55D0E2DBF9B52 * ___xmlContext_39;
	// System.Xml.XmlTextReaderImpl_ParsingState[] System.Xml.XmlTextReaderImpl::parsingStatesStack
	ParsingStateU5BU5D_t7A5096046F9BF1BA70E9696B2A2479272FC65739* ___parsingStatesStack_40;
	// System.Int32 System.Xml.XmlTextReaderImpl::parsingStatesStackTop
	int32_t ___parsingStatesStackTop_41;
	// System.String System.Xml.XmlTextReaderImpl::reportedBaseUri
	String_t* ___reportedBaseUri_42;
	// System.Text.Encoding System.Xml.XmlTextReaderImpl::reportedEncoding
	Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4 * ___reportedEncoding_43;
	// System.Xml.IDtdInfo System.Xml.XmlTextReaderImpl::dtdInfo
	RuntimeObject* ___dtdInfo_44;
	// System.Xml.XmlNodeType System.Xml.XmlTextReaderImpl::fragmentType
	int32_t ___fragmentType_45;
	// System.Xml.XmlParserContext System.Xml.XmlTextReaderImpl::fragmentParserContext
	XmlParserContext_tDC3A95452BC683F0D64EC3C4AF9934D3FC732279 * ___fragmentParserContext_46;
	// System.Boolean System.Xml.XmlTextReaderImpl::fragment
	bool ___fragment_47;
	// System.Xml.IncrementalReadDecoder System.Xml.XmlTextReaderImpl::incReadDecoder
	IncrementalReadDecoder_t787BFB5889B01B88DDA030C503A0C2E0525CA723 * ___incReadDecoder_48;
	// System.Xml.XmlTextReaderImpl_IncrementalReadState System.Xml.XmlTextReaderImpl::incReadState
	int32_t ___incReadState_49;
	// System.Xml.LineInfo System.Xml.XmlTextReaderImpl::incReadLineInfo
	LineInfo_t7E3D50496C7BA51B84D485D0A30B9006943544E5  ___incReadLineInfo_50;
	// System.Int32 System.Xml.XmlTextReaderImpl::incReadDepth
	int32_t ___incReadDepth_51;
	// System.Int32 System.Xml.XmlTextReaderImpl::incReadLeftStartPos
	int32_t ___incReadLeftStartPos_52;
	// System.Int32 System.Xml.XmlTextReaderImpl::incReadLeftEndPos
	int32_t ___incReadLeftEndPos_53;
	// System.Int32 System.Xml.XmlTextReaderImpl::attributeValueBaseEntityId
	int32_t ___attributeValueBaseEntityId_54;
	// System.Boolean System.Xml.XmlTextReaderImpl::emptyEntityInAttributeResolved
	bool ___emptyEntityInAttributeResolved_55;
	// System.Xml.IValidationEventHandling System.Xml.XmlTextReaderImpl::validationEventHandling
	RuntimeObject* ___validationEventHandling_56;
	// System.Xml.XmlTextReaderImpl_OnDefaultAttributeUseDelegate System.Xml.XmlTextReaderImpl::onDefaultAttributeUse
	OnDefaultAttributeUseDelegate_tE83A97BD37E08D3C5AA377CEA6388782D99EA34D * ___onDefaultAttributeUse_57;
	// System.Boolean System.Xml.XmlTextReaderImpl::validatingReaderCompatFlag
	bool ___validatingReaderCompatFlag_58;
	// System.Boolean System.Xml.XmlTextReaderImpl::addDefaultAttributesAndNormalize
	bool ___addDefaultAttributesAndNormalize_59;
	// System.Text.StringBuilder System.Xml.XmlTextReaderImpl::stringBuilder
	StringBuilder_t * ___stringBuilder_60;
	// System.Boolean System.Xml.XmlTextReaderImpl::rootElementParsed
	bool ___rootElementParsed_61;
	// System.Boolean System.Xml.XmlTextReaderImpl::standalone
	bool ___standalone_62;
	// System.Int32 System.Xml.XmlTextReaderImpl::nextEntityId
	int32_t ___nextEntityId_63;
	// System.Xml.XmlTextReaderImpl_ParsingMode System.Xml.XmlTextReaderImpl::parsingMode
	int32_t ___parsingMode_64;
	// System.Xml.ReadState System.Xml.XmlTextReaderImpl::readState
	int32_t ___readState_65;
	// System.Xml.IDtdEntityInfo System.Xml.XmlTextReaderImpl::lastEntity
	RuntimeObject* ___lastEntity_66;
	// System.Boolean System.Xml.XmlTextReaderImpl::afterResetState
	bool ___afterResetState_67;
	// System.Int32 System.Xml.XmlTextReaderImpl::documentStartBytePos
	int32_t ___documentStartBytePos_68;
	// System.Int32 System.Xml.XmlTextReaderImpl::readValueOffset
	int32_t ___readValueOffset_69;
	// System.Int64 System.Xml.XmlTextReaderImpl::charactersInDocument
	int64_t ___charactersInDocument_70;
	// System.Int64 System.Xml.XmlTextReaderImpl::charactersFromEntities
	int64_t ___charactersFromEntities_71;
	// System.Collections.Generic.Dictionary`2<System.Xml.IDtdEntityInfo,System.Xml.IDtdEntityInfo> System.Xml.XmlTextReaderImpl::currentEntities
	Dictionary_2_tD00930653EC02E03C14ADE0FF8737B6193A5FE1B * ___currentEntities_72;
	// System.Boolean System.Xml.XmlTextReaderImpl::disableUndeclaredEntityCheck
	bool ___disableUndeclaredEntityCheck_73;
	// System.Xml.XmlReader System.Xml.XmlTextReaderImpl::outerReader
	XmlReader_t13F08E3C651EB9F2AE882342BCD5E2CA86F29ABB * ___outerReader_74;
	// System.Boolean System.Xml.XmlTextReaderImpl::xmlResolverIsSet
	bool ___xmlResolverIsSet_75;
	// System.String System.Xml.XmlTextReaderImpl::Xml
	String_t* ___Xml_76;
	// System.String System.Xml.XmlTextReaderImpl::XmlNs
	String_t* ___XmlNs_77;
	// System.Threading.Tasks.Task`1<System.Tuple`4<System.Int32,System.Int32,System.Int32,System.Boolean>> System.Xml.XmlTextReaderImpl::parseText_dummyTask
	Task_1_tFB42A7666202CD6CD81E6BF0FF63815EE40E621D * ___parseText_dummyTask_78;

public:
	inline static int32_t get_offset_of_laterInitParam_3() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___laterInitParam_3)); }
	inline LaterInitParam_tE2FFFA55A2C7B183721762B4AC4B0DF93485A1AF * get_laterInitParam_3() const { return ___laterInitParam_3; }
	inline LaterInitParam_tE2FFFA55A2C7B183721762B4AC4B0DF93485A1AF ** get_address_of_laterInitParam_3() { return &___laterInitParam_3; }
	inline void set_laterInitParam_3(LaterInitParam_tE2FFFA55A2C7B183721762B4AC4B0DF93485A1AF * value)
	{
		___laterInitParam_3 = value;
		Il2CppCodeGenWriteBarrier((&___laterInitParam_3), value);
	}

	inline static int32_t get_offset_of_xmlCharType_4() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___xmlCharType_4)); }
	inline XmlCharType_t7F6CCEEB0A0BC8FC40F161B8928A766BE7B234E9  get_xmlCharType_4() const { return ___xmlCharType_4; }
	inline XmlCharType_t7F6CCEEB0A0BC8FC40F161B8928A766BE7B234E9 * get_address_of_xmlCharType_4() { return &___xmlCharType_4; }
	inline void set_xmlCharType_4(XmlCharType_t7F6CCEEB0A0BC8FC40F161B8928A766BE7B234E9  value)
	{
		___xmlCharType_4 = value;
	}

	inline static int32_t get_offset_of_ps_5() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___ps_5)); }
	inline ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2  get_ps_5() const { return ___ps_5; }
	inline ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2 * get_address_of_ps_5() { return &___ps_5; }
	inline void set_ps_5(ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2  value)
	{
		___ps_5 = value;
	}

	inline static int32_t get_offset_of_parsingFunction_6() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___parsingFunction_6)); }
	inline int32_t get_parsingFunction_6() const { return ___parsingFunction_6; }
	inline int32_t* get_address_of_parsingFunction_6() { return &___parsingFunction_6; }
	inline void set_parsingFunction_6(int32_t value)
	{
		___parsingFunction_6 = value;
	}

	inline static int32_t get_offset_of_nextParsingFunction_7() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___nextParsingFunction_7)); }
	inline int32_t get_nextParsingFunction_7() const { return ___nextParsingFunction_7; }
	inline int32_t* get_address_of_nextParsingFunction_7() { return &___nextParsingFunction_7; }
	inline void set_nextParsingFunction_7(int32_t value)
	{
		___nextParsingFunction_7 = value;
	}

	inline static int32_t get_offset_of_nextNextParsingFunction_8() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___nextNextParsingFunction_8)); }
	inline int32_t get_nextNextParsingFunction_8() const { return ___nextNextParsingFunction_8; }
	inline int32_t* get_address_of_nextNextParsingFunction_8() { return &___nextNextParsingFunction_8; }
	inline void set_nextNextParsingFunction_8(int32_t value)
	{
		___nextNextParsingFunction_8 = value;
	}

	inline static int32_t get_offset_of_nodes_9() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___nodes_9)); }
	inline NodeDataU5BU5D_tD5EBFFECEF67B4D0D7D521A99182D3B2814E07BE* get_nodes_9() const { return ___nodes_9; }
	inline NodeDataU5BU5D_tD5EBFFECEF67B4D0D7D521A99182D3B2814E07BE** get_address_of_nodes_9() { return &___nodes_9; }
	inline void set_nodes_9(NodeDataU5BU5D_tD5EBFFECEF67B4D0D7D521A99182D3B2814E07BE* value)
	{
		___nodes_9 = value;
		Il2CppCodeGenWriteBarrier((&___nodes_9), value);
	}

	inline static int32_t get_offset_of_curNode_10() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___curNode_10)); }
	inline NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * get_curNode_10() const { return ___curNode_10; }
	inline NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF ** get_address_of_curNode_10() { return &___curNode_10; }
	inline void set_curNode_10(NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * value)
	{
		___curNode_10 = value;
		Il2CppCodeGenWriteBarrier((&___curNode_10), value);
	}

	inline static int32_t get_offset_of_index_11() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___index_11)); }
	inline int32_t get_index_11() const { return ___index_11; }
	inline int32_t* get_address_of_index_11() { return &___index_11; }
	inline void set_index_11(int32_t value)
	{
		___index_11 = value;
	}

	inline static int32_t get_offset_of_curAttrIndex_12() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___curAttrIndex_12)); }
	inline int32_t get_curAttrIndex_12() const { return ___curAttrIndex_12; }
	inline int32_t* get_address_of_curAttrIndex_12() { return &___curAttrIndex_12; }
	inline void set_curAttrIndex_12(int32_t value)
	{
		___curAttrIndex_12 = value;
	}

	inline static int32_t get_offset_of_attrCount_13() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___attrCount_13)); }
	inline int32_t get_attrCount_13() const { return ___attrCount_13; }
	inline int32_t* get_address_of_attrCount_13() { return &___attrCount_13; }
	inline void set_attrCount_13(int32_t value)
	{
		___attrCount_13 = value;
	}

	inline static int32_t get_offset_of_attrHashtable_14() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___attrHashtable_14)); }
	inline int32_t get_attrHashtable_14() const { return ___attrHashtable_14; }
	inline int32_t* get_address_of_attrHashtable_14() { return &___attrHashtable_14; }
	inline void set_attrHashtable_14(int32_t value)
	{
		___attrHashtable_14 = value;
	}

	inline static int32_t get_offset_of_attrDuplWalkCount_15() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___attrDuplWalkCount_15)); }
	inline int32_t get_attrDuplWalkCount_15() const { return ___attrDuplWalkCount_15; }
	inline int32_t* get_address_of_attrDuplWalkCount_15() { return &___attrDuplWalkCount_15; }
	inline void set_attrDuplWalkCount_15(int32_t value)
	{
		___attrDuplWalkCount_15 = value;
	}

	inline static int32_t get_offset_of_attrNeedNamespaceLookup_16() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___attrNeedNamespaceLookup_16)); }
	inline bool get_attrNeedNamespaceLookup_16() const { return ___attrNeedNamespaceLookup_16; }
	inline bool* get_address_of_attrNeedNamespaceLookup_16() { return &___attrNeedNamespaceLookup_16; }
	inline void set_attrNeedNamespaceLookup_16(bool value)
	{
		___attrNeedNamespaceLookup_16 = value;
	}

	inline static int32_t get_offset_of_fullAttrCleanup_17() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___fullAttrCleanup_17)); }
	inline bool get_fullAttrCleanup_17() const { return ___fullAttrCleanup_17; }
	inline bool* get_address_of_fullAttrCleanup_17() { return &___fullAttrCleanup_17; }
	inline void set_fullAttrCleanup_17(bool value)
	{
		___fullAttrCleanup_17 = value;
	}

	inline static int32_t get_offset_of_attrDuplSortingArray_18() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___attrDuplSortingArray_18)); }
	inline NodeDataU5BU5D_tD5EBFFECEF67B4D0D7D521A99182D3B2814E07BE* get_attrDuplSortingArray_18() const { return ___attrDuplSortingArray_18; }
	inline NodeDataU5BU5D_tD5EBFFECEF67B4D0D7D521A99182D3B2814E07BE** get_address_of_attrDuplSortingArray_18() { return &___attrDuplSortingArray_18; }
	inline void set_attrDuplSortingArray_18(NodeDataU5BU5D_tD5EBFFECEF67B4D0D7D521A99182D3B2814E07BE* value)
	{
		___attrDuplSortingArray_18 = value;
		Il2CppCodeGenWriteBarrier((&___attrDuplSortingArray_18), value);
	}

	inline static int32_t get_offset_of_nameTable_19() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___nameTable_19)); }
	inline XmlNameTable_t3C1CDAB4E7D97DE41A409D6D9ADD2C10B1F281A6 * get_nameTable_19() const { return ___nameTable_19; }
	inline XmlNameTable_t3C1CDAB4E7D97DE41A409D6D9ADD2C10B1F281A6 ** get_address_of_nameTable_19() { return &___nameTable_19; }
	inline void set_nameTable_19(XmlNameTable_t3C1CDAB4E7D97DE41A409D6D9ADD2C10B1F281A6 * value)
	{
		___nameTable_19 = value;
		Il2CppCodeGenWriteBarrier((&___nameTable_19), value);
	}

	inline static int32_t get_offset_of_nameTableFromSettings_20() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___nameTableFromSettings_20)); }
	inline bool get_nameTableFromSettings_20() const { return ___nameTableFromSettings_20; }
	inline bool* get_address_of_nameTableFromSettings_20() { return &___nameTableFromSettings_20; }
	inline void set_nameTableFromSettings_20(bool value)
	{
		___nameTableFromSettings_20 = value;
	}

	inline static int32_t get_offset_of_xmlResolver_21() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___xmlResolver_21)); }
	inline XmlResolver_t93269F14B2F8750D040AED2FB7A303CE85016280 * get_xmlResolver_21() const { return ___xmlResolver_21; }
	inline XmlResolver_t93269F14B2F8750D040AED2FB7A303CE85016280 ** get_address_of_xmlResolver_21() { return &___xmlResolver_21; }
	inline void set_xmlResolver_21(XmlResolver_t93269F14B2F8750D040AED2FB7A303CE85016280 * value)
	{
		___xmlResolver_21 = value;
		Il2CppCodeGenWriteBarrier((&___xmlResolver_21), value);
	}

	inline static int32_t get_offset_of_url_22() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___url_22)); }
	inline String_t* get_url_22() const { return ___url_22; }
	inline String_t** get_address_of_url_22() { return &___url_22; }
	inline void set_url_22(String_t* value)
	{
		___url_22 = value;
		Il2CppCodeGenWriteBarrier((&___url_22), value);
	}

	inline static int32_t get_offset_of_normalize_23() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___normalize_23)); }
	inline bool get_normalize_23() const { return ___normalize_23; }
	inline bool* get_address_of_normalize_23() { return &___normalize_23; }
	inline void set_normalize_23(bool value)
	{
		___normalize_23 = value;
	}

	inline static int32_t get_offset_of_supportNamespaces_24() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___supportNamespaces_24)); }
	inline bool get_supportNamespaces_24() const { return ___supportNamespaces_24; }
	inline bool* get_address_of_supportNamespaces_24() { return &___supportNamespaces_24; }
	inline void set_supportNamespaces_24(bool value)
	{
		___supportNamespaces_24 = value;
	}

	inline static int32_t get_offset_of_whitespaceHandling_25() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___whitespaceHandling_25)); }
	inline int32_t get_whitespaceHandling_25() const { return ___whitespaceHandling_25; }
	inline int32_t* get_address_of_whitespaceHandling_25() { return &___whitespaceHandling_25; }
	inline void set_whitespaceHandling_25(int32_t value)
	{
		___whitespaceHandling_25 = value;
	}

	inline static int32_t get_offset_of_dtdProcessing_26() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___dtdProcessing_26)); }
	inline int32_t get_dtdProcessing_26() const { return ___dtdProcessing_26; }
	inline int32_t* get_address_of_dtdProcessing_26() { return &___dtdProcessing_26; }
	inline void set_dtdProcessing_26(int32_t value)
	{
		___dtdProcessing_26 = value;
	}

	inline static int32_t get_offset_of_entityHandling_27() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___entityHandling_27)); }
	inline int32_t get_entityHandling_27() const { return ___entityHandling_27; }
	inline int32_t* get_address_of_entityHandling_27() { return &___entityHandling_27; }
	inline void set_entityHandling_27(int32_t value)
	{
		___entityHandling_27 = value;
	}

	inline static int32_t get_offset_of_ignorePIs_28() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___ignorePIs_28)); }
	inline bool get_ignorePIs_28() const { return ___ignorePIs_28; }
	inline bool* get_address_of_ignorePIs_28() { return &___ignorePIs_28; }
	inline void set_ignorePIs_28(bool value)
	{
		___ignorePIs_28 = value;
	}

	inline static int32_t get_offset_of_ignoreComments_29() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___ignoreComments_29)); }
	inline bool get_ignoreComments_29() const { return ___ignoreComments_29; }
	inline bool* get_address_of_ignoreComments_29() { return &___ignoreComments_29; }
	inline void set_ignoreComments_29(bool value)
	{
		___ignoreComments_29 = value;
	}

	inline static int32_t get_offset_of_checkCharacters_30() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___checkCharacters_30)); }
	inline bool get_checkCharacters_30() const { return ___checkCharacters_30; }
	inline bool* get_address_of_checkCharacters_30() { return &___checkCharacters_30; }
	inline void set_checkCharacters_30(bool value)
	{
		___checkCharacters_30 = value;
	}

	inline static int32_t get_offset_of_lineNumberOffset_31() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___lineNumberOffset_31)); }
	inline int32_t get_lineNumberOffset_31() const { return ___lineNumberOffset_31; }
	inline int32_t* get_address_of_lineNumberOffset_31() { return &___lineNumberOffset_31; }
	inline void set_lineNumberOffset_31(int32_t value)
	{
		___lineNumberOffset_31 = value;
	}

	inline static int32_t get_offset_of_linePositionOffset_32() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___linePositionOffset_32)); }
	inline int32_t get_linePositionOffset_32() const { return ___linePositionOffset_32; }
	inline int32_t* get_address_of_linePositionOffset_32() { return &___linePositionOffset_32; }
	inline void set_linePositionOffset_32(int32_t value)
	{
		___linePositionOffset_32 = value;
	}

	inline static int32_t get_offset_of_closeInput_33() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___closeInput_33)); }
	inline bool get_closeInput_33() const { return ___closeInput_33; }
	inline bool* get_address_of_closeInput_33() { return &___closeInput_33; }
	inline void set_closeInput_33(bool value)
	{
		___closeInput_33 = value;
	}

	inline static int32_t get_offset_of_maxCharactersInDocument_34() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___maxCharactersInDocument_34)); }
	inline int64_t get_maxCharactersInDocument_34() const { return ___maxCharactersInDocument_34; }
	inline int64_t* get_address_of_maxCharactersInDocument_34() { return &___maxCharactersInDocument_34; }
	inline void set_maxCharactersInDocument_34(int64_t value)
	{
		___maxCharactersInDocument_34 = value;
	}

	inline static int32_t get_offset_of_maxCharactersFromEntities_35() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___maxCharactersFromEntities_35)); }
	inline int64_t get_maxCharactersFromEntities_35() const { return ___maxCharactersFromEntities_35; }
	inline int64_t* get_address_of_maxCharactersFromEntities_35() { return &___maxCharactersFromEntities_35; }
	inline void set_maxCharactersFromEntities_35(int64_t value)
	{
		___maxCharactersFromEntities_35 = value;
	}

	inline static int32_t get_offset_of_v1Compat_36() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___v1Compat_36)); }
	inline bool get_v1Compat_36() const { return ___v1Compat_36; }
	inline bool* get_address_of_v1Compat_36() { return &___v1Compat_36; }
	inline void set_v1Compat_36(bool value)
	{
		___v1Compat_36 = value;
	}

	inline static int32_t get_offset_of_namespaceManager_37() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___namespaceManager_37)); }
	inline XmlNamespaceManager_t8323BEB96BBE8F75207DC2AAFE9430E7F473658F * get_namespaceManager_37() const { return ___namespaceManager_37; }
	inline XmlNamespaceManager_t8323BEB96BBE8F75207DC2AAFE9430E7F473658F ** get_address_of_namespaceManager_37() { return &___namespaceManager_37; }
	inline void set_namespaceManager_37(XmlNamespaceManager_t8323BEB96BBE8F75207DC2AAFE9430E7F473658F * value)
	{
		___namespaceManager_37 = value;
		Il2CppCodeGenWriteBarrier((&___namespaceManager_37), value);
	}

	inline static int32_t get_offset_of_lastPrefix_38() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___lastPrefix_38)); }
	inline String_t* get_lastPrefix_38() const { return ___lastPrefix_38; }
	inline String_t** get_address_of_lastPrefix_38() { return &___lastPrefix_38; }
	inline void set_lastPrefix_38(String_t* value)
	{
		___lastPrefix_38 = value;
		Il2CppCodeGenWriteBarrier((&___lastPrefix_38), value);
	}

	inline static int32_t get_offset_of_xmlContext_39() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___xmlContext_39)); }
	inline XmlContext_tC94B1A0D023B096ADF338FA72FB55D0E2DBF9B52 * get_xmlContext_39() const { return ___xmlContext_39; }
	inline XmlContext_tC94B1A0D023B096ADF338FA72FB55D0E2DBF9B52 ** get_address_of_xmlContext_39() { return &___xmlContext_39; }
	inline void set_xmlContext_39(XmlContext_tC94B1A0D023B096ADF338FA72FB55D0E2DBF9B52 * value)
	{
		___xmlContext_39 = value;
		Il2CppCodeGenWriteBarrier((&___xmlContext_39), value);
	}

	inline static int32_t get_offset_of_parsingStatesStack_40() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___parsingStatesStack_40)); }
	inline ParsingStateU5BU5D_t7A5096046F9BF1BA70E9696B2A2479272FC65739* get_parsingStatesStack_40() const { return ___parsingStatesStack_40; }
	inline ParsingStateU5BU5D_t7A5096046F9BF1BA70E9696B2A2479272FC65739** get_address_of_parsingStatesStack_40() { return &___parsingStatesStack_40; }
	inline void set_parsingStatesStack_40(ParsingStateU5BU5D_t7A5096046F9BF1BA70E9696B2A2479272FC65739* value)
	{
		___parsingStatesStack_40 = value;
		Il2CppCodeGenWriteBarrier((&___parsingStatesStack_40), value);
	}

	inline static int32_t get_offset_of_parsingStatesStackTop_41() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___parsingStatesStackTop_41)); }
	inline int32_t get_parsingStatesStackTop_41() const { return ___parsingStatesStackTop_41; }
	inline int32_t* get_address_of_parsingStatesStackTop_41() { return &___parsingStatesStackTop_41; }
	inline void set_parsingStatesStackTop_41(int32_t value)
	{
		___parsingStatesStackTop_41 = value;
	}

	inline static int32_t get_offset_of_reportedBaseUri_42() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___reportedBaseUri_42)); }
	inline String_t* get_reportedBaseUri_42() const { return ___reportedBaseUri_42; }
	inline String_t** get_address_of_reportedBaseUri_42() { return &___reportedBaseUri_42; }
	inline void set_reportedBaseUri_42(String_t* value)
	{
		___reportedBaseUri_42 = value;
		Il2CppCodeGenWriteBarrier((&___reportedBaseUri_42), value);
	}

	inline static int32_t get_offset_of_reportedEncoding_43() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___reportedEncoding_43)); }
	inline Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4 * get_reportedEncoding_43() const { return ___reportedEncoding_43; }
	inline Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4 ** get_address_of_reportedEncoding_43() { return &___reportedEncoding_43; }
	inline void set_reportedEncoding_43(Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4 * value)
	{
		___reportedEncoding_43 = value;
		Il2CppCodeGenWriteBarrier((&___reportedEncoding_43), value);
	}

	inline static int32_t get_offset_of_dtdInfo_44() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___dtdInfo_44)); }
	inline RuntimeObject* get_dtdInfo_44() const { return ___dtdInfo_44; }
	inline RuntimeObject** get_address_of_dtdInfo_44() { return &___dtdInfo_44; }
	inline void set_dtdInfo_44(RuntimeObject* value)
	{
		___dtdInfo_44 = value;
		Il2CppCodeGenWriteBarrier((&___dtdInfo_44), value);
	}

	inline static int32_t get_offset_of_fragmentType_45() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___fragmentType_45)); }
	inline int32_t get_fragmentType_45() const { return ___fragmentType_45; }
	inline int32_t* get_address_of_fragmentType_45() { return &___fragmentType_45; }
	inline void set_fragmentType_45(int32_t value)
	{
		___fragmentType_45 = value;
	}

	inline static int32_t get_offset_of_fragmentParserContext_46() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___fragmentParserContext_46)); }
	inline XmlParserContext_tDC3A95452BC683F0D64EC3C4AF9934D3FC732279 * get_fragmentParserContext_46() const { return ___fragmentParserContext_46; }
	inline XmlParserContext_tDC3A95452BC683F0D64EC3C4AF9934D3FC732279 ** get_address_of_fragmentParserContext_46() { return &___fragmentParserContext_46; }
	inline void set_fragmentParserContext_46(XmlParserContext_tDC3A95452BC683F0D64EC3C4AF9934D3FC732279 * value)
	{
		___fragmentParserContext_46 = value;
		Il2CppCodeGenWriteBarrier((&___fragmentParserContext_46), value);
	}

	inline static int32_t get_offset_of_fragment_47() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___fragment_47)); }
	inline bool get_fragment_47() const { return ___fragment_47; }
	inline bool* get_address_of_fragment_47() { return &___fragment_47; }
	inline void set_fragment_47(bool value)
	{
		___fragment_47 = value;
	}

	inline static int32_t get_offset_of_incReadDecoder_48() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___incReadDecoder_48)); }
	inline IncrementalReadDecoder_t787BFB5889B01B88DDA030C503A0C2E0525CA723 * get_incReadDecoder_48() const { return ___incReadDecoder_48; }
	inline IncrementalReadDecoder_t787BFB5889B01B88DDA030C503A0C2E0525CA723 ** get_address_of_incReadDecoder_48() { return &___incReadDecoder_48; }
	inline void set_incReadDecoder_48(IncrementalReadDecoder_t787BFB5889B01B88DDA030C503A0C2E0525CA723 * value)
	{
		___incReadDecoder_48 = value;
		Il2CppCodeGenWriteBarrier((&___incReadDecoder_48), value);
	}

	inline static int32_t get_offset_of_incReadState_49() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___incReadState_49)); }
	inline int32_t get_incReadState_49() const { return ___incReadState_49; }
	inline int32_t* get_address_of_incReadState_49() { return &___incReadState_49; }
	inline void set_incReadState_49(int32_t value)
	{
		___incReadState_49 = value;
	}

	inline static int32_t get_offset_of_incReadLineInfo_50() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___incReadLineInfo_50)); }
	inline LineInfo_t7E3D50496C7BA51B84D485D0A30B9006943544E5  get_incReadLineInfo_50() const { return ___incReadLineInfo_50; }
	inline LineInfo_t7E3D50496C7BA51B84D485D0A30B9006943544E5 * get_address_of_incReadLineInfo_50() { return &___incReadLineInfo_50; }
	inline void set_incReadLineInfo_50(LineInfo_t7E3D50496C7BA51B84D485D0A30B9006943544E5  value)
	{
		___incReadLineInfo_50 = value;
	}

	inline static int32_t get_offset_of_incReadDepth_51() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___incReadDepth_51)); }
	inline int32_t get_incReadDepth_51() const { return ___incReadDepth_51; }
	inline int32_t* get_address_of_incReadDepth_51() { return &___incReadDepth_51; }
	inline void set_incReadDepth_51(int32_t value)
	{
		___incReadDepth_51 = value;
	}

	inline static int32_t get_offset_of_incReadLeftStartPos_52() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___incReadLeftStartPos_52)); }
	inline int32_t get_incReadLeftStartPos_52() const { return ___incReadLeftStartPos_52; }
	inline int32_t* get_address_of_incReadLeftStartPos_52() { return &___incReadLeftStartPos_52; }
	inline void set_incReadLeftStartPos_52(int32_t value)
	{
		___incReadLeftStartPos_52 = value;
	}

	inline static int32_t get_offset_of_incReadLeftEndPos_53() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___incReadLeftEndPos_53)); }
	inline int32_t get_incReadLeftEndPos_53() const { return ___incReadLeftEndPos_53; }
	inline int32_t* get_address_of_incReadLeftEndPos_53() { return &___incReadLeftEndPos_53; }
	inline void set_incReadLeftEndPos_53(int32_t value)
	{
		___incReadLeftEndPos_53 = value;
	}

	inline static int32_t get_offset_of_attributeValueBaseEntityId_54() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___attributeValueBaseEntityId_54)); }
	inline int32_t get_attributeValueBaseEntityId_54() const { return ___attributeValueBaseEntityId_54; }
	inline int32_t* get_address_of_attributeValueBaseEntityId_54() { return &___attributeValueBaseEntityId_54; }
	inline void set_attributeValueBaseEntityId_54(int32_t value)
	{
		___attributeValueBaseEntityId_54 = value;
	}

	inline static int32_t get_offset_of_emptyEntityInAttributeResolved_55() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___emptyEntityInAttributeResolved_55)); }
	inline bool get_emptyEntityInAttributeResolved_55() const { return ___emptyEntityInAttributeResolved_55; }
	inline bool* get_address_of_emptyEntityInAttributeResolved_55() { return &___emptyEntityInAttributeResolved_55; }
	inline void set_emptyEntityInAttributeResolved_55(bool value)
	{
		___emptyEntityInAttributeResolved_55 = value;
	}

	inline static int32_t get_offset_of_validationEventHandling_56() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___validationEventHandling_56)); }
	inline RuntimeObject* get_validationEventHandling_56() const { return ___validationEventHandling_56; }
	inline RuntimeObject** get_address_of_validationEventHandling_56() { return &___validationEventHandling_56; }
	inline void set_validationEventHandling_56(RuntimeObject* value)
	{
		___validationEventHandling_56 = value;
		Il2CppCodeGenWriteBarrier((&___validationEventHandling_56), value);
	}

	inline static int32_t get_offset_of_onDefaultAttributeUse_57() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___onDefaultAttributeUse_57)); }
	inline OnDefaultAttributeUseDelegate_tE83A97BD37E08D3C5AA377CEA6388782D99EA34D * get_onDefaultAttributeUse_57() const { return ___onDefaultAttributeUse_57; }
	inline OnDefaultAttributeUseDelegate_tE83A97BD37E08D3C5AA377CEA6388782D99EA34D ** get_address_of_onDefaultAttributeUse_57() { return &___onDefaultAttributeUse_57; }
	inline void set_onDefaultAttributeUse_57(OnDefaultAttributeUseDelegate_tE83A97BD37E08D3C5AA377CEA6388782D99EA34D * value)
	{
		___onDefaultAttributeUse_57 = value;
		Il2CppCodeGenWriteBarrier((&___onDefaultAttributeUse_57), value);
	}

	inline static int32_t get_offset_of_validatingReaderCompatFlag_58() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___validatingReaderCompatFlag_58)); }
	inline bool get_validatingReaderCompatFlag_58() const { return ___validatingReaderCompatFlag_58; }
	inline bool* get_address_of_validatingReaderCompatFlag_58() { return &___validatingReaderCompatFlag_58; }
	inline void set_validatingReaderCompatFlag_58(bool value)
	{
		___validatingReaderCompatFlag_58 = value;
	}

	inline static int32_t get_offset_of_addDefaultAttributesAndNormalize_59() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___addDefaultAttributesAndNormalize_59)); }
	inline bool get_addDefaultAttributesAndNormalize_59() const { return ___addDefaultAttributesAndNormalize_59; }
	inline bool* get_address_of_addDefaultAttributesAndNormalize_59() { return &___addDefaultAttributesAndNormalize_59; }
	inline void set_addDefaultAttributesAndNormalize_59(bool value)
	{
		___addDefaultAttributesAndNormalize_59 = value;
	}

	inline static int32_t get_offset_of_stringBuilder_60() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___stringBuilder_60)); }
	inline StringBuilder_t * get_stringBuilder_60() const { return ___stringBuilder_60; }
	inline StringBuilder_t ** get_address_of_stringBuilder_60() { return &___stringBuilder_60; }
	inline void set_stringBuilder_60(StringBuilder_t * value)
	{
		___stringBuilder_60 = value;
		Il2CppCodeGenWriteBarrier((&___stringBuilder_60), value);
	}

	inline static int32_t get_offset_of_rootElementParsed_61() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___rootElementParsed_61)); }
	inline bool get_rootElementParsed_61() const { return ___rootElementParsed_61; }
	inline bool* get_address_of_rootElementParsed_61() { return &___rootElementParsed_61; }
	inline void set_rootElementParsed_61(bool value)
	{
		___rootElementParsed_61 = value;
	}

	inline static int32_t get_offset_of_standalone_62() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___standalone_62)); }
	inline bool get_standalone_62() const { return ___standalone_62; }
	inline bool* get_address_of_standalone_62() { return &___standalone_62; }
	inline void set_standalone_62(bool value)
	{
		___standalone_62 = value;
	}

	inline static int32_t get_offset_of_nextEntityId_63() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___nextEntityId_63)); }
	inline int32_t get_nextEntityId_63() const { return ___nextEntityId_63; }
	inline int32_t* get_address_of_nextEntityId_63() { return &___nextEntityId_63; }
	inline void set_nextEntityId_63(int32_t value)
	{
		___nextEntityId_63 = value;
	}

	inline static int32_t get_offset_of_parsingMode_64() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___parsingMode_64)); }
	inline int32_t get_parsingMode_64() const { return ___parsingMode_64; }
	inline int32_t* get_address_of_parsingMode_64() { return &___parsingMode_64; }
	inline void set_parsingMode_64(int32_t value)
	{
		___parsingMode_64 = value;
	}

	inline static int32_t get_offset_of_readState_65() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___readState_65)); }
	inline int32_t get_readState_65() const { return ___readState_65; }
	inline int32_t* get_address_of_readState_65() { return &___readState_65; }
	inline void set_readState_65(int32_t value)
	{
		___readState_65 = value;
	}

	inline static int32_t get_offset_of_lastEntity_66() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___lastEntity_66)); }
	inline RuntimeObject* get_lastEntity_66() const { return ___lastEntity_66; }
	inline RuntimeObject** get_address_of_lastEntity_66() { return &___lastEntity_66; }
	inline void set_lastEntity_66(RuntimeObject* value)
	{
		___lastEntity_66 = value;
		Il2CppCodeGenWriteBarrier((&___lastEntity_66), value);
	}

	inline static int32_t get_offset_of_afterResetState_67() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___afterResetState_67)); }
	inline bool get_afterResetState_67() const { return ___afterResetState_67; }
	inline bool* get_address_of_afterResetState_67() { return &___afterResetState_67; }
	inline void set_afterResetState_67(bool value)
	{
		___afterResetState_67 = value;
	}

	inline static int32_t get_offset_of_documentStartBytePos_68() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___documentStartBytePos_68)); }
	inline int32_t get_documentStartBytePos_68() const { return ___documentStartBytePos_68; }
	inline int32_t* get_address_of_documentStartBytePos_68() { return &___documentStartBytePos_68; }
	inline void set_documentStartBytePos_68(int32_t value)
	{
		___documentStartBytePos_68 = value;
	}

	inline static int32_t get_offset_of_readValueOffset_69() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___readValueOffset_69)); }
	inline int32_t get_readValueOffset_69() const { return ___readValueOffset_69; }
	inline int32_t* get_address_of_readValueOffset_69() { return &___readValueOffset_69; }
	inline void set_readValueOffset_69(int32_t value)
	{
		___readValueOffset_69 = value;
	}

	inline static int32_t get_offset_of_charactersInDocument_70() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___charactersInDocument_70)); }
	inline int64_t get_charactersInDocument_70() const { return ___charactersInDocument_70; }
	inline int64_t* get_address_of_charactersInDocument_70() { return &___charactersInDocument_70; }
	inline void set_charactersInDocument_70(int64_t value)
	{
		___charactersInDocument_70 = value;
	}

	inline static int32_t get_offset_of_charactersFromEntities_71() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___charactersFromEntities_71)); }
	inline int64_t get_charactersFromEntities_71() const { return ___charactersFromEntities_71; }
	inline int64_t* get_address_of_charactersFromEntities_71() { return &___charactersFromEntities_71; }
	inline void set_charactersFromEntities_71(int64_t value)
	{
		___charactersFromEntities_71 = value;
	}

	inline static int32_t get_offset_of_currentEntities_72() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___currentEntities_72)); }
	inline Dictionary_2_tD00930653EC02E03C14ADE0FF8737B6193A5FE1B * get_currentEntities_72() const { return ___currentEntities_72; }
	inline Dictionary_2_tD00930653EC02E03C14ADE0FF8737B6193A5FE1B ** get_address_of_currentEntities_72() { return &___currentEntities_72; }
	inline void set_currentEntities_72(Dictionary_2_tD00930653EC02E03C14ADE0FF8737B6193A5FE1B * value)
	{
		___currentEntities_72 = value;
		Il2CppCodeGenWriteBarrier((&___currentEntities_72), value);
	}

	inline static int32_t get_offset_of_disableUndeclaredEntityCheck_73() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___disableUndeclaredEntityCheck_73)); }
	inline bool get_disableUndeclaredEntityCheck_73() const { return ___disableUndeclaredEntityCheck_73; }
	inline bool* get_address_of_disableUndeclaredEntityCheck_73() { return &___disableUndeclaredEntityCheck_73; }
	inline void set_disableUndeclaredEntityCheck_73(bool value)
	{
		___disableUndeclaredEntityCheck_73 = value;
	}

	inline static int32_t get_offset_of_outerReader_74() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___outerReader_74)); }
	inline XmlReader_t13F08E3C651EB9F2AE882342BCD5E2CA86F29ABB * get_outerReader_74() const { return ___outerReader_74; }
	inline XmlReader_t13F08E3C651EB9F2AE882342BCD5E2CA86F29ABB ** get_address_of_outerReader_74() { return &___outerReader_74; }
	inline void set_outerReader_74(XmlReader_t13F08E3C651EB9F2AE882342BCD5E2CA86F29ABB * value)
	{
		___outerReader_74 = value;
		Il2CppCodeGenWriteBarrier((&___outerReader_74), value);
	}

	inline static int32_t get_offset_of_xmlResolverIsSet_75() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___xmlResolverIsSet_75)); }
	inline bool get_xmlResolverIsSet_75() const { return ___xmlResolverIsSet_75; }
	inline bool* get_address_of_xmlResolverIsSet_75() { return &___xmlResolverIsSet_75; }
	inline void set_xmlResolverIsSet_75(bool value)
	{
		___xmlResolverIsSet_75 = value;
	}

	inline static int32_t get_offset_of_Xml_76() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___Xml_76)); }
	inline String_t* get_Xml_76() const { return ___Xml_76; }
	inline String_t** get_address_of_Xml_76() { return &___Xml_76; }
	inline void set_Xml_76(String_t* value)
	{
		___Xml_76 = value;
		Il2CppCodeGenWriteBarrier((&___Xml_76), value);
	}

	inline static int32_t get_offset_of_XmlNs_77() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___XmlNs_77)); }
	inline String_t* get_XmlNs_77() const { return ___XmlNs_77; }
	inline String_t** get_address_of_XmlNs_77() { return &___XmlNs_77; }
	inline void set_XmlNs_77(String_t* value)
	{
		___XmlNs_77 = value;
		Il2CppCodeGenWriteBarrier((&___XmlNs_77), value);
	}

	inline static int32_t get_offset_of_parseText_dummyTask_78() { return static_cast<int32_t>(offsetof(XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61, ___parseText_dummyTask_78)); }
	inline Task_1_tFB42A7666202CD6CD81E6BF0FF63815EE40E621D * get_parseText_dummyTask_78() const { return ___parseText_dummyTask_78; }
	inline Task_1_tFB42A7666202CD6CD81E6BF0FF63815EE40E621D ** get_address_of_parseText_dummyTask_78() { return &___parseText_dummyTask_78; }
	inline void set_parseText_dummyTask_78(Task_1_tFB42A7666202CD6CD81E6BF0FF63815EE40E621D * value)
	{
		___parseText_dummyTask_78 = value;
		Il2CppCodeGenWriteBarrier((&___parseText_dummyTask_78), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // XMLTEXTREADERIMPL_T393737BE3F9168D966F164C2FD840C3494DEDE61_H
#ifndef LATERINITPARAM_TE2FFFA55A2C7B183721762B4AC4B0DF93485A1AF_H
#define LATERINITPARAM_TE2FFFA55A2C7B183721762B4AC4B0DF93485A1AF_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.XmlTextReaderImpl_LaterInitParam
struct  LaterInitParam_tE2FFFA55A2C7B183721762B4AC4B0DF93485A1AF  : public RuntimeObject
{
public:
	// System.Boolean System.Xml.XmlTextReaderImpl_LaterInitParam::useAsync
	bool ___useAsync_0;
	// System.IO.Stream System.Xml.XmlTextReaderImpl_LaterInitParam::inputStream
	Stream_tFC50657DD5AAB87770987F9179D934A51D99D5E7 * ___inputStream_1;
	// System.Byte[] System.Xml.XmlTextReaderImpl_LaterInitParam::inputBytes
	ByteU5BU5D_tD06FDBE8142446525DF1C40351D523A228373821* ___inputBytes_2;
	// System.Int32 System.Xml.XmlTextReaderImpl_LaterInitParam::inputByteCount
	int32_t ___inputByteCount_3;
	// System.Uri System.Xml.XmlTextReaderImpl_LaterInitParam::inputbaseUri
	Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E * ___inputbaseUri_4;
	// System.String System.Xml.XmlTextReaderImpl_LaterInitParam::inputUriStr
	String_t* ___inputUriStr_5;
	// System.Xml.XmlResolver System.Xml.XmlTextReaderImpl_LaterInitParam::inputUriResolver
	XmlResolver_t93269F14B2F8750D040AED2FB7A303CE85016280 * ___inputUriResolver_6;
	// System.Xml.XmlParserContext System.Xml.XmlTextReaderImpl_LaterInitParam::inputContext
	XmlParserContext_tDC3A95452BC683F0D64EC3C4AF9934D3FC732279 * ___inputContext_7;
	// System.IO.TextReader System.Xml.XmlTextReaderImpl_LaterInitParam::inputTextReader
	TextReader_t7DF8314B601D202ECFEDF623093A87BFDAB58D0A * ___inputTextReader_8;
	// System.Xml.XmlTextReaderImpl_InitInputType System.Xml.XmlTextReaderImpl_LaterInitParam::initType
	int32_t ___initType_9;

public:
	inline static int32_t get_offset_of_useAsync_0() { return static_cast<int32_t>(offsetof(LaterInitParam_tE2FFFA55A2C7B183721762B4AC4B0DF93485A1AF, ___useAsync_0)); }
	inline bool get_useAsync_0() const { return ___useAsync_0; }
	inline bool* get_address_of_useAsync_0() { return &___useAsync_0; }
	inline void set_useAsync_0(bool value)
	{
		___useAsync_0 = value;
	}

	inline static int32_t get_offset_of_inputStream_1() { return static_cast<int32_t>(offsetof(LaterInitParam_tE2FFFA55A2C7B183721762B4AC4B0DF93485A1AF, ___inputStream_1)); }
	inline Stream_tFC50657DD5AAB87770987F9179D934A51D99D5E7 * get_inputStream_1() const { return ___inputStream_1; }
	inline Stream_tFC50657DD5AAB87770987F9179D934A51D99D5E7 ** get_address_of_inputStream_1() { return &___inputStream_1; }
	inline void set_inputStream_1(Stream_tFC50657DD5AAB87770987F9179D934A51D99D5E7 * value)
	{
		___inputStream_1 = value;
		Il2CppCodeGenWriteBarrier((&___inputStream_1), value);
	}

	inline static int32_t get_offset_of_inputBytes_2() { return static_cast<int32_t>(offsetof(LaterInitParam_tE2FFFA55A2C7B183721762B4AC4B0DF93485A1AF, ___inputBytes_2)); }
	inline ByteU5BU5D_tD06FDBE8142446525DF1C40351D523A228373821* get_inputBytes_2() const { return ___inputBytes_2; }
	inline ByteU5BU5D_tD06FDBE8142446525DF1C40351D523A228373821** get_address_of_inputBytes_2() { return &___inputBytes_2; }
	inline void set_inputBytes_2(ByteU5BU5D_tD06FDBE8142446525DF1C40351D523A228373821* value)
	{
		___inputBytes_2 = value;
		Il2CppCodeGenWriteBarrier((&___inputBytes_2), value);
	}

	inline static int32_t get_offset_of_inputByteCount_3() { return static_cast<int32_t>(offsetof(LaterInitParam_tE2FFFA55A2C7B183721762B4AC4B0DF93485A1AF, ___inputByteCount_3)); }
	inline int32_t get_inputByteCount_3() const { return ___inputByteCount_3; }
	inline int32_t* get_address_of_inputByteCount_3() { return &___inputByteCount_3; }
	inline void set_inputByteCount_3(int32_t value)
	{
		___inputByteCount_3 = value;
	}

	inline static int32_t get_offset_of_inputbaseUri_4() { return static_cast<int32_t>(offsetof(LaterInitParam_tE2FFFA55A2C7B183721762B4AC4B0DF93485A1AF, ___inputbaseUri_4)); }
	inline Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E * get_inputbaseUri_4() const { return ___inputbaseUri_4; }
	inline Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E ** get_address_of_inputbaseUri_4() { return &___inputbaseUri_4; }
	inline void set_inputbaseUri_4(Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E * value)
	{
		___inputbaseUri_4 = value;
		Il2CppCodeGenWriteBarrier((&___inputbaseUri_4), value);
	}

	inline static int32_t get_offset_of_inputUriStr_5() { return static_cast<int32_t>(offsetof(LaterInitParam_tE2FFFA55A2C7B183721762B4AC4B0DF93485A1AF, ___inputUriStr_5)); }
	inline String_t* get_inputUriStr_5() const { return ___inputUriStr_5; }
	inline String_t** get_address_of_inputUriStr_5() { return &___inputUriStr_5; }
	inline void set_inputUriStr_5(String_t* value)
	{
		___inputUriStr_5 = value;
		Il2CppCodeGenWriteBarrier((&___inputUriStr_5), value);
	}

	inline static int32_t get_offset_of_inputUriResolver_6() { return static_cast<int32_t>(offsetof(LaterInitParam_tE2FFFA55A2C7B183721762B4AC4B0DF93485A1AF, ___inputUriResolver_6)); }
	inline XmlResolver_t93269F14B2F8750D040AED2FB7A303CE85016280 * get_inputUriResolver_6() const { return ___inputUriResolver_6; }
	inline XmlResolver_t93269F14B2F8750D040AED2FB7A303CE85016280 ** get_address_of_inputUriResolver_6() { return &___inputUriResolver_6; }
	inline void set_inputUriResolver_6(XmlResolver_t93269F14B2F8750D040AED2FB7A303CE85016280 * value)
	{
		___inputUriResolver_6 = value;
		Il2CppCodeGenWriteBarrier((&___inputUriResolver_6), value);
	}

	inline static int32_t get_offset_of_inputContext_7() { return static_cast<int32_t>(offsetof(LaterInitParam_tE2FFFA55A2C7B183721762B4AC4B0DF93485A1AF, ___inputContext_7)); }
	inline XmlParserContext_tDC3A95452BC683F0D64EC3C4AF9934D3FC732279 * get_inputContext_7() const { return ___inputContext_7; }
	inline XmlParserContext_tDC3A95452BC683F0D64EC3C4AF9934D3FC732279 ** get_address_of_inputContext_7() { return &___inputContext_7; }
	inline void set_inputContext_7(XmlParserContext_tDC3A95452BC683F0D64EC3C4AF9934D3FC732279 * value)
	{
		___inputContext_7 = value;
		Il2CppCodeGenWriteBarrier((&___inputContext_7), value);
	}

	inline static int32_t get_offset_of_inputTextReader_8() { return static_cast<int32_t>(offsetof(LaterInitParam_tE2FFFA55A2C7B183721762B4AC4B0DF93485A1AF, ___inputTextReader_8)); }
	inline TextReader_t7DF8314B601D202ECFEDF623093A87BFDAB58D0A * get_inputTextReader_8() const { return ___inputTextReader_8; }
	inline TextReader_t7DF8314B601D202ECFEDF623093A87BFDAB58D0A ** get_address_of_inputTextReader_8() { return &___inputTextReader_8; }
	inline void set_inputTextReader_8(TextReader_t7DF8314B601D202ECFEDF623093A87BFDAB58D0A * value)
	{
		___inputTextReader_8 = value;
		Il2CppCodeGenWriteBarrier((&___inputTextReader_8), value);
	}

	inline static int32_t get_offset_of_initType_9() { return static_cast<int32_t>(offsetof(LaterInitParam_tE2FFFA55A2C7B183721762B4AC4B0DF93485A1AF, ___initType_9)); }
	inline int32_t get_initType_9() const { return ___initType_9; }
	inline int32_t* get_address_of_initType_9() { return &___initType_9; }
	inline void set_initType_9(int32_t value)
	{
		___initType_9 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // LATERINITPARAM_TE2FFFA55A2C7B183721762B4AC4B0DF93485A1AF_H
#ifndef NODEDATA_TAACF4D5ECADB9124568D01525E72D14495BC5ACF_H
#define NODEDATA_TAACF4D5ECADB9124568D01525E72D14495BC5ACF_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.XmlTextReaderImpl_NodeData
struct  NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF  : public RuntimeObject
{
public:
	// System.Xml.XmlNodeType System.Xml.XmlTextReaderImpl_NodeData::type
	int32_t ___type_1;
	// System.String System.Xml.XmlTextReaderImpl_NodeData::localName
	String_t* ___localName_2;
	// System.String System.Xml.XmlTextReaderImpl_NodeData::prefix
	String_t* ___prefix_3;
	// System.String System.Xml.XmlTextReaderImpl_NodeData::ns
	String_t* ___ns_4;
	// System.String System.Xml.XmlTextReaderImpl_NodeData::nameWPrefix
	String_t* ___nameWPrefix_5;
	// System.String System.Xml.XmlTextReaderImpl_NodeData::value
	String_t* ___value_6;
	// System.Char[] System.Xml.XmlTextReaderImpl_NodeData::chars
	CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2* ___chars_7;
	// System.Int32 System.Xml.XmlTextReaderImpl_NodeData::valueStartPos
	int32_t ___valueStartPos_8;
	// System.Int32 System.Xml.XmlTextReaderImpl_NodeData::valueLength
	int32_t ___valueLength_9;
	// System.Xml.LineInfo System.Xml.XmlTextReaderImpl_NodeData::lineInfo
	LineInfo_t7E3D50496C7BA51B84D485D0A30B9006943544E5  ___lineInfo_10;
	// System.Xml.LineInfo System.Xml.XmlTextReaderImpl_NodeData::lineInfo2
	LineInfo_t7E3D50496C7BA51B84D485D0A30B9006943544E5  ___lineInfo2_11;
	// System.Char System.Xml.XmlTextReaderImpl_NodeData::quoteChar
	Il2CppChar ___quoteChar_12;
	// System.Int32 System.Xml.XmlTextReaderImpl_NodeData::depth
	int32_t ___depth_13;
	// System.Boolean System.Xml.XmlTextReaderImpl_NodeData::isEmptyOrDefault
	bool ___isEmptyOrDefault_14;
	// System.Int32 System.Xml.XmlTextReaderImpl_NodeData::entityId
	int32_t ___entityId_15;
	// System.Boolean System.Xml.XmlTextReaderImpl_NodeData::xmlContextPushed
	bool ___xmlContextPushed_16;
	// System.Xml.XmlTextReaderImpl_NodeData System.Xml.XmlTextReaderImpl_NodeData::nextAttrValueChunk
	NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * ___nextAttrValueChunk_17;
	// System.Object System.Xml.XmlTextReaderImpl_NodeData::schemaType
	RuntimeObject * ___schemaType_18;
	// System.Object System.Xml.XmlTextReaderImpl_NodeData::typedValue
	RuntimeObject * ___typedValue_19;

public:
	inline static int32_t get_offset_of_type_1() { return static_cast<int32_t>(offsetof(NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF, ___type_1)); }
	inline int32_t get_type_1() const { return ___type_1; }
	inline int32_t* get_address_of_type_1() { return &___type_1; }
	inline void set_type_1(int32_t value)
	{
		___type_1 = value;
	}

	inline static int32_t get_offset_of_localName_2() { return static_cast<int32_t>(offsetof(NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF, ___localName_2)); }
	inline String_t* get_localName_2() const { return ___localName_2; }
	inline String_t** get_address_of_localName_2() { return &___localName_2; }
	inline void set_localName_2(String_t* value)
	{
		___localName_2 = value;
		Il2CppCodeGenWriteBarrier((&___localName_2), value);
	}

	inline static int32_t get_offset_of_prefix_3() { return static_cast<int32_t>(offsetof(NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF, ___prefix_3)); }
	inline String_t* get_prefix_3() const { return ___prefix_3; }
	inline String_t** get_address_of_prefix_3() { return &___prefix_3; }
	inline void set_prefix_3(String_t* value)
	{
		___prefix_3 = value;
		Il2CppCodeGenWriteBarrier((&___prefix_3), value);
	}

	inline static int32_t get_offset_of_ns_4() { return static_cast<int32_t>(offsetof(NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF, ___ns_4)); }
	inline String_t* get_ns_4() const { return ___ns_4; }
	inline String_t** get_address_of_ns_4() { return &___ns_4; }
	inline void set_ns_4(String_t* value)
	{
		___ns_4 = value;
		Il2CppCodeGenWriteBarrier((&___ns_4), value);
	}

	inline static int32_t get_offset_of_nameWPrefix_5() { return static_cast<int32_t>(offsetof(NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF, ___nameWPrefix_5)); }
	inline String_t* get_nameWPrefix_5() const { return ___nameWPrefix_5; }
	inline String_t** get_address_of_nameWPrefix_5() { return &___nameWPrefix_5; }
	inline void set_nameWPrefix_5(String_t* value)
	{
		___nameWPrefix_5 = value;
		Il2CppCodeGenWriteBarrier((&___nameWPrefix_5), value);
	}

	inline static int32_t get_offset_of_value_6() { return static_cast<int32_t>(offsetof(NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF, ___value_6)); }
	inline String_t* get_value_6() const { return ___value_6; }
	inline String_t** get_address_of_value_6() { return &___value_6; }
	inline void set_value_6(String_t* value)
	{
		___value_6 = value;
		Il2CppCodeGenWriteBarrier((&___value_6), value);
	}

	inline static int32_t get_offset_of_chars_7() { return static_cast<int32_t>(offsetof(NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF, ___chars_7)); }
	inline CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2* get_chars_7() const { return ___chars_7; }
	inline CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2** get_address_of_chars_7() { return &___chars_7; }
	inline void set_chars_7(CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2* value)
	{
		___chars_7 = value;
		Il2CppCodeGenWriteBarrier((&___chars_7), value);
	}

	inline static int32_t get_offset_of_valueStartPos_8() { return static_cast<int32_t>(offsetof(NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF, ___valueStartPos_8)); }
	inline int32_t get_valueStartPos_8() const { return ___valueStartPos_8; }
	inline int32_t* get_address_of_valueStartPos_8() { return &___valueStartPos_8; }
	inline void set_valueStartPos_8(int32_t value)
	{
		___valueStartPos_8 = value;
	}

	inline static int32_t get_offset_of_valueLength_9() { return static_cast<int32_t>(offsetof(NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF, ___valueLength_9)); }
	inline int32_t get_valueLength_9() const { return ___valueLength_9; }
	inline int32_t* get_address_of_valueLength_9() { return &___valueLength_9; }
	inline void set_valueLength_9(int32_t value)
	{
		___valueLength_9 = value;
	}

	inline static int32_t get_offset_of_lineInfo_10() { return static_cast<int32_t>(offsetof(NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF, ___lineInfo_10)); }
	inline LineInfo_t7E3D50496C7BA51B84D485D0A30B9006943544E5  get_lineInfo_10() const { return ___lineInfo_10; }
	inline LineInfo_t7E3D50496C7BA51B84D485D0A30B9006943544E5 * get_address_of_lineInfo_10() { return &___lineInfo_10; }
	inline void set_lineInfo_10(LineInfo_t7E3D50496C7BA51B84D485D0A30B9006943544E5  value)
	{
		___lineInfo_10 = value;
	}

	inline static int32_t get_offset_of_lineInfo2_11() { return static_cast<int32_t>(offsetof(NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF, ___lineInfo2_11)); }
	inline LineInfo_t7E3D50496C7BA51B84D485D0A30B9006943544E5  get_lineInfo2_11() const { return ___lineInfo2_11; }
	inline LineInfo_t7E3D50496C7BA51B84D485D0A30B9006943544E5 * get_address_of_lineInfo2_11() { return &___lineInfo2_11; }
	inline void set_lineInfo2_11(LineInfo_t7E3D50496C7BA51B84D485D0A30B9006943544E5  value)
	{
		___lineInfo2_11 = value;
	}

	inline static int32_t get_offset_of_quoteChar_12() { return static_cast<int32_t>(offsetof(NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF, ___quoteChar_12)); }
	inline Il2CppChar get_quoteChar_12() const { return ___quoteChar_12; }
	inline Il2CppChar* get_address_of_quoteChar_12() { return &___quoteChar_12; }
	inline void set_quoteChar_12(Il2CppChar value)
	{
		___quoteChar_12 = value;
	}

	inline static int32_t get_offset_of_depth_13() { return static_cast<int32_t>(offsetof(NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF, ___depth_13)); }
	inline int32_t get_depth_13() const { return ___depth_13; }
	inline int32_t* get_address_of_depth_13() { return &___depth_13; }
	inline void set_depth_13(int32_t value)
	{
		___depth_13 = value;
	}

	inline static int32_t get_offset_of_isEmptyOrDefault_14() { return static_cast<int32_t>(offsetof(NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF, ___isEmptyOrDefault_14)); }
	inline bool get_isEmptyOrDefault_14() const { return ___isEmptyOrDefault_14; }
	inline bool* get_address_of_isEmptyOrDefault_14() { return &___isEmptyOrDefault_14; }
	inline void set_isEmptyOrDefault_14(bool value)
	{
		___isEmptyOrDefault_14 = value;
	}

	inline static int32_t get_offset_of_entityId_15() { return static_cast<int32_t>(offsetof(NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF, ___entityId_15)); }
	inline int32_t get_entityId_15() const { return ___entityId_15; }
	inline int32_t* get_address_of_entityId_15() { return &___entityId_15; }
	inline void set_entityId_15(int32_t value)
	{
		___entityId_15 = value;
	}

	inline static int32_t get_offset_of_xmlContextPushed_16() { return static_cast<int32_t>(offsetof(NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF, ___xmlContextPushed_16)); }
	inline bool get_xmlContextPushed_16() const { return ___xmlContextPushed_16; }
	inline bool* get_address_of_xmlContextPushed_16() { return &___xmlContextPushed_16; }
	inline void set_xmlContextPushed_16(bool value)
	{
		___xmlContextPushed_16 = value;
	}

	inline static int32_t get_offset_of_nextAttrValueChunk_17() { return static_cast<int32_t>(offsetof(NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF, ___nextAttrValueChunk_17)); }
	inline NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * get_nextAttrValueChunk_17() const { return ___nextAttrValueChunk_17; }
	inline NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF ** get_address_of_nextAttrValueChunk_17() { return &___nextAttrValueChunk_17; }
	inline void set_nextAttrValueChunk_17(NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * value)
	{
		___nextAttrValueChunk_17 = value;
		Il2CppCodeGenWriteBarrier((&___nextAttrValueChunk_17), value);
	}

	inline static int32_t get_offset_of_schemaType_18() { return static_cast<int32_t>(offsetof(NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF, ___schemaType_18)); }
	inline RuntimeObject * get_schemaType_18() const { return ___schemaType_18; }
	inline RuntimeObject ** get_address_of_schemaType_18() { return &___schemaType_18; }
	inline void set_schemaType_18(RuntimeObject * value)
	{
		___schemaType_18 = value;
		Il2CppCodeGenWriteBarrier((&___schemaType_18), value);
	}

	inline static int32_t get_offset_of_typedValue_19() { return static_cast<int32_t>(offsetof(NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF, ___typedValue_19)); }
	inline RuntimeObject * get_typedValue_19() const { return ___typedValue_19; }
	inline RuntimeObject ** get_address_of_typedValue_19() { return &___typedValue_19; }
	inline void set_typedValue_19(RuntimeObject * value)
	{
		___typedValue_19 = value;
		Il2CppCodeGenWriteBarrier((&___typedValue_19), value);
	}
};

struct NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF_StaticFields
{
public:
	// System.Xml.XmlTextReaderImpl_NodeData modreq(System.Runtime.CompilerServices.IsVolatile) System.Xml.XmlTextReaderImpl_NodeData::s_None
	NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * ___s_None_0;

public:
	inline static int32_t get_offset_of_s_None_0() { return static_cast<int32_t>(offsetof(NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF_StaticFields, ___s_None_0)); }
	inline NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * get_s_None_0() const { return ___s_None_0; }
	inline NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF ** get_address_of_s_None_0() { return &___s_None_0; }
	inline void set_s_None_0(NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * value)
	{
		___s_None_0 = value;
		Il2CppCodeGenWriteBarrier((&___s_None_0), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NODEDATA_TAACF4D5ECADB9124568D01525E72D14495BC5ACF_H
#ifndef XMLCONTEXT_TC94B1A0D023B096ADF338FA72FB55D0E2DBF9B52_H
#define XMLCONTEXT_TC94B1A0D023B096ADF338FA72FB55D0E2DBF9B52_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.XmlTextReaderImpl_XmlContext
struct  XmlContext_tC94B1A0D023B096ADF338FA72FB55D0E2DBF9B52  : public RuntimeObject
{
public:
	// System.Xml.XmlSpace System.Xml.XmlTextReaderImpl_XmlContext::xmlSpace
	int32_t ___xmlSpace_0;
	// System.String System.Xml.XmlTextReaderImpl_XmlContext::xmlLang
	String_t* ___xmlLang_1;
	// System.String System.Xml.XmlTextReaderImpl_XmlContext::defaultNamespace
	String_t* ___defaultNamespace_2;
	// System.Xml.XmlTextReaderImpl_XmlContext System.Xml.XmlTextReaderImpl_XmlContext::previousContext
	XmlContext_tC94B1A0D023B096ADF338FA72FB55D0E2DBF9B52 * ___previousContext_3;

public:
	inline static int32_t get_offset_of_xmlSpace_0() { return static_cast<int32_t>(offsetof(XmlContext_tC94B1A0D023B096ADF338FA72FB55D0E2DBF9B52, ___xmlSpace_0)); }
	inline int32_t get_xmlSpace_0() const { return ___xmlSpace_0; }
	inline int32_t* get_address_of_xmlSpace_0() { return &___xmlSpace_0; }
	inline void set_xmlSpace_0(int32_t value)
	{
		___xmlSpace_0 = value;
	}

	inline static int32_t get_offset_of_xmlLang_1() { return static_cast<int32_t>(offsetof(XmlContext_tC94B1A0D023B096ADF338FA72FB55D0E2DBF9B52, ___xmlLang_1)); }
	inline String_t* get_xmlLang_1() const { return ___xmlLang_1; }
	inline String_t** get_address_of_xmlLang_1() { return &___xmlLang_1; }
	inline void set_xmlLang_1(String_t* value)
	{
		___xmlLang_1 = value;
		Il2CppCodeGenWriteBarrier((&___xmlLang_1), value);
	}

	inline static int32_t get_offset_of_defaultNamespace_2() { return static_cast<int32_t>(offsetof(XmlContext_tC94B1A0D023B096ADF338FA72FB55D0E2DBF9B52, ___defaultNamespace_2)); }
	inline String_t* get_defaultNamespace_2() const { return ___defaultNamespace_2; }
	inline String_t** get_address_of_defaultNamespace_2() { return &___defaultNamespace_2; }
	inline void set_defaultNamespace_2(String_t* value)
	{
		___defaultNamespace_2 = value;
		Il2CppCodeGenWriteBarrier((&___defaultNamespace_2), value);
	}

	inline static int32_t get_offset_of_previousContext_3() { return static_cast<int32_t>(offsetof(XmlContext_tC94B1A0D023B096ADF338FA72FB55D0E2DBF9B52, ___previousContext_3)); }
	inline XmlContext_tC94B1A0D023B096ADF338FA72FB55D0E2DBF9B52 * get_previousContext_3() const { return ___previousContext_3; }
	inline XmlContext_tC94B1A0D023B096ADF338FA72FB55D0E2DBF9B52 ** get_address_of_previousContext_3() { return &___previousContext_3; }
	inline void set_previousContext_3(XmlContext_tC94B1A0D023B096ADF338FA72FB55D0E2DBF9B52 * value)
	{
		___previousContext_3 = value;
		Il2CppCodeGenWriteBarrier((&___previousContext_3), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // XMLCONTEXT_TC94B1A0D023B096ADF338FA72FB55D0E2DBF9B52_H
#ifndef U3CGETENTITYASYNCU3ED__15_T383C4608618A66FB04F41F38C0534EE9E14CC934_H
#define U3CGETENTITYASYNCU3ED__15_T383C4608618A66FB04F41F38C0534EE9E14CC934_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.XmlUrlResolver_<GetEntityAsync>d__15
struct  U3CGetEntityAsyncU3Ed__15_t383C4608618A66FB04F41F38C0534EE9E14CC934 
{
public:
	// System.Int32 System.Xml.XmlUrlResolver_<GetEntityAsync>d__15::<>1__state
	int32_t ___U3CU3E1__state_0;
	// System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object> System.Xml.XmlUrlResolver_<GetEntityAsync>d__15::<>t__builder
	AsyncTaskMethodBuilder_1_t2A9513A084F4B19851B91EF1F22BB57776D35663  ___U3CU3Et__builder_1;
	// System.Type System.Xml.XmlUrlResolver_<GetEntityAsync>d__15::ofObjectToReturn
	Type_t * ___ofObjectToReturn_2;
	// System.Uri System.Xml.XmlUrlResolver_<GetEntityAsync>d__15::absoluteUri
	Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E * ___absoluteUri_3;
	// System.Xml.XmlUrlResolver System.Xml.XmlUrlResolver_<GetEntityAsync>d__15::<>4__this
	XmlUrlResolver_t43FE24F4601B4197354EFB5783E5CB9F57997EC9 * ___U3CU3E4__this_4;
	// System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1_ConfiguredTaskAwaiter<System.IO.Stream> System.Xml.XmlUrlResolver_<GetEntityAsync>d__15::<>u__1
	ConfiguredTaskAwaiter_t27ECAA4B74502BD3AC7E68F47088D46DAA13D133  ___U3CU3Eu__1_5;

public:
	inline static int32_t get_offset_of_U3CU3E1__state_0() { return static_cast<int32_t>(offsetof(U3CGetEntityAsyncU3Ed__15_t383C4608618A66FB04F41F38C0534EE9E14CC934, ___U3CU3E1__state_0)); }
	inline int32_t get_U3CU3E1__state_0() const { return ___U3CU3E1__state_0; }
	inline int32_t* get_address_of_U3CU3E1__state_0() { return &___U3CU3E1__state_0; }
	inline void set_U3CU3E1__state_0(int32_t value)
	{
		___U3CU3E1__state_0 = value;
	}

	inline static int32_t get_offset_of_U3CU3Et__builder_1() { return static_cast<int32_t>(offsetof(U3CGetEntityAsyncU3Ed__15_t383C4608618A66FB04F41F38C0534EE9E14CC934, ___U3CU3Et__builder_1)); }
	inline AsyncTaskMethodBuilder_1_t2A9513A084F4B19851B91EF1F22BB57776D35663  get_U3CU3Et__builder_1() const { return ___U3CU3Et__builder_1; }
	inline AsyncTaskMethodBuilder_1_t2A9513A084F4B19851B91EF1F22BB57776D35663 * get_address_of_U3CU3Et__builder_1() { return &___U3CU3Et__builder_1; }
	inline void set_U3CU3Et__builder_1(AsyncTaskMethodBuilder_1_t2A9513A084F4B19851B91EF1F22BB57776D35663  value)
	{
		___U3CU3Et__builder_1 = value;
	}

	inline static int32_t get_offset_of_ofObjectToReturn_2() { return static_cast<int32_t>(offsetof(U3CGetEntityAsyncU3Ed__15_t383C4608618A66FB04F41F38C0534EE9E14CC934, ___ofObjectToReturn_2)); }
	inline Type_t * get_ofObjectToReturn_2() const { return ___ofObjectToReturn_2; }
	inline Type_t ** get_address_of_ofObjectToReturn_2() { return &___ofObjectToReturn_2; }
	inline void set_ofObjectToReturn_2(Type_t * value)
	{
		___ofObjectToReturn_2 = value;
		Il2CppCodeGenWriteBarrier((&___ofObjectToReturn_2), value);
	}

	inline static int32_t get_offset_of_absoluteUri_3() { return static_cast<int32_t>(offsetof(U3CGetEntityAsyncU3Ed__15_t383C4608618A66FB04F41F38C0534EE9E14CC934, ___absoluteUri_3)); }
	inline Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E * get_absoluteUri_3() const { return ___absoluteUri_3; }
	inline Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E ** get_address_of_absoluteUri_3() { return &___absoluteUri_3; }
	inline void set_absoluteUri_3(Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E * value)
	{
		___absoluteUri_3 = value;
		Il2CppCodeGenWriteBarrier((&___absoluteUri_3), value);
	}

	inline static int32_t get_offset_of_U3CU3E4__this_4() { return static_cast<int32_t>(offsetof(U3CGetEntityAsyncU3Ed__15_t383C4608618A66FB04F41F38C0534EE9E14CC934, ___U3CU3E4__this_4)); }
	inline XmlUrlResolver_t43FE24F4601B4197354EFB5783E5CB9F57997EC9 * get_U3CU3E4__this_4() const { return ___U3CU3E4__this_4; }
	inline XmlUrlResolver_t43FE24F4601B4197354EFB5783E5CB9F57997EC9 ** get_address_of_U3CU3E4__this_4() { return &___U3CU3E4__this_4; }
	inline void set_U3CU3E4__this_4(XmlUrlResolver_t43FE24F4601B4197354EFB5783E5CB9F57997EC9 * value)
	{
		___U3CU3E4__this_4 = value;
		Il2CppCodeGenWriteBarrier((&___U3CU3E4__this_4), value);
	}

	inline static int32_t get_offset_of_U3CU3Eu__1_5() { return static_cast<int32_t>(offsetof(U3CGetEntityAsyncU3Ed__15_t383C4608618A66FB04F41F38C0534EE9E14CC934, ___U3CU3Eu__1_5)); }
	inline ConfiguredTaskAwaiter_t27ECAA4B74502BD3AC7E68F47088D46DAA13D133  get_U3CU3Eu__1_5() const { return ___U3CU3Eu__1_5; }
	inline ConfiguredTaskAwaiter_t27ECAA4B74502BD3AC7E68F47088D46DAA13D133 * get_address_of_U3CU3Eu__1_5() { return &___U3CU3Eu__1_5; }
	inline void set_U3CU3Eu__1_5(ConfiguredTaskAwaiter_t27ECAA4B74502BD3AC7E68F47088D46DAA13D133  value)
	{
		___U3CU3Eu__1_5 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // U3CGETENTITYASYNCU3ED__15_T383C4608618A66FB04F41F38C0534EE9E14CC934_H
#ifndef XMLWHITESPACE_TF5EA718743A148EBF7594ADF5A06B3224857AD4D_H
#define XMLWHITESPACE_TF5EA718743A148EBF7594ADF5A06B3224857AD4D_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.XmlWhitespace
struct  XmlWhitespace_tF5EA718743A148EBF7594ADF5A06B3224857AD4D  : public XmlCharacterData_tA7587D706680E42BD7A094F87CB0859C840A8531
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // XMLWHITESPACE_TF5EA718743A148EBF7594ADF5A06B3224857AD4D_H
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
#ifndef ONDEFAULTATTRIBUTEUSEDELEGATE_TE83A97BD37E08D3C5AA377CEA6388782D99EA34D_H
#define ONDEFAULTATTRIBUTEUSEDELEGATE_TE83A97BD37E08D3C5AA377CEA6388782D99EA34D_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Xml.XmlTextReaderImpl_OnDefaultAttributeUseDelegate
struct  OnDefaultAttributeUseDelegate_tE83A97BD37E08D3C5AA377CEA6388782D99EA34D  : public MulticastDelegate_t
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // ONDEFAULTATTRIBUTEUSEDELEGATE_TE83A97BD37E08D3C5AA377CEA6388782D99EA34D_H
// System.Char[]
struct CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) Il2CppChar m_Items[1];

public:
	inline Il2CppChar GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Il2CppChar* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Il2CppChar value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline Il2CppChar GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Il2CppChar* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Il2CppChar value)
	{
		m_Items[index] = value;
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
// System.Byte[]
struct ByteU5BU5D_tD06FDBE8142446525DF1C40351D523A228373821  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) uint8_t m_Items[1];

public:
	inline uint8_t GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline uint8_t* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, uint8_t value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline uint8_t GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline uint8_t* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, uint8_t value)
	{
		m_Items[index] = value;
	}
};


// System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<!0> System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>::Create()
extern "C" IL2CPP_METHOD_ATTR AsyncTaskMethodBuilder_1_t2A9513A084F4B19851B91EF1F22BB57776D35663  AsyncTaskMethodBuilder_1_Create_mC7806A5C115ED2239A5073313AA3564D8244156E_gshared (const RuntimeMethod* method);
// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>::Start<System.Xml.XmlUrlResolver/<GetEntityAsync>d__15>(!!0&)
extern "C" IL2CPP_METHOD_ATTR void AsyncTaskMethodBuilder_1_Start_TisU3CGetEntityAsyncU3Ed__15_t383C4608618A66FB04F41F38C0534EE9E14CC934_mF03E454780149AFBE6F88C60A4283797936195AD_gshared (AsyncTaskMethodBuilder_1_t2A9513A084F4B19851B91EF1F22BB57776D35663 * __this, U3CGetEntityAsyncU3Ed__15_t383C4608618A66FB04F41F38C0534EE9E14CC934 * p0, const RuntimeMethod* method);
// System.Threading.Tasks.Task`1<!0> System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>::get_Task()
extern "C" IL2CPP_METHOD_ATTR Task_1_tA56001ED5270173CA1432EDFCD84EABB1024BC09 * AsyncTaskMethodBuilder_1_get_Task_m19C5664D70C4FC799BEFB8D0FC98E687F97059FA_gshared (AsyncTaskMethodBuilder_1_t2A9513A084F4B19851B91EF1F22BB57776D35663 * __this, const RuntimeMethod* method);
// System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<!0> System.Threading.Tasks.Task`1<System.Object>::ConfigureAwait(System.Boolean)
extern "C" IL2CPP_METHOD_ATTR ConfiguredTaskAwaitable_1_tA36F8230F9392F8C09FD6FDBAEA3F1A41388CCA8  Task_1_ConfigureAwait_m60DD864D9488EACBA6C087E87E448797C1C8B76B_gshared (Task_1_tA56001ED5270173CA1432EDFCD84EABB1024BC09 * __this, bool p0, const RuntimeMethod* method);
// System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1/ConfiguredTaskAwaiter<!0> System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<System.Object>::GetAwaiter()
extern "C" IL2CPP_METHOD_ATTR ConfiguredTaskAwaiter_tFB3C4197768C6CF02BE088F703AA6E46D703D46E  ConfiguredTaskAwaitable_1_GetAwaiter_m86C543D72022CB5D0C43053C4AF5F37EA4E690A7_gshared (ConfiguredTaskAwaitable_1_tA36F8230F9392F8C09FD6FDBAEA3F1A41388CCA8 * __this, const RuntimeMethod* method);
// System.Boolean System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1/ConfiguredTaskAwaiter<System.Object>::get_IsCompleted()
extern "C" IL2CPP_METHOD_ATTR bool ConfiguredTaskAwaiter_get_IsCompleted_mA1F08104B225C8640528B38BFD0AAAEE84541586_gshared (ConfiguredTaskAwaiter_tFB3C4197768C6CF02BE088F703AA6E46D703D46E * __this, const RuntimeMethod* method);
// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>::AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1/ConfiguredTaskAwaiter<System.Object>,System.Xml.XmlUrlResolver/<GetEntityAsync>d__15>(!!0&,!!1&)
extern "C" IL2CPP_METHOD_ATTR void AsyncTaskMethodBuilder_1_AwaitUnsafeOnCompleted_TisConfiguredTaskAwaiter_tFB3C4197768C6CF02BE088F703AA6E46D703D46E_TisU3CGetEntityAsyncU3Ed__15_t383C4608618A66FB04F41F38C0534EE9E14CC934_mF317CFCC50E2EC331EA7CC77DD06EFC53A6DC83E_gshared (AsyncTaskMethodBuilder_1_t2A9513A084F4B19851B91EF1F22BB57776D35663 * __this, ConfiguredTaskAwaiter_tFB3C4197768C6CF02BE088F703AA6E46D703D46E * p0, U3CGetEntityAsyncU3Ed__15_t383C4608618A66FB04F41F38C0534EE9E14CC934 * p1, const RuntimeMethod* method);
// !0 System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1/ConfiguredTaskAwaiter<System.Object>::GetResult()
extern "C" IL2CPP_METHOD_ATTR RuntimeObject * ConfiguredTaskAwaiter_GetResult_m4EE5BF4F8536CCC951CA3F4E3C494411AE2D507E_gshared (ConfiguredTaskAwaiter_tFB3C4197768C6CF02BE088F703AA6E46D703D46E * __this, const RuntimeMethod* method);
// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>::SetException(System.Exception)
extern "C" IL2CPP_METHOD_ATTR void AsyncTaskMethodBuilder_1_SetException_m4C0B5462ECCB520FACA3C90B353DF596DAAF586D_gshared (AsyncTaskMethodBuilder_1_t2A9513A084F4B19851B91EF1F22BB57776D35663 * __this, Exception_t * p0, const RuntimeMethod* method);
// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>::SetResult(!0)
extern "C" IL2CPP_METHOD_ATTR void AsyncTaskMethodBuilder_1_SetResult_mD7DA7A17DC0610B11A0AAA364C3CA51FEC1271DB_gshared (AsyncTaskMethodBuilder_1_t2A9513A084F4B19851B91EF1F22BB57776D35663 * __this, RuntimeObject * p0, const RuntimeMethod* method);
// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>::SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine)
extern "C" IL2CPP_METHOD_ATTR void AsyncTaskMethodBuilder_1_SetStateMachine_m5CC21A02320CF3D2DD7894A31123DFD82A428E4C_gshared (AsyncTaskMethodBuilder_1_t2A9513A084F4B19851B91EF1F22BB57776D35663 * __this, RuntimeObject* p0, const RuntimeMethod* method);

// System.Void System.Xml.XmlException::.ctor(System.String,System.String)
extern "C" IL2CPP_METHOD_ATTR void XmlException__ctor_mD27C8593D4F5978D5B419DA73EB60B23D80CC9E4 (XmlException_tD7DA2CBE07488D18EE7A284862B7523E3CD4365D * __this, String_t* ___res0, String_t* ___arg1, const RuntimeMethod* method);
// System.Int32 System.String::Compare(System.String,System.String,System.StringComparison)
extern "C" IL2CPP_METHOD_ATTR int32_t String_Compare_m5BD1EF8904C9B13BEDB7A876B122F117B317B442 (String_t* p0, String_t* p1, int32_t p2, const RuntimeMethod* method);
// System.Void System.Object::.ctor()
extern "C" IL2CPP_METHOD_ATTR void Object__ctor_m925ECA5E85CA100E3FB86A4F9E15C120E9A184C0 (RuntimeObject * __this, const RuntimeMethod* method);
// System.Void System.Xml.XmlTextReaderImpl/DtdDefaultAttributeInfoToNodeDataComparer::.ctor()
extern "C" IL2CPP_METHOD_ATTR void DtdDefaultAttributeInfoToNodeDataComparer__ctor_mE7BC53A14858DE5CD693E0E8C5E35D798BA1E358 (DtdDefaultAttributeInfoToNodeDataComparer_t0B9FEF7A80832980C3E32D47BE835964E8B423B7 * __this, const RuntimeMethod* method);
// System.Xml.XmlNameTable System.Xml.XmlTextReaderImpl::get_DtdParserProxy_NameTable()
extern "C" IL2CPP_METHOD_ATTR XmlNameTable_t3C1CDAB4E7D97DE41A409D6D9ADD2C10B1F281A6 * XmlTextReaderImpl_get_DtdParserProxy_NameTable_mC74340532F97E8B584DBB1118A91BB326437040F (XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * __this, const RuntimeMethod* method);
// System.Xml.IXmlNamespaceResolver System.Xml.XmlTextReaderImpl::get_DtdParserProxy_NamespaceResolver()
extern "C" IL2CPP_METHOD_ATTR RuntimeObject* XmlTextReaderImpl_get_DtdParserProxy_NamespaceResolver_mC3EB3FE6FCD70248450386A5EB990F2163A1CC3D (XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * __this, const RuntimeMethod* method);
// System.Uri System.Xml.XmlTextReaderImpl::get_DtdParserProxy_BaseUri()
extern "C" IL2CPP_METHOD_ATTR Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E * XmlTextReaderImpl_get_DtdParserProxy_BaseUri_mF2E4A50579AF488866944F856C4AD8BE411DACF7 (XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * __this, const RuntimeMethod* method);
// System.Boolean System.Xml.XmlTextReaderImpl::get_DtdParserProxy_IsEof()
extern "C" IL2CPP_METHOD_ATTR bool XmlTextReaderImpl_get_DtdParserProxy_IsEof_mF3D72303461DE771D8C45C2E3A1B69A6D0AC8F46 (XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * __this, const RuntimeMethod* method);
// System.Char[] System.Xml.XmlTextReaderImpl::get_DtdParserProxy_ParsingBuffer()
extern "C" IL2CPP_METHOD_ATTR CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2* XmlTextReaderImpl_get_DtdParserProxy_ParsingBuffer_m732E67E86FACC20D76FA4B242A4D68DDF2C4F8B4 (XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * __this, const RuntimeMethod* method);
// System.Int32 System.Xml.XmlTextReaderImpl::get_DtdParserProxy_ParsingBufferLength()
extern "C" IL2CPP_METHOD_ATTR int32_t XmlTextReaderImpl_get_DtdParserProxy_ParsingBufferLength_mB8E5A0E682D68237CF8F91988B2FD401851EE1F6 (XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * __this, const RuntimeMethod* method);
// System.Int32 System.Xml.XmlTextReaderImpl::get_DtdParserProxy_CurrentPosition()
extern "C" IL2CPP_METHOD_ATTR int32_t XmlTextReaderImpl_get_DtdParserProxy_CurrentPosition_m52421528101C78618D4044A58AAB9B35F0F361E8 (XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * __this, const RuntimeMethod* method);
// System.Void System.Xml.XmlTextReaderImpl::set_DtdParserProxy_CurrentPosition(System.Int32)
extern "C" IL2CPP_METHOD_ATTR void XmlTextReaderImpl_set_DtdParserProxy_CurrentPosition_mA9B55AABF3CF3855E738277D0EE102B8476DFC31 (XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * __this, int32_t ___value0, const RuntimeMethod* method);
// System.Int32 System.Xml.XmlTextReaderImpl::get_DtdParserProxy_EntityStackLength()
extern "C" IL2CPP_METHOD_ATTR int32_t XmlTextReaderImpl_get_DtdParserProxy_EntityStackLength_mB3E614D6A13AE3CC15FCB3F39AD2BD01BA4CD37B (XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * __this, const RuntimeMethod* method);
// System.Boolean System.Xml.XmlTextReaderImpl::get_DtdParserProxy_IsEntityEolNormalized()
extern "C" IL2CPP_METHOD_ATTR bool XmlTextReaderImpl_get_DtdParserProxy_IsEntityEolNormalized_m7CFE71A7E9CB847419D371F1CE50F14CCD29CF98 (XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * __this, const RuntimeMethod* method);
// System.Void System.Xml.XmlTextReaderImpl::DtdParserProxy_OnNewLine(System.Int32)
extern "C" IL2CPP_METHOD_ATTR void XmlTextReaderImpl_DtdParserProxy_OnNewLine_m54D60BD71043CCA2A79A92E36B33E3A1911A433E (XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * __this, int32_t ___pos0, const RuntimeMethod* method);
// System.Int32 System.Xml.XmlTextReaderImpl::get_DtdParserProxy_LineNo()
extern "C" IL2CPP_METHOD_ATTR int32_t XmlTextReaderImpl_get_DtdParserProxy_LineNo_mF6D9CDCA34905AB52FFDB0A8F7E86AE1439E571A (XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * __this, const RuntimeMethod* method);
// System.Int32 System.Xml.XmlTextReaderImpl::get_DtdParserProxy_LineStartPosition()
extern "C" IL2CPP_METHOD_ATTR int32_t XmlTextReaderImpl_get_DtdParserProxy_LineStartPosition_mC2B02BC83BF626D234DC141BDF1DD2FE0AA38226 (XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * __this, const RuntimeMethod* method);
// System.Int32 System.Xml.XmlTextReaderImpl::DtdParserProxy_ReadData()
extern "C" IL2CPP_METHOD_ATTR int32_t XmlTextReaderImpl_DtdParserProxy_ReadData_mBCE4874C93F3847B98418C908AB5C10ECC5CC7A4 (XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * __this, const RuntimeMethod* method);
// System.Int32 System.Xml.XmlTextReaderImpl::DtdParserProxy_ParseNumericCharRef(System.Text.StringBuilder)
extern "C" IL2CPP_METHOD_ATTR int32_t XmlTextReaderImpl_DtdParserProxy_ParseNumericCharRef_mFABC3FF9160DAEB435CF575CE550154E126526EA (XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * __this, StringBuilder_t * ___internalSubsetBuilder0, const RuntimeMethod* method);
// System.Int32 System.Xml.XmlTextReaderImpl::DtdParserProxy_ParseNamedCharRef(System.Boolean,System.Text.StringBuilder)
extern "C" IL2CPP_METHOD_ATTR int32_t XmlTextReaderImpl_DtdParserProxy_ParseNamedCharRef_mA59A919144E9C9256FE25125B1B20FC139E18F80 (XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * __this, bool ___expand0, StringBuilder_t * ___internalSubsetBuilder1, const RuntimeMethod* method);
// System.Void System.Xml.XmlTextReaderImpl::DtdParserProxy_ParsePI(System.Text.StringBuilder)
extern "C" IL2CPP_METHOD_ATTR void XmlTextReaderImpl_DtdParserProxy_ParsePI_mB882A376B7C7E442393A2F7E624D5B78CC36EA45 (XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * __this, StringBuilder_t * ___sb0, const RuntimeMethod* method);
// System.Void System.Xml.XmlTextReaderImpl::DtdParserProxy_ParseComment(System.Text.StringBuilder)
extern "C" IL2CPP_METHOD_ATTR void XmlTextReaderImpl_DtdParserProxy_ParseComment_mAAC7583A896F7BCF4785E621C4207C20FF5066B8 (XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * __this, StringBuilder_t * ___sb0, const RuntimeMethod* method);
// System.Boolean System.Xml.XmlTextReaderImpl::DtdParserProxy_PushEntity(System.Xml.IDtdEntityInfo,System.Int32&)
extern "C" IL2CPP_METHOD_ATTR bool XmlTextReaderImpl_DtdParserProxy_PushEntity_mECD5C4AD5E9040006BA77DA2559E6008A96E22E4 (XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * __this, RuntimeObject* ___entity0, int32_t* ___entityId1, const RuntimeMethod* method);
// System.Boolean System.Xml.XmlTextReaderImpl::DtdParserProxy_PopEntity(System.Xml.IDtdEntityInfo&,System.Int32&)
extern "C" IL2CPP_METHOD_ATTR bool XmlTextReaderImpl_DtdParserProxy_PopEntity_m180E9DC0F80126F67235BFE4AA23D22D554C74F1 (XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * __this, RuntimeObject** ___oldEntity0, int32_t* ___newEntityId1, const RuntimeMethod* method);
// System.Boolean System.Xml.XmlTextReaderImpl::DtdParserProxy_PushExternalSubset(System.String,System.String)
extern "C" IL2CPP_METHOD_ATTR bool XmlTextReaderImpl_DtdParserProxy_PushExternalSubset_mDD30749ED33A61DFF48062339109D14C299A0ECE (XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * __this, String_t* ___systemId0, String_t* ___publicId1, const RuntimeMethod* method);
// System.Void System.Xml.XmlTextReaderImpl::DtdParserProxy_PushInternalDtd(System.String,System.String)
extern "C" IL2CPP_METHOD_ATTR void XmlTextReaderImpl_DtdParserProxy_PushInternalDtd_m6AC6F1C2B2106FB423D2A0777DDC23F5603891F4 (XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * __this, String_t* ___baseUri0, String_t* ___internalDtd1, const RuntimeMethod* method);
// System.Void System.Xml.XmlTextReaderImpl::DtdParserProxy_Throw(System.Exception)
extern "C" IL2CPP_METHOD_ATTR void XmlTextReaderImpl_DtdParserProxy_Throw_m6807FDDF98894315BADCE32EAC5E8B0C32C0AD33 (XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * __this, Exception_t * ___e0, const RuntimeMethod* method);
// System.Void System.Xml.XmlTextReaderImpl::DtdParserProxy_OnSystemId(System.String,System.Xml.LineInfo,System.Xml.LineInfo)
extern "C" IL2CPP_METHOD_ATTR void XmlTextReaderImpl_DtdParserProxy_OnSystemId_mAA44EE85320C1F5AFAC2EE86217A88A04DA1285F (XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * __this, String_t* ___systemId0, LineInfo_t7E3D50496C7BA51B84D485D0A30B9006943544E5  ___keywordLineInfo1, LineInfo_t7E3D50496C7BA51B84D485D0A30B9006943544E5  ___systemLiteralLineInfo2, const RuntimeMethod* method);
// System.Void System.Xml.XmlTextReaderImpl::DtdParserProxy_OnPublicId(System.String,System.Xml.LineInfo,System.Xml.LineInfo)
extern "C" IL2CPP_METHOD_ATTR void XmlTextReaderImpl_DtdParserProxy_OnPublicId_mAC5A2232A5BBD487837E35E2B805C37926ED5149 (XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * __this, String_t* ___publicId0, LineInfo_t7E3D50496C7BA51B84D485D0A30B9006943544E5  ___keywordLineInfo1, LineInfo_t7E3D50496C7BA51B84D485D0A30B9006943544E5  ___publicLiteralLineInfo2, const RuntimeMethod* method);
// System.Boolean System.Xml.XmlTextReaderImpl::get_DtdParserProxy_DtdValidation()
extern "C" IL2CPP_METHOD_ATTR bool XmlTextReaderImpl_get_DtdParserProxy_DtdValidation_m9D55886560D6F84A954F3F2645FDCD16C6EC0D51 (XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * __this, const RuntimeMethod* method);
// System.Xml.IValidationEventHandling System.Xml.XmlTextReaderImpl::get_DtdParserProxy_ValidationEventHandling()
extern "C" IL2CPP_METHOD_ATTR RuntimeObject* XmlTextReaderImpl_get_DtdParserProxy_ValidationEventHandling_m63C63E3979E32960701A5B251C0099348A37A2CA (XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * __this, const RuntimeMethod* method);
// System.Boolean System.Xml.XmlTextReaderImpl::get_DtdParserProxy_Normalization()
extern "C" IL2CPP_METHOD_ATTR bool XmlTextReaderImpl_get_DtdParserProxy_Normalization_mE177D1DFA47257E6433B29E798C5DCFC5A615BD7 (XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * __this, const RuntimeMethod* method);
// System.Boolean System.Xml.XmlTextReaderImpl::get_DtdParserProxy_Namespaces()
extern "C" IL2CPP_METHOD_ATTR bool XmlTextReaderImpl_get_DtdParserProxy_Namespaces_mD03942B2D13243298515296268D68F4926F3CF20 (XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * __this, const RuntimeMethod* method);
// System.Boolean System.Xml.XmlTextReaderImpl::get_DtdParserProxy_V1CompatibilityMode()
extern "C" IL2CPP_METHOD_ATTR bool XmlTextReaderImpl_get_DtdParserProxy_V1CompatibilityMode_mA32E5EBB4E7AAFB7B55C14182767E6FE2FCAA26E (XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * __this, const RuntimeMethod* method);
// System.Void System.Xml.XmlNamespaceManager::.ctor()
extern "C" IL2CPP_METHOD_ATTR void XmlNamespaceManager__ctor_m90EC2B95E3A18E70520DF7C98FBDB439E3BE6D2D (XmlNamespaceManager_t8323BEB96BBE8F75207DC2AAFE9430E7F473658F * __this, const RuntimeMethod* method);
// System.Void System.Xml.XmlTextReaderImpl/NodeData::.ctor()
extern "C" IL2CPP_METHOD_ATTR void NodeData__ctor_m076D3A9B7188D2C830DDD3708764440856711ED7 (NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * __this, const RuntimeMethod* method);
// System.Void System.Xml.XmlTextReaderImpl/NodeData::Clear(System.Xml.XmlNodeType)
extern "C" IL2CPP_METHOD_ATTR void NodeData_Clear_mD71A1EC98F0BE924739AE49F5457A45ADA7A5C4D (NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * __this, int32_t ___type0, const RuntimeMethod* method);
// System.String System.String::CreateString(System.Char[],System.Int32,System.Int32)
extern "C" IL2CPP_METHOD_ATTR String_t* String_CreateString_mC7FB167C0D5B97F7EF502AF54399C61DD5B87509 (String_t* __this, CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2* ___val0, int32_t ___startIndex1, int32_t ___length2, const RuntimeMethod* method);
// System.Boolean System.Xml.XmlTextReaderImpl/NodeData::get_ValueBuffered()
extern "C" IL2CPP_METHOD_ATTR bool NodeData_get_ValueBuffered_m7FD057CE5A48B546847B9FBFFDEB1D7C77608014 (NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * __this, const RuntimeMethod* method);
// System.Void System.Xml.XmlTextReaderImpl::StripSpaces(System.Char[],System.Int32,System.Int32&)
extern "C" IL2CPP_METHOD_ATTR void XmlTextReaderImpl_StripSpaces_m727E8C1F0AC37111247AD7352DC8A209576C14E5 (CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2* ___value0, int32_t ___index1, int32_t* ___len2, const RuntimeMethod* method);
// System.String System.Xml.XmlTextReaderImpl::StripSpaces(System.String)
extern "C" IL2CPP_METHOD_ATTR String_t* XmlTextReaderImpl_StripSpaces_mB12C2C6298DADEEB9E11040418F911DAD4AE335C (String_t* ___value0, const RuntimeMethod* method);
// System.Void System.Xml.XmlTextReaderImpl/NodeData::ClearName()
extern "C" IL2CPP_METHOD_ATTR void NodeData_ClearName_m4EEEF5315A52473FC6470BB297C8E506FECD764B (NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * __this, const RuntimeMethod* method);
// System.Void System.Xml.LineInfo::Set(System.Int32,System.Int32)
extern "C" IL2CPP_METHOD_ATTR void LineInfo_Set_mAD399BFCEAB252539354B80ECF46E85F7D7B09E3 (LineInfo_t7E3D50496C7BA51B84D485D0A30B9006943544E5 * __this, int32_t ___lineNo0, int32_t ___linePos1, const RuntimeMethod* method);
// System.Void System.Xml.XmlTextReaderImpl/NodeData::SetNamedNode(System.Xml.XmlNodeType,System.String,System.String,System.String)
extern "C" IL2CPP_METHOD_ATTR void NodeData_SetNamedNode_m77D0D37FB571646037FE64C72649995D06218A5F (NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * __this, int32_t ___type0, String_t* ___localName1, String_t* ___prefix2, String_t* ___nameWPrefix3, const RuntimeMethod* method);
// System.Text.StringBuilder System.Text.StringBuilder::Append(System.Char[],System.Int32,System.Int32)
extern "C" IL2CPP_METHOD_ATTR StringBuilder_t * StringBuilder_Append_m549C532422286A982F7956C9BAE197D00B30DCA8 (StringBuilder_t * __this, CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2* p0, int32_t p1, int32_t p2, const RuntimeMethod* method);
// System.Text.StringBuilder System.Text.StringBuilder::Append(System.String)
extern "C" IL2CPP_METHOD_ATTR StringBuilder_t * StringBuilder_Append_mDBB8CCBB7750C67BE2F2D92F47E6C0FA42793260 (StringBuilder_t * __this, String_t* p0, const RuntimeMethod* method);
// System.Int32 System.String::get_Length()
extern "C" IL2CPP_METHOD_ATTR int32_t String_get_Length_mD48C8A16A5CF1914F330DCE82D9BE15C3BEDD018 (String_t* __this, const RuntimeMethod* method);
// System.Text.StringBuilder System.Text.StringBuilder::Append(System.String,System.Int32,System.Int32)
extern "C" IL2CPP_METHOD_ATTR StringBuilder_t * StringBuilder_Append_m9EB954E99DC99B8CC712ABB70EAA07616B841D46 (StringBuilder_t * __this, String_t* p0, int32_t p1, int32_t p2, const RuntimeMethod* method);
// System.String System.Xml.XmlTextReaderImpl/NodeData::CreateNameWPrefix(System.Xml.XmlNameTable)
extern "C" IL2CPP_METHOD_ATTR String_t* NodeData_CreateNameWPrefix_m5D8818A7500ABBADB43B2923EEC59CCDC28B3F97 (NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * __this, XmlNameTable_t3C1CDAB4E7D97DE41A409D6D9ADD2C10B1F281A6 * ___nt0, const RuntimeMethod* method);
// System.String System.String::Concat(System.String,System.String,System.String)
extern "C" IL2CPP_METHOD_ATTR String_t* String_Concat_mF4626905368D6558695A823466A1AF65EADB9923 (String_t* p0, String_t* p1, String_t* p2, const RuntimeMethod* method);
// System.Boolean System.Xml.Ref::Equal(System.String,System.String)
extern "C" IL2CPP_METHOD_ATTR bool Ref_Equal_mE6DE69202A01B55D8F7C88627331ADB96F88CA00 (String_t* ___strA0, String_t* ___strB1, const RuntimeMethod* method);
// System.Int32 System.String::CompareOrdinal(System.String,System.String)
extern "C" IL2CPP_METHOD_ATTR int32_t String_CompareOrdinal_m172D84EDDE0823F53EAB60857C07EA7F85600068 (String_t* p0, String_t* p1, const RuntimeMethod* method);
// System.Void System.Xml.XmlTextReaderImpl/ParsingState::Clear()
extern "C" IL2CPP_METHOD_ATTR void ParsingState_Clear_mB03C277E58A91CB626BBE6EC5CF2D6E97ECE48E2 (ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2 * __this, const RuntimeMethod* method);
// System.Void System.Xml.XmlTextReaderImpl/ParsingState::Close(System.Boolean)
extern "C" IL2CPP_METHOD_ATTR void ParsingState_Close_mD17CB448C04F94BE7FA9AFC29B1443C88BCE67B4 (ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2 * __this, bool ___closeInput0, const RuntimeMethod* method);
// System.Int32 System.Xml.XmlTextReaderImpl/ParsingState::get_LineNo()
extern "C" IL2CPP_METHOD_ATTR int32_t ParsingState_get_LineNo_m2F68C696B809CC3B5F5AC076BD88E039C5CAB53A (ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2 * __this, const RuntimeMethod* method);
// System.Int32 System.Xml.XmlTextReaderImpl/ParsingState::get_LinePos()
extern "C" IL2CPP_METHOD_ATTR int32_t ParsingState_get_LinePos_m89ABB430BB316ED269D32CEEFDBFFC32306DFACF (ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2 * __this, const RuntimeMethod* method);
// System.Void System.Xml.XmlAttribute::.ctor(System.String,System.String,System.String,System.Xml.XmlDocument)
extern "C" IL2CPP_METHOD_ATTR void XmlAttribute__ctor_m6A0A80A14549911E2901FB44FA291BD8DDBB7A8F (XmlAttribute_tEAB5F066D1D6965D6528617BD89826AE7114DEFA * __this, String_t* ___prefix0, String_t* ___localName1, String_t* ___namespaceURI2, XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97 * ___doc3, const RuntimeMethod* method);
// System.Xml.XmlNode System.Xml.XmlAttribute::RemoveChild(System.Xml.XmlNode)
extern "C" IL2CPP_METHOD_ATTR XmlNode_t07D70045D843753E4FE8AFE40FD36244E6B6D7FB * XmlAttribute_RemoveChild_mFFCDFF1C5410F74FA8B7D9F18530C9C17D91470F (XmlAttribute_tEAB5F066D1D6965D6528617BD89826AE7114DEFA * __this, XmlNode_t07D70045D843753E4FE8AFE40FD36244E6B6D7FB * ___oldChild0, const RuntimeMethod* method);
// System.Xml.XmlNode System.Xml.XmlAttribute::AppendChild(System.Xml.XmlNode)
extern "C" IL2CPP_METHOD_ATTR XmlNode_t07D70045D843753E4FE8AFE40FD36244E6B6D7FB * XmlAttribute_AppendChild_m7F17561A3054A0E2A4EDC19241EFD30DD5FA5D66 (XmlAttribute_tEAB5F066D1D6965D6528617BD89826AE7114DEFA * __this, XmlNode_t07D70045D843753E4FE8AFE40FD36244E6B6D7FB * ___newChild0, const RuntimeMethod* method);
// System.Void System.Xml.XmlDownloadManager::.ctor()
extern "C" IL2CPP_METHOD_ATTR void XmlDownloadManager__ctor_mF13307004D49134611C0246153CEBF94E3844A27 (XmlDownloadManager_tF864449330C09DCF4353B7F17EA226CE28C4D752 * __this, const RuntimeMethod* method);
// System.Void System.Xml.XmlResolver::.ctor()
extern "C" IL2CPP_METHOD_ATTR void XmlResolver__ctor_m13C03FD7D7D57C97976BBCB547B9E2C3C09C408A (XmlResolver_t93269F14B2F8750D040AED2FB7A303CE85016280 * __this, const RuntimeMethod* method);
// System.Boolean System.Type::op_Equality(System.Type,System.Type)
extern "C" IL2CPP_METHOD_ATTR bool Type_op_Equality_m7040622C9E1037EFC73E1F0EDB1DD241282BE3D8 (Type_t * p0, Type_t * p1, const RuntimeMethod* method);
// System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
extern "C" IL2CPP_METHOD_ATTR Type_t * Type_GetTypeFromHandle_m9DC58ADF0512987012A8A016FB64B068F3B1AFF6 (RuntimeTypeHandle_t7B542280A22F0EC4EAC2061C29178845847A8B2D  p0, const RuntimeMethod* method);
// System.Xml.XmlDownloadManager System.Xml.XmlUrlResolver::get_DownloadManager()
extern "C" IL2CPP_METHOD_ATTR XmlDownloadManager_tF864449330C09DCF4353B7F17EA226CE28C4D752 * XmlUrlResolver_get_DownloadManager_m420E0324A705EBAF4320453656ABAAC232A173C0 (const RuntimeMethod* method);
// System.IO.Stream System.Xml.XmlDownloadManager::GetStream(System.Uri,System.Net.ICredentials,System.Net.IWebProxy,System.Net.Cache.RequestCachePolicy)
extern "C" IL2CPP_METHOD_ATTR Stream_tFC50657DD5AAB87770987F9179D934A51D99D5E7 * XmlDownloadManager_GetStream_mD7A14E8675B8CAE8AC4AF96D53CD430024A60525 (XmlDownloadManager_tF864449330C09DCF4353B7F17EA226CE28C4D752 * __this, Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E * ___uri0, RuntimeObject* ___credentials1, RuntimeObject* ___proxy2, RequestCachePolicy_t30D7352C7E9D49EEADD492A70EC92C118D90CD61 * ___cachePolicy3, const RuntimeMethod* method);
// System.Uri System.Xml.XmlResolver::ResolveUri(System.Uri,System.String)
extern "C" IL2CPP_METHOD_ATTR Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E * XmlResolver_ResolveUri_m3B74CC7D9ABBEDBE2CD281F44E614641917F4FEB (XmlResolver_t93269F14B2F8750D040AED2FB7A303CE85016280 * __this, Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E * ___baseUri0, String_t* ___relativeUri1, const RuntimeMethod* method);
// System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<!0> System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>::Create()
inline AsyncTaskMethodBuilder_1_t2A9513A084F4B19851B91EF1F22BB57776D35663  AsyncTaskMethodBuilder_1_Create_mC7806A5C115ED2239A5073313AA3564D8244156E (const RuntimeMethod* method)
{
	return ((  AsyncTaskMethodBuilder_1_t2A9513A084F4B19851B91EF1F22BB57776D35663  (*) (const RuntimeMethod*))AsyncTaskMethodBuilder_1_Create_mC7806A5C115ED2239A5073313AA3564D8244156E_gshared)(method);
}
// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>::Start<System.Xml.XmlUrlResolver/<GetEntityAsync>d__15>(!!0&)
inline void AsyncTaskMethodBuilder_1_Start_TisU3CGetEntityAsyncU3Ed__15_t383C4608618A66FB04F41F38C0534EE9E14CC934_mF03E454780149AFBE6F88C60A4283797936195AD (AsyncTaskMethodBuilder_1_t2A9513A084F4B19851B91EF1F22BB57776D35663 * __this, U3CGetEntityAsyncU3Ed__15_t383C4608618A66FB04F41F38C0534EE9E14CC934 * p0, const RuntimeMethod* method)
{
	((  void (*) (AsyncTaskMethodBuilder_1_t2A9513A084F4B19851B91EF1F22BB57776D35663 *, U3CGetEntityAsyncU3Ed__15_t383C4608618A66FB04F41F38C0534EE9E14CC934 *, const RuntimeMethod*))AsyncTaskMethodBuilder_1_Start_TisU3CGetEntityAsyncU3Ed__15_t383C4608618A66FB04F41F38C0534EE9E14CC934_mF03E454780149AFBE6F88C60A4283797936195AD_gshared)(__this, p0, method);
}
// System.Threading.Tasks.Task`1<!0> System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>::get_Task()
inline Task_1_tA56001ED5270173CA1432EDFCD84EABB1024BC09 * AsyncTaskMethodBuilder_1_get_Task_m19C5664D70C4FC799BEFB8D0FC98E687F97059FA (AsyncTaskMethodBuilder_1_t2A9513A084F4B19851B91EF1F22BB57776D35663 * __this, const RuntimeMethod* method)
{
	return ((  Task_1_tA56001ED5270173CA1432EDFCD84EABB1024BC09 * (*) (AsyncTaskMethodBuilder_1_t2A9513A084F4B19851B91EF1F22BB57776D35663 *, const RuntimeMethod*))AsyncTaskMethodBuilder_1_get_Task_m19C5664D70C4FC799BEFB8D0FC98E687F97059FA_gshared)(__this, method);
}
// System.Threading.Tasks.Task`1<System.IO.Stream> System.Xml.XmlDownloadManager::GetStreamAsync(System.Uri,System.Net.ICredentials,System.Net.IWebProxy,System.Net.Cache.RequestCachePolicy)
extern "C" IL2CPP_METHOD_ATTR Task_1_tAA7557E5A6A8B2C89E44907CB5B0502A618E9D01 * XmlDownloadManager_GetStreamAsync_m39DCD22D4B46A17B36D223C5BB8C818B40D4856A (XmlDownloadManager_tF864449330C09DCF4353B7F17EA226CE28C4D752 * __this, Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E * ___uri0, RuntimeObject* ___credentials1, RuntimeObject* ___proxy2, RequestCachePolicy_t30D7352C7E9D49EEADD492A70EC92C118D90CD61 * ___cachePolicy3, const RuntimeMethod* method);
// System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<!0> System.Threading.Tasks.Task`1<System.IO.Stream>::ConfigureAwait(System.Boolean)
inline ConfiguredTaskAwaitable_1_t8F8087337FA5C6475CA153C95469983DDDED9F48  Task_1_ConfigureAwait_m190880408777F02426C980806C63032BEC154505 (Task_1_tAA7557E5A6A8B2C89E44907CB5B0502A618E9D01 * __this, bool p0, const RuntimeMethod* method)
{
	return ((  ConfiguredTaskAwaitable_1_t8F8087337FA5C6475CA153C95469983DDDED9F48  (*) (Task_1_tAA7557E5A6A8B2C89E44907CB5B0502A618E9D01 *, bool, const RuntimeMethod*))Task_1_ConfigureAwait_m60DD864D9488EACBA6C087E87E448797C1C8B76B_gshared)(__this, p0, method);
}
// System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1/ConfiguredTaskAwaiter<!0> System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<System.IO.Stream>::GetAwaiter()
inline ConfiguredTaskAwaiter_t27ECAA4B74502BD3AC7E68F47088D46DAA13D133  ConfiguredTaskAwaitable_1_GetAwaiter_m7A0F2D7CFD71CFFC2586B93E3A1FAD30221784BC (ConfiguredTaskAwaitable_1_t8F8087337FA5C6475CA153C95469983DDDED9F48 * __this, const RuntimeMethod* method)
{
	return ((  ConfiguredTaskAwaiter_t27ECAA4B74502BD3AC7E68F47088D46DAA13D133  (*) (ConfiguredTaskAwaitable_1_t8F8087337FA5C6475CA153C95469983DDDED9F48 *, const RuntimeMethod*))ConfiguredTaskAwaitable_1_GetAwaiter_m86C543D72022CB5D0C43053C4AF5F37EA4E690A7_gshared)(__this, method);
}
// System.Boolean System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1/ConfiguredTaskAwaiter<System.IO.Stream>::get_IsCompleted()
inline bool ConfiguredTaskAwaiter_get_IsCompleted_m0720F20A96AD14393558BEB67540D8545A45FABF (ConfiguredTaskAwaiter_t27ECAA4B74502BD3AC7E68F47088D46DAA13D133 * __this, const RuntimeMethod* method)
{
	return ((  bool (*) (ConfiguredTaskAwaiter_t27ECAA4B74502BD3AC7E68F47088D46DAA13D133 *, const RuntimeMethod*))ConfiguredTaskAwaiter_get_IsCompleted_mA1F08104B225C8640528B38BFD0AAAEE84541586_gshared)(__this, method);
}
// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>::AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1/ConfiguredTaskAwaiter<System.IO.Stream>,System.Xml.XmlUrlResolver/<GetEntityAsync>d__15>(!!0&,!!1&)
inline void AsyncTaskMethodBuilder_1_AwaitUnsafeOnCompleted_TisConfiguredTaskAwaiter_t27ECAA4B74502BD3AC7E68F47088D46DAA13D133_TisU3CGetEntityAsyncU3Ed__15_t383C4608618A66FB04F41F38C0534EE9E14CC934_m2ADCCD4826BB678962D141602B12B2B0F69CC672 (AsyncTaskMethodBuilder_1_t2A9513A084F4B19851B91EF1F22BB57776D35663 * __this, ConfiguredTaskAwaiter_t27ECAA4B74502BD3AC7E68F47088D46DAA13D133 * p0, U3CGetEntityAsyncU3Ed__15_t383C4608618A66FB04F41F38C0534EE9E14CC934 * p1, const RuntimeMethod* method)
{
	((  void (*) (AsyncTaskMethodBuilder_1_t2A9513A084F4B19851B91EF1F22BB57776D35663 *, ConfiguredTaskAwaiter_t27ECAA4B74502BD3AC7E68F47088D46DAA13D133 *, U3CGetEntityAsyncU3Ed__15_t383C4608618A66FB04F41F38C0534EE9E14CC934 *, const RuntimeMethod*))AsyncTaskMethodBuilder_1_AwaitUnsafeOnCompleted_TisConfiguredTaskAwaiter_tFB3C4197768C6CF02BE088F703AA6E46D703D46E_TisU3CGetEntityAsyncU3Ed__15_t383C4608618A66FB04F41F38C0534EE9E14CC934_mF317CFCC50E2EC331EA7CC77DD06EFC53A6DC83E_gshared)(__this, p0, p1, method);
}
// !0 System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1/ConfiguredTaskAwaiter<System.IO.Stream>::GetResult()
inline Stream_tFC50657DD5AAB87770987F9179D934A51D99D5E7 * ConfiguredTaskAwaiter_GetResult_m4F8B73FFFC823973FDD6AD1386EE0D8B7CEDF8ED (ConfiguredTaskAwaiter_t27ECAA4B74502BD3AC7E68F47088D46DAA13D133 * __this, const RuntimeMethod* method)
{
	return ((  Stream_tFC50657DD5AAB87770987F9179D934A51D99D5E7 * (*) (ConfiguredTaskAwaiter_t27ECAA4B74502BD3AC7E68F47088D46DAA13D133 *, const RuntimeMethod*))ConfiguredTaskAwaiter_GetResult_m4EE5BF4F8536CCC951CA3F4E3C494411AE2D507E_gshared)(__this, method);
}
// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>::SetException(System.Exception)
inline void AsyncTaskMethodBuilder_1_SetException_m4C0B5462ECCB520FACA3C90B353DF596DAAF586D (AsyncTaskMethodBuilder_1_t2A9513A084F4B19851B91EF1F22BB57776D35663 * __this, Exception_t * p0, const RuntimeMethod* method)
{
	((  void (*) (AsyncTaskMethodBuilder_1_t2A9513A084F4B19851B91EF1F22BB57776D35663 *, Exception_t *, const RuntimeMethod*))AsyncTaskMethodBuilder_1_SetException_m4C0B5462ECCB520FACA3C90B353DF596DAAF586D_gshared)(__this, p0, method);
}
// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>::SetResult(!0)
inline void AsyncTaskMethodBuilder_1_SetResult_mD7DA7A17DC0610B11A0AAA364C3CA51FEC1271DB (AsyncTaskMethodBuilder_1_t2A9513A084F4B19851B91EF1F22BB57776D35663 * __this, RuntimeObject * p0, const RuntimeMethod* method)
{
	((  void (*) (AsyncTaskMethodBuilder_1_t2A9513A084F4B19851B91EF1F22BB57776D35663 *, RuntimeObject *, const RuntimeMethod*))AsyncTaskMethodBuilder_1_SetResult_mD7DA7A17DC0610B11A0AAA364C3CA51FEC1271DB_gshared)(__this, p0, method);
}
// System.Void System.Xml.XmlUrlResolver/<GetEntityAsync>d__15::MoveNext()
extern "C" IL2CPP_METHOD_ATTR void U3CGetEntityAsyncU3Ed__15_MoveNext_m025A24D8C9AF0CAE7D6470F3BE1FD32F71BD1966 (U3CGetEntityAsyncU3Ed__15_t383C4608618A66FB04F41F38C0534EE9E14CC934 * __this, const RuntimeMethod* method);
// System.Void System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Object>::SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine)
inline void AsyncTaskMethodBuilder_1_SetStateMachine_m5CC21A02320CF3D2DD7894A31123DFD82A428E4C (AsyncTaskMethodBuilder_1_t2A9513A084F4B19851B91EF1F22BB57776D35663 * __this, RuntimeObject* p0, const RuntimeMethod* method)
{
	((  void (*) (AsyncTaskMethodBuilder_1_t2A9513A084F4B19851B91EF1F22BB57776D35663 *, RuntimeObject*, const RuntimeMethod*))AsyncTaskMethodBuilder_1_SetStateMachine_m5CC21A02320CF3D2DD7894A31123DFD82A428E4C_gshared)(__this, p0, method);
}
// System.Void System.Xml.XmlUrlResolver/<GetEntityAsync>d__15::SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine)
extern "C" IL2CPP_METHOD_ATTR void U3CGetEntityAsyncU3Ed__15_SetStateMachine_m102A8E0E12BF7F318C7880C850455EF3AF4B8D0B (U3CGetEntityAsyncU3Ed__15_t383C4608618A66FB04F41F38C0534EE9E14CC934 * __this, RuntimeObject* ___stateMachine0, const RuntimeMethod* method);
// System.Void System.Xml.XmlCharacterData::.ctor(System.String,System.Xml.XmlDocument)
extern "C" IL2CPP_METHOD_ATTR void XmlCharacterData__ctor_m1733B463DB83C45AE9F57D7DE42CA997087E78A6 (XmlCharacterData_tA7587D706680E42BD7A094F87CB0859C840A8531 * __this, String_t* ___data0, XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97 * ___doc1, const RuntimeMethod* method);
// System.Boolean System.Xml.XmlDocument::get_IsLoading()
extern "C" IL2CPP_METHOD_ATTR bool XmlDocument_get_IsLoading_m6121F2E25E1B39DA8A090585EC483D289F520F6A (XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97 * __this, const RuntimeMethod* method);
// System.Boolean System.Xml.XmlCharacterData::CheckOnData(System.String)
extern "C" IL2CPP_METHOD_ATTR bool XmlCharacterData_CheckOnData_m256EB1478D4EE87B7FD97C54882AE684EA2DA474 (XmlCharacterData_tA7587D706680E42BD7A094F87CB0859C840A8531 * __this, String_t* ___data0, const RuntimeMethod* method);
// System.String System.Xml.Res::GetString(System.String)
extern "C" IL2CPP_METHOD_ATTR String_t* Res_GetString_m47B81D62E4B5E4C48C06BCC7995B9ED5218EE7A2 (String_t* ___name0, const RuntimeMethod* method);
// System.Void System.ArgumentException::.ctor(System.String)
extern "C" IL2CPP_METHOD_ATTR void ArgumentException__ctor_m9A85EF7FEFEC21DDD525A67E831D77278E5165B7 (ArgumentException_tEDCD16F20A09ECE461C3DA766C16EDA8864057D1 * __this, String_t* p0, const RuntimeMethod* method);
// System.Xml.XmlNode System.Xml.XmlNode::get_ParentNode()
extern "C" IL2CPP_METHOD_ATTR XmlNode_t07D70045D843753E4FE8AFE40FD36244E6B6D7FB * XmlNode_get_ParentNode_m6AC4A7F4FEE5B469A86490C129F011C12201C3E6 (XmlNode_t07D70045D843753E4FE8AFE40FD36244E6B6D7FB * __this, const RuntimeMethod* method);
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Collections.Generic.IComparer`1<System.Object> System.Xml.XmlTextReaderImpl_DtdDefaultAttributeInfoToNodeDataComparer::get_Instance()
extern "C" IL2CPP_METHOD_ATTR RuntimeObject* DtdDefaultAttributeInfoToNodeDataComparer_get_Instance_m874469D09ABF5CCAC32A665B40B6CC9FD88B3638 (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (DtdDefaultAttributeInfoToNodeDataComparer_get_Instance_m874469D09ABF5CCAC32A665B40B6CC9FD88B3638_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(DtdDefaultAttributeInfoToNodeDataComparer_t0B9FEF7A80832980C3E32D47BE835964E8B423B7_il2cpp_TypeInfo_var);
		RuntimeObject* L_0 = ((DtdDefaultAttributeInfoToNodeDataComparer_t0B9FEF7A80832980C3E32D47BE835964E8B423B7_StaticFields*)il2cpp_codegen_static_fields_for(DtdDefaultAttributeInfoToNodeDataComparer_t0B9FEF7A80832980C3E32D47BE835964E8B423B7_il2cpp_TypeInfo_var))->get_s_instance_0();
		return L_0;
	}
}
// System.Int32 System.Xml.XmlTextReaderImpl_DtdDefaultAttributeInfoToNodeDataComparer::Compare(System.Object,System.Object)
extern "C" IL2CPP_METHOD_ATTR int32_t DtdDefaultAttributeInfoToNodeDataComparer_Compare_m9F094BA85561258B6DAA077B369BD4380599FDE3 (DtdDefaultAttributeInfoToNodeDataComparer_t0B9FEF7A80832980C3E32D47BE835964E8B423B7 * __this, RuntimeObject * ___x0, RuntimeObject * ___y1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (DtdDefaultAttributeInfoToNodeDataComparer_Compare_m9F094BA85561258B6DAA077B369BD4380599FDE3_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	String_t* V_0 = NULL;
	String_t* V_1 = NULL;
	String_t* V_2 = NULL;
	String_t* V_3 = NULL;
	NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * V_4 = NULL;
	int32_t V_5 = 0;
	RuntimeObject* V_6 = NULL;
	RuntimeObject* V_7 = NULL;
	{
		RuntimeObject * L_0 = ___x0;
		if (L_0)
		{
			goto IL_000a;
		}
	}
	{
		RuntimeObject * L_1 = ___y1;
		if (!L_1)
		{
			goto IL_0008;
		}
	}
	{
		return (-1);
	}

IL_0008:
	{
		return 0;
	}

IL_000a:
	{
		RuntimeObject * L_2 = ___y1;
		if (L_2)
		{
			goto IL_000f;
		}
	}
	{
		return 1;
	}

IL_000f:
	{
		RuntimeObject * L_3 = ___x0;
		V_4 = ((NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF *)IsInstClass((RuntimeObject*)L_3, NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF_il2cpp_TypeInfo_var));
		NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * L_4 = V_4;
		if (!L_4)
		{
			goto IL_002d;
		}
	}
	{
		NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * L_5 = V_4;
		NullCheck(L_5);
		String_t* L_6 = L_5->get_localName_2();
		V_0 = L_6;
		NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * L_7 = V_4;
		NullCheck(L_7);
		String_t* L_8 = L_7->get_prefix_3();
		V_2 = L_8;
		goto IL_005b;
	}

IL_002d:
	{
		RuntimeObject * L_9 = ___x0;
		V_6 = ((RuntimeObject*)IsInst((RuntimeObject*)L_9, IDtdDefaultAttributeInfo_tA4B426A7E92054F6EF626DC0E493CA19C4ECB26A_il2cpp_TypeInfo_var));
		RuntimeObject* L_10 = V_6;
		if (!L_10)
		{
			goto IL_004b;
		}
	}
	{
		RuntimeObject* L_11 = V_6;
		NullCheck(L_11);
		String_t* L_12 = InterfaceFuncInvoker0< String_t* >::Invoke(1 /* System.String System.Xml.IDtdAttributeInfo::get_LocalName() */, IDtdAttributeInfo_t650C2A35C205461E5ECF38D70B0D9CD8A4B46068_il2cpp_TypeInfo_var, L_11);
		V_0 = L_12;
		RuntimeObject* L_13 = V_6;
		NullCheck(L_13);
		String_t* L_14 = InterfaceFuncInvoker0< String_t* >::Invoke(0 /* System.String System.Xml.IDtdAttributeInfo::get_Prefix() */, IDtdAttributeInfo_t650C2A35C205461E5ECF38D70B0D9CD8A4B46068_il2cpp_TypeInfo_var, L_13);
		V_2 = L_14;
		goto IL_005b;
	}

IL_004b:
	{
		String_t* L_15 = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
		XmlException_tD7DA2CBE07488D18EE7A284862B7523E3CD4365D * L_16 = (XmlException_tD7DA2CBE07488D18EE7A284862B7523E3CD4365D *)il2cpp_codegen_object_new(XmlException_tD7DA2CBE07488D18EE7A284862B7523E3CD4365D_il2cpp_TypeInfo_var);
		XmlException__ctor_mD27C8593D4F5978D5B419DA73EB60B23D80CC9E4(L_16, _stringLiteral16A3C2A876EADFBFB7EF0193C48BCF6088E0B6AD, L_15, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_16, NULL, DtdDefaultAttributeInfoToNodeDataComparer_Compare_m9F094BA85561258B6DAA077B369BD4380599FDE3_RuntimeMethod_var);
	}

IL_005b:
	{
		RuntimeObject * L_17 = ___y1;
		V_4 = ((NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF *)IsInstClass((RuntimeObject*)L_17, NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF_il2cpp_TypeInfo_var));
		NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * L_18 = V_4;
		if (!L_18)
		{
			goto IL_0079;
		}
	}
	{
		NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * L_19 = V_4;
		NullCheck(L_19);
		String_t* L_20 = L_19->get_localName_2();
		V_1 = L_20;
		NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * L_21 = V_4;
		NullCheck(L_21);
		String_t* L_22 = L_21->get_prefix_3();
		V_3 = L_22;
		goto IL_00a7;
	}

IL_0079:
	{
		RuntimeObject * L_23 = ___y1;
		V_7 = ((RuntimeObject*)IsInst((RuntimeObject*)L_23, IDtdDefaultAttributeInfo_tA4B426A7E92054F6EF626DC0E493CA19C4ECB26A_il2cpp_TypeInfo_var));
		RuntimeObject* L_24 = V_7;
		if (!L_24)
		{
			goto IL_0097;
		}
	}
	{
		RuntimeObject* L_25 = V_7;
		NullCheck(L_25);
		String_t* L_26 = InterfaceFuncInvoker0< String_t* >::Invoke(1 /* System.String System.Xml.IDtdAttributeInfo::get_LocalName() */, IDtdAttributeInfo_t650C2A35C205461E5ECF38D70B0D9CD8A4B46068_il2cpp_TypeInfo_var, L_25);
		V_1 = L_26;
		RuntimeObject* L_27 = V_7;
		NullCheck(L_27);
		String_t* L_28 = InterfaceFuncInvoker0< String_t* >::Invoke(0 /* System.String System.Xml.IDtdAttributeInfo::get_Prefix() */, IDtdAttributeInfo_t650C2A35C205461E5ECF38D70B0D9CD8A4B46068_il2cpp_TypeInfo_var, L_27);
		V_3 = L_28;
		goto IL_00a7;
	}

IL_0097:
	{
		String_t* L_29 = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
		XmlException_tD7DA2CBE07488D18EE7A284862B7523E3CD4365D * L_30 = (XmlException_tD7DA2CBE07488D18EE7A284862B7523E3CD4365D *)il2cpp_codegen_object_new(XmlException_tD7DA2CBE07488D18EE7A284862B7523E3CD4365D_il2cpp_TypeInfo_var);
		XmlException__ctor_mD27C8593D4F5978D5B419DA73EB60B23D80CC9E4(L_30, _stringLiteral16A3C2A876EADFBFB7EF0193C48BCF6088E0B6AD, L_29, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_30, NULL, DtdDefaultAttributeInfoToNodeDataComparer_Compare_m9F094BA85561258B6DAA077B369BD4380599FDE3_RuntimeMethod_var);
	}

IL_00a7:
	{
		String_t* L_31 = V_0;
		String_t* L_32 = V_1;
		int32_t L_33 = String_Compare_m5BD1EF8904C9B13BEDB7A876B122F117B317B442(L_31, L_32, 4, /*hidden argument*/NULL);
		V_5 = L_33;
		int32_t L_34 = V_5;
		if (!L_34)
		{
			goto IL_00b8;
		}
	}
	{
		int32_t L_35 = V_5;
		return L_35;
	}

IL_00b8:
	{
		String_t* L_36 = V_2;
		String_t* L_37 = V_3;
		int32_t L_38 = String_Compare_m5BD1EF8904C9B13BEDB7A876B122F117B317B442(L_36, L_37, 4, /*hidden argument*/NULL);
		return L_38;
	}
}
// System.Void System.Xml.XmlTextReaderImpl_DtdDefaultAttributeInfoToNodeDataComparer::.ctor()
extern "C" IL2CPP_METHOD_ATTR void DtdDefaultAttributeInfoToNodeDataComparer__ctor_mE7BC53A14858DE5CD693E0E8C5E35D798BA1E358 (DtdDefaultAttributeInfoToNodeDataComparer_t0B9FEF7A80832980C3E32D47BE835964E8B423B7 * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m925ECA5E85CA100E3FB86A4F9E15C120E9A184C0(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void System.Xml.XmlTextReaderImpl_DtdDefaultAttributeInfoToNodeDataComparer::.cctor()
extern "C" IL2CPP_METHOD_ATTR void DtdDefaultAttributeInfoToNodeDataComparer__cctor_m0C04DBA55773309DA7070567B915912CC7C1A59D (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (DtdDefaultAttributeInfoToNodeDataComparer__cctor_m0C04DBA55773309DA7070567B915912CC7C1A59D_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		DtdDefaultAttributeInfoToNodeDataComparer_t0B9FEF7A80832980C3E32D47BE835964E8B423B7 * L_0 = (DtdDefaultAttributeInfoToNodeDataComparer_t0B9FEF7A80832980C3E32D47BE835964E8B423B7 *)il2cpp_codegen_object_new(DtdDefaultAttributeInfoToNodeDataComparer_t0B9FEF7A80832980C3E32D47BE835964E8B423B7_il2cpp_TypeInfo_var);
		DtdDefaultAttributeInfoToNodeDataComparer__ctor_mE7BC53A14858DE5CD693E0E8C5E35D798BA1E358(L_0, /*hidden argument*/NULL);
		((DtdDefaultAttributeInfoToNodeDataComparer_t0B9FEF7A80832980C3E32D47BE835964E8B423B7_StaticFields*)il2cpp_codegen_static_fields_for(DtdDefaultAttributeInfoToNodeDataComparer_t0B9FEF7A80832980C3E32D47BE835964E8B423B7_il2cpp_TypeInfo_var))->set_s_instance_0(L_0);
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
// System.Void System.Xml.XmlTextReaderImpl_DtdParserProxy::.ctor(System.Xml.XmlTextReaderImpl)
extern "C" IL2CPP_METHOD_ATTR void DtdParserProxy__ctor_m8612F3FEF4AC41D41795ED46B0A0E050C4D6DB33 (DtdParserProxy_tF94C8FBE3EC41EF7C960BEDC0CD3DD25090265B7 * __this, XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * ___reader0, const RuntimeMethod* method)
{
	{
		Object__ctor_m925ECA5E85CA100E3FB86A4F9E15C120E9A184C0(__this, /*hidden argument*/NULL);
		XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * L_0 = ___reader0;
		__this->set_reader_0(L_0);
		return;
	}
}
// System.Xml.XmlNameTable System.Xml.XmlTextReaderImpl_DtdParserProxy::System.Xml.IDtdParserAdapter.get_NameTable()
extern "C" IL2CPP_METHOD_ATTR XmlNameTable_t3C1CDAB4E7D97DE41A409D6D9ADD2C10B1F281A6 * DtdParserProxy_System_Xml_IDtdParserAdapter_get_NameTable_m61FA83EC45A4DDC893D391F1B57FD64A5B2419D1 (DtdParserProxy_tF94C8FBE3EC41EF7C960BEDC0CD3DD25090265B7 * __this, const RuntimeMethod* method)
{
	{
		XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * L_0 = __this->get_reader_0();
		NullCheck(L_0);
		XmlNameTable_t3C1CDAB4E7D97DE41A409D6D9ADD2C10B1F281A6 * L_1 = XmlTextReaderImpl_get_DtdParserProxy_NameTable_mC74340532F97E8B584DBB1118A91BB326437040F(L_0, /*hidden argument*/NULL);
		return L_1;
	}
}
// System.Xml.IXmlNamespaceResolver System.Xml.XmlTextReaderImpl_DtdParserProxy::System.Xml.IDtdParserAdapter.get_NamespaceResolver()
extern "C" IL2CPP_METHOD_ATTR RuntimeObject* DtdParserProxy_System_Xml_IDtdParserAdapter_get_NamespaceResolver_m2F7C2E426581A33B4191992A4C543B816CE5BDF5 (DtdParserProxy_tF94C8FBE3EC41EF7C960BEDC0CD3DD25090265B7 * __this, const RuntimeMethod* method)
{
	{
		XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * L_0 = __this->get_reader_0();
		NullCheck(L_0);
		RuntimeObject* L_1 = XmlTextReaderImpl_get_DtdParserProxy_NamespaceResolver_mC3EB3FE6FCD70248450386A5EB990F2163A1CC3D(L_0, /*hidden argument*/NULL);
		return L_1;
	}
}
// System.Uri System.Xml.XmlTextReaderImpl_DtdParserProxy::System.Xml.IDtdParserAdapter.get_BaseUri()
extern "C" IL2CPP_METHOD_ATTR Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E * DtdParserProxy_System_Xml_IDtdParserAdapter_get_BaseUri_m52A4B84B039022155AC622A2B086ACE9A759BAE5 (DtdParserProxy_tF94C8FBE3EC41EF7C960BEDC0CD3DD25090265B7 * __this, const RuntimeMethod* method)
{
	{
		XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * L_0 = __this->get_reader_0();
		NullCheck(L_0);
		Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E * L_1 = XmlTextReaderImpl_get_DtdParserProxy_BaseUri_mF2E4A50579AF488866944F856C4AD8BE411DACF7(L_0, /*hidden argument*/NULL);
		return L_1;
	}
}
// System.Boolean System.Xml.XmlTextReaderImpl_DtdParserProxy::System.Xml.IDtdParserAdapter.get_IsEof()
extern "C" IL2CPP_METHOD_ATTR bool DtdParserProxy_System_Xml_IDtdParserAdapter_get_IsEof_m5220768473C12E512E485B700A753AF84E1CC293 (DtdParserProxy_tF94C8FBE3EC41EF7C960BEDC0CD3DD25090265B7 * __this, const RuntimeMethod* method)
{
	{
		XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * L_0 = __this->get_reader_0();
		NullCheck(L_0);
		bool L_1 = XmlTextReaderImpl_get_DtdParserProxy_IsEof_mF3D72303461DE771D8C45C2E3A1B69A6D0AC8F46(L_0, /*hidden argument*/NULL);
		return L_1;
	}
}
// System.Char[] System.Xml.XmlTextReaderImpl_DtdParserProxy::System.Xml.IDtdParserAdapter.get_ParsingBuffer()
extern "C" IL2CPP_METHOD_ATTR CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2* DtdParserProxy_System_Xml_IDtdParserAdapter_get_ParsingBuffer_mF63FEE3A1E5A2B3547392115787029FAC3222297 (DtdParserProxy_tF94C8FBE3EC41EF7C960BEDC0CD3DD25090265B7 * __this, const RuntimeMethod* method)
{
	{
		XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * L_0 = __this->get_reader_0();
		NullCheck(L_0);
		CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2* L_1 = XmlTextReaderImpl_get_DtdParserProxy_ParsingBuffer_m732E67E86FACC20D76FA4B242A4D68DDF2C4F8B4(L_0, /*hidden argument*/NULL);
		return L_1;
	}
}
// System.Int32 System.Xml.XmlTextReaderImpl_DtdParserProxy::System.Xml.IDtdParserAdapter.get_ParsingBufferLength()
extern "C" IL2CPP_METHOD_ATTR int32_t DtdParserProxy_System_Xml_IDtdParserAdapter_get_ParsingBufferLength_mA53413308A880F5551FA69AA1690D15E7D6B88BE (DtdParserProxy_tF94C8FBE3EC41EF7C960BEDC0CD3DD25090265B7 * __this, const RuntimeMethod* method)
{
	{
		XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * L_0 = __this->get_reader_0();
		NullCheck(L_0);
		int32_t L_1 = XmlTextReaderImpl_get_DtdParserProxy_ParsingBufferLength_mB8E5A0E682D68237CF8F91988B2FD401851EE1F6(L_0, /*hidden argument*/NULL);
		return L_1;
	}
}
// System.Int32 System.Xml.XmlTextReaderImpl_DtdParserProxy::System.Xml.IDtdParserAdapter.get_CurrentPosition()
extern "C" IL2CPP_METHOD_ATTR int32_t DtdParserProxy_System_Xml_IDtdParserAdapter_get_CurrentPosition_m470F1A642F0567770712B93EF240A8096BD7AB01 (DtdParserProxy_tF94C8FBE3EC41EF7C960BEDC0CD3DD25090265B7 * __this, const RuntimeMethod* method)
{
	{
		XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * L_0 = __this->get_reader_0();
		NullCheck(L_0);
		int32_t L_1 = XmlTextReaderImpl_get_DtdParserProxy_CurrentPosition_m52421528101C78618D4044A58AAB9B35F0F361E8(L_0, /*hidden argument*/NULL);
		return L_1;
	}
}
// System.Void System.Xml.XmlTextReaderImpl_DtdParserProxy::System.Xml.IDtdParserAdapter.set_CurrentPosition(System.Int32)
extern "C" IL2CPP_METHOD_ATTR void DtdParserProxy_System_Xml_IDtdParserAdapter_set_CurrentPosition_m1DF5F5AB2B1E13074CDC580E9461830909841C65 (DtdParserProxy_tF94C8FBE3EC41EF7C960BEDC0CD3DD25090265B7 * __this, int32_t ___value0, const RuntimeMethod* method)
{
	{
		XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * L_0 = __this->get_reader_0();
		int32_t L_1 = ___value0;
		NullCheck(L_0);
		XmlTextReaderImpl_set_DtdParserProxy_CurrentPosition_mA9B55AABF3CF3855E738277D0EE102B8476DFC31(L_0, L_1, /*hidden argument*/NULL);
		return;
	}
}
// System.Int32 System.Xml.XmlTextReaderImpl_DtdParserProxy::System.Xml.IDtdParserAdapter.get_EntityStackLength()
extern "C" IL2CPP_METHOD_ATTR int32_t DtdParserProxy_System_Xml_IDtdParserAdapter_get_EntityStackLength_m69CB21FD351A8249B8D51A1C4593E48AD7DA8568 (DtdParserProxy_tF94C8FBE3EC41EF7C960BEDC0CD3DD25090265B7 * __this, const RuntimeMethod* method)
{
	{
		XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * L_0 = __this->get_reader_0();
		NullCheck(L_0);
		int32_t L_1 = XmlTextReaderImpl_get_DtdParserProxy_EntityStackLength_mB3E614D6A13AE3CC15FCB3F39AD2BD01BA4CD37B(L_0, /*hidden argument*/NULL);
		return L_1;
	}
}
// System.Boolean System.Xml.XmlTextReaderImpl_DtdParserProxy::System.Xml.IDtdParserAdapter.get_IsEntityEolNormalized()
extern "C" IL2CPP_METHOD_ATTR bool DtdParserProxy_System_Xml_IDtdParserAdapter_get_IsEntityEolNormalized_mC190F188708BC00A9F5DBE5254BF37562293E315 (DtdParserProxy_tF94C8FBE3EC41EF7C960BEDC0CD3DD25090265B7 * __this, const RuntimeMethod* method)
{
	{
		XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * L_0 = __this->get_reader_0();
		NullCheck(L_0);
		bool L_1 = XmlTextReaderImpl_get_DtdParserProxy_IsEntityEolNormalized_m7CFE71A7E9CB847419D371F1CE50F14CCD29CF98(L_0, /*hidden argument*/NULL);
		return L_1;
	}
}
// System.Void System.Xml.XmlTextReaderImpl_DtdParserProxy::System.Xml.IDtdParserAdapter.OnNewLine(System.Int32)
extern "C" IL2CPP_METHOD_ATTR void DtdParserProxy_System_Xml_IDtdParserAdapter_OnNewLine_m5BF1A9C1D2A50FDB134794D155BD67FA7E10ADC2 (DtdParserProxy_tF94C8FBE3EC41EF7C960BEDC0CD3DD25090265B7 * __this, int32_t ___pos0, const RuntimeMethod* method)
{
	{
		XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * L_0 = __this->get_reader_0();
		int32_t L_1 = ___pos0;
		NullCheck(L_0);
		XmlTextReaderImpl_DtdParserProxy_OnNewLine_m54D60BD71043CCA2A79A92E36B33E3A1911A433E(L_0, L_1, /*hidden argument*/NULL);
		return;
	}
}
// System.Int32 System.Xml.XmlTextReaderImpl_DtdParserProxy::System.Xml.IDtdParserAdapter.get_LineNo()
extern "C" IL2CPP_METHOD_ATTR int32_t DtdParserProxy_System_Xml_IDtdParserAdapter_get_LineNo_m4466EDE0868A989235670A7BA849A5230679D2CF (DtdParserProxy_tF94C8FBE3EC41EF7C960BEDC0CD3DD25090265B7 * __this, const RuntimeMethod* method)
{
	{
		XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * L_0 = __this->get_reader_0();
		NullCheck(L_0);
		int32_t L_1 = XmlTextReaderImpl_get_DtdParserProxy_LineNo_mF6D9CDCA34905AB52FFDB0A8F7E86AE1439E571A(L_0, /*hidden argument*/NULL);
		return L_1;
	}
}
// System.Int32 System.Xml.XmlTextReaderImpl_DtdParserProxy::System.Xml.IDtdParserAdapter.get_LineStartPosition()
extern "C" IL2CPP_METHOD_ATTR int32_t DtdParserProxy_System_Xml_IDtdParserAdapter_get_LineStartPosition_mBACD093652C9778E1D3EE31A0FA8BEA8C30346FA (DtdParserProxy_tF94C8FBE3EC41EF7C960BEDC0CD3DD25090265B7 * __this, const RuntimeMethod* method)
{
	{
		XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * L_0 = __this->get_reader_0();
		NullCheck(L_0);
		int32_t L_1 = XmlTextReaderImpl_get_DtdParserProxy_LineStartPosition_mC2B02BC83BF626D234DC141BDF1DD2FE0AA38226(L_0, /*hidden argument*/NULL);
		return L_1;
	}
}
// System.Int32 System.Xml.XmlTextReaderImpl_DtdParserProxy::System.Xml.IDtdParserAdapter.ReadData()
extern "C" IL2CPP_METHOD_ATTR int32_t DtdParserProxy_System_Xml_IDtdParserAdapter_ReadData_mFEA585CA48AD763B5F5399A394F34E88F5C8C9E8 (DtdParserProxy_tF94C8FBE3EC41EF7C960BEDC0CD3DD25090265B7 * __this, const RuntimeMethod* method)
{
	{
		XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * L_0 = __this->get_reader_0();
		NullCheck(L_0);
		int32_t L_1 = XmlTextReaderImpl_DtdParserProxy_ReadData_mBCE4874C93F3847B98418C908AB5C10ECC5CC7A4(L_0, /*hidden argument*/NULL);
		return L_1;
	}
}
// System.Int32 System.Xml.XmlTextReaderImpl_DtdParserProxy::System.Xml.IDtdParserAdapter.ParseNumericCharRef(System.Text.StringBuilder)
extern "C" IL2CPP_METHOD_ATTR int32_t DtdParserProxy_System_Xml_IDtdParserAdapter_ParseNumericCharRef_mC5A854BFCAB7A1B6E676042093A175DC29465108 (DtdParserProxy_tF94C8FBE3EC41EF7C960BEDC0CD3DD25090265B7 * __this, StringBuilder_t * ___internalSubsetBuilder0, const RuntimeMethod* method)
{
	{
		XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * L_0 = __this->get_reader_0();
		StringBuilder_t * L_1 = ___internalSubsetBuilder0;
		NullCheck(L_0);
		int32_t L_2 = XmlTextReaderImpl_DtdParserProxy_ParseNumericCharRef_mFABC3FF9160DAEB435CF575CE550154E126526EA(L_0, L_1, /*hidden argument*/NULL);
		return L_2;
	}
}
// System.Int32 System.Xml.XmlTextReaderImpl_DtdParserProxy::System.Xml.IDtdParserAdapter.ParseNamedCharRef(System.Boolean,System.Text.StringBuilder)
extern "C" IL2CPP_METHOD_ATTR int32_t DtdParserProxy_System_Xml_IDtdParserAdapter_ParseNamedCharRef_mB21E3AEC7667F23EF0C6D6CA7FBCD39BEE84648F (DtdParserProxy_tF94C8FBE3EC41EF7C960BEDC0CD3DD25090265B7 * __this, bool ___expand0, StringBuilder_t * ___internalSubsetBuilder1, const RuntimeMethod* method)
{
	{
		XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * L_0 = __this->get_reader_0();
		bool L_1 = ___expand0;
		StringBuilder_t * L_2 = ___internalSubsetBuilder1;
		NullCheck(L_0);
		int32_t L_3 = XmlTextReaderImpl_DtdParserProxy_ParseNamedCharRef_mA59A919144E9C9256FE25125B1B20FC139E18F80(L_0, L_1, L_2, /*hidden argument*/NULL);
		return L_3;
	}
}
// System.Void System.Xml.XmlTextReaderImpl_DtdParserProxy::System.Xml.IDtdParserAdapter.ParsePI(System.Text.StringBuilder)
extern "C" IL2CPP_METHOD_ATTR void DtdParserProxy_System_Xml_IDtdParserAdapter_ParsePI_mC8CB57B3850FF5BBC6D4C044C21B48425AA420A6 (DtdParserProxy_tF94C8FBE3EC41EF7C960BEDC0CD3DD25090265B7 * __this, StringBuilder_t * ___sb0, const RuntimeMethod* method)
{
	{
		XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * L_0 = __this->get_reader_0();
		StringBuilder_t * L_1 = ___sb0;
		NullCheck(L_0);
		XmlTextReaderImpl_DtdParserProxy_ParsePI_mB882A376B7C7E442393A2F7E624D5B78CC36EA45(L_0, L_1, /*hidden argument*/NULL);
		return;
	}
}
// System.Void System.Xml.XmlTextReaderImpl_DtdParserProxy::System.Xml.IDtdParserAdapter.ParseComment(System.Text.StringBuilder)
extern "C" IL2CPP_METHOD_ATTR void DtdParserProxy_System_Xml_IDtdParserAdapter_ParseComment_m7098DF00F27699BF0CE9C87E19CA020BC6BB4316 (DtdParserProxy_tF94C8FBE3EC41EF7C960BEDC0CD3DD25090265B7 * __this, StringBuilder_t * ___sb0, const RuntimeMethod* method)
{
	{
		XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * L_0 = __this->get_reader_0();
		StringBuilder_t * L_1 = ___sb0;
		NullCheck(L_0);
		XmlTextReaderImpl_DtdParserProxy_ParseComment_mAAC7583A896F7BCF4785E621C4207C20FF5066B8(L_0, L_1, /*hidden argument*/NULL);
		return;
	}
}
// System.Boolean System.Xml.XmlTextReaderImpl_DtdParserProxy::System.Xml.IDtdParserAdapter.PushEntity(System.Xml.IDtdEntityInfo,System.Int32U26)
extern "C" IL2CPP_METHOD_ATTR bool DtdParserProxy_System_Xml_IDtdParserAdapter_PushEntity_m79236E743FE1B0B3A676CF364F77B132FA411B4C (DtdParserProxy_tF94C8FBE3EC41EF7C960BEDC0CD3DD25090265B7 * __this, RuntimeObject* ___entity0, int32_t* ___entityId1, const RuntimeMethod* method)
{
	{
		XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * L_0 = __this->get_reader_0();
		RuntimeObject* L_1 = ___entity0;
		int32_t* L_2 = ___entityId1;
		NullCheck(L_0);
		bool L_3 = XmlTextReaderImpl_DtdParserProxy_PushEntity_mECD5C4AD5E9040006BA77DA2559E6008A96E22E4(L_0, L_1, (int32_t*)L_2, /*hidden argument*/NULL);
		return L_3;
	}
}
// System.Boolean System.Xml.XmlTextReaderImpl_DtdParserProxy::System.Xml.IDtdParserAdapter.PopEntity(System.Xml.IDtdEntityInfoU26,System.Int32U26)
extern "C" IL2CPP_METHOD_ATTR bool DtdParserProxy_System_Xml_IDtdParserAdapter_PopEntity_m221A969F2BDF15ECD29C98C8E5190EF9C5F7F867 (DtdParserProxy_tF94C8FBE3EC41EF7C960BEDC0CD3DD25090265B7 * __this, RuntimeObject** ___oldEntity0, int32_t* ___newEntityId1, const RuntimeMethod* method)
{
	{
		XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * L_0 = __this->get_reader_0();
		RuntimeObject** L_1 = ___oldEntity0;
		int32_t* L_2 = ___newEntityId1;
		NullCheck(L_0);
		bool L_3 = XmlTextReaderImpl_DtdParserProxy_PopEntity_m180E9DC0F80126F67235BFE4AA23D22D554C74F1(L_0, (RuntimeObject**)L_1, (int32_t*)L_2, /*hidden argument*/NULL);
		return L_3;
	}
}
// System.Boolean System.Xml.XmlTextReaderImpl_DtdParserProxy::System.Xml.IDtdParserAdapter.PushExternalSubset(System.String,System.String)
extern "C" IL2CPP_METHOD_ATTR bool DtdParserProxy_System_Xml_IDtdParserAdapter_PushExternalSubset_mF5D4105E281BA8A1273432D73F53E9BD536C70C1 (DtdParserProxy_tF94C8FBE3EC41EF7C960BEDC0CD3DD25090265B7 * __this, String_t* ___systemId0, String_t* ___publicId1, const RuntimeMethod* method)
{
	{
		XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * L_0 = __this->get_reader_0();
		String_t* L_1 = ___systemId0;
		String_t* L_2 = ___publicId1;
		NullCheck(L_0);
		bool L_3 = XmlTextReaderImpl_DtdParserProxy_PushExternalSubset_mDD30749ED33A61DFF48062339109D14C299A0ECE(L_0, L_1, L_2, /*hidden argument*/NULL);
		return L_3;
	}
}
// System.Void System.Xml.XmlTextReaderImpl_DtdParserProxy::System.Xml.IDtdParserAdapter.PushInternalDtd(System.String,System.String)
extern "C" IL2CPP_METHOD_ATTR void DtdParserProxy_System_Xml_IDtdParserAdapter_PushInternalDtd_mA03D547EF05A1092A15820DDAA0151113BAB922F (DtdParserProxy_tF94C8FBE3EC41EF7C960BEDC0CD3DD25090265B7 * __this, String_t* ___baseUri0, String_t* ___internalDtd1, const RuntimeMethod* method)
{
	{
		XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * L_0 = __this->get_reader_0();
		String_t* L_1 = ___baseUri0;
		String_t* L_2 = ___internalDtd1;
		NullCheck(L_0);
		XmlTextReaderImpl_DtdParserProxy_PushInternalDtd_m6AC6F1C2B2106FB423D2A0777DDC23F5603891F4(L_0, L_1, L_2, /*hidden argument*/NULL);
		return;
	}
}
// System.Void System.Xml.XmlTextReaderImpl_DtdParserProxy::System.Xml.IDtdParserAdapter.Throw(System.Exception)
extern "C" IL2CPP_METHOD_ATTR void DtdParserProxy_System_Xml_IDtdParserAdapter_Throw_m9542006E009D152CF55C1F06C9A55BEE0D23A678 (DtdParserProxy_tF94C8FBE3EC41EF7C960BEDC0CD3DD25090265B7 * __this, Exception_t * ___e0, const RuntimeMethod* method)
{
	{
		XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * L_0 = __this->get_reader_0();
		Exception_t * L_1 = ___e0;
		NullCheck(L_0);
		XmlTextReaderImpl_DtdParserProxy_Throw_m6807FDDF98894315BADCE32EAC5E8B0C32C0AD33(L_0, L_1, /*hidden argument*/NULL);
		return;
	}
}
// System.Void System.Xml.XmlTextReaderImpl_DtdParserProxy::System.Xml.IDtdParserAdapter.OnSystemId(System.String,System.Xml.LineInfo,System.Xml.LineInfo)
extern "C" IL2CPP_METHOD_ATTR void DtdParserProxy_System_Xml_IDtdParserAdapter_OnSystemId_m4F28832D217320AA989C5A2F74CBBE8AD8A176A4 (DtdParserProxy_tF94C8FBE3EC41EF7C960BEDC0CD3DD25090265B7 * __this, String_t* ___systemId0, LineInfo_t7E3D50496C7BA51B84D485D0A30B9006943544E5  ___keywordLineInfo1, LineInfo_t7E3D50496C7BA51B84D485D0A30B9006943544E5  ___systemLiteralLineInfo2, const RuntimeMethod* method)
{
	{
		XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * L_0 = __this->get_reader_0();
		String_t* L_1 = ___systemId0;
		LineInfo_t7E3D50496C7BA51B84D485D0A30B9006943544E5  L_2 = ___keywordLineInfo1;
		LineInfo_t7E3D50496C7BA51B84D485D0A30B9006943544E5  L_3 = ___systemLiteralLineInfo2;
		NullCheck(L_0);
		XmlTextReaderImpl_DtdParserProxy_OnSystemId_mAA44EE85320C1F5AFAC2EE86217A88A04DA1285F(L_0, L_1, L_2, L_3, /*hidden argument*/NULL);
		return;
	}
}
// System.Void System.Xml.XmlTextReaderImpl_DtdParserProxy::System.Xml.IDtdParserAdapter.OnPublicId(System.String,System.Xml.LineInfo,System.Xml.LineInfo)
extern "C" IL2CPP_METHOD_ATTR void DtdParserProxy_System_Xml_IDtdParserAdapter_OnPublicId_m1D6B0F5095BDAE0B718DA9E8FA986C5DE918A9A3 (DtdParserProxy_tF94C8FBE3EC41EF7C960BEDC0CD3DD25090265B7 * __this, String_t* ___publicId0, LineInfo_t7E3D50496C7BA51B84D485D0A30B9006943544E5  ___keywordLineInfo1, LineInfo_t7E3D50496C7BA51B84D485D0A30B9006943544E5  ___publicLiteralLineInfo2, const RuntimeMethod* method)
{
	{
		XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * L_0 = __this->get_reader_0();
		String_t* L_1 = ___publicId0;
		LineInfo_t7E3D50496C7BA51B84D485D0A30B9006943544E5  L_2 = ___keywordLineInfo1;
		LineInfo_t7E3D50496C7BA51B84D485D0A30B9006943544E5  L_3 = ___publicLiteralLineInfo2;
		NullCheck(L_0);
		XmlTextReaderImpl_DtdParserProxy_OnPublicId_mAC5A2232A5BBD487837E35E2B805C37926ED5149(L_0, L_1, L_2, L_3, /*hidden argument*/NULL);
		return;
	}
}
// System.Boolean System.Xml.XmlTextReaderImpl_DtdParserProxy::System.Xml.IDtdParserAdapterWithValidation.get_DtdValidation()
extern "C" IL2CPP_METHOD_ATTR bool DtdParserProxy_System_Xml_IDtdParserAdapterWithValidation_get_DtdValidation_mB57AB33CE0230ED007B1BC84BC746A44DE385227 (DtdParserProxy_tF94C8FBE3EC41EF7C960BEDC0CD3DD25090265B7 * __this, const RuntimeMethod* method)
{
	{
		XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * L_0 = __this->get_reader_0();
		NullCheck(L_0);
		bool L_1 = XmlTextReaderImpl_get_DtdParserProxy_DtdValidation_m9D55886560D6F84A954F3F2645FDCD16C6EC0D51(L_0, /*hidden argument*/NULL);
		return L_1;
	}
}
// System.Xml.IValidationEventHandling System.Xml.XmlTextReaderImpl_DtdParserProxy::System.Xml.IDtdParserAdapterWithValidation.get_ValidationEventHandling()
extern "C" IL2CPP_METHOD_ATTR RuntimeObject* DtdParserProxy_System_Xml_IDtdParserAdapterWithValidation_get_ValidationEventHandling_mBB934C26D5BA92F4A88775505D63583E6A4BB255 (DtdParserProxy_tF94C8FBE3EC41EF7C960BEDC0CD3DD25090265B7 * __this, const RuntimeMethod* method)
{
	{
		XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * L_0 = __this->get_reader_0();
		NullCheck(L_0);
		RuntimeObject* L_1 = XmlTextReaderImpl_get_DtdParserProxy_ValidationEventHandling_m63C63E3979E32960701A5B251C0099348A37A2CA(L_0, /*hidden argument*/NULL);
		return L_1;
	}
}
// System.Boolean System.Xml.XmlTextReaderImpl_DtdParserProxy::System.Xml.IDtdParserAdapterV1.get_Normalization()
extern "C" IL2CPP_METHOD_ATTR bool DtdParserProxy_System_Xml_IDtdParserAdapterV1_get_Normalization_m82D835A9F6F12EBEB5C5523D01FF1328147F95F9 (DtdParserProxy_tF94C8FBE3EC41EF7C960BEDC0CD3DD25090265B7 * __this, const RuntimeMethod* method)
{
	{
		XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * L_0 = __this->get_reader_0();
		NullCheck(L_0);
		bool L_1 = XmlTextReaderImpl_get_DtdParserProxy_Normalization_mE177D1DFA47257E6433B29E798C5DCFC5A615BD7(L_0, /*hidden argument*/NULL);
		return L_1;
	}
}
// System.Boolean System.Xml.XmlTextReaderImpl_DtdParserProxy::System.Xml.IDtdParserAdapterV1.get_Namespaces()
extern "C" IL2CPP_METHOD_ATTR bool DtdParserProxy_System_Xml_IDtdParserAdapterV1_get_Namespaces_m694ED950F9C804883DEE5D1FB0221C57F42F271E (DtdParserProxy_tF94C8FBE3EC41EF7C960BEDC0CD3DD25090265B7 * __this, const RuntimeMethod* method)
{
	{
		XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * L_0 = __this->get_reader_0();
		NullCheck(L_0);
		bool L_1 = XmlTextReaderImpl_get_DtdParserProxy_Namespaces_mD03942B2D13243298515296268D68F4926F3CF20(L_0, /*hidden argument*/NULL);
		return L_1;
	}
}
// System.Boolean System.Xml.XmlTextReaderImpl_DtdParserProxy::System.Xml.IDtdParserAdapterV1.get_V1CompatibilityMode()
extern "C" IL2CPP_METHOD_ATTR bool DtdParserProxy_System_Xml_IDtdParserAdapterV1_get_V1CompatibilityMode_m6BC3892546ED0FFECD3F53D047313AB8466EA889 (DtdParserProxy_tF94C8FBE3EC41EF7C960BEDC0CD3DD25090265B7 * __this, const RuntimeMethod* method)
{
	{
		XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * L_0 = __this->get_reader_0();
		NullCheck(L_0);
		bool L_1 = XmlTextReaderImpl_get_DtdParserProxy_V1CompatibilityMode_mA32E5EBB4E7AAFB7B55C14182767E6FE2FCAA26E(L_0, /*hidden argument*/NULL);
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
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void System.Xml.XmlTextReaderImpl_NoNamespaceManager::.ctor()
extern "C" IL2CPP_METHOD_ATTR void NoNamespaceManager__ctor_mEB2BAA3D381F3F1262637E93EE1751183CEF462B (NoNamespaceManager_t11014200BFBB3974A5E72A75867B9730C7D7E883 * __this, const RuntimeMethod* method)
{
	{
		XmlNamespaceManager__ctor_m90EC2B95E3A18E70520DF7C98FBDB439E3BE6D2D(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.String System.Xml.XmlTextReaderImpl_NoNamespaceManager::get_DefaultNamespace()
extern "C" IL2CPP_METHOD_ATTR String_t* NoNamespaceManager_get_DefaultNamespace_mF2EE6849B1F51B0A441399EB7FF3F1F36869C4C4 (NoNamespaceManager_t11014200BFBB3974A5E72A75867B9730C7D7E883 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (NoNamespaceManager_get_DefaultNamespace_mF2EE6849B1F51B0A441399EB7FF3F1F36869C4C4_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		String_t* L_0 = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
		return L_0;
	}
}
// System.Void System.Xml.XmlTextReaderImpl_NoNamespaceManager::PushScope()
extern "C" IL2CPP_METHOD_ATTR void NoNamespaceManager_PushScope_m30772D24E5EC7F84059723F7340A0EF08EDDB101 (NoNamespaceManager_t11014200BFBB3974A5E72A75867B9730C7D7E883 * __this, const RuntimeMethod* method)
{
	{
		return;
	}
}
// System.Boolean System.Xml.XmlTextReaderImpl_NoNamespaceManager::PopScope()
extern "C" IL2CPP_METHOD_ATTR bool NoNamespaceManager_PopScope_m13B23055DB86E9754F197B6870DD9D19189DF87D (NoNamespaceManager_t11014200BFBB3974A5E72A75867B9730C7D7E883 * __this, const RuntimeMethod* method)
{
	{
		return (bool)0;
	}
}
// System.Void System.Xml.XmlTextReaderImpl_NoNamespaceManager::AddNamespace(System.String,System.String)
extern "C" IL2CPP_METHOD_ATTR void NoNamespaceManager_AddNamespace_mC7AD1BC355BBD06CDACE67C7AD6D16222937C6E9 (NoNamespaceManager_t11014200BFBB3974A5E72A75867B9730C7D7E883 * __this, String_t* ___prefix0, String_t* ___uri1, const RuntimeMethod* method)
{
	{
		return;
	}
}
// System.Collections.IEnumerator System.Xml.XmlTextReaderImpl_NoNamespaceManager::GetEnumerator()
extern "C" IL2CPP_METHOD_ATTR RuntimeObject* NoNamespaceManager_GetEnumerator_mA3D6C92178E249FF571189A8F27F45AAB375A506 (NoNamespaceManager_t11014200BFBB3974A5E72A75867B9730C7D7E883 * __this, const RuntimeMethod* method)
{
	{
		return (RuntimeObject*)NULL;
	}
}
// System.String System.Xml.XmlTextReaderImpl_NoNamespaceManager::LookupNamespace(System.String)
extern "C" IL2CPP_METHOD_ATTR String_t* NoNamespaceManager_LookupNamespace_m99593EEE9A0B2EE9505F98C205A63B35B07C273B (NoNamespaceManager_t11014200BFBB3974A5E72A75867B9730C7D7E883 * __this, String_t* ___prefix0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (NoNamespaceManager_LookupNamespace_m99593EEE9A0B2EE9505F98C205A63B35B07C273B_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		String_t* L_0 = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
		return L_0;
	}
}
// System.String System.Xml.XmlTextReaderImpl_NoNamespaceManager::LookupPrefix(System.String)
extern "C" IL2CPP_METHOD_ATTR String_t* NoNamespaceManager_LookupPrefix_m87057574E988EB338FDCE21772AF9CCAF827D9E6 (NoNamespaceManager_t11014200BFBB3974A5E72A75867B9730C7D7E883 * __this, String_t* ___uri0, const RuntimeMethod* method)
{
	{
		return (String_t*)NULL;
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
// System.Xml.XmlTextReaderImpl_NodeData System.Xml.XmlTextReaderImpl_NodeData::get_None()
extern "C" IL2CPP_METHOD_ATTR NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * NodeData_get_None_m439866B97299F03866A79F6A178B2FD4A45F6E6B (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (NodeData_get_None_m439866B97299F03866A79F6A178B2FD4A45F6E6B_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * L_0 = ((NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF_StaticFields*)il2cpp_codegen_static_fields_for(NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF_il2cpp_TypeInfo_var))->get_s_None_0();
		il2cpp_codegen_memory_barrier();
		if (L_0)
		{
			goto IL_0015;
		}
	}
	{
		NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * L_1 = (NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF *)il2cpp_codegen_object_new(NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF_il2cpp_TypeInfo_var);
		NodeData__ctor_m076D3A9B7188D2C830DDD3708764440856711ED7(L_1, /*hidden argument*/NULL);
		il2cpp_codegen_memory_barrier();
		((NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF_StaticFields*)il2cpp_codegen_static_fields_for(NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF_il2cpp_TypeInfo_var))->set_s_None_0(L_1);
	}

IL_0015:
	{
		NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * L_2 = ((NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF_StaticFields*)il2cpp_codegen_static_fields_for(NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF_il2cpp_TypeInfo_var))->get_s_None_0();
		il2cpp_codegen_memory_barrier();
		return L_2;
	}
}
// System.Void System.Xml.XmlTextReaderImpl_NodeData::.ctor()
extern "C" IL2CPP_METHOD_ATTR void NodeData__ctor_m076D3A9B7188D2C830DDD3708764440856711ED7 (NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m925ECA5E85CA100E3FB86A4F9E15C120E9A184C0(__this, /*hidden argument*/NULL);
		NodeData_Clear_mD71A1EC98F0BE924739AE49F5457A45ADA7A5C4D(__this, 0, /*hidden argument*/NULL);
		__this->set_xmlContextPushed_16((bool)0);
		return;
	}
}
// System.Int32 System.Xml.XmlTextReaderImpl_NodeData::get_LineNo()
extern "C" IL2CPP_METHOD_ATTR int32_t NodeData_get_LineNo_m65D99BBB9EDC648A79DDB50ECEE50C386741E003 (NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * __this, const RuntimeMethod* method)
{
	{
		LineInfo_t7E3D50496C7BA51B84D485D0A30B9006943544E5 * L_0 = __this->get_address_of_lineInfo_10();
		int32_t L_1 = L_0->get_lineNo_0();
		return L_1;
	}
}
// System.Int32 System.Xml.XmlTextReaderImpl_NodeData::get_LinePos()
extern "C" IL2CPP_METHOD_ATTR int32_t NodeData_get_LinePos_mD3E147F0A626B4DA939D38CCDC43DA121C338142 (NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * __this, const RuntimeMethod* method)
{
	{
		LineInfo_t7E3D50496C7BA51B84D485D0A30B9006943544E5 * L_0 = __this->get_address_of_lineInfo_10();
		int32_t L_1 = L_0->get_linePos_1();
		return L_1;
	}
}
// System.Boolean System.Xml.XmlTextReaderImpl_NodeData::get_IsEmptyElement()
extern "C" IL2CPP_METHOD_ATTR bool NodeData_get_IsEmptyElement_mECB610FA2675033E04C83231F003F0CC955364DA (NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * __this, const RuntimeMethod* method)
{
	{
		int32_t L_0 = __this->get_type_1();
		if ((!(((uint32_t)L_0) == ((uint32_t)1))))
		{
			goto IL_0010;
		}
	}
	{
		bool L_1 = __this->get_isEmptyOrDefault_14();
		return L_1;
	}

IL_0010:
	{
		return (bool)0;
	}
}
// System.Void System.Xml.XmlTextReaderImpl_NodeData::set_IsEmptyElement(System.Boolean)
extern "C" IL2CPP_METHOD_ATTR void NodeData_set_IsEmptyElement_mB0E8A20B411F8F7F9635DDAD2B11F76BBDA7FDC6 (NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * __this, bool ___value0, const RuntimeMethod* method)
{
	{
		bool L_0 = ___value0;
		__this->set_isEmptyOrDefault_14(L_0);
		return;
	}
}
// System.Boolean System.Xml.XmlTextReaderImpl_NodeData::get_IsDefaultAttribute()
extern "C" IL2CPP_METHOD_ATTR bool NodeData_get_IsDefaultAttribute_mAD56F44BC4B318261806A02DA187BC6A000E3BEA (NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * __this, const RuntimeMethod* method)
{
	{
		int32_t L_0 = __this->get_type_1();
		if ((!(((uint32_t)L_0) == ((uint32_t)2))))
		{
			goto IL_0010;
		}
	}
	{
		bool L_1 = __this->get_isEmptyOrDefault_14();
		return L_1;
	}

IL_0010:
	{
		return (bool)0;
	}
}
// System.Void System.Xml.XmlTextReaderImpl_NodeData::set_IsDefaultAttribute(System.Boolean)
extern "C" IL2CPP_METHOD_ATTR void NodeData_set_IsDefaultAttribute_mB7E827BC7B3CB413F518EE2C04C22F4E81F058B3 (NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * __this, bool ___value0, const RuntimeMethod* method)
{
	{
		bool L_0 = ___value0;
		__this->set_isEmptyOrDefault_14(L_0);
		return;
	}
}
// System.Boolean System.Xml.XmlTextReaderImpl_NodeData::get_ValueBuffered()
extern "C" IL2CPP_METHOD_ATTR bool NodeData_get_ValueBuffered_m7FD057CE5A48B546847B9FBFFDEB1D7C77608014 (NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * __this, const RuntimeMethod* method)
{
	{
		String_t* L_0 = __this->get_value_6();
		return (bool)((((RuntimeObject*)(String_t*)L_0) == ((RuntimeObject*)(RuntimeObject *)NULL))? 1 : 0);
	}
}
// System.String System.Xml.XmlTextReaderImpl_NodeData::get_StringValue()
extern "C" IL2CPP_METHOD_ATTR String_t* NodeData_get_StringValue_mB86B678495CCE0095452B8191A5B83183FE2E579 (NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * __this, const RuntimeMethod* method)
{
	{
		String_t* L_0 = __this->get_value_6();
		if (L_0)
		{
			goto IL_0025;
		}
	}
	{
		CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2* L_1 = __this->get_chars_7();
		int32_t L_2 = __this->get_valueStartPos_8();
		int32_t L_3 = __this->get_valueLength_9();
		String_t* L_4 = String_CreateString_mC7FB167C0D5B97F7EF502AF54399C61DD5B87509(NULL, L_1, L_2, L_3, /*hidden argument*/NULL);
		__this->set_value_6(L_4);
	}

IL_0025:
	{
		String_t* L_5 = __this->get_value_6();
		return L_5;
	}
}
// System.Void System.Xml.XmlTextReaderImpl_NodeData::TrimSpacesInValue()
extern "C" IL2CPP_METHOD_ATTR void NodeData_TrimSpacesInValue_m5E494EB090C8217B661353664A5C7302739ABD48 (NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * __this, const RuntimeMethod* method)
{
	{
		bool L_0 = NodeData_get_ValueBuffered_m7FD057CE5A48B546847B9FBFFDEB1D7C77608014(__this, /*hidden argument*/NULL);
		if (!L_0)
		{
			goto IL_0020;
		}
	}
	{
		CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2* L_1 = __this->get_chars_7();
		int32_t L_2 = __this->get_valueStartPos_8();
		int32_t* L_3 = __this->get_address_of_valueLength_9();
		XmlTextReaderImpl_StripSpaces_m727E8C1F0AC37111247AD7352DC8A209576C14E5(L_1, L_2, (int32_t*)L_3, /*hidden argument*/NULL);
		return;
	}

IL_0020:
	{
		String_t* L_4 = __this->get_value_6();
		String_t* L_5 = XmlTextReaderImpl_StripSpaces_mB12C2C6298DADEEB9E11040418F911DAD4AE335C(L_4, /*hidden argument*/NULL);
		__this->set_value_6(L_5);
		return;
	}
}
// System.Void System.Xml.XmlTextReaderImpl_NodeData::Clear(System.Xml.XmlNodeType)
extern "C" IL2CPP_METHOD_ATTR void NodeData_Clear_mD71A1EC98F0BE924739AE49F5457A45ADA7A5C4D (NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * __this, int32_t ___type0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (NodeData_Clear_mD71A1EC98F0BE924739AE49F5457A45ADA7A5C4D_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		int32_t L_0 = ___type0;
		__this->set_type_1(L_0);
		NodeData_ClearName_m4EEEF5315A52473FC6470BB297C8E506FECD764B(__this, /*hidden argument*/NULL);
		String_t* L_1 = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
		__this->set_value_6(L_1);
		__this->set_valueStartPos_8((-1));
		String_t* L_2 = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
		__this->set_nameWPrefix_5(L_2);
		__this->set_schemaType_18(NULL);
		__this->set_typedValue_19(NULL);
		return;
	}
}
// System.Void System.Xml.XmlTextReaderImpl_NodeData::ClearName()
extern "C" IL2CPP_METHOD_ATTR void NodeData_ClearName_m4EEEF5315A52473FC6470BB297C8E506FECD764B (NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (NodeData_ClearName_m4EEEF5315A52473FC6470BB297C8E506FECD764B_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		String_t* L_0 = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
		__this->set_localName_2(L_0);
		String_t* L_1 = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
		__this->set_prefix_3(L_1);
		String_t* L_2 = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
		__this->set_ns_4(L_2);
		String_t* L_3 = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
		__this->set_nameWPrefix_5(L_3);
		return;
	}
}
// System.Void System.Xml.XmlTextReaderImpl_NodeData::SetLineInfo(System.Int32,System.Int32)
extern "C" IL2CPP_METHOD_ATTR void NodeData_SetLineInfo_m5D93BA799C2C7A3A754A2C42E4F42D2CAC694DFE (NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * __this, int32_t ___lineNo0, int32_t ___linePos1, const RuntimeMethod* method)
{
	{
		LineInfo_t7E3D50496C7BA51B84D485D0A30B9006943544E5 * L_0 = __this->get_address_of_lineInfo_10();
		int32_t L_1 = ___lineNo0;
		int32_t L_2 = ___linePos1;
		LineInfo_Set_mAD399BFCEAB252539354B80ECF46E85F7D7B09E3((LineInfo_t7E3D50496C7BA51B84D485D0A30B9006943544E5 *)L_0, L_1, L_2, /*hidden argument*/NULL);
		return;
	}
}
// System.Void System.Xml.XmlTextReaderImpl_NodeData::SetLineInfo2(System.Int32,System.Int32)
extern "C" IL2CPP_METHOD_ATTR void NodeData_SetLineInfo2_m8E7C9C87B2E2AF930C692FC09BAAFC5F36083F20 (NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * __this, int32_t ___lineNo0, int32_t ___linePos1, const RuntimeMethod* method)
{
	{
		LineInfo_t7E3D50496C7BA51B84D485D0A30B9006943544E5 * L_0 = __this->get_address_of_lineInfo2_11();
		int32_t L_1 = ___lineNo0;
		int32_t L_2 = ___linePos1;
		LineInfo_Set_mAD399BFCEAB252539354B80ECF46E85F7D7B09E3((LineInfo_t7E3D50496C7BA51B84D485D0A30B9006943544E5 *)L_0, L_1, L_2, /*hidden argument*/NULL);
		return;
	}
}
// System.Void System.Xml.XmlTextReaderImpl_NodeData::SetValueNode(System.Xml.XmlNodeType,System.String)
extern "C" IL2CPP_METHOD_ATTR void NodeData_SetValueNode_m311A9DBEADE4189DF3E42E332A89464E1E23E7CE (NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * __this, int32_t ___type0, String_t* ___value1, const RuntimeMethod* method)
{
	{
		int32_t L_0 = ___type0;
		__this->set_type_1(L_0);
		NodeData_ClearName_m4EEEF5315A52473FC6470BB297C8E506FECD764B(__this, /*hidden argument*/NULL);
		String_t* L_1 = ___value1;
		__this->set_value_6(L_1);
		__this->set_valueStartPos_8((-1));
		return;
	}
}
// System.Void System.Xml.XmlTextReaderImpl_NodeData::SetValueNode(System.Xml.XmlNodeType,System.Char[],System.Int32,System.Int32)
extern "C" IL2CPP_METHOD_ATTR void NodeData_SetValueNode_m6F8516070D1CC8248D69A0D110B8731872AAA02D (NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * __this, int32_t ___type0, CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2* ___chars1, int32_t ___startPos2, int32_t ___len3, const RuntimeMethod* method)
{
	{
		int32_t L_0 = ___type0;
		__this->set_type_1(L_0);
		NodeData_ClearName_m4EEEF5315A52473FC6470BB297C8E506FECD764B(__this, /*hidden argument*/NULL);
		__this->set_value_6((String_t*)NULL);
		CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2* L_1 = ___chars1;
		__this->set_chars_7(L_1);
		int32_t L_2 = ___startPos2;
		__this->set_valueStartPos_8(L_2);
		int32_t L_3 = ___len3;
		__this->set_valueLength_9(L_3);
		return;
	}
}
// System.Void System.Xml.XmlTextReaderImpl_NodeData::SetNamedNode(System.Xml.XmlNodeType,System.String)
extern "C" IL2CPP_METHOD_ATTR void NodeData_SetNamedNode_m5BE05A811DCE5E36A09613E92B6EB7C69F291949 (NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * __this, int32_t ___type0, String_t* ___localName1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (NodeData_SetNamedNode_m5BE05A811DCE5E36A09613E92B6EB7C69F291949_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		int32_t L_0 = ___type0;
		String_t* L_1 = ___localName1;
		String_t* L_2 = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
		String_t* L_3 = ___localName1;
		NodeData_SetNamedNode_m77D0D37FB571646037FE64C72649995D06218A5F(__this, L_0, L_1, L_2, L_3, /*hidden argument*/NULL);
		return;
	}
}
// System.Void System.Xml.XmlTextReaderImpl_NodeData::SetNamedNode(System.Xml.XmlNodeType,System.String,System.String,System.String)
extern "C" IL2CPP_METHOD_ATTR void NodeData_SetNamedNode_m77D0D37FB571646037FE64C72649995D06218A5F (NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * __this, int32_t ___type0, String_t* ___localName1, String_t* ___prefix2, String_t* ___nameWPrefix3, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (NodeData_SetNamedNode_m77D0D37FB571646037FE64C72649995D06218A5F_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		int32_t L_0 = ___type0;
		__this->set_type_1(L_0);
		String_t* L_1 = ___localName1;
		__this->set_localName_2(L_1);
		String_t* L_2 = ___prefix2;
		__this->set_prefix_3(L_2);
		String_t* L_3 = ___nameWPrefix3;
		__this->set_nameWPrefix_5(L_3);
		String_t* L_4 = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
		__this->set_ns_4(L_4);
		String_t* L_5 = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
		__this->set_value_6(L_5);
		__this->set_valueStartPos_8((-1));
		return;
	}
}
// System.Void System.Xml.XmlTextReaderImpl_NodeData::SetValue(System.String)
extern "C" IL2CPP_METHOD_ATTR void NodeData_SetValue_m7460F9E4320831AA386FA5FDF2F606C1987167F3 (NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		__this->set_valueStartPos_8((-1));
		String_t* L_0 = ___value0;
		__this->set_value_6(L_0);
		return;
	}
}
// System.Void System.Xml.XmlTextReaderImpl_NodeData::SetValue(System.Char[],System.Int32,System.Int32)
extern "C" IL2CPP_METHOD_ATTR void NodeData_SetValue_m41387D07794996E6334F74AFCF1C52215366B679 (NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * __this, CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2* ___chars0, int32_t ___startPos1, int32_t ___len2, const RuntimeMethod* method)
{
	{
		__this->set_value_6((String_t*)NULL);
		CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2* L_0 = ___chars0;
		__this->set_chars_7(L_0);
		int32_t L_1 = ___startPos1;
		__this->set_valueStartPos_8(L_1);
		int32_t L_2 = ___len2;
		__this->set_valueLength_9(L_2);
		return;
	}
}
// System.Void System.Xml.XmlTextReaderImpl_NodeData::OnBufferInvalidated()
extern "C" IL2CPP_METHOD_ATTR void NodeData_OnBufferInvalidated_m43A7442913B0BFDCDED30F17C959646A49E0E04C (NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * __this, const RuntimeMethod* method)
{
	{
		String_t* L_0 = __this->get_value_6();
		if (L_0)
		{
			goto IL_0025;
		}
	}
	{
		CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2* L_1 = __this->get_chars_7();
		int32_t L_2 = __this->get_valueStartPos_8();
		int32_t L_3 = __this->get_valueLength_9();
		String_t* L_4 = String_CreateString_mC7FB167C0D5B97F7EF502AF54399C61DD5B87509(NULL, L_1, L_2, L_3, /*hidden argument*/NULL);
		__this->set_value_6(L_4);
	}

IL_0025:
	{
		__this->set_valueStartPos_8((-1));
		return;
	}
}
// System.Void System.Xml.XmlTextReaderImpl_NodeData::CopyTo(System.Int32,System.Text.StringBuilder)
extern "C" IL2CPP_METHOD_ATTR void NodeData_CopyTo_mF84D5DFA0BF7DBBA303DBB5899CB21019F0D0FF2 (NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * __this, int32_t ___valueOffset0, StringBuilder_t * ___sb1, const RuntimeMethod* method)
{
	{
		String_t* L_0 = __this->get_value_6();
		if (L_0)
		{
			goto IL_0026;
		}
	}
	{
		StringBuilder_t * L_1 = ___sb1;
		CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2* L_2 = __this->get_chars_7();
		int32_t L_3 = __this->get_valueStartPos_8();
		int32_t L_4 = ___valueOffset0;
		int32_t L_5 = __this->get_valueLength_9();
		int32_t L_6 = ___valueOffset0;
		NullCheck(L_1);
		StringBuilder_Append_m549C532422286A982F7956C9BAE197D00B30DCA8(L_1, L_2, ((int32_t)il2cpp_codegen_add((int32_t)L_3, (int32_t)L_4)), ((int32_t)il2cpp_codegen_subtract((int32_t)L_5, (int32_t)L_6)), /*hidden argument*/NULL);
		return;
	}

IL_0026:
	{
		int32_t L_7 = ___valueOffset0;
		if ((((int32_t)L_7) > ((int32_t)0)))
		{
			goto IL_0038;
		}
	}
	{
		StringBuilder_t * L_8 = ___sb1;
		String_t* L_9 = __this->get_value_6();
		NullCheck(L_8);
		StringBuilder_Append_mDBB8CCBB7750C67BE2F2D92F47E6C0FA42793260(L_8, L_9, /*hidden argument*/NULL);
		return;
	}

IL_0038:
	{
		StringBuilder_t * L_10 = ___sb1;
		String_t* L_11 = __this->get_value_6();
		int32_t L_12 = ___valueOffset0;
		String_t* L_13 = __this->get_value_6();
		NullCheck(L_13);
		int32_t L_14 = String_get_Length_mD48C8A16A5CF1914F330DCE82D9BE15C3BEDD018(L_13, /*hidden argument*/NULL);
		int32_t L_15 = ___valueOffset0;
		NullCheck(L_10);
		StringBuilder_Append_m9EB954E99DC99B8CC712ABB70EAA07616B841D46(L_10, L_11, L_12, ((int32_t)il2cpp_codegen_subtract((int32_t)L_14, (int32_t)L_15)), /*hidden argument*/NULL);
		return;
	}
}
// System.String System.Xml.XmlTextReaderImpl_NodeData::GetNameWPrefix(System.Xml.XmlNameTable)
extern "C" IL2CPP_METHOD_ATTR String_t* NodeData_GetNameWPrefix_m3093317F8D9A418033A0F245EB0E02EA4DA7EA3D (NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * __this, XmlNameTable_t3C1CDAB4E7D97DE41A409D6D9ADD2C10B1F281A6 * ___nt0, const RuntimeMethod* method)
{
	{
		String_t* L_0 = __this->get_nameWPrefix_5();
		if (!L_0)
		{
			goto IL_000f;
		}
	}
	{
		String_t* L_1 = __this->get_nameWPrefix_5();
		return L_1;
	}

IL_000f:
	{
		XmlNameTable_t3C1CDAB4E7D97DE41A409D6D9ADD2C10B1F281A6 * L_2 = ___nt0;
		String_t* L_3 = NodeData_CreateNameWPrefix_m5D8818A7500ABBADB43B2923EEC59CCDC28B3F97(__this, L_2, /*hidden argument*/NULL);
		return L_3;
	}
}
// System.String System.Xml.XmlTextReaderImpl_NodeData::CreateNameWPrefix(System.Xml.XmlNameTable)
extern "C" IL2CPP_METHOD_ATTR String_t* NodeData_CreateNameWPrefix_m5D8818A7500ABBADB43B2923EEC59CCDC28B3F97 (NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * __this, XmlNameTable_t3C1CDAB4E7D97DE41A409D6D9ADD2C10B1F281A6 * ___nt0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (NodeData_CreateNameWPrefix_m5D8818A7500ABBADB43B2923EEC59CCDC28B3F97_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		String_t* L_0 = __this->get_prefix_3();
		NullCheck(L_0);
		int32_t L_1 = String_get_Length_mD48C8A16A5CF1914F330DCE82D9BE15C3BEDD018(L_0, /*hidden argument*/NULL);
		if (L_1)
		{
			goto IL_001b;
		}
	}
	{
		String_t* L_2 = __this->get_localName_2();
		__this->set_nameWPrefix_5(L_2);
		goto IL_003d;
	}

IL_001b:
	{
		XmlNameTable_t3C1CDAB4E7D97DE41A409D6D9ADD2C10B1F281A6 * L_3 = ___nt0;
		String_t* L_4 = __this->get_prefix_3();
		String_t* L_5 = __this->get_localName_2();
		String_t* L_6 = String_Concat_mF4626905368D6558695A823466A1AF65EADB9923(L_4, _stringLiteral05A79F06CF3F67F726DAE68D18A2290F6C9A50C9, L_5, /*hidden argument*/NULL);
		NullCheck(L_3);
		String_t* L_7 = VirtFuncInvoker1< String_t*, String_t* >::Invoke(6 /* System.String System.Xml.XmlNameTable::Add(System.String) */, L_3, L_6);
		__this->set_nameWPrefix_5(L_7);
	}

IL_003d:
	{
		String_t* L_8 = __this->get_nameWPrefix_5();
		return L_8;
	}
}
// System.Int32 System.Xml.XmlTextReaderImpl_NodeData::System.IComparable.CompareTo(System.Object)
extern "C" IL2CPP_METHOD_ATTR int32_t NodeData_System_IComparable_CompareTo_m4E92445E817BC3141166CBED8CFCD9C1C8577F62 (NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * __this, RuntimeObject * ___obj0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (NodeData_System_IComparable_CompareTo_m4E92445E817BC3141166CBED8CFCD9C1C8577F62_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * V_0 = NULL;
	{
		RuntimeObject * L_0 = ___obj0;
		V_0 = ((NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF *)IsInstClass((RuntimeObject*)L_0, NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF_il2cpp_TypeInfo_var));
		NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * L_1 = V_0;
		if (!L_1)
		{
			goto IL_0056;
		}
	}
	{
		String_t* L_2 = __this->get_localName_2();
		NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * L_3 = V_0;
		NullCheck(L_3);
		String_t* L_4 = L_3->get_localName_2();
		bool L_5 = Ref_Equal_mE6DE69202A01B55D8F7C88627331ADB96F88CA00(L_2, L_4, /*hidden argument*/NULL);
		if (!L_5)
		{
			goto IL_0044;
		}
	}
	{
		String_t* L_6 = __this->get_ns_4();
		NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * L_7 = V_0;
		NullCheck(L_7);
		String_t* L_8 = L_7->get_ns_4();
		bool L_9 = Ref_Equal_mE6DE69202A01B55D8F7C88627331ADB96F88CA00(L_6, L_8, /*hidden argument*/NULL);
		if (!L_9)
		{
			goto IL_0032;
		}
	}
	{
		return 0;
	}

IL_0032:
	{
		String_t* L_10 = __this->get_ns_4();
		NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * L_11 = V_0;
		NullCheck(L_11);
		String_t* L_12 = L_11->get_ns_4();
		int32_t L_13 = String_CompareOrdinal_m172D84EDDE0823F53EAB60857C07EA7F85600068(L_10, L_12, /*hidden argument*/NULL);
		return L_13;
	}

IL_0044:
	{
		String_t* L_14 = __this->get_localName_2();
		NodeData_tAACF4D5ECADB9124568D01525E72D14495BC5ACF * L_15 = V_0;
		NullCheck(L_15);
		String_t* L_16 = L_15->get_localName_2();
		int32_t L_17 = String_CompareOrdinal_m172D84EDDE0823F53EAB60857C07EA7F85600068(L_14, L_16, /*hidden argument*/NULL);
		return L_17;
	}

IL_0056:
	{
		return 1;
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
// System.Void System.Xml.XmlTextReaderImpl_OnDefaultAttributeUseDelegate::.ctor(System.Object,System.IntPtr)
extern "C" IL2CPP_METHOD_ATTR void OnDefaultAttributeUseDelegate__ctor_m93599EE4C0D026AAA717B1EC5C6CD8FE0E0FF6BA (OnDefaultAttributeUseDelegate_tE83A97BD37E08D3C5AA377CEA6388782D99EA34D * __this, RuntimeObject * ___object0, intptr_t ___method1, const RuntimeMethod* method)
{
	__this->set_method_ptr_0(il2cpp_codegen_get_method_pointer((RuntimeMethod*)___method1));
	__this->set_method_3(___method1);
	__this->set_m_target_2(___object0);
}
// System.Void System.Xml.XmlTextReaderImpl_OnDefaultAttributeUseDelegate::Invoke(System.Xml.IDtdDefaultAttributeInfo,System.Xml.XmlTextReaderImpl)
extern "C" IL2CPP_METHOD_ATTR void OnDefaultAttributeUseDelegate_Invoke_m71C321CF6849E9AFBCFB0B23CA0476C98AC584BC (OnDefaultAttributeUseDelegate_tE83A97BD37E08D3C5AA377CEA6388782D99EA34D * __this, RuntimeObject* ___defaultAttribute0, XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * ___coreReader1, const RuntimeMethod* method)
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
					typedef void (*FunctionPointerType) (RuntimeObject*, XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 *, const RuntimeMethod*);
					((FunctionPointerType)targetMethodPointer)(___defaultAttribute0, ___coreReader1, targetMethod);
				}
				else
				{
					// closed
					typedef void (*FunctionPointerType) (void*, RuntimeObject*, XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 *, const RuntimeMethod*);
					((FunctionPointerType)targetMethodPointer)(targetThis, ___defaultAttribute0, ___coreReader1, targetMethod);
				}
			}
			else if (___parameterCount != 2)
			{
				// open
				if (il2cpp_codegen_method_is_virtual(targetMethod) && !il2cpp_codegen_object_is_of_sealed_type(targetThis) && il2cpp_codegen_delegate_has_invoker((Il2CppDelegate*)__this))
				{
					if (il2cpp_codegen_method_is_virtual(targetMethod) && !il2cpp_codegen_object_is_of_sealed_type(targetThis) && il2cpp_codegen_delegate_has_invoker((Il2CppDelegate*)__this))
					{
						if (il2cpp_codegen_method_is_generic_instance(targetMethod))
						{
							if (il2cpp_codegen_method_is_interface_method(targetMethod))
								GenericInterfaceActionInvoker1< XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * >::Invoke(targetMethod, ___defaultAttribute0, ___coreReader1);
							else
								GenericVirtActionInvoker1< XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * >::Invoke(targetMethod, ___defaultAttribute0, ___coreReader1);
						}
						else
						{
							if (il2cpp_codegen_method_is_interface_method(targetMethod))
								InterfaceActionInvoker1< XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), il2cpp_codegen_method_get_declaring_type(targetMethod), ___defaultAttribute0, ___coreReader1);
							else
								VirtActionInvoker1< XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), ___defaultAttribute0, ___coreReader1);
						}
					}
				}
				else
				{
					typedef void (*FunctionPointerType) (RuntimeObject*, XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 *, const RuntimeMethod*);
					((FunctionPointerType)targetMethodPointer)(___defaultAttribute0, ___coreReader1, targetMethod);
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
							typedef void (*FunctionPointerType) (RuntimeObject*, XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 *, const RuntimeMethod*);
							((FunctionPointerType)targetMethodPointer)(___defaultAttribute0, ___coreReader1, targetMethod);
						}
						else if (il2cpp_codegen_method_is_generic_instance(targetMethod))
						{
							if (il2cpp_codegen_method_is_interface_method(targetMethod))
								GenericInterfaceActionInvoker2< RuntimeObject*, XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * >::Invoke(targetMethod, targetThis, ___defaultAttribute0, ___coreReader1);
							else
								GenericVirtActionInvoker2< RuntimeObject*, XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * >::Invoke(targetMethod, targetThis, ___defaultAttribute0, ___coreReader1);
						}
						else
						{
							if (il2cpp_codegen_method_is_interface_method(targetMethod))
								InterfaceActionInvoker2< RuntimeObject*, XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), il2cpp_codegen_method_get_declaring_type(targetMethod), targetThis, ___defaultAttribute0, ___coreReader1);
							else
								VirtActionInvoker2< RuntimeObject*, XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), targetThis, ___defaultAttribute0, ___coreReader1);
						}
					}
				}
				else
				{
					typedef void (*FunctionPointerType) (void*, RuntimeObject*, XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 *, const RuntimeMethod*);
					((FunctionPointerType)targetMethodPointer)(targetThis, ___defaultAttribute0, ___coreReader1, targetMethod);
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
				typedef void (*FunctionPointerType) (RuntimeObject*, XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 *, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(___defaultAttribute0, ___coreReader1, targetMethod);
			}
			else
			{
				// closed
				typedef void (*FunctionPointerType) (void*, RuntimeObject*, XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 *, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetThis, ___defaultAttribute0, ___coreReader1, targetMethod);
			}
		}
		else if (___parameterCount != 2)
		{
			// open
			if (il2cpp_codegen_method_is_virtual(targetMethod) && !il2cpp_codegen_object_is_of_sealed_type(targetThis) && il2cpp_codegen_delegate_has_invoker((Il2CppDelegate*)__this))
			{
				if (il2cpp_codegen_method_is_virtual(targetMethod) && !il2cpp_codegen_object_is_of_sealed_type(targetThis) && il2cpp_codegen_delegate_has_invoker((Il2CppDelegate*)__this))
				{
					if (il2cpp_codegen_method_is_generic_instance(targetMethod))
					{
						if (il2cpp_codegen_method_is_interface_method(targetMethod))
							GenericInterfaceActionInvoker1< XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * >::Invoke(targetMethod, ___defaultAttribute0, ___coreReader1);
						else
							GenericVirtActionInvoker1< XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * >::Invoke(targetMethod, ___defaultAttribute0, ___coreReader1);
					}
					else
					{
						if (il2cpp_codegen_method_is_interface_method(targetMethod))
							InterfaceActionInvoker1< XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), il2cpp_codegen_method_get_declaring_type(targetMethod), ___defaultAttribute0, ___coreReader1);
						else
							VirtActionInvoker1< XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), ___defaultAttribute0, ___coreReader1);
					}
				}
			}
			else
			{
				typedef void (*FunctionPointerType) (RuntimeObject*, XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 *, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(___defaultAttribute0, ___coreReader1, targetMethod);
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
						typedef void (*FunctionPointerType) (RuntimeObject*, XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 *, const RuntimeMethod*);
						((FunctionPointerType)targetMethodPointer)(___defaultAttribute0, ___coreReader1, targetMethod);
					}
					else if (il2cpp_codegen_method_is_generic_instance(targetMethod))
					{
						if (il2cpp_codegen_method_is_interface_method(targetMethod))
							GenericInterfaceActionInvoker2< RuntimeObject*, XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * >::Invoke(targetMethod, targetThis, ___defaultAttribute0, ___coreReader1);
						else
							GenericVirtActionInvoker2< RuntimeObject*, XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * >::Invoke(targetMethod, targetThis, ___defaultAttribute0, ___coreReader1);
					}
					else
					{
						if (il2cpp_codegen_method_is_interface_method(targetMethod))
							InterfaceActionInvoker2< RuntimeObject*, XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), il2cpp_codegen_method_get_declaring_type(targetMethod), targetThis, ___defaultAttribute0, ___coreReader1);
						else
							VirtActionInvoker2< RuntimeObject*, XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), targetThis, ___defaultAttribute0, ___coreReader1);
					}
				}
			}
			else
			{
				typedef void (*FunctionPointerType) (void*, RuntimeObject*, XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 *, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetThis, ___defaultAttribute0, ___coreReader1, targetMethod);
			}
		}
	}
}
// System.IAsyncResult System.Xml.XmlTextReaderImpl_OnDefaultAttributeUseDelegate::BeginInvoke(System.Xml.IDtdDefaultAttributeInfo,System.Xml.XmlTextReaderImpl,System.AsyncCallback,System.Object)
extern "C" IL2CPP_METHOD_ATTR RuntimeObject* OnDefaultAttributeUseDelegate_BeginInvoke_m5F77C01C5CD5EBBB76ABA77EA6CB3749EA4F38FD (OnDefaultAttributeUseDelegate_tE83A97BD37E08D3C5AA377CEA6388782D99EA34D * __this, RuntimeObject* ___defaultAttribute0, XmlTextReaderImpl_t393737BE3F9168D966F164C2FD840C3494DEDE61 * ___coreReader1, AsyncCallback_t3F3DA3BEDAEE81DD1D24125DF8EB30E85EE14DA4 * ___callback2, RuntimeObject * ___object3, const RuntimeMethod* method)
{
	void *__d_args[3] = {0};
	__d_args[0] = ___defaultAttribute0;
	__d_args[1] = ___coreReader1;
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___callback2, (RuntimeObject*)___object3);
}
// System.Void System.Xml.XmlTextReaderImpl_OnDefaultAttributeUseDelegate::EndInvoke(System.IAsyncResult)
extern "C" IL2CPP_METHOD_ATTR void OnDefaultAttributeUseDelegate_EndInvoke_mCB8BBEF251A5656354ABA58F2A29FD3F8FF36073 (OnDefaultAttributeUseDelegate_tE83A97BD37E08D3C5AA377CEA6388782D99EA34D * __this, RuntimeObject* ___result0, const RuntimeMethod* method)
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
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Conversion methods for marshalling of: System.Xml.XmlTextReaderImpl/ParsingState
extern "C" void ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2_marshal_pinvoke(const ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2& unmarshaled, ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2_marshaled_pinvoke& marshaled)
{
	Exception_t* ___encoding_3Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'encoding' of type 'ParsingState': Reference type field marshaling is not supported.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___encoding_3Exception, NULL, NULL);
}
extern "C" void ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2_marshal_pinvoke_back(const ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2_marshaled_pinvoke& marshaled, ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2& unmarshaled)
{
	Exception_t* ___encoding_3Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'encoding' of type 'ParsingState': Reference type field marshaling is not supported.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___encoding_3Exception, NULL, NULL);
}
// Conversion method for clean up from marshalling of: System.Xml.XmlTextReaderImpl/ParsingState
extern "C" void ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2_marshal_pinvoke_cleanup(ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2_marshaled_pinvoke& marshaled)
{
}
// Conversion methods for marshalling of: System.Xml.XmlTextReaderImpl/ParsingState
extern "C" void ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2_marshal_com(const ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2& unmarshaled, ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2_marshaled_com& marshaled)
{
	Exception_t* ___encoding_3Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'encoding' of type 'ParsingState': Reference type field marshaling is not supported.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___encoding_3Exception, NULL, NULL);
}
extern "C" void ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2_marshal_com_back(const ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2_marshaled_com& marshaled, ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2& unmarshaled)
{
	Exception_t* ___encoding_3Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'encoding' of type 'ParsingState': Reference type field marshaling is not supported.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___encoding_3Exception, NULL, NULL);
}
// Conversion method for clean up from marshalling of: System.Xml.XmlTextReaderImpl/ParsingState
extern "C" void ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2_marshal_com_cleanup(ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2_marshaled_com& marshaled)
{
}
// System.Void System.Xml.XmlTextReaderImpl_ParsingState::Clear()
extern "C" IL2CPP_METHOD_ATTR void ParsingState_Clear_mB03C277E58A91CB626BBE6EC5CF2D6E97ECE48E2 (ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (ParsingState_Clear_mB03C277E58A91CB626BBE6EC5CF2D6E97ECE48E2_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		__this->set_chars_0((CharU5BU5D_t4CC6ABF0AD71BEC97E3C2F1E9C5677E46D3A75C2*)NULL);
		__this->set_charPos_1(0);
		__this->set_charsUsed_2(0);
		__this->set_encoding_3((Encoding_t7837A3C0F55EAE0E3959A53C6D6E88B113ED78A4 *)NULL);
		__this->set_stream_5((Stream_tFC50657DD5AAB87770987F9179D934A51D99D5E7 *)NULL);
		__this->set_decoder_6((Decoder_tEEF45EB6F965222036C49E8EC6BA8A0692AA1F26 *)NULL);
		__this->set_bytes_7((ByteU5BU5D_tD06FDBE8142446525DF1C40351D523A228373821*)NULL);
		__this->set_bytePos_8(0);
		__this->set_bytesUsed_9(0);
		__this->set_textReader_10((TextReader_t7DF8314B601D202ECFEDF623093A87BFDAB58D0A *)NULL);
		__this->set_lineNo_11(1);
		__this->set_lineStartPos_12((-1));
		String_t* L_0 = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
		__this->set_baseUriStr_13(L_0);
		__this->set_baseUri_14((Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E *)NULL);
		__this->set_isEof_15((bool)0);
		__this->set_isStreamEof_16((bool)0);
		__this->set_eolNormalized_19((bool)1);
		__this->set_entityResolvedManually_20((bool)0);
		return;
	}
}
extern "C"  void ParsingState_Clear_mB03C277E58A91CB626BBE6EC5CF2D6E97ECE48E2_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2 * _thisAdjusted = reinterpret_cast<ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2 *>(__this + 1);
	ParsingState_Clear_mB03C277E58A91CB626BBE6EC5CF2D6E97ECE48E2(_thisAdjusted, method);
}
// System.Void System.Xml.XmlTextReaderImpl_ParsingState::Close(System.Boolean)
extern "C" IL2CPP_METHOD_ATTR void ParsingState_Close_mD17CB448C04F94BE7FA9AFC29B1443C88BCE67B4 (ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2 * __this, bool ___closeInput0, const RuntimeMethod* method)
{
	{
		bool L_0 = ___closeInput0;
		if (!L_0)
		{
			goto IL_002a;
		}
	}
	{
		Stream_tFC50657DD5AAB87770987F9179D934A51D99D5E7 * L_1 = __this->get_stream_5();
		if (!L_1)
		{
			goto IL_0017;
		}
	}
	{
		Stream_tFC50657DD5AAB87770987F9179D934A51D99D5E7 * L_2 = __this->get_stream_5();
		NullCheck(L_2);
		VirtActionInvoker0::Invoke(15 /* System.Void System.IO.Stream::Close() */, L_2);
		return;
	}

IL_0017:
	{
		TextReader_t7DF8314B601D202ECFEDF623093A87BFDAB58D0A * L_3 = __this->get_textReader_10();
		if (!L_3)
		{
			goto IL_002a;
		}
	}
	{
		TextReader_t7DF8314B601D202ECFEDF623093A87BFDAB58D0A * L_4 = __this->get_textReader_10();
		NullCheck(L_4);
		VirtActionInvoker0::Invoke(7 /* System.Void System.IO.TextReader::Close() */, L_4);
	}

IL_002a:
	{
		return;
	}
}
extern "C"  void ParsingState_Close_mD17CB448C04F94BE7FA9AFC29B1443C88BCE67B4_AdjustorThunk (RuntimeObject * __this, bool ___closeInput0, const RuntimeMethod* method)
{
	ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2 * _thisAdjusted = reinterpret_cast<ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2 *>(__this + 1);
	ParsingState_Close_mD17CB448C04F94BE7FA9AFC29B1443C88BCE67B4(_thisAdjusted, ___closeInput0, method);
}
// System.Int32 System.Xml.XmlTextReaderImpl_ParsingState::get_LineNo()
extern "C" IL2CPP_METHOD_ATTR int32_t ParsingState_get_LineNo_m2F68C696B809CC3B5F5AC076BD88E039C5CAB53A (ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2 * __this, const RuntimeMethod* method)
{
	{
		int32_t L_0 = __this->get_lineNo_11();
		return L_0;
	}
}
extern "C"  int32_t ParsingState_get_LineNo_m2F68C696B809CC3B5F5AC076BD88E039C5CAB53A_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2 * _thisAdjusted = reinterpret_cast<ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2 *>(__this + 1);
	return ParsingState_get_LineNo_m2F68C696B809CC3B5F5AC076BD88E039C5CAB53A(_thisAdjusted, method);
}
// System.Int32 System.Xml.XmlTextReaderImpl_ParsingState::get_LinePos()
extern "C" IL2CPP_METHOD_ATTR int32_t ParsingState_get_LinePos_m89ABB430BB316ED269D32CEEFDBFFC32306DFACF (ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2 * __this, const RuntimeMethod* method)
{
	{
		int32_t L_0 = __this->get_charPos_1();
		int32_t L_1 = __this->get_lineStartPos_12();
		return ((int32_t)il2cpp_codegen_subtract((int32_t)L_0, (int32_t)L_1));
	}
}
extern "C"  int32_t ParsingState_get_LinePos_m89ABB430BB316ED269D32CEEFDBFFC32306DFACF_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2 * _thisAdjusted = reinterpret_cast<ParsingState_tE4A8E7F14B2068AE43ECF99F81F55B0301A551A2 *>(__this + 1);
	return ParsingState_get_LinePos_m89ABB430BB316ED269D32CEEFDBFFC32306DFACF(_thisAdjusted, method);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void System.Xml.XmlTextReaderImpl_XmlContext::.ctor()
extern "C" IL2CPP_METHOD_ATTR void XmlContext__ctor_m286116CAF14DF829F24584EA85FC55DA1A507DBF (XmlContext_tC94B1A0D023B096ADF338FA72FB55D0E2DBF9B52 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (XmlContext__ctor_m286116CAF14DF829F24584EA85FC55DA1A507DBF_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		Object__ctor_m925ECA5E85CA100E3FB86A4F9E15C120E9A184C0(__this, /*hidden argument*/NULL);
		__this->set_xmlSpace_0(0);
		String_t* L_0 = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
		__this->set_xmlLang_1(L_0);
		String_t* L_1 = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
		__this->set_defaultNamespace_2(L_1);
		__this->set_previousContext_3((XmlContext_tC94B1A0D023B096ADF338FA72FB55D0E2DBF9B52 *)NULL);
		return;
	}
}
// System.Void System.Xml.XmlTextReaderImpl_XmlContext::.ctor(System.Xml.XmlTextReaderImpl_XmlContext)
extern "C" IL2CPP_METHOD_ATTR void XmlContext__ctor_mBB84FF04DE297252942CC5731BBBC3F5DCEAD4D2 (XmlContext_tC94B1A0D023B096ADF338FA72FB55D0E2DBF9B52 * __this, XmlContext_tC94B1A0D023B096ADF338FA72FB55D0E2DBF9B52 * ___previousContext0, const RuntimeMethod* method)
{
	{
		Object__ctor_m925ECA5E85CA100E3FB86A4F9E15C120E9A184C0(__this, /*hidden argument*/NULL);
		XmlContext_tC94B1A0D023B096ADF338FA72FB55D0E2DBF9B52 * L_0 = ___previousContext0;
		NullCheck(L_0);
		int32_t L_1 = L_0->get_xmlSpace_0();
		__this->set_xmlSpace_0(L_1);
		XmlContext_tC94B1A0D023B096ADF338FA72FB55D0E2DBF9B52 * L_2 = ___previousContext0;
		NullCheck(L_2);
		String_t* L_3 = L_2->get_xmlLang_1();
		__this->set_xmlLang_1(L_3);
		XmlContext_tC94B1A0D023B096ADF338FA72FB55D0E2DBF9B52 * L_4 = ___previousContext0;
		NullCheck(L_4);
		String_t* L_5 = L_4->get_defaultNamespace_2();
		__this->set_defaultNamespace_2(L_5);
		XmlContext_tC94B1A0D023B096ADF338FA72FB55D0E2DBF9B52 * L_6 = ___previousContext0;
		__this->set_previousContext_3(L_6);
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
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void System.Xml.XmlUnspecifiedAttribute::.ctor(System.String,System.String,System.String,System.Xml.XmlDocument)
extern "C" IL2CPP_METHOD_ATTR void XmlUnspecifiedAttribute__ctor_mE777BCF4E5CF4B6A6FB3A5D86B2049A0FC69A9EA (XmlUnspecifiedAttribute_t1C82B285B60096D164B703202A8BD91A2009DE5D * __this, String_t* ___prefix0, String_t* ___localName1, String_t* ___namespaceURI2, XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97 * ___doc3, const RuntimeMethod* method)
{
	{
		String_t* L_0 = ___prefix0;
		String_t* L_1 = ___localName1;
		String_t* L_2 = ___namespaceURI2;
		XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97 * L_3 = ___doc3;
		XmlAttribute__ctor_m6A0A80A14549911E2901FB44FA291BD8DDBB7A8F(__this, L_0, L_1, L_2, L_3, /*hidden argument*/NULL);
		return;
	}
}
// System.Boolean System.Xml.XmlUnspecifiedAttribute::get_Specified()
extern "C" IL2CPP_METHOD_ATTR bool XmlUnspecifiedAttribute_get_Specified_mBEDAB05EFC60EA50883A76DF8750107B97F89576 (XmlUnspecifiedAttribute_t1C82B285B60096D164B703202A8BD91A2009DE5D * __this, const RuntimeMethod* method)
{
	{
		bool L_0 = __this->get_fSpecified_3();
		return L_0;
	}
}
// System.Xml.XmlNode System.Xml.XmlUnspecifiedAttribute::CloneNode(System.Boolean)
extern "C" IL2CPP_METHOD_ATTR XmlNode_t07D70045D843753E4FE8AFE40FD36244E6B6D7FB * XmlUnspecifiedAttribute_CloneNode_mC54FB5A0257784A556FC0789575EB4DE4DA0EC38 (XmlUnspecifiedAttribute_t1C82B285B60096D164B703202A8BD91A2009DE5D * __this, bool ___deep0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (XmlUnspecifiedAttribute_CloneNode_mC54FB5A0257784A556FC0789575EB4DE4DA0EC38_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97 * V_0 = NULL;
	{
		XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97 * L_0 = VirtFuncInvoker0< XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97 * >::Invoke(14 /* System.Xml.XmlDocument System.Xml.XmlNode::get_OwnerDocument() */, __this);
		V_0 = L_0;
		XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97 * L_1 = V_0;
		String_t* L_2 = VirtFuncInvoker0< String_t* >::Invoke(29 /* System.String System.Xml.XmlNode::get_Prefix() */, __this);
		String_t* L_3 = VirtFuncInvoker0< String_t* >::Invoke(30 /* System.String System.Xml.XmlNode::get_LocalName() */, __this);
		String_t* L_4 = VirtFuncInvoker0< String_t* >::Invoke(28 /* System.String System.Xml.XmlNode::get_NamespaceURI() */, __this);
		NullCheck(L_1);
		XmlAttribute_tEAB5F066D1D6965D6528617BD89826AE7114DEFA * L_5 = VirtFuncInvoker3< XmlAttribute_tEAB5F066D1D6965D6528617BD89826AE7114DEFA *, String_t*, String_t*, String_t* >::Invoke(56 /* System.Xml.XmlAttribute System.Xml.XmlDocument::CreateDefaultAttribute(System.String,System.String,System.String) */, L_1, L_2, L_3, L_4);
		XmlUnspecifiedAttribute_t1C82B285B60096D164B703202A8BD91A2009DE5D * L_6 = ((XmlUnspecifiedAttribute_t1C82B285B60096D164B703202A8BD91A2009DE5D *)CastclassClass((RuntimeObject*)L_5, XmlUnspecifiedAttribute_t1C82B285B60096D164B703202A8BD91A2009DE5D_il2cpp_TypeInfo_var));
		XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97 * L_7 = V_0;
		NullCheck(L_6);
		VirtActionInvoker3< XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97 *, XmlNode_t07D70045D843753E4FE8AFE40FD36244E6B6D7FB *, bool >::Invoke(27 /* System.Void System.Xml.XmlNode::CopyChildren(System.Xml.XmlDocument,System.Xml.XmlNode,System.Boolean) */, L_6, L_7, __this, (bool)1);
		XmlUnspecifiedAttribute_t1C82B285B60096D164B703202A8BD91A2009DE5D * L_8 = L_6;
		NullCheck(L_8);
		L_8->set_fSpecified_3((bool)1);
		return L_8;
	}
}
// System.Xml.XmlNode System.Xml.XmlUnspecifiedAttribute::RemoveChild(System.Xml.XmlNode)
extern "C" IL2CPP_METHOD_ATTR XmlNode_t07D70045D843753E4FE8AFE40FD36244E6B6D7FB * XmlUnspecifiedAttribute_RemoveChild_mC4109B83678A178250CA6BEF215F837096EA795E (XmlUnspecifiedAttribute_t1C82B285B60096D164B703202A8BD91A2009DE5D * __this, XmlNode_t07D70045D843753E4FE8AFE40FD36244E6B6D7FB * ___oldChild0, const RuntimeMethod* method)
{
	{
		XmlNode_t07D70045D843753E4FE8AFE40FD36244E6B6D7FB * L_0 = ___oldChild0;
		XmlNode_t07D70045D843753E4FE8AFE40FD36244E6B6D7FB * L_1 = XmlAttribute_RemoveChild_mFFCDFF1C5410F74FA8B7D9F18530C9C17D91470F(__this, L_0, /*hidden argument*/NULL);
		__this->set_fSpecified_3((bool)1);
		return L_1;
	}
}
// System.Xml.XmlNode System.Xml.XmlUnspecifiedAttribute::AppendChild(System.Xml.XmlNode)
extern "C" IL2CPP_METHOD_ATTR XmlNode_t07D70045D843753E4FE8AFE40FD36244E6B6D7FB * XmlUnspecifiedAttribute_AppendChild_m02BB99D25A5034CD4CF1823C30E53A0A3FB550FE (XmlUnspecifiedAttribute_t1C82B285B60096D164B703202A8BD91A2009DE5D * __this, XmlNode_t07D70045D843753E4FE8AFE40FD36244E6B6D7FB * ___newChild0, const RuntimeMethod* method)
{
	{
		XmlNode_t07D70045D843753E4FE8AFE40FD36244E6B6D7FB * L_0 = ___newChild0;
		XmlNode_t07D70045D843753E4FE8AFE40FD36244E6B6D7FB * L_1 = XmlAttribute_AppendChild_m7F17561A3054A0E2A4EDC19241EFD30DD5FA5D66(__this, L_0, /*hidden argument*/NULL);
		__this->set_fSpecified_3((bool)1);
		return L_1;
	}
}
// System.Void System.Xml.XmlUnspecifiedAttribute::SetSpecified(System.Boolean)
extern "C" IL2CPP_METHOD_ATTR void XmlUnspecifiedAttribute_SetSpecified_mE8F69E10D5E945D419793E3AE422166CF65F3C47 (XmlUnspecifiedAttribute_t1C82B285B60096D164B703202A8BD91A2009DE5D * __this, bool ___f0, const RuntimeMethod* method)
{
	{
		bool L_0 = ___f0;
		__this->set_fSpecified_3(L_0);
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
// System.Xml.XmlDownloadManager System.Xml.XmlUrlResolver::get_DownloadManager()
extern "C" IL2CPP_METHOD_ATTR XmlDownloadManager_tF864449330C09DCF4353B7F17EA226CE28C4D752 * XmlUrlResolver_get_DownloadManager_m420E0324A705EBAF4320453656ABAAC232A173C0 (const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (XmlUrlResolver_get_DownloadManager_m420E0324A705EBAF4320453656ABAAC232A173C0_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject * V_0 = NULL;
	{
		RuntimeObject * L_0 = ((XmlUrlResolver_t43FE24F4601B4197354EFB5783E5CB9F57997EC9_StaticFields*)il2cpp_codegen_static_fields_for(XmlUrlResolver_t43FE24F4601B4197354EFB5783E5CB9F57997EC9_il2cpp_TypeInfo_var))->get_s_DownloadManager_0();
		if (L_0)
		{
			goto IL_001a;
		}
	}
	{
		XmlDownloadManager_tF864449330C09DCF4353B7F17EA226CE28C4D752 * L_1 = (XmlDownloadManager_tF864449330C09DCF4353B7F17EA226CE28C4D752 *)il2cpp_codegen_object_new(XmlDownloadManager_tF864449330C09DCF4353B7F17EA226CE28C4D752_il2cpp_TypeInfo_var);
		XmlDownloadManager__ctor_mF13307004D49134611C0246153CEBF94E3844A27(L_1, /*hidden argument*/NULL);
		V_0 = L_1;
		RuntimeObject * L_2 = V_0;
		InterlockedCompareExchangeImpl<RuntimeObject *>((RuntimeObject **)(((XmlUrlResolver_t43FE24F4601B4197354EFB5783E5CB9F57997EC9_StaticFields*)il2cpp_codegen_static_fields_for(XmlUrlResolver_t43FE24F4601B4197354EFB5783E5CB9F57997EC9_il2cpp_TypeInfo_var))->get_address_of_s_DownloadManager_0()), L_2, NULL);
	}

IL_001a:
	{
		RuntimeObject * L_3 = ((XmlUrlResolver_t43FE24F4601B4197354EFB5783E5CB9F57997EC9_StaticFields*)il2cpp_codegen_static_fields_for(XmlUrlResolver_t43FE24F4601B4197354EFB5783E5CB9F57997EC9_il2cpp_TypeInfo_var))->get_s_DownloadManager_0();
		return ((XmlDownloadManager_tF864449330C09DCF4353B7F17EA226CE28C4D752 *)CastclassClass((RuntimeObject*)L_3, XmlDownloadManager_tF864449330C09DCF4353B7F17EA226CE28C4D752_il2cpp_TypeInfo_var));
	}
}
// System.Void System.Xml.XmlUrlResolver::.ctor()
extern "C" IL2CPP_METHOD_ATTR void XmlUrlResolver__ctor_m60DC644B9275BBA4308DCDE17E8378F39739640B (XmlUrlResolver_t43FE24F4601B4197354EFB5783E5CB9F57997EC9 * __this, const RuntimeMethod* method)
{
	{
		XmlResolver__ctor_m13C03FD7D7D57C97976BBCB547B9E2C3C09C408A(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Object System.Xml.XmlUrlResolver::GetEntity(System.Uri,System.String,System.Type)
extern "C" IL2CPP_METHOD_ATTR RuntimeObject * XmlUrlResolver_GetEntity_m48F7349856F393B8FF6990C85993D607989E8663 (XmlUrlResolver_t43FE24F4601B4197354EFB5783E5CB9F57997EC9 * __this, Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E * ___absoluteUri0, String_t* ___role1, Type_t * ___ofObjectToReturn2, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (XmlUrlResolver_GetEntity_m48F7349856F393B8FF6990C85993D607989E8663_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		Type_t * L_0 = ___ofObjectToReturn2;
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		bool L_1 = Type_op_Equality_m7040622C9E1037EFC73E1F0EDB1DD241282BE3D8(L_0, (Type_t *)NULL, /*hidden argument*/NULL);
		if (L_1)
		{
			goto IL_002d;
		}
	}
	{
		Type_t * L_2 = ___ofObjectToReturn2;
		RuntimeTypeHandle_t7B542280A22F0EC4EAC2061C29178845847A8B2D  L_3 = { reinterpret_cast<intptr_t> (Stream_tFC50657DD5AAB87770987F9179D934A51D99D5E7_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_4 = Type_GetTypeFromHandle_m9DC58ADF0512987012A8A016FB64B068F3B1AFF6(L_3, /*hidden argument*/NULL);
		bool L_5 = Type_op_Equality_m7040622C9E1037EFC73E1F0EDB1DD241282BE3D8(L_2, L_4, /*hidden argument*/NULL);
		if (L_5)
		{
			goto IL_002d;
		}
	}
	{
		Type_t * L_6 = ___ofObjectToReturn2;
		RuntimeTypeHandle_t7B542280A22F0EC4EAC2061C29178845847A8B2D  L_7 = { reinterpret_cast<intptr_t> (RuntimeObject_0_0_0_var) };
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_8 = Type_GetTypeFromHandle_m9DC58ADF0512987012A8A016FB64B068F3B1AFF6(L_7, /*hidden argument*/NULL);
		bool L_9 = Type_op_Equality_m7040622C9E1037EFC73E1F0EDB1DD241282BE3D8(L_6, L_8, /*hidden argument*/NULL);
		if (!L_9)
		{
			goto IL_004b;
		}
	}

IL_002d:
	{
		XmlDownloadManager_tF864449330C09DCF4353B7F17EA226CE28C4D752 * L_10 = XmlUrlResolver_get_DownloadManager_m420E0324A705EBAF4320453656ABAAC232A173C0(/*hidden argument*/NULL);
		Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E * L_11 = ___absoluteUri0;
		RuntimeObject* L_12 = __this->get__credentials_1();
		RuntimeObject* L_13 = __this->get__proxy_2();
		RequestCachePolicy_t30D7352C7E9D49EEADD492A70EC92C118D90CD61 * L_14 = __this->get__cachePolicy_3();
		NullCheck(L_10);
		Stream_tFC50657DD5AAB87770987F9179D934A51D99D5E7 * L_15 = XmlDownloadManager_GetStream_mD7A14E8675B8CAE8AC4AF96D53CD430024A60525(L_10, L_11, L_12, L_13, L_14, /*hidden argument*/NULL);
		return L_15;
	}

IL_004b:
	{
		String_t* L_16 = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
		XmlException_tD7DA2CBE07488D18EE7A284862B7523E3CD4365D * L_17 = (XmlException_tD7DA2CBE07488D18EE7A284862B7523E3CD4365D *)il2cpp_codegen_object_new(XmlException_tD7DA2CBE07488D18EE7A284862B7523E3CD4365D_il2cpp_TypeInfo_var);
		XmlException__ctor_mD27C8593D4F5978D5B419DA73EB60B23D80CC9E4(L_17, _stringLiteral4599D801351B053589C8FB8B5E3D7A2604B79DE2, L_16, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_17, NULL, XmlUrlResolver_GetEntity_m48F7349856F393B8FF6990C85993D607989E8663_RuntimeMethod_var);
	}
}
// System.Uri System.Xml.XmlUrlResolver::ResolveUri(System.Uri,System.String)
extern "C" IL2CPP_METHOD_ATTR Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E * XmlUrlResolver_ResolveUri_mFF7AFFD6F0955BCE93E7355DCDAB57F7F8A146D3 (XmlUrlResolver_t43FE24F4601B4197354EFB5783E5CB9F57997EC9 * __this, Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E * ___baseUri0, String_t* ___relativeUri1, const RuntimeMethod* method)
{
	{
		Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E * L_0 = ___baseUri0;
		String_t* L_1 = ___relativeUri1;
		Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E * L_2 = XmlResolver_ResolveUri_m3B74CC7D9ABBEDBE2CD281F44E614641917F4FEB(__this, L_0, L_1, /*hidden argument*/NULL);
		return L_2;
	}
}
// System.Threading.Tasks.Task`1<System.Object> System.Xml.XmlUrlResolver::GetEntityAsync(System.Uri,System.String,System.Type)
extern "C" IL2CPP_METHOD_ATTR Task_1_tA56001ED5270173CA1432EDFCD84EABB1024BC09 * XmlUrlResolver_GetEntityAsync_m95A9D45B7E41B78FD1784BB897FEC70567CB06E8 (XmlUrlResolver_t43FE24F4601B4197354EFB5783E5CB9F57997EC9 * __this, Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E * ___absoluteUri0, String_t* ___role1, Type_t * ___ofObjectToReturn2, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (XmlUrlResolver_GetEntityAsync_m95A9D45B7E41B78FD1784BB897FEC70567CB06E8_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	U3CGetEntityAsyncU3Ed__15_t383C4608618A66FB04F41F38C0534EE9E14CC934  V_0;
	memset(&V_0, 0, sizeof(V_0));
	AsyncTaskMethodBuilder_1_t2A9513A084F4B19851B91EF1F22BB57776D35663  V_1;
	memset(&V_1, 0, sizeof(V_1));
	{
		(&V_0)->set_U3CU3E4__this_4(__this);
		Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E * L_0 = ___absoluteUri0;
		(&V_0)->set_absoluteUri_3(L_0);
		Type_t * L_1 = ___ofObjectToReturn2;
		(&V_0)->set_ofObjectToReturn_2(L_1);
		IL2CPP_RUNTIME_CLASS_INIT(AsyncTaskMethodBuilder_1_t2A9513A084F4B19851B91EF1F22BB57776D35663_il2cpp_TypeInfo_var);
		AsyncTaskMethodBuilder_1_t2A9513A084F4B19851B91EF1F22BB57776D35663  L_2 = AsyncTaskMethodBuilder_1_Create_mC7806A5C115ED2239A5073313AA3564D8244156E(/*hidden argument*/AsyncTaskMethodBuilder_1_Create_mC7806A5C115ED2239A5073313AA3564D8244156E_RuntimeMethod_var);
		(&V_0)->set_U3CU3Et__builder_1(L_2);
		(&V_0)->set_U3CU3E1__state_0((-1));
		U3CGetEntityAsyncU3Ed__15_t383C4608618A66FB04F41F38C0534EE9E14CC934  L_3 = V_0;
		AsyncTaskMethodBuilder_1_t2A9513A084F4B19851B91EF1F22BB57776D35663  L_4 = L_3.get_U3CU3Et__builder_1();
		V_1 = L_4;
		AsyncTaskMethodBuilder_1_Start_TisU3CGetEntityAsyncU3Ed__15_t383C4608618A66FB04F41F38C0534EE9E14CC934_mF03E454780149AFBE6F88C60A4283797936195AD((AsyncTaskMethodBuilder_1_t2A9513A084F4B19851B91EF1F22BB57776D35663 *)(&V_1), (U3CGetEntityAsyncU3Ed__15_t383C4608618A66FB04F41F38C0534EE9E14CC934 *)(&V_0), /*hidden argument*/AsyncTaskMethodBuilder_1_Start_TisU3CGetEntityAsyncU3Ed__15_t383C4608618A66FB04F41F38C0534EE9E14CC934_mF03E454780149AFBE6F88C60A4283797936195AD_RuntimeMethod_var);
		AsyncTaskMethodBuilder_1_t2A9513A084F4B19851B91EF1F22BB57776D35663 * L_5 = (&V_0)->get_address_of_U3CU3Et__builder_1();
		Task_1_tA56001ED5270173CA1432EDFCD84EABB1024BC09 * L_6 = AsyncTaskMethodBuilder_1_get_Task_m19C5664D70C4FC799BEFB8D0FC98E687F97059FA((AsyncTaskMethodBuilder_1_t2A9513A084F4B19851B91EF1F22BB57776D35663 *)L_5, /*hidden argument*/AsyncTaskMethodBuilder_1_get_Task_m19C5664D70C4FC799BEFB8D0FC98E687F97059FA_RuntimeMethod_var);
		return L_6;
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
// System.Void System.Xml.XmlUrlResolver_<GetEntityAsync>d__15::MoveNext()
extern "C" IL2CPP_METHOD_ATTR void U3CGetEntityAsyncU3Ed__15_MoveNext_m025A24D8C9AF0CAE7D6470F3BE1FD32F71BD1966 (U3CGetEntityAsyncU3Ed__15_t383C4608618A66FB04F41F38C0534EE9E14CC934 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (U3CGetEntityAsyncU3Ed__15_MoveNext_m025A24D8C9AF0CAE7D6470F3BE1FD32F71BD1966_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	XmlUrlResolver_t43FE24F4601B4197354EFB5783E5CB9F57997EC9 * V_1 = NULL;
	RuntimeObject * V_2 = NULL;
	ConfiguredTaskAwaiter_t27ECAA4B74502BD3AC7E68F47088D46DAA13D133  V_3;
	memset(&V_3, 0, sizeof(V_3));
	ConfiguredTaskAwaitable_1_t8F8087337FA5C6475CA153C95469983DDDED9F48  V_4;
	memset(&V_4, 0, sizeof(V_4));
	Exception_t * V_5 = NULL;
	Exception_t * __last_unhandled_exception = 0;
	NO_UNUSED_WARNING (__last_unhandled_exception);
	Exception_t * __exception_local = 0;
	NO_UNUSED_WARNING (__exception_local);
	int32_t __leave_target = -1;
	NO_UNUSED_WARNING (__leave_target);
	{
		int32_t L_0 = __this->get_U3CU3E1__state_0();
		V_0 = L_0;
		XmlUrlResolver_t43FE24F4601B4197354EFB5783E5CB9F57997EC9 * L_1 = __this->get_U3CU3E4__this_4();
		V_1 = L_1;
	}

IL_000e:
	try
	{ // begin try (depth: 1)
		{
			int32_t L_2 = V_0;
			if (!L_2)
			{
				goto IL_00ae;
			}
		}

IL_0014:
		{
			Type_t * L_3 = __this->get_ofObjectToReturn_2();
			IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
			bool L_4 = Type_op_Equality_m7040622C9E1037EFC73E1F0EDB1DD241282BE3D8(L_3, (Type_t *)NULL, /*hidden argument*/NULL);
			if (L_4)
			{
				goto IL_0053;
			}
		}

IL_0022:
		{
			Type_t * L_5 = __this->get_ofObjectToReturn_2();
			RuntimeTypeHandle_t7B542280A22F0EC4EAC2061C29178845847A8B2D  L_6 = { reinterpret_cast<intptr_t> (Stream_tFC50657DD5AAB87770987F9179D934A51D99D5E7_0_0_0_var) };
			IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
			Type_t * L_7 = Type_GetTypeFromHandle_m9DC58ADF0512987012A8A016FB64B068F3B1AFF6(L_6, /*hidden argument*/NULL);
			bool L_8 = Type_op_Equality_m7040622C9E1037EFC73E1F0EDB1DD241282BE3D8(L_5, L_7, /*hidden argument*/NULL);
			if (L_8)
			{
				goto IL_0053;
			}
		}

IL_0039:
		{
			Type_t * L_9 = __this->get_ofObjectToReturn_2();
			RuntimeTypeHandle_t7B542280A22F0EC4EAC2061C29178845847A8B2D  L_10 = { reinterpret_cast<intptr_t> (RuntimeObject_0_0_0_var) };
			IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
			Type_t * L_11 = Type_GetTypeFromHandle_m9DC58ADF0512987012A8A016FB64B068F3B1AFF6(L_10, /*hidden argument*/NULL);
			bool L_12 = Type_op_Equality_m7040622C9E1037EFC73E1F0EDB1DD241282BE3D8(L_9, L_11, /*hidden argument*/NULL);
			if (!L_12)
			{
				goto IL_00d4;
			}
		}

IL_0053:
		{
			XmlDownloadManager_tF864449330C09DCF4353B7F17EA226CE28C4D752 * L_13 = XmlUrlResolver_get_DownloadManager_m420E0324A705EBAF4320453656ABAAC232A173C0(/*hidden argument*/NULL);
			Uri_t87E4A94B2901F5EEDD18AA72C3DB1B00E672D68E * L_14 = __this->get_absoluteUri_3();
			XmlUrlResolver_t43FE24F4601B4197354EFB5783E5CB9F57997EC9 * L_15 = V_1;
			NullCheck(L_15);
			RuntimeObject* L_16 = L_15->get__credentials_1();
			XmlUrlResolver_t43FE24F4601B4197354EFB5783E5CB9F57997EC9 * L_17 = V_1;
			NullCheck(L_17);
			RuntimeObject* L_18 = L_17->get__proxy_2();
			XmlUrlResolver_t43FE24F4601B4197354EFB5783E5CB9F57997EC9 * L_19 = V_1;
			NullCheck(L_19);
			RequestCachePolicy_t30D7352C7E9D49EEADD492A70EC92C118D90CD61 * L_20 = L_19->get__cachePolicy_3();
			NullCheck(L_13);
			Task_1_tAA7557E5A6A8B2C89E44907CB5B0502A618E9D01 * L_21 = XmlDownloadManager_GetStreamAsync_m39DCD22D4B46A17B36D223C5BB8C818B40D4856A(L_13, L_14, L_16, L_18, L_20, /*hidden argument*/NULL);
			NullCheck(L_21);
			ConfiguredTaskAwaitable_1_t8F8087337FA5C6475CA153C95469983DDDED9F48  L_22 = Task_1_ConfigureAwait_m190880408777F02426C980806C63032BEC154505(L_21, (bool)0, /*hidden argument*/Task_1_ConfigureAwait_m190880408777F02426C980806C63032BEC154505_RuntimeMethod_var);
			V_4 = L_22;
			ConfiguredTaskAwaiter_t27ECAA4B74502BD3AC7E68F47088D46DAA13D133  L_23 = ConfiguredTaskAwaitable_1_GetAwaiter_m7A0F2D7CFD71CFFC2586B93E3A1FAD30221784BC((ConfiguredTaskAwaitable_1_t8F8087337FA5C6475CA153C95469983DDDED9F48 *)(&V_4), /*hidden argument*/ConfiguredTaskAwaitable_1_GetAwaiter_m7A0F2D7CFD71CFFC2586B93E3A1FAD30221784BC_RuntimeMethod_var);
			V_3 = L_23;
			bool L_24 = ConfiguredTaskAwaiter_get_IsCompleted_m0720F20A96AD14393558BEB67540D8545A45FABF((ConfiguredTaskAwaiter_t27ECAA4B74502BD3AC7E68F47088D46DAA13D133 *)(&V_3), /*hidden argument*/ConfiguredTaskAwaiter_get_IsCompleted_m0720F20A96AD14393558BEB67540D8545A45FABF_RuntimeMethod_var);
			if (L_24)
			{
				goto IL_00ca;
			}
		}

IL_008e:
		{
			int32_t L_25 = 0;
			V_0 = L_25;
			__this->set_U3CU3E1__state_0(L_25);
			ConfiguredTaskAwaiter_t27ECAA4B74502BD3AC7E68F47088D46DAA13D133  L_26 = V_3;
			__this->set_U3CU3Eu__1_5(L_26);
			AsyncTaskMethodBuilder_1_t2A9513A084F4B19851B91EF1F22BB57776D35663 * L_27 = __this->get_address_of_U3CU3Et__builder_1();
			AsyncTaskMethodBuilder_1_AwaitUnsafeOnCompleted_TisConfiguredTaskAwaiter_t27ECAA4B74502BD3AC7E68F47088D46DAA13D133_TisU3CGetEntityAsyncU3Ed__15_t383C4608618A66FB04F41F38C0534EE9E14CC934_m2ADCCD4826BB678962D141602B12B2B0F69CC672((AsyncTaskMethodBuilder_1_t2A9513A084F4B19851B91EF1F22BB57776D35663 *)L_27, (ConfiguredTaskAwaiter_t27ECAA4B74502BD3AC7E68F47088D46DAA13D133 *)(&V_3), (U3CGetEntityAsyncU3Ed__15_t383C4608618A66FB04F41F38C0534EE9E14CC934 *)__this, /*hidden argument*/AsyncTaskMethodBuilder_1_AwaitUnsafeOnCompleted_TisConfiguredTaskAwaiter_t27ECAA4B74502BD3AC7E68F47088D46DAA13D133_TisU3CGetEntityAsyncU3Ed__15_t383C4608618A66FB04F41F38C0534EE9E14CC934_m2ADCCD4826BB678962D141602B12B2B0F69CC672_RuntimeMethod_var);
			goto IL_0111;
		}

IL_00ae:
		{
			ConfiguredTaskAwaiter_t27ECAA4B74502BD3AC7E68F47088D46DAA13D133  L_28 = __this->get_U3CU3Eu__1_5();
			V_3 = L_28;
			ConfiguredTaskAwaiter_t27ECAA4B74502BD3AC7E68F47088D46DAA13D133 * L_29 = __this->get_address_of_U3CU3Eu__1_5();
			il2cpp_codegen_initobj(L_29, sizeof(ConfiguredTaskAwaiter_t27ECAA4B74502BD3AC7E68F47088D46DAA13D133 ));
			int32_t L_30 = (-1);
			V_0 = L_30;
			__this->set_U3CU3E1__state_0(L_30);
		}

IL_00ca:
		{
			Stream_tFC50657DD5AAB87770987F9179D934A51D99D5E7 * L_31 = ConfiguredTaskAwaiter_GetResult_m4F8B73FFFC823973FDD6AD1386EE0D8B7CEDF8ED((ConfiguredTaskAwaiter_t27ECAA4B74502BD3AC7E68F47088D46DAA13D133 *)(&V_3), /*hidden argument*/ConfiguredTaskAwaiter_GetResult_m4F8B73FFFC823973FDD6AD1386EE0D8B7CEDF8ED_RuntimeMethod_var);
			V_2 = L_31;
			goto IL_00fd;
		}

IL_00d4:
		{
			String_t* L_32 = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_5();
			XmlException_tD7DA2CBE07488D18EE7A284862B7523E3CD4365D * L_33 = (XmlException_tD7DA2CBE07488D18EE7A284862B7523E3CD4365D *)il2cpp_codegen_object_new(XmlException_tD7DA2CBE07488D18EE7A284862B7523E3CD4365D_il2cpp_TypeInfo_var);
			XmlException__ctor_mD27C8593D4F5978D5B419DA73EB60B23D80CC9E4(L_33, _stringLiteral4599D801351B053589C8FB8B5E3D7A2604B79DE2, L_32, /*hidden argument*/NULL);
			IL2CPP_RAISE_MANAGED_EXCEPTION(L_33, NULL, U3CGetEntityAsyncU3Ed__15_MoveNext_m025A24D8C9AF0CAE7D6470F3BE1FD32F71BD1966_RuntimeMethod_var);
		}
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		__exception_local = (Exception_t *)e.ex;
		if(il2cpp_codegen_class_is_assignable_from (Exception_t_il2cpp_TypeInfo_var, il2cpp_codegen_object_class(e.ex)))
			goto CATCH_00e4;
		throw e;
	}

CATCH_00e4:
	{ // begin catch(System.Exception)
		V_5 = ((Exception_t *)__exception_local);
		__this->set_U3CU3E1__state_0(((int32_t)-2));
		AsyncTaskMethodBuilder_1_t2A9513A084F4B19851B91EF1F22BB57776D35663 * L_34 = __this->get_address_of_U3CU3Et__builder_1();
		Exception_t * L_35 = V_5;
		AsyncTaskMethodBuilder_1_SetException_m4C0B5462ECCB520FACA3C90B353DF596DAAF586D((AsyncTaskMethodBuilder_1_t2A9513A084F4B19851B91EF1F22BB57776D35663 *)L_34, L_35, /*hidden argument*/AsyncTaskMethodBuilder_1_SetException_m4C0B5462ECCB520FACA3C90B353DF596DAAF586D_RuntimeMethod_var);
		goto IL_0111;
	} // end catch (depth: 1)

IL_00fd:
	{
		__this->set_U3CU3E1__state_0(((int32_t)-2));
		AsyncTaskMethodBuilder_1_t2A9513A084F4B19851B91EF1F22BB57776D35663 * L_36 = __this->get_address_of_U3CU3Et__builder_1();
		RuntimeObject * L_37 = V_2;
		AsyncTaskMethodBuilder_1_SetResult_mD7DA7A17DC0610B11A0AAA364C3CA51FEC1271DB((AsyncTaskMethodBuilder_1_t2A9513A084F4B19851B91EF1F22BB57776D35663 *)L_36, L_37, /*hidden argument*/AsyncTaskMethodBuilder_1_SetResult_mD7DA7A17DC0610B11A0AAA364C3CA51FEC1271DB_RuntimeMethod_var);
	}

IL_0111:
	{
		return;
	}
}
extern "C"  void U3CGetEntityAsyncU3Ed__15_MoveNext_m025A24D8C9AF0CAE7D6470F3BE1FD32F71BD1966_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	U3CGetEntityAsyncU3Ed__15_t383C4608618A66FB04F41F38C0534EE9E14CC934 * _thisAdjusted = reinterpret_cast<U3CGetEntityAsyncU3Ed__15_t383C4608618A66FB04F41F38C0534EE9E14CC934 *>(__this + 1);
	U3CGetEntityAsyncU3Ed__15_MoveNext_m025A24D8C9AF0CAE7D6470F3BE1FD32F71BD1966(_thisAdjusted, method);
}
// System.Void System.Xml.XmlUrlResolver_<GetEntityAsync>d__15::SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine)
extern "C" IL2CPP_METHOD_ATTR void U3CGetEntityAsyncU3Ed__15_SetStateMachine_m102A8E0E12BF7F318C7880C850455EF3AF4B8D0B (U3CGetEntityAsyncU3Ed__15_t383C4608618A66FB04F41F38C0534EE9E14CC934 * __this, RuntimeObject* ___stateMachine0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (U3CGetEntityAsyncU3Ed__15_SetStateMachine_m102A8E0E12BF7F318C7880C850455EF3AF4B8D0B_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		AsyncTaskMethodBuilder_1_t2A9513A084F4B19851B91EF1F22BB57776D35663 * L_0 = __this->get_address_of_U3CU3Et__builder_1();
		RuntimeObject* L_1 = ___stateMachine0;
		AsyncTaskMethodBuilder_1_SetStateMachine_m5CC21A02320CF3D2DD7894A31123DFD82A428E4C((AsyncTaskMethodBuilder_1_t2A9513A084F4B19851B91EF1F22BB57776D35663 *)L_0, L_1, /*hidden argument*/AsyncTaskMethodBuilder_1_SetStateMachine_m5CC21A02320CF3D2DD7894A31123DFD82A428E4C_RuntimeMethod_var);
		return;
	}
}
extern "C"  void U3CGetEntityAsyncU3Ed__15_SetStateMachine_m102A8E0E12BF7F318C7880C850455EF3AF4B8D0B_AdjustorThunk (RuntimeObject * __this, RuntimeObject* ___stateMachine0, const RuntimeMethod* method)
{
	U3CGetEntityAsyncU3Ed__15_t383C4608618A66FB04F41F38C0534EE9E14CC934 * _thisAdjusted = reinterpret_cast<U3CGetEntityAsyncU3Ed__15_t383C4608618A66FB04F41F38C0534EE9E14CC934 *>(__this + 1);
	U3CGetEntityAsyncU3Ed__15_SetStateMachine_m102A8E0E12BF7F318C7880C850455EF3AF4B8D0B(_thisAdjusted, ___stateMachine0, method);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void System.Xml.XmlWhitespace::.ctor(System.String,System.Xml.XmlDocument)
extern "C" IL2CPP_METHOD_ATTR void XmlWhitespace__ctor_m016512E3F1D4094C7B53F02D9799AF5303E34A64 (XmlWhitespace_tF5EA718743A148EBF7594ADF5A06B3224857AD4D * __this, String_t* ___strData0, XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97 * ___doc1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (XmlWhitespace__ctor_m016512E3F1D4094C7B53F02D9799AF5303E34A64_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		String_t* L_0 = ___strData0;
		XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97 * L_1 = ___doc1;
		XmlCharacterData__ctor_m1733B463DB83C45AE9F57D7DE42CA997087E78A6(__this, L_0, L_1, /*hidden argument*/NULL);
		XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97 * L_2 = ___doc1;
		NullCheck(L_2);
		bool L_3 = XmlDocument_get_IsLoading_m6121F2E25E1B39DA8A090585EC483D289F520F6A(L_2, /*hidden argument*/NULL);
		if (L_3)
		{
			goto IL_0029;
		}
	}
	{
		String_t* L_4 = ___strData0;
		bool L_5 = XmlCharacterData_CheckOnData_m256EB1478D4EE87B7FD97C54882AE684EA2DA474(__this, L_4, /*hidden argument*/NULL);
		if (L_5)
		{
			goto IL_0029;
		}
	}
	{
		String_t* L_6 = Res_GetString_m47B81D62E4B5E4C48C06BCC7995B9ED5218EE7A2(_stringLiteralB8C1626447FA8716F0689D3C8B247CF5BDA4ED6D, /*hidden argument*/NULL);
		ArgumentException_tEDCD16F20A09ECE461C3DA766C16EDA8864057D1 * L_7 = (ArgumentException_tEDCD16F20A09ECE461C3DA766C16EDA8864057D1 *)il2cpp_codegen_object_new(ArgumentException_tEDCD16F20A09ECE461C3DA766C16EDA8864057D1_il2cpp_TypeInfo_var);
		ArgumentException__ctor_m9A85EF7FEFEC21DDD525A67E831D77278E5165B7(L_7, L_6, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_7, NULL, XmlWhitespace__ctor_m016512E3F1D4094C7B53F02D9799AF5303E34A64_RuntimeMethod_var);
	}

IL_0029:
	{
		return;
	}
}
// System.String System.Xml.XmlWhitespace::get_Name()
extern "C" IL2CPP_METHOD_ATTR String_t* XmlWhitespace_get_Name_m22021E848A3448DA0CDD27A78D7465AB082415F9 (XmlWhitespace_tF5EA718743A148EBF7594ADF5A06B3224857AD4D * __this, const RuntimeMethod* method)
{
	{
		XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97 * L_0 = VirtFuncInvoker0< XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97 * >::Invoke(14 /* System.Xml.XmlDocument System.Xml.XmlNode::get_OwnerDocument() */, __this);
		NullCheck(L_0);
		String_t* L_1 = L_0->get_strNonSignificantWhitespaceName_33();
		return L_1;
	}
}
// System.String System.Xml.XmlWhitespace::get_LocalName()
extern "C" IL2CPP_METHOD_ATTR String_t* XmlWhitespace_get_LocalName_mD23683B158041C22DB151381AA6FB0EE45BEBB9E (XmlWhitespace_tF5EA718743A148EBF7594ADF5A06B3224857AD4D * __this, const RuntimeMethod* method)
{
	{
		XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97 * L_0 = VirtFuncInvoker0< XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97 * >::Invoke(14 /* System.Xml.XmlDocument System.Xml.XmlNode::get_OwnerDocument() */, __this);
		NullCheck(L_0);
		String_t* L_1 = L_0->get_strNonSignificantWhitespaceName_33();
		return L_1;
	}
}
// System.Xml.XmlNodeType System.Xml.XmlWhitespace::get_NodeType()
extern "C" IL2CPP_METHOD_ATTR int32_t XmlWhitespace_get_NodeType_m37154979E28465979B6E8191DD318A3C0A9A10F9 (XmlWhitespace_tF5EA718743A148EBF7594ADF5A06B3224857AD4D * __this, const RuntimeMethod* method)
{
	{
		return (int32_t)(((int32_t)13));
	}
}
// System.Xml.XmlNode System.Xml.XmlWhitespace::get_ParentNode()
extern "C" IL2CPP_METHOD_ATTR XmlNode_t07D70045D843753E4FE8AFE40FD36244E6B6D7FB * XmlWhitespace_get_ParentNode_mD94B65792F1C17FCACAC27C4465A90C1F3E24A36 (XmlWhitespace_tF5EA718743A148EBF7594ADF5A06B3224857AD4D * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	XmlNode_t07D70045D843753E4FE8AFE40FD36244E6B6D7FB * V_1 = NULL;
	{
		XmlNode_t07D70045D843753E4FE8AFE40FD36244E6B6D7FB * L_0 = ((XmlNode_t07D70045D843753E4FE8AFE40FD36244E6B6D7FB *)__this)->get_parentNode_0();
		NullCheck(L_0);
		int32_t L_1 = VirtFuncInvoker0< int32_t >::Invoke(8 /* System.Xml.XmlNodeType System.Xml.XmlNode::get_NodeType() */, L_0);
		V_0 = L_1;
		int32_t L_2 = V_0;
		if ((!(((uint32_t)((int32_t)il2cpp_codegen_subtract((int32_t)L_2, (int32_t)3))) > ((uint32_t)1))))
		{
			goto IL_0027;
		}
	}
	{
		int32_t L_3 = V_0;
		if ((((int32_t)L_3) == ((int32_t)((int32_t)9))))
		{
			goto IL_0020;
		}
	}
	{
		int32_t L_4 = V_0;
		if ((!(((uint32_t)((int32_t)il2cpp_codegen_subtract((int32_t)L_4, (int32_t)((int32_t)13)))) > ((uint32_t)1))))
		{
			goto IL_0027;
		}
	}
	{
		goto IL_0046;
	}

IL_0020:
	{
		XmlNode_t07D70045D843753E4FE8AFE40FD36244E6B6D7FB * L_5 = XmlNode_get_ParentNode_m6AC4A7F4FEE5B469A86490C129F011C12201C3E6(__this, /*hidden argument*/NULL);
		return L_5;
	}

IL_0027:
	{
		XmlNode_t07D70045D843753E4FE8AFE40FD36244E6B6D7FB * L_6 = ((XmlNode_t07D70045D843753E4FE8AFE40FD36244E6B6D7FB *)__this)->get_parentNode_0();
		NullCheck(L_6);
		XmlNode_t07D70045D843753E4FE8AFE40FD36244E6B6D7FB * L_7 = L_6->get_parentNode_0();
		V_1 = L_7;
		goto IL_003c;
	}

IL_0035:
	{
		XmlNode_t07D70045D843753E4FE8AFE40FD36244E6B6D7FB * L_8 = V_1;
		NullCheck(L_8);
		XmlNode_t07D70045D843753E4FE8AFE40FD36244E6B6D7FB * L_9 = L_8->get_parentNode_0();
		V_1 = L_9;
	}

IL_003c:
	{
		XmlNode_t07D70045D843753E4FE8AFE40FD36244E6B6D7FB * L_10 = V_1;
		NullCheck(L_10);
		bool L_11 = VirtFuncInvoker0< bool >::Invoke(42 /* System.Boolean System.Xml.XmlNode::get_IsText() */, L_10);
		if (L_11)
		{
			goto IL_0035;
		}
	}
	{
		XmlNode_t07D70045D843753E4FE8AFE40FD36244E6B6D7FB * L_12 = V_1;
		return L_12;
	}

IL_0046:
	{
		XmlNode_t07D70045D843753E4FE8AFE40FD36244E6B6D7FB * L_13 = ((XmlNode_t07D70045D843753E4FE8AFE40FD36244E6B6D7FB *)__this)->get_parentNode_0();
		return L_13;
	}
}
// System.String System.Xml.XmlWhitespace::get_Value()
extern "C" IL2CPP_METHOD_ATTR String_t* XmlWhitespace_get_Value_m5AF3D1513F247582D7EB8102C67085C64C57B5F0 (XmlWhitespace_tF5EA718743A148EBF7594ADF5A06B3224857AD4D * __this, const RuntimeMethod* method)
{
	{
		String_t* L_0 = VirtFuncInvoker0< String_t* >::Invoke(43 /* System.String System.Xml.XmlCharacterData::get_Data() */, __this);
		return L_0;
	}
}
// System.Xml.XmlNode System.Xml.XmlWhitespace::CloneNode(System.Boolean)
extern "C" IL2CPP_METHOD_ATTR XmlNode_t07D70045D843753E4FE8AFE40FD36244E6B6D7FB * XmlWhitespace_CloneNode_m3C22A8D29CB9546529DAB5193C06E51A5E02E35C (XmlWhitespace_tF5EA718743A148EBF7594ADF5A06B3224857AD4D * __this, bool ___deep0, const RuntimeMethod* method)
{
	{
		XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97 * L_0 = VirtFuncInvoker0< XmlDocument_t448325D04430147AF19F2955BD6A5F1551003C97 * >::Invoke(14 /* System.Xml.XmlDocument System.Xml.XmlNode::get_OwnerDocument() */, __this);
		String_t* L_1 = VirtFuncInvoker0< String_t* >::Invoke(43 /* System.String System.Xml.XmlCharacterData::get_Data() */, __this);
		NullCheck(L_0);
		XmlWhitespace_tF5EA718743A148EBF7594ADF5A06B3224857AD4D * L_2 = VirtFuncInvoker1< XmlWhitespace_tF5EA718743A148EBF7594ADF5A06B3224857AD4D *, String_t* >::Invoke(54 /* System.Xml.XmlWhitespace System.Xml.XmlDocument::CreateWhitespace(System.String) */, L_0, L_1);
		return L_2;
	}
}
// System.Boolean System.Xml.XmlWhitespace::get_IsText()
extern "C" IL2CPP_METHOD_ATTR bool XmlWhitespace_get_IsText_mE65776DE3C055807C4D18A331496945D8F36AB9A (XmlWhitespace_tF5EA718743A148EBF7594ADF5A06B3224857AD4D * __this, const RuntimeMethod* method)
{
	{
		return (bool)1;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
