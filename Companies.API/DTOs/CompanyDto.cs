﻿namespace Companies.API.DTOs;

    public record CompanyDto
    {
        public int Id { get; init; }
        public string? Name { get; init; }
        public string? Address { get; init; }
        public string? Country { get; init; }
    }

