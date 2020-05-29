#pragma once

#define DllImport   __declspec( dllimport )

namespace ClrWrapper {

	DllImport int SetIntValue(int x);
	DllImport double SetObject(void* x);

}