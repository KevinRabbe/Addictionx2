# Architecture guardrails — decisions, risks and implementation timing

**Date:** 2026-11-13  
**State:** Architecture briefing only. No production architecture is committed by this file.

This document captures architectural concerns that could cause future rewrites, while keeping **Prototype 0.01 limited to movement, camera and controls**.

## Current preferences and decisions

| Subject | User direction | Status | Decision point |
| --- | --- | --- | --- |
| Single-player/co-op state | Co-op matters; shared world and distant party XP | **Confirmed intent; architecture open** | Before meaningful multiplayer gameplay |
| Character persistence across worlds | **Not unrestricted option A**. B = world-bound, or C = restricted/configurable hybrid | **A rejected; B/C undecided** | Before persistent character equipment/XP |
| Item / stat architecture | Separate stat model/definitions from item definitions and per-item runtime state | **Strong direction; interfaces unchosen** | Before inventory, loot and enhancement |
| Class architecture | Proper modular responsibilities, possible managers/classes; ask if deterministic | **Question; no pattern chosen** | Before class/skill implementation |
| World generation | Handcrafted/placed town embedded within generated world | **Chosen high-level direction** | Before full-world implementation |
| Building | Valheim-like building is an essential gameplay pillar | **Confirmed importance; exact mechanics open** | Prototype a basic build loop, then deeper building-system tests |
| First milestone | Graybox movement/camera/input | **Confirmed** | Now |

**Engineering process guardrail:** Before each core system becomes permanent, write down its responsibilities, owned state, dependencies, and save/network implications in a *short* note. Avoid both architectural guesswork and premature frameworks. The user wants us to think carefully because the project is ambitious, **not** to commit today to one manager/service/ECS pattern.

## New world-architecture requirement (2026-11-14): deformable terrain

**Confirmed gameplay direction:** outdoor terrain is editable by players (lower/dig, raise, flatten, reshape), Valheim-style. This has consequences for procedural generation, town/POI protection, construction placement/support, water/coast edges, persistence and multiplayer replication. In future prototypes, compare feasible terrain representation and serialization/authority options **before committing to a full-world implementation**. Persist edits separately from the seed and prevent regeneration from overwriting them.

**Not implied:** voxel caves, freeform undercuts and tunnels, unlimited depth, a specific Unity terrain API, global real-time terrain regeneration or fixed terraforming costs. These are not approved by the surface-editing decision.

## New world boundaries and POI direction (2026-11-14)

- **Finite generated world:** choose a finite extent, without locking a specific radius or mandatory loading implementation.
- **Editable surface terrain:** lower, flatten and raise height-based ground; **no requirement for full voxel underground tunnels or caves**.
- **Site protection:** building **and terrain editing** must recognize town, NPC, dungeon entrance and other essential-site exclusion/permissions boundaries. Do not treat town building restrictions as only a placement-UI concern.
- **Freely chosen building sites outside those limits:** construction should accommodate variable generated ground and player editing.
- **Experimental procedural POIs:** the director likes assembled/variable dungeon/ruin layouts. The **starting town remains authored**. POI identifiers, repeatable seeded assembly, navigation/gameplay checks, persistence and quest/boss semantic anchors matter before investing in procedural dungeon generation; no algorithm or content mix is yet selected.
- **Travel and resources:** progression-unlocked fast travel must be balanced against island exploration/sailing; renewable wood with mostly finite ore deposits requires planning for years-long shared saves without exhausting essential progression.
- **Initial character arrival:** start in the handcrafted town, distinct from any future respawn/rejoin behavior.

## Latest building / dungeon / co-op design boundaries (2026-11-14)

- **Support rules:** Valheim-like structural stability is a gameplay target, **tempered by deliberate creative freedom**. Prototype readable structural constraints rather than codifying Valheim formulas or enforcing untested rigid snapping. Support recalculation must tolerate later terrain edits, save/load and eventual multiplayer.
- **Dungeon state split:** discovered, persistent POIs should keep their once-generated layouts; explicitly repeatable dungeons may generate new layouts per run. Keep world-space entrance/POI identity separate from a run's transient layout/encounter state if this split becomes part of implementation. Actual instancing is not selected.
- **Fast travel:** progression may eventually relax restrictions; require evidence that it does not invalidate long-distance travel or item transport gameplay.
- **Respawn:** player-owned/assigned bed with starting-town fallback; handle invalidated beds in later save/co-op tests.
- **Raids:** **open question**, including existence and frequency. No auto-spawn raid mechanic may be presumed from the Valheim inspiration; if pursued, consider warning, frequency, absence/offline safety and whether structures take lasting damage.
- **Building permissions:** world setting for shared vs protected structures is **tentative**; don't freeze per-object ownership or permission infrastructure based solely on “I guess C”.

## 1. Networking and authoritative state

A co-op game should plan who has authority over **combat outcomes, loot creation, item ownership, building placement and saves**, even if networking arrives later. A **host/server-authoritative approach** is a candidate, not an approved framework. Do not write every eventual multiplayer mechanic assuming a single global local player; keep input, simulation and visual representation separate where it is cheap.

Do **not** force networking into the first capsule controller. Run a small **two-player movement/network spike** before large persistent multi-user systems. Network package, topology, dedicated servers, peer-hosted servers, limits and behavior while the host is offline are undecided.

## 2. Persistence and identity

The rejected option A meant **take one character and all its equipment/progression freely into unrelated worlds**. **User's reason:** a powerful transferred character in a fresh co-op world would immediately spoil the fun and organic progression for the people starting there. Safeguarding a group's experience is a primary design constraint, separate from code security or cheat prevention. The user currently prefers either:

**B — World-bound:** player creates/maintains a character within a particular world's saved progress.

**C — Restricted hybrid:** some transfer or cross-world character identity is supported, but world owners can impose settings/limitations.

These are choices, not implementation instructions. Save boundaries should eventually distinguish **world identity, player identity, character identity, item identity, object identity**, and potentially shared guild/party membership. Persist rolled loot **values**, building placements and terrain/player changes rather than assuming generation alone will recreate them. Choose save migration/versioning when introducing persistent saves. Tests should include saving, quitting, loading and keeping inventories, objects and world changes consistent.

No need to implement saves in Prototype 0.01.

## 3. Stat engine and items — separate meanings from instances

A useful **candidate design**:

```text
ItemDefinition (shared template, e.g. iron_sword)
       | uses
       +---- Weapon/Equipment category rules
       +---- Base stats (from StatDefinition identities)
       +---- Allowed regular bonus pool (e.g. Sword)
       +---- Optional special roll table (DSS/FKS only where defined)
       |
ItemInstance (specific sword)
       +---- Unique item ID
       +---- ItemDefinition ID
       +---- Enhancement level
       +---- Rolled special values, if any
       +---- Rolled regular bonuses
       +---- Other mutable condition data, if later needed

StatDefinition / BonusDefinition
       +---- Stable stat ID / label
       +---- Units and semantics (flat, percent, etc.)
       +---- Applicable categories and combination rules
       +---- Calculation / stacking semantics

StatCalculator (pure/testable math)
       +---- Character/base/item/bonus/buff context
       +---- Produces derived combat stats
```

Data-driven templates (e.g. Unity ScriptableObjects) can be convenient for shared definitions; **runtime item instances should be persistable plain data**, not mutable changes to shared definition assets.

Examples to protect:
- All swords can roll the **regular Orc-damage bonus**, whether mundane or rare.
- A selected individual special weapon can have **additional DSS/FKS-like rules** without forcing that roll system onto every sword.
- Bonuses can use item-specific distributions/ratios; no hardcoded global table that forces everything to roll alike.

No stat formula, bonus stacking order, class bonus multiplier or specific data class is approved yet.

## 4. Class system and determinism — different concerns

**Class composition vs “God Manager”:** The user's question about managers is reasonable, but **one giant PlayerManager/ClassManager that owns movement, progression, mining, construction, UI and combat** would produce exactly the entanglement we're trying to avoid. A candidate structure is a data-driven **ClassDefinition** for combat eligibility, separate **CharacterState / Progression**, **Combat/Ability execution**, **Equipment**, and **Survival/Gathering/Building** components. Use managers/services for shared coordination only where clearly needed. Decide exact class/weapon skill ownership after testing combat, not via premature abstraction.

**Determinism has at least three meanings:**
1. **Repeatable combat math** given the same inputs and bonuses — very useful for tests and debugging.
2. **Seeded procedural generation and loot RNG** — useful for reproducing worlds and item drops; serialize final random item rolls and changing world state.
3. **Network-synchronized lockstep deterministic simulation/physics** — much harder and **not automatically guaranteed by Unity physics**, especially cross-platform.

A host/server authority model can support co-op without insisting that every physics step simulate identically on all machines. Keep simulation code testable; decide whether any fully deterministic simulation is needed after networking experiments.

## 5. World model: hand-placed landmark, generated surroundings

**High-level selected direction:** We design/place the Map1-inspired starting town as an authored landmark/scene, then generate the wider world around it.

Potential later considerations:
- Reserve a suitable zone for the town; terrain height blending, collision, landscape seams, roads and biome integration.
- The town's protection/build restrictions must persist independently of procedural terrain.
- Procedural generation should be **seeded/reproducible**, with important player/world modifications saved.
- Player buildings and destroyed/harvested objects must survive reloads. Don't regenerate over them.
- Dungeons, unique boss arenas, major lore locations and other hand-placed points can be embedded using the same approach; whether and how to do this is undecided.

These are design/engineering risks to **test in a small world-generation spike**, not instructions to build a full procedural map immediately.

## 6. Building needs its own prototype

The player should be able to genuinely live in a constructed home; Valheim-style building is **a core pillar**, not a superficial place-one-cube feature.

After a minimal build/place/destroy interaction, evaluate in small tests:
- Placement ghosts, snapping, rotation and piece connections.
- Structural support and stability.
- Terrain, roofs/weather, repair or upgrading pieces (candidate features).
- Building permission boundaries (town vs player land), multi-person building/ownership (candidate policies).
- Large player bases: performance, save/load, future network synchronization.

The **importance** of this system is decided. The **exact Valheim mechanics** are not yet automatically adopted.

## 7. Sequence that limits rewrites without overplanning

**Now:** movement, camera and controls. Keep input code separate from movement and camera tuning.

**Then:** minimal combat; test where class abilities and weapon movesets belong.

**Before inventory/loot:** specify item definitions, stat semantics, instance identifiers, and test saved rolls.

**Before persistent progression:** decide world-bound (B) versus configurable hybrid (C) save model.

**Before large world generation:** make a mini generated terrain with the authored town and verify it can persist modifications.

**Before heavy co-op content:** networked two-capsule experiment, decide authority and state ownership.

**Before extensive building content:** basic placing, then a deeper Valheim-like building feel/structural experiment.

In every stage, **one job, one test, one reviewed change**. Never expand prototype 0.01 into a universal framework simply because future complexity is expected.
