﻿using EmployeesApi.Models.Employees;
using System.Threading.Tasks;

namespace EmployeesApi
{
    public interface IManageEmployeeData
    {
        Task<GetEmployeesResponse> GetAllActiveEmployeesAsync();
        Task<GetEmployeeDetailsResponse> GetEmployeeDetailsAsync(int id);
        Task<GetEmployeeDetailsResponse> HireAsync(PostEmployeeRequest request);
        Task FireAsync(int id);
        Task<bool> ChangeFirstNameAsync(int id, string firstName);
    }
}