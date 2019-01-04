using AutoMapper;

using MediatR;

using Microsoft.AspNetCore.Mvc;

using JsonApiSerializer.JsonApi;

using System.Reflection;

using System.Threading.Tasks;

namespace Bob.Api
{
    public class BaseController : Controller
    {
        protected readonly IMediator _mediator;

        public BaseController(IMediator mediator)
        {
            _mediator = mediator;
        }

        protected async Task<DocumentRoot<TData>> ExecuteRequestPipline<TData>(IRequest<TData> request) where TData: class
        {
            var jsonResponce = new DocumentRoot<TData>
            {
                JsonApi = new VersionInfo
                {
                    Version = Assembly.GetEntryAssembly()
                    .GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion
                    
                }
            };

            jsonResponce.Data = await _mediator.Send(request);

            return jsonResponce;
        }
    }
}