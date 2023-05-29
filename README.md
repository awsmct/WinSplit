# WinSplit
**Fast split text files on lines on Windows.**

# Requirements
For launch Microsoft .Net Core Runtime 3.1 required.

# Usage with autocounting:
Open command promt in folder with WinSplit.exe and write "winsplit.exe" with 5 space-separated arguments.
1. File name;
2. Count of output files;
3. Output file name;
4. Output file attribute.

**Example:**
InputFile.json on 25.000 lines

**winsplit.exe InputFile.json 5 output .json**

# Usage without autocounting:
Open command promt in folder with WinSplit.exe and write "winsplit.exe" with 5 space-separated arguments.
1. File name;
2. Lines in output files;
3. Count of output files;
4. Output file name;
5. Output file attribute.

**If lines count in output files * numbers of files < lines in source file, you will get part of lines.**

**Example:**
InputFile.json on 25.000 lines

**winsplit.exe InputFile.json 5000 5 output .json**

# Output:
1. output0.json
2. output1.json
3. output2.json
4. output3.json
5. output4.json
