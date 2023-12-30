using Mapster;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFGPlastic.Core.Entity;
using TFGPlastic.Core.Entity.User.User;
using TFGPlastic.Core.Enum;
using TFGPlastic.Infrastructure.DataBase;
using TFGPlastic.UseCases.Contributor.Command.CrearTarea;
using TFGPlastic.UseCases.Contributor.Command.EstadoTareas;

namespace TFGPlastic.UseCases.Contributor.Command.LogIn
{
    /*public class ValidarUsuarioCommandHandler : IRequestHandler<ValidarUsuarioCommand, bool>
    {

        private readonly IUserRepository _userRepository;

        public ValidarUsuarioCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        /*public Task<bool> Handle(ValidarUsuarioCommand request, CancellationToken cancellationToken)
        {
            // Realiza la validación del usuario 
            return Task.FromResult( _userRepository.ValidateLog(request.nombre, request.password));
            throw new Exception("user not found");
        }
    }*/
}
