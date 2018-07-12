# Document_Merger

## Description: Merge text documents provided by the user into a new file.

## Purpose: This application provides experience with user input and interaction in the Console, writing files to disk, reading files from disk, working with exceptions, and writing programs in C#/.NET.

## Requirements:

Project Name: Document Merger
Target Platform: Console
Programming Language: C#

This project is to be managed in a public GitHub repository. For this assignment, submit the Clone with HTTPS URL for the repository that contains it.

## Documentation:

Types and variables (Microsoft)
Console.ReadLine Method () (Microsoft)
Strings (C# Programming Guide) (Microsoft)
How to read from and write to a text file by using Visual C# (Microsoft)
StreamWriter Class (Microsoft)
Exceptions and Exception Handling (C# Programming Guide) (Microsoft)
This program is to display the name of the app "Document Merger" followed by a blank line, prompt the user for the names of two documents (which should be in the current directory) and save a new document in the current directory, and display a message if it was successful or unsuccessful based on a specification provided. The filename of the document is the names of the provided files merged together. Verify that the filenames the user enters exist at the point they enter the name. If the file doesn't exist, give the user feedback that the file doesn't exist and prompt them for another filename.

## When the program runs:

1. Display "Document Merger" followed by a blank line.
2. Prompt the user for the name of the first text file.
3. Verify that the first file exists. If not, give the user feedback and let them re-enter the first filename.
4. Prompt the user for the name of the second document.
5. Verify that the second file exists. If not, give the user feedback and let them re-enter the second filename.
6. Merge the two file names and append .txt to the end (this includes removing the existing .txt extensions from the names).
7. Read and merge the text of the two files.
8. Save the content to a file in the current directory.
9. If an exception occurs, output the exception message and exit.
10. If an exception does not occur, output "[filename] was successfully saved. The document contains [count] characters." and exit. [filename] and [count] are placeholders for the filename of the document and the number of characters it contains.
11. After the program does or does not fail to merge the files, ask the user if they would like to merge two more files. If they do, prompt them again for input. If not, exit the program.
12. Note that the requirements say the files should all be in the current directory. This means you can use just the file name as the path for the file. If you do that, the file will be saved/read in the current directory for the application. When I created the project and called it Document Merger, a directory called Document Merger was created that contains Document Merger.sln and another directory called Document Merger. The Document Merger directory inside of the project is the current directory when the application runs and is where you will find the files that are saved.

13. Close open streams in the finally block of a try-catch-finally. Caution: test a variable holding a reference to a stream to make sure it is not null before calling the Close method on it. Calling a method on a null reference will crash the application.

## Optional Requirements:

The following requirements are optional, but you should try to implement them if you can.

Instead of always using the merged names of the files for the new file name, prompt the user for a filename and present them with the default of the merged names if they don't enter a name (e.g. they choose the default by just hitting enter). Also, if they don't supply an extension of .txt, append .txt on the end.

Example: Enter new filename (default: File1File2.txt):

Allow the user to merge more than two files. Prompt the user for the names of files to merge until they don't supply any more files. So, at the first prompt the user enters a filename, at the second prompt they enter a filename, and at a third prompt they enter a filename. Then, at the fourth prompt, they hit enter indicating they are done entering filenames. So, repeatedly ask for filenames and put them in a list of files to merge until the user signals no more files by supplying no filename at a prompt and just hitting enter. Remember, if a file doesn't exist, give the user feedback that the file doesn't exist and prompt them for another filename immediately after they enter the filename.
