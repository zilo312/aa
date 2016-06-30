#pragma once

using namespace System;

ref class ExceptionTest
{
public:

	    void ThrowMethod()
        {
			throw gcnew ArgumentException("error");
        }

        void Handler()
        {
            try
            {
                ThrowMethod();
            }
            catch (ArgumentException^ ex)
            {
				Console::WriteLine(ex->Message);
            }
            catch (Exception^ ex)
            {
				Console::WriteLine(ex->Message);
            }
            finally
            {
				Console::WriteLine("Finally");
            }
        }
};
