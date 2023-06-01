using Microsoft.AspNetCore.Http;
using Shared.RequestFeatures;

public record LinkParameters(EmployeeParameters EmployeeParameters, HttpContext
Context);