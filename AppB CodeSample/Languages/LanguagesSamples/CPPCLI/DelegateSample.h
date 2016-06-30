#pragma once

using namespace System;

public delegate void DemoDelegate(int x);

public ref class Demo
{
public:
	static void Foo(int x)
	{
		Console::WriteLine("Foo {0}", x);
	}

	void Bar(int x)
	{
		Console::WriteLine("Bar {0}", x);
	}

};

