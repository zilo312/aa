#pragma once
using namespace System::Collections::Generic;

ref class GenericsDemo
{
public:
	static void UseGenerics()
	{
		List<int>^ intList = gcnew List<int>();
		intList->Add(1);
		intList->Add(2);
		intList->Add(3);
	}
};

generic <typename T>
where T : IComparable<T>
ref class MyGeneric
{
private:
	List<T>^ list;

public:
	MyGeneric()
	{
		list = gcnew List<T>();
	}

	void Add(T item)
	{
		list->Add(item);
	}

	void Sort()
	{
		list->Sort();
	}
};
