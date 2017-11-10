using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ApiExample.Models;
using System.Data.Entity;
using System.Web.Http.Cors;

namespace ApiExample.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class UserApiController : ApiController
    {
        Model1 db = new Model1();

        public IList<udata> GetUser()
        {
            return db.udatas.ToList();
        }

        public string PostUser([FromBody]udata u)
        {
            try
            {
                db.udatas.Add(u);
                db.SaveChanges();
                return "done";
            }
            catch (Exception ee)
            {
                return "error";
            }
        }

        public string PutUser(int id,[FromBody]udata u)
        {
            try
            {
                db.Entry(u).State = EntityState.Modified;
                db.SaveChanges();
                return "done";
            }
            catch (Exception ee)
            {
                return "error";
            }
        }

        public string DeleteUser(int id)
        {
            try
            {
                udata u = db.udatas.Find(id);
                db.udatas.Remove(u);
                db.SaveChanges();
                return "done";
            }
            catch (Exception ee)
            {
                return "error";
            }
        }

    }
}
