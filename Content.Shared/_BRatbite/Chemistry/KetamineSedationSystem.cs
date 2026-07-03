using Content.Shared._Shitmed.DoAfter;
using Content.Shared.Buckle.Components;
using Content.Shared.Cuffs.Components;
using Content.Shared.Cuffs;

namespace Content.Shared._BRatbite.Chemistry;

public sealed class KetamineSedationSystem : EntitySystem
{
    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<KetamineSedationComponent, GetDoAfterDelayMultiplierEvent>(OnGetDoAfterDelayMultiplier);
        SubscribeLocalEvent<KetamineSedationComponent, UnbuckleAttemptEvent>(OnUnbuckleAttempt);
        SubscribeLocalEvent<UncuffAttemptEvent>(OnUncuffAttempt);
    }

    private void OnGetDoAfterDelayMultiplier(Entity<KetamineSedationComponent> ent, ref GetDoAfterDelayMultiplierEvent args)
    {
        args.Multiplier *= ent.Comp.DoAfterDelayMultiplier;
    }

    private void OnUncuffAttempt(ref UncuffAttemptEvent args)
    {
        if (args.Cancelled || args.User != args.Target)
            return;

        if (!HasComp<KetamineSedationComponent>(args.User))
            return;

        args.Cancelled = true;
    }

    private void OnUnbuckleAttempt(Entity<KetamineSedationComponent> ent, ref UnbuckleAttemptEvent args)
    {
        if (args.Cancelled || args.User != ent.Owner)
            return;

        args.Cancelled = true;
    }
}
