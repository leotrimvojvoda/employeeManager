using System;
using System.Linq;
using Emanager01.Data;
using Emanager01.Models;
namespace Emanager01.Data
{
    public class RemarkQuerry : CRUD
    {

        private EmsDatabaseContext emx;

        private Remark generalRemark;

        public RemarkQuerry()
        {

            emx = new EmsDatabaseContext();

            generalRemark = new Remark();

        }

        public void add(object obj)
        {
            if (obj is Remark && obj != null)
            {
                try
                {
                    emx.Add((Remark)obj);
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
                Console.WriteLine("ERROR ADDING REMARK");
            }
        }

        public object get(string id)
        {
            try
            {

                var rem = emx.Remarks.First(r => r.RemarksId == Convert.ToInt32(id));

                return rem;

            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR GETTING REMARK");
                Console.WriteLine(e);
            }

            return null;
        }

        public void update(string id, object newManager)
        {

            Console.WriteLine("NOT SUPPORTED");
        }

        public void delete(string id)
        {
            try
            {
                generalRemark.RemarksId = Convert.ToInt32(id);

                emx.Remarks.Attach(generalRemark);
                emx.Remarks.Remove(generalRemark);

                emx.SaveChanges();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("ERROR DELETING REMARK");
            }
        }


    }
}
