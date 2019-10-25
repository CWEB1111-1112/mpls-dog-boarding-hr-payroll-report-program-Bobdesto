using System;
/**
Name: Bobdesto Che
Date of completion:10-23-2019

Please be sure to comment your code - provide a comment for each structure use in 
program.
 */
namespace assignment_three
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarations
            string employeeName="";
            int deptNum;
            double hourlySalary = 00.00;
            double hoursWorked, grossSalary;
            string EXIT = "stop";
            double[] deptSalaryAccum ={0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0};
            string[] DEPT_NAMES ={"Personnel","Marketing","Information Technology","Computer Services","sales","Legal","Accounting"};

            Console.WriteLine("Welcome to MPLS Dog Boarding H/R Payroll Report Program.");
            Console.WriteLine("   This program allows the H/R Payroll department to generate");
            Console.WriteLine("   a report that breakdown payroll by department");
            /*Enter Employee Data
            Looping structure to continuously iterateX */
        
            Console.WriteLine("Please enter Employee name");
            employeeName= Console.ReadLine();

            //Loop continuously
            while(employeeName != EXIT){
                
                // Check to see if the Name is filled in and a string
                if (employeeName == ""){
                    Console.WriteLine("Invalid name, please enter a name or stop to exit and generate report");
                    employeeName= Console.ReadLine();
                } // else if()

                Console.WriteLine($"Your name is {employeeName}. Please enter employee dept number");
                deptNum= Convert.ToInt32(Console.ReadLine());

                //Defensive program to ensure employee department number is valid
                if(!(deptNum > 0 && deptNum <= (DEPT_NAMES.Length))){
                Console.WriteLine("Invalid department number. Please enter employee's department number");
                deptNum= Convert.ToInt32(Console.ReadLine());
                }//end while deptNumber is not Invalid
            
                Console.WriteLine($"Your department number  is {deptNum}. Please enter your hourly rate");
                //Collecting hourly rate
                hourlySalary= Convert.ToInt32(Console.ReadLine());

                //Defensive mechanism to ensure that hourly salary is valid
                while(!(hourlySalary > 0 && hourlySalary <9999.99)){
                    Console.WriteLine("Invalid hourly rate. Please enter a valid hourly rate");
                    hourlySalary= Convert.ToInt32(Console.ReadLine());

                }//end while loop if rate is valid

                Console.WriteLine($"Your hourly rate is {hourlySalary} Please enter employee numberof hours worked");
                hoursWorked= Convert.ToInt32(Console.ReadLine());
                //Get gross Salary
                grossSalary= hoursWorked * hourlySalary;
                Console.WriteLine($"Your Gross Salary is {grossSalary}");

                //Determine if department name  is the same as department number
                Console.WriteLine("Department Name"  + DEPT_NAMES [deptNum -1]);

                Console.WriteLine($"Employee name is {employeeName}, gross salary is {grossSalary} and works in {DEPT_NAMES[deptNum -1]} department");

                //Display output of list of seven departments and the total gross salary for each department
                
                for (int i=0; i < DEPT_NAMES.Length; i++){
                    
                }
               
                
                //Reprompt
                Console.WriteLine("Please enter Employee name");
                employeeName= Console.ReadLine();


            }//End while loop for data collection.
                
        

           

            
                






            

            
            
            

            
            


    


        

            
        


        }
    }
}
