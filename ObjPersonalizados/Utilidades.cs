namespace ObjPersonalizados
{
    public class Utilidades
    {
        public bool validarNumeros(KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || e.KeyChar >= 58)
            {
                e.Handled = true;
                return true;
            }
            return false;
        }

        public bool validarLetras(KeyPressEventArgs e)
        {
            if (e.KeyChar < 32 && e.KeyChar > 32 || e.KeyChar >= 48 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <= 128 || e.KeyChar >= 131 && e.KeyChar <= 159 || e.KeyChar >= 166 && e.KeyChar <= 255)
            {
                e.Handled = true;
                return true;
            }
            return false;
        }
    }
}