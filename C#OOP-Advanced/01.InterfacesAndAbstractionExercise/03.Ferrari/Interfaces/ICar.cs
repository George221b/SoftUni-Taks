public interface ICar
{
    string Model { get; }
    string DriverName { get; }

    string Brake();
    string Gas();
}
