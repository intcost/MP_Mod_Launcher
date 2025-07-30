using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace MPMODENEWLAUNCHER
{
	public static class GamePatcherMod
	{
		internal static void Patch()
		{
			using (Process process = new Process())
			{
				process.StartInfo.WorkingDirectory = "msco_crack\\bin\\Debug\\";
				process.StartInfo.FileName = "MSCO.exe";
				process.StartInfo.Arguments = "-force-d3d9";
				process.Start();
				process.WaitForInputIdle();
			}
		}

		internal static void InjectorLic()
		{
			using (Process process = new Process())
			{
				process.StartInfo.WorkingDirectory = "msco_crack\\bin\\Debug\\";
				process.StartInfo.FileName = "MSCO_Lic.exe";
				process.StartInfo.Arguments = "-force-d3d9";
				process.Start();
				process.WaitForInputIdle();
			}
		}

		internal static void Inject(this Process process, string dllPath)
		{
			IntPtr procAddress = GamePatcherMod.GetProcAddress(GamePatcherMod.GetModuleHandle("kernel32.dll"), "LoadLibraryA");
			if (procAddress == IntPtr.Zero)
			{
				Console.WriteLine("Failed to get the address of the LoadLibrary function. Error code: " + Marshal.GetLastWin32Error().ToString());
				return;
			}
			IntPtr intPtr = GamePatcherMod.VirtualAllocEx(process.Handle, IntPtr.Zero, (uint)(dllPath.Length + 1), 12288U, 4U);
			if (intPtr == IntPtr.Zero)
			{
				Console.WriteLine("Failed to allocate memory in the process. Error code: " + Marshal.GetLastWin32Error().ToString());
				return;
			}
			byte[] bytes = Encoding.ASCII.GetBytes(dllPath);
			UIntPtr uintPtr;
			if (!GamePatcherMod.WriteProcessMemory(process.Handle, intPtr, bytes, (uint)bytes.Length, out uintPtr))
			{
				Console.WriteLine("Failed to write to process memory. Error code: " + Marshal.GetLastWin32Error().ToString());
				return;
			}
			IntPtr intPtr2 = GamePatcherMod.CreateRemoteThread(process.Handle, IntPtr.Zero, 0U, procAddress, intPtr, 0U, IntPtr.Zero);
			if (intPtr2 == IntPtr.Zero)
			{
				Console.WriteLine("Failed to create remote thread. Error code: " + Marshal.GetLastWin32Error().ToString());
				return;
			}
			GamePatcherMod.WaitForSingleObject(intPtr2, uint.MaxValue);
			GamePatcherMod.VirtualFreeEx(process.Handle, intPtr, (uint)dllPath.Length, 32768U);
			GamePatcherMod.CloseHandle(intPtr2);
		}

		[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
		internal static extern IntPtr GetModuleHandle(string lpModuleName);

		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		internal static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		internal static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

		[DllImport("kernel32.dll", SetLastError = true)]
		internal static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out UIntPtr lpNumberOfBytesWritten);

		[DllImport("kernel32.dll")]
		internal static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		internal static extern bool VirtualFreeEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint dwFreeType);

		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern uint WaitForSingleObject(IntPtr hHandle, uint dwMilliseconds);

		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[SuppressUnmanagedCodeSecurity]
		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool CloseHandle(IntPtr hObject);

		internal const uint MEM_COMMIT = 4096U;

		internal const uint MEM_RESERVE = 8192U;

		internal const uint PAGE_READWRITE = 4U;

		internal const uint MEM_RELEASE = 32768U;
	}
}
