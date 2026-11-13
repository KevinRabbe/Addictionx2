# Prototype plan: test the game before designing the whole game

**Current milestone:** **0.01a — movement/camera complete, human-playtested, and committed as `3feb669` on 2026-11-14. Next: 0.02a — first combat-feel experiment.** Advanced movement refinements (jumping, sprinting, traversal polish) are deferred unless needed to test fighting. This supersedes earlier plans to implement loot/blacksmith immediately.

## Principle

**One focused task → implement → compile/test → human playtest → adjust → commit.** Keep experiments reversible. Do not ask one AI prompt to create a complete survival RPG. Ugly is intentional: character capsules, primitive obstacles, flat lighting, placeholder names. Fun and reliable control are the test.

## 0.01a — First controllable character (COMPLETED)

### Scope

- Dedicated **Prototype_Movement** graybox scene (exact filename flexible); preserve existing SampleScene rather than destructively replacing it.
- Flat floor, a few ramps, steps, ledges and obstacles to test slopes/terrain and camera collision.
- Single placeholder controllable character, third-person follow/orbit camera.
- Camera-relative WASD walk/turn and a mouse-controlled third-person follow/orbit camera using the existing Input System actions.
- Exposed Inspector tuning for movement speed/turning and camera sensitivity/distance/follow smoothing.
- Jump, sprint, dodge, camera collision, and interaction remain follow-up experiments; they are not part of 0.01a.
- Use the existing Unity Input System when practical, with understandable defaults; later remapping/gamepad support undecided.
- No enemies, RPG levels, drops, multiplayer, blacksmith, building, dialogue, ships, procedural world or polished Blender assets in this milestone.

### Verification and playtest result

1. Unity 6000.6.9f1 compiled the project without compilation failures; Pipeline opened and ran the new scene with no console errors.
2. The human playtest reported that WASD movement and the third-person camera feel good.
3. The lowest step is traversable. The two higher steps are not; this is accepted for now and does not trigger a movement change.
4. Movement and camera tuning values are exposed in the Inspector. **AI does not certify game feel; the assessment above is the user's playtest result.**

### First Codex task suggestion (not a commitment to code details)

“Read AGENTS.md and the project docs. Implement only the first small part of Prototype 0.01 in a dedicated graybox scene: a capsule, basic third-person camera and configurable keyboard movement, using the existing Input System. Do not add combat, RPG or inventory systems. Use Unity CLI/Pipeline where available, compile/check errors, report tests, and leave a short playtest checklist. Avoid touching unrelated scenes.”

**Human feedback (2026-11-14):** The initial WASD movement and mouse orbit feel good. The low step is traversable; the two taller steps are not. Do not change the working movement merely to make high steps traversable. The user clarified that **fighting feel matters more than additional basic movement polish**; postpone standalone jump/sprint/debug-panel refinements until they are useful. This first vertical slice is committed as `3feb669` on `main`.

## Later experiments — order flexible, not a feature contract

**0.02 Combat feel — NEXT PRIORITY:** **important user clarification**: a capsule/primitive test can verify attack input, range, collision, damage events and basic effects, but **cannot fully validate how combat feels without a moving, animated 3D character model**. Begin with **0.02a: one basic attack against a stationary target** for mechanical correctness and crude feedback; then bring in **a simple rigged/animated 3D humanoid placeholder**, without waiting for a polished final model. Test anticipation, attack pose/arc, hit contact, recovery and impact with real animation. Preserve existing movement/camera. **0.02b:** give one simple enemy a readable attack so that we can test avoiding damage, combat spacing, timing and responsiveness; then explore dodge/block/parry where they help the fight. Adjust rigged-placeholder timing alongside this. Assess basic combat before advanced traversal. Test grounded weight against snappy responsiveness. No full class skills, stat framework or finished art yet. **A stationary dummy alone tests hit feel, not complete combat feel**; the interactive enemy follow-up is essential.

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
