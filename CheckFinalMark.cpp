//Jose Vilaplana
#include <iostream>
using namespace std;
int main()
{
    int mark1;
    int mark2;
    int mark3;
    double avg;

    cout << "Enter the first mark";
    cin >> mark1 >> endl;
    
    cout << "Enter the second mark";
    cin >> mark2 >> endl;
    
    cout << "Enter the third mark";
    cin >> mark3 >> endl;
    
    avg = (mark1 + mark2 + mark3) / 3;

    //Case A
    if(mark1 >= 4 && mark2 >= 4 && mark3 >= 4 && avg >= 5)
        cout << "Final mark: "+avg;

    //Case B
    else if(mark1 >= 4 && mark2 >= 4 && mark3 >= 4 && avg < 5)
        cout << "Final mark: 4";

    //Case C
    else
    {
        if(avg > 3)
            cout << "Final mark: 3";
        else
            cout << "Final mark: "+avg
    }
    return 0;
}