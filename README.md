# Addiction² — Valheim × Metin2-inspired original game

**Project stage:** Ugly prototype / pre-gameplay implementation  
**Engine:** Unity 6.6 (6000.6.9f1), Universal Render Pipeline, C#  
**Development style:** Director-led playable milestones, Codex implementation, focused automated verification  
**Design snapshot:** 2026-11-13

## What we are building

An **original single-player and small-group co-op survival action RPG**. Valheim-like freedom, exploration, survival, construction, farming, sailing, and a world worth living in are the **foundation**. Metin2-inspired classes, levels, equipment bonuses/enhancement, loot grinding, NPCs, quests, bosses, and repeatable dungeons are the **complementary missing piece**. A **small** New World-inspired gathering profession progression system sits on top.

The promise: spend two hours after work grinding toward a favorite weapon, or spend the evening building a home; both are legitimate. No competitive MMO obligations, artificial weekly pressure, or required party composition. Friends can play differently and still progress together.

This is **not** a Valheim mod and is **not** a plan to clone Metin2 or New World. It is its own game.

## Read these documents first

1. **[docs/01_VISION.md](docs/01_VISION.md)** — product identity, pillars, player experience, non-negotiable principles.
2. **[docs/02_DECISIONS.md](docs/02_DECISIONS.md)** — confirmed decisions versus candidates/open questions; corrections to earlier brainstorming. **Authoritative for design status.**
3. **[docs/03_DESIGN_NOTEBOOK.md](docs/03_DESIGN_NOTEBOOK.md)** — complete structured capture of systems, examples, alternatives, and tentative ideas discussed.
4. **[docs/04_PROTOTYPE.md](docs/04_PROTOTYPE.md)** — immediate prototype scope and experimental sequence.
5. **[docs/05_DEVELOPMENT.md](docs/05_DEVELOPMENT.md)** — verified Unity/Codex/GitHub setup and operating workflow.
6. **[docs/06_DISCUSSION_HISTORY.md](docs/06_DISCUSSION_HISTORY.md)** — chronological decision/correction history, so early mistakes do not come back as facts.
7. **[docs/07_REFERENCES_AND_BACKLOG.md](docs/07_REFERENCES_AND_BACKLOG.md)** — the two AI-development-video lessons and deferred inspirations.
8. **[docs/08_CONVERSATION_COVERAGE_AUDIT.md](docs/08_CONVERSATION_COVERAGE_AUDIT.md)** — item-by-item audit mapping the important original conversation decisions, corrections, and unanswered questions to repository documentation.
9. **[docs/09_ARCHITECTURE_GUARDRAILS.md](docs/09_ARCHITECTURE_GUARDRAILS.md)** — architecture risks, current preferences for persistence, stat/class/data layering, hybrid world generation and Valheim-like building.
10. **[docs/10_ROADMAP.md](docs/10_ROADMAP.md)** — proposed path from graybox prototype to a tiny playable game combining survival/building and combat/RPG progression.
11. **[docs/11_PLAYABLE_WORKFLOW.md](docs/11_PLAYABLE_WORKFLOW.md)** — revised gameplay-first workflow: meaningful playable outcomes, batched implementation, automated technical checks, and fewer manual handoffs.
12. **[docs/STATE.md](docs/STATE.md)** — CURRENT one-page milestone, user priority, local safety, and next loop; read first when doing development work.
13. **[docs/BRIEF_01_SHELTER.md](docs/BRIEF_01_SHELTER.md)** — candidate building-first Codex brief (not yet authorized to implement).
14. **[docs/12_STARTING_REGION.md](docs/12_STARTING_REGION.md)** — confirmed starting-town principles, two entry routes, the hill as a landscape boundary, building outside town and unresolved spatial design.
15. **[docs/13_WORLD_BUILDING_STRATEGY.md](docs/13_WORLD_BUILDING_STRATEGY.md)** — proposed sequence for playable building, terrain, persistence, early co-op checks and generated-world integration; **not an approved Codex task**.
16. **[AGENTS.md](AGENTS.md)** — operating instructions for Codex and future agents.

## Single source of truth

**The committed repository is canonical, not an AI chat's memory.** A future chat or agent must read the files above instead of assuming earlier conversational context. Proposals and numeric examples in the notebook are **not approved features**. The decision ledger overrides brainstorming when they disagree.

When a decision changes, update the decision ledger and the affected documentation **in the same change as implementation**. Preserve the previous reasoning in discussion history when important. If a user correction conflicts with an assistant idea, **the user's correction wins**.

## Current next milestone

**Director decision, 2026-11-14:** Build and live in the world FIRST. See **[STATE.md](docs/STATE.md)** and the first playable building brief **[BRIEF_01_SHELTER.md](docs/BRIEF_01_SHELTER.md)**. This changes the next development track; combat/RPG remains important and will return. Existing movement/camera is human-tested and committed as `3feb669`. The 0.02a capsule/dummy combat spike is reported as **local uncommitted work** and must be safely preserved before switching tracks. Some older roadmap/prototype sections still say combat is next; those descriptions record previous planning and do not override the newer user priority.

## Repository notes

The GitHub repository is **KevinRabbe/Addictionx2** (public as observed on 2026-11-14; check whether intentional). Local Windows Unity project path reported as **F:\Addiction²\Addiction²**. The local project and the remote need to be synchronized by Git; changes made on GitHub are not automatically present on disk.
