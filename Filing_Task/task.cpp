#include<iostream>
#include <list>
#include<fstream>
using namespace std;

class Student
{
    public:
    string first_name,last_name, id,standing,date_of_birth;
    int credits;
    double gpa;
};
class Course
{
    public:
        string name,code,prof_name;
        int no_of_credits;
};
Student students[20];

class Roster
{
    int count;

    public:
        Roster()
        {
            count = 0;
        }
        void insert(Student obj)
        {
            students[count] = obj;
        }
};

void show_menu_User()
{
    cout<<" 1: Insert new Student to a Roster \n 2: Remove a Student from a Roster \n 3:Update a Student in a Roster \n"<<endl;
}
void show_menu_Super()
{

    cout<<"1: Create a new Roster "<<endl;
    cout<<"2: Drop a Roster "<<endl;
    cout<<"3: Display Roster information "<<endl;
    cout<<"4: Display all Rosters "<<endl;
}
void show_user()
{
    cout<<"Please enter  below options "<<endl;
    cout<<"1: SuperVisor Mode"<<endl;
    cout<<"2: User Mode"<<endl;
}
bool authenticate()
{
    string user_name;
    string password;
    string input_user_name;
    string input_password;

    cin>>user_name;
    cin>>password;

    ifstream reader("database.txt");
    reader>>input_user_name;
    reader>>input_password;

    reader.close();
    if(input_password==password && user_name == input_user_name)
        return true;
    return false;
}
int main()
{
    int choice=0;
    while(true)
    {
        show_user();
        cin>>choice;
        if(choice== 1 || choice ==2)
            break;
    }
    if(choice==1)
    {
        cout<<"Welcome to Supervisor Mode"<<endl;
        cout<<"enter the password"<<endl;
        if(authenticate())
        {
            cout<<"login successful"<<endl;
            while(true)
            {
                int choice_user;
                show_menu_Super();
                cin>>choice_user;
                if(choice_user==1||choice_user==2|| choice_user==3 || choice_user==4)
                {
                    break;
                }
            }
        }
        else
        {
            cout<<"login failed"<<endl;
        }

    }
    else if(choice==2)
    {
        cout<<"Welcome to User Mode"<<endl;
        while(true)
            {
                int choice_user;
                show_menu_User();
                cin>>choice_user;
                if(choice_user==1||choice_user==2|| choice_user==3)
                {
                    break;
                }
            }
    }
}
