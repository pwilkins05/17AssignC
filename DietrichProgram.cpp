#include <iostream>

using namespace std;

int main()
{

    char letter = 'a';
    cout << "Choose an option!" << endl;
    cout << "a. Print the alphabet!" << endl;
    cout << "b. Count to 100!" << endl;

    char choice;
    cin >> choice;


    /*BUG:  Adds a [ after the alphabet. */

    if (choice == 'a')
    {

        for (int i = 0; i <= 26; i++)
        {
            cout << letter++ << " ";
        }
    }

    /*BUG:  Commas after spaces
      BUG:  Comma after 100  */

    //I don't know C++, but below is how I would solve this with C#
    else if (choice == 'b') 
    {
        for (int i = 0; i <= 100; i++)
        {
            cout << i << " ,";
        }
    }
    else
        cout << "Oops! Try choosing a or b." << endl;

    return 0;
}

//Josh's C# Bug fix
else if (choice == 'b') 
    {
    	string output = "";
        for (int i = 1; i <= 100; i++)
        {
            output += i + ", ";
            if (i == 10)
            	return string finalOutput = output.Substring(0, output.Length -2);
        }
    }
