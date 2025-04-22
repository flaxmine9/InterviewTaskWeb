using AutoMapper;
using InterviewTaskWeb.DataBase.Models;
using InterviewTaskWeb.DataBase.Services;
using InterviewTaskWeb.DTOModels;
using Microsoft.AspNetCore.Mvc;

namespace InterviewTaskWeb.Controllers
{
    public class CompanyController : ControllerBase
    {
        // здесь можно избавиться от явного определения типа и переделать через интерфейс, создав нужный объет через DI
        private readonly CompanyService _companyService;

        private readonly IMapper _mapper;

        public CompanyController(CompanyService companyService, IMapper mapper)
        {
            _companyService = companyService;
            _mapper = mapper;
        }

        #region Companies endpoints

        [HttpGet("companies")]
        public async Task<ActionResult<IEnumerable<CompanyDto>>> GetAllCompanies()
        {
            try
            {
                var companies = await _companyService.GetAllCompaniesAsync();
                var result = _mapper.Map<List<CompanyDto>>(companies);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("companies/{id}")]
        public async Task<ActionResult<CompanyDto>> GetCompany(int id)
        {
            try
            {
                var company = await _companyService.GetCompanyWithDepartmentsAsync(id);
                if (company == null)
                {
                    return NotFound();
                }
                return Ok(_mapper.Map<CompanyDto>(company));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPost("companies")]
        public async Task<ActionResult<CompanyDto>> CreateCompany([FromBody] CreateCompanyDto createDto)
        {
            try
            {
                var company = _mapper.Map<Company>(createDto);
                await _companyService.AddCompanyAsync(company);

                var result = _mapper.Map<CompanyDto>(company);
                return CreatedAtAction(nameof(GetCompany), new { id = result.Id }, result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpDelete("companies/{id}")]
        public async Task<IActionResult> DeleteCompany(int id)
        {
            try
            {
                await _companyService.DeleteCompanyAsync(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        #endregion

        #region Departments endpoints

        [HttpGet("departments")]
        public async Task<ActionResult<IEnumerable<DepartmentDto>>> GetAllDepartments()
        {
            try
            {
                var companies = await _companyService.GetAllCompaniesAsync();
                var departments = companies.SelectMany(c => c.Departments);
                return Ok(_mapper.Map<List<DepartmentDto>>(departments));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPost("departments")]
        public async Task<ActionResult<DepartmentDto>> CreateDepartment([FromBody] CreateDepartmentDto createDto)
        {
            try
            {
                var department = _mapper.Map<Department>(createDto);
                await _companyService.AddDepartmentAsync(department);

                var company = await _companyService.GetCompanyWithDepartmentsAsync(department.CompanyId);
                var result = _mapper.Map<DepartmentDto>(department);

                return CreatedAtAction(nameof(GetCompany), new { id = department.CompanyId }, result);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPost("departments/{id}/move")]
        public async Task<IActionResult> MoveDepartment(int id, [FromBody] MoveDepartmentDto moveDto)
        {
            try
            {
                await _companyService.MoveDepartmentAsync(id, moveDto.NewCompanyId);
                return NoContent();
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        #endregion

        #region Otdels endpoints

        [HttpGet("Otdels")]
        public async Task<ActionResult<IEnumerable<OtdelDto>>> GetAllOtdels()
        {
            try
            {
                var companies = await _companyService.GetAllCompaniesAsync();
                var Otdels = companies
                    .SelectMany(c => c.Departments)
                    .SelectMany(d => d.Otdels);
                return Ok(_mapper.Map<List<OtdelDto>>(Otdels));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPost("Otdels")]
        public async Task<ActionResult<OtdelDto>> CreateOtdel([FromBody] CreateOtdelDto createDto)
        {
            try
            {
                var Otdel = _mapper.Map<Otdel>(createDto);
                await _companyService.AddOtdelAsync(Otdel);

                var department = await _companyService.GetDepartmentWithCompanyAsync(Otdel.DepartmentId);
                var result = _mapper.Map<OtdelDto>(Otdel);

                return CreatedAtAction(nameof(GetCompany), new { id = department.CompanyId }, result);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPost("Otdels/{id}/move")]
        public async Task<IActionResult> MoveOtdel(int id, [FromBody] MoveOtdelDto moveDto)
        {
            try
            {
                await _companyService.MoveOtdelAsync(id, moveDto.NewDepartmentId);
                return NoContent();
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        #endregion
    }
}