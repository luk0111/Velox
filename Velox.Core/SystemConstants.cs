namespace Velox.Core;

public static class SystemConstants
{
    public static class ConfigurationKeys
    {
        public const string Routing = "Routing";
        public const string Geocoding = "Geocoding";
        public const string Cache = "Cache";
        public const string Retry = "Retry";

        public const string RoutingProvider = "Routing:Provider";
        public const string GeocodingProvider = "Geocoding:Provider";
        public const string GeocodingApiKey = "Geocoding:ApiKey";
        public const string RoutingApiKey = "Routing:ApiKey";
    }

    public static class OrderLimits
    {
        public const int MaxOrdersPerRoute = 50;
        public const int MaxOrdersPerDriverPerDay = 120;
        public const double MaxOrderWeightKg = 50.0;
        public const int MaxRecipientNameLength = 100;
        public const int MaxPhoneLength = 20;
        public const int MaxAddressLength = 250;
    }

    public static class DriverLimits
    {
        public const int MaxDriverNameLength = 100;
        public const double MinDriverLoadKg = 0.0;
        public const double MaxDriverLoadKg = 1500.0;
        public const int MaxRoutesPerDriverPerDay = 8;
    }

    public static class RouteLimits
    {
        public const double MaxRouteDistanceMeters = 500_000.0;
        public const int MaxRouteDurationMinutes = 12 * 60;
        public const int OptimizationTimeoutSeconds = 30;
    }

    public static class GeoLimits
    {
        public const double MinLatitude = -90.0;
        public const double MaxLatitude = 90.0;
        public const double MinLongitude = -180.0;
        public const double MaxLongitude = 180.0;
        public const double DistanceEpsilonMeters = 1.0;
    }

    public static class Pagination
    {
        public const int DefaultPageSize = 25;
        public const int MaxPageSize = 200;
    }
}