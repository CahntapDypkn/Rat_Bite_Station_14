<!--
SPDX-FileCopyrightText: 2026 Sprinkle <40203084+lnn0q@users.noreply.github.com>

SPDX-License-Identifier: AGPL-3.0-or-later
-->

# Traits Info

This file documents selectable non-language, non-accent traits as they appear in the character traits UI. Traits are grouped by category and sorted by point cost, then by name. Positive cost spends points; negative cost gives points.

## Physical

| Skill | Cost | Description | Gameplay Details | Technical Details |
|---|---:|---|---|---|
| Neurogenesis Imperfecta | -10 | Your brain is incompatible with neural connectors, MMIs, cloning, and foreign bodies. | Blocks cloning/revival and prevents brain/MMI body transfer behavior. | Adds NeurogenesisImperfecta, NeurogenesisImperfectaBrain, Uncloneable, and Unrevivable behavior. Species blacklist: IPC. Component blacklist: BorgChassis. |
| Blindness | -6 | You are legally blind and cannot see clearly past a few meters. | Applies permanent blindness and starts with a white cane. | Adds PermanentBlindness. Component whitelist: Blindable. Trait gear: WhiteCane. |
| Osteogenesis Imperfecta | -6 | Also known as brittle bone disease; your bones are easily broken. | Reduces your critical injury threshold by 50 points. | Adds GlassJaw with a larger crit decrease. Exclusive with Tenacity. Species blacklist: IPC. Component blacklist: BorgChassis. |
| Wheelchair Bound | -6 | You cannot move without your wheelchair. | Starts buckled to a wheelchair with paralyzed legs. | Adds BuckleOnMapInit, LegsStartParalyzed, and LegsParalyzed. Component blacklist: BorgChassis. |
| Clumsiness | -5 | You're not that good with your hands... Your hand coordination leaves people around you speechless. Just don't try to hold a gun. We don't need any casualties... | Applies clumsy gun, catch, and vaulting/climbing mishaps. Uses the default clumsy sound, not the wawa protest sound. | Adds Clumsy with gunShootFailDamage Blunt 5, Piercing 4, Burn 3 and catchingFailDamage Blunt 1. No custom clumsySound override. |
| Movement Impaired | -5 | You cannot walk well without assistance. | Starts with a cane and reduces movement speed to 60%. | Adds MovementImpaired. Component blacklist: BorgChassis. Trait gear: Cane. |
| Deaf | -4 | You're completely deaf. | Prevents hearing. | Adds Deaf. Component blacklist: BorgChassis. |
| Feeble | -4 | Your body responds poorly to injuries, making damage slow you more severely. | Damage slows movement earlier and harder at 45/65 damage thresholds. | Adds SlowOnDamage. Exclusive with Steadfast. Species blacklist: Felinid, Tajaran. |
| Hemophilia | -4 | Your body has impaired blood clotting. | Bleeding lasts longer and Blunt damage taken is increased. | Adds Hemophilia. Species blacklist: IPC. Component blacklist: BorgChassis. |
| Lethargy | -4 | You tire faster than others. | Lowers stamina, stamina regeneration, and delays stamina recovery. | Adds Lethargy. Exclusive with Vigor. Species blacklist: Felinid, Tajaran. Component blacklist: BorgChassis. |
| Glass Jaw | -2 | Your body is fragile and more vulnerable to critical injuries. | Lowers the critical threshold by 10 points. | Adds GlassJaw. Exclusive with Tenacity. Species blacklist: IPC. |
| Deuteranopia | -1 | Whether through custom bionic eyes, random mutation, or being a Vulpkanin, you have red-green colour blindness. | Applies red-green colorblind vision overlay behavior. | Adds DogVision. Moved from uncategorized to Physical and assigned cost -1 in Resources/Prototypes/_DV/Traits/altvision.yml. |
| High Pain Tolerance | -1 | You cannot assess your own health status reliably. | Hides or impairs health-state feedback. | Adds PainNumbness. |
| Inner peace | -1 | You are always in touch with the center of the tile you are standing on. | Forces tile movement. | Adds TileMovement. |
| Lightweight drunk | -1 | Alcohol has a stronger effect on you. | Doubles booze strength. | Adds LightweightDrunk. |
| Monochromacy | -1 | You are fully colorblind. | Applies black-and-white overlay. | Adds BlackAndWhiteOverlay. |
| Short-sighted | -1 | You have difficulty seeing far away without corrective glasses. | Applies partial permanent blindness and starts with prescription glasses. | Adds PermanentBlindness with blindness 4. Component whitelist: Blindable. Trait gear: ClothingEyesPrescriptionGlasses. |
| Snoring | -1 | You snore while sleeping. | Makes the character snore while asleep. | Adds Snoring. |
| Unrevivable | -1 | You cannot be revived by defibrillators. | Prevents defibrillator revival while still allowing cloning when configured. | Adds Unrevivable with cloneable true. |
| Alcohol Tolerance | 1 | Your body shrugs off the visual effects of booze. | Reduces drunk overlay strength; does not prevent alcohol poisoning. | Adds AlcoholTolerance. Exclusive with LightweightDrunk, LiquorLifeline. Species blacklist: Dwarf, IPC. Component blacklist: BorgChassis. |
| Temperature Tolerance | 1 | You tolerate lower temperatures. | Improves cold/temperature protection. | Adds TemperatureProtection. |
| Tenacity | 1 | You are hardier than others. | Raises the critical threshold by 5 points. | Adds Tenacity. Exclusive with GlassJaw and OsteogenesisImperfecta. Species blacklist: IPC. |
| Ultraviolet Vision | 1 | Whether through custom bionic eyes, random mutation, or being a Harpy, you perceive the world with ultraviolet light. | Applies ultraviolet vision overlay behavior. | Adds UltraVision. Moved from uncategorized to Physical and assigned cost 1 in Resources/Prototypes/_DV/Traits/altvision.yml. |
| Voracious | 1 | Nothing gets between you and your food. | Doubles food and drink consumption speed. | Adds Voracious. Species blacklist: IPC. Component blacklist: BorgChassis. |
| Bionic Spinarette | 2 | A bionic organ lets you spin all-natural silk. | Grants sericulture silk production at hunger cost. | Adds Sericulture. Species blacklist: IPC, Arachnid. Component blacklist: BorgChassis. |
| Light Step | 2 | You move with a gentle step. | Reduces walking and sprinting footstep volume by 10. | Adds FootstepVolumeModifier. Species blacklist: Felinid, Tajaran. |
| Prybar Prosthetics | 2 | Your arms have been reinforced with steel and hydraulics. | Lets prosthetic arms pry out of restraints. | Adds PrybarProsthetics. |
| Striking Calluses | 2 | Reinforced knuckles improve barehand strikes. | Adds 2 Blunt damage to barehand attacks. | Adds StrikingCalluses. Component blacklist: BorgChassis. |
| Lyre Bird | 3 | Your mimicry lets you imitate songs in their entirety. | Grants singing plus swappable instrument behavior. | Adds HarpySinger, Instrument, and SwappableInstrument. Exclusive with Muted. Included species: Harpy, IPC. |
| Steadfast | 3 | You keep moving despite injuries. | Damage slows movement later and less severely at 70/90 damage thresholds. | Adds SlowOnDamage. Exclusive with Feeble. Species blacklist: Felinid, Tajaran. Component blacklist: BorgChassis. |
| Thieving | 3 | You are deft with your hands and talented at convincing people of their belongings. | Lets you identify pocketed items, steal 50% faster, and use subtler strip feedback. | Adds Thieving. Species blacklist: Felinid. Kleptomania strip attempts use the normal strip pipeline, so this trait can buff involuntary strip attempts. |
| Tracking by Scent | 3 | Either through bionic augmentation or some genetic circumstance, your sense of smell is heightened. Just sniff it, alright! | Grants existing scent tracking verbs and behavior. Vulpkanin cannot select it because they already have scent tracking. | Adds ScentTracker. Species blacklist: Vulpkanin. Added in Resources/Prototypes/Traits/quirks.yml and clone-whitelisted in clone.yml. |
| Trap Avoider | 3 | You unconsciously avoid traps. | Prevents triggering floor traps. | Adds TrapAvoider. Species blacklist: Felinid, Tajaran, Harpy. |
| All Ears | 4 | Allows for a higher threshold of hearing conversations - through walls and even whispers. | Extends normal speech hearing from 10 to 14 and muffled whisper hearing from 5 to 8. Clear whisper range is unchanged. | Adds EnhancedHearing. EnhancedHearingSystem expands ExpandICChatRecipientsEvent recipients while normal chat handling still controls deafness, language comprehension, and LOS/wall behavior. Clone-whitelisted in clone.yml. |
| Hardened Lymphocytes | 4 | Your marrow has been treated to reduce radiation harm. | Adds flat Radiation damage reduction. | Adds DamageProtectionBuff. Species blacklist: IPC. Component blacklist: BorgChassis. |
| Paci-fist | 5 | A pacifist martial art designed to subdue with range control. | Requires Pacifist. Barehand attacks deal stamina damage, pull targets inward, and allow instant chokehold on harm-grabbed stamina-crit targets. | Adds PaciFist, PacifismAllowedUnarmedCombat, PacifismAllowedGrab, and InstantChokeholdOnStaminaCrit. Exclusive with PctTraining. Component blacklist: MartialArtsKnowledge, KravMaga, BorgChassis. |
| Parkour Training | 5 | You are trained in parkour. | Halves climb delay, reduces slipping paralysis to 70%, and halves contact speed slowdown. | Adds ClimbDelayModifier, SlippableModifier, and SpeedModifiedByContactModifier. |
| PCT Training | 5 | Precise Combat Techniques training improves unarmed strikes. | Adds 5 Blunt damage to unarmed strikes, rewards consecutive clean hits, and punishes misses/objects with punch lockout. | Adds PctTraining. Component blacklist: MartialArtsKnowledge, KravMaga, BorgChassis. |
| Dermal Armor | 6 | Your skin is reinforced with a synthetic hard-polymer shell. | Reduces Blunt, Slash, and Piercing damage by 3.5; increases Shock damage taken by 25%. | Adds DamageProtectionBuff. |
| Liquor Lifeline | 6 | Ethanol acts like a prescription. | While drunk, slowly heals Brute, Heat, Shock, and Cold damage based on drunkenness. | Adds LiquorLifeline and grants alcohol-tolerance behavior. Exclusive with AlcoholTolerance. Species blacklist: IPC, Dwarf. Component blacklist: BorgChassis. |
| Vigor | 6 | Your endurance is enhanced. | Raises stamina, improves stamina regeneration, and reduces stamina cooldown. | Adds Vigor. Exclusive with Lethargy. Species blacklist: Oni, IPC. |
| Bionic Legs | 8 | One or more limbs have been replaced with bionics. | Improves movement speed. | Adds BionicLegs. |
| Juggernaut | 8 | Your critical and death damage thresholds are increased. | Raises crit/death survivability thresholds by 50. | Adds Juggernaut. Exclusive with GlassJaw, Tenacity, OsteogenesisImperfecta. Species blacklist: IPC. Component blacklist: BorgChassis. |
| Marathoner | 10 | You gain stamina, run faster, and recover from prone faster. | Adds 50 stamina, increases running speed, and improves prone get-up speed. | Adds Marathoner. Exclusive with Vigor, Lethargy. Species blacklist: IPC. Component blacklist: BorgChassis. |
| Nanite Repair Drones | 10 | IPC chassis nanites respond to physical trauma. | IPC-only passive Brute/Burn repair over time. | Adds PlateletFactories. Species blacklist excludes non-IPC species. Component blacklist: BorgChassis. |
| Platelet Factories | 10 | Bio-tailored organs enhance long-term survivability. | Passively repairs burn and brute damage over time, reduced in crit. | Adds PlateletFactories. Exclusive with Hemophilia. Species blacklist: IPC. Component blacklist: BorgChassis. |

## Mental

| Skill | Cost | Description | Gameplay Details | Technical Details |
|---|---:|---|---|---|
| Chronic Kleptomania | -8 | Basically makes you attempt to steal stuff from nearby people every 3 seconds. | Every 3 seconds, if the player can interact and has an empty hand, attempts involuntary theft. Successful loose floor-item pickup forces at least a 10 second cooldown. Strip targets are visible held items and visible worn slots only. | Adds Kleptomania with timeBetweenIncidents 3, 3 and riskyTargets true. Mutually exclusive only with Kleptomania. Uses explicit visible slots, not SlotFlags.WITHOUT_POCKET. |
| Redshirt | -8 | "They said this air would be breathable. Get in, get out again, and no one gets hurt. Something is pulling me up the hill. I look down in my red shirt. I look down in my red shirt." | Reduces your death threshold by 100 points. | Adds WillToDie with a larger death decrease. Exclusive with WillToLive. Species blacklist: IPC. Component blacklist: BorgChassis. |
| Pacifist | -6 | You cannot attack or hurt living beings. | Blocks direct harm against living targets unless another component explicitly allows it. | Adds Pacified. |
| Kleptomania | -4 | ..Y'know it's just... it's not like I can help it. I see the shine of that disabler... God, it's intoxicating to think that I could have one if I were sneakier. | Every 12-20 seconds, if the player can interact and has an empty hand, tries loose floor items, visible held items, then low-risk visible worn slots. It does not steal from backpacks, pockets, suit storage, storage contents, self, ghosts, dead/critical mobs, anchored items, or inaccessible targets. | Adds Kleptomania with timeBetweenIncidents 12, 20. Mutually exclusive only with ChronicKleptomania. Uses SharedHandsSystem for loose pickup and SharedStrippableSystem helpers for strip attempts. |
| Narcolepsy | -4 | You fall asleep randomly. | Random sleep incidents every 300-600 seconds for 10-30 seconds. | Adds Narcolepsy. |
| Muted | -3 | You cannot speak. | Prevents speaking. | Adds Muted. Component blacklist: BorgChassis. |
| Paracusia | -1 | You hear sounds that are not really there. | Plays hallucinated sounds at random intervals. | Adds Paracusia with minTimeBetweenIncidents 0.1, maxTimeBetweenIncidents 300, maxSoundDistance 7, and Paracusia sound collection. |
| Social Anxiety | -1 | You have crippling social anxiety and are freaked out by affectionate things. | Applies social anxiety interaction effects. | Adds SocialAnxiety. |
| Will To Die | -1 | You have an unusually weak will to live. | Lowers death threshold by 15 points. | Adds WillToDie. Exclusive with WillToLive. Species blacklist: IPC. Component blacklist: BorgChassis. |
| NanoTrasen Loyalty Training | 0 | You start with a mindshield implant. | Starts the character with a mindshield implant. | Adds LoyaltyTraining. |
| Will To Live | 1 | You have an unusually strong will to live. | Raises death threshold by 10 points. | Adds WillToLive. Exclusive with WillToDie and Redshirt. Species blacklist: IPC. Component blacklist: BorgChassis. |
| Self-Aware | 2 | You have a keen intuition of your body and senses. | Adds accurate self-examine health information. | Adds SelfAware. |
| CPR Training | 3 | You have received CPR training. | Allows CPR training behavior. | Adds CPRTraining. |
| Experienced Surgeon | 3 | Surgery is your specialty. | Sets surgery speed modifier to 2.3. | Adds SurgerySpeedModifier. |
| Surgery Training | 3 | You can perform surgery effectively. | Sets surgery speed modifier to 1.6. | Adds SurgerySpeedModifier. |

## Shared Systems Touched By Added Traits

| File | Purpose |
|---|---|
| Content.Shared/Strip/SharedStrippableSystem.cs | Adds public helpers for automated strip attempts from inventory slots and hands. These helpers still run range/access checks, existing strip validation, do-after setup, warnings, logging, and BeforeStripEvent. This lets Kleptomania strip attempts benefit from Thieving without directly moving equipment. |
| Content.Server/Traits/Assorted/EnhancedHearingComponent.cs | Marker component for All Ears. |
| Content.Server/Traits/Assorted/EnhancedHearingSystem.cs | Expands chat recipients for entities with EnhancedHearing. |
| Content.Server/Traits/Assorted/KleptomaniaComponent.cs | Stores kleptomania interval, range, risky target flag, floor-item cooldown, and next incident timer. |
| Content.Server/Traits/Assorted/KleptomaniaSystem.cs | Runs involuntary loose-item pickup and strip attempts. Restricts all strip stealing to visible hands or explicit visible worn slots. |
| Resources/Prototypes/_DV/Traits/altvision.yml | Moves UltraVision and DogVision into Physical and assigns costs. |
| Resources/Prototypes/Traits/quirks.yml | Adds TrackingByScent and AllEars trait prototypes. |
| Resources/Prototypes/Traits/disabilities.yml | Adds Clumsiness, Kleptomania, and ChronicKleptomania trait prototypes. Despite the file name, these traits are categorized as Physical or Mental in the character setup UI. |
| Resources/Locale/en-US/traits/traits.ftl | Adds player-facing names and descriptions for the new traits. |
| Resources/Prototypes/Entities/Mobs/Player/clone.yml | Adds EnhancedHearing, Kleptomania, and ScentTracker to clone component copying. DogVision and UltraVision were already clone-whitelisted. |
