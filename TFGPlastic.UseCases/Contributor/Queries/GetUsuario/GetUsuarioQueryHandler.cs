using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFGPlastic.Infrastructure.DataBase;
using TFGPlastic.UseCases.Contributor.Command.LogIn;
using Mapster;
using Microsoft.EntityFrameworkCore;
using TFGPlastic.Core.Entity.User.User;

namespace TFGPlastic.UseCases.Contributor.Queries.GetUsuario
{
    public class GetUsuarioQueryHandler : IRequestHandler<GetUsuarioQuery, UserDto>
    {
        private readonly TFGPlasticDbContext _context;

        public GetUsuarioQueryHandler(TFGPlasticDbContext context)
        {
            _context = context;
        }

        public async Task<UserDto> Handle(GetUsuarioQuery request, CancellationToken cancellationToken)
        {
            // Recupera el usuario por su ID u otra información de consulta específica.
            //usuario user = this._context.Users.FirstOrDefaultAsync(u => u.Id == request.Id);

            /*UsuarioEntity user = await this._context.Users.FirstOrDefaultAsync(u => u.Id == request.Id);

            if (user == null)
            {
                throw new UsuarioNoEncontradoException("El usuario no se encontró");
            }


            UserDto usuarioDto = user.Adapt<UserDto>();*/
            return null;


        }
    }
}
