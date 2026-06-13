using Content.Shared.Weapons.Melee.Events;

namespace Content.Shared._BRatbite.Weapons.Melee;

public sealed class ImmuneToShoveSystem : EntitySystem
{
    public override void Initialize()
    {
        base.Initialize();
        SubscribeLocalEvent<ImmuneToShoveComponent, BeforeHarmfulActionEvent>(OnDisarmAttempt);
    }

    public void OnDisarmAttempt(Entity<ImmuneToShoveComponent> ent, ref BeforeHarmfulActionEvent args)
    {
        if (args.Type == HarmfulActionType.Disarm)
        {
            args.Cancel();
        }
    }
}
