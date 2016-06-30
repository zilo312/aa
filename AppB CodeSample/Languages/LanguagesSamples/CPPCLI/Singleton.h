#pragma once



namespace Wrox
{
	namespace ProCSharp
	{

public ref class SomeData
{
};

public ref class Singleton
{
private: 
	static SomeData^ hData;

public:
	static SomeData^ GetData()
	{
		if (hData == nullptr)
		{
			hData = gcnew SomeData();
		}
		return hData;
	}
};
	}
}
