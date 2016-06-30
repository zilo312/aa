// CPPCLI.cpp : main project file.

#include "stdafx.h"
#include "color.h"
#include "singleton.h"
#include "exceptiontest.h"
#include "inheritancedemo.h"
#include "delegatesample.h"
#include "eventdemo.h"
#include "genericsdemo.h"
#include "mixing.h"
#include "passingparameters.h"

using namespace System;
namespace Pro = Wrox::ProCSharp;
using namespace Pro;

public enum class Suit
{
	Heart, Diamond, Club, Spade
};

String^ GetColor(Suit s)
{
	
	String^ color = nullptr;
	switch (s)
	{
	case Suit::Heart:
	case Suit::Diamond:
		color = "Red";
		break;
	case Suit::Spade:
	case Suit::Club:
		color = "Black";
		break;
	default:
		color = "Unknown";
		break;
	}
	return color;
}

int main(array<System::String ^> ^args)
{
	int a = 1;
	PassingParameters pp;
	pp.ChangeVal(a);
	Console::WriteLine(a);

	GenericsDemo::UseGenerics();

	EventDemo^ evd = gcnew EventDemo();
	Subscriber^ subscr = gcnew Subscriber();
	evd->FireEvent();
	evd->DemoEvent += gcnew DemoDelegate(subscr, &Subscriber::Handler);
	evd->FireEvent();

	Demo^ demo = gcnew Demo();
	DemoDelegate^ d1 = gcnew DemoDelegate(demo, &Demo::Bar);
	d1(33);

	DemoDelegate^ d2 = gcnew DemoDelegate(&Demo::Foo);

	DemoDelegate^ d3 = d1 + d2;
	d3(44);

	Console::WriteLine(L"Hello World");
	bool b = true;
	unsigned int x = 33;

	array<int>^ arr1 = {1, 2, 3};
	for each (int i in arr1)
	{
		Console::WriteLine(i);
	}


	long l1 = 4;
	long long l2 = 3;
	unsigned long long l3 = 2;
	Console::WriteLine("{0} {1} {2}", l1, l2, l3);

	char s = 'c';
	Console::WriteLine(s);

	array<int>^ arr = gcnew array<int>(3) {1, 2, 3};
	array<int>^ arr2 = {1, 2, 3};


	Suit st = Suit::Club;
	String^ color = GetColor(st);


	return 0;
}


