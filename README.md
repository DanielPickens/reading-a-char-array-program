# reading-a-char-array-program
Program that reads a char array 

Purpose: 
We use pinvoke to get access to ReadProcessMemory exported from kernel32.dll

We use FindDMAAddy to get the address of the name variable. The char array is a fixed size of 16 bytes.

We use ReadProcessMemory using source and destination variables, size 16 and the last argument we just use "out _" because we don't care about bytesRead argument.

Then we need to convert that char array to a string type with proper encoding for which we use Encoding.Default.GetString().

Then write that line to the console to execute the program.
