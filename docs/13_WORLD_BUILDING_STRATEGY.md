# World & building development strategy — first playable foundation

**Proposed:** 2026-11-14  
**Status:** **Longer-term planning proposal, not production architecture.** The director has separately approved the revised **B01 outdoor shelter brief** on 2026-11-14; B01 has **not** been launched, and later stages remain proposals. This document describes how to investigate the world/building foundation while honoring the confirmed game design. `docs/02_DECISIONS.md` remains authoritative for decisions.

## Experience we are trying to prove

The player enters a recognizable safe starting town, leaves through either of its two routes into an explorable landscape, **chooses a personal place to live**, changes the ground where useful, builds a shelter or home, and can return to that place later. Eventually friends inhabit and change the same world. Metin2-inspired combat, loot, levels, blacksmith services and authored/variable dungeons should enrich this foundation rather than replace it.

**Success is a desirable player experience**, not merely the existence of a Unity scene, generator, object-placement script, or debug counter. The director evaluates building/world feel; Codex verifies functionality and reports once.

## Decision-constrained direction

- **One continuous-feeling, finite main world;** islands/oceans are the preferred geography to **experiment with**, not yet a fixed topology.
- **Medium-to-large starting island** as an experience target, with a safer biome, a first more-dangerous biome and an **authored Map1-inspired starting town** placed inland near the coast. The town's two entrances remain access paths, not teleports.
- Town layout recognizable in different seeds; **its surroundings vary**. Important NPC/POI footprints protected from building and harmful terraforming.
- Players build **almost anywhere else**. **Surface terrain** can be lowered, raised and flattened (no requirement for voxel tunnels). Structural support should create readable limits **without killing creativity**.
- Player buildings, terrain edits and critical world changes must remain consistent across reloads and eventual co-op. Initial town spawn and bed-based later respawn are selected experiences.
- Raids are **explicitly deferred**, perhaps until co-op playtests. Procedural/variable POIs are appealing but do **not** need a dungeon generator in the first building milestone.

## Recommended development sequence: prove the risks in playable steps

The sequence below is a **working recommendation**. Proceed only when the prior experience and technical evidence justify the next step; do not issue a list of unrelated microtickets or attempt the entire world at once.

### Gate 0 — Preserve the real project and check terrain constraints

**Before new code:** Codex must inspect local Git state, safely checkpoint **existing uncommitted combat work** without including the unrelated three `Assets/Editor` deletions, and reconcile independently changed GitHub docs carefully. No blind pull/reset.

**Technical risk check:** Compare the smallest viable Unity terrain representation for **height/surface editing + collisions + buildings + saved deltas + procedural reuse**. A heightfield/Unity Terrain approach is an obvious **candidate**, not a preselected production solution. Confirm how protected town footprints and later multiplayer replication could fit, without implementing a giant network/save framework.

**Gate outcome:** A short evidence-backed note of chosen *prototype approach*, limitations and rollback options. This is not a separate hour-long fake gameplay milestone.

### Playable loop 1 — Choose a plot and build a real shelter

Use a **small, believable outdoor test region**, not a featureless platform and not the final island. Include modest uneven terrain, visual paths/outlines indicating an off-limits town location, and at least two appealing build spots. Reuse the known-good player controller.

Player walks into the landscape, chooses a site, **aims/rotates/snaps a small actual 3D-modelled wood kit** (floors/walls/open doorways/pitched roof/gables/posts/beams), enters the resulting shelter, then changes it by adding/removing pieces. **The player-built shelter cannot be mere gray cubes;** the outdoor terrain may still be placeholder art. See [B01 wood kit](14_BUILDING_KIT_B01.md). A clear ghost, grounded placement, meaningful snapping and understandable errors matter more than exact art.

**Test construction with plentiful/free temporary materials at first if gathering distracts from placement feel.** Add a small wood-gathering reason only when it helps answer the next gameplay question. This is now captured by the approved-but-unlaunched `BRIEF_01_SHELTER.md`; the director should experience enough activity to decide whether building is enjoyable.

**Director evaluates:** Does placement feel easy? Can an imaginative shape emerge? Is the world inviting enough that finding a plot matters?

### Playable loop 2 — Make the site yours, and keep it

On the same region, add **minimal surface terraforming** (flatten and limited raise/lower), test building on and near altered ground, introduce a **readable first support/stability rule** where it enriches construction, and **save/reload** the placed structure and modified terrain. A lightweight persistent world identifier and stable placement identities should be considered now; don't grow a full account/character framework.

Test protection: neither building nor earthworks should destroy the reserved town footprint. Test repeated save/load, removing a piece and loading again, and ground edits beneath structures.

**Director evaluates:** Does terraforming help creativity rather than create busywork? Does the home feel like a lasting part of this world?

### Co-op architecture checkpoint — Before we scale content

Run a narrow **two-player shared-world spike** once local placement/terrain edits and save/load exist: both participants see the same structure and ground change; join/rejoin observes saved state; simultaneous modifications don't silently diverge. Determine responsibility for world-edit authority and save ownership from that evidence. **No full multiplayer product, raids, guilds or party XP in this checkpoint.**

If co-op is initially infeasible, document the precise blockers and keep local world-state changes isolated from client-only input/visual code. Do not postpone thinking about this until after a sprawling content build.

### Playable loop 3 — Integrate authored town and generated landscape

Only after the home loop and its persistence boundaries are credible: generate a **small representative region with a few seeds**, not the entire large world. Insert a **simple authored town footprint**, two exits and road transitions into seed-varying terrain; preserve a near-coast inland position and **safe vs first-dangerous biome** distinction. Verify site selection/terrain blending, protected zones, repeatable generation, and that saved player modifications survive regeneration or streaming.

A full detailed village, blacksmith economy, finished coastline/ships, dozens of biomes and procedurally assembled dungeons are **not prerequisites** to validate this transition.

### First integrated experience — Return home in a living world

Extend the result into a coherent short session: start in town, walk into wilderness, gather a simple resource, choose a place, alter terrain and build a useful shelter, then save, leave and return. Give the player reasons to revisit the town and eventually introduce **animated/meaningful enemy encounters and RPG progression**, but only after the world/building loop has demonstrated value.

We do not define arbitrary playtime, map diameter or fixed script count as success criteria.

## Cross-cutting guardrails

| Risk | Early evidence needed | Avoid |
| --- | --- | --- |
| Terrain/structure interaction | Works on uneven and edited ground | Freezing building rules before feeling tests |
| Save/seed split | Edited ground, homes, harvested/altered objects survive reload | World generation erasing player changes |
| Town/POI protection | Footprints block destructive construction/terraforming | Enforcing protection in UI only |
| Co-op authority | Two players observe one authoritative world state | Deep single-local-player assumptions |
| Town meets procedural land | Multiple seeds show playable roads and natural transitions | One lucky manually fixed map disguised as a generator |
| Creative structural limits | Players build normal and unusual shapes with readable support feedback | Rigid rules imported without playtesting |

**Not now:** a full archipelago generator, shipping/sailing implementation, full dungeon assembly, item/stat engine, advanced NPC services, boss raids, mounts, comprehensive multiplayer or polished environments. Future scope is decided from playable evidence, not this list.

## Operating rule and next authorization

This document remains **strategy, not an executable ticket**. The director has approved **B01** separately in `BRIEF_01_SHELTER.md`; it is **not yet launched**. On actual execution, Codex must first reconcile and preserve the local project, then implement **one outcome with one acceptance scenario** from B01, run focused technical verification, and stop for the director's gameplay feedback. Later stages require separate prioritization.

Related: [current state](STATE.md), [design decisions](02_DECISIONS.md), [starting region](12_STARTING_REGION.md), [architecture guardrails](09_ARCHITECTURE_GUARDRAILS.md), [approved B01 brief](BRIEF_01_SHELTER.md).
