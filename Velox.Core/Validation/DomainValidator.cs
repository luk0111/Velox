namespace Velox.Core.Validation;

public static class DomainValidator
{
    public static ValidationResult ValidateOrder(Order order)
    {
        var errors = new List<ValidationError>();

        if (string.IsNullOrWhiteSpace(order.RecipientName) || order.RecipientName.Length > SystemConstants.OrderLimits.MaxRecipientNameLength)
        {
            errors.Add(new ValidationError("Order.RecipientName", $"Recipient name is required and must be <= {SystemConstants.OrderLimits.MaxRecipientNameLength} characters."));
        }

        if (string.IsNullOrWhiteSpace(order.RecipientPhoneNumber) || order.RecipientPhoneNumber.Length > SystemConstants.OrderLimits.MaxPhoneLength)
        {
            errors.Add(new ValidationError("Order.RecipientPhoneNumber", $"Recipient phone number is required and must be <= {SystemConstants.OrderLimits.MaxPhoneLength} characters."));
        }

        if (string.IsNullOrWhiteSpace(order.DestinationAdress) || order.DestinationAdress.Length > SystemConstants.OrderLimits.MaxAddressLength)
        {
            errors.Add(new ValidationError("Order.DestinationAdress", $"Destination address is required and must be <= {SystemConstants.OrderLimits.MaxAddressLength} characters."));
        }

        if (order.Weight <= 0 || order.Weight > SystemConstants.OrderLimits.MaxOrderWeightKg)
        {
            errors.Add(new ValidationError("Order.Weight", $"Order weight must be > 0 and <= {SystemConstants.OrderLimits.MaxOrderWeightKg} kg."));
        }

        ValidateCoordinates(order.Latitude, order.Longitude, "Order", errors);

        return ValidationResult.Failure(errors);
    }

    public static ValidationResult ValidateDriver(Driver driver)
    {
        var errors = new List<ValidationError>();

        if (string.IsNullOrWhiteSpace(driver.Name) || driver.Name.Length > SystemConstants.DriverLimits.MaxDriverNameLength)
        {
            errors.Add(new ValidationError("Driver.Name", $"Driver name is required and must be <= {SystemConstants.DriverLimits.MaxDriverNameLength} characters."));
        }

        if (driver.MaxLoad < SystemConstants.DriverLimits.MinDriverLoadKg || driver.MaxLoad > SystemConstants.DriverLimits.MaxDriverLoadKg)
        {
            errors.Add(new ValidationError("Driver.MaxLoad", $"Driver max load must be between {SystemConstants.DriverLimits.MinDriverLoadKg} and {SystemConstants.DriverLimits.MaxDriverLoadKg} kg."));
        }

        ValidateCoordinates(driver.Latitude, driver.Longitude, "Driver", errors);

        if (driver.Routes.Count > SystemConstants.DriverLimits.MaxRoutesPerDriverPerDay)
        {
            errors.Add(new ValidationError("Driver.Routes", $"Driver routes per day cannot exceed {SystemConstants.DriverLimits.MaxRoutesPerDriverPerDay}."));
        }

        if (driver.Orders.Count > SystemConstants.OrderLimits.MaxOrdersPerDriverPerDay)
        {
            errors.Add(new ValidationError("Driver.Orders", $"Driver orders per day cannot exceed {SystemConstants.OrderLimits.MaxOrdersPerDriverPerDay}."));
        }

        return ValidationResult.Failure(errors);
    }

    public static ValidationResult ValidateRouteAssignment(Driver driver, IReadOnlyCollection<Order> orders)
    {
        var errors = new List<ValidationError>();

        if (orders.Count == 0)
        {
            errors.Add(new ValidationError("Route.Orders", "At least one order is required to build a route."));
            return ValidationResult.Failure(errors);
        }

        if (orders.Count > SystemConstants.OrderLimits.MaxOrdersPerRoute)
        {
            errors.Add(new ValidationError("Route.Orders", $"Orders per route cannot exceed {SystemConstants.OrderLimits.MaxOrdersPerRoute}."));
        }

        var totalWeight = orders.Sum(o => o.Weight);
        if (totalWeight > driver.MaxLoad)
        {
            errors.Add(new ValidationError("Route.Weight", "Total order weight exceeds driver capacity."));
        }

        return ValidationResult.Failure(errors);
    }

    private static void ValidateCoordinates(double latitude, double longitude, string entityName, ICollection<ValidationError> errors)
    {
        if (latitude < SystemConstants.GeoLimits.MinLatitude || latitude > SystemConstants.GeoLimits.MaxLatitude)
        {
            errors.Add(new ValidationError($"{entityName}.Latitude", $"Latitude must be between {SystemConstants.GeoLimits.MinLatitude} and {SystemConstants.GeoLimits.MaxLatitude}."));
        }

        if (longitude < SystemConstants.GeoLimits.MinLongitude || longitude > SystemConstants.GeoLimits.MaxLongitude)
        {
            errors.Add(new ValidationError($"{entityName}.Longitude", $"Longitude must be between {SystemConstants.GeoLimits.MinLongitude} and {SystemConstants.GeoLimits.MaxLongitude}."));
        }
    }
}

