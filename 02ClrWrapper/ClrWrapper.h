#pragma once

#define DllExport   __declspec( dllexport )

namespace ClrWrapper {
	DllExport int SetIntValue(int x);
	DllExport double SetObject(void* x);
}
