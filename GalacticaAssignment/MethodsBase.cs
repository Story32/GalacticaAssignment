namespace GalacticaOOP
{
    internal class MethodsBase
    {
        public static float Distance(Planet planet)
        {
            return MathF.Sqrt(
                (MathF.Pow(0 - planet.Position.X, 2) + MathF.Pow(0 - planet.Position.Y, 2))
                );
        }

        internal static float Distance(GalacticaOOP.Planet planet)
        {
            throw new NotImplementedException();
        }
    }
}