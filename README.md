# WinSplit
 Fast split text files on lines on Windows.

Usage:
Open command promt in folder with WinSplit.exe and write "winsplit.exe" with 5 space-separated arguments.
1. File name;
2. Lines in output files;
3. Count of output files;
4. Output file name;
5. Output file attribute.

**If lines count in output files * numbers of files < lines in source file, you will get part of lines.**

# Example:
file.json on 25.000 lines

**winsplit.exe file.json 5000 5 output .json**

# Output:
output1.json
output2.json
output3.json
output4.json
output5.json
