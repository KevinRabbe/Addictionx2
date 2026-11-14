# Development workflow reset — build playable outcomes, not endless micro-tests

**Created 2026-11-14. Status: workflow proposal responding to an explicit user request for a fundamental change; evaluate and refine after the next real playable build.** Game design decisions in [02_DECISIONS.md](02_DECISIONS.md) remain unchanged.

## Why the previous method failed

- The original one-small-task-per-session rule became **one tiny technical mechanic per handoff**, not an enjoyable activity to play.
- Prototype 0.02a culminated in a capsule hitting a stationary dummy while a debug overlay displayed `HIT -20`. The user correctly asked what this reveals about Addiction²; **almost nothing about combat fun**.
- Codex repeatedly ran or retried verification commands and issued the same human-playtest requests while the actual implementation appeared finished. The user **had to manually stop it**. No exact wasted duration has been independently verified.
- AI optimization focused on process compliance, build output and status reports rather than reaching a useful player-facing result.
- The user wants a major change, not another small verification instruction appended to the same ineffective method.

## Fundamental switch: player-facing vertical slices

**Old unit of work:** a script, action, debug overlay, technical micro-feature or a checklist item.

**New unit of work:** a **short, complete playable interaction** that answers one important game-design question. It may involve several technical components internally; Codex should execute them without interrupting the user after each step.

**Sample first target:** From the already working third-person controller, the player can enter a tiny arena, use a visibly animated placeholder attack, face an enemy that approaches and telegraphs one attack, hit/be hit with understandable feedback, either win or lose, then restart instantly. The user can spend ~one minute playing and compare how responsiveness, timing, hit contact and enemy readability feel.

This example is **proposed scope**, not an approved final combat style, class system, parry/dodge system, weapon type or animation set. Use licensed prototype models/animations or a suitable crude custom placeholder if appropriate; don't spend weeks on art. A static capsule+HP overlay alone is not sufficient.

## The new milestone contract

Each implementation milestone should be specified in this order:

1. **What the player does:** one sentence describing the experience.
2. **Why this matters to Addiction²:** which core pillar or serious technical risk it addresses.
3. **What visibly happens:** entry condition, interactions, response, clear outcome, replay.
4. **Flexible implementation scope:** allow the agent to construct **all minimal connected parts** needed for that scenario. Avoid prescribing every class, filename or API without reason.
5. **Boundaries:** prevent premature full RPG systems, generic frameworks and new unrelated content.
6. **Verification:** Unity editor compiles; the scene runs; focused automated assertions for damage, state transitions and failure cases. The agent does **not** outsource trivial numerical correctness to the human.
7. **One human evaluation:** a short play scenario and **two or three meaningful feel questions**. Stop after reporting once.
8. **Source control:** keep baseline safe, protect unrelated changes, checkpoint code appropriately and commit/push reviewed milestone per task agreement.

## Execution modes

**Codex / tools:** implementation, scene setup, temporary animation/asset wiring, integration, automated correctness checks, and a concise report. Internally it may make multiple related changes to achieve the scenario.

**Player (user):** test whether the **activity** is fun or satisfying: how attacks move, whether enemy danger is clear, whether input is responsive, whether building snaps feel pleasant, whether there is a reason to repeat. Only do this after the end-to-end scenario is playable.

**ChatGPT / design repo:** translate user feedback into a new milestone or an actual design decision, without respecifying every mechanical substep.

**Do not:** wait in a tool loop for human feedback; retry the same broken Unity command repeatedly; ask a user to confirm mathematical health subtraction; require a separate consultation for each technical micro-feature; make long status reports after every line of code.

## Verification budget / stop rule

- When Unity Editor is open, use its running Pipeline; **do not launch batch mode into the same open project**.
- Run one consolidated compile/Play Mode/console verification and focused targeted automatic checks. Retry only after a distinct fix or when evidence suggests the retry can succeed.
- When the scene is runnable, report the result and stop. If the editor or tool is blocked, report once, preserving the files. Do not continue probing indefinitely.
- Treat a debugger panel as optional developer instrumentation, not the playable deliverable.

## Next practical steps and local safety

**A. Safely preserve the existing combat spike.** As reported by Codex, `Prototype_Combat` and its scripts are still **local and uncommitted**; three older unrelated `Assets/Editor` deletions exist. Before replacing or extending this work, inspect local `git status`, keep its source and scene, and protect other changes. Avoid a blind `git pull` that overwrites locally modified docs. The current prototype may be valuable infrastructure even though it is not fun yet.

**B. Replace Issue #2 as the *player-experience* target.** Issue #2 currently specifies a capsule/dummy technical spike. It must not be treated as a completed gameplay milestone. A future combat milestone should cover a **complete short encounter with an animated attack, a responsive opponent, feedback and reset**. Decide its exact size based on local asset/code state, not by copying the reference video.

**C. Give building similarly meaningful early treatment.** A later vertical slice is **gather a resource → place/rotate/snap enough parts to make a tiny shelter → see a useful result**. Valheim-like building is a foundation, not a decorative cube placement demo.

**D. Integrate successful experiences.** The broader roadmap toward authored starting town + generated world, progression/loot/blacksmith, persistent world and co-op remains a **proposed sequence**. Evaluate source-of-truth requirements before implementing major architecture.

## How to judge whether this reset works

After the next implementation, ask:
- Could the player do something worth playing and judging beyond seeing a number change?
- Did the AI complete several necessary internal steps without repeatedly handing them back?
- Was the local project left playable and safely versioned?
- Did the agent stop after a concise verification report without requiring manual termination?

If the answer is no, change the workflow again. Do not make workflow compliance itself the objective.
