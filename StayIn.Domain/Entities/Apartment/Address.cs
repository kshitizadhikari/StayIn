﻿namespace StayIn.Domain.Entities.Apartment;
public record Address(
    string Country,
    string State,
    string ZipCode,
    string City,
    string Street);
