# B01 — Automated verification and handoff gates

**Prepared:** 2026-11-14  
**Status:** Approved B01 implementation's **verification plan**, not evidence that any implementation/tests ran. Do not create a separate multi-day testing project. Fold these focused checks into B01 and hand the player one complete, verified experience.  
**Scope:** [B01 playable brief](BRIEF_01_SHELTER.md) and [actual 3D wood kit](14_BUILDING_KIT_B01.md).

## Principle: Codex checks correctness; the director checks feel

Automated and editor-driven checks can prove that meshes import, piece placement obeys rules, snapping coordinates match, and a constructed shelter can be occupied. They **cannot prove** that building feels good, the models are aesthetically satisfying, or the interaction encourages creativity. The latter needs a **single meaningful director playtest after the technical handoff**.

For every gate distinguish **PASS**, **FAIL**, **BLOCKED** (tool/Unity/environment prevents checking), and **NOT RUN**. Include specific evidence (test name/assertions, log or screenshot path, scene/version, relevant error). **Never call unexecuted or simulated tests passed.** If a gate is blocked, mark it explicitly rather than transferring routine technical verification onto the director.

## Gate 0 — Preserve local work and establish real tools (hard prerequisite)

- Inspect actual local Git changes, branch and Unity project; preserve the reported **uncommitted combat scene/scripts and modified docs** separately. **Do not include or disturb the unrelated three `Assets/Editor` deletions**. Fetch/reconcile GitHub changes without resetting or overwriting local work.
- Confirm Unity Editor version/project can be opened, whether Unity is **already open**, and whether Blender/model-export tools and Unity test/edit automation are truly available. **Never run batch-mode Unity on the same concurrently open project.**
- Compare the scope to the accepted brief; isolate B01 to its own scene/assets and non-destructive modular scripts.
- **Fail/stop** if a safe local checkpoint/reconciliation cannot be achieved. Report the exact blocker and do not modify gameplay.

## Gate 1 — Actual 3D asset/prefab validity (hard prerequisite to gameplay handoff)

Use Blender's data inspection/export checks **if Blender can run**, and Unity editor asset/prefab checks after import:

1. All **ten required B01 functional categories** exist as actual modeled 3D geometry and **selectable Unity prefabs**: full/half floor, full/half wall, doorway, pitched roof, ridge, gable, vertical post and horizontal beam.
2. Each prefab has a nonempty, visible mesh with reasonable scale/orientation, a valid renderer/material reference and appropriate colliders; no broken mesh refs. Geometry should read as **timber planks/framing, sloped roofing and posts**, not simple gray cube facsimiles.
3. Normal directions, rotation/pivots, colliders and snap anchor transforms are valid; the 2 m/1 m **prototype** modules interoperate. Size and doorway clearance must be compared against the **actual controller** rather than assuming a default capsule size.
4. Check roof slope + ridge + gable **as one assembly**. Intersections, excessive gaps and obvious overhang/collider errors need inspection in the Unity scene, not just a prefab existence test.
5. Where editor screenshots/camera inspection are possible, capture at least **exterior, roof/gable connection and interior/doorway** views for self-review; note if no rendered scene could be observed.

**Gate fails** if the house is composed only of abstract cubes, any essential category is missing/unselectable, prefabs import broken, or the roof/door geometry does not permit a usable shelter. A screenshot/render assessment is an additional check, **not a substitute for importing and placing prefabs**.

## Gate 2 — Placement rules and snap math (Unity EditMode/unit tests when feasible)

Create a small focused test fixture using simple test pieces/anchors where appropriate, and the **real B01 prefab data** where relevant:

| Test | Measurable outcome |
| --- | --- |
| Full + half module snapping | 2 m/1 m floor and wall modules align at expected edges/corners after rotation; anchor-to-anchor transforms agree within a small documented prototype tolerance. |
| Rotation | Typical quarter-turn rotations preserve anchor alignment; adjacent pieces don't drift or flip unexpectedly. Test at least two rotations and both full/half modules. |
| Roof attachment | Roof-to-wall, two roof slopes, ridge and gable anchors form expected connections and orientation for one standard cabin assembly. |
| Valid placement | Supported piece in unprotected permitted land is accepted; no mysterious rejection due to decorative mesh colliders. |
| Invalid placement | Overlapping existing solid pieces, obviously floating unsupported pieces, and protected-town proxy placement are rejected by **authoritative validation**, not only ghost color. |
| Boundary handling | Build-zone edges and just-outside positions behave consistently and cannot be bypassed with a rotated/partially crossing piece. |
| Removal | Targeted removal deletes the intended placed instance, not terrain, unrelated original scene objects or a neighboring piece. |
| Preview agreement | Where code allows, the same validation logic drives preview/feedback and final placement: an 'invalid' preview must not successfully place. |

**Don't bake guessed dimensions or tolerances into global rules.** Calibrate once from the imported meshes/controller and document test-specific numerical values. If an automated input path is impractical, isolate the underlying place/snap/validate functions for EditMode tests **without claiming the real UI was tested**.

## Gate 3 — Runtime Play Mode / full automated cabin scenario (highest-value gate)

When Unity Play Mode automation is available, create a focused test that loads **`Prototype_Building`** and exercises a whole gameplay sequence. Drive the actual placement APIs and, **where tooling supports it**, UI/input pathways. **If UI is not driven, state that the scenario checks underlying gameplay logic, not real controls.**

1. Verify scene starts with player/controller, active camera, ground collision, build kit registered in selection interface and **two distinct reasonable outdoor building spots**.
2. Build a small **4 × 4 m example** using floor modules, walls including a doorway, opposing roof slopes, compatible gables and ridge (and place at least one post and beam). Use pieces from the actual 3D kit.
3. Check the placed assembly has sensible geometry/placement state and colliders; character-sized capsule or the real movement controller can **enter the doorway, move inside, and stand under the roof**, without collision with an invisible wall.
4. Put a piece in the reserved town footprint: **reject**. Put comparable pieces in both normal outdoor build spots: **accept**.
5. Remove a chosen wall/roof/floor and replace it; verify the correct object count/state and no dangling ghost/collider. Repeat a brief place/remove cycle to spot duplicated previews, ghost colliders and exceptions.
6. Confirm the built shelter remains in the playable session after changing build piece and walking away/back; **save/reload is explicitly not a B01 requirement**.
7. Run focused Console checks for relevant exceptions or repeat errors. Avoid endless retries: one pass and, if a specific actionable issue emerges, one targeted corrective pass.

**Gate fails** if a real-kit cabin cannot be assembled through the build system or entered in the live scene, validation fails, a prior scene is broken, or Play Mode throws blocking errors. Mark true Play Mode execution **BLOCKED** if tools don't allow it; do not claim equivalent evidence from static code review.

## Gate 4 — Non-destructive project integrity and buildability

- Unity C# scripts compile/import without blocking errors; inspect the relevant Console/test output where accessible. Check no essential asset references/Unity `.meta` files are missing.
- **`Prototype_Movement` remains intact**; preserve **`Prototype_Combat` local WIP** and unrelated changes. Verify source diff and Git status. Do not run a broad repo cleanup that deletes user work.
- A representative scene opens and can enter Play Mode when tools permit; original scene still loads. Test scene must use actual imported kit and intended existing controller/input conventions.
- No surprise dependencies on networking, a completed island generator, item inventory, resource harvesting or production structural physics. A minimum small note may document the prototype terrain choice and later height editing compatibility.

## Gate 5 — Evidence-based handoff (required before asking director to test)

Codex's **single final report** should contain:

| Gate | State | Evidence | What remains unverified |
| --- | --- | --- | --- |
| G0 workspace safety | PASS / FAIL / BLOCKED | Git status, checkpoint description | ... |
| G1 3D kit and import | PASS / FAIL / BLOCKED | Prefab names, asset validation, rendered views if available | ... |
| G2 placement/snap tests | PASS / FAIL / BLOCKED | Test count/assertion names, failures | ... |
| G3 Play Mode shelter scenario | PASS / FAIL / BLOCKED | Scene, scenario/test result and relevant logs | ... |
| G4 project integrity | PASS / FAIL / BLOCKED | Compile/editor status, diff summary | ... |

List **changed files**, exact current **Git state**, actual tests executed (not promised), any blockers and one **director playtest scenario**. If critical gates fail or cannot be executed, do **not claim “fully tested / ready”**; stop with the specific blocker and a limited, accurate report. Do not repeatedly ask the director to test basic physics, asset import, math, scene setup or compiler errors.

### The one director playtest, after successful technical gates

Explore both sites, choose one, build an unconventional small wooden house using the real 3D kit, walk inside, then change and extend it. The director judges **aesthetics/readability, snapping/rotation feel, building freedom, and whether they want to build more**. Automated checks cannot decide this for them.

## Explicitly outside B01 test gates

**Do not implement merely to test:** real ground digging/flattening, production structural collapse, resource economy, combat, save/load, two-player network replication, raids, full islands, town NPCs or procedural dungeon generation. These need separate later milestones.

**Run discipline:** prefer a few high-value automated tests over a large testing framework. Never spend an hour repeatedly retrying the same blocked Editor/Blender operation. When the deliverable is working, verified as far as tools permit, and evidence is recorded, **stop**.
