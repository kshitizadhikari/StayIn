﻿namespace StayIn.Domain.Abstractions;
public record Error(string code, string name)
{
    public static Error None => new Error(string.Empty, string.Empty);
    public static Error NullValue => new Error("Error.NullValue", "Null value was provided");
}
