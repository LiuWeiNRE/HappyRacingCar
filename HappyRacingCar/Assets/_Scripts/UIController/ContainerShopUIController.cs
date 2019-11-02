public partial class ContainerShopUIController : UIControllerBase
{
    public enum ShopType
    {
        ShopPower = 1,//体力
        ShopDiamond = 2,//钻石
        ShopCoin = 3,//金币
        ShopProps = 4,//道具
        ShopScore = 5,//积分
    }

    private static ShopType shopType = ShopType.ShopDiamond;
    public static ShopType CurrentShopType
    {
        get { return shopType; }
        set { shopType = value; }
    }
}