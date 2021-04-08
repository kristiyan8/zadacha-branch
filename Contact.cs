using System;


namespace sda
{
    class Contact
    {
        private string firstname;
        private string lastname;
        private string phone;

        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public string Phone
        {
            get { return phone; }
            set
            {
                if (value.Length == 10)
                {
                    phone = value;
                }

                else
                {
                    phone = "0000000000";
                }
            }
        }

        public  Contact()
            {
              FirstName = "Joe";
            LastName = "Doe";
            Phone = "0000000000";

               
            }
        public Contact(string firstName, string LastName , string phone)
        {
            FirstName = firstName;
            lastname = LastName;
            Phone = phone;
        }

        public override string ToString()
        {
            string output = String.Empty;

            output += String.Format("{0}, {1}", LastName, FirstName);
            output += String.Format("({0}) {1}-{2}", Phone.Substring(0, 3), Phone.Substring(3, 3),Phone.Substring(6, 4));

            return output;
        }



    }
}
