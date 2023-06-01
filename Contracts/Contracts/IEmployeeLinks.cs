using Microsoft.AspNetCore.Http;
using System.Net.Http;

public interface IEmployeeLinks
{
    LinkResponse TryGenerateLinks(IEnumerable<EmployeeDto> employeesDto,
    string fields, Guid companyId, HttpContext httpContext);
}