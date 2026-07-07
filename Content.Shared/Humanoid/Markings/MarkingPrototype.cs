// SPDX-FileCopyrightText: 2022 Flipp Syder <76629141+vulppine@users.noreply.github.com>
// SPDX-FileCopyrightText: 2022 metalgearsloth <31366439+metalgearsloth@users.noreply.github.com>
// SPDX-FileCopyrightText: 2022 metalgearsloth <comedian_vs_clown@hotmail.com>
// SPDX-FileCopyrightText: 2022 wrexbe <81056464+wrexbe@users.noreply.github.com>
// SPDX-FileCopyrightText: 2023 DrSmugleaf <DrSmugleaf@users.noreply.github.com>
// SPDX-FileCopyrightText: 2023 Morb <14136326+Morb0@users.noreply.github.com>
// SPDX-FileCopyrightText: 2023 csqrb <56765288+CaptainSqrBeard@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 Aiden <28298836+Aidenkrz@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 BloodfiendishOperator <141253729+Diggy0@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 Ed <96445749+TheShuEd@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 GoobBot <uristmchands@proton.me>
// SPDX-FileCopyrightText: 2025 SX-7 <92227810+SX-7@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 SX-7 <sn1.test.preria.2002@gmail.com>
// SPDX-FileCopyrightText: 2025 Tayrtahn <tayrtahn@gmail.com>
//
// SPDX-License-Identifier: MIT

using Robust.Shared.Prototypes;
using Robust.Shared.Utility;

namespace Content.Shared.Humanoid.Markings
{
    [Prototype]
    public sealed partial class MarkingPrototype : IPrototype
    {
        [IdDataField]
        public string ID { get; private set; } = "uwu";

        public string Name { get; private set; } = default!;

        [DataField("bodyPart", required: true)]
        public HumanoidVisualLayers BodyPart { get; private set; } = default!;

        [DataField("markingCategory", required: true)]
        public MarkingCategories MarkingCategory { get; private set; } = default!;

        [DataField("speciesRestriction")]
        public List<string>? SpeciesRestrictions { get; private set; }

        [DataField("sexRestriction")]
        public Sex? SexRestriction { get; private set; }

        [DataField("followSkinColor")]
        public bool FollowSkinColor { get; private set; } = false;

        [DataField("forcedColoring")]
        public bool ForcedColoring { get; private set; } = false;

        [DataField("coloring")]
        public MarkingColors Coloring { get; private set; } = new();

        /// <summary>
        /// Do we need to apply any displacement maps to this marking? Set to false if your marking is incompatible
        /// with a standard human doll, and is used for some special races with unusual shapes
        /// </summary>
        [DataField]
        public bool CanBeDisplaced { get; private set; } = true;

        [DataField("sprites", required: true)]
        public List<SpriteSpecifier> Sprites { get; private set; } = default!;

        /// Impstation start
        [DataField]

        public string? Shader { get; private set; } = null;
        /// Impstation end

        // Starlight start - split marking sprites can use different visual anchors and color slots.
        /// <summary>
        /// Optional visual layer anchors for each sprite in <see cref="Sprites"/>.
        /// Body-part anchors insert above the body part; other anchors insert below the anchor layer.
        /// </summary>
        [DataField]
        public List<HumanoidVisualLayers>? SpriteLayers;

        /// <summary>
        /// Maps each sprite layer to a color slot. When unset, each sprite gets
        /// its own color slot for legacy marking behavior.
        /// </summary>
        [DataField]
        public List<int>? SpriteColorIndexes;

        public int ColorSlotCount
        {
            get
            {
                if (SpriteColorIndexes == null || SpriteColorIndexes.Count == 0)
                    return Sprites.Count;

                var colorCount = 0;
                for (var i = 0; i < Sprites.Count; i++)
                {
                    var colorIndex = GetColorIndex(i);
                    if (colorIndex >= colorCount)
                        colorCount = Math.Max(colorCount, colorIndex + 1);
                }

                return colorCount;
            }
        }

        public int GetColorIndex(int spriteIndex)
        {
            if (SpriteColorIndexes == null ||
                SpriteColorIndexes.Count == 0 ||
                spriteIndex >= SpriteColorIndexes.Count)
            {
                return spriteIndex;
            }

            return Math.Max(0, SpriteColorIndexes[spriteIndex]);
        }

        public List<Color> GetColorSlotColors(IReadOnlyList<Color> colors)
        {
            var slotColors = new List<Color>(ColorSlotCount);
            for (var i = 0; i < ColorSlotCount; i++)
            {
                slotColors.Add(Color.White);
            }

            if (colors.Count == ColorSlotCount)
            {
                for (var i = 0; i < ColorSlotCount; i++)
                {
                    slotColors[i] = colors[i];
                }

                return slotColors;
            }

            if (SpriteColorIndexes is { Count: > 0 } && colors.Count == Sprites.Count)
            {
                var assignedSlots = new bool[ColorSlotCount];
                for (var i = 0; i < Sprites.Count; i++)
                {
                    var colorIndex = GetColorIndex(i);
                    if (colorIndex >= ColorSlotCount || assignedSlots[colorIndex])
                        continue;

                    slotColors[colorIndex] = colors[i];
                    assignedSlots[colorIndex] = true;
                }

                return slotColors;
            }

            for (var i = 0; i < colors.Count && i < ColorSlotCount; i++)
            {
                slotColors[i] = colors[i];
            }

            return slotColors;
        }

        public Marking AsMarking()
        {
            return new Marking(ID, ColorSlotCount);
        }
        // Starlight end
    }
}
