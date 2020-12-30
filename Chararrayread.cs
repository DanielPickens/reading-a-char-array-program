[DllImport("kernel32.dll", SetLastError = true)]
public static extern bool ReadProcessMemory(
    IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, Int32 nSize, out IntPtr lpNumberOfBytesRead);

var nameAddr = ghapi.FindDMAAddy(hProc, (IntPtr)(modBase2 + 0x10f4f4), new int[] { 0x225 });

byte[] name = new byte[16];

ghapi.ReadProcessMemory(hProc, nameAddr, name, 16, out _);

Console.WriteLine(Encoding.Default.GetString(name));
