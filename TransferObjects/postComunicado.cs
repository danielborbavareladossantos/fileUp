using System;
using Microsoft.AspNetCore.Http;

namespace upFile.Controllers
{
    public class postComunicado
    {
        #region atributos
        public virtual String Nome { get; set; }
        public virtual Int64 Id_comunicado { get; set; }
        public virtual IFormFile Arquivo { get; set; }
        #endregion

        #region Construtores
        public postComunicado() { }

        public postComunicado(
            String Nome,
            Int64 Id_comunicado,
            IFormFile Arquivo
        )
        {
            this.Nome = Nome;
            this.Id_comunicado = Id_comunicado;
            this.Arquivo = Arquivo;
        }
        #endregion

        #region Sobrescritas
        public override string ToString()
        {
            return
                 this.Nome + ", "
                + this.Id_comunicado + ", "
                + this.Arquivo + ", ";
        }
        #endregion
    }
}