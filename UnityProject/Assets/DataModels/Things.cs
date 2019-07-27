using System.Collections.Generic;
/// <summary>
///  512 x 512 픽셀의 게임을 만든다. 
/// 간단한 원시적인 렌더링을 직접해보고 싶다. 
/// 게임 출력 화면은 위 사이즈의 텍스쳐고 (각 픽셀 값에 대한 int 에 해당하는 색을 실시간으로 그리는 식으로 )
/// PixelGameBehaviour.cs 를 제외하면 가능하면 유니티 기능을 쓰지는 않도록 해본다. 
/// 이 프로젝트는 순전히 재미를 위해서 하는 것임을 잊지말자. (Don't be so serious.)
/// </summary>
namespace PixelGames
{
    public class PgObject
    {
        public readonly string id;
        public string name;
        public PgTransform transform;
        public List<PgCompnent> Compnents;
    }


    public class PgTransform
    {
        public int CenterPosX;
        public int CenterPosY;
        public int SortingOrder;
        public int Width;
        public int Height;
    }

    public abstract class PgCompnent
    {
        public abstract void Awake();
        public abstract void Update();
    }


}