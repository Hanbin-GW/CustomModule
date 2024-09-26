using System;
using CameraShaking;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.CustomModules.API.Enums;
using Exiled.CustomModules.API.Features;
using Exiled.CustomModules.API.Features.Attributes;
using Exiled.CustomModules.API.Features.CustomItems;
using Exiled.CustomModules.API.Features.CustomItems.Items.Firearms;

namespace CustomModule.Item.Basilisk;
[ModuleIdentifier]
public class Basilisk : CustomItem<BasiliskBehavior>
{
    public override uint Id { get; set; } = CustomItemType.Basilisk;
    public override string Name { get; set; } = "Basilisk";
    public override string Description { get; set; } = "대미지가 더 개량된 리볼버 입니다.\nDamage: 75";
    public override ModulePointer Config { get; set; } = new BasiliskConfig();
    public override Type BehaviourComponent { get; } = typeof(BasiliskBehavior);
    public override ItemType ItemType { get; set; } = ItemType.GunRevolver;
    public override ItemCategory ItemCategory { get; set; } = ItemCategory.Firearm;
    public override bool IsEnabled { get; set; } = true;

    public override SettingsBase Settings { get; set; } = new FirearmSettings()
    {
        MaxAmmo = 5,
        ClipSize = 5,
        Damage = 75,
        FireRate = 50,
        FiringMode  = FiringMode.SemiAutomatic,
        AmmoType = ItemType.Ammo44cal,
        RecoilSettings = new RecoilSettings()
        {
            AnimationTime = 1f,
            ZAxis = 10f,
            FovKick = 15f,
            SideKick = 10f,
            UpKick = 13,
        },
        SelectedText = new TextDisplay("당신은 Basilisk 를 선택하였습니다!\n<color=red>피해량이 75</color>인 대신 반동이 심한 리볼버 입니다.",10,channel: TextChannelType.Hint),
        PickedUpText= new TextDisplay("당신은 Basilisk 를 선택하였습니다!",10,channel: TextChannelType.Broadcast)
    };
}