#pragma once

public ref class Base abstract
{
public:

	virtual void Foo1()
	{
	}

	virtual void Bar() abstract;

};

public ref class Derived : public Base
{
public:
	virtual void Foo1() override
	{
		Base::Foo1();
	}
	virtual void Bar() override
	{
	}
};
