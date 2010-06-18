pwdgen
======

> **Note:** This project is no longer maintained. It was created for the .NET Frameowrk 1.1 in 2003. I am just archiving it on GitHub as part of a consolidation of my projects. You can find the original article for this project on [The Code Project](http://www.codeproject.com/KB/cs/pwdgen.aspx).

pwdgen illustrates how to create a very simple password generator using C#. Password generators are useful in many applications:

* Registration/membership systems for Web sites
* Auto-creation of passwords according to a specified rule
* Securing application-specific data

The PasswordGenerator class is fairly simple. It exposes several properties that control how the password will be generated.

* Exclusions: Specifies the set of characters to exclude in password generation.
* Minimum: Specifies the minimum length of the generated password.
* Maximum: Specifies the maximum length of the generated password.
* ConsecutiveCharacters: Controls generation of consecutive characters in the generated password.
* RepeatingCharacters: Controls generation of repeating characters in the generated password.
* ExcludeSymbols: Excludes symbols from the set of characters used to generate the password

After setting your desired properties, call the Generate() method to create your new password.

Demo
====

The demo project is a simple Windows Forms UI that allows one to configure the password generator's properties. I must say that while VS.NET is fairly complete and powerful, I just don't like the feel of the forms designer. However, it definitely does the job.

Acknowledgments
===============

Many thanks to Mike Asher and Julian Roberts for their feedback on the first version of the password generator. Julian was kind enough to test the code in an ASP.NET project and confirmed that it performs much better. Also, I reverted to my old C++ bracing style just to make Nish happy...hope you appreciate the sacrifice! :-)

License
=======

(The MIT License)

Copyright (c) 2010 Kevin Stewart

Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
'Software'), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED 'AS IS', WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.