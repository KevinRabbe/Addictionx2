# Instructions for Codex / AI contributors — Addiction²

## Mandatory first steps in every new task/session

1. **Read docs/STATE.md FIRST** for the current milestone, then `docs/02_DECISIONS.md` for authoritative game-design decisions, and the **current brief** (initially `docs/BRIEF_01_SHELTER.md`). Consult `README.md` and `docs/01_VISION.md` for product direction, and `docs/11_PLAYABLE_WORKFLOW.md` for workflow. Avoid loading the entire documentation archive every task.
2. Read the relevant sections of docs/03_DESIGN_NOTEBOOK.md and docs/05_DEVELOPMENT.md. Consult docs/08_CONVERSATION_COVERAGE_AUDIT.md when reconstructing context, making a design change, or checking if earlier user corrections are captured. Before introducing inventory, class logic, world generation, saving or network state, read docs/09_ARCHITECTURE_GUARDRAILS.md.
3. Inspect the current repository and Unity project state before editing. Do not guess what has already been implemented.
4. State **one meaningful player-facing outcome** and a concrete playable acceptance scenario. You may implement several tightly related components within that slice (input, character behavior, enemy response, temporary art/animation, UI) **without returning to the user after every technical substep**. Avoid unrelated features and framework-building.
5. Verify ordinary correctness via a focused automatic Unity build/Play Mode/test pass, and describe what could not be checked. **Request one human playtest only for a meaningful playable outcome**, not for every HP subtraction, input event, dummy flash or technical checkpoint. The human decides whether actual gameplay feels good.
6. Update docs/02_DECISIONS.md when a real decision is made, and docs/04_PROTOTYPE.md or docs/05_DEVELOPMENT.md when implementation or tooling state changes.
7. Preserve working changes and keep the project playable. Do not add unrelated systems.

## Design authority and boundaries

- User-confirmed decisions in docs/02_DECISIONS.md take precedence over earlier ideas and assistant proposals.
- Status vocabulary: **CONFIRMED**, **DIRECTION / LIKELY**, **UNDECIDED**, **PROPOSAL / EXAMPLE**, **REJECTED / CORRECTED**.
- Never silently promote an example number, weapon, NPC, class, dungeon, upgrade formula, video technique, or hypothetical feature into a requirement.
- We're building an **original game**, not a Valheim modification.
- Valheim is the survival/world foundation; Metin2 supplies RPG progression; New World mainly inspires a small profession overlay.
- **Milestone 0.01a (movement and camera) is completed and committed.** The director chose **building and living in a world as the first substantial gameplay loop** on 2026-11-14. The current `docs/BRIEF_01_SHELTER.md` is **approved by the director as the next scoped implementation brief, but has not yet been started**. Read `docs/13_WORLD_BUILDING_STRATEGY.md` for longer-term building/world/persistence/co-op sequencing, but implement **B01 only**. Begin with the required safe checkpoint/reconciliation of local uncommitted combat work. B01 prioritizes enjoyable shelter placement **using an actual modelled 3D wood building kit**, with temporary free materials before gathering. **Do not ship a cube/primitive-built house as the milestone; read `docs/14_BUILDING_KIT_B01.md` for the required prototype art shapes, model handoff and snapping rules.** The outdoor terrain may be grayboxed. The existing local 0.02a capsule+dummy combat code is an **uncommitted technical spike to preserve safely**, not a validated combat experience. Combat and RPG progression remain in the game.
- Classes affect combat identity, **not** the right to build, farm, mine, explore, or craft. Solo viability for every class is a requirement.
- Hard level restrictions for dungeons and mandatory support roles contradict the design.
- The specific DSS/FKS weapon is **one possible item among many**, not the cornerstone of item design. Ordinary sword bonuses must not be arbitrarily restricted to particular sword models.
- Party XP is intended to support different playstyles regardless of distance, with group-choice distribution; exact coefficients are undecided.
- Do not copy protected Metin2 or Valheim art, models, names, sound assets, maps, or code into the released original game. Descriptive reference names in design docs are placeholders.

## Technical working method

- Unity 6.6 / C# / URP, local Windows project reported: F:\Addiction²\Addiction².
- Prefer readable, testable, modular C# over prematurely complex frameworks.
- Where useful, expose controller tuning (movement speed, acceleration, jump, camera) for playtesting.
- Use Unity CLI / Pipeline for reproducible editor tasks when actually connected; CLI and Blender MCP capabilities must be checked per environment.
- Codex CLI and ChatGPT's Unity plugin installation are **not the same thing**. Do not assume local Codex plugin configuration without checking.
- Use existing Input System where appropriate; avoid unnecessary packages.
- Preserve Unity .meta files and scene references. Respect existing Unity .gitignore; never commit Library/, Temp/, Logs/, Build/, or machine-local secrets.
- Avoid destructive scene edits, force pushes, and sweeping refactors. Use small diffs and explain unexpected changes.
- Automated tests prove code behavior, not that action combat feels good. Ask for a human playtest only when there is something runnable.

## Stop conditions and efficient verification (required for every Codex task)

**Do not keep working after the requested implementation is done just because a human playtest is pending.** A pending human playtest is a legitimate stopping point, not a reason for repeated probing.

1. Define a **meaningful gameplay question** and a **complete playable scenario** before editing. A technical smoke test (e.g. HP goes from 100 to 80) is for the agent's automated verification, not an entire user-facing milestone. A small vertical slice may require multiple scripts and assets; keep it bounded but complete.
2. Implement the requested scope, then perform **one focused verification pass** (compile/import, targeted automated checks, inspect Console if accessible). A second focused attempt is acceptable only if it can resolve a specific actionable failure. Avoid repeatedly relaunching Unity or reattempting commands that already failed for the same reason.
3. **If Unity is already open, do not attempt batch mode on the same project**. Prefer the running Editor's Pipeline connection when available; if blocked, report that specific limitation once and stop.
4. **When a playable outcome is ready**, stop and report: what the player can now *do*, changed files, evidence from automated checks, one **meaningful gameplay experience to evaluate**, and exact Git status. **Do not issue repeated reminders, status-only follow-ups, or request the same checks in a loop.** If a necessary tool is blocked, report once with a specific obstacle and stop; never simulate waiting for the user.
5. Do not spend substantial extra time perfecting optional verifications, building elaborate overlays, or troubleshooting automation that does not answer the milestone's game-design question. Focus on observable player experience and technical correctness sufficient for the current slice.
6. Do not throw away local changes. **Preserve the current uncommitted combat spike safely before starting the next slice**, checking `git status` and maintaining the known unrelated `Assets/Editor` deletions. You may make local checkpoint commits when the user/task permits, but do not push or merge unreviewed gameplay work if the user explicitly requires a playtest first. Do not touch unrelated changes.
7. Be explicit about the **difference between code/build verified, Play Mode observed, and human-tested gameplay feel**; none implies the other.

## Working scale: a vertical slice, not a micro-ticket

- **Wrong unit:** one HP change, one input action, one overlay label, one report per technical check. Those are internal implementation details.
- **Right unit:** one short interaction the user can genuinely play and evaluate (for example, fight an approaching opponent with a visible attack, readable enemy strike, feedback, win/lose and immediate replay).
- Use simple placeholder assets, but introduce **basic rigged characters/attack animations early enough for actual combat-feel testing**; don't claim final feel based only on capsules.
- Build technical substeps independently, integrate them, run focused automated verification, and present a single playable result. Keep scope narrow enough to roll back; do not generate the entire game in one prompt.
- Debug UIs are developer tools, normally tucked away, not substitutes for actual player-facing behavior.
- If the user needs to evaluate **whether it is fun**, provide a meaningful encounter or building loop rather than asking for manual validation of simple math.

## Source-of-truth maintenance

- Keep the main documents coherent; do not treat chat messages as authoritative if the repository says otherwise.
- Add new findings as dated updates, distinguishing observation from decision.
- A deferred idea should remain discoverable in the notebook/backlog, even if not implemented now.
- If a new prompt conflicts with a confirmed choice, identify the conflict and use the newest explicit user instruction.
