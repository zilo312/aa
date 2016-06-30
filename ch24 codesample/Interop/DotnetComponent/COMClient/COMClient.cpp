// COMClient.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#import "../DotNetComponent/bin/debug/DotnetComponent.tlb" named_guids

using namespace std;
using namespace DotnetComponent;

CComModule _Module;

const UINT IDSRC = 42;


class CEventHandler : public IDispEventImpl<IDSRC, CEventHandler, &DIID_IMathEvents, &LIBID_DotnetComponent, 2, 0>
{
public:
	BEGIN_SINK_MAP(CEventHandler)
		SINK_ENTRY_EX(IDSRC, DIID_IMathEvents, 0x1, OnCalcCompleted)
	END_SINK_MAP()

	HRESULT __stdcall OnCalcCompleted()
	{
		ATLTRACE("CEventHandler::OnCalcCompleted\n");
		cout << "calculation completed" << endl;
		return S_OK;
	}

};

//public class CEventHandler : IDispEventSimpleImpl<id, CEventHandler, &DIID_IMathEvents>
//{
//	BEGIN_SINK_MAP(CEventHandler)
//		SINK_ENTRY_EX(3, DIID_IMathEvents, 60001, Completed)
//
//	END_SINK_MAP()
//};

int _tmain(int argc, _TCHAR* argv[])
{
	HRESULT hr;
	hr = CoInitialize(NULL);


	// _Module.Init(null, hInstance);

	try
	{
		IWelcomePtr spWelcome;
		hr = spWelcome.CreateInstance("Wrox.DotnetComponent");   // CoCreateInstance()

		IUnknownPtr spUnknown = spWelcome;


		cout << spWelcome->Greeting("Isabella") << endl;

		CEventHandler* eventHandler = new CEventHandler();
		hr = eventHandler->DispEventAdvise(spUnknown);
		

		IMathPtr spMath;
		spMath = spWelcome;   // QueryInterface()

		long result = spMath->Add(4, 5);
		cout << "result:" << result << endl; 

		eventHandler->DispEventUnadvise(spWelcome.GetInterfacePtr());
		delete eventHandler;
	}
	catch (_com_error& e)
	{
		cout << e.ErrorMessage() << endl;
	}

	CoUninitialize();
	return 0;
}

