#include "MyForm.h"
#using <System.Windows.Forms.dll>
using namespace System;
using namespace System::Windows::Forms;
[STAThread]
void main(array<String^>^ args)
{
	Application::EnableVisualStyles();
	Application::SetCompatibleTextRenderingDefault(false);
	Elite::MyForm form;
	Application::Run(%form);
}