using MediatR;
using Microsoft.AspNetCore.Mvc;
using ReceitaFederal.Services.Features.Empresa.UseCases;

namespace ReceitaFederal.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpresaController(IMediator _mediator) : ControllerBase
    {
        [HttpGet("{nome}/nome")]
        public async Task<IActionResult> ObterPorNomeAsync(
            [FromRoute] string nome, 
            CancellationToken cancellationToken)
            => Ok(await _mediator.Send(new ObterPorNomeQuery { Nome = nome }, cancellationToken));

        [HttpGet("{cnpj}/cnpj")]
        public async Task<IActionResult> ObterPorCnpjAsync(
            [FromRoute] string cnpj, 
            CancellationToken cancellationToken)
            => Ok(await _mediator.Send(new ObterPorCnpjQuery { Cnpj = cnpj }, cancellationToken));
    }
}