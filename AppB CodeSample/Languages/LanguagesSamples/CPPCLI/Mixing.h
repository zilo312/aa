#pragma once
#include <iostream>
#include "gcroot.h"

using namespace std;
using namespace System;

public class Native
{
public:
	void Mix()
	{
		cout << "Native Code" << endl;
		Console::WriteLine("Managed Code");
	}

	void Foo()
	{
	}
};

public ref class Managed
{
public:
	Managed()
	{
		m_p = new Native();
	}
private:
	Native* m_p;
public:
	void Mix()
	{
		cout << "Native Code" << endl;
		Console::WriteLine("Managed Code");
		m_p->Foo();
	}

};

public class Native2
{
private:
	// Managed^ m_p;
	gcroot<Managed^> m_p;

public:
	Native2()
	{
		m_p = gcnew Managed();
	}

	void Foo()
	{
		m_p->Mix();
	}
};
