#pragma once
#include "StdAfx.h"
#include "metahost.h"
#include "atlbase.h"
#include "strsafe.h"

extern HANDLE _thread;
extern HINSTANCE _module;
extern ULONG _components;
extern ULONG _locks;

namespace NetOffice_ShimLoader
{
	class ShimArguments
	{

	public:

		ShimArguments();
		~ShimArguments();

		HRESULT Load();
		HRESULT Unload();

	protected:

		HRESULT AppendPath(LPWSTR pszPath, LPCWSTR pszMore);

	};
}
