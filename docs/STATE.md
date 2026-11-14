# STATE — Addiction²

**Updated:** 2026-11-14 · **Working development plan**, not a locked feature specification. Read this first for the current priority; `docs/02_DECISIONS.md` is authoritative for game-design decisions.

## What we're making

**Addiction² is a working title.** The game is an original solo/small-group co-op survival action RPG: **Valheim-inspired world, building and living = foundation**; **Metin2-inspired fighting, classes, loot and progression = complementary RPG loop**; a very small New World-inspired profession layer. No MMO pressure. Players should freely choose building, exploration or fighting.

## What we are focusing on now

**CONFIRMED by the director, 2026-11-14: build and live in a world FIRST.** This changes the *next development track*, not the overall vision or the importance of enjoyable combat. The earlier note that fighting feel matters more than **optional extra movement polish** remains valid.

**Why:** Evaluate whether constructing a home and gathering resources is something the player wants to keep doing, instead of spending more sessions on a capsule-vs-dummy technical test.

## Latest design clarification (director, 2026-11-14)

- **Division of testing:** Codex should independently verify **functional correctness** where tools allow; the director evaluates **gameplay feel**, satisfaction, and whether the result fits the vision. Human playtesting is not a substitute for Codex checking basic functionality.
- **Home direction:** the suggested role of a home (chosen place, player-built and expandable, persistent, useful to adventures, eventually shared) is **broadly aligned, but NOT fully specified or approved point by point**. Do not freeze exact building rules or home benefits from this tentative description.
- **Sequence:** establish the **world/home/building foundation first**; introduce the RPG experience **afterward**, while still protecting future integration with combat, loot and progression. No final order among terrain, construction, gathering and persistence has yet been decided.
- **Planning gate:** do not treat `BRIEF_01_SHELTER.md` as an authorized implementation task until the world/building approach and risk boundaries have been considered sufficiently. It is a candidate brief, not a green light to start coding.

## World design decision 1 — confirmed

**One continuous main world**, not separate Metin2-style overworld maps. Authored settlements and locations will sit inside generated terrain; town entrances connect to surrounding wilderness without portal transitions. World size, landmass/ocean arrangement, streaming, fast travel and dungeon interior handling remain open. We are **discussing the world step by step**, not yet assigning a Codex implementation task.

## World design direction 2 — island geography (experimental)

**Preference, not final lock:** the director favors **Option A: islands and oceans**, and wants to experiment with that world structure. A large-continent hybrid (Option C) is less attractive partly because the director expects it would make **mounts necessary for overland travel**. Do not add mounts, boats or a fixed archipelago algorithm from this preference alone. **World decision #3 confirmed:** a **medium-to-large starting island (Option B)**, with enough room for early exploration and building without needing to sail. Exact size, sailing timing and world geography remain to be tested. **World decision #4 confirmed:** the handcrafted town is **inland but relatively near the coast (Option C)**; walking into wilderness and finding the sea should be possible without making the town itself coastal. **World decision #5 confirmed:** the **handcrafted town remains recognizable across generated worlds**, but its suitable inland-near-coast placement and surrounding landscape can vary with the seed (Option B). Integration/terrain-blending method is open. **Next design question:** how should environmental biomes and Metin2-style character/enemy level danger coexist across one open world?

## World decision 6 — consistent biome danger confirmed

**Confirmed:** comparable instances of the same biome across different islands should have a **recognizable, generally consistent baseline enemy difficulty** (director chose Option A). Metin2-inspired elite enemies, camps, bosses, and dungeons can provide **signposted exceptional challenges** without silently changing ordinary biome difficulty by island. No specific enemy levels, biome roster, scaling, or procedural implementation is approved. **World decision #7 confirmed:** start with **a safer beginner biome and one more dangerous biome on the same landmass**, enabling early homebuilding and meaningful exploration before sailing. Biome names and sizes are open. **World decision #8 chosen (delegated):** **guided randomness (C)**, predominantly Valheim-style **distance progression (A)**. Dangerous biomes generally become more frequent farther out, with some fair exceptions; ordinary enemies in the same biome do **not** scale in level just because an island is more distant. Exact probabilities and generator mechanics are open. **Next map/world question:** how should major handcrafted locations (ruins, NPC settlements, bosses, dungeon entrances) fit into generated islands? No Codex task is authorized.

## World decision 9 — landscape editing confirmed

**Confirmed:** Valheim-style outdoor ground editing (dig/lower, raise, flatten and reshape) is intended, including for home-building and landscaping. **Do not assume voxel tunneling/caves** from this decision. Generated landscape edits must ultimately integrate with **persistent saves and co-op world state**; exact terrain representation, limits and tools remain undecided. The director asked to **batch 5–10 high-impact map/world design questions** to speed decisions. This is still design/planning, **not** a Codex implementation assignment.

## World decisions 10–17 — director's batch (2026-11-14)

**Confirmed gameplay targets:** **finite large world (#10A)**, **surface-only terrain shaping rather than voxel tunneling (#11A)**, **protect essential towns/NPC sites/dungeon entrances (#12B)**, **freedom to build nearly anywhere else (#13A)**, **new characters appear in the starting town (#15A)**, **unlockable fast travel (#16B)**, and **renewable trees with generally finite individual ore deposits (#17A)**.

**Preferred experiment, not hard production commitment:** **procedurally assembled dungeons/ruins/other POIs (#14B)** are appealing to the director. Preserve the **authored recurring Map1-style starting town**; explore modular-authored components and generated layouts for other locations rather than forcing all landmarks to be random.

**High-risk intersections:** persistence of terrain edits and built structures, protected-site borders, stable identities for generated POIs, availability of ore in long-lived co-op worlds, and not trivializing sailing with fast travel. No specific tools/frameworks, sizes, protection radii, portal restrictions or regeneration formulas have been authorized; this is still world/building design, not a Codex task.

## Starting-region design reference

The director supplied a high-level **Map1-inspired starting-town sketch with two black-marked entry paths**. The town should be a safe, useful hub; players build outside it; the nearby wilderness should invite exploration; the drawn **hill marks a boundary**, not a committed gameplay landmark. **The two black marks are entrances, not dangerous biomes.** A **bottom-left area is a flexible potential NPC location** (mount-related only if needed; otherwise any suitable NPC). Detailed route roles and terrain geometry are open. See [12_STARTING_REGION.md](12_STARTING_REGION.md). **This is a design statement, not authorization to start a Codex scene task.**

## Current state

- **Available on GitHub:** `Prototype_Movement` scene and controller/camera, playtested and committed (`3feb669`). User liked WASD and orbit camera.
- **Reported local-only, uncommitted:** `Prototype_Combat` scene/scripts and edits to `docs/04_PROTOTYPE.md` and `docs/10_ROADMAP.md`. This is a **technical smoke test**, not an enjoyable combat prototype. Preserve it safely; never overwrite local work or the three unrelated `Assets/Editor` deletions.
- **Current brief:** [BRIEF_01_SHELTER.md](BRIEF_01_SHELTER.md). The first substantial playable outcome is **gather wood → build a tiny shelter → walk inside**. The brief is an implementation proposal subject to reality checks in Unity, not a mandate for polished tree physics or a production inventory.
- Older documentation may still say `combat next`; **this state note overrides the old sequencing**, not the mechanics or architecture decisions in the ledger.

## Working direction after the shelter

1. **B01 — First shelter:** basic resource interaction and usable snapped construction pieces, with emphasis on *placement feel*.
2. **Building iteration:** adjust placement, rotation, ghost feedback, and construction usability based on playtest. Consider stronger Valheim-like structural behavior only when it makes the experience better.
3. **Early persistence/authority risks:** keep player structures through reload and test relevant future co-op state ownership before piling on content. World-bound vs restricted hybrid *character* progression remains undecided.
4. **Combat/RPG connection:** eventually animate and test a real opponent, then integrate loot/blacksmith with the home loop. Do not lock all combat, gear, town and world scope in advance.
5. **First integrated world:** move toward a small explorable place with authored starting town (blacksmith; no building in town), building outside, meaningful encounters and free choices. A ~30-minute sample game is a **possible target**, not a deadline or locked scope.

## Not now

Full procedural world, comprehensive co-op, classes, guilds, ships, finished graphics, professions trees, large items/stats frameworks. Avoid accidental architecture choices that would make future co-op and persistent building difficult.

## Division of responsibility

- **Director (user):** owns the vision, gameplay priorities, and how playing *feels*.
- **Design planning (AI assistant):** scopes meaningful outcomes, identifies costly risks, and updates decisions from actual feedback; doesn't equate math tests with gameplay milestones.
- **Codex:** owns implementation and routine technical verification; works from one coherent brief, reports once, then stops.
- **Loop:** brief → implement and check technical correctness → one meaningful player session → keep/change/drop → update source of truth. Scope by dependencies, uncertainty and observable outcome, not arbitrary file counts or one tiny script per task.

## Local safety before starting B01

First inspect `git status`. Safely checkpoint the current local combat work on its own WIP branch or commit **without including unrelated deletions**. Since GitHub docs have advanced independently, fetch and reconcile deliberately; **never blindly pull/reset/checkout over uncommitted docs**. A remote GitHub documentation commit does **not** update the Windows Unity project until the local repository is synchronized.
