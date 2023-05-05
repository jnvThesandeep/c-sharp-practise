using System;
namespace readOnlyVar{
class person
{

    static readonly int val;

    static person(){
        val=123;
        Console.WriteLine(val);
    }

    public static void Main(){

        person obj=new person();
    }
}

}








