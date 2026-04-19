#ifndef WIN32_LEAN_AND_MEAN
#define WIN32_LEAN_AND_MEAN
#endif
#ifdef _WIN32_WINNT
#undef _WIN32_WINNT
#endif
#define _WIN32_WINNT 0x0600 // Vista и выше

#include <windows.h>
#include <winsock2.h>
#include <ws2tcpip.h>
#include <iphlpapi.h>
#include <netioapi.h> // The actual home of GetIpForwardEntry2
#include <stdio.h>

int main()
{
	GetIpForwardEntry2(NULL);
	return 0;
}