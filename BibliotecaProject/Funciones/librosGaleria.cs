using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaProject.Funciones
{
    public class librosGaleria
    {
        string titulo, autor, descripcion;
        Image foto;

        public librosGaleria(Image foto, string titulo, string autor, string descripcion) 
        {
            this.foto = foto;
            this.titulo = titulo;
            this.autor = autor;
            this.descripcion = descripcion;
        }

        public Image getFoto() { return foto; }
        public string getDescripcion() {  return descripcion; }
        public string getTitulo() {  return titulo; }
        public string getAutor() {  return autor; }

    }
}
