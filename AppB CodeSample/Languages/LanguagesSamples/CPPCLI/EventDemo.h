#pragma once
#include "DelegateSample.h"

public ref class EventDemo
{
public:
	event DemoDelegate^ DemoEvent;

	void FireEvent()
	{
		DemoEvent(44);
	}
};

public ref class Subscriber
{
public:
	void Handler(int x)
	{
		Console::WriteLine("Handler {0}", x);
	}
};

