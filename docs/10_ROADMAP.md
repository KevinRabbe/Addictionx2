# From capsule to Addiction² — experimental development roadmap

**Created:** 2026-11-14  
**Status:** **PROPOSED DEVELOPMENT SEQUENCE**, not a locked feature specification, release schedule, or authorization to implement every example.  
**Design authority:** [02_DECISIONS.md](02_DECISIONS.md) and [01_VISION.md](01_VISION.md).  
**Execution method:** One small task → Unity verification → human playtest → adjust → reviewed commit. See [04_PROTOTYPE.md](04_PROTOTYPE.md).

## The real objective

Don't try to transform a gray capsule directly into the finished game. Build **small playable experiments**, then connect the successful results into a **tiny end-to-end experience that already feels like Addiction²**.

Both halves matter from early development:

- **Valheim foundation:** a place to explore and live in; resources, building, preparation, and an eventual persistent co-op world.
- **Metin2-inspired RPG complement:** character identity and combat, enemies, progression, desirable equipment, blacksmith/NPC, repeatable goal.
- **Small New World-style layer:** profession growth when gathering; do not build a giant skill catalog.

The intended experience is **freedom to choose what to do**. A player who spends an evening building should not feel like they are failing to play the RPG, and a player who farms monsters should still care about home and resources.

## Distinguish three levels of progress

1. **Mechanics experiments:** prove a single behavior works; use capsules, primitives, disposable UI.
2. **Playability experiments:** prove the activity feels good; bring in animations, reactive enemies, and readable feedback when they become necessary.
3. **Integrated vertical slice:** prove that the building/survival loop and combat/RPG loop coexist and reinforce each other, not merely that their scripts compile independently.

Do **not** equate a successful isolated dummy-hit test with enjoyable combat, or a successful place-one-wall test with enjoyable Valheim-style building.

## Checkpoint 0 — Preserve current baseline (immediate)

**Observed in human playtest:** the existing `Prototype_Movement` capsule and third-person camera felt good. Lowest step was walkable; taller steps were not. Codex reported clean compilation and left prototype changes uncommitted pending human review.

**Repository sync caveat at the time of this roadmap:** GitHub `main` still showed `Assets/Scenes/SampleScene.unity` only and no `Assets/Scripts` directory. The actual movement prototype shown in the screenshot therefore appears **local-only** until Codex commits/pushes it. Check actual Windows `git status`, remote and diff before editing; preserve unrelated pre-existing `Assets/Editor` deletions. Do not label this checkpoint completed based on chat alone.

**Exit:** baseline scene, scripts and `.meta` files reviewed, committed and accessible on remote GitHub; existing movement/camera still work.

## Checkpoint 1 — Core fighting sandbox (very next prototype track)

**Risk being tested:** does interaction and combat itself have the potential to be fun?

- One capsule vs target: simple attack input, range/hitbox, attack state, hit confirmation, and adjustable timings; small **debug overlay** to understand what happens.
- One opponent that can attack: spacing, readable danger windows and actual fight interaction.
- **A basic rigged/animated humanoid placeholder EARLY**, before claiming animation-dependent weapon feel has been solved. Animations/strike contact and enemy reactions affect the subjective evaluation.
- Experiment with the minimum combat mobility/defensive behavior required to make a fight readable; do not implement a complete stamina/skills/combo/parry tree.
- Distinguish **Valheim-like dangerous individuals** from **Metin2-like repeatable enemy packs** by eventually testing both in tiny arenas, without choosing final density yet.
- User explicitly considers fighting feel more important than extra polish to basic locomotion; postpone separate jump/sprint/stair tuning unless needed to test combat.

**Exit:** user can fight one responding enemy, explain what feels good/bad about attacks, recovery, spacing and feedback; combat tuning is easy to change. A dummy-only experiment is **not** enough.

## Checkpoint 2 — Building and survival sandbox (early, not a distant afterthought)

**Risk being tested:** is making a home and gathering inherently satisfying?

- Gather one representative resource via a repeatable interaction; build a minimal inventory/resource counter only if needed.
- Place, rotate, snap and remove a **small set of structural pieces** in a little build area. Try the construction *feel*, not just whether a cube spawns.
- Test at least one meaningful Valheim-inspired building consideration (e.g. support/stability or placement affordances); exact system remains undecided.
- Confirm a combat-oriented character can build/gather freely — **classes will not gate survival activities**.
- Give a reason to return to the home, even if only a temporary food/preparation/resource loop.

**Exit:** a player can gather, build something recognizable and want to improve it. Record the feel of snapping, camera placement, feedback and repetition.

## Checkpoint 3 — Early technical risk spikes, not full frameworks

Do these **before lots of systems depend on the wrong assumptions**:

- **Save/load spike:** one character identity and one placed building survive quit/reload; decide world-bound character (B) vs restricted hybrid (C) before serious equipment/XP saves. Unrestricted cross-world high-level transfer is rejected because it ruins fresh-group progression.
- **Co-op spike:** two players in a test scene with clear authority over movement and one shared interaction, to reveal architectural constraints early. Confirm a direction for who owns damage, loot, placed buildings and world state; don't implement full multiplayer yet.
- **Data model spike:** prototype reusable item definitions, stat/bonus definitions, item instances and calculation tests **before** building an elaborate inventory/loot/equipment system.
- **Seeded world spike (when world work begins):** a tiny procedurally generated area containing a reserved authored landmark, and persistence of one world modification.

**Exit:** critical technical assumptions have been *tested* and documented, not merely discussed. No manager/ECS/networking framework should be selected because it's fashionable.

**Timing:** these small spikes can happen between Checkpoints 1–4 rather than requiring a rigid phase where nothing else progresses.

## Checkpoint 4 — Small authored town inside generated nature

**Risk being tested:** can the starting hub feel meaningful in a Valheim-like explorable world?

- Begin with a **tiny** generated wilderness containing an intentionally positioned, authored **Map1-inspired town placeholder**; blend terrain around the reserved town area.
- One NPC service for a real purpose; a blacksmith is the user's specifically required town role.
- No player building inside the established town; allow construction outside it.
- Preserve player-built state separately from reproducible generated terrain.

**Exit:** walk out from the town, explore, find/gather something, return, then place something at your own base. The atmosphere can remain very rough.

## Checkpoint 5 — Minimal RPG progression and equipment

**Risk being tested:** do combat and loot provide desirable *voluntary* repeatable goals?

- Simple XP and levels; a minimal representative class/combat identity without locking the roster or skills/weapon ownership.
- One ordinary craftable item and an interesting loot item; **shared regular sword bonus pools** wherever applicable. The special DSS/FKS concept is one optional example among many and not a roadmap centerpiece.
- Prototype blacksmith enhancement (eventually +0..+9) and eligible normal bonus switching with **temporary** numerical values, not a finalized economy.
- Keep stats as distinct definitions from items and rolled item instances, and verify the values survive save/load.
- Introduce one repeatable encounter or mini-dungeon with a reason to revisit, not dozens of enemies or gear tiers.

**Exit:** player can acquire/improve something, see its effect on combat, and voluntarily choose another run. Existing crafted gear remains useful.

## Checkpoint 6 — The first **tiny Addiction²** vertical slice

**This is the first major integration target, not a complete game.**

A possible **illustrative loop** (not an approved quest design):

1. Start in an authored town inside an explorable generated region; speak to a useful NPC.
2. Explore and gather a resource.
3. Build or improve a small home.
4. Prepare for a fight (basic equipment/consumable or similar).
5. Fight a small encounter or tiny dungeon; obtain something worthwhile.
6. Return to town or base, improve equipment, and decide whether to build/explore more or fight again.
7. Save, quit and reload successfully.

Then test the same small world with two friends (building-oriented and combat-oriented), including the **distance-independent configurable party character XP** direction when networking is ready. Profession XP remains activity-earned. A full guild system is not necessary for this first slice.

**Exit:** the two principal loops work together, can be played repeatedly, and the user can describe *why* they'd want another session. A scripted linear demo alone is not enough: it must allow the player to choose building versus fighting.

## Checkpoint 7 — Grow from a working slice, not a feature spreadsheet

Only after the slice works:
- Expand class identities, weapon types, enemy types, dungeon variety, bosses and quests incrementally.
- Deepen Valheim-like building, gathering progression, home life, sailing and world exploration.
- Add lightweight multi-guild identity and co-op UX.
- Improve visual identity, character animation, combat feedback, audio, performance, larger-world streaming and save reliability.
- Perform focused balancing for underleveled challenge, solo viability for all classes, group XP and voluntary farming.
- Gradually add content after the underlying loops are proven.

**Avoid:** months of art before gameplay; dozens of static NPCs; a complete procedural world before persistence; a finalized seven-bonus item scheme because another game has one; or a large networking rewrite after many unowned shared-state scripts.

## Operating rules and milestone quality gates

- **Each checkpoint is a hypothesis**, not a guaranteed design choice. Keep a brief experiment log and allow results to change the order.
- Each task ends with reported Unity compile/test status, human playtest where relevant, and a reviewed Git commit.
- A feature has three possible honest statuses: **prototype works technically**, **user tested feel**, **integrated and persists/networked**. Don't conflate them.
- Do not allow ChatGPT-side documentation changes to hide local-only Unity changes: sync through Git.
- If a proposed experiment contradicts `docs/02_DECISIONS.md`, the decision ledger wins until the user changes it.
- Keep placeholders easily replaceable. **Blender MCP becomes useful when we need actual model/animation/content work, not for generating basic Unity cubes.**
- No deadline/date, scope count, balance table, engine architecture or asset style in this document is final.

## Most useful question at every milestone

> **What is the smallest playable change that makes Addiction² noticeably closer to a survival world you want to live in AND an RPG you want to progress in?**

If a change doesn't improve those experiences or reduce a serious technical risk, defer it.
