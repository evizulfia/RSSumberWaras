using RSSumberWaras.Model.Entity;
using RSSumberWaras.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSumberWaras.Controller
{
    public class UserController
    {
        public int Create(User user)
        {
            // membuat objek collection

            int result = 0;
            var repo = new UserRestApiRepository();
            result = repo.Create(user);
            return result;
        }
    }
}
