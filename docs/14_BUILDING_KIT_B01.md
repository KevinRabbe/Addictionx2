# B01 prototype wood building kit — playable 3D asset specification

**Recorded:** 2026-11-14  
**Status:** **Director-approved visual-quality requirement and starting kit direction for B01.** The dimensions and mesh breakdown below are **prototype targets to validate in Unity**, not final production dimensions or an art-style lock.  
**Implementation:** not started. This specification belongs to [B01's approved playable brief](BRIEF_01_SHELTER.md), not a separate asset-polishing project.

## Purpose

**B01 must use actual, recognizable low-poly 3D building models, not primitive-cube grayboxes used as final build pieces.** A grayboxed outdoor environment is fine. The player-built shelter should visually read as a small *wooden home* from both outside and inside: wooden plank floors/walls, framing, visibly pitched roof and useful pillars/beams. The models should be interesting enough that choosing a building site and inventing a house form is a genuine gameplay test.

**Art target:** original, simple, grounded medieval / stylized timber construction. Inspiration may come from the *practical categories* of Valheim's beginner wood kit; do **not** copy any Valheim models, meshes, UVs, textures, proportions as intellectual property, screenshots or game assets. No final texture polish, sculpt detail, weathering, or destruction-state assets. A few flat wood/roof material variations and real low-poly geometry suffice.

## Minimum kit — ten functional build categories

Suggested sizing convention for the **prototype only**: **1 Unity unit = 1 meter**; full modular cell **2 m**, half cell **1 m**. Final sizes and openings are subject to comparison against the **existing player controller dimensions**. Mesh thickness, trims and overhangs should be consistent and should not create collisions that block ordinary building.

| ID / working model name | Prototype target size / shape | What it lets the player do | Priority |
| --- | --- | --- | --- |
| `Wood_Floor_2x2` | 2 × 2 m horizontal plank floor, convincing thickness | Main floor/foundation platform | Required |
| `Wood_Floor_1x1` | 1 × 1 m plank floor | Half-scale floor variation / creative offsets | Required |
| `Wood_Wall_2x2` | 2 m wide × 2 m tall plank wall with framing | Full-height shelter envelope | Required |
| `Wood_Wall_2x1` | 2 m wide × 1 m tall half-height wall | Short partitions and half-height construction | Required |
| `Wood_Doorway_2x2` | 2 × 2 m wall with believable unobstructed doorway | Entry you can actually walk through | Required |
| `Wood_RoofSlope_45` | 2 m longitudinal module, 2 m horizontal run, 45° rise; visible roof thickness | Real pitched roof with a matching eave/ridge | Required |
| `Wood_RidgeCap_2m` | 2 m long fitted ridge cap/trim | Finish roof apex without a visual hole | Required |
| `Wood_GableEnd` | Triangular roof-end closure matched to two opposing 45° slopes; prototype may use a 4 m wide full gable or modular mirrored 2 m halves | Closes the triangular ends of a roof | Required |
| `Wood_Post_2m` | 2 m high solid timber post, with visible end treatment | Columns, corners, supports, visual variation | Required |
| `Wood_Beam_2m` | 2 m horizontal timber beam | Structural-looking frames, railings and flexible creative details | Required |

**Clarifications:** "Required" means the build kit must let the player place and use that category in B01. Mirrored/end variants may legitimately take more than ten mesh objects, but no giant art catalog is expected. **The roof and gable must be tested as a matched system**, not modeled independently and left to intersect in ugly ways. The `Wood_Doorway_2x2` is an **opening**; an animated functional door is not required.

**Future optional kit (NOT part of B01):** steps/stairs, dedicated doors, corner roof variants, half post/beam, windows, different roof pitches, ramps, decorative timber styles. Add only if early player testing identifies a necessary piece, not as blanket scope creep.

## Modeling and handoff requirements

1. **Make actual reusable 3D mesh assets**, preferably authored in **Blender** (Blender scripting or a connected Blender tool is acceptable if available). Export meshes to a Unity-supported asset format such as FBX and keep editable source files under version control where reasonable. Do not substitute Unity cube stacks and call the kit finished. Validate the available local Blender/Unity integration instead of assuming any connector works.
2. Ensure **consistent units, axes and origins/pivots** before import. Mesh appearance should visibly include boards/planks, posts/bracing, believable thickness, roof pitch/eaves and a coherent wood palette. Stylization is allowed; no detailed UV/photo textures needed.
3. Convert models to **reusable Unity prefabs** with renderers, appropriately simple colliders and **predictable snap anchors** (corners/edges; compatible roof-wall/ridge anchors). A piece's snap/placement data must not be encoded only in its decorative mesh geometry.
4. Make the kit useful in both directions: visible outside, and **sensible walls/roof interior** without see-through surfaces or a camera colliding with oversized roof decorations.
5. **Demonstrate the assembled house:** e.g., a 4 × 4 m floor (four full floor tiles), at least one doorway, surrounding walls, roof slopes, closed gables and ridge cap. Place several pieces freely beyond this example and test extensions/creative arrangements. **The house blueprint is a test, not a prescribed player layout.**
6. Confirm dimensions and collision with the **existing playable character**. Door must be walkable without crouching unless the actual controller supports and calls for that; roofing and support placement must not prevent a useful interior.
7. Ensure the Unity project imports cleanly and prefabs are actually selectable/usable by B01's construction UI. Check scale, normals, no missing meshes/materials, visual joins, colliders and snapping in Play Mode. Preserve Unity `.meta` files and Blender/source assets as appropriate.

## Visual acceptance checks

- From a typical third-person distance, a small house **looks like a wooden house**, with wood framing and a recognizably sloped roof; it should not read as stacked untextured blocks.
- The character can **walk through the doorway and stand inside**, with roof and gable assembled correctly.
- The player can **snap a roof to walls and join roof panels**, rather than placing disconnected wedges by eye.
- Floor/half-floor, full/half-wall, posts and beams provide at least some **creative alternatives** for enclosure or framing.
- Pieces have coherent scale, material language and silhouette. A **simple prototype-quality model is enough**; final textures, elaborate detail and weathering are out of scope.

## Process and limits

- **First verify the local Unity/Git state**; protect reported uncommitted `Prototype_Combat` files, locally changed docs and unrelated `Assets/Editor` deletions, as required in [B01](BRIEF_01_SHELTER.md). GitHub docs are not automatically present in the local project.
- Treat the complete **3D kit + functional snapping/building + walkable shelter** as one integrated B01 player outcome. Art may be modeled first for fit testing, but do **not** ask for a separate user playtest for a nonplayable asset-only checkpoint.
- If Blender or model-export tooling is unavailable, **report the limitation and propose an actionable way forward**, rather than silently replacing the required kit with abstract grayboxes or claiming it has been delivered.
- Deferred: polished textures/materials, animations, destruction LODs, resource economy, advanced roof library, final building structural support, persistence/co-op, terrain sculpting, world generation, raid mechanics.

The primary director playtest remains: *Can I make a home that looks convincing enough to care about, and do the piece shapes/snapping invite me to build more?*
