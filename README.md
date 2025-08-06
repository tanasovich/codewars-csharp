# CodeWars C#

Just storing solutions for Katas. As you can suppose, solutions are done in C#.

## Rules of solution storage

### Kata Solution

Project structure follows `classlib` template.

#### Directory and project file

Solution with name *X* and complexity *Y kyu* is stored in the directory
with name **Kyu*Y*.*X***.

`.csproj` file uses the same name.

#### C# file

`.cs` file is named as **Kata**. Class also has name **Kata**.

Name of the method solution follows C# code conventions, even if CodeWars task
uses different one. 

### Kata Tests

Project structure follows `nunit` template.

#### Directory and project file

If solution has name *X* and complexity *Y*, test directory and `.csproj` file
have name **Kyu*Y*.*X*.Tests**

#### C# file

`.cs` file is named as **Tests**. Class also has name **Tests**.
