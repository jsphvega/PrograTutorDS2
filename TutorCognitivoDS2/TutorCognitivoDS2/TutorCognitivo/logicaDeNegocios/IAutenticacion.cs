using dto;
using System;

namespace logicaDeNegocios
{
    public interface IAutenticacion
    {
        void autenticarUsuario(DTOUsuario usuario, String pTipo);
    }
}