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
