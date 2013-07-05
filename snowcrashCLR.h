// snowcrashCLR.h

#pragma once
#include "snowcrash\src\snowcrash.h"

using namespace System;

namespace snowcrashCLR {

	// TODO: Rename
	public ref class Class1
	{
		// TODO: Add your methods for this class here.

	public:

		// TODO: Rename & revisit
		static void test()
		{
			snowcrash::Result result;
			snowcrash::Blueprint blueprint;
			snowcrash::parse("# My API\n", 0, result, blueprint);
		}
	};
}
