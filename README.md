# Addiction² — Valheim × Metin2-inspired original game

**Project stage:** Ugly prototype / pre-gameplay implementation  
**Engine:** Unity 6.6 (6000.6.9f1), Universal Render Pipeline, C#  
**Development style:** Codex-assisted, test-first small iterations  
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
9. **[AGENTS.md](AGENTS.md)** — operating instructions for Codex and future agents.

## Single source of truth

**The committed repository is canonical, not an AI chat's memory.** A future chat or agent must read the files above instead of assuming earlier conversational context. Proposals and numeric examples in the notebook are **not approved features**. The decision ledger overrides brainstorming when they disagree.

When a decision changes, update the decision ledger and the affected documentation **in the same change as implementation**. Preserve the previous reasoning in discussion history when important. If a user correction conflicts with an assistant idea, **the user's correction wins**.

## Current next milestone

**Prototype 0.01: movement, camera, and controls** in an ugly graybox test level. No combat, blacksmith, levels, inventory, quests, or elaborate assets yet. We will playtest movement feel first.

## Repository notes

The GitHub repository is **KevinRabbe/Addictionx2** (private at snapshot). Local Windows Unity project path reported as **F:\Addiction²\Addiction²**. The local project and the remote need to be synchronized by Git; changes made on GitHub are not automatically present on disk.
