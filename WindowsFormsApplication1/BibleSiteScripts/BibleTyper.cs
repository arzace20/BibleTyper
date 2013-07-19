using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibleTyper;
using System.Threading;

namespace BibleTyper
{
    public class BibleTyper
    {
        public General General;
        public Login Login;
        public Setup Setup;
        public MainPage MainPage;
        public TypePage TypePage;
        public string InitialBookName = "";
        public string BibleName = "";

        public BibleTyper()
        {
            Setup = new Setup();
            General = new General(this);
            Login = new Login(this);
            MainPage = new MainPage(this);
            TypePage = new TypePage(this);
        }

        public void pause(int Milliseconds)
        {
            Thread.Sleep(Milliseconds);
        }
    }
}
