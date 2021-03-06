﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ficha1
{
    class Repo
    {
        private string name;

        public string Name
        {
            get { return name != null ? name : "Unnamed Repository"; }
            set { name = value; }
        }

        private string language;

        public string Language
        {
            get { return language != null ? language : "(N/A)"; }
            set { language = value; }
        }



        //lista de colaboradores aqui??????????
        public List<Collab> colbs;
        
        private string contributors_url;
        public string Contributors_url { get { return contributors_url == null ? null : contributors_url.Replace("{/collaborator}", "").Replace("https://api.github.com", ""); } set { contributors_url = value; } }

        public Repo()
        {
            colbs = new List<Collab>();
        }
    }
}
