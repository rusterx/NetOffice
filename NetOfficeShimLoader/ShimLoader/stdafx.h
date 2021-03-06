#pragma once

#define WIN32_LEAN_AND_MEAN


#include "targetver.h"
#include <windows.h>
#include <strsafe.h>
#include <shlobj_core.h>
#include <shlobj_core.h>
#include <tchar.h>
#include <mscoree.h>
#include <fstream>
#include "shlwapi.h"
#include "WriteLog.hpp"
#include "WriteRegisterLog.hpp"
#include "WriteUnRegisterLog.hpp"


//
// detect 64 bit windows TODO: move it to a special namespace to avoid specific utils in stdafx
//
typedef BOOL(WINAPI *LPFN_ISWOW64PROCESS) (HANDLE, PBOOL);
LPFN_ISWOW64PROCESS fnIsWow64Process;


//
// Import Type Libraries
//
#import <mscorlib.tlb> raw_interfaces_only high_property_prefixes("_get","_put","_putref")  rename("ReportEvent", "MsCorLib_ReportEvent")
#import <msxml6.dll> rename_namespace(_T("MSXML")) exclude("ISequentialStream", "_FILETIME")// need to have XML Core Services SDK installed for the lib but import .lib cause an open file error - i dont know why at the moment but need to fix it in order to have no additional dll depedencies in release build


//
// Macros
//
extern BOOL ENABLE_DEBUG_MESSAGE_BOX;
#define IfFalseGo(x) { if (FALSE == x) {hr = E_FAIL; goto Error;} }
#define IfZeroGo(x) { if (0 == x) {hr = E_FAIL; goto Error;} }
#define IfNotZeroGo(x) { if (0 != x) {hr = E_FAIL; goto Error;} }
//#define IfFalseGo(x) { b=(x); if (FALSE == b) {hr = E_FAIL; goto Error;} }
#define IfFailGo(x) { hr=(x); if (FAILED(hr)) goto Error; }
#define IfNullGo(p) { if(!p) {hr = E_FAIL; goto Error; } }
#define ShimDebugMessageBox(text, title){if(ENABLE_DEBUG_MESSAGE_BOX){MessageBox(GetDesktopWindow(), text, title, MB_OK);}}
#define DebugOutput(text){OutputDebugString(text);}
// TODO: this macro is not general, move it to ShimProxy
#define ValidateExtensibilityFail(x) { if(EXTENSIBILITY_FAIL_RESULT != E_NOTIMPL) x = EXTENSIBILITY_FAIL_RESULT; }
#define ConcatePath(x, y) { b = PathAppend(x,y);}
