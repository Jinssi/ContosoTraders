﻿global using AutoMapper;
global using gravyTraders.Api.Core;
global using gravyTraders.Api.Core.Constants;
global using gravyTraders.Api.Core.Exceptions;
global using gravyTraders.Api.Core.Models;
global using gravyTraders.Api.Core.Models.Implementations.Dao;
global using gravyTraders.Api.Core.Models.Implementations.Dto;
global using gravyTraders.Api.Core.Models.Interfaces;
global using gravyTraders.Api.Core.Repositories;
global using gravyTraders.Api.Core.Repositories.Implementations;
global using gravyTraders.Api.Core.Repositories.Interfaces;
global using gravyTraders.Api.Core.Requests.Definitions;
global using gravyTraders.Api.Core.Requests.Validators;
global using gravyTraders.Api.Core.Services.Implementations;
global using gravyTraders.Api.Core.Services.Interfaces;
global using FluentValidation;
global using MediatR;
global using Microsoft.AspNetCore.Http;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.Azure.CognitiveServices.Vision.ComputerVision;
global using Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.Logging;