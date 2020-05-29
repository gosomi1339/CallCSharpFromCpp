#pragma once

#define DllImport   __declspec( dllimport )

namespace ClrWrapper {

	DllImport int SetIntValue(int x);
	DllImport double SetObject(int t, void* x);

}