using Abp.Application.Services.Dto;

namespace PruebaEntity.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

