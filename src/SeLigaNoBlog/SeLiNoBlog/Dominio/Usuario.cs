﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeLigaNoBlog
{
    public class Usuario
    {
        private string nome;

        public string Nome { 
            get {
                return nome;
            }
            set {

                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("value");

                nome = value;
            }
        }
        private string email;

        public string Email
        {
            get
            {
                return email;
            }
            set
            {

                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("value");

                email = value;
            }
        }

        public Usuario(string nome, string email)
        {
            this.Nome = nome;
            this.Email = email;
        }
    }
}
