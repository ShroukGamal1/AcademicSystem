﻿global using Academic.API.Exceptions;
global using Academic.Application.Mapper.Configuration;
global using Microsoft.OpenApi.Models;
global using Academic.Infrastructure.Data;
global using Microsoft.EntityFrameworkCore;
global using Academic.Core.Entities;
global using FluentValidation.AspNetCore;
global using Microsoft.AspNetCore.Identity;
global using Academic.Application.Authentication;
global using Academic.API.DependencyInjection;
global using FluentValidation;
global using Microsoft.AspNetCore.Authentication.JwtBearer;
global using Microsoft.IdentityModel.Tokens;
global using System.Reflection;
global using System.Text;
global using Microsoft.AspNetCore.Mvc;
global using Academic.Application.DTOs.Account;
global using Academic.Application.Interfaces;
global using Academic.Application.Utilities;
global using Academic.Application.DTOs.Supervisor;
global using Academic.Application.DTOs.Branch;
global using Swashbuckle.AspNetCore.Annotations;
global using Academic.Application.Constants;
global using Academic.Application.Services;
global using Academic.Core.Interfaces;
global using Academic.Infrastructure.UnitOfWork;
global using Academic.Application.Interfaces.IRepository;
global using Academic.Application.Repositories;
global using Academic.Application.DTOs.Subjects;
global using Microsoft.AspNetCore.Authorization;
global using Academic.Infrastructure.Repository;
global using Academic.Application.DTOs.Course;
global using Academic.Application.DTOs.Subjects;
global using Academic.Infrastructure.Repository;
