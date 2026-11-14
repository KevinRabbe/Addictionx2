# BRIEF 01 — Find a place and build a shelter

**Revised:** 2026-11-14  
**Status:** **Director-approved scope for the next Codex implementation assignment (2026-11-14); implementation NOT yet launched.** Begin with the local Git safety/reconciliation gate below before editing Unity gameplay files.  
**Primary question:** *Does finding a place in the world and freely building a small shelter feel intuitive, inviting, and creatively satisfying?*

Related: [B01 prototype wood 3D kit](14_BUILDING_KIT_B01.md) (**required part of this brief**), [automated verification/handoff gates](15_B01_VERIFICATION_GATES.md) (**required before the director playtests**), [world/building strategy](13_WORLD_BUILDING_STRATEGY.md), [current state](STATE.md), [confirmed decisions](02_DECISIONS.md).

## Player-facing outcome — one complete playable experience

Use the familiar third-person movement/camera to explore a small **outdoor landscape**, choose between **at least two plausibly interesting build sites**, construct a recognizable **small shelter**, **walk inside**, and then **modify or extend it** without restarting the scene.

The environment should feel like the edge of a place one could live in, not a featureless test platform or a final-size world. **This is not the entire island, completed starting village, or procedural generator.**

## Playable acceptance scenario

1. **Enter a dedicated `Prototype_Building` scene** using the working movement and orbit camera; preserve the existing movement/combat scenes. A modest outdoor graybox area has gentle slopes, some visual terrain variation, a clear boundary representing future protected town land, and two suitable but different build sites. Use placeholder trees/rocks for atmosphere if helpful, **not** a harvesting system.
2. **Pick a location** by walking there. Construction is unavailable on the visually indicated protected-town test footprint and available outside it on reasonable terrain. The restriction is enforced by placement rules, not just preview color.
3. **Use an actual prototype-quality 3D wood building kit, not gray cube building blocks.** Create/import low-poly **Blender-authored (or equivalent actual 3D mesh)** modular pieces as reusable Unity prefabs with useful snap anchors/colliders. The B01 kit must provide **full/half floor, full/half wooden wall, doorway wall, sloped roof, roof ridge cap, gable end, vertical post and horizontal beam**, with **verified correct silhouettes and unique piece identities/selection mappings** (no mislabeled or accidentally duplicated pieces). Exact provisional sizing/visual/technical criteria are in [14_BUILDING_KIT_B01.md](14_BUILDING_KIT_B01.md). Check fit against the existing character controller. The outdoor scene may stay grayboxed.
4. **Enter build mode** with accessible on-screen control hints. Select the supplied 3D wood pieces. Piece orientation and size must make a walkable shelter possible with the existing character controller.
5. **Preview and place** pieces with an understandable placement ghost, clear valid/invalid feedback, useful adjacent/edge snapping, and controlled rotation. Pieces should connect predictably on modest uneven ground. Reject obvious penetrations, isolated floating pieces and placement inside the protected footprint; do **not** implement a production structural-physics simulation.
6. **Finish and inhabit** a little house or shelter with a real doorway and roof; walk inside and around it. Then **remove/reposition/extend** pieces using a legible edit interaction, without affecting unrelated landscape geometry.
7. **Repeat immediately**: the player can start over or keep experimenting without relaunching the editor. The build experience is usable for several short creative attempts.

**First-pass materials:** use **unlimited/free materials** (or a clearly identified sandbox toggle defaulted on) so that the session tests **building feel rather than wood harvesting**. This is a prototype convenience, not a decision about the final economy. Costs, wood gathering and crafting are follow-up questions.

## Acceptance quality bar

- The player can make a **recognizable enclosed timber shelter using actual 3D model shapes**, walk inside it, and choose to alter the structure. Roof slopes and gables must meet coherently.
- Aiming, snapping and rotation should make common connections easy. Invalid placement should explain itself clearly enough to avoid guesswork.
- At least **two outdoor building spots** invite different arrangements; the ground should not look like a flat grid disguised as wilderness.
- The protected-town test area cannot be built upon, while ordinary non-protected ground can.
- All controls needed to finish the exercise are discoverable within the scene.
- **B01 cannot be marked complete with cube-built placeholder houses, meshless prefabs or a code-only snapping demo**. Prototype 3D timber/roof geometry must be present and playable; final art polish is not required.

## Engineering guidance and boundaries

**Read first:** `AGENTS.md`, `docs/STATE.md`, `docs/02_DECISIONS.md`, `docs/09_ARCHITECTURE_GUARDRAILS.md`, and the related strategy. Inspect the actual project, packages and local source **before** making implementation decisions.

**Mandatory local safety gate:** inspect `git status`, then safely checkpoint the **reported uncommitted Prototype_Combat scene/scripts and locally edited docs**, taking care **not to stage, discard or alter the three unrelated `Assets/Editor` deletions**. GitHub documentation changed independently; fetch/reconcile carefully. **Never blindly reset, checkout or pull over local uncommitted changes.** If you cannot safely reconcile them, report the precise blocker and stop.

**Short technical feasibility check, folded into the assignment:** choose a **prototype** terrain approach consistent with later **surface flatten/raise/lower**, collision and saved terrain modifications. Heightfield/Unity Terrain may be a candidate, but neither a terrain framework nor a procedural world engine is selected by this brief. Record important constraints in a short note.

- Reuse existing Input System and controller where practical; resolve any local combat/build input conflict without rewriting combat.
- Separate basic piece definitions, placed-instance data/identities, placement/validation rules and input/preview enough that subsequent saving, terrain editing and co-op tests can build on them. **Do not** create a large general-purpose manager/inventory/networking framework.
- Favor clear snap points and alignment over complex physics. Use real 3D piece meshes with a coherent wood visual language and roof/eave shapes, as specified in the B01 kit. Expose basic rotation/snap adjustments for playtesting only where useful.
- Verify the **local Blender/3D modeling and export route** (e.g., Blender → FBX → Unity) rather than assuming it is connected. Keep practical editable source files and imported Unity prefabs. If actual 3D models cannot be produced/imported, report that blocker instead of silently substituting gray cube pieces.
- Implement lightweight local construction removal; do not alter source assets or other players' world objects (not yet implemented).
- Preserve the original project/scenes. `BRIEF_01` does **not** authorize an authored town, procedural islands, terrain sculpting tools, world saves, co-op, full structural collapse, harvesting/wood costs, advanced NPCs, raids, bosses, combat overhaul or polished art.
- **Scope is the complete playable shelter experience, not one script per ticket.** Codex should handle connected internal tasks without repeatedly asking the director to check technical plumbing.

## Verification and stop condition

**Codex owns technical correctness:** follow [B01 verification gates G0–G5](15_B01_VERIFICATION_GATES.md): protect local work, validate the actual 3D mesh/prefab kit **including the shape-to-name mapping, duplicate detection and menu-to-instantiated-model check**, exercise snapping/placement rules in EditMode, run an automated full shelter scenario in Play Mode when tooling permits, and confirm project/scene integrity. Include truthful PASS/FAIL/BLOCKED evidence. One focused verification run with at most one actionable correction/retry, not an indefinite testing marathon. Do not invoke headless Unity against an already-open project; do not repeatedly rerun the same blocked test. If verification is blocked, report what was attempted and why, once.

**Director owns gameplay judgment:** one meaningful session assessing:

1. *Which site did I want to build on, and why?*
2. *Did snapping/rotation/removal feel natural enough that I wanted to build more?*
3. *Could I create something of my own, or did the rules fight me?*

When the scope is implemented or a genuine blocker is found, deliver **one concise final report**: playable outcome, changed files, verification evidence/limitations, remaining issues, and exact Git status. **Then stop.** Do not keep working while waiting for a human playtest.

## Next stage — explicitly outside this brief

After evaluating this experience: small-scale ground flatten/raising, understandable structural support constraints, saving/reloading buildings and terrain, then an early two-person world-state checkpoint. **Do not implement these preemptively.**
