namespace LibreriaSysacad
{
    public class Usuario
    {
        private string _correo;
        private string _clave;

        public Usuario(string correo, string clave)
        {
            _correo = correo;
            _clave = clave;
        }
        public string Correo { get { return _correo; } set { _correo = value; } }    
        public string Clave { get { return _clave; } set { _clave = value; } }  
    }
}