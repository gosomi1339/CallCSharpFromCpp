#include <iostream>

#include "..\02ClrWrapper\ClrWrapperDLL.h"
#include <string>

int main()
{
    {
        int result = ClrWrapper::SetIntValue(1);
        std::cout << "Result 1= " << result << std::endl;
    }

    {
        int x = 1;
        double result = ClrWrapper::SetObject(0, &x);
        std::cout << "Result 2= " << result << std::endl;
    }

    {
        double x = 1;
        double result = ClrWrapper::SetObject(1, &x);
        std::cout << "Result 3= " << result << std::endl;
    }

    {
        std::string x = "1";
        double result = ClrWrapper::SetObject(2, &x);
        std::cout << "Result 4= " << result << std::endl;
    }

}

