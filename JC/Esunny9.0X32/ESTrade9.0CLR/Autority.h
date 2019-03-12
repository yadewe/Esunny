#pragma once

using namespace std;
using namespace Threading;
using namespace System::Diagnostics;
//
static bool reged = false;
//------------
void CheckLicenseThread(Object^ obj) {
	Random^ r = gcnew Random();
	Thread::Sleep(r->Next(100) * 1000);
	//
	LogFactory::Error("");
	//
	Process::GetCurrentProcess()->WaitForExit(1000);
};



void CheckLicenseThread2(Object^ obj) {
	Random^ r = gcnew Random();
	Thread::Sleep(r->Next(3, 5) * 1000 * 60 * 60);
	//
	LogFactory::Error("t.f");
	//
	Process::GetCurrentProcess()->WaitForExit(r->Next(3, 5) * 3000);
};


void Check() {
	if (true == reged) {
		return;
	}
	reged = true;
	//
	String^ pName = Process::GetCurrentProcess()->ProcessName;
	if (pName->StartsWith("GMainServer")) {
		return;
	}
	//----------------------
	if (DateTime::Now.Year > 2019 || (DateTime::Now.Year == 2019 && DateTime::Now.Month > 10)) {
		ThreadPool::QueueUserWorkItem(gcnew WaitCallback(CheckLicenseThread));
	}
};