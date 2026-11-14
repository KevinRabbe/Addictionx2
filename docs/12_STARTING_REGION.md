# Starting region concept — Map1-inspired town

**Recorded:** 2026-11-14  
**Status:** **Approved high-level design principles**, not a final map, geometry specification, biome plan, NPC roster, or Codex implementation task.  
**Origin:** Director's hand-drawn starting-region sketch and explicit clarification that **the two black markings represent two paths for entering the town**. This document preserves the interpretation in text; the drawing itself was shared in chat and is not yet stored in the repository.

## Purpose and overall experience

Build an original starting settlement with a familiar **Map1-style sense of place**, but grounded in a **Valheim-like explorable survival world**. The town is a recognizable early service hub and navigation reference, not a sealed level or the only place the player can live. Its surroundings should encourage exploration, gathering, choosing a place to build, and eventually adventuring toward harder challenges.

This is part of the **building/world-first development direction**. The RPG systems can be introduced later within the same world.

## Confirmed starting-region principles

1. **Safe starting hub:** The town initially provides a recognizable, comparatively safe place with useful NPC services. The **blacksmith is specifically required**; other NPCs should be added as gameplay needs emerge, not filled in to imitate another game's exact roster.
2. **No construction inside town:** Player-built homes and structures belong **outside the established settlement**. Build restrictions must eventually be clear to players and work with the future persistent world.
3. **Two entrances / access paths:** **Both black markings in the user's drawing indicate paths used to enter the town.** They are **not** representations of dark forests, danger zones, or other biomes. Preserve the intent that the settlement connects to the surrounding world through **two routes**.
4. **Freedom outside town:** The nearby world should introduce exploration, gathering, and the possibility of choosing a home location. Do not prescribe permanent housing plots or require a specific combat class for building.
5. **Terrain boundary and orientation:** The area marked as a **hill in the sketch is intended as a landscape boundary / edge of the drawn region**, **not** a proposed major gameplay destination or specially designed landmark. Recognizable orientation cues may be useful later, but their type and placement are open.
6. **Readable transitions and danger:** Terrain, paths, vegetation, landmarks and later enemy placement should help players understand where they are going and when an area feels less safe; avoid making difficulty legible only through a UI level number.
7. **Part of one continuous world:** The significant town layout is **authored/hand-placed** within **generated surrounding wilderness** in one physically connected overworld (director confirmed Option A, 2026-11-14). The two entry paths connect directly to the landscape, **not** separate overworld maps or mandatory portal transitions. Terrain-generation, streaming and exact placement methods remain undecided.

## How to read the sketch (without over-interpreting it)

- The drawing suggests a settlement with simple structures, adjacent open ground, a **hill drawn to indicate a boundary**, and **two access routes**.
- The **bottom-left marked position** is a **possible NPC location**: perhaps a mount-related NPC **if mounts need such a service**, or another NPC if that fits later gameplay better. It is **not** a confirmed mount system or a required NPC.
- The **black markings identify the two entry routes**. Previous speculation that those marks depicted dangerous or dark regions was **incorrect**.
- The sketch communicates **relationships and spatial identity**, not final distances, north/south orientation, road widths, gates, house counts, building zones or enemy locations.
- Do **not** assume one road is for survival/building and the other is for combat/RPG. Both should belong to the same explorable world; whether one becomes a main route and the other a secondary route is **undecided**.
- The town should feel connected to the world rather than like an isolated tutorial corridor. A wall, gate, elevation advantage or natural boundary might help, but **no specific fortification has been approved**.

## Player-building relationship

The protected town serves as an initial point of reference and NPC support. After leaving by either path, players eventually find a place for their own home in the wilderness. The home should be something players can grow and return to over many sessions; **placement restrictions, terrain rules, structural support, permissions and exact home benefits have not yet been selected**.

The eventual implementation must distinguish **authored town content**, **generated world content**, and **persistent player/world changes**. This is a boundary to investigate, not a mandate for any particular Unity architecture.

## Design questions still open

- How do the **two entrance routes** physically meet the town? Their exact positions, width, grade, gate treatments and relative importance.
- What is the boundary implied by the sketched hill (terrain rise, surrounding ridge or just conceptual map edge)? **Do not assume it must become a special destination or gameplay landmark.**
- What is the practical safety boundary, and how gradually do threats appear outside it?
- How large is the surrounding first-play area, where are natural building spots, and how do we avoid an artificial housing-zone feeling?
- Which NPCs and services besides the required blacksmith actually earn their place? The bottom-left mark is a **flexible possible NPC spot**, with a mount NPC only a conditional idea.
- How does an authored town meet procedurally generated terrain without seams or regeneration destroying player changes?

## Planning and implementation guardrail

**This document is a regional design statement, not approval to construct the final Map1 scene.** First use it to judge world/building prototypes and identify a suitable small representative landscape. Codex can automatically test scene correctness; the director evaluates whether moving through, orienting within, and eventually building around the region feels believable and inviting. Do not copy Metin2's protected map geometry or assets into the original game.

Related: [vision](01_VISION.md), [decision ledger](02_DECISIONS.md), [architecture guardrails](09_ARCHITECTURE_GUARDRAILS.md), [current state](STATE.md).
