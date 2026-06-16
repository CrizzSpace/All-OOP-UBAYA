using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MargaretEmployeeApplication
{
    [Serializable]
    public class MargaretEmployee
    {
        #region DATA MEMBER
        private int id;
        private string name;
        private int basicSalary;
        private string gender;
        private DateTime startingWork;
        private int numChild;
        #endregion

        #region CONTRUCTOR
        public MargaretEmployee(int id, string name, int basicSalary, string gender, DateTime startingWork, int numChild)
        {
            this.Id = id;
            this.Name = name;
            this.BasicSalary = basicSalary;
            this.Gender = gender;
            this.StartingWork = startingWork;
            this.NumChild = numChild;
        }
        #endregion

        #region PROPERTIES
        public int Id
        {
            get => id;
            set
            {
                if (value != 0)
                {
                    id = value;
                }
                else
                {
                    throw new Exception("Id can't be Empty!");
                }
            }
        }
        public string Name
        {
            get => name;
            set
            {
                if (value != "")
                {
                    name = value;
                }
                else
                {
                    throw new Exception("Name can't be Empty!");
                }
            }
        }
        public int BasicSalary
        {
            get => basicSalary;
            set
            {
                if (value >= 0)
                {
                    basicSalary = value;
                }
                else
                {
                    throw new Exception("BasicSalary can't be Negative!");
                }
            }
        }
        public string Gender
        {
            get => gender;
            set
            {
                if (value != "")
                {
                    gender = value;
                }
                else
                {
                    throw new Exception("Gender can't be Empty!");
                }
            }
        }
        public DateTime StartingWork
        {
            get => startingWork;
            set {startingWork = value;}
        }
        public int NumChild
        {
            get => numChild;
            set
            {
                if (value >= 0)
                {
                    numChild = value;
                }
                else
                {
                    throw new Exception("Number of Child can't be Negative!");
                }
            }
        }
        #endregion

        #region METHOD
        public int CalculateChildAllowance()
        {
            int allowence = 0;
            if(this.Gender == "Male")
            {
                allowence = (int)(this.NumChild * 0.15 * this.BasicSalary);
            }
            return allowence;
        }
        public int CalculateIncentive(int latestTotalSalest)
        {
            int incentive = 0;
            int lengthOfService = DateTime.Now.Subtract(this.StartingWork).Days;
            if (lengthOfService >= 365)
            {
                incentive = (int)(0.25 * latestTotalSalest);
            }
            return incentive;
        }
        public string DisplayData()
        {
            string data = "Employee Id : " + this.Id +
                          "\nName : " + this.Name +
                          "\nBasic Salary : " + this.BasicSalary +
                          "\nGender : " + this.Gender +
                          "\nStarting Work : " + this.StartingWork.ToShortDateString() +
                          "\nNumber of Child : " + this.NumChild +
                          "\nChild Allowance : " + CalculateChildAllowance() + "\n";
            return data;
        }
        #endregion



    }
}
