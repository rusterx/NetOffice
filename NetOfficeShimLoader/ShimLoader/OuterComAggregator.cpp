#include "stdafx.h"
#include "OuterComAggregator.h"

using namespace NetOffice_Tools_Isolation;

namespace NetOffice_ShimLoader
{
	/***************************************************************************
	* Ctor, Dtor
	***************************************************************************/

	OuterComAggregator::OuterComAggregator()
	{
		_refCounter = 0;
		IncComponents(L"OuterComAggregator");
	}

	OuterComAggregator::~OuterComAggregator()
	{
		if (_innerAddin)
		{
			delete _innerAddin;
			_innerAddin = nullptr;
		}
		DecComponents(L"OuterComAggregator");
	}


	/***************************************************************************
	* OuterComAggregator Methods
	***************************************************************************/

	ManagedAddin* OuterComAggregator::Addin()
	{
		return _innerAddin;
	}


	/***************************************************************************
	* IOuterComAggregator Implementation
	***************************************************************************/

	HRESULT __stdcall OuterComAggregator::SetInnerAddin(IUnknown* innerAddin)
	{
		if (innerAddin == NULL)
			return E_POINTER;
		if (_innerAddin != NULL)
			return E_UNEXPECTED;

		_innerAddin = new ManagedAddin(innerAddin);

		return S_OK;
	}


	/***************************************************************************
	* IUnknown Implementation
	***************************************************************************/

	STDMETHODIMP OuterComAggregator::QueryInterface(REFIID riid, void** ppv)
	{
		if (NULL == ppv)
			return E_POINTER;
		*ppv = NULL;

		HRESULT hr = E_FAIL;

		if ((IID_IUnknown == riid))
		{
			*ppv = static_cast<IUnknown*>(this);
			hr = S_OK;
		}
		else if ((IID_IOuterComAggregator == riid))
		{
			*ppv = static_cast<IOuterComAggregator*>(this);
			hr = S_OK;
		}
		else
			hr = E_NOINTERFACE;

		if (NULL != *ppv)
		{
			reinterpret_cast<IUnknown*>(*ppv)->AddRef();
		}

		return hr;
	}

	STDMETHODIMP_(ULONG) OuterComAggregator::AddRef(void)
	{
		return ++_refCounter;
	}

	STDMETHODIMP_(ULONG) OuterComAggregator::Release(void)
	{
		if (_refCounter > 0)
			_refCounter--;
		return _refCounter;
	}
}
