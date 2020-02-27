namespace Facade
{
    public class SMTPSettings
    {
        private string _serverName;
        private string _userName;
        private string _password;

        public string serverName{

            get{return _serverName;}
            set{_serverName = value;}
        }
         public string userName{
            
            get{return _userName;}
            set{_userName = value;}
        }
        
         public string password{
            
            get{return _password;}
            set{_password = value;}
        }
    }
}