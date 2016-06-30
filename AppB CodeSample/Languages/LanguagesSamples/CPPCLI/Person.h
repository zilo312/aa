#pragma once
using namespace System;

public interface class IDisplay
{
	void Display();
};

public ref class Person : public IDisplay
{
public:
	virtual void Display()
	{
	}

	Person()
	{
		Person("unknown", "unknown");
	}
	Person(String^ firstname, String^ lastname)
	{
		this->firstname = firstname;
		this->Lastname = lastname;
	}
	String^ firstname;

	property String^ Firstname
	{
		String^ get()
		{
			return firstname;
		}
		void set(String^ value)
		{
			firstname = value;
		}
	}

	property String^ Lastname;
	
};
