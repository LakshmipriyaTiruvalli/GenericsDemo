using System;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiante the class using required datatype
            CustomerData<string, int> customerdata1 = new CustomerData<string, int>();
            customerdata1.name = "Priya";
            customerdata1.id = 10;
            CustomerData<string, int> customerdata2 = new CustomerData<string, int>();
            //customerdata2.name = 20;  //gives compile time error, since string should be passed
            //customerdata2.id = "Lakshmi"; //gives compile time error, since int should be passed
            customerdata2.id = 20;
            customerdata2.name = "Lakshmi";

            //Instantiating generic methods
            GenericMethodExample<string> genericMethodExample1 = new GenericMethodExample<string>();
            genericMethodExample1.Method1(10, "Lakshmi");
            GenericMethodExample<int> genericMethodExample2 = new GenericMethodExample<int>();
            genericMethodExample2.Method1(10, 20);
        }
    }
    //Generic class example
    //First define class using generic syntax
    public  class CustomerData<TName,TId>
        {

        //generic fields
         public TName name { get; set; }
         public TId id { get; set; }

        }

}
