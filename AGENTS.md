# Instructions for Codex / AI contributors — Addiction²

## Mandatory first steps in every new task/session

1. Read README.md, docs/01_VISION.md, docs/02_DECISIONS.md, and docs/04_PROTOTYPE.md.
2. Read the relevant sections of docs/03_DESIGN_NOTEBOOK.md and docs/05_DEVELOPMENT.md.
3. Inspect the current repository and Unity project state before editing. Do not guess what has already been implemented.
4. State the **one small task**, why it matters, and its acceptance test. Implement only that slice.
5. Verify by compiling/importing in Unity and running appropriate automated checks; report what could **not** be checked. The human decides whether movement/combat/visuals actually **feel good**.
6. Update docs/02_DECISIONS.md when a real decision is made, and docs/04_PROTOTYPE.md or docs/05_DEVELOPMENT.md when implementation or tooling state changes.
7. Preserve working changes and keep the project playable. Do not add unrelated systems.

## Design authority and boundaries

- User-confirmed decisions in docs/02_DECISIONS.md take precedence over earlier ideas and assistant proposals.
- Status vocabulary: **CONFIRMED**, **DIRECTION / LIKELY**, **UNDECIDED**, **PROPOSAL / EXAMPLE**, **REJECTED / CORRECTED**.
- Never silently promote an example number, weapon, NPC, class, dungeon, upgrade formula, video technique, or hypothetical feature into a requirement.
- We're building an **original game**, not a Valheim modification.
- Valheim is the survival/world foundation; Metin2 supplies RPG progression; New World mainly inspires a small profession overlay.
- The first milestone is **movement and camera only**. Do not sneak in character levels, item systems, combat, networking, polished models, or world generation.
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

## Source-of-truth maintenance

- Keep the main documents coherent; do not treat chat messages as authoritative if the repository says otherwise.
- Add new findings as dated updates, distinguishing observation from decision.
- A deferred idea should remain discoverable in the notebook/backlog, even if not implemented now.
- If a new prompt conflicts with a confirmed choice, identify the conflict and use the newest explicit user instruction.
