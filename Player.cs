﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CisESport
{
    public class Player
    {
       private string name, lastname,studentid, major, displayname, mail, phone;
        private int age = 0;

       public Player(string name, string lastname, string studentid,
            string major, string displayname, string mail, string phone, int age) 
        {
        this.name = name;
        this.lastname = lastname;
        this.studentid = studentid;  
        this.major = major;
        this.displayname = displayname;
        this.mail = mail;
        this.phone= phone;
        this.age = age;
        }
    }
}
