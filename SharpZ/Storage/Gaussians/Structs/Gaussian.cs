using System.Numerics;

namespace SharPZ;


// public interface IGaussian
// {
//     bool Compressed { get; }

//     Vector3 Position { get; }
//     Vector3 Scale { get; }
//     Quaternion Rotation { get; }
//     float Alpha { get; }
//     Vector3 Color { get; }
//     GaussianHarmonics<float> Sh { get; }
// }


public readonly struct Gaussian(in Vector3 pos, in Vector3 scale, in Quaternion rotation, float alpha, in Vector3 color, in GaussianHarmonics<float> sh)
{
    public readonly bool Compressed => false;

    public readonly Vector3 Position { get; } = pos;
    public readonly Vector3 Scale { get; } = scale;
    public readonly Quaternion Rotation { get; } = rotation;
    public readonly float Alpha { get; } = alpha;
    public readonly Vector3 Color { get; } = color;
    public readonly GaussianHarmonics<float> Sh { get; } = sh;
}
