using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFGPlastic.UseCases.Contributor.Command.LogIn;

namespace TFGPlastic.UseCases.Contributor.Queries.GetUsuario
{
    public class GetUsuarioQuery: IRequest<UserDto>
    {
        public GetUsuarioQuery(Guid id, Guid userDto)
        {
            Id = id;
            UserDto = userDto;
        }

        public Guid Id { get; set; }
        public Guid UserDto { get; internal set; }
    }
}
