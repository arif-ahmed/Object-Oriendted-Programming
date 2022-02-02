
namespace ParkingLotManagement.Infrastructure
{
    [AttributeUsage(
   AttributeTargets.Class |
   AttributeTargets.Constructor |
   AttributeTargets.Field |
   AttributeTargets.Method |
   AttributeTargets.Property,
   AllowMultiple = true)]
    public class AdminOnly : Attribute
    {
    }
}
