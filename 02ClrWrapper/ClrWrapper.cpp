#include "pch.h"

#include "ClrWrapper.h"

using namespace CSClassLibrary;

DllExport int ClrWrapper::SetIntValue(int x) {

	return Class1::SetIntValue(x);
}

DllExport double ClrWrapper::SetObject(int t, void* x) {

	return Class1::SetObject(t,x);
}
