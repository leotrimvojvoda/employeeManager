using System;
using Emanager01.Data;
using Emanager01.Models;
using System.Linq;
namespace Emanager01.Data
{
    public class ManagerQuerry : CRUD
    {

        private EmsDatabaseContext emx;

        private Manager generalManager;

        public ManagerQuerry()
        {

            emx = new EmsDatabaseContext();

            generalManager = new Manager();

        }

        public void add(object obj)
        {
            if (obj is Manager && obj != null)
            {
                try
                {
                    emx.Add((Manager)obj);
                    emx.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine("ERROR");
                    Console.WriteLine(e);
                }
            }
            else
            {
                Console.WriteLine("ERROR ADDING MANAGER");
            }
        }

        public object get(string id)
        {
            try
            {

                var man = emx.Managers.First(m => m.ManagerId == Convert.ToInt32(id)); 

                return man;

            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR GETTING MANAGER");
                Console.WriteLine(e);
            }

            return null;
        }

        public void update(string id, object newManager)
        {

            if (newManager is Manager)
            {
                try
                {

                    var man = emx.Managers.First(m => m.ManagerId == Convert.ToInt32(id));


                    if (man != null)
                    {
                        man.FirstName = ((Manager)newManager).FirstName;
                        man.LastName = ((Manager)newManager).LastName;
                        man.DateOfBirth = ((Manager)newManager).DateOfBirth;
                        man.Email = ((Manager)newManager).Email;
                        man.Password = ((Manager)newManager).Password;
                        man.Gender = ((Manager)newManager).Gender;
                        man.Phone = ((Manager)newManager).Phone;

                        emx.SaveChanges();
                    }
                    else
                    {
                        Console.WriteLine("MANAGER DOES NOT EXIST");
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Console.WriteLine("ERROR UPDATING MANAGER");
                }
            }

        }

        public void delete(string id)
        {
            try
            {
                generalManager.ManagerId = Convert.ToInt32(id);

                emx.Managers.Attach(generalManager);
                emx.Managers.Remove(generalManager);

                emx.SaveChanges();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("ERROR DELETING MANAGER");
            }
        }
    }
}
