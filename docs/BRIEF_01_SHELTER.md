# BRIEF 01 — Gather wood, build a tiny shelter

**Status:** first building-first playable brief, proposed 2026-11-14. **Priority:** feel of placing/connecting parts and making a recognizable shelter; gathering is there to give building a simple reason, not to launch a tree-simulation project.

**Read:** `AGENTS.md`, `docs/STATE.md`, `docs/02_DECISIONS.md`, and relevant building guidance in `docs/09_ARCHITECTURE_GUARDRAILS.md`. Inspect existing code and local `git status` first; respect uncommitted combat work and unrelated `Assets/Editor` deletions.

## What the player does

Walk through a small outdoor graybox area, chop or harvest wood, use it to **construct a tiny shelter from connected pieces**, and walk inside. The playable outcome must be more than a button that spawns cubes.

## Why it matters

**Building and living in the world is the foundation** of Addiction². We're testing whether aiming, rotating, snapping, placing, removing and arranging pieces encourages the player to keep constructing. A brief resource loop gives construction context.

## Playable acceptance scenario

1. **Scene:** Create a separate `Prototype_Building` test scene, preserving `Prototype_Movement`, `Prototype_Combat` and unrelated work. Reuse working WASD and orbit camera.
2. **Gather:** A few obvious harvestable trees/wood sources. The player can hit/interact repeatedly, see a clear reaction and obtain wood. A tree may topple with a **simple scripted visual**; do not implement physically simulated falling trees or realistic chopping. Wood is shown with a simple counter; sources can be reset/replenished for repeat play.
3. **Build:** A build-mode toggle, translucent piece preview where aimed, clear valid/invalid feedback, controlled rotation, and satisfying **edge snapping** with simple grid fallback. Adjustable snap/grid values in Inspector. The system should prevent obviously invalid floating/overlapping placement where feasible without a structural-simulation framework.
4. **Piece kit:** floor, wall, doorway wall and roof using temporary shapes. Player can select pieces, see their wood cost, place enough to form a recognizable shelter, and walk through the doorway and stand inside. Basic collision works.
5. **Undo:** Remove a placed piece and refund its wood cost; no deleting unrelated world geometry.
6. **Outcome:** User can finish a tiny shelter and immediately choose to revise/extend it. The scene is reusable for several short building attempts.

## Implementation guidance

- **Prioritize build placement feel over tree effects**. Do not let animated tree-falling, advanced UI, asset imports, or tests dominate the effort.
- Resource ownership, construction pieces and preview/placement should have understandable boundaries, but no global gameplay framework, generic inventory, item stat engine or finished assets.
- Preserve the existing Input System; inspect how left click and cursor recapture interact with the locally added combat input before assigning build controls. Make controls visible in a small help legend.
- Use a few reusable piece definitions with clear snap points; avoid one-off hardcoding each piece in a giant manager. No decision about the final Valheim structure system is being made here.
- Aim for the **complete shelter loop in one implementation assignment**. Codex can make and test internal substeps independently without repeatedly asking the user to verify individual scripts.
- If a serious technical blocker prevents the whole experience, stop after reporting the obstacle and a playable subset; do not spend an hour retrying the same Unity command.

## Explicitly deferred

Structural integrity/support, damage/decay/repair, realistic tree physics, detailed axe animations, crafting menus, weather/food, persistent save/load, multiplayer, world generation, combat, classes, levels, loot, blacksmith, polish.

## Verification / finish line

Codex: one consolidated Unity compile/scene/Play Mode pass where accessible; automatic correctness checks of wood cost/refund, placement validity and snap behavior when practical. **Do not ask the user to validate arithmetic**. Avoid opening Unity batch mode on the same open project. Check that the original movement scene is preserved. Report what works and what could not be verified, list changed files and git status, then **STOP**.

The director plays and evaluates three things:
1. Does placing and snapping pieces feel precise and pleasant, or fiddly?
2. After finishing the shelter, do you want to keep building? What stopped you?
3. Is collecting wood pleasant context for construction, or does it interrupt the fun?

Review/commit the accepted result according to the current Git workflow; never bundle unrelated local changes.
