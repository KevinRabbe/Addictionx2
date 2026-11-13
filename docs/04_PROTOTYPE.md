# Prototype plan: test the game before designing the whole game

**Current milestone:** **0.01a — basic movement/camera playtested and reported to feel good; review/commit the slice first. Then prioritize 0.02a — first combat-feel experiment.** Advanced movement refinements (jumping, sprinting, traversal polish) are deferred unless needed to test fighting. This supersedes earlier plans to implement loot/blacksmith immediately.

## Principle

**One focused task → implement → compile/test → human playtest → adjust → commit.** Keep experiments reversible. Do not ask one AI prompt to create a complete survival RPG. Ugly is intentional: character capsules, primitive obstacles, flat lighting, placeholder names. Fun and reliable control are the test.

## 0.01 — First controllable character (NOW)

### Scope

- Dedicated **Prototype_Movement** graybox scene (exact filename flexible); preserve existing SampleScene rather than destructively replacing it.
- Flat floor, a few ramps, steps, ledges and obstacles to test slopes/terrain and camera collision.
- Single placeholder controllable character, third-person follow/orbit camera.
- Functional walk/turn, camera-relative input if it feels right, jump; test sprint/run and dodge in **small separate tasks** rather than making every control a fixed commitment on day one.
- Exposed tuning parameters (inspector and/or later in-game debug panel) for movement speed, acceleration/deceleration, turning, air movement, jump, camera distance/smoothing, sprint and dodge if present.
- Use the existing Unity Input System when practical, with understandable defaults; later remapping/gamepad support undecided.
- No enemies, RPG levels, drops, multiplayer, blacksmith, building, dialogue, ships, procedural world or polished Blender assets in this milestone.

### Acceptance tests

1. Project imports and compiles in Unity 6.6 with no new errors.
2. Starting the movement scene permits input-controlled navigation.
3. Camera follows/orbits, does not spontaneously snap/clip through obstacles in normal test cases.
4. Character reliably stays on floor, climbs reasonable steps/slopes and jumps/lands; no obvious jitter or input-stuck states.
5. Adjustable values produce observable differences without code rewrites.
6. Tester can identify what feels responsive/weighty/awkward and record iteration notes. **AI cannot certify game feel from compilation.**

### First Codex task suggestion (not a commitment to code details)

“Read AGENTS.md and the project docs. Implement only the first small part of Prototype 0.01 in a dedicated graybox scene: a capsule, basic third-person camera and configurable keyboard movement, using the existing Input System. Do not add combat, RPG or inventory systems. Use Unity CLI/Pipeline where available, compile/check errors, report tests, and leave a short playtest checklist. Avoid touching unrelated scenes.”

**Human feedback:** The initial WASD movement and mouse orbit feel good. Low step is traversable; two taller steps are not. Do not change the working movement merely to make high steps traversable. The user clarified that **fighting feel matters more than additional basic movement polish**; postpone standalone jump/sprint/debug-panel refinements until they are useful. Preserve and commit this first vertical slice before implementing combat.

## Later experiments — order flexible, not a feature contract

**0.02 Combat feel — NEXT PRIORITY:** begin with **0.02a: one basic attack against a stationary target**, readable range/timing, clear damage/hit feedback, and adjustable parameters. Preserve existing movement/camera. **0.02b:** give one simple enemy a readable attack so that we can test avoiding damage, combat spacing, timing and responsiveness; then explore dodge/block/parry where they help the fight. Assess basic combat before advanced traversal. Test grounded weight against snappy responsiveness. No full class skills, stat framework or finished art yet. **A stationary dummy alone tests hit feel, not complete combat feel**; the interactive enemy follow-up is essential.

**0.03 Combat identity and enemies:** test class skill vs weapon skill vs hybrid with minimal stand-ins. Compare a couple distinctive foes against larger farmable packs; experiment with support synergies.

**0.04 Character/equipment prototype:** very small number of data-driven items, XP and levels, loot, basic blacksmith interaction, enhancement, one optional special DSS/FKS weapon. Only now is an item loop appropriate. Confirm stat/bonus ownership rather than implementing the speculative notebook as production data.

**0.05 Survival connection:** tree/rock gathering, a few building parts, a tiny own-base area, and test whether gathering/building and combat progression reinforce each other. **Follow-up building-specific experiment:** Valheim-like snapping, construction feel, structural rules and persistence — important to the game identity, not just a decorative placing mechanic.

**Later:** small authored-town-in-generated-wilderness spike; simple starting-town NPC interactions, quest/dungeon prototype, multiplayer party XP/guild and networking after core movement/combat systems prove interesting. Co-op is foundational to the final game, so early architecture should avoid needlessly blocking future multiplayer.

## Test questions we care about

- Is merely traversing our small world satisfying?
- Does combat remain fun against stronger enemies even when you're underleveled?
- Can farmable packs be enjoyable without becoming mindless?
- Does a rare weapon drop feel special, without making ordinary gear worthless?
- Do upgrades and switching create desirable optional goals?
- Is returning to your own base pleasant rather than a disruption?
- Can two friends with different preferences contribute meaningfully, including via configurable party XP?

## Don't optimize for screenshot appeal

A visual polish pass may come later, guided by visual references and a consistent art direction. No procedural snow simulation, village dressing, elaborate Blender meshes, deep RPG architecture or multiplayer backend just to make the first clip impressive.

## How to log an experiment

Record: date; hypothesis; minimal implementation; how verified; human playtest observation; confirmed decision/change; next single experiment. Update docs/02_DECISIONS.md only when a genuine decision is made.
